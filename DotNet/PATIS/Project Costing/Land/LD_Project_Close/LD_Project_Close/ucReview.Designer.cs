namespace LD_Project_Close
{
    partial class ucReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReview));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcProject = new DevExpress.XtraGrid.GridControl();
            this.ds_header1 = new LD_Project_Close.ds_header();
            this.gvProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseg_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseg_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualsToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOSToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovedBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisedBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseAdjustmentsAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProjDetails = new DevExpress.XtraGrid.GridControl();
            this.ds_detail1 = new LD_Project_Close.ds_detail();
            this.gvProjDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_1_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_2_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_3_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_4_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_1_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_2_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_3_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvl_4_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualsToDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalBudget1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovedBudget1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisedBudget1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVariance1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_header = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_detail = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_detail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deInvoiceDate);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1225, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(296, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Close Date";
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.Location = new System.Drawing.Point(365, 12);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.deInvoiceDate.TabIndex = 1;
            // 
            // acctYearPeriod1
            // 
            this.acctYearPeriod1.Location = new System.Drawing.Point(3, 4);
            this.acctYearPeriod1.Name = "acctYearPeriod1";
            this.acctYearPeriod1.Size = new System.Drawing.Size(287, 31);
            this.acctYearPeriod1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcProject);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcProjDetails);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1225, 632);
            this.splitContainerControl1.SplitterPosition = 182;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcProject
            // 
            this.gcProject.DataMember = "working_ld_pca_ProjectHeader";
            this.gcProject.DataSource = this.ds_header1;
            this.gcProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProject.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProject.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProject.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProject.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProject.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProject.Location = new System.Drawing.Point(0, 0);
            this.gcProject.MainView = this.gvProject;
            this.gcProject.Name = "gcProject";
            this.gcProject.Size = new System.Drawing.Size(1225, 182);
            this.gcProject.TabIndex = 0;
            this.gcProject.UseEmbeddedNavigator = true;
            this.gcProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProject});
            // 
            // ds_header1
            // 
            this.ds_header1.DataSetName = "ds_header";
            this.ds_header1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProject
            // 
            this.gvProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colpri_id,
            this.colpri_code,
            this.colpri_name,
            this.colseg_2,
            this.colseg_3,
            this.colTotalRevenue,
            this.colActualsToDate,
            this.colCOSToDate,
            this.colOriginalBudget,
            this.colApprovedBudget,
            this.colRevisedBudget,
            this.colCloseAdjustmentsAmount,
            this.colVariance});
            this.gvProject.GridControl = this.gcProject;
            this.gvProject.Name = "gvProject";
            this.gvProject.OptionsBehavior.Editable = false;
            this.gvProject.OptionsView.ColumnAutoWidth = false;
            this.gvProject.OptionsView.ShowFooter = true;
            this.gvProject.OptionsView.ShowGroupPanel = false;
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
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project #";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 0;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.Visible = true;
            this.colpri_name.VisibleIndex = 1;
            this.colpri_name.Width = 142;
            // 
            // colseg_2
            // 
            this.colseg_2.FieldName = "seg_2";
            this.colseg_2.Name = "colseg_2";
            this.colseg_2.Visible = true;
            this.colseg_2.VisibleIndex = 2;
            this.colseg_2.Width = 60;
            // 
            // colseg_3
            // 
            this.colseg_3.FieldName = "seg_3";
            this.colseg_3.Name = "colseg_3";
            this.colseg_3.Visible = true;
            this.colseg_3.VisibleIndex = 3;
            this.colseg_3.Width = 60;
            // 
            // colTotalRevenue
            // 
            this.colTotalRevenue.Caption = "Total Revenue";
            this.colTotalRevenue.DisplayFormat.FormatString = "n2";
            this.colTotalRevenue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalRevenue.FieldName = "TotalRevenue";
            this.colTotalRevenue.Name = "colTotalRevenue";
            this.colTotalRevenue.OptionsColumn.AllowEdit = false;
            this.colTotalRevenue.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalRevenue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalRevenue.Visible = true;
            this.colTotalRevenue.VisibleIndex = 4;
            this.colTotalRevenue.Width = 100;
            // 
            // colActualsToDate
            // 
            this.colActualsToDate.Caption = "Actuals To Date";
            this.colActualsToDate.DisplayFormat.FormatString = "n2";
            this.colActualsToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActualsToDate.FieldName = "ActualsToDate";
            this.colActualsToDate.Name = "colActualsToDate";
            this.colActualsToDate.OptionsColumn.AllowEdit = false;
            this.colActualsToDate.SummaryItem.DisplayFormat = "{0:n2}";
            this.colActualsToDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colActualsToDate.Visible = true;
            this.colActualsToDate.VisibleIndex = 5;
            this.colActualsToDate.Width = 100;
            // 
            // colCOSToDate
            // 
            this.colCOSToDate.Caption = "COS To Date";
            this.colCOSToDate.DisplayFormat.FormatString = "n2";
            this.colCOSToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOSToDate.FieldName = "COSToDate";
            this.colCOSToDate.Name = "colCOSToDate";
            this.colCOSToDate.OptionsColumn.AllowEdit = false;
            this.colCOSToDate.SummaryItem.DisplayFormat = "{0:n2}";
            this.colCOSToDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCOSToDate.Visible = true;
            this.colCOSToDate.VisibleIndex = 6;
            this.colCOSToDate.Width = 100;
            // 
            // colOriginalBudget
            // 
            this.colOriginalBudget.Caption = "Original Budget";
            this.colOriginalBudget.DisplayFormat.FormatString = "n2";
            this.colOriginalBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOriginalBudget.FieldName = "OriginalBudget";
            this.colOriginalBudget.Name = "colOriginalBudget";
            this.colOriginalBudget.OptionsColumn.AllowEdit = false;
            this.colOriginalBudget.SummaryItem.DisplayFormat = "{0:n2}";
            this.colOriginalBudget.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOriginalBudget.Visible = true;
            this.colOriginalBudget.VisibleIndex = 7;
            this.colOriginalBudget.Width = 100;
            // 
            // colApprovedBudget
            // 
            this.colApprovedBudget.Caption = "Approved Budget";
            this.colApprovedBudget.DisplayFormat.FormatString = "n2";
            this.colApprovedBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colApprovedBudget.FieldName = "ApprovedBudget";
            this.colApprovedBudget.Name = "colApprovedBudget";
            this.colApprovedBudget.OptionsColumn.AllowEdit = false;
            this.colApprovedBudget.SummaryItem.DisplayFormat = "{0:n2}";
            this.colApprovedBudget.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colApprovedBudget.Visible = true;
            this.colApprovedBudget.VisibleIndex = 8;
            this.colApprovedBudget.Width = 106;
            // 
            // colRevisedBudget
            // 
            this.colRevisedBudget.Caption = "Revised Budget";
            this.colRevisedBudget.DisplayFormat.FormatString = "n2";
            this.colRevisedBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRevisedBudget.FieldName = "RevisedBudget";
            this.colRevisedBudget.Name = "colRevisedBudget";
            this.colRevisedBudget.OptionsColumn.AllowEdit = false;
            this.colRevisedBudget.SummaryItem.DisplayFormat = "{0:n2}";
            this.colRevisedBudget.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRevisedBudget.Visible = true;
            this.colRevisedBudget.VisibleIndex = 9;
            this.colRevisedBudget.Width = 100;
            // 
            // colCloseAdjustmentsAmount
            // 
            this.colCloseAdjustmentsAmount.Caption = "Close Adjustment Amount";
            this.colCloseAdjustmentsAmount.DisplayFormat.FormatString = "n2";
            this.colCloseAdjustmentsAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseAdjustmentsAmount.FieldName = "CloseAdjustmentsAmount";
            this.colCloseAdjustmentsAmount.Name = "colCloseAdjustmentsAmount";
            this.colCloseAdjustmentsAmount.OptionsColumn.AllowEdit = false;
            this.colCloseAdjustmentsAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colCloseAdjustmentsAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseAdjustmentsAmount.Visible = true;
            this.colCloseAdjustmentsAmount.VisibleIndex = 10;
            this.colCloseAdjustmentsAmount.Width = 146;
            // 
            // colVariance
            // 
            this.colVariance.Caption = "Variance";
            this.colVariance.DisplayFormat.FormatString = "n2";
            this.colVariance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVariance.FieldName = "Variance";
            this.colVariance.Name = "colVariance";
            this.colVariance.OptionsColumn.AllowEdit = false;
            this.colVariance.SummaryItem.DisplayFormat = "{0:n2}";
            this.colVariance.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colVariance.Visible = true;
            this.colVariance.VisibleIndex = 11;
            this.colVariance.Width = 100;
            // 
            // gcProjDetails
            // 
            this.gcProjDetails.DataMember = "working_ld_pca_ProjectDetail";
            this.gcProjDetails.DataSource = this.ds_detail1;
            this.gcProjDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProjDetails.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProjDetails.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProjDetails.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProjDetails.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProjDetails.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProjDetails.Location = new System.Drawing.Point(0, 0);
            this.gcProjDetails.MainView = this.gvProjDetails;
            this.gcProjDetails.Name = "gcProjDetails";
            this.gcProjDetails.Size = new System.Drawing.Size(1225, 444);
            this.gcProjDetails.TabIndex = 0;
            this.gcProjDetails.UseEmbeddedNavigator = true;
            this.gcProjDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProjDetails});
            // 
            // ds_detail1
            // 
            this.ds_detail1.DataSetName = "ds_detail";
            this.ds_detail1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProjDetails
            // 
            this.gvProjDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colusername1,
            this.collvl_1_ID,
            this.collvl_2_ID,
            this.collvl_3_ID,
            this.collvl_4_ID,
            this.colpri_id1,
            this.collvl_1_Code,
            this.collvl_2_Code,
            this.collvl_3_Code,
            this.collvl_4_Code,
            this.collvl_1_Description,
            this.collvl_2_Description,
            this.collvl_3_Description,
            this.collvl_4_Description,
            this.colActualsToDate1,
            this.colOriginalBudget1,
            this.colApprovedBudget1,
            this.colRevisedBudget1,
            this.colVariance1});
            this.gvProjDetails.GridControl = this.gcProjDetails;
            this.gvProjDetails.Name = "gvProjDetails";
            this.gvProjDetails.OptionsBehavior.Editable = false;
            this.gvProjDetails.OptionsView.ColumnAutoWidth = false;
            this.gvProjDetails.OptionsView.ShowFooter = true;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername1
            // 
            this.colusername1.FieldName = "username";
            this.colusername1.Name = "colusername1";
            this.colusername1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // collvl_1_ID
            // 
            this.collvl_1_ID.FieldName = "lvl_1_ID";
            this.collvl_1_ID.Name = "collvl_1_ID";
            this.collvl_1_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // collvl_2_ID
            // 
            this.collvl_2_ID.FieldName = "lvl_2_ID";
            this.collvl_2_ID.Name = "collvl_2_ID";
            this.collvl_2_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // collvl_3_ID
            // 
            this.collvl_3_ID.FieldName = "lvl_3_ID";
            this.collvl_3_ID.Name = "collvl_3_ID";
            this.collvl_3_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // collvl_4_ID
            // 
            this.collvl_4_ID.FieldName = "lvl_4_ID";
            this.collvl_4_ID.Name = "collvl_4_ID";
            this.collvl_4_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_id1
            // 
            this.colpri_id1.FieldName = "pri_id";
            this.colpri_id1.Name = "colpri_id1";
            this.colpri_id1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // collvl_1_Code
            // 
            this.collvl_1_Code.FieldName = "lvl_1_Code";
            this.collvl_1_Code.Name = "collvl_1_Code";
            this.collvl_1_Code.Visible = true;
            this.collvl_1_Code.VisibleIndex = 0;
            this.collvl_1_Code.Width = 89;
            // 
            // collvl_2_Code
            // 
            this.collvl_2_Code.FieldName = "lvl_2_Code";
            this.collvl_2_Code.Name = "collvl_2_Code";
            this.collvl_2_Code.Visible = true;
            this.collvl_2_Code.VisibleIndex = 1;
            this.collvl_2_Code.Width = 89;
            // 
            // collvl_3_Code
            // 
            this.collvl_3_Code.FieldName = "lvl_3_Code";
            this.collvl_3_Code.Name = "collvl_3_Code";
            this.collvl_3_Code.Visible = true;
            this.collvl_3_Code.VisibleIndex = 2;
            this.collvl_3_Code.Width = 89;
            // 
            // collvl_4_Code
            // 
            this.collvl_4_Code.FieldName = "lvl_4_Code";
            this.collvl_4_Code.Name = "collvl_4_Code";
            this.collvl_4_Code.Visible = true;
            this.collvl_4_Code.VisibleIndex = 3;
            this.collvl_4_Code.Width = 89;
            // 
            // collvl_1_Description
            // 
            this.collvl_1_Description.FieldName = "lvl_1_Description";
            this.collvl_1_Description.Name = "collvl_1_Description";
            this.collvl_1_Description.Width = 110;
            // 
            // collvl_2_Description
            // 
            this.collvl_2_Description.FieldName = "lvl_2_Description";
            this.collvl_2_Description.Name = "collvl_2_Description";
            this.collvl_2_Description.Width = 110;
            // 
            // collvl_3_Description
            // 
            this.collvl_3_Description.FieldName = "lvl_3_Description";
            this.collvl_3_Description.Name = "collvl_3_Description";
            this.collvl_3_Description.Width = 110;
            // 
            // collvl_4_Description
            // 
            this.collvl_4_Description.FieldName = "lvl_4_Description";
            this.collvl_4_Description.Name = "collvl_4_Description";
            this.collvl_4_Description.Width = 110;
            // 
            // colActualsToDate1
            // 
            this.colActualsToDate1.Caption = "Actuals To Date";
            this.colActualsToDate1.DisplayFormat.FormatString = "n2";
            this.colActualsToDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActualsToDate1.FieldName = "ActualsToDate";
            this.colActualsToDate1.Name = "colActualsToDate1";
            this.colActualsToDate1.OptionsColumn.AllowEdit = false;
            this.colActualsToDate1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colActualsToDate1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colActualsToDate1.Visible = true;
            this.colActualsToDate1.VisibleIndex = 4;
            this.colActualsToDate1.Width = 116;
            // 
            // colOriginalBudget1
            // 
            this.colOriginalBudget1.Caption = "Original Budget";
            this.colOriginalBudget1.DisplayFormat.FormatString = "n2";
            this.colOriginalBudget1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOriginalBudget1.FieldName = "OriginalBudget";
            this.colOriginalBudget1.Name = "colOriginalBudget1";
            this.colOriginalBudget1.OptionsColumn.AllowEdit = false;
            this.colOriginalBudget1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colOriginalBudget1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOriginalBudget1.Visible = true;
            this.colOriginalBudget1.VisibleIndex = 5;
            this.colOriginalBudget1.Width = 116;
            // 
            // colApprovedBudget1
            // 
            this.colApprovedBudget1.Caption = "Approved Budget";
            this.colApprovedBudget1.DisplayFormat.FormatString = "n2";
            this.colApprovedBudget1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colApprovedBudget1.FieldName = "ApprovedBudget";
            this.colApprovedBudget1.Name = "colApprovedBudget1";
            this.colApprovedBudget1.OptionsColumn.AllowEdit = false;
            this.colApprovedBudget1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colApprovedBudget1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colApprovedBudget1.Visible = true;
            this.colApprovedBudget1.VisibleIndex = 6;
            this.colApprovedBudget1.Width = 116;
            // 
            // colRevisedBudget1
            // 
            this.colRevisedBudget1.Caption = "Revised Budget";
            this.colRevisedBudget1.DisplayFormat.FormatString = "n2";
            this.colRevisedBudget1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRevisedBudget1.FieldName = "RevisedBudget";
            this.colRevisedBudget1.Name = "colRevisedBudget1";
            this.colRevisedBudget1.OptionsColumn.AllowEdit = false;
            this.colRevisedBudget1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colRevisedBudget1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRevisedBudget1.Visible = true;
            this.colRevisedBudget1.VisibleIndex = 7;
            this.colRevisedBudget1.Width = 116;
            // 
            // colVariance1
            // 
            this.colVariance1.Caption = "Variance";
            this.colVariance1.DisplayFormat.FormatString = "n2";
            this.colVariance1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVariance1.FieldName = "Variance";
            this.colVariance1.Name = "colVariance1";
            this.colVariance1.OptionsColumn.AllowEdit = false;
            this.colVariance1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colVariance1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colVariance1.Visible = true;
            this.colVariance1.VisibleIndex = 8;
            this.colVariance1.Width = 120;
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
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@seg_2", System.Data.SqlDbType.VarChar, 0, "seg_2"),
            new System.Data.SqlClient.SqlParameter("@seg_3", System.Data.SqlDbType.VarChar, 0, "seg_3"),
            new System.Data.SqlClient.SqlParameter("@TotalRevenue", System.Data.SqlDbType.Money, 0, "TotalRevenue"),
            new System.Data.SqlClient.SqlParameter("@ActualsToDate", System.Data.SqlDbType.Money, 0, "ActualsToDate"),
            new System.Data.SqlClient.SqlParameter("@COSToDate", System.Data.SqlDbType.Money, 0, "COSToDate"),
            new System.Data.SqlClient.SqlParameter("@OriginalBudget", System.Data.SqlDbType.Money, 0, "OriginalBudget"),
            new System.Data.SqlClient.SqlParameter("@ApprovedBudget", System.Data.SqlDbType.Money, 0, "ApprovedBudget"),
            new System.Data.SqlClient.SqlParameter("@RevisedBudget", System.Data.SqlDbType.Money, 0, "RevisedBudget"),
            new System.Data.SqlClient.SqlParameter("@CloseAdjustmentsAmount", System.Data.SqlDbType.Money, 0, "CloseAdjustmentsAmount"),
            new System.Data.SqlClient.SqlParameter("@Variance", System.Data.SqlDbType.Money, 0, "Variance")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@seg_2", System.Data.SqlDbType.VarChar, 0, "seg_2"),
            new System.Data.SqlClient.SqlParameter("@seg_3", System.Data.SqlDbType.VarChar, 0, "seg_3"),
            new System.Data.SqlClient.SqlParameter("@TotalRevenue", System.Data.SqlDbType.Money, 0, "TotalRevenue"),
            new System.Data.SqlClient.SqlParameter("@ActualsToDate", System.Data.SqlDbType.Money, 0, "ActualsToDate"),
            new System.Data.SqlClient.SqlParameter("@COSToDate", System.Data.SqlDbType.Money, 0, "COSToDate"),
            new System.Data.SqlClient.SqlParameter("@OriginalBudget", System.Data.SqlDbType.Money, 0, "OriginalBudget"),
            new System.Data.SqlClient.SqlParameter("@ApprovedBudget", System.Data.SqlDbType.Money, 0, "ApprovedBudget"),
            new System.Data.SqlClient.SqlParameter("@RevisedBudget", System.Data.SqlDbType.Money, 0, "RevisedBudget"),
            new System.Data.SqlClient.SqlParameter("@CloseAdjustmentsAmount", System.Data.SqlDbType.Money, 0, "CloseAdjustmentsAmount"),
            new System.Data.SqlClient.SqlParameter("@Variance", System.Data.SqlDbType.Money, 0, "Variance"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_seg_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "seg_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_seg_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "seg_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_seg_3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "seg_3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_seg_3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "seg_3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalRevenue", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalRevenue", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalRevenue", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalRevenue", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualsToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualsToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COSToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COSToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COSToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COSToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ApprovedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ApprovedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevisedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevisedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CloseAdjustmentsAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CloseAdjustmentsAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CloseAdjustmentsAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CloseAdjustmentsAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Variance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Variance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_seg_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "seg_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_seg_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "seg_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_seg_3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "seg_3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_seg_3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "seg_3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalRevenue", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalRevenue", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalRevenue", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalRevenue", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualsToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualsToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COSToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COSToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COSToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COSToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ApprovedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ApprovedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevisedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevisedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CloseAdjustmentsAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CloseAdjustmentsAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CloseAdjustmentsAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CloseAdjustmentsAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Variance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Variance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, null)});
            // 
            // da_header
            // 
            this.da_header.DeleteCommand = this.sqlDeleteCommand1;
            this.da_header.InsertCommand = this.sqlInsertCommand1;
            this.da_header.SelectCommand = this.sqlSelectCommand1;
            this.da_header.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_pca_ProjectHeader", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("seg_2", "seg_2"),
                        new System.Data.Common.DataColumnMapping("seg_3", "seg_3"),
                        new System.Data.Common.DataColumnMapping("TotalRevenue", "TotalRevenue"),
                        new System.Data.Common.DataColumnMapping("ActualsToDate", "ActualsToDate"),
                        new System.Data.Common.DataColumnMapping("COSToDate", "COSToDate"),
                        new System.Data.Common.DataColumnMapping("OriginalBudget", "OriginalBudget"),
                        new System.Data.Common.DataColumnMapping("ApprovedBudget", "ApprovedBudget"),
                        new System.Data.Common.DataColumnMapping("RevisedBudget", "RevisedBudget"),
                        new System.Data.Common.DataColumnMapping("CloseAdjustmentsAmount", "CloseAdjustmentsAmount"),
                        new System.Data.Common.DataColumnMapping("Variance", "Variance")})});
            this.da_header.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_ID", System.Data.SqlDbType.Int, 0, "lvl_1_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_ID", System.Data.SqlDbType.Int, 0, "lvl_2_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_ID", System.Data.SqlDbType.Int, 0, "lvl_3_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_ID", System.Data.SqlDbType.Int, 0, "lvl_4_ID"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_Code", System.Data.SqlDbType.VarChar, 0, "lvl_1_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_Code", System.Data.SqlDbType.VarChar, 0, "lvl_2_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_Code", System.Data.SqlDbType.VarChar, 0, "lvl_3_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_Code", System.Data.SqlDbType.VarChar, 0, "lvl_4_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_Description", System.Data.SqlDbType.VarChar, 0, "lvl_1_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_Description", System.Data.SqlDbType.VarChar, 0, "lvl_2_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_Description", System.Data.SqlDbType.VarChar, 0, "lvl_3_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_Description", System.Data.SqlDbType.VarChar, 0, "lvl_4_Description"),
            new System.Data.SqlClient.SqlParameter("@ActualsToDate", System.Data.SqlDbType.Money, 0, "ActualsToDate"),
            new System.Data.SqlClient.SqlParameter("@OriginalBudget", System.Data.SqlDbType.Money, 0, "OriginalBudget"),
            new System.Data.SqlClient.SqlParameter("@ApprovedBudget", System.Data.SqlDbType.Money, 0, "ApprovedBudget"),
            new System.Data.SqlClient.SqlParameter("@RevisedBudget", System.Data.SqlDbType.Money, 0, "RevisedBudget"),
            new System.Data.SqlClient.SqlParameter("@Variance", System.Data.SqlDbType.Money, 0, "Variance")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_ID", System.Data.SqlDbType.Int, 0, "lvl_1_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_ID", System.Data.SqlDbType.Int, 0, "lvl_2_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_ID", System.Data.SqlDbType.Int, 0, "lvl_3_ID"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_ID", System.Data.SqlDbType.Int, 0, "lvl_4_ID"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_Code", System.Data.SqlDbType.VarChar, 0, "lvl_1_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_Code", System.Data.SqlDbType.VarChar, 0, "lvl_2_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_Code", System.Data.SqlDbType.VarChar, 0, "lvl_3_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_Code", System.Data.SqlDbType.VarChar, 0, "lvl_4_Code"),
            new System.Data.SqlClient.SqlParameter("@lvl_1_Description", System.Data.SqlDbType.VarChar, 0, "lvl_1_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_2_Description", System.Data.SqlDbType.VarChar, 0, "lvl_2_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_3_Description", System.Data.SqlDbType.VarChar, 0, "lvl_3_Description"),
            new System.Data.SqlClient.SqlParameter("@lvl_4_Description", System.Data.SqlDbType.VarChar, 0, "lvl_4_Description"),
            new System.Data.SqlClient.SqlParameter("@ActualsToDate", System.Data.SqlDbType.Money, 0, "ActualsToDate"),
            new System.Data.SqlClient.SqlParameter("@OriginalBudget", System.Data.SqlDbType.Money, 0, "OriginalBudget"),
            new System.Data.SqlClient.SqlParameter("@ApprovedBudget", System.Data.SqlDbType.Money, 0, "ApprovedBudget"),
            new System.Data.SqlClient.SqlParameter("@RevisedBudget", System.Data.SqlDbType.Money, 0, "RevisedBudget"),
            new System.Data.SqlClient.SqlParameter("@Variance", System.Data.SqlDbType.Money, 0, "Variance"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualsToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualsToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ApprovedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ApprovedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevisedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevisedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Variance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Variance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_1_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_1_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_1_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_1_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_2_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_2_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_2_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_2_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_3_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_3_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_3_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_3_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lvl_4_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lvl_4_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lvl_4_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lvl_4_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualsToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualsToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualsToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ApprovedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ApprovedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ApprovedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevisedBudget", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevisedBudget", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevisedBudget", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Variance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Variance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Variance", System.Data.DataRowVersion.Original, null)});
            // 
            // da_detail
            // 
            this.da_detail.DeleteCommand = this.sqlDeleteCommand2;
            this.da_detail.InsertCommand = this.sqlInsertCommand2;
            this.da_detail.SelectCommand = this.sqlSelectCommand2;
            this.da_detail.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_pca_ProjectDetail", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("lvl_1_ID", "lvl_1_ID"),
                        new System.Data.Common.DataColumnMapping("lvl_2_ID", "lvl_2_ID"),
                        new System.Data.Common.DataColumnMapping("lvl_3_ID", "lvl_3_ID"),
                        new System.Data.Common.DataColumnMapping("lvl_4_ID", "lvl_4_ID"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("lvl_1_Code", "lvl_1_Code"),
                        new System.Data.Common.DataColumnMapping("lvl_2_Code", "lvl_2_Code"),
                        new System.Data.Common.DataColumnMapping("lvl_3_Code", "lvl_3_Code"),
                        new System.Data.Common.DataColumnMapping("lvl_4_Code", "lvl_4_Code"),
                        new System.Data.Common.DataColumnMapping("lvl_1_Description", "lvl_1_Description"),
                        new System.Data.Common.DataColumnMapping("lvl_2_Description", "lvl_2_Description"),
                        new System.Data.Common.DataColumnMapping("lvl_3_Description", "lvl_3_Description"),
                        new System.Data.Common.DataColumnMapping("lvl_4_Description", "lvl_4_Description"),
                        new System.Data.Common.DataColumnMapping("ActualsToDate", "ActualsToDate"),
                        new System.Data.Common.DataColumnMapping("OriginalBudget", "OriginalBudget"),
                        new System.Data.Common.DataColumnMapping("ApprovedBudget", "ApprovedBudget"),
                        new System.Data.Common.DataColumnMapping("RevisedBudget", "RevisedBudget"),
                        new System.Data.Common.DataColumnMapping("Variance", "Variance")})});
            this.da_detail.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // ucReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucReview";
            this.Size = new System.Drawing.Size(1225, 672);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_header1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_detail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit deInvoiceDate;
        public AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcProject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProject;
        private DevExpress.XtraGrid.GridControl gcProjDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProjDetails;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter da_header;
        private ds_header ds_header1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_detail;
        private ds_detail ds_detail1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colseg_2;
        private DevExpress.XtraGrid.Columns.GridColumn colseg_3;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn colActualsToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCOSToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginalBudget;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedBudget;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisedBudget;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseAdjustmentsAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colVariance;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername1;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_2_ID;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_3_ID;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_4_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id1;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_1_Code;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_2_Code;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_3_Code;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_4_Code;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_1_Description;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_2_Description;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_3_Description;
        private DevExpress.XtraGrid.Columns.GridColumn collvl_4_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colActualsToDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginalBudget1;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovedBudget1;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisedBudget1;
        private DevExpress.XtraGrid.Columns.GridColumn colVariance1;
    }
}
