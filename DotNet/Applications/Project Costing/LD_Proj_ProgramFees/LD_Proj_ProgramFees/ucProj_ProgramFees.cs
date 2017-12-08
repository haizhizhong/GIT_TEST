using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Proj_ProgramFees
{
    public partial class ucProj_ProgramFees : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private bool bCustomMessage = false;
        private TUC_GridG.GridG ggProgramFees;
        private ReflexConnection.Extended ReflexConExt;
        private Supplier_Lookup_Rep.Repository_Supplier_Lookup SupplierLookup;
        private bool bViewMode = false;
        private bool bReadOnly = false;
        private int iPri_ID = -1;

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

        public ucProj_ProgramFees(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;

            sqlTR.ConnectionString = ReflexCon.TRConnection;
            sqlTR1.ConnectionString = ReflexCon.TRConnection;

            ReflexConExt = new ReflexConnection.Extended(ReflexCon);

            SupplierLookup = new Supplier_Lookup_Rep.Repository_Supplier_Lookup();
            SupplierLookup.HMConnection = ReflexCon;
            SupplierLookup.DevXMgr = dxStyle;
            SupplierLookup.ValueMember = "SUPPLIER_ID"; //Needed ID not code.
            colSupplier_ID.ColumnEdit = SupplierLookup;
            //PopupMenuShowingEventHandler
            rtecNotes.LoadTextEdit(ReflexCon, dxStyle);
            rtecNotes.RichTextEdit.DataBindings.Add("RtfText", lDProjProgramFeesBindingSource1, "Notes", true, DataSourceUpdateMode.OnValidation, "");
            //rtecNotes.RichTextEdit.DataBindings.Add("Text", lDProjProgramFeesBindingSource1, "NotesText", true, DataSourceUpdateMode.OnPropertyChanged, "");
            rtecNotes.RichTextEdit.PopupMenuShowing += new DevExpress.XtraRichEdit.PopupMenuShowingEventHandler(rtecNotes_PreparePopupMenu);

            ggProgramFees = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvProgramFees, daProgramFees, dsProgramFees1);
            ggProgramFees.AllowTabCreateNewRecord = true;
            ggProgramFees.AskBeforeDelete = false;
            ggProgramFees.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggProgramFees_AllowDelete);
            ggProgramFees.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(ggProgramFees_AfterUpdate);

            /*
            * This query MUST BE UPDATED WHEN VALUES ARE ADDED TO THE MAIN DATA ADAPTER AS SOME DISPLAY FIELDS HAVE TO BE SHOWN THAT REQUIRED A 
            * JOIN IN ORDER TO VIEW THEM. This query has a joined table option that will allow this to work BUT NEEDS TO BE KEPT UPDATED
            */

            daProgramFees.SelectCommand.CommandText =
            @"SELECT ppf.ID, ppf.pri_id, ppf.ProgramFees_ID, ppf.Lot_Class_ID, ppf.Lot_Sub_Class_ID, ppf.InternalPortion, ppf.PurchaserPortion, ppf.RetailsAmount1, 
