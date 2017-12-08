using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;



namespace LD_LotSaleAssistant
{
    public partial class ucPati : DevExpress.XtraEditors.XtraUserControl
    {


        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        
        LD_LotSearch.ucLotSearch ucLotSearch;
        ucReview ucRev;
        ucSummary ucSum;
        private KeyControlAccess.Validator KCA_Validator;

        public ucPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, KeyControlAccess.Validator pKCA_Valadator)
        {
            InitializeComponent();
            KCA_Validator = pKCA_Valadator;
            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

            object result = connection.SQLExecutor.ExecuteScalar("select isnull(SeperateDownPayment,0) from LD_Setup", connection.TRConnection);
            if (!Convert.ToBoolean(result))
            {
                rgSaleType.Properties.Items.RemoveAt(1);
            }
        }

        private void ucPati_Load(object sender, EventArgs e)
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
            RefreshLabels();
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

            }
            else if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                if (isLotSelectionValid())
                {
                    tcDetails.SelectedTabPage = tpReview;
                    ucRev.RefreshMe(rgSaleType.EditValue.ToString());
                }
               
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                if (ucRev.isValid())
                {
                    btnNext.Enabled = false;
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSum.RefreshMe(ucRev.acctYearPeriod1.luAcctPeriod.EditValue,ucRev.acctYearPeriod1.luAcctPeriod.Text, ucRev.acctYearPeriod1.luAcctYear.Text, ucRev.deInvoiceDate.DateTime,rgSaleType.EditValue.ToString());
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
                else //if (popup.ShowPopup("Are you sure you want to process the following lots?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    if (KCA_Validator.ValidatePassword(230))
                    {
                        if (ucSum.Finish())
                        {
                            btnNext.Text = "Restart";
                            btnARPayment.Visible = true;
                            btnBack.Enabled = false;
                        }
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
            btnARPayment.Visible = false;
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
                if (rgSaleType.EditValue.ToString().ToUpper() == "P")
                {
                    topBanner1.BannerText = "Review the lot(s) pre-sales information, click next to continue.";
                    topBanner1.BannerTitle = "Lot Pre-Sale";
                }
                else if (rgSaleType.EditValue.ToString().ToUpper() == "D")
                {
                    topBanner1.BannerText = "Review the lot(s) down payment information, click next to continue.";
                    topBanner1.BannerTitle = "Lot Down Payment";
                }
                else
                {
                    topBanner1.BannerText = "Review the lot(s) sales information, make / add any necessary adjustments and click next to continue.";
                    topBanner1.BannerTitle = "Lot Sale";
                }
            }
            else if(tcDetails.SelectedTabPage == tpSummary)
            {
                if (rgSaleType.EditValue.ToString().ToUpper() == "P")
                {
                    topBanner1.BannerText = "Review the lot(s) pre-sales information and click finish to complete the transaction.";
                    topBanner1.BannerTitle = "Lot Pre-Sale Summary";
                }
                else if (rgSaleType.EditValue.ToString().ToUpper() == "P")
                {
                    topBanner1.BannerText = "Review the lot(s) down payment information and click finish to complete the transaction.";
                    topBanner1.BannerTitle = "Lot Down Payment Summary";
                }
                else
                {
                    topBanner1.BannerText = "Review the lot(s) sales information and click finish to complete the transaction.";
                    topBanner1.BannerTitle = "Lot Sale Summary";
                }
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
                    ucLotSearch = new LD_LotSearch.ucLotSearch(hmCon, tuc_mgr, LD_LotSearch.LotSearchType.LotSaleAssistant);
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
        }
        void ucSum_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }
        private bool isLotSelectionValid()
        {
            bool returnValue = true;

            try
            {
                string sSQL = @"declare @message varchar(max)
                exec LD_lsa_ValidateLotSale '" + ucLotSearch.MLUser + @"', '" + rgSaleType.EditValue + @"', @message output
                select @message";
                object oResult = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (!oResult.Equals("ok"))
                {
                    popup.ShowPopup(oResult.ToString());
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error :" + ex.Message);
                returnValue = false;
            }

            return returnValue;
        }

        private void btnARPayment_Click(object sender, EventArgs e)
        {
            DoBatchRun();
        }

        private void DoBatchRun()
        {
            AR_Payments.ucAR_Payments ucARPayments = new AR_Payments.ucAR_Payments(hmCon, tuc_mgr, KCA_Validator);
                  
            ucARPayments = new AR_Payments.ucAR_Payments(hmCon, tuc_mgr, KCA_Validator);

            Form form = new Form();

            form.Size = new Size(1600, 900);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowIcon = false;
            form.Text = "AR Payments";

            ucARPayments.Dock = DockStyle.Fill;
            ucARPayments.Parent = form;

            form.Show();
            form.TopMost = true;
          


        }
    }
}
