using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HMConnection;
using WS_Popups;
using ReflexMap;
using TUC_HMDevXManager;

namespace ProjectUtilities.Land.LotInventory
{
    public partial class ucSearch : DevExpress.XtraEditors.XtraUserControl
    {
        #region ucSearch Class Variables

        public delegate void LotView_Delegate(int LotID);
        public event LotView_Delegate LotView_Event;
        public delegate void LotEdit_Delegate(int LotID);
        public event LotEdit_Delegate LotEdit_Event;
        public delegate void LotChange_Delegate(int LotID);
        public event LotChange_Delegate LotChange_Event;
        public delegate void AddLot_Delegate();
        public event AddLot_Delegate AddLot_Event;

        private ComboSearch.Util CBOUtil;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private bool _ReadOnly = false;
        private int _PriID = -1;
        private bool _InProject = false;
        private int _Lot_ID = -1;
        private bool suppressMessage = false;

        const int CONST_AGREEMENT_ROUTING = 68;
        private ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer ucARHV;

        #endregion

        public ucSearch(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            CBOUtil = new ComboSearch.Util(DevXMgr);
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            RunSetups();

        }

        #region Setups

        private void RunSetups()
        {
            TR_Conn.ConnectionString = Connection.TRConnection;

            tcAddressSearch.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            object result = Connection.SQLExecutor.ExecuteScalar("select isnull(UsemunicipalAddr,0) from ld_Setup", Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error setting address type:" + Connection.SQLExecutor.Exception.Message);
            else if (result != null)
            {
                if (Convert.ToBoolean(result))
                {
                    tcAddressSearch.SelectedTabPage = tpMunicipal;
                    colAddr1.Visible = false;
                    colAddr1.OptionsColumn.ShowInCustomizationForm = false;
                    colAddr2.Visible = false;
                    colAddr2.OptionsColumn.ShowInCustomizationForm = false;

                }
                else
                {
                    tcAddressSearch.SelectedTabPage = tpCivic;
                    colma_StreetName.Visible = false;
                    colma_StreetName.OptionsColumn.ShowInCustomizationForm = false;
                    colma_streetNumber.Visible = false;
                    colma_streetNumber.OptionsColumn.ShowInCustomizationForm = false;
                    colma_StreetPrefixDir.Visible = false;
                    colma_StreetPrefixDir.OptionsColumn.ShowInCustomizationForm = false;
                    colma_StreetSuffix.Visible = false;
                    colma_StreetSuffix.OptionsColumn.ShowInCustomizationForm = false;
                    colma_streetSuffixdir.Visible = false;
                    colma_streetSuffixdir.OptionsColumn.ShowInCustomizationForm = false;


                }
            }
            else//default to civic
            {
                tcAddressSearch.SelectedTabPage = tpCivic;
            }

            hlRefresh_Click(null, null);

            SetupUnits();
        }

        private void SetupUnits()
        {
            if (Connection.CountryCode.Equals("U"))
            {
                lciProv.Text = "State";
                lciPostal.Text = "Zip Code";
                colProv.Caption = "State";
                colPostal.Caption = "Zip Code";
                lciCivPostal.Text = "Zip Code";
                lciCivProv.Text = "State";
            }
        }

        public void SetProjectSearch(bool InProject)
        {
            if (InProject)
            {
                _InProject = true;
                cboProject.Properties.ReadOnly = true;
                cboProject.Properties.Buttons[1].Visible = false;
                cboProjName.Properties.ReadOnly = true;
                cboProjName.Properties.Buttons[1].Visible = false;
                colpri_code.Visible = false;
                colpri_desc.Visible = false;
            }
            else
            {
                _InProject = false;
                cboProject.Properties.ReadOnly = false;
                cboProject.Properties.Buttons[1].Visible = true;
                cboProjName.Properties.ReadOnly = false;
                cboProjName.Properties.Buttons[1].Visible = true;
                colpri_code.Visible = true;
                colpri_desc.Visible = true;
                colpri_code.VisibleIndex = 0;
                colpri_desc.VisibleIndex = 1;
            }
        }

        #endregion

        public void Clear()
        {
            btnClear_Click(null, null);
            dsSearch1.Clear();
        }

        public int LotSelected()
        {
            int iLot = -1;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    iLot = Convert.ToInt32(oLOT_ID);
                }
            }

            return iLot;
        }

