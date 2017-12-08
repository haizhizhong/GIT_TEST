namespace LD_Project_Close
{
    partial class ucSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSummary));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpnlSubledgerPreview = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReporting = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.tePeriod = new DevExpress.XtraEditors.TextEdit();
            this.teYear = new DevExpress.XtraEditors.TextEdit();
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
            this.da_header = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpnlSubledgerPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpnlSubledgerPreview});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpnlSubledgerPreview
            // 
            this.dpnlSubledgerPreview.Controls.Add(this.dockPanel1_Container);
            this.dpnlSubledgerPreview.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpnlSubledgerPreview.ID = new System.Guid("85f0a7ee-1f38-4a58-8873-a25e0f0fab68");
            this.dpnlSubledgerPreview.Location = new System.Drawing.Point(0, 308);
            this.dpnlSubledgerPreview.Name = "dpnlSubledgerPreview";
            this.dpnlSubledgerPreview.Size = new System.Drawing.Size(1234, 322);
            this.dpnlSubledgerPreview.Text = "Subledger Preveiw";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1228, 294);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnReporting);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deInvoiceDate);
            this.panelControl1.Controls.Add(this.tePeriod);
            this.panelControl1.Controls.Add(this.teYear);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1234, 34);
            this.panelControl1.TabIndex = 7;
            // 
            // btnReporting
            // 
            this.btnReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporting.Location = new System.Drawing.Point(1084, 4);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(134, 23);
            this.btnReporting.TabIndex = 6;
            this.btnReporting.Text = "Print Pre-Register";
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(223, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Close Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(120, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Period";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Year";
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.Enabled = false;
            this.deInvoiceDate.Location = new System.Drawing.Point(290, 7);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.deInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.deInvoiceDate.TabIndex = 2;
            // 
            // tePeriod
            // 
            this.tePeriod.Enabled = false;
            this.tePeriod.Location = new System.Drawing.Point(156, 7);
            this.tePeriod.Name = "tePeriod";
            this.tePeriod.Size = new System.Drawing.Size(61, 20);
            this.tePeriod.TabIndex = 1;
            // 
            // teYear
            // 
            this.teYear.Enabled = false;
            this.teYear.Location = new System.Drawing.Point(38, 6);
            this.teYear.Name = "teYear";
            this.teYear.Size = new System.Drawing.Size(70, 20);
            this.teYear.TabIndex = 0;
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
            this.gcProject.Location = new System.Drawing.Point(0, 34);
            this.gcProject.MainView = this.gvProject;
            this.gcProject.Name = "gcProject";
            this.gcProject.Size = new System.Drawing.Size(1234, 274);
            this.gcProject.TabIndex = 9;
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
            this.colpri_code.Width = 101;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.Visible = true;
            this.colpri_name.VisibleIndex = 1;
            this.colpri_name.Width = 101;
            // 
            // colseg_2
            // 
            this.colseg_2.FieldName = "seg_2";
            this.colseg_2.Name = "colseg_2";
            this.colseg_2.Visible = true;
            this.colseg_2.VisibleIndex = 2;
            this.colseg_2.Width = 101;
            // 
            // colseg_3
            // 
            this.colseg_3.FieldName = "seg_3";
            this.colseg_3.Name = "colseg_3";
            this.colseg_3.Visible = true;
            this.colseg_3.VisibleIndex = 3;
            this.colseg_3.Width = 101;
            // 
            // colTotalRevenue
            // 
            this.colTotalRevenue.DisplayFormat.FormatString = "N2";
            this.colTotalRevenue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalRevenue.FieldName = "TotalRevenue";
            this.colTotalRevenue.Name = "colTotalRevenue";
            this.colTotalRevenue.OptionsColumn.AllowEdit = false;
            this.colTotalRevenue.OptionsColumn.ReadOnly = true;
            this.colTotalRevenue.Visible = true;
            this.colTotalRevenue.VisibleIndex = 4;
            this.colTotalRevenue.Width = 101;
            // 
            // colActualsToDate
            // 
            this.colActualsToDate.DisplayFormat.FormatString = "N2";
            this.colActualsToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActualsToDate.FieldName = "ActualsToDate";
            this.colActualsToDate.Name = "colActualsToDate";
            this.colActualsToDate.OptionsColumn.AllowEdit = false;
            this.colActualsToDate.OptionsColumn.ReadOnly = true;
            this.colActualsToDate.Visible = true;
            this.colActualsToDate.VisibleIndex = 5;
            this.colActualsToDate.Width = 101;
            // 
            // colCOSToDate
            // 
            this.colCOSToDate.Caption = "COS To Date";
            this.colCOSToDate.DisplayFormat.FormatString = "N2";
            this.colCOSToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOSToDate.FieldName = "COSToDate";
            this.colCOSToDate.Name = "colCOSToDate";
            this.colCOSToDate.OptionsColumn.AllowEdit = false;
            this.colCOSToDate.OptionsColumn.ReadOnly = true;
            this.colCOSToDate.Visible = true;
            this.colCOSToDate.VisibleIndex = 6;
            this.colCOSToDate.Width = 101;
            // 
            // colOriginalBudget
            // 
            this.colOriginalBudget.Caption = "Original Budget";
            this.colOriginalBudget.DisplayFormat.FormatString = "N2";
            this.colOriginalBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOriginalBudget.FieldName = "OriginalBudget";
            this.colOriginalBudget.Name = "colOriginalBudget";
            this.colOriginalBudget.OptionsColumn.AllowEdit = false;
            this.colOriginalBudget.OptionsColumn.ReadOnly = true;
            this.colOriginalBudget.Visible = true;
            this.colOriginalBudget.VisibleIndex = 7;
            this.colOriginalBudget.Width = 101;
            // 
            // colApprovedBudget
            // 
            this.colApprovedBudget.DisplayFormat.FormatString = "N2";
            this.colApprovedBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colApprovedBudget.FieldName = "ApprovedBudget";
            this.colApprovedBudget.Name = "colApprovedBudget";
            this.colApprovedBudget.OptionsColumn.AllowEdit = false;
            this.colApprovedBudget.OptionsColumn.ReadOnly = true;
            this.colApprovedBudget.Visible = true;
            this.colApprovedBudget.VisibleIndex = 8;
            this.colApprovedBudget.Width = 106;
            // 
            // colRevisedBudget
            // 
            this.colRevisedBudget.DisplayFormat.FormatString = "N2";
            this.colRevisedBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRevisedBudget.FieldName = "RevisedBudget";
            this.colRevisedBudget.Name = "colRevisedBudget";
            this.colRevisedBudget.OptionsColumn.AllowEdit = false;
            this.colRevisedBudget.OptionsColumn.ReadOnly = true;
            this.colRevisedBudget.Visible = true;
            this.colRevisedBudget.VisibleIndex = 9;
            this.colRevisedBudget.Width = 99;
            // 
            // colCloseAdjustmentsAmount
            // 
            this.colCloseAdjustmentsAmount.DisplayFormat.FormatString = "N2";
            this.colCloseAdjustmentsAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseAdjustmentsAmount.FieldName = "CloseAdjustmentsAmount";
            this.colCloseAdjustmentsAmount.Name = "colCloseAdjustmentsAmount";
            this.colCloseAdjustmentsAmount.OptionsColumn.AllowEdit = false;
            this.colCloseAdjustmentsAmount.OptionsColumn.ReadOnly = true;
            this.colCloseAdjustmentsAmount.Visible = true;
            this.colCloseAdjustmentsAmount.VisibleIndex = 10;
            this.colCloseAdjustmentsAmount.Width = 151;
            // 
            // colVariance
            // 
            this.colVariance.DisplayFormat.FormatString = "N2";
            this.colVariance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVariance.FieldName = "Variance";
            this.colVariance.Name = "colVariance";
            this.colVariance.OptionsColumn.AllowEdit = false;
            this.colVariance.OptionsColumn.ReadOnly = true;
            this.colVariance.Visible = true;
            this.colVariance.VisibleIndex = 11;
            this.colVariance.Width = 63;
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
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
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
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcProject);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dpnlSubledgerPreview);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1234, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpnlSubledgerPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_header1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpnlSubledgerPreview;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReporting;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deInvoiceDate;
        private DevExpress.XtraEditors.TextEdit tePeriod;
        private DevExpress.XtraEditors.TextEdit teYear;
        private DevExpress.XtraGrid.GridControl gcProject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProject;
        private System.Data.SqlClient.SqlDataAdapter da_header;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private ds_header ds_header1;
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
    }
}
