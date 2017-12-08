using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAdjustmentAssistant
{
    public partial class ucLotAdjustments : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;

        LD_LotSearch.ucLotSearch ucLotSearch;
        ucReview ucRev;
        ucSummary ucSum;


        public ucLotAdjustments(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void ucLotAdjustments_Load(object sender, EventArgs e)
        {
            ResetPati();
            RefreshLabels();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MoveBack();
            RefreshLabels();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (popup.ShowPopup("Are you sure you want to cancel?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                ResetPati();
            }
        }

        private void MoveNext()
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                tcMain.SelectedTabPage = tpDetails;
                tcDetails.SelectedTabPage = tpLotSelection;
                ucLotSearch.RefreshMe();
                btnBack.Enabled = true;
                btnCancel.Enabled = true;
            }
            else if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                if (isLotSelectionValid())
                {
                    tcDetails.SelectedTabPage = tpReview;
                    ucRev.RefreshMe();
                }

            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                if (ucRev.isValid())
                {
                    btnNext.Enabled = false;
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSum.RefreshMe(ucRev.acctYearPeriod1.luAcctPeriod.EditValue,ucRev.acctYearPeriod1.luAcctPeriod.Text, ucRev.acctYearPeriod1.luAcctYear.Text, ucRev.deInvoiceDate.DateTime);
                    btnNext.Text = "Finish";
                }
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                if (btnNext.Text == "Restart")
                {
                    if (popup.ShowPopup("Are you sure you want to restart?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        ResetPati();

                }
                else //if (popup.ShowPopup("Are you sure you want to process the listed lots?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    if (ucSum.Finish())
                    {
                        btnNext.Text = "Restart";
                        btnBack.Enabled = false;
                        btnCancel.Enabled = false;
                    }
                }
            }
        }

        private void MoveBack()
        {
            if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                ResetPati();
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                tcDetails.SelectedTabPage = tpLotSelection;
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                btnNext.Enabled = true;
                tcDetails.SelectedTabPage = tpReview;
                btnNext.Text = "Next >";
            }
        }

        private void ResetPati()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpLotSelection;
            btnNext.Text = "Next >";
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            btnCancel.Enabled = false;
            RefreshLabels();
        }

        private void RefreshLabels()
        {
            if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                topBanner1.BannerText = "Select the lot(s) you want to process.";
                topBanner1.BannerTitle = "Lot Selection";
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                topBanner1.BannerText = "Enter your lot sale adjustments and click next to continue.";
                topBanner1.BannerTitle = "Lot Sale Adjustments";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerText = "Review the lots sale adjustments and click finish to complete the transaction.";
                topBanner1.BannerTitle = "Lot Sale Adjustment Summary";
            }


            topBanner1.RefreshLabels();
        }

        private void tcMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tcDetails_SelectedPageChanged(tcDetails, new DevExpress.XtraTab.TabPageChangedEventArgs(tcDetails.SelectedTabPage, tcDetails.SelectedTabPage));
        }
        private void tcDetails_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tpLotSelection)
            {
                if (ucLotSearch == null)
                {
                    ucLotSearch = new LD_LotSearch.ucLotSearch(hmCon, tuc_mgr, LD_LotSearch.LotSearchType.LotSaleAdjustments);
                    ucLotSearch.Dock = DockStyle.Fill;
                    ucLotSearch.Parent = tpLotSelection;
                    tuc_mgr.FormInit(ucLotSearch);
                }
            }
            else if (e.Page == tpReview)
            {
                if (ucRev == null)
                {
                    ucRev = new ucReview(hmCon, tuc_mgr);
                    ucRev.Dock = DockStyle.Fill;
                    ucRev.Parent = tpReview;
                    tuc_mgr.FormInit(ucRev);
                }
            }
            else if (e.Page == tpSummary)
            {
                if (ucSum == null)
                {
                    ucSum = new ucSummary(hmCon, tuc_mgr);
                    ucSum.Dock = DockStyle.Fill;
                    ucSum.Parent = tpSummary;
                    ucSum.RegisterPrinted += new ucSummary.Delegate_Action_Clicked(ucSum_RegisterPrinted);
                    tuc_mgr.FormInit(ucSum);

                }
            }
            RefreshLabels();
        }

        void ucSum_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }

        private bool isLotSelectionValid()
        {
            bool returnValue = true;

            string sql = "LD_ladj_ValidateAdjustments";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql);
            cmd.Connection = new System.Data.SqlClient.SqlConnection(hmCon.TRConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = ucLotSearch.MLUser;//special username for common search object.
            
            cmd.Parameters.Add("@message", SqlDbType.VarChar, 1000).Direction = ParameterDirection.InputOutput;
            cmd.Parameters["@message"].Value = "";



            try
            {
                cmd.Connection.Open();
                object result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (cmd.Parameters["@message"].Value.ToString().ToLower() != "ok")
                {
                    popup.ShowPopup(cmd.Parameters["@message"].Value.ToString());
                    returnValue = false;
                }

            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error :" + ex.Message);
                returnValue = false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }


            return returnValue;

        }



    }
}
