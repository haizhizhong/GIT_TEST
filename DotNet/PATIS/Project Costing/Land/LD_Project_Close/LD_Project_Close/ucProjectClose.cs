using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Project_Close
{
    public partial class ucProjectClose : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        ProjectUtilities.ucSearch ucProjSearch;
        ucReview ucRev;
        ucSummary ucSum;
        private KeyControlAccess.Validator KCA_Validator;


        public ucProjectClose(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,KeyControlAccess.Validator pKCA_Valadator)
        {
            InitializeComponent();
            KCA_Validator = pKCA_Valadator;
            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void ucProjectClose_Load(object sender, EventArgs e)
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
                tcDetails.SelectedTabPage = tpProjSelection;
                //ucProjSearch.RefreshMe();
                btnBack.Enabled = true;

            }
            else if (tcDetails.SelectedTabPage == tpProjSelection)
            {
                if (isProjectSelectionValid())
                {
                    tcDetails.SelectedTabPage = tpReview;
                    ucRev.RefreshMe(ucProjSearch.ProjectSelected());
                }

            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                if (ucRev.isValid())
                {
                    btnNext.Enabled = false;
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSum.RefreshMe(ucRev.acctYearPeriod1.luAcctPeriod.EditValue, ucRev.acctYearPeriod1.luAcctPeriod.Text, ucRev.acctYearPeriod1.luAcctYear.Text, ucRev.deInvoiceDate.DateTime);
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
                else 
                {
                    if (KCA_Validator.ValidatePassword(105))
                    {
                        if (popup.ShowPopup("Are you sure you want to close the listed project(s)?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        {
                            if (ucSum.Finish())
                            {
                                btnNext.Text = "Restart";
                                btnBack.Enabled = false;
                            }
                        }
                    }
                }
            }
        }
        private void MoveBack()
        {
            if (tcDetails.SelectedTabPage == tpProjSelection)
            {
                ResetPati();
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                tcDetails.SelectedTabPage = tpProjSelection;
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
            tcDetails.SelectedTabPage = tpProjSelection;
            btnNext.Text = "Next >";
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            RefreshLabels();
        }
        private void RefreshLabels()
        {
            if (tcDetails.SelectedTabPage == tpProjSelection)
            {
                topBanner1.BannerText = "Select the project you want to close.";
                topBanner1.BannerTitle = "Project Selection";
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                topBanner1.BannerText = "Review your project close details and click next to continue.";
                topBanner1.BannerTitle = "Project Close Details";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerText = "Review the project close detail and click finish to close the project.";
                topBanner1.BannerTitle = "Project Close Summary";
            }


            topBanner1.RefreshLabels();
        }
        private void tcMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tcDetails_SelectedPageChanged(tcDetails, new DevExpress.XtraTab.TabPageChangedEventArgs(tcDetails.SelectedTabPage, tcDetails.SelectedTabPage));
        }
        private void tcDetails_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tpProjSelection)
            {
                if (ucProjSearch == null)
                {
                    ucProjSearch = new ProjectUtilities.ucSearch(hmCon, tuc_mgr, ProjectTypes.ProjectType.PC_Land_Construction);
                    ucProjSearch.Dock = DockStyle.Fill;
                    ucProjSearch.Parent = tpProjSelection;
                    ucProjSearch.HideActions();
                    
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

        private bool isProjectSelectionValid()
        {
            bool returnValue = true;

            if (ucProjSearch.ProjectSelected() == -1)
            {
                popup.ShowPopup("You must select a project to continue.");
                returnValue = false;
            }
            else if (GetIntFromSQL("select COUNT(*) from PROJ_LOT where lot_status_id != 3 and pri_id = "+ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("All lots must be sold to close a project.");
                returnValue = false;                
            }
            else if (GetIntFromSQL("select COUNT(*) from PROJ_LOT_AGREEMENT where agreement_status_id not in(2,3) and pri_id =  " + ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("All agreements must be completed or canceled to close a project.");
                returnValue = false; 
            }
            else if (GetIntFromSQL("select COUNT(*) from PO_HEADER h join PO_DETAIL d on d.PO_ID=h.PO_ID where h.STATUS not in ('Complete', 'Cancel') and d.pri_id=" + ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("All PO's must be completed or canceled to close a project.");
                returnValue = false; 
            }
            else if (GetIntFromSQL("select COUNT(*) from PO_HEADER h where h.STATUS not in ('Complete', 'Cancel') and h.pri_num =" + ucProjSearch.ProjectNumberSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("All PO's must be completed or canceled to close a project.");
                returnValue = false;
            }
            else if (GetIntFromSQL("select count(*) from AP_INV_HEADER h join AP_GL_ALLOC d on h.AP_INV_HEADER_ID=d.AP_INV_HEADER_ID where isnull(h.ACCRUAL_FLAG,'U') = 'U' and d.pri_id=" + ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("Project still has outstanding invoices and can not be closed.");
                returnValue = false;
            }
            else if (GetIntFromSQL("select count(*) from GL_JOURNAL_HEADERS h join GL_JOURNAL_DETAIL d on d.JOURNAL_ID=h.JOURNAL_ID where h.STATUS = 'N' and d.pri_id=" + ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("Project still has unposted journal entries and cannot be closed.");
                returnValue = false;
            }
            else if (GetIntFromSQL("select count(*) from GL_SUBLEDGER_HEADERS h join GL_SUBLEDGER_DETAIL d on d.SUBLEDGER_NUMBER=h.SUBLEDGER_NUMBER where h.STATUS = 'N' and d.pri_id=" + ucProjSearch.ProjectSelected().ToString(), hmCon.TRConnection, 1) > 0)
            {
                popup.ShowPopup("Project still has unposted subledger entries and cannot be closed.");
                returnValue = false;
            }
            return returnValue;
        }


        private int GetIntFromSQL(string sql, string connectionString,int NullOrErrorReturn)
        {

            object result = hmCon.SQLExecutor.ExecuteScalar(sql, connectionString);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error in sql:" + hmCon.SQLExecutor.Exception.Message + "\r\n" + sql);
            else if (result != null && result != DBNull.Value)
            {
                try
                {
                    NullOrErrorReturn = Convert.ToInt32(result);
                }
                catch { }

            }
            return NullOrErrorReturn;
        }

        void ucSum_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }
    }
}