        private void dockManager1_Load(object sender, EventArgs e)
        {
            dpActions.Height = 285;
            if (!_InProject)
            {
                dockManager1.BeginUpdate();

                panelContainer1.RemovePanel(dpActions);
                panelContainer1.Update();

                dockManager1.EndUpdate();
            }
        }

        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;
        }

        public void LoadProject(int ProjectID)
        {
            if (ProjectID != _PriID)
            {
                _PriID = ProjectID;
                string sSelect = "select pri_code, pri_name from proj_header where pri_id=" + ProjectID;
                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        if (dr != null)
                        {
                            cboProject.Text = dr[0].ToString();
                            cboProjName.Text = dr[1].ToString();
                        }
                    }
                }
                btnClear_Click(null, null);
                dsSearch1.Clear();
            }
        }

        static class SecurityFunctions
        {
            public const int RM_PC_LD_LotInventory = 20717;
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            int tabFuncId = this.GetNearestSecurityFunctionID();
            if ((new List<int> { SecurityFunctions.RM_PC_LD_LotInventory }).Contains(tabFuncId))
            {
                MapShapeLayer shapeLayer = MapLinkTables.ProjectCostingLotInventory.CreatePolygonLayer("proj_lot_id");
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrClass, "Class"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrLot, "lot_num"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrBlock, "block_num"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrPlan, "plan_num"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrAddress, "address_1"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrStatus, "Lot_Status"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrSubStatus, "Sub_Status"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLotInventory.AttrPurchaser, "Purchaser"));

                MapPointLayer pointLayer = MapLinkTables.ProjectCostingLotInventory.CreatePointLayer("proj_lot_id");
                pointLayer.Attributes = shapeLayer.Attributes;

                ucMap1.Init(Connection, DevXMgr, gvLotSearch, new List<IMapLayer> { pointLayer, shapeLayer });
            }
            else
            {
                dpGIS.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }

            DevXMgr.FormInit(this);
        }

        private void ucSearch_Resize(object sender, EventArgs e)
        {
            dpActions.Height = 285;
        }

        private void hlAdd_Click(object sender, EventArgs e)
        {
            if (AddLot_Event != null)
                AddLot_Event();

        }

        private void hlView_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    if (LotView_Event != null)
                    {
                        LotView_Event(Convert.ToInt32(oLOT_ID));
                    }
                    Valid = true;
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No lot has been selected to view.");
            }
        }

        private void hlEdit_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    if (LotEdit_Event != null)
                    {
                        LotEdit_Event(Convert.ToInt32(oLOT_ID));
                    }
                    Valid = true;
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No lot has been selected to edit.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool bFieldsEmpty = true;
            daSearch.SelectCommand.Parameters["@username"].Value = Connection.MLUser;

            object oPriID = _PriID;
            if (_PriID == -1)
                oPriID = DBNull.Value;
            daSearch.SelectCommand.Parameters["@pri_id"].Value = oPriID;

            if (!_InProject)
            {
                if (!cboProject.Text.Trim().Equals(""))
                {
                    bFieldsEmpty = false;
                    daSearch.SelectCommand.Parameters["@pri_code"].Value = cboProject.Text;
                }
                else
                {
                    daSearch.SelectCommand.Parameters["@pri_code"].Value = DBNull.Value;
                }

                if (!cboProjName.Text.Trim().Equals(""))
                {
                    bFieldsEmpty = false;
                    daSearch.SelectCommand.Parameters["@pri_name"].Value = cboProjName.Text;
                }
                else
                {
                    daSearch.SelectCommand.Parameters["@pri_name"].Value = DBNull.Value;
                }
            }
            else
            {
                daSearch.SelectCommand.Parameters["@pri_code"].Value = DBNull.Value;
                daSearch.SelectCommand.Parameters["@pri_name"].Value = DBNull.Value;
            }

            if (lueClass.EditValue != null && lueClass.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@lot_class_id"].Value = lueClass.EditValue;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@lot_class_id"].Value = DBNull.Value;
            }

            if (lueSubClass.EditValue != null && lueSubClass.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@lot_sub_class_id"].Value = lueSubClass.EditValue;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@lot_sub_class_id"].Value = DBNull.Value;
            }

            if (!cboPlan.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@plan_num"].Value = cboPlan.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@plan_num"].Value = DBNull.Value;
            }

            if (!cboBlock.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@block_num"].Value = cboBlock.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@block_num"].Value = DBNull.Value;
            }

            if (!cboLot.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@lot_num"].Value = cboLot.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@lot_num"].Value = DBNull.Value;
            }

            if (luePurchaser.EditValue != null && luePurchaser.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@purchasers_id"].Value = luePurchaser.EditValue;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@purchasers_id"].Value = DBNull.Value;
            }

            if (!cboParcel.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@parcel_number"].Value = cboParcel.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@parcel_number"].Value = DBNull.Value;
            }

            if (!cboTitle.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@title_number"].Value = cboTitle.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@title_number"].Value = DBNull.Value;
            }

            if (!txtStreetPrefix.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@prefix_dir"].Value = txtStreetPrefix.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@prefix_dir"].Value = DBNull.Value;
            }

            if (!txtStreetNo.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@number"].Value = txtStreetNo.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@number"].Value = DBNull.Value;
            }

            if (!txtStreetName.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@name"].Value = txtStreetName.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@name"].Value = DBNull.Value;
            }

            if (!txtStreetSuffix.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@suffix"].Value = txtStreetSuffix.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@suffix"].Value = DBNull.Value;
            }

            if (!txtStreetSuffixDir.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@suffix_dir"].Value = txtStreetSuffixDir.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@suffix_dir"].Value = DBNull.Value;
            }

            if (!txtCity.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@city"].Value = txtCity.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@city"].Value = DBNull.Value;
            }

            if (!lueStateProv.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@prov"].Value = lueStateProv.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@prov"].Value = DBNull.Value;
            }

            if (!txtPostal.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@postal"].Value = txtPostal.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@postal"].Value = DBNull.Value;
            }

            if (!teCivAddress.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@civ_address_1"].Value = teCivAddress.Text.Replace("'", "''");
            }
            else
            {
                daSearch.SelectCommand.Parameters["@civ_address_1"].Value = DBNull.Value;
            }

            if (!teCivAddress2.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@civ_address_2"].Value = teCivAddress2.Text.Replace("'", "''");
            }
            else
            {
                daSearch.SelectCommand.Parameters["@civ_address_2"].Value = DBNull.Value;
            }

            if (!teCivCity.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@civ_city"].Value = teCivCity.Text.Replace("'", "''");
            }
            else
            {
                daSearch.SelectCommand.Parameters["@civ_city"].Value = DBNull.Value;
            }
            if (!lueCivProv.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@civ_prov"].Value = lueCivProv.Text.Replace("'", "''");
            }
            else
            {
                daSearch.SelectCommand.Parameters["@civ_prov"].Value = DBNull.Value;
            }
            if (!teCivPostal.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@civ_postal"].Value = teCivPostal.Text.Replace("'", "''");
            }
            else
            {
                daSearch.SelectCommand.Parameters["@civ_postal"].Value = DBNull.Value;
            }
            if (lueLotStatus.EditValue != null && lueLotStatus.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@lot_status_id"].Value = lueLotStatus.EditValue;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@lot_status_id"].Value = DBNull.Value;
            }
            if (lueSubStatus.EditValue != null && lueSubStatus.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@lot_substatus_id"].Value = lueSubStatus.EditValue;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@lot_substatus_id"].Value = DBNull.Value;
            }
            if (!cboFileNumber.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daSearch.SelectCommand.Parameters["@file_number"].Value = cboFileNumber.Text;
            }
            else
            {
                daSearch.SelectCommand.Parameters["@file_number"].Value = DBNull.Value;
            }



            if (bFieldsEmpty && !suppressMessage)
            {
                if (Popup.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    CL_Dialog.PleaseWait.Show("Loading Lot's...", null);
                    dsSearch1.Clear();
                    daSearch.Fill(dsSearch1);
                    CL_Dialog.PleaseWait.Hide();
                }
            }
            else
            {
                CL_Dialog.PleaseWait.Show("Loading Lot's...", null);
                dsSearch1.Clear();
                daSearch.Fill(dsSearch1);
                CL_Dialog.PleaseWait.Hide();
            }
            if (gvLotSearch.RowCount == 0)
            {
                if (LotChange_Event != null)
                    LotChange_Event(-1);
                _Lot_ID = -1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!_InProject)
            {
                cboProject.EditValue = null;
                cboProjName.EditValue = null;
            }
            lueClass.EditValue = null;
            lueSubClass.EditValue = null;
            cboPlan.EditValue = null;
            cboBlock.EditValue = null;
            cboLot.EditValue = null;
            luePurchaser.EditValue = null;
            cboParcel.EditValue = null;
            cboTitle.EditValue = null;
            lueLotStatus.EditValue = null;
            lueSubStatus.EditValue = null;
            cboFileNumber.EditValue = null;

            txtCity.EditValue = null;
            txtPostal.EditValue = null;
            lueStateProv.EditValue = null;
            txtStreetName.EditValue = null;
            txtStreetNo.EditValue = null;
            txtStreetPrefix.EditValue = null;
            txtStreetSuffix.EditValue = null;
            txtStreetSuffixDir.EditValue = null;

            teCivAddress.EditValue = null;
            teCivAddress2.EditValue = null;
            teCivCity.EditValue = null;
            lueCivProv.EditValue = null;
            teCivPostal.EditValue = null;

        }

        private void gvLotSearch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            hlUploadSlip.Enabled = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    if (LotChange_Event != null)
                        LotChange_Event(Convert.ToInt32(oLOT_ID));
                    _Lot_ID = Convert.ToInt32(oLOT_ID);
                    hlUploadSlip.Enabled = true;
                }
                else
                {
                    if (LotChange_Event != null)
                        LotChange_Event(-1);
                    _Lot_ID = -1;
                }
            }
            else
            {
                if (LotChange_Event != null)
                    LotChange_Event(-1);
                _Lot_ID = -1;
            }
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void cboProject_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, true,
                    "select distinct pri_code from proj_header where pri_type = 'PLC' order by pri_code");
            }
        }

        private void cboProjName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct pri_name from proj_header where pri_type = 'PLC' order by pri_name");
            }
        }

        private void cboPlan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct plan_num from proj_lot where pri_id = " + _PriID + " order by plan_num");
            }
        }

        private void cboBlock_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct block_num from proj_lot where pri_id = " + _PriID + " order by block_num");
            }
        }

        private void cboLot_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct lot_num from proj_lot where pri_id = " + _PriID + " order by lot_num");
            }
        }

        private void cboParcel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct parcel_number from proj_lot where pri_id = " + _PriID + " order by parcel_number");
            }
        }

        private void cboTitle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct title_number from proj_lot where pri_id = " + _PriID + " order by title_number");
            }
        }

        private void cboFileNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct file_number from PROJ_LOT_AGREEMENT a join PROJ_LOT l on a.proj_lot_id = l.proj_lot_id " +
                    "where a.agreement_status_id <> 2 and l.pri_id = " + _PriID + " order by file_number");
            }
        }



        private void hlCancel_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    Valid = true;

                    string sSQL = "declare @message varchar(250) " +
                        "exec sp_PC_LotDeleteValidation @message output, " + oLOT_ID + " " +
                        "select @message";
                    object oResult = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                    if (oResult != null && oResult != DBNull.Value)
                    {
                        if (oResult.Equals("OK"))
                        {
                            if (Popup.ShowPopup("Are you sure you want to delete the selected lot?", WS_Popups.frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                            {
                                string sDelete = @"
                                    declare @message varchar(250) 
                                    begin tran 
                                    exec PC_LotDelete " + oLOT_ID + @", @message output 
                                    if( isnull(@message,'') = 'OK' ) 
                                        commit tran 
                                    else 
                                        rollback tran 
                                    select @message";
                                object oResult2 = Connection.SQLExecutor.ExecuteScalar(sDelete, Connection.TRConnection);
                                if (oResult2 != null && oResult2 != DBNull.Value)
                                {
                                    if (oResult2.Equals("OK"))
                                    {
                                        gvLotSearch.DeleteRow(gvLotSearch.FocusedRowHandle);
                                    }
                                    else
                                    {
                                        Popup.ShowPopup(oResult2.ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            Popup.ShowPopup(oResult.ToString());
                        }
                    }
                    else
                    {
                        Popup.ShowPopup("Unable to delete lot.");
                    }
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No lot has been selected to delete.");
            }
        }

        private void hlRefresh_Click(object sender, EventArgs e)
        {
            dsLotClass.Clear();
            dsLotSubClass.Clear();
            dsPurchaser.Clear();
            ds_stateProv1.Clear();
            ds_LotStatus1.Clear();
            ds_LotSubStatus1.Clear();
            da_StateProv.Fill(ds_stateProv1);
            daLotClass.Fill(dsLotClass);
            daLotSubClass.Fill(dsLotSubClass);
            daPurchaser.Fill(dsPurchaser);
            da_LotStatus.Fill(ds_LotStatus1);
            da_LotSubStatus.Fill(ds_LotSubStatus1);
        }

        private void gvLotSearch_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLotID = dr["proj_lot_id"];
                if (oLotID != null && oLotID != DBNull.Value)
                {
                    if (LotView_Event != null)
                    {
                        LotView_Event(Convert.ToInt32(oLotID));
                    }
                }
            }
        }


        private void PostPreSaleDeposits(int _AgreementID)
        {
            //ANY CHANGES MADE HERE MUST ALSO BE DONE TO AGREEMENT "hlPost_Click(object sender, EventArgs e)"

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
                    //LoadLot(_LotID, _PriID);
                }
            }
            else
            {
                Popup.ShowPopup("There currently are no unprocessed presale deposits.");
            }

        }

        private void hlPost_Click(object sender, EventArgs e)
        {
            string sql = "select agreement_id from PROJ_LOT_AGREEMENT where agreement_status_id not in( 2,3) and proj_lot_id = " + _Lot_ID.ToString();
            object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
            {
                Popup.ShowPopup("Error checking for agreement:" + Connection.SQLExecutor.Exception.Message);
                return;
            }
            else if (result != null && result != DBNull.Value)
            {
                PostPreSaleDeposits(Convert.ToInt32(result));
            }
            else
                Popup.ShowPopup("Lot must have an agreement that is not canceled or completed");
        }

        private void hlMulti_LotEntry_Click(object sender, EventArgs e)
        {
            LoadMultiLotEntry();


        }
        private void LoadMultiLotEntry()
        {
            using (Form frmEntry = new Form())
            {

                using (LD_Multi_Lot_Entry.ucMulti_Lot_Entry multiLotEntry = new LD_Multi_Lot_Entry.ucMulti_Lot_Entry(Connection, DevXMgr, _Lot_ID, _PriID))
                {

                    multiLotEntry.frm = frmEntry;
                    frmEntry.Size = new Size(multiLotEntry.Width, multiLotEntry.Height);
                    frmEntry.WindowState = FormWindowState.Maximized;
                    frmEntry.StartPosition = FormStartPosition.CenterScreen;
                    multiLotEntry.Parent = frmEntry;
                    multiLotEntry.Dock = DockStyle.Fill;

                    frmEntry.Icon = this.ParentForm.Icon;
                    frmEntry.Text = "";

                    if (DialogResult.OK == frmEntry.ShowDialog())
                    {
                        suppressMessage = true;
                        btnSearch_Click(btnSearch, null);

                        suppressMessage = false;
                    }
                    frmEntry.Dispose();
                }

            }
        }
        private void layoutControlItem16_Click(object sender, EventArgs e)
        {

        }

        private void hlAgreementDocuments_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    Valid = true;
                    string sql = "select top 1 agreement_id from PROJ_LOT_AGREEMENT where agreement_status_id <> 2 and proj_lot_id = " + oLOT_ID.ToString();
                    object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                    if (result != null && result != DBNull.Value)
                    {
                        using (LD_Agree_WordMerge.frmAgreeDocs frm = new LD_Agree_WordMerge.frmAgreeDocs(Connection, DevXMgr, Convert.ToInt32(result)))
                        {
                            frm.ShowDialog();
                        }

                    }
                    else
                    {
                        Popup.ShowPopup("No agreements have been made on this lot.");
                    }
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No lot has been selected to edit.");
            }
        }

        private void hlUploadSlip_Click(object sender, EventArgs e)
        {
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    string sSQL = @"select count(*) from proj_lot where proj_lot_id=" + oLOT_ID + @" and Grade_Slip_Attached_TF='T'";
                    if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection)) > 0)
                    {
                        if (Popup.ShowPopup("The selected lot already has a grade slip uploaded for it. Continuing will replace the current file. Are you sure you want to continue?", frmPopup.PopupType.OK_Cancel) != frmPopup.PopupResult.OK)
                            return;
                    }
                    frmGradeSlip fGradeSlip = new frmGradeSlip(Connection, DevXMgr, Convert.ToInt32(oLOT_ID));
                    DialogResult result = fGradeSlip.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dr[colGrade_Slip_Attached_TF.FieldName] = "T";
                        Popup.ShowPopup("Upload Complete");
                    }
                }
            }
        }

        private void hlMulti_LotEntry_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;
        }

        private void ribeRouting_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle) != null)
            {
                string sApprovalStatus = "";
                try { sApprovalStatus = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle)["ApprovalStatus"].ToString(); }
                catch { }

                int iRequestID = -1, iAgreement_ID = -1;
                try { iRequestID = Convert.ToInt32(gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle)["ApprovalReqeust_ID"]); }
                catch { }
                try { iAgreement_ID = Convert.ToInt32(gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle)["agreement_id"]); }
                catch { }

                if (sApprovalStatus == "P" || sApprovalStatus == "D")
                {
                    bool bNoRecall = sApprovalStatus != "P";

                    using (DevExpress.XtraEditors.XtraForm fARHV = new XtraForm())
                    {
                        fARHV.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                        fARHV.ShowInTaskbar = false;

                        try
                        {
                            ucARHV = new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer(Connection, DevXMgr, false);

                            ucARHV.Dock = DockStyle.Fill;
                            ucARHV.RequestRecalled += new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer.Delegate_RequestRecalled(ucARHV_RequestRecalled);
                            ucARHV.RequestSubmitted += new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer.Delegate_RequestSubmitted(ucARHV_RequestSubmitted);
                            ucARHV.RefreshMe(iAgreement_ID.ToString(), "LAND", null, CONST_AGREEMENT_ROUTING, false, bNoRecall);
                            ucARHV.Parent = fARHV;
                            fARHV.StartPosition = FormStartPosition.CenterParent;
                            fARHV.Size = new Size(650, 650);
                            fARHV.ShowDialog();
                            ucARHV.Dispose();
                        }
                        finally
                        {
                            if (ucARHV != null)
                            {
                                if (!ucARHV.IsDisposed)
                                    ucARHV.Dispose();
                                ucARHV = null;
                            }
                        }
                    }
                }
            }
        }

        private void ucARHV_RequestRecalled(int ApprovalRequestID)
        {
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["AgreementRoutingStatus"] = "Recalled";
                dr.AcceptChanges();
                gvLotSearch.RefreshData();
                int iAgreement_ID = -1;
                try { iAgreement_ID = Convert.ToInt32(gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle)["agreement_id"]); }
                catch { }
                string sUpdate = "update proj_lot_agreement set ApprovalStatus='R' where agreement_id = " + iAgreement_ID;
                Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);
            }
        }

        private void ucARHV_RequestSubmitted(int ApprovalRequestID)
        {
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["AgreementRoutingStatus"] = "Recalled";
                dr.AcceptChanges();
                gvLotSearch.RefreshData();
                int iAgreement_ID = -1;
                try { iAgreement_ID = Convert.ToInt32(gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle)["agreement_id"]); }
                catch { }
                string sUpdate = "update proj_lot_agreement set ApprovalStatus='R' where agreement_id = " + iAgreement_ID;
                Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);

                if (ucARHV != null)
                    ucARHV.ParentForm.Close();
            }
        }

        private void hleCOSTest_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            bool LotSelected = false;
            DataRow dr = gvLotSearch.GetDataRow(gvLotSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOT_ID = dr["proj_lot_id"];
                if (oLOT_ID != null && oLOT_ID != DBNull.Value)
                {
                    LotSelected = true;
                    using (frmCOSTest frm = new frmCOSTest(Connection, DevXMgr, Convert.ToInt32(oLOT_ID)))
                    {
                        frm.ShowDialog();
                    }
                }
            }

            if (!LotSelected)
            {
                Popup.ShowPopup("No lot has been selected to edit.");
            }
        }

        private void hlPost_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;
        }

      

        private void LoadMultiLotEdit()
        {
                                 
            LD_Multi_Lot_Edit.frmLotEdit frm = new LD_Multi_Lot_Edit.frmLotEdit(Connection, DevXMgr, _PriID);
            if (DialogResult.OK == frm.ShowDialog())
            {
                suppressMessage = true;
                btnSearch_Click(btnSearch, null);
                suppressMessage = false;
            }
            frm.Dispose();
            //
        }

        private void hlMultiLotEdit_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;
        }

        private void hlMultiLotEdit_Click(object sender, EventArgs e)
        {
            LoadMultiLotEdit();
        }
    }
}
