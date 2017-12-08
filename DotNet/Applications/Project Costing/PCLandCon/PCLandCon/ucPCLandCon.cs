using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using System.Data.SqlClient;
using WS_Popups;
using CL_Dialog;
using KeyControlAccess;
using ProjectUtilities;
using PC_Services;
using ProjectTypes;
using WorkOrder_Details;
using PCPatis;
using AlertManager;
using WO_QueryAnalysis;
using WO_Setup;
using PC_TimeTicketReview;
using PC_PaymentReqApp;

namespace PCLandCon
{
    public partial class ucPCLandCon : DevExpress.XtraEditors.XtraUserControl
    {
        #region ucPCLandCon Class Variables

        private ucSearch Search;
        private ucHeader Header;
        private ucHeader HeaderRaw;
        private ucHeader HeaderEdit;
        private ucHeader HeaderRawEdit;
        private ucPurReqEntry PurchaseReq;
        private ucPurReqEntry PurchaseReqEdit;
        private ucBillofMaterials RawMatInv;
        private ucBillofMaterials RawMatInvEdit;
        private ucBillofEquipment InternalEquip;
        private ucBillofEquipment InternalEquipEdit;
        private ucBillofEquipment ToolCrib;
        private ucBillofEquipment ToolCribEdit;
        private ucConsumablesReq InvSurplus;
        private ucConsumablesReq InvSurplusEdit;
        private ucBillofLabor Labor;
        private ucBillofLabor LaborEdit;
        private ucConsumablesReq Consumables;
        private ucConsumablesReq ConsumablesEdit;
        private PCPatis.ProjectClose.ucProjectClose ClosePati;
        private PurchaseReqRelease PurchRelPati;
        private ProjectBillingRelease BillReleasePati;
        private ManagementBoard AlertBoard;
        private ucCostingBudgetView BudgetView;
        private ucCostingBudgetView BudgetViewEdit;
        private ucQueryMain QACost;
        private ucQueryMain QARevenue;
        private ucSetup_Burden EBurden;
        private ucSetup_Burden VBurden;
        private ucSetup_WorkClasses EWorkClass;
        private ucSetup_WorkClasses VWorkClass;
        private ucSetup_EqiClasses EEqiClass;
        private ucSetup_EqiClasses VEqiClass;
        private ucSetup_OvertimeLimits_BillingThresholds EOTLimitsBillThresh;
        private ucSetup_OvertimeLimits_BillingThresholds VOTLimitsBillThresh;
        private ReportLauncher.TUC_HMReportLauncher ucReportLauncher;
        private ucTimeTicketReview TTReview;
        private PC_ProgressAnalysis.ucPC_ProgressAnalysis PCProgAnalaysis;
        private CashFlow.ucBase ELandCost;
        private CashFlow.ucBase ELandRev;
        private CashFlow.ucBase EMiscRecs;
        private CashFlow.ucBase ELoanRepay;
        //private ProjectUtilities.Land.Projections.ucCost ELandCost;
        //private ProjectUtilities.Land.Projections.ucRevenue ELandRev;
        private ProjectUtilities.Land.Leases.ucLeaseDetail ELandLease;
        private ProjectUtilities.Land.Financing.ucFinancingDetail ELandFinance;
        private ProjectUtilities.Land.StandardTerms.ucStandardTermsDetails ELandStdTerms;
        private CashFlow.ucBase VLandCost;
        private CashFlow.ucBase VLandRev;
        //private ProjectUtilities.Land.Projections.ucCost VLandCost;
        //private ProjectUtilities.Land.Projections.ucRevenue VLandRev;
        private ProjectUtilities.Land.Leases.ucLeaseDetail VLandLease;
        private ProjectUtilities.Land.Financing.ucFinancingDetail VLandFinance;
        private ProjectUtilities.Land.StandardTerms.ucStandardTermsDetails VLandStdTerms;
        private ProjectUtilities.Land.LotInventory.ucSearch LotSearch;
        private ProjectUtilities.Land.LotInventory.ucHeader LotHeaderView;
        private ProjectUtilities.Land.LotInventory.ucHeader LotHeaderEdit;
        private ProjectUtilities.Land.LotInventory.Detail.ucAgreement LotAgreeView;
        private ProjectUtilities.Land.LotInventory.Detail.ucAgreement LotAgreeEdit;
        private ProjectUtilities.Land.LotInventory.Detail.ucTaxes LotTaxesView;
        private ProjectUtilities.Land.LotInventory.Detail.ucTaxes LotTaxesEdit;
        private ProjectUtilities.Land.LotInventory.Detail.ucHolds LotHoldsView;
        private ProjectUtilities.Land.LotInventory.Detail.ucHolds LotHoldsEdit;
        private ProjectUtilities.Land.LotInventory.Detail.ucFinancial LotFinancialView;
        private ProjectUtilities.Land.LotInventory.Detail.ucFinancial LotFinancialEdit;
        private ProjectUtilities.Land.Processing.ucLOC LOC;
        private ProjectUtilities.Land.Processing.ucLotPairing LotPairing;
        private LD_LotAgreementAssistant.ucPati ucLotAgreeementAsssistant;
        private LD_LotSaleAssistant.ucPati ucLotSaleAssistant;
        private LD_LotAdjustmentAssistant.ucLotAdjustments ucLotAdjAssistant;
        private ucPaymentRequest PaymentRequest;
        private LD_LotUnSellAssistant.ucPati ucLotUnSellAssistant;
        private LD_LotPayoutAssistant.ucPati ucLotPayoutAssistant;
        private LD_Project_Close.ucProjectClose ucProjclose;
        private ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit LetterOfCreditEdit;
        private ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit LetterOfCreditView;
        private LD_TaxrollUpdate.ucLD_TaxrollUpdate TaxRollUpdate;
        private LD_DownPaymentDue.ucDownPaymentDue DownPaymentDue;
        private LD_ManagementFees.ucManagementFees ManagementFees;
        private LD_ProgramFees.ucProgramFees ProgramFees;
        private LD_DateManagement.ucDateManagement DateManagement;
        private LD_Proj_ManagementFees.ucProj_ManagementFees ProjManagementFeesView;
        private LD_Proj_ManagementFees.ucProj_ManagementFees ProjManagementFeesEdit;
        private LD_Proj_AdditionalFees.ucProjAdditionalFees ProjAdditionalFeesView;
        private LD_Proj_AdditionalFees.ucProjAdditionalFees ProjAdditionalFeesEdit;
        private LD_Proj_ProgramFees.ucProj_ProgramFees ProjProgramFeesView;
        private LD_Proj_ProgramFees.ucProj_ProgramFees ProjProgramFeesEdit;
        private LD_SpecHomeOwnerUpdate.ucSpecHomeOwnerUpdate specHomeOwnerUpdate;
        private LD_DevBgtByProj.DevBgtByProj DevBudgetByProj;
        private LD_DevCostByProj.DevCostByProj DevCostByProj;
        private LD_DevCostByYear.DevCostByYear DevCostByYear;
        private LD_ProjSalesByYear.ProjSalesByYear ProjSalesByYear;

        private LD_LotNeighbor.ucLotSearch lotNeighbor;
        private LD_LotNeighbor.ucLotNeighborMain lotNeighborSetup;

        private LD_ProjInvestors.ucProjInvestors ProjInvestorsE;
        private LD_ProjInvestors.ucProjInvestors ProjInvestorsV;

        private LD_CashCall.ucCashCallPati CashCallPati;
        private LD_CashCall.ucCashCallPati DistributionPati;

        private LD_RefundDeposits.ucRefundDeposits refundDeposits;

        private LD_LotDiscount.ucLotDiscountPati lotDiscounts;

        private LD_LevyAssistant.ucLevyAssistant levyManagement;
        private LD_AgreementsInterest.ucPati lotInterest;



        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private KeyControlAccess.Validator KCA_Validator;
        private HMCon Connection;
        private frmPopup Popup;

        private const int CONST_KCA_PROJECT_COSTING = 45;
        private string CONST_LAND_CONSTRUCTION_TYPE = "PCL";
        private const int APPROVAL_TOPIC_ID_SHOW_REVENUE_SUMMARY = 144;

        private int _ProjectID = -1;
        private int _LotID = -1;
        private bool _bNewLot = false;




        #endregion

        public ucPCLandCon(string WebDB, string Server, string CompanyID, string User, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            CL_Dialog.PleaseWait.Show("Loading Land Development\r\nPlease Wait", null);
            InitializeComponent();
            Connection = new HMCon(WebDB, Server, Convert.ToInt32(CompanyID), User);

            pBack.BringToFront();

            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);

            KCA_Validator = new KeyControlAccess.Validator(Connection, DevXMgr, CONST_KCA_PROJECT_COSTING, CONST_LAND_CONSTRUCTION_TYPE);
            KCA_Validator.MenuBar = bar2;

            this.hmNavigationBar1.SetSecurity(Connection.Department, Connection.TRConnection);
            hmtc_main.SelectedTabPage = tpMaintenance;
            CL_Dialog.PleaseWait.Hide();
        }

        public void NewAlert()
        {
            if (AlertBoard != null)
                AlertBoard.RefreshAlerts();
        }

        public void AlertClicked(int ID)
        {
            if (AlertBoard != null)
            {
                if (hmtc_main != null && tcTools != null)
                {
                    hmtc_main.SelectedTabPage = tpProcessing;
                    hmtc_processing.SelectedTabPage = tpAlerts;
                    AlertBoard.AlertClicked(ID);
                }
            }
        }

