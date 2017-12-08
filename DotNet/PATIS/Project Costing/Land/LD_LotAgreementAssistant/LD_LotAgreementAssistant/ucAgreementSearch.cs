using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAgreementAssistant
{
    public partial class ucAgreementSearch : DevExpress.XtraEditors.XtraUserControl
    {

        private HMConnection.HMCon hmCon;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        private WS_Popups.frmPopup popup;

        private int _currentAgreement = -1;
        public int CurrentAgreement
        {
            get { return _currentAgreement; }
            
        }
        private bool isFilling = false;
        public ucAgreementSearch(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_AgreementSearch.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            SetCountryInfo();
			
        }

        private void SetCountryInfo()
        {
            if (hmCon.CountryCode == "U")
            {
                colgst.Caption = "Tax 1";
                colpst.Caption = "Tax 2";
            }
            else if (hmCon.CountryCode == "C")
            {
                colgst.Caption = "GST";
                colpst.Caption = "PST";
            }
        }


        public void RefreshMe()
        {
            Clear();
            try
            {
                //avoids conflictions with new agreement section. this search is used only with "Edit" agreement.
                hmCon.SQLExecutor.ExecuteNonQuery("delete working_ld_LotSearch where username = '" + hmCon.MLUser + "LotAgreementAssistant')", hmCon.TRConnection);
                _currentAgreement = -1;
                ds_AgreementSearch1.Clear();
                ds_SearchLookups1.Clear();
                

                da_SearchLookups.Fill(ds_SearchLookups1);

            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error in refresh me call:" + ex.Message);
            }
            lueAgreementStatus.EditValue = 1;
        }

        public void Clear()
        {
            lueAgreementType.EditValue = DBNull.Value;
            lueMasterAgreement.EditValue = DBNull.Value;
            lueAgreementNum.EditValue = DBNull.Value;
            lueAgreementStatus.EditValue = DBNull.Value;
            lueCommunity.EditValue = DBNull.Value;
            lueProject.EditValue = DBNull.Value;
            luePurchaser.EditValue = DBNull.Value;
        }

        private void LookupsButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                if (sender != null)
                {
                    if (sender is LookUpEdit)
                    {
                        ((LookUpEdit)sender).EditValue = DBNull.Value;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lueAgreementNum.Text == "" && lueAgreementStatus.Text == "" && lueAgreementType.Text == "" && lueMasterAgreement.Text == "" &&
                lueCommunity.Text == "" && lueProject.Text == "" && luePurchaser.Text == "")
            {
                if (popup.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.Cancel)
                    return;
            }



            RunSearch();

            isFilling = true;
            ds_AgreementSearch1.Clear();
            da_AgreementSearch.Fill(ds_AgreementSearch1);
            isFilling = false;
            gvAgreementSelection_FocusedRowChanged(gvAgreementSelection,new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle,gvAgreementSelection.FocusedRowHandle));

        }

        private void RunSearch()
        {
            string sql = "LD_laa_AgreementSearch";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql);
            cmd.Connection = new System.Data.SqlClient.SqlConnection(hmCon.TRConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@agreementType", SqlDbType.VarChar);
            cmd.Parameters.Add("@MasterAgreement", SqlDbType.Int);
            cmd.Parameters.Add("@Agreement", SqlDbType.Int);
            cmd.Parameters.Add("@AgreementStatus_ID", SqlDbType.Int);
            cmd.Parameters.Add("@Community_ID", SqlDbType.Int);
            cmd.Parameters.Add("@Pri_id", SqlDbType.Int);
            cmd.Parameters.Add("@Purchaser_ID", SqlDbType.Int);

            cmd.Parameters["@username"].Value = hmCon.MLUser;
            cmd.Parameters["@agreementType"].Value = lueAgreementType.EditValue == DBNull.Value ? "" : lueAgreementType.EditValue;
            cmd.Parameters["@MasterAgreement"].Value = lueMasterAgreement.EditValue == DBNull.Value ? -1 : lueMasterAgreement.EditValue ;
            cmd.Parameters["@Agreement"].Value = lueAgreementNum.EditValue == DBNull.Value ? -1 : lueAgreementNum.EditValue;
            cmd.Parameters["@AgreementStatus_ID"].Value = lueAgreementStatus.EditValue == DBNull.Value ? -1 : lueAgreementStatus.EditValue;
            cmd.Parameters["@Community_ID"].Value = lueCommunity.EditValue == DBNull.Value ? -1 : lueCommunity.EditValue;
            cmd.Parameters["@Pri_id"].Value = lueProject.EditValue == DBNull.Value ? -1 : lueProject.EditValue;
            cmd.Parameters["@Purchaser_ID"].Value = luePurchaser.EditValue == DBNull.Value ? -1 : luePurchaser.EditValue;

            
  
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading agreement search:" + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

        }

        private void gvAgreementSelection_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            int curAggrID = -1;
            DataRow row = gvAgreementSelection.GetFocusedDataRow();
            if (row != null)
            {
                try
                {
                    curAggrID = Convert.ToInt32(row[colagreement_id.FieldName]);
                }
                catch { }
            }
            _currentAgreement = curAggrID;
        }


        public bool isValid()
        {
            bool returnValue = true;
            DataRow row = gvAgreementSelection.GetDataRow(gvAgreementSelection.FocusedRowHandle);
            if (row != null)
            {
                if (row[colagreement_status_id.FieldName].ToString() != "1")
                {
                    popup.ShowPopup("You can only edit active agreemeents.");
                    returnValue = false;
                }
            }
            else
            {
                popup.ShowPopup("Please select an agreement to edit.");
                returnValue = false;
            }


            return returnValue;
        }

    }
}
