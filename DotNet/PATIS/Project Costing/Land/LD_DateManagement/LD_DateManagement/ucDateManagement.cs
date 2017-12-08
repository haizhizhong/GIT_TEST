using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;

namespace LD_DateManagement
{

      
    public partial class ucDateManagement : DevExpress.XtraEditors.XtraUserControl
    {
        //IS CURRENTLY A SHELL UNTIL SPEC IS READY FOR THIS.

        #region Local Variables

        private WS_Popups.frmPopup Popups;
        private LD_LotSearch.ucLotSearch lotSearch;
        private ucDateUpdate dateUpdate;


        private string sType = "AgreementDateManagement";
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

        public ucDateManagement(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            LoadUserControls();
            DeleteWorkingTables();
        }

        private void ucDateManagement_Load(object sender, EventArgs e)
        {
            SetupControls();
            SetupButtons();
            dxStyle.FormInit(this);
        }
        private void LoadUserControls()
        {
            Popups = new WS_Popups.frmPopup(dxStyle);
            lotSearch = new LD_LotSearch.ucLotSearch(ReflexCon, dxStyle, LD_LotSearch.LotSearchType.AgreementDateManagement);
            lotSearch.Dock = DockStyle.Fill;
            lotSearch.Parent = pcLotSelection;
            lotSearch.BringToFront();
            lotSearch.RefreshMe();

            dateUpdate = new ucDateUpdate(ReflexCon, dxStyle);
            dateUpdate.Dock = DockStyle.Fill;
            dateUpdate.Parent = pcDateUpdate;
            dateUpdate.dateManagement_Main = this;
        }

        private void SetupButtons()
        {
            btnCancel.Enabled = true;
            btnFinish.SendToBack();

            btnNext.Enabled = (tcMain.SelectedTabPageIndex < tcMain.TabPages.Count - 1);
            btnBack.Enabled = (tcMain.SelectedTabPageIndex > 0);
            if (tcMain.SelectedTabPage == tpDateUpdate)
            {
                btnFinish.BringToFront();
                btnFinish.Enabled = false;
            }
            //if (this.adjSummary != null)
            //{
            //    this.adjSummary.SetupPrintButtons();
            //}


        }

        private void SetupControls()
        {
            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcMain.SelectedTabPage = tpWelcome;
                        
            // WelcomeScreen

            welcomeScreen.Title = "Date Management Assistant" ;
            welcomeScreen.Description = "Use this assistant to help you in managing dates on your agreements.";
            welcomeScreen.RefreshLabels();

            // Lot Selection
            topBanner_LotSelection.BannerTitle = "Lot / Agreement Selection";
            topBanner_LotSelection.BannerText = "Select the agreement(s) you want to manage.";
            topBanner_LotSelection.RefreshLabels();

            // Date Updates
            topBanner_DateUpdates.BannerTitle = "Date Management";
            topBanner_DateUpdates.BannerText = "Enter the dates manually or use the Update All option to update dates";
            topBanner_DateUpdates.RefreshLabels();

            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetTabPageNext();
            SetupButtons();
        }

        private string VerifySelection()
        {
            string msg = "";
            
            if (tcMain.SelectedTabPage == tpLotSelection)
            {
                string sqlstr = " select COUNT(*) from working_ld_LotSearch where username = "
                     + "'" + ReflexCon.MLUser + sType+"'"
                      + " and selected =1 and isnull(agreement_id,0) <> 0 ";
                int count = Convert.ToInt32(ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection));
                if (count == 0)
                    msg = "You need to select at least one agreement to continue.";
                else
                {
                    sqlstr = "select  count(distinct pri_id) from  working_ld_LotSearch where  selected =1 and isnull(agreement_id,0) <> 0 and  username = "
                          + "'" + ReflexCon.MLUser + sType + "'";
                    count = Convert.ToInt32(ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection));
                    if (count > 1)
                        msg = "You cannot select agreement(s) from different project(s).";
                }
            }
            return msg;
        }

        private void SetTabPageNext()
        {
            try
            {                
                string msg = VerifySelection();
                if (msg != "")
                {
                    Popups.ShowPopup(this, msg);
                    return;
                }
                else
                {
                    this.tcMain.SelectedTabPageIndex++;
                    if (tcMain.SelectedTabPage == tpDateUpdate)
                    {
                        if (dateUpdate != null)
                        {
                            dateUpdate.RefreshDateHdr();
                            dateUpdate.SetupControls();
                        }
                    }
                   
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found in SetTabPageNext process in ucDateManagement: " + ex.StackTrace.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetTabPageBack();
            SetupButtons();
        }
        private void SetTabPageBack()
        {
            this.tcMain.SelectedTabPageIndex--;
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Popups.ShowPopup(this, "Cancel Process Assistant?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
            {

                ResetPati();
            }
        
        }
        private void ResetPati()
        {
            DeleteWorkingTables();
            btnFinish.Text = "Finish";
            tcMain.SelectedTabPageIndex = 0;
            lotSearch.RefreshMe();
            SetupButtons();
            dateUpdate.ClearSelection();
        }

        private void DeleteWorkingTables()
        {
            string sqlStr = "delete Working_Agreement_Date_Hdr where username ='" +ReflexCon.MLUser+"'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sqlStr, ReflexCon.TRConnection);
            sqlStr = "delete Working_Agreement_Date_Det where username ='" + ReflexCon.MLUser + "'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sqlStr, ReflexCon.TRConnection);

            sqlStr = "delete working_ld_LotSearch where username = " + "'" + ReflexCon.MLUser + sType + "'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sqlStr, ReflexCon.TRConnection);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (this.btnFinish.Text == "Finish")
            {
                string agreeNum = "";
                string sql = " exec WS_GetDateChangedAgreements "  + "'" + ReflexCon.MLUser + "'";
                object obj = ReflexCon.SQLExecutor.ExecuteScalar(sql, ReflexCon.TRConnection);
                if (obj != null && obj != DBNull.Value)
                {
                    if (obj.ToString() != "")
                        agreeNum = obj.ToString();
                }
                if (agreeNum != "")
                {
                    if (this.Popups.ShowPopup("Dete(s) of agreement(s)" + agreeNum.ToString() + " changed. Are you sure you want to continue? ", frmPopup.PopupType.OK_Cancel)
                        == frmPopup.PopupResult.OK)
                    {
                        UpdateAgreementDate();
                    }
                }

               else if (this.Popups.ShowPopup("Are you sure you want to continue? ", frmPopup.PopupType.OK_Cancel)
                        == frmPopup.PopupResult.OK)
                {
                    
                    UpdateAgreementDate();
                }
                
            }
            else
            {
                ResetPati();
            }
        }

      
        private void UpdateAgreementDate()
        {
            string sql = "exec WS_UpdateAgreementDates '" + ReflexCon.MLUser + "'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sql, ReflexCon.TRConnection);
            btnBack.Enabled = false;
            btnFinish.Text = "Restart";
            dateUpdate.btnUpdate.Enabled = false;
            dateUpdate.btnPrintRegister.Enabled = true;
        }
        //
    }
}
