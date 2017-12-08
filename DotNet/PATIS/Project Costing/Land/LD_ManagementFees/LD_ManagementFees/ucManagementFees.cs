using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ManagementFees
{
    public partial class ucManagementFees : DevExpress.XtraEditors.XtraUserControl
    {
        //IS CURRENTLY A SHELL UNTIL SPEC IS READY FOR THIS.

        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private LD_LotSearch.ucLotSearch LotSearch;
        private ucFeeSelection FeeSeletion;
        private ucSummary Summary;
        private int iManagementFee_ID = -1;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConnection
        {
            get { return ReflexCon; }
            set { ReflexCon = value; }
        }

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        #endregion Properties

        public ucManagementFees(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;

            sqlTR.ConnectionString = ReflexCon.TRConnection;

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcContent.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void ucManagementFees_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            if(this.ParentForm != null)
                this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
            daManagementFeeList.Fill(dsManagementFeeList1);

            dxStyle.FormInit(this);
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearWorkingTables();
        }

        #region Buttons

        private void btnBack_Click(object sender, EventArgs e)
        {
            MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmMessageBox.ShowPopup("Are you sure you wish to cancel?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
            {
                ResetPati();
            }
        }

        #endregion Buttons

        #region Navigation

        private void MoveNext()
        {
            if (tcMain.SelectedTabPage == tpWelcome)
            {
                if (ValidateWelcomeScreen())
                {
                    tcMain.SelectedTabPage = tpContent;
                    tcContent.SelectedTabPage = tpLotSelection;
                    LoadLotSelection();
                    btnCancel.Enabled = true;
                    btnBack.Enabled = true;
                }
            }
            else if (tcContent.SelectedTabPage == tpLotSelection)
            {
                if (ValidateLotSelection())
                {
                    tcContent.SelectedTabPage = tpFeeSelection;
                    LoadFeeSelection();
                }
            }
            else if (tcContent.SelectedTabPage == tpFeeSelection)
            {
                if (ValidateFeeSelection())
                {
                    tcContent.SelectedTabPage = tpSummary;
                    LoadSummary();
                    btnNext.Enabled = false;
                    btnNext.Text = "Finish";
                }
            }
            else if (tcContent.SelectedTabPage == tpSummary)
            {
                if (btnNext.Text == "Finish")
                {
                    bool bValid = true;
                    if(Summary != null)
                        bValid = Summary.ProcessSummary();

                    btnBack.Enabled = false;
                    btnCancel.Enabled = false;
                    btnNext.Text = "Restart";
                }
                else
                {
                    ResetPati();
                }
            }

            SetBannerText();
        }

        private void MovePrevious()
        {
            if (tcContent.SelectedTabPage == tpLotSelection)
            {
                tcMain.SelectedTabPage = tpWelcome;
                btnBack.Enabled = false;
            }
            else if (tcContent.SelectedTabPage == tpFeeSelection)
            {
                tcContent.SelectedTabPage = tpLotSelection;
            }
            else if (tcContent.SelectedTabPage == tpSummary)
            {
                tcContent.SelectedTabPage = tpFeeSelection;
                btnNext.Text = "Next >";
                btnNext.Enabled = true;
            }

            SetBannerText();
        }

        private void SetBannerText()
        {
            if (tcContent.SelectedTabPage == tpLotSelection)
            {
                topBanner1.BannerTitle = "Lot/Agreement Selection";
                topBanner1.BannerText = "Select the lot agreement(s) you want to manage.";
            }
            if (tcContent.SelectedTabPage == tpFeeSelection)
            {
                topBanner1.BannerTitle = "Management Fee Selection";
                topBanner1.BannerText = "Review calculated amounts and over-ride if required. Click next to continue.";
            }
            if (tcContent.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerTitle = "Summary";
                topBanner1.BannerText = "Review the management fee summary and click finish to complete the transaction.";
            }

            topBanner1.RefreshLabels();
        }

        private void ResetPati()
        {
            tcMain.SelectedTabPage = tpWelcome;
            tcContent.SelectedTabPage = tpLotSelection;
            btnCancel.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = true;
            btnNext.Text = "Next >";
            dsManagementFeeList1.Clear();
            daManagementFeeList.Fill(dsManagementFeeList1);
            lueManagementFeeList.EditValue = null;
            iManagementFee_ID = -1;

            ClearWorkingTables();
        }

        private void ClearWorkingTables()
        {
            ReflexCon.SQLExecutor.ExecuteNonQuery("Delete working_ld_lmf_LotList Where Username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
        }

        #endregion Navigation

        #region Welcome Screen

        private bool ValidateWelcomeScreen()
        {
            if (lueManagementFeeList.EditValue == null || lueManagementFeeList.EditValue == DBNull.Value)
            {
                frmMessageBox.ShowPopup("Please select a management fee to continue.");
                return false;
            }

            return true;
        }

        #endregion Welcome Screen

        #region Lot Selection

        private void LoadLotSelection()
        {
            if (LotSearch == null)
            {
                LotSearch = new LD_LotSearch.ucLotSearch(ReflexCon, dxStyle, LD_LotSearch.LotSearchType.ManagementFeesAssistant);
                LotSearch.Dock = DockStyle.Fill;
                LotSearch.Parent = tpLotSelection;
            }

            LotSearch.RefreshMe();
            try { iManagementFee_ID = Convert.ToInt32(lueManagementFeeList.EditValue); }
            catch { }
            LotSearch.ManagementFee_ID = iManagementFee_ID;
        }

        private bool ValidateLotSelection()
        {
            bool bValid = false;

            if (LotSearch != null)
                bValid = LotSearch.isValid(LD_LotSearch.Actions.GeneraicValidation);

            return bValid;
        }

        #endregion Lot Selection

        #region Fee Selection

        private void LoadFeeSelection()
        {
            if (FeeSeletion == null)
            {
                FeeSeletion = new ucFeeSelection(ReflexCon, dxStyle);
                FeeSeletion.Dock = DockStyle.Fill;
                FeeSeletion.Parent = tpFeeSelection;
            }

            FeeSeletion.RefreshFeeSelection(iManagementFee_ID);
        }

        private bool ValidateFeeSelection()
        {
            if (FeeSeletion != null)
                return FeeSeletion.ValidateFeeSelection();

            return false;
        }

        #endregion Fee Selection

        #region Summary

        private void LoadSummary()
        {
            if (Summary == null)
            {
                Summary = new ucSummary(ReflexCon, dxStyle);
                Summary.Printed += new ucSummary.PrintedDelegate(Summary_Printed);
                Summary.Dock = DockStyle.Fill;
                Summary.Parent = tpSummary;
            }

            if(FeeSeletion != null)
                Summary.RefreshSummary(FeeSeletion.Year, FeeSeletion.Period, FeeSeletion.RecoveryDate);
        }

        private void Summary_Printed()
        {
            btnNext.Enabled = true;
        }

        #endregion Summary
    }
}
