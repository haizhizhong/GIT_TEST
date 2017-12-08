using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_CashCall
{
    public enum PatiType { Cashcall, Distribution };

    public partial class ucCashCallPati : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        PatiType _type;
        ucProjectSelection ucProjSelect;
        ucSummaryCashCall ucSummCash;
        CashFlow.ucReportViews rv;
        

        public ucCashCallPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, PatiType pType)
        {
            InitializeComponent();

            con = connection;
            sqlConnection1.ConnectionString = con.WebConnection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            _type = pType;

            if (_type == PatiType.Cashcall)
            {
                welcomeScreen1.Description = "This assistant will help in creating cash call A/R invoices and letters for development projects. You may either load previously created batches or create a new batch.";
                welcomeScreen1.Title = "Cash Call Assistant";
                welcomeScreen1.RefreshLabels();
            }
            else
            {
                welcomeScreen1.Description = "This assistant will help in creating distribution A/P invoices for development projects. You may either load previously created batches or create a new batch.";
                welcomeScreen1.Title = "Distribution Assistant";
                welcomeScreen1.RefreshLabels();
            }

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            daBatches.SelectCommand.Parameters["@CompanyID"].Value = con.CompanyID;
        }
        public void ResetPati()
        {
            tcDetails.SelectedTabPage = tpProjSelection;
            tcMain.SelectedTabPage = tpMain;
            btnBack.Enabled = false;
            btnNext.Text = "&Next";
            btnNext.Enabled = true;
            btnCancel.Enabled = false;
            btnCancel.Text = "&Cancel";
            if (ucSummCash != null)
            {
                ucSummCash.Parent = null;
                ucSummCash = null;
            }
            if (rv != null)
            {
                rv.Parent = null;
                rv = null;
            }
            luBatches.EditValue = null;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetPati();
        }
        private void ucCashCallPati_Load(object sender, EventArgs e)
        {
            ResetPati();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_type == PatiType.Cashcall)
                BackCash();
            else
                BackDist();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_type == PatiType.Cashcall)
                NextCash();
            else
                NextDist();
        }
        private void LoadProjectSelection()
        {
            if (ucProjSelect == null)
            {
                ucProjSelect = new ucProjectSelection(con, tuc_mgr, _type);
                ucProjSelect.Dock = DockStyle.Fill;
                ucProjSelect.Parent = tpProjSelection;
            }
            ucProjSelect.RefreshProjectSelection();
        }
        
        #region Cash Call
        private void NextCash()
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                if (tcMain.SelectedTabPage == tpMain)
                {
                    LoadProjectSelection();
                    btnBack.Enabled = true;
                    btnCancel.Enabled = true;
                    tcMain.SelectedTabPage = tpDetails;
                    tcDetails.SelectedTabPage = tpProjSelection;
                }
                else if (tcDetails.SelectedTabPage == tpProjSelection)
                {
                    if (ucProjSelect.IsValid())
                    {
                        LoadCashSelection();
                        rv.panelControl1.SendToBack();
                        rv.gcProjects.BringToFront();
                        tcDetails.SelectedTabPage = tpCalculations;
                        rv.gcProjects.Parent = rv.tpProjectBreakdown;
                    }
                }
                else if (tcDetails.SelectedTabPage == tpCalculations)
                {
                    LoadCashSummary();
                    tcDetails.SelectedTabPage = tpSummary;
                    ucSummCash.GenerateCashcall(false);
                    btnNext.Text = "&Finish";
                }
                else if (tcDetails.SelectedTabPage == tpSummary)
                {
                    ProcessCashCall();
                }
            }
            else
            {
                if (luBatches.EditValue == null)
                    return;
                if (tcMain.SelectedTabPage == tpMain)
                {
                    //selected a previous batch            
                    if (ucSummCash == null)
                    {
                        ucSummCash = new ucSummaryCashCall(con, tuc_mgr, Convert.ToInt32(luBatches.EditValue), PatiType.Cashcall, this);
                        ucSummCash.Dock = DockStyle.Fill;
                        ucSummCash.Parent = tpSummary;
                    }
                    ucSummCash.BatchID = Convert.ToInt32(luBatches.EditValue);
                    tcMain.SelectedTabPage = tpDetails;
                    tcDetails.SelectedTabPage = tpSummary;
                    btnBack.Enabled = true;
                    btnCancel.Enabled = true;
                    if (tcDetails.SelectedTabPage == tpSummary)//may have been dissallowed due to invalid accounts
                    {
                        btnNext.Text = "&Finish";
                        ucSummCash.GenerateCashcall(false);
                    }
                }
                else
                {
                    //processing
                    ProcessCashCall();
                }
            }
            SetTopBannerTextCash();
        }
        private void ProcessCashCall()
        {
            ucSummCash.GenerateCashcall(true);
            pop.ShowPopup("The cash call invoices have been successfully created.");
            btnBack.Enabled = false;
            btnCancel.Text = "&Restart";
            btnNext.Enabled = false;
        }
        private void BackCash()
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                if (tcDetails.SelectedTabPage == tpProjSelection)
                {
                    tcMain.SelectedTabPage = tpMain;
                    btnBack.Enabled = false;
                    btnCancel.Enabled = false;
                }
                else if (tcDetails.SelectedTabPage == tpCalculations)
                {
                    tcDetails.SelectedTabPage = tpProjSelection;
                }
                else if (tcDetails.SelectedTabPage == tpSummary)
                {
                    btnNext.Text = "&Next";
                    tcDetails.SelectedTabPage = tpCalculations;
                }
            }
            else
            {
                ResetCalculationsTab();
                btnNext.Enabled = true;
            }
            SetTopBannerTextCash();
        }
        private void LoadCashSelection()
        {
            string pri_ids = "", pati_type = "C";
            if (_type == PatiType.Distribution)
                pati_type = "D";
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(@"
select * from working_LD_CashDist_Selection 
where selected = 1 
and pati_type = '" + pati_type + @"'
and username = '" + con.MLUser + "'", con.TRConnection);
            foreach (DataRow dr in dt.Rows)
            {
                pri_ids += dr["pri_id"].ToString() + ", ";
            }
            pri_ids = pri_ids.Substring(0, pri_ids.Length - 2);
            if (rv == null)
            {
                rv = new CashFlow.ucReportViews(tuc_mgr, con);
                rv.RunType = _type.ToString();
                rv.Pri_IDS = pri_ids;
                rv.Consolidated = true;
                rv.Dock = DockStyle.Fill;
                rv.Parent = pcCashflow;
            }
        }
        private void LoadCashSummary()
        {
            if (ucSummCash == null)
            {
                ucSummCash = new ucSummaryCashCall(con, tuc_mgr, rv.BatchID, PatiType.Cashcall, this);
                ucSummCash.Dock = DockStyle.Fill;
                ucSummCash.Parent = tpSummary;
            }
            ucSummCash.BatchID = rv.BatchID;
        }
        private void SetTopBannerTextCash()
        {
            if (tcDetails.SelectedTabPage == tpProjSelection)
            {
                topBanner.BannerText = "Select the project(s) on which you would like to run a cash call.";
                topBanner.BannerTitle = "Project Selection";
            }
            else if (tcDetails.SelectedTabPage == tpCalculations)
            {
                topBanner.BannerText = "'System Date' determines actuals / projections, while 'As At' determines the covering period.";
                topBanner.BannerTitle = "Cash Flow Analysis";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner.BannerText = "Create A/R Invoices && Cash Call Letters.";
                topBanner.BannerTitle = "Cash Call Summary";
            }
            topBanner.RefreshLabels();
        }
        #endregion Cash Call

        #region Distribution
        private void NextDist()
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                if (tcMain.SelectedTabPage == tpMain)
                {
                    LoadProjectSelection();
                    btnBack.Enabled = true;
                    btnCancel.Enabled = true;
                    tcMain.SelectedTabPage = tpDetails;
                    tcDetails.SelectedTabPage = tpProjSelection;
                }
                else if (tcDetails.SelectedTabPage == tpProjSelection)
                {
                    if (ucProjSelect.IsValid())
                    {
                        LoadDistSelection();
                        rv.panelControl1.SendToBack();
                        rv.gcProjects.BringToFront();
                        tcDetails.SelectedTabPage = tpCalculations;
                        rv.gcProjects.Parent = rv.tpProjectBreakdown;
                    }
                }
                else if (tcDetails.SelectedTabPage == tpCalculations)
                {
                    LoadDistSummary();
                    tcDetails.SelectedTabPage = tpSummary;
                    if (tcDetails.SelectedTabPage == tpSummary)//may have been dissallowed due to invalid accounts
                    {
                        btnNext.Text = "&Finish";
                        ucSummCash.GenerateDistribution(false);
                    }
                }
                else if (tcDetails.SelectedTabPage == tpSummary)
                {
                    ProcessDistribution();
                }
            }
            else
            {
                if (luBatches.EditValue == null)
                    return;
                if (tcMain.SelectedTabPage == tpMain)
                {
                    //selected a previous batch            
                    if (ucSummCash == null)
                    {
                        ucSummCash = new ucSummaryCashCall(con, tuc_mgr, Convert.ToInt32(luBatches.EditValue), PatiType.Distribution, this);
                        ucSummCash.Dock = DockStyle.Fill;
                        ucSummCash.Parent = tpSummary;
                    }
                    ucSummCash.BatchID = Convert.ToInt32(luBatches.EditValue);
                    tcMain.SelectedTabPage = tpDetails;
                    tcDetails.SelectedTabPage = tpSummary;
                    btnBack.Enabled = true;
                    btnCancel.Enabled = true;
                    if (tcDetails.SelectedTabPage == tpSummary)//may have been dissallowed due to invalid accounts
                    {
                        btnNext.Text = "&Finish";
                        ucSummCash.GenerateDistribution(false);
                    }
                }
                else
                {//is processing page
                    ProcessDistribution();   
                }
            }
            SetTopBannerTextDist();
        }
        private void ProcessDistribution()
        {
            string s = "";
            if (btnNext.Text == "&Create A/P Invoice")
            {
                ucSummCash.GenerateDistribution(true);
                pop.ShowPopup("The distribution invoices have been successfully created.");
                btnBack.Enabled = false;
                btnCancel.Text = "&Restart";
                btnNext.Enabled = false;
            }
            else if (btnNext.Text == "&Re-Route For Approval" || btnNext.Text == "&Route For Approval")
            {

                int requestID = LoadRequestViewer(84, ucSummCash.BatchID.ToString(), "Investor Distribution", "Batch #" + ucSummCash.BatchID.ToString(), false);
                if (requestID != -1)
                {
                    string sql = "";
                    if (requestID == -2)//recalled
                    {
                        sql = "update LD_CashcallDisbursementHeader set BatchStatus = 'Created', RoutingID = null where ID = " + ucSummCash.BatchID.ToString();
                        s = "This distribution batch has routing request has been recalled.";
                    }
                    else
                    {
                        sql = "update LD_CashcallDisbursementHeader set BatchStatus = 'Routed', RoutingID = " + requestID + " where ID = " + ucSummCash.BatchID.ToString();
                        s = "This distribution batch has been routed for approval.";
                    }
                    con.SQLExecutor.ExecuteNonQuery(sql, con.WebConnection);
                }
                if(s != "")
                    pop.ShowPopup(s);
            }
            if (s != "")
            {
                btnBack.Enabled = false;
                btnCancel.Text = "&Restart";
                btnNext.Enabled = false;
            }
        }
        private int LoadRequestViewer(int topicID, string moduleReferenceID, string request, string notes, bool AutoLoad)
        {
            int returnValue = -1;

            ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer viewer;
            if (AutoLoad)
            {
                viewer =
                      new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer(con, tuc_mgr, moduleReferenceID, request, notes, topicID, false);
                viewer.Submit();
            }
            else
                viewer = new ApprovalRequestHistoryViewer.ucApprovalRequestHistoryViewer(con,
                tuc_mgr,
                moduleReferenceID,
                request,
                notes,
                topicID,
                true);
            if (viewer.Submitted)
            {
                returnValue = viewer.ApprovalRequestID;
            }
            else if (viewer.Recalled)
            {
                returnValue = -2;
            }
            return returnValue;
        }
        private void BackDist()
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                if (tcDetails.SelectedTabPage == tpProjSelection)
                {
                    tcMain.SelectedTabPage = tpMain;
                    btnBack.Enabled = false;
                    btnCancel.Enabled = false;
                }
                else if (tcDetails.SelectedTabPage == tpCalculations)
                {
                    tcDetails.SelectedTabPage = tpProjSelection;

                }
                else if (tcDetails.SelectedTabPage == tpSummary)
                {
                    ResetCalculationsTab();
                }
            }
            else
            {
                ResetCalculationsTab(); 
                btnNext.Enabled = true;
            }
            SetTopBannerTextDist();
        }
        public void ResetCalculationsTab()
        {
            btnNext.Text = "&Next";
            if (radioGroup1.SelectedIndex == 0)
            {
                tcDetails.SelectedTabPage = tpCalculations;
            }
            else
            {
                tcDetails.SelectedTabPage = tpCalculations;
                tcMain.SelectedTabPage = tpMain;
                btnBack.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        private void LoadDistSelection()
        {
            string pri_ids = "", pati_type = "C";
            if (_type == PatiType.Distribution)
                pati_type = "D";
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(@"
select * from working_LD_CashDist_Selection 
where selected = 1 
and pati_type = '" + pati_type + @"'
and username = '" + con.MLUser + "'", con.TRConnection);
            foreach (DataRow dr in dt.Rows)
            {
                pri_ids += dr["pri_id"].ToString() + ", ";
            }
            pri_ids = pri_ids.Substring(0, pri_ids.Length - 2);
            if (rv == null)
            {
                rv = new CashFlow.ucReportViews(tuc_mgr, con);
                rv.RunType = _type.ToString();
                rv.Pri_IDS = pri_ids;
                rv.Consolidated = true;
                rv.Dock = DockStyle.Fill;
                rv.Parent = pcCashflow;
            }
        }
        private void LoadDistSummary()
        {
            if (ucSummCash == null)
            {
                ucSummCash = new ucSummaryCashCall(con, tuc_mgr, rv.BatchID, PatiType.Distribution, this);
                ucSummCash.Dock = DockStyle.Fill;
                ucSummCash.Parent = tpSummary;
            }
            ucSummCash.BatchID = rv.BatchID;
        }
        private void SetTopBannerTextDist()
        {
            if (tcDetails.SelectedTabPage == tpProjSelection)
            {
                topBanner.BannerText = "Select the project(s) on which you would like to run a distribution.";
                topBanner.BannerTitle = "Project Selection";
            }
            else if (tcDetails.SelectedTabPage == tpCalculations)
            {
                topBanner.BannerText = "'System Date' determines the value of actuals to distribute.";
                topBanner.BannerTitle = "Cash Flow Analysis";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner.BannerText = "Create A/P Invoices && Distribution Letters.";
                topBanner.BannerTitle = "Distribution Summary";
            }
            topBanner.RefreshLabels();
        }
        #endregion Distribution

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                luBatches.Visible = false;
            }
            else
            {
                luBatches.Visible = true;
            }
        }
        private void luBatches_QueryPopUp(object sender, CancelEventArgs e)
        {
            dsBatches1.Tables[0].Clear();
            daBatches.SelectCommand.Parameters["@Type"].Value = _type.ToString();
            daBatches.Fill(dsBatches1);
        }
        private void luBatches_EditValueChanged(object sender, EventArgs e)
        {
            luBatches.Properties.Buttons[1].Visible = false;
            if (luBatches.EditValue != null)
            {
                object oStatus = con.SQLExecutor.ExecuteScalar(@"
select BatchStatus FROM LD_CashcallDisbursementHeader WHERE id = " + luBatches.EditValue.ToString(), con.WebConnection);
                if (oStatus != null && oStatus != DBNull.Value)
                {
                    if (oStatus.ToString() == "Created" || oStatus.ToString() == "Approved"
                        || oStatus.ToString() == "Declined")
                        luBatches.Properties.Buttons[1].Visible = true;
                }
            }
        }
        private void luBatches_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                con.SQLExecutor.ExecuteNonQuery(@"
declare @BatchID int = " + luBatches.EditValue.ToString() + @"
delete LD_CashcallDisbursementDetail WHERE Batchid = @BatchID
delete LD_CashcallDisbursementHeader WHERE id = @BatchID", con.WebConnection);

            }
        }
        
    }
}
