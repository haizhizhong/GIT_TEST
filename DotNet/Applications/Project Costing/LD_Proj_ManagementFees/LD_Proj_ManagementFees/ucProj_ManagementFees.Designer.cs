namespace LD_Proj_ManagementFees
{
    partial class ucProj_ManagementFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProj_ManagementFees));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcManagementFees = new DevExpress.XtraGrid.GridControl();
            this.lDProjManagementFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsManagementFees1 = new LD_Proj_ManagementFees.dsManagementFees();
            this.gvManagementFees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueManagementFeeList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDManagementFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMgmtFeeList1 = new LD_Proj_ManagementFees.dsMgmtFeeList();
            this.colOffSetDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OffSetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueOffSetDate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDAdditionalDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOffSetDate1 = new LD_Proj_ManagementFees.dsOffSetDate();
            this.colPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLv1ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level1CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel1Codes1 = new LD_Proj_ManagementFees.dsLevel1Codes();
            this.colLv2ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level2CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel2Codes1 = new LD_Proj_ManagementFees.dsLevel2Codes();
            this.colLv3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level3CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel3Codes1 = new LD_Proj_ManagementFees.dsLevel3Codes();
            this.colLv4ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level4CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel4Codes1 = new LD_Proj_ManagementFees.dsLevel4Codes();
            this.colGST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceGST = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSupplier_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteMaxLength50 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadAll = new DevExpress.XtraEditors.SimpleButton();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daManagementFees = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daMgmtFeeList = new System.Data.SqlClient.SqlDataAdapter();
            this.daLevel1Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daLevel2Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.level2CodesFilteredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daLevel3Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.level3CodesFilteredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daLevel4Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.level4CodesFilteredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daOffSetDate = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand12 = new System.Data.SqlClient.SqlCommand();
            this.colPri_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcManagementFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProjManagementFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManagementFees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManagementFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueManagementFeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDManagementFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMgmtFeeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOffSetDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDAdditionalDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffSetDate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel1Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel2Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel3Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel4Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMaxLength50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesFilteredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesFilteredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesFilteredBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcManagementFees);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1276, 716);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Management Fees";
            // 
            // gcManagementFees
            // 
            this.gcManagementFees.DataSource = this.lDProjManagementFeesBindingSource;
            this.gcManagementFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcManagementFees.Location = new System.Drawing.Point(2, 52);
            this.gcManagementFees.MainView = this.gvManagementFees;
            this.gcManagementFees.Name = "gcManagementFees";
            this.gcManagementFees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riceGST,
            this.riteMaxLength50,
            this.rilueOffSetDate,
            this.riteNumber,
            this.rilueLevel1,
            this.rilueLevel2,
            this.rilueLevel3,
            this.rilueLevel4,
            this.rilueManagementFeeList});
            this.gcManagementFees.Size = new System.Drawing.Size(1272, 662);
            this.gcManagementFees.TabIndex = 0;
            this.gcManagementFees.UseEmbeddedNavigator = true;
            this.gcManagementFees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvManagementFees});
            // 
            // lDProjManagementFeesBindingSource
            // 
            this.lDProjManagementFeesBindingSource.DataMember = "LD_Proj_ManagementFees";
            this.lDProjManagementFeesBindingSource.DataSource = this.dsManagementFees1;
            // 
            // dsManagementFees1
            // 
            this.dsManagementFees1.DataSetName = "dsManagementFees";
            this.dsManagementFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvManagementFees
            // 
            this.gvManagementFees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colOffSetDays,
            this.OffSetDate,
            this.colPercentage,
            this.colAmount,
            this.colLv1ID,
            this.colLv2ID,
            this.colLv3ID,
            this.colLv4ID,
            this.colGST,
            this.colSupplier_ID,
            this.colPST,
            this.colPri_ID});
            this.gvManagementFees.GridControl = this.gcManagementFees;
            this.gvManagementFees.Name = "gvManagementFees";
            this.gvManagementFees.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvManagementFees_CellValueChanged);
            this.gvManagementFees.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvManagementFees_InitNewRow);
            this.gvManagementFees.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvManagementFees_InvalidRowException);
            this.gvManagementFees.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvManagementFees_ValidateRow);
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Fee Description";
            this.colDescription.ColumnEdit = this.rilueManagementFeeList;
            this.colDescription.FieldName = "ManagementFee_ID";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // rilueManagementFeeList
            // 
            this.rilueManagementFeeList.AutoHeight = false;
            this.rilueManagementFeeList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueManagementFeeList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueManagementFeeList.DataSource = this.lDManagementFeesBindingSource;
            this.rilueManagementFeeList.DisplayMember = "Description";
            this.rilueManagementFeeList.Name = "rilueManagementFeeList";
            this.rilueManagementFeeList.NullText = "";
            this.rilueManagementFeeList.ValueMember = "ID";
            // 
            // lDManagementFeesBindingSource
            // 
            this.lDManagementFeesBindingSource.DataMember = "LD_ManagementFees";
            this.lDManagementFeesBindingSource.DataSource = this.dsMgmtFeeList1;
            // 
            // dsMgmtFeeList1
            // 
            this.dsMgmtFeeList1.DataSetName = "dsMgmtFeeList";
            this.dsMgmtFeeList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colOffSetDays
            // 
            this.colOffSetDays.Caption = "Offset Days";
            this.colOffSetDays.FieldName = "OffSetDays";
            this.colOffSetDays.Name = "colOffSetDays";
            this.colOffSetDays.Visible = true;
            this.colOffSetDays.VisibleIndex = 1;
            // 
            // OffSetDate
            // 
            this.OffSetDate.Caption = "Offset Date";
            this.OffSetDate.ColumnEdit = this.rilueOffSetDate;
            this.OffSetDate.FieldName = "OffSetDate";
            this.OffSetDate.Name = "OffSetDate";
            this.OffSetDate.Visible = true;
            this.OffSetDate.VisibleIndex = 2;
            // 
            // rilueOffSetDate
            // 
            this.rilueOffSetDate.AutoHeight = false;
            this.rilueOffSetDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueOffSetDate.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueOffSetDate.DataSource = this.lDAdditionalDatesBindingSource;
            this.rilueOffSetDate.DisplayMember = "Description";
            this.rilueOffSetDate.Name = "rilueOffSetDate";
            this.rilueOffSetDate.NullText = "";
            this.rilueOffSetDate.PopupWidth = 300;
            this.rilueOffSetDate.ValueMember = "ID";
            // 
            // lDAdditionalDatesBindingSource
            // 
            this.lDAdditionalDatesBindingSource.DataMember = "LD_AdditionalDates";
            this.lDAdditionalDatesBindingSource.DataSource = this.dsOffSetDate1;
            // 
            // dsOffSetDate1
            // 
            this.dsOffSetDate1.DataSetName = "dsOffSetDate";
            this.dsOffSetDate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colPercentage
            // 
            this.colPercentage.Caption = "Percentage";
            this.colPercentage.ColumnEdit = this.riteNumber;
            this.colPercentage.FieldName = "Percentage";
            this.colPercentage.Name = "colPercentage";
            this.colPercentage.Visible = true;
            this.colPercentage.VisibleIndex = 3;
            // 
            // riteNumber
            // 
            this.riteNumber.AutoHeight = false;
            this.riteNumber.Mask.EditMask = "n2";
            this.riteNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumber.Name = "riteNumber";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.ColumnEdit = this.riteNumber;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            // 
            // colLv1ID
            // 
            this.colLv1ID.Caption = "Level 1";
            this.colLv1ID.ColumnEdit = this.rilueLevel1;
            this.colLv1ID.FieldName = "Lv1ID";
            this.colLv1ID.Name = "colLv1ID";
            this.colLv1ID.Visible = true;
            this.colLv1ID.VisibleIndex = 5;
            // 
            // rilueLevel1
            // 
            this.rilueLevel1.AutoHeight = false;
            this.rilueLevel1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel1.DataSource = this.level1CodesBindingSource;
            this.rilueLevel1.DisplayMember = "Level1";
            this.rilueLevel1.Name = "rilueLevel1";
            this.rilueLevel1.NullText = "";
            this.rilueLevel1.PopupWidth = 500;
            this.rilueLevel1.ValueMember = "lv1ID";
            // 
            // level1CodesBindingSource
            // 
            this.level1CodesBindingSource.DataMember = "Level1_Codes";
            this.level1CodesBindingSource.DataSource = this.dsLevel1Codes1;
            // 
            // dsLevel1Codes1
            // 
            this.dsLevel1Codes1.DataSetName = "dsLevel1Codes";
            this.dsLevel1Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colLv2ID
            // 
            this.colLv2ID.Caption = "Level 2";
            this.colLv2ID.ColumnEdit = this.rilueLevel2;
            this.colLv2ID.FieldName = "Lv2ID";
            this.colLv2ID.Name = "colLv2ID";
            this.colLv2ID.Visible = true;
            this.colLv2ID.VisibleIndex = 6;
            // 
            // rilueLevel2
            // 
            this.rilueLevel2.AutoHeight = false;
            this.rilueLevel2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel2.DataSource = this.level2CodesBindingSource;
            this.rilueLevel2.DisplayMember = "Level2";
            this.rilueLevel2.Name = "rilueLevel2";
            this.rilueLevel2.NullText = "";
            this.rilueLevel2.PopupWidth = 500;
            this.rilueLevel2.ValueMember = "lv2ID";
            this.rilueLevel2.Enter += new System.EventHandler(this.rilueLevel2_Enter);
            // 
            // level2CodesBindingSource
            // 
            this.level2CodesBindingSource.DataMember = "Level2_Codes";
            this.level2CodesBindingSource.DataSource = this.dsLevel2Codes1;
            // 
            // dsLevel2Codes1
            // 
            this.dsLevel2Codes1.DataSetName = "dsLevel2Codes";
            this.dsLevel2Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colLv3ID
            // 
            this.colLv3ID.Caption = "Level 3";
            this.colLv3ID.ColumnEdit = this.rilueLevel3;
            this.colLv3ID.FieldName = "Lv3ID";
            this.colLv3ID.Name = "colLv3ID";
            this.colLv3ID.Visible = true;
            this.colLv3ID.VisibleIndex = 7;
            // 
            // rilueLevel3
            // 
            this.rilueLevel3.AutoHeight = false;
            this.rilueLevel3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel3.DataSource = this.level3CodesBindingSource;
            this.rilueLevel3.DisplayMember = "Level3";
            this.rilueLevel3.Name = "rilueLevel3";
            this.rilueLevel3.NullText = "";
            this.rilueLevel3.ValueMember = "lv3ID";
            this.rilueLevel3.Enter += new System.EventHandler(this.rilueLevel3_Enter);
            // 
            // level3CodesBindingSource
            // 
            this.level3CodesBindingSource.DataMember = "Level3_Codes";
            this.level3CodesBindingSource.DataSource = this.dsLevel3Codes1;
            // 
            // dsLevel3Codes1
            // 
            this.dsLevel3Codes1.DataSetName = "dsLevel3Codes";
            this.dsLevel3Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colLv4ID
            // 
            this.colLv4ID.Caption = "Level 4";
            this.colLv4ID.ColumnEdit = this.rilueLevel4;
            this.colLv4ID.FieldName = "Lv4ID";
            this.colLv4ID.Name = "colLv4ID";
            this.colLv4ID.Visible = true;
            this.colLv4ID.VisibleIndex = 8;
            // 
            // rilueLevel4
            // 
            this.rilueLevel4.AutoHeight = false;
            this.rilueLevel4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel4.DataSource = this.level4CodesBindingSource;
            this.rilueLevel4.DisplayMember = "Level4";
            this.rilueLevel4.Name = "rilueLevel4";
            this.rilueLevel4.NullText = "";
            this.rilueLevel4.PopupWidth = 500;
            this.rilueLevel4.ValueMember = "lv4ID";
            this.rilueLevel4.Enter += new System.EventHandler(this.rilueLevel4_Enter);
            // 
            // level4CodesBindingSource
            // 
            this.level4CodesBindingSource.DataMember = "Level4_Codes";
            this.level4CodesBindingSource.DataSource = this.dsLevel4Codes1;
            // 
            // dsLevel4Codes1
            // 
            this.dsLevel4Codes1.DataSetName = "dsLevel4Codes";
            this.dsLevel4Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colGST
            // 
            this.colGST.Caption = "GST";
            this.colGST.ColumnEdit = this.riceGST;
            this.colGST.FieldName = "GST";
            this.colGST.Name = "colGST";
            this.colGST.Visible = true;
            this.colGST.VisibleIndex = 9;
            // 
            // riceGST
            // 
            this.riceGST.AutoHeight = false;
            this.riceGST.Name = "riceGST";
            this.riceGST.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colSupplier_ID
            // 
            this.colSupplier_ID.Caption = "Supplier";
            this.colSupplier_ID.FieldName = "Supplier_ID";
            this.colSupplier_ID.Name = "colSupplier_ID";
            this.colSupplier_ID.Visible = true;
            this.colSupplier_ID.VisibleIndex = 11;
            // 
            // colPST
            // 
            this.colPST.Caption = "PST";
            this.colPST.ColumnEdit = this.riceGST;
            this.colPST.FieldName = "PST";
            this.colPST.Name = "colPST";
            this.colPST.Visible = true;
            this.colPST.VisibleIndex = 10;
            // 
            // riteMaxLength50
            // 
            this.riteMaxLength50.AutoHeight = false;
            this.riteMaxLength50.MaxLength = 50;
            this.riteMaxLength50.Name = "riteMaxLength50";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadAll);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1272, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadAll.Location = new System.Drawing.Point(1194, 5);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAll.TabIndex = 0;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "Pri_ID")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Pri_ID", System.Data.SqlDbType.Int, 0, "Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@ManagementFee_ID", System.Data.SqlDbType.Int, 0, "ManagementFee_ID"),
            new System.Data.SqlClient.SqlParameter("@OffSetDays", System.Data.SqlDbType.Int, 0, "OffSetDays"),
            new System.Data.SqlClient.SqlParameter("@OffSetDate", System.Data.SqlDbType.Int, 0, "OffSetDate"),
            new System.Data.SqlClient.SqlParameter("@Percentage", System.Data.SqlDbType.Money, 0, "Percentage"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Lv1ID", System.Data.SqlDbType.Int, 0, "Lv1ID"),
            new System.Data.SqlClient.SqlParameter("@Lv2ID", System.Data.SqlDbType.Int, 0, "Lv2ID"),
            new System.Data.SqlClient.SqlParameter("@Lv3ID", System.Data.SqlDbType.Int, 0, "Lv3ID"),
            new System.Data.SqlClient.SqlParameter("@Lv4ID", System.Data.SqlDbType.Int, 0, "Lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Pri_ID", System.Data.SqlDbType.Int, 0, "Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@ManagementFee_ID", System.Data.SqlDbType.Int, 0, "ManagementFee_ID"),
            new System.Data.SqlClient.SqlParameter("@OffSetDays", System.Data.SqlDbType.Int, 0, "OffSetDays"),
            new System.Data.SqlClient.SqlParameter("@OffSetDate", System.Data.SqlDbType.Int, 0, "OffSetDate"),
            new System.Data.SqlClient.SqlParameter("@Percentage", System.Data.SqlDbType.Money, 0, "Percentage"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Lv1ID", System.Data.SqlDbType.Int, 0, "Lv1ID"),
            new System.Data.SqlClient.SqlParameter("@Lv2ID", System.Data.SqlDbType.Int, 0, "Lv2ID"),
            new System.Data.SqlClient.SqlParameter("@Lv3ID", System.Data.SqlDbType.Int, 0, "Lv3ID"),
            new System.Data.SqlClient.SqlParameter("@Lv4ID", System.Data.SqlDbType.Int, 0, "Lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Percentage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Percentage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Percentage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Percentage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Percentage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Percentage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Percentage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Percentage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null)});
            // 
            // daManagementFees
            // 
            this.daManagementFees.DeleteCommand = this.sqlDeleteCommand1;
            this.daManagementFees.InsertCommand = this.sqlInsertCommand1;
            this.daManagementFees.SelectCommand = this.sqlSelectCommand1;
            this.daManagementFees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Proj_ManagementFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Pri_ID", "Pri_ID"),
                        new System.Data.Common.DataColumnMapping("ManagementFee_ID", "ManagementFee_ID"),
                        new System.Data.Common.DataColumnMapping("OffSetDays", "OffSetDays"),
                        new System.Data.Common.DataColumnMapping("OffSetDate", "OffSetDate"),
                        new System.Data.Common.DataColumnMapping("Percentage", "Percentage"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Lv1ID", "Lv1ID"),
                        new System.Data.Common.DataColumnMapping("Lv2ID", "Lv2ID"),
                        new System.Data.Common.DataColumnMapping("Lv3ID", "Lv3ID"),
                        new System.Data.Common.DataColumnMapping("Lv4ID", "Lv4ID"),
                        new System.Data.Common.DataColumnMapping("GST", "GST"),
                        new System.Data.Common.DataColumnMapping("Supplier_ID", "Supplier_ID"),
                        new System.Data.Common.DataColumnMapping("PST", "PST")})});
            this.daManagementFees.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     ID, Description\r\nFROM         LD_ManagementFees\r\nORDER BY Description";
            this.sqlSelectCommand2.Connection = this.sqlTR;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [LD_ManagementFees] ([Description]) VALUES (@Description);\r\nSELECT ID" +
                ", Description FROM LD_ManagementFees WHERE (ID = SCOPE_IDENTITY()) ORDER BY Desc" +
                "ription";
            this.sqlInsertCommand2.Connection = this.sqlTR;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTR;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [LD_ManagementFees] WHERE (([ID] = @Original_ID) AND ((@IsNull_Descri" +
                "ption = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description))" +
                ")";
            this.sqlDeleteCommand2.Connection = this.sqlTR;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // daMgmtFeeList
            // 
            this.daMgmtFeeList.DeleteCommand = this.sqlDeleteCommand2;
            this.daMgmtFeeList.InsertCommand = this.sqlInsertCommand2;
            this.daMgmtFeeList.SelectCommand = this.sqlSelectCommand2;
            this.daMgmtFeeList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ManagementFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daMgmtFeeList.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // daLevel1Codes
            // 
            this.daLevel1Codes.DeleteCommand = this.sqlDeleteCommand3;
            this.daLevel1Codes.InsertCommand = this.sqlInsertCommand3;
            this.daLevel1Codes.SelectCommand = this.sqlSelectCommand3;
            this.daLevel1Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level1_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv1_code", "lv1_code"),
                        new System.Data.Common.DataColumnMapping("lv1_desc", "lv1_desc"),
                        new System.Data.Common.DataColumnMapping("Level1", "Level1")})});
            this.daLevel1Codes.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTR;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTR;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTR;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTR;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc"),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 4, "lv1ID")});
            // 
            // daLevel2Codes
            // 
            this.daLevel2Codes.DeleteCommand = this.sqlDeleteCommand4;
            this.daLevel2Codes.InsertCommand = this.sqlInsertCommand4;
            this.daLevel2Codes.SelectCommand = this.sqlSelectCommand4;
            this.daLevel2Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level2_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv2_code", "lv2_code"),
                        new System.Data.Common.DataColumnMapping("lv2_desc", "lv2_desc"),
                        new System.Data.Common.DataColumnMapping("Level2", "Level2"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID")})});
            this.daLevel2Codes.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.sqlTR;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlTR;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID")});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlTR;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlTR;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 4, "lv2ID")});
            // 
            // level2CodesFilteredBindingSource
            // 
            this.level2CodesFilteredBindingSource.DataMember = "Level2_Codes";
            this.level2CodesFilteredBindingSource.DataSource = this.dsLevel2Codes1;
            // 
            // daLevel3Codes
            // 
            this.daLevel3Codes.DeleteCommand = this.sqlCommand1;
            this.daLevel3Codes.InsertCommand = this.sqlCommand2;
            this.daLevel3Codes.SelectCommand = this.sqlCommand3;
            this.daLevel3Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level3_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv3_code", "lv3_code"),
                        new System.Data.Common.DataColumnMapping("lv3_desc", "lv3_desc"),
                        new System.Data.Common.DataColumnMapping("Level3", "Level3"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID")})});
            this.daLevel3Codes.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlTR;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlTR;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlTR;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlTR;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 4, "lv3ID")});
            // 
            // level3CodesFilteredBindingSource
            // 
            this.level3CodesFilteredBindingSource.DataMember = "Level3_Codes";
            this.level3CodesFilteredBindingSource.DataSource = this.dsLevel3Codes1;
            // 
            // daLevel4Codes
            // 
            this.daLevel4Codes.DeleteCommand = this.sqlCommand5;
            this.daLevel4Codes.InsertCommand = this.sqlCommand6;
            this.daLevel4Codes.SelectCommand = this.sqlCommand7;
            this.daLevel4Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level4_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("lv4_code", "lv4_code"),
                        new System.Data.Common.DataColumnMapping("lv4_desc", "lv4_desc"),
                        new System.Data.Common.DataColumnMapping("Level4", "Level4"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID")})});
            this.daLevel4Codes.UpdateCommand = this.sqlCommand8;
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = resources.GetString("sqlCommand5.CommandText");
            this.sqlCommand5.Connection = this.sqlTR;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlTR;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlTR;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlTR;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 4, "lv4ID")});
            // 
            // level4CodesFilteredBindingSource
            // 
            this.level4CodesFilteredBindingSource.DataMember = "Level4_Codes";
            this.level4CodesFilteredBindingSource.DataSource = this.dsLevel4Codes1;
            // 
            // daOffSetDate
            // 
            this.daOffSetDate.DeleteCommand = this.sqlCommand9;
            this.daOffSetDate.InsertCommand = this.sqlCommand10;
            this.daOffSetDate.SelectCommand = this.sqlCommand11;
            this.daOffSetDate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_AdditionalDates", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daOffSetDate.UpdateCommand = this.sqlCommand12;
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "DELETE FROM [LD_AdditionalDates] WHERE (([ID] = @Original_ID) AND ((@IsNull_Descr" +
                "iption = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)" +
                "))";
            this.sqlCommand9.Connection = this.sqlTR;
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand10
            // 
            this.sqlCommand10.CommandText = "INSERT INTO [LD_AdditionalDates] ([ID], [Description]) VALUES (@ID, @Description)" +
                ";\r\nSELECT ID, Description FROM LD_AdditionalDates WHERE (ID = @ID) ORDER BY Desc" +
                "ription";
            this.sqlCommand10.Connection = this.sqlTR;
            this.sqlCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description")});
            // 
            // sqlCommand11
            // 
            this.sqlCommand11.CommandText = "SELECT     ID, Description\r\nFROM         LD_AdditionalDates\r\nORDER BY Description" +
                "";
            this.sqlCommand11.Connection = this.sqlTR;
            // 
            // sqlCommand12
            // 
            this.sqlCommand12.CommandText = resources.GetString("sqlCommand12.CommandText");
            this.sqlCommand12.Connection = this.sqlTR;
            this.sqlCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // colPri_ID
            // 
            this.colPri_ID.FieldName = "Pri_ID";
            this.colPri_ID.Name = "colPri_ID";
            this.colPri_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ucProj_ManagementFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucProj_ManagementFees";
            this.Size = new System.Drawing.Size(1276, 716);
            this.Load += new System.EventHandler(this.ucProj_ManagementFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcManagementFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProjManagementFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManagementFees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvManagementFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueManagementFeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDManagementFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMgmtFeeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOffSetDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDAdditionalDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffSetDate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel1Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel2Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel3Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel4Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMaxLength50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesFilteredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesFilteredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesFilteredBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcManagementFees;
        private DevExpress.XtraGrid.Views.Grid.GridView gvManagementFees;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteMaxLength50;
        private DevExpress.XtraGrid.Columns.GridColumn colOffSetDays;
        private DevExpress.XtraGrid.Columns.GridColumn OffSetDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueOffSetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentage;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLv1ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel1;
        private DevExpress.XtraGrid.Columns.GridColumn colLv2ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel2;
        private DevExpress.XtraGrid.Columns.GridColumn colLv3ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel3;
        private DevExpress.XtraGrid.Columns.GridColumn colLv4ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel4;
        private DevExpress.XtraGrid.Columns.GridColumn colGST;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceGST;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier_ID;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadAll;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daManagementFees;
        private dsManagementFees dsManagementFees1;
        private System.Windows.Forms.BindingSource lDProjManagementFeesBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueManagementFeeList;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daMgmtFeeList;
        private dsMgmtFeeList dsMgmtFeeList1;
        private System.Windows.Forms.BindingSource lDManagementFeesBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel1Codes;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private dsLevel1Codes dsLevel1Codes1;
        private System.Windows.Forms.BindingSource level1CodesBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel2Codes;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private dsLevel2Codes dsLevel2Codes1;
        private System.Windows.Forms.BindingSource level2CodesBindingSource;
        private System.Windows.Forms.BindingSource level2CodesFilteredBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel3Codes;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private dsLevel3Codes dsLevel3Codes1;
        private System.Windows.Forms.BindingSource level3CodesBindingSource;
        private System.Windows.Forms.BindingSource level3CodesFilteredBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel4Codes;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private dsLevel4Codes dsLevel4Codes1;
        private System.Windows.Forms.BindingSource level4CodesBindingSource;
        private System.Windows.Forms.BindingSource level4CodesFilteredBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daOffSetDate;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
        private System.Data.SqlClient.SqlCommand sqlCommand12;
        private dsOffSetDate dsOffSetDate1;
        private System.Windows.Forms.BindingSource lDAdditionalDatesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPST;
        private DevExpress.XtraGrid.Columns.GridColumn colPri_ID;

    }
}