        private void ucPCLandCon_Load(object sender, EventArgs e)
        {
            LoadSearchTab();
            Hide();
            DevXMgr.FormInit(this);
            FindBottomTabControl(hmtc_main);
            pBack.SendToBack();
            dockPanel1.Width = 250;            
            Show();  
        }

        #region TabPage Change Events

        private void FindBottomTabControl(HMTools.HMTabControl TControl)
        {
            if (TControl.TabPages.Count > 0)
            {
                bool HasLower = false;
                foreach (Control C in TControl.TabPages[0].Controls)
                {
                    if (C is HMTools.HMTabControl)
                    {
                        FindBottomTabControl(C as HMTools.HMTabControl);
                        HasLower = true;
                        break;
                    }
                }
                if (!HasLower)
                {
                    if (TControl.Name == hmtc_main.Name)
                    {
                        hmTabControl1_SelectedPageChanged(null, null);
                    }
                    else if (TControl.Name == hmtc_processing.Name)
                    {
                        hmTabControl4_SelectedPageChanged(null, null);
                    }
                    else if (TControl.Name == hmTabControl5.Name)
                    {
                        hmTabControl5_SelectedPageChanged(null, null);
                    }
                }
            }
        }

        private void hmTabControl10_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;

            if (hmTabControl10.SelectedTabPage == tpQCosts && QACost == null)
            {
                QACost = new ucQueryMain(Connection, DevXMgr, "C", ProjectType.PC_Land_Construction, KCA_Validator);
                QACost.Dock = DockStyle.Fill;
                QACost.Parent = tpQCosts;
            }
            else if (hmTabControl10.SelectedTabPage == tpQRev && QARevenue == null)
            {
                QARevenue = new ucQueryMain(Connection, DevXMgr, "R", ProjectType.PC_Land_Construction, KCA_Validator);
                QARevenue.Dock = DockStyle.Fill;
                QARevenue.Parent = tpQRev;
            }

