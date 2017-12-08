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
    public partial class ucPati : DevExpress.XtraEditors.XtraUserControl
    {

        ucAgreementSearch ucAgreeSearch;
        ucLotAgreement ucLotAgreement;
        LD_LotSearch.ucLotSearch ucLotSearch;
        ucAgreementDetail ucAgreeDetail;
        ucSummary ucSumm;
        object masterAgreeID;

        private LD_LotSearch.Actions _currentAction;
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        public KeyControlAccess.Validator KCA_Validator;

        public ucPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

            ucAgreeSearch = new ucAgreementSearch(hmCon, tuc_mgr);
            ucAgreeSearch.Dock = DockStyle.Fill;
            ucAgreeSearch.Parent = tpdAgreement;
            tuc_mgr.FormInit(ucAgreeSearch);
        }

        private void ucPati_Load(object sender, EventArgs e)
        {
            ResetPati();

        }

  

        private void RefreshLabels()
        {
            if (tcMain.SelectedTabPage == tpDetails)
            {
                switch (tcDetails.SelectedTabPage.Name)
                {
                    case "tpdAgreement":
                        topBanner1.BannerTitle = "Agreement Selection";
                        topBanner1.BannerText = "Select the agreement you want to modify.";
                        break;
                    case "tpdLot":
                        topBanner1.BannerTitle = "Lot Selection";
                        topBanner1.BannerText = "Select the lot(s) for which you want to create or append an agreement.";
                        break;
                    case "tpdAgreementEdit":
                        topBanner1.BannerTitle = "Agreement Entry/Edit";
                        topBanner1.BannerText = "Enter the lot agreement information and click next to continue.";
                        break;
                    case "tpdUpdate" :
                        topBanner1.BannerTitle = "Agreement Details Entry";
                        topBanner1.BannerText = "Update any agreement specific details and click next to continue.";
                        break;
                    case "tpdSummary":
                        topBanner1.BannerTitle = "Lot Agreement Summary";
                        topBanner1.BannerText = "Review the lots selected, print the pre-register, and click finish to complete.";
                        break;
                }
            }
            topBanner1.RefreshLabels();

        }

        


        #region ButtonFuncationality
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (popup.ShowPopup("Are you sure you want to cancel?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                ResetPati();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rgProcessType.EditValue.ToString() == "N")
                MoveNextNew();
            else
                MoveNextEdit();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (rgProcessType.EditValue.ToString() == "N")
                MoveBackNew();
            else
                MoveBackEdit();

        }
        public void ResetPati()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpdAgreement;
            rgProcessType.SelectedIndex = 0;
            btnNext.Text = "Next >";
            btnARPayment.Visible = false;
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            RefreshLabels();
            ClearWorkingTables();
        }

        private void ClearWorkingTables()
        {
            string sSQL = @"delete from working_ld_laa_proj_lot_agreement where username='"+hmCon.MLUser+@"'
                delete from working_ld_laa_proj_lot_agreement_deposits where username='" + hmCon.MLUser + @"'
                delete from working_ld_laa_proj_lot_agreement_levy where username='" + hmCon.MLUser + @"'
                delete from working_ld_laa_Proj_Agreement_AddDates where username='" + hmCon.MLUser + @"'";
            hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
        }
        
        #region New
        private void MoveNextNew()
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                tcMain.SelectedTabPage = tpDetails;
                tcDetails.SelectedTabPage = tpdLot;
                ucLotSearch.RefreshMe();
                btnBack.Enabled = true;

            }
            else if (tcDetails.SelectedTabPage == tpdLot)
            {
                popup.ShowPopup("Please select an action to continue.");
            }
            else if (tcDetails.SelectedTabPage == tpdAgreementEdit)
            {
                if (ucLotAgreement.isValid(true))
                {
                    tcDetails.SelectedTabPage = tpdUpdate;
                    ucAgreeDetail.RefreshMe(_currentAction.ToString(),-1);
                    
                    if (!ucAgreeDetail.ValidateReservation())
                    {
                        ucLotAgreement.ReloadAgreement();
                        tcDetails.SelectedTabPage = tpdAgreementEdit;
                    }
                }
            }
            else if (tcDetails.SelectedTabPage == tpdUpdate)
            {
                tcDetails.SelectedTabPage = tpdSummary;
                if (_currentAction == LD_LotSearch.Actions.AddToMaster)
                {
                    ucSumm.MasterAgreementID = masterAgreeID;
                }
                else
                    ucSumm.MasterAgreementID = "Started";
                btnNext.Text = "Finish";
                btnNext.Enabled = false;
                ucSumm.RefreshMe(_currentAction.ToString());
            }
            else if (tcDetails.SelectedTabPage == tpdSummary)
            {
                string message = "Are you sure you want to create this agreement?";
                if (ucSumm.NumberOfAgreements > 1)
                    message = "Are you sure you want to create these agreements?";
                if (btnNext.Text == "Restart")
                {
                    if (popup.ShowPopup("Are you sure you want to restart?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        ResetPati();

                }
                else if (popup.ShowPopup(message, WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    if (ucSumm.Finish())
                    {
                        bool bMaster = false;
                        if (_currentAction == LD_LotSearch.Actions.AddToMaster || _currentAction == LD_LotSearch.Actions.NewMasterAgree)
                            bMaster = true;

                        if (!bMaster)
                        {
                            ucLotAgreement.SaveRepRules(ucSumm.Agreement_ID);
                        }

                        if (ucSumm.PostDeposits)
                        {                            
                            int iDepositCnt = 0;
                            if (bMaster)
                            {
                                string sSelect = @"select COUNT(*)
                    from PROJ_LOT_AGREEMENT a
                    join PROJ_LOT_AGREEMENT_DEPOSITS d on d.agreement_id=a.agreement_id
                    join LD_Deposits l on l.Deposit_ID=d.deposit_id
                    join PROJ_LOT_MASTER_AGREEMENT_DETAIL pl on pl.LOT_AGREEMENT_ID=a.agreement_id
                    where pl.lot_master_agreement_id=" + ucSumm.Agreement_ID + @" and ISNULL(d.processed,'F') = 'F' and l.Type='P'";
                                iDepositCnt = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection));
                            }
                            else
                            {
                                string sSelect = @"select COUNT(*)
                    from PROJ_LOT_AGREEMENT_DEPOSITS d
                    join LD_Deposits l on l.Deposit_ID=d.deposit_id
                    where d.agreement_id=" + ucSumm.Agreement_ID + @" and ISNULL(d.processed,'F') = 'F' and l.Type='P'";
                                iDepositCnt = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection));                                
                            }

                            if (iDepositCnt > 0)
                            {
                                LD_LotPreSale.frmLotPreSale fLPS = new LD_LotPreSale.frmLotPreSale(hmCon, tuc_mgr, ucSumm.Agreement_ID, bMaster);
                                fLPS.AgreementPATI = true;
                                fLPS.ShowDialog();
                            }
                        }
                        btnNext.Text = "Restart";
                        btnARPayment.Visible = true;
                        btnBack.Enabled = false;
                    }                    
                }
            }

            RefreshLabels();
        }



        private void MoveBackNew()
        {
            if (tcDetails.SelectedTabPage == tpdLot)
            {
                ResetPati();
            }
            else if (tcDetails.SelectedTabPage == tpdAgreementEdit )
            {
                tcDetails.SelectedTabPage = tpdLot;
            }
            else if (tcDetails.SelectedTabPage == tpdUpdate)
            {
                if (_currentAction == LD_LotSearch.Actions.AddToMaster)
                    tcDetails.SelectedTabPage = tpdLot;
                else
                {
                    ucLotAgreement.UpdateMe();
                    tcDetails.SelectedTabPage = tpdAgreementEdit;
                }
            }
            else if (tcDetails.SelectedTabPage == tpdSummary )
            {
                tcDetails.SelectedTabPage = tpdUpdate;
                btnNext.Text = "Next >";
                btnNext.Enabled = true;
                
            }




            RefreshLabels();
        }
        #endregion New
        #region Edit
        private void MoveNextEdit()
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                tcMain.SelectedTabPage = tpDetails;
                tcDetails.SelectedTabPage = tpdAgreement;
                hmCon.SQLExecutor.ExecuteNonQuery(
                    @"delete working_ld_laa_proj_lot_agreement where username = '"+hmCon.MLUser+@"'
                      delete working_ld_laa_proj_lot_agreement_deposits where username = '" + hmCon.MLUser + @"'
                      delete working_ld_laa_proj_lot_agreement_levy where username = '" + hmCon.MLUser + @"'
                      delete working_ld_laa_Proj_Agreement_AddDates where username = '" +hmCon.MLUser+"'", hmCon.TRConnection);
                ucAgreeSearch.RefreshMe();
                btnBack.Enabled = true;
            }
            else if (tcDetails.SelectedTabPage == tpdAgreement)
            {
                if (ucAgreeSearch.isValid())
                {
                    tcDetails.SelectedTabPage = tpdAgreementEdit;
                    ucLotAgreement.RefreshMe(ucAgreeSearch.CurrentAgreement,"Edit");
                }
            }
            else if (tcDetails.SelectedTabPage == tpdAgreementEdit)
            {
                if (ucLotAgreement.isValid(true))
                {
                    tcDetails.SelectedTabPage = tpdUpdate;
                    ucAgreeDetail.RefreshMe("Edit",-1);
                    if (!ucAgreeDetail.ValidateReservation())
                    {
                        ucLotAgreement.ReloadAgreement();
                        tcDetails.SelectedTabPage = tpdAgreementEdit;
                    }
                }
            }
            else if (tcDetails.SelectedTabPage == tpdUpdate)
            {
                tcDetails.SelectedTabPage = tpdSummary;
                btnNext.Text = "Finish";
                btnNext.Enabled = false;
                ucSumm.RefreshMe("Edit");
            }
            else if (tcDetails.SelectedTabPage == tpdSummary)
            {
                if (btnNext.Text == "Restart")
                {
                    if (popup.ShowPopup("Are you sure you want to restart?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        ResetPati();

                }
                else if (popup.ShowPopup("Are you sure you want to update this agreement?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    if (ucSumm.Finish())
                    {
                        ucLotAgreement.SaveRepRules(ucSumm.Agreement_ID);

                        if (ucSumm.PostDeposits)
                        {
                            bool bMaster = false;
                            if (_currentAction == LD_LotSearch.Actions.AddToMaster || _currentAction == LD_LotSearch.Actions.NewMasterAgree)
                                bMaster = true;
                            int iDepositCnt = 0;
                            if (bMaster)
                            {
                                string sSelect = @"select COUNT(*)
                    from PROJ_LOT_AGREEMENT a
                    join PROJ_LOT_AGREEMENT_DEPOSITS d on d.agreement_id=a.agreement_id
                    join LD_Deposits l on l.Deposit_ID=d.deposit_id
                    join PROJ_LOT_MASTER_AGREEMENT_DETAIL pl on pl.LOT_AGREEMENT_ID=a.agreement_id
                    where pl.lot_master_agreement_id=" + ucSumm.Agreement_ID + @" and ISNULL(d.processed,'F') = 'F' and l.Type='P'";
                                iDepositCnt = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection));
                            }
                            else
                            {
                                string sSelect = @"select COUNT(*)
                    from PROJ_LOT_AGREEMENT_DEPOSITS d
                    join LD_Deposits l on l.Deposit_ID=d.deposit_id
                    where d.agreement_id=" + ucSumm.Agreement_ID + @" and ISNULL(d.processed,'F') = 'F' and l.Type='P'";
                                iDepositCnt = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection));
                            }

                            if (iDepositCnt > 0)
                            {
                                LD_LotPreSale.frmLotPreSale fLPS = new LD_LotPreSale.frmLotPreSale(hmCon, tuc_mgr, ucSumm.Agreement_ID, bMaster);
                                fLPS.ShowDialog();
                            }
                        }
                        btnNext.Text = "Restart";
                        btnARPayment.Visible = true;
                        btnBack.Enabled = false;
                    } 
                }
            }


            RefreshLabels();
        }
        private void MoveBackEdit()
        {
            if (tcDetails.SelectedTabPage == tpdAgreement)
            {
                ResetPati();              
            }
            else if (tcDetails.SelectedTabPage == tpdAgreementEdit )
            {
                tcDetails.SelectedTabPage = tpdAgreement;
            }
            else if (tcDetails.SelectedTabPage == tpdUpdate )
            {
                ucLotAgreement.UpdateMe();
                tcDetails.SelectedTabPage = tpdAgreementEdit;
                
            }
            else if (tcDetails.SelectedTabPage == tpdSummary )
            {
                tcDetails.SelectedTabPage = tpdUpdate;
                btnNext.Text = "Next >";
                btnNext.Enabled = true;
            }





            RefreshLabels();
        }
        #endregion Edit
       
        #endregion ButtonFuncationality

        #region Page changed and Loading of controls
        private void tcMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tcDetails_SelectedPageChanged(tcDetails,new DevExpress.XtraTab.TabPageChangedEventArgs(tcDetails.SelectedTabPage,tcDetails.SelectedTabPage));
        }
        private void tcDetails_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tpdAgreement)
            {
                if (ucAgreeSearch == null)
                {
                    ucAgreeSearch = new ucAgreementSearch(hmCon,tuc_mgr);
                    ucAgreeSearch.Dock = DockStyle.Fill;
                    ucAgreeSearch.Parent = tpdAgreement;
                    tuc_mgr.FormInit(ucAgreeSearch);
                }
                
            }
            else if (e.Page == tpdLot)
            {
                if (ucLotSearch == null)
                {
                    ucLotSearch = new LD_LotSearch.ucLotSearch(hmCon, tuc_mgr, LD_LotSearch.LotSearchType.LotAgreementAssistant);
                    ucLotSearch.Dock = DockStyle.Fill;
                    ucLotSearch.ActionClicked += new LD_LotSearch.ucLotSearch.Delegate_Action_Clicked(ucLotSearch_ActionClicked);
                    ucLotSearch.Parent = tpdLot;
                    ucLotSearch.Validate_NoActiveAgreementsSelected = true;
                    ucLotSearch.Validate_SameProjectSelection = true;
                    ucLotSearch.Validate_ForcePairedSelection = true;
                    tuc_mgr.FormInit(ucLotSearch);
                }
                
            }
            else if (e.Page == tpdAgreementEdit)
            {
                if (ucLotAgreement == null)
                {
                    ucLotAgreement = new ucLotAgreement(hmCon,tuc_mgr);
                    ucLotAgreement.KCA_Validator = KCA_Validator;
                    ucLotAgreement.Dock = DockStyle.Fill;
                    ucLotAgreement.Parent = tpdAgreementEdit;
                    tuc_mgr.FormInit(ucLotAgreement);
                }
                
            }
            else if (e.Page == tpdUpdate)
            {
                if (ucAgreeDetail == null)
                {
                    ucAgreeDetail = new ucAgreementDetail(hmCon,tuc_mgr);
                    ucAgreeDetail.Dock = DockStyle.Fill;
                    ucAgreeDetail.Parent = tpdUpdate;
                    tuc_mgr.FormInit(ucAgreeDetail);

                }
                
            }
            else if (e.Page == tpdSummary)
            {
                if (ucSumm == null)
                {
                    ucSumm = new ucSummary(hmCon,tuc_mgr);
                    ucSumm.Dock = DockStyle.Fill;
                    ucSumm.Parent = tpdSummary;
                    ucSumm.RegisterPrinted += new ucSummary.Delegate_Action_Clicked(ucSumm_RegisterPrinted);
                    tuc_mgr.FormInit(ucSumm);
                }
                
            }

        }

        private void ucSumm_RegisterPrinted()
        {
            btnNext.Enabled = true;
        }

        private void ucLotSearch_ActionClicked(LD_LotSearch.Actions actionClicked)
        {
            _currentAction = actionClicked;
            if (actionClicked == LD_LotSearch.Actions.NewAgree || actionClicked == LD_LotSearch.Actions.NewMasterAgree)
            {
                tcDetails.SelectedTabPage = tpdAgreementEdit;
                ucLotAgreement.RefreshMe(-1, actionClicked.ToString());
            }
            else if (actionClicked == LD_LotSearch.Actions.AddToMaster)
            {
                object oCount = hmCon.SQLExecutor.ExecuteScalar("Select COUNT(Distinct pri_code) From working_ld_LotSearch Where username = '" + ucLotSearch.MLUser + "' and selected = 1", hmCon.TRConnection);
                int iCount = 0;
                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount > 1)
                {
                    popup.ShowPopup("Lots selected are on different projects. Please select lots from one project.");
                    return;
                }
                else if (iCount <= 0)
                {
                    popup.ShowPopup("Please select a lot to continue.");
                    return;
                }
                

                oCount = hmCon.SQLExecutor.ExecuteScalar(@"select count(*) from working_ld_LotSearch s 
                        join PROJ_LOT_AGREEMENT a on s.agreement_id = a.agreement_id 
                        where a.agreement_status_id not in( 1,2) and username = '" +
                        hmCon.MLUser + @"LotAgreementAssistant' and selected = 1", hmCon.TRConnection);
                iCount = 0;
                try { iCount = Convert.ToInt32(oCount); }
                catch { }
                if (iCount > 0)
                {
                    popup.ShowPopup("To add a lot with an agreement the agreement status must be Active.");
                    return;
                }
                


                int purchaser_id_1 = -1;
                int purchaser_id_2 = -1;
                int purchaser_id_3 = -1;
                bool hasAgreements = false;

                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(@"select a.purchaser_id,a.purchaser_id2,a.purchaser_id3 from working_ld_LotSearch s 
join PROJ_LOT_AGREEMENT a on s.agreement_id = a.agreement_id where username = '"+hmCon.MLUser+@"LotAgreementAssistant' and selected = 1 
group by a.purchaser_id,a.purchaser_id2,a.purchaser_id3", hmCon.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count > 1)
                    {
                        popup.ShowPopup("Purchasers must be the same on all agreements within a master agreement.");
                        return;
                    }
                    else if(dt.Rows.Count == 1)
                    {
                        hasAgreements = true;
                        try{
                            purchaser_id_1 = Convert.ToInt32(dt.Rows[0]["purchaser_id"]);
                        }
                        catch { };
                        try
                        {
                            purchaser_id_2 = Convert.ToInt32(dt.Rows[0]["purchaser_id2"]);
                        }
                        catch { };
                        try
                        {
                            purchaser_id_3 = Convert.ToInt32(dt.Rows[0]["purchaser_id3"]);
                        }
                        catch { };
                    }
                }
                else
                {
                    popup.ShowPopup("Error validating lot selection");
                    return;
                }


                object oPri_ID = hmCon.SQLExecutor.ExecuteScalar("Select Top 1 pri_id From working_ld_LotSearch Where username = '" + ucLotSearch.MLUser + "' and selected = 1", hmCon.TRConnection);
                int iPri_Id = -1;
                try { iPri_Id = Convert.ToInt32(oPri_ID); }
                catch { }

                using (frmMasterAgreeemntSelection frm = new frmMasterAgreeemntSelection(hmCon,tuc_mgr,iPri_Id,purchaser_id_1,purchaser_id_2,purchaser_id_3,hasAgreements) )
                {
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        masterAgreeID = frm.lueMasterAgreement.EditValue;
                        tcDetails.SelectedTabPage = tpdUpdate;
                        ucAgreeDetail.RefreshMe(actionClicked.ToString(),masterAgreeID);
                    }
                }
            }
            RefreshLabels();
        }

        #endregion Page changed and Loading of controls

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
