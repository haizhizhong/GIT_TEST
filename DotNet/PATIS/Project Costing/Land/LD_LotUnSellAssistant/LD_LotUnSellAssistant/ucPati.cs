using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotUnSellAssistant
{
    public partial class ucPati : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private HMConnection.HMCon hmCon;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        private WS_Popups.frmPopup popup;

        private LD_LotSearch.ucLotSearch ucLotSearch;
        private ucReview ucRev;
        private ucSummary ucSum;
        private KeyControlAccess.Validator KCA_Validator;

        #endregion Local Variables

        #region Properties

        #endregion Properties

        public ucPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, KeyControlAccess.Validator pKCA_Valadator)
        {
            InitializeComponent();
            KCA_Validator = pKCA_Valadator;
            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

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

        #region Reset

        private void ResetPati()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpLotSelection;
            btnNext.Text = "Next >";
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            btnCancel.Enabled = true;
            RefreshLabels();
        }

        #endregion Reset

        #region Navigation

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
                    ucRev.RefreshMe();
                }

            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                if (ucRev.isValid())
                {
                    btnNext.Enabled = false;
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSum.RefreshMe(ucRev.acctYearPeriod1.luAcctPeriod.EditValue, ucRev.acctYearPeriod1.luAcctPeriod.Text, ucRev.acctYearPeriod1.luAcctYear.Text, ucRev.deUnSellDate.DateTime);
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
                    if (KCA_Validator.ValidatePassword(231))
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

        private void RefreshLabels()
        {
            if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                topBanner1.BannerText = "Select the lot you want to process.";
                topBanner1.BannerTitle = "Lot Selection";
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                topBanner1.BannerText = "Review the lot un-sell details and click next to continue.";
                topBanner1.BannerTitle = "Lot Un-Sell Details";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerText = "Review the lot un-sell information and click finish to complete the transaction.";
                topBanner1.BannerTitle = "Lot Un-Sell Summary";
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
                    ucLotSearch = new LD_LotSearch.ucLotSearch(hmCon, tuc_mgr, LD_LotSearch.LotSearchType.LotUnsellAssistant);
                    ucLotSearch.SingleSelect = true;
                    ucLotSearch.Dock = DockStyle.Fill;
                    ucLotSearch.Parent = tpLotSelection;
                    tuc_mgr.FormInit(ucLotSearch);
                }
            }
            else if (e.Page == tpReview)
            {
                if (ucRev == null)
                {
                    ucRev = new ucReview(hmCon, tuc_mgr,KCA_Validator);
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

        #endregion Navigation

        void ucSum_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }

        private bool isLotSelectionValid()
        {
            bool returnValue = true;

            returnValue = ucLotSearch.isValid(LD_LotSearch.Actions.GeneraicValidation);

            return returnValue;
        }
    }
}
