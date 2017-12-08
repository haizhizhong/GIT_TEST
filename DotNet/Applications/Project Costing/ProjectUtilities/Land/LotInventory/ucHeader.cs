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

namespace ProjectUtilities.Land.LotInventory
{
    public partial class ucHeader : DevExpress.XtraEditors.XtraUserControl
    {
        #region ucHeader Class Variables

        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private LandCC.ucPairedLots PairedLots;

        private UDF_Manager.ucUDF_Manager udfManager;
        private DataTable _dtProjLot;

        private bool _ReadOnly = false;
        private bool _bLotLoading = false;        

        public delegate void NewLotCancelled_Delegate();
        public event NewLotCancelled_Delegate NewLotCancelled_Event;

        public delegate void NewLotCreated_Delegate(int LotID);
        public event NewLotCreated_Delegate NewLotCreated_Event;

        private int _LotID = -1;
        private int _PriID = -1;

        private BaseEdit[] arrLI;
        private BaseEdit[] arrAddr;
        private BaseEdit[] arrFin;
        private BaseEdit[] arrAtt;

        private double CONST_SQ_FT_IN_ACRE = 43560;
        private double CONST_SQ_FT_IN_MT = 10.76391;
        private double CONST_SQ_MT_IN_HA = 10000;
        private const int CONST_CANCEL_APPROVED_PUR_REQ = 280;
        public KeyControlAccess.Validator KCA_Validator;

        private string sFileMgrType = "LDLOT";
        private int _ProjLot_FieldLink_ID = -1;
        private ContactMiniMgmt.ucTabMiniMgmt miniMgmt;

       
        #endregion

        public ucHeader(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            RunSetups();
        }

        private void RunSetups()
        {
            TR_Conn.ConnectionString = Connection.TRConnection;
            SetupUnits();            
            btnRefresh_Click(null, null);
            PairedLots = new LandCC.ucPairedLots(Connection, DevXMgr);
            PairedLots.Dock = DockStyle.Fill;
            PairedLots.Parent = tpPairedLots;

            udfManager = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr,UDF_Manager.UDFType.LotInventory);
            udfManager.Parent = tpUDF;
            udfManager.Dock = DockStyle.Fill;
            //to set the reference type
            udfManager.PopulateUDFValues("Lot", -1);
            object result = Connection.SQLExecutor.ExecuteScalar("SELECT TOP 1 ISNULL(UseMunicipalAddr,0) FROM LD_Setup", Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for "+Connection.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToBoolean(result))
                    tcAddresses.SelectedTabPage = tpMuniAddress;
                else
                    tcAddresses.SelectedTabPage = tpAddress;
                tcAddresses.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            }

           


            SetupStatus();
        }

        private void SetupStatus()
        {
            DataTable dt = new DataTable("dtStatus");
            dt.Columns.Add("Status");
            dt.Columns.Add("Desc");
            dt.Rows.Add(new object[] { "P", "Pending" });
            dt.Rows.Add(new object[] { "D", "Declined" });
            dt.Rows.Add(new object[] { "A", "Approved" });
            dt.Rows.Add(new object[] { "C", "Cancelled" });

            riStatus.DataSource = dt;
            riStatus.DisplayMember = "Desc";
            riStatus.ValueMember = "Status";
        }

        private void SetupUOM()
        {
            if (!_ReadOnly)
            {
                string sUOM = "M";
                string sSelect = "select ISNULL(UOM,'M') from PROJ_DEV_INFO where PRI_ID=" + _PriID;
                object obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                if (obj != null && obj != DBNull.Value)
                {
                    sUOM = obj.ToString();
                }

                if (sUOM.Equals("M"))
                {
                    txtSqFt.Properties.ReadOnly = true;
                    txtAcres.Properties.ReadOnly = true;
                    txtSqMt.Properties.ReadOnly = false;
                    txtHectares.Properties.ReadOnly = false;
                }
                else
                {
                    txtSqFt.Properties.ReadOnly = false;
                    txtAcres.Properties.ReadOnly = false;
                    txtSqMt.Properties.ReadOnly = true;
                    txtHectares.Properties.ReadOnly = true;
                }
            }
        }
        
        private void SetupUnits()
        {
            if (Connection.CountryCode.Equals("U"))
            {
                lciProv.Text = "State";
                lciPostal.Text = "Zip Code";
                lciProv2.Text = "State";
                lciPostal2.Text = "Zip Code";
            }
        }

        private void ucHeader_Load(object sender, EventArgs e)
        {
            miniMgmt = new ContactMiniMgmt.ucTabMiniMgmt(Connection, DevXMgr);
            miniMgmt.SetReadOnly(_ReadOnly);
            miniMgmt.Dock = DockStyle.Fill;
            miniMgmt.Parent = tpCommunications;
            _ProjLot_FieldLink_ID = CommonUtils.Util.GetContactHistoryFieldLinkID("PROJ_LOT.PROJ_LOT_ID", "Land Lot", Connection.WebConnection);
            
            DevXMgr.FormInit(this);
        }

        #region Readonly

        public void SetReadOnly(bool IsReadOnly)
        {
            _ReadOnly = IsReadOnly;
            LockLotInfo(IsReadOnly);
            LockAddress(IsReadOnly);
            LockFinancial(IsReadOnly);
            LockAttributes(IsReadOnly);
            dnLot.Buttons.EndEdit.Enabled = !IsReadOnly;
            dnLot.Buttons.CancelEdit.Enabled = !IsReadOnly;
            gvAck.OptionsBehavior.Editable = !IsReadOnly;
            gvLotComment.OptionsBehavior.Editable = !IsReadOnly;
            udfManager.SetReadOnly(IsReadOnly);

            LoackAdditonalInformation(IsReadOnly);
        }

        private void LoackAdditonalInformation(bool IsReadOnly)
        {
            ceLongTermLease.Properties.ReadOnly = IsReadOnly;
            deLeaseStartDate.Properties.ReadOnly = IsReadOnly;
            deLeaseStartDate.Properties.Buttons[1].Enabled = !IsReadOnly;
            txtLeaseAmount.Properties.ReadOnly = IsReadOnly;
            ceTaxTitle.Properties.ReadOnly = IsReadOnly;
            deTaxTitleStartDate.Properties.ReadOnly = IsReadOnly;
            deTaxTitleStartDate.Properties.Buttons[1].Enabled = !IsReadOnly;
            txtTaxTitleAmount.Properties.ReadOnly = IsReadOnly;
        }

        private void LockAttributes(bool IsReadOnly)
        {
            if (arrAtt == null)
            {
                arrAtt = new BaseEdit[20];
                arrAtt[0] = txtFrontage;
                arrAtt[1] = txtDepth;
                arrAtt[2] = txtSqMt;
                arrAtt[3] = txtHectares;
                arrAtt[4] = chkCornerLot;
                arrAtt[5] = lueZoning;
                arrAtt[6] = lueFeature;
                arrAtt[7] = chkCurb;
                arrAtt[8] = chkRearSide;
                arrAtt[9] = lueGrading;
                arrAtt[10] = lueBuildType;
                arrAtt[11] = lueOrientation;
                arrAtt[12] = lueAmenity;
                arrAtt[13] = txtSqFt;
                arrAtt[14] = txtAcres;

                arrAtt[15] = lueCounty;
                arrAtt[16] = beSection;
                arrAtt[17] = beTownship;
                arrAtt[18] = beRange;
                arrAtt[19] = txtMeridian;
            }
            for (int i = 0; i < arrAtt.Length; i++)
            {
                LockControl(arrAtt[i], IsReadOnly);
            }
        }

