using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandCostUpdate
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private int _GLYear = -1;
        private int _GLPeriod = -1;
        private Subledger_Preview.ucSubledger_Preview SubledgerPreview;

        public delegate void DelegatePrintPreRegisterClick();
        public event DelegatePrintPreRegisterClick PrintPreRegisterClick;

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            LoadLevels();

            SubledgerPreview = new Subledger_Preview.ucSubledger_Preview(con, tuc_mgr, Subledger_Preview.ucSubledger_Preview.Flavor.LD_CostTransfer);
            SubledgerPreview.Dock = DockStyle.Fill;
            SubledgerPreview.Parent = dpSubledgerPreview;

        }

        private void LoadLevels()
        {
            string sql = "select lv1_land_desc,isnull(lv1_active_land,'F')[lv1_active_land],lv2_land_desc,isnull(lv2_active_land,'F')[lv2_active_land],lv3_land_desc,isnull(lv3_active_land,'F')[lv3_active_land],lv4_land_desc,isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl";

            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading level information:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["lv1_active_land"].ToString() == "T")
                    {
                        colDev_lvl1ID.Caption = "Project " + dt.Rows[0]["lv1_land_desc"].ToString();
                        colDev_lvl1ID_Desc.Caption = "Project " + dt.Rows[0]["lv1_land_desc"].ToString() + " Description";
                        
                    }
                    else
                    {
                        colDev_lvl1ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl1ID.Visible = false;
                        colDev_lvl1ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl1ID_Desc.Visible = false;
                        
                    }
                    if (dt.Rows[0]["lv2_active_land"].ToString() == "T")
                    {
                        colDev_lvl2ID.Caption = "Project " + dt.Rows[0]["lv2_land_desc"].ToString();
                        colDev_lvl2ID_Desc.Caption = "Project " + dt.Rows[0]["lv2_land_desc"].ToString()+" Description";
                    }
                    else
                    {
                        colDev_lvl2ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl2ID.Visible = false;
                        colDev_lvl2ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl2ID_Desc.Visible = false;
                    }
                    if (dt.Rows[0]["lv3_active_land"].ToString() == "T")
                    {
                        colDev_lvl3ID.Caption = "Project " + dt.Rows[0]["lv3_land_desc"].ToString();
                        colDev_lvl3ID_Desc.Caption = "Project " + dt.Rows[0]["lv3_land_desc"].ToString() + " Description";
                    }
                    else
                    {
                        colDev_lvl3ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl3ID.Visible = false;
                        colDev_lvl3ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl3ID_Desc.Visible = false;
                    }
                    if (dt.Rows[0]["lv4_active_land"].ToString() == "T")
                    {
                        colDev_lvl4ID.Caption = "Project " + dt.Rows[0]["lv4_land_desc"].ToString();
                        colDev_lvl4ID_Desc.Caption = "Project " + dt.Rows[0]["lv4_land_desc"].ToString() + " Description";
                    }
                    else
                    {
                        colDev_lvl4ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl4ID.Visible = false;
                        colDev_lvl4ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl4ID_Desc.Visible = false;
                    }

                }
            }



        }



        public void RefreshSummary(int GLYear,int GLPeriod)
        {
            _GLPeriod = GLPeriod;
            _GLYear = GLYear;
            btnRegister.Text = "Print Pre-Register";
            RefreshDatasets();
            con.SQLExecutor.ExecuteNonQuery("LD_CostTransfer_SummaryFill '"+con.MLUser+"'", con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading summary:" + con.SQLExecutor.Exception.Message);
            daSummary.SelectCommand.Parameters["@username"].Value = con.MLUser;

            dsSummary1.Clear();
            daSummary.Fill(dsSummary1);

            SubledgerPreview.Year = GLYear;
            SubledgerPreview.Period = GLPeriod;
            SubledgerPreview.LoadPreview();

        }

        private void RefreshDatasets()
        {
            ds_ALL_Levels1.Clear();
            if (colDev_lvl1ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level1.SelectCommand.Parameters["@pri_id"].Value = -1;
                da_Level1.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl2ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level2.SelectCommand.Parameters["@pri_id"].Value = -1;
                da_Level2.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl3ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level3.SelectCommand.Parameters["@pri_id"].Value = -1;
                da_Level3.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl4ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level4.SelectCommand.Parameters["@pri_id"].Value = -1;
                da_Level4.Fill(ds_ALL_Levels1);
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] saParam = new string[2, 4];
                saParam[0, 0] = "@username";
                saParam[1, 0] = con.MLUser;
                saParam[0, 1] = "@PreReg";
                saParam[1, 1] = (btnRegister.Text == "Print Pre-Register"?"T":"F");
                saParam[0, 2] = "@GLYear";
                saParam[1, 2] = _GLYear.ToString();
                saParam[0, 3] = "@GLPeriod";
                saParam[1, 3] = _GLPeriod.ToString();

                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(con, tuc_mgr, saParam, "LD_CostTransferRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    if (PrintPreRegisterClick != null)
                        PrintPreRegisterClick();
                    

                }
            }
            catch (Exception ex)
            {
                pop.ShowPopup(ex.Message);
            }
        }


        public bool Finish()
        {
            bool bResult = false;
            if (pop.ShowPopup(this, "Are you sure you want to post to  " + PeriodName(_GLPeriod) +
                    " " + _GLYear.ToString() + " (Period " + _GLPeriod.ToString() + ") ?", WS_Popups.frmPopup.PopupType.OK_Cancel)
                    == WS_Popups.frmPopup.PopupResult.OK)
            {

                try
                {
                    if (SubledgerPreview.ErrorMessage.Trim() == "")
                    {
                        SubledgerPreview.ProcessSelection();
                        bResult = true;
                        btnRegister.Text = "Print Register";
                        if (SubledgerPreview.ErrorMessage.Trim() == "")
                            pop.ShowPopup("Update Complete.");
                   }
                }
                catch
                {
                    bResult = false;
                }
            }

            return bResult;
            
        }

        private string PeriodName(int period)
        {
            string PeriodName = "";
            string sSelect = "select top 1 datename( M, end_date) from gl_periods where period = " + period;
            object oPeriod = con.SQLExecutor.ExecuteScalar(sSelect, con.TRConnection);
            if (oPeriod != null && oPeriod != DBNull.Value)
            {
                PeriodName = oPeriod.ToString();
            }
            return PeriodName;
        }
    }
}
