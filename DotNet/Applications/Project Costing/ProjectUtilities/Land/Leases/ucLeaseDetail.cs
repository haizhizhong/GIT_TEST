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

namespace ProjectUtilities.Land.Leases
{
    public partial class ucLeaseDetail : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private int _Current_PriID = -1;
        private bool _ReadOnly = false;
        private string sFileMgrType = "PJLSE";
        

        public ucLeaseDetail(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            InitializeComponent();
            this.Connection = Connection;
            //sqlTRConnection = new System.Data.SqlClient.SqlConnection(Connection.TRConnection); DO NOT DO THIS AS WILL MESS-UP DATA ADAPTERS AND THEY HAVE OLD CONNECTION.
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            
            RunSetups();
        }

        private void RunSetups()
        {
            SetupUnits();
        }
        //global set
        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;
            SetReadOnlyState(ReadOnly);
            dnProject.Buttons.Append.Visible = !ReadOnly;
            dnProject.Buttons.Remove.Visible = !ReadOnly;
            dnProject.Buttons.EndEdit.Visible = !ReadOnly;
            dnProject.Buttons.CancelEdit.Visible = !ReadOnly;
            
        }
        //internal calls
        private void SetReadOnlyState(bool ReadOnly)
        {
            if (_ReadOnly)//global set trumps internal set if its readonly.
                ReadOnly = _ReadOnly;
            
            teName.Properties.ReadOnly = ReadOnly;
            teAddress1.Properties.ReadOnly = ReadOnly;
            teAddress2.Properties.ReadOnly = ReadOnly;
            teCity.Properties.ReadOnly = ReadOnly;
            tePhone.Properties.ReadOnly = ReadOnly;
            teFax.Properties.ReadOnly = ReadOnly;
            teEmail.Properties.ReadOnly = ReadOnly;
            lueStateProv.Properties.ReadOnly = ReadOnly;
            tePostalCode.Properties.ReadOnly = ReadOnly;
            deStartDate.Properties.ReadOnly = ReadOnly;
            deEndDate.Properties.ReadOnly = ReadOnly;
            dePaymentDate.Properties.ReadOnly = ReadOnly;
            tePaymentAmount.Properties.ReadOnly = ReadOnly;
            tePurpose.Properties.ReadOnly = ReadOnly;
            meComments.Properties.ReadOnly = ReadOnly;
            deExpiryDate.Properties.ReadOnly = ReadOnly;
            ceCertificateRecived.Properties.ReadOnly = ReadOnly;


           
        }

        public void LoadProject(int PriID)
        {
            
            _Current_PriID = PriID;
            dsLeases1.Clear();
            daLeases.SelectCommand.Parameters["@PRI_ID"].Value = PriID;
            daLeases.Fill(dsLeases1);

            dsStateProv1.Clear();
            daStateProv.Fill(dsStateProv1);
            
            gvLeases_RowCountChanged(gvLeases, null);
        }

        private void SetupUnits()
        {
            if (Connection.CountryCode.Equals("U"))
            {
                lciProv.Text = "State";
                lciPostal.Text = "Zip Code";
                colPROV.Caption = "State";
                colPOSTAL.Caption = "Zip Code";
            }
            else
            {
                lciProv.Text = "Province";
                lciPostal.Text = "Postal Code";
                colPROV.Caption = "Province";
                colPOSTAL.Caption = "Postal Code";
            }
        }

        private void ucLeaseDetail_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        

        private void dnProject_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            
            DataRow row = gvLeases.GetDataRow(gvLeases.FocusedRowHandle);

            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (isValid(row))
                {
                    if (row != null)//if row exsists update it.
                    {
                        daLeases.Update(dsLeases1);
                    }
                    gcLeases.Enabled = false;
                    SetReadOnlyState(false);
                    btnSharepoint.Enabled = false;
                }
                else
                    e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = true;
                if (Popup.ShowPopup("Are you sure you want to delete the selected lease?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                {
                    if (row != null)
                    {
                        if (row.RowState == DataRowState.Detached)
                            e.Handled = false;
                        else
                        {
                            row.Delete();
                            daLeases.Update(dsLeases1);
                        }
                        gcLeases.Enabled = true;
                        if (gvLeases.RowCount == 0 || (gvLeases.RowCount == 1 && row.RowState == DataRowState.Detached))
                        {
                            SetReadOnlyState(true);
                            btnSharepoint.Enabled = false;
                        }
                        else
                        {
                            btnSharepoint.Enabled = true;
                        }
                    }
                }
                
            }
            else if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                e.Handled = true;

                bs_Leases.CancelEdit();

                if (gvLeases.GetFocusedDataRow() != null)
                {
                    gvLeases.GetFocusedDataRow().RejectChanges();
                }

                if (gvLeases.FocusedRowHandle < 0)
                    gvLeases.FocusedRowHandle = 0;

                //if (row != null)
                //{
                    gcLeases.Enabled = true;
                    //gcLeases.EmbeddedNavigator.Buttons.DoClick(gcLeases.EmbeddedNavigator.Buttons.CancelEdit);
                    if (gvLeases.RowCount == 0)// || (gvLeases.RowCount == 1 && row.RowState == DataRowState.Detached))
                    {
                        SetReadOnlyState(true);
                        btnSharepoint.Enabled = false;
                    }
                    else
                    {
                        btnSharepoint.Enabled = true;
                    }
                //}
            }
            else if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            { 
                e.Handled = true;
                if (isValid(row))
                {
                    bs_Leases.EndEdit();
                    daLeases.Update(dsLeases1);
                    gcLeases.Enabled = true;

                    int iLeaseID = -1;
                    try { iLeaseID = Convert.ToInt32(gvLeases.GetFocusedDataRow()["LEASES_ID"]); }
                    catch { }

                    SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Project", ref btnSharepoint, "Leases", iLeaseID);
                }
                else
                {
                    gcLeases.Enabled = false;
                }

                btnSharepoint.Enabled = true;
            }
            



        }

        private bool isValid(DataRow row)
        {
            bool isValid = true;
            if (row != null)
            {
                //this will end any editors bound not just teName.
                teName.BindingManager.EndCurrentEdit();

                if (teName.Text.Trim() == "")
                {
                    teName.Focus();
                    Popup.ShowPopup("Name is required.");
                    isValid = false;
                }
                else if (deStartDate.Text.Trim() == "")
                {
                    deStartDate.Focus();
                    Popup.ShowPopup("Start date is required.");
                    isValid = false;
                }
                else if (deEndDate.Text.Trim() == "")
                {
                    deEndDate.Focus();
                    Popup.ShowPopup("End date is required.");
                    isValid = false;
                }
                else if (deStartDate.DateTime.CompareTo(deEndDate.DateTime) > 0)
                {
                    deStartDate.Focus();
                    Popup.ShowPopup("Start date must be less then end date.");
                    isValid = false;
                }
                else if (tePaymentAmount.Text.Trim() == "")
                {
                    tePaymentAmount.Focus();
                    Popup.ShowPopup("Payment amount is required.");
                    isValid = false;
                }
                else if (Convert.ToDouble(tePaymentAmount.EditValue) <= 0)
                {
                    tePaymentAmount.Focus();
                    Popup.ShowPopup("Payment amount must be greater then 0.");
                    isValid = false;
                }
            }
            return isValid;
        }

        private void gvLeases_RowCountChanged(object sender, EventArgs e)
        {
            DataRow row = gvLeases.GetDataRow(gvLeases.FocusedRowHandle);
            if( gvLeases.RowCount == 0  || (gvLeases.RowCount == 1 && row.RowState == DataRowState.Detached) )
                SetReadOnlyState(true);
            else
                SetReadOnlyState(false);
            
        }

        private void AllControls_EditValueChanged(object sender, EventArgs e)
        {
            if(sender != null)
            {
                if (sender is TextEdit)
                {
                    if (((TextEdit)sender).IsEditorActive)
                        gcLeases.Enabled = false;
                }
                else if (sender is DateEdit)
                {
                    if (((DateEdit)sender).IsEditorActive)
                        gcLeases.Enabled = false;
                }
                else if (sender is LookUpEdit)
                {
                    if (((LookUpEdit)sender).IsEditorActive)
                        gcLeases.Enabled = false;
                }
                
            }
        }

        private void gvLeases_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvLeases.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colPRI_ID.FieldName] = _Current_PriID;
                row[colCERT_RECEIVED.FieldName] = "F";
            }

        }

        private void btnSharepoint_Click(object sender, EventArgs e)
        {
            int iLeaseID = -1;
            try { iLeaseID = Convert.ToInt32(gvLeases.GetFocusedDataRow()["LEASES_ID"]); }
            catch { }

            using (SharePointMgr.frmSharePointMgr SharePointManager = new SharePointMgr.frmSharePointMgr(Connection, DevXMgr, "Project", "Leases", "", "Leases", iLeaseID))
            {
                SharePointManager.ReadOnly = _ReadOnly;
                SharePointManager.ShowDialog();
                SharePointManager.Dispose();
                SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Project", ref btnSharepoint, "Leases", iLeaseID);
            }
        }

        private void gvLeases_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int iLeaseID = -1;
            try { iLeaseID = Convert.ToInt32(gvLeases.GetDataRow(e.FocusedRowHandle)["LEASES_ID"]); }
            catch { }

            SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Project", ref btnSharepoint, "Leases", iLeaseID);
            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, iLeaseID, ref btnDirectAttachments);
        }

        private void btnDirectAttachments_Click(object sender, EventArgs e)
        {
            int iLeaseID = -1;
            try { iLeaseID = Convert.ToInt32(gvLeases.GetDataRow(gvLeases.FocusedRowHandle)["LEASES_ID"]); }

            catch { }

            using (WO_CentralizedFSManager.frmFileManager FileMgr = new WO_CentralizedFSManager.frmFileManager(Connection, DevXMgr, WO_CentralizedFSManager.DocumentViewerMode.All, sFileMgrType, iLeaseID, _ReadOnly))
            {
                FileMgr.ShowDialog();
                FileMgr.Dispose();
            }

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, sFileMgrType, iLeaseID, ref btnDirectAttachments);
        }

       


       
        
    }
}