ppf.RetailsAmount2, ppf.GST, ppf.PST, ppf.Supplier_ID, 
pf.GL_Account AS GLAccount, lv1.lv1_code + ' ' + lv1.lv1_desc AS Level1, lv2.lv2_code + ' ' + lv2.lv2_desc AS Level2, 
lv3.lv3_code + ' ' + lv3.lv3_desc AS Level3, lv4.lv4_code + ' ' + lv4.lv4_desc AS Level4
FROM LD_Proj_ProgramFees ppf
Inner Join LD_ProgramFees pf on pf.ID = ppf.ProgramFees_ID
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = pf.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = pf.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = pf.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = pf.lv4ID
WHERE     (pri_id = @pri_id)
ORDER BY pf.Description";

            daProgramFees.InsertCommand.CommandText = daProgramFees.InsertCommand.CommandText.Replace(@";
SELECT ID, pri_id, ProgramFees_ID, Lot_Class_ID, Lot_Sub_Class_ID, InternalPortion, PurchaserPortion, RetailsAmount1, RetailsAmount2, GST, PST, Supplier_ID, CONVERT (varchar(21), ISNULL(pri_id, - 1)) AS GLAccount, CONVERT (varchar(21), ISNULL(pri_id, - 1)) AS Level1, CONVERT (varchar(21), ISNULL(pri_id, - 1)) AS Level2, CONVERT (varchar(21), ISNULL(pri_id, - 1)) AS Level3, CONVERT (varchar(21), ISNULL(pri_id, - 1)) AS Level4 FROM LD_Proj_ProgramFees WHERE (ID = SCOPE_IDENTITY()) ORDER BY (SELECT Description FROM LD_ProgramFees AS pf WHERE (ID = LD_Proj_ProgramFees.ProgramFees_ID))",
@";
SELECT ppf.ID, ppf.pri_id, ppf.ProgramFees_ID, ppf.Lot_Class_ID, ppf.Lot_Sub_Class_ID, ppf.InternalPortion, ppf.PurchaserPortion, ppf.RetailsAmount1, 
ppf.RetailsAmount2, ppf.GST, ppf.PST, ppf.Supplier_ID, 
pf.GL_Account AS GLAccount, lv1.lv1_code + ' ' + lv1.lv1_desc AS Level1, lv2.lv2_code + ' ' + lv2.lv2_desc AS Level2, 
lv3.lv3_code + ' ' + lv3.lv3_desc AS Level3, lv4.lv4_code + ' ' + lv4.lv4_desc AS Level4
FROM LD_Proj_ProgramFees ppf
Inner Join LD_ProgramFees pf on pf.ID = ppf.ProgramFees_ID
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = pf.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = pf.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = pf.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = pf.lv4ID
WHERE (ppf.ID = SCOPE_IDENTITY())
ORDER BY pf.Description");
        }

        private void ucProj_ProgramFees_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            SetupLevels();

            dxStyle.FormInit(this);
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
            collv1ID.Caption = row["lv1_land_desc"].ToString();
            collv2ID.Caption = row["lv2_land_desc"].ToString();
            collv3ID.Caption = row["lv3_land_desc"].ToString();
            collv4ID.Caption = row["lv4_land_desc"].ToString();

            collv1ID.OptionsColumn.ShowInCustomizationForm = collv1ID.Visible = (row["lv1_active_land"].ToString() == "T");
            collv2ID.OptionsColumn.ShowInCustomizationForm = collv2ID.Visible = (row["lv2_active_land"].ToString() == "T");
            collv3ID.OptionsColumn.ShowInCustomizationForm = collv3ID.Visible = (row["lv3_active_land"].ToString() == "T");
            collv4ID.OptionsColumn.ShowInCustomizationForm = collv4ID.Visible = (row["lv4_active_land"].ToString() == "T");

        }

        public void LoadProgramFees(int Pri_id, bool ViewMode)
        {
            bViewMode = ViewMode;
            iPri_ID = Pri_id;

            if (bViewMode)
                bReadOnly = true;

            SetReadOnly();

            RefreshProjAdditionalFees();
        }

        public void RefreshProjAdditionalFees()
        {
            dsProgramFeesList1.Clear();
            daProgramFeesList.Fill(dsProgramFeesList1);
            dsLotClass1.Clear();
            daLotClass.Fill(dsLotClass1);
            dsLotSubClass1.Clear();
            daLotSubClass.Fill(dsLotSubClass1);

            dsProgramFees1.Clear();
            daProgramFees.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daProgramFees.Fill(dsProgramFees1, dsProgramFees1.LD_Proj_ProgramFees.TableName);
        }

        private void SetReadOnly()
        {
            btnLoadAll.Enabled = !bReadOnly;
            ggProgramFees.Event_ProcessGridKey_Enabled = !bReadOnly;
            gcProgramFees.EmbeddedNavigator.Buttons.Append.Visible = !bReadOnly;
            gcProgramFees.EmbeddedNavigator.Buttons.CancelEdit.Visible = !bReadOnly;
            gcProgramFees.EmbeddedNavigator.Buttons.Edit.Visible = !bReadOnly;
            gcProgramFees.EmbeddedNavigator.Buttons.EndEdit.Visible = !bReadOnly;
            gcProgramFees.EmbeddedNavigator.Buttons.Remove.Visible = !bReadOnly;
            gvProgramFees.OptionsBehavior.Editable = !bReadOnly;

            rtecNotes.RichTextEdit.Enabled = !bReadOnly;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlParameter[] saParams = new System.Data.SqlClient.SqlParameter[1];

            saParams[0] = new System.Data.SqlClient.SqlParameter("@pri_id", iPri_ID);

            ReflexConExt.ExecuteNonQueryProc("LD_Proj_LoadProgramFees", ReflexCon.TRConnection, saParams);
            if (ReflexConExt.Exception != null)
                frmMessageBox.ShowPopup("Unable to load all program fees: " + ReflexConExt.Exception.Message);

            RefreshProjAdditionalFees();
        }

        private void rilueLotSubClass_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit)
            {
                int iLotClassID = -1;
                try { iLotClassID = Convert.ToInt32(gvProgramFees.GetFocusedDataRow()["Lot_Class_ID"]); }
                catch { }

                lDLotSubClassFilteredBindingSource.Filter = "LD_Lot_Class_ID = " + iLotClassID.ToString();

                ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = lDLotSubClassFilteredBindingSource;
            }
        }

        private void gvProgramFees_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvProgramFees.GetDataRow(e.RowHandle)["GST"] = false;
            gvProgramFees.GetDataRow(e.RowHandle)["PST"] = false;
            gvProgramFees.GetDataRow(e.RowHandle)["pri_id"] = iPri_ID;
            gvProgramFees.GetDataRow(e.RowHandle)["InternalPortion"] = 0.00;
            gvProgramFees.GetDataRow(e.RowHandle)["PurchaserPortion"] = 0.00;
            gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount1"] = 0.00;
            gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount2"] = 0.00;
        }

        private void gvProgramFees_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colFeeDescription)
            {
                int iAdditionalFeeID = -1;
                try { iAdditionalFeeID = Convert.ToInt32(e.Value); }
                catch { }

                DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter(@"Select af.Description, af.GL_Account, af.Lot_Class_ID, af.Lot_Sub_Class_ID,
lv1.lv1_code + ' ' + lv1.lv1_desc AS Level1, lv2.lv2_code + ' ' + lv2.lv2_desc AS Level2, 
lv3.lv3_code + ' ' + lv3.lv3_desc AS Level3, lv4.lv4_code + ' ' + lv4.lv4_desc AS Level4, af.GST, af.PST, 
af.InternalPortion, af.PurchaserPortion, af.RetailsAmount1, af.RetailsAmount2, af.Supplier_ID
From LD_ProgramFees af
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = af.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = af.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = af.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = af.lv4ID
Where af.ID = " + iAdditionalFeeID.ToString(), ReflexCon.TRConnection);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gvProgramFees.GetDataRow(e.RowHandle)["GLAccount"] = dt.Rows[0]["GL_Account"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Lot_Class_ID"] = dt.Rows[0]["Lot_Class_ID"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Lot_Sub_Class_ID"] = dt.Rows[0]["Lot_Sub_Class_ID"];
                        gvProgramFees.GetDataRow(e.RowHandle)["InternalPortion"] = dt.Rows[0]["InternalPortion"];
                        gvProgramFees.GetDataRow(e.RowHandle)["PurchaserPortion"] = dt.Rows[0]["PurchaserPortion"];
                        gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount1"] = dt.Rows[0]["RetailsAmount1"];
                        gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount2"] = dt.Rows[0]["RetailsAmount2"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Level1"] = dt.Rows[0]["Level1"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Level2"] = dt.Rows[0]["Level2"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Level3"] = dt.Rows[0]["Level3"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Level4"] = dt.Rows[0]["Level4"];
                        gvProgramFees.GetDataRow(e.RowHandle)["GST"] = dt.Rows[0]["GST"];
                        gvProgramFees.GetDataRow(e.RowHandle)["PST"] = dt.Rows[0]["PST"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Supplier_ID"] = dt.Rows[0]["Supplier_ID"];
                    }
                }
            }
        }

        private void gvProgramFees_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvProgramFees.GetDataRow(e.RowHandle) != null && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle &&
               e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (gvProgramFees.GetDataRow(e.RowHandle)["ProgramFees_ID"] == DBNull.Value || gvProgramFees.GetDataRow(e.RowHandle)["ProgramFees_ID"] == null)
                {
                    e.ErrorText = "Fee Description cannot be blank.";
                    e.Valid = false;
                }

                if (e.Valid)
                {
                    double dAmount = 0;
                    try { dAmount = Convert.ToDouble(gvProgramFees.GetDataRow(e.RowHandle)["InternalPortion"]); }
                    catch { }

                    if (dAmount < 0)
                    {
                        e.ErrorText = "Internal Portion must at least be 0.";
                        e.Valid = false;
                    }
                }
                if (e.Valid)
                {
                    double dAmount = 0;
                    try { dAmount = Convert.ToDouble(gvProgramFees.GetDataRow(e.RowHandle)["PurchaserPortion"]); }
                    catch { }

                    if (dAmount < 0)
                    {
                        e.ErrorText = "Purchaser Portion must at least be 0.";
                        e.Valid = false;
                    }
                }
                if (e.Valid)
                {
                    double dAmount = 0;
                    try { dAmount = Convert.ToDouble(gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount1"]); }
                    catch { }

                    if (dAmount < 0)
                    {
                        e.ErrorText = "Retails Amount 1 must at least be 0.";
                        e.Valid = false;
                    }
                }
                if (e.Valid)
                {
                    double dAmount = 0;
                    try { dAmount = Convert.ToDouble(gvProgramFees.GetDataRow(e.RowHandle)["RetailsAmount2"]); }
                    catch { }

                    if (dAmount < 0)
                    {
                        e.ErrorText = "Retails Amount 2 must at least be 0.";
                        e.Valid = false;
                    }
                }

                if (e.Valid && (gvProgramFees.GetDataRow(e.RowHandle)["Supplier_ID"] == DBNull.Value || gvProgramFees.GetDataRow(e.RowHandle)["Supplier_ID"] == null))
                {
                    e.ErrorText = "Supplier is required.";
                    e.Valid = false;
                }

                if (e.Valid)
                {
                    int iProgramFee_ID = -1, iID = -1;
                    try { iProgramFee_ID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)["ProgramFees_ID"]); }
                    catch { }
                    try { iID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)["ID"]); }
                    catch { }

                    object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select count(1) from LD_Proj_ProgramFees where ProgramFees_ID = " + iProgramFee_ID.ToString() + " and ID <> " + iID.ToString() + " and pri_id = " + iPri_ID.ToString(), ReflexCon.TRConnection);
                    int iCount = 0;
                    try { iCount = Convert.ToInt32(oCount); }
                    catch { }

                    if (iCount != 0)
                    {
                        e.ErrorText = "Program fee already in use.";
                        e.Valid = false;
                    }
                }
            }

            if (!e.Valid)
                bCustomMessage = true;
        }

        private void gvProgramFees_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomMessage)
            {
                bCustomMessage = false;
                frmMessageBox.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvProgramFees_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsNotes1.LD_Proj_ProgramFees.Clear();
            rtecNotes.RichTextEdit.Text = "";

            rtecNotes.RichTextEdit.ReadOnly = true;

            if (e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle &&
                e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && gvProgramFees.GetDataRow(e.FocusedRowHandle) != null)
            {
                int iID = -1;
                try { iID = Convert.ToInt32(gvProgramFees.GetDataRow(e.FocusedRowHandle)["ID"]); }
                catch { }

                LoadNotes(iID);
                if (dsNotes1.LD_Proj_ProgramFees.Rows.Count > 0)
                    rtecNotes.RichTextEdit.ReadOnly = false;
            }
        }

        private bool ggProgramFees_AllowDelete(object sender, DataRow row)
        {
            int iID = -1;
            try { iID = Convert.ToInt32(row["ID"]); }
            catch { }

            object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select count(1) from LD_Proj_Agreement_ProgramFees where LD_Proj_ProgramFees_ID = " + iID.ToString(), ReflexCon.TRConnection);
            int iCount = 0;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount != 0)
            {
                frmMessageBox.ShowPopup("Program fee is already in use and cannot be deleted.");
                return false;
            }

            if (frmMessageBox.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }

        void ggProgramFees_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            if (UType == TUC_GridG.UpdateType.Add)
            {
                int iID = -1;
                try { iID = Convert.ToInt32(gvProgramFees.GetFocusedDataRow()["ID"]); }
                catch { }

                ReflexCon.SQLExecutor.ExecuteScalar("Update LD_Proj_ProgramFees Set Notes = (Select Notes From LD_ProgramFees pf where pf.ID = LD_Proj_ProgramFees.ProgramFees_ID), " +
                                                    " NotesText = (Select NotesText From LD_ProgramFees pf where pf.ID = LD_Proj_ProgramFees.ProgramFees_ID) Where ID = " + iID.ToString(), ReflexCon.TRConnection);

                dsNotes1.Clear();
                rtecNotes.RichTextEdit.Text = "";

                LoadNotes(iID);

                if (dsNotes1.LD_Proj_ProgramFees.Rows.Count > 0)
                    rtecNotes.RichTextEdit.ReadOnly = false;
            }
            else if (UType == TUC_GridG.UpdateType.Delete)
            {
                int iID = -1;
                try { iID = Convert.ToInt32(gvProgramFees.GetFocusedDataRow()["ID"]); }
                catch { }

                dsNotes1.Clear();
                rtecNotes.RichTextEdit.Text = "";

                LoadNotes(iID);
            }
        }

        private void LoadNotes(int pID)
        {
            daNotes.SelectCommand.Parameters["@ID"].Value = pID;
            daNotes.Fill(dsNotes1);
        }

        private void dnNotes_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                //lDProjProgramFeesBindingSource1.CancelEdit();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                e.Handled = true;
                if (dsNotes1.LD_Proj_ProgramFees.Rows.Count > 0)
                {
                    dsNotes1.LD_Proj_ProgramFees.Rows[0]["NotesText"] = rtecNotes.RichTextEdit.Text;
                }
                lDProjProgramFeesBindingSource1.EndEdit();
                daNotes.Update(dsNotes1);
            }
        }

        private void rtecNotes_PreparePopupMenu(object sender, DevExpress.XtraRichEdit.PopupMenuShowingEventArgs e)
        {
            if (e.Menu != null)
            {
                DevExpress.Utils.Menu.DXMenuItem AddRetail1Amt = new DevExpress.Utils.Menu.DXMenuItem("Insert Retail 1");
                AddRetail1Amt.BeginGroup = true;
                AddRetail1Amt.Click += new EventHandler(AddRetail1Amt_Click);
                e.Menu.Items.Add(AddRetail1Amt);

                DevExpress.Utils.Menu.DXMenuItem AddRetail2Amt = new DevExpress.Utils.Menu.DXMenuItem("Insert Retail 2");
                AddRetail2Amt.Click += new EventHandler(AddRetail2Amt_Click);
                e.Menu.Items.Add(AddRetail2Amt);

                DevExpress.Utils.Menu.DXMenuItem AddRetailTotalAmt = new DevExpress.Utils.Menu.DXMenuItem("Insert Retail Total");
                AddRetailTotalAmt.Click += new EventHandler(AddRetailTotalAmt_Click);
                e.Menu.Items.Add(AddRetailTotalAmt);
            }
        }

        private void AddRetail1Amt_Click(object sender, EventArgs e)
        {
            string sValue = "";
            try { sValue = Convert.ToDouble(gvProgramFees.GetFocusedDataRow()["RetailsAmount1"]).ToString("n2"); }
            catch { }
            InsertText(sValue);
        }

        private void AddRetail2Amt_Click(object sender, EventArgs e)
        {
            string sValue = "";
            try { sValue = Convert.ToDouble(gvProgramFees.GetFocusedDataRow()["RetailsAmount2"]).ToString("n2"); }
            catch { }
            InsertText(sValue);
        }

        private void AddRetailTotalAmt_Click(object sender, EventArgs e)
        {
            double dTotal = 0, dRetail1 = 0, dRetail2 = 0;
            string sValue = "";
            try { dRetail1 = Convert.ToDouble(gvProgramFees.GetFocusedDataRow()["RetailsAmount1"]); }
            catch { }
            try { dRetail2 = Convert.ToDouble(gvProgramFees.GetFocusedDataRow()["RetailsAmount2"]); }
            catch { }

            dTotal = dRetail1 + dRetail2;

            try
            {
                sValue = dTotal.ToString("n2");
            }
            catch { }
            InsertText(sValue);
        }

        private void InsertText(string Text)
        {
            rtecNotes.RichTextEdit.Document.InsertText(rtecNotes.RichTextEdit.Document.CaretPosition, Text);
        }
    }
}
