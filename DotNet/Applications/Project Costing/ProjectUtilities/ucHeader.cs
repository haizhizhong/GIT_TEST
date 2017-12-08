using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;
using PC_StakeholderPicker;
using PC_Services;
using ProjectTypes;
using System.Threading;
using System.Diagnostics;

namespace ProjectUtilities
{

    public partial class ucHeader : DevExpress.XtraEditors.XtraUserControl
    {
        #region ucHeader Class Variables

        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        public ucStakeholderVG Stakeholders;
        private PPM_SOW.ucResourceMgmt ResourceManagement;
        private PPM_SOW.ucWorkFlow ProcessFlow;

        public delegate void RefreshGAPStructureDelegate();
        public event RefreshGAPStructureDelegate RefreshGAPStructure;

        private ProjectType _Flavour;

        private KeyControlAccess.Validator KCA_Validator;
        private const int CONST_REV_ACCESS_GC_APPROVAL_TOPIC_ID = 141;
        private const int CONST_REV_ACCESS_HC_APPROVAL_TOPIC_ID = 142;
        private const int CONST_REV_ACCESS_UC_APPROVAL_TOPIC_ID = 143;
        private const int CONST_REV_ACCESS_LC_APPROVAL_TOPIC_ID = 144;
        private const int CONST_ProvinceChange = 352;
        
        private Land.Header.Frame LandFrame;
        private PPM_GapCtrl.ucProjInfoGap uPIG;
        private bool _bPPM_Enabled = false;

        private LD_RawLandControls.ucAdditionalUseAreas LD_AdditionalUseAreas;
        private LD_RawLandControls.ucRawLandHolding LD_RawLandHolding;
        private LD_RawLandControls.ucStages LD_Stages;
        private LD_RawLandControls.ucMarketValue LD_MarketValue;
        private LD_RawLandControls.ucPreviousLandUse LD_PrevLandUse;
        private LD_ProjMilestone.ucProjMilestone LD_ProjMilestone;
        private LD_RawLandControls.ucProjectAllocated LD_ProjAllocated;

        private int _PriID = -1;
        private bool _ReadOnly = false;

        private TUC_GridG.GridG gGridAdditionalDates;
        private UDF_Manager.ucUDF_Manager udf;
        

        #endregion

        public ucHeader(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, ProjectType Flavour, KeyControlAccess.Validator KCA_Validator):
        this(Connection,DevXMgr,Flavour,KCA_Validator,"P")
        {
        }

        public ucHeader(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, ProjectType Flavour, KeyControlAccess.Validator KCA_Validator,string pLandSubType)
        {
            this.sLandSubType = pLandSubType;
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            this.KCA_Validator = KCA_Validator;
            Popup = new frmPopup(DevXMgr);
            _Flavour = Flavour;
            InitializeComponent();
            WEB_Conn.ConnectionString = Connection.WebConnection;
            RunSetups();

            gGridAdditionalDates = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvAdditionalDates, da_AdditionalDates, ds_AdditionalDates1);
            gGridAdditionalDates.AllowTabCreateNewRecord = true;
            gGridAdditionalDates.AskBeforeDelete = false;
            gGridAdditionalDates.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            

        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }

        public void LoadProject( int ProjectID )
        {
            _PriID = ProjectID;
            dsSelectedProject1.Clear();
            txtProjNum.EditValue = null;
            uPIG.PriID = _PriID;
            dsCustAddr1.Clear();
            dsEstimate1.Clear();
            dsContractType1.Clear();
            ds_lueAdditionalDates1.Clear();
            ds_AdditionalDates1.Clear();
            da_AdditionalDates.SelectCommand.Parameters["@pri_id"].Value = ProjectID;

            da_AdditionalDates.Fill(ds_AdditionalDates1);
            da_lueAdditionalDates.Fill(ds_lueAdditionalDates1);
            LoadCustomerType();
            if (ProjectID != -1)
            {
                //SetupCO(); 
                string sSQL = "exec sp_WO_CalcCosts "+ProjectID;
                Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                daContractType.Fill(dsContractType1);
                daSelectedProject.SelectCommand.Parameters["@pri_id"].Value = ProjectID;
                daSelectedProject.Fill(dsSelectedProject1);
                SetupCO(); 

                FillAdminProjects();

                string sSelect = @"select CASE WHEN ISNULL(p.is_co , 'F') = 'F' 
	                THEN CAST(p.pri_code AS varchar) 
	                ELSE CAST(mp.pri_code AS varchar) + '-' + CAST(p.pri_code AS varchar) 
	                END AS pri_code
                    from proj_header p 
                    LEFT OUTER JOIN PROJ_HEADER AS mp ON mp.pri_id = p.CO_Pri_ID
                    where p.pri_id=" + ProjectID;
                txtProjNum.EditValue = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                
                if(lueContractType.EditValue == null)
                    txtContractAmt.Properties.ReadOnly = false;
                else if ((lueContractType.EditValue.Equals("F") || lueContractType.EditValue == DBNull.Value ) && dnProject.Buttons.EndEdit.Enabled)
                    txtContractAmt.Properties.ReadOnly = false;
                else
                    txtContractAmt.Properties.ReadOnly = true;
                daCustAddr.SelectCommand.Parameters["@customer_id"].Value = Connection.SQLExecutor.ExecuteScalar("select customer_id from proj_header where pri_id=" + ProjectID, Connection.TRConnection);
                daCustAddr.Fill(dsCustAddr1);
                daEstimate.SelectCommand.Parameters["@est_id"].Value = Connection.SQLExecutor.ExecuteScalar("select est_id from proj_header where pri_id=" + ProjectID, Connection.TRConnection); ;
                daEstimate.Fill(dsEstimate1);
                if (_Flavour == ProjectType.PC_Land_Construction)
                {


                    string sql = "if not exists(select * from PROJ_DEV_INFO where PRI_ID = " + ProjectID.ToString() + ")" +
                        "insert into PROJ_DEV_INFO(PRI_ID)select " + ProjectID.ToString();

                    Connection.SQLExecutor.ExecuteNonQuery(sql, Connection.TRConnection);
                    if (Connection.SQLExecutor.Exception != null)
                        Popup.ShowPopup("Error inserting default Development Project Information:\r\n" + Connection.SQLExecutor.Exception.Message);

                    daProjDevInfo.SelectCommand.Parameters["@PRI_ID"].Value = ProjectID;
                    dsProjDevInfo1.Clear();
                    daProjDevInfo.Fill(dsProjDevInfo1);
                    if (dsProjDevInfo1.PROJ_DEV_INFO.Rows.Count > 0)
                    {
                        if (dsProjDevInfo1.PROJ_DEV_INFO.Rows[0]["GEOGRAPHIC_AREA_ID"] == DBNull.Value)
                            Popup.ShowPopup("Development Project Information must be entered");

                    }

                    double dFrontage = 0.00;

                    try { dFrontage = Convert.ToDouble(Connection.SQLExecutor.ExecuteScalar("Select Sum(frontage) From PROJ_LOT where pri_id = " + ProjectID.ToString(), Connection.TRConnection)); }
                    catch { }

                    teActualFrontage.EditValue = dFrontage;
                    lueLandType.EditValue = sLandSubType;
                    
                }
               
                if (_Flavour == ProjectType.PC_Software_Development)
                {
                    ResourceManagement.SetProject(ProjectID, -1);
                    ProcessFlow.SetProject(ProjectID, -1);
                }

            }
            Stakeholders.LoadStakeholders(ProjectID);
            LoadKCAAccess();

            if (_Flavour == ProjectType.PC_Land_Construction)
            {
                dsLotSummary.Clear();
                daLotSummary.SelectCommand.Parameters["@pri_id"].Value = ProjectID.ToString();
                daLotSummary.Fill(dsLotSummary);   

                LD_MarketValue.RefreshDetails(ProjectID);
                if (LandSubType == "P")
                {
                    LD_RawLandHolding.RefreshDetails(ProjectID);
                    LD_ProjMilestone.RefreshMe(ProjectID);
                }
                else
                {
                    LD_Stages.RefreshDetails(ProjectID);
                    LD_AdditionalUseAreas.RefreshDetails(ProjectID);
                    LD_PrevLandUse.RefreshMe(ProjectID);
                    LD_ProjAllocated.RefreshMe(ProjectID);
                   
                }

            }

            SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Project", ref btnSharepoint, "Header", _PriID);

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, GetPriTypeString(), _PriID, ref btnAttachments);

