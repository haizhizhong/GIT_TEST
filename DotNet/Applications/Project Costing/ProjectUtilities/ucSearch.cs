using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HMConnection;
using WS_Popups;
using ProjectTypes;
using System.Data.SqlClient;
using System.Diagnostics;
using ReflexMap;
using TUC_HMDevXManager;


namespace ProjectUtilities
{
    public partial class ucSearch : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void ProjectView_Delegate(int ProjectID);
        public event ProjectView_Delegate ProjectView_Event;
        public delegate void ProjectEdit_Delegate(int ProjectID);
        public event ProjectEdit_Delegate ProjectEdit_Event;
        public delegate void ProjectChange_Delegate(int ProjectID);
        public event ProjectChange_Delegate ProjectChange_Event;

        private bool b_ClearNonSearchPanel = false;
        private bool b_NonClosed = false;

        private UDF_Conditioner.UDFConditioner udc;

        #region ucSearch Class Variables

        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private HMCon Connection;
        private frmPopup Popup;
        private ProjectType _Flavour;

        private bool b_GLSwapSegOn = false;
        private int i_GLSwapSeg = -1;

        private string ProjGC = "select pri_id, pri_code, pri_name from proj_header where pri_type='PGC' and isnull(is_co,'F')='F' order by pri_code";
        private string ProjUC = "select pri_id, pri_code, pri_name from proj_header where pri_type='PUC' and isnull(is_co,'F')='F' order by pri_code";
        private string ProjLC = "select pri_id, pri_code, pri_name from proj_header where pri_type='PLC' and isnull(is_co,'F')='F' order by pri_code";
        private string ProjHC = "select pri_id, pri_code, pri_name from proj_header where pri_type='PHC' and isnull(is_co,'F')='F' order by pri_code";
        private string ProjSD = "select pri_id, pri_code, pri_name from proj_header where pri_type='PSD' and isnull(is_co,'F')='F' order by pri_code";

        private string DivWhere = "";
        private string WhseWhere = "";

        private ComboSearch.Util ComboBoxUtil;

        private string sLandSubType = "P";
        public string LandSubType
        {
            get { return sLandSubType; }
        }

        private bool _fomDashboard = false;

        #endregion

        public ucSearch(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, ProjectType Flavour)
            : this(Connection, DevXMgr, Flavour, false)
        {
        }

