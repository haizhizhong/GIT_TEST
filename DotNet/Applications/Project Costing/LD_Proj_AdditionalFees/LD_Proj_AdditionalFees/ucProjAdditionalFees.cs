using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Proj_AdditionalFees
{
    public partial class ucProjAdditionalFees : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private ReflexConnection.Extended ReflexConExt;
        private int iPri_ID = -1;
        private bool bCustomMessage = false;
        private TUC_GridG.GridG ggAdditionalFees;
        private bool bViewMode = false;
        private bool bReadOnly = false;

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

        public ucProjAdditionalFees(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;

            sqlTRConnection.ConnectionString = ReflexCon.TRConnection;

            ReflexConExt = new ReflexConnection.Extended(ReflexCon);

            /*
             * This query MUST BE UPDATED WHEN VALUES ARE ADDED TO THE MAIN DATA ADAPTER AS SOME DISPLAY FIELDS HAVE TO BE SHOWN THAT REQUIRED A 
             * JOIN IN ORDER TO VIEW THEM. This query has a joined table option that will allow this to work BUT NEEDS TO BE KEPT UPDATED
             */

            daAdditionalFees.SelectCommand.CommandText =
            @"SELECT     ID, paf.Additional_Fees_ID, paf.Lot_Class_ID, paf.Lot_Sub_Class_ID, paf.GST, paf.PST, paf.Amount, 
			af.GL_Account AS GLAccount, 
            lv1.lv1_code + ' ' + lv1.lv1_desc AS Level1, lv2.lv2_code + ' ' + lv2.lv2_desc AS Level2, 
            lv3.lv3_code + ' ' + lv3.lv3_desc AS Level3, lv4.lv4_code + ' ' + lv4.lv4_desc AS Level4, paf.pri_id
FROM         LD_Proj_Additional_Fees paf
Inner Join LD_Additional_Fees af on af.Additional_Fees_ID = paf.Additional_Fees_ID
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = af.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = af.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = af.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = af.lv4ID
WHERE     (pri_id = @pri_id)
ORDER BY 
                          (SELECT     FeeDescription
                            FROM          LD_Additional_Fees AS a
                            WHERE      (paf.Additional_Fees_ID = Additional_Fees_ID))";

            daAdditionalFees.InsertCommand.CommandText = "INSERT INTO [LD_Proj_Additional_Fees] ([Additional_Fees_ID], [Lot_Class_ID], [Lot_Sub_Class_ID], [GST], [PST], [Amount], [pri_id]) VALUES (@Additional_Fees_ID, @Lot_Class_ID, @Lot_Sub_Class_ID, @GST, @PST, @Amount, @pri_id);" +
            daAdditionalFees.SelectCommand.CommandText.Replace("(pri_id = @pri_id)", "(ID = SCOPE_IDENTITY())");


            SetupLevels();
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

        private void ucProjAdditionalFees_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            ggAdditionalFees = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvAdditionalFees, daAdditionalFees, dsAdditionalFees1);
            ggAdditionalFees.AllowTabCreateNewRecord = true;
            ggAdditionalFees.AskBeforeDelete = false;
            ggAdditionalFees.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggAdditionalFees_AllowDelete);
            ggAdditionalFees.IgnoreFieldList = new string[] { "Level1", "Level2", "Level3", "Level4","GLAccount" };
            dxStyle.FormInit(this);
        }

      

        public void LoadAdditionalFees(int Pri_id, bool ViewMode)
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
            dsAdditionalFeesList1.Clear();
            daAdditionalFeesList.Fill(dsAdditionalFeesList1);
            dsLotClass1.Clear();
            daLotClass.Fill(dsLotClass1);
            dsLotSubClass1.Clear();
            daLotSubClass.Fill(dsLotSubClass1);

            dsAdditionalFees1.Clear();
            daAdditionalFees.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daAdditionalFees.Fill(dsAdditionalFees1,dsAdditionalFees1.LD_Proj_Additional_Fees.TableName);
        }

        private void SetReadOnly()
        {
            btnLoadAll.Enabled = !bReadOnly;
            ggAdditionalFees.Event_ProcessGridKey_Enabled = !bReadOnly;
            gcAdditionalFees.EmbeddedNavigator.Buttons.Append.Visible = !bReadOnly;
            gcAdditionalFees.EmbeddedNavigator.Buttons.CancelEdit.Visible = !bReadOnly;
            gcAdditionalFees.EmbeddedNavigator.Buttons.Edit.Visible = !bReadOnly;
            gcAdditionalFees.EmbeddedNavigator.Buttons.EndEdit.Visible = !bReadOnly;
            gcAdditionalFees.EmbeddedNavigator.Buttons.Remove.Visible = !bReadOnly;
            gvAdditionalFees.OptionsBehavior.Editable = !bReadOnly;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlParameter[] saParams = new System.Data.SqlClient.SqlParameter[1];

            saParams[0] = new System.Data.SqlClient.SqlParameter("@pri_id", iPri_ID);

            ReflexConExt.ExecuteNonQueryProc("LD_Proj_LoadAdditionalFees", ReflexCon.TRConnection, saParams);
            if (ReflexConExt.Exception != null)
                frmMessageBox.ShowPopup("Unable to load all additional fees: " + ReflexConExt.Exception.Message);

            RefreshProjAdditionalFees();
        }

        private void gvAdditionalFees_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvAdditionalFees.GetDataRow(e.RowHandle)["pri_id"] = iPri_ID;
            gvAdditionalFees.GetDataRow(e.RowHandle)["GST"] = false;
            gvAdditionalFees.GetDataRow(e.RowHandle)["PST"] = false;
            gvAdditionalFees.GetDataRow(e.RowHandle)["Amount"] = 0.00;
        }

        private void rilueLotSubClass_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.LookUpEdit)
            {
                int iLotClassID = -1;
                try { iLotClassID = Convert.ToInt32(gvAdditionalFees.GetFocusedDataRow()["Lot_Class_ID"]); }
                catch { }

                lDLotSubClassFilteredBindingSource.Filter = "LD_Lot_Class_ID = " + iLotClassID.ToString();

                ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = lDLotSubClassFilteredBindingSource;
            }
        }

        private void gvAdditionalFees_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colFeeDescription)
            {
                int iAdditionalFeeID = -1;
                try { iAdditionalFeeID = Convert.ToInt32(e.Value); }
                catch { }

                DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter(@"Select af.FeeDescription, af.GL_Account, af.Lot_Class_ID, af.Lot_Sub_Class_ID,
lv1.lv1_code + ' ' + lv1.lv1_desc AS Level1, lv2.lv2_code + ' ' + lv2.lv2_desc AS Level2, 
lv3.lv3_code + ' ' + lv3.lv3_desc AS Level3, lv4.lv4_code + ' ' + lv4.lv4_desc AS Level4, af.GST, af.PST, af.Amount
From LD_Additional_Fees af
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = af.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = af.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = af.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = af.lv4ID
Where af.Additional_Fees_ID = " + iAdditionalFeeID.ToString(), ReflexCon.TRConnection);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gvAdditionalFees.GetDataRow(e.RowHandle)["GLAccount"] = dt.Rows[0]["GL_Account"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Lot_Class_ID"] = dt.Rows[0]["Lot_Class_ID"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Lot_Sub_Class_ID"] = dt.Rows[0]["Lot_Sub_Class_ID"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Amount"] = dt.Rows[0]["Amount"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Level1"] = dt.Rows[0]["Level1"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Level2"] = dt.Rows[0]["Level2"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Level3"] = dt.Rows[0]["Level3"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Level4"] = dt.Rows[0]["Level4"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["GST"] = dt.Rows[0]["GST"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["PST"] = dt.Rows[0]["PST"];
                        
                    }
                }
            }
        }

        private void gvAdditionalFees_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvAdditionalFees.GetDataRow(e.RowHandle) != null && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle &&
                e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                if (gvAdditionalFees.GetDataRow(e.RowHandle)["Additional_Fees_ID"] == DBNull.Value || gvAdditionalFees.GetDataRow(e.RowHandle)["Additional_Fees_ID"] == null)
                {
                    e.ErrorText = "Fee Description is required.";
                    e.Valid = false;
                }

                if (e.Valid)
                {
                    double dAmount = 0;
                    try { dAmount = Convert.ToDouble(gvAdditionalFees.GetDataRow(e.RowHandle)["Amount"]); }
                    catch { }

                    if (dAmount < 0)
                    {
                        e.ErrorText = "Amount entered must at least be 0.";
                        e.Valid = false;
                    }
                }

                if (e.Valid)
                {
                    int iAdditionalFee_ID = -1, iID = -1;
                    try { iAdditionalFee_ID = Convert.ToInt32(gvAdditionalFees.GetDataRow(e.RowHandle)["Additional_Fees_ID"]); }
                    catch { }
                    try { iID = Convert.ToInt32(gvAdditionalFees.GetDataRow(e.RowHandle)["ID"]); }
                    catch { }

                    object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select count(1) from LD_Proj_Additional_Fees where Additional_Fees_ID = " + iAdditionalFee_ID.ToString() + " and ID <> " + iID.ToString() + " and pri_id = " + iPri_ID.ToString(), ReflexCon.TRConnection);
                    int iCount = 0;
                    try { iCount = Convert.ToInt32(oCount); }
                    catch { }

                    if (iCount != 0)
                    {
                        e.ErrorText = "Additional fee already in use.";
                        e.Valid = false;
                    }
                }
            }

            if (!e.Valid)
                bCustomMessage = true;
        }

        private void gvAdditionalFees_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomMessage)
            {
                bCustomMessage = false;
                frmMessageBox.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private bool ggAdditionalFees_AllowDelete(object sender, DataRow row)
        {
            if (bReadOnly)
                return false;
            else if (frmMessageBox.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }


       
			
    }
}
