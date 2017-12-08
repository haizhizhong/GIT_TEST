using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_AgreementsInterest
{
    public partial class ucPati : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;

        LD_LotSearch.ucLotSearch ucLotSearch;
        ucCalculation ucCalc;
        ucSummary ucSum;

        public ucPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            //sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }


        private void SetBannerLabels()
        {
            if (tcDetails.SelectedTabPage == tpSearch)
            {
                topBanner1.BannerText = "Select the lot agreement(s) you want to manage.";
                topBanner1.BannerTitle = "Lot/Agreement Selection";
            }
            else if (tcDetails.SelectedTabPage == tpCalculation)
            {
                topBanner1.BannerText = "Review Interest details and click next to continue.";
                topBanner1.BannerTitle = "Lot Interest Details";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerText = "Review the Interest Summary and click Finish to complete.";
                topBanner1.BannerTitle = "Interest Summary";
            }
            topBanner1.RefreshLabels();
        }

        private void ResetPati()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpSearch;
            btnNext.Text = "Next >";
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            btnCancel.Enabled = false;
            SetBannerLabels();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcDetails.SelectedTabPage == tpSearch)
            {
                ResetPati();
            }
            else if (tcDetails.SelectedTabPage == tpCalculation)
            {
                tcDetails.SelectedTabPage = tpSearch;
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                btnNext.Enabled = true;
                tcDetails.SelectedTabPage = tpCalculation;
                btnNext.Text = "Next";
            }
            SetBannerLabels();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                
                
                if(ucLotSearch == null)
                {
                    ucLotSearch = new LD_LotSearch.ucLotSearch(con, tuc_mgr, LD_LotSearch.LotSearchType.AgreementsInterest);
                    ucLotSearch.Dock = DockStyle.Fill;
                    ucLotSearch.Parent = tpSearch;
                }
                ucLotSearch.RefreshMe();
                
                btnBack.Enabled = true;
                btnCancel.Enabled = true;
                tcMain.SelectedTabPage = tpDetails;
                tcDetails.SelectedTabPage = tpSearch;

            }
            else if (tcDetails.SelectedTabPage == tpSearch)
            {
                if (isLotSelectionValid())
                {
                    if(ucCalc == null)
                    {
                        ucCalc = new ucCalculation(con, tuc_mgr, ucLotSearch.SearchUsername);
                        ucCalc.Dock = DockStyle.Fill;
                        ucCalc.Parent = tpCalculation;
                    }
                    ucCalc.RefreshMe();
                    tcDetails.SelectedTabPage = tpCalculation;
                }

            }
            else if (tcDetails.SelectedTabPage == tpCalculation)
            {
                if (ucCalc.isValid())
                {
                    btnNext.Enabled = false;
                    if (ucSum == null)
                    {
                        ucSum = new ucSummary(con, tuc_mgr,ucLotSearch.SearchUsername);
                        ucSum.Dock = DockStyle.Fill;
                        ucSum.Parent = tpSummary;
                        ucSum.RegisterPrinted += UcSum_RegisterPrinted;
                    }
                    ucSum.RefreshMe(ucCalc.acctYearPeriod1.luAcctPeriod.EditValue, ucCalc.acctYearPeriod1.luAcctPeriod.Text, ucCalc.acctYearPeriod1.luAcctYear.Text, ucCalc.deInterestDate.DateTime);
                    btnNext.Text = "Finish";
                    tcDetails.SelectedTabPage = tpSummary;

                }
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                if (btnNext.Text == "Restart")
                {
                    if (pop.ShowPopup("Are you sure you want to restart?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        ResetPati();

                }
                else if (pop.ShowPopup("Are you sure you want to process the listed lots?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    if (ucSum.ValidateSummary())
                    {
                        ucSum.Finish();
                        btnNext.Text = "Restart";
                        btnBack.Enabled = false;
                    }
                }
            }

            SetBannerLabels();
        }

        private void UcSum_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pop.ShowPopup("Are you sure you want to cancel?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                ResetPati();
            }
            SetBannerLabels();
        }

        private bool isLotSelectionValid()
        {
            bool returnValue = false;
            returnValue = ucLotSearch.isValid(LD_LotSearch.Actions.GeneraicValidation);

            return returnValue;
        }

    }
}