            if (LandFrame != null)
                LandFrame.LoadProject(ProjectID);
            LoadUDF();
            object oAllowCustomerChange = Connection.SQLExecutor.ExecuteScalar("select AllowCustomerChange from proj_cntl", Connection.TRConnection);
            if (oAllowCustomerChange != null && oAllowCustomerChange != DBNull.Value && !Convert.ToBoolean(oAllowCustomerChange))
                lciChangeCustomer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void SetupCO()
        {
            
            dsSuperProject1.Tables[0].DefaultView.RowFilter = "";
            luSuperProject.Properties.DataSource = dsSuperProject1.Tables[0].DefaultView;
            dsCOSummary1.Clear();

            decimal dGAP_Amt = 0;

            lciBillingType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciBaseFolder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciSuperProject.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            string sSelect = "select isnull(is_co,'F') from proj_header where pri_id = "+_PriID;
            if (Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection).Equals("T"))
            {
                lciMasterProjInfo.RestoreFromCustomization();
                lciMasterProjInfo.ShowInCustomizationForm = true;
                lciMasterProjInfo.Move(lciEstimateReference, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                gProjInfo.Text = "Change Order Information";
                gProjCostInfo.Text = "Change Order Costing Information";

                lciSiteAddr.Move(lciProjCostInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                lciStakeholders.Move(lciSiteAddr, DevExpress.XtraLayout.Utils.InsertType.Bottom);

                lciProjInfo.MinSize = new Size(560, 400);
                lciCOInfo.RestoreFromCustomization();
                lciCOInfo.ShowInCustomizationForm = true;

                sSelect = "select m.pri_code, isnull(m.pri_name,'') from proj_header m join proj_header c on c.co_pri_id=m.pri_id where c.pri_id="+_PriID;
                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        if (dr != null)
                        {
                            txtMastProjNo.Text = dr[0].ToString();
                            txtMastProjName.Text = dr[1].ToString();
                        }
                    }
                }

                if (lciCOAmt.ShowInCustomizationForm || layoutControlItem33.ShowInCustomizationForm)
                {
                    if (lciCOAmt.Visible)
                        lciCOAmt.HideToCustomization();
                    lciCOAmt.ShowInCustomizationForm = false;

                    if (layoutControlItem33.Visible)
                        layoutControlItem33.HideToCustomization();
                    layoutControlItem33.ShowInCustomizationForm = false;
                }

                lciProjCostInfo.MinSize = new Size(540, 141);
                lciProjCostInfo.MaxSize = new Size(540, 141);

                dockManager1.ForceInitialize();
                dpChangeOrders.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                //Stakeholders.SetChangeOrder(true);
            }
            else
            {
                lciMasterProjInfo.HideToCustomization();
                lciMasterProjInfo.ShowInCustomizationForm = false;
                gProjInfo.Text = "Project Information";
                gProjCostInfo.Text = "Project Costing Information";

                if (_Flavour == ProjectType.PC_Unit_Construction)
                {
                    lciSiteAddr.Move(lciProjCostInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciStakeholders.Move(lciSiteAddr, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                }
                else
                {
                    lciStakeholders.Move(lciProjCostInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciSiteAddr.Move(lciProjInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                }

                //Stakeholders.SetChangeOrder(false);
                if (_Flavour == ProjectType.PC_Land_Construction)
                {
                    lciProjInfo.MinSize = new Size(560, 310);
                    lciProjInfo.MaxSize = new Size(560, 310);
                }
                else if (_Flavour == ProjectType.PC_General_Construction)
                {
                    lciBaseFolder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                    int iProjInfoHeight = 300;

                    if (_bPPM_Enabled)
                    {
                        iProjInfoHeight =  330;
                    }

                    lciProjInfo.MinSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.MaxSize = new Size(560, iProjInfoHeight);
                    dpChangeOrders.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                }
                else if (_Flavour == ProjectType.PC_Software_Development)
                {
                    lciBillingType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciBaseFolder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciSuperProject.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                    int iProjInfoHeight = 290;

                    if (_bPPM_Enabled)
                    {
                        iProjInfoHeight = 290;
                    }

                    lciProjInfo.MinSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.MaxSize = new Size(560, iProjInfoHeight);

                    if (_bPPM_Enabled)
                    {
                       

                        lciGAPAmount.RestoreFromCustomization(lciCOAmt, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                        lciGAPAmount.ShowInCustomizationForm = true;
                       

                        lciCustType.RestoreFromCustomization(lciCustomer, DevExpress.XtraLayout.Utils.InsertType.Top);
                        lciCustType.ShowInCustomizationForm = true;

                        lciInternalType.RestoreFromCustomization(lciCustType, DevExpress.XtraLayout.Utils.InsertType.Right);
                        lciInternalType.ShowInCustomizationForm = true;

                        lciCustInfo.MinSize = new Size(540, 260);
                        lciCustInfo.MaxSize = new Size(540, 260);
                        lciCustInfo.Size = new Size(540, 260);

                        lciProjCostInfo.MinSize = new Size(540, 290);   
                        lciProjCostInfo.MaxSize = new Size(540, 290);
                        lciProjCostInfo.Size = new Size(540, 290);

                        dsCustomerType1.Clear();
                        daCustomerType.Fill(dsCustomerType1);

                        dsInternalType1.Clear();
                        daInternalType.Fill(dsInternalType1);

                        string sSQL = @"select isnull((select SUM(ISNULL(contract_amount,0)) from PPM_Milestone where pri_id="+_PriID+@"),0)";
                        object oGAP_Amt = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                        if (oGAP_Amt == null || oGAP_Amt == DBNull.Value)
                            oGAP_Amt = 0;

                        dGAP_Amt = Convert.ToDecimal(oGAP_Amt);

                        txtGAPAmt.EditValue = dGAP_Amt;
                    }
                }
                //else
                //{
                //    lciProjInfo.MinSize = new Size(545, 195);
                //    lciProjInfo.MaxSize = new Size(545, 195);
                //} 

               
                lciCOInfo.HideToCustomization();
                lciCOInfo.ShowInCustomizationForm = false;

                //lciProjCostInfo.MaxSize = new Size(540, 195);
                //lciProjCostInfo.MinSize = new Size(540, 195);

                //layoutControlItem3 //Change Order Amount
                //layoutControlItem33 //Total Contract Amount

                if (!lciCOAmt.ShowInCustomizationForm && !layoutControlItem33.ShowInCustomizationForm)
                {
                    lciCOAmt.ShowInCustomizationForm = true;
                    layoutControlItem33.ShowInCustomizationForm = true;
                    lciCOAmt.RestoreFromCustomization(layoutControlItem6, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    //layoutControlItem3.Move(layoutControlItem10, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    layoutControlItem33.RestoreFromCustomization(layoutControlItem10, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                }

                Connection.SQLExecutor.ExecuteNonQuery("exec Proj_Fill_CO_Summary '" + Connection.MLUser + "', " + _PriID.ToString(), Connection.TRConnection);
                daCOSummary.SelectCommand.Parameters["@Username"].Value = Connection.MLUser;
                daCOSummary.SelectCommand.Parameters["@Pri_ID"].Value = _PriID;
                daCOSummary.Fill(dsCOSummary1);

                object oCOAmt = Connection.SQLExecutor.ExecuteScalar("Select SUM(Amount) From working_Proj_CO_Summary Where Username = '" + Connection.MLUser + "' and pri_id = " + _PriID.ToString(), Connection.TRConnection);
                decimal dCOAmt = 0, dContractAmount = 0;
                try { dCOAmt = Convert.ToDecimal(oCOAmt); }
                catch { }
                try { dContractAmount = Convert.ToDecimal(dsSelectedProject1.PROJ_HEADER.Rows[0]["pri_revenue_amt"]); }
                catch { }

                txtCOAmount.EditValue = dCOAmt;
                txtTotalContractAmt.EditValue = dContractAmount + dCOAmt + dGAP_Amt;

                dockManager1.ForceInitialize();
            }
        }

        public string Project
        {
            get { return txtProjName.Text; }
        }

        public string ProjectNumber
        {
            get { return txtProjNum.Text; }
        }

        public string Customer
        {
            get
            {
                string Cust = "";
                object obj = lueCustomer.GetColumnValue("name");
                if (obj != null && obj != DBNull.Value)
                    Cust = obj.ToString();
                return Cust; 
            }
        }

        public string CustomerCode
        {
            get 
            {
                string Cust = "";
                object obj = lueCustomer.GetColumnValue("customer_code");
                if (obj != null && obj != DBNull.Value)
                    Cust = obj.ToString();
                return Cust; 
            }
        }

        private string sLandSubType = "P";
        public string LandSubType
        {
            
            get { return sLandSubType; }
        }

        #region Setups

        private void RunSetups()
        {
            TR_Conn.ConnectionString = Connection.TRConnection;

            uPIG = new PPM_GapCtrl.ucProjInfoGap(Connection, DevXMgr, KCA_Validator);
            uPIG.RefreshGAPStructure += new PPM_GapCtrl.ucProjInfoGap.RefreshGAPStructureDelegate(ucProjInfoGap_RefreshGAPStructure);
            uPIG.Dock = DockStyle.Fill;
            uPIG.Parent = pGapCount;

            _bPPM_Enabled = Convert.ToBoolean(Connection.SQLExecutor.ExecuteScalar(@"select isnull((select Active from SecurityOverride where ID = 1), 0)", Connection.TRConnection));

            SetupFlavour();
            SetupUnits();
            SetupStakeholders();
            
            SetupDatatables();
            SetupSwapSeg();
            SetupWarehouse();
            FillLookups();
            LoadKCAAccess();
            SetupKCAccess();

            SetupUDF();
        }

        private void ucProjInfoGap_RefreshGAPStructure()
        {
            if (RefreshGAPStructure != null)
                RefreshGAPStructure();
        }

        private void SetRevenueBudgetButton()
        {
            lueBillingLevel.Properties.Buttons[1].Visible = true;
        }

        private void SetupFlavour()
        {
           
            lciMasterProjInfo.HideToCustomization();
            lciMasterProjInfo.ShowInCustomizationForm = false;
            lciDevelopmentProjectInfo.HideToCustomization();
            lciDevelopmentProjectInfo.ShowInCustomizationForm = false;
            lciLandType.HideToCustomization();
            lciLandType.ShowInCustomizationForm = false;
            lciArea.HideToCustomization();
            lciArea.ShowInCustomizationForm = false;
            lciAreaUOM.HideToCustomization();
            lciAreaUOM.ShowInCustomizationForm = false;
            lciProjectAllocated.HideToCustomization();
            lciProjectAllocated.ShowInCustomizationForm = false;
            lciNetArea.HideToCustomization();
            lciNetArea.ShowInCustomizationForm = false;
            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    HideHomebuilder();
                    HideLand();
                    HideUnit();
                    HideResourceManagement();
                    HideProcessFlow();
                    navGen.Expanded = true;
                    lciBuildType.HideToCustomization();
                    lciBuildType.ShowInCustomizationForm = false;
                    lciSeg3.HideToCustomization();
                    lciSeg3.ShowInCustomizationForm = false;
                    lciSeg3Code.HideToCustomization();
                    lciSeg3Code.ShowInCustomizationForm = false;
                    //lciHoldbackDue.Move(lciEstCompletion, DevExpress.XtraLayout.Utils.InsertType.Right);

                    int iProjInfoHeight = 300;

                    lciGapCount.HideToCustomization();
                    lciGapCount.ShowInCustomizationForm = false;
                   
                    //545, 307
                    lciProjInfo.MinSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.MinSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.Size = new Size(545, iProjInfoHeight);

                    lciProjCostInfo.MinSize = new Size(540, 260);
                    lciProjCostInfo.MaxSize = new Size(540, 260);
                    lciProjCostInfo.Size = new Size(540, 260);

                    SetRevenueBudgetButton();

                   

                    break;
                case ProjectType.PC_Homebuilder:
                    HideGenCon();
                    HideLand();
                    HideUnit();
                    HideResourceManagement();
                    HideProcessFlow();
                    navHome.Expanded = true;
                    lciDevelopmentProjectInfo.RestoreFromCustomization();
                    lciDevelopmentProjectInfo.ShowInCustomizationForm = true;
                    lciDevelopmentProjectInfo.Move(lciCustInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciStakeholders.Move(lciSiteAddr, DevExpress.XtraLayout.Utils.InsertType.Bottom);  
                    
                    lciProjCostInfo.HideToCustomization();
                    lciProjCostInfo.ShowInCustomizationForm = false;

                    lciGapCount.HideToCustomization();
                    lciGapCount.ShowInCustomizationForm = false;

                    lciTaxProv.HideToCustomization();
                    lciTaxProv.ShowInCustomizationForm = false;

                    gcFlavorInfo.Text = "Homebuilder Project Information";
                    lciEstFrontage.HideToCustomization();
                    lciEstFrontage.ShowInCustomizationForm = false;
                    lciActualFrontage.HideToCustomization();
                    lciActualFrontage.ShowInCustomizationForm = false;
                    lciRoadArea.HideToCustomization();
                    lciRoadArea.ShowInCustomizationForm = false;
                    lciLandUse.HideToCustomization();
                    lciLandUse.ShowInCustomizationForm = false;

                    lciDevelopmentProjectInfo.MinSize = new Size(540, 350);
                    lciDevelopmentProjectInfo.MaxSize = new Size(540, 350);
                    lciDevelopmentProjectInfo.Size = new Size(540, 350);
                    lciProjInfo.MinSize = new Size(560, 225);
                    lciProjInfo.MaxSize = new Size(560, 225);
                    lciProjInfo.Size = new Size(560, 225);

                    

                    break;
                case ProjectType.PC_Land_Construction:
                    HideGenCon();
                    HideHomebuilder();
                    HideUnit();
                    HideResourceManagement();
                    HideProcessFlow();
                    navLand.Expanded = true;
                    lciDevelopmentProjectInfo.RestoreFromCustomization();
                    lciDevelopmentProjectInfo.ShowInCustomizationForm = true;
                    lciDevelopmentProjectInfo.Move(lciCustInfo, DevExpress.XtraLayout.Utils.InsertType.Top);
                    lciStakeholders.Move(lciProjInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciSiteAddr.Move(lciDevelopmentProjectInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);  
                    
                    lciCustInfo.HideToCustomization();
                    lciCustInfo.ShowInCustomizationForm = false;
                    lciProjCostInfo.HideToCustomization();
                    lciProjCostInfo.ShowInCustomizationForm = false;

                    lciGapCount.HideToCustomization();
                    lciGapCount.ShowInCustomizationForm = false;

                    lciPhase.HideToCustomization();
                    lciPhase.ShowInCustomizationForm = false;
                    lciFrontage.HideToCustomization();
                    lciFrontage.ShowInCustomizationForm = false;
                    lciModel.HideToCustomization();
                    lciModel.ShowInCustomizationForm = false;
                    lciElevation.HideToCustomization();
                    lciElevation.ShowInCustomizationForm = false;
                    lciBuildType.HideToCustomization();
                    lciBuildType.ShowInCustomizationForm = false;
                    lciCashFlowLevel.HideToCustomization();
                    lciCashFlowLevel.ShowInCustomizationForm = false;
                    lciTaxProv.HideToCustomization();
                    lciTaxProv.ShowInCustomizationForm = false;
                    lciLandType.RestoreFromCustomization(lciHoldbackDue,DevExpress.XtraLayout.Utils.InsertType.Right);
                    lciLandType.ShowInCustomizationForm = true;
                    lciArea.RestoreFromCustomization();
                    lciArea.ShowInCustomizationForm = true;
                    lciAreaUOM.RestoreFromCustomization(lciArea, DevExpress.XtraLayout.Utils.InsertType.Right);
                    lciAreaUOM.ShowInCustomizationForm = true;

                    lciDevelopmentProjectInfo.MinSize = new Size(540, 500);
                    lciDevelopmentProjectInfo.MaxSize = new Size(540, 500);
                    lciDevelopmentProjectInfo.Size = new Size(540, 500);
                    lciProjInfo.MinSize = new Size(560, 260);
                    lciProjInfo.MaxSize = new Size(560, 260);
                    lciProjInfo.Size = new Size(560, 260);

                    lciStakeholders.Move(lciDevelopmentProjectInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);



                    LandFrame = new ProjectUtilities.Land.Header.Frame(Connection,DevXMgr,_Flavour,sLandSubType);
                    LandFrame.Dock = DockStyle.Fill;
                    LandFrame.Parent = this;
                    layoutControl1.Parent = LandFrame;

                    LD_MarketValue = new LD_RawLandControls.ucMarketValue(Connection, DevXMgr);
                    LD_MarketValue.Dock = DockStyle.Fill;
                    LD_MarketValue.SetReadOnlyMode(_ReadOnly);
                    LD_MarketValue.Parent = dpnlMarketValue;

                    if(LandSubType == "P")
                    {
                        LD_RawLandHolding = new LD_RawLandControls.ucRawLandHolding(Connection, DevXMgr);
                        LD_RawLandHolding.Dock = DockStyle.Fill;
                        LD_RawLandHolding.SetReadOnlyMode(_ReadOnly);
                        LD_RawLandHolding.Parent = dpRawLandHolding;

                        LD_ProjMilestone = new LD_ProjMilestone.ucProjMilestone(Connection, DevXMgr,KCA_Validator);
                        LD_ProjMilestone.Dock = DockStyle.Fill;
                        LD_ProjMilestone.SetReadOnly(_ReadOnly);
                        LD_ProjMilestone.Parent = dpnlProjMilestones;
                    }
                    else
                    {
                        lciProjectAllocated.RestoreFromCustomization();
                        lciProjectAllocated.ShowInCustomizationForm = true;
                        lciNetArea.RestoreFromCustomization(lciProjectAllocated, DevExpress.XtraLayout.Utils.InsertType.Right);
                        lciNetArea.ShowInCustomizationForm = true;

                        LD_AdditionalUseAreas = new LD_RawLandControls.ucAdditionalUseAreas(Connection, DevXMgr);
                        LD_AdditionalUseAreas.Dock = DockStyle.Fill;
                        LD_AdditionalUseAreas.SetReadOnlyMode(_ReadOnly);
                        LD_AdditionalUseAreas.Parent = dpAdditionalUseAreas;

                        LD_Stages = new LD_RawLandControls.ucStages(Connection, DevXMgr);
                        LD_Stages.Dock = DockStyle.Fill;
                        LD_Stages.SetReadOnlyMode(_ReadOnly);
                        LD_Stages.Parent = dpStages;

                        LD_PrevLandUse = new LD_RawLandControls.ucPreviousLandUse(Connection, DevXMgr);
                        LD_PrevLandUse.Dock = DockStyle.Fill;
                        LD_PrevLandUse.SetReadOnly(_ReadOnly);
                        LD_PrevLandUse.Parent = dpPreviousLandUse;

                        LD_ProjAllocated = new LD_RawLandControls.ucProjectAllocated(Connection, DevXMgr);
                        LD_ProjAllocated.Dock = DockStyle.Fill;
                        LD_ProjAllocated.Parent = dpnlProjectsRLH;
                       
                    }
                    

                    //lciSeg3.Move(lciWHSE, DevExpress.XtraLayout.Utils.InsertType.Left);
                    //lciWHSE.Move(lciStart, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    //lciEstCompletion.Move(lciEnd, DevExpress.XtraLayout.Utils.InsertType.Bottom);

                    //layoutControl5.AddItem(new DevExpress.XtraLayout.EmptySpaceItem(), lciHoldbackDue, DevExpress.XtraLayout.Utils.InsertType.Right);

                    dsLandSubType1.Clear();
                    daLandSubType.Fill(dsLandSubType1);

                    DataTable dtUOM = new DataTable("dtUOM");
                    dtUOM.Columns.Add("ID", typeof(string));
                    dtUOM.Columns.Add("Desc", typeof(string));

                    dtUOM.Rows.Add(new object[] { "I", "Imperial" });
                    dtUOM.Rows.Add(new object[] { "M", "Metric" });

                    lueAreaUOM.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "UOM"));
                    lueAreaUOM.Properties.DataSource = dtUOM;
                    lueAreaUOM.Properties.DisplayMember = "Desc";
                    lueAreaUOM.Properties.ValueMember = "ID";

                    LoadSeg3();

                    
                    break;
                case ProjectType.PC_Unit_Construction:
                    HideGenCon();
                    HideHomebuilder();
                    HideLand();
                    HideResourceManagement();
                    HideProcessFlow();
                    navUnit.Expanded = true;
                    lciCustInfo.HideToCustomization();
                    lciCustInfo.ShowInCustomizationForm = false;
                    lciTaxProv.HideToCustomization();
                    lciTaxProv.ShowInCustomizationForm = false;
                                       

                    lciTaxDefaults.Move(lciProjInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciStakeholders.Move(lciProjCostInfo, DevExpress.XtraLayout.Utils.InsertType.Top);
                    lciStakeholders.Move(lciProjCostInfo, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciSiteAddr.Move(lciStakeholders, DevExpress.XtraLayout.Utils.InsertType.Top);  
                    
                    lciSeg3.HideToCustomization();
                    lciSeg3.ShowInCustomizationForm = false;
                    lciSeg3Code.HideToCustomization();
                    lciSeg3Code.ShowInCustomizationForm = false;
                    lciBuildType.HideToCustomization();
                    lciBuildType.ShowInCustomizationForm = false;

                    lciGapCount.HideToCustomization();
                    lciGapCount.ShowInCustomizationForm = false;

                    //lciHoldbackDue.Move(lciEstCompletion, DevExpress.XtraLayout.Utils.InsertType.Right);

                    lciProjInfo.MinSize = new Size(560, 280);
                    lciProjInfo.MaxSize = new Size(560, 280);
                    lciProjInfo.Size = new Size(560, 280);

                   

                    break;

                    //
                case ProjectType.PC_Software_Development:
                    SetupResourceManagement();
                    SetupProcessFlow();
                    HideHomebuilder();
                    HideLand();
                    HideUnit();
                    navGen.Expanded = true;
                    navGen.Caption = "Software Development Analysis ";
                    lciBuildType.HideToCustomization();
                    lciBuildType.ShowInCustomizationForm = false;
                    lciSeg3.HideToCustomization();
                    lciSeg3.ShowInCustomizationForm = false;
                    lciSeg3Code.HideToCustomization();
                    lciSeg3Code.ShowInCustomizationForm = false;

                    lciTaxProv.HideToCustomization();
                    lciTaxProv.ShowInCustomizationForm = false;

                    //lciHoldbackDue.Move(lciEstCompletion, DevExpress.XtraLayout.Utils.InsertType.Right);

                    lciSiteAddr.HideToCustomization();
                    lciSiteAddr.ShowInCustomizationForm = false;

                    iProjInfoHeight = 230;

                    if (!_bPPM_Enabled)
                    {
                        lciGapCount.HideToCustomization();
                        lciGapCount.ShowInCustomizationForm = false;
                    }
                    else
                    {
                        iProjInfoHeight = 260;  

                        lciGAPAmount.RestoreFromCustomization(lciCOAmt, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                        lciGAPAmount.ShowInCustomizationForm = true;
                                               

                        lciCustType.RestoreFromCustomization(lciCustomer, DevExpress.XtraLayout.Utils.InsertType.Top);
                        lciCustType.ShowInCustomizationForm = true;

                        lciInternalType.RestoreFromCustomization(lciCustType, DevExpress.XtraLayout.Utils.InsertType.Right);
                        lciInternalType.ShowInCustomizationForm = true;

                        lciCustInfo.MinSize = new Size(540, 260);
                        lciCustInfo.MaxSize = new Size(540, 260);
                        lciCustInfo.Size = new Size(540, 260);

                        lciProjCostInfo.MinSize = new Size(540, 290);
                        lciProjCostInfo.MaxSize = new Size(540, 290);
                        lciProjCostInfo.Size = new Size(540, 290);   

                        
                        dsCustomerType1.Clear();
                        daCustomerType.Fill(dsCustomerType1);

                        dsInternalType1.Clear();
                        daInternalType.Fill(dsInternalType1);
                    }
                    
                    //545, 307
                    lciProjInfo.MinSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.MaxSize = new Size(560, iProjInfoHeight);
                    lciProjInfo.Size = new Size(560, iProjInfoHeight);
                                       
                    SetRevenueBudgetButton();

                   
                                        
                    break;
            }
        }

        private void SetDockpanelVisibility()
        {
            dockManager1.ForceInitialize();
            if (!navUnit.Visible)
            {
                pUnitSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    dpnlAddDates.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalUseAreas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpStages.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpRawLandHolding.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpPreviousLandUse.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjectsRLH.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlLotSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlMarketValue.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjMilestones.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    panelContainer1.ActiveChild = this.dpnlAnalysis;
                    break;
                case ProjectType.PC_Homebuilder:
                    dpnlAddDates.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalUseAreas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpStages.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpRawLandHolding.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpPreviousLandUse.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjectsRLH.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlLotSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlMarketValue.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjMilestones.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                    break;
                case ProjectType.PC_Land_Construction:
                    
                    dpnlAnalysis.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpChangeOrders.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                    if (LandSubType == "P")
                    {

                        dpAdditionalUseAreas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpStages.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpPreviousLandUse.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpnlProjectsRLH.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        //lciPurchaseDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }
                    else
                    {
                        //dpAdditionalInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpRawLandHolding.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpnlAddDates.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpnlProjMilestones.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        dpnlLotSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;//hide the container as no panels inside are visible
                        panelContainer3.ActiveChild = this.dpStakeholders;

                    }

                    break;
                case ProjectType.PC_Unit_Construction:
                    dpnlAddDates.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalUseAreas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpStages.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpRawLandHolding.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpPreviousLandUse.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlMarketValue.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjectsRLH.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlLotSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjMilestones.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                    break;

                //
                case ProjectType.PC_Software_Development:
                    dpnlAddDates.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalUseAreas.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpStages.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpRawLandHolding.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpPreviousLandUse.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjectsRLH.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlLotSummary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlMarketValue.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpAdditionalInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    dpnlProjMilestones.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

                    break;
            }
        }


        private bool _bAcctSegConfigured = true;
        private void LoadSeg3()
        {
            string sSelect = "select isnull(PROFIT_CENTER_SEG,3) from SO_SETUP";
            object obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            int profCenterSeg = 3;
            try
            {
                profCenterSeg = Convert.ToInt32(obj);
            }
            catch { }

            if (profCenterSeg == 0)
            {
                _bAcctSegConfigured = false;
                Popup.ShowPopup("Account segments have not been configured for land construction.");
            }

            sSelect = "select isnull(seg_"+profCenterSeg.ToString()+"_desc,'') from gl_setup";
            obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            if (obj != null && obj != DBNull.Value)
            {
                lciSeg3.Text = obj.ToString();
                lciSeg3Code.Text = obj.ToString();
            }
            daSeg3.SelectCommand.CommandText = "SELECT DISTINCT a.SEG_" + profCenterSeg.ToString() + " AS Code, m.SEGMENT_DESC AS Description " +
                    "FROM GL_ACCOUNTS a "+
                    "LEFT OUTER JOIN GL_SEGMENT_SETUP m ON m.SEGMENT_VALUE = a.SEG_" + profCenterSeg.ToString() + " AND m.SEGMENT_NUMBER = " + profCenterSeg.ToString() + " " +
                    "ORDER BY a.SEG_" + profCenterSeg.ToString() + " ";

        }

        private void HideGenCon()
        {
            navGen.Visible = false;
        }

        private void HideHomebuilder()
        {
            navHome.Visible = false;
        }

        private void HideLand()
        {
            navLand.Visible = false;
        }
        private void HideProcessFlow()
        {
            dpnProcessFlow.Close();
        }
        private void HideResourceManagement()
        {
            dpnResourceManagement.Close();
        }

        private void HideUnit()
        {
            navUnit.Visible = false;
            lciTaxDefaults.HideToCustomization();
            lciTaxDefaults.ShowInCustomizationForm = false;
        }

        private void SetupUnits()
        {
            if( Connection.CountryCode.Equals( "U" ) )
            {
                lciProv.Text = "State";
                lciPostalCode.Text = "Zip Code";
                lciProv2.Text = "State";
                lciPostalCode2.Text = "Zip Code";

                lciGSTType.Text = "Tax 1";
                lciGST.Text = "Tax 1";
                lciPSTType.Text = "Tax 2";
                lciPST.Text = "Tax 2";
            }
        }

        private void SetupStakeholders()
        {
            Stakeholders = new ucStakeholderVG(Connection, DevXMgr, StakeholderType.Project, _Flavour); //new ucStakeholder(Connection, DevXMgr, StakeholderType.Project, _Flavour);
            Stakeholders.Dock = DockStyle.Fill;
            Stakeholders.Parent = dpStakeholders; //pStakeholders;
        }

        private void SetupProcessFlow()
        {
            ProcessFlow = new PPM_SOW.ucWorkFlow(Connection, DevXMgr, _PriID);
            ProcessFlow.Parent = dpnProcessFlow;
            ProcessFlow.Dock = DockStyle.Fill;
        }

        private void SetupResourceManagement()
        {
            ResourceManagement = new PPM_SOW.ucResourceMgmt(Connection, DevXMgr, _PriID);
            ResourceManagement.Parent = dpnResourceManagement;
            ResourceManagement.Dock = DockStyle.Fill;
            ResourceManagement.OnGetValueChanged += new PPM_SOW.ucResourceMgmt.GetValueChangedHandler(ResourceManagement_OnGetValueChanged);
        }

        private void ResourceManagement_OnGetValueChanged(object source, EventArgs e)
        {
            if (ProcessFlow != null)
            {
                ProcessFlow.RequestDataRefresh();
            }
        }

        private void SetupDatatables()
        {
            DataTable dtBuildType = new DataTable("dtBuildType");
            dtBuildType.Columns.Add("ID", typeof(string));
            dtBuildType.Columns.Add("Desc", typeof(string));

            dtBuildType.Rows.Add(new object[] { "S", "Spec" });
            dtBuildType.Rows.Add(new object[] { "H", "Show Home" });
            dtBuildType.Rows.Add(new object[] { "T", "TPS" });

            lueBuildType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Build Type"));
            lueBuildType.Properties.DataSource = dtBuildType;
            lueBuildType.Properties.DisplayMember = "Desc";
            lueBuildType.Properties.ValueMember = "ID";

            DataTable dtStatus = new DataTable("dtStatus");
            dtStatus.Columns.Add("ID", typeof(string));
            dtStatus.Columns.Add("Desc", typeof(string));

            dtStatus.Rows.Add(new object[] { "A", "Active" });
            dtStatus.Rows.Add(new object[] { "L", "Closed" });
            dtStatus.Rows.Add(new object[] { "C", "Complete" });
            dtStatus.Rows.Add(new object[] { "X", "Cancelled" });
            

            lueStatus.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Status"));
            lueStatus.Properties.DataSource = dtStatus;
            lueStatus.Properties.DisplayMember = "Desc";
            lueStatus.Properties.ValueMember = "ID";

            DataTable dtBilling = new DataTable("dtBilling");
            dtBilling.Columns.Add("ID", typeof(string));
            dtBilling.Columns.Add("Desc", typeof(string));

            dtBilling.Rows.Add(new object[]{ "P", "Project" });
            dtBilling.Rows.Add(new object[]{ "L", "Level 1" });
            dtBilling.Rows.Add(new object[] { "T", "Time Ticket" });

            lueBillingLevel.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Billing Level"));
            lueBillingLevel.Properties.DataSource = dtBilling;
            lueBillingLevel.Properties.DisplayMember = "Desc";
            lueBillingLevel.Properties.ValueMember = "ID";

            DataTable dtBillType = new DataTable("dtBillType");
            dtBillType.Columns.Add("ID", typeof(string));
            dtBillType.Columns.Add("Desc", typeof(string));

            dtBillType.Rows.Add(new object[] { "B", "Billable" });
            dtBillType.Rows.Add(new object[] { "N", "Non-Billable" });

            lueBillType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Bill Type"));
            lueBillType.Properties.DataSource = dtBillType;
            lueBillType.Properties.DisplayMember = "Desc";
            lueBillType.Properties.ValueMember = "ID";

            DataTable dtCosting = new DataTable("dtCosting");
            dtCosting.Columns.Add("ID", typeof(string));
            dtCosting.Columns.Add("Desc", typeof(string));
            
            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    dtCosting.Rows.Add(new object[] { "G", "General Construction Project" });
                    break;
                case ProjectType.PC_Homebuilder:
                    dtCosting.Rows.Add(new object[] { "H", "Homebuilder Construction Project" });
                    break;
                case ProjectType.PC_Land_Construction:
                    dtCosting.Rows.Add(new object[] { "L", "Land Construction Project" });
                    break;
                case ProjectType.PC_Unit_Construction:
                    dtCosting.Rows.Add(new object[] { "U", "Unit Construction Project" });
                    break;
                case ProjectType.PC_Software_Development:
                    dtCosting.Rows.Add(new object[] { "S", "Software Development Project" });
                    break;
            }

            lueCostingType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Costing Type"));
            lueCostingType.Properties.DataSource = dtCosting;
            lueCostingType.Properties.DisplayMember = "Desc";
            lueCostingType.Properties.ValueMember = "ID";


            //DataTable dtContract = new DataTable("dtContract");
            //dtContract.Columns.Add("ID", typeof(string));
            //dtContract.Columns.Add("Desc", typeof(string));

            //dtContract.Rows.Add(new object[] { "F", "Fixed Price" });
            //dtContract.Rows.Add(new object[] { "C", "Cost Plus" });
            //dtContract.Rows.Add(new object[] { "D", "Design Build" });
            //dtContract.Rows.Add(new object[] { "M", "Construction Management" });

            //lueContractType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Contract Type"));
            //lueContractType.Properties.DataSource = dtContract;
            //lueContractType.Properties.DisplayMember = "Desc";
            //lueContractType.Properties.ValueMember = "ID";

            DataTable dtUOM = new DataTable("dtUOM");
            dtUOM.Columns.Add("ID", typeof(string));
            dtUOM.Columns.Add("Desc", typeof(string));

            dtUOM.Rows.Add(new object[] { "I", "Imperial" });
            dtUOM.Rows.Add(new object[] { "M", "Metric" });

            lueFrontageUOM.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "UOM"));
            lueFrontageUOM.Properties.DataSource = dtUOM;
            lueFrontageUOM.Properties.DisplayMember = "Desc";
            lueFrontageUOM.Properties.ValueMember = "ID";

            DataTable dtBillingType = new DataTable("dtBillingType");
            dtBillingType.Columns.Add("Code", typeof(string));
            dtBillingType.Columns.Add("Desc", typeof(string));

            dtBillingType.Rows.Add(new object[] { "C", "Contract" });
            dtBillingType.Rows.Add(new object[] { "E", "Estimated" });
            luBillingType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Billing Type"));
            luBillingType.Properties.DataSource = dtBillingType;
            luBillingType.Properties.DisplayMember = "Desc";
            luBillingType.Properties.ValueMember = "Code";
            //
        }

        private void SetupSwapSeg()
        {
            string sSelect = "select isnull(clear_req,'F') from gl_setup";
            //if (Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection).ToString().ToUpper().Trim() == "T")
            //{
                //sSelect = "select clear_seg from gl_setup";
                sSelect = "select isnull(clear_seg,2) from gl_setup";
                object obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                if (obj != null && obj.GetType() != typeof(DBNull))
                {
                    int Column = Convert.ToInt32(obj);
                    string ColumnName = "SEG_" + Column + "_DESC";

                    string sSecurity = "";
                    sSelect = "select count(*) from working_mluser_supervisor wms " +
                        "left outer join warehouse_security ws on wms.mluser=ws.mluser " +
                        "where wms.username='" + Connection.MLUser + "' and ws_id is null";
                    object oResult = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);

                    if (Convert.ToInt32(oResult) == 0)
                    {
                        sSecurity = " join warehouse w on w.whse_div = a.seg_" + Column + " " +
                            "join warehouse_security ws on ws.whse_id=w.whse_id " +
                            "join mluser m on m.name = ws.mluser " +
                            "join working_mluser_supervisor s ON s.mluser = m.name " +
                            "where s.username = '" + Connection.MLUser + "' ";
                    }

                    sSelect = "select " + ColumnName + " from gl_setup";
                    daSwapSeg.SelectCommand.CommandText = "select distinct a.seg_" + Column + " [Code], g.SEGMENT_DESC [Description] " +
                                                "from gl_accounts a " +
                                                "left outer join gl_segment_setup g on g.SEGMENT_VALUE = a.seg_" + Column + " " +
                                                "and SEGMENT_NUMBER = " + Column + " " +
                                                sSecurity +
                                                "order by a.seg_" + Column;
                    dsSwapSeg11.Clear();
                    daSwapSeg.Fill(dsSwapSeg11);

                    obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                    if (obj != null && obj.GetType() != typeof(DBNull))
                    {
                        lciDivision.Text = obj.ToString();
                        lciDivision.ShowInCustomizationForm = true;
                        lciDivision2.Text = obj.ToString();
                        lciDivision2.ShowInCustomizationForm = true;
                    }
                }
            //}
            //else
            //{
            //    lciDivision.HideToCustomization();
            //    lciDivision.ShowInCustomizationForm = false;
            //}
        }

        private void SetupWarehouse()
        {
            string sSelect = "select count(*) from working_mluser_supervisor wms " +
                "left outer join warehouse_security ws on wms.mluser=ws.mluser " +
                "where wms.username='" + Connection.MLUser + "' and ws_id is null";
            object oResult = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);

            if (Convert.ToInt32(oResult) == 0)
            {
                daWarehouse.SelectCommand.CommandText = "select distinct w.whse_id, warehouse, description " +
                    "from warehouse w " +
                    "join warehouse_security ws on ws.whse_id=w.whse_id " +
                    "join mluser m on m.name = ws.mluser " +
                    "join working_mluser_supervisor s ON s.mluser = m.name " +
                    "where s.username= '" + Connection.MLUser + "' " +
                    "order by description";
            }
            dsWarehouse11.Clear();
            daWarehouse.Fill(dsWarehouse11);
        }

        private void FillLookups()
        {
            dsCategory11.Clear();
            dsClass11.Clear();
            dsCustomers11.Clear();
            dsBidType1.Clear();
            dsGST1.Clear();
            dsPST1.Clear();
            dsStateProv1.Clear();
            dsCOType1.Clear();
            dsCOReason1.Clear();
            ds_lueAdditionalDates1.Clear();

            daCategory.Fill(dsCategory11);
            daClass.Fill(dsClass11);
            daCustomers.Fill(dsCustomers11);
            daBidType.Fill(dsBidType1);
            daGST.Fill(dsGST1);
            daPST.Fill(dsPST1);
            daStateProv.Fill(dsStateProv1);
            daCOType.Fill(dsCOType1);
            daCOReason.Fill(dsCOReason1);
            da_lueAdditionalDates.Fill(ds_lueAdditionalDates1);

            if (_Flavour == ProjectType.PC_Land_Construction)
            {
                dsGeographicArea1.Clear();
                dsRegions1.Clear();
                dsMunicipality1.Clear();
                dsCommunity1.Clear();
                dsLandUse1.Clear();
                dsCashFlow1.Clear();
                dsSeg31.Clear();

                daGeographicArea.Fill(dsGeographicArea1);
                daRegions.Fill(dsRegions1);
                daMunicipality.Fill(dsMunicipality1);
                daCommunity.Fill(dsCommunity1);
                daLandUse.Fill(dsLandUse1);
                daCashFlow.Fill(dsCashFlow1);
                if( _bAcctSegConfigured )
                    daSeg3.Fill(dsSeg31);
            }
            else if (_Flavour == ProjectType.PC_General_Construction)
            {
                dsTaxProvince1.Clear();
                daTaxProvince.Fill(dsTaxProvince1);
            }
            daCompanies.Fill(dsCompanies1);

            dsSuperProject1.Clear();
            daSuperProject.Fill(dsSuperProject1);
            
        }

        #endregion

        #region ReadOnly

        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;
            //SetEstimateReadOnly(ReadOnly);
            SetProjectInfoReadOnly(ReadOnly);
            SetSiteAddressReadOnly(ReadOnly);
            SetCustomerInfoReadOnly(ReadOnly);
            SetCostingInfoReadOnly(ReadOnly);
            Stakeholders.SetReadOnly(ReadOnly);
            SetAnalysisReadOnly(ReadOnly);
            SetTaxDefaults(ReadOnly);
            meExtDesc.Properties.ReadOnly = ReadOnly;

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    SetGenConReadOnly(ReadOnly);
                    break;
                case ProjectType.PC_Homebuilder:
                    SetHomeConReadOnly(ReadOnly);
                    break;
                case ProjectType.PC_Land_Construction:
                    SetLandConReadOnly(ReadOnly);
                    break;
                case ProjectType.PC_Unit_Construction:
                    SetUnitConReadOnly(ReadOnly);
                    break;
                case ProjectType.PC_Software_Development:
                    ProcessFlow.SwitchGridEnabled(!ReadOnly);
                    ResourceManagement.SwitchGridEnabled(!ReadOnly);
                    break;
            }

            dnProject.Buttons.EndEdit.Enabled = !ReadOnly;
            dnProject.Buttons.CancelEdit.Enabled = !ReadOnly;
            lueBillingLevel.Properties.Buttons[0].Enabled = !ReadOnly;

            gcAdditionalDates.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcAdditionalDates.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;
            gvAdditionalDates.OptionsBehavior.Editable = !ReadOnly;
            

            //for some reason this break's databinding
            //btnLoadAll.Enabled = !ReadOnly;
            //for some reason this break's databinding
            //btnLoadSelected.Enabled = !ReadOnly;

            meGeneralComments.Properties.ReadOnly = ReadOnly;
        }

        private void SetAnalysisReadOnly(bool ReadOnly)
        {
            //txtRevenue.Properties.ReadOnly = ReadOnly;
            //txtCost.Properties.ReadOnly = ReadOnly;
            //txtGMA.Properties.ReadOnly = ReadOnly;
            //txtGMP.Properties.ReadOnly = ReadOnly;

            //txtIEquip.Properties.ReadOnly = ReadOnly;
            //txtILabor.Properties.ReadOnly = ReadOnly;
            //txtIMaterial.Properties.ReadOnly = ReadOnly;
            //txtIOther.Properties.ReadOnly = ReadOnly;
            //txtITotal.Properties.ReadOnly = ReadOnly;

            //txtEEquip.Properties.ReadOnly = ReadOnly;
            //txtELabor.Properties.ReadOnly = ReadOnly;
            //txtEMaterial.Properties.ReadOnly = ReadOnly;
            //txtEOther.Properties.ReadOnly = ReadOnly;
            //txtETotal.Properties.ReadOnly = ReadOnly;
        }

        private void SetTaxDefaults(bool ReadOnly)
        {
            radGST.Properties.ReadOnly = ReadOnly;
            radPST.Properties.ReadOnly = ReadOnly;
            lueGST.Properties.ReadOnly = ReadOnly;
            luePST.Properties.ReadOnly = ReadOnly;
        }

        private void SetEstimateReadOnly(bool ReadOnly)
        {
            txtEstName.Properties.ReadOnly = ReadOnly;
            txtEstNo.Properties.ReadOnly = ReadOnly;
            txtEstRevDesc.Properties.ReadOnly = ReadOnly;
            txtEstRevNo.Properties.ReadOnly = ReadOnly;
        }

        private void SetProjectInfoReadOnly(bool ReadOnly)
        {
            txtProjName.Properties.ReadOnly = ReadOnly;
            chkBillable.Properties.ReadOnly = ReadOnly;
            txtProjNum.Properties.ReadOnly = true;// ReadOnly;
            lueStatus.Properties.ReadOnly = true;// ReadOnly;
            lueDivision.Properties.ReadOnly = true;// ReadOnly;
            lueDivision2.Properties.ReadOnly = true;// ReadOnly;
            lueSeg3.Properties.ReadOnly = true;// ReadOnly;
            lueSeg3Code.Properties.ReadOnly = true;
            lueWHSE.Properties.ReadOnly = true;// ReadOnly;
            lueCategory.Properties.ReadOnly = true;// ReadOnly;
            lueClass.Properties.ReadOnly = ReadOnly;
            deStart.Properties.ReadOnly = ReadOnly;
            deEstComp.Properties.ReadOnly = ReadOnly;
            deEstComp.Properties.ReadOnly = ReadOnly;
            lueCOType.Properties.ReadOnly = true;// ReadOnly;
            lueBillType.Properties.ReadOnly = true;//ReadOnly;
            lueReason.Properties.ReadOnly = true;//ReadOnly;
            memoReason.Properties.ReadOnly = true;//ReadOnly;
            deCompletionDate.Properties.ReadOnly = ReadOnly; //true;
            deHoldbackDue.Properties.ReadOnly = ReadOnly;
            beBaseFolder.Properties.ReadOnly = ReadOnly;
            luSuperProject.Properties.ReadOnly = ReadOnly;
            uPIG.SetEnabled(!ReadOnly);
            luTaxprovince.Properties.ReadOnly = true;
        }

        private void SetSiteAddressReadOnly(bool ReadOnly)
        {
            txtLocation.Properties.ReadOnly = ReadOnly;
            meProjAddr.Properties.ReadOnly = ReadOnly;
            txtSiteCity.Properties.ReadOnly = ReadOnly;
            lueStateProv.Properties.ReadOnly = ReadOnly;
            txtSitePostal.Properties.ReadOnly = ReadOnly;
        }

        private void SetCustomerInfoReadOnly(bool ReadOnly)
        {
            //lueCustomer.Properties.ReadOnly = ReadOnly;
            //txtAddr1.Properties.ReadOnly = ReadOnly;
            //txtAddr2.Properties.ReadOnly = ReadOnly;
            //txtAddr3.Properties.ReadOnly = ReadOnly;
            //txtCity.Properties.ReadOnly = ReadOnly;
            //txtProv.Properties.ReadOnly = ReadOnly;
            //txtPostal.Properties.ReadOnly = ReadOnly;

            lueCustType.Properties.ReadOnly = ReadOnly;
            lueInternalType.Properties.ReadOnly = ReadOnly;
        }

        private void SetCostingInfoReadOnly(bool ReadOnly)
        {
            //lueBidType.Properties.ReadOnly = ReadOnly;
            //lueCostingType.Properties.ReadOnly = ReadOnly;
            lueContractType.Properties.ReadOnly = ReadOnly;
            txtCustFile.Properties.ReadOnly = ReadOnly;
            txtContractAmt.Properties.ReadOnly = ReadOnly;
            lueBillingLevel.Properties.ReadOnly = ReadOnly;
            luBillingType.Properties.ReadOnly = ReadOnly;
            chkUseContractTemp.Properties.ReadOnly = ReadOnly;
            txtProjRef1.Properties.ReadOnly = ReadOnly;
            txtProjRef2.Properties.ReadOnly = ReadOnly;
            txtProjRef3.Properties.ReadOnly = ReadOnly;
        }

        private void SetGenConReadOnly(bool ReadOnly)
        {
        }

        private void SetUnitConReadOnly(bool ReadOnly)
        {
        }

        private void SetHomeConReadOnly(bool ReadOnly)
        {

        }

        private void SetLandConReadOnly(bool ReadOnly)
        {
            
            lueGeographicArea.Properties.ReadOnly = ReadOnly;
            lueRegion.Properties.ReadOnly = ReadOnly;
            lueMunicipality.Properties.ReadOnly = ReadOnly;
            lueCommunity.Properties.ReadOnly = ReadOnly;
            lueLandUse.Properties.ReadOnly = ReadOnly;
            teExternalReference.Properties.ReadOnly = ReadOnly;
            lueFrontageUOM.Properties.ReadOnly = ReadOnly;
            teEstimatedFrontage.Properties.ReadOnly = ReadOnly;
            //teActualFrontage.Properties.ReadOnly = ReadOnly;
            teRoadArea.Properties.ReadOnly = ReadOnly;
            lueCashFlow.Properties.ReadOnly = ReadOnly;
            luAdminCompany.Properties.ReadOnly = ReadOnly;
            luAdminProject.Properties.ReadOnly = ReadOnly;
            teArea.Properties.ReadOnly = ReadOnly;
            lueAreaUOM.Properties.ReadOnly = ReadOnly;
            if (LD_AdditionalUseAreas != null)
                LD_AdditionalUseAreas.SetReadOnlyMode(ReadOnly);
            if (LD_RawLandHolding != null)
                LD_RawLandHolding.SetReadOnlyMode(ReadOnly);
            if (LD_ProjMilestone != null)
                LD_ProjMilestone.SetReadOnly(ReadOnly);
            if (LD_Stages != null)
                LD_Stages.SetReadOnlyMode(ReadOnly);
            if (LD_MarketValue != null)
                LD_MarketValue.SetReadOnlyMode(ReadOnly);
            if (LD_PrevLandUse != null)
                LD_PrevLandUse.SetReadOnly(ReadOnly);
        }
        #endregion

        private void dnProject_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem32.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem71.AppearanceItemCaption.ForeColor = Color.Black;
            lciLandUse.AppearanceItemCaption.ForeColor = Color.Black;
            layoutControlItem75.AppearanceItemCaption.ForeColor = Color.Black;
            lciEstFrontage.AppearanceItemCaption.ForeColor = Color.Black;
            lciActualFrontage.AppearanceItemCaption.ForeColor = Color.Black;
            lciRoadArea.AppearanceItemCaption.ForeColor = Color.Black;
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (Valid())
                {
                    Stakeholders.SaveStakeholders();
                    BindingContext[dsSelectedProject1.PROJ_HEADER].EndCurrentEdit();
                    daSelectedProject.Update(dsSelectedProject1);
                    if (_Flavour == ProjectType.PC_Land_Construction)
                    {
                        lueGeographicArea.BindingManager.EndCurrentEdit();
                        daProjDevInfo.Update(dsProjDevInfo1);
                    }
                    else if (_Flavour == ProjectType.PC_Software_Development && _bPPM_Enabled)
                    {
                        object oCustType = lueCustType.EditValue;
                        if (oCustType == null || oCustType == DBNull.Value)
                            oCustType = "null";
                        object oIntType = lueInternalType.EditValue;
                        if (oIntType == null || oIntType == DBNull.Value)
                            oIntType = "null";
                        string sSQL = @"update proj_header 
                            set proj_customer_type_id="+oCustType+@",
                                proj_internal_type_id=" + oIntType + @"
                            where pri_id=" +_PriID;
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                    }

                    Connection.SQLExecutor.ExecuteNonQuery("exec RE_LD_Sync_Admin_Project " + _PriID.ToString(),
                        Connection.TRConnection);

                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
            {
                Stakeholders.CancelSaveStakeholders();
                dsSelectedProject1BindingSource.CancelEdit();

                if (_Flavour == ProjectType.PC_Software_Development && _bPPM_Enabled)
                {
                    LoadCustomerType();
                }
            }
        }

        private void LoadCustomerType()
        {
            string sSQL = @"select proj_customer_type_id, proj_internal_type_id from proj_header where pri_id=" + _PriID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSQL, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        lueCustType.EditValue = dr["proj_customer_type_id"];
                        lueInternalType.EditValue = dr["proj_internal_type_id"];
                    }
                }
            }
        }

        private bool Valid()
        {
            bool Valid = true;

            //if (Stakeholders.lueProjectManager.EditValue == null || Stakeholders.lueProjectManager.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueProjectManager.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Project manager required.");
            //    return false;
            //}
            //if (Stakeholders.lueEngineer.EditValue == null || Stakeholders.lueEngineer.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueEngineer.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Engineer required.");
            //    return false;
            //}
            //if (Stakeholders.lueSalesperson.EditValue == null || Stakeholders.lueSalesperson.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueSalesperson.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Salesperson required.");
            //    return false;
            //}
            //if (Stakeholders.lueGeneralContractor.EditValue == null || Stakeholders.lueGeneralContractor.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueGeneralContractor.Focus();
            //    Popup.ShowPopup("Project Stakeholders - General contractor required.");
            //    return false;
            //}
            //if (Stakeholders.lueAccountant.EditValue == null || Stakeholders.lueAccountant.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueAccountant.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Accountant required.");
            //    return false;
            //}
            //if (Stakeholders.lueEstimator.EditValue == null || Stakeholders.lueEstimator.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueEstimator.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Estimator required.");
            //    return false;
            //}
            //if (Stakeholders.lueSiteForeman.EditValue == null || Stakeholders.lueSiteForeman.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueSiteForeman.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Site foreman required.");
            //    return false;
            //}
            //if (Stakeholders.lueArchitect.EditValue == null || Stakeholders.lueArchitect.EditValue == DBNull.Value)
            //{
            //    Stakeholders.lueArchitect.Focus();
            //    Popup.ShowPopup("Project Stakeholders - Architect required.");
            //    return false;
            //}
            //if (_Flavour != ProjectType.PC_Land_Construction)
            //{
            //    if (Stakeholders.lueCustContact.EditValue == null || Stakeholders.lueCustContact.EditValue == DBNull.Value)
            //    {
            //        Stakeholders.lueCustContact.Focus();
            //        Popup.ShowPopup("Project Stakeholders - Customer contact required.");
            //        return false;
            //    }
            //}

            if (deCompletionDate.EditValue != null && deCompletionDate.EditValue != DBNull.Value)
            {
                if (deStart.EditValue != null && deStart.EditValue != DBNull.Value)
                {
                    DateTime dtStartDateNoTime = new DateTime(deStart.DateTime.Year, deStart.DateTime.Month, deStart.DateTime.Day);
                    if (dtStartDateNoTime.CompareTo(deCompletionDate.DateTime) > 0)
                    {
                        Popup.ShowPopup("Completion Date cannot come before the start date.");
                        return false;
                    }
                }
            }

            if (_Flavour == ProjectType.PC_Land_Construction)
                Valid = ValidateLand();
            return Valid;
        }

        private bool ValidateLand()
        {
            bool valid = true;          

            if (lueGeographicArea.EditValue == null || lueGeographicArea.EditValue == DBNull.Value)
            {
                layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Red;
                lueGeographicArea.Focus();
                Popup.ShowPopup("Development Project Information - Geographic area required.");
                return false;
            }
            if (lueRegion.EditValue == null || lueRegion.EditValue == DBNull.Value)
            {
                layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Red;
                lueRegion.Focus();
                Popup.ShowPopup("Development Project Information - Region required.");
                return false;
            }
            if (lueMunicipality.EditValue == null || lueMunicipality.EditValue == DBNull.Value)
            {
                layoutControlItem32.AppearanceItemCaption.ForeColor = Color.Red;
                lueMunicipality.Focus();
                Popup.ShowPopup("Development Project Information - Municipality required.");
                return false;
            }
            if (lueCommunity.EditValue == null || lueCommunity.EditValue == DBNull.Value)
            {
                layoutControlItem71.AppearanceItemCaption.ForeColor = Color.Red;
                lueCommunity.Focus();
                Popup.ShowPopup("Development Project Information - Community required.");
                return false;
            }
            if (lueLandUse.EditValue == null || lueLandUse.EditValue == DBNull.Value)
            {
                lciLandUse.AppearanceItemCaption.ForeColor = Color.Red;
                lueLandUse.Focus();
                Popup.ShowPopup("Development Project Information - Land Use required.");
                return false;
            }            
            if (lueFrontageUOM.EditValue == null || lueFrontageUOM.EditValue == DBNull.Value)
            {
                layoutControlItem75.AppearanceItemCaption.ForeColor = Color.Red;
                lueFrontageUOM.Focus();
                Popup.ShowPopup("Development Project Information - Frontage UOM required.");
                return false;
            }
            if (ObjectToDouble(teEstimatedFrontage.EditValue,0) < 0  )
            {
                lciEstFrontage.AppearanceItemCaption.ForeColor = Color.Red;
                teEstimatedFrontage.Focus();
                Popup.ShowPopup("Development Project Information - Estimated frontage cannot be less than 0.");
                return false;
            }
            //if (ObjectToDouble(teActualFrontage.EditValue, 0) < 0)
            //{
            //    lciActualFrontage.AppearanceItemCaption.ForeColor = Color.Red;
            //    teActualFrontage.Focus();
            //    Popup.ShowPopup("Development Project Information - Actual frontage cannot be less than 0.");
            //    return false;
            //}
            if (ObjectToDouble(teRoadArea.EditValue, 0) < 0)
            {
                lciRoadArea.AppearanceItemCaption.ForeColor = Color.Red;
                teRoadArea.Focus();
                Popup.ShowPopup("Development Project Information - Road area cannot be less than 0.");
                return false;
            }
            object result = Connection.SQLExecutor.ExecuteScalar("select isnull(sum(TotalArea),0)  from PROJ_LD_Stages where pri_id = "+_PriID.ToString(),Connection.TRConnection);

            if( ObjectToDouble(result,0) > ObjectToDouble(teArea.EditValue,0))
            {
                teArea.Focus();
                Popup.ShowPopup("Stages total can not exceed project Area.");
                return false;
            }
            result = Connection.SQLExecutor.ExecuteScalar("select isnull(sum(original),0)[OriginalTotal] from PROJ_LD_AdditionalUseArea where PRI_ID = " + _PriID.ToString(), Connection.TRConnection);

            if (ObjectToDouble(result, 0) > ObjectToDouble(teArea.EditValue, 0))
            {
                teArea.Focus();
                Popup.ShowPopup("Additional use original total can not exceed project Area.");
                return false;
            }

            if (tePresalesRequired.EditValue != null && tePresalesRequired.EditValue != DBNull.Value)
            {
                if (IsLessThanZero(tePresalesRequired.EditValue,true))
                {
                    Popup.ShowPopup("Presales required can not be less than 0.");
                    return false;
                }
                else if(IsNumberToLarge(tePresalesRequired.EditValue))
                {
                    Popup.ShowPopup("Presales required is too large.");
                    return false;
                }
            }


            return valid;
        }


        private bool AdditionalUseLargerThanArea()
        {
            bool returnvalue = false;
            double Original = 0;
            double Area = 0;
            try
            {
                Area = Convert.ToDouble(teArea.EditValue);
            }
            catch { }
            string sql = "select isnull(sum(original),0)[OriginalTotal] from PROJ_LD_AdditionalUseArea where PRI_ID = " + _PriID.ToString();
            Object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error :" + Connection.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                try
                {
                    Original = Convert.ToDouble(result);
                }
                catch { }
            }

            if (Original > Area)
                returnvalue = true;

            return returnvalue;
        }

        private bool IsLessThanZero(object value, bool AllowZero)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try { dValue = Convert.ToDecimal(value); }
            catch { }

            if (dValue == 0 && !AllowZero)
                returnValue = true;
            else if (dValue < 0)
                returnValue = true;
            return returnValue;
        }

        private bool IsNumberToLarge(object value)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue > 9999999999)
                returnValue = true;

            return returnValue;
        }

        double ObjectToDouble(object value,double invlaidValue )
        {
            try
            {
                invlaidValue = Convert.ToDouble(value);
            }
            catch{}
            return invlaidValue;            
        }

        private void ucHeader_Load(object sender, EventArgs e)
        {
            gcAdditionalDates.ForceInitialize();
            colAdditionalDates_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            colAdditionalDates_ID.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            SetDockpanelVisibility();
            DevXMgr.FormInit(this);
        }

        private void LoadKCAAccess()
        {
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                if (!KCA_Validator.UserAccessAllowed(CONST_REV_ACCESS_GC_APPROVAL_TOPIC_ID))
                {
                    layoutControl4.BeginUpdate();
                    lciGMA.HideToCustomization();
                    lciGMA.ShowInCustomizationForm = false;
                    lciGMP.HideToCustomization();
                    lciGMP.ShowInCustomizationForm = false;
                    lciRev.HideToCustomization();
                    lciRev.ShowInCustomizationForm = false;
                    lciSpace.RestoreFromCustomization(lciCost, DevExpress.XtraLayout.Utils.InsertType.Right);
                    layoutControl4.EndUpdate();
                }
                else
                {
                    layoutControl4.BeginUpdate();
                    lciSpace.HideToCustomization();
                    lciSpace.ShowInCustomizationForm = false;
                    lciRev.RestoreFromCustomization(lciCost, DevExpress.XtraLayout.Utils.InsertType.Left);
                    lciRev.ShowInCustomizationForm = true;
                    lciGMA.RestoreFromCustomization(lciRev, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciGMA.ShowInCustomizationForm = true;
                    lciGMP.RestoreFromCustomization(lciGMA, DevExpress.XtraLayout.Utils.InsertType.Right);
                    lciGMP.RestoreFromCustomization(lciCost, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                    lciGMP.ShowInCustomizationForm = true;
                    layoutControl4.EndUpdate();
                }
            }
        }

        private void lueContractType_EditValueChanged(object sender, EventArgs e)
        {
            if ((lueContractType.EditValue.Equals("F") || lueContractType.EditValue == DBNull.Value) && dnProject.Buttons.EndEdit.Enabled)
            {
                txtContractAmt.Properties.ReadOnly = false;
            }
            else
            {
                if (lueContractType.EditValue.Equals("C"))
                {
                    txtContractAmt.EditValue = 0.0;
                }
                txtContractAmt.Properties.ReadOnly = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetupSwapSeg();
            SetupWarehouse();
            FillLookups();
            Stakeholders.RefreshLookups();
            int CustID = -1;
            if (lueCustomer.EditValue != null && lueCustomer.EditValue != DBNull.Value)
                CustID = Convert.ToInt32(lueCustomer.EditValue);
            Stakeholders.LoadCustomer(CustID);
        }

        private void lueCustomer_EditValueChanged(object sender, EventArgs e)
        {
            int CustID = -1;
            if (lueCustomer.EditValue != null && lueCustomer.EditValue != DBNull.Value)
                CustID = Convert.ToInt32(lueCustomer.EditValue);
            Stakeholders.LoadCustomer(CustID);
        }

        private void lueContractType_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            string sSelect = "select count(*) from so_trn_hdr_proj where pri_id="+_PriID;
            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
            {
                Popup.ShowPopup("Billings have already been released for this project. Unable to change contract type.");
                e.Cancel = true;
            }
        }

        private void btnSharepoint_Click(object sender, EventArgs e)
        {
            using (SharePointMgr.frmSharePointMgr SharePointManager = new SharePointMgr.frmSharePointMgr(Connection, DevXMgr, "Project", "Project Costing", "", "Header", _PriID))
            {
                SharePointManager.ReadOnly = _ReadOnly;
                SharePointManager.ShowDialog();
                SharePointManager.Dispose();
                SharePointMgr.cSharePointMgr.UpdateButton(Connection, "Project", ref btnSharepoint, "Header", _PriID);
            }
        }

        private void dockManager1_Load(object sender, EventArgs e)
        {
            //SetDockpanelVisibility();
        }

        


        private void gvAdditionalDates_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colpri_id.FieldName] = _PriID;
            }
        }

      

        private void gvAdditionalDates_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvAdditionalDates_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           DataRowView rv = (DataRowView)e.Row;
           
           if (rv[colAdditionalDates_ID.FieldName] == null || rv[colAdditionalDates_ID.FieldName] == DBNull.Value)
           {
               Popup.ShowPopup("Description is required.");
               e.ErrorText = "DeveloperThrownError";
               e.Valid = false;
           }
           else if (IsAlreadyEntered(rv[colAdditionalDates_ID.FieldName], rv[colID.FieldName]))
           {
               Popup.ShowPopup("Description has already been selected.");
               e.ErrorText = "DeveloperThrownError";
               e.Valid = false;
           }

           else if (!isGreaterThenZero(rv[colOffsetDays.FieldName], true))
           {
               Popup.ShowPopup("Offset days can not be less then zero.");
               e.ErrorText = "DeveloperThrownError";
               e.Valid = false;
           }
           if (e.Valid && rv[colOffsetDate_ID.FieldName] != DBNull.Value)
           {
               string sql = "exec LD_Proj_AdditionalDatesValidation " + rv[colAdditionalDates_ID.FieldName].ToString() + "," + rv[colOffsetDate_ID.FieldName].ToString() + ", " + _PriID.ToString();
               object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
               if (Connection.SQLExecutor.Exception != null)
                   Popup.ShowPopup("Error validating additional date selection." + Connection.SQLExecutor.Exception.Message);
               if (result != null && result != DBNull.Value)
               {
                   if (result.ToString().ToLower() != "ok")
                   {
                       Popup.ShowPopup(result.ToString());
                       e.ErrorText = "DeveloperThrownError";
                       e.Valid = false;
                   }
               }
               else
               {
                   Popup.ShowPopup("Unknown error, Invalid value returned.");
                   e.ErrorText = "DeveloperThrownError";
                   e.Valid = false;
               }
           }
            

        }

        private bool IsAlreadyEntered(object AdditionalDates_ID,object rowID)
        {

            bool returnvalue = false;

            
                string sql = "select COUNT(*) from LD_Proj_AdditionalDates where AdditionalDates_ID = " + AdditionalDates_ID.ToString() +
                    " and ID != " + rowID.ToString() + " and pri_id = " + _PriID.ToString();

                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                {
                    Popup.ShowPopup("Error validating additional dates selection:" + Connection.SQLExecutor.Exception.Message);

                }
                int count = -1;
                try { count = Convert.ToInt32(result); }
                catch { }

                if (count != 0)
                {
                    returnvalue = true; ;

                }


                return returnvalue;
        }
     

        private bool isGreaterThenZero(object Value, bool AllowEqual)
        {
            double dValue = -1;
            try
            {
                dValue = Convert.ToDouble(Value);
            }
            catch { }

            if (dValue > 0)
                return true;
            else if (dValue == 0 && AllowEqual)
                return true;
            else
                return false;
        }

        private void ri_lueAdditionalDates_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit)
            {
                if(((LookUpEdit)sender).EditValue != DBNull.Value && ((LookUpEdit)sender).EditValue != null)
                {
                    object obj = ((LookUpEdit)sender).Properties.GetDataSourceRowByKeyValue(((LookUpEdit)sender).EditValue);
                    if (obj != null)
                    {
                        DataRowView rv = (DataRowView)obj;
                        DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);

                        row[colOffsetDays.FieldName] = rv["OffSetDays"];
                        row[colOffsetDate_ID.FieldName] = rv["AdditinalDates_ID"];

                    }
                }
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            if (_ReadOnly)
                return;
            Connection.SQLExecutor.ExecuteNonQuery(@"Insert into LD_Proj_AdditionalDates(pri_id, AdditionalDates_ID, OffsetDays, OffsetDate_ID)
Select " + _PriID.ToString() + @", ID, OffSetDays, AdditinalDates_ID
From LD_AdditionalDates
Where ID not in (Select LD_Proj_AdditionalDates.AdditionalDates_ID From LD_Proj_AdditionalDates where pri_id = " + _PriID.ToString() + @")", Connection.TRConnection);

            ds_AdditionalDates1.Clear();
            da_AdditionalDates.SelectCommand.Parameters["@pri_id"].Value = _PriID.ToString();
            da_AdditionalDates.Fill(ds_AdditionalDates1);
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            if (_ReadOnly)
                return;
            object oCount = Connection.SQLExecutor.ExecuteScalar("Select Count(1) From LD_AdditionalDates Where ID not in (Select LD_Proj_AdditionalDates.AdditionalDates_ID From LD_Proj_AdditionalDates where pri_id = " + _PriID.ToString() + ") ", Connection.TRConnection);
            int iCount = 0;

            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount <= 0)
            {
                Popup.ShowPopup("No additional dates avaliable to load.");
                return;
            }

            using (frmAddtionalDatesSelection AdditionalDateSelection = new frmAddtionalDatesSelection(Connection, DevXMgr, _PriID))
            {
                if (AdditionalDateSelection.ShowDialog() == DialogResult.OK)
                {
                    ds_AdditionalDates1.Clear();
                    da_AdditionalDates.SelectCommand.Parameters["@pri_id"].Value = _PriID.ToString();
                    da_AdditionalDates.Fill(ds_AdditionalDates1);
                }
            }
        }

        private void ri_lueOffSetDate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                if (sender is DevExpress.XtraEditors.LookUpEdit)
                {
                    ((DevExpress.XtraEditors.LookUpEdit)sender).EditValue = DBNull.Value;
                }
            }
        }

        private void ri_lueOffSetDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gvAdditionalDates.GetDataRow(gvAdditionalDates.FocusedRowHandle);
            int ID = Convert.ToInt32(row[colAdditionalDates_ID.FieldName]);
            if (ID == 1 /*Agreement*/|| ID == 2 /*Sale*/|| ID == 3/*Closing*/)
            {
                Popup.ShowPopup("Agreement Date, Sale Date and Closing Date can not have an offset date.");
                e.Cancel = true;
            }
        }

        private void FillAdminProjects()
        {
            try
            {
                int AdminCo = Convert.ToInt32(luAdminCompany.EditValue);
                HMCon hc = new HMCon(Connection.WebDB, Connection.WebServer, AdminCo);
                AdminTR.ConnectionString = hc.TRConnection;
                daAdminProjects.Fill(dsAdminProjects1);
            }
            catch { }
        }

        private void luAdminCompany_EditValueChanged(object sender, EventArgs e)
        {
            FillAdminProjects();
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            using (WO_CentralizedFSManager.frmFileManager FileMgr = new WO_CentralizedFSManager.frmFileManager(Connection, DevXMgr, WO_CentralizedFSManager.DocumentViewerMode.All, GetPriTypeString(), _PriID, _ReadOnly))
            {
                FileMgr.ShowDialog();
                FileMgr.Dispose();
            }

            WO_CentralizedFSManager.cCentralizedFSUtils.UpdateButton(Connection, GetPriTypeString(), _PriID, ref btnAttachments);
        }

        private string GetPriTypeString()
        {
            string sType = "PGC";

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    sType = "PGC";
                    break;
                case ProjectType.PC_Homebuilder:
                    sType = "PHC";
                    break;
                case ProjectType.PC_Land_Construction:
                    sType = "PLC";
                    break;
                case ProjectType.PC_Unit_Construction:
                    sType = "PUC";
                    break;
                case ProjectType.PC_Software_Development:
                    sType = "PSD";
                    break;
                default:
                    sType = "PGC";
                    break;
            }

            return sType;
        }

        private void lueCustType_EditValueChanged(object sender, EventArgs e)
        {
            object oVal = lueCustType.EditValue;
            if (oVal == null || oVal == DBNull.Value)
                oVal = -1;
            if (Convert.ToInt32(oVal) == 3)
                lueInternalType.Enabled = true;
            else
            {
                lueInternalType.EditValue = null;
                lueInternalType.Enabled = false;
            }
        }

        private void dpnlAnalysis_Click(object sender, EventArgs e)
        {

        }

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            string sSQL = "exec sp_WO_CalcCosts " + _PriID;
            Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);

            daSelectedProject.SelectCommand.Parameters["@pri_id"].Value = _PriID;
            daSelectedProject.Fill(dsSelectedProject1);
        }

        private void lueBillingLevel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (_ReadOnly)
                    return;
                string sSQL = @"select contract_type from proj_header where pri_id = " + _PriID;
                object oContractType = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (oContractType == null || oContractType == DBNull.Value)
                    oContractType = "";

                if (oContractType.Equals("F"))
                {
                    sSQL = @"select billing_level from proj_header where pri_id = " + _PriID;
                    object oLevel = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                    if (oLevel == null || oLevel == DBNull.Value)
                        oLevel = "";

                    if (oLevel.Equals("L"))
                    {
                        PC_RevenueDistribution.frmRevenueDistribution RevDist = null;
                        try
                        {
                            RevDist = new PC_RevenueDistribution.frmRevenueDistribution(Connection, DevXMgr, _PriID);
                            RevDist.ShowDialog();
                        }
                        finally
                        {
                            if (RevDist != null)
                            {
                                ((IDisposable)RevDist).Dispose();
                            }
                        }
                    }
                    else
                    {
                        Popup.ShowPopup("The billing level must be level 1 to edit the revenue budget distribution.");
                    }
                }
                else
                {
                    Popup.ShowPopup("The contract type must be fixed price to edit the revenue budget distribution.");
                }
            }
        }

        private void beBaseFolder_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (beBaseFolder.Text != "")
                    folderBrowserDialog1.SelectedPath = beBaseFolder.Text;
                
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    beBaseFolder.Text = folderBrowserDialog1.SelectedPath;

            }
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                if (beBaseFolder.Text != "")
                {
                    Process.Start("explorer.exe", beBaseFolder.Text);
                }
            }
        }

        private void luSuperProject_Enter(object sender, EventArgs e)
        {
           try
            {

                if (lueCustomer.EditValue != null && lueCustomer.EditValue != DBNull.Value)
                {

                    DataView clone = dsSuperProject1.Tables[0].DefaultView;
                    clone.RowFilter = " customer_id = " + lueCustomer.EditValue;
                    luSuperProject.Properties.DataSource = clone;
                }

            }
            catch (Exception ex)
            {
                Popup.ShowPopup("Error found in luSuperProject_Enter: " + ex.Message + " " + ex.StackTrace);
            }
        }


        private void SetupKCAccess()
        {
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                if (KCA_Validator.ModulePointRequired(CONST_ProvinceChange))
                {
                    KCA_Validator.ModulePointLocked_Event += new KeyControlAccess.Validator.ModulePointLocked_Delegate(KCA_Validator_ModulePointLocked_Event);
                    KCA_Validator.ModulePointUnlocked_Event += new KeyControlAccess.Validator.ModulePointUnlocked_Delegate(KCA_Validator_ModulePointUnlocked_Event);
                }
            }
        }

        void KCA_Validator_ModulePointUnlocked_Event(int ModulePointID)
        {
            if (!_ReadOnly)
                luTaxprovince.Properties.ReadOnly = false;
        }

        void KCA_Validator_ModulePointLocked_Event(int ModulePointID)
        {
            luTaxprovince.Properties.ReadOnly = true;
        }

        private void dpStakeholders_Click(object sender, EventArgs e)
        {

        }

         
        private void LoadUDF()
        {
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                if (_PriID == -1)
                {
                    udf.ClearUDFValues();
                    udf.SetReadOnly(true);
                }
                else if (!_ReadOnly) 
                {
                    udf.SetReadOnly(false);
                    udf.PopulateUDFValues("PGC", _PriID);
                }
                else
                {
                    udf.SetReadOnly(true);
                    udf.PopulateUDFValues("PGC",_PriID);
                }
            }
            else if (_Flavour == ProjectType.PC_Land_Construction)
            {
                if (_PriID == -1)
                {
                    udf.ClearUDFValues();
                    udf.SetReadOnly(true);
                }
                else if (!_ReadOnly) 
                {
                    udf.SetReadOnly(false);
                    udf.PopulateUDFValues("PLC", _PriID);
                }
                else
                {
                    udf.SetReadOnly(true);
                    udf.PopulateUDFValues("PLC",_PriID);
                }
            }
            else if (_Flavour == ProjectType.PC_Unit_Construction)
            {
                if (_PriID == -1)
                {
                    udf.ClearUDFValues();
                    udf.SetReadOnly(true);
                }
                else if (!_ReadOnly)
                {
                    udf.SetReadOnly(false);
                    udf.PopulateUDFValues("PUC", _PriID);
                }
                else
                {
                    udf.SetReadOnly(true);
                    udf.PopulateUDFValues("PUC", _PriID);
                }
            }
            else if (_Flavour == ProjectType.PC_Homebuilder)
            {
                if (_PriID == -1)
                {
                    udf.ClearUDFValues();
                    udf.SetReadOnly(true);
                }
                else if (!_ReadOnly)
                {
                    udf.SetReadOnly(false);
                    udf.PopulateUDFValues("PHC", _PriID);
                }
                else
                {
                    udf.SetReadOnly(true);
                    udf.PopulateUDFValues("PHC", _PriID);
                }
            }
            else if (_Flavour == ProjectType.PC_Software_Development)
            {
                if (_PriID == -1)
                {
                    udf.ClearUDFValues();
                    udf.SetReadOnly(true);
                }
                else if (!_ReadOnly)
                {
                    udf.SetReadOnly(false);
                    udf.PopulateUDFValues("PSD", _PriID);
                }
                else
                {
                    udf.SetReadOnly(true);
                    udf.PopulateUDFValues("PSD", _PriID);
                }
            }
        
        }
        private void SetupUDF()
        {
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                udf = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.PGC);
                udf.Dock = DockStyle.Fill;
                udf.Parent = dpUDFs;
                
            }
            else if (_Flavour == ProjectType.PC_Land_Construction)
            {
                if (udf == null)
                {
                    udf = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.PLC);
                    udf.Dock = DockStyle.Fill;
                    udf.Parent = dpUDFs;
                }
               
            }
            else if (_Flavour == ProjectType.PC_Unit_Construction)
            {
                if (udf == null)
                {
                    udf = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.PUC);
                    udf.Dock = DockStyle.Fill;
                    udf.Parent = dpUDFs;
                }

            }
            else if (_Flavour == ProjectType.PC_Homebuilder)
            {
                if (udf == null)
                {
                    udf = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.PHC);
                    udf.Dock = DockStyle.Fill;
                    udf.Parent = dpUDFs;
                }

            }
            else if (_Flavour == ProjectType.PC_Software_Development)
            {
                if (udf == null)
                {
                    udf = new UDF_Manager.ucUDF_Manager(Connection, DevXMgr, UDF_Manager.UDFType.PSD);
                    udf.Dock = DockStyle.Fill;
                    udf.Parent = dpUDFs;
                }

            }

        }

        private void lueBillingLevel_EditValueChanged(object sender, EventArgs e)
        {
            if (_ReadOnly)
                return;
            object oBillingLv = lueBillingLevel.EditValue;
            if (oBillingLv == null || oBillingLv == DBNull.Value)
                oBillingLv = "";
            if (oBillingLv.Equals("P"))
                chkUseContractTemp.Properties.ReadOnly = false;
            else
            {
                DataRowView current = (DataRowView)bsSelectedProject.Current;
                current["UseContractTemplate"] = false;
                chkUseContractTemp.EditValue = false;                
                chkUseContractTemp.Properties.ReadOnly = true;                
            }
        }

        private void rHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeCustomer cc = new frmChangeCustomer(Connection.TRConnection);
                if (cc.ShowDialog() == DialogResult.OK)
                {
                    object oResult = Connection.SQLExecutor.ExecuteScalar(" exec PC_ChangeCustomer " + _PriID + ", " + cc.Customer_ID, Connection.TRConnection);
                    if (oResult != null && oResult != DBNull.Value && oResult.ToString() != "OK")
                    {
                        Popup.ShowPopup("The customer could not be changed for the following reason(s):" + Environment.NewLine + oResult.ToString());
                    }
                    else
                    {
                        Popup.ShowPopup("The customer has been changed.");
                        CL_Dialog.PleaseWait.Show("Reloading project... please wait.", this.ParentForm);
                        LoadProject(_PriID);
                    }
                }
            }
            finally { CL_Dialog.PleaseWait.Hide(); }
        }
    }
}
