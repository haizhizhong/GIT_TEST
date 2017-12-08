namespace LD_LevyAssistant
{
    partial class ucUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUpdate));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpUpdate = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrintPreRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.teNewAmount = new DevExpress.XtraEditors.TextEdit();
            this.lueLotClass = new DevExpress.XtraEditors.LookUpEdit();
            this.lDLotClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLotClass1 = new LD_LevyAssistant.dsLotClass();
            this.lueDescription = new DevExpress.XtraEditors.LookUpEdit();
            this.lDLevyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevy1 = new LD_LevyAssistant.dsLevy();
            this.lueLevyType = new DevExpress.XtraEditors.LookUpEdit();
            this.bsLevyType = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevyType1 = new LD_LevyAssistant.dsLevyType();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcLevyUpdate = new DevExpress.XtraGrid.GridControl();
            this.bsLevyUpdate = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevyUpdate1 = new LD_LevyAssistant.dsLevyUpdate();
            this.gvLevyUpdate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlock_Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlan_Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_Class_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_ClassCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevyType_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevyDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevy_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNewAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProj_lot_agreement_levy_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daLevyUpdate = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daLevyType = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daLevy = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.daLotClass = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpUpdate.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNewAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLotClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLotClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLevyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLevyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLevyUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLevyUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyUpdate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLevyUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpUpdate});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dpUpdate
            // 
            this.dpUpdate.Controls.Add(this.dockPanel1_Container);
            this.dpUpdate.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dpUpdate.ID = new System.Guid("1b72ab97-cd03-4653-b432-5488b0354aeb");
            this.dpUpdate.Location = new System.Drawing.Point(827, 0);
            this.dpUpdate.Name = "dpUpdate";
            this.dpUpdate.OriginalSize = new System.Drawing.Size(351, 200);
            this.dpUpdate.Size = new System.Drawing.Size(351, 752);
            this.dpUpdate.Text = "Update";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(342, 725);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrintPreRegister);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClear);
            this.layoutControl1.Controls.Add(this.teNewAmount);
            this.layoutControl1.Controls.Add(this.lueLotClass);
            this.layoutControl1.Controls.Add(this.lueDescription);
            this.layoutControl1.Controls.Add(this.lueLevyType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(342, 725);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrintPreRegister
            // 
            this.btnPrintPreRegister.Location = new System.Drawing.Point(140, 356);
            this.btnPrintPreRegister.Name = "btnPrintPreRegister";
            this.btnPrintPreRegister.Size = new System.Drawing.Size(190, 22);
            this.btnPrintPreRegister.StyleController = this.layoutControl1;
            this.btnPrintPreRegister.TabIndex = 10;
            this.btnPrintPreRegister.Text = "Print Register";
            this.btnPrintPreRegister.Click += new System.EventHandler(this.btnPrintPreRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 22);
            this.btnUpdate.StyleController = this.layoutControl1;
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 22);
            this.btnClear.StyleController = this.layoutControl1;
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // teNewAmount
            // 
            this.teNewAmount.Location = new System.Drawing.Point(76, 306);
            this.teNewAmount.Name = "teNewAmount";
            this.teNewAmount.Properties.Mask.EditMask = "n";
            this.teNewAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNewAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teNewAmount.Properties.MaxLength = 12;
            this.teNewAmount.Size = new System.Drawing.Size(254, 20);
            this.teNewAmount.StyleController = this.layoutControl1;
            this.teNewAmount.TabIndex = 7;
            // 
            // lueLotClass
            // 
            this.lueLotClass.Location = new System.Drawing.Point(76, 60);
            this.lueLotClass.Name = "lueLotClass";
            this.lueLotClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLotClass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lot_Class_ID", "Lot_Class_ID", 86, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueLotClass.Properties.DataSource = this.lDLotClassBindingSource;
            this.lueLotClass.Properties.DisplayMember = "Code";
            this.lueLotClass.Properties.NullText = "";
            this.lueLotClass.Properties.ValueMember = "Lot_Class_ID";
            this.lueLotClass.Size = new System.Drawing.Size(254, 20);
            this.lueLotClass.StyleController = this.layoutControl1;
            this.lueLotClass.TabIndex = 6;
            // 
            // lDLotClassBindingSource
            // 
            this.lDLotClassBindingSource.DataMember = "LD_Lot_Class";
            this.lDLotClassBindingSource.DataSource = this.dsLotClass1;
            // 
            // dsLotClass1
            // 
            this.dsLotClass1.DataSetName = "dsLotClass";
            this.dsLotClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueDescription
            // 
            this.lueDescription.Location = new System.Drawing.Point(76, 36);
            this.lueDescription.Name = "lueDescription";
            this.lueDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDescription.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Levy_ID", "Levy_ID", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LevyType_ID", "Levy Type_ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lot_class_id", "lot_class_id", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lueDescription.Properties.DataSource = this.lDLevyBindingSource;
            this.lueDescription.Properties.DisplayMember = "Description";
            this.lueDescription.Properties.NullText = "";
            this.lueDescription.Properties.ValueMember = "Levy_ID";
            this.lueDescription.Size = new System.Drawing.Size(254, 20);
            this.lueDescription.StyleController = this.layoutControl1;
            this.lueDescription.TabIndex = 5;
            // 
            // lDLevyBindingSource
            // 
            this.lDLevyBindingSource.DataMember = "LD_Levy";
            this.lDLevyBindingSource.DataSource = this.dsLevy1;
            // 
            // dsLevy1
            // 
            this.dsLevy1.DataSetName = "dsLevy";
            this.dsLevy1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueLevyType
            // 
            this.lueLevyType.Location = new System.Drawing.Point(76, 12);
            this.lueLevyType.Name = "lueLevyType";
            this.lueLevyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevyType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LevyType_ID", "Levy Type_ID", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaidTo", "Paid To", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lueLevyType.Properties.DataSource = this.bsLevyType;
            this.lueLevyType.Properties.DisplayMember = "Description";
            this.lueLevyType.Properties.NullText = "";
            this.lueLevyType.Properties.ValueMember = "LevyType_ID";
            this.lueLevyType.Size = new System.Drawing.Size(254, 20);
            this.lueLevyType.StyleController = this.layoutControl1;
            this.lueLevyType.TabIndex = 4;
            // 
            // bsLevyType
            // 
            this.bsLevyType.DataMember = "LD_LevyType";
            this.bsLevyType.DataSource = this.dsLevyType1;
            // 
            // dsLevyType1
            // 
            this.dsLevyType1.DataSetName = "dsLevyType";
            this.dsLevyType1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(342, 725);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueLevyType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(322, 24);
            this.layoutControlItem1.Text = "Levy Type";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(322, 222);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueDescription;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(322, 24);
            this.layoutControlItem2.Text = "Description";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueLotClass;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(322, 24);
            this.layoutControlItem3.Text = "Lot Class";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnClear;
            this.layoutControlItem5.Location = new System.Drawing.Point(128, 318);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(194, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 370);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(322, 335);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnUpdate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 318);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPrintPreRegister;
            this.layoutControlItem7.Location = new System.Drawing.Point(128, 344);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(194, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 344);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(128, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teNewAmount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 294);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(322, 24);
            this.layoutControlItem4.Text = "New Amount";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // gcLevyUpdate
            // 
            this.gcLevyUpdate.DataSource = this.bsLevyUpdate;
            this.gcLevyUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLevyUpdate.Location = new System.Drawing.Point(0, 0);
            this.gcLevyUpdate.MainView = this.gvLevyUpdate;
            this.gcLevyUpdate.Name = "gcLevyUpdate";
            this.gcLevyUpdate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteNumaric2});
            this.gcLevyUpdate.Size = new System.Drawing.Size(827, 752);
            this.gcLevyUpdate.TabIndex = 4;
            this.gcLevyUpdate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLevyUpdate});
            // 
            // bsLevyUpdate
            // 
            this.bsLevyUpdate.DataMember = "working_ld_levy_update";
            this.bsLevyUpdate.DataSource = this.dsLevyUpdate1;
            // 
            // dsLevyUpdate1
            // 
            this.dsLevyUpdate1.DataSetName = "dsLevyUpdate";
            this.dsLevyUpdate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLevyUpdate
            // 
            this.gvLevyUpdate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colPri_id,
            this.colProjectCode,
            this.colProjectName,
            this.colCommunity,
            this.colMunicipality,
            this.colRegion,
            this.colPurchaser_ID,
            this.colPurchaserName,
            this.colLot_num,
            this.colBlock_Num,
            this.colPlan_Num,
            this.colLot_Class_ID,
            this.colLot_ClassCode,
            this.colLevyType_ID,
            this.colLevyType,
            this.colLevyDescription,
            this.colLevy_ID,
            this.colOldAmount,
            this.colNewAmount,
            this.colUpdated,
            this.colProj_lot_agreement_levy_id});
            this.gvLevyUpdate.GridControl = this.gcLevyUpdate;
            this.gvLevyUpdate.Name = "gvLevyUpdate";
            this.gvLevyUpdate.OptionsView.ColumnAutoWidth = false;
            this.gvLevyUpdate.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvLevyUpdate_RowCellStyle);
            this.gvLevyUpdate.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvLevyUpdate_InvalidRowException);
            this.gvLevyUpdate.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvLevyUpdate_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.ReadOnly = true;
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPri_id
            // 
            this.colPri_id.FieldName = "Pri_id";
            this.colPri_id.Name = "colPri_id";
            this.colPri_id.OptionsColumn.AllowEdit = false;
            this.colPri_id.OptionsColumn.ReadOnly = true;
            this.colPri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colProjectCode
            // 
            this.colProjectCode.DisplayFormat.FormatString = "F0";
            this.colProjectCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProjectCode.FieldName = "ProjectCode";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.OptionsColumn.AllowEdit = false;
            this.colProjectCode.OptionsColumn.ReadOnly = true;
            // 
            // colProjectName
            // 
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.OptionsColumn.ReadOnly = true;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 0;
            this.colProjectName.Width = 125;
            // 
            // colCommunity
            // 
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.OptionsColumn.AllowEdit = false;
            this.colCommunity.OptionsColumn.ReadOnly = true;
            this.colCommunity.Width = 110;
            // 
            // colMunicipality
            // 
            this.colMunicipality.FieldName = "Municipality";
            this.colMunicipality.Name = "colMunicipality";
            this.colMunicipality.OptionsColumn.AllowEdit = false;
            this.colMunicipality.OptionsColumn.ReadOnly = true;
            this.colMunicipality.Width = 106;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.OptionsColumn.AllowEdit = false;
            this.colRegion.OptionsColumn.ReadOnly = true;
            this.colRegion.Width = 91;
            // 
            // colPurchaser_ID
            // 
            this.colPurchaser_ID.FieldName = "Purchaser_ID";
            this.colPurchaser_ID.Name = "colPurchaser_ID";
            this.colPurchaser_ID.OptionsColumn.AllowEdit = false;
            this.colPurchaser_ID.OptionsColumn.ReadOnly = true;
            this.colPurchaser_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPurchaserName
            // 
            this.colPurchaserName.FieldName = "PurchaserName";
            this.colPurchaserName.Name = "colPurchaserName";
            this.colPurchaserName.OptionsColumn.AllowEdit = false;
            this.colPurchaserName.OptionsColumn.ReadOnly = true;
            this.colPurchaserName.Visible = true;
            this.colPurchaserName.VisibleIndex = 1;
            this.colPurchaserName.Width = 170;
            // 
            // colLot_num
            // 
            this.colLot_num.Caption = "Lot";
            this.colLot_num.FieldName = "Lot_num";
            this.colLot_num.Name = "colLot_num";
            this.colLot_num.OptionsColumn.AllowEdit = false;
            this.colLot_num.OptionsColumn.ReadOnly = true;
            this.colLot_num.Visible = true;
            this.colLot_num.VisibleIndex = 2;
            // 
            // colBlock_Num
            // 
            this.colBlock_Num.Caption = "Block";
            this.colBlock_Num.FieldName = "Block_Num";
            this.colBlock_Num.Name = "colBlock_Num";
            this.colBlock_Num.OptionsColumn.AllowEdit = false;
            this.colBlock_Num.OptionsColumn.ReadOnly = true;
            this.colBlock_Num.Visible = true;
            this.colBlock_Num.VisibleIndex = 3;
            this.colBlock_Num.Width = 108;
            // 
            // colPlan_Num
            // 
            this.colPlan_Num.FieldName = "Plan_Num";
            this.colPlan_Num.Name = "colPlan_Num";
            this.colPlan_Num.OptionsColumn.AllowEdit = false;
            this.colPlan_Num.OptionsColumn.ReadOnly = true;
            this.colPlan_Num.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colLot_Class_ID
            // 
            this.colLot_Class_ID.FieldName = "Lot_Class_ID";
            this.colLot_Class_ID.Name = "colLot_Class_ID";
            this.colLot_Class_ID.OptionsColumn.AllowEdit = false;
            this.colLot_Class_ID.OptionsColumn.ReadOnly = true;
            this.colLot_Class_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colLot_ClassCode
            // 
            this.colLot_ClassCode.Caption = "Lot Class";
            this.colLot_ClassCode.FieldName = "Lot_ClassCode";
            this.colLot_ClassCode.Name = "colLot_ClassCode";
            this.colLot_ClassCode.OptionsColumn.AllowEdit = false;
            this.colLot_ClassCode.OptionsColumn.ReadOnly = true;
            this.colLot_ClassCode.Visible = true;
            this.colLot_ClassCode.VisibleIndex = 4;
            this.colLot_ClassCode.Width = 108;
            // 
            // colLevyType_ID
            // 
            this.colLevyType_ID.FieldName = "LevyType_ID";
            this.colLevyType_ID.Name = "colLevyType_ID";
            this.colLevyType_ID.OptionsColumn.AllowEdit = false;
            this.colLevyType_ID.OptionsColumn.ReadOnly = true;
            this.colLevyType_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colLevyType
            // 
            this.colLevyType.FieldName = "LevyType";
            this.colLevyType.Name = "colLevyType";
            this.colLevyType.OptionsColumn.AllowEdit = false;
            this.colLevyType.OptionsColumn.ReadOnly = true;
            this.colLevyType.Visible = true;
            this.colLevyType.VisibleIndex = 5;
            this.colLevyType.Width = 96;
            // 
            // colLevyDescription
            // 
            this.colLevyDescription.FieldName = "LevyDescription";
            this.colLevyDescription.Name = "colLevyDescription";
            this.colLevyDescription.OptionsColumn.AllowEdit = false;
            this.colLevyDescription.OptionsColumn.ReadOnly = true;
            this.colLevyDescription.Visible = true;
            this.colLevyDescription.VisibleIndex = 6;
            this.colLevyDescription.Width = 178;
            // 
            // colLevy_ID
            // 
            this.colLevy_ID.FieldName = "Levy_ID";
            this.colLevy_ID.Name = "colLevy_ID";
            this.colLevy_ID.OptionsColumn.AllowEdit = false;
            this.colLevy_ID.OptionsColumn.ReadOnly = true;
            this.colLevy_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOldAmount
            // 
            this.colOldAmount.ColumnEdit = this.riteNumaric2;
            this.colOldAmount.FieldName = "OldAmount";
            this.colOldAmount.Name = "colOldAmount";
            this.colOldAmount.OptionsColumn.AllowEdit = false;
            this.colOldAmount.OptionsColumn.ReadOnly = true;
            this.colOldAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OldAmount", "SUM={0:0.##}")});
            this.colOldAmount.Visible = true;
            this.colOldAmount.VisibleIndex = 7;
            this.colOldAmount.Width = 98;
            // 
            // riteNumaric2
            // 
            this.riteNumaric2.AutoHeight = false;
            this.riteNumaric2.Mask.EditMask = "n";
            this.riteNumaric2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumaric2.Name = "riteNumaric2";
            // 
            // colNewAmount
            // 
            this.colNewAmount.ColumnEdit = this.riteNumaric2;
            this.colNewAmount.FieldName = "NewAmount";
            this.colNewAmount.Name = "colNewAmount";
            this.colNewAmount.OptionsColumn.AllowEdit = false;
            this.colNewAmount.OptionsColumn.ReadOnly = true;
            this.colNewAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NewAmount", "SUM={0:0.##}")});
            this.colNewAmount.Visible = true;
            this.colNewAmount.VisibleIndex = 8;
            this.colNewAmount.Width = 91;
            // 
            // colUpdated
            // 
            this.colUpdated.FieldName = "Updated";
            this.colUpdated.Name = "colUpdated";
            this.colUpdated.OptionsColumn.AllowEdit = false;
            this.colUpdated.OptionsColumn.ReadOnly = true;
            this.colUpdated.Visible = true;
            this.colUpdated.VisibleIndex = 9;
            // 
            // colProj_lot_agreement_levy_id
            // 
            this.colProj_lot_agreement_levy_id.FieldName = "Proj_lot_agreement_levy_id";
            this.colProj_lot_agreement_levy_id.Name = "colProj_lot_agreement_levy_id";
            this.colProj_lot_agreement_levy_id.OptionsColumn.AllowEdit = false;
            this.colProj_lot_agreement_levy_id.OptionsColumn.ReadOnly = true;
            this.colProj_lot_agreement_levy_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DEVSQL2008R2;Initial Catalog=TR_V11_GC;User ID=hmsqlsa;Password=hmsql" +
    "sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@Pri_id", System.Data.SqlDbType.Int, 0, "Pri_id"),
            new System.Data.SqlClient.SqlParameter("@ProjectCode", System.Data.SqlDbType.Int, 0, "ProjectCode"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@Municipality", System.Data.SqlDbType.VarChar, 0, "Municipality"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.VarChar, 0, "Region"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_ID", System.Data.SqlDbType.Int, 0, "Purchaser_ID"),
            new System.Data.SqlClient.SqlParameter("@PurchaserName", System.Data.SqlDbType.VarChar, 0, "PurchaserName"),
            new System.Data.SqlClient.SqlParameter("@Lot_num", System.Data.SqlDbType.VarChar, 0, "Lot_num"),
            new System.Data.SqlClient.SqlParameter("@Block_Num", System.Data.SqlDbType.VarChar, 0, "Block_Num"),
            new System.Data.SqlClient.SqlParameter("@Plan_Num", System.Data.SqlDbType.VarChar, 0, "Plan_Num"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_ID", System.Data.SqlDbType.Int, 0, "Lot_Class_ID"),
            new System.Data.SqlClient.SqlParameter("@Lot_ClassCode", System.Data.SqlDbType.VarChar, 0, "Lot_ClassCode"),
            new System.Data.SqlClient.SqlParameter("@LevyType_ID", System.Data.SqlDbType.Int, 0, "LevyType_ID"),
            new System.Data.SqlClient.SqlParameter("@LevyType", System.Data.SqlDbType.VarChar, 0, "LevyType"),
            new System.Data.SqlClient.SqlParameter("@LevyDescription", System.Data.SqlDbType.VarChar, 0, "LevyDescription"),
            new System.Data.SqlClient.SqlParameter("@Levy_ID", System.Data.SqlDbType.Int, 0, "Levy_ID"),
            new System.Data.SqlClient.SqlParameter("@OldAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "OldAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NewAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Updated", System.Data.SqlDbType.Bit, 0, "Updated"),
            new System.Data.SqlClient.SqlParameter("@Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, "Proj_lot_agreement_levy_id")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@Pri_id", System.Data.SqlDbType.Int, 0, "Pri_id"),
            new System.Data.SqlClient.SqlParameter("@ProjectCode", System.Data.SqlDbType.Int, 0, "ProjectCode"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@Municipality", System.Data.SqlDbType.VarChar, 0, "Municipality"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.VarChar, 0, "Region"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_ID", System.Data.SqlDbType.Int, 0, "Purchaser_ID"),
            new System.Data.SqlClient.SqlParameter("@PurchaserName", System.Data.SqlDbType.VarChar, 0, "PurchaserName"),
            new System.Data.SqlClient.SqlParameter("@Lot_num", System.Data.SqlDbType.VarChar, 0, "Lot_num"),
            new System.Data.SqlClient.SqlParameter("@Block_Num", System.Data.SqlDbType.VarChar, 0, "Block_Num"),
            new System.Data.SqlClient.SqlParameter("@Plan_Num", System.Data.SqlDbType.VarChar, 0, "Plan_Num"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_ID", System.Data.SqlDbType.Int, 0, "Lot_Class_ID"),
            new System.Data.SqlClient.SqlParameter("@Lot_ClassCode", System.Data.SqlDbType.VarChar, 0, "Lot_ClassCode"),
            new System.Data.SqlClient.SqlParameter("@LevyType_ID", System.Data.SqlDbType.Int, 0, "LevyType_ID"),
            new System.Data.SqlClient.SqlParameter("@LevyType", System.Data.SqlDbType.VarChar, 0, "LevyType"),
            new System.Data.SqlClient.SqlParameter("@LevyDescription", System.Data.SqlDbType.VarChar, 0, "LevyDescription"),
            new System.Data.SqlClient.SqlParameter("@Levy_ID", System.Data.SqlDbType.Int, 0, "Levy_ID"),
            new System.Data.SqlClient.SqlParameter("@OldAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "OldAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NewAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Updated", System.Data.SqlDbType.Bit, 0, "Updated"),
            new System.Data.SqlClient.SqlParameter("@Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, "Proj_lot_agreement_levy_id"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Municipality", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Municipality", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Municipality", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Municipality", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Region", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PurchaserName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PurchaserName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PurchaserName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PurchaserName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Block_Num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Block_Num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Block_Num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Block_Num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Plan_Num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Plan_Num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Plan_Num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Plan_Num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_ClassCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_ClassCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_ClassCode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_ClassCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyDescription", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyDescription", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OldAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OldAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OldAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "OldAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NewAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NewAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NewAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Updated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Updated", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Updated", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Updated", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proj_lot_agreement_levy_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proj_lot_agreement_levy_id", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Municipality", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Municipality", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Municipality", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Municipality", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Region", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Region", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PurchaserName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PurchaserName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PurchaserName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PurchaserName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Block_Num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Block_Num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Block_Num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Block_Num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Plan_Num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Plan_Num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Plan_Num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Plan_Num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_ClassCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_ClassCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_ClassCode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_ClassCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyDescription", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyDescription", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OldAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OldAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OldAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "OldAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NewAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NewAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NewAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Updated", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Updated", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Updated", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Updated", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proj_lot_agreement_levy_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proj_lot_agreement_levy_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proj_lot_agreement_levy_id", System.Data.DataRowVersion.Original, null)});
            // 
            // daLevyUpdate
            // 
            this.daLevyUpdate.DeleteCommand = this.sqlDeleteCommand1;
            this.daLevyUpdate.InsertCommand = this.sqlInsertCommand1;
            this.daLevyUpdate.SelectCommand = this.sqlSelectCommand1;
            this.daLevyUpdate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_levy_update", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("Pri_id", "Pri_id"),
                        new System.Data.Common.DataColumnMapping("ProjectCode", "ProjectCode"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"),
                        new System.Data.Common.DataColumnMapping("Community", "Community"),
                        new System.Data.Common.DataColumnMapping("Municipality", "Municipality"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("Purchaser_ID", "Purchaser_ID"),
                        new System.Data.Common.DataColumnMapping("PurchaserName", "PurchaserName"),
                        new System.Data.Common.DataColumnMapping("Lot_num", "Lot_num"),
                        new System.Data.Common.DataColumnMapping("Block_Num", "Block_Num"),
                        new System.Data.Common.DataColumnMapping("Plan_Num", "Plan_Num"),
                        new System.Data.Common.DataColumnMapping("Lot_Class_ID", "Lot_Class_ID"),
                        new System.Data.Common.DataColumnMapping("Lot_ClassCode", "Lot_ClassCode"),
                        new System.Data.Common.DataColumnMapping("LevyType_ID", "LevyType_ID"),
                        new System.Data.Common.DataColumnMapping("LevyType", "LevyType"),
                        new System.Data.Common.DataColumnMapping("LevyDescription", "LevyDescription"),
                        new System.Data.Common.DataColumnMapping("Levy_ID", "Levy_ID"),
                        new System.Data.Common.DataColumnMapping("OldAmount", "OldAmount"),
                        new System.Data.Common.DataColumnMapping("NewAmount", "NewAmount"),
                        new System.Data.Common.DataColumnMapping("Updated", "Updated"),
                        new System.Data.Common.DataColumnMapping("Proj_lot_agreement_levy_id", "Proj_lot_agreement_levy_id")})});
            this.daLevyUpdate.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        LevyType_ID, Description, PaidTo\r\nFROM            LD_LevyType\r\nORDE" +
    "R BY Description";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@PaidTo", System.Data.SqlDbType.VarChar, 0, "PaidTo")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@PaidTo", System.Data.SqlDbType.VarChar, 0, "PaidTo"),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PaidTo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PaidTo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PaidTo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PaidTo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@LevyType_ID", System.Data.SqlDbType.Int, 4, "LevyType_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PaidTo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PaidTo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PaidTo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PaidTo", System.Data.DataRowVersion.Original, null)});
            // 
            // daLevyType
            // 
            this.daLevyType.DeleteCommand = this.sqlDeleteCommand2;
            this.daLevyType.InsertCommand = this.sqlInsertCommand2;
            this.daLevyType.SelectCommand = this.sqlSelectCommand2;
            this.daLevyType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_LevyType", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LevyType_ID", "LevyType_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("PaidTo", "PaidTo")})});
            this.daLevyType.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        Levy_ID, LevyType_ID, Description, lot_class_id\r\nFROM            LD" +
    "_Levy";
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LevyType_ID", System.Data.SqlDbType.Int, 0, "LevyType_ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@lot_class_id", System.Data.SqlDbType.Int, 0, "lot_class_id")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LevyType_ID", System.Data.SqlDbType.Int, 0, "LevyType_ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@lot_class_id", System.Data.SqlDbType.Int, 0, "lot_class_id"),
            new System.Data.SqlClient.SqlParameter("@Original_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Levy_ID", System.Data.SqlDbType.Int, 4, "Levy_ID")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Levy_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Levy_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevyType_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevyType_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_id", System.Data.DataRowVersion.Original, null)});
            // 
            // daLevy
            // 
            this.daLevy.DeleteCommand = this.sqlDeleteCommand3;
            this.daLevy.InsertCommand = this.sqlInsertCommand3;
            this.daLevy.SelectCommand = this.sqlSelectCommand3;
            this.daLevy.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Levy", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Levy_ID", "Levy_ID"),
                        new System.Data.Common.DataColumnMapping("LevyType_ID", "LevyType_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("lot_class_id", "lot_class_id")})});
            this.daLevy.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT        Lot_Class_ID, Code, Description\r\nFROM            LD_Lot_Class\r\nORDE" +
    "R BY Code";
            this.sqlSelectCommand4.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_ID", System.Data.SqlDbType.Int, 4, "Lot_Class_ID")});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = "DELETE FROM [LD_Lot_Class] WHERE (([Lot_Class_ID] = @Original_Lot_Class_ID) AND (" +
    "[Code] = @Original_Code) AND ([Description] = @Original_Description))";
            this.sqlDeleteCommand4.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // daLotClass
            // 
            this.daLotClass.DeleteCommand = this.sqlDeleteCommand4;
            this.daLotClass.SelectCommand = this.sqlSelectCommand4;
            this.daLotClass.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Lot_Class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Lot_Class_ID", "Lot_Class_ID"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daLotClass.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // ucUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcLevyUpdate);
            this.Controls.Add(this.dpUpdate);
            this.Name = "ucUpdate";
            this.Size = new System.Drawing.Size(1178, 752);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpUpdate.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNewAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLotClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLotClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLevyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLevyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLevyUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLevyUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyUpdate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLevyUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gcLevyUpdate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLevyUpdate;
        private DevExpress.XtraBars.Docking.DockPanel dpUpdate;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreRegister;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.TextEdit teNewAmount;
        private DevExpress.XtraEditors.LookUpEdit lueLotClass;
        private DevExpress.XtraEditors.LookUpEdit lueDescription;
        private DevExpress.XtraEditors.LookUpEdit lueLevyType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daLevyUpdate;
        private dsLevyUpdate dsLevyUpdate1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daLevyType;
        private dsLevyType dsLevyType1;
        private System.Windows.Forms.BindingSource bsLevyType;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter daLevy;
        private dsLevy dsLevy1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter daLotClass;
        private dsLotClass dsLotClass1;
        private System.Windows.Forms.BindingSource lDLotClassBindingSource;
        private System.Windows.Forms.BindingSource lDLevyBindingSource;
        private System.Windows.Forms.BindingSource bsLevyUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colPri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipality;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaserName;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colBlock_Num;
        private DevExpress.XtraGrid.Columns.GridColumn colPlan_Num;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_Class_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_ClassCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLevyType_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLevyType;
        private DevExpress.XtraGrid.Columns.GridColumn colLevyDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLevy_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOldAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNewAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colProj_lot_agreement_levy_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumaric2;
    }
}
