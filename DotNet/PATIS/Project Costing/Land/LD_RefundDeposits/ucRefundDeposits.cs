using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RefundDeposits
{
    public partial class ucRefundDeposits : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;

        LD_LotSearch.ucLotSearch ucLotSearch;
        ucSummary ucSum;
      

        public ucRefundDeposits(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();
            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            
        }

        private void ucRefundDeposits_Load(object sender, EventArgs e)
        {
            ResetPati();
            RefreshLabels();
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
          
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerText = "Review the Deposit Refund Summary and click Finish to complete the transaction.";
                topBanner1.BannerTitle = "Summary";
            }


            topBanner1.RefreshLabels();
        }

        private void MoveBack()
        {
            if (tcDetails.SelectedTabPage == tpLotSelection)
            {
                ResetPati();
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                tcDetails.SelectedTabPage = tpLotSelection;
                btnNext.Enabled = true;
                btnNext.Text = "Next >";
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
                    btnNext.Enabled = false;
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSum.RefreshMe();
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
                    ucLotSearch = new LD_LotSearch.ucLotSearch(hmCon, tuc_mgr, LD_LotSearch.LotSearchType.RefundDeposit);
                    ucLotSearch.Dock = DockStyle.Fill;
                    ucLotSearch.Parent = tpLotSelection;
                    tuc_mgr.FormInit(ucLotSearch);
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

        private bool isLotSelectionValid()
        {
            bool returnValue = true;
            string Misc_Supplier_Code = "";
            string sql = "select isnull(Misc_Supplier_Code,'') from LD_Setup";
            object obj = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
            
            if (obj != null && obj != DBNull.Value)
            {
                Misc_Supplier_Code = obj.ToString();
              
            }
            sql = "select COUNT(ID) from working_ld_LotSearch where  selected = 1 and username = '" + hmCon.MLUser + "RefundDeposit" + "'";
            int count = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection));


            if (Misc_Supplier_Code == "")
            {
                popup.ShowPopup("A MISC supplier is required. ");
                returnValue = false;
            }
            else if (count == 0)
            {
                popup.ShowPopup("Please select at least one lot to continue.");
                returnValue = false;
            }
            return returnValue;

        }
       
        //
    }
}
