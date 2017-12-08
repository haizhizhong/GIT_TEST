using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;
using System.Data.SqlClient;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucAgreement : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private ucHoldAttachments Attachments;
        public HMCon Connection;
        private frmPopup Popup;
        private Supplier_Lookup_Rep.Repository_Supplier_Lookup Supp_Repository;
        private LandCC.ucLetterOfCredit LOC;
        private LandCC.ucAgreementHistory AgreeHist;
        private LD_ModelRepRules.ucModelRepRules ucMRR;
        private int _LotID = -1;
        private int _PriID = -1;
        private int _AgreementID = -1;
        private bool _ReadOnly = false;
        private bool _bLoading = false;
        private TUC_GridG.GridG gGrid;
        private TUC_GridG.GridG gGridAgreeDates;
        private TUC_GridG.GridG gGridDiscounts;
        private UDF_Manager.ucUDF_Manager udfManager;
        private ucThirdPartyPurchaserHist thirdPartyPurchaserHist;
        private const int ApprovalRoutingTopic_ID = 68;
        private bool bCancelAgreement = false;
        private string sFileMgrType = "LDAGR";
        public KeyControlAccess.Validator KCA_Validator;
        private bool _IsMasterAgreement = false;
        private int _MasterAgreement_ID = -1;
        private bool SettingFromStandardTerms = false;
        private bool Overwrite = false;

        private bool _lv1_active = false;
        private bool _lv2_active = false;
        private bool _lv3_active = false;
        private bool _lv4_active = false;
        private bool isTierPresale = false;


        public ucAgreement(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            RunSetups();

            gGrid = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvDeposits, da_deposits, ds_deposits1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            gGridAgreeDates = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvAdditionalDates, da_AgreeAdditionalDates, ds_AgreeAdditionalDates1);
            gGridAgreeDates.AllowTabCreateNewRecord = true;
            gGridAgreeDates.AskBeforeDelete = false;
            gGridAgreeDates.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGridAgreeDates.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGridAgreeDates_AfterUpdate);

            gGridDiscounts = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvDiscounts, daAgreeDiscounts, dsAgreeDiscounts1);
            gGridDiscounts.AllowTabCreateNewRecord = true;
            gGridDiscounts.AskBeforeDelete = false;
            gGridDiscounts.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            Attachments = new ucHoldAttachments(Connection, DevXMgr);
            Attachments.Readonly = true;
            Attachments.Dock = DockStyle.Fill;
            Attachments.Parent = dpAttachments;

            SetupLevels();

            object result = Connection.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for Tier Pre-Sale:" + Connection.SQLExecutor.Exception.Message);
            else if (Convert.ToBoolean(result))
            {
                isTierPresale = true;
            }
            else
            {
                colPresaleSeq.Visible = false;
                colPresaleSeq.OptionsColumn.ShowInCustomizationForm = false;
            }
            
        }

       

        private void SetupLevels()
        {
            string sql = "select  isnull(lv1_land_desc,'')[lv1_land_desc] , isnull(lv2_land_desc,'')[lv2_land_desc] , isnull(lv3_land_desc,'')[lv3_land_desc] , isnull(lv4_land_desc,'')[lv4_land_desc] ," +
                "isnull(lv1_active_land,'F')[lv1_active_land] , isnull(lv2_active_land,'F')[lv2_active_land] , isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl ";

            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
            {
                if (Popup != null)
                    Popup.ShowPopup("Error loading costing reference setup:" + Connection.SQLExecutor.Exception.Message);
                else
                    MessageBox.Show("Error loading costing reference setup:" + Connection.SQLExecutor.Exception.Message);
            }
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    SetCostingReferenceColumns(dt.Rows[0]);
                }
            }
            if (Connection.CountryCode == "C")
            {
                colGST.Caption = "GST";
                colPST.Caption = "PST";
                colGST1.Caption = "GST";
                colPST1.Caption = "PST";
            }
            else if (Connection.CountryCode == "U")
            {
                colGST.Caption = "Tax 1";
                colPST.Caption = "Tax 2";
                colGST1.Caption = "Tax 1";
                colPST1.Caption = "Tax 2";
            }
        }



        private void SetCostingReferenceColumns(DataRow row)
        {
            collv1id2.Caption = row["lv1_land_desc"].ToString();
            collv2id2.Caption = row["lv2_land_desc"].ToString();
            collv3id2.Caption = row["lv3_land_desc"].ToString();
            collv4id2.Caption = row["lv4_land_desc"].ToString();

            collv1id2.OptionsColumn.ShowInCustomizationForm = collv1id2.Visible = _lv1_active = (row["lv1_active_land"].ToString() == "T");
            collv2id2.OptionsColumn.ShowInCustomizationForm = collv2id2.Visible = _lv2_active = (row["lv2_active_land"].ToString() == "T");
            collv3id2.OptionsColumn.ShowInCustomizationForm = collv3id2.Visible = _lv3_active = (row["lv3_active_land"].ToString() == "T");
            collv4id2.OptionsColumn.ShowInCustomizationForm = collv4id2.Visible = _lv4_active = (row["lv4_active_land"].ToString() == "T");

            colLv1ID.Caption = row["lv1_land_desc"].ToString();
            colLv2ID.Caption = row["lv2_land_desc"].ToString();
            colLv3ID.Caption = row["lv3_land_desc"].ToString();
            colLv4ID.Caption = row["lv4_land_desc"].ToString();

            colLv1ID.OptionsColumn.ShowInCustomizationForm = colLv1ID.Visible = (row["lv1_active_land"].ToString() == "T");
            colLv2ID.OptionsColumn.ShowInCustomizationForm = colLv2ID.Visible = (row["lv2_active_land"].ToString() == "T");
            colLv3ID.OptionsColumn.ShowInCustomizationForm = colLv3ID.Visible = (row["lv3_active_land"].ToString() == "T");
            colLv4ID.OptionsColumn.ShowInCustomizationForm = colLv4ID.Visible = (row["lv4_active_land"].ToString() == "T");

            colLV1ID1.Caption = row["lv1_land_desc"].ToString();
            colLV2ID1.Caption = row["lv2_land_desc"].ToString();
            colLV3ID1.Caption = row["lv3_land_desc"].ToString();
            colLV4ID1.Caption = row["lv4_land_desc"].ToString();

            colLV1ID1.OptionsColumn.ShowInCustomizationForm = colLV1ID1.Visible = (row["lv1_active_land"].ToString() == "T");
            colLV2ID1.OptionsColumn.ShowInCustomizationForm = colLV2ID1.Visible = (row["lv2_active_land"].ToString() == "T");
            colLV3ID1.OptionsColumn.ShowInCustomizationForm = colLV3ID1.Visible = (row["lv3_active_land"].ToString() == "T");
            colLV4ID1.OptionsColumn.ShowInCustomizationForm = colLV4ID1.Visible = (row["lv4_active_land"].ToString() == "T");

            colLevel1.Caption = row["lv1_land_desc"].ToString();
            colLevel2.Caption = row["lv2_land_desc"].ToString();
            colLevel3.Caption = row["lv3_land_desc"].ToString();
            colLevel4.Caption = row["lv4_land_desc"].ToString();

            colLevel1.OptionsColumn.ShowInCustomizationForm = colLevel1.Visible = (row["lv1_active_land"].ToString() == "T");
            colLevel2.OptionsColumn.ShowInCustomizationForm = colLevel2.Visible = (row["lv2_active_land"].ToString() == "T");
            colLevel3.OptionsColumn.ShowInCustomizationForm = colLevel3.Visible = (row["lv3_active_land"].ToString() == "T");
            colLevel4.OptionsColumn.ShowInCustomizationForm = colLevel4.Visible = (row["lv4_active_land"].ToString() == "T");

        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }
			
        #region Setups

        private void RunSetups()
        {
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            TR_Conn.ConnectionString = Connection.TRConnection;

            daLv1.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv2.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv3.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv4.SelectCommand.Parameters["@projtype"].Value = "L";

            LOC = new LandCC.ucLetterOfCredit(Connection, DevXMgr);
            LOC.Dock = DockStyle.Fill;
            LOC.Parent = dpLOC;

            AgreeHist = new LandCC.ucAgreementHistory(Connection, DevXMgr);
            AgreeHist.AgreementChange_Event += new LandCC.ucAgreementHistory.AgreementChange_Delegate(AgreeHist_AgreementChange_Event);
            AgreeHist.Dock = DockStyle.Fill;
            AgreeHist.Parent = dpAgreeHist;

            SetupUnits();
            udfManager = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.LotAgreement);
            udfManager.Parent = tpUDF;
            udfManager.Dock = DockStyle.Fill;
            //to set the reference type
            udfManager.PopulateUDFValues("Agreement", -1);

            thirdPartyPurchaserHist = new ucThirdPartyPurchaserHist(Connection, DevXMgr);
            thirdPartyPurchaserHist.Dock = DockStyle.Fill;
            thirdPartyPurchaserHist.Parent = tpHist;

            ucMRR = new LD_ModelRepRules.ucModelRepRules(Connection);
            ucMRR.Dock = DockStyle.Fill;
            ucMRR.Parent = tpRepRules;

            SetupSupplierLU();
            
            btnRefresh_Click(null, null);
        }

        private void SetupSupplierLU()
        {
            Supp_Repository = new Supplier_Lookup_Rep.Repository_Supplier_Lookup();
            Supp_Repository.HMConnection = Connection;
            Supp_Repository.DevXMgr = DevXMgr;
            Supp_Repository.ActiveSuppliers = true;
            Supp_Repository.ValueMember = "SUPPLIER_ID";
            colsupplier_id1.ColumnEdit = Supp_Repository;
        }
        
        private void SetupUnits()
        {
            if (!Connection.CountryCode.Equals("U"))
            {
                lciTax1.Text = "GST";
                lciTax2.Text = "PST";
            }
        }

        private void LoadLotInfo()
        {
            txtLot.Text = "";
            txtBlock.Text = "";
            txtPlan.Text = "";

            string sSelect = "select lot_num, block_num, plan_num from proj_lot where proj_lot_id=" + _LotID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        object oLot = dr["lot_num"];
                        if (oLot != null && oLot != DBNull.Value)
                            txtLot.Text = oLot.ToString();

                        object oBlock = dr["block_num"];
                        if (oBlock != null && oBlock != DBNull.Value)
                            txtBlock.Text = oBlock.ToString();

                        object oPlan = dr["plan_num"];
                        if (oPlan != null && oPlan != DBNull.Value)
                            txtPlan.Text = oPlan.ToString();
                    }
                }
            }			
        }

        #endregion

        public void SetupDashboardMode()
        {
            dockManager1.ForceInitialize();
            dpActions.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dpAgreeHist.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dpLOC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dpManagementFees.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;

            //btnLoadFrom.Enabled = !ReadOnly;
            dnUnit.Enabled = !ReadOnly;
            SetControlsReadOnly(ReadOnly);
            udfManager.SetReadOnly(_ReadOnly);
            ucMRR.SetReadOnly(_ReadOnly);
        }

        private void SetControlsReadOnly(bool ReadOnly)
        {
            if (_ReadOnly)//if view is readonly then trump the call.
            {
                ReadOnly = _ReadOnly;
                ceCollectRemindSent.Properties.ReadOnly = ReadOnly;//always editable
            }
            
            luePrimeSource.Properties.ReadOnly = ReadOnly;
            lueSaleType.Properties.ReadOnly = ReadOnly;
            ceTax1.Properties.ReadOnly = ReadOnly;
            ceTax2.Properties.ReadOnly = ReadOnly;
            teActualDownPayment.Properties.ReadOnly = ReadOnly;
            teActualSellPrice.Properties.ReadOnly = ReadOnly;
            teDiscountAmt.Properties.ReadOnly = ReadOnly;
            teDiscountPct.Properties.ReadOnly = ReadOnly;
            tePen.Properties.ReadOnly = ReadOnly;
            tePenaltyPct.Properties.ReadOnly = ReadOnly;

            ucMRR.SetReadOnly(ReadOnly);
            
            if (_IsMasterAgreement)
            {//master agreement fields that have to be the same accross the board
                //**purchaser MUST be consistant or AR Payments will break.
                luePurchaserType.Properties.ReadOnly = true;
                luePurchaser1.Properties.ReadOnly = true;
                luePurchaser2.Properties.ReadOnly = true;
                luePurchaser3.Properties.ReadOnly = true;
            }
            else
            {
                luePurchaserType.Properties.ReadOnly = ReadOnly;
                luePurchaser1.Properties.ReadOnly = ReadOnly;
                luePurchaser2.Properties.ReadOnly = ReadOnly;
                luePurchaser3.Properties.ReadOnly = ReadOnly;
            }
            luePurchaser1.Properties.Buttons[1].Enabled = !luePurchaser1.Properties.ReadOnly;
            luePurchaser2.Properties.Buttons[1].Enabled = !luePurchaser2.Properties.ReadOnly;
            luePurchaser3.Properties.Buttons[1].Enabled = !luePurchaser3.Properties.ReadOnly;

            object oPT = luePurchaserType.EditValue;
            int iPT = -1;
            try { iPT = Convert.ToInt32(oPT); }
            catch { }

            lueAssumedPurchaser.Properties.ReadOnly = ReadOnly;
            deAssumedDate.Properties.ReadOnly = ReadOnly;
            if (!ReadOnly)//Individual can not have an assumed purchaser
            {
                lueAssumedPurchaser.Properties.ReadOnly = !(iPT == 3 || iPT == 1);
                deAssumedDate.Properties.ReadOnly = lueAssumedPurchaser.Properties.ReadOnly;
            }
            lueAssumedPurchaser.Properties.Buttons[1].Enabled = !lueAssumedPurchaser.Properties.ReadOnly;
            deAssumedDate.Properties.Buttons[1].Enabled = !deAssumedDate.Properties.ReadOnly;
            
            

            deAgreeDate.Properties.ReadOnly = ReadOnly;
            deArrIntDate.Properties.ReadOnly = ReadOnly;
            deClosingDate.Properties.ReadOnly = ReadOnly;
            deExpPayDate.Properties.ReadOnly = ReadOnly;
            deIntAdjDate.Properties.ReadOnly = ReadOnly;
            deOrgArrDate.Properties.ReadOnly = ReadOnly;
            deSaleDate.Properties.ReadOnly = ReadOnly;
            deEstReleaseDate.Properties.ReadOnly = ReadOnly;
            deActualReleaseDate.Properties.ReadOnly = ReadOnly;
            //ceCollectRemindSent.Properties.ReadOnly = ReadOnly;
            //interest tab
            lueARateType.Properties.ReadOnly = ReadOnly;
            lueABasedOn.Properties.ReadOnly = ReadOnly;
            lueACompFreq.Properties.ReadOnly = ReadOnly;
            txtAIRS.Properties.ReadOnly = ReadOnly;
            txtAMaxIR.Properties.ReadOnly = ReadOnly;
            txtAMinIR.Properties.ReadOnly = ReadOnly;
            lueRRateType.Properties.ReadOnly = ReadOnly;
            lueRBasedOn.Properties.ReadOnly = ReadOnly;
            lueRCompFreq.Properties.ReadOnly = ReadOnly;
            txtRIRS.Properties.ReadOnly = ReadOnly;
            txtRMaxIR.Properties.ReadOnly = ReadOnly;
            txtRMinIR.Properties.ReadOnly = ReadOnly;
            //
            lueHB.Properties.ReadOnly = ReadOnly;
            chkHOAApp.Properties.ReadOnly = ReadOnly;
            chkHOARec.Properties.ReadOnly = ReadOnly;
            chkWCB.Properties.ReadOnly = ReadOnly;
            meHOAComment.Properties.ReadOnly = ReadOnly;
            txtHOAAmt.Properties.ReadOnly = ReadOnly;
            teFileNumber.Properties.ReadOnly = ReadOnly;
            txtWCBProvider.Properties.ReadOnly = ReadOnly;
            deHOADate.Properties.ReadOnly = ReadOnly;
            ceProbationLot.Properties.ReadOnly = ReadOnly;
            lueWarrantyType.Properties.ReadOnly = ReadOnly;
            ceTitleTrnConfirmed.Properties.ReadOnly = ReadOnly;
            ceTitleTrnRequested.Properties.ReadOnly = ReadOnly;
            deTrnRequested.Properties.ReadOnly = ReadOnly;
            deTrnConfirmed.Properties.ReadOnly = ReadOnly;
            //3rd party tab
            lueHomeBuilder.Properties.ReadOnly = ReadOnly;
            lueModel.Properties.ReadOnly = ReadOnly;
            lueElevation.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser1.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser2.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser3.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser4.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser5.Properties.ReadOnly = ReadOnly;
            lue3rdPurchaser6.Properties.ReadOnly = ReadOnly;

            ceThirdPartyPurchase.Properties.ReadOnly = ReadOnly;
            ceSpecHome.Properties.ReadOnly = ReadOnly;
            ceShowHome.Properties.ReadOnly = ReadOnly;

            if (ReadOnly)
            {   
                deThirdPartyPurchaseDate.Properties.ReadOnly = ReadOnly;
                deSpecHomeStartDate.Properties.ReadOnly = ReadOnly;
                deShowHomeStartDate.Properties.ReadOnly = ReadOnly;
                deShowHomeCloseDate.Properties.ReadOnly = ReadOnly;
            }

            if (isTierPresale && !_ReadOnly)
            {
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from proj_lot_agreement where agreement_status_id in (1,4,5) and agreement_id=" + _AgreementID, Connection.TRConnection)) != 0)
                    hlPost.Enabled = true;
                else
                    hlPost.Enabled = !ReadOnly;
            }
            else
                hlPost.Enabled = !ReadOnly;

            hlAgreementExtension.Enabled = !ReadOnly;
            if(!ReadOnly)
            {
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from proj_lot_agreement where agreement_status_id=3 and agreement_id=" + _AgreementID, Connection.TRConnection)) != 0)
                    hlAgreementExtension.Enabled = false;
            }
            
            btnLoadFrom.Enabled = !ReadOnly;
            RoutingActive(ReadOnly);

            gvDeposits.OptionsBehavior.Editable = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;

            gvAdditionalDates.OptionsBehavior.Editable = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;

            gvLevy.OptionsBehavior.Editable = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;

            gvDiscounts.OptionsBehavior.Editable = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;
        }

        private void SetupCompletedReadOnly()
        {
            bool ReadOnly = true;

            if (_ReadOnly)//if view is readonly then trump the call.
            {
                SetControlsReadOnly(_ReadOnly);
                return;
            }
            
            luePrimeSource.Properties.ReadOnly = ReadOnly;
            lueSaleType.Properties.ReadOnly = ReadOnly;
            ceTax1.Properties.ReadOnly = ReadOnly;
            ceTax2.Properties.ReadOnly = ReadOnly;
            teActualDownPayment.Properties.ReadOnly = ReadOnly;
            teActualSellPrice.Properties.ReadOnly = ReadOnly;
            teDiscountAmt.Properties.ReadOnly = !ReadOnly;
            teDiscountPct.Properties.ReadOnly = !ReadOnly;
            tePen.Properties.ReadOnly = !ReadOnly;
            tePenaltyPct.Properties.ReadOnly = !ReadOnly;
            luePurchaserType.Properties.ReadOnly = ReadOnly;
            luePurchaser1.Properties.ReadOnly = ReadOnly;
            luePurchaser2.Properties.ReadOnly = ReadOnly;
            luePurchaser3.Properties.ReadOnly = ReadOnly;
            luePurchaser1.Properties.Buttons[1].Enabled = !luePurchaser1.Properties.ReadOnly;
            luePurchaser2.Properties.Buttons[1].Enabled = !luePurchaser2.Properties.ReadOnly;
            luePurchaser3.Properties.Buttons[1].Enabled = !luePurchaser3.Properties.ReadOnly;

            lueAssumedPurchaser.Properties.ReadOnly = !ReadOnly;
            deAssumedDate.Properties.ReadOnly = !ReadOnly;
            lueAssumedPurchaser.Properties.Buttons[1].Enabled = !lueAssumedPurchaser.Properties.ReadOnly;
            deAssumedDate.Properties.Buttons[1].Enabled = !deAssumedDate.Properties.ReadOnly;

            deAgreeDate.Properties.ReadOnly = ReadOnly;
            deArrIntDate.Properties.ReadOnly = !ReadOnly;
            deClosingDate.Properties.ReadOnly = !ReadOnly;
            deExpPayDate.Properties.ReadOnly = !ReadOnly;
            deIntAdjDate.Properties.ReadOnly = !ReadOnly;
            deOrgArrDate.Properties.ReadOnly = !ReadOnly;
            deSaleDate.Properties.ReadOnly = ReadOnly;
            deEstReleaseDate.Properties.ReadOnly = !ReadOnly;
            deActualReleaseDate.Properties.ReadOnly = !ReadOnly;

            //interest tab
            lueARateType.Properties.ReadOnly = !ReadOnly;
            lueABasedOn.Properties.ReadOnly = !ReadOnly;
            lueACompFreq.Properties.ReadOnly = !ReadOnly;
            txtAIRS.Properties.ReadOnly = !ReadOnly;
            txtAMaxIR.Properties.ReadOnly = !ReadOnly;
            txtAMinIR.Properties.ReadOnly = !ReadOnly;
            lueRRateType.Properties.ReadOnly = !ReadOnly;
            lueRBasedOn.Properties.ReadOnly = !ReadOnly;
            lueRCompFreq.Properties.ReadOnly = !ReadOnly;
            txtRIRS.Properties.ReadOnly = !ReadOnly;
            txtRMaxIR.Properties.ReadOnly = !ReadOnly;
            txtRMinIR.Properties.ReadOnly = !ReadOnly;
            //
            lueHB.Properties.ReadOnly = !ReadOnly;
            chkHOAApp.Properties.ReadOnly = !ReadOnly;
            chkHOARec.Properties.ReadOnly = !ReadOnly;
            chkWCB.Properties.ReadOnly = !ReadOnly;
            meHOAComment.Properties.ReadOnly = !ReadOnly;
            txtHOAAmt.Properties.ReadOnly = !ReadOnly;
            txtWCBProvider.Properties.ReadOnly = !ReadOnly;
            deHOADate.Properties.ReadOnly = !ReadOnly;
            teFileNumber.Properties.ReadOnly = !ReadOnly;
            ceProbationLot.Properties.ReadOnly = !ReadOnly;
            lueWarrantyType.Properties.ReadOnly = !ReadOnly;
            ceTitleTrnConfirmed.Properties.ReadOnly = !ReadOnly;
            ceTitleTrnRequested.Properties.ReadOnly = !ReadOnly;
            deTrnRequested.Properties.ReadOnly = !ReadOnly;
            deTrnConfirmed.Properties.ReadOnly = !ReadOnly;
            //3rd party tab
            lueHomeBuilder.Properties.ReadOnly = !ReadOnly;
            lueModel.Properties.ReadOnly = !ReadOnly;
            lueElevation.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser1.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser2.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser3.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser4.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser5.Properties.ReadOnly = !ReadOnly;
            lue3rdPurchaser6.Properties.ReadOnly = !ReadOnly;

            ceThirdPartyPurchase.Properties.ReadOnly = !ReadOnly;
            ceSpecHome.Properties.ReadOnly = !ReadOnly;
            ceShowHome.Properties.ReadOnly = !ReadOnly;


            if (isTierPresale && !_ReadOnly)
            {
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from proj_lot_agreement where agreement_status_id in (1,4,5) and agreement_id=" + _AgreementID, Connection.TRConnection)) != 0)
                    hlPost.Enabled = true;
                else
                    hlPost.Enabled = !ReadOnly;
            }
            else
                hlPost.Enabled = !ReadOnly;
            
            btnLoadFrom.Enabled = !ReadOnly;
            RoutingActive(ReadOnly);

            gvDeposits.OptionsBehavior.Editable = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcDeposits.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;

            gvAdditionalDates.OptionsBehavior.Editable = ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.Edit.Visible = ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.EndEdit.Visible = ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.CancelEdit.Visible = ReadOnly;

            gvDiscounts.OptionsBehavior.Editable = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcDiscounts.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;

            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from proj_lot_agreement where agreement_status_id not in(2, 3) and agreement_id=" + _AgreementID, Connection.TRConnection)) == 1)
               if(!_ReadOnly)
                   hlAgreementExtension.Enabled = true;
        }

        private void AgreeHist_AgreementChange_Event(int AgreementID)
        {
            _bLoading = true;
            _bSetting3rdPP = true;
            _AgreementID = AgreementID;
            object result = Connection.SQLExecutor.ExecuteScalar("select ISNULL((select LOT_MASTER_AGREEMENT_ID from PROJ_LOT_MASTER_AGREEMENT_DETAIL d where d.LOT_AGREEMENT_ID = "+_AgreementID+"),-1)", Connection.TRConnection);
            _MasterAgreement_ID = -1;
            try { _MasterAgreement_ID = Convert.ToInt32(result); }
            catch { }
            if (_MasterAgreement_ID != -1)
                _IsMasterAgreement = true;
            else
                _IsMasterAgreement = false;

            Attachments.AgreementID = _AgreementID;
            udfManager.PopulateUDFValues("Agreement", _AgreementID);
            SharePointMgr.cSharePointMgr.UpdateButton(Connection, "PC Lot Agreement", ref btnSharepoint, "Agreement", AgreementID);
            ds_proj_lot_agreement1.Clear();
            da_proj_lot_agreement.SelectCommand.Parameters["@AgreementID"].Value = AgreementID;
            da_proj_lot_agreement.Fill(ds_proj_lot_agreement1);
            
            da_deposits.SelectCommand.Parameters["@agreement_id"].Value = AgreementID;
            ds_deposits1.Clear();
            da_deposits.Fill(ds_deposits1);

            dsAgreeDiscounts1.Clear();
            daAgreeDiscounts.SelectCommand.Parameters["@agreement_id"].Value = AgreementID;
            daAgreeDiscounts.Fill(dsAgreeDiscounts1.Tables[0]);

            da_AgreeAdditionalDates.SelectCommand.Parameters["@agreement_id"].Value = AgreementID;
            ds_AgreeAdditionalDates1.Clear();
            da_AgreeAdditionalDates.Fill(ds_AgreeAdditionalDates1);

            LoadLevies(AgreementID);

            ds_AgreementExtension1.Clear();
            da_AgreementExtension.SelectCommand.Parameters["@agreement_id"].Value = AgreementID;
            da_AgreementExtension.Fill(ds_AgreementExtension1);
            tePayoutExtGranted.Text = ds_AgreementExtension1.Proj_Lot_Agreement_Extension_Hist.Rows.Count.ToString();

            bool ReadOnly = false, CompletedStatus = false;
            if (ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows.Count == 0)
                ReadOnly = true;
            else
            {
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from proj_lot_agreement where agreement_status_id=1 and agreement_id=" + _AgreementID, Connection.TRConnection)) == 0)
                    CompletedStatus = true;
            }

            string sSQL = @"if exists( select * from proj_lot_agreement where agreement_status_id=2 and agreement_id=" + _AgreementID+@")
                begin
                    select 1
                end
                else
                begin
                    select 0
                end";

            object obj = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (obj == null || obj == DBNull.Value)
                obj = 0;

            if (!ReadOnly && Convert.ToInt32(obj) == 1)
                ReadOnly = true;

            if(CompletedStatus)
                SetupCompletedReadOnly();
            else
                SetControlsReadOnly(ReadOnly);
            
            luePurchaserType_EditValueChanged(null, null);
            LOC.FillLOC(_LotID, AgreementID);
            Load3rdPartyPurch();
            dsAgreeManagementFees1.Clear();
            daAgreeManagementFees.SelectCommand.Parameters["@pri_id"].Value = _PriID;
            daAgreeManagementFees.SelectCommand.Parameters["@agreement_id"].Value = _AgreementID;
            daAgreeManagementFees.Fill(dsAgreeManagementFees1);
            dsAgreeAdditionalFees1.Clear();
            daAgreeAdditionalFees.SelectCommand.Parameters["@pri_id"].Value = _PriID;
            daAgreeAdditionalFees.SelectCommand.Parameters["@agreement_id"].Value = _AgreementID;
            daAgreeAdditionalFees.Fill(dsAgreeAdditionalFees1);
            dsAgreeProgramFees1.Clear();
            //daAgreeProgramFees.SelectCommand.Parameters["@pri_id"].Value = _PriID;
            daAgreeProgramFees.SelectCommand.Parameters["@agreement_id"].Value = _AgreementID;
            daAgreeProgramFees.Fill(dsAgreeProgramFees1);
            _bSetting3rdPP = false;
            _bLoading = false;
            if (thirdPartyPurchaserHist != null)
                thirdPartyPurchaserHist.LoadHist(AgreementID);

            LoadAgreementCOS();

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, _AgreementID, ref btnAttachments);
        }

        private void LoadLevies(int AgreementID)
        {
            dsAgreeLevy.Clear();
            daAgreeLevy.SelectCommand.Parameters["@agreement_id"].Value = AgreementID;
            daAgreeLevy.Fill(dsAgreeLevy);
            gvLevy.BestFitColumns();
        }

        private void LoadAgreementCOS()
        {
            //Checks agreeement if there is an agreement converted cost of sales and if not gets the cost of sales from invoices for the current agreement
            object oCost = Connection.SQLExecutor.ExecuteScalar("exec LD_GetAgreementCOS " + _AgreementID.ToString(), Connection.TRConnection);
            decimal dCost = 0;
            try { dCost = Convert.ToDecimal(oCost); }
            catch { }

            //if (dCost < 0) dCost = 0;

            txtCostOfSales.EditValue = dCost;
        }

        public void LoadLot(int LotID, int PriID)
        {            
            _bLoading = true;
            _bCreatingNew = false;
            _LotID = LotID;
            _PriID = PriID;
            _AgreementID = -1;
            Attachments.AgreementID = _AgreementID;
            LOC.FillLOC(-1, -1);
            LoadLotInfo();
            CheckAgreements();
            ds_proj_lot_agreement1.Clear();
            da_proj_lot_agreement.SelectCommand.Parameters["@PROJ_LOT_ID"].Value = LotID;            
            AgreeHist.Proj_Lot_ID = LotID;
            if(_AgreementID == -1)
                AgreeHist_AgreementChange_Event(_AgreementID);

            LoadRepRules();
            _bLoading = false;
            btnRefresh_Click(btnRefresh, null);
        }

        //ONLY TO BE USED WHEN A SPECIFIC AGREEMENT IS SHOW AND THE HISTORY IS NOT USED!
        public void LoadAgreement(int AgreementID)
        {
            AgreeHist_AgreementChange_Event(AgreementID);
            Attachments.AgreementID = AgreementID;

        }

        private void RoutingActive(bool pReadOnly)
        {
            object oActive = Connection.SQLExecutor.ExecuteScalar("Select IsNull(Active,0) From Approval_Topic where ID = " + ApprovalRoutingTopic_ID.ToString(), Connection.WebConnection);
            bool bActive = false;
            try { bActive = Convert.ToBoolean(oActive); }
            catch { }

            if (!pReadOnly)
                hlRoute.Enabled = bActive;
            else
                hlRoute.Enabled = false;

        }

        private void CheckAgreements()
        {
            dnUnit.Buttons.Append.Enabled = true;

            string sSelect = "select count(*) from proj_lot_agreement where proj_lot_id ="+_LotID+" and agreement_status_id <> 2";
            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
            {
                dnUnit.Buttons.Append.Enabled = false;
            }
        }
        
        private void ucAgreement_Load(object sender, EventArgs e)
        {
            panelContainer1.ActiveChild = dpAgreeHist;
            DevXMgr.FormInit(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsLv1.Clear();
            daLv1.Fill(dsLv1);
            dsLv2.Clear();
            daLv2.Fill(dsLv2);
            dsLv3.Clear();
            daLv3.Fill(dsLv3);
            dsLv4.Clear();
            daLv4.Fill(dsLv4);
            dsLevyType.Clear();
            daLevyType.Fill(dsLevyType);
            dsAgreementLookups.Clear();
            daAgreementLookups.Fill(ds_lueAgreement_SP1);
            ds_lueDepositTyeps1.Clear();
            da_lueDepositType.Fill(ds_lueDepositTyeps1);
            ds3Purchaser.Clear();
            da3Purchaser.Fill(ds3Purchaser);
            ds_LD_WarrantyType1.Clear();
            da_LD_WarrantyType.Fill(ds_LD_WarrantyType1);
            ds_lueAdditionalDates.Clear();
            da_lueAdditionalDates.Fill(ds_lueAdditionalDates);
            dsSupplier1.Clear();
            daSupplier.Fill(dsSupplier1);

            dsAssumedPurchaser1.Clear();
            daAssumedPurchaser.Fill(dsAssumedPurchaser1);

            dsLevel1Codes1.Clear();
            daLevel1Codes.Fill(dsLevel1Codes1);
            dsLevel2Codes1.Clear();
            daLevel2Codes.Fill(dsLevel2Codes1);
            dsLevel3Codes1.Clear();
            daLevel3Codes.Fill(dsLevel3Codes1);
            dsLevel4Codes1.Clear();
            daLevel4Codes.Fill(dsLevel4Codes1);

            dsDiscountType1.Clear();
            daDiscountType.Fill(dsDiscountType1);

            ds_lueValueType1.Clear();
            da_lueValueType.Fill(ds_lueValueType1);

            dsPurchaser.Clear();
            object oPT = luePurchaserType.EditValue;
            if (oPT != null && oPT != DBNull.Value)
            {
                daPurchaser.SelectCommand.Parameters["@purchaser_type_id"].Value = oPT;
                daPurchaser.Fill(dsPurchaser);
            }
        }

        private bool _bCreatingNew = false;

        private void dnUnit_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                _AgreementID = -1;
                Attachments.AgreementID = _AgreementID;
                ds_proj_lot_agreement1.Clear();
                ds_AgreeAdditionalDates1.Clear();
                ds_deposits1.Clear();
                bs_proj_lot_agreement.SuspendBinding();
                object newObject = bs_proj_lot_agreement.AddNew();
                DataRow dr = ((DataRowView)newObject).Row;
                SetDefaults(dr);
                bs_proj_lot_agreement.ResumeBinding();
                SetControlsReadOnly(false);
                _bCreatingNew = true;

                e.Handled = true;
                Load3rdPartyPurch();
                dnUnit.Buttons.Append.Enabled = false;
                txtCostOfSales.EditValue = DBNull.Value;
            }
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {           
                object oDRV = bs_proj_lot_agreement.Current;
                if (oDRV != null)
                {
                    DataRowView DRV = oDRV as DataRowView;
                    if (isValid(DRV.Row))
                    {
                        DRV.Row["pri_id"] = _PriID;
                        DRV.Row["proj_lot_id"] = _LotID;
                        object oStatus = DRV.Row["agreement_status_id"];
                        if (oStatus == null || oStatus == DBNull.Value)
                        {
                            DRV.Row["agreement_status_id"] = 1;
                        }

                        if (!bCancelAgreement)
                        {
                            string sDate = (deAgreeDate.DateTime.Year > 1899 && deAgreeDate.DateTime.Year < 3000 ? deAgreeDate.DateTime.ToShortDateString() : "1/1/1900");
                            object oCount = Connection.SQLExecutor.ExecuteScalar("Select Count(1) From PROJ_LOT_HOLD h where h.purchaser_id <> "+DRV.Row["purchaser_id"].ToString()+" and h.proj_lot_id = " + _LotID.ToString() + " and CONVERT(datetime,Convert(varchar,h.start_date,101)) <= '" + sDate + "' and CONVERT(datetime,Convert(varchar,h.end_date,101)) >= '" + sDate + "'", Connection.TRConnection);
                            int iCount = 0;
                            try { iCount = Convert.ToInt32(oCount); }
                            catch { }

                            if (iCount > 0)
                            {
                                if (Popup.ShowPopup("Lot has current active holds. Do you want to continue?", frmPopup.PopupType.Yes_No) != frmPopup.PopupResult.Yes)
                                    return;
                            }
                        }

                        bs_proj_lot_agreement.EndEdit();
                        DataTable dt =CheckForAdditionalDatesChange(DRV);
                        da_proj_lot_agreement.Update(ds_proj_lot_agreement1);

                        if (_bCreatingNew)
                        {
                            string sUpdate = "exec LD_LogLotStatusChange " + Connection.MLUser + ", " + _LotID.ToString() + " update proj_lot set lot_status_id=4, sub_status_id=10 where proj_lot_id=" + _LotID.ToString();
                            Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);
                            _bCreatingNew = false;
                        }
                        
                        try
                        {   //agreement ID will be -1 for a new record.
                            if (_AgreementID == -1)
                            {
                                _AgreementID = Convert.ToInt32(ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows[0]["agreement_id"]);
                                ucMRR.SaveRepetitonRules(_AgreementID);
                                //gets filled from AgreeHist.Proj_Lot_ID call below(fires agreement changed event)
                                LoadAdditionalDatesFromProject(false);
                                //if(Convert.ToBoolean( DRV.Row["LoadedFromSetup"] ))
                                //    LoadStandardTermsDeposits();

                                Connection.SQLExecutor.ExecuteNonQuery("exec LD_Agreement_LoadManagementFee " + _AgreementID.ToString() + " exec LD_Agreement_LoadAdditionalFees " + _AgreementID.ToString() + " exec LD_Agreement_LoadProgramFees " + _AgreementID.ToString(), Connection.TRConnection);
                                if (Connection.SQLExecutor.Exception != null)
                                    Popup.ShowPopup("Unable to load management fees: " + Connection.SQLExecutor.Exception.Message);

                                //adds any 3rd party purchases from the hold that was entered from the web.
                                Connection.SQLExecutor.ExecuteNonQuery("exec LD_Agreement_LoadHold_3PartyPurchasers " + _AgreementID, Connection.TRConnection);
                                
                                //set every additional date as changed
                                dt.Rows.Add(new object[] { 1 });
                                dt.Rows.Add(new object[] { 2 });
                                dt.Rows.Add(new object[] { 3 });
                                dt.Rows.Add(new object[] { 4 });
                                dt.Rows.Add(new object[] { 5 });
                                dt.Rows.Add(new object[] { 6 });
                                dt.Rows.Add(new object[] { 7 });
                                dt.Rows.Add(new object[] { 8 });
                                dt.Rows.Add(new object[] { 9 });
                            }
                            else
                            {
                                ucMRR.SaveRepetitonRules(_AgreementID);
                                ////deposits should only load from clicking standard terms.
                                //if (Convert.ToBoolean(DRV.Row["LoadedFromSetup"]) && Convert.ToInt32(DRV.Row["agreement_status_id"]) != 6)
                                //    LoadStandardTermsDeposits();
                            }
                        }
                        catch { }
                        AgreeHist.Proj_Lot_ID = _LotID;

                        double dSellPrice = 0;
                        try { dSellPrice = Convert.ToDouble(teActualSellPrice.EditValue); }
                        catch { }

                        if(dSellPrice != 0)
                            Connection.SQLExecutor.ExecuteNonQuery("Update PROJ_LOT set current_price = " + dSellPrice.ToString() + " where proj_lot_id = " + _LotID.ToString(), Connection.TRConnection);

                        //now that everything is updated set the additional dates(key date changes)
                        foreach (DataRow row in dt.Rows)
                        {
                            AdditionalDateChanged(Convert.ToInt32(row["ID"]), true);
                        }
                        CheckAgreements();
                        LoadLot(_LotID, _PriID);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                BindingContext[ds_proj_lot_agreement1, "PROJ_LOT_AGREEMENT"].CancelCurrentEdit();
                ds_proj_lot_agreement1.RejectChanges();
                if (ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows.Count == 0)
                    SetControlsReadOnly(true);
                else if (_AgreementID == -1)
                {
                   _AgreementID = Convert.ToInt32(ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows[0]["agreement_id"]);
                   Attachments.AgreementID = _AgreementID;
                }
                LoadRepRules();

                if(_bCreatingNew)//Refresh Agreements
                    AgreeHist.Proj_Lot_ID = _LotID;

                _bCreatingNew = false;

                CheckAgreements();
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = true;

                object oStatus = Connection.SQLExecutor.ExecuteScalar("Select agreement_status_id From PROJ_LOT_AGREEMENT where agreement_id = " + _AgreementID.ToString(), Connection.TRConnection);
                int iStatusID = -1;
                try { iStatusID = Convert.ToInt32(oStatus); }
                catch { }

                oStatus = Connection.SQLExecutor.ExecuteScalar("select count(*) from SO_TRN_HDR where isnull(BALANCE,0) <> 0 and agreement_id = " + _AgreementID.ToString(), Connection.TRConnection);
                int OSARCount = 0;
                try { OSARCount = Convert.ToInt32(oStatus); }
                catch { }

                oStatus = Connection.SQLExecutor.ExecuteScalar("select COUNT(*) from AR_DEPOSIT where isnull(BALANCE,0) <> 0 and agreement_id = " + _AgreementID.ToString(), Connection.TRConnection);
                int OSDeposit = 0;
                try { OSDeposit = Convert.ToInt32(oStatus); }
                catch { }

                if (iStatusID != 1)
                {
                    Popup.ShowPopup("Agreement status must be active in order to cancel.");
                    return;
                }
                else if (OSARCount > 0)
                {
                    Popup.ShowPopup("Agreement has outstanding AR and can not be canceled.");
                    return;
                }
                else if (OSDeposit > 0)
                {
                    Popup.ShowPopup("Agreement has deposits and can not be canceled.");
                    return;
                }
                else
                {

                    if (Popup.ShowPopup("Are you sure you wish to cancel this agreement?", frmPopup.PopupType.Yes_No) != frmPopup.PopupResult.Yes)
                    {
                        return;
                    }

                    bCancelAgreement = true;
                    BindingContext[ds_proj_lot_agreement1, "PROJ_LOT_AGREEMENT"].CancelCurrentEdit();
                    ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows[0]["agreement_status_id"] = 2;
                    lueStatus.EditValue = 2;
                    dnUnit.Buttons.DoClick(dnUnit.Buttons.EndEdit);
                    Connection.SQLExecutor.ExecuteNonQuery("exec LD_CancelAgreement " + _AgreementID + ", '" + Connection.MLUser + "'", Connection.TRConnection);
                    _IsMasterAgreement = false;
                    _MasterAgreement_ID = -1;

                    
                    bCancelAgreement = false;
                }
            }
        }

        private DataTable CheckForAdditionalDatesChange(DataRowView drv)
        {
            //check the row and see what additional dates have been changed.
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            if (_bCreatingNew || _bLoading) return dt;
            try
            {
                if (drv.Row.HasVersion(DataRowVersion.Original) && drv.Row.HasVersion(DataRowVersion.Current))
                {
                    if (!drv.Row["agreement_date", DataRowVersion.Current].Equals(drv.Row["agreement_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 1 });
                    }
                    if (!drv.Row["closing_date", DataRowVersion.Current].Equals(drv.Row["closing_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 2 });
                    }
                    if (!drv.Row["sale_date", DataRowVersion.Current].Equals(drv.Row["sale_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 3 });
                    }
                    if (!drv.Row["interest_adjustment_date", DataRowVersion.Current].Equals(drv.Row["interest_adjustment_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 4 });
                    }
                    if (!drv.Row["arrears_interest_date", DataRowVersion.Current].Equals(drv.Row["arrears_interest_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 5 });
                    }
                    if (!drv.Row["payout_date", DataRowVersion.Current].Equals(drv.Row["payout_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 6 });
                    }
                    if (!drv.Row["original_arrears_date", DataRowVersion.Current].Equals(drv.Row["original_arrears_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 7 });
                    }
                    if (!drv.Row["estimated_release_date", DataRowVersion.Current].Equals(drv.Row["estimated_release_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 8 });
                    }
                    if (!drv.Row["actual_release_date", DataRowVersion.Current].Equals(drv.Row["actual_release_date", DataRowVersion.Original]))
                    {
                        dt.Rows.Add(new object[] { 9 });
                    }
                }
            }
            catch { }
            return dt;
        }

        private void LoadAdditionalDatesFromProject(bool ReFill)
        {
            Connection.SQLExecutor.ExecuteNonQuery("exec LD_AgreeAdditionalDateLoad " + _AgreementID + "," + _PriID, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error loading Additional Dates From project");
            if (ReFill)
            {
                ds_AgreeAdditionalDates1.Clear();
                da_AgreeAdditionalDates.Fill(ds_AgreeAdditionalDates1);
            }
        }

        private void SetDefaults(DataRow row)
        {
            //*****Update procedure [LD_laa_AgreementEdit_Fill]**** for any new defaults

            row["pri_id"] = _PriID;
            row["proj_lot_id"] = _LotID;
            row["agreement_num"] = Connection.SQLExecutor.ExecuteScalar("select isnull( (select MAX(agreement_num)+1 from PROJ_LOT_AGREEMENT),1)",Connection.TRConnection);
            row["sales_type_id"] = 2;// No Presale
            row["proj_lot_id"] = _LotID;
            row["agreement_date"] = DateTime.Now.Date;
            row["closing_date"] = DBNull.Value;
            row["sale_date"] = DateTime.Now.Date;
            row["interest_adjustment_date"] = DBNull.Value;
            row["arrears_interest_date"] = DBNull.Value;
            row["payout_date"] = DBNull.Value;
            row["original_arrears_date"] = DBNull.Value;
            row["assumeddate"] = DBNull.Value;
            row["r_rate_type_id"] = row["a_rate_type_id"] = 1;// Fixed
            row["r_rate_based_on_id"] = row["a_rate_based_on_id"] = 1; // 1st
            row["r_frequency_id"] = row["a_frequency_id"] = 3;// Annual
            row["r_min_interest"] = row["a_min_interest"] = 0;
            row["r_interest_rate"] = row["a_interest_rate"] = 0;
            row["r_max_interest"] = row["a_max_interest"] = 0;
            row["LoadedFromSetup"] = false;

            row["sell_price"] = Connection.SQLExecutor.ExecuteScalar("Select IsNull((Select IsNull(current_price,0) From PROJ_LOT where proj_lot_id = " + _LotID.ToString() + "),0)", Connection.TRConnection); ;
            row["sales_deposit"] = 0;
            row["down_payment"] = 0;
            row["damage_deposit"] = 0;
            row["discount_pct"] = 0;
            row["discount_amt"] = 0;
            row["penalty_pct"] = 0;
            row["penalty_amt"] = 0;
            row["ProbationLot"] = false;
            row["TransferRequested"] = false;
            row["TransferConfirmed"] = false;
            row["CollectionReminderSent"] = false;

            
            DataTable dtTPP = Connection.SQLExecutor.ExecuteDataAdapter("exec LD_AgreementGetApprovedTPP " + _LotID, Connection.TRConnection);
            if (dtTPP != null)
            {
                if (dtTPP.Rows.Count > 0)
                {
                    DataRow dr = dtTPP.Rows[0];
                    if (dr != null)
                    {
                        row["purchaser_type_id"] = dr["purchaser_type_id"];
                        row["purchaser_id"] = dr["purchaser_id"];
                        row["homebuilder_id"] = dr["homebuilder_id"];
                        row["Third_Party_Purchase"] = dr["Third_Party_Purchase"];
                        row["Third_Party_Purchase_Date"] = dr["Third_Party_Purchase_Date"];
                        row["model_desc"] = dr["model_desc"];
                        row["elevation"] = dr["elevation"];
                        row["SpecHome"] = dr["SpecHome"];
                        row["Builder_Models_ID"] = dr["Builder_Models_ID"];
                        row["thrird_party_purchaser_id"] = dr["thrird_party_purchaser_id"];
                        row["thrird_party_purchaser2_id"] = dr["thrird_party_purchaser2_id"];
                        row["thrird_party_purchaser3_id"] = dr["thrird_party_purchaser3_id"];
                        row["thrird_party_purchaser4_id"] = dr["thrird_party_purchaser4_id"];
                        row["thrird_party_purchaser5_id"] = dr["thrird_party_purchaser5_id"];
                        row["thrird_party_purchaser6_id"] = dr["thrird_party_purchaser6_id"];
                    }
                }
            }
            //*****Update procedure [LD_laa_AgreementEdit_Fill]**** for any new defaults
            ds3Purchaser.Clear();
            da3Purchaser.Fill(ds3Purchaser);
        }

        private bool isValid(DataRow row)
        {
            //*****Update LD_LotAgreementAssistant.ucLotAgreement with any new validation
            if (luePurchaserType.EditValue == null || luePurchaserType.EditValue == DBNull.Value)
            {
                Popup.ShowPopup("Purchaser type is required.");
                return false;
            }
            else if (luePurchaser1.EditValue == null || luePurchaser1.EditValue == DBNull.Value)
            {
                Popup.ShowPopup("Primary Purchaser is required.");
                return false;
            }
            if (lueAssumedPurchaser.Text == "" && deAssumedDate.Text != "")
            {
                Popup.ShowPopup("Assumed Purchaser is required when assumed Date has been set.");
                return false;
            }
            if (lueAssumedPurchaser.Text != "" && deAssumedDate.Text == "")
            {
                Popup.ShowPopup("Assumed Date is required when assumed purchaser has been set.");
                return false;
            }

            string sPur1 = luePurchaser1.EditValue.ToString();
            string sPur2 = "null";
            if (luePurchaser2.EditValue != null && luePurchaser2.EditValue != DBNull.Value)
                sPur2 = luePurchaser2.EditValue.ToString();
            string sPur3 = "null";
            if (luePurchaser3.EditValue != null && luePurchaser3.EditValue != DBNull.Value)
                sPur3 = luePurchaser3.EditValue.ToString();

            


            int agreeNum = PurchaserOnOtherAgreement(Convert.ToInt32(sPur1), deSaleDate.DateTime, _AgreementID);
            if (agreeNum != -1)
            {
                Popup.ShowPopup(luePurchaser1.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                return false;
            }
            if (sPur2 != "null")
            {
                agreeNum = PurchaserOnOtherAgreement(Convert.ToInt32(sPur2), deSaleDate.DateTime, _AgreementID);
                if (agreeNum != -1)
                {
                    Popup.ShowPopup(luePurchaser2.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                    return false;
                }
            }
            if (sPur3 != "null")
            {
                agreeNum = PurchaserOnOtherAgreement(Convert.ToInt32(sPur3), deSaleDate.DateTime, _AgreementID);
                if (agreeNum != -1)
                {
                    Popup.ShowPopup(luePurchaser3.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                    return false;
                }
            }



            if (deHOADate.EditValue != DBNull.Value)
            {
                if (deHOADate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    Popup.ShowPopup("HOA date can not be prior to agreement date.");
                    return false;
                }
            }

            if (deSpecHomeStartDate.EditValue != DBNull.Value)
            {
                if (deSpecHomeStartDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    Popup.ShowPopup("Spec home start date can not be prior to agreement date.");
                    return false;
                }
            }

            if (deShowHomeStartDate.EditValue != DBNull.Value)
            {
                if (deShowHomeStartDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    Popup.ShowPopup("Show home start date can not be prior to agreement date.");
                    return false;
                }
                else if (deShowHomeCloseDate.EditValue != DBNull.Value)
                {
                    if (deShowHomeStartDate.DateTime.CompareTo(deShowHomeCloseDate.DateTime) > 0)
                    {
                        Popup.ShowPopup("Show home close date can not be prior to show home start date.");
                        return false;
                    }
                }
            }

            if (deShowHomeCloseDate.EditValue != DBNull.Value)
            {
                if (deShowHomeCloseDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    Popup.ShowPopup("Show home close date can not be prior to agreement date.");
                    return false;
                }
            }

            if (deAssumedDate.EditValue != DBNull.Value)
            {
                if (deAssumedDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    Popup.ShowPopup("Assumed date can not be prior to agreement date.");
                    return false;
                }
            }

            string sSQL = "exec LD_Agreement_ValidateReservation " + _LotID + ", " + sPur1 + ", " + sPur2 + ", " + sPur3;
            object oResult = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (oResult != null && oResult != DBNull.Value)
            {
                if (!oResult.ToString().Equals("OK"))
                {
                    Popup.ShowPopup(oResult.ToString());
                    return false;
                }
            }
            else
            {
                Popup.ShowPopup("Error validating lot reservation.");
                return false;
            }

            //3rd Party Purchaser
            bool b3PartyValid = true;
            bool bModel = true;
            bool bElevation = true;
            bool bHomebuilder = true;
            if (lueModel.EditValue == null || lueModel.EditValue == DBNull.Value)
                bModel = false;
            if (lueElevation.EditValue == null || lueElevation.EditValue == DBNull.Value)
                bElevation = false;
            if (lueHomeBuilder.EditValue == null || lueHomeBuilder.EditValue == DBNull.Value)
                bHomebuilder = false;

            if (bModel)
            {
                if (bElevation)
                {
                    if (!bHomebuilder)
                        b3PartyValid = false;
                }
                else
                    b3PartyValid = false;
            }
            else if (bElevation)
                b3PartyValid = false;
            else if (bHomebuilder)
                b3PartyValid = false;

            if (!b3PartyValid)
            {
                //Popup.ShowPopup("3rd Party Purchaser Info requires the Model, Elevation and Homebuilder to be set.");
                //return false;
                row["builder_models_id"] = DBNull.Value;
            }
            else
            {
                object obj = null;
                if (lueModel.EditValue != null && lueModel.EditValue != DBNull.Value && lueElevation.EditValue != null && lueElevation.EditValue != DBNull.Value && lueHomeBuilder.EditValue != null && lueHomeBuilder.EditValue != DBNull.Value)
                {
                    string sSelect = "select builder_models_id from LD_Builder_Models where Description='" + lueModel.EditValue + "' and Elevation='" + lueElevation.EditValue + "' and customer_id=" + lueHomeBuilder.EditValue;
                    obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                }
                row.BeginEdit();
                if( obj == null )
                    obj = DBNull.Value;
                row["builder_models_id"] = obj;
            }

            if (!ucMRR.ModelRepRulesValid())
            {
                tcThirdPartyPurchaser.SelectedTabPage = tpRepRules;
                Popup.ShowPopup("All of the repetition rules are required to be filled out for the selected model.");
                return false;
            }

            if (!isGreaterThenZero(teDiscountPct.EditValue, true))
            {
                Popup.ShowPopup("Discount percent must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teDiscountPct.EditValue) > 100)
            {
                Popup.ShowPopup("Discount percent must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(tePenaltyPct.EditValue, true))
            {
                Popup.ShowPopup("Penalty percent must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(tePenaltyPct.EditValue) > 100)
            {
                Popup.ShowPopup("Penalty percent must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRMinIR.EditValue, true))
            {
                Popup.ShowPopup("Min Regular Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRMinIR.EditValue) > 100)
            {
                Popup.ShowPopup("Min Regular Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRIRS.EditValue, true))
            {
                Popup.ShowPopup("Regular Interest Rate / Spread must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRIRS.EditValue) > 100)
            {
                Popup.ShowPopup("Regular Interest Rate / Spread must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRMaxIR.EditValue, true))
            {
                Popup.ShowPopup("Max Regular Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRMaxIR.EditValue) > 100)
            {
                Popup.ShowPopup("Max Regular Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAMinIR.EditValue, true))
            {
                Popup.ShowPopup("Min Arrears Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAMinIR.EditValue) > 100)
            {
                Popup.ShowPopup("Min Arrears Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAIRS.EditValue, true))
            {
                Popup.ShowPopup("Arrears Interest Rate / Spread must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAIRS.EditValue) > 100)
            {
                Popup.ShowPopup("Arrears Interest Rate / Spread must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAMaxIR.EditValue, true))
            {
                Popup.ShowPopup("Max Arrears Interest Rate must be greater or equal to then zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAMaxIR.EditValue) > 100)
            {
                Popup.ShowPopup("Max Arrears Interest Rate must be less then or equal to 100.");
                return false;
            }

            if (!isGreaterThenZero(teDiscountAmt.EditValue, true))
            {
                Popup.ShowPopup("Discount amount must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teDiscountAmt.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Discount amount is too large.");
                return false;
            }


            if (!isGreaterThenZero(tePen.EditValue, true))
            {
                Popup.ShowPopup("Penalty amount must be greater then or equal to zero.");
                return false;
            }
            else if( Convert.ToDecimal(tePen.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Penalty amount is too large.");
                return false;
            }

            if (!isGreaterThenZero(teActualSellPrice.EditValue, true))
            {
                Popup.ShowPopup("Actual Sell Price must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teActualSellPrice.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Actual Sell Price is too large.");
                return false;
            }


            if (!isGreaterThenZero(teActualDownPayment.EditValue, true))
            {
                Popup.ShowPopup("Actual Down Payment must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teActualDownPayment.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Actual Down Payment is too large.");
                return false;
            }

            if (Convert.ToDouble(teActualSellPrice.EditValue).CompareTo(Convert.ToDouble(teActualDownPayment.EditValue)) < 0)
            {
                Popup.ShowPopup("Actual Down Payment must be less then Actual Sell Price.");
                return false;
            }
            
            
            if (!isGreaterThenZero(txtHOAAmt.EditValue, true))
            {
                Popup.ShowPopup("HOA Amount must be greater then or equal to zero.");
                return false;
            }
            else if (txtHOAAmt.EditValue != DBNull.Value && Convert.ToDecimal(txtHOAAmt.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("HOA Amount is too large.");
                return false;
            }

            object result = Connection.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Primary purchaser is on probation and temporarily removed.' 	when Probation = 1 then 'Primary purchaser is on probation.' when Temp_Removed = 1 then 'Primary purchaser is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur1, Connection.TRConnection);
            string purchaserMessage = "";
            if (result != null && result != DBNull.Value)
                purchaserMessage = result.ToString()+"\r\n";
            result = Connection.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Purchaser 2 is on probation and temporarily removed.' 	when Probation = 1 then 'Purchaser 2 is on probation.' when Temp_Removed = 1 then 'Purchaser 2 is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur2, Connection.TRConnection);
            

            if (result != null && result != DBNull.Value)
                purchaserMessage += result.ToString() + "\r\n";
            result = Connection.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Purchaser 3 is on probation and temporarily removed.' 	when Probation = 1 then 'Purchaser 3 is on probation.' when Temp_Removed = 1 then 'Purchaser 3 is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur3, Connection.TRConnection);

            if (result != null && result != DBNull.Value)
                purchaserMessage += result.ToString() + "\r\n";

            if (purchaserMessage.Replace("\r\n", "").Trim() != "")
                if (Popup.ShowPopup(purchaserMessage + "\r\n" + "Are you sure you want to continue?", WS_Popups.frmPopup.PopupType.Yes_No) != frmPopup.PopupResult.Yes)
                    return false;

           //*****Update LD_LotAgreementAssistant.ucLotAgreement with any new validation
            return true;
        }

        private void Load3rdPartyPurch()
        {
            ds3Builder.Clear();
            ds3Elevation.Clear();
            ds3Model.Clear();

            string sSelect = @"select builder_models_id, model_desc, elevation, homebuilder_id from proj_lot_agreement where agreement_id=" + _AgreementID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            object oBM_ID = DBNull.Value;
            object oMOD = lueModel.EditValue == null ? DBNull.Value : lueModel.EditValue;
            object oELE = lueElevation.EditValue == null ? DBNull.Value : lueElevation.EditValue;
            object oHB_ID = lueHomeBuilder.EditValue == null ? DBNull.Value : lueHomeBuilder.EditValue;


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {

                        oBM_ID = dr[0];
                        oMOD = dr[1];
                        oELE = dr[2];
                        oHB_ID = dr[3];
                    }
                }
            }


            da3Model.SelectCommand.Parameters["@elevation"].Value = oELE;
            da3Model.SelectCommand.Parameters["@builder_id"].Value = oHB_ID;
            da3Model.SelectCommand.Parameters["@builder_models_id"].Value = oBM_ID;
            ds3Model.Clear();
            da3Model.Fill(ds3Model);

            da3Elevation.SelectCommand.Parameters["@Model"].Value = oMOD;
            da3Elevation.SelectCommand.Parameters["@builder_id"].Value = oHB_ID;
            da3Elevation.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
            ds3Elevation.Clear();
            da3Elevation.Fill(ds3Elevation);

            da3Builder.SelectCommand.Parameters["@elevation"].Value = oELE;
            da3Builder.SelectCommand.Parameters["@Model"].Value = oMOD;
            da3Builder.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
            ds3Builder.Clear();
            da3Builder.Fill(ds3Builder);

        }

        private bool _bSetting3rdPP = false;

        private void lueModel_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bSetting3rdPP)
            {
                _bSetting3rdPP = true;
                object obj = lueModel.EditValue;
                if (obj == null)
                    obj = DBNull.Value;

                object oEle = lueElevation.EditValue;
                object oHB = lueHomeBuilder.EditValue;
                if ((oEle == null || oEle == DBNull.Value))                     
                {
                    if (oEle == null)
                        oEle = DBNull.Value;

                    lueElevation.EditValue = DBNull.Value;                    
                    ds3Elevation.Clear();
                }
                if ((oHB == null || oHB == DBNull.Value))
                {
                    if (oHB == null)
                        oHB = DBNull.Value;

                    lueHomeBuilder.EditValue = DBNull.Value;
                    ds3Builder.Clear();                    
                }

                da3Elevation.SelectCommand.Parameters["@Model"].Value = obj;
                da3Elevation.SelectCommand.Parameters["@builder_id"].Value = oHB;
                da3Elevation.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Elevation.Clear();
                da3Elevation.Fill(ds3Elevation);

                da3Builder.SelectCommand.Parameters["@elevation"].Value = oEle;
                da3Builder.SelectCommand.Parameters["@Model"].Value = obj;
                da3Builder.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Builder.Clear(); 
                da3Builder.Fill(ds3Builder);
                _bSetting3rdPP = false;
            }
            LoadRepRules();
        }

        private void lueElevation_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bSetting3rdPP)
            {
                _bSetting3rdPP = true;
                object obj = lueElevation.EditValue; 
                if (obj == null)
                    obj = DBNull.Value;

                object oMod = lueModel.EditValue;
                object oHB = lueHomeBuilder.EditValue;
                if ((oMod == null || oMod == DBNull.Value))                    
                {
                    if (oMod == null)
                        oMod = DBNull.Value;

                    lueModel.EditValue = DBNull.Value;
                    ds3Model.Clear();
                    
                }
                if ((oHB == null || oHB == DBNull.Value))
                {
                    if (oHB == null)
                        oHB = DBNull.Value;
                                        
                    lueHomeBuilder.EditValue = DBNull.Value;
                    ds3Builder.Clear();
                }

                da3Model.SelectCommand.Parameters["@elevation"].Value = obj;
                da3Model.SelectCommand.Parameters["@builder_id"].Value = oHB;
                da3Model.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Model.Clear();
                da3Model.Fill(ds3Model);

                da3Builder.SelectCommand.Parameters["@elevation"].Value = obj;
                da3Builder.SelectCommand.Parameters["@Model"].Value = oMod;
                da3Builder.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Builder.Clear();
                da3Builder.Fill(ds3Builder);
                _bSetting3rdPP = false;
            }
            LoadRepRules();
        }

        private void lueHomeBuilder_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bSetting3rdPP)
            {
                _bSetting3rdPP = true;
                object obj = lueHomeBuilder.EditValue;
                if (obj == null)
                    obj = DBNull.Value;

                object oMod = lueModel.EditValue;
                object oEle = lueElevation.EditValue;
                if ((oMod == null || oMod == DBNull.Value))                    
                {
                    if (oMod == null)
                        oMod = DBNull.Value;

                    lueModel.EditValue = DBNull.Value;                    
                    ds3Model.Clear();                    
                }
                if ((oEle == null || oEle == DBNull.Value))
                {
                    if (oEle == null)
                        oEle = DBNull.Value;

                    lueElevation.EditValue = DBNull.Value;
                    ds3Elevation.Clear();
                }

                da3Model.SelectCommand.Parameters["@elevation"].Value = oEle;
                da3Model.SelectCommand.Parameters["@builder_id"].Value = obj;
                da3Model.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Model.Clear();  
                da3Model.Fill(ds3Model);

                da3Elevation.SelectCommand.Parameters["@Model"].Value = oMod;
                da3Elevation.SelectCommand.Parameters["@builder_id"].Value = obj;
                da3Elevation.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                ds3Elevation.Clear();
                da3Elevation.Fill(ds3Elevation);
                _bSetting3rdPP = false;
            }
            LoadRepRules();
        }

        private void LoadRepRules()
        {
            object oBuilder_ID = lueHomeBuilder.EditValue;
            object oModel = lueModel.EditValue;
            object oElevation = lueElevation.EditValue;

            if (oBuilder_ID == null || oBuilder_ID == DBNull.Value)
                oBuilder_ID = -1;
            if (oModel == null || oModel == DBNull.Value)
                oModel = "";
            if (oElevation == null || oElevation == DBNull.Value)
                oElevation = "";

            string sSQL = @"select Builder_Models_ID 
                from LD_Builder_Models 
                where customer_id=" + oBuilder_ID + @" 
                and Description='" + oModel + @"' 
                and Elevation='" + oElevation + @"'";
            object oBM_ID = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (oBM_ID == null || oBM_ID == DBNull.Value)
                oBM_ID = -1;

            ucMRR.LoadModel(_LotID, Convert.ToInt32(oBM_ID), _AgreementID);
        }

        private bool hasStandartTerms()
        {
            bool returnValue = false;
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value)
            {
                string sql = "select count(*) from LD_Standard_Terms_det where PRI_ID = " + _PriID + @" and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + @"and SALES_TYPE_ID = " + lueSaleType.EditValue;
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting standard terms defaults:");
                else if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) != 0)
                        returnValue = true;
                    else
                        Popup.ShowPopup("No standard term defaults have been setup.");
                }
            }
            else Popup.ShowPopup("Purchaser type is required to load standard terms.");

            return returnValue;

        }
        private void SetStandardTermsDefault()
        {
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                string SQL = @"select REG_LD_RATETYPE_ID,REG_LD_RATE_BASED_ON_ID,REG_LD_FREQUENCY_ID,REG_INTEREST_MIN,REG_INTEREST_SPREAD,REG_INTEREST_MAX, 
                ARR_LD_RATETYPE_ID,ARR_LD_RATE_BASED_ON_ID,ARR_LD_FREQUENCY_ID,ARR_INTEREST_MIN,ARR_INTEREST_SPREAD,ARR_INTEREST_MAX, PRIMESOURCE_LD_LENDER_ID,
                CompoundUponArrears,MONTH_OFFSET_INTEREST,MONTH_OFFSET_MATURITY,standard_terms_det_ID
                from LD_Standard_Terms_det where PRI_ID = " + _PriID + @" and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + @"and SALES_TYPE_ID = " + lueSaleType.EditValue;

                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(SQL, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting standard terms defaults:");
                else if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        lueRBasedOn.EditValue = row["REG_LD_RATE_BASED_ON_ID"];
                        lueRCompFreq.EditValue = row["REG_LD_FREQUENCY_ID"];
                        lueRRateType.EditValue = row["REG_LD_RATETYPE_ID"];
                        txtRMinIR.EditValue = row["REG_INTEREST_MIN"];
                        txtRMaxIR.EditValue = row["REG_INTEREST_MAX"];
                        txtRIRS.EditValue = row["REG_INTEREST_SPREAD"];

                        lueABasedOn.EditValue = row["ARR_LD_RATE_BASED_ON_ID"];
                        lueACompFreq.EditValue = row["ARR_LD_FREQUENCY_ID"];
                        lueARateType.EditValue = row["ARR_LD_RATETYPE_ID"];
                        txtAMaxIR.EditValue = row["ARR_INTEREST_MAX"];
                        txtAMinIR.EditValue = row["ARR_INTEREST_MIN"];
                        txtAIRS.EditValue = row["ARR_INTEREST_SPREAD"];

                        luePrimeSource.EditValue = row["PRIMESOURCE_LD_LENDER_ID"];
                        ceCompoundOnArrears.EditValue = row["CompoundUponArrears"];

                        if (Overwrite)
                        {

                            if (!HasOffsetDate(4))//if there is no offset date use the standard terms default.
                            {
                                if (row["MONTH_OFFSET_INTEREST"] != DBNull.Value && row["MONTH_OFFSET_INTEREST"] != null)
                                    deIntAdjDate.EditValue = deSaleDate.DateTime.AddMonths(Convert.ToInt32(row["MONTH_OFFSET_INTEREST"]));
                                else
                                    deIntAdjDate.EditValue = deSaleDate.EditValue;
                            }

                            if (!HasOffsetDate(5))//if there is no offset date use the standard terms default.
                            {
                                if (row["MONTH_OFFSET_MATURITY"] != DBNull.Value && row["MONTH_OFFSET_MATURITY"] != null)
                                    deArrIntDate.EditValue = deOrgArrDate.EditValue = deSaleDate.DateTime.AddMonths(Convert.ToInt32(row["MONTH_OFFSET_MATURITY"]));
                                else
                                    deArrIntDate.EditValue = deOrgArrDate.EditValue = deSaleDate.EditValue;
                            }
                        }

                        SQL = "select STANDARD_TERMS_DET_ID " +
                "from LD_Standard_Terms_det where PRI_ID = " + _PriID + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + "and SALES_TYPE_ID = " + lueSaleType.EditValue;

                        object result = Connection.SQLExecutor.ExecuteScalar(SQL, Connection.TRConnection);
                        if (Connection.SQLExecutor.Exception != null)
                            Popup.ShowPopup("Error setting standard terms deposits:");
                        else if (result != null && result != DBNull.Value)
                        {
                            double value = 0;
                            try
                            {
                                value = Convert.ToDouble(teActualSellPrice.Text);
                            }
                            catch { }

                            LoadActualDownPayment(value, result);
                        }

                        bs_proj_lot_agreement.CurrencyManager.EndCurrentEdit();
                        ((DataRowView)bs_proj_lot_agreement.Current).Row["LoadedFromSetup"] = true;
                        ((DataRowView)bs_proj_lot_agreement.Current).Row["ld_standard_terms_det_ID"] = row["standard_terms_det_ID"];
                        //ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows[0]["LoadedFromSetup"] = true;
                        //Popup.ShowPopup("Defaults Loaded.");
                    }
                    else
                        Popup.ShowPopup("No standard term defaults have been found.");
                }
            }
        }

        private bool HasOffsetDate(int AddDateID)
        {
            bool returnValue = true;
            string sql = "select OffsetDate_ID from  LD_Proj_Agreement_AddDates " +
                " where Agreement_ID = " + _AgreementID + " and AdditionalDates_ID = " + AddDateID.ToString();
            object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for offset date." + Connection.SQLExecutor.Exception.Message);
            else
            {
                if (result == null || result == DBNull.Value)
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }


        private void LoadStandardTermsDeposits()
        {
            // DEPOSITS
            bool bLoadStdDeposits = false;
            if (gvDeposits.RowCount > 0)
            {
                frmPopup.PopupResult pResult = Popup.ShowPopup("Deposits exist for this agreement, would you like to replace them with the standard terms deposits?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    string sSQL = @"delete from PROJ_LOT_AGREEMENT_DEPOSITS where agreement_id=" + _AgreementID;
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                    ds_deposits1.Clear();
                    da_deposits.Fill(ds_deposits1);
                    bLoadStdDeposits = true;
                }
                else if (pResult == frmPopup.PopupResult.No)
                {
                    bLoadStdDeposits = false;
                }
                else 
                    return;
            }
            else
            {
                bLoadStdDeposits = true;
            }
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                string SQL = "select STANDARD_TERMS_DET_ID " +
                "from LD_Standard_Terms_det where PRI_ID = " + _PriID + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + "and SALES_TYPE_ID = " + lueSaleType.EditValue;

                object oSTANDARD_TERMS_DET_ID = Connection.SQLExecutor.ExecuteScalar(SQL, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting standard terms deposits:");
                else if (oSTANDARD_TERMS_DET_ID != null && oSTANDARD_TERMS_DET_ID != DBNull.Value)
                {
                    double value = 0;
                    try
                    {
                        value = Convert.ToDouble(teActualSellPrice.Text);
                    }
                    catch { }

                    if (bLoadStdDeposits)
                    {
                        SQL = @"select case when isnull(DepositType,'A') = 'A' then AmountPercent else " + value + @" * AmountPercent / 100 end, LD_Deposits_ID, off_set_days, ID ,presaleseq
                            from LD_Standard_Terms_Deposits_Det 
                            where LD_StandardTerms_Det_ID = " + oSTANDARD_TERMS_DET_ID;
                        DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(SQL, Connection.TRConnection);
                        if (Connection.SQLExecutor.Exception != null)
                            Popup.ShowPopup("Error setting standard terms defaults:" + SQL);
                        else if (dt != null)
                        {
                            int count = -1;
                            foreach (DataRow row in dt.Rows)
                            {
                                ds_deposits1.PROJ_LOT_AGREEMENT_DEPOSITS.Rows.Add(
                                    new object[] { count, _AgreementID, row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4] });
                                count -= 1;
                            }
                            da_deposits.Update(ds_deposits1);
                        }
                        string sSQL = @"exec LD_CalcDownPayment " + oSTANDARD_TERMS_DET_ID + @", " + _AgreementID + @", " + value;
                        object oResult = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                        if (oResult == null || oResult == DBNull.Value)
                            oResult = 0;
                        teActualDownPayment.EditValue = Convert.ToDouble(oResult);
                    }
                }                
            }


            // LEVIES
            bool bLoadStdLevies = false;
            if (gvLevy.RowCount > 0)
            {
                frmPopup.PopupResult pResult = Popup.ShowPopup("Levies exist for this agreement, would you like to replace them with the standard terms levies?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    string sSQL = @"delete l 
                        from PROJ_LOT_AGREEMENT_LEVY l
                        where isnull(l.matched,0) = 0 and l.agreement_id=" + _AgreementID;
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                    dsAgreeLevy.Clear();
                    bLoadStdLevies = true;
                }
                else if (pResult == frmPopup.PopupResult.No)
                {
                    bLoadStdLevies = false;
                }
                else
                    return;
            }
            else
            {
                bLoadStdLevies = true;
            }
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                string SQL = "select STANDARD_TERMS_DET_ID " +
                "from LD_Standard_Terms_det where PRI_ID = " + _PriID + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + "and SALES_TYPE_ID = " + lueSaleType.EditValue;

                object oSTANDARD_TERMS_DET_ID = Connection.SQLExecutor.ExecuteScalar(SQL, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting standard terms deposits:");
                else if (oSTANDARD_TERMS_DET_ID != null && oSTANDARD_TERMS_DET_ID != DBNull.Value)
                {
                    if (bLoadStdLevies)
                    {                        
                        string sSQL = @"declare @lot_class_id int, @agreement_id int

                            select @agreement_id = " + _AgreementID + @"

                            select @lot_class_id=l.lot_class_id
                            from PROJ_LOT_AGREEMENT a 
                            join PROJ_LOT l on l.proj_lot_id=a.proj_lot_id
                            where a.agreement_id=@agreement_id

                            insert into PROJ_LOT_AGREEMENT_LEVY (agreement_id, LD_Levy_ID, lv1id, lv2id, lv3id, lv4id, Amount, Supplier_ID)
                            select @agreement_id, LD_Levy_ID, lv1id, lv2id, lv3id, lv4id, Amount, Supplier_ID
                            from LD_Standard_Terms_Levy_Det
                            where isnull(amount,0) > 0 and isnull(lot_class_id,-1) in (-1, @lot_class_id) and LD_StandardTerms_Det_ID=" + oSTANDARD_TERMS_DET_ID;
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                        LoadLevies(_AgreementID);
                    }
                }
            }

            //Discounts
            bool bLoadStdDiscounts = false;
            if (gvDiscounts.RowCount > 0)
            {
                frmPopup.PopupResult pResult = Popup.ShowPopup("Discounts exist for this agreement, would you like to replace them with the standard terms discounts?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    string sSQL = @"delete l 
                        from PROJ_LOT_AGREEMENT_DISCOUNTS l
                        where l.invoice_id IS NULL and l.agreement_id=" + _AgreementID;
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                    dsAgreeLevy.Clear();
                    bLoadStdDiscounts = true;
                }
                else if (pResult == frmPopup.PopupResult.No)
                {
                    bLoadStdDiscounts = false;
                }
                else
                    return;
            }
            else
            {
                bLoadStdDiscounts = true;
            }
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                string SQL = "select STANDARD_TERMS_DET_ID " +
                "from LD_Standard_Terms_det where PRI_ID = " + _PriID + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + "and SALES_TYPE_ID = " + lueSaleType.EditValue;

                object oSTANDARD_TERMS_DET_ID = Connection.SQLExecutor.ExecuteScalar(SQL, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting standard terms discounts:");
                else if (oSTANDARD_TERMS_DET_ID != null && oSTANDARD_TERMS_DET_ID != DBNull.Value)
                {
                    if (bLoadStdDiscounts)
                    {
                        string sSQL = @"declare @lot_class_id int, @agreement_id int

                            select @agreement_id = " + _AgreementID + @"

                            select @lot_class_id=l.lot_class_id
                            from PROJ_LOT_AGREEMENT a 
                            join PROJ_LOT l on l.proj_lot_id=a.proj_lot_id
                            where a.agreement_id=@agreement_id

                            insert into PROJ_LOT_AGREEMENT_DISCOUNTS (agreement_id,LD_Discounts_ID,type,value,processed )
                            select @agreement_id, d.LD_Discounts_ID,d.Type,d.Value,0
                            from LD_Standard_Terms_Discounts_Det d
                            where d.LD_Standard_Terms_Det_ID=" + oSTANDARD_TERMS_DET_ID;
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                        dsAgreeDiscounts1.Clear();
                        daAgreeDiscounts.Fill(dsAgreeDiscounts1);
                    }
                }
            }
        }

        private void LoadActualDownPayment(double dSaleAmount, object oStd_Terms_Det_ID)
        {
            string sSQL = @"exec LD_CalcDownPayment " + oStd_Terms_Det_ID + @", "+_AgreementID+@", " + dSaleAmount;
            object oResult = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (oResult == null || oResult == DBNull.Value)
                oResult = 0;
            teActualDownPayment.EditValue = Convert.ToDouble(oResult);
            bs_proj_lot_agreement.CurrencyManager.EndCurrentEdit();
        }

        private void luePurchaserType_EditValueChanged(object sender, EventArgs e)
        {
            dsPurchaser.Clear();
            if (!_bLoading)
            {
                luePurchaser1.EditValue = null;
                luePurchaser2.EditValue = null;
                luePurchaser3.EditValue = null;
                lueAssumedPurchaser.EditValue = null;
                deAssumedDate.EditValue = DBNull.Value;
            }

            object oPT = luePurchaserType.EditValue;
            if (oPT != null && oPT != DBNull.Value)
            {
                daPurchaser.SelectCommand.Parameters["@purchaser_type_id"].Value = oPT;
                daPurchaser.Fill(dsPurchaser);
            }

            int iPT = -1;
            try { iPT = Convert.ToInt32(oPT); }
            catch { }

            if (!_ReadOnly && !luePurchaserType.Properties.ReadOnly)
            {
                lueAssumedPurchaser.Properties.ReadOnly = !(iPT == 3 || iPT == 1);
                lueAssumedPurchaser.Properties.Buttons[1].Enabled = !lueAssumedPurchaser.Properties.ReadOnly;
                deAssumedDate.Properties.ReadOnly = lueAssumedPurchaser.Properties.ReadOnly;
                deAssumedDate.Properties.Buttons[1].Enabled = !deAssumedDate.Properties.ReadOnly;
            }
            Load3rdPartyPurch();
        }

        private void btnLoadFrom_Click(object sender, EventArgs e)
        {

            string sql = @"select count(*)
from PROJ_LOT_AGREEMENT a
join PROJ_LOT l on l.proj_lot_id = a.proj_lot_id
join LD_Standard_Terms_Det s on s.PRI_ID = a.pri_id and s.PURCHASER_TYPE_ID = a.purchaser_type_id
join LD_Standard_Terms_Levy_Det d on d.LD_StandardTerms_Det_ID = s.STANDARD_TERMS_DET_ID and d.lot_class_id = l.lot_class_id
where amount = 0 and a.agreement_id = "+_AgreementID;
            Object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error :" + Connection.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    if (Popup.ShowPopup("There are levy's setup on the project that have an amount of zero and will not be loaded\r\n Are you sure you want to continue?.", WS_Popups.frmPopup.PopupType.Yes_No) != frmPopup.PopupResult.Yes)
                        return;
                }
            }


            Overwrite = false;
            SettingFromStandardTerms = true;
            if (ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows.Count == 0)
                Popup.ShowPopup("You must save this agreement to load standard terms");
            else if(ds_proj_lot_agreement1.PROJ_LOT_AGREEMENT.Rows[0].RowState == DataRowState.Added)
                Popup.ShowPopup("You must save this agreement to load standard terms");
            else
            {

                if (hasStandartTerms())
                {
                    object oDRV = bs_proj_lot_agreement.Current;
                    if (oDRV != null)
                    {
                        DataRowView DRV = oDRV as DataRowView;
                        if (isValid(DRV.Row))
                        {
                            if (ShowDatePopup())
                            {
                                SetStandardTermsDefault();
                                if (_AgreementID != -1)
                                    LoadStandardTermsDeposits();
                                dnUnit.Buttons.DoClick(dnUnit.Buttons.EndEdit);
                                Popup.ShowPopup("Defaults Loaded.");
                            }
                        }
                    }

                    
                }
            }
            SettingFromStandardTerms = false;
        }

        private bool ShowDatePopup()
        {
            bool returnValue = false;
            using (frmAgreementDateSelection frm = new frmAgreementDateSelection(Connection, DevXMgr,_LotID))
            {
                
                if (Popup.ShowPopup("Would you like to overwrite existing dates?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                {
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        Overwrite = true;
                        deAgreeDate.EditValue = DBNull.Value;
                        deSaleDate.EditValue = DBNull.Value;
                        deClosingDate.EditValue = DBNull.Value;
                        deIntAdjDate.EditValue = DBNull.Value;
                        deArrIntDate.EditValue = DBNull.Value;
                        deExpPayDate.EditValue = DBNull.Value;
                        deOrgArrDate.EditValue = DBNull.Value;
                        deEstReleaseDate.EditValue = DBNull.Value;
                        deActualReleaseDate.EditValue = DBNull.Value;
                        

                        returnValue = true;
                        deAgreeDate.EditValue = frm.deAgreementDate.EditValue;
                        deSaleDate.EditValue = frm.deSaleDate.EditValue;

                        bs_proj_lot_agreement.EndEdit();
                        da_proj_lot_agreement.Update(ds_proj_lot_agreement1);


                        AdditionalDateChanged(1, true);
                        AdditionalDateChanged(3, true);

                        //force a refresh as key dates may of been changed.
                        AgreeHist.Proj_Lot_ID = _LotID;


                        teActualSellPrice.EditValue = frm.seSellPrice.EditValue;

                    }
                }
                else
                    returnValue = false;//dont load standard terms

            }

            return returnValue;
        }

        private void btnSharepoint_Click(object sender, EventArgs e)
        {
            if (_AgreementID != -1)
            {
                using (SharePointMgr.frmSharePointMgr SharePointManager = new SharePointMgr.frmSharePointMgr(Connection, DevXMgr, "PC Lot Agreement", "Lot Agreement", "", "Agreement", _AgreementID))
                {
                    SharePointManager.ReadOnly = _ReadOnly;
                    SharePointManager.ShowDialog();
                    SharePointManager.Dispose();
                    SharePointMgr.cSharePointMgr.UpdateButton(Connection, "PC Lot Agreement", ref btnSharepoint, "Agreement", _AgreementID);
                }
            }
        }

        private void gcDeposits_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (_AgreementID == -1)
                {
                    Popup.ShowPopup("You must save the agreement record prior to adding a deposit.");
                    e.Handled = true;
                }            
            }
        }

        private void gvDeposits_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;

            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { coldeposit_id, coldeposit_amt, coloff_set_days,  }, false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[coldeposit_amt.FieldName], false))
            {
                Popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (DepositGreaterThenSellPrice(((DataRowView)e.Row)))
            {
                Popup.ShowPopup("Total deposits can not be greater then sell price.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (isPreSaleSeqInvalid((DataRowView)e.Row))
            {
                Popup.ShowPopup("Pre-sale sequence must be between 1 and 10.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }

        }

        private bool isPreSaleSeqInvalid(DataRowView drv)
        {
            bool returnValue = false;
            if (isTierPresale)
            {
                if (ds_lueDepositTyeps1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(drv[coldeposit_id.FieldName])).Type == "P")
                {
                    int PresaleSeq = -1;
                    try
                    {
                        PresaleSeq = Convert.ToInt32(drv[colPresaleSeq.FieldName]);
                    }
                    catch {}
                    if (PresaleSeq > 10 || PresaleSeq < 1)
                        returnValue = true;
                }
                
            }


            return returnValue;
        }

        private bool DepositGreaterThenSellPrice(DataRowView view)
        {
            bool returnValue = false;

            if( Convert.ToDouble(view[coldeposit_amt.FieldName].ToString()) > Convert.ToDouble( teActualSellPrice.Text.ToString() ) )
            {//if there is only one record the sql below will return nothing...
                returnValue = true;
            }
            else
            {
                string sql = @"select a.sell_price -isnull( (select SUM(deposit_amt) +" + view[coldeposit_amt.FieldName].ToString() + " from PROJ_LOT_AGREEMENT_DEPOSITS d where d.agreement_id = a.agreement_id and d.id <> " + view[colid.FieldName].ToString() + " ) ,0) " +
                    "from PROJ_LOT_AGREEMENT a where a.agreement_id ="+_AgreementID;
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToDouble(result) < 0)
                        returnValue = true;
                }
            }

            return returnValue;
        }
        private string ValidateColumnsRequired(DataRowView RowView, DevExpress.XtraGrid.Columns.GridColumn[] gridColumns, bool multiLine)
        {
            string returnValue = "";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridColumns)
            {
                bool Process = false;
                if (RowView[col.FieldName] == DBNull.Value || RowView[col.FieldName] == null)
                {
                    Process = true;
                }
                else if (RowView[col.FieldName].ToString().Trim() == "")
                {
                    Process = true;
                }
                if (Process)
                {

                    returnValue += GetColumnsCaption(col) + " is required.";
                    if (!multiLine)
                        break;
                    else
                        returnValue += "\r\n";
                }
            }
            return returnValue;
        }
        private string GetColumnsCaption(DevExpress.XtraGrid.Columns.GridColumn col)
        {
            StringBuilder newText = new StringBuilder();
            if (col.Caption.ToString().Trim() == "")
            {
                if (string.IsNullOrEmpty(col.FieldName))
                    return "";

                newText.Append(col.FieldName[0]);
                for (int i = 1; i < col.FieldName.Length; i++)
                {
                    if (char.IsUpper(col.FieldName[i]))
                        newText.Append(' ');
                    newText.Append(col.FieldName[i]);
                }
            }
            else
                newText.Append(col.Caption);


            return newText.ToString();
        }

        private bool isGreaterThenZero(object Value, bool AllowEqual)
        {
            double dValue = 0;
            try
            {
                dValue = Convert.ToDouble(Value);
            }
            catch { }

            if (dValue > 0)
                return true;
            else if (dValue == 0 && AllowEqual)
                return true;
            else
                return false;
        }

        private void gvDeposits_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void ri_lueDeposists_EditValueChanged(object sender, EventArgs e)
        {
            object Offset = ((LookUpEdit)sender).GetColumnValue("Off_Set_Days");
            
            gvDeposits.SetFocusedRowCellValue(coloff_set_days, Offset);
        }

        private void teActualSellPrice_Leave(object sender, EventArgs e)
        {
            if (teActualSellPrice.Properties.ReadOnly || !teActualSellPrice.Enabled)
                return;

            if (teActualSellPrice.EditValue != DBNull.Value && teActualSellPrice.EditValue != null && _AgreementID != -1)
            {
                string sql = @"select COUNT(d.ID) from proj_lot_agreement_deposits d
                        join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                        where d.agreement_id = "+_AgreementID+" and dep.DepositType = 'P'";
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error checking for percentage deposits:" + Connection.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) > 0)
                    {
                        if (Popup.ShowPopup("Would you like to re-calculate deposit amounts?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        {
                            sql = @"update proj_lot_agreement_deposits set
                                deposit_amt = " + teActualSellPrice.Text.ToString().Replace(",", "") +@" * dep.AmountPercent / 100 
                                from proj_lot_agreement_deposits d
                                join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                                where d.agreement_id = " + _AgreementID + " and dep.DepositType = 'P'";
                            Connection.SQLExecutor.ExecuteNonQuery(sql, Connection.TRConnection);
                            if (Connection.SQLExecutor.Exception != null)
                                Popup.ShowPopup("Error setting percentage deposits:" + Connection.SQLExecutor.Exception.Message);
                            ds_deposits1.Clear();
                            da_deposits.Fill(ds_deposits1);

                            if (((DataRowView)bs_proj_lot_agreement.Current)["ld_standard_terms_det_ID"] != DBNull.Value)
                            {
                                sql = "declare @SaleAmt money =" + teActualSellPrice.Text.ToString().Replace(",", "") + "  exec [LD_CalcDownPayment] " + ((DataRowView)bs_proj_lot_agreement.Current)["ld_standard_terms_det_ID"].ToString() +
                                    ", " + _AgreementID + ", @SaleAmt output, 'F', ''   select @SaleAmt";
                                result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                                teActualDownPayment.EditValue = result;
                            }

                        }
                    }
                }

            }
        }

        private void gvDeposits_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvDeposits.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colagreement_id.FieldName] = _AgreementID;
                row["off_set_days"] = 0;                
            }
        }

        private void lue3PP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                if (!_ReadOnly)
                {
                    if (sender != null)
                    {
                        LookUpEdit lue = sender as LookUpEdit;
                        if (lue != null)
                        {
                            lue.EditValue = DBNull.Value;
                            ucMRR.LoadModel(_LotID, -1, _AgreementID);
                        }
                    }
                }
            }
        }

        private void luePurchaser1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dockManager1_Load(object sender, EventArgs e)
        {
            dpActions.Height = 250;
        }


        private void AdditionalDateChanged(int ID, bool isKeyDate)
        {
            
            string sql = "exec LD_AgreeAdditionalDateUpdate "+_AgreementID.ToString()+","+ID.ToString()+","+(isKeyDate?"1":"0");
            Connection.SQLExecutor.ExecuteNonQuery(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error updating additional dates:" + Connection.SQLExecutor.Exception.Message);

            da_AgreeAdditionalDates.Fill(ds_AgreeAdditionalDates1);
        }

        private void gvAdditionalDates_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            
            DataRow row = gvAdditionalDates.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colDate)
                {
                    if (row[colOffsetDate_ID.FieldName] != null && row[colOffsetDate_ID.FieldName] != DBNull.Value)
                    {
                        e.RepositoryItem = ri_deReadOnly;
                    }
                }
            }
        }
              
        private void gGridAgreeDates_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            if (row != null)
            {
                AdditionalDateChanged(Convert.ToInt32(row[colAdditionalDates_ID.FieldName]), false);
                //force a refresh as key dates may of been changed.
                AgreeHist.Proj_Lot_ID = _LotID;
            }
        }

        private void hlPost_Click(object sender, EventArgs e)
        {
            //ANY CHANGES MADE HERE MUST ALSO BE DONE TO LOT SEARCH "PostPreSaleDeposits(int _AgreementID)"
            if (_AgreementID != -1)
            {
                string sSelect = @"select COUNT(*)
                    from PROJ_LOT_AGREEMENT_DEPOSITS d
                    join LD_Deposits l on l.Deposit_ID=d.deposit_id
                    where d.agreement_id=" + _AgreementID + @" and ISNULL(d.processed,'F') = 'F' and l.Type='P'";
                int iDepositCnt = Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection));

                if (iDepositCnt > 0)
                {
                    LD_LotPreSale.frmLotPreSale fPreSale = new LD_LotPreSale.frmLotPreSale(Connection, DevXMgr, _AgreementID, false);
                    if (fPreSale.ShowDialog() == DialogResult.OK)
                    {
                        LoadLot(_LotID, _PriID);
                    }
                }
                else
                {
                    Popup.ShowPopup("There currently are no unprocessed presale deposits.");
                }
            }
            else
            {
                Popup.ShowPopup("The Agreement must be saved before presale deposits can be processed.");
            }
        }

        private void hlRoute_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;

            int iAgreementID = 1;
            try { iAgreementID = Convert.ToInt32(ds_proj_lot_agreement1.Tables[0].Rows[0]["agreement_id"]); }
            catch { }

            DataTable dtAgreementInfo = Connection.SQLExecutor.ExecuteDataAdapter("Select IsNull(ApprovalStatus,'') as ApprovalStatus, IsNull(ApprovalReqeust_ID,-1) as ApprovalReqeust_ID From PROJ_LOT_AGREEMENT where agreement_id = " + iAgreementID.ToString(), Connection.TRConnection);

            string sApprovedStatus = "";
            int iApprovedRequestID = -1;
            if (dtAgreementInfo != null)
            {
                if (dtAgreementInfo.Rows.Count > 0)
                {
                    if (dtAgreementInfo.Rows[0]["ApprovalStatus"] != DBNull.Value && dtAgreementInfo.Rows[0]["ApprovalStatus"] != null)
                        sApprovedStatus = dtAgreementInfo.Rows[0]["ApprovalStatus"].ToString();
                    if (dtAgreementInfo.Rows[0]["ApprovalReqeust_ID"] != DBNull.Value && dtAgreementInfo.Rows[0]["ApprovalReqeust_ID"] != null)
                        iApprovedRequestID = Convert.ToInt32(dtAgreementInfo.Rows[0]["ApprovalReqeust_ID"]);
                }
            }

            if (sApprovedStatus != "A")
            {
                ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer RequestApproval = 
                    new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer(Connection, DevXMgr, iAgreementID.ToString(), "","", ApprovalRoutingTopic_ID,true);
                if (RequestApproval.Submitted)
                {
                    if (iApprovedRequestID == -1)
                    {
                        iApprovedRequestID = RequestApproval.ApprovalRequestID;
                        Connection.SQLExecutor.ExecuteScalar("Update PROJ_LOT_AGREEMENT Set ApprovalStatus = 'P', ApprovalReqeust_ID = " + iApprovedRequestID.ToString() + "  where agreement_id = " + iAgreementID.ToString(), Connection.TRConnection);
                    }
                }
            }
        }

        private void ceThirdPartyPurchase_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceThirdPartyPurchase.EditValue); }
            catch { }

            if (!_ReadOnly)
                deThirdPartyPurchaseDate.Properties.ReadOnly = !bChecked;
        }

        private void ceSpecHome_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceSpecHome.EditValue); }
            catch { }

            if (!_ReadOnly)
                deSpecHomeStartDate.Properties.ReadOnly = !bChecked;
        }

        private void ceShowHome_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceShowHome.EditValue); }
            catch { }

            if (!_ReadOnly)
            {
                deShowHomeStartDate.Properties.ReadOnly = !bChecked;
                deShowHomeCloseDate.Properties.ReadOnly = !bChecked;
            }
        }

        private void gvAdditionalDates_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;

            if (!isGreaterThenZero(rv[colOffsetDays.FieldName], true))
            {
                Popup.ShowPopup("Offset days can not be less then zero.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (e.Valid && rv[colOffsetDate_ID.FieldName] != DBNull.Value)
            {
                string sql = "exec LD_Proj_Agreement_AdditionalDatesValidation " + rv[colAdditionalDates_ID.FieldName].ToString() + "," + rv[colOffsetDate_ID.FieldName].ToString() + ", " + _AgreementID.ToString();
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error validating additional date selection." + Connection.SQLExecutor.Exception.Message);
                if (result != null && result != DBNull.Value)
                {
                    if (result.ToString().ToLower() != "ok")
                    {
                        Popup.ShowPopup(result.ToString());
                        e.ErrorText = "DeveloperThrownError";
                        e.Valid = false;
                    }
                }
                else
                {
                    Popup.ShowPopup("Unknown error, Invalid value returned.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
            else if (ds_proj_lot_agreement1.Tables[0].Rows[0].RowState != DataRowState.Unchanged)
            {
                Popup.ShowPopup("You must save changes made to the agreement before you can change additional dates.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
        }

        private void gvAdditionalDates_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }


        private DateTime? GetOffsetDateTime(DataRow row)
        {
            DateTime? returnDate = null;
            if(row[colOffsetDate_ID.FieldName] != DBNull.Value)
            {
                
                string sql = "select date from LD_Proj_Agreement_AddDates where Agreement_ID = "+_AgreementID+" and AdditionalDates_ID = "+ row[colOffsetDate_ID.FieldName].ToString();
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                    Popup.ShowPopup("Error setting offset date: " + Connection.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    returnDate = Convert.ToDateTime(result);

                }
                else//no result see if its a key date
                {
                    sql = "select dbo.fn_LD_getDateByKey_ID(ID," + _AgreementID + ")  from LD_AdditionalDates where KeyDate = 1 and ID = " + row[colOffsetDate_ID.FieldName].ToString();
                    result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                    if (Connection.SQLExecutor.Exception != null)
                        Popup.ShowPopup("Error setting offset date: " + Connection.SQLExecutor.Exception.Message);
                    else if (result != null && result != DBNull.Value)
                    {
                        
                        returnDate = Convert.ToDateTime(result);
                    }
                }

                //return date was set, calculate the date via offset days
                if (returnDate != null)
                {
                    int days = 0;
                    try
                    {
                        days = Convert.ToInt32(row[colOffsetDays.FieldName]);
                    }
                    catch { }
                    returnDate = ((DateTime)returnDate).AddDays(days);
                }

            }

            return returnDate;
        }

        private void ri_lueAdditionalDates_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!_ReadOnly)
            {
                ((LookUpEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void gvAdditionalDates_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(e.RowHandle);
            if (row == null) return;

            if (e.Column == colOffsetDate_ID || e.Column == colOffsetDays)
            {
                object newdate = GetOffsetDateTime(row);
                if (newdate == null)
                    newdate = DBNull.Value;
                row[colDate.FieldName] = newdate;
            }
        }

        private void ri_deReadOnly_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(!_ReadOnly)
                Popup.ShowPopup("Date cannot be changed when an offset date is set. Use offset days to change the date.");
        }

        private void ri_lueAdditionalDates_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            int ID = Convert.ToInt32(row[colAdditionalDates_ID.FieldName]);
            if (ID == 1 /*Agreement*/|| ID == 2 /*Sale*/|| ID == 3/*Closing*/)
            {
                Popup.ShowPopup("Agreement Date, Sale Date and Closing Date can not have an offset date.");
                e.Cancel = true;
            }
        }

        private void KeyDates_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime? NewDate = null;
            try
            {
                NewDate = Convert.ToDateTime(e.NewValue);
            }
            catch { }
            if (sender != null && NewDate != null )
            {
                if (sender is DateEdit)
                {
                    DateEdit de = (DateEdit)sender;
                    if (!_bLoading)
                    {
                        

                            string KeyDateID = "-1";
                            string DateName = "";
                            switch (de.Name)
                            {
                                case "deAgreeDate": KeyDateID = "1"; DateName = "Agreement"; break;
                                case "deClosingDate": KeyDateID = "2"; DateName = "Closing"; break;
                                case "deSaleDate": KeyDateID = "3"; DateName = "Sale"; break;
                                case "deIntAdjDate": KeyDateID = "4"; DateName = "Inerest Adjustment"; break;
                                case "deArrIntDate": KeyDateID = "5"; DateName = "Arrears Interest"; break;
                                case "deExpPayDate": KeyDateID = "6"; DateName = "Expected Payout"; break;
                                case "deOrgArrDate": KeyDateID = "7"; DateName = "Original Arrears"; break;
                                case "deEstReleaseDate": KeyDateID = "8"; DateName = "Estimated Release"; break;
                                case "deActualReleaseDate": KeyDateID = "9"; DateName = "Actual Release"; break;
                            }

                            object result = Connection.SQLExecutor.ExecuteScalar("select OffsetDate_ID from LD_Proj_Agreement_AddDates where Agreement_ID =" + _AgreementID.ToString() + " and AdditionalDates_ID =" + KeyDateID, Connection.TRConnection);
                            if (Connection.SQLExecutor.Exception != null)
                            {
                                Popup.ShowPopup("Error checking for offset date:" + Connection.SQLExecutor.Exception.Message);
                                e.Cancel = true;
                            }
                            else if (result != null && result != DBNull.Value)
                            {
                                Popup.ShowPopup("Date cannot be changed when an offset date is set. Use offset days in the agreement dates grid to change the date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID != "1" && deAgreeDate.DateTime.CompareTo(NewDate) > 0)
                            {
                                Popup.ShowPopup(DateName+" Date can not be less then the agreement date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deClosingDate.DateTime.CompareTo(NewDate) < 0 && deClosingDate.Text != "" )
                            {
                                Popup.ShowPopup("Agreement date can not be greater then closing date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deSaleDate.DateTime.CompareTo(NewDate) < 0 && deSaleDate.Text != "" && !SettingFromStandardTerms)
                            {
                                Popup.ShowPopup("Agreement date can not be greater then sale date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deIntAdjDate.DateTime.CompareTo(NewDate) < 0 && deIntAdjDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then interest adjustment date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deArrIntDate.DateTime.CompareTo(NewDate) < 0 && deArrIntDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then arrears interest date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deExpPayDate.DateTime.CompareTo(NewDate) < 0 && deExpPayDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then expected payout date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deOrgArrDate.DateTime.CompareTo(NewDate) < 0 && deOrgArrDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then original arrears date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deEstReleaseDate.DateTime.CompareTo(NewDate) < 0 && deEstReleaseDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then estimated release date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deActualReleaseDate.DateTime.CompareTo(NewDate) < 0 && deActualReleaseDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then actual release date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deAssumedDate.DateTime.CompareTo(NewDate) < 0 && deAssumedDate.Text != "")
                            {
                                Popup.ShowPopup("Agreement date can not be greater then assumed date.");
                                e.Cancel = true;
                            }


                       


                    }
                }
            }
        }

        private void dpProgramFees_Click(object sender, EventArgs e)
        {

        }

        private void dpLOC_Click(object sender, EventArgs e)
        {

        }

        private void lueSaleType_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void lueSaleType_Leave(object sender, EventArgs e)
        {
            if (_ReadOnly) return;
            if (ds_proj_lot_agreement1.Tables[0].Rows.Count > 0)
            {
                bs_proj_lot_agreement.EndEdit();
                bool preSale = false;
                try
                {
                    if (Convert.ToInt32(lueSaleType.EditValue) == 1)
                        preSale = true;
                }
                catch { }

                ds_proj_lot_agreement1.Tables[0].Rows[0]["pre_sale"] = preSale;
            }
        }

        private void luePurchaser1_Leave(object sender, EventArgs e)
        {
            if (_ReadOnly) return;
            if (luePurchaserType.EditValue != DBNull.Value && luePurchaserType.EditValue != null)
            {
                if (luePurchaserType.EditValue.ToString() == "1" || luePurchaserType.EditValue.ToString() == "3")
                {
                    if (luePurchaser1.EditValue != DBNull.Value)
                    {
                        if (lueHomeBuilder.EditValue == DBNull.Value || lueHomeBuilder.EditValue == null)
                        {
                            //lueHomeBuilder.EditValue = luePurchaser1.EditValue;
                            //purchaser was getting reverted when changed.
                            object purchaserID = (luePurchaser1.EditValue == null ? DBNull.Value : luePurchaser1.EditValue);
                            ((DataRowView)bs_proj_lot_agreement.Current).Row["homebuilder_id"] = purchaserID;
                            luePurchaser1.EditValue = purchaserID;
                            
                        }
                        if (lueWarrantyType.EditValue == DBNull.Value || lueWarrantyType.EditValue == null)
                        {
                            if (luePurchaser1.EditValue != null)
                            {
                                object purchaserID = luePurchaser1.EditValue;
                                string sql = "select LD_WarrantyType_ID from CUSTOMERS where CUSTOMER_ID = " + purchaserID.ToString();
                                lueWarrantyType.EditValue = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                            }

                        }
                    }
                }
            }
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            using (WO_CentralizedFSManager.frmFileManager FileMgr = new WO_CentralizedFSManager.frmFileManager(Connection, DevXMgr, WO_CentralizedFSManager.DocumentViewerMode.All, sFileMgrType, _AgreementID, _ReadOnly))
            {
                FileMgr.ShowDialog();
                FileMgr.Dispose();
            }

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, _AgreementID, ref btnAttachments);
        }

        private void teActualSellPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
                e.Cancel = !KCA_Validator.ValidatePassword(101);
        }

        private int PurchaserOnOtherAgreement(int purchaserID, DateTime saleDate,int AgreementID)
        {
            int returnValue = -1;
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value)
            {
                if (luePurchaserType.EditValue.ToString() == "2")
                {

                    
                    string sql = "declare @Date date = '" + saleDate.ToShortDateString() + "',@Purchaser_ID int = " + purchaserID.ToString() + ", @YearsBetween int " +
                    @"select @YearsBetween = isnull(YearsBetweenPurchases,0) from ld_setup

if(@YearsBetween > 0)
begin
	select agreement_num from PROJ_LOT_AGREEMENT where sale_date between dateadd(yyyy,-@YearsBetween,dateadd(dd,1,@Date)) and DATEADD(yyyy,@YearsBetween,dateadd(dd,-1,@Date))
	and (purchaser_id = @Purchaser_ID or purchaser_id2 = @Purchaser_ID or purchaser_id3 = @Purchaser_ID )
	and agreement_status_id <> 2 and agreement_id <> " + _AgreementID.ToString() + " end";

                    object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                    if (Connection.SQLExecutor.Exception != null)
                        Popup.ShowPopup("Error checking individual years between purchases:" + Connection.SQLExecutor.Exception.Message);
                    else if (result != null && result != DBNull.Value)
                    {
                        returnValue = Convert.ToInt32(result);
                    }
                }
            }



            return returnValue;
        }

        private void lueAssumedPurchaser_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (lueAssumedPurchaser.Properties.ReadOnly)
                return;
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                ((LookUpEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void deAssumedDate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (deAssumedDate.Properties.ReadOnly)
                return;
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                ((DateEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void luePurchaser1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (luePurchaser1.Properties.ReadOnly)
                return;

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (luePurchaserType.EditValue != DBNull.Value && luePurchaserType.EditValue != null)
                {
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(Connection, DevXMgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(dsPurchaser);
                            luePurchaser1.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    Popup.ShowPopup("You must select a purchaser type.");
            }
        }

        private void luePurchaser2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (luePurchaser2.Properties.ReadOnly)
                return;

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (luePurchaserType.EditValue != DBNull.Value && luePurchaserType.EditValue != null)
                {
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(Connection, DevXMgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(dsPurchaser);
                            luePurchaser2.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    Popup.ShowPopup("You must select a purchaser type.");
            }
        }

        private void luePurchaser3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (luePurchaser3.Properties.ReadOnly)
                return;

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (luePurchaserType.EditValue != DBNull.Value && luePurchaserType.EditValue != null)
                {
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(Connection, DevXMgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(dsPurchaser);
                            luePurchaser3.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    Popup.ShowPopup("You must select a purchaser type.");
            }
        }

        private void hlAgreementDocuments_Click(object sender, EventArgs e)
        {
            if (_AgreementID != -1)
            {
                using (LD_Agree_WordMerge.frmAgreeDocs frm = new LD_Agree_WordMerge.frmAgreeDocs(Connection, DevXMgr, _AgreementID))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                Popup.ShowPopup("The Agreement must be saved before you can view documents.");
            }
            
        }

        private void hlDocumentLibrary_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            if (_AgreementID != -1)
            {                
                DocumentLibrary.frmLaunch frm = new DocumentLibrary.frmLaunch(Connection, DevXMgr, DocumentLibrary.LaunchTypes.Agreement, _AgreementID);
                frm.ShowDialog();
                frm.Dispose();                
            }
        }

        private void ri_teOffestDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            int ID = Convert.ToInt32(row[colAdditionalDates_ID.FieldName]);
            if (ID == 1 /*Agreement*/|| ID == 2 /*Sale*/|| ID == 3/*Closing*/)
            {
                Popup.ShowPopup("Agreement Date, Sale Date and Closing Date can not have an offset date.");
                e.Cancel = true;
            }
        }

        private void hlAgreementExtension_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;
            if (_AgreementID != -1)
            {
                bool showPopup = true;
                if (HasOffsetDate(6))
                {
                    if (Popup.ShowPopup("Expected Payout Date has an offset date.Would you like to override this?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                    {
                        showPopup = true;
                    }
                    else
                        showPopup = false;
                }

                if (showPopup)
                {
                    using (frmAgreementExt frm = new frmAgreementExt(Connection, DevXMgr, _AgreementID))
                    {
                        frm.ShowDialog(this);
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            AgreeHist_AgreementChange_Event(_AgreementID);
                            AdditionalDateChanged(6, true);
                        }
                    }
                }
            }
        }

        private void gvLevy_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLD_Levy_ID = dr["LD_Levy_ID"];
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                {
                    e.Valid = false;
                    e.ErrorText = "'Levy Description' is required.";
                    gvLevy.FocusedColumn = colLD_Levy_ID;
                    return;
                }

                if (_lv1_active)
                {
                    object olv1id = dr["lv1id"];
                    if (olv1id == null || olv1id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv1id2.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv1id2;
                        return;
                    }
                }

                if (_lv2_active)
                {
                    object olv2id = dr["lv2id"];
                    if (olv2id == null || olv2id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv2id2.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv2id2;
                        return;
                    }
                }

                if (_lv3_active)
                {
                    object olv3id = dr["lv3id"];
                    if (olv3id == null || olv3id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv3id2.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv3id2;
                        return;
                    }
                }

                if (_lv4_active)
                {
                    object olv4id = dr["lv4id"];
                    if (olv4id == null || olv4id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv4id2.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv4id2;
                        return;
                    }
                }

                object oAmount = dr["Amount"];
                if (oAmount == null || oAmount == DBNull.Value)
                    oAmount = 0;

                if (Convert.ToDouble(oAmount) == 0)
                {
                    e.Valid = false;
                    e.ErrorText = "'Amount' is required.";
                    gvLevy.FocusedColumn = colAmount2;
                    return;
                }

                object oPROJ_LOT_AGREEMENT_LEVY_ID = dr["PROJ_LOT_AGREEMENT_LEVY_ID"];
                if (oPROJ_LOT_AGREEMENT_LEVY_ID == null || oPROJ_LOT_AGREEMENT_LEVY_ID == DBNull.Value)
                    oPROJ_LOT_AGREEMENT_LEVY_ID = -1;

                // supplier only needs to be validated if the type = 'other'
                string sSQL = @"select count(*) 
                from PROJ_LOT_AGREEMENT_LEVY p
                join LD_Levy l on l.Levy_ID=p.LD_Levy_ID
                join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                where p.id=" + oPROJ_LOT_AGREEMENT_LEVY_ID + @" and t.PaidTo='O'";
                object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;
                if (Convert.ToInt32(oCNT) == 1)
                {
                    object oSupplier_ID = dr["Supplier_ID"];
                    if (oSupplier_ID == null || oSupplier_ID == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'Supplier' is required.";
                        gvLevy.FocusedColumn = colsupplier_id1;
                        return;
                    }
                }
            }
        }

        private void gvLevy_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oAgreement_id = _AgreementID;
                object oPROJ_LOT_AGREEMENT_LEVY_ID = (dr["PROJ_LOT_AGREEMENT_LEVY_ID"] == null || dr["PROJ_LOT_AGREEMENT_LEVY_ID"] == DBNull.Value) ? DBNull.Value : dr["PROJ_LOT_AGREEMENT_LEVY_ID"];
                object oLD_Levy_ID = (dr["LD_Levy_ID"] == null || dr["LD_Levy_ID"] == DBNull.Value) ? DBNull.Value : dr["LD_Levy_ID"];
                object oLv1id = (dr["lv1id"] == null || dr["lv1id"] == DBNull.Value) ? DBNull.Value : dr["lv1id"];
                object oLv2id = (dr["lv2id"] == null || dr["lv2id"] == DBNull.Value) ? DBNull.Value : dr["lv2id"];
                object oLv3id = (dr["lv3id"] == null || dr["lv3id"] == DBNull.Value) ? DBNull.Value : dr["lv3id"];
                object oLv4id = (dr["lv4id"] == null || dr["lv4id"] == DBNull.Value) ? DBNull.Value : dr["lv4id"];
                object oAmount = (dr["Amount"] == null || dr["Amount"] == DBNull.Value) ? DBNull.Value : dr["Amount"];
                object oSupplier = (dr["supplier_id"] == null || dr["supplier_id"] == DBNull.Value) ? DBNull.Value : dr["supplier_id"];

                using (SqlConnection sqlcon = new SqlConnection(Connection.TRConnection))
                {
                    string sSQL = @"LD_Proj_AgreementLevy_Save";
                    SqlCommand cmd = new SqlCommand(sSQL, sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter pAgreement_id = new SqlParameter("@agreement_id", oAgreement_id);
                    SqlParameter pPROJ_LOT_AGREEMENT_LEVY_ID = new SqlParameter("@PROJ_LOT_AGREEMENT_LEVY_ID", oPROJ_LOT_AGREEMENT_LEVY_ID);
                    SqlParameter pLD_Levy_ID = new SqlParameter("@LD_Levy_ID", oLD_Levy_ID);
                    SqlParameter pLv1id = new SqlParameter("@lv1id", oLv1id);
                    SqlParameter pLv2id = new SqlParameter("@lv2id", oLv2id);
                    SqlParameter pLv3id = new SqlParameter("@lv3id", oLv3id);
                    SqlParameter pLv4id = new SqlParameter("@lv4id", oLv4id);
                    SqlParameter pAmount = new SqlParameter("@Amount", oAmount);
                    SqlParameter pSupplier = new SqlParameter("@supplier_id", oSupplier);

                    cmd.Parameters.Add(pAgreement_id);
                    cmd.Parameters.Add(pPROJ_LOT_AGREEMENT_LEVY_ID);
                    cmd.Parameters.Add(pLD_Levy_ID);
                    cmd.Parameters.Add(pLv1id);
                    cmd.Parameters.Add(pLv2id);
                    cmd.Parameters.Add(pLv3id);
                    cmd.Parameters.Add(pLv4id);
                    cmd.Parameters.Add(pAmount);
                    cmd.Parameters.Add(pSupplier);

                    try
                    {
                        cmd.Connection.Open();
                        oPROJ_LOT_AGREEMENT_LEVY_ID = cmd.ExecuteScalar();
                        dr.BeginEdit();
                        dr["PROJ_LOT_AGREEMENT_LEVY_ID"] = oPROJ_LOT_AGREEMENT_LEVY_ID;
                        dr.EndEdit();
                        dr.AcceptChanges();
                    }
                    catch (Exception)
                    {
                        Popup.ShowPopup("Error saving agreement levy.");
                    }
                    finally
                    {
                        cmd.Connection.Close();
                    }
                }
            }
        }

        private void riLevel1_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv2id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel2_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel2_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv1ID = dr["lv1id"];
                if (oLv1ID == null || oLv1ID == DBNull.Value)
                    oLv1ID = -1;

                bsLv2Filtered.Filter = "lv1id = " + oLv1ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv2Filtered;
            }
        }

        private void riLevel3_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel3_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv2ID = dr["lv2id"];
                if (oLv2ID == null || oLv2ID == DBNull.Value)
                    oLv2ID = -1;

                bsLv3Filtered.Filter = "lv2id = " + oLv2ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv3Filtered;
            }
        }

        private void riLevel4_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv3ID = dr["lv3id"];
                if (oLv3ID == null || oLv3ID == DBNull.Value)
                    oLv3ID = -1;

                bsLv4Filtered.Filter = "lv3id = " + oLv3ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv4Filtered;
            }
        }

        private void gvLevy_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colLD_Levy_ID || e.Column == collv1id2 || e.Column == collv2id2 || e.Column == collv3id2
                 || e.Column == collv4id2 || e.Column == colAmount2)
            {
                object oMatched = gvLevy.GetFocusedRowCellValue("Matched");
                if (oMatched == null || oMatched == DBNull.Value)
                    oMatched = false;
                bool bMatched = Convert.ToBoolean(oMatched);

                if (e.Column == colLD_Levy_ID)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevy;
                    else
                        e.RepositoryItem = riLevyRO;
                }
                else if (e.Column == collv1id2)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel1;
                    else
                        e.RepositoryItem = riLevel1RO;
                }
                else if (e.Column == collv2id2)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel2;
                    else
                        e.RepositoryItem = riLevel2RO;
                }
                else if (e.Column == collv3id2)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel3;
                    else
                        e.RepositoryItem = riLevel3RO;
                }
                else if (e.Column == collv4id2)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel4;
                    else
                        e.RepositoryItem = riLevel4RO;
                }
                else if (e.Column == colAmount2)
                {
                    if (!bMatched)
                        e.RepositoryItem = riAmount;
                    else
                        e.RepositoryItem = riAmountRO;
                }
            }
            else if (e.Column == colsupplier_id1)
            {                
                object oLD_Levy_ID = gvLevy.GetFocusedRowCellValue("LD_Levy_ID");
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                    oLD_Levy_ID = -1;
                string sSQL = @"select count(*) 
                    from LD_Levy l 
                    join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                    where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
                object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;

                if (Convert.ToInt32(oCNT) == 1)
                    e.RepositoryItem = Supp_Repository;
                else
                    e.RepositoryItem = riSupplierRO;

                object oMatched = gvLevy.GetFocusedRowCellValue("Matched");
                if (oMatched == null || oMatched == DBNull.Value)
                    oMatched = false;
                bool bMatched = Convert.ToBoolean(oMatched);

                if (bMatched)
                    e.RepositoryItem = riSupplierRO;
            }
        }

        private void gcLevy_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete the selected 'Levy'?", WS_Popups.frmPopup.PopupType.OK_Cancel) ==
                     WS_Popups.frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvLevy.GetFocusedDataRow();
                    if (dr != null)
                    {
                        bool bSuccess = false;
                        string sMessage = "";

                        object oPROJ_LOT_AGREEMENT_LEVY_ID = dr["PROJ_LOT_AGREEMENT_LEVY_ID"];
                        string sSQL = @"exec LD_Proj_AgreementLevy_Delete "+oPROJ_LOT_AGREEMENT_LEVY_ID;
                        DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSQL, Connection.TRConnection);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                DataRow drResult = dt.Rows[0];
                                if (drResult != null)
                                {
                                    object oSuccess = drResult["Success"];
                                    if (oSuccess == null || oSuccess == DBNull.Value)
                                        oSuccess = false;

                                    bSuccess = Convert.ToBoolean(oSuccess);

                                    object oMessage = drResult["Message"];
                                    if (oMessage == null || oMessage == DBNull.Value)
                                        oMessage = "";

                                    sMessage = oMessage.ToString();
                                }
                            }
                        }

                        if (bSuccess)
                        {
                            gvLevy.DeleteRow(gvLevy.FocusedRowHandle);
                        }
                        else
                        {
                            if (sMessage.Trim().Equals(""))
                                sMessage = "Error deleting the selected levy.";

                            Popup.ShowPopup(sMessage);
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private void gvLevy_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void riAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object oAmount = e.NewValue;
            if (oAmount == null || oAmount == DBNull.Value)
                oAmount = 0;

            double dAmout = Convert.ToDouble(oAmount);
            if (dAmout < -999999999999999.99 || dAmout > 999999999999999.99)
            {
                e.Cancel = true;
                return;
            }
        }

        private void gvLevy_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                dr["PaidAmt"] = 0;
            }
        }

        private void riLevy_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object oLD_Levy_ID = e.NewValue;
            if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                oLD_Levy_ID = -1;
            string sSQL = @"select count(*) 
                from LD_Levy l 
                join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
            object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (oCNT == null || oCNT == DBNull.Value)
                oCNT = 0;
            if (Convert.ToInt32(oCNT) == 0)
            {
                gvLevy.SetFocusedRowCellValue("supplier_id", DBNull.Value);
            }
        }

        private void gvDeposits_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colPresaleSeq)
            {
                DataRow row = gvDeposits.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row[coldeposit_id.FieldName] != null && row[coldeposit_id.FieldName] != DBNull.Value)
                    {
                        try
                        {
                            if (ds_lueDepositTyeps1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(row[coldeposit_id.FieldName])).Type == "P")
                                e.RepositoryItem = ri_teNumaric0;
                            else
                                e.RepositoryItem = ri_teReadOnly;
                        }
                        catch { e.RepositoryItem = ri_teReadOnly; }
                    }
                    else
                        e.RepositoryItem = ri_teReadOnly;
                }
            }
        }

        private void lueDepositType_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            if(lue.EditValue != null && lue.EditValue != DBNull.Value && isTierPresale)
            {
                try
                {
                    if (ds_lueDepositTyeps1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(lue.EditValue)).Type == "P")
                    {
                        object sequence = Connection.SQLExecutor.ExecuteScalar(@"
select max(isnull(t.presaleseq,0)) from PROJ_LOT_AGREEMENT_DEPOSITS t
join LD_Deposits d on d.Deposit_ID = t.Deposit_ID
where d.Type = 'P' and t.agreement_id =" + _AgreementID, Connection.TRConnection);
                        if (sequence != null && sequence != DBNull.Value)
                            sequence = Convert.ToInt32(sequence) + 1;
                        else
                            sequence = 1;
                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, sequence);
                    }
                    else
                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value);
                }
                catch { gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value); }
            }
        }

        private void gvDiscounts_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvDiscounts.GetDataRow(e.RowHandle);
            dr[colagreement_id3.FieldName] = _AgreementID;
            dr[colprocessed.FieldName] = false;
        }

        private void gvDiscounts_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvDiscounts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colLD_Discounts_ID, colType, colValue }, false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[colValue.FieldName], false))
            {
                Popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (IsNumberToLarge(((DataRowView)e.Row)[colValue.FieldName]))
            {
                Popup.ShowPopup("Value is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
        }

        private bool IsNumberToLarge(object value)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue > 9999999999)
                returnValue = true;

            return returnValue;
        }

        private void rilueDiscountType_EditValueChanged(object sender, EventArgs e)
        {
            if (gvDiscounts.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                LookUpEdit lue = (LookUpEdit)sender;

                if (lue.EditValue != null && lue.EditValue != DBNull.Value)
                {
                    DataRowView row = (DataRowView)lue.GetSelectedDataRow();
                    if (row != null)
                    {
                        object cellValue = gvDiscounts.GetFocusedRowCellValue(colValue);
                        if (cellValue == null || cellValue == DBNull.Value)
                            gvDiscounts.SetFocusedRowCellValue(colValue, row["Value"]);
                        cellValue = gvDiscounts.GetFocusedRowCellValue(colType);
                        if (cellValue == null || cellValue == DBNull.Value)
                            gvDiscounts.SetFocusedRowCellValue(colType, row["Type"]);
                    }
                }
            }
        }
    }
}