        private void LockFinancial(bool IsReadOnly)
        {
            if (arrFin == null)
            {
                arrFin = new BaseEdit[6];
                arrFin[0] = txtOrgPrice;
                arrFin[1] = txtCurrentPrice;
                arrFin[2] = txtCommAmt;
                arrFin[3] = txtCommPct;
                arrFin[4] = txtSales_Agreement_Price;
                arrFin[5] = txtCMV;

            }
            for (int i = 0; i < arrFin.Length; i++)
            {
                LockControl(arrFin[i], IsReadOnly);
            }
        }

        private void LockAddress(bool IsReadOnly)
        {
            if (arrAddr == null)
            {
                arrAddr = new BaseEdit[14];
                arrAddr[0] = txtAddr1;
                arrAddr[1] = txtAddr2;
                arrAddr[2] = txtCity;
                arrAddr[3] = lueProv;
                arrAddr[4] = txtPostal;
                arrAddr[5] = txtMACity;
                arrAddr[6] = txtMAName;
                arrAddr[7] = txtMANumber;
                arrAddr[8] = txtMAPostal;
                arrAddr[9] = txtMAPrefix;
                arrAddr[10] = lueMAProv;
                arrAddr[11] = txtMASite;
                arrAddr[12] = txtMASuffix;
                arrAddr[13] = txtMASuffixDir;
            }
            for (int i = 0; i < arrAddr.Length; i++)
            {
                LockControl(arrAddr[i], IsReadOnly);
            }
        }
       
        private void LockLotInfo(bool IsReadOnly)
        {
            if (lueSubStatus.EditValue != null && lueSubStatus.EditValue != DBNull.Value)
            {
                if (lueSubStatus.EditValue.ToString() == "9" || _ReadOnly)
                {
                    arrLI = new BaseEdit[8];
                    arrLI[0] = lueClass;
                    arrLI[1] = lueSubClass;
                    arrLI[2] = txtLot;
                    arrLI[3] = txtBlock;
                    arrLI[4] = txtPlan;
                    arrLI[5] = txtParcel;
                    arrLI[6] = txtTitle;
                    arrLI[7] = txtLegal;
                }
                else
                {
                    arrLI = new BaseEdit[6];
                    arrLI[0] = lueClass;
                    arrLI[1] = lueSubClass;
                    arrLI[2] = txtLot;
                    arrLI[3] = txtBlock;
                    arrLI[4] = txtPlan;
                    arrLI[5] = txtLegal;
                }
            }
            else
            {
                arrLI = new BaseEdit[8];
                arrLI[0] = lueClass;
                arrLI[1] = lueSubClass;
                arrLI[2] = txtLot;
                arrLI[3] = txtBlock;
                arrLI[4] = txtPlan;
                arrLI[5] = txtLegal;
                arrLI[6] = txtParcel;
                arrLI[7] = txtTitle;
            }
                
            
            for (int i = 0; i < arrLI.Length; i++)
            {
                LockControl(arrLI[i], IsReadOnly);
            }
        }

        private void LockControl(BaseEdit be, bool IsReadOnly)
        {
            be.Properties.ReadOnly = IsReadOnly;            
        }

        #endregion

        #region Lot Load

