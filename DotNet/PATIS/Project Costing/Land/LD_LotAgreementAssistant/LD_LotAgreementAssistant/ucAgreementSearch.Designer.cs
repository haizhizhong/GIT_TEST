namespace LD_LotAgreementAssistant
{
    partial class ucAgreementSearch
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAgreementSearch));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpnlSearch = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luePurchaser = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_purchaser = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SearchLookups1 = new LD_LotAgreementAssistant.ds_SearchLookups();
            this.lueProject = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_project = new System.Windows.Forms.BindingSource(this.components);
            this.lueCommunity = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_Communities = new System.Windows.Forms.BindingSource(this.components);
            this.lueAgreementStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueAgreementNum = new DevExpress.XtraEditors.LookUpEdit();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueMasterAgreement = new DevExpress.XtraEditors.LookUpEdit();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lueAgreementType = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_AgreementType = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gcAgreementSelection = new DevExpress.XtraGrid.GridControl();
            this.ds_AgreementSearch1 = new LD_LotAgreementAssistant.ds_AgreementSearch();
            this.gvAgreementSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproj_lot_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueProject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colagreement_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpurchaser_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpurchaser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpre_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsell_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teNumaric2ReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colgst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_ceBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colgst_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpst_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_sell_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasteragreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunities_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueCommunity = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_AgreementSearch = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_SearchLookups = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dpnlSearch.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePurchaser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SearchLookups1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCommunity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Communities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMasterAgreement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AgreementType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAgreementSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_AgreementSearch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgreementSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumaric2ReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCommunity)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager
            // 
            this.dockManager.DockingOptions.ShowCloseButton = false;
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpnlSearch});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpnlSearch
            // 
            this.dpnlSearch.Controls.Add(this.dockPanel1_Container);
            this.dpnlSearch.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dpnlSearch.ID = new System.Guid("a2c09973-937f-42ff-9ff5-a2fc90263a43");
            this.dpnlSearch.Location = new System.Drawing.Point(792, 0);
            this.dpnlSearch.Name = "dpnlSearch";
            this.dpnlSearch.Size = new System.Drawing.Size(315, 650);
            this.dpnlSearch.Text = "Search";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Controls.Add(this.panelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(309, 622);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.luePurchaser);
            this.layoutControl1.Controls.Add(this.lueProject);
            this.layoutControl1.Controls.Add(this.lueCommunity);
            this.layoutControl1.Controls.Add(this.lueAgreementStatus);
            this.layoutControl1.Controls.Add(this.lueAgreementNum);
            this.layoutControl1.Controls.Add(this.lueMasterAgreement);
            this.layoutControl1.Controls.Add(this.lueAgreementType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(309, 584);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luePurchaser
            // 
            this.luePurchaser.Location = new System.Drawing.Point(112, 193);
            this.luePurchaser.Name = "luePurchaser";
            this.luePurchaser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luePurchaser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Name", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMER_CODE", "Code", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luePurchaser.Properties.DataSource = this.bs_purchaser;
            this.luePurchaser.Properties.DisplayMember = "NAME";
            this.luePurchaser.Properties.NullText = "";
            this.luePurchaser.Properties.ValueMember = "CUSTOMER_ID";
            this.luePurchaser.Size = new System.Drawing.Size(191, 20);
            this.luePurchaser.StyleController = this.layoutControl1;
            this.luePurchaser.TabIndex = 10;
            this.luePurchaser.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // bs_purchaser
            // 
            this.bs_purchaser.DataMember = "Table6";
            this.bs_purchaser.DataSource = this.ds_SearchLookups1;
            // 
            // ds_SearchLookups1
            // 
            this.ds_SearchLookups1.DataSetName = "ds_SearchLookups";
            this.ds_SearchLookups1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueProject
            // 
            this.lueProject.Location = new System.Drawing.Point(112, 162);
            this.lueProject.Name = "lueProject";
            this.lueProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueProject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_name", "Project Name", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_code", "Project #", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueProject.Properties.DataSource = this.bs_project;
            this.lueProject.Properties.DisplayMember = "pri_name";
            this.lueProject.Properties.NullText = "";
            this.lueProject.Properties.PopupWidth = 300;
            this.lueProject.Properties.ValueMember = "pri_id";
            this.lueProject.Size = new System.Drawing.Size(191, 20);
            this.lueProject.StyleController = this.layoutControl1;
            this.lueProject.TabIndex = 9;
            this.lueProject.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // bs_project
            // 
            this.bs_project.DataMember = "Table5";
            this.bs_project.DataSource = this.ds_SearchLookups1;
            // 
            // lueCommunity
            // 
            this.lueCommunity.Location = new System.Drawing.Point(112, 131);
            this.lueCommunity.Name = "lueCommunity";
            this.lueCommunity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueCommunity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Communities", "Community", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueCommunity.Properties.DataSource = this.bs_Communities;
            this.lueCommunity.Properties.DisplayMember = "Communities";
            this.lueCommunity.Properties.NullText = "";
            this.lueCommunity.Properties.ValueMember = "Communities_ID";
            this.lueCommunity.Size = new System.Drawing.Size(191, 20);
            this.lueCommunity.StyleController = this.layoutControl1;
            this.lueCommunity.TabIndex = 8;
            this.lueCommunity.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // bs_Communities
            // 
            this.bs_Communities.DataMember = "Table4";
            this.bs_Communities.DataSource = this.ds_SearchLookups1;
            // 
            // lueAgreementStatus
            // 
            this.lueAgreementStatus.Location = new System.Drawing.Point(112, 7);
            this.lueAgreementStatus.Name = "lueAgreementStatus";
            this.lueAgreementStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueAgreementStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueAgreementStatus.Properties.DataSource = this.table3BindingSource;
            this.lueAgreementStatus.Properties.DisplayMember = "Description";
            this.lueAgreementStatus.Properties.NullText = "";
            this.lueAgreementStatus.Properties.ValueMember = "Agreement_Status_ID";
            this.lueAgreementStatus.Size = new System.Drawing.Size(191, 20);
            this.lueAgreementStatus.StyleController = this.layoutControl1;
            this.lueAgreementStatus.TabIndex = 7;
            this.lueAgreementStatus.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table3";
            this.table3BindingSource.DataSource = this.ds_SearchLookups1;
            // 
            // lueAgreementNum
            // 
            this.lueAgreementNum.Location = new System.Drawing.Point(112, 100);
            this.lueAgreementNum.Name = "lueAgreementNum";
            this.lueAgreementNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueAgreementNum.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agreement_Num", "Agreement #", 103, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lueAgreementNum.Properties.DataSource = this.table1BindingSource;
            this.lueAgreementNum.Properties.DisplayMember = "Agreement_Num";
            this.lueAgreementNum.Properties.NullText = "";
            this.lueAgreementNum.Properties.ValueMember = "agreement_id";
            this.lueAgreementNum.Size = new System.Drawing.Size(191, 20);
            this.lueAgreementNum.StyleController = this.layoutControl1;
            this.lueAgreementNum.TabIndex = 6;
            this.lueAgreementNum.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.ds_SearchLookups1;
            // 
            // lueMasterAgreement
            // 
            this.lueMasterAgreement.Location = new System.Drawing.Point(112, 69);
            this.lueMasterAgreement.Name = "lueMasterAgreement";
            this.lueMasterAgreement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueMasterAgreement.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASTER_AGREEMENT_NUM", "Agreement #", 157, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lueMasterAgreement.Properties.DataSource = this.table2BindingSource;
            this.lueMasterAgreement.Properties.DisplayMember = "MASTER_AGREEMENT_NUM";
            this.lueMasterAgreement.Properties.NullText = "";
            this.lueMasterAgreement.Properties.ValueMember = "ID";
            this.lueMasterAgreement.Size = new System.Drawing.Size(191, 20);
            this.lueMasterAgreement.StyleController = this.layoutControl1;
            this.lueMasterAgreement.TabIndex = 5;
            this.lueMasterAgreement.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table2";
            this.table2BindingSource.DataSource = this.ds_SearchLookups1;
            // 
            // lueAgreementType
            // 
            this.lueAgreementType.Location = new System.Drawing.Point(112, 38);
            this.lueAgreementType.Name = "lueAgreementType";
            this.lueAgreementType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueAgreementType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueAgreementType.Properties.DataSource = this.bs_AgreementType;
            this.lueAgreementType.Properties.DisplayMember = "Description";
            this.lueAgreementType.Properties.NullText = "";
            this.lueAgreementType.Properties.ValueMember = "Value";
            this.lueAgreementType.Size = new System.Drawing.Size(191, 20);
            this.lueAgreementType.StyleController = this.layoutControl1;
            this.lueAgreementType.TabIndex = 4;
            this.lueAgreementType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookupsButtonClick);
            // 
            // bs_AgreementType
            // 
            this.bs_AgreementType.DataMember = "LD_laa_AgreementSearchLookups";
            this.bs_AgreementType.DataSource = this.ds_SearchLookups1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(309, 584);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueAgreementType;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem1.Text = "Agreement Type";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueMasterAgreement;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem2.Text = "Master Agreement #";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueAgreementNum;
            this.layoutControlItem3.CustomizationFormText = "Agreement #";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem3.Text = "Agreement #";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueAgreementStatus;
            this.layoutControlItem4.CustomizationFormText = "Status";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem4.Text = "Status";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueCommunity;
            this.layoutControlItem5.CustomizationFormText = "Community";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem5.Text = "Community";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lueProject;
            this.layoutControlItem6.CustomizationFormText = "Project";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 155);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(307, 31);
            this.layoutControlItem6.Text = "Project";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.luePurchaser;
            this.layoutControlItem7.CustomizationFormText = "Purchaser";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(307, 396);
            this.layoutControlItem7.Text = "Purchaser";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(100, 13);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClear);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 584);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(309, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gcAgreementSelection
            // 
            this.gcAgreementSelection.DataMember = "working_ld_laa_AgreementSearch";
            this.gcAgreementSelection.DataSource = this.ds_AgreementSearch1;
            this.gcAgreementSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAgreementSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAgreementSelection.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAgreementSelection.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAgreementSelection.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAgreementSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAgreementSelection.Location = new System.Drawing.Point(0, 0);
            this.gcAgreementSelection.MainView = this.gvAgreementSelection;
            this.gcAgreementSelection.Name = "gcAgreementSelection";
            this.gcAgreementSelection.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.teNumaric2ReadOnly,
            this.ri_ceBool,
            this.ri_lueProject,
            this.ri_lueCommunity});
            this.gcAgreementSelection.Size = new System.Drawing.Size(792, 650);
            this.gcAgreementSelection.TabIndex = 1;
            this.gcAgreementSelection.UseEmbeddedNavigator = true;
            this.gcAgreementSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgreementSelection});
            // 
            // ds_AgreementSearch1
            // 
            this.ds_AgreementSearch1.DataSetName = "ds_AgreementSearch";
            this.ds_AgreementSearch1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAgreementSelection
            // 
            this.gvAgreementSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colagreement_id,
            this.colproj_lot_id,
            this.colpri_id,
            this.colagreement_type,
            this.colagreement_num,
            this.colpurchaser_code,
            this.colpurchaser,
            this.colagreement_status_id,
            this.colagreement_status,
            this.collot_num,
            this.colblock_num,
            this.colplan_num,
            this.colpre_sale,
            this.colsell_price,
            this.colgst,
            this.colgst_value,
            this.colpst,
            this.colpst_value,
            this.coltotal_sell_price,
            this.colmasteragreement_id,
            this.colCommunities_ID});
            this.gvAgreementSelection.GridControl = this.gcAgreementSelection;
            this.gvAgreementSelection.Name = "gvAgreementSelection";
            this.gvAgreementSelection.OptionsBehavior.Editable = false;
            this.gvAgreementSelection.OptionsView.ColumnAutoWidth = false;
            this.gvAgreementSelection.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAgreementSelection_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.Width = 23;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername.Width = 59;
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colagreement_id.Width = 78;
            // 
            // colproj_lot_id
            // 
            this.colproj_lot_id.FieldName = "proj_lot_id";
            this.colproj_lot_id.Name = "colproj_lot_id";
            this.colproj_lot_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colproj_lot_id.Width = 63;
            // 
            // colpri_id
            // 
            this.colpri_id.Caption = "Project";
            this.colpri_id.ColumnEdit = this.ri_lueProject;
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colpri_id.Visible = true;
            this.colpri_id.VisibleIndex = 13;
            this.colpri_id.Width = 114;
            // 
            // ri_lueProject
            // 
            this.ri_lueProject.AutoHeight = false;
            this.ri_lueProject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueProject.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_name", "Project", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueProject.DataSource = this.bs_project;
            this.ri_lueProject.DisplayMember = "pri_name";
            this.ri_lueProject.Name = "ri_lueProject";
            this.ri_lueProject.NullText = "";
            this.ri_lueProject.ReadOnly = true;
            this.ri_lueProject.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.ri_lueProject.ValueMember = "pri_id";
            // 
            // colagreement_type
            // 
            this.colagreement_type.Caption = "Agreement Type";
            this.colagreement_type.FieldName = "agreement_type";
            this.colagreement_type.Name = "colagreement_type";
            this.colagreement_type.Visible = true;
            this.colagreement_type.VisibleIndex = 0;
            this.colagreement_type.Width = 102;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 2;
            this.colagreement_num.Width = 100;
            // 
            // colpurchaser_code
            // 
            this.colpurchaser_code.Caption = "Purchaser Code";
            this.colpurchaser_code.FieldName = "purchaser_code";
            this.colpurchaser_code.Name = "colpurchaser_code";
            this.colpurchaser_code.Width = 99;
            // 
            // colpurchaser
            // 
            this.colpurchaser.Caption = "Purchaser";
            this.colpurchaser.FieldName = "purchaser";
            this.colpurchaser.Name = "colpurchaser";
            this.colpurchaser.Visible = true;
            this.colpurchaser.VisibleIndex = 3;
            this.colpurchaser.Width = 70;
            // 
            // colagreement_status_id
            // 
            this.colagreement_status_id.FieldName = "agreement_status_id";
            this.colagreement_status_id.Name = "colagreement_status_id";
            this.colagreement_status_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colagreement_status_id.Width = 114;
            // 
            // colagreement_status
            // 
            this.colagreement_status.Caption = "Status";
            this.colagreement_status.FieldName = "agreement_status";
            this.colagreement_status.Name = "colagreement_status";
            this.colagreement_status.Visible = true;
            this.colagreement_status.VisibleIndex = 4;
            this.colagreement_status.Width = 110;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 6;
            this.collot_num.Width = 60;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 7;
            this.colblock_num.Width = 72;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 5;
            this.colplan_num.Width = 68;
            // 
            // colpre_sale
            // 
            this.colpre_sale.Caption = "Pre-Sale";
            this.colpre_sale.FieldName = "pre_sale";
            this.colpre_sale.Name = "colpre_sale";
            this.colpre_sale.Visible = true;
            this.colpre_sale.VisibleIndex = 8;
            this.colpre_sale.Width = 63;
            // 
            // colsell_price
            // 
            this.colsell_price.Caption = "Sell Price";
            this.colsell_price.ColumnEdit = this.teNumaric2ReadOnly;
            this.colsell_price.FieldName = "sell_price";
            this.colsell_price.Name = "colsell_price";
            this.colsell_price.Visible = true;
            this.colsell_price.VisibleIndex = 9;
            this.colsell_price.Width = 66;
            // 
            // teNumaric2ReadOnly
            // 
            this.teNumaric2ReadOnly.AutoHeight = false;
            this.teNumaric2ReadOnly.DisplayFormat.FormatString = "N2";
            this.teNumaric2ReadOnly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teNumaric2ReadOnly.EditFormat.FormatString = "N2";
            this.teNumaric2ReadOnly.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teNumaric2ReadOnly.Name = "teNumaric2ReadOnly";
            this.teNumaric2ReadOnly.ReadOnly = true;
            // 
            // colgst
            // 
            this.colgst.ColumnEdit = this.ri_ceBool;
            this.colgst.FieldName = "gst";
            this.colgst.Name = "colgst";
            this.colgst.Visible = true;
            this.colgst.VisibleIndex = 10;
            this.colgst.Width = 76;
            // 
            // ri_ceBool
            // 
            this.ri_ceBool.AutoHeight = false;
            this.ri_ceBool.Name = "ri_ceBool";
            this.ri_ceBool.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colgst_value
            // 
            this.colgst_value.ColumnEdit = this.teNumaric2ReadOnly;
            this.colgst_value.FieldName = "gst_value";
            this.colgst_value.Name = "colgst_value";
            this.colgst_value.OptionsColumn.ShowInCustomizationForm = false;
            this.colgst_value.Width = 69;
            // 
            // colpst
            // 
            this.colpst.ColumnEdit = this.ri_ceBool;
            this.colpst.FieldName = "pst";
            this.colpst.Name = "colpst";
            this.colpst.Visible = true;
            this.colpst.VisibleIndex = 11;
            this.colpst.Width = 81;
            // 
            // colpst_value
            // 
            this.colpst_value.ColumnEdit = this.teNumaric2ReadOnly;
            this.colpst_value.FieldName = "pst_value";
            this.colpst_value.Name = "colpst_value";
            this.colpst_value.OptionsColumn.ShowInCustomizationForm = false;
            this.colpst_value.Width = 69;
            // 
            // coltotal_sell_price
            // 
            this.coltotal_sell_price.Caption = "Total Sell Price";
            this.coltotal_sell_price.ColumnEdit = this.teNumaric2ReadOnly;
            this.coltotal_sell_price.FieldName = "total_sell_price";
            this.coltotal_sell_price.Name = "coltotal_sell_price";
            this.coltotal_sell_price.Visible = true;
            this.coltotal_sell_price.VisibleIndex = 12;
            this.coltotal_sell_price.Width = 94;
            // 
            // colmasteragreement_id
            // 
            this.colmasteragreement_id.Caption = "Master Agreement #";
            this.colmasteragreement_id.FieldName = "masteragreement_id";
            this.colmasteragreement_id.Name = "colmasteragreement_id";
            this.colmasteragreement_id.Visible = true;
            this.colmasteragreement_id.VisibleIndex = 1;
            this.colmasteragreement_id.Width = 122;
            // 
            // colCommunities_ID
            // 
            this.colCommunities_ID.Caption = "Community";
            this.colCommunities_ID.ColumnEdit = this.ri_lueCommunity;
            this.colCommunities_ID.FieldName = "Communities_ID";
            this.colCommunities_ID.Name = "colCommunities_ID";
            this.colCommunities_ID.Visible = true;
            this.colCommunities_ID.VisibleIndex = 14;
            // 
            // ri_lueCommunity
            // 
            this.ri_lueCommunity.AutoHeight = false;
            this.ri_lueCommunity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueCommunity.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Communities", "Community", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueCommunity.DataSource = this.bs_Communities;
            this.ri_lueCommunity.DisplayMember = "Communities";
            this.ri_lueCommunity.Name = "ri_lueCommunity";
            this.ri_lueCommunity.NullText = "";
            this.ri_lueCommunity.ReadOnly = true;
            this.ri_lueCommunity.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.ri_lueCommunity.ValueMember = "Communities_ID";
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_type", System.Data.SqlDbType.VarChar, 0, "agreement_type"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@purchaser_code", System.Data.SqlDbType.VarChar, 0, "purchaser_code"),
            new System.Data.SqlClient.SqlParameter("@purchaser", System.Data.SqlDbType.VarChar, 0, "purchaser"),
            new System.Data.SqlClient.SqlParameter("@agreement_status_id", System.Data.SqlDbType.Int, 0, "agreement_status_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_status", System.Data.SqlDbType.VarChar, 0, "agreement_status"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@pre_sale", System.Data.SqlDbType.Bit, 0, "pre_sale"),
            new System.Data.SqlClient.SqlParameter("@sell_price", System.Data.SqlDbType.Money, 0, "sell_price"),
            new System.Data.SqlClient.SqlParameter("@gst", System.Data.SqlDbType.Bit, 0, "gst"),
            new System.Data.SqlClient.SqlParameter("@gst_value", System.Data.SqlDbType.Money, 0, "gst_value"),
            new System.Data.SqlClient.SqlParameter("@pst", System.Data.SqlDbType.Bit, 0, "pst"),
            new System.Data.SqlClient.SqlParameter("@pst_value", System.Data.SqlDbType.Money, 0, "pst_value"),
            new System.Data.SqlClient.SqlParameter("@total_sell_price", System.Data.SqlDbType.Money, 0, "total_sell_price"),
            new System.Data.SqlClient.SqlParameter("@masteragreement_id", System.Data.SqlDbType.Int, 0, "masteragreement_id"),
            new System.Data.SqlClient.SqlParameter("@Communities_ID", System.Data.SqlDbType.Int, 0, "Communities_ID")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_type", System.Data.SqlDbType.VarChar, 0, "agreement_type"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@purchaser_code", System.Data.SqlDbType.VarChar, 0, "purchaser_code"),
            new System.Data.SqlClient.SqlParameter("@purchaser", System.Data.SqlDbType.VarChar, 0, "purchaser"),
            new System.Data.SqlClient.SqlParameter("@agreement_status_id", System.Data.SqlDbType.Int, 0, "agreement_status_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_status", System.Data.SqlDbType.VarChar, 0, "agreement_status"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@pre_sale", System.Data.SqlDbType.Bit, 0, "pre_sale"),
            new System.Data.SqlClient.SqlParameter("@sell_price", System.Data.SqlDbType.Money, 0, "sell_price"),
            new System.Data.SqlClient.SqlParameter("@gst", System.Data.SqlDbType.Bit, 0, "gst"),
            new System.Data.SqlClient.SqlParameter("@gst_value", System.Data.SqlDbType.Money, 0, "gst_value"),
            new System.Data.SqlClient.SqlParameter("@pst", System.Data.SqlDbType.Bit, 0, "pst"),
            new System.Data.SqlClient.SqlParameter("@pst_value", System.Data.SqlDbType.Money, 0, "pst_value"),
            new System.Data.SqlClient.SqlParameter("@total_sell_price", System.Data.SqlDbType.Money, 0, "total_sell_price"),
            new System.Data.SqlClient.SqlParameter("@masteragreement_id", System.Data.SqlDbType.Int, 0, "masteragreement_id"),
            new System.Data.SqlClient.SqlParameter("@Communities_ID", System.Data.SqlDbType.Int, 0, "Communities_ID"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pre_sale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pre_sale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst_value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst_value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst_value", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst_value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst_value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst_value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst_value", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst_value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_total_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "total_sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_total_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "total_sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Communities_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Communities_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Communities_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Communities_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pre_sale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pre_sale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst_value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst_value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst_value", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst_value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst_value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst_value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst_value", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst_value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_total_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "total_sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_total_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "total_sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Communities_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Communities_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Communities_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Communities_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // da_AgreementSearch
            // 
            this.da_AgreementSearch.DeleteCommand = this.sqlDeleteCommand1;
            this.da_AgreementSearch.InsertCommand = this.sqlInsertCommand1;
            this.da_AgreementSearch.SelectCommand = this.sqlSelectCommand1;
            this.da_AgreementSearch.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_laa_AgreementSearch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_type", "agreement_type"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("purchaser_code", "purchaser_code"),
                        new System.Data.Common.DataColumnMapping("purchaser", "purchaser"),
                        new System.Data.Common.DataColumnMapping("agreement_status_id", "agreement_status_id"),
                        new System.Data.Common.DataColumnMapping("agreement_status", "agreement_status"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("pre_sale", "pre_sale"),
                        new System.Data.Common.DataColumnMapping("sell_price", "sell_price"),
                        new System.Data.Common.DataColumnMapping("gst", "gst"),
                        new System.Data.Common.DataColumnMapping("gst_value", "gst_value"),
                        new System.Data.Common.DataColumnMapping("pst", "pst"),
                        new System.Data.Common.DataColumnMapping("pst_value", "pst_value"),
                        new System.Data.Common.DataColumnMapping("total_sell_price", "total_sell_price"),
                        new System.Data.Common.DataColumnMapping("masteragreement_id", "masteragreement_id"),
                        new System.Data.Common.DataColumnMapping("Communities_ID", "Communities_ID")})});
            this.da_AgreementSearch.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.LD_laa_AgreementSearchLookups";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // da_SearchLookups
            // 
            this.da_SearchLookups.SelectCommand = this.sqlSelectCommand2;
            this.da_SearchLookups.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_laa_AgreementSearchLookups", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Value", "Value")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Agreement_Num", "Agreement_Num"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id")}),
            new System.Data.Common.DataTableMapping("Table2", "Table2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MASTER_AGREEMENT_NUM", "MASTER_AGREEMENT_NUM"),
                        new System.Data.Common.DataColumnMapping("ID", "ID")}),
            new System.Data.Common.DataTableMapping("Table3", "Table3", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Agreement_Status_ID", "Agreement_Status_ID")}),
            new System.Data.Common.DataTableMapping("Table4", "Table4", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Communities_ID", "Communities_ID"),
                        new System.Data.Common.DataColumnMapping("Communities", "Communities")}),
            new System.Data.Common.DataTableMapping("Table5", "Table5", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name")}),
            new System.Data.Common.DataTableMapping("Table6", "Table6", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CUSTOMER_ID", "CUSTOMER_ID"),
                        new System.Data.Common.DataColumnMapping("CUSTOMER_CODE", "CUSTOMER_CODE"),
                        new System.Data.Common.DataColumnMapping("NAME", "NAME")})});
            // 
            // ucAgreementSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcAgreementSelection);
            this.Controls.Add(this.dpnlSearch);
            this.Name = "ucAgreementSearch";
            this.Size = new System.Drawing.Size(1107, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dpnlSearch.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luePurchaser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SearchLookups1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCommunity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Communities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMasterAgreement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAgreementType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AgreementType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAgreementSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_AgreementSearch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgreementSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumaric2ReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCommunity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dpnlSearch;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcAgreementSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgreementSelection;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit lueAgreementType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter da_AgreementSearch;
        private ds_AgreementSearch ds_AgreementSearch1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraGrid.Columns.GridColumn colproj_lot_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_type;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_status_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_status;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colpre_sale;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_price;
        private DevExpress.XtraGrid.Columns.GridColumn colgst;
        private DevExpress.XtraGrid.Columns.GridColumn colgst_value;
        private DevExpress.XtraGrid.Columns.GridColumn colpst;
        private DevExpress.XtraGrid.Columns.GridColumn colpst_value;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_sell_price;
        private DevExpress.XtraEditors.LookUpEdit lueAgreementStatus;
        private DevExpress.XtraEditors.LookUpEdit lueAgreementNum;
        private DevExpress.XtraEditors.LookUpEdit lueMasterAgreement;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_SearchLookups;
        private ds_SearchLookups ds_SearchLookups1;
        private System.Windows.Forms.BindingSource bs_AgreementType;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit teNumaric2ReadOnly;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceBool;
        private DevExpress.XtraGrid.Columns.GridColumn colmasteragreement_id;
        private DevExpress.XtraEditors.LookUpEdit luePurchaser;
        private DevExpress.XtraEditors.LookUpEdit lueProject;
        private DevExpress.XtraEditors.LookUpEdit lueCommunity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource bs_purchaser;
        private System.Windows.Forms.BindingSource bs_project;
        private System.Windows.Forms.BindingSource bs_Communities;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueProject;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunities_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueCommunity;
    }
}