        public ucSearch( HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, ProjectType Flavour, bool fromDashBoard)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            _Flavour = Flavour;
            _fomDashboard = fromDashBoard;
            InitializeComponent();
            RunSetups();
            ComboBoxUtil = new ComboSearch.Util(DevXMgr);
        }

        public bool ClearNonSearchPanels
        {
            set
            {            	
                b_ClearNonSearchPanel = value;
            }
        }

        public bool NonClosed
        {
            set
            {
                b_NonClosed = value;
                SetupDatatables();
            }
        }

        public void ClearSearch()
        {
            btnReset_Click(null, null);
            dsProject1.Clear();
        }

        static class SecurityFunctions
        {
            public const int RM_P_C_GeneralConstruction = 10570;
            public const int RM_P_C_LandDevelopment = 20570;
            public const int Dashboard_PWO_GeneralConstruction = 21252;
            public const int Dashboard_PWO_LandDevelopment = 21256;
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            int tabFuncId = this.GetNearestSecurityFunctionID();
            if ((new List<int> { SecurityFunctions.RM_P_C_GeneralConstruction, SecurityFunctions.Dashboard_PWO_GeneralConstruction }).Contains(tabFuncId))
            {
                MapShapeLayer shapeLayer = MapLinkTables.ProjectCostingGeneralConstruction.CreatePolygonLayer("pri_code");
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrProjectNum, "pri_code"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrProjecName, "pri_name"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrStartDate, "pri_start_date"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrSiteAddress, "pri_site1"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrWarehouse, "description"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrCustomer, "NAME"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrProjectManager, "proj_manager"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingGeneralConstruction.AttrStatus, "pri_status"));

                MapPointLayer pointLayer = MapLinkTables.ProjectCostingGeneralConstruction.CreatePointLayer("pri_code");
                pointLayer.Attributes = shapeLayer.Attributes;

                ucMap1.Init(Connection, DevXMgr, gvSearch, new List<IMapLayer> { pointLayer, shapeLayer });
            }
            else if ((new List<int> { SecurityFunctions.RM_P_C_LandDevelopment, SecurityFunctions.Dashboard_PWO_LandDevelopment }).Contains(tabFuncId))
            {
                MapShapeLayer shapeLayer = MapLinkTables.ProjectCostingLandDevelopment.CreatePolygonLayer("pri_code");
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrProjectNum, "pri_code"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrProjecName, "pri_name"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrStartDate, "pri_start_date"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrSiteAddress, "pri_site1"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrWarehouse, "description"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrLandType, "LandSubType"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrProjectManager, "proj_manager"));
                shapeLayer.Attributes.Add(new AttrInfo(MapLinkTables.ProjectCostingLandDevelopment.AttrStatus, "pri_status"));

                MapPointLayer pointLayer = MapLinkTables.ProjectCostingLandDevelopment.CreatePointLayer("pri_code");
                pointLayer.Attributes = shapeLayer.Attributes;

                ucMap1.Init(Connection, DevXMgr, gvSearch, new List<IMapLayer> { pointLayer, shapeLayer });
            }
            else
            {
                dpGIS.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }

            if ((new List<int> { SecurityFunctions.Dashboard_PWO_LandDevelopment, SecurityFunctions.Dashboard_PWO_GeneralConstruction }).Contains(tabFuncId))
            {
                ucMap1.EnableMapDraw = false;
                ucMap1.EnableMapImport = false;
            }

            DevXMgr.FormInit(this);
            lueProjStatus.EditValue = "A";
        }

        public int ProjectSelected()
        {
            int Project = -1;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    Project = Convert.ToInt32(oPRI_ID);
                }
            }

            return Project;
        }

        public int ProjectNumberSelected()
        {
            int Project = -1;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_code"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    Project = Convert.ToInt32(oPRI_ID);
                }
            }

            return Project;
        }

        #region Setups

        private void RunSetups()
        {
            WEB_Conn.ConnectionString = Connection.WebConnection;
            TR_Conn.ConnectionString = Connection.TRConnection;
            daSalesperson.SelectCommand.CommandText = daSalesperson.SelectCommand.CommandText.Replace("TR_STRIKE_TEST10", Connection.TRDB);
            Connection.SQLExecutor.ExecuteNonQuery("exec sp_fill_mluser_supervisor '" + Connection.MLUser + "','" + Connection.MLUser + "', 1", Connection.TRConnection);
            
            SetupFlavour();
            SetupDatatables();
            SetupSwapSeg();
            SetupProfitSeg();
            SetupWarehouse();

            SetupUDF();

            daProject.SelectCommand.Parameters["@username"].Value = Connection.MLUser;
            daProject.SelectCommand.CommandText = daProject.SelectCommand.CommandText.Replace("web_strike_test", Connection.WebDB); 

            if (b_GLSwapSegOn)
            {
                daProject.SelectCommand.CommandText += " and gl.segment_number="+i_GLSwapSeg;
            }

            daProject.SelectCommand.CommandText += " order by isnull(mp.pri_code,p.pri_code), case when mp.pri_code is null then 0 else p.pri_code end ";
            //chkIncludeCO.EditValue = "F";
            lueIncludeChangeOrdres.EditValue = "P";
        }

        public void HideActions()
        {
            if (dpActions.Visibility != DevExpress.XtraBars.Docking.DockVisibility.Hidden)
            {
                dpActions.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
                dpActions.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
        }

        private void SetupFlavour()
        {
            //Hide change order action as not currently setup at this time
            if(layoutControlItem21.Visible)
                layoutControlItem21.HideToCustomization();

            layoutControlItem21.ShowInCustomizationForm = false;

            lciCustomerType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction :
                    HideHomebuilder();
                    HideLand();
                    HideUnit();
                    navBarGroup3.Expanded = true;
                    daProjNum.SelectCommand.CommandText = ProjGC;
                    daCategory.SelectCommand.Parameters["@pri_type"].Value = "PGC";
                    //Land Project # to sort numarically but does not show changeorder
                    colProjectNumber.OptionsColumn.ShowInCustomizationForm = false;
                    colProjectNumber.Visible = false;

                    colBaseFolder.OptionsColumn.ShowInCustomizationForm = false;
                    colBaseFolder.Visible = false;
                    break;
                case ProjectType.PC_Homebuilder:
                    HideGenCon();
                    HideLand();
                    HideUnit();
                    navBarGroup4.Expanded = true;
                    daProjNum.SelectCommand.CommandText = ProjHC;
                    daCategory.SelectCommand.Parameters["@pri_type"].Value = "PHC";
                    //Land Project # to sort numarically but does not show changeorder
                    colProjectNumber.OptionsColumn.ShowInCustomizationForm = false;
                    colProjectNumber.Visible = false;
                    colBaseFolder.OptionsColumn.ShowInCustomizationForm = false;
                    colBaseFolder.Visible = false;

                    //hide ununsed stakeholders
                    lciStkProjCoordinator.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case ProjectType.PC_Land_Construction:
                    HideGenCon();
                    HideHomebuilder();
                    HideUnit();
                    navBarGroup5.Expanded = true;
                    daProjNum.SelectCommand.CommandText = ProjLC;
                    daCategory.SelectCommand.Parameters["@pri_type"].Value = "PLC";
                    hlRefresh_Click(hlRefresh, new EventArgs());
                    lciCustomer.HideToCustomization();
                    lciCustomer.ShowInCustomizationForm = false;
                    lciCustName.HideToCustomization();
                    lciCustName.ShowInCustomizationForm = false;
                    lciIncludeChangeOrders.HideToCustomization();
                    lciIncludeChangeOrders.ShowInCustomizationForm = false;
                    colcustomer_id.Visible = false;
                    colcustomer_id.OptionsColumn.ShowInCustomizationForm = false;
                    colname.Visible = false;
                    colname.OptionsColumn.ShowInCustomizationForm = false;
                    colis_co.Visible = false;
                    colis_co.OptionsColumn.ShowInCustomizationForm = false;
                    colBilling_Level.Visible = false;
                    colBilling_Level.OptionsColumn.ShowInCustomizationForm = false;
                    colcontract_type.Visible = false;
                    colcontract_type.OptionsColumn.ShowInCustomizationForm = false;
                    //Other Project # that sorts alpha numarically
                    colpri_code.OptionsColumn.ShowInCustomizationForm = false;
                    colpri_code.Visible = false;

                    colBaseFolder.OptionsColumn.ShowInCustomizationForm = false;
                    colBaseFolder.Visible = false;

                    //hide ununsed stakeholders
                    lciStkProjCoordinator.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciStkCustContact.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                    navBarGroupControlContainer2.Height = navBarGroupControlContainer2.Height - 60;
                    break;
                case ProjectType.PC_Unit_Construction:
                    HideGenCon();
                    HideHomebuilder();
                    HideLand();
                    navBarGroup6.Expanded = true;
                    daProjNum.SelectCommand.CommandText = ProjUC;
                    daCategory.SelectCommand.Parameters["@pri_type"].Value = "PUC";
                    //Land Project # to sort numarically but does not show changeorder
                    colProjectNumber.OptionsColumn.ShowInCustomizationForm = false;
                    colProjectNumber.Visible = false;

                    colBaseFolder.OptionsColumn.ShowInCustomizationForm = false;
                    colBaseFolder.Visible = false;

                    //hide ununsed stakeholders
                    lciStkProjCoordinator.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                    //
                case ProjectType.PC_Software_Development:
                    HideHomebuilder();
                    HideLand();
                    HideUnit();
                    navBarGroup3.Caption = "Software Development";
                    navBarGroup3.Expanded = true;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    daProjNum.SelectCommand.CommandText = ProjSD;
                    daCategory.SelectCommand.Parameters["@pri_type"].Value = "PSD";
                    //Land Project # to sort numarically but does not show changeorder
                    colProjectNumber.OptionsColumn.ShowInCustomizationForm = false;
                    colProjectNumber.Visible = false;

                    lciCustomerType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;


                    //hide ununsed stakeholders
                    lciStkProjCoordinator.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
            }
        }

        private void HideGenCon()
        {
            navBarGroup3.Visible = false;
        }

        private void HideHomebuilder()
        {
            navBarGroup4.Visible = false;
        }

        private void HideLand()
        {
            navBarGroup5.Visible = false;
            colLandSubType.Visible = false;
            colLandSubType.OptionsColumn.ShowInCustomizationForm = false;
        }

        private void HideUnit()
        {
            navBarGroup6.Visible = false;
        }

        private void SetupDatatables()
        {            
            DataTable dtStatus = new DataTable("dtStatus");
            dtStatus.Columns.Add("ID", typeof(string));
            dtStatus.Columns.Add("Desc", typeof(string));
            
            if (b_NonClosed)
            {
                dtStatus.Rows.Add(new object[] { "A", "Active" });
                dtStatus.Rows.Add(new object[] { "C", "Complete" });
                dtStatus.Rows.Add(new object[] { "X", "Cancelled" });
            }
            else
            {
                dtStatus.Rows.Add(new object[] { "A", "Active" });
                dtStatus.Rows.Add(new object[] { "L", "Closed" });
                dtStatus.Rows.Add(new object[] { "C", "Complete" });
                dtStatus.Rows.Add(new object[] { "X", "Cancelled" });
            }

            lueProjStatus.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Status"));
            lueProjStatus.Properties.DataSource = dtStatus;
            lueProjStatus.Properties.DisplayMember = "Desc";
            lueProjStatus.Properties.ValueMember = "ID";

            riStatus.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Status"));
            riStatus.DataSource = dtStatus;
            riStatus.DisplayMember = "Desc";
            riStatus.ValueMember = "ID";

            DataTable dtIncChangeOrders = new DataTable("dtIncChangeOrders");
            dtIncChangeOrders.Columns.Add("ID", typeof(string));
            dtIncChangeOrders.Columns.Add("Desc", typeof(string));

            dtIncChangeOrders.Rows.Add(new object[] { "P", "No Change Orders" });
            dtIncChangeOrders.Rows.Add(new object[] { "C", "Only Change Orders" });
            dtIncChangeOrders.Rows.Add(new object[] { "B", "All" });

            lueIncludeChangeOrdres.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc", 150, "Type"));
            lueIncludeChangeOrdres.Properties.DataSource = dtIncChangeOrders;
            lueIncludeChangeOrdres.Properties.DisplayMember = "Desc";
            lueIncludeChangeOrdres.Properties.ValueMember = "ID";

            lueIncludeChangeOrdres.EditValue = "P";//Set default to only projects

            dsCustType1.Clear();
            daCustType.Fill(dsCustType1);

            dsLandSubType1.Clear();
            daLandSubType.Fill(dsLandSubType1);
        }

        private void SetupSwapSeg()
        {
            //string sSelect = "select isnull(clear_req,'F') from gl_setup";
            //if (Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection).ToString().ToUpper().Trim() == "T")
            //{
                string sSelect = "select clear_seg from gl_setup";
                object obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                if (obj != null && obj.GetType() != typeof(DBNull))
                {
                    int Column = Convert.ToInt32(obj);
                    i_GLSwapSeg = Column;
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
                    dsSwapSeg1.Clear();
                    daSwapSeg.Fill(dsSwapSeg1);

                    if (sSecurity == "")
                    {
                        DivWhere = "";
                    }
                    else
                    {
                        DivWhere = "and p.pri_division in ( select distinct a.seg_" + Column + " " +
                                    "from gl_accounts a " +
                                    "left outer join gl_segment_setup g on g.SEGMENT_VALUE = a.seg_" + Column + " " +
                                    "and SEGMENT_NUMBER = " + Column + " " +
                                    sSecurity +
                                    " ) ";
                    }

                    obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                    if (obj != null && obj.GetType() != typeof(DBNull))
                    {
                        b_GLSwapSegOn = true;
                        lciDivision.Text = obj.ToString();
                        lciDivision.ShowInCustomizationForm = true;
                        lciDivisionCode.Text = obj.ToString() + " Code";
                        lciDivisionCode.ShowInCustomizationForm = true;
                        colsegment_desc.Caption = obj.ToString();
                        colsegment_desc.Visible = true;
                        colsegment_desc.OptionsColumn.ShowInCustomizationForm = true;
                        colpri_division.Caption = obj.ToString() + " Code"; ;
                        colpri_division.OptionsColumn.ShowInCustomizationForm = true;
                    }
                }
            //}
            //else
            //{
            //    b_GLSwapSegOn = false;
            //    lciDivision.HideToCustomization();
            //    lciDivision.ShowInCustomizationForm = false;
            //    DivWhere = "";
            //    colsegment_desc.Visible = false;
            //    colsegment_desc.OptionsColumn.ShowInCustomizationForm = false;
            //}
        }

        private void SetupProfitSeg()
        {

            string sSelect = "select isnull(PROFIT_CENTER_SEG,3) from SO_SETUP";
            object obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            if (obj != null && obj.GetType() != typeof(DBNull))
            {
                int Column = Convert.ToInt32(obj);
                if (Column.ToString() != "0")
                {
                    string ColumnName = "SEG_" + Column + "_DESC";

                    sSelect = "select " + ColumnName + " from gl_setup";
                    daProfitSeg.SelectCommand.CommandText = "select distinct a.seg_" + Column + " [Code], g.SEGMENT_DESC [Description] " +
                                                "from gl_accounts a " +
                                                "left outer join gl_segment_setup g on g.SEGMENT_VALUE = a.seg_" + Column + " " +
                                                "and SEGMENT_NUMBER = " + Column + " " +
                                                "order by a.seg_" + Column;
                    dsProfitSeg1.Clear();
                    daProfitSeg.Fill(dsProfitSeg1);

                    obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                    if (obj != null && obj.GetType() != typeof(DBNull))
                    {

                        lciProfit.Text = obj.ToString();
                        lciProfitCode.Text = obj.ToString() + " Code";

                    }
                }
                else
                {
                    lciProfit.HideToCustomization();
                    lciProfitCode.HideToCustomization();
                }

            }
           
        }

        private void SetupWarehouse()
        {
            string sSelect = "select count(*) from working_mluser_supervisor wms " +
                "left outer join warehouse_security ws on wms.mluser=ws.mluser " +
                "where wms.username='" + Connection.MLUser + "' and ws_id is null";
            object oResult = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            WhseWhere = "";

            if (Convert.ToInt32(oResult) == 0)
            {
                daWarehouse.SelectCommand.CommandText = "select w.whse_id, warehouse, description "+
                    "from warehouse w "+
                    "join warehouse_security ws on ws.whse_id=w.whse_id "+
                    "join mluser m on m.name = ws.mluser "+
                    "join working_mluser_supervisor s ON s.mluser = m.name "+
                    "where s.username= '" + Connection.MLUser + "' "+
                    "order by description";

                WhseWhere = " and p.pri_whs in (select w.whse_id " +
                    "from warehouse w " +
                    "join warehouse_security ws on ws.whse_id=w.whse_id " +
                    "join mluser m on m.name = ws.mluser " +
                    "join working_mluser_supervisor s ON s.mluser = m.name " +
                    "where s.username= '" + Connection.MLUser + "') ";
                
            }
        }
        

        #endregion

        #region Search Functions

        private void btnReset_Click(object sender, EventArgs e)
        {
            lueProjNum.EditValue = null;
            lueProjName.EditValue = null;
            lueProjStatus.EditValue = null;
            lueCustomer.EditValue = null;
            lueCustName.EditValue = null;
            lueDivision.EditValue = null;
            lueDivisionCode.EditValue = null;
            lueProfit.EditValue = null;
            lueProfitCode.EditValue = null;
            lueProjMan.EditValue = null;
            lueEngineer.EditValue = null;
            lueArchitect.EditValue = null;
            lueForman.EditValue = null;
            lueFieldManager.EditValue = null;
            lueProjCoordinator.EditValue = null;
            lueProjAccountant.EditValue = null;
            lueSalesperson.EditValue = null;
            lueGenContractor.EditValue = null;
            lueEstimator.EditValue = null;
            lueCustContact.EditValue = null;
            lueIncludeChangeOrdres.EditValue = "B";
            luCustType.EditValue = null;
            
            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    lueCategory.EditValue = null;
                    lueClass.EditValue = null;
                    lueWarehouse.EditValue = null;
                    cboCustPO.Text = "";
                    deEstCompletion.EditValue = null;
                    break;
                case ProjectType.PC_Homebuilder:
                    break;
                case ProjectType.PC_Land_Construction:
                    lueCategoryLand.EditValue = null;
                    lueClassLand.EditValue = null;
                    lueGeographicAreaLand.EditValue = null;
                    lueMunicipalityLand.EditValue = null;
                    lueCommunityLand.EditValue = null;
                    lueLandUseLand.EditValue = null;
                    teLD_ExternalRef.EditValue = null;
                    lueLandType.EditValue = null;
                    lueRawLandHolding.EditValue = null;
                    break;
                case ProjectType.PC_Unit_Construction:
                    break;
                    
                case ProjectType.PC_Software_Development:
                    lueCategory.EditValue = null;
                    lueClass.EditValue = null;
                    lueWarehouse.EditValue = null;
                    cboCustPO.Text = "";
                    deEstCompletion.EditValue = null;
                    break;
            }

        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender is LookUpEdit)
                {//when enter is clicked editor does not save highlighted value.
                    if (!((LookUpEdit)sender).IsPopupOpen)
                        btnSearch_Click(null, null);
                }
                else
                    btnSearch_Click(null, null);

            }

            if (sender.Equals(cboCustPO))
            {
                if (e.Alt && e.KeyCode == Keys.Down)
                {
                    cboCustPO_ButtonClick(cboCustPO, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(cboCustPO.Properties.Buttons[1]));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool bFieldsEmpty = true;

            //SqlCommand cmd = new SqlCommand("PC_ProjectSearch @username, @pri_type, @include_co, @pri_id, @pri_id2, @pri_status, @non_closed, " +
            //    "@customer_id, @customer_id2,  @pri_division, @proj_manager, @engineer, @architect, @field_forman, @proj_accountant, " +
            //    "@salesperson, @gen_contractor, @estimator, @customer_contact, @prc_code, @prcl_code, "+
            //    "@pri_whs, @customer_po, @est_completion, @geographic_area_id, @municipalities_id, "+
            //    "@communities_id, @land_use_id, @external_ref, @co_pri_id, @co_pri_id2", new SqlConnection(Connection.TRConnection));
            SqlCommand cmd = daProjectSearch.SelectCommand;

            cmd.Parameters["@username"].Value = Connection.MLUser;

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    cmd.Parameters["@pri_type"].Value = "PGC";
                    break;
                case ProjectType.PC_Homebuilder:
                    cmd.Parameters["@pri_type"].Value = "PHC";
                    break;
                case ProjectType.PC_Land_Construction:
                    cmd.Parameters["@pri_type"].Value = "PLC";
                    break;
                case ProjectType.PC_Unit_Construction:
                    cmd.Parameters["@pri_type"].Value = "PUC";
                    break;
                case ProjectType.PC_Software_Development:
                    cmd.Parameters["@pri_type"].Value = "PSD";
                    break;
            }

            cmd.Parameters["@include_co"].Value = lueIncludeChangeOrdres.EditValue; //chkIncludeCO.EditValue;

            cmd.Parameters["@pri_id"].Value = DBNull.Value;
            cmd.Parameters["@pri_id2"].Value = DBNull.Value;
            cmd.Parameters["@pri_status"].Value = DBNull.Value;
            cmd.Parameters["@non_closed"].Value = DBNull.Value;

            cmd.Parameters["@customer_id"].Value = DBNull.Value;
            cmd.Parameters["@customer_id2"].Value = DBNull.Value;
            cmd.Parameters["@pri_division"].Value = DBNull.Value;
            cmd.Parameters["@pri_profit"].Value = DBNull.Value;
            cmd.Parameters["@proj_manager"].Value = DBNull.Value;
            cmd.Parameters["@engineer"].Value = DBNull.Value;
            cmd.Parameters["@architect"].Value = DBNull.Value;
            cmd.Parameters["@field_forman"].Value = DBNull.Value;
            cmd.Parameters["@proj_accountant"].Value = DBNull.Value;
            cmd.Parameters["@field_manager"].Value = DBNull.Value;
            cmd.Parameters["@proj_coordinator"].Value = DBNull.Value;


            cmd.Parameters["@salesperson"].Value = DBNull.Value;
            cmd.Parameters["@gen_contractor"].Value = DBNull.Value;
            cmd.Parameters["@estimator"].Value = DBNull.Value;
            cmd.Parameters["@customer_contact"].Value = DBNull.Value;
            cmd.Parameters["@prc_code"].Value = DBNull.Value;
            cmd.Parameters["@prcl_code"].Value = DBNull.Value;

            cmd.Parameters["@pri_whs"].Value = DBNull.Value;
            cmd.Parameters["@customer_po"].Value = DBNull.Value;
            cmd.Parameters["@est_completion"].Value = DBNull.Value;
            cmd.Parameters["@geographic_area_id"].Value = DBNull.Value;
            cmd.Parameters["@municipalities_id"].Value = DBNull.Value;

            cmd.Parameters["@communities_id"].Value = DBNull.Value;
            cmd.Parameters["@land_use_id"].Value = DBNull.Value;
            cmd.Parameters["@external_ref"].Value = DBNull.Value;
            cmd.Parameters["@co_pri_id"].Value = DBNull.Value;
            cmd.Parameters["@co_pri_id2"].Value = DBNull.Value;

            cmd.Parameters["@proj_customer_type_id"].Value = DBNull.Value;
            cmd.Parameters["@LandSubType"].Value = DBNull.Value;
            cmd.Parameters["@RawLandHolding_Pri_ID"].Value = DBNull.Value;

            string sWhereClause = GetProjType();

            sWhereClause += WhseWhere;

            if (lueProjNum.EditValue != null)
            {
                //sWhereClause += " and p.pri_id = " + lueProjNum.EditValue + " ";
                cmd.Parameters["@pri_id"].Value = lueProjNum.EditValue;
                bFieldsEmpty = false;
            }
            if (lueProjName.EditValue != null)
            {
                //sWhereClause += " and p.pri_id = " + lueProjName.EditValue + " ";
                cmd.Parameters["@pri_id2"].Value = lueProjName.EditValue;
                bFieldsEmpty = false;
            }
            if (lueProjStatus.EditValue != null)
            {
                //sWhereClause += " and p.pri_status = '" + lueProjStatus.EditValue + "' ";
                cmd.Parameters["@pri_status"].Value = lueProjStatus.EditValue;
                bFieldsEmpty = false;
            }
            if (b_NonClosed)
            {
                //sWhereClause += " and p.pri_status <> 'L' ";
                cmd.Parameters["@non_closed"].Value = "T";
            }
            if (lueCustomer.EditValue != null)
            {
                //sWhereClause += " and p.customer_id = " + lueCustomer.EditValue + " ";
                cmd.Parameters["@customer_id"].Value = lueCustomer.EditValue;
                bFieldsEmpty = false;
            }
            if (lueCustName.EditValue != null)
            {
                //sWhereClause += " and p.customer_id = " + lueCustName.EditValue + " ";
                cmd.Parameters["@customer_id2"].Value = lueCustName.EditValue;
                bFieldsEmpty = false;
            }
            if (b_GLSwapSegOn && lueDivision.EditValue != null)
            {
                //sWhereClause += " and p.pri_division = '" + lueDivision.EditValue + "' ";
                cmd.Parameters["@pri_division"].Value = lueDivision.EditValue;
                bFieldsEmpty = false;
            }
            if (b_GLSwapSegOn && lueDivisionCode.EditValue != null)
            {
                
                cmd.Parameters["@pri_division"].Value = lueDivisionCode.EditValue;
                bFieldsEmpty = false;
            }
            if (lueProfit.EditValue != null)
            {
                //sWhereClause += " and p.pri_division = '" + lueDivision.EditValue + "' ";
                cmd.Parameters["@pri_profit"].Value = lueProfit.EditValue;
                bFieldsEmpty = false;
            }
            if (lueProfitCode.EditValue != null)
            {

                cmd.Parameters["@pri_profit"].Value = lueProfitCode.EditValue;
                bFieldsEmpty = false;
            }
            if (b_GLSwapSegOn)
            {
                //sWhereClause += DivWhere;
            }
            if (lueProjMan.EditValue != null)
            {
                //sWhereClause += " and c.proj_manager = " + lueProjMan.EditValue + " ";
                cmd.Parameters["@proj_manager"].Value = lueProjMan.EditValue;
                bFieldsEmpty = false;
            }
            if (lueEngineer.EditValue != null)
            {
                //sWhereClause += " and c.engineer = " + lueEngineer.EditValue + " ";
                cmd.Parameters["@engineer"].Value = lueEngineer.EditValue;
                bFieldsEmpty = false;
            }
            if (lueArchitect.EditValue != null)
            {
                //sWhereClause += " and c.architect = " + lueArchitect.EditValue + " ";
                cmd.Parameters["@architect"].Value = lueArchitect.EditValue;
                bFieldsEmpty = false;
            }
            if (lueForman.EditValue != null)
            {
                //sWhereClause += " and c.field_forman = " + lueForman.EditValue + " ";
                cmd.Parameters["@field_forman"].Value = lueForman.EditValue;
                bFieldsEmpty = false;
            }
            if (lueFieldManager.EditValue != null)
            {
                cmd.Parameters["@field_manager"].Value = lueFieldManager.EditValue;
                bFieldsEmpty = false;                
            }
            if (lueProjCoordinator.EditValue != null)
            {
                cmd.Parameters["@proj_coordinator"].Value = lueProjCoordinator.EditValue;
                bFieldsEmpty = false;                
            }
            if (lueProjAccountant.EditValue != null)
            {
                //sWhereClause += " and c.proj_accountant = " + lueProjAccountant.EditValue + " ";
                cmd.Parameters["@proj_accountant"].Value = lueProjAccountant.EditValue;
                bFieldsEmpty = false;
            }
            if (lueSalesperson.EditValue != null)
            {
                //sWhereClause += " and c.salesperson = " + lueSalesperson.EditValue + " ";
                cmd.Parameters["@salesperson"].Value = lueSalesperson.EditValue;
                bFieldsEmpty = false;
            }
            if (lueGenContractor.EditValue != null)
            {
                //sWhereClause += " and c.gen_contractor = " + lueGenContractor.EditValue + " ";
                cmd.Parameters["@gen_contractor"].Value = lueGenContractor.EditValue;
                bFieldsEmpty = false;
            }
            if (lueEstimator.EditValue != null)
            {
                //sWhereClause += " and c.estimator = " + lueEstimator.EditValue + " ";
                cmd.Parameters["@estimator"].Value = lueEstimator.EditValue;
                bFieldsEmpty = false;
            }
            if (lueCustContact.EditValue != null)
            {
                //sWhereClause += " and c.customer_contact = " + lueCustContact.EditValue + " ";
                cmd.Parameters["@customer_contact"].Value = lueCustContact.EditValue;
                bFieldsEmpty = false;
            }
                                 

            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    if (lueCategory.EditValue != null)
                    {
                        //sWhereClause += " and p.prc_code = '" + lueCategory.EditValue + "' ";
                        cmd.Parameters["@prc_code"].Value = lueCategory.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueClass.EditValue != null)
                    {
                        //sWhereClause += " and p.prcl_code = '" + lueClass.EditValue + "' ";
                        cmd.Parameters["@prcl_code"].Value = lueClass.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueWarehouse.EditValue != null)
                    {
                        //sWhereClause += " and p.pri_whs = " + lueWarehouse.EditValue + " ";
                        cmd.Parameters["@pri_whs"].Value = lueWarehouse.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (!cboCustPO.Text.Trim().Equals(""))
                    {
                        //sWhereClause += " and p.customer_po like '" + cboCustPO.Text + "' ";
                        cmd.Parameters["@customer_po"].Value = cboCustPO.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (deEstCompletion.EditValue != null)
                    {
                        //sWhereClause += " and p.pri_est_completion_date = '" + deEstCompletion.DateTime.ToShortDateString() + "' ";
                        cmd.Parameters["@est_completion"].Value = deEstCompletion.DateTime;
                        bFieldsEmpty = false;
                    }
                    break;
                case ProjectType.PC_Homebuilder:
                    break;
                case ProjectType.PC_Land_Construction:
                    if (lueCategoryLand.EditValue != null)
                    {
                        //sWhereClause += " and p.prc_code = '" + lueCategoryLand.EditValue + "' ";
                        cmd.Parameters["@prc_code"].Value = lueCategoryLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueClassLand.EditValue != null)
                    {
                        //sWhereClause += " and p.prcl_code = '" + lueClassLand.EditValue + "' ";
                        cmd.Parameters["@prcl_code"].Value = lueClassLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueGeographicAreaLand.EditValue != null)
                    {
                        //sWhereClause += " and d.geographic_area_id = " + lueGeographicAreaLand.EditValue + " ";
                        cmd.Parameters["@geographic_area_id"].Value = lueGeographicAreaLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueMunicipalityLand.EditValue != null)
                    {
                        //sWhereClause += " and d.municipalities_id = " + lueMunicipalityLand.EditValue + " ";
                        cmd.Parameters["@municipalities_id"].Value = lueMunicipalityLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueCommunityLand.EditValue != null)
                    {
                        //sWhereClause += " and d.communities_id = " + lueCommunityLand.EditValue + " ";
                        cmd.Parameters["@communities_id"].Value = lueCommunityLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueLandUseLand.EditValue != null)
                    {
                        //sWhereClause += " and d.land_use_id = " + lueLandUseLand.EditValue + " ";
                        cmd.Parameters["@land_use_id"].Value = lueLandUseLand.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (teLD_ExternalRef.Text.Trim() != "")
                    {
                        //sWhereClause += " and d.external_ref = '" + teLD_ExternalRef.Text.Replace("'", "''") + "' ";
                        cmd.Parameters["@external_ref"].Value = teLD_ExternalRef.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueLandType.EditValue != null)
                    {
                        //sWhereClause += " and d.land_use_id = " + lueLandUseLand.EditValue + " ";
                        cmd.Parameters["@LandSubType"].Value = lueLandType.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueRawLandHolding.EditValue != null)
                    {
                        cmd.Parameters["@RawLandHolding_Pri_ID"].Value = lueRawLandHolding.EditValue;
                        bFieldsEmpty = false;
                    }
                    break;
                case ProjectType.PC_Unit_Construction:
                    break;
                    //
                case ProjectType.PC_Software_Development:
                    if (lueCategory.EditValue != null)
                    {
                        //sWhereClause += " and p.prc_code = '" + lueCategory.EditValue + "' ";
                        cmd.Parameters["@prc_code"].Value = lueCategory.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueClass.EditValue != null)
                    {
                        //sWhereClause += " and p.prcl_code = '" + lueClass.EditValue + "' ";
                        cmd.Parameters["@prcl_code"].Value = lueClass.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (lueWarehouse.EditValue != null)
                    {
                        //sWhereClause += " and p.pri_whs = " + lueWarehouse.EditValue + " ";
                        cmd.Parameters["@pri_whs"].Value = lueWarehouse.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (!cboCustPO.Text.Trim().Equals(""))
                    {
                        //sWhereClause += " and p.customer_po like '" + cboCustPO.Text + "' ";
                        cmd.Parameters["@customer_po"].Value = cboCustPO.EditValue;
                        bFieldsEmpty = false;
                    }
                    if (deEstCompletion.EditValue != null)
                    {
                        //sWhereClause += " and p.pri_est_completion_date = '" + deEstCompletion.DateTime.ToShortDateString() + "' ";
                        cmd.Parameters["@est_completion"].Value = deEstCompletion.DateTime.ToShortDateString();
                        bFieldsEmpty = false;
                    }
                    if (luCustType.EditValue != null)
                    {
                        cmd.Parameters["@proj_customer_type_id"].Value = luCustType.EditValue;
                        bFieldsEmpty = false;
                    }
                    break;
            }


            if (bFieldsEmpty)
            {
                if (Popup.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    CL_Dialog.PleaseWait.Show("Loading Project's...", null);                    
                    FillGrid(cmd);
                    CL_Dialog.PleaseWait.Hide();
                }
            }
            else
            {
                CL_Dialog.PleaseWait.Show("Loading Project's...", null);
                FillGrid(cmd);
                CL_Dialog.PleaseWait.Hide();
            }
            if (gvSearch.RowCount == 0)
            {
                sLandSubType = "P";
                if (ProjectChange_Event != null)
                    ProjectChange_Event(-1);
            }
        }

        private string GetProjType()
        {
            string sWhere = "";
            switch (_Flavour)
            {
                case ProjectType.PC_General_Construction:
                    sWhere = " and p.pri_type='PGC' ";
                    break;
                case ProjectType.PC_Homebuilder:
                    sWhere = " and p.pri_type='PHC' ";
                    break;
                case ProjectType.PC_Land_Construction:
                    sWhere = " and p.pri_type='PLC' ";
                    break;
                case ProjectType.PC_Unit_Construction:
                    sWhere = " and p.pri_type='PUC' ";
                    break;
                case ProjectType.PC_Software_Development:
                    sWhere = " and p.pri_type='PSD' ";
                    break;
            }
            return sWhere;
        }

        private void FillGrid(SqlCommand cmd)//string WhereClause)
        {
            //string sSQL = "delete from working_proj_selected where username='" + Connection.MLUser + "' " +
            //    "insert into working_proj_selected " +
            //    "select distinct '" + Connection.MLUser + "', p.pri_id " +
            //    "from proj_header p " +
            //    "left outer join proj_header co on co.master_pri_id=p.pri_id "+
            //    "left outer join proj_contacts c on p.pri_id = c.pri_id  " +
            //    "left outer join proj_dev_info d on p.pri_id = d.pri_id  " +
            //    "where (1=1) " + WhereClause;
            //Connection.SQLExecutor.ExecuteNonQuery( sSQL, Connection.TRConnection );
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch( Exception ex )
            {
                Popup.ShowPopup(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }

            dsProject1.Clear();
            daProject.Fill(dsProject1);
            gvSearch.BestFitColumns();

            LoadUDFs();
        }

        
        #endregion

        #region DropDownLoad

        private bool ProjLoaded = false;
        private bool CustomerLoaded = false;
        private bool ProjManagerLoaded = false;
        private bool EngineerLoaded = false;
        private bool ArchitectLoaded = false;
        private bool FormanLoaded = false;
        private bool AccountantLoaded = false;
        private bool SalespersonLoaded = false;
        private bool CategoryLoaded = false;
        private bool ClassLoaded = false;
        private bool WarehouseLoaded = false;
        private bool EstimatorLoaded = false;
        private bool CustomerContactLoaded = false;
        private bool GeneralContractorLoaded = false;
        private bool FieldManagerLoaded = false;
        private bool ProjCoordinatorLoaded = false;

        private void lueGenContractor_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!GeneralContractorLoaded)
            {
                daContractor.SelectCommand.CommandText = "select c.id, isnull(c.knownas, isnull(c.firstname,'')+' '+isnull(c.lastname,'')) [Name], s.name [Supplier] "+
                    "from contact c "+
                    "join relations r on r.itemid=c.id and r.target='supplier' and r.itemtype='contact' "+
                    "join "+Connection.TRDB+"..supplier_master s on s.supplier_id=r.targetid and r.target='supplier' and r.itemtype='contact' "+
                    "where c.type='Supplier' and c.id <> -1 and isnull(s.active,'F')='T' and r.companyid="+Connection.CompanyID+" "+
                    "and isnull(IsGenContractor,'F') = 'T' "+
                    "order by [Supplier],[Name]";
                daContractor.Fill(dsContractor1);
                GeneralContractorLoaded = true;
            }
        }

        private void lueEstimator_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!EstimatorLoaded)
            {
                daEstimator.SelectCommand.CommandText = "select c.id, isnull(c.knownas, isnull(c.firstname,'')+' '+isnull(c.lastname,'')) [Name] "+
                    "from contact c "+
                    "join "+Connection.TRDB+"..mluser m on m.contactid=c.id "+
                    "where type='User' and c.id <> -1 and isnull(estimator,'F') ='T' and isnull(m.inactive,'Y') = 'N' "+
                    "order by [Name]";
                daEstimator.Fill(dsEstimator1);
                EstimatorLoaded = true;
            }
        }

        private void lueCustContact_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!CustomerContactLoaded)
            {
                daCustContact.SelectCommand.CommandText = "select c.id, isnull(c.knownas, isnull(c.firstname,'')+' '+isnull(c.lastname,'')) [Name], cu.name [Customer] "+
                    "from contact c "+
                    "join relations r on r.itemid=c.id and r.target='customer' and r.itemtype='contact' "+
                    "join "+Connection.TRDB+"..customers cu on cu.customer_id=r.targetid and r.target='customer' and r.itemtype='contact' "+
                    "where c.type='Customer' and c.id <> -1 and isnull(cu.active,'F')='T' and r.companyid="+Connection.CompanyID+" and isnull(active,'F')='T' "+
                    "order by [Customer],[Name]";
                daCustContact.Fill(dsCustContact1);
                CustomerContactLoaded = true;
            }
        }

        private void lueProjNum_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!ProjLoaded)
            {
                daProjNum.Fill(dsProjNum1);
                ProjLoaded = true;
            }
        }

        private void lueCustomer_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!CustomerLoaded)
            {
               // daCustomers.Fill(dsCustomers1);
                ActivateCustomerLookup();
                CustomerLoaded = true;
            }
        }
        private void ActivateCustomerLookup()
        {
            string cmdText = "select customer_id, customer_code, name from customers where isnull(active,'F') = 'T'";
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                cmdText = cmdText + " and isnull(purchaser_type_id,0) <> 4";
            }
            else if (_Flavour == ProjectType.PC_Software_Development)
            {
                cmdText = cmdText + " and isnull(purchaser_type_id,0) <> 4";
            }
            dsCustomers1.Clear();
            daCustomers.SelectCommand.CommandText = cmdText;
            daCustomers.Fill(dsCustomers1);
        }

        private void lueProjMan_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!ProjManagerLoaded)
            {
                daProjManager.Fill(dsProjManager1);
                ProjManagerLoaded = true;
            }
        }

        private void lueEngineer_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!EngineerLoaded)
            {
                daEngineer.Fill(dsEngineer1);
                EngineerLoaded = true;
            }
        }

        private void lueArchitect_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!ArchitectLoaded)
            {
                daArchitect.Fill(dsArchitect1);
                ArchitectLoaded = true;
            }
        }

        private void lueForman_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!FormanLoaded)
            {
                daForman.Fill(dsForman1);
                FormanLoaded = true;
            }
        }

        private void lueFieldManager_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!FieldManagerLoaded)
            {
                daFieldManager.Fill(dsFieldManager1);
                FieldManagerLoaded = true;
            }
        }
        private void lueProjCoordinator_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!ProjCoordinatorLoaded)
            {
                daProjCoordinator.Fill(dsProjCoordinator1);
                ProjCoordinatorLoaded = true;
            }
        }

        private void lueProjAccountant_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!AccountantLoaded)
            {
                daAccountant.Fill(dsAccountant1);
                AccountantLoaded = true;
            }
        }

        private void lueSalesperson_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!SalespersonLoaded)
            {
                daSalesperson.Fill(dsSalesperson1);
                SalespersonLoaded = true;
            }
        }

        private void lueCategory_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!CategoryLoaded)
            {
                daCategory.Fill(dsCategory1);
                CategoryLoaded = true;
            }
        }

        private void lueClass_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!ClassLoaded)
            {
                daClass.Fill(dsClass1);
                ClassLoaded = true;
            }
        }

        private void lueWarehouse_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (!WarehouseLoaded)
            {
                daWarehouse.Fill(dsWarehouse1);
                WarehouseLoaded = true;
            }
        }

        private void cboCustPO_QueryPopUp(object sender, CancelEventArgs e)
        {
            //cboCustPO.Properties.Items.Clear();
            
            //if (!cboCustPO.Text.Trim().Equals(""))
            //{
            //    string sSelect = "select distinct Customer_File_Num from proj_header where Customer_File_Num like '" + cboCustPO.Text + "%' order by Customer_File_Num";
            //    DataTable dtCustPO = Connection.SQLExecutor.ExecuteDataAdapter( sSelect, Connection.TRConnection );
            //    if (dtCustPO != null)
            //    {
            //        foreach( DataRow dr in dtCustPO.Rows )
            //        {
            //            cboCustPO.Properties.Items.Add( dr[0] );
            //        }
            //    }
            //}
        }


        #endregion

        private void gvSearch_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    if (ProjectView_Event != null)
                    {
                        ProjectView_Event(Convert.ToInt32(oPRI_ID));
                    }                    
                }
            }
        }

        #region Actions

        private void hlViewProject_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    if (ProjectView_Event != null)
                    {
                        ProjectView_Event(Convert.ToInt32(oPRI_ID));
                        Valid = true;
                    }
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No project has been selected to view.");
            }
        }

        private void hlEditProj_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    if (ProjectEdit_Event != null)
                    {
                        ProjectEdit_Event(Convert.ToInt32(oPRI_ID));
                        Valid = true;
                    }
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No project has been selected to edit.");
            }
        }

        private void hlCancelProject_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                bool bValid = true;
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    DataRow drx = null;
                    DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter("exec PC_ValidateToCancel " + oPRI_ID.ToString(), Connection.TRConnection);
                    if (Connection.SQLExecutor.Exception != null)
                    {
                        Popup.ShowPopup("Error validating project cancellation:" + Connection.SQLExecutor.Exception.Message);
                        return;
                    }
                    if (dt != null && dt.Rows.Count > 0)
                        drx = dt.Rows[0];
                    if (drx == null)
                        return;

                    if (drx["Valid"] != null && drx["Valid"] != DBNull.Value)
                    {
                        try { bValid = Convert.ToBoolean(drx["Valid"]); }
                        catch { bValid = false; }
                    }
                    string message = "";
                    if (drx["message"] != null && drx["message"] != DBNull.Value)
                    {
                        try { message = drx["message"].ToString(); }
                        catch { message = ""; }
                    }
                    if (!bValid)
                    {
                        Popup.ShowPopup(message);
                        return;
                    }

                    if (Popup.ShowPopup("Are you sure you want to cancel the selected project?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                    {
                        string sUpdate = "update proj_header set pri_status='X' where pri_id=" + oPRI_ID;
                        Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);
                        int iHandle = gvSearch.FocusedRowHandle;
                        dsProject1.Clear();
                        daProject.Fill(dsProject1);
                        gvSearch.FocusedRowHandle = iHandle;
                        Valid = true;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (!Valid)
            {
                Popup.ShowPopup("No project has been selected to cancel.");
            }
        }

        
        private void hlRefresh_Click(object sender, EventArgs e)
        {
            if (ProjLoaded)
            {
                dsProjNum1.Clear();
                daProjNum.Fill(dsProjNum1);
            }
            if (CustomerLoaded)
            {
                //dsCustomers1.Clear();
                //daCustomers.Fill(dsCustomers1);
                ActivateCustomerLookup();
            }
            if (ProjManagerLoaded)
            {
                dsProjManager1.Clear();
                daProjManager.Fill(dsProjManager1);
            }
            if (EngineerLoaded)
            {
                dsEngineer1.Clear();
                daEngineer.Fill(dsEngineer1);
            }
            if (ArchitectLoaded)
            {
                dsArchitect1.Clear();
                daArchitect.Fill(dsArchitect1);
            }
            if (FormanLoaded)
            {
                dsForman1.Clear();
                daForman.Fill(dsForman1);
            }
            if (FieldManagerLoaded)
            {
                dsFieldManager1.Clear();
                daFieldManager.Fill(dsFieldManager1);
            }
            if (AccountantLoaded)
            {
                dsAccountant1.Clear();
                daAccountant.Fill(dsAccountant1);
            }
            if (SalespersonLoaded)
            {
                dsSalesperson1.Clear();
                daSalesperson.Fill(dsSalesperson1);
            }
            if (CategoryLoaded)
            {
                dsCategory1.Clear();
                daCategory.Fill(dsCategory1);
            }
            if (ClassLoaded)
            {
                dsClass1.Clear();
                daClass.Fill(dsClass1);
            }
            if (WarehouseLoaded)
            {
                dsWarehouse1.Clear();
                daWarehouse.Fill(dsWarehouse1);
            }
            if (_Flavour == ProjectType.PC_Land_Construction)
            {
                ds_LandDevelopmentLookups1.Clear();
                da_LandDevelopmentLookups.Fill(ds_LandDevelopmentLookups1);

                dsRawLandProj1.Clear();
                daRawLandProj.Fill(dsRawLandProj1);
            }

        }

        #endregion

        private void gvSearch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLandType = dr[colLandSubType.FieldName];
                if (oLandType != null && oLandType != DBNull.Value)
                {
                    sLandSubType = oLandType.ToString();
                }
                else
                {
                    sLandSubType = "P";
                }

                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    if (ProjectChange_Event != null)
                    {
                        ProjectChange_Event(Convert.ToInt32(oPRI_ID));
                    }
                }
                else
                {
                    if (ProjectChange_Event != null)
                        ProjectChange_Event(-1);
                }
            }
            else
            {
                if (ProjectChange_Event != null)
                    ProjectChange_Event(-1);
            }
        }

        private void dockManager1_Load(object sender, EventArgs e)
        {
            if (b_ClearNonSearchPanel)
            {
                dockManager1.BeginUpdate();

                panelContainer1.RemovePanel(dpActions);
                panelContainer1.Update();

                dpPhoneBook.Close();
                dpQuickView.Close();
                hideContainerBottom.Visible = false;

                dockManager1.EndUpdate();
            }
        }

        private void ucSearch_Resize(object sender, EventArgs e)
        {
            if (dpActions.Visibility != DevExpress.XtraBars.Docking.DockVisibility.Hidden)
                dpActions.Height = 230;
        }

        private void lookUpEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hlViewProject_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {

        }

        private void hlDocumentLibrary_Click(object sender, EventArgs e)
        {
            bool Valid = false;
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPRI_ID = dr["pri_id"];
                if (oPRI_ID != null && oPRI_ID != DBNull.Value)
                {
                    DocumentLibrary.frmLaunch frm = new DocumentLibrary.frmLaunch(Connection, DevXMgr, DocumentLibrary.LaunchTypes.Project, Convert.ToInt32(oPRI_ID));
                    frm.ShowDialog();
                    frm.Dispose();
                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void HideSomeActions()
        {
            layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

        }

        private void cboCustPO_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ComboBoxUtil.loadDropDown(cboCustPO, Connection, false,
                "select distinct Customer_File_Num from proj_header where Customer_File_Num like % order by Customer_File_Num");
        }

        private void hlCancelProject_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {

        }

        private void beBaseFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr["BaseFolder"].ToString() != "")
                Process.Start(dr["BaseFolder"].ToString());
        }

        private void SetupUDF()
        {
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                udc = new UDF_Conditioner.UDFConditioner(Connection, gvSearch, "General Construction Project", "PGC", dsProject1, true, DevXMgr);
            }
            else if (_Flavour == ProjectType.PC_Land_Construction)
            {
                udc = new UDF_Conditioner.UDFConditioner(Connection, gvSearch, "Land Development Project", "PLC", dsProject1, true, DevXMgr);
            }
            else if (_Flavour == ProjectType.PC_Unit_Construction)
            {

                udc = new UDF_Conditioner.UDFConditioner(Connection, gvSearch, "Unit Com/Res Project", "PUC", dsProject1, true, DevXMgr);
            }
            else if (_Flavour == ProjectType.PC_Homebuilder)
            {
                udc = new UDF_Conditioner.UDFConditioner(Connection, gvSearch, "Homebuilder Project", "PHC", dsProject1, true, DevXMgr);

            }
            else if (_Flavour == ProjectType.PC_Software_Development)
            {
                udc = new UDF_Conditioner.UDFConditioner(Connection, gvSearch, "Software Development Project", "PSD", dsProject1, true, DevXMgr);


            }
            udc.InitializeColumns();
        }

        private void LoadUDFs()
        {
            
            if (_Flavour == ProjectType.PC_General_Construction)
            {
                udc.FillColumns("pri_id", dsProject1.Tables[0], "PGC");
            }
            else if (_Flavour == ProjectType.PC_Land_Construction)
            {
                udc.FillColumns("pri_id", dsProject1.Tables[0], "PLC");
            }
            else if (_Flavour == ProjectType.PC_Unit_Construction)
            {
                udc.FillColumns("pri_id", dsProject1.Tables[0], "PUC");
            }
            else if (_Flavour == ProjectType.PC_Homebuilder)
            {
                udc.FillColumns("pri_id", dsProject1.Tables[0], "PHC");
            }
            else if (_Flavour == ProjectType.PC_Software_Development)
            {
                udc.FillColumns("pri_id", dsProject1.Tables[0], "PSD");
            }
        }

        private void lueRawLandHolding_QueryPopUp(object sender, CancelEventArgs e)
        {

        }
        

        
    }
}