        public void LoadLot(int LotID)
        {

            
            string sql = "select pri_id from PROJ_LOT  where proj_lot_id = "+LotID.ToString();
            object reuslt = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error loading lot:" + Connection.SQLExecutor.Exception.Message);
            int pri_id = -1;

            try
            {
                pri_id = Convert.ToInt32(reuslt);
            }
            catch { }
            LoadLot(LotID, pri_id);

        }

       
        public void LoadLot(int LotID, int PriID)
        {
            udfManager.PopulateUDFValues(LotID);
            _LotID = LotID;
            _PriID = PriID;
            SetupUOM();
            LoadLotDB(false);
            SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Land Development", ref btnSharepoint, "Header", _LotID);
            PairedLots.Proj_Lot_ID = LotID;

            dsAckResEas.Clear();
            daAckResEas.SelectCommand.Parameters["@proj_lot_id"].Value = LotID;
            daAckResEas.Fill(dsAckResEas);

            dsStatusHist.Clear();
            daStatusHist.SelectCommand.Parameters["@proj_lot_id"].Value = LotID;
            daStatusHist.Fill(dsStatusHist);

            dsPurReq1.Clear();
            daPurReq.SelectCommand.Parameters["@proj_lot_id"].Value = LotID;
            daPurReq.Fill(dsPurReq1);

            ds_LotComments1.Clear();
            da_LotComments.SelectCommand.Parameters["@proj_lot_id"].Value = LotID;
            da_LotComments.Fill(ds_LotComments1);

            LoadCurrentPriceChangeHist(LotID);

            SetCurrentAgreementInformation(LotID);
            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, _LotID, ref btnAttachments);
            if(tcCommunications.SelectedTabPage == tpCommunications)
                miniMgmt.SetLink(new ContactMiniMgmt.FieldLink[] { 
                new ContactMiniMgmt.FieldLink(_ProjLot_FieldLink_ID, _LotID, "Land Lot"),
                new ContactMiniMgmt.FieldLink(_ProjLot_FieldLink_ID, _PriID, "Project",true,"ProjWO")});
        }

        private void SetCurrentAgreementInformation(int LotID)
        {
            string sql = "select file_number from proj_lot_agreement where proj_lot_id = "+LotID.ToString()+" and agreement_status_id <> 2";
            object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error loading agreement information on lot:" + Connection.SQLExecutor.Exception.Message);
            else
            {
                teFileNumber.Text = "";
                if (result != null && result != DBNull.Value)
                    teFileNumber.Text = result.ToString();
            }


        }


        private void LoadLotDB(bool ReloadFromDT)
        {
            if (_LotID == -1 && ReloadFromDT)
            {
                if (NewLotCancelled_Event != null)
                    NewLotCancelled_Event();
                return;
            }

            _bLotLoading = true;
            ClearForm();

            if (!ReloadFromDT)
            {
                string sSelect = "select proj_lot_id, pri_id, lot_num, block_num, plan_num, lot_class_id, lot_sub_class_id, lot_status_id, sub_status_id, parcel_number, title_number, "+
                    "long_legal, isnull(frontage,0) [frontage], isnull(depth,0) [depth], isnull(area_metre,0.0) [area_metre], isnull(area_ft,0.0) [area_ft], isnull(area_acres,0.0000) [area_acres], " +
                    "isnull(area_hectares,0) [area_hectares], isnull(corner,'F') [corner], zoning_id, shapes_id, isnull(curb_treatment,'F') [curb_treatment], "+
                    "isnull(rear_side_treatment,'F') [rear_side_treatment], address_1, address_2, city, prov, postal, ma_prefix_dir, "+
                    "ma_number, ma_name, ma_site, ma_suffix, ma_suffix_dir, ma_city, ma_prov, ma_postal, isnull(original_price,0) [original_price], "+
                    "isnull(current_price,0) [current_price], isnull(commission_amt,0) [commission_amt], isnull(commission_pct,0) [commission_pct], "+
                    "grading_id, buildtype_id, orientation_id, amenity_id,isnull(sales_agreement_price,0)[sales_agreement_price], isnull(CMV,0)[CMV], lotcounty_ID, lot_section, lot_township, lot_range, meridian, " +
                    "LongTermLease, LongTermStartDate, LeaseAmount, TaxTitle, TaxTitleStartDate, ExpectedSaleAmount, date_created " +
                    " from proj_lot where proj_lot_id=" + _LotID;
                _dtProjLot = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            }

            if (_dtProjLot != null)
            {
                dnLot.DataSource = _dtProjLot;
                if (_dtProjLot.Rows.Count > 0)
                {
                    DataRow dr = _dtProjLot.Rows[0];
                    if (dr != null)
                    {
                        //row 1
                        _PriID = Convert.ToInt32(dr["pri_id"]);
                        txtLot.EditValue = dr["lot_num"];
                        txtBlock.EditValue = dr["block_num"];
                        txtPlan.EditValue = dr["plan_num"];
                        lueClass.EditValue = dr["lot_class_id"];
                        lueSubClass.EditValue = dr["lot_sub_class_id"];
                        lueStatus.EditValue = dr["lot_status_id"];
                        lueSubStatus.EditValue = dr["sub_status_id"];
                        txtParcel.EditValue = dr["parcel_number"];
                        txtTitle.EditValue = dr["title_number"];
                        //row 2
                        txtLegal.EditValue = dr["long_legal"];
                        txtFrontage.EditValue = dr["frontage"];
                        txtDepth.EditValue = dr["depth"];
                        txtSqMt.EditValue = dr["area_metre"];
                        txtSqFt.EditValue = dr["area_ft"];
                        txtAcres.EditValue = dr["area_acres"];
                        //row 3
                        txtHectares.EditValue = dr["area_hectares"];
                        chkCornerLot.EditValue = dr["corner"];
                        lueZoning.EditValue = dr["zoning_id"];
                        lueFeature.EditValue = dr["shapes_id"];
                        chkCurb.EditValue = dr["curb_treatment"];                        
                        //row 4
                        chkRearSide.EditValue = dr["rear_side_treatment"];
                        txtAddr1.EditValue = dr["address_1"];
                        txtAddr2.EditValue = dr["address_2"];
                        txtCity.EditValue = dr["city"];
                        lueProv.EditValue = dr["prov"];
                        txtPostal.EditValue = dr["postal"];
                        txtMAPrefix.EditValue = dr["ma_prefix_dir"];
                        //row 5
                        txtMANumber.EditValue = dr["ma_number"];
                        txtMAName.EditValue = dr["ma_name"];
                        txtMASite.EditValue = dr["ma_site"];
                        txtMASuffix.EditValue = dr["ma_suffix"];
                        txtMASuffixDir.EditValue = dr["ma_suffix_dir"];
                        txtMACity.EditValue = dr["ma_city"];
                        lueMAProv.EditValue = dr["ma_prov"];
                        txtMAPostal.EditValue = dr["ma_postal"];
                        txtOrgPrice.EditValue = dr["original_price"];
                        //row 6
                        txtCurrentPrice.EditValue = dr["current_price"];
                        txtCommAmt.EditValue = dr["commission_amt"];
                        txtCommPct.EditValue = dr["commission_pct"];
                        //row 7
                        lueGrading.EditValue = dr["grading_id"];
                        lueBuildType.EditValue = dr["buildtype_id"];
                        lueOrientation.EditValue = dr["orientation_id"];
                        lueAmenity.EditValue = dr["amenity_id"];

                        txtSales_Agreement_Price.EditValue = dr["sales_agreement_price"];
                        txtCMV.EditValue = dr["CMV"];
                        lueCounty.EditValue = dr["lotcounty_ID"];
                        beSection.EditValue = dr["lot_section"];
                        beTownship.EditValue = dr["lot_township"];
                        beRange.EditValue = dr["lot_range"];
                        txtMeridian.EditValue = dr["meridian"];

                        ceLongTermLease.EditValue = dr["LongTermLease"];
                        deLeaseStartDate.EditValue = dr["LongTermStartDate"];
                        txtLeaseAmount.EditValue = dr["LeaseAmount"];

                        ceTaxTitle.EditValue = dr["TaxTitle"];
                        deTaxTitleStartDate.EditValue = dr["TaxTitleStartDate"];
                        txtTaxTitleAmount.EditValue = dr["ExpectedSaleAmount"];
                        deDateCreated.EditValue = dr["date_created"];
                    }
                }
            }

            if (_LotID != -1)
            {
                //load bottom flyouts
            }

            _bLotLoading = false;
        }

        #endregion

        #region Unit Validation/Insertion

        public void SetInsertMode()
        {
            _bLotLoading = true;
            _LotID = -1;
            LoadLot(_LotID,_PriID);
            ClearForm();
            _dtProjLot = new DataTable();
            _dtProjLot.Columns.Add();
            _dtProjLot.Rows.Add(new object[] { "" });
            lueStatus.EditValue = 1;
            lueSubStatus.EditValue = 1;
            dnLot.DataSource = _dtProjLot;
            dsAckResEas.Clear();
            dsStatusHist.Clear();
            _bLotLoading = false;
           
        }

        private void hlNewUnit_Click(object sender, EventArgs e)
        {
            SetInsertMode();
        }

        private bool LotValid()
        {
            ClearInvalidColors();
            if (lueClass.EditValue == null || lueClass.EditValue == DBNull.Value)
            {
                lueClass.Focus();
                lciClass.AppearanceItemCaption.ForeColor = Color.Red;
                Popup.ShowPopup("A class must be entered.");
                return false;
            }

            if (lueSubClass.EditValue == null || lueSubClass.EditValue == DBNull.Value)
            {
                lueSubClass.Focus();
                lciSubClass.AppearanceItemCaption.ForeColor = Color.Red;
                Popup.ShowPopup("A sub class must be entered.");
                return false;
            }

            if (txtLot.Text.Trim().Equals(""))
            {
                txtLot.Focus();
                lciLot.AppearanceItemCaption.ForeColor = Color.Red;
                Popup.ShowPopup("A lot # must be entered.");
                return false;
            }
            else if (txtBlock.Text.Trim().Equals(""))
            {
                txtBlock.Focus();
                lciBlock.AppearanceItemCaption.ForeColor = Color.Red;
                Popup.ShowPopup("A block # must be entered.");
                return false;
            }
            else if(!isGreaterThenZero(txtOrgPrice.EditValue,true))
            {
                Popup.ShowPopup("Origional Price must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtOrgPrice.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Origional Price is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtCurrentPrice.EditValue, true))
            {
                Popup.ShowPopup("Current Price must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtCurrentPrice.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Current Price is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtCommAmt.EditValue, true))
            {
                Popup.ShowPopup("Commission Amount must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtCommAmt.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Commission Amount is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtCommPct.EditValue, true))
            {
                Popup.ShowPopup("Commission Percent must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDouble(txtCommPct.EditValue) > 100)
            {
                Popup.ShowPopup("Commission Percent must be less than or equal to 100.");
                return false;
            }
            else if (!isGreaterThenZero(txtFrontage.EditValue, true))
            {
                Popup.ShowPopup("Frontage must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtFrontage.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Frontage is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtDepth.EditValue, true))
            {
                Popup.ShowPopup("Depth must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtDepth.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Depth is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtSqFt.EditValue, true))
            {
                Popup.ShowPopup("Sq. Ft. must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtSqFt.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Sq. Ft. is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtAcres.EditValue, true))
            {
                Popup.ShowPopup("Acres must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtAcres.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Acres is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtSqMt.EditValue, true))
            {
                Popup.ShowPopup("Sq Meters must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtSqMt.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Sq Meters is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtHectares.EditValue, true))
            {
                Popup.ShowPopup("Hectares must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtHectares.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Hectares is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtSales_Agreement_Price.EditValue, true))
            {
                Popup.ShowPopup("Sales Agreement Price must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtSales_Agreement_Price.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Sales Agreement Price is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtCMV.EditValue, true))
            {
                Popup.ShowPopup("CMV must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtCMV.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("CMV is too large.");
                return false;
            }
            else if (beSection.EditValue != DBNull.Value && !isGreaterThenZero(beSection.EditValue, true))
            {
                Popup.ShowPopup("Section must be greather than or equal to zero.");
                return false;
            }
            else if (beSection.EditValue != DBNull.Value && Convert.ToDecimal(beSection.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Section is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtLeaseAmount.EditValue, true))
            {
                Popup.ShowPopup("Long Term Lease Amount must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtLeaseAmount.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Long Term Lease Amount is too large.");
                return false;
            }
            else if (!isGreaterThenZero(txtTaxTitleAmount.EditValue, true))
            {
                Popup.ShowPopup("Tax Tile Expected Sale Amount must be greather than or equal to zero.");
                return false;
            }
            else if (Convert.ToDecimal(txtTaxTitleAmount.EditValue) > 922337203685477)
            {
                Popup.ShowPopup("Tax Tile Expected Sale Amount is too large.");
                return false;
            }
            else
            {
                string sSelect = "declare @proj_lot_id int, @lot_num varchar(5), @block_num varchar(5), @pri_id int " +
                    "select @proj_lot_id = " + _LotID + ", @pri_id=" + _PriID + ", @lot_num = '" + txtLot.Text.Replace("'", "''") + "', @block_num = '" + txtBlock.Text.Replace("'", "''") +
                    "' " +
                    "select COUNT(*) from PROJ_LOT " +
                    "where (pri_id=@pri_id) and (proj_lot_id <> isnull(@proj_lot_id, -1)) and " +
                    "(lot_num = @lot_num) and (block_num=@block_num)";
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
                {
                    txtLot.Focus();
                    lciLot.AppearanceItemCaption.ForeColor = Color.Red;
                    lciBlock.AppearanceItemCaption.ForeColor = Color.Red;
                    Popup.ShowPopup("The combination of lot # and block # entered already exists for this project.");
                    return false;
                }
            }

            if (txtPlan.Text.Trim().Equals(""))
            {
                txtPlan.EditValue = "Unregistered";
            }     

            return true;
        }

        private void ClearInvalidColors()
        {

            lciClass.AppearanceItemCaption.ForeColor = Color.Empty;
            lciSubClass.AppearanceItemCaption.ForeColor = Color.Empty;
            lciLot.AppearanceItemCaption.ForeColor = Color.Empty;
            lciBlock.AppearanceItemCaption.ForeColor = Color.Empty;
            lciPlan.AppearanceItemCaption.ForeColor = Color.Empty;
            lciParcel.AppearanceItemCaption.ForeColor = Color.Empty;
            lciTitle.AppearanceItemCaption.ForeColor = Color.Empty;
            lciLegal.AppearanceItemCaption.ForeColor = Color.Empty;
            lciStatus.AppearanceItemCaption.ForeColor = Color.Empty;
            lciSubStatus.AppearanceItemCaption.ForeColor = Color.Empty;
        }

        private void ClearForm()
        {
            ClearInvalidColors();
            //Lot Information
            lueClass.EditValue = DBNull.Value;
            lueSubClass.EditValue = DBNull.Value;
            txtLot.EditValue = DBNull.Value;
            txtBlock.EditValue = DBNull.Value;
            txtPlan.EditValue = DBNull.Value;            
            txtParcel.EditValue = DBNull.Value;
            txtTitle.EditValue = DBNull.Value;
            txtLegal.EditValue = DBNull.Value;
            lueStatus.EditValue = DBNull.Value;
            lueSubStatus.EditValue = DBNull.Value;
            deDateCreated.EditValue = DBNull.Value;
            //Address
            txtAddr1.EditValue = DBNull.Value;
            txtAddr2.EditValue = DBNull.Value;
            txtCity.EditValue = DBNull.Value;
            lueProv.EditValue = DBNull.Value;
            txtPostal.EditValue = DBNull.Value;
            //Municipal Address
            txtMACity.EditValue = DBNull.Value;
            txtMAName.EditValue = DBNull.Value;
            txtMANumber.EditValue = DBNull.Value;
            txtMAPostal.EditValue = DBNull.Value;
            txtMAPrefix.EditValue = DBNull.Value;
            lueMAProv.EditValue = DBNull.Value;
            txtMASite.EditValue = DBNull.Value;
            txtMASuffix.EditValue = DBNull.Value;
            txtMASuffixDir.EditValue = DBNull.Value;
            //Financial
            txtOrgPrice.EditValue = 0.0;
            txtCurrentPrice.EditValue = 0.0;
            txtCommAmt.EditValue = 0.0;
            txtCommPct.EditValue = 0.0;
            //Attributes
            txtFrontage.EditValue = 0.0;
            txtDepth.EditValue = 0.0;
            txtSqMt.EditValue = 0.0;
            txtHectares.EditValue = 0.0;
            txtSqFt.EditValue = 0.0;
            txtAcres.EditValue = 0.0;
            chkCornerLot.EditValue = "F";
            lueZoning.EditValue = DBNull.Value;
            lueFeature.EditValue = DBNull.Value;
            chkCurb.EditValue = "F";
            chkRearSide.EditValue = "F";
            lueGrading.EditValue = DBNull.Value;
            lueBuildType.EditValue = DBNull.Value;
            lueOrientation.EditValue = DBNull.Value;
            lueAmenity.EditValue = DBNull.Value;

            txtSales_Agreement_Price.EditValue = 0.0;
            txtCMV.EditValue = 0.0;
            lueCounty.EditValue = DBNull.Value;
            beSection.EditValue = DBNull.Value; ;
            beTownship.EditValue = DBNull.Value; ;
            beRange.EditValue = DBNull.Value; ;
            txtMeridian.EditValue = DBNull.Value;

            //flyout attributes
            ceLongTermLease.Checked = false;
            deLeaseStartDate.EditValue = DBNull.Value;
            txtLeaseAmount.EditValue = 0.0;
            ceTaxTitle.Checked = false;
            deTaxTitleStartDate.EditValue = DBNull.Value;
            txtTaxTitleAmount.EditValue = 0.0;

            //clear flyout datasets
        }

        private void RunInsertUpdate()
        {
            if (!LotValid())
            {
                return;
            }

            SqlCommand cmd = new SqlCommand("PC_Lot_InsertUpdate @proj_lot_id, @pri_id, @lot_num, @block_num, @plan_num, @lot_class_id, @lot_sub_class_id, @lot_status_id, "+
                "@sub_status_id, @parcel_number, @title_number, @long_legal, @frontage, @depth, @area_metre, @area_hectares, @area_ft, @area_acres, @corner, " +
		        "@zoning_id, @shapes_id, @curb_treatment, @rear_side_treatment, @address_1, @address_2, @city, @prov, @postal, @ma_prefix_dir, "+
		        "@ma_number, @ma_name, @ma_site, @ma_suffix, @ma_suffix_dir, @ma_city, @ma_prov, @ma_postal, @original_price, @current_price, @commission_amt, "+
                "@commission_pct, @grading_id, @buildtype_id, @orientation_id, @amenity_id, " +
                "@sales_agreement_price, @CMV, @county, @section, @township, @range, @meridian, @LongTermLease, @LongTermStartDate, @LeaseAmount, @TaxTitle, @TaxTitleStartDate, @ExpectedSaleAmount", new SqlConnection(Connection.TRConnection));
            object oLOT_ID = DBNull.Value;
            if (_LotID != -1)
                oLOT_ID = _LotID;

            //(txtCurrentPrice.EditValue == DBNull.Value || txtCurrentPrice.Text.Trim() == "0.00" ? txtOrgPrice.EditValue : txtCurrentPrice.EditValue)
            double dCurrentPrice = 0;
            try { dCurrentPrice = Convert.ToDouble(txtCurrentPrice.EditValue); }
            catch { }

            if (dCurrentPrice == 0 && (_LotID == -1))
            {
                txtCurrentPrice.EditValue = txtOrgPrice.EditValue;
            }

            // get current price
            double dCurrentPrice_Curr = 0;
            if ( _LotID != -1)
            {
                string sqlstr = "select isnull(current_price,0) from PROJ_LOT where proj_lot_id= " + _LotID.ToString();
                
                object obj = Connection.SQLExecutor.ExecuteScalar(sqlstr, Connection.TRConnection);
                if (obj != null && obj != DBNull.Value)
                {
                    dCurrentPrice_Curr = Convert.ToDouble(obj);
                }
            }

            //
            cmd.Parameters.Add("@proj_lot_id", SqlDbType.Int);
            cmd.Parameters["@proj_lot_id"].Value = oLOT_ID;
            cmd.Parameters.Add("@pri_id", SqlDbType.Int);
            cmd.Parameters["@pri_id"].Value = _PriID;
            cmd.Parameters.Add("@lot_num", SqlDbType.VarChar);
            cmd.Parameters["@lot_num"].Value = txtLot.EditValue;
            cmd.Parameters.Add("@block_num", SqlDbType.VarChar);
            cmd.Parameters["@block_num"].Value = txtBlock.EditValue;
            cmd.Parameters.Add("@plan_num", SqlDbType.VarChar);
            cmd.Parameters["@plan_num"].Value = txtPlan.EditValue;
            cmd.Parameters.Add("@lot_class_id", SqlDbType.Int);
            cmd.Parameters["@lot_class_id"].Value = lueClass.EditValue;
            cmd.Parameters.Add("@lot_sub_class_id", SqlDbType.Int);
            cmd.Parameters["@lot_sub_class_id"].Value = lueSubClass.EditValue;
            cmd.Parameters.Add("@lot_status_id", SqlDbType.VarChar);
            cmd.Parameters["@lot_status_id"].Value = lueStatus.EditValue;            
            cmd.Parameters.Add("@sub_status_id", SqlDbType.Int);
            cmd.Parameters["@sub_status_id"].Value = lueSubStatus.EditValue; 
            cmd.Parameters.Add("@parcel_number", SqlDbType.VarChar);
            cmd.Parameters["@parcel_number"].Value = txtParcel.EditValue;
            cmd.Parameters.Add("@title_number", SqlDbType.VarChar);
            cmd.Parameters["@title_number"].Value = txtTitle.EditValue;
            cmd.Parameters.Add("@long_legal", SqlDbType.VarChar);
            cmd.Parameters["@long_legal"].Value = txtLegal.EditValue;
            cmd.Parameters.Add("@frontage", SqlDbType.Money);
            cmd.Parameters["@frontage"].Value = txtFrontage.EditValue;
            cmd.Parameters.Add("@depth", SqlDbType.Money);
            cmd.Parameters["@depth"].Value = txtDepth.EditValue;
            cmd.Parameters.Add("@area_metre", SqlDbType.Money);
            cmd.Parameters["@area_metre"].Value = txtSqMt.EditValue;
            cmd.Parameters.Add("@area_hectares", SqlDbType.Money);
            cmd.Parameters["@area_hectares"].Value = txtHectares.EditValue;
            cmd.Parameters.Add("@area_ft", SqlDbType.Money);
            cmd.Parameters["@area_ft"].Value = txtSqFt.EditValue;
            cmd.Parameters.Add("@area_acres", SqlDbType.Money);
            cmd.Parameters["@area_acres"].Value = txtAcres.EditValue;
            cmd.Parameters.Add("@corner", SqlDbType.VarChar);
            cmd.Parameters["@corner"].Value = chkCornerLot.EditValue;            
            cmd.Parameters.Add("@zoning_id", SqlDbType.Int);
            cmd.Parameters["@zoning_id"].Value = lueZoning.EditValue;
            cmd.Parameters.Add("@shapes_id", SqlDbType.Int);
            cmd.Parameters["@shapes_id"].Value = lueFeature.EditValue;
            cmd.Parameters.Add("@curb_treatment", SqlDbType.VarChar);
            cmd.Parameters["@curb_treatment"].Value = chkCurb.EditValue;
            cmd.Parameters.Add("@rear_side_treatment", SqlDbType.VarChar);
            cmd.Parameters["@rear_side_treatment"].Value = chkRearSide.EditValue;
            cmd.Parameters.Add("@address_1", SqlDbType.VarChar);
            cmd.Parameters["@address_1"].Value = txtAddr1.EditValue;
            cmd.Parameters.Add("@address_2", SqlDbType.VarChar);
            cmd.Parameters["@address_2"].Value = txtAddr2.EditValue;
            cmd.Parameters.Add("@city", SqlDbType.VarChar);
            cmd.Parameters["@city"].Value = txtCity.EditValue;
            cmd.Parameters.Add("@prov", SqlDbType.VarChar);
            cmd.Parameters["@prov"].Value = lueProv.EditValue;
            cmd.Parameters.Add("@postal", SqlDbType.VarChar);
            cmd.Parameters["@postal"].Value = txtPostal.EditValue;
            cmd.Parameters.Add("@ma_prefix_dir", SqlDbType.VarChar);
            cmd.Parameters["@ma_prefix_dir"].Value = txtMAPrefix.EditValue;            
            cmd.Parameters.Add("@ma_number", SqlDbType.VarChar);
            cmd.Parameters["@ma_number"].Value = txtMANumber.EditValue;
            cmd.Parameters.Add("@ma_name", SqlDbType.VarChar);
            cmd.Parameters["@ma_name"].Value = txtMAName.EditValue;
            cmd.Parameters.Add("@ma_site", SqlDbType.VarChar);
            cmd.Parameters["@ma_site"].Value = txtMASite.EditValue;
            cmd.Parameters.Add("@ma_suffix", SqlDbType.VarChar);
            cmd.Parameters["@ma_suffix"].Value = txtMASuffix.EditValue;
            cmd.Parameters.Add("@ma_suffix_dir", SqlDbType.VarChar);
            cmd.Parameters["@ma_suffix_dir"].Value = txtMASuffixDir.EditValue;
            cmd.Parameters.Add("@ma_city", SqlDbType.VarChar);
            cmd.Parameters["@ma_city"].Value = txtMACity.EditValue;
            cmd.Parameters.Add("@ma_prov", SqlDbType.VarChar);
            cmd.Parameters["@ma_prov"].Value = lueMAProv.EditValue;
            cmd.Parameters.Add("@ma_postal", SqlDbType.VarChar);
            cmd.Parameters["@ma_postal"].Value = txtMAPostal.EditValue;
            cmd.Parameters.Add("@original_price", SqlDbType.Money);
            cmd.Parameters["@original_price"].Value = txtOrgPrice.EditValue;
            cmd.Parameters.Add("@current_price", SqlDbType.Money);
            cmd.Parameters["@current_price"].Value = txtCurrentPrice.EditValue;
            cmd.Parameters.Add("@commission_amt", SqlDbType.Money);
            cmd.Parameters["@commission_amt"].Value = txtCommAmt.EditValue;
            cmd.Parameters.Add("@commission_pct", SqlDbType.Money);
            cmd.Parameters["@commission_pct"].Value = txtCommPct.EditValue;
            cmd.Parameters.Add("@grading_id", SqlDbType.Int);
            cmd.Parameters["@grading_id"].Value = lueGrading.EditValue;
            cmd.Parameters.Add("@buildtype_id", SqlDbType.Int);
            cmd.Parameters["@buildtype_id"].Value = lueBuildType.EditValue;
            cmd.Parameters.Add("@orientation_id", SqlDbType.Int);
            cmd.Parameters["@orientation_id"].Value = lueOrientation.EditValue;
            cmd.Parameters.Add("@amenity_id", SqlDbType.Int);
            cmd.Parameters["@amenity_id"].Value = lueAmenity.EditValue;

            cmd.Parameters.Add("@sales_agreement_price", SqlDbType.Money);
            cmd.Parameters["@sales_agreement_price"].Value = txtSales_Agreement_Price.EditValue;

            cmd.Parameters.Add("@CMV", SqlDbType.Money);
            cmd.Parameters["@CMV"].Value = txtCMV.EditValue;

            cmd.Parameters.Add("@county", SqlDbType.Int);
            cmd.Parameters["@county"].Value = lueCounty.EditValue;

            cmd.Parameters.Add("@section", SqlDbType.Int);
            cmd.Parameters["@section"].Value = beSection.EditValue;

            cmd.Parameters.Add("@township", SqlDbType.VarChar);
            cmd.Parameters["@township"].Value = beTownship.EditValue;

            cmd.Parameters.Add("@range", SqlDbType.VarChar);
            cmd.Parameters["@range"].Value = beRange.EditValue;

            cmd.Parameters.Add("@meridian", SqlDbType.VarChar);
            cmd.Parameters["@meridian"].Value = txtMeridian.EditValue;

            cmd.Parameters.Add("@LongTermLease", SqlDbType.Bit);
            cmd.Parameters["@LongTermLease"].Value = ceLongTermLease.EditValue;

            cmd.Parameters.Add("@LongTermStartDate", SqlDbType.DateTime);
            cmd.Parameters["@LongTermStartDate"].Value = deLeaseStartDate.EditValue;

            cmd.Parameters.Add("@LeaseAmount", SqlDbType.Money);
            cmd.Parameters["@LeaseAmount"].Value = txtLeaseAmount.EditValue;

            cmd.Parameters.Add("@TaxTitle", SqlDbType.Bit);
            cmd.Parameters["@TaxTitle"].Value = ceTaxTitle.EditValue;

            cmd.Parameters.Add("@TaxTitleStartDate", SqlDbType.DateTime);
            cmd.Parameters["@TaxTitleStartDate"].Value = deTaxTitleStartDate.EditValue;

            cmd.Parameters.Add("@ExpectedSaleAmount", SqlDbType.Money);
            cmd.Parameters["@ExpectedSaleAmount"].Value = txtTaxTitleAmount.EditValue;

            try
            {
                cmd.Connection.Open();
                oLOT_ID = cmd.ExecuteScalar();
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    if (_LotID == -1)
                    {
                        LoadLot(Convert.ToInt32(oLOT_ID));
                       
                    }
                    else
                    {
                        _LotID = Convert.ToInt32(oLOT_ID);
                        CurrentPriceChangeLogEntry(_LotID, dCurrentPrice_Curr);
                    }
                 

                    if (NewLotCreated_Event != null)
                        NewLotCreated_Event(_LotID);
                }
            }
            catch (Exception e)
            {
                Popup.ShowPopup(e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        #endregion

        private void btnSharepoint_Click(object sender, EventArgs e)
        {
            if (_LotID != -1)
            {
                using (SharePointMgr.frmSharePointMgr SharePointManager = new SharePointMgr.frmSharePointMgr(Connection, DevXMgr, "Land Development", "Land Development", "", "Header", _LotID))
                {
                    SharePointManager.ReadOnly = _ReadOnly;
                    SharePointManager.ShowDialog();
                    SharePointManager.Dispose();
                    SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Land Development", ref btnSharepoint, "Header", _LotID);
                }
            }
        }

        private void dnLot_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (_dtProjLot != null)
                {
                    if (_dtProjLot.Rows.Count > 0)
                    {
                        RunInsertUpdate();                        
                    }
                }
               

            }
            else if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                if (_dtProjLot != null)
                {
                    if (_dtProjLot.Rows.Count > 0)
                    {
                        _dtProjLot.Rows[0].CancelEdit();
                        LoadLotDB(false);
                    }
                }
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsLotClass.Clear();            
            dsLotStatus.Clear();
            dsSubStatus.Clear();
            dsAttributes.Clear();
            dsProv1.Clear();
            dsRestrictionType.Clear();
            dsAllRestrictions.Clear();
            ds_LD_County1.Clear();

            daLotClass.Fill(dsLotClass);            
            daStatus.Fill(dsLotStatus);
            daSubStatus.Fill(dsSubStatus);
            daAttributes.Fill(dsAttributes);
            daProv.Fill(dsProv1);
            daRestrictionType.Fill(dsRestrictionType);
            daAllRestrictions.Fill(dsAllRestrictions);
            da_LD_County.Fill(ds_LD_County1);
            SetCurrentAgreementInformation(_LotID);
            

        }

        private void lueClass_EditValueChanged(object sender, EventArgs e)
        {
            dsLotSubClass.Clear();
            if (!_bLotLoading)
            {
                lueSubClass.EditValue = null;
            }

            object oClassID = lueClass.EditValue;
            if (oClassID != null && oClassID != DBNull.Value)
            {
                daLotSubClass.SelectCommand.Parameters["@class_id"].Value = oClassID;
                daLotSubClass.Fill(dsLotSubClass);
            }
        }

        private void txtCommAmt_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dAmt = 0;
                object oAmt = txtCommAmt.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                double dCPAmt = 0;
                object oCPAmt = txtCurrentPrice.EditValue;
                if (oCPAmt != null && oCPAmt != DBNull.Value)
                {
                    dCPAmt = Convert.ToDouble(oCPAmt);
                }

                _bLotLoading = true;
                if (dCPAmt == 0)
                    txtCommPct.EditValue = 0;
                else
                    txtCommPct.EditValue = Math.Round(dAmt / dCPAmt * 100, 2, MidpointRounding.AwayFromZero);
                _bLotLoading = false;
            }
        }

        private void txtCommPct_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dPct = 0;
                object oPct = txtCommPct.EditValue;
                if (oPct != null && oPct != DBNull.Value)
                {
                    dPct = Convert.ToDouble(oPct);
                }

                double dCPAmt = 0;
                object oCPAmt = txtCurrentPrice.EditValue;
                if (oCPAmt != null && oCPAmt != DBNull.Value)
                {
                    dCPAmt = Convert.ToDouble(oCPAmt);
                }

                _bLotLoading = true;
                txtCommAmt.EditValue = Math.Round((dPct * .01) * dCPAmt, 2, MidpointRounding.AwayFromZero);
                _bLotLoading = false;
            }
        }

        private void txtCurrentPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dPct = 0;
                object oPct = txtCommPct.EditValue;
                if (oPct != null && oPct != DBNull.Value)
                {
                    dPct = Convert.ToDouble(oPct);
                }

                double dCPAmt = 0;
                object oCPAmt = txtCurrentPrice.EditValue;
                if (oCPAmt != null && oCPAmt != DBNull.Value)
                {
                    dCPAmt = Convert.ToDouble(oCPAmt);
                }

                _bLotLoading = true;
                txtCommAmt.EditValue = Math.Round((dPct * .01) * dCPAmt, 2, MidpointRounding.AwayFromZero);
                _bLotLoading = false;
            }
        }

        private void txtSqFt_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dAmt = 0;
                object oAmt = txtSqFt.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                _bLotLoading = true;
                txtAcres.EditValue = Math.Round(dAmt / CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
                CalculateMetricArea();
                _bLotLoading = false;
            }
        }

        private void txtAcres_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dAmt = 0;
                object oAmt = txtAcres.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                _bLotLoading = true;
                txtSqFt.EditValue = Math.Round(dAmt * CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
                CalculateMetricArea();
                _bLotLoading = false;
            }             
        }

        private void CalculateMetricArea()
        {
            
                double dAmt = 0;
                object oAmt = txtSqFt.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                txtSqMt.EditValue = Math.Round(dAmt / CONST_SQ_FT_IN_MT, 4, MidpointRounding.AwayFromZero);
                txtHectares.EditValue = Math.Round((dAmt / CONST_SQ_FT_IN_MT) / CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
                        
        }

        private void txtSqMt_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dAmt = 0;
                object oAmt = txtSqMt.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                _bLotLoading = true;
                txtHectares.EditValue = Math.Round(dAmt / CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
                CalculateImperialArea();
                _bLotLoading = false;
            }
        }

        private void txtHectares_EditValueChanged(object sender, EventArgs e)
        {
            if (!_bLotLoading)
            {
                double dAmt = 0;
                object oAmt = txtHectares.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                _bLotLoading = true;
                txtSqMt.EditValue = Math.Round(dAmt * CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
                CalculateImperialArea();
                _bLotLoading = false;
            }   
        }

        private void CalculateImperialArea()
        {
                double dAmt = 0;
                object oAmt = txtSqMt.EditValue;
                if (oAmt != null && oAmt != DBNull.Value)
                {
                    dAmt = Convert.ToDouble(oAmt);
                }

                txtSqFt.EditValue = Math.Round(dAmt * CONST_SQ_FT_IN_MT, 4, MidpointRounding.AwayFromZero);
                txtAcres.EditValue = Math.Round((dAmt * CONST_SQ_FT_IN_MT) / CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
            
        }

        private void gvAck_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow dr = gvAck.GetDataRow(e.RowHandle);
            if (e.Column == colName)
            {
                if (e.RowHandle == gvAck.FocusedRowHandle)
                {
                    e.RepositoryItem = riRestrictions;
                }
                else
                {
                    e.RepositoryItem = riAllRestrictions;
                }
            }
        }

        private void FillRestrictions(object oID)
        {
            dsRestrictions.Clear();
            if (daRestrictions.SelectCommand.Connection.State == ConnectionState.Closed)
            {
                if (oID == null || oID == DBNull.Value)
                {
                    DataRow dr = gvAck.GetDataRow(gvAck.FocusedRowHandle);
                    if (dr != null)
                    {
                        object obj = dr["RestrictionType_ID"];
                        if (obj != null && obj != DBNull.Value)
                        {
                            daRestrictions.SelectCommand.Parameters["@type_id"].Value = obj;
                            daRestrictions.Fill(dsRestrictions);
                        }
                    }
                }
                else
                {
                    daRestrictions.SelectCommand.Parameters["@type_id"].Value = oID;
                    daRestrictions.Fill(dsRestrictions);
                }
            }
        }

        private void riType_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            FillRestrictions(e.NewValue);
            gvAck.SetFocusedRowCellValue(colName, DBNull.Value);
            gvAck.SetFocusedRowCellValue(colDesc, DBNull.Value);
        }

        private void gvAck_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillRestrictions(null);
        }

        private void riRestrictions_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue != null)
            {
                object obj = lue.EditValue;
                if (obj != null && obj != DBNull.Value)
                {
                    object desc = lue.GetColumnValue("ExDescription");
                    gvAck.SetFocusedRowCellValue(colDesc, desc);
                }
                else
                {
                    gvAck.SetFocusedRowCellValue(colDesc, DBNull.Value);
                }
            }
        }

        private void gvAck_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvAck.GetDataRow(gvAck.FocusedRowHandle);
            if (dr != null)
            {
                object oTypeID = dr["RestrictionType_ID"];
                if (oTypeID == null || oTypeID == DBNull.Value)
                {
                    e.ErrorText = "Acknowledgments, Building Restrictions and Easements type is required.";
                    gvAck.FocusedColumn = colType;
                    e.Valid = false;
                    return;
                }

                object oBRID = dr["Building_Restrictions_ID"];
                if (oBRID == null || oBRID == DBNull.Value)
                {
                    e.ErrorText = "Name is required.";
                    gvAck.FocusedColumn = colName;
                    e.Valid = false;
                    return;
                }
            }
        }

        private void gvAck_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daAckResEas.Update(dsAckResEas);
        }

        private void gvAck_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gcAck_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete this record?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvAck.GetDataRow(gvAck.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["id"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from PROJ_LOT_RESTRICTION where id=" + oID;
                            Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Append && _LotID == -1)
            {
                Popup.ShowPopup("You must save this lot before you can add Acknowledgments, Building Restrictions and Easements.");
                e.Handled = true;
            }
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


        private void gvAck_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvAck.GetDataRow(gvAck.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["proj_lot_id"] = _LotID;
                dr.EndEdit();
            }
        }

        private void lueStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (!_ReadOnly)
            {
                int iStatus = 0;
                try { iStatus = Convert.ToInt32(lueStatus.EditValue); }
                catch { }

                if (iStatus == 3)
                {
                    LockLotInfo(true);
                    LockFinancial(true);
                }
                else
                {
                    LockLotInfo(false);
                    LockFinancial(false);
                }
            }
        }

        private void lueSubStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (!_ReadOnly)
            {
                int iStatus = 0;
                try { iStatus = Convert.ToInt32(lueSubStatus.EditValue); }
                catch { }

                if (iStatus == 9)
                {//lock 
                    LockLotInfo(true);
                  
                }
                
            }
        
        }


        private void be_Delete(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is ButtonEdit)
            {
                ((ButtonEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void txtCurrentPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if(!_bLotLoading)
                e.Cancel = !KCA_Validator.ValidatePassword(228);
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            using (WO_CentralizedFSManager.frmFileManager FileMgr = new WO_CentralizedFSManager.frmFileManager(Connection, DevXMgr, WO_CentralizedFSManager.DocumentViewerMode.All, sFileMgrType, _LotID, _ReadOnly))
            {
                FileMgr.ShowDialog();
                FileMgr.Dispose();
            }

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, _LotID, ref btnAttachments);
        }

        private void gvPurReq_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colCancel)
            {
                DataRow dr = gvPurReq.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    object oSTATUS = dr["route_status"];
                    if (oSTATUS == null || oSTATUS == DBNull.Value)
                    {
                        //lock down gl account
                        e.RepositoryItem = riDisCancel;
                        return;
                    }
                    if (oSTATUS.Equals("A"))
                    {
                        //lock down gl account
                        e.RepositoryItem = riCancel;
                        return;
                    }
                    else
                    {
                        //lock down gl account
                        e.RepositoryItem = riDisCancel;
                        return;
                    }
                }
            }
        }

        private void riCancel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!KCA_Validator.ValidatePassword(CONST_CANCEL_APPROVED_PUR_REQ))
                return;
            
            DataRow dr = gvPurReq.GetDataRow(gvPurReq.FocusedRowHandle);
            if (dr != null)
            {
                object oWS_LPR_ID = dr["WS_LPR_ID"];
                if (oWS_LPR_ID != null && oWS_LPR_ID != DBNull.Value)
                {
                    if (Popup.ShowPopup("Are you sure you want to cancel the approved purchase request?", WS_Popups.frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                    {
                        string sSQL = @"exec LD_CancelPurchaseReq "+oWS_LPR_ID+@", '" + Connection.MLUser + @"'";
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);

                        dsPurReq1.Clear();
                        daPurReq.Fill(dsPurReq1);
                    }
                }
            }
        }
        private bool bSettingValue = false;
        private void ceLongTermLease_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ReadOnly)
            {
                if (ceLongTermLease.Checked && !bSettingValue)
                {
                    bSettingValue = true;
                    ceTaxTitle.Checked = false;
                    bSettingValue = false;
                }
            }
        }

        private void ceTaxTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ReadOnly)
            {
                if (ceTaxTitle.Checked && !bSettingValue)
                {
                    bSettingValue = true;
                    ceLongTermLease.Checked = false;
                    bSettingValue = false;
                }
            }
        }

        private void ceLongTermLease_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_ReadOnly && !_bLotLoading)
            {
                if (ceTaxTitle.Checked && !bSettingValue)
                {
                    if (Popup.ShowPopup("You can only have Tax Title or Long Term Lease checked. Checking this will unselect Tax Title, are you sure you wish to proceed?", frmPopup.PopupType.OK_Cancel) != frmPopup.PopupResult.OK)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ceTaxTitle_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_ReadOnly && !_bLotLoading)
            {
                if (ceLongTermLease.Checked && !bSettingValue)
                {
                    if (Popup.ShowPopup("You can only have Tax Title or Long Term Lease checked. Checking this will unselect Long Term Lease, are you sure you wish to proceed?", frmPopup.PopupType.OK_Cancel) != frmPopup.PopupResult.OK)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void DateClear_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                try
                {
                    ((DevExpress.XtraEditors.DateEdit)sender).EditValue = DBNull.Value;
                }
                catch { }
            }
        }

      
        private void gvLotComment_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvLotComment.GetDataRow(gvLotComment.FocusedRowHandle);
            if (dr != null)
            {
                object oTypeID = dr[colComments.FieldName];
                if (oTypeID == null || oTypeID == DBNull.Value)
                {
                    e.ErrorText = "Comments are required.";
                    gvAck.FocusedColumn = colType;
                    e.Valid = false;
                    return;
                }

                
            }
        }

        private void gvLotComment_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            da_LotComments.Update(ds_LotComments1);
        }

        private void gcLotComment_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete this record?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvLotComment.GetDataRow(gvLotComment.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["ID"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from LD_Lot_Comments where id=" + oID;
                            Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Append && _LotID == -1)
            {
                Popup.ShowPopup("You must save this lot before you can comments.");
                e.Handled = true;
            }
        }

        private void gvLotComment_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvLotComment.GetDataRow(e.RowHandle);
            row[colMLUSer.FieldName] = Connection.MLUser;
            row[colDateSaved.FieldName] = DateTime.Now;
            row[colproj_lot_id.FieldName] = _LotID;

        }

        private void gvLotComment_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void tcCommunications_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tpCommunications)
            {
                miniMgmt.SetLink(new ContactMiniMgmt.FieldLink[] { 
                new ContactMiniMgmt.FieldLink(_ProjLot_FieldLink_ID, _LotID, "Land Lot"),
                new ContactMiniMgmt.FieldLink(_ProjLot_FieldLink_ID, _PriID, "Project",true,"ProjWO")});
                miniMgmt.SetReadOnly(_ReadOnly);
            }
        }

        private void txtOrgPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_bLotLoading)
                e.Cancel = !KCA_Validator.ValidatePassword(381);
        }

        private void CurrentPriceChangeLogEntry(int lot_id, double dCurrentPrice)
        {           
            double dCurrentPrice_new = 0;
            bool Track_Current_Lot_Price_Change = false;
            string sqlstr = "select isnull(Track_Current_Lot_Price_Change,0) from LD_Setup ";
            object obj = Connection.SQLExecutor.ExecuteScalar(sqlstr, Connection.TRConnection);
            if (obj != null && obj != DBNull.Value)
                Track_Current_Lot_Price_Change = Convert.ToBoolean(obj);
            if (Track_Current_Lot_Price_Change)
            {

                try { dCurrentPrice_new = Convert.ToDouble(txtCurrentPrice.EditValue); }
                catch { }
                if (dCurrentPrice_new != dCurrentPrice)
                {
                    frmComments frm = new frmComments(Connection, DevXMgr, lot_id, dCurrentPrice);
                    frm.ShowDialog();
                    frm.Dispose();
                    LoadCurrentPriceChangeHist(lot_id);
                }
            }
        }

        private void LoadCurrentPriceChangeHist(int lotID)
        {
            dsCurrentPriceChangeHist1.Clear();
            daCurrentPriceChangeHist.SelectCommand.Parameters["@proj_lot_id"].Value = lotID;
            daCurrentPriceChangeHist.Fill(dsCurrentPriceChangeHist1);
        }



    }
}
