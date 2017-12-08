using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;

namespace LD_LotAgreementAssistant
{
    public partial class ucLotAgreement : DevExpress.XtraEditors.XtraUserControl
    {

        private HMConnection.HMCon hmCon;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        private LD_ModelRepRules.ucModelRepRules ucMRR;
        private Supplier_Lookup_Rep.Repository_Supplier_Lookup Supp_Repository;
        private WS_Popups.frmPopup popup;
        private bool _bLoading = false;
        private TUC_GridG.GridG gGrid;
        private TUC_GridG.GridG gGridAgreeDates;
        private TUC_GridG.GridG gGridAgreeDiscount;
        private LandCC.ucLetterOfCredit LOC;
        private UDF_Manager.ucUDF_Manager udfManager;
        private int _YearsForIndividualPurchases = 0;
        private int _AgreementID = -1;
        public KeyControlAccess.Validator KCA_Validator;
        private string _ActionType = "";
        private bool _IsMasterAgreement = false;
        private int _MasterAgreement_ID = -1;
        private bool overwrite = false;
        private int _LotID = -1;

        private bool _lv1_active = false;
        private bool _lv2_active = false;
        private bool _lv3_active = false;
        private bool _lv4_active = false;
        private bool isTierPresale = false;


        public ucLotAgreement(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_agreement.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_Deposits.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            daLevies.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_AdditionalDates.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_Discounts.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;

            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvDeposits, da_Deposits, ds_deposits1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete +=new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGrid.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGrid_AfterUpdate);
            

