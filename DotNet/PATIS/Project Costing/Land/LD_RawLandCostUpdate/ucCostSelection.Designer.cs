namespace LD_RawLandCostUpdate
{
    partial class ucCostSelection
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCostSelection));
            this.colLevelsValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSelections = new DevExpress.XtraEditors.PanelControl();
            this.rgCostComparision = new DevExpress.XtraEditors.RadioGroup();
            this.ceShowZero = new DevExpress.XtraEditors.CheckEdit();
            this.rgActOptions = new DevExpress.XtraEditors.RadioGroup();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.rgBudgetActual = new DevExpress.XtraEditors.RadioGroup();
            this.ucAccountingPicker1 = new AccountingPicker.ucAccountingPicker();
            this.gcCostSelection = new DevExpress.XtraGrid.GridControl();
            this.bs_working_ld_costs_to_transfer = new System.Windows.Forms.BindingSource(this.components);
            this.ds_working_ld_costs_to_transfer1 = new LD_RawLandCostUpdate.ds_working_ld_costs_to_transfer();
            this.gvCostSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaw_Pri_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaw_lvl1ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lv1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ALL_Levels1 = new LD_RawLandCostUpdate.ds_ALL_Levels();
            this.colRaw_lvl2ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lv2 = new System.Windows.Forms.BindingSource(this.components);
            this.colRaw_lvl3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_Lv3 = new System.Windows.Forms.BindingSource(this.components);
            this.colRaw_lvl4ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lv4 = new System.Windows.Forms.BindingSource(this.components);
            this.colRaw_LEMOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferedToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewTransferAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_Pri_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl1ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl2ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl4ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_LEMOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl1ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel1Desc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDev_lvl2ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel2Desc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDev_lvl3ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDev_lvl4ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaw_lvl1ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaw_lvl2ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaw_lvl3ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel3Desc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRaw_lvl4ID_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLevel4Desc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDev_Matched = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBudgetRemaining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_working_ld_costs_to_transfer = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_Level1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.da_Level2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.da_Level3 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand5 = new System.Data.SqlClient.SqlCommand();
            this.da_Level4 = new System.Data.SqlClient.SqlDataAdapter();
            this.bs_lv1_Filtered = new System.Windows.Forms.BindingSource(this.components);
            this.bs_lv2_Filtered = new System.Windows.Forms.BindingSource(this.components);
            this.bs_lv3_Filtered = new System.Windows.Forms.BindingSource(this.components);
            this.bs_lv4_Filtered = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelections)).BeginInit();
            this.pnlSelections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgCostComparision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowZero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgActOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgBudgetActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCostSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_working_ld_costs_to_transfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_working_ld_costs_to_transfer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCostSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ALL_Levels1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Lv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel1Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel2Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel3Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel4Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv1_Filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv2_Filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv3_Filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv4_Filtered)).BeginInit();
            this.SuspendLayout();
            // 
            // colLevelsValid
            // 
            this.colLevelsValid.FieldName = "LevelsValid";
            this.colLevelsValid.Name = "colLevelsValid";
            this.colLevelsValid.OptionsColumn.AllowEdit = false;
            this.colLevelsValid.OptionsColumn.ShowInCustomizationForm = false;
            this.colLevelsValid.Visible = true;
            this.colLevelsValid.VisibleIndex = 13;
            // 
            // pnlSelections
            // 
            this.pnlSelections.Controls.Add(this.rgCostComparision);
            this.pnlSelections.Controls.Add(this.ceShowZero);
            this.pnlSelections.Controls.Add(this.rgActOptions);
            this.pnlSelections.Controls.Add(this.btnUpdate);
            this.pnlSelections.Controls.Add(this.rgBudgetActual);
            this.pnlSelections.Controls.Add(this.ucAccountingPicker1);
            this.pnlSelections.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelections.Location = new System.Drawing.Point(0, 0);
            this.pnlSelections.Name = "pnlSelections";
            this.pnlSelections.Size = new System.Drawing.Size(1223, 98);
            this.pnlSelections.TabIndex = 0;
            // 
            // rgCostComparision
            // 
            this.rgCostComparision.Location = new System.Drawing.Point(541, 6);
            this.rgCostComparision.Name = "rgCostComparision";
            this.rgCostComparision.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Match Cost Codes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Single Cost Code")});
            this.rgCostComparision.Size = new System.Drawing.Size(159, 66);
            this.rgCostComparision.TabIndex = 5;
            this.rgCostComparision.EditValueChanged += new System.EventHandler(this.rgCostComparision_EditValueChanged);
            this.rgCostComparision.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.rgCostComparision_EditValueChanging);
            // 
            // ceShowZero
            // 
            this.ceShowZero.Location = new System.Drawing.Point(716, 8);
            this.ceShowZero.Name = "ceShowZero";
            this.ceShowZero.Properties.Caption = "Show Zero";
            this.ceShowZero.Size = new System.Drawing.Size(75, 19);
            this.ceShowZero.TabIndex = 4;
            // 
            // rgActOptions
            // 
            this.rgActOptions.Location = new System.Drawing.Point(326, 5);
            this.rgActOptions.Name = "rgActOptions";
            this.rgActOptions.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("T", "Total Remaining To Date"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Area Proportionate Share"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Residual Area Proportionate Share")});
            this.rgActOptions.Size = new System.Drawing.Size(209, 80);
            this.rgActOptions.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(829, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Refresh";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rgBudgetActual
            // 
            this.rgBudgetActual.Location = new System.Drawing.Point(232, 5);
            this.rgBudgetActual.Name = "rgBudgetActual";
            this.rgBudgetActual.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Actuals"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("B", "Budget")});
            this.rgBudgetActual.Size = new System.Drawing.Size(88, 67);
            this.rgBudgetActual.TabIndex = 1;
            this.rgBudgetActual.EditValueChanged += new System.EventHandler(this.rgBudgetActual_EditValueChanged);
            // 
            // ucAccountingPicker1
            // 
            this.ucAccountingPicker1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ucAccountingPicker1.Appearance.Options.UseBackColor = true;
            this.ucAccountingPicker1.HasEntryDate = false;
            this.ucAccountingPicker1.Location = new System.Drawing.Point(5, 5);
            this.ucAccountingPicker1.Name = "ucAccountingPicker1";
            this.ucAccountingPicker1.SelectedPeriod = 0;
            this.ucAccountingPicker1.SelectedYear = 0;
            this.ucAccountingPicker1.Size = new System.Drawing.Size(184, 80);
            this.ucAccountingPicker1.TabIndex = 0;
            this.ucAccountingPicker1.UserName = "";
            // 
            // gcCostSelection
            // 
            this.gcCostSelection.DataSource = this.bs_working_ld_costs_to_transfer;
            this.gcCostSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCostSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCostSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcCostSelection.Location = new System.Drawing.Point(0, 98);
            this.gcCostSelection.MainView = this.gvCostSelection;
            this.gcCostSelection.Name = "gcCostSelection";
            this.gcCostSelection.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueLevel1,
            this.ri_lueLevel2,
            this.ri_lueLevel3,
            this.ri_lueLevel4,
            this.ri_lueLevel1Desc,
            this.ri_lueLevel2Desc,
            this.ri_lueLevel3Desc,
            this.ri_lueLevel4Desc,
            this.ri_teNumaric2});
            this.gcCostSelection.Size = new System.Drawing.Size(1223, 702);
            this.gcCostSelection.TabIndex = 1;
            this.gcCostSelection.UseEmbeddedNavigator = true;
            this.gcCostSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCostSelection});
            // 
            // bs_working_ld_costs_to_transfer
            // 
            this.bs_working_ld_costs_to_transfer.DataMember = "working_ld_costs_to_transfer";
            this.bs_working_ld_costs_to_transfer.DataSource = this.ds_working_ld_costs_to_transfer1;
            // 
            // ds_working_ld_costs_to_transfer1
            // 
            this.ds_working_ld_costs_to_transfer1.DataSetName = "ds_working_ld_costs_to_transfer";
            this.ds_working_ld_costs_to_transfer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCostSelection
            // 
            this.gvCostSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colRaw_Pri_ID,
            this.colRaw_lvl1ID,
            this.colRaw_lvl2ID,
            this.colRaw_lvl3ID,
            this.colRaw_lvl4ID,
            this.colRaw_LEMOS,
            this.colBudget,
            this.colActual,
            this.colTransferedToDate,
            this.colNewTransferAmount,
            this.colDev_Pri_ID,
            this.colDev_lvl1ID,
            this.colDev_lvl2ID,
            this.colDev_lvl3ID,
            this.colDev_lvl4ID,
            this.colDev_LEMOS,
            this.colDev_lvl1ID_Desc,
            this.colDev_lvl2ID_Desc,
            this.colDev_lvl3ID_Desc,
            this.colDev_lvl4ID_Desc,
            this.colRaw_lvl1ID_Desc,
            this.colRaw_lvl2ID_Desc,
            this.colRaw_lvl3ID_Desc,
            this.colRaw_lvl4ID_Desc,
            this.colDev_Matched,
            this.colBudgetRemaining,
            this.colLevelsValid});
            this.gvCostSelection.CustomizationFormBounds = new System.Drawing.Rectangle(1455, 708, 225, 214);
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[LevelsValid] = False And [NewTransferAmount] <> 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvCostSelection.FormatRules.Add(gridFormatRule1);
            this.gvCostSelection.GridControl = this.gcCostSelection;
            this.gvCostSelection.Name = "gvCostSelection";
            this.gvCostSelection.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvCostSelection.OptionsView.ColumnAutoWidth = false;
            this.gvCostSelection.OptionsView.ShowFooter = true;
            this.gvCostSelection.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvCostSelection_InvalidRowException);
            this.gvCostSelection.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvCostSelection_ValidateRow);
            this.gvCostSelection.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvCostSelection_RowUpdated);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colRaw_Pri_ID
            // 
            this.colRaw_Pri_ID.FieldName = "Raw_Pri_ID";
            this.colRaw_Pri_ID.Name = "colRaw_Pri_ID";
            this.colRaw_Pri_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colRaw_lvl1ID
            // 
            this.colRaw_lvl1ID.ColumnEdit = this.ri_lueLevel1;
            this.colRaw_lvl1ID.FieldName = "Raw_lvl1ID";
            this.colRaw_lvl1ID.Name = "colRaw_lvl1ID";
            this.colRaw_lvl1ID.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl1ID.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl1ID.Visible = true;
            this.colRaw_lvl1ID.VisibleIndex = 0;
            this.colRaw_lvl1ID.Width = 108;
            // 
            // ri_lueLevel1
            // 
            this.ri_lueLevel1.AutoHeight = false;
            this.ri_lueLevel1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1ID", "lv1ID", 48, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel1.DataSource = this.bs_lv1;
            this.ri_lueLevel1.DisplayMember = "lv1_code";
            this.ri_lueLevel1.Name = "ri_lueLevel1";
            this.ri_lueLevel1.NullText = "";
            this.ri_lueLevel1.PopupWidth = 220;
            this.ri_lueLevel1.ValueMember = "lv1ID";
            this.ri_lueLevel1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // bs_lv1
            // 
            this.bs_lv1.DataMember = "Level1_Codes";
            this.bs_lv1.DataSource = this.ds_ALL_Levels1;
            // 
            // ds_ALL_Levels1
            // 
            this.ds_ALL_Levels1.DataSetName = "ds_ALL_Levels";
            this.ds_ALL_Levels1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colRaw_lvl2ID
            // 
            this.colRaw_lvl2ID.ColumnEdit = this.ri_lueLevel2;
            this.colRaw_lvl2ID.FieldName = "Raw_lvl2ID";
            this.colRaw_lvl2ID.Name = "colRaw_lvl2ID";
            this.colRaw_lvl2ID.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl2ID.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl2ID.Visible = true;
            this.colRaw_lvl2ID.VisibleIndex = 1;
            this.colRaw_lvl2ID.Width = 114;
            // 
            // ri_lueLevel2
            // 
            this.ri_lueLevel2.AutoHeight = false;
            this.ri_lueLevel2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2ID", "lv2ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1ID", "lv1ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel2.DataSource = this.bs_lv2;
            this.ri_lueLevel2.DisplayMember = "lv2_code";
            this.ri_lueLevel2.Name = "ri_lueLevel2";
            this.ri_lueLevel2.NullText = "";
            this.ri_lueLevel2.PopupWidth = 220;
            this.ri_lueLevel2.ValueMember = "lv2ID";
            this.ri_lueLevel2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // bs_lv2
            // 
            this.bs_lv2.DataMember = "Level2_Codes";
            this.bs_lv2.DataSource = this.ds_ALL_Levels1;
            // 
            // colRaw_lvl3ID
            // 
            this.colRaw_lvl3ID.ColumnEdit = this.ri_lueLevel3;
            this.colRaw_lvl3ID.FieldName = "Raw_lvl3ID";
            this.colRaw_lvl3ID.Name = "colRaw_lvl3ID";
            this.colRaw_lvl3ID.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl3ID.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl3ID.Visible = true;
            this.colRaw_lvl3ID.VisibleIndex = 2;
            this.colRaw_lvl3ID.Width = 122;
            // 
            // ri_lueLevel3
            // 
            this.ri_lueLevel3.AutoHeight = false;
            this.ri_lueLevel3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3ID", "lv3ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2ID", "lv2ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel3.DataSource = this.bs_Lv3;
            this.ri_lueLevel3.DisplayMember = "lv3_code";
            this.ri_lueLevel3.Name = "ri_lueLevel3";
            this.ri_lueLevel3.NullText = "";
            this.ri_lueLevel3.PopupWidth = 220;
            this.ri_lueLevel3.ValueMember = "lv3ID";
            this.ri_lueLevel3.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // bs_Lv3
            // 
            this.bs_Lv3.DataMember = "Level3_Codes";
            this.bs_Lv3.DataSource = this.ds_ALL_Levels1;
            // 
            // colRaw_lvl4ID
            // 
            this.colRaw_lvl4ID.ColumnEdit = this.ri_lueLevel4;
            this.colRaw_lvl4ID.FieldName = "Raw_lvl4ID";
            this.colRaw_lvl4ID.Name = "colRaw_lvl4ID";
            this.colRaw_lvl4ID.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl4ID.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl4ID.Visible = true;
            this.colRaw_lvl4ID.VisibleIndex = 3;
            this.colRaw_lvl4ID.Width = 108;
            // 
            // ri_lueLevel4
            // 
            this.ri_lueLevel4.AutoHeight = false;
            this.ri_lueLevel4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4ID", "lv4ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3ID", "lv3ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel4.DataSource = this.bs_lv4;
            this.ri_lueLevel4.DisplayMember = "lv4_code";
            this.ri_lueLevel4.Name = "ri_lueLevel4";
            this.ri_lueLevel4.NullText = "";
            this.ri_lueLevel4.PopupWidth = 220;
            this.ri_lueLevel4.ValueMember = "lv4ID";
            this.ri_lueLevel4.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel4.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // bs_lv4
            // 
            this.bs_lv4.DataMember = "Level4_Codes";
            this.bs_lv4.DataSource = this.ds_ALL_Levels1;
            // 
            // colRaw_LEMOS
            // 
            this.colRaw_LEMOS.FieldName = "Raw_LEMOS";
            this.colRaw_LEMOS.Name = "colRaw_LEMOS";
            this.colRaw_LEMOS.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBudget
            // 
            this.colBudget.ColumnEdit = this.ri_teNumaric2;
            this.colBudget.FieldName = "Budget";
            this.colBudget.Name = "colBudget";
            this.colBudget.OptionsColumn.AllowEdit = false;
            this.colBudget.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Budget", "{0:n2}")});
            this.colBudget.Visible = true;
            this.colBudget.VisibleIndex = 4;
            this.colBudget.Width = 150;
            // 
            // ri_teNumaric2
            // 
            this.ri_teNumaric2.AutoHeight = false;
            this.ri_teNumaric2.Mask.EditMask = "N2";
            this.ri_teNumaric2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric2.Name = "ri_teNumaric2";
            // 
            // colActual
            // 
            this.colActual.ColumnEdit = this.ri_teNumaric2;
            this.colActual.FieldName = "Actual";
            this.colActual.Name = "colActual";
            this.colActual.OptionsColumn.AllowEdit = false;
            this.colActual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Actual", "{0:n2}")});
            this.colActual.Visible = true;
            this.colActual.VisibleIndex = 5;
            this.colActual.Width = 150;
            // 
            // colTransferedToDate
            // 
            this.colTransferedToDate.Caption = "Transferred To Date";
            this.colTransferedToDate.ColumnEdit = this.ri_teNumaric2;
            this.colTransferedToDate.FieldName = "TransferedToDate";
            this.colTransferedToDate.Name = "colTransferedToDate";
            this.colTransferedToDate.OptionsColumn.AllowEdit = false;
            this.colTransferedToDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferedToDate", "{0:n2}")});
            this.colTransferedToDate.Visible = true;
            this.colTransferedToDate.VisibleIndex = 7;
            this.colTransferedToDate.Width = 150;
            // 
            // colNewTransferAmount
            // 
            this.colNewTransferAmount.ColumnEdit = this.ri_teNumaric2;
            this.colNewTransferAmount.FieldName = "NewTransferAmount";
            this.colNewTransferAmount.Name = "colNewTransferAmount";
            this.colNewTransferAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NewTransferAmount", "{0:n2}")});
            this.colNewTransferAmount.Visible = true;
            this.colNewTransferAmount.VisibleIndex = 8;
            this.colNewTransferAmount.Width = 150;
            // 
            // colDev_Pri_ID
            // 
            this.colDev_Pri_ID.FieldName = "Dev_Pri_ID";
            this.colDev_Pri_ID.Name = "colDev_Pri_ID";
            this.colDev_Pri_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDev_lvl1ID
            // 
            this.colDev_lvl1ID.ColumnEdit = this.ri_lueLevel1;
            this.colDev_lvl1ID.FieldName = "Dev_lvl1ID";
            this.colDev_lvl1ID.Name = "colDev_lvl1ID";
            this.colDev_lvl1ID.Visible = true;
            this.colDev_lvl1ID.VisibleIndex = 9;
            this.colDev_lvl1ID.Width = 129;
            // 
            // colDev_lvl2ID
            // 
            this.colDev_lvl2ID.ColumnEdit = this.ri_lueLevel2;
            this.colDev_lvl2ID.FieldName = "Dev_lvl2ID";
            this.colDev_lvl2ID.Name = "colDev_lvl2ID";
            this.colDev_lvl2ID.Visible = true;
            this.colDev_lvl2ID.VisibleIndex = 10;
            this.colDev_lvl2ID.Width = 124;
            // 
            // colDev_lvl3ID
            // 
            this.colDev_lvl3ID.ColumnEdit = this.ri_lueLevel3;
            this.colDev_lvl3ID.FieldName = "Dev_lvl3ID";
            this.colDev_lvl3ID.Name = "colDev_lvl3ID";
            this.colDev_lvl3ID.Visible = true;
            this.colDev_lvl3ID.VisibleIndex = 11;
            this.colDev_lvl3ID.Width = 123;
            // 
            // colDev_lvl4ID
            // 
            this.colDev_lvl4ID.ColumnEdit = this.ri_lueLevel4;
            this.colDev_lvl4ID.FieldName = "Dev_lvl4ID";
            this.colDev_lvl4ID.Name = "colDev_lvl4ID";
            this.colDev_lvl4ID.Visible = true;
            this.colDev_lvl4ID.VisibleIndex = 12;
            this.colDev_lvl4ID.Width = 113;
            // 
            // colDev_LEMOS
            // 
            this.colDev_LEMOS.FieldName = "Dev_LEMOS";
            this.colDev_LEMOS.Name = "colDev_LEMOS";
            this.colDev_LEMOS.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDev_lvl1ID_Desc
            // 
            this.colDev_lvl1ID_Desc.ColumnEdit = this.ri_lueLevel1Desc;
            this.colDev_lvl1ID_Desc.FieldName = "Dev_lvl1ID";
            this.colDev_lvl1ID_Desc.Name = "colDev_lvl1ID_Desc";
            this.colDev_lvl1ID_Desc.Width = 250;
            // 
            // ri_lueLevel1Desc
            // 
            this.ri_lueLevel1Desc.AutoHeight = false;
            this.ri_lueLevel1Desc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel1Desc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1ID", "lv1ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel1Desc.DataSource = this.bs_lv1;
            this.ri_lueLevel1Desc.DisplayMember = "lv1_desc";
            this.ri_lueLevel1Desc.Name = "ri_lueLevel1Desc";
            this.ri_lueLevel1Desc.NullText = "";
            this.ri_lueLevel1Desc.PopupWidth = 220;
            this.ri_lueLevel1Desc.ValueMember = "lv1ID";
            this.ri_lueLevel1Desc.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel1Desc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // colDev_lvl2ID_Desc
            // 
            this.colDev_lvl2ID_Desc.ColumnEdit = this.ri_lueLevel2Desc;
            this.colDev_lvl2ID_Desc.FieldName = "Dev_lvl2ID";
            this.colDev_lvl2ID_Desc.Name = "colDev_lvl2ID_Desc";
            this.colDev_lvl2ID_Desc.Width = 250;
            // 
            // ri_lueLevel2Desc
            // 
            this.ri_lueLevel2Desc.AutoHeight = false;
            this.ri_lueLevel2Desc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel2Desc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2ID", "lv2ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1ID", "lv1ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel2Desc.DataSource = this.bs_lv2;
            this.ri_lueLevel2Desc.DisplayMember = "lv2_desc";
            this.ri_lueLevel2Desc.Name = "ri_lueLevel2Desc";
            this.ri_lueLevel2Desc.NullText = "";
            this.ri_lueLevel2Desc.PopupWidth = 220;
            this.ri_lueLevel2Desc.ValueMember = "lv2ID";
            this.ri_lueLevel2Desc.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel2Desc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // colDev_lvl3ID_Desc
            // 
            this.colDev_lvl3ID_Desc.ColumnEdit = this.ri_lueLevel3;
            this.colDev_lvl3ID_Desc.FieldName = "Dev_lvl3ID";
            this.colDev_lvl3ID_Desc.Name = "colDev_lvl3ID_Desc";
            this.colDev_lvl3ID_Desc.Width = 250;
            // 
            // colDev_lvl4ID_Desc
            // 
            this.colDev_lvl4ID_Desc.ColumnEdit = this.ri_lueLevel4;
            this.colDev_lvl4ID_Desc.FieldName = "Dev_lvl4ID";
            this.colDev_lvl4ID_Desc.Name = "colDev_lvl4ID_Desc";
            this.colDev_lvl4ID_Desc.Width = 250;
            // 
            // colRaw_lvl1ID_Desc
            // 
            this.colRaw_lvl1ID_Desc.ColumnEdit = this.ri_lueLevel1Desc;
            this.colRaw_lvl1ID_Desc.FieldName = "Raw_lvl1ID";
            this.colRaw_lvl1ID_Desc.Name = "colRaw_lvl1ID_Desc";
            this.colRaw_lvl1ID_Desc.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl1ID_Desc.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl1ID_Desc.Width = 250;
            // 
            // colRaw_lvl2ID_Desc
            // 
            this.colRaw_lvl2ID_Desc.ColumnEdit = this.ri_lueLevel2Desc;
            this.colRaw_lvl2ID_Desc.FieldName = "Raw_lvl2ID";
            this.colRaw_lvl2ID_Desc.Name = "colRaw_lvl2ID_Desc";
            this.colRaw_lvl2ID_Desc.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl2ID_Desc.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl2ID_Desc.Width = 250;
            // 
            // colRaw_lvl3ID_Desc
            // 
            this.colRaw_lvl3ID_Desc.ColumnEdit = this.ri_lueLevel3Desc;
            this.colRaw_lvl3ID_Desc.FieldName = "Raw_lvl3ID";
            this.colRaw_lvl3ID_Desc.Name = "colRaw_lvl3ID_Desc";
            this.colRaw_lvl3ID_Desc.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl3ID_Desc.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl3ID_Desc.Width = 250;
            // 
            // ri_lueLevel3Desc
            // 
            this.ri_lueLevel3Desc.AutoHeight = false;
            this.ri_lueLevel3Desc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel3Desc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3ID", "lv3ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2ID", "lv2ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel3Desc.DataSource = this.bs_Lv3;
            this.ri_lueLevel3Desc.DisplayMember = "lv3_desc";
            this.ri_lueLevel3Desc.Name = "ri_lueLevel3Desc";
            this.ri_lueLevel3Desc.NullText = "";
            this.ri_lueLevel3Desc.PopupWidth = 220;
            this.ri_lueLevel3Desc.ValueMember = "lv3ID";
            this.ri_lueLevel3Desc.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel3Desc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // colRaw_lvl4ID_Desc
            // 
            this.colRaw_lvl4ID_Desc.ColumnEdit = this.ri_lueLevel4Desc;
            this.colRaw_lvl4ID_Desc.FieldName = "Raw_lvl4ID";
            this.colRaw_lvl4ID_Desc.Name = "colRaw_lvl4ID_Desc";
            this.colRaw_lvl4ID_Desc.OptionsColumn.AllowEdit = false;
            this.colRaw_lvl4ID_Desc.OptionsColumn.ReadOnly = true;
            this.colRaw_lvl4ID_Desc.Width = 250;
            // 
            // ri_lueLevel4Desc
            // 
            this.ri_lueLevel4Desc.AutoHeight = false;
            this.ri_lueLevel4Desc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ri_lueLevel4Desc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4ID", "lv4ID", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3ID", "lv3ID", 35, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 39, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InBudget", "In Budget", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevPri_ID", "Dev Pri_ID", 61, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLevel4Desc.DataSource = this.bs_lv4;
            this.ri_lueLevel4Desc.DisplayMember = "lv4_desc";
            this.ri_lueLevel4Desc.Name = "ri_lueLevel4Desc";
            this.ri_lueLevel4Desc.NullText = "";
            this.ri_lueLevel4Desc.PopupWidth = 220;
            this.ri_lueLevel4Desc.ValueMember = "lv4ID";
            this.ri_lueLevel4Desc.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.ri_lueAll_Levels_QueryPopUp);
            this.ri_lueLevel4Desc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_lueALLLevels_ButtonClick);
            // 
            // colDev_Matched
            // 
            this.colDev_Matched.FieldName = "Dev_Matched";
            this.colDev_Matched.Name = "colDev_Matched";
            this.colDev_Matched.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBudgetRemaining
            // 
            this.colBudgetRemaining.ColumnEdit = this.ri_teNumaric2;
            this.colBudgetRemaining.FieldName = "BudgetRemaining";
            this.colBudgetRemaining.Name = "colBudgetRemaining";
            this.colBudgetRemaining.OptionsColumn.AllowEdit = false;
            this.colBudgetRemaining.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BudgetRemaining", "{0:n2}")});
            this.colBudgetRemaining.Visible = true;
            this.colBudgetRemaining.VisibleIndex = 6;
            this.colBudgetRemaining.Width = 130;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 10, "username")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DEV11\\SQL2014;Initial Catalog=tr_strike_test10;Persist Security Info=" +
    "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@Raw_Pri_ID", System.Data.SqlDbType.Int, 0, "Raw_Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl1ID", System.Data.SqlDbType.Int, 0, "Raw_lvl1ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl2ID", System.Data.SqlDbType.Int, 0, "Raw_lvl2ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl3ID", System.Data.SqlDbType.Int, 0, "Raw_lvl3ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl4ID", System.Data.SqlDbType.Int, 0, "Raw_lvl4ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_LEMOS", System.Data.SqlDbType.VarChar, 0, "Raw_LEMOS"),
            new System.Data.SqlClient.SqlParameter("@Budget", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Budget", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Actual", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Actual", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TransferedToDate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TransferedToDate", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NewTransferAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewTransferAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Dev_Pri_ID", System.Data.SqlDbType.Int, 0, "Dev_Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl1ID", System.Data.SqlDbType.Int, 0, "Dev_lvl1ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl2ID", System.Data.SqlDbType.Int, 0, "Dev_lvl2ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl3ID", System.Data.SqlDbType.Int, 0, "Dev_lvl3ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl4ID", System.Data.SqlDbType.Int, 0, "Dev_lvl4ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_LEMOS", System.Data.SqlDbType.VarChar, 0, "Dev_LEMOS"),
            new System.Data.SqlClient.SqlParameter("@Dev_Matched", System.Data.SqlDbType.Bit, 0, "Dev_Matched"),
            new System.Data.SqlClient.SqlParameter("@LevelsValid", System.Data.SqlDbType.Bit, 0, "LevelsValid")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@Raw_Pri_ID", System.Data.SqlDbType.Int, 0, "Raw_Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl1ID", System.Data.SqlDbType.Int, 0, "Raw_lvl1ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl2ID", System.Data.SqlDbType.Int, 0, "Raw_lvl2ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl3ID", System.Data.SqlDbType.Int, 0, "Raw_lvl3ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_lvl4ID", System.Data.SqlDbType.Int, 0, "Raw_lvl4ID"),
            new System.Data.SqlClient.SqlParameter("@Raw_LEMOS", System.Data.SqlDbType.VarChar, 0, "Raw_LEMOS"),
            new System.Data.SqlClient.SqlParameter("@Budget", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Budget", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Actual", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Actual", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TransferedToDate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TransferedToDate", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NewTransferAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewTransferAmount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Dev_Pri_ID", System.Data.SqlDbType.Int, 0, "Dev_Pri_ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl1ID", System.Data.SqlDbType.Int, 0, "Dev_lvl1ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl2ID", System.Data.SqlDbType.Int, 0, "Dev_lvl2ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl3ID", System.Data.SqlDbType.Int, 0, "Dev_lvl3ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_lvl4ID", System.Data.SqlDbType.Int, 0, "Dev_lvl4ID"),
            new System.Data.SqlClient.SqlParameter("@Dev_LEMOS", System.Data.SqlDbType.VarChar, 0, "Dev_LEMOS"),
            new System.Data.SqlClient.SqlParameter("@Dev_Matched", System.Data.SqlDbType.Bit, 0, "Dev_Matched"),
            new System.Data.SqlClient.SqlParameter("@LevelsValid", System.Data.SqlDbType.Bit, 0, "LevelsValid"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_LEMOS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_LEMOS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_LEMOS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_LEMOS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Budget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Budget", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Budget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Actual", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Actual", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Actual", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Actual", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TransferedToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TransferedToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TransferedToDate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TransferedToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NewTransferAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NewTransferAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NewTransferAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewTransferAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_LEMOS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_LEMOS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_LEMOS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_LEMOS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_Matched", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_Matched", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_Matched", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_Matched", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevelsValid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevelsValid", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevelsValid", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevelsValid", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_lvl4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_lvl4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Raw_LEMOS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Raw_LEMOS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Raw_LEMOS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Raw_LEMOS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Budget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Budget", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Budget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Actual", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Actual", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Actual", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Actual", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TransferedToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TransferedToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TransferedToDate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TransferedToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NewTransferAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NewTransferAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NewTransferAmount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NewTransferAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_Pri_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_Pri_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_Pri_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_lvl4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_lvl4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_lvl4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_LEMOS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_LEMOS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_LEMOS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_LEMOS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Dev_Matched", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Dev_Matched", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Dev_Matched", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dev_Matched", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LevelsValid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LevelsValid", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LevelsValid", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LevelsValid", System.Data.DataRowVersion.Original, null)});
            // 
            // da_working_ld_costs_to_transfer
            // 
            this.da_working_ld_costs_to_transfer.DeleteCommand = this.sqlDeleteCommand1;
            this.da_working_ld_costs_to_transfer.InsertCommand = this.sqlInsertCommand1;
            this.da_working_ld_costs_to_transfer.SelectCommand = this.sqlSelectCommand1;
            this.da_working_ld_costs_to_transfer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_costs_to_transfer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("Raw_Pri_ID", "Raw_Pri_ID"),
                        new System.Data.Common.DataColumnMapping("Raw_lvl1ID", "Raw_lvl1ID"),
                        new System.Data.Common.DataColumnMapping("Raw_lvl2ID", "Raw_lvl2ID"),
                        new System.Data.Common.DataColumnMapping("Raw_lvl3ID", "Raw_lvl3ID"),
                        new System.Data.Common.DataColumnMapping("Raw_lvl4ID", "Raw_lvl4ID"),
                        new System.Data.Common.DataColumnMapping("Raw_LEMOS", "Raw_LEMOS"),
                        new System.Data.Common.DataColumnMapping("Budget", "Budget"),
                        new System.Data.Common.DataColumnMapping("Actual", "Actual"),
                        new System.Data.Common.DataColumnMapping("TransferedToDate", "TransferedToDate"),
                        new System.Data.Common.DataColumnMapping("NewTransferAmount", "NewTransferAmount"),
                        new System.Data.Common.DataColumnMapping("Dev_Pri_ID", "Dev_Pri_ID"),
                        new System.Data.Common.DataColumnMapping("Dev_lvl1ID", "Dev_lvl1ID"),
                        new System.Data.Common.DataColumnMapping("Dev_lvl2ID", "Dev_lvl2ID"),
                        new System.Data.Common.DataColumnMapping("Dev_lvl3ID", "Dev_lvl3ID"),
                        new System.Data.Common.DataColumnMapping("Dev_lvl4ID", "Dev_lvl4ID"),
                        new System.Data.Common.DataColumnMapping("Dev_LEMOS", "Dev_LEMOS"),
                        new System.Data.Common.DataColumnMapping("Dev_Matched", "Dev_Matched"),
                        new System.Data.Common.DataColumnMapping("BudgetRemaining", "BudgetRemaining"),
                        new System.Data.Common.DataColumnMapping("LevelsValid", "LevelsValid")})});
            this.da_working_ld_costs_to_transfer.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 4, "lv1ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null)});
            // 
            // da_Level1
            // 
            this.da_Level1.DeleteCommand = this.sqlDeleteCommand2;
            this.da_Level1.InsertCommand = this.sqlInsertCommand2;
            this.da_Level1.SelectCommand = this.sqlSelectCommand2;
            this.da_Level1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level1_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv1_code", "lv1_code"),
                        new System.Data.Common.DataColumnMapping("lv1_desc", "lv1_desc"),
                        new System.Data.Common.DataColumnMapping("active", "active"),
                        new System.Data.Common.DataColumnMapping("InBudget", "InBudget"),
                        new System.Data.Common.DataColumnMapping("DevPri_ID", "DevPri_ID")})});
            this.da_Level1.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 4, "lv2ID")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null)});
            // 
            // da_Level2
            // 
            this.da_Level2.DeleteCommand = this.sqlDeleteCommand3;
            this.da_Level2.InsertCommand = this.sqlInsertCommand3;
            this.da_Level2.SelectCommand = this.sqlSelectCommand3;
            this.da_Level2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level2_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv2_code", "lv2_code"),
                        new System.Data.Common.DataColumnMapping("lv2_desc", "lv2_desc"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("active", "active"),
                        new System.Data.Common.DataColumnMapping("InBudget", "InBudget"),
                        new System.Data.Common.DataColumnMapping("DevPri_ID", "DevPri_ID")})});
            this.da_Level2.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlTRConnection;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlTRConnection;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 4, "lv3ID")});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null)});
            // 
            // da_Level3
            // 
            this.da_Level3.DeleteCommand = this.sqlDeleteCommand4;
            this.da_Level3.InsertCommand = this.sqlInsertCommand4;
            this.da_Level3.SelectCommand = this.sqlSelectCommand4;
            this.da_Level3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level3_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv3_code", "lv3_code"),
                        new System.Data.Common.DataColumnMapping("lv3_desc", "lv3_desc"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("active", "active"),
                        new System.Data.Common.DataColumnMapping("InBudget", "InBudget"),
                        new System.Data.Common.DataColumnMapping("DevPri_ID", "DevPri_ID")})});
            this.da_Level3.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlTRConnection;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = resources.GetString("sqlInsertCommand5.CommandText");
            this.sqlInsertCommand5.Connection = this.sqlTRConnection;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand5
            // 
            this.sqlUpdateCommand5.CommandText = resources.GetString("sqlUpdateCommand5.CommandText");
            this.sqlUpdateCommand5.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@active", System.Data.SqlDbType.VarChar, 0, "active"),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 4, "lv4ID")});
            // 
            // sqlDeleteCommand5
            // 
            this.sqlDeleteCommand5.CommandText = resources.GetString("sqlDeleteCommand5.CommandText");
            this.sqlDeleteCommand5.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_active", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "active", System.Data.DataRowVersion.Original, null)});
            // 
            // da_Level4
            // 
            this.da_Level4.DeleteCommand = this.sqlDeleteCommand5;
            this.da_Level4.InsertCommand = this.sqlInsertCommand5;
            this.da_Level4.SelectCommand = this.sqlSelectCommand5;
            this.da_Level4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level4_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("lv4_code", "lv4_code"),
                        new System.Data.Common.DataColumnMapping("lv4_desc", "lv4_desc"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("active", "active"),
                        new System.Data.Common.DataColumnMapping("InBudget", "InBudget"),
                        new System.Data.Common.DataColumnMapping("DevPri_ID", "DevPri_ID")})});
            this.da_Level4.UpdateCommand = this.sqlUpdateCommand5;
            // 
            // bs_lv1_Filtered
            // 
            this.bs_lv1_Filtered.DataMember = "Level1_Codes";
            this.bs_lv1_Filtered.DataSource = this.ds_ALL_Levels1;
            // 
            // bs_lv2_Filtered
            // 
            this.bs_lv2_Filtered.DataMember = "Level2_Codes";
            this.bs_lv2_Filtered.DataSource = this.ds_ALL_Levels1;
            // 
            // bs_lv3_Filtered
            // 
            this.bs_lv3_Filtered.DataMember = "Level3_Codes";
            this.bs_lv3_Filtered.DataSource = this.ds_ALL_Levels1;
            // 
            // bs_lv4_Filtered
            // 
            this.bs_lv4_Filtered.DataMember = "Level4_Codes";
            this.bs_lv4_Filtered.DataSource = this.ds_ALL_Levels1;
            // 
            // ucCostSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCostSelection);
            this.Controls.Add(this.pnlSelections);
            this.Name = "ucCostSelection";
            this.Size = new System.Drawing.Size(1223, 800);
            this.Load += new System.EventHandler(this.ucCostSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelections)).EndInit();
            this.pnlSelections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgCostComparision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowZero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgActOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgBudgetActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCostSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_working_ld_costs_to_transfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_working_ld_costs_to_transfer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCostSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ALL_Levels1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Lv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel1Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel2Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel3Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLevel4Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv1_Filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv2_Filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv3_Filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lv4_Filtered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlSelections;
        private DevExpress.XtraEditors.RadioGroup rgBudgetActual;
        private AccountingPicker.ucAccountingPicker ucAccountingPicker1;
        private DevExpress.XtraEditors.RadioGroup rgActOptions;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraGrid.GridControl gcCostSelection;
        private DevExpress.XtraEditors.RadioGroup rgCostComparision;
        private DevExpress.XtraEditors.CheckEdit ceShowZero;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter da_working_ld_costs_to_transfer;
        private ds_working_ld_costs_to_transfer ds_working_ld_costs_to_transfer1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCostSelection;
        private System.Windows.Forms.BindingSource bs_working_ld_costs_to_transfer;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_Pri_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl1ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl2ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl3ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl4ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_LEMOS;
        private DevExpress.XtraGrid.Columns.GridColumn colBudget;
        private DevExpress.XtraGrid.Columns.GridColumn colActual;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferedToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNewTransferAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_Pri_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl1ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl2ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl3ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl4ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_LEMOS;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_Level1;
        private ds_ALL_Levels ds_ALL_Levels1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter da_Level2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter da_Level3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand5;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand5;
        private System.Data.SqlClient.SqlDataAdapter da_Level4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel1;
        private System.Windows.Forms.BindingSource bs_lv1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel2;
        private System.Windows.Forms.BindingSource bs_lv2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel3;
        private System.Windows.Forms.BindingSource bs_Lv3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel4;
        private System.Windows.Forms.BindingSource bs_lv4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel1Desc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel2Desc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel3Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl1ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl2ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl3ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_lvl4ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl1ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl2ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl3ID_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colRaw_lvl4ID_Desc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLevel4Desc;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric2;
        private System.Windows.Forms.BindingSource bs_lv1_Filtered;
        private System.Windows.Forms.BindingSource bs_lv2_Filtered;
        private System.Windows.Forms.BindingSource bs_lv3_Filtered;
        private System.Windows.Forms.BindingSource bs_lv4_Filtered;
        private DevExpress.XtraGrid.Columns.GridColumn colDev_Matched;
        private DevExpress.XtraGrid.Columns.GridColumn colBudgetRemaining;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelsValid;
    }
}
