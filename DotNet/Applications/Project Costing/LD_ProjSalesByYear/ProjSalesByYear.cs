using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProjSalesByYear
{
    public partial class ProjSalesByYear : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private ProjectTypes.ProjectType ptType = ProjectTypes.ProjectType.PC_Land_Construction;
        private LD_ExcelRptSearchPanel.ExcelRptSearchPanel ucExcelRptSearchPnl;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConnection
        {
            get { return ReflexCon; }
            set { ReflexCon = value; }
        }

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        #endregion Properties

        public ProjSalesByYear(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, ProjectTypes.ProjectType pProjType)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            ptType = pProjType;

            ucExcelRptSearchPnl = new LD_ExcelRptSearchPanel.ExcelRptSearchPanel(ReflexCon, dxStyle, LD_ExcelRptSearchPanel.SearchType.NoLevels, ptType, LD_ExcelRptSearchPanel.YearSelectionType.IncludeYears);
            ucExcelRptSearchPnl.SearchClick += new LD_ExcelRptSearchPanel.ExcelRptSearchPanel.DelegateSearchClick(ucExcelRptSearchPnl_SearchClick);
            ucExcelRptSearchPnl.Dock = DockStyle.Fill;
            ucExcelRptSearchPnl.Parent = dpSearch;

            //Connection Set
            sqlTR.ConnectionString = ReflexCon.TRConnection;

            SetupGLSegsWhse();
        }

        private void SetupGLSegsWhse()
        {
            string sClearReq = "F", sPC_Req = "F", sClearColumnDesc = "Division", sPCColumnDesc = "Profit Center", sSecurity = "";
            int iClearSeg = 0, iPCSeg = 0, iWhseCount = 0;

            using (SqlConnection sqlCon = new SqlConnection(ReflexCon.TRConnection))
            {
                SqlCommand sqlCmd = new SqlCommand("exec sp_Proj_GLSwapSegs_WhseCount '" + ReflexCon.MLUser + "' ", sqlCon);
                sqlCon.Open();
                using (SqlDataReader dr = sqlCmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            if (dr["Clear_Req"] != DBNull.Value && dr["Clear_Req"] != null)
                                sClearReq = dr["Clear_Req"].ToString();
                            if (dr["Clear_Seg"] != DBNull.Value && dr["Clear_Seg"] != null)
                                iClearSeg = Convert.ToInt32(dr["Clear_Seg"]);
                            if (dr["Seg_Name"] != DBNull.Value && dr["Seg_Name"] != null)
                                sClearColumnDesc = dr["Seg_Name"].ToString();
                            if (dr["PC_Req"] != DBNull.Value && dr["PC_Req"] != null)
                                sPC_Req = dr["PC_Req"].ToString();
                            if (dr["Profit_Center_Seg"] != DBNull.Value && dr["Profit_Center_Seg"] != null)
                                iPCSeg = Convert.ToInt32(dr["Profit_Center_Seg"]);
                            if (dr["PC_Name"] != DBNull.Value && dr["PC_Name"] != null)
                                sPCColumnDesc = dr["PC_Name"].ToString();
                            if (dr["Warehouses"] != DBNull.Value && dr["Warehouses"] != null)
                                iWhseCount = Convert.ToInt32(dr["Warehouses"]);
                        }
                    }

                    dr.Close();
                }
                sqlCon.Close();
            }

            if (iClearSeg <= 0)
                iClearSeg = 2; //Default Division

            //Division
            if (iClearSeg > 0)
            {
                fieldDivision.Caption = sClearColumnDesc;
            }
            else
            {
                fieldDivision.Visible = false;
                fieldDivision.Options.ShowInCustomizationForm = false;
            }

            //Reset Security String
            if (sSecurity != "") sSecurity = "";

            //Profit Center
            if (sPC_Req.ToUpper() == "T" && iPCSeg > 0)
            {
                fieldProfitCenter.Caption = sPCColumnDesc;
            }
            else
            {
                fieldProfitCenter.Visible = false;
                fieldProfitCenter.Options.ShowInCustomizationForm = false;
            }
        }

        private void ProjSalesByYear_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        private string GetProjTypeStr()
        {
            string sProjType = "PLC";

            switch (ptType)
            {
                case ProjectTypes.ProjectType.PC_Land_Construction:
                    sProjType = "PLC";
                    break;
                case ProjectTypes.ProjectType.PC_General_Construction:
                    sProjType = "PGC";
                    break;
            }

            return sProjType;
        }

        private void ucExcelRptSearchPnl_SearchClick(bool EmptySearch)
        {
            int iToYear = 0, iFromYear = 0;

            try { iToYear = Convert.ToInt32(ucExcelRptSearchPnl.ToYear); }
            catch { }
            try { iFromYear = Convert.ToInt32(ucExcelRptSearchPnl.FromYear); }
            catch { }

            if (iToYear == 0 || iFromYear == 0)
            {
                frmMessageBox.ShowPopup("Year selection is required.");
                ucExcelRptSearchPnl.SetRequiredControlColor("ToYear");
                ucExcelRptSearchPnl.SetRequiredControlColor("FromYear");
                return;
            }
            else if (iToYear < iFromYear)
            {
                frmMessageBox.ShowPopup("From year cannot come after to year.");
                ucExcelRptSearchPnl.SetRequiredControlColor("ToYear");
                ucExcelRptSearchPnl.SetRequiredControlColor("FromYear");
                return;
            }

            if (EmptySearch)
            {
                if (frmMessageBox.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.Cancel)
                    return;
            }

            dsProjSalesByYear1.Clear();

            try
            {
                daProjSalesByYear.SelectCommand.Parameters["@pri_type"].Value = GetProjTypeStr();
                daProjSalesByYear.SelectCommand.Parameters["@GeographicArea_ID"].Value = (ucExcelRptSearchPnl.GeographicArea == null ? DBNull.Value : ucExcelRptSearchPnl.GeographicArea);
                daProjSalesByYear.SelectCommand.Parameters["@Regions_ID"].Value = (ucExcelRptSearchPnl.Regions == null ? DBNull.Value : ucExcelRptSearchPnl.Regions);
                daProjSalesByYear.SelectCommand.Parameters["@Municipality_ID"].Value = (ucExcelRptSearchPnl.Municipality == null ? DBNull.Value : ucExcelRptSearchPnl.Municipality);
                daProjSalesByYear.SelectCommand.Parameters["@Communities_ID"].Value = (ucExcelRptSearchPnl.Community == null ? DBNull.Value : ucExcelRptSearchPnl.Community);
                daProjSalesByYear.SelectCommand.Parameters["@pri_id"].Value = (ucExcelRptSearchPnl.Project == null ? DBNull.Value : ucExcelRptSearchPnl.Project);
                daProjSalesByYear.SelectCommand.Parameters["@proj_manager_ID"].Value = (ucExcelRptSearchPnl.ProjectManager == null ? DBNull.Value : ucExcelRptSearchPnl.ProjectManager);
                daProjSalesByYear.SelectCommand.Parameters["@CatCode"].Value = (ucExcelRptSearchPnl.ProjectCategory == null ? DBNull.Value : ucExcelRptSearchPnl.ProjectCategory);
                daProjSalesByYear.SelectCommand.Parameters["@ClassCode"].Value = (ucExcelRptSearchPnl.ProjectClass == null ? DBNull.Value : ucExcelRptSearchPnl.ProjectClass);
                daProjSalesByYear.SelectCommand.Parameters["@ProjStatus"].Value = (ucExcelRptSearchPnl.ProjectStatus == null ? DBNull.Value : ucExcelRptSearchPnl.ProjectStatus);
                daProjSalesByYear.SelectCommand.Parameters["@Division"].Value = (ucExcelRptSearchPnl.Division == null ? DBNull.Value : ucExcelRptSearchPnl.Division);
                daProjSalesByYear.SelectCommand.Parameters["@ProfitCenter"].Value = (ucExcelRptSearchPnl.ProfitCenter == null ? DBNull.Value : ucExcelRptSearchPnl.ProfitCenter);
                daProjSalesByYear.SelectCommand.Parameters["@FromYear"].Value = (ucExcelRptSearchPnl.FromYear == null ? DBNull.Value : ucExcelRptSearchPnl.FromYear);
                daProjSalesByYear.SelectCommand.Parameters["@ToYear"].Value = (ucExcelRptSearchPnl.ToYear == null ? DBNull.Value : ucExcelRptSearchPnl.ToYear);

                daProjSalesByYear.Fill(dsProjSalesByYear1);
            }
            catch (Exception ex)
            {
                frmMessageBox.ShowPopup("Unable to load project information: " + ex.Message);
            }

        }

        private void pivotGridControl1_CustomSummary(object sender, DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs e)
        {
            if (e.DataField == fieldPerFrontage)
            {
                decimal dTotal = 0, dTotalFrontage = 0;
                int iPriCode = 0, iPrePriCode = -1,iSelectedYear = -1,iPreSelectedYear = -1;
                DevExpress.XtraPivotGrid.PivotDrillDownDataSource FilteredData = e.CreateDrillDownDataSource();

                for (int index = 0; index < FilteredData.RowCount; index++)
                {
                    DevExpress.XtraPivotGrid.PivotDrillDownDataRow row = FilteredData[index];
                    try { dTotal += (decimal)row[fieldSales]; }
                    catch { }

                    try { iPriCode = (int)row[fieldProjCode]; }
                    catch { }
                    try { iSelectedYear = (int)row[fieldSelectedYear]; }
                    catch { }
                   
                    if (iPriCode != iPrePriCode || ( iPriCode == iPrePriCode && iSelectedYear != iPreSelectedYear))
                    {
                        iPreSelectedYear = iSelectedYear;
                        iPrePriCode = iPriCode;
                        if (row[fieldTotalFrontage] != DBNull.Value)
                        {
                            try { dTotalFrontage += (decimal)row[fieldTotalFrontage]; }
                            catch { }
                        }
                    }
                }

                
                if (dTotalFrontage > 0)
                    e.CustomValue = dTotal / dTotalFrontage;
                else
                    e.CustomValue = 0.00;
            }
            else if (e.DataField == fieldPerAcres)
            {
                decimal dTotal = 0, dTotalAcres = 0;
                int iPriCode = 0, iPrePriCode = -1, iSelectedYear = -1, iPreSelectedYear = -1; 
                DevExpress.XtraPivotGrid.PivotDrillDownDataSource FilteredData = e.CreateDrillDownDataSource();

                for (int index = 0; index < FilteredData.RowCount; index++)
                {
                    DevExpress.XtraPivotGrid.PivotDrillDownDataRow row = FilteredData[index];
                    try { dTotal += (decimal)row[fieldSales]; }
                    catch { }

                    try { iPriCode = (int)row[fieldProjCode]; }
                    catch { }

                    try { iSelectedYear = (int)row[fieldSelectedYear]; }
                    catch { }


                    if (iPriCode != iPrePriCode || (iPriCode == iPrePriCode && iSelectedYear != iPreSelectedYear))
                    {
                        iPreSelectedYear = iSelectedYear;
                        iPrePriCode = iPriCode;
                        if (row[fieldTotalFrontage] != DBNull.Value)
                        {
                            try { dTotalAcres += (decimal)row[fieldTotalAcres]; }
                            catch { }
                        }
                    }
                }

                if (dTotalAcres > 0)
                    e.CustomValue = dTotal / dTotalAcres;
                else
                    e.CustomValue = 0.00;
            }
        }
    }
}