            gGridAgreeDates = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvAdditionalDates, da_AdditionalDates, ds_AdditionalDates1);
            gGridAgreeDates.AllowTabCreateNewRecord = true;
            gGridAgreeDates.AskBeforeDelete = false;
            gGridAgreeDates.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGridAgreeDates.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGridAgreeDates_AfterUpdate);

            gGridAgreeDiscount = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvDiscounts, da_Discounts, ds_Discounts1);
            gGridAgreeDiscount.AllowTabCreateNewRecord = true;
            gGridAgreeDiscount.AskBeforeDelete = false;


            udfManager = new UDF_Manager.ucUDF_Manager(hmCon, tuc, UDF_Manager.UDFType.LotAgreement);
            udfManager.Dock = DockStyle.Fill;
            udfManager.Parent = tpUDF;
            udfManager.PopulateUDFValues("Agreement", -1);

            ucMRR = new LD_ModelRepRules.ucModelRepRules(hmCon);
            ucMRR.Dock = DockStyle.Fill;
            ucMRR.Parent = tpRepRules;

            tpUDF.PageVisible = false;

            LOC = new LandCC.ucLetterOfCredit(hmCon, tuc_mgr);
            LOC.Dock = DockStyle.Fill;
            LOC.Parent = dpnlLOC;

            SetupLevels();
            SetupSupplierLU();
            
            if (hmCon.CountryCode == "U")
            {
                lciTax1.Text = "Tax 1";
                lciTax2.Text = "Tax 2";
            }
            else if (hmCon.CountryCode == "C")
            {
                lciTax1.Text = "GST";
                lciTax2.Text = "PST";
            }


            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(YearsBetweenPurchases,0) from ld_setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for individual years between purchases:" + hmCon.SQLExecutor.Exception.Message);
            else if(result != null && result != DBNull.Value)
            {
                _YearsForIndividualPurchases = Convert.ToInt32(result);
            }

            result = hmCon.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for Tier Pre-Sale:" + hmCon.SQLExecutor.Exception.Message);
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

        private void SetupSupplierLU()
        {
            Supp_Repository = new Supplier_Lookup_Rep.Repository_Supplier_Lookup();
            Supp_Repository.HMConnection = hmCon;
            Supp_Repository.DevXMgr = tuc_mgr;
            Supp_Repository.ActiveSuppliers = true;
            Supp_Repository.ValueMember = "SUPPLIER_ID";
            colsupplier_id1.ColumnEdit = Supp_Repository;
        }

        private void SetupLevels()
        {
            daLv1.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv2.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv3.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv4.SelectCommand.Parameters["@projtype"].Value = "L";

            string sSQL = @"select  isnull(lv1_land_desc,'')[lv1_land_desc], isnull(lv2_land_desc,'')[lv2_land_desc],
                isnull(lv3_land_desc,'')[lv3_land_desc], isnull(lv4_land_desc,'')[lv4_land_desc], 
                isnull(lv1_active_land,'F')[lv1_active_land], isnull(lv2_active_land,'F')[lv2_active_land], 
                isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] 
            from proj_cntl";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        collv1id.Caption = dr["lv1_land_desc"].ToString();
                        collv2id.Caption = dr["lv2_land_desc"].ToString();
                        collv3id.Caption = dr["lv3_land_desc"].ToString();
                        collv4id.Caption = dr["lv4_land_desc"].ToString();

                        collv1id.OptionsColumn.ShowInCustomizationForm = collv1id.Visible = _lv1_active = (dr["lv1_active_land"].ToString() == "T");
                        collv2id.OptionsColumn.ShowInCustomizationForm = collv2id.Visible = _lv2_active = (dr["lv2_active_land"].ToString() == "T");
                        collv3id.OptionsColumn.ShowInCustomizationForm = collv3id.Visible = _lv3_active = (dr["lv3_active_land"].ToString() == "T");
                        collv4id.OptionsColumn.ShowInCustomizationForm = collv4id.Visible = _lv4_active = (dr["lv4_active_land"].ToString() == "T");
                    }
                }
            }
        }

        private void gGrid_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            object oPURCHASER_TYPE_ID = luePurchaserType.EditValue;
            if (oPURCHASER_TYPE_ID == null || oPURCHASER_TYPE_ID == DBNull.Value)
                oPURCHASER_TYPE_ID = -1;

            object oSALES_TYPE_ID = lueSaleType.EditValue;
            if (oSALES_TYPE_ID == null || oSALES_TYPE_ID == DBNull.Value)
                oSALES_TYPE_ID = -1;

            string SQL = @"select STANDARD_TERMS_DET_ID 
                from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"]+@"
                and PURCHASER_TYPE_ID = " + oPURCHASER_TYPE_ID + @" and SALES_TYPE_ID = " + oSALES_TYPE_ID;

            object result = hmCon.SQLExecutor.ExecuteScalar(SQL, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error setting standard terms deposits:" + hmCon.SQLExecutor.Exception.Message);
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
        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }

        public void RefreshMe(int agreement_id,string ActionSelected)
        {
            _YearsForIndividualPurchases = 0;
            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(YearsBetweenPurchases,0) from ld_setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for individual years between purchases:" + hmCon.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                _YearsForIndividualPurchases = Convert.ToInt32(result);
            }
            result = hmCon.SQLExecutor.ExecuteScalar("select ISNULL((select LOT_MASTER_AGREEMENT_ID from PROJ_LOT_MASTER_AGREEMENT_DETAIL d where d.LOT_AGREEMENT_ID = " + agreement_id + "),-1)", hmCon.TRConnection);
            _MasterAgreement_ID = -1;
            try { _MasterAgreement_ID = Convert.ToInt32(result); }
            catch { }
            if (_MasterAgreement_ID != -1)
                _IsMasterAgreement = true;
            else
                _IsMasterAgreement = false;
            
            if (ActionSelected.Equals(LD_LotSearch.Actions.AddToMaster.ToString()) || ActionSelected.Equals(LD_LotSearch.Actions.NewMasterAgree.ToString()) || _IsMasterAgreement)
            {
                layoutControl16.Enabled = false;
                ucMRR.SetReadOnly(true);
                gcLevies.Enabled = false;
                gcLevies.EmbeddedNavigator.Buttons.Append.Visible =
                gcLevies.EmbeddedNavigator.Buttons.CancelEdit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.Edit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.EndEdit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.Remove.Visible = false;
            }
            else
            {
                layoutControl16.Enabled = true;
                ucMRR.SetReadOnly(false);
                gcLevies.Enabled = true;
                gcLevies.EmbeddedNavigator.Buttons.Append.Visible =
                gcLevies.EmbeddedNavigator.Buttons.CancelEdit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.Edit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.EndEdit.Visible =
                gcLevies.EmbeddedNavigator.Buttons.Remove.Visible = true;
            }

            _ActionType = ActionSelected;
            teActualDownPayment.Enabled = true;
            _AgreementID = agreement_id;
            udfManager.PopulateUDFValues("Agreement", agreement_id);
            layoutControlItem15.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem27.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem28.AppearanceItemCaption.ForeColor = Color.Black;
            object oLotID = hmCon.SQLExecutor.ExecuteScalar("select proj_lot_id from PROJ_LOT_AGREEMENT where agreement_id ="+agreement_id.ToString(), hmCon.TRConnection);
            if (oLotID != null && oLotID != DBNull.Value)
            {
                _LotID = Convert.ToInt32(oLotID);
                LOC.FillLOC(_LotID, agreement_id);
            }
            else
            {
                _LotID = -1;
                LOC.FillLOC(-1, -1);
            }
            FillWorkingTable(agreement_id);
            try
            {
                _bLoading = true;
                da_agreement.SelectCommand.Parameters["@agreement_id"].Value = agreement_id;
                da_Deposits.SelectCommand.Parameters["@agreement_id"].Value = agreement_id;
                daLevies.SelectCommand.Parameters["@agreement_id"].Value = agreement_id;
                da_AdditionalDates.SelectCommand.Parameters["@agreement_id"].Value = agreement_id;
                da_Discounts.SelectCommand.Parameters["@agreement_id"].Value = agreement_id;
                ds_lookups1.Clear();
                da_lookups.Fill(ds_lookups1);
                ds_WarrantyType1.Clear();
                da_WarrantyType.Fill(ds_WarrantyType1);
                ds_lueDepositType1.Clear();
                da_lueDepositType.Fill(ds_lueDepositType1);
                ds_agreement1.Clear();
                da_agreement.Fill(ds_agreement1);
                ds_deposits1.Clear();
                da_Deposits.Fill(ds_deposits1);
                ds_Discounts1.Clear();
                da_Discounts.Fill(ds_Discounts1);
                dsLevies.Clear();
                if (ActionSelected.Equals("Edit"))
                {
                    daLevies.Fill(dsLevies);
                }
                ds_lueAdditionalDates1.Clear();
                da_lueAdditionalDates.Fill(ds_lueAdditionalDates1);
                ds_AdditionalDates1.Clear();
                da_AdditionalDates.Fill(ds_AdditionalDates1);
                dsLv11.Clear();
                daLv1.Fill(dsLv11);
                dsLv21.Clear();
                daLv2.Fill(dsLv21);
                dsLv31.Clear();
                daLv3.Fill(dsLv31);
                dsLv41.Clear();
                daLv4.Fill(dsLv41);
                dsLevyType1.Clear();
                daLevyType.Fill(dsLevyType1);
                dsSupplier1.Clear();
                daSupplier.Fill(dsSupplier1);
                dsAssumedPurchaser1.Clear();
                daAssumedPurchaser.Fill(dsAssumedPurchaser1);
                ds3Purchaser.Clear();
                da3Purchaser.Fill(ds3Purchaser);
                luePurchaserType_EditValueChanged(luePurchaserType, null);
                ds_lueDiscountType1.Clear();
                da_lueDiscountType.Fill(ds_lueDiscountType1);
                ds_lueValueType1.Clear();
                da_lueValueType.Fill(ds_lueValueType1);
                _bLoading = false;
                SetBanner(agreement_id);

                if (agreement_id == -1)//new agreement
                {
                    AdditionalDateChanged(1, true, "'" + deAgreeDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(2, true, "'" + deClosingDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(3, true, "'" + deSaleDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(4, true, "'" + deIntAdjDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(5, true, "'" + deArrIntDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(6, true, "'" + deExpPayDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(7, true, "'" + deOrgArrDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(8, true, "'" + deEstReleaseDate.DateTime.ToShortDateString() + "'");
                    AdditionalDateChanged(9, true, "'" + deActualReleaseDate.DateTime.ToShortDateString() + "'");
                }


                
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error in refresh me:" + ex.Message);
            }


            
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
                luePurchaserType.Properties.ReadOnly = false;
                luePurchaser1.Properties.ReadOnly = false;
                luePurchaser2.Properties.ReadOnly = false;
                luePurchaser3.Properties.ReadOnly = false;
            }

            luePurchaser1.Properties.Buttons[1].Enabled = !luePurchaser1.Properties.ReadOnly;
            luePurchaser2.Properties.Buttons[1].Enabled = !luePurchaser2.Properties.ReadOnly;
            luePurchaser3.Properties.Buttons[1].Enabled = !luePurchaser3.Properties.ReadOnly;

            
            Load3rdPartyPurch(agreement_id);            
        }

        private void SetBanner(int Agreement_ID)
        {
            lblHeader.Text = "";
            DataTable dt;
            if (Agreement_ID == -1)
            {

                dt = hmCon.SQLExecutor.ExecuteDataAdapter("select pri_code,pri_name,lot_num,block_num,plan_num,masteragreementNum " +
                    "from working_ld_lotsearch where username = '" + hmCon.MLUser + "LotAgreementAssistant' and selected = 1", hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error loading header information:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0]["masteragreementNum"] == DBNull.Value || dt.Rows[0]["masteragreementNum"] == null)
                        {
                            lblHeader.Text = "Project: " + dt.Rows[0]["pri_code"] + "(" + dt.Rows[0]["pri_name"] + ")  Lot:" + dt.Rows[0]["lot_num"] + " Block:" + dt.Rows[0]["block_num"] + " Plan:" + dt.Rows[0]["plan_num"];
                        }
                        else
                        {
                            lblHeader.Text = "Project: " + dt.Rows[0]["pri_code"] + "(" + dt.Rows[0]["pri_name"] + ") Master Agreement:" + dt.Rows[0]["masteragreementNum"] + " Lot:" + dt.Rows[0]["lot_num"] + " Block:" + dt.Rows[0]["block_num"] + " Plan:" + dt.Rows[0]["plan_num"];
                        }
                    }
                    else
                    {
                        lblHeader.Text = "Project: " + dt.Rows[0]["pri_code"] + "(" + dt.Rows[0]["pri_name"] + ") Master agreement, see lots panel.";
                    }
                }
            }
            else
            {
                string sql = "select p.pri_code,p.pri_name,l.lot_num,l.block_num,l.plan_num,d.LOT_MASTER_AGREEMENT_ID from proj_lot_agreement a "+
                "join PROJ_LOT l on a.proj_lot_id = l.proj_lot_id "+
                "join PROJ_HEADER p on p.pri_id = l.pri_id "+
                "left outer join PROJ_LOT_MASTER_AGREEMENT_DETAIL d on d.LOT_AGREEMENT_ID = a.agreement_id "+
                "where a.agreement_id = "+ Agreement_ID.ToString();

                dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error loading header information:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0]["LOT_MASTER_AGREEMENT_ID"] == DBNull.Value || dt.Rows[0]["LOT_MASTER_AGREEMENT_ID"] == null)
                        {
                            lblHeader.Text = "Project: " + dt.Rows[0]["pri_code"] + "(" + dt.Rows[0]["pri_name"] + ")  Lot:" + dt.Rows[0]["lot_num"] + " Block:" + dt.Rows[0]["block_num"] + " Plan:" + dt.Rows[0]["plan_num"];
                        }
                        else
                        {
                            lblHeader.Text = "Project: " + dt.Rows[0]["pri_code"] + "(" + dt.Rows[0]["pri_name"] + ")  Master agreement, see lots panel.";
                            sql = "select l.lot_num,l.block_num,l.plan_num from proj_lot_agreement a "+
                                "join PROJ_LOT l on a.proj_lot_id = l.proj_lot_id "+
                                "join PROJ_HEADER p on p.pri_id = l.pri_id "+
                                "join PROJ_LOT_MASTER_AGREEMENT_DETAIL d on d.LOT_AGREEMENT_ID = a.agreement_id "+
                                "where d.LOT_MASTER_AGREEMENT_ID = " + dt.Rows[0]["LOT_MASTER_AGREEMENT_ID"];
                            dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                            if (hmCon.SQLExecutor.Exception != null)
                                popup.ShowPopup("Error loading grid:" + hmCon.SQLExecutor.Exception.Message);

                        }
                    }
                   
                }

            }

            gcLots.DataSource = dt;

        }


        private void FillWorkingTable(int AgreementID)
        {
            string sql = "LD_laa_AgreementEdit_Fill";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql);
            cmd.Connection = new System.Data.SqlClient.SqlConnection(hmCon.TRConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@agreement_id", SqlDbType.VarChar);

            cmd.Parameters["@username"].Value = hmCon.MLUser;
            cmd.Parameters["@agreement_id"].Value = AgreementID;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error :" + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }



        }

        private void luePurchaserType_EditValueChanged(object sender, EventArgs e)
        {
            
            
            if (!_bLoading)
            {
                ds_purchaser1.Clear();
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
                daPurchaser.Fill(ds_purchaser1);
            }

            int iPT = -1;
            try { iPT = Convert.ToInt32(oPT); }
            catch { }

            lueAssumedPurchaser.Properties.ReadOnly = !(iPT == 3 || iPT == 1);
            lueAssumedPurchaser.Properties.Buttons[1].Enabled = !lueAssumedPurchaser.Properties.ReadOnly;
            deAssumedDate.Properties.ReadOnly = lueAssumedPurchaser.Properties.ReadOnly;
            deAssumedDate.Properties.Buttons[1].Enabled = !deAssumedDate.Properties.ReadOnly;
        }



        private void UpdateTaxInfo()
        {

            string sql = "select gst.GST_PCT from CUSTOMERS c join GST_CODES gst on gst.GST_CODE = c.GST_CODE " +
                " where c.customer_id = " + luePurchaser1.EditValue;
            object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error in UpdateTaxInfo:" + hmCon.SQLExecutor.Exception.Message);

            ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["GST_PCT"] = result == null? DBNull.Value : result;

            sql = "select st.SALES_TAX from CUSTOMERS c left outer join SALES_TAXES st on st.SALES_TAX_ID = c.SALES_TAX_ID " +
                " where c.customer_id = " + luePurchaser1.EditValue;
            result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error in UpdateTaxInfo2:" + hmCon.SQLExecutor.Exception.Message);

            ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["PST_PCT"] = result == null ? DBNull.Value : result;


            double GST_PCT = 0, PST_PCT = 0, SellPrice = 0, GST_AMT = 0, PST_AMT = 0;

            try
            {
                GST_PCT = Convert.ToDouble(ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["GST_PCT"]);
            }
            catch
            {
            }
            try
            {
                PST_PCT = Convert.ToDouble(ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["PST_PCT"]);
            }
            catch
            {
            }
            try
            {
                SellPrice = Convert.ToDouble(teActualSellPrice.Text);
            }
            catch
            {
            }
            if (ceTax1.Checked)
                GST_AMT = SellPrice * GST_PCT / 100;
            if (ceTax2.Checked)
                PST_AMT = SellPrice * PST_AMT / 100;

            ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["TotalSellPrice"] = (SellPrice + GST_AMT + PST_AMT);
            


        }


        public bool isValid(bool update)
        {
            bool returnValue = true;
            layoutControlItem27.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem28.AppearanceItemCaption.ForeColor = Color.Black;

            if (luePurchaserType.EditValue == null || luePurchaserType.EditValue == DBNull.Value)
            {
                popup.ShowPopup("Purchaser type is required.");
                layoutControlItem27.AppearanceItemCaption.ForeColor = Color.Red;

                return false;
            }
            else if (luePurchaser1.EditValue == null || luePurchaser1.EditValue == DBNull.Value)
            {
                popup.ShowPopup("Primary Purchaser is required.");
                layoutControlItem28.AppearanceItemCaption.ForeColor = Color.Red;
                return false;
            }

            if (Convert.ToInt32(luePurchaserType.EditValue) == 2 && _ActionType == "NewMasterAgree" && _YearsForIndividualPurchases != 0)
            {
                popup.ShowPopup("Individual purchasers can not have a master agreement.");
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
                popup.ShowPopup(luePurchaser1.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                return false;
            }
            if (sPur2 != "null")
            {
                agreeNum = PurchaserOnOtherAgreement(Convert.ToInt32(sPur2), deSaleDate.DateTime, _AgreementID);
                if (agreeNum != -1)
                {
                    popup.ShowPopup(luePurchaser2.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                    return false;
                }
            }
            if (sPur3 != "null")
            {
                agreeNum = PurchaserOnOtherAgreement(Convert.ToInt32(sPur3), deSaleDate.DateTime, _AgreementID);
                if (agreeNum != -1)
                {
                    popup.ShowPopup(luePurchaser3.Text + " has an agreement within the individual years between purchases on agreement#" + agreeNum.ToString());
                    return false;
                }
            }
            if (deHOADate.EditValue != DBNull.Value)
            {
                if (deHOADate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    popup.ShowPopup("HOA date can not be prior to agreement date.");
                    return false;
                }
            }

            if (deSpecHomeStartDate.EditValue != DBNull.Value)
            {
                if (deSpecHomeStartDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    popup.ShowPopup("Spec home start date can not be prior to agreement date.");
                    return false;
                }
            }

            if (deShowHomeStartDate.EditValue != DBNull.Value)
            {
                if (deShowHomeStartDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
                {
                    popup.ShowPopup("Show home start date can not be prior to agreement date.");
                    return false;
                }
                //else if (deShowHomeCloseDate.EditValue != DBNull.Value)
                //{
                //    if (deShowHomeStartDate.DateTime.CompareTo(deShowHomeCloseDate.DateTime) > 0)
                //    {
                //        popup.ShowPopup("Show home close date can not be prior to show home start date.");
                //        return false;
                //    }
                //}
            }

            //if (deShowHomeCloseDate.EditValue != DBNull.Value)
            //{
            //    if (deShowHomeCloseDate.DateTime.CompareTo(deAgreeDate.DateTime) < 0)
            //    {
            //        popup.ShowPopup("Show home close date can not be prior to agreement date.");
            //        return false;
            //    }
            //}


            if (lueAssumedPurchaser.Text == "" && deAssumedDate.Text != "")
            {
                popup.ShowPopup("Assumed Purchaser is required when assumed Date has been set.");
                return false;
            }
            if (lueAssumedPurchaser.Text != "" && deAssumedDate.Text == "")
            {
                popup.ShowPopup("Assumed Date is required when assumed purchaser has been set.");
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
                //popup.ShowPopup("3rd Party Purchaser Info requires the Model, Elevation and Homebuilder to be set.");
                //return false;
                object oDRV = bs_proj_lot_agreement.Current;
                if (oDRV != null)
                {
                    DataRowView DRV = oDRV as DataRowView;
                    DataRow row = DRV.Row;
                    row.BeginEdit();
                    row["builder_models_id"] = DBNull.Value;
                    row.EndEdit();
                }
            }
            else
            {
                object oDRV = bs_proj_lot_agreement.Current;
                if (oDRV != null)
                {
                    DataRowView DRV = oDRV as DataRowView;
                    DataRow row = DRV.Row;
                    string sSelect = "select builder_models_id from LD_Builder_Models where Description='" + lueModel.EditValue + "' and Elevation='" + lueElevation.EditValue + "' and customer_id=" + lueHomeBuilder.EditValue;
                    row.BeginEdit();
                    object obj = hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection);
                    if (obj == null)
                        obj = DBNull.Value;
                    row["builder_models_id"] = obj;
                }
            }

            if (!ucMRR.ModelRepRulesValid())
            {
                tcThirdPartyPurchaser.SelectedTabPage = tpRepRules;
                popup.ShowPopup("All of the repetition rules are required to be filled out for the selected model.");
                return false;
            }

            if (!isGreaterThenZero(teDiscountPct.EditValue, true))
            {
                popup.ShowPopup("Discount percent must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teDiscountPct.EditValue) > 100)
            {
                popup.ShowPopup("Discount percent must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(tePenaltyPct.EditValue, true))
            {
                popup.ShowPopup("Penalty percent must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(tePenaltyPct.EditValue) > 100)
            {
                popup.ShowPopup("Penalty percent must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRMinIR.EditValue, true))
            {
                popup.ShowPopup("Min Regular Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRMinIR.EditValue) > 100)
            {
                popup.ShowPopup("Min Regular Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRIRS.EditValue, true))
            {
                popup.ShowPopup("Regular Interest Rate / Spread must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRIRS.EditValue) > 100)
            {
                popup.ShowPopup("Regular Interest Rate / Spread must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtRMaxIR.EditValue, true))
            {
                popup.ShowPopup("Max Regular Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtRMaxIR.EditValue) > 100)
            {
                popup.ShowPopup("Max Regular Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAMinIR.EditValue, true))
            {
                popup.ShowPopup("Min Arrears Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAMinIR.EditValue) > 100)
            {
                popup.ShowPopup("Min Arrears Interest Rate must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAIRS.EditValue, true))
            {
                popup.ShowPopup("Arrears Interest Rate / Spread must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAIRS.EditValue) > 100)
            {
                popup.ShowPopup("Arrears Interest Rate / Spread must be less then or equal to 100.");
                return false;
            }
            if (!isGreaterThenZero(txtAMaxIR.EditValue, true))
            {
                popup.ShowPopup("Max Arrears Interest Rate must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAMaxIR.EditValue) > 100)
            {
                popup.ShowPopup("Max Arrears Interest Rate must be less then or equal to 100.");
                return false;
            }

            if (!isGreaterThenZero(teDiscountAmt.EditValue, true))
            {
                popup.ShowPopup("Discount amount must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(teDiscountAmt.EditValue) > 922337203685477)
            {
                popup.ShowPopup("Discount amount is to large.");
                return false;
            }

            if (!isGreaterThenZero(tePen.EditValue, true))
            {
                popup.ShowPopup("Penalty amount must be greater then or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(tePen.EditValue) > 922337203685477)
            {
                popup.ShowPopup("Penalty amount is to large.");
                return false;
            }
            
            
            if (!ceUseCurrentPrice.Checked)
            {
                if (!isGreaterThenZero(teActualSellPrice.EditValue, true))
                {
                    popup.ShowPopup("Actual Sell Price must be greater then or equal to zero.");
                    return false;
                }
                else if (Convert.ToDecimal(teActualSellPrice.EditValue) > 922337203685477)
                {
                    popup.ShowPopup("Actual Sell Price is to large.");
                    return false;
                }
           
                if (!isGreaterThenZero(teActualDownPayment.EditValue, true))
                {
                    popup.ShowPopup("Actual Down Payment must be greater then or equal to zero.");
                    return false;
                }
                else if (Convert.ToDecimal(teActualDownPayment.EditValue) > 922337203685477)
                {
                    popup.ShowPopup("Actual Down Payment is to large.");
                    return false;
                }
            
                if (Convert.ToDouble(teActualSellPrice.EditValue).CompareTo(Convert.ToDouble(teActualDownPayment.EditValue)) < 0)
                {
                    popup.ShowPopup("Actual Down Payment must be less then Actual Sell Price.");
                    return false;
                }
            }
            object result = hmCon.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Primary purchaser is on probation and temporarily removed.' 	when Probation = 1 then 'Primary purchaser is on probation.' when Temp_Removed = 1 then 'Primary purchaser is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur1, hmCon.TRConnection);
            string purchaserMessage = "";
            if (result != null && result != DBNull.Value)
                purchaserMessage = result.ToString() + "\r\n";
            result = hmCon.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Purchaser 2 is on probation and temporarily removed.' 	when Probation = 1 then 'Purchaser 2 is on probation.' when Temp_Removed = 1 then 'Purchaser 2 is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur2, hmCon.TRConnection);


            if (result != null && result != DBNull.Value)
                purchaserMessage += result.ToString() + "\r\n";
            result = hmCon.SQLExecutor.ExecuteScalar("select case when Probation = 1 and Temp_Removed = 1 then 'Purchaser 3 is on probation and temporarily removed.' 	when Probation = 1 then 'Purchaser 3 is on probation.' when Temp_Removed = 1 then 'Purchaser 3 is temporarily removed.' else '' end from customers where CUSTOMER_ID = " + sPur3, hmCon.TRConnection);

            if (result != null && result != DBNull.Value)
                purchaserMessage += result.ToString() + "\r\n";

            if (purchaserMessage.Replace("\r\n", "").Trim() != "")
                if (popup.ShowPopup(purchaserMessage + "\r\n" + "Are you sure you want to continue?", WS_Popups.frmPopup.PopupType.Yes_No) != frmPopup.PopupResult.Yes)
                    return false;


            if (returnValue && update)
            {
                UpdateTaxInfo();
                bs_proj_lot_agreement.EndEdit();
                da_agreement.Update(ds_agreement1);
            }

            return returnValue;
        }



      


        public void ReloadAgreement()
        {
            _bLoading = true;
            ds_agreement1.Clear();
            da_agreement.Fill(ds_agreement1);
            _bLoading = false;
        }


        private void btnLoadFrom_Click(object sender, EventArgs e)
        {
            if (hasStandardTerms())
            {
                overwrite = false;
                bs_proj_lot_agreement.EndEdit();
                bs_proj_lot_agreement.CurrencyManager.EndCurrentEdit();
                da_agreement.Update(ds_agreement1);
                object oDRV = bs_proj_lot_agreement.Current;
                if (oDRV != null)
                {
                    DataRowView DRV = oDRV as DataRowView;
                    if (isValid(false))
                    {
                        if (ShowDatePopup())
                        {
                            SetStandardTermsDefault();
                            LoadStandardTermsDeposits();
                            LoadStandardTermsLevies();
                            LoadStandardTermsDiscounts();
                        }                        
                    }
                }
            }
        }

        private bool ShowDatePopup()
        {
            bool returnValue = false;
            using (frmAgreementDateSelection frm = new frmAgreementDateSelection(hmCon, tuc_mgr))
            {

                if (popup.ShowPopup("Would you like to overwrite existing dates?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                {
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        returnValue = true;

                        overwrite = true;
                        deAgreeDate.EditValue = DBNull.Value;
                        deSaleDate.EditValue = DBNull.Value;
                        deClosingDate.EditValue = DBNull.Value;
                        deIntAdjDate.EditValue = DBNull.Value;
                        deArrIntDate.EditValue = DBNull.Value;
                        deExpPayDate.EditValue = DBNull.Value;
                        deOrgArrDate.EditValue = DBNull.Value;
                        deEstReleaseDate.EditValue = DBNull.Value;
                        deActualReleaseDate.EditValue = DBNull.Value;
                        

                        AdditionalDateChanged(1, true, "'" + frm.deAgreementDate.EditValue.ToString() + "'");
                        AdditionalDateChanged(3, true, "'" + frm.deSaleDate.EditValue.ToString() + "'");

                        ceUseCurrentPrice.EditValue = frm.ceUseCurrentPrice.EditValue;
                        teActualSellPrice.EditValue = frm.seSellPrice.EditValue;

                        bs_proj_lot_agreement.EndEdit();

                    }
                }
                else
                    returnValue = true;
            }

            return returnValue;
        }

        private bool hasStandardTerms()
        {
            bool returnValue = false;
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                    lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                string sql = "select count(*) from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"].ToString() + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + " and SALES_TYPE_ID = " + lueSaleType.EditValue;
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting standard terms defaults:");
                else if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) != 0)
                        returnValue = true;
                    else
                        popup.ShowPopup("No standard term defaults have been setup.");
                }
                layoutControlItem15.AppearanceItemCaption.ForeColor = Color.Black;
                layoutControlItem27.AppearanceItemCaption.ForeColor = Color.Black;
                layoutControlItem28.AppearanceItemCaption.ForeColor = Color.Black; 
            }
            else
            {
                if (luePurchaserType.EditValue == null || luePurchaserType.EditValue == DBNull.Value)
                {
                    popup.ShowPopup("Purchaser type is required to load standard terms.");
                    layoutControlItem27.AppearanceItemCaption.ForeColor = Color.Red; 
                }
                else
                {
                    popup.ShowPopup("Sale type is required to load standard terms.");
                    layoutControlItem15.AppearanceItemCaption.ForeColor = Color.Red;
                }
            }

            return returnValue;
        }

        private void SetStandardTermsDefault()
        {
            if (luePurchaserType.EditValue != null && luePurchaserType.EditValue != DBNull.Value &&
                lueSaleType.EditValue != null && lueSaleType.EditValue != DBNull.Value)
            {
                
                string SQL = "select REG_LD_RATETYPE_ID,REG_LD_RATE_BASED_ON_ID,REG_LD_FREQUENCY_ID,REG_INTEREST_MIN,REG_INTEREST_SPREAD,REG_INTEREST_MAX, " +
                "ARR_LD_RATETYPE_ID,ARR_LD_RATE_BASED_ON_ID,ARR_LD_FREQUENCY_ID,ARR_INTEREST_MIN,ARR_INTEREST_SPREAD,ARR_INTEREST_MAX, PRIMESOURCE_LD_LENDER_ID,"+
                "CompoundUponArrears,MONTH_OFFSET_INTEREST,MONTH_OFFSET_MATURITY ,standard_terms_det_ID " +
                "from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"].ToString() + " and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + " and SALES_TYPE_ID = " + lueSaleType.EditValue;

                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(SQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting standard terms defaults:");
                else if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        _bLoading = true;
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
                        ceCompoundUponArrears.EditValue = row["CompoundUponArrears"];
                        luePrimeSource.EditValue = row["PRIMESOURCE_LD_LENDER_ID"];


                        if (overwrite)
                        {
                            if (!HasOffsetDate(4))//if there is no offset date use the standard terms default.
                            {
                                if (row["MONTH_OFFSET_INTEREST"] != DBNull.Value && row["MONTH_OFFSET_INTEREST"] != null)
                                    deIntAdjDate.EditValue = deSaleDate.DateTime.AddMonths(Convert.ToInt32(row["MONTH_OFFSET_INTEREST"]));
                                else
                                    deIntAdjDate.EditValue = deSaleDate.EditValue;
                                bs_proj_lot_agreement.EndEdit();
                                da_agreement.Update(ds_agreement1);
                                AdditionalDateChanged(4, true, "'" + deIntAdjDate.EditValue.ToString() + "'");
                            }

                            if (!HasOffsetDate(5))//if there is no offset date use the standard terms default.
                            {
                                if (row["MONTH_OFFSET_MATURITY"] != DBNull.Value && row["MONTH_OFFSET_MATURITY"] != null)
                                    deArrIntDate.EditValue = deOrgArrDate.EditValue = deSaleDate.DateTime.AddMonths(Convert.ToInt32(row["MONTH_OFFSET_MATURITY"]));
                                else
                                    deArrIntDate.EditValue = deOrgArrDate.EditValue = deSaleDate.EditValue;
                                bs_proj_lot_agreement.EndEdit();
                                da_agreement.Update(ds_agreement1);
                                AdditionalDateChanged(5, true, "'" + deArrIntDate.EditValue.ToString() + "'");
                            }
                        }
                        bs_proj_lot_agreement.EndEdit();
                        ((DataRowView)bs_proj_lot_agreement.Current).Row["LoadedFromSetup"] = true;
                        ((DataRowView)bs_proj_lot_agreement.Current).Row["ld_standard_terms_det_ID"] = row["standard_terms_det_ID"];
                        //ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["LoadedFromSetup"] = true;
                        bs_proj_lot_agreement.EndEdit();
                        da_agreement.Update(ds_agreement1);
                        _bLoading = false;
                        popup.ShowPopup("Defaults Loaded.");
                    }
                    else
                        popup.ShowPopup("No standard term defaults have been setup.");
                }
            }
        }

        private bool HasOffsetDate(int AddDateID)
        {
            bool returnValue = true;
            string sql = "select OffsetDate_ID from  working_ld_laa_Proj_Agreement_AddDates "+
	            " where Agreement_ID = "+_AgreementID+" and AdditionalDates_ID = "+AddDateID.ToString()+" and username = '"+hmCon.MLUser+"'";
            object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for offset date." + hmCon.SQLExecutor.Exception.Message);
            else
            {
                if (result == null || result == DBNull.Value)
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }

        public void UpdateMe()
        {//called on back click.
            //avoids concurrency violation
            da_agreement.Fill(ds_agreement1);
            //remove any deposits, levies or additional dates from NON primary agreements
            string sql = @"delete working_ld_laa_proj_lot_agreement_deposits 
            where username = '" + hmCon.MLUser + @"' and
            agreement_id not in(select a.agreement_id from working_ld_laa_proj_lot_agreement a where a.username = '" + hmCon.MLUser + @"' and 
            isnull(a.isPrimary,0) = 1)
        
            delete working_ld_laa_proj_lot_agreement_levy 
            where username = '" + hmCon.MLUser + @"' and
            agreement_id not in(select a.agreement_id from working_ld_laa_proj_lot_agreement a where a.username = '" + hmCon.MLUser + @"' and 
            isnull(a.isPrimary,0) = 1)

            delete working_ld_laa_Proj_Agreement_AddDates
            where username = '" + hmCon.MLUser + @"' and agreement_id not in(select a.agreement_id from working_ld_laa_proj_lot_agreement a where a.username = '" + hmCon.MLUser + @"' and isnull(a.isPrimary,0) = 1)
             ";
            hmCon.SQLExecutor.ExecuteNonQuery(@sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error removing deposits, levies and additional dates: " + hmCon.SQLExecutor.Exception.Message);            
        }

        private void LoadStandardTermsLevies()
        {
            bool bLoadStdLevies = false;
            string sSQL = @"select COUNT(*) from working_ld_laa_proj_lot_agreement_levy where username='"+hmCon.MLUser+@"'";
            object oCNT = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
            if (oCNT == null || oCNT == DBNull.Value)
                oCNT = 0;

            if( Convert.ToInt32(oCNT) > 0)
            {
                frmPopup.PopupResult pResult = popup.ShowPopup("Levies exist for this agreement, would you like to replace them with the standard terms levies?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    sSQL = @"delete from working_ld_laa_proj_lot_agreement_levy where isnull(matched,0) = 0 and username='" + hmCon.MLUser + @"'";
                    hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
                    dsLevies.Clear();                    
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
                sSQL = @"select STANDARD_TERMS_DET_ID 
                from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"]+ @" and PURCHASER_TYPE_ID = " + luePurchaserType.EditValue + @" and SALES_TYPE_ID = " + lueSaleType.EditValue;
                object oSTANDARD_TERMS_DET_ID = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting standard terms levies:" + hmCon.SQLExecutor.Exception.Message);
                else if (oSTANDARD_TERMS_DET_ID != null && oSTANDARD_TERMS_DET_ID != DBNull.Value)
                {
                    if (bLoadStdLevies)
                    {
                        bool bIsMasterAgree = false;
                        if (ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["proj_lot_id"].ToString() == "-1")
                            bIsMasterAgree = true;

                        if (!bIsMasterAgree)
                        {
                            int iProjLot_ID = Convert.ToInt32(ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["proj_lot_id"]);
                            sSQL = @"declare @lot_class_id int, @proj_lot_id int

                            select @proj_lot_id = " + iProjLot_ID + @"

                            select @lot_class_id=l.lot_class_id
                            from PROJ_LOT l  
                            where l.proj_lot_id=@proj_lot_id

                            insert into working_ld_laa_proj_lot_agreement_levy (username, agreement_id, LD_Levy_ID, lv1id, lv2id, lv3id, lv4id, Amount, Supplier_ID)
                            select '" + hmCon.MLUser + @"', -1, LD_Levy_ID, lv1id, lv2id, lv3id, lv4id, Amount, Supplier_ID
                            from LD_Standard_Terms_Levy_Det
                            where isnull(lot_class_id,-1) in (-1, @lot_class_id) and LD_StandardTerms_Det_ID=" + oSTANDARD_TERMS_DET_ID;
                            hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);

                            dsLevies.Clear();
                            daLevies.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
                            daLevies.SelectCommand.Parameters["@agreement_id"].Value = -1;
                            daLevies.Fill(dsLevies);
                        }
                    }                    
                }
            }
        }

        private void LoadStandardTermsDeposits()
        {
            bool bLoadStdDeposits = false;
            if (gvDeposits.RowCount > 0)
            {
                frmPopup.PopupResult pResult = popup.ShowPopup("Deposits exist for this agreement, would you like to replace them with the standard terms deposits?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    string sSQL = @"delete from working_ld_laa_proj_lot_agreement_deposits where username='" + hmCon.MLUser + @"' and agreement_id=" + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"];
                    hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
                    ds_deposits1.Clear();
                    da_Deposits.Fill(ds_deposits1);
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
                object oPURCHASER_TYPE_ID = luePurchaserType.EditValue;
                if (oPURCHASER_TYPE_ID == null || oPURCHASER_TYPE_ID == DBNull.Value)
                    oPURCHASER_TYPE_ID = -1;

                object oSALES_TYPE_ID = lueSaleType.EditValue;
                if (oSALES_TYPE_ID == null || oSALES_TYPE_ID == DBNull.Value)
                    oSALES_TYPE_ID = -1;

                string SQL = @"select STANDARD_TERMS_DET_ID 
                    from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"].ToString() + @"
                    and PURCHASER_TYPE_ID = " + oPURCHASER_TYPE_ID + @" and SALES_TYPE_ID = " + oSALES_TYPE_ID;

                object result = hmCon.SQLExecutor.ExecuteScalar(SQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting standard terms deposits:" + hmCon.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    double value = 0;
                    try
                    {
                        if (ceUseCurrentPrice.Checked)
                        {
                           object oresult = hmCon.SQLExecutor.ExecuteScalar("select case when ISNULL(current_price,0) = 0 then ISNULL(original_price,0) else current_price end from PROJ_LOT where proj_lot_id = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["proj_lot_id"].ToString(), hmCon.TRConnection);
                           if (hmCon.SQLExecutor.Exception != null)
                               popup.ShowPopup("Error getting current price from lot:"+hmCon.SQLExecutor.Exception.Message);
                           try
                           {
                                value = Convert.ToDouble(oresult);
                           }
                           catch { value = 0; }
                        }
                        else
                            value = Convert.ToDouble(teActualSellPrice.Text);
                    }
                    catch { }

                    if (bLoadStdDeposits)
                    {
                        string percentCalc;
                        //if its a master agreement put null for amount of percent deposits.
                        if (ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["proj_lot_id"].ToString() == "-1" && ceUseCurrentPrice.Checked)
                            percentCalc = "null";
                        else
                            percentCalc = value.ToString() + " * AmountPercent / 100";


                        SQL = "select case when isnull(DepositType,'A') = 'A' then AmountPercent else " + percentCalc + " end, LD_Deposits_ID,off_set_days,ID,PresaleSeq " +
                            "from LD_Standard_Terms_Deposits_Det " +
                            "where LD_StandardTerms_Det_ID = " + result.ToString();
                        DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(SQL, hmCon.TRConnection);
                        if (hmCon.SQLExecutor.Exception != null)
                            popup.ShowPopup("Error setting standard terms defaults:" + SQL);
                        else if (dt != null)
                        {
                            int count = -1;
                            foreach (DataRow row in dt.Rows)
                            {
                                ds_deposits1.working_ld_laa_proj_lot_agreement_deposits.Rows.Add(
                                    new object[] { count, hmCon.MLUser, ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"], row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3],DBNull.Value,row.ItemArray[4] });
                                count -= 1;
                            }
                            da_Deposits.Update(ds_deposits1);
                        }
                    }
                    LoadActualDownPayment(value, result);
                }
            }
        }

        private void LoadStandardTermsDiscounts()
        {
            bool bLoadStdDiscounts = false;
            if (gvDiscounts.RowCount > 0)
            {
                frmPopup.PopupResult pResult = popup.ShowPopup("Discounts exist for this agreement, would you like to replace them with the standard terms discounts?", frmPopup.PopupType.Yes_No);
                if (pResult == frmPopup.PopupResult.Yes)
                {
                    string sSQL = @"delete from working_ld_laa_proj_lot_agreement_discounts where username='" + hmCon.MLUser + @"' and agreement_id=" + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"];
                    hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
                    ds_Discounts1.Clear();
                    da_Discounts.Fill(ds_Discounts1);
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
                object oPURCHASER_TYPE_ID = luePurchaserType.EditValue;
                if (oPURCHASER_TYPE_ID == null || oPURCHASER_TYPE_ID == DBNull.Value)
                    oPURCHASER_TYPE_ID = -1;

                object oSALES_TYPE_ID = lueSaleType.EditValue;
                if (oSALES_TYPE_ID == null || oSALES_TYPE_ID == DBNull.Value)
                    oSALES_TYPE_ID = -1;

                string SQL = @"select STANDARD_TERMS_DET_ID 
                    from LD_Standard_Terms_det where PRI_ID = " + ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["pri_id"].ToString() + @"
                    and PURCHASER_TYPE_ID = " + oPURCHASER_TYPE_ID + @" and SALES_TYPE_ID = " + oSALES_TYPE_ID;

                object result = hmCon.SQLExecutor.ExecuteScalar(SQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting standard terms discounts:" + hmCon.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    

                    if (bLoadStdDiscounts)
                    {
 

                        SQL = "select LD_Standard_Terms_Det_ID, LD_Discounts_ID, Type, Value " +
                            "from LD_Standard_Terms_Discounts_Det " +
                            "where LD_Standard_Terms_Det_ID = " + result.ToString();
                        DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(SQL, hmCon.TRConnection);
                        if (hmCon.SQLExecutor.Exception != null)
                            popup.ShowPopup("Error setting standard terms discount defaults:" + SQL+"    "+ hmCon.SQLExecutor.Exception.Message);
                        else if (dt != null)
                        {
                            int count = -1;
                            foreach (DataRow row in dt.Rows)
                            {
                                ds_Discounts1.working_ld_laa_proj_lot_agreement_discounts.Rows.Add(
                                    new object[] { count, hmCon.MLUser, ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3],DBNull.Value, false,DBNull.Value, DBNull.Value });
                                count -= 1;
                            }
                            da_Discounts.Update(ds_Discounts1);
                        }
                    }
                    
                }
            }
        }
        private void LoadActualDownPayment(double dSaleAmount, object oStd_Terms_Det_ID)
        {
            if (ceUseCurrentPrice.Checked)
            {
                teActualDownPayment.EditValue = DBNull.Value;
                teActualDownPayment.Enabled = false;
            }
            //else
            //{
                string sSQL = @"exec LD_CalcDownPayment " + oStd_Terms_Det_ID + @", " + _AgreementID + @", " + dSaleAmount + @", 'T', '" + hmCon.MLUser + @"'";
                object oResult = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting down payment:" + hmCon.SQLExecutor.Exception.Message);
                if (oResult == null || oResult == DBNull.Value)
                    oResult = 0;
                teActualDownPayment.EditValue = Convert.ToDouble(oResult);
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds_lookups1.Clear();
            da_lookups.Fill(ds_lookups1);

            ds_purchaser1.Clear();
            object oPT = luePurchaserType.EditValue;
            if (oPT != null && oPT != DBNull.Value)
            {
                daPurchaser.SelectCommand.Parameters["@purchaser_type_id"].Value = oPT;
                daPurchaser.Fill(ds_purchaser1);
            }
        }


        private void gvDeposits_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;

            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { coldeposit_id, coldeposit_amt, coloff_set_days, }, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[coldeposit_amt.FieldName], false))
            {
                popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (DepositGreaterThenSellPrice(((DataRowView)e.Row)))
            {
                popup.ShowPopup("Total deposits can not be greater then sell price.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (isPreSaleSeqInvalid((DataRowView)e.Row))
            {
                popup.ShowPopup("Pre-sale sequence must be between 1 and 10.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }

        }

        private bool DepositGreaterThenSellPrice(DataRowView view)
        {
            bool returnValue = false;
            string sql = @"select a.sell_price -isnull( (select SUM(deposit_amt) +" + view[coldeposit_amt.FieldName].ToString() + " from proj_lot_agreement_deposits d where d.agreement_id = a.agreement_id and d.id <> " + view[colid.FieldName].ToString() + " ,0) " +
                "from working_ld_laa_proj_lot_agreement a where a.isPrimary = 1 and a.username = '"+hmCon.MLUser+"'";
            object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
            if (result != null && result != DBNull.Value)
            {
                if (Convert.ToDouble(result) < 0)
                    returnValue = true;
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
            double dValue = -1;
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
        private bool isPreSaleSeqInvalid(DataRowView drv)
        {
            bool returnValue = false;
            if (isTierPresale)
            {
                if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(drv[coldeposit_id.FieldName])).Type == "P")
                {
                    int PresaleSeq = -1;
                    try
                    {
                        PresaleSeq = Convert.ToInt32(drv[colPresaleSeq.FieldName]);
                    }
                    catch { }
                    if (PresaleSeq > 10 || PresaleSeq < 1)
                        returnValue = true;
                }

            }


            return returnValue;
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

            LookUpEdit lue = (LookUpEdit)sender;
            if(lue.EditValue != null && lue.EditValue != DBNull.Value && isTierPresale)
            {
                try
                {
                    if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(lue.EditValue)).Type == "P")
                    {
                        object sequence = hmCon.SQLExecutor.ExecuteScalar(@"
select max(isnull(t.presaleseq,0)) from working_ld_laa_proj_lot_agreement_deposits t
join LD_Deposits d on d.Deposit_ID = t.Deposit_ID
where d.Type = 'P' and t.username = '"+hmCon.MLUser+"' and t.agreement_id =" + _AgreementID, hmCon.TRConnection);
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

        private void gvDeposits_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvDeposits.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colagreement_id.FieldName] = ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"];
                row[colusername.FieldName] = hmCon.MLUser;

            }
        }

        private void teActualSellPrice_Leave(object sender, EventArgs e)
        {
            if (this.Disposing) return;
            if(teActualSellPrice.EditValue != DBNull.Value && teActualSellPrice.EditValue != null)
            {
                string sql = @"select COUNT(d.ID) from working_ld_laa_proj_lot_agreement_deposits d
                        join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                        where username = '"+ hmCon.MLUser +"' and dep.DepositType = 'P'";
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error checking for percentage deposits:"+hmCon.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) > 0)
                    {
                        if (popup.ShowPopup("Would you like to re-calculate deposit amounts?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        {
                            sql = @"update working_ld_laa_proj_lot_agreement_deposits set
                                deposit_amt = " + teActualSellPrice.Text.ToString().Replace(",", "") + @" * dep.AmountPercent / 100 
                                from working_ld_laa_proj_lot_agreement_deposits d
                                join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                                where username = '" +hmCon.MLUser+"' and dep.DepositType = 'P'";
                            hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                            if (hmCon.SQLExecutor.Exception != null)
                                popup.ShowPopup("Error setting percentage deposits:"+hmCon.SQLExecutor.Exception.Message);
                            ds_deposits1.Clear();
                            da_Deposits.Fill(ds_deposits1);

                            if (((DataRowView)bs_proj_lot_agreement.Current)["ld_standard_terms_det_ID"] != DBNull.Value)
                            {
                                sql = "declare @SaleAmt money =" + teActualSellPrice.Text.ToString().Replace(",", "") + "  exec [LD_CalcDownPayment] " + ((DataRowView)bs_proj_lot_agreement.Current)["ld_standard_terms_det_ID"].ToString() +
                                    ", " + _AgreementID + ", @SaleAmt output, 'T', '"+hmCon.MLUser+"'   select @SaleAmt";
                                result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                                teActualDownPayment.EditValue = result;
                            }

                        }
                    }
                }
                
            }
        }


        private void Load3rdPartyPurch(int _AgreementID)
        {
            ds3Builder.Clear();
            ds3Elevation.Clear();
            ds3Model.Clear();

            string sSelect = @"select builder_models_id, model_desc, elevation, homebuilder_id from proj_lot_agreement where agreement_id=" + _AgreementID;
            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSelect, hmCon.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        object oBM_ID = dr[0];
                        object oMOD = dr[1];
                        object oELE = dr[2];
                        object oHB_ID = dr[3];

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
                }
                else
                {
                    da3Model.SelectCommand.Parameters["@elevation"].Value = DBNull.Value;
                    da3Model.SelectCommand.Parameters["@builder_id"].Value = DBNull.Value;
                    da3Model.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                    ds3Model.Clear();
                    da3Model.Fill(ds3Model);

                    da3Elevation.SelectCommand.Parameters["@Model"].Value = DBNull.Value;
                    da3Elevation.SelectCommand.Parameters["@builder_id"].Value = DBNull.Value;
                    da3Elevation.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                    ds3Elevation.Clear();
                    da3Elevation.Fill(ds3Elevation);

                    da3Builder.SelectCommand.Parameters["@elevation"].Value = DBNull.Value;
                    da3Builder.SelectCommand.Parameters["@Model"].Value = DBNull.Value;
                    da3Builder.SelectCommand.Parameters["@builder_models_id"].Value = DBNull.Value;
                    ds3Builder.Clear();
                    da3Builder.Fill(ds3Builder);
                }
            }
            LoadRepRules();
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
            object oBM_ID = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
            if (oBM_ID == null || oBM_ID == DBNull.Value)
                oBM_ID = -1;

            ucMRR.LoadModel(GetLotID(), Convert.ToInt32(oBM_ID), _AgreementID);
        }

        private void lue3PP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                if (sender != null)
                {
                    LookUpEdit lue = sender as LookUpEdit;
                    if (lue != null)
                    {
                        lue.EditValue = DBNull.Value;
                        ucMRR.LoadModel(GetLotID(), -1, _AgreementID);
                    }
                }
            }
        }

        private int GetLotID()
        {
            int lotID = -1;
            if (_ActionType.Equals("Edit"))
            {
                lotID = _LotID;
            }
            else
            {
                object oID = hmCon.SQLExecutor.ExecuteScalar("select proj_lot_id from working_ld_lotsearch where username = '" + hmCon.MLUser + "LotAgreementAssistant' and selected = 1", hmCon.TRConnection);
                if (oID == null || oID == DBNull.Value)
                    oID = -1;
                lotID = Convert.ToInt32(oID);
            }

            return lotID;
        }

        public void SaveRepRules(int AgreementID)
        {
            ucMRR.SaveRepetitonRules(AgreementID);
        }

        private void luePurchaser1_EditValueChanged(object sender, EventArgs e)
        {
            if (_bLoading) return;

            if (luePurchaser1.EditValue != DBNull.Value && luePurchaser1.EditValue != null)
            {
                if (luePurchaserType.EditValue.ToString() == "1" || luePurchaserType.EditValue.ToString() == "3")
                {
                    if (lueHomeBuilder.EditValue == null || lueHomeBuilder.EditValue == DBNull.Value)
                    {
                        lueHomeBuilder.EditValue = luePurchaser1.EditValue;
                    }
                }
            }
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
        void gGridAgreeDates_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            if (row != null)
            {
                bs_proj_lot_agreement.EndEdit();
                da_agreement.Update(ds_agreement1);
                AdditionalDateChanged(Convert.ToInt32(row[colID1.FieldName]), false,"null");
                
                _bLoading = true;
                ds_agreement1.Clear();
                da_agreement.Fill(ds_agreement1);
                _bLoading = false;
            }
        }

        private void AdditionalDateChanged(int ID, bool isKeyDate,string date)
        {
            _bLoading = true;
            bs_proj_lot_agreement.EndEdit();
            da_agreement.Update(ds_agreement1);
            if (date == "'1/1/0001'") date = "null";
            string sql = "exec LD_laa_AgreeAdditionalDateUpdate " + _AgreementID.ToString() + "," + ID.ToString() + "," + (isKeyDate ? "1" : "0")+",'"+hmCon.MLUser+"',"+date;
            hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error updating additional dates:" + hmCon.SQLExecutor.Exception.Message);
            
            da_AdditionalDates.Fill(ds_AdditionalDates1);
            ds_agreement1.Clear();
            da_agreement.Fill(ds_agreement1);
            _bLoading = false;
        }

        

        #region AdditionalDates EditValueChanged
        private void deAgreeDate_EditValueChanged(object sender, EventArgs e)
        {
            
            if (!_bLoading)
                AdditionalDateChanged(1, true, "'" + deAgreeDate.DateTime.ToShortDateString() + "'");
        }

        private void deClosingDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(2, true, "'" + deClosingDate.DateTime.ToShortDateString() + "'");
        }

        private void deSaleDate_EditValueChanged(object sender, EventArgs e)
        {
            
            if (!_bLoading)
                AdditionalDateChanged(3, true, "'" + ((DateEdit)sender).DateTime.ToShortDateString() + "'");
        }

        private void deIntAdjDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(4, true, "'" + deIntAdjDate.DateTime.ToShortDateString() + "'");
        }

        private void deArrIntDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(5, true, "'" + deArrIntDate.DateTime.ToShortDateString() + "'");
        }

        private void deExpPayDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(6, true, "'" + deExpPayDate.DateTime.ToShortDateString() + "'");
        }

        private void deOrgArrDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(7, true, "'" + deOrgArrDate.DateTime.ToShortDateString() + "'");
        }

        private void deEstReleaseDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(8, true, "'" + deEstReleaseDate.DateTime.ToShortDateString() + "'");
        }

        private void deActualReleaseDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLoading)
                AdditionalDateChanged(9, true, "'" + deActualReleaseDate.DateTime.ToShortDateString() + "'");
        }

        #endregion AdditionalDates EditValueChanged

        private void gvAdditionalDates_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;

            if (!isGreaterThenZero(rv[colOffsetDays.FieldName], true))
            {
                popup.ShowPopup("Offset days can not be less then zero.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (e.Valid && rv[colOffsetDate_ID.FieldName] != DBNull.Value)
            {
                string sql = "exec LD_laa_Agreement_AdditionalDatesValidation " + rv[colAdditionalDates_ID.FieldName].ToString() + "," + rv[colOffsetDate_ID.FieldName].ToString() + ", " + _AgreementID.ToString() + ", '" + hmCon.MLUser + "' ";
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error validating additional date selection." + hmCon.SQLExecutor.Exception.Message);
                if (result != null && result != DBNull.Value)
                {
                    if (result.ToString().ToLower() != "ok")
                    {
                        popup.ShowPopup(result.ToString());
                        e.ErrorText = "DeveloperThrownError";
                        e.Valid = false;
                    }
                }
                else
                {
                    popup.ShowPopup("Unknown error, Invalid value returned.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
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

        private void ceThirdPartyPurchase_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceThirdPartyPurchase.EditValue); }
            catch { }

            deThirdPartyPurchaseDate.Properties.ReadOnly = !bChecked;
        }

        private void ceSpecHome_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceSpecHome.EditValue); }
            catch { }

            deSpecHomeStartDate.Properties.ReadOnly = !bChecked;
        }

        private void ceShowHome_EditValueChanged(object sender, EventArgs e)
        {
            bool bChecked = false;
            try { bChecked = Convert.ToBoolean(ceShowHome.EditValue); }
            catch { }

            deShowHomeStartDate.Properties.ReadOnly = !bChecked;
        }

        
        private DateTime? GetOffsetDateTime(DataRow row)
        {
            DateTime? returnDate = null;
            if (row[colOffsetDate_ID.FieldName] != DBNull.Value)
            {

                string sql = "select date from working_ld_laa_Proj_Agreement_AddDates where Agreement_ID = " + _AgreementID + " and AdditionalDates_ID = " + row[colOffsetDate_ID.FieldName].ToString();
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting offset date: " + hmCon.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    returnDate = Convert.ToDateTime(result);

                }
                else//no result see if its a key date
                {
                    int KeyDateID = -1;
                    try
                    {
                        KeyDateID = Convert.ToInt32(row[colOffsetDate_ID.FieldName]);
                    }
                    catch{}

                    switch(KeyDateID)
                    {
                        case 1:
                            returnDate = deAgreeDate.DateTime;
                            break;
                        case 2:
                            returnDate = deClosingDate.DateTime;
                            break;
                        case 3:
                            returnDate = deSaleDate.DateTime;
                            break;
                        case 4:
                            returnDate = deIntAdjDate.DateTime;
                            break;
                        case 5:
                            returnDate = deArrIntDate.DateTime;
                            break;
                        case 6:
                            returnDate = deExpPayDate.DateTime;
                            break;
                        case 7:
                            returnDate = deOrgArrDate.DateTime;
                            break;
                        case 8:
                            returnDate = deEstReleaseDate.DateTime;
                            break;
                        case 9:
                            returnDate = deActualReleaseDate.DateTime;
                            break;
                    }
                     
                }

                if (returnDate == DateTime.MinValue)
                    returnDate = null;

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
            ((LookUpEdit)sender).EditValue = DBNull.Value;
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
            popup.ShowPopup("Date cannot be changed when an offset date is set. Use offset days to change the date.");
        }

        private void ceUseCurrentPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (_bLoading || ceUseCurrentPrice.EditValue == null || ceUseCurrentPrice.EditValue == DBNull.Value) return;
            teActualSellPrice.Enabled = !ceUseCurrentPrice.Checked;
            if (ceUseCurrentPrice.Checked)
            {

                teActualSellPrice.EditValue = DBNull.Value;
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("select ISNULL(proj_lot_id,0) from working_ld_laa_proj_lot_agreement where username = '" + hmCon.MLUser + "'", hmCon.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count >= 1)
                    {
                        if (dt.Rows[0][0] != DBNull.Value)
                            teActualSellPrice.EditValue = hmCon.SQLExecutor.ExecuteScalar("select isnull(current_price,0) from PROJ_LOT where proj_lot_id = " + dt.Rows[0][0].ToString(), hmCon.TRConnection);
                    }
                }
                
                
            }
            else
            {
                teActualSellPrice.EditValue = 0.00;
                teActualDownPayment.Enabled = true;
                teActualDownPayment.EditValue = 0;
                teActualSellPrice.Focus();
            }
        }

        private void ri_lueAdditionalDates_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            int ID = Convert.ToInt32(row[colAdditionalDates_ID.FieldName]);
            if (ID == 1 /*Agreement*/|| ID == 2 /*Sale*/|| ID == 3/*Closing*/)
            {
                popup.ShowPopup("Agreement Date, Sale Date and Closing Date can not have an offset date.");
                e.Cancel = true;
            }

        }

        private void KeyDates_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
            if (_bLoading) return;
            if (sender != null && e.NewValue != DBNull.Value && e.NewValue != null)
            {
                if (sender is DateEdit)
                {
                           DateEdit de = (DateEdit)sender;

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

                            object result = hmCon.SQLExecutor.ExecuteScalar("select OffsetDate_ID from LD_Proj_Agreement_AddDates where Agreement_ID =" + _AgreementID.ToString() + " and AdditionalDates_ID =" + KeyDateID, hmCon.TRConnection);
                            if (hmCon.SQLExecutor.Exception != null)
                            {
                                popup.ShowPopup("Error checking for offset date:" + hmCon.SQLExecutor.Exception.Message);
                                e.Cancel = true;
                            }
                            else if (result != null && result != DBNull.Value)
                            {
                                popup.ShowPopup("Date cannot be changed when an offset date is set. Use offset days in the agreenemt dates grid to change the date.");
                                e.Cancel = true;
                            }

                            DateTime ?newDate = null;

                            try
                            {
                                newDate = Convert.ToDateTime(e.NewValue);
                            }
                            catch{}

                            if (newDate == null) return;
                            
                            if (KeyDateID != "1" && deAgreeDate.DateTime.CompareTo(newDate) > 0)
                            {
                                popup.ShowPopup(DateName + " Date can not be less then the agreement date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deClosingDate.DateTime.CompareTo(newDate) < 0 && deClosingDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then closing date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deSaleDate.DateTime.CompareTo(newDate) < 0 && deSaleDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then sales date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deIntAdjDate.DateTime.CompareTo(newDate) < 0 && deIntAdjDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then interest adjustment date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deArrIntDate.DateTime.CompareTo(newDate) < 0 && deArrIntDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then arrears interest date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deExpPayDate.DateTime.CompareTo(newDate) < 0 && deExpPayDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then expected payout date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deOrgArrDate.DateTime.CompareTo(newDate) < 0 && deOrgArrDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then original arrears date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deEstReleaseDate.DateTime.CompareTo(newDate) < 0 && deEstReleaseDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then estimated release date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deActualReleaseDate.DateTime.CompareTo(newDate) < 0 && deActualReleaseDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then actual release date.");
                                e.Cancel = true;
                            }
                            else if (KeyDateID == "1" && deAssumedDate.DateTime.CompareTo(newDate) < 0 && deAssumedDate.EditValue != DBNull.Value)
                            {
                                popup.ShowPopup("Agreement date can not be greater then assumed date.");
                                e.Cancel = true;
                            }
                            
                        
                    
                }
            }
            
        }

       

        private void lueSaleType_Leave(object sender, EventArgs e)
        {
            bs_proj_lot_agreement.EndEdit();
            bool preSale = false;
            try
            {
                if (Convert.ToInt32(lueSaleType.EditValue) == 1)
                    preSale = true;
            }
            catch { }

            ds_agreement1.Tables[0].Rows[0]["pre_sale"] = preSale;
        }

        private void gvDeposits_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow row = gvDeposits.GetDataRow(e.RowHandle);
            if (row.RowState != DataRowState.Added && row.RowState != DataRowState.Detached)
            {
                if (row[coldeposit_amt.FieldName] == DBNull.Value)
                {
                    if (e.Column == coldeposit_amt)
                        e.RepositoryItem = ri_teReadOnly;
                    else if (e.Column == coldeposit_id)
                        e.RepositoryItem = ri_lueDepositTypeReadOnly;
                }
            }

            if (e.Column == colPresaleSeq)
            {
                
                if (row != null)
                {
                    if (row[coldeposit_id.FieldName] != null && row[coldeposit_id.FieldName] != DBNull.Value)
                    {
                        try
                        {
                            if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(row[coldeposit_id.FieldName])).Type == "P")
                                e.RepositoryItem = riteNumaric0;
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

        private void luePurchaser1_Leave(object sender, EventArgs e)
        {
            if (luePurchaserType.EditValue != DBNull.Value && luePurchaserType.EditValue != null)
            {
                if (luePurchaserType.EditValue.ToString() == "1" || luePurchaserType.EditValue.ToString() == "3")
                {
                    if (luePurchaser1.EditValue != DBNull.Value)
                    {
                        if (lueHomeBuilder.EditValue == DBNull.Value || lueHomeBuilder.EditValue == null)
                        {
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
                                lueWarrantyType.EditValue = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                            }

                        }
                    }
                }
            }
        }

        private void ucLotAgreement_Load(object sender, EventArgs e)
        {
            dockManager1.ForceInitialize();
        }

        private void teActualSellPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            e.Cancel = !KCA_Validator.ValidatePassword(101);
        }

        private int PurchaserOnOtherAgreement(int purchaserID, DateTime saleDate, int AgreementID)
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

                    object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                        popup.ShowPopup("Error checking individual years between purchases:" + hmCon.SQLExecutor.Exception.Message);
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
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                ((LookUpEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void deAssumedDate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(hmCon, tuc_mgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(ds_purchaser1);
                            luePurchaser1.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    popup.ShowPopup("You must select a purchaser type.");
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
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(hmCon, tuc_mgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(ds_purchaser1);
                            luePurchaser2.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    popup.ShowPopup("You must select a purchaser type.");
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
                    using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(hmCon, tuc_mgr, Convert.ToInt32(luePurchaserType.EditValue)))
                    {
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            daPurchaser.Fill(ds_purchaser1);
                            luePurchaser3.EditValue = frm.Purchaser_ID;
                        }
                    }
                }
                else
                    popup.ShowPopup("You must select a purchaser type.");
            }
        }

        private void riAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object oAmount = e.NewValue;
            if (oAmount == null || oAmount == DBNull.Value)
                oAmount = 0;

            double dAmout = Convert.ToDouble(oAmount);
            if (dAmout < 0 || dAmout > 999999999999999.99)
            {
                e.Cancel = true;
                return;
            }
        }

        private void riLevel2_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevies.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv1ID = dr["lv1id"];
                if (oLv1ID == null || oLv1ID == DBNull.Value)
                    oLv1ID = -1;

                bsLv2Filtered.Filter = "lv1id = " + oLv1ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv2Filtered;
            }
        }

        private void riLevel3_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevies.GetFocusedDataRow();
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
            DataRow dr = gvLevies.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv3ID = dr["lv3id"];
                if (oLv3ID == null || oLv3ID == DBNull.Value)
                    oLv3ID = -1;

                bsLv4Filtered.Filter = "lv3id = " + oLv3ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv4Filtered;
            }
        }

        private void riLevel1_EditValueChanged(object sender, EventArgs e)
        {
            gvLevies.SetFocusedRowCellValue("lv2id", DBNull.Value);
            gvLevies.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevies.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel2_EditValueChanged(object sender, EventArgs e)
        {
            gvLevies.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevies.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel3_EditValueChanged(object sender, EventArgs e)
        {
            gvLevies.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void gvLevies_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvLevies.GetFocusedDataRow();
            if (dr != null)
            {
                object oLD_Levy_ID = dr["LD_Levy_ID"];
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                {
                    e.Valid = false;
                    e.ErrorText = "'Levy Description' is required.";
                    gvLevies.FocusedColumn = colLD_Levy_ID;
                    return;
                }

                if (_lv1_active)
                {
                    object olv1id = dr["lv1id"];
                    if (olv1id == null || olv1id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv1id.Caption + "' is required.";
                        gvLevies.FocusedColumn = collv1id;
                        return;
                    }
                }

                if (_lv2_active)
                {
                    object olv2id = dr["lv2id"];
                    if (olv2id == null || olv2id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv2id.Caption + "' is required.";
                        gvLevies.FocusedColumn = collv2id;
                        return;
                    }
                }

                if (_lv3_active)
                {
                    object olv3id = dr["lv3id"];
                    if (olv3id == null || olv3id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv3id.Caption + "' is required.";
                        gvLevies.FocusedColumn = collv3id;
                        return;
                    }
                }

                if (_lv4_active)
                {
                    object olv4id = dr["lv4id"];
                    if (olv4id == null || olv4id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv4id.Caption + "' is required.";
                        gvLevies.FocusedColumn = collv4id;
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
                    gvLevies.FocusedColumn = colAmount;
                    return;
                }
            }
        }

        private void gvLevies_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daLevies.Update(dsLevies);
        }

        private void gcLevies_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (popup.ShowPopup("Are you sure you want to delete the selected 'Levy'?", WS_Popups.frmPopup.PopupType.OK_Cancel) ==
                     WS_Popups.frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvLevies.GetFocusedDataRow();
                    if (dr != null)
                    {
                        object oPROJ_LOT_AGREEMENT_LEVY_ID = dr["original_id"];
                        if (oPROJ_LOT_AGREEMENT_LEVY_ID == null || oPROJ_LOT_AGREEMENT_LEVY_ID == DBNull.Value)
                            oPROJ_LOT_AGREEMENT_LEVY_ID = -1;
                        
                        string sSQL = @"select count(*) from PROJ_LOT_AGREEMENT_LEVY where id="+oPROJ_LOT_AGREEMENT_LEVY_ID+@" and ISNULL(Matched,0)=1";
                        object oCNT = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                        if( oCNT == null || oCNT == DBNull.Value )
                            oCNT = 0;
                        if( Convert.ToInt32(oCNT) > 0 )
                        {
                            popup.ShowPopup("Unable to delete, this levy has been matched on an AP invoice.");
                        }
                        else
                        {
                            gvLevies.DeleteRow(gvLevies.FocusedRowHandle);
                            daLevies.Update(dsLevies);
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private void gvLevies_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvLevies_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvLevies.GetFocusedDataRow();
            if (dr != null)
            {
                dr["agreement_id"] = ds_agreement1.working_ld_laa_proj_lot_agreement.Rows[0]["agreement_id"];
                dr["username"] = hmCon.MLUser;
                dr["Amount"] = 0;
            }
        }

        private void gvLevies_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colLD_Levy_ID || e.Column == collv1id || e.Column == collv2id || e.Column == collv3id
                 || e.Column == collv4id || e.Column == colAmount)
            {
                object oMatched = gvLevies.GetFocusedRowCellValue("Matched");
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
                else if (e.Column == collv1id)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel1;
                    else
                        e.RepositoryItem = riLevel1RO;
                }
                else if (e.Column == collv2id)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel2;
                    else
                        e.RepositoryItem = riLevel2RO;
                }
                else if (e.Column == collv3id)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel3;
                    else
                        e.RepositoryItem = riLevel3RO;
                }
                else if (e.Column == collv4id)
                {
                    if (!bMatched)
                        e.RepositoryItem = riLevel4;
                    else
                        e.RepositoryItem = riLevel4RO;
                }
                else if (e.Column == colAmount)
                {
                    if (!bMatched)
                        e.RepositoryItem = riAmount;
                    else
                        e.RepositoryItem = riAmountRO;
                }
            }
            else if (e.Column == colsupplier_id1)
            {
                object oLD_Levy_ID = gvLevies.GetFocusedRowCellValue("LD_Levy_ID");
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                    oLD_Levy_ID = -1;
                string sSQL = @"select count(*) 
                    from LD_Levy l 
                    join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                    where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
                object oCNT = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;

                if (Convert.ToInt32(oCNT) == 1)
                    e.RepositoryItem = Supp_Repository;
                else
                    e.RepositoryItem = riSupplierRO;

                object oMatched = gvLevies.GetFocusedRowCellValue("Matched");
                if (oMatched == null || oMatched == DBNull.Value)
                    oMatched = false;
                bool bMatched = Convert.ToBoolean(oMatched);

                if (bMatched)
                    e.RepositoryItem = riSupplierRO;
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
            object oCNT = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
            if (oCNT == null || oCNT == DBNull.Value)
                oCNT = 0;
            if (Convert.ToInt32(oCNT) == 0)
            {
                gvLevies.SetFocusedRowCellValue("Supplier_ID", DBNull.Value);
            }
        }

        private void gvDiscounts_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvDiscounts.GetDataRow(e.RowHandle);
            dr[colagreement_id2.FieldName] = _AgreementID;
            dr[colprocessed.FieldName] = false;
            dr[colusername2.FieldName] = hmCon.MLUser;
            
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
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[colValue.FieldName], false))
            {
                popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (IsNumberToLarge(((DataRowView)e.Row)[colValue.FieldName]))
            {
                popup.ShowPopup("Value is too large.");
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

        private void da_lueDiscountType_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void gcDiscounts_Click(object sender, EventArgs e)
        {

        }
    }

}
