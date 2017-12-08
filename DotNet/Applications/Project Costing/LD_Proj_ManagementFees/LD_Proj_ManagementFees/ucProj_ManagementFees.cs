using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Proj_ManagementFees
{
    public partial class ucProj_ManagementFees : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private Supplier_Lookup_Rep.Repository_Supplier_Lookup SupplierLookup;
        private bool bViewMode = false;
        private bool bReadOnly = false;
        private ReflexConnection.Extended ReflexConExt;
        private int iPri_ID = -1;
        private bool bCustomMessage = false;
        private TUC_GridG.GridG ggManagementFees;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConn
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

        public ucProj_ManagementFees(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            ReflexConExt = new ReflexConnection.Extended(ReflexCon);
            

            sqlTR.ConnectionString = ReflexCon.TRConnection;
    
            SetupLevels();

            SupplierLookup = new Supplier_Lookup_Rep.Repository_Supplier_Lookup();
            SupplierLookup.HMConnection = ReflexCon;
            SupplierLookup.DevXMgr = dxStyle;
            SupplierLookup.ValueMember = "SUPPLIER_ID"; //Needed ID not code.
            colSupplier_ID.ColumnEdit = SupplierLookup;

            ggManagementFees = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvManagementFees, daManagementFees, dsManagementFees1);
            ggManagementFees.AllowTabCreateNewRecord = true;
            ggManagementFees.AskBeforeDelete = false;
            ggManagementFees.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggManagementFees_AllowDelete);
        }

        private void SetupLevels()
        {
            string sql = "select  isnull(lv1_land_desc,'')[lv1_land_desc] , isnull(lv2_land_desc,'')[lv2_land_desc] , isnull(lv3_land_desc,'')[lv3_land_desc] , isnull(lv4_land_desc,'')[lv4_land_desc] ," +
                "isnull(lv1_active_land,'F')[lv1_active_land] , isnull(lv2_active_land,'F')[lv2_active_land] , isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl ";

            DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                if (frmMessageBox != null)
                    frmMessageBox.ShowPopup("Error loading costing reference setup:" + ReflexCon.SQLExecutor.Exception.Message);
                else
                    MessageBox.Show("Error loading costing reference setup:" + ReflexCon.SQLExecutor.Exception.Message);
            }
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    SetCostingReferenceColumns(dt.Rows[0]);
                }
            }
            if (ReflexCon.CountryCode == "C")
            {
                colGST.Caption = "GST";
                colPST.Caption = "PST";
            }
            else if (ReflexCon.CountryCode == "U")
            {
                colGST.Caption = "Tax 1";
                colPST.Caption = "Tax 2";
            }
        }

        private void SetCostingReferenceColumns(DataRow row)
        {
            colLv1ID.Caption = row["lv1_land_desc"].ToString();
            colLv2ID.Caption = row["lv2_land_desc"].ToString();
            colLv3ID.Caption = row["lv3_land_desc"].ToString();
            colLv4ID.Caption = row["lv4_land_desc"].ToString();

            colLv1ID.OptionsColumn.ShowInCustomizationForm = colLv1ID.Visible = (row["lv1_active_land"].ToString() == "T");
            colLv2ID.OptionsColumn.ShowInCustomizationForm = colLv2ID.Visible = (row["lv2_active_land"].ToString() == "T");
            colLv3ID.OptionsColumn.ShowInCustomizationForm = colLv3ID.Visible = (row["lv3_active_land"].ToString() == "T");
            colLv4ID.OptionsColumn.ShowInCustomizationForm = colLv4ID.Visible = (row["lv4_active_land"].ToString() == "T");

        }

        private void ucProj_ManagementFees_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        public void LoadManagementFees(int Pri_id, bool ViewMode)
        {
            bViewMode = ViewMode;
            iPri_ID = Pri_id;

            if (bViewMode)
                bReadOnly = true;

            SetReadOnly();

            RefreshManagementFees();
        }

        private void SetReadOnly()
        {
            btnLoadAll.Enabled = !bReadOnly;
            ggManagementFees.Event_ProcessGridKey_Enabled = !bReadOnly;
            gcManagementFees.EmbeddedNavigator.Buttons.Append.Visible = !bReadOnly;
            gcManagementFees.EmbeddedNavigator.Buttons.CancelEdit.Visible = !bReadOnly;
            gcManagementFees.EmbeddedNavigator.Buttons.Edit.Visible = !bReadOnly;
            gcManagementFees.EmbeddedNavigator.Buttons.EndEdit.Visible = !bReadOnly;
            gcManagementFees.EmbeddedNavigator.Buttons.Remove.Visible = !bReadOnly;
            gvManagementFees.OptionsBehavior.Editable = !bReadOnly;
        }

        private void RefreshManagementFees()
        {
            daLevel1Codes.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daLevel2Codes.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daLevel3Codes.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daLevel4Codes.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            dsMgmtFeeList1.Clear();
            daMgmtFeeList.Fill(dsMgmtFeeList1);
            dsOffSetDate1.Clear();
            daOffSetDate.Fill(dsOffSetDate1);
            dsLevel1Codes1.Clear();
            daLevel1Codes.Fill(dsLevel1Codes1);
            dsLevel2Codes1.Clear();
            daLevel2Codes.Fill(dsLevel2Codes1);
            dsLevel3Codes1.Clear();
            daLevel3Codes.Fill(dsLevel3Codes1);
            dsLevel4Codes1.Clear();
            daLevel4Codes.Fill(dsLevel4Codes1);

            dsManagementFees1.Clear();
            daManagementFees.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daManagementFees.Fill(dsManagementFees1);
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlParameter[] saParams = new System.Data.SqlClient.SqlParameter[1];

            saParams[0] = new System.Data.SqlClient.SqlParameter("@pri_id", iPri_ID);

            ReflexConExt.ExecuteNonQueryProc("LD_Proj_LoadManagementFees", ReflexCon.TRConnection, saParams);
            if (ReflexConExt.Exception != null)
                frmMessageBox.ShowPopup("Unable to load all management fees: " + ReflexConExt.Exception.Message);

            RefreshManagementFees();
        }

        private void rilueLevel2_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit)
            {
                int iLevel1ID = -1;
                try { iLevel1ID = Convert.ToInt32(gvManagementFees.GetFocusedDataRow()["lv1id"]); }
                catch { }

                level2CodesFilteredBindingSource.Filter = "lv1ID = " + iLevel1ID.ToString();

                ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = level2CodesFilteredBindingSource;
            }
        }

        private void rilueLevel3_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit)
            {
                int iLevel2ID = -1;
                try { iLevel2ID = Convert.ToInt32(gvManagementFees.GetFocusedDataRow()["lv2id"]); }
                catch { }

                level3CodesFilteredBindingSource.Filter = "lv2ID = " + iLevel2ID.ToString();

                ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = level3CodesFilteredBindingSource;
            }
        }

        private void rilueLevel4_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit)
            {
                int iLevel3ID = -1;
                try { iLevel3ID = Convert.ToInt32(gvManagementFees.GetFocusedDataRow()["lv3id"]); }
                catch { }

                level4CodesFilteredBindingSource.Filter = "lv3ID = " + iLevel3ID.ToString();

                ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = level4CodesFilteredBindingSource;
            }
        }

        private void gvManagementFees_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvManagementFees.GetDataRow(e.RowHandle)["Pri_ID"] = iPri_ID;
            gvManagementFees.GetDataRow(e.RowHandle)["GST"] = false;
            gvManagementFees.GetDataRow(e.RowHandle)["PST"] = false;
            gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"] = 0;
            gvManagementFees.GetDataRow(e.RowHandle)["Percentage"] = 0;
            gvManagementFees.GetDataRow(e.RowHandle)["Amount"] = 0.00;
        }

        private void gvManagementFees_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colDescription)
            {
                int iMgmtFeeID = -1;
                try { iMgmtFeeID = Convert.ToInt32(e.Value); }
                catch { }

                DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter("Select mf.OffSetDays, mf.OffSetDate, mf.Percentage, mf.Amount, mf.Lv1ID, " + 
                    " mf.Lv2ID, mf.Lv3ID, mf.Lv4ID,mf.GST, mf.Supplier_ID, mf.PST From LD_ManagementFees mf where ID = " + iMgmtFeeID.ToString(), ReflexCon.TRConnection);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"] = dt.Rows[0]["OffSetDays"];
                        gvManagementFees.GetDataRow(e.RowHandle)["OffSetDate"] = dt.Rows[0]["OffSetDate"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Percentage"] = dt.Rows[0]["Percentage"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Amount"] = dt.Rows[0]["Amount"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Lv1ID"] = dt.Rows[0]["Lv1ID"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Lv2ID"] = dt.Rows[0]["Lv2ID"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Lv3ID"] = dt.Rows[0]["Lv3ID"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Lv4ID"] = dt.Rows[0]["Lv4ID"];
                        gvManagementFees.GetDataRow(e.RowHandle)["GST"] = dt.Rows[0]["GST"];
                        gvManagementFees.GetDataRow(e.RowHandle)["PST"] = dt.Rows[0]["PST"];
                        gvManagementFees.GetDataRow(e.RowHandle)["Supplier_ID"] = dt.Rows[0]["Supplier_ID"];
                    }
                }
            }
        }

        private void gvManagementFees_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvManagementFees.GetDataRow(e.RowHandle) != null && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle &&
                e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (gvManagementFees.GetDataRow(e.RowHandle)["ManagementFee_ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["ManagementFee_ID"] == null)
                {
                    e.ErrorText = "Fee Description is required.";
                    e.Valid = false;
                }

                if (e.Valid && gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"] != DBNull.Value && gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"] != null)
                {
                    int iDaysOffset = -1;
                    try { iDaysOffset = Convert.ToInt32(gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"]); }
                    catch { }

                    if (iDaysOffset < 0)
                    {
                        e.ErrorText = "Offset days must at least be 0.";
                        e.Valid = false;
                    }
                    else if (iDaysOffset > 0 && (gvManagementFees.GetDataRow(e.RowHandle)["OffSetDate"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["OffSetDate"] == null))
                    {
                        e.ErrorText = "Offset Date is required.";
                        e.Valid = false;
                    }
                }

                if (e.Valid && (gvManagementFees.GetDataRow(e.RowHandle)["OffSetDate"] != DBNull.Value && gvManagementFees.GetDataRow(e.RowHandle)["OffSetDate"] != null))
                {
                    int iDaysOffset = -1;
                    try { iDaysOffset = Convert.ToInt32(gvManagementFees.GetDataRow(e.RowHandle)["OffSetDays"]); }
                    catch { }

                    if (iDaysOffset < 0)
                    {
                        e.ErrorText = "Offset days must at least be 0.";
                        e.Valid = false;
                    }
                }

                if (e.Valid)
                {
                    double dPercentage = 0, dAmount = 0;
                    try { dPercentage = Convert.ToDouble(gvManagementFees.GetDataRow(e.RowHandle)["Percentage"]); }
                    catch { }
                    try { dAmount = Convert.ToDouble(gvManagementFees.GetDataRow(e.RowHandle)["Amount"]); }
                    catch { }

                    if (dPercentage <= 0 && dAmount <= 0)
                    {
                        e.ErrorText = "You must have either a percentage or amount greather than 0.";
                        e.Valid = false;
                    }
                    else if (dPercentage > 0 && dAmount > 0)
                    {
                        e.ErrorText = "You can only have a percentage or an amount entered greather than 0.";
                        e.Valid = false;
                    }
                    else if (dPercentage > 100)
                    {
                        e.ErrorText = "Percentage can not be greather than 100.";
                        e.Valid = false;
                    }
                }

                if (e.Valid && (gvManagementFees.GetDataRow(e.RowHandle)["lv1ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["lv1ID"] == null))
                {
                    e.ErrorText = colLv1ID.Caption + " is required.";
                    e.Valid = false;
                }

                if (e.Valid && colLv2ID.OptionsColumn.ShowInCustomizationForm && (gvManagementFees.GetDataRow(e.RowHandle)["lv2ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["lv2ID"] == null))
                {
                    e.ErrorText = colLv2ID.Caption + " is required.";
                    e.Valid = false;
                }
                if (e.Valid && colLv3ID.OptionsColumn.ShowInCustomizationForm && (gvManagementFees.GetDataRow(e.RowHandle)["lv3ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["lv3ID"] == null))
                {
                    e.ErrorText = colLv3ID.Caption + " is required.";
                    e.Valid = false;
                }
                if (e.Valid && colLv4ID.OptionsColumn.ShowInCustomizationForm && (gvManagementFees.GetDataRow(e.RowHandle)["lv4ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["lv4ID"] == null))
                {
                    e.ErrorText = colLv4ID.Caption + " is required.";
                    e.Valid = false;
                }
                if (e.Valid && (gvManagementFees.GetDataRow(e.RowHandle)["Supplier_ID"] == DBNull.Value || gvManagementFees.GetDataRow(e.RowHandle)["Supplier_ID"] == null))
                {
                    e.ErrorText = "Supplier is required.";
                    e.Valid = false;
                }

                if (e.Valid)
                {
                    int iManagementFee_ID = -1, iID = -1;
                    try { iManagementFee_ID = Convert.ToInt32(gvManagementFees.GetDataRow(e.RowHandle)["ManagementFee_ID"]); }
                    catch{}
                    try { iID = Convert.ToInt32(gvManagementFees.GetDataRow(e.RowHandle)["ID"]); }
                    catch { }

                    object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select count(1) from LD_Proj_ManagementFees where ManagementFee_ID = " + iManagementFee_ID.ToString() + " and ID <> " + iID.ToString() + " and pri_id = " + iPri_ID.ToString(), ReflexCon.TRConnection);
                    int iCount = 0;
                    try { iCount = Convert.ToInt32(oCount); }
                    catch { }

                    if (iCount != 0)
                    {
                        e.ErrorText = "Management fees already in use.";
                        e.Valid = false;
                    }
                }
            }

            if (!e.Valid)
                bCustomMessage = true;
        }

        private void gvManagementFees_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomMessage)
            {
                bCustomMessage = false;
                frmMessageBox.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private bool ggManagementFees_AllowDelete(object sender, DataRow row)
        {
            if (bReadOnly)
                return false;

            string sql = @"select count(*) from LD_Proj_Agreement_ManagementFees m
join PROJ_LOT_AGREEMENT a on a.agreement_id = m.Agreement_ID
where a.pri_id = "+row[colPri_ID.FieldName]+" and m.ManagementFee_ID = "+row[colDescription.FieldName];
            object result = ReflexCon.SQLExecutor.ExecuteScalar(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Error checking for management fee on agreements:"+ReflexCon.SQLExecutor.Exception.Message);
                return false;
            }
            else if (result != DBNull.Value && result != null)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    frmMessageBox.ShowPopup("Management fee is currently used on an agreement and can not be deleted.");
                    return false;
                }
                else if (frmMessageBox.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                    return true;
                else
                    return false;
            }
            else
                return false;
            
        }
    }
}