            if (_ProjectID != -1)
            {
                if (QACost != null)
                {
                    QACost.LoadQuery(_ProjectID);
                }
                if (QARevenue != null)
                {
                    QARevenue.LoadQuery(_ProjectID);
                }
            }
        }

        private void hmTabControl9_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;

            if (hmTabControl9.SelectedTabPage == tpEBurdens && EBurden == null)
            {
                EBurden = new ucSetup_Burden(Connection, DevXMgr);
                EBurden.Dock = DockStyle.Fill;
                EBurden.Parent = tpEBurdens;
            }
            else if (hmTabControl9.SelectedTabPage == tpEWorkClasses && EWorkClass == null)
            {
                EWorkClass = new ucSetup_WorkClasses(Connection, DevXMgr);
                EWorkClass.Dock = DockStyle.Fill;
                EWorkClass.Parent = tpEWorkClasses;
            }
            else if (hmTabControl9.SelectedTabPage == tpEEquipClasses && EEqiClass == null)
            {
                EEqiClass = new ucSetup_EqiClasses(Connection, DevXMgr);
                EEqiClass.Dock = DockStyle.Fill;
                EEqiClass.Parent = tpEEquipClasses;
            }
            else if (hmTabControl9.SelectedTabPage == tpEOvertime && EOTLimitsBillThresh == null)
            {
                EOTLimitsBillThresh = new ucSetup_OvertimeLimits_BillingThresholds(Connection, DevXMgr);
                EOTLimitsBillThresh.Dock = DockStyle.Fill;
                EOTLimitsBillThresh.Parent = tpEOvertime;
            }

            if (_ProjectID != -1)
            {
                if (EBurden != null)
                {
                    EBurden.LoadBurdens(_ProjectID, false);
                }
                if (EWorkClass != null)
                {
                    EWorkClass.LoadCostingWorkClass(_ProjectID, false);
                }
                if (EEqiClass != null)
                {
                    EEqiClass.LoadCostingEqiClass(_ProjectID, false);
                }
                if (EOTLimitsBillThresh != null)
                {
                    EOTLimitsBillThresh.LoadOTLimitsBillThresholds(_ProjectID, false);
                }
            }
        }

        private void hmTabControl7_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl7.SelectedTabPage == tpVBurdens && VBurden == null)
            {
                VBurden = new ucSetup_Burden(Connection, DevXMgr);
                VBurden.Dock = DockStyle.Fill;
                VBurden.Parent = tpVBurdens;
            }
            else if (hmTabControl7.SelectedTabPage == tpVWorkClasses && VWorkClass == null)
            {
                VWorkClass = new ucSetup_WorkClasses(Connection, DevXMgr);
                VWorkClass.Dock = DockStyle.Fill;
                VWorkClass.Parent = tpVWorkClasses;
            }
            else if (hmTabControl7.SelectedTabPage == tpVEquipClasses && VEqiClass == null)
            {
                VEqiClass = new ucSetup_EqiClasses(Connection, DevXMgr);
                VEqiClass.Dock = DockStyle.Fill;
                VEqiClass.Parent = tpVEquipClasses;
            }
            else if (hmTabControl7.SelectedTabPage == tpVOvertime && VOTLimitsBillThresh == null)
            {
                VOTLimitsBillThresh = new ucSetup_OvertimeLimits_BillingThresholds(Connection, DevXMgr);
                VOTLimitsBillThresh.Dock = DockStyle.Fill;
                VOTLimitsBillThresh.Parent = tpVOvertime;
            }

            if (_ProjectID != -1)
            {
                if (VBurden != null)
                {
                    VBurden.LoadBurdens(_ProjectID, true);
                }
                if (VWorkClass != null)
                {
                    VWorkClass.LoadCostingWorkClass(_ProjectID, true);
                }
                if (VEqiClass != null)
                {
                    VEqiClass.LoadCostingEqiClass(_ProjectID, true);
                }
                if (VOTLimitsBillThresh != null)
                {
                    VOTLimitsBillThresh.LoadOTLimitsBillThresholds(_ProjectID, true);
                }
            }
        }

        private void hmTabControl2_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (this.hmTabControl2.SelectedTabPage == this.tpReportLauncher && ucReportLauncher == null)
            {
                ucReportLauncher = new ReportLauncher.TUC_HMReportLauncher();
                ucReportLauncher.ConnectTimeout = 200;

                ucReportLauncher.Parent = this.tpReportLauncher;
                ucReportLauncher.Dock = DockStyle.Fill;

                string sSelect = "select DBID from DBS where DBName='" + this.Connection.TRDB + "'";
                object oDBID = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.WebConnection);

                if (oDBID != null && oDBID != DBNull.Value && !oDBID.Equals(""))
                {
                    //ucReportLauncher.InitReportLauncher(Connection.WebDB, Connection.WebServer, oDBID.ToString(), "51", "224", "0",
                    //    Connection.ReportPath, Connection.MLUser, DevXMgr);

                    ucReportLauncher.InitReportLauncher(Connection.WebDB, Connection.WebServer, oDBID.ToString(), "5", "0", "0",
                      Connection.ReportPath, Connection.MLUser, DevXMgr,Connection.CompanyID);
                }
            }
        }

        private void hmTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmtc_main.SelectedTabPage == tpMaintenance)
            {
                hmTabControl5_SelectedPageChanged(null, null);
            }
            else if (hmtc_main.SelectedTabPage == tpTools)
            {
                tcTools_SelectedPageChanged(null, null);
            }
            else if (hmtc_main.SelectedTabPage == tpReporting)
            {
                hmTabControl2_SelectedPageChanged(null, null);
            }
            else if (hmtc_main.SelectedTabPage == tpProcessing)
            {
                hmTabControl4_SelectedPageChanged(null, null);
            }
        }

        private void hmTabControl4_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;

            if (hmtc_processing.SelectedTabPage == tpAlerts && AlertBoard == null)
            {
                pAlertBack.BringToFront();
                AlertBoard = new ManagementBoard(Connection, DevXMgr);
                AlertBoard.Dock = DockStyle.Fill;
                AlertBoard.Parent = tpAlerts;
                pAlertBack.SendToBack();
            }
            else if (hmtc_processing.SelectedTabPage == tpLOC && LOC == null)
            {
                LOC = new ProjectUtilities.Land.Processing.ucLOC(Connection, DevXMgr);
                LOC.Dock = DockStyle.Fill;
                LOC.Parent = tpLOC;
            }
            else if (hmtc_processing.SelectedTabPage == tpPairing && LotPairing == null)
            {
                LotPairing = new ProjectUtilities.Land.Processing.ucLotPairing(Connection, DevXMgr);
                LotPairing.Dock = DockStyle.Fill;
                LotPairing.Parent = tpPairing;
            }
            else if (hmtc_processing.SelectedTabPage == tpPaymentSubApp && PaymentRequest == null)
            {
                PaymentRequest = new ucPaymentRequest(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                PaymentRequest.Dock = DockStyle.Fill;
                PaymentRequest.Parent = tpPaymentSubApp;
            }
            else if (hmtc_processing.SelectedTabPage == tpTaxrollUpdate && TaxRollUpdate == null)
            {
                TaxRollUpdate = new LD_TaxrollUpdate.ucLD_TaxrollUpdate(Connection, DevXMgr);
                TaxRollUpdate.Dock = DockStyle.Fill;
                TaxRollUpdate.Parent = tpTaxrollUpdate;
            }
            else if (hmtc_processing.SelectedTabPage == tpLotNeighbors)
            {
                tcLotNeighbors_SelectedPageChanged(null, null);
            }

            if (hmtc_processing.SelectedTabPage == tpPaymentSubApp && PaymentRequest != null)
            {
                PaymentRequest.RefreshMe();
            }

        }

        private void hmTabControl5_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl5.SelectedTabPage == tpSearch && Search == null)
            {
                pSearchBack.BringToFront();
                Search = new ucSearch(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                Search.ProjectView_Event += new ucSearch.ProjectView_Delegate(Search_ProjectView_Event);
                Search.ProjectEdit_Event += new ucSearch.ProjectEdit_Delegate(Search_ProjectEdit_Event);
                Search.ProjectChange_Event += new ucSearch.ProjectChange_Delegate(Search_ProjectChange_Event);
                Search.Dock = DockStyle.Fill;
                Search.Parent = tpSearch;
                pSearchBack.SendToBack();
            }
            else if (hmTabControl5.SelectedTabPage == tpProjView)
            {
                hmTabControl6.SelectedTabPage = tpHeaderV;
                hmTabControl6_SelectedPageChanged(null, null);
            }
            else if (hmTabControl5.SelectedTabPage == tpProjEdit)
            {
                hmTabControl8.SelectedTabPage = tpHeaderE;
                hmTabControl8_SelectedPageChanged(null, null);
            }
            else if (hmTabControl5.SelectedTabPage == tpQueryAnalysis)
            {
                hmTabControl10_SelectedPageChanged(null, null);
                SetCostRevKCSecuirity();
            }
            else if (hmTabControl5.SelectedTabPage == tpLotInv)
            {
                hmTabControl15_SelectedPageChanged(null, null);
            } 
            
        }

        private void SetCostRevKCSecuirity()
        {
            try
            {
                if (!KCA_Validator.UserAccessAllowed(APPROVAL_TOPIC_ID_SHOW_REVENUE_SUMMARY))
                {
                    tpQRev.PageVisible = false;
                }
                else
                {
                    tpQRev.PageVisible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found in SetCostRevKCSecuirity Process in PCLandCon (PC_LandCon) :" + ex.Message.ToString());
            }
        }

        private void Search_ProjectChange_Event(int ProjectID)
        {
            txtProject.Text = "";            
            txtProjNoEProjections.Text = "";
            txtProjNoEFinancing.Text = "";
            txtProjNoELeases.Text = "";
            txtProjNoEST.Text = "";
            txtProjNoProjections.Text = "";
            txtProjNoFinancing.Text = "";
            txtProjNoLeases.Text = "";
            txtProjNoST.Text = "";

            txtProjectName.Text = "";
            txtProjNameEProjections.Text = "";            
            txtProjNameEFinancing.Text = "";            
            txtProjNameELeases.Text = "";            
            txtProjNameEST.Text = "";            
            txtProjNameProjections.Text = "";            
            txtProjNameFinancing.Text = "";            
            txtProjNameLeases.Text = "";            
            txtProjNameST.Text = "";

            string sSelect = "select pri_code, pri_name from proj_header where pri_id=" + ProjectID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        object oCode = dr["pri_code"];
                        if (oCode != null && oCode != DBNull.Value)
                        {
                            txtProject.Text = oCode.ToString();
                            txtProjNoQA.Text = oCode.ToString();
                            txtProjNoEProjections.Text = oCode.ToString();
                            txtProjNoEFinancing.Text = oCode.ToString();
                            txtProjNoELeases.Text = oCode.ToString();
                            txtProjNoEST.Text = oCode.ToString();
                            txtProjNoProjections.Text = oCode.ToString();
                            txtProjNoFinancing.Text = oCode.ToString();
                            txtProjNoLeases.Text = oCode.ToString();
                            txtProjNoST.Text = oCode.ToString();
                        }
                        object oDesc = dr["pri_name"];
                        if (oDesc != null && oDesc != DBNull.Value)
                        {
                            txtProjectName.Text = oDesc.ToString();
                            txtProjNameQA.Text = oDesc.ToString();
                            txtProjNameEProjections.Text = oDesc.ToString();
                            txtProjNameEFinancing.Text = oDesc.ToString();
                            txtProjNameELeases.Text = oDesc.ToString();
                            txtProjNameEST.Text = oDesc.ToString();
                            txtProjNameProjections.Text = oDesc.ToString();
                            txtProjNameFinancing.Text = oDesc.ToString();
                            txtProjNameLeases.Text = oDesc.ToString();
                            txtProjNameST.Text = oDesc.ToString();
                        }
                    }
                }
            }
        }

        private void hmTabControl6_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;

            if (hmTabControl6.SelectedTabPage == tpHeaderV && Header == null && Search.LandSubType == "P")
            {
                Header = new ucHeader(Connection, DevXMgr, ProjectType.PC_Land_Construction, KCA_Validator);
                Header.SetReadOnly(true);
                Header.Dock = DockStyle.Fill;
                Header.Parent = tpHeaderV;
                
            }
            if (hmTabControl6.SelectedTabPage == tpHeaderV && HeaderRaw == null && Search.LandSubType == "R")
            {
                HeaderRaw = new ucHeader(Connection, DevXMgr, ProjectType.PC_Land_Construction, KCA_Validator,"R");
                HeaderRaw.Name = "HeaderRaw";//create a new name so layouts load ** same as the edit so they share layouts
                HeaderRaw.SetReadOnly(true);
                HeaderRaw.Dock = DockStyle.Fill;
                HeaderRaw.Parent = tpHeaderV;
                
            }
            else if (hmTabControl6.SelectedTabPage == tpDetailV)
            {
                hmTabControl12_SelectedPageChanged(null, null);
            }
            else if (hmTabControl6.SelectedTabPage == tpVProjections)
            {
                hmTabControl14_SelectedPageChanged(null, null);
            }
            else if (hmTabControl6.SelectedTabPage == tpVLeases && VLandLease == null)
            {
                VLandLease = new ProjectUtilities.Land.Leases.ucLeaseDetail(Connection, DevXMgr);
                VLandLease.SetReadOnly(true);
                VLandLease.Dock = DockStyle.Fill;                
                VLandLease.Parent = tpVLeases;
                VLandLease.BringToFront();
            }
            else if (hmTabControl6.SelectedTabPage == tpVFinancing && VLandFinance == null)
            {
                VLandFinance = new ProjectUtilities.Land.Financing.ucFinancingDetail(Connection, DevXMgr);
                VLandFinance.SetReadOnly(true);
                VLandFinance.Dock = DockStyle.Fill;
                VLandFinance.Parent = tpVFinancing;
                VLandFinance.BringToFront();
            }
            else if (hmTabControl6.SelectedTabPage == tpVStdTerms && VLandStdTerms == null)
            {
                VLandStdTerms = new ProjectUtilities.Land.StandardTerms.ucStandardTermsDetails(Connection, DevXMgr);
                VLandStdTerms.SetReadOnly(true);
                VLandStdTerms.Dock = DockStyle.Fill;
                VLandStdTerms.Parent = tpVStdTerms;
                VLandStdTerms.BringToFront();
            }
            else if (hmTabControl6.SelectedTabPage == tpvLetterOfCredit && LetterOfCreditView == null)
            {
                LetterOfCreditView = new ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit(Connection, DevXMgr);
                LetterOfCreditView.SetReadOnly(true);
                LetterOfCreditView.Dock = DockStyle.Fill;
                LetterOfCreditView.Parent = tpvLetterOfCredit;
                LetterOfCreditView.BringToFront();
            }
            
            
            if (hmTabControl6.SelectedTabPage == tpHeaderV )
            {
                if (Search.LandSubType == "P" && Header != null)
                {
                    Header.LoadProject(_ProjectID);
                    if (HeaderRaw != null)
                        HeaderRaw.SendToBack();
                    Header.BringToFront();
                }
                else if (Search.LandSubType == "R" && HeaderRaw != null)
                {
                    HeaderRaw.LoadProject(_ProjectID);
                    if (Header != null)
                        Header.SendToBack();
                    HeaderRaw.BringToFront();
                }
                LoadHeaderInformation();
            }
            else if (hmTabControl6.SelectedTabPage == tpVLeases && VLandLease != null)
            {
                VLandLease.LoadProject(_ProjectID);
            }
            else if (hmTabControl6.SelectedTabPage == tpVFinancing && VLandFinance != null)
            {
                VLandFinance.LoadProject(_ProjectID);
            }
            else if (hmTabControl6.SelectedTabPage == tpVStdTerms && VLandStdTerms != null)
            {
                VLandStdTerms.LoadProject(_ProjectID);
            }
            else if (hmTabControl6.SelectedTabPage == tpvLetterOfCredit && LetterOfCreditView != null)
            {
                LetterOfCreditView.RefreshMe(_ProjectID);
            }
            else if (hmTabControl6.SelectedTabPage == tpVManagementFees)
            {
                if (ProjManagementFeesView == null)
                {
                    ProjManagementFeesView = new LD_Proj_ManagementFees.ucProj_ManagementFees(Connection, DevXMgr);
                    ProjManagementFeesView.Dock = DockStyle.Fill;
                    ProjManagementFeesView.Parent = tpVManagementFees;
                    ProjManagementFeesView.BringToFront();
                }

                ProjManagementFeesView.LoadManagementFees(_ProjectID, true);
            }
            else if (hmTabControl6.SelectedTabPage == tpVAdditionalFees)
            {
                if (ProjAdditionalFeesView == null)
                {
                    ProjAdditionalFeesView = new LD_Proj_AdditionalFees.ucProjAdditionalFees(Connection, DevXMgr);
                    ProjAdditionalFeesView.Dock = DockStyle.Fill;
                    ProjAdditionalFeesView.Parent = tpVAdditionalFees;
                    ProjAdditionalFeesView.BringToFront();
                }

                ProjAdditionalFeesView.LoadAdditionalFees(_ProjectID, true);
            }
            else if (hmTabControl6.SelectedTabPage == tpVProgramFees)
            {
                if (ProjProgramFeesView == null)
                {
                    ProjProgramFeesView = new LD_Proj_ProgramFees.ucProj_ProgramFees(Connection, DevXMgr);
                    ProjProgramFeesView.Dock = DockStyle.Fill;
                    ProjProgramFeesView.Parent = tpVProgramFees;
                    ProjProgramFeesView.BringToFront();
                }

                ProjProgramFeesView.LoadProgramFees(_ProjectID, true);
            }
            else if (hmTabControl6.SelectedTabPage == tpInvestors)
            {
                if (ProjInvestorsV == null)
                {
                    ProjInvestorsV = new LD_ProjInvestors.ucProjInvestors(Connection, DevXMgr);
                    ProjInvestorsV.Dock = DockStyle.Fill;
                    ProjInvestorsV.Parent = tpInvestors;
                    ProjInvestorsV.SetReadOnlyMode(true);
                    ProjInvestorsV.BringToFront();
                }

                ProjInvestorsV.RefreshDetails(_ProjectID);
            }
        }

        private void hmTabControl8_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;

            if (hmTabControl8.SelectedTabPage == tpHeaderE && HeaderEdit == null && Search.LandSubType == "P")
            {
                HeaderEdit = new ucHeader(Connection, DevXMgr, ProjectType.PC_Land_Construction, KCA_Validator,"P");
                HeaderEdit.SetReadOnly(false);
                HeaderEdit.Dock = DockStyle.Fill;
                HeaderEdit.Parent = tpHeaderE;
            }
            if (hmTabControl6.SelectedTabPage == tpHeaderV && HeaderRawEdit == null && Search.LandSubType == "R")
            {
                HeaderRawEdit = new ucHeader(Connection, DevXMgr, ProjectType.PC_Land_Construction, KCA_Validator, "R");
                HeaderRawEdit.Name = "HeaderRaw";//create a new name so layouts load ** same as the veiw so they share layouts
                HeaderRawEdit.SetReadOnly(false);
                HeaderRawEdit.Dock = DockStyle.Fill;
                HeaderRawEdit.Parent = tpHeaderE;

            }
            else if (hmTabControl8.SelectedTabPage == tpDetailE)
            {
                hmTabControl11_SelectedPageChanged(null, null);
            }
            else if (hmTabControl8.SelectedTabPage == tpEProjections)
            {
                hmTabControl13_SelectedPageChanged(null, null);
            }
            else if (hmTabControl8.SelectedTabPage == tpELeases && ELandLease == null)
            {
                ELandLease = new ProjectUtilities.Land.Leases.ucLeaseDetail(Connection, DevXMgr);
                ELandLease.SetReadOnly(false);
                ELandLease.Dock = DockStyle.Fill;                
                ELandLease.Parent = tpELeases;
                ELandLease.BringToFront();
                
            }
            else if (hmTabControl8.SelectedTabPage == tpEFinancing && ELandFinance == null)
            {
                ELandFinance = new ProjectUtilities.Land.Financing.ucFinancingDetail(Connection, DevXMgr);
                ELandFinance.SetReadOnly(false);
                ELandFinance.Dock = DockStyle.Fill;
                ELandFinance.Parent = tpEFinancing;
                ELandFinance.BringToFront();
            }
            else if (hmTabControl8.SelectedTabPage == tpEStdTerms && ELandStdTerms == null)
            {
                ELandStdTerms = new ProjectUtilities.Land.StandardTerms.ucStandardTermsDetails(Connection, DevXMgr);
                ELandStdTerms.SetReadOnly(false);
                ELandStdTerms.Dock = DockStyle.Fill;
                ELandStdTerms.Parent = tpEStdTerms;
                ELandStdTerms.BringToFront();
            }
            else if (hmTabControl8.SelectedTabPage == tpELetterOfCredit && LetterOfCreditEdit == null)
            {
                LetterOfCreditEdit = new ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit(Connection, DevXMgr);
                LetterOfCreditEdit.SetReadOnly(false);
                LetterOfCreditEdit.Dock = DockStyle.Fill;
                LetterOfCreditEdit.Parent = tpELetterOfCredit;
                LetterOfCreditEdit.BringToFront();
            }

            if (hmTabControl8.SelectedTabPage == tpHeaderE )
            {
                if (_ProjectID != -1)
                    Connection.SQLExecutor.ExecuteNonQuery("exec sp_WO_CalcCosts " + _ProjectID, Connection.TRConnection);
                if (Search.LandSubType == "P" && HeaderEdit != null)
                {
                    HeaderEdit.LoadProject(_ProjectID);
                    if (HeaderRawEdit != null)
                        HeaderRawEdit.SendToBack();
                    HeaderEdit.BringToFront();
                }
                else if (Search.LandSubType == "R" && HeaderRawEdit != null)
                {
                    HeaderRawEdit.LoadProject(_ProjectID);
                    if (HeaderEdit != null)
                        HeaderEdit.SendToBack();
                    HeaderRawEdit.BringToFront();
                }
                
                
                LoadHeaderEditInformation();
            }
            else if (hmTabControl8.SelectedTabPage == tpELeases && ELandLease != null)
            {
                ELandLease.LoadProject(_ProjectID);
            }
            else if (hmTabControl8.SelectedTabPage == tpEFinancing && ELandFinance != null)
            {
                ELandFinance.LoadProject(_ProjectID);
            }
            else if (hmTabControl8.SelectedTabPage == tpEStdTerms && ELandStdTerms != null)
            {
                ELandStdTerms.LoadProject(_ProjectID);
            }
            else if (hmTabControl8.SelectedTabPage == tpELetterOfCredit && LetterOfCreditEdit != null)
            {
                LetterOfCreditEdit.RefreshMe(_ProjectID);
            }
            else if (hmTabControl8.SelectedTabPage == tpEManagementFees)
            {
                if (ProjManagementFeesEdit == null)
                {
                    ProjManagementFeesEdit = new LD_Proj_ManagementFees.ucProj_ManagementFees(Connection, DevXMgr);
                    ProjManagementFeesEdit.Dock = DockStyle.Fill;
                    ProjManagementFeesEdit.Parent = tpEManagementFees;
                    ProjManagementFeesEdit.BringToFront();
                }

                ProjManagementFeesEdit.LoadManagementFees(_ProjectID, false);
            }
            else if (hmTabControl8.SelectedTabPage == tpEAdditionalFees)
            {
                if (ProjAdditionalFeesEdit == null)
                {
                    ProjAdditionalFeesEdit = new LD_Proj_AdditionalFees.ucProjAdditionalFees(Connection, DevXMgr);
                    ProjAdditionalFeesEdit.Dock = DockStyle.Fill;
                    ProjAdditionalFeesEdit.Parent = tpEAdditionalFees;
                    ProjAdditionalFeesEdit.BringToFront();
                }

                ProjAdditionalFeesEdit.LoadAdditionalFees(_ProjectID, false);
            }
            else if (hmTabControl8.SelectedTabPage == tpEProgramFees)
            {
                if (ProjProgramFeesEdit == null)
                {
                    ProjProgramFeesEdit = new LD_Proj_ProgramFees.ucProj_ProgramFees(Connection, DevXMgr);
                    ProjProgramFeesEdit.Dock = DockStyle.Fill;
                    ProjProgramFeesEdit.Parent = tpEProgramFees;
                    ProjProgramFeesEdit.BringToFront();
                }

                ProjProgramFeesEdit.LoadProgramFees(_ProjectID, false);
            }
            else if (hmTabControl8.SelectedTabPage == tpInvestorsEdit)
            {
                if (ProjInvestorsE == null)
                {
                    ProjInvestorsE = new LD_ProjInvestors.ucProjInvestors( Connection, DevXMgr);
                    ProjInvestorsE.Dock = DockStyle.Fill;
                    ProjInvestorsE.Parent = tpInvestorsEdit;
                    ProjInvestorsE.BringToFront();
                }

                ProjInvestorsE.RefreshDetails(_ProjectID);
            }
        }

        private void hmTabControl12_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl12.SelectedTabPage == tpPurchReqV && PurchaseReq == null)
            {
                PurchaseReq = new ucPurReqEntry(Connection, DevXMgr, KCA_Validator, LaunchType.Project, ProjectType.PC_Land_Construction);
                PurchaseReq.SetReadOnly(true);
                PurchaseReq.Dock = DockStyle.Fill;
                PurchaseReq.Parent = tpPurchReqV;
            }
            else if (hmTabControl12.SelectedTabPage == tpRawMatInvV && RawMatInv == null)
            {
                RawMatInv = new ucBillofMaterials(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                RawMatInv.Dock = DockStyle.Fill;
                RawMatInv.Parent = tpRawMatInvV;
            }
            else if (hmTabControl12.SelectedTabPage == tpToolCrib && ToolCrib == null)
            {
                ToolCrib = new ucBillofEquipment(Connection, DevXMgr, "T", ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                ToolCrib.Dock = DockStyle.Fill;
                ToolCrib.Parent = tpToolCrib;
            }
            else if (hmTabControl12.SelectedTabPage == tpIntEquip && InternalEquip == null)
            {
                InternalEquip = new ucBillofEquipment(Connection, DevXMgr, "F", ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                InternalEquip.Dock = DockStyle.Fill;
                InternalEquip.Parent = tpIntEquip;
            }
            else if (hmTabControl12.SelectedTabPage == tpLabor && Labor == null)
            {
                Labor = new ucBillofLabor(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                Labor.Dock = DockStyle.Fill;
                Labor.Parent = tpLabor;
            }
            else if (hmTabControl12.SelectedTabPage == tpSurplus && InvSurplus == null)
            {
                InvSurplus = new ucConsumablesReq(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, "S", KCA_Validator);
                InvSurplus.Dock = DockStyle.Fill;
                InvSurplus.Parent = tpSurplus;
            }
            else if (hmTabControl12.SelectedTabPage == tpConsumables && Consumables == null)
            {
                Consumables = new ucConsumablesReq(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, "C", KCA_Validator);
                Consumables.Dock = DockStyle.Fill;
                Consumables.Parent = tpConsumables;
            }
            else if (hmTabControl12.SelectedTabPage == tpCostingBudget && BudgetView == null)
            {
                BudgetView = new ucCostingBudgetView(Connection, DevXMgr, LaunchType.Project, ProjectType.PC_Land_Construction);
                BudgetView.ReadOnly = true;
                BudgetView.Dock = DockStyle.Fill;
                BudgetView.Parent = tpCostingBudget;
            }
            else if (hmTabControl12.SelectedTabPage == tpVSetup )
            {
                hmTabControl7_SelectedPageChanged(null, null);
            }

            if (tpProjView.PageVisible)
            {
                if (PurchaseReq != null && hmTabControl12.SelectedTabPage == tpPurchReqV)
                {
                    PurchaseReq.LoadPri_ID(_ProjectID);
                }
                if (RawMatInv != null && hmTabControl12.SelectedTabPage == tpRawMatInvV)
                {
                    RawMatInv.LoadBillofMaterials(_ProjectID, true);
                }
                if (ToolCrib != null && hmTabControl12.SelectedTabPage == tpToolCrib)
                {
                    ToolCrib.LoadBillofEquipments(_ProjectID, true);
                }
                if (InternalEquip != null && hmTabControl12.SelectedTabPage == tpIntEquip)
                {
                    InternalEquip.LoadBillofEquipments(_ProjectID, true);
                }
                if (Labor != null && hmTabControl12.SelectedTabPage == tpLabor)
                {
                    Labor.LoadBillofLabor(_ProjectID, true);
                }
                if (InvSurplus != null && hmTabControl12.SelectedTabPage == tpSurplus)
                {
                    InvSurplus.LoadConsumablesReq(_ProjectID, true);
                }
                if (Consumables != null && hmTabControl12.SelectedTabPage == tpConsumables)
                {
                    Consumables.LoadConsumablesReq(_ProjectID, true);
                }
                if (BudgetView != null && hmTabControl12.SelectedTabPage == tpCostingBudget)
                {
                    BudgetView.ReadOnly = true;
                    BudgetView.PriID = _ProjectID;
                }
            }
        }

        private void hmTabControl11_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl11.SelectedTabPage == tpPurchReqE && PurchaseReqEdit == null)
            {
                PurchaseReqEdit = new ucPurReqEntry(Connection, DevXMgr, KCA_Validator, LaunchType.Project, ProjectType.PC_Land_Construction);
                PurchaseReqEdit.SetReadOnly(false);
                PurchaseReqEdit.Dock = DockStyle.Fill;
                PurchaseReqEdit.Parent = tpPurchReqE;
            }
            else if (hmTabControl11.SelectedTabPage == tpRawMatInvE && RawMatInvEdit == null)
            {
                RawMatInvEdit = new ucBillofMaterials(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                RawMatInvEdit.Dock = DockStyle.Fill;
                RawMatInvEdit.Parent = tpRawMatInvE;
            }
            else if (hmTabControl11.SelectedTabPage == tpToolCribE && ToolCribEdit == null)
            {
                ToolCribEdit = new ucBillofEquipment(Connection, DevXMgr, "T", ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                ToolCribEdit.Dock = DockStyle.Fill;
                ToolCribEdit.Parent = tpToolCribE;
            }
            else if (hmTabControl11.SelectedTabPage == tpIntEquipE && InternalEquipEdit == null)
            {
                InternalEquipEdit = new ucBillofEquipment(Connection, DevXMgr, "F", ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                InternalEquipEdit.Dock = DockStyle.Fill;
                InternalEquipEdit.Parent = tpIntEquipE;
            }
            else if (hmTabControl11.SelectedTabPage == tpLaborE && LaborEdit == null)
            {
                LaborEdit = new ucBillofLabor(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, KCA_Validator);
                LaborEdit.Dock = DockStyle.Fill;
                LaborEdit.Parent = tpLaborE;
            }
            else if (hmTabControl11.SelectedTabPage == tpSurplusEdit && InvSurplusEdit == null)
            {
                InvSurplusEdit = new ucConsumablesReq(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, "S", KCA_Validator);
                InvSurplusEdit.Dock = DockStyle.Fill;
                InvSurplusEdit.Parent = tpSurplusEdit;
            }
            else if (hmTabControl11.SelectedTabPage == tpConsumablesEdit && ConsumablesEdit == null)
            {
                ConsumablesEdit = new ucConsumablesReq(Connection, DevXMgr, ProjectType.PC_Land_Construction, LaunchType.Project, "C", KCA_Validator);
                ConsumablesEdit.Dock = DockStyle.Fill;
                ConsumablesEdit.Parent = tpConsumablesEdit;
            }
            else if (hmTabControl11.SelectedTabPage == tpCostingBudgetEdit && BudgetViewEdit == null)
            {
                BudgetViewEdit = new ucCostingBudgetView(Connection, DevXMgr, LaunchType.Project, ProjectType.PC_Land_Construction);
                BudgetViewEdit.Dock = DockStyle.Fill;
                BudgetViewEdit.Parent = tpCostingBudgetEdit;
            }
            else if (hmTabControl11.SelectedTabPage == tpESetup)
            {
                hmTabControl9_SelectedPageChanged(null, null);
            }

            if (tpProjEdit.PageVisible)
            {
                if (PurchaseReqEdit != null && hmTabControl11.SelectedTabPage == tpPurchReqE)
                {
                    PurchaseReqEdit.LoadPri_ID(_ProjectID);
                }
                if (RawMatInvEdit != null && hmTabControl11.SelectedTabPage == tpRawMatInvE)
                {
                    RawMatInvEdit.LoadBillofMaterials(_ProjectID, false);
                }
                if (ToolCribEdit != null && hmTabControl11.SelectedTabPage == tpToolCribE)
                {
                    ToolCribEdit.LoadBillofEquipments(_ProjectID, false);
                }
                if (InternalEquipEdit != null && hmTabControl11.SelectedTabPage == tpIntEquipE)
                {
                    InternalEquipEdit.LoadBillofEquipments(_ProjectID, false);
                }
                if (LaborEdit != null && hmTabControl11.SelectedTabPage == tpLaborE)
                {
                    LaborEdit.LoadBillofLabor(_ProjectID, false);
                }
                if (InvSurplusEdit != null && hmTabControl11.SelectedTabPage == tpSurplusEdit)
                {
                    InvSurplusEdit.LoadConsumablesReq(_ProjectID, false);
                }
                if (ConsumablesEdit != null && hmTabControl11.SelectedTabPage == tpConsumablesEdit)
                {
                    ConsumablesEdit.LoadConsumablesReq(_ProjectID, false);
                }
                if (BudgetViewEdit != null && hmTabControl11.SelectedTabPage == tpCostingBudgetEdit)
                {
                    BudgetViewEdit.PriID = _ProjectID;
                }
            }
        }

       

        #endregion

        #region Project Changing

        private void Search_ProjectView_Event(int ProjectID)
        {
            if (ProjectID != -1)
            {
                _ProjectID = ProjectID;
                if (tpProjView.PageVisible)
                    hmTabControl5.SelectedTabPage = tpProjView;
            }
        }

        private void Search_ProjectEdit_Event(int ProjectID)
        {
            if (ProjectID != -1)
            {
                _ProjectID = ProjectID;
                if (tpProjEdit.PageVisible)
                    hmTabControl5.SelectedTabPage = tpProjEdit;
            }
        }

       
        #endregion

        private void LoadHeaderInformation()
        {
            ucHeader hdr;
            if (Search.LandSubType == "R")
                hdr = HeaderRaw;
            else
                hdr = Header;
            txtProjName.Text = hdr.Project;
            txtProjNo.Text = hdr.ProjectNumber;
            txtProjNameProjections.Text = hdr.Project;
            txtProjNoProjections.Text = hdr.ProjectNumber;
            txtProjNameLeases.Text = hdr.Project;
            txtProjNoLeases.Text = hdr.ProjectNumber;
            txtProjNameFinancing.Text = hdr.Project;
            txtProjNoFinancing.Text = hdr.ProjectNumber;
            txtProjNameST.Text = hdr.Project;
            txtProjNoST.Text = hdr.ProjectNumber;
            txtProjNameLOCV.Text = hdr.Project;
            txtProjNoLOCV.Text = hdr.ProjectNumber;
            txtProjNameMFV.Text = hdr.Project;
            txtProjNoMFV.Text = hdr.ProjectNumber;
            txtProjNameAFV.Text = hdr.Project;
            txtProjNoAFV.Text = hdr.ProjectNumber;
            txtProjNamePFV.Text = hdr.Project;
            txtProjNoPFV.Text = hdr.ProjectNumber;
            txtProjNameInv.Text = hdr.Project;
            txtProjNoInv.Text = hdr.ProjectNumber;
        }

        private void LoadHeaderEditInformation()
        {
            ucHeader hdr;
            if (Search.LandSubType == "R")
                hdr = HeaderRawEdit;
            else
                hdr = HeaderEdit;

            txtProjNameE.Text = hdr.Project;
            txtProjNoE.Text = hdr.ProjectNumber;
            txtProjNameEProjections.Text = hdr.Project;
            txtProjNoEProjections.Text = hdr.ProjectNumber;
            txtProjNameELeases.Text = hdr.Project;
            txtProjNoELeases.Text = hdr.ProjectNumber;
            txtProjNameEFinancing.Text = hdr.Project;
            txtProjNoEFinancing.Text = hdr.ProjectNumber;
            txtProjNameEST.Text = hdr.Project;
            txtProjNoEST.Text = hdr.ProjectNumber;
            txtProjNameLOCE.Text = hdr.Project;
            txtProjNoLOCE.Text = hdr.ProjectNumber;
            txtProjNameMFE.Text = hdr.Project;
            txtProjNoMFE.Text = hdr.ProjectNumber;
            txtProjNameAFE.Text = hdr.Project;
            txtProjNoAFE.Text = hdr.ProjectNumber;
            txtProjNamePFE.Text = hdr.Project;
            txtProjNoPFE.Text = hdr.ProjectNumber;
            txtProjNameInvE.Text = hdr.Project;
            txtProjNoInvE.Text = hdr.ProjectNumber;
        }

        private void LoadSearchTab()
        {
            if (tpMaintenance.PageVisible)
            {
                if (tpSearch.PageVisible)
                {
                    hmtc_main.SelectedTabPage = tpMaintenance;
                    hmTabControl5.SelectedTabPage = tpSearch;
                }
            }
        }

        private void hmTabControl13_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl13.SelectedTabPage == tpEProjCost && ELandCost == null)
            {
                ELandCost = new CashFlow.ucBase();
                ELandCost.HMConnection = Connection;
                ELandCost.TUC_DevXMgr = DevXMgr;
                ELandCost.KeyControlValidator = KCA_Validator;
                ELandCost.SetReadOnly(false);
                ELandCost.Dock = DockStyle.Fill;
                CashFlow.ucCostControl cc = new CashFlow.ucCostControl();
                cc.Parent = tpEProjCost;
                cc.Dock = DockStyle.Fill;
                ELandCost.Name = "RevenueCashflow";                
                ELandCost.Parent = cc;

                ELandCost.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                ELandCost.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                ELandCost.CashFlowType = CashFlow.ucBase.CF_CashFlowType.Cost;
            }
            else if (hmTabControl13.SelectedTabPage == tpEProjRev && ELandRev == null)
            {
                ELandRev = new CashFlow.ucBase();
                ELandRev.HMConnection = Connection;
                ELandRev.TUC_DevXMgr = DevXMgr;
                ELandRev.KeyControlValidator = KCA_Validator;
                ELandRev.SetReadOnly(false);
                ELandRev.Dock = DockStyle.Fill;
                CashFlow.ucRevenueControl cc = new CashFlow.ucRevenueControl();
                cc.Parent = tpEProjRev;
                cc.Dock = DockStyle.Fill;
                ELandRev.Name = "CostCashflow";
                ELandRev.Parent = cc;

                ELandRev.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                ELandRev.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                ELandRev.CashFlowType = CashFlow.ucBase.CF_CashFlowType.Revenue;
            }

            else if (hmTabControl13.SelectedTabPage == tpEProjMiscRecs && EMiscRecs == null)
            {
                EMiscRecs = new CashFlow.ucBase();
                EMiscRecs.HMConnection = Connection;
                EMiscRecs.TUC_DevXMgr = DevXMgr;
                EMiscRecs.KeyControlValidator = KCA_Validator;
                EMiscRecs.SetReadOnly(false);
                EMiscRecs.Dock = DockStyle.Fill;
                CashFlow.ucMiscReceivablesControl cc = new CashFlow.ucMiscReceivablesControl();
                cc.Parent = tpEProjMiscRecs;
                cc.Dock = DockStyle.Fill;
                EMiscRecs.Name = "MiscRevenueCashflow";
                EMiscRecs.Parent = cc;

                EMiscRecs.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                EMiscRecs.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                EMiscRecs.CashFlowType = CashFlow.ucBase.CF_CashFlowType.MiscReceivables;
            }

            else if (hmTabControl13.SelectedTabPage == tpEProjLoanRepay && ELoanRepay == null)
            {
                ELoanRepay = new CashFlow.ucBase();
                ELoanRepay.HMConnection = Connection;
                ELoanRepay.TUC_DevXMgr = DevXMgr;
                ELoanRepay.KeyControlValidator = KCA_Validator;
                ELoanRepay.SetReadOnly(false);
                ELoanRepay.Dock = DockStyle.Fill;
                CashFlow.ucLoanRepayControl cc = new CashFlow.ucLoanRepayControl();
                cc.Parent = tpEProjLoanRepay;
                cc.Dock = DockStyle.Fill;
                ELoanRepay.Name = "LoanRepayCashflow";
                ELoanRepay.Parent = cc;

                ELoanRepay.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                ELoanRepay.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                ELoanRepay.CashFlowType = CashFlow.ucBase.CF_CashFlowType.LoanRepay;
            }
            if (hmTabControl13.SelectedTabPage == tpEProjCost && ELandCost != null)
            {
                if( ELandCost.LinkID != _ProjectID )
                    ELandCost.LoadLinkID(_ProjectID);
            }
            else if (hmTabControl13.SelectedTabPage == tpEProjRev && ELandRev != null)
            {
                if (ELandRev.LinkID != _ProjectID)
                    ELandRev.LoadLinkID(_ProjectID);
            }
            else if (hmTabControl13.SelectedTabPage == tpEProjMiscRecs && EMiscRecs != null)
            {
                if (EMiscRecs.LinkID != _ProjectID)
                    EMiscRecs.LoadLinkID(_ProjectID);
            }
            else if (hmTabControl13.SelectedTabPage == tpEProjLoanRepay && ELoanRepay != null)
            {
                if (ELoanRepay.LinkID != _ProjectID)
                    ELoanRepay.LoadLinkID(_ProjectID);
            }
        }

        private void hmTabControl14_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl14.SelectedTabPage == tpVProjCost && VLandCost == null)
            {
                VLandCost = new CashFlow.ucBase();
                VLandCost.HMConnection = Connection;
                VLandCost.TUC_DevXMgr = DevXMgr;
                VLandCost.KeyControlValidator = KCA_Validator;
                VLandCost.SetReadOnly(true);
                VLandCost.Dock = DockStyle.Fill;
                VLandCost.Parent = tpVProjCost;

                VLandCost.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                VLandCost.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                VLandCost.CashFlowType = CashFlow.ucBase.CF_CashFlowType.Cost;
                //VLandCost = new ProjectUtilities.Land.Projections.ucCost(Connection, DevXMgr);
                //VLandCost.SetReadOnly(true);
                //VLandCost.Dock = DockStyle.Fill;
                //VLandCost.Parent = tpVProjCost;
            }
            else if (hmTabControl14.SelectedTabPage == tpVProjRev && VLandRev == null)
            {
                VLandRev = new CashFlow.ucBase();
                VLandRev.HMConnection = Connection;
                VLandRev.TUC_DevXMgr = DevXMgr;
                VLandRev.KeyControlValidator = KCA_Validator;
                VLandRev.SetReadOnly(true);
                VLandRev.Dock = DockStyle.Fill;
                VLandRev.Parent = tpVProjRev;

                VLandRev.LinkType = CashFlow.ucBase.CF_LinkType.Project;
                VLandRev.LinkSubType = CashFlow.ucBase.CF_LinkSubType.PLC;
                VLandRev.CashFlowType = CashFlow.ucBase.CF_CashFlowType.Revenue;
                //VLandRev = new ProjectUtilities.Land.Projections.ucRevenue(Connection, DevXMgr);
                //VLandRev.SetReadOnly(true);
                //VLandRev.Dock = DockStyle.Fill;
                //VLandRev.Parent = tpVProjRev;
            }

            if (hmTabControl14.SelectedTabPage == tpVProjCost && VLandCost != null)
            {
                if (VLandCost.LinkID != _ProjectID)
                    VLandCost.LoadLinkID(_ProjectID);
            }
            else if (hmTabControl14.SelectedTabPage == tpVProjRev && VLandRev != null)
            {
                if (VLandRev.LinkID != _ProjectID)
                    VLandRev.LoadLinkID(_ProjectID);
            }
        }

        private void hmTabControl15_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl15.SelectedTabPage == tpLotSearch && LotSearch == null)
            {
                LotSearch = new ProjectUtilities.Land.LotInventory.ucSearch(Connection, DevXMgr);
                LotSearch.SetReadOnly(false);
                LotSearch.SetProjectSearch(true);
                LotSearch.Dock = DockStyle.Fill;
                LotSearch.Parent = tpLotSearch;
                LotSearch.BringToFront();
                LotSearch.LotView_Event += new ProjectUtilities.Land.LotInventory.ucSearch.LotView_Delegate(LotSearch_LotView_Event);
                LotSearch.LotEdit_Event += new ProjectUtilities.Land.LotInventory.ucSearch.LotEdit_Delegate(LotSearch_LotEdit_Event);
                LotSearch.AddLot_Event += new ProjectUtilities.Land.LotInventory.ucSearch.AddLot_Delegate(LotSearch_AddLot_Event);                
            }
            else if (hmTabControl15.SelectedTabPage == tpLotView)
            {
                hmTabControl17_SelectedPageChanged(null, null);               
            }
            else if (hmTabControl15.SelectedTabPage == tpLotEdit)
            {
                hmTabControl16_SelectedPageChanged(null, null);
            }
            
            if (hmTabControl15.SelectedTabPage == tpLotSearch && LotSearch != null)
            {
                LotSearch.LoadProject(_ProjectID);
            }            
        }

      
        private void LotSearch_LotEdit_Event(int LotID)
        {
            if (tpLotEdit.PageVisible)
            {
                hmTabControl15.SelectedTabPage = tpLotEdit;
                LotHeaderEdit.LoadLot(LotID, _ProjectID);
            }
        }

        private void LotSearch_LotView_Event(int LotID)
        {
            if (tpLotView.PageVisible)
            {
                hmTabControl15.SelectedTabPage = tpLotView;
                LotHeaderView.LoadLot(LotID, _ProjectID);
            }
        }

        private void LotSearch_AddLot_Event()
        {
            _bNewLot = true;
            if (tpLotEdit.PageVisible)
            {
                hmTabControl15.SelectedTabPage = tpLotEdit;
                hmTabControl16.SelectedTabPage = tpELotHeader;
                LotHeaderEdit.SetInsertMode();
            }
            _bNewLot = false;
        }

        private void hmTabControl17_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl17.SelectedTabPage == tpVLotHeader && LotHeaderView == null)
            {
                LotHeaderView = new ProjectUtilities.Land.LotInventory.ucHeader(Connection, DevXMgr);
                LotHeaderView.KCA_Validator = KCA_Validator;
                LotHeaderView.SetReadOnly(true);
                LotHeaderView.Dock = DockStyle.Fill;
                LotHeaderView.Parent = tpVLotHeader;
                LotHeaderView.BringToFront();
            }
            else if (hmTabControl17.SelectedTabPage == tpVLotDetail)
            {
                hmTabControl19_SelectedPageChanged(null, null);
            }


            if (hmTabControl17.SelectedTabPage == tpVLotHeader && LotHeaderView != null)
            {
                LotHeaderView.LoadLot(_LotID, _ProjectID);
            }             
        }

        private void hmTabControl16_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl16.SelectedTabPage == tpELotHeader && LotHeaderEdit == null)
            {
                LotHeaderEdit = new ProjectUtilities.Land.LotInventory.ucHeader(Connection, DevXMgr);
                LotHeaderEdit.NewLotCreated_Event += new ProjectUtilities.Land.LotInventory.ucHeader.NewLotCreated_Delegate(LotHeaderEdit_NewLotCreated_Event);
                LotHeaderEdit.KCA_Validator = KCA_Validator;
                LotHeaderEdit.SetReadOnly(false);
                LotHeaderEdit.Dock = DockStyle.Fill;
                LotHeaderEdit.Parent = tpELotHeader;
                LotHeaderEdit.BringToFront();
            }
            else if (hmTabControl16.SelectedTabPage == tpELotDetails)
            {
                hmTabControl18_SelectedPageChanged(null, null);
            }

            if (hmTabControl16.SelectedTabPage == tpELotHeader && LotHeaderEdit != null)
            {
                LotHeaderEdit.LoadLot(_LotID, _ProjectID);
            } 
        }

        private void LotHeaderEdit_NewLotCreated_Event(int LotID)
        {
            _LotID = LotID;
        }

        private void hmTabControl19_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl19.SelectedTabPage == tpVAgreement && LotAgreeView == null)
            {
                LotAgreeView = new ProjectUtilities.Land.LotInventory.Detail.ucAgreement(Connection, DevXMgr);
                LotAgreeView.KCA_Validator = KCA_Validator;
                LotAgreeView.SetReadOnly(true);
                LotAgreeView.Dock = DockStyle.Fill;
                LotAgreeView.Parent = tpVAgreement;
                LotAgreeView.BringToFront();
            }
            else if (hmTabControl19.SelectedTabPage == tpVTaxes && LotTaxesView == null)
            {
                LotTaxesView = new ProjectUtilities.Land.LotInventory.Detail.ucTaxes(Connection, DevXMgr);
                LotTaxesView.SetReadOnly(true);
                LotTaxesView.Dock = DockStyle.Fill;
                LotTaxesView.Parent = tpVTaxes;
                LotTaxesView.BringToFront();
            }
            else if (hmTabControl19.SelectedTabPage == tpVHolds && LotHoldsView == null)
            {
                LotHoldsView = new ProjectUtilities.Land.LotInventory.Detail.ucHolds(Connection, DevXMgr);
                LotHoldsView.SetReadOnly(true);
                LotHoldsView.Dock = DockStyle.Fill;
                LotHoldsView.Parent = tpVHolds;
                LotHoldsView.BringToFront();
            }
            else if (hmTabControl19.SelectedTabPage == tpVFinancial && LotFinancialView == null)
            {
                LotFinancialView = new ProjectUtilities.Land.LotInventory.Detail.ucFinancial(Connection, DevXMgr);
                LotFinancialView.SetReadOnly(true);
                LotFinancialView.Dock = DockStyle.Fill;
                LotFinancialView.Parent = tpVFinancial;
                LotFinancialView.BringToFront();
            }            
            
                        
            if (hmTabControl19.SelectedTabPage == tpVAgreement && LotAgreeView != null)
            {
                LotAgreeView.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl19.SelectedTabPage == tpVTaxes && LotTaxesView != null)
            {
                LotTaxesView.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl19.SelectedTabPage == tpVHolds && LotHoldsView != null)
            {
                LotHoldsView.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl19.SelectedTabPage == tpVFinancial && LotFinancialView != null)
            {
                LotFinancialView.LoadLot(_LotID, _ProjectID);
            } 
        }

        private void hmTabControl18_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (hmTabControl18.SelectedTabPage == tpEAgreement && LotAgreeEdit == null)
            {
                LotAgreeEdit = new ProjectUtilities.Land.LotInventory.Detail.ucAgreement(Connection, DevXMgr);
                LotAgreeEdit.KCA_Validator = KCA_Validator;
                LotAgreeEdit.SetReadOnly(false);
                LotAgreeEdit.Dock = DockStyle.Fill;
                LotAgreeEdit.Parent = tpEAgreement;
                LotAgreeEdit.BringToFront();
            }
            else if (hmTabControl18.SelectedTabPage == tpETaxes && LotTaxesEdit == null)
            {
                LotTaxesEdit = new ProjectUtilities.Land.LotInventory.Detail.ucTaxes(Connection, DevXMgr);
                LotTaxesEdit.SetReadOnly(false);
                LotTaxesEdit.Dock = DockStyle.Fill;
                LotTaxesEdit.Parent = tpETaxes;
                LotTaxesEdit.BringToFront();
            }
            else if (hmTabControl18.SelectedTabPage == tpEHolds && LotHoldsEdit == null)
            {
                LotHoldsEdit = new ProjectUtilities.Land.LotInventory.Detail.ucHolds(Connection, DevXMgr);
                LotHoldsEdit.SetReadOnly(false);
                LotHoldsEdit.Dock = DockStyle.Fill;
                LotHoldsEdit.Parent = tpEHolds;
                LotHoldsEdit.BringToFront();
            }
            else if (hmTabControl18.SelectedTabPage == tpEFinancial && LotFinancialEdit == null)
            {
                LotFinancialEdit = new ProjectUtilities.Land.LotInventory.Detail.ucFinancial(Connection, DevXMgr);
                LotFinancialEdit.SetReadOnly(false);
                LotFinancialEdit.Dock = DockStyle.Fill;
                LotFinancialEdit.Parent = tpEFinancial;
                LotFinancialEdit.BringToFront();
            }
                        

            if (hmTabControl18.SelectedTabPage == tpEAgreement && LotAgreeEdit != null)
            {
                LotAgreeEdit.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl18.SelectedTabPage == tpETaxes && LotTaxesEdit != null)
            {
                LotTaxesEdit.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl18.SelectedTabPage == tpEHolds && LotHoldsEdit != null)
            {
                LotHoldsEdit.LoadLot(_LotID, _ProjectID);
            }
            else if (hmTabControl18.SelectedTabPage == tpEFinancial && LotFinancialEdit != null)
            {
                LotFinancialEdit.LoadLot(_LotID, _ProjectID);
            } 
        }

     

        private void tcTools_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            if (tcTools.SelectedTabPage == tp_tAgreements && ucLotAgreeementAsssistant == null)
            {
                ucLotAgreeementAsssistant = new LD_LotAgreementAssistant.ucPati(Connection, DevXMgr);
                ucLotAgreeementAsssistant.KCA_Validator = KCA_Validator; ;
                ucLotAgreeementAsssistant.Dock = DockStyle.Fill;
                ucLotAgreeementAsssistant.Parent = tp_tAgreements;
            }
            else if (tcTools.SelectedTabPage == tp_tLotSale && ucLotSaleAssistant == null)
            {
                ucLotSaleAssistant = new LD_LotSaleAssistant.ucPati(Connection, DevXMgr, KCA_Validator);
                ucLotSaleAssistant.Dock = DockStyle.Fill;
                ucLotSaleAssistant.Parent = tp_tLotSale;
            }
            else if (tcTools.SelectedTabPage == tp_pLotSaleAdj && ucLotAdjAssistant == null)
            {
                ucLotAdjAssistant = new LD_LotAdjustmentAssistant.ucLotAdjustments(Connection, DevXMgr);
                ucLotAdjAssistant.Dock = DockStyle.Fill;
                ucLotAdjAssistant.Parent = tp_pLotSaleAdj;
            }
            else if (tcTools.SelectedTabPage == tp_tLotUnSell && ucLotUnSellAssistant == null)
            {
                ucLotUnSellAssistant = new LD_LotUnSellAssistant.ucPati(Connection, DevXMgr, KCA_Validator);
                ucLotUnSellAssistant.Dock = DockStyle.Fill;
                ucLotUnSellAssistant.Parent = tp_tLotUnSell;
            }
            else if (tcTools.SelectedTabPage == tp_tLotPayout && ucLotPayoutAssistant == null)
            {
                ucLotPayoutAssistant = new LD_LotPayoutAssistant.ucPati(Connection, DevXMgr, KCA_Validator);
                ucLotPayoutAssistant.Dock = DockStyle.Fill;
                ucLotPayoutAssistant.Parent = tp_tLotPayout;
            }
            else if (tcTools.SelectedTabPage == tp_tProjectClose && ucProjclose == null)
            {
                ucProjclose = new LD_Project_Close.ucProjectClose(Connection, DevXMgr, KCA_Validator);
                ucProjclose.Dock = DockStyle.Fill;
                ucProjclose.Parent = tp_tProjectClose;
            }
            else if (tcTools.SelectedTabPage == tpDownPaymentDue)
            {
                if (DownPaymentDue == null)
                {
                    DownPaymentDue = new LD_DownPaymentDue.ucDownPaymentDue(Connection, DevXMgr);
                    DownPaymentDue.Dock = DockStyle.Fill;
                    DownPaymentDue.Parent = tpDownPaymentDue;
                }
            }
            else if (tcTools.SelectedTabPage == tpManagementFees)
            {
                if (ManagementFees == null)
                {
                    ManagementFees = new LD_ManagementFees.ucManagementFees(Connection, DevXMgr);
                    ManagementFees.Dock = DockStyle.Fill;
                    ManagementFees.Parent = tpManagementFees;
                }
            }
            else if (tcTools.SelectedTabPage == tpProgramFees)
            {
                if (ProgramFees == null)
                {
                    ProgramFees = new LD_ProgramFees.ucProgramFees(Connection, DevXMgr);
                    ProgramFees.Dock = DockStyle.Fill;
                    ProgramFees.Parent = tpProgramFees;
                }
            }
            else if (tcTools.SelectedTabPage == tpDateManagement)
            {
                if (DateManagement == null)
                {
                    DateManagement = new LD_DateManagement.ucDateManagement(Connection, DevXMgr);
                    DateManagement.Dock = DockStyle.Fill;
                    DateManagement.Parent = tpDateManagement;
                }
            }
            else if (tcTools.SelectedTabPage == tpSpecHomeOwnerUpdate)
            {
                if (specHomeOwnerUpdate == null)
                {
                    specHomeOwnerUpdate = new LD_SpecHomeOwnerUpdate.ucSpecHomeOwnerUpdate(Connection, DevXMgr);
                    specHomeOwnerUpdate.Dock = DockStyle.Fill;
                    specHomeOwnerUpdate.Parent = tpSpecHomeOwnerUpdate;
                }
            }
            else if (tcTools.SelectedTabPage == tpQueries)
            {
                tcQueries_SelectedPageChanged(tcQueries,
                    new DevExpress.XtraTab.TabPageChangedEventArgs(tcQueries.SelectedTabPage, tcQueries.SelectedTabPage));
            }
            else if (tcTools.SelectedTabPage == tpCashCall)
            {
                if (CashCallPati == null)
                {
                    CashCallPati = new LD_CashCall.ucCashCallPati(Connection, DevXMgr, LD_CashCall.PatiType.Cashcall);
                    CashCallPati.Dock = DockStyle.Fill;
                    CashCallPati.Parent = tpCashCall;
                }
            }
            else if (tcTools.SelectedTabPage == tpDistribution)
            {
                if (DistributionPati == null)
                {
                    DistributionPati = new LD_CashCall.ucCashCallPati(Connection, DevXMgr, LD_CashCall.PatiType.Distribution);
                    DistributionPati.Dock = DockStyle.Fill;
                    DistributionPati.Parent = tpDistribution;
                }
            }
            else if (tcTools.SelectedTabPage == tpRefundDeposit)
            {
                if (refundDeposits == null)
                {
                    refundDeposits = new LD_RefundDeposits.ucRefundDeposits(Connection, DevXMgr);
                    refundDeposits.Dock = DockStyle.Fill;
                    refundDeposits.Parent = tpRefundDeposit;

                }
            }
            else if (tcTools.SelectedTabPage == tpLotDiscount)
            {
                if (lotDiscounts == null)
                {
                    lotDiscounts = new LD_LotDiscount.ucLotDiscountPati(Connection, DevXMgr);
                    lotDiscounts.Dock = DockStyle.Fill;
                    lotDiscounts.Parent = tpLotDiscount;

                }
            }
            else if (tcTools.SelectedTabPage == tpLevyMgmt)
            {
                if (levyManagement == null)
                {
                    levyManagement = new LD_LevyAssistant.ucLevyAssistant(Connection, DevXMgr);
                    levyManagement.Dock = DockStyle.Fill;
                    levyManagement.Parent = tpLevyMgmt;

                }
            }
            else if (tcTools.SelectedTabPage == tpLotInterest)
            {
                if(lotInterest == null)
                {
                    lotInterest = new LD_AgreementsInterest.ucPati(Connection, DevXMgr);
                    lotInterest.Dock = DockStyle.Fill;
                    lotInterest.Parent = tpLotInterest;
                }
            }

        }

        private void tcLotNeighbors_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            
            if (tcLotNeighbors.SelectedTabPage == tpLotNeighborsSearch)
            {
                if (lotNeighbor == null)
                {
                    lotNeighbor = new LD_LotNeighbor.ucLotSearch(Connection, DevXMgr);
                    lotNeighbor.Dock = DockStyle.Fill;
                    lotNeighbor.Parent = tpLotNeighborsSearch;
                }
            }
            else if (tcLotNeighbors.SelectedTabPage ==tpNeignborSetup)
            {
                if (lotNeighborSetup == null)
                {
                    lotNeighborSetup = new LD_LotNeighbor.ucLotNeighborMain(Connection, DevXMgr);
                    lotNeighborSetup.Dock = DockStyle.Fill;
                    lotNeighborSetup.Parent = tpNeignborSetup;
                }
                if (lotNeighborSetup != null)
                    lotNeighborSetup.GetLostLists();
            }
        }

        private void tcQueries_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tcQueries.SelectedTabPage == tpDevBgtByProj)
            {
                if (DevBudgetByProj == null)
                {
                    DevBudgetByProj = new LD_DevBgtByProj.DevBgtByProj(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                    DevBudgetByProj.Dock = DockStyle.Fill;
                    DevBudgetByProj.Parent = tpDevBgtByProj;
                }
            }
            else if (tcQueries.SelectedTabPage == tpDevCostByProj)
            {
                if (DevCostByProj == null)
                {
                    DevCostByProj = new LD_DevCostByProj.DevCostByProj(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                    DevCostByProj.Dock = DockStyle.Fill;
                    DevCostByProj.Parent = tpDevCostByProj;
                }
            }
            else if (tcQueries.SelectedTabPage == tpDevCostByYear)
            {
                if (DevCostByYear == null)
                {
                    DevCostByYear = new LD_DevCostByYear.DevCostByYear(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                    DevCostByYear.Dock = DockStyle.Fill;
                    DevCostByYear.Parent = tpDevCostByYear;
                }
            }
            else if (tcQueries.SelectedTabPage == tpProjSalesByYear)
            {
                if (ProjSalesByYear == null)
                {
                    ProjSalesByYear = new LD_ProjSalesByYear.ProjSalesByYear(Connection, DevXMgr, ProjectType.PC_Land_Construction);
                    ProjSalesByYear.Dock = DockStyle.Fill;
                    ProjSalesByYear.Parent = tpProjSalesByYear;
                }
            }
        }


        #region Selected Page Changing

        
        private void hmtc_main_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (tpProcessing.Name == e.PrevPage.Name)
            {
                hmtc_processing_SelectedPageChanging(hmtc_processing,new DevExpress.XtraTab.TabPageChangingEventArgs(hmtc_processing.SelectedTabPage,hmtc_processing.SelectedTabPage));
            }
        }

        private void hmTabControl5_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (hmTabControl5.SelectedTabPage == tpSearch)
            {
                int ProjectID = Search.ProjectSelected();
                if (ProjectID != -1)
                {
                    _ProjectID = ProjectID;
                }
                else
                {
                    if (e.Page == tpProjView)
                        Popup.ShowPopup("Please select a project to view.");
                    else if (e.Page == tpProjEdit)
                        Popup.ShowPopup("Please select a project to edit.");
                    else if (e.Page == tpQueryAnalysis)
                        Popup.ShowPopup("Please select a project.");
                    else if (e.Page == tpLotInv)
                        Popup.ShowPopup("Please select a project.");
                    e.Cancel = true;
                }
            }
        }

        private void hmTabControl15_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (hmNavigationBar1.SettingSecurity) return;
            int LotID = LotSearch.LotSelected();
            _LotID = LotID;

            if (hmTabControl15.SelectedTabPage == tpLotSearch && !_bNewLot)
            {
                if (LotID != -1)
                {
                    _LotID = LotID;
                }
                else
                {
                    if (e.Page == tpLotView)
                        Popup.ShowPopup("Please select a lot to view.");
                    else if (e.Page == tpLotEdit)
                        Popup.ShowPopup("Please select a lot to edit.");
                    e.Cancel = true;
                }
            }
        }

        #endregion Selected Page Changing

        private void hmtc_processing_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (e.PrevPage.Name == tpLotNeighbors.Name)
            {
                tcLotNeighbors_SelectedPageChanging(tcLotNeighbors,new DevExpress.XtraTab.TabPageChangingEventArgs(tcLotNeighbors.SelectedTabPage,tcLotNeighbors.SelectedTabPage));
            }
        }

        private void tcLotNeighbors_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (e.PrevPage.Name == tpNeignborSetup.Name)
            {
                if (lotNeighborSetup != null)
                {
                    e.Cancel = !lotNeighborSetup.CanSwitchTabPages();
                }
            }
        }

        


    }
}
    