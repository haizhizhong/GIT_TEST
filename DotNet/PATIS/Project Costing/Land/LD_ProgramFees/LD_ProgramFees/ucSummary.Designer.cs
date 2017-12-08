namespace LD_ProgramFees
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintCertificates = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.dePODate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.workingldlpfLotListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSummary1 = new LD_ProgramFees.dsSummary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostingReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGSTAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPOAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecoveredAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpfLotListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintCertificates);
            this.panelControl1.Controls.Add(this.btnPrintRegister);
            this.panelControl1.Controls.Add(this.dePODate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1280, 42);
            this.panelControl1.TabIndex = 2;
            // 
            // btnPrintCertificates
            // 
            this.btnPrintCertificates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCertificates.Enabled = false;
            this.btnPrintCertificates.Location = new System.Drawing.Point(1029, 10);
            this.btnPrintCertificates.Name = "btnPrintCertificates";
            this.btnPrintCertificates.Size = new System.Drawing.Size(120, 23);
            this.btnPrintCertificates.TabIndex = 4;
            this.btnPrintCertificates.Text = "Print Certificates";
            this.btnPrintCertificates.Click += new System.EventHandler(this.btnPrintCertificates_Click);
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRegister.Location = new System.Drawing.Point(1155, 10);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(120, 23);
            this.btnPrintRegister.TabIndex = 3;
            this.btnPrintRegister.Text = "Print Pre-Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // dePODate
            // 
            this.dePODate.EditValue = null;
            this.dePODate.Location = new System.Drawing.Point(380, 13);
            this.dePODate.Name = "dePODate";
            this.dePODate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePODate.Properties.ReadOnly = true;
            this.dePODate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePODate.Size = new System.Drawing.Size(135, 20);
            this.dePODate.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(302, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Recovery Date";
            // 
            // acctYearPeriod1
            // 
            this.acctYearPeriod1.Location = new System.Drawing.Point(3, 5);
            this.acctYearPeriod1.Name = "acctYearPeriod1";
            this.acctYearPeriod1.Size = new System.Drawing.Size(290, 36);
            this.acctYearPeriod1.TabIndex = 0;
            // 
            // gcSummary
            // 
            this.gcSummary.DataSource = this.workingldlpfLotListBindingSource;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 42);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteNumber});
            this.gcSummary.Size = new System.Drawing.Size(1280, 683);
            this.gcSummary.TabIndex = 3;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // workingldlpfLotListBindingSource
            // 
            this.workingldlpfLotListBindingSource.DataMember = "working_ld_lpf_LotList";
            this.workingldlpfLotListBindingSource.DataSource = this.dsSummary1;
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOCertificate,
            this.colSupplier,
            this.colSupplierName,
            this.colCostingReference,
            this.colPOAmount,
            this.colGSTAmount,
            this.colPSTAmount,
            this.colTotalPOAmount,
            this.colRecoveredAmount,
            this.colRetailAmount1,
            this.colRetailAmount2});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            // 
            // colPOCertificate
            // 
            this.colPOCertificate.Caption = "Certificate #/PO";
            this.colPOCertificate.FieldName = "POCertificate";
            this.colPOCertificate.Name = "colPOCertificate";
            this.colPOCertificate.Visible = true;
            this.colPOCertificate.VisibleIndex = 0;
            this.colPOCertificate.Width = 101;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 1;
            this.colSupplier.Width = 60;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 2;
            this.colSupplierName.Width = 379;
            // 
            // colCostingReference
            // 
            this.colCostingReference.Caption = "Costing Reference";
            this.colCostingReference.FieldName = "CostingReference";
            this.colCostingReference.Name = "colCostingReference";
            this.colCostingReference.Visible = true;
            this.colCostingReference.VisibleIndex = 3;
            this.colCostingReference.Width = 379;
            // 
            // colPOAmount
            // 
            this.colPOAmount.Caption = "PO Amount";
            this.colPOAmount.ColumnEdit = this.riteNumber;
            this.colPOAmount.FieldName = "POAmount";
            this.colPOAmount.Name = "colPOAmount";
            this.colPOAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPOAmount.Visible = true;
            this.colPOAmount.VisibleIndex = 4;
            this.colPOAmount.Width = 76;
            // 
            // colGSTAmount
            // 
            this.colGSTAmount.Caption = "GST Amount";
            this.colGSTAmount.ColumnEdit = this.riteNumber;
            this.colGSTAmount.FieldName = "GSTAmount";
            this.colGSTAmount.Name = "colGSTAmount";
            this.colGSTAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGSTAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGSTAmount.Visible = true;
            this.colGSTAmount.VisibleIndex = 5;
            this.colGSTAmount.Width = 81;
            // 
            // colPSTAmount
            // 
            this.colPSTAmount.Caption = "PST Amount";
            this.colPSTAmount.ColumnEdit = this.riteNumber;
            this.colPSTAmount.FieldName = "PSTAmount";
            this.colPSTAmount.Name = "colPSTAmount";
            this.colPSTAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPSTAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPSTAmount.Visible = true;
            this.colPSTAmount.VisibleIndex = 6;
            this.colPSTAmount.Width = 80;
            // 
            // colTotalPOAmount
            // 
            this.colTotalPOAmount.Caption = "Total PO Amount";
            this.colTotalPOAmount.ColumnEdit = this.riteNumber;
            this.colTotalPOAmount.FieldName = "TotalPOAmount";
            this.colTotalPOAmount.Name = "colTotalPOAmount";
            this.colTotalPOAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalPOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalPOAmount.Visible = true;
            this.colTotalPOAmount.VisibleIndex = 7;
            this.colTotalPOAmount.Width = 103;
            // 
            // colRecoveredAmount
            // 
            this.colRecoveredAmount.Caption = "Recovered Amount";
            this.colRecoveredAmount.ColumnEdit = this.riteNumber;
            this.colRecoveredAmount.FieldName = "RecoveredAmount";
            this.colRecoveredAmount.Name = "colRecoveredAmount";
            this.colRecoveredAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colRecoveredAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colRetailAmount1
            // 
            this.colRetailAmount1.Caption = "Retail Amount 1";
            this.colRetailAmount1.ColumnEdit = this.riteNumber;
            this.colRetailAmount1.FieldName = "RetailAmount1";
            this.colRetailAmount1.Name = "colRetailAmount1";
            this.colRetailAmount1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colRetailAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colRetailAmount2
            // 
            this.colRetailAmount2.Caption = "Retail Amount 2";
            this.colRetailAmount2.ColumnEdit = this.riteNumber;
            this.colRetailAmount2.FieldName = "RetailAmount2";
            this.colRetailAmount2.Name = "colRetailAmount2";
            this.colRetailAmount2.SummaryItem.DisplayFormat = "{0:n2}";
            this.colRetailAmount2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "Username")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@POCertificate", System.Data.SqlDbType.VarChar, 0, "POCertificate"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@SupplierName", System.Data.SqlDbType.VarChar, 0, "SupplierName"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@POAmount", System.Data.SqlDbType.Money, 0, "POAmount"),
            new System.Data.SqlClient.SqlParameter("@GSTAmount", System.Data.SqlDbType.Money, 0, "GSTAmount"),
            new System.Data.SqlClient.SqlParameter("@PSTAmount", System.Data.SqlDbType.Money, 0, "PSTAmount"),
            new System.Data.SqlClient.SqlParameter("@TotalPOAmount", System.Data.SqlDbType.Money, 0, "TotalPOAmount"),
            new System.Data.SqlClient.SqlParameter("@RecoveredAmount", System.Data.SqlDbType.Money, 0, "RecoveredAmount"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount1", System.Data.SqlDbType.Money, 0, "RetailAmount1"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount2", System.Data.SqlDbType.Money, 0, "RetailAmount2")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@POCertificate", System.Data.SqlDbType.VarChar, 0, "POCertificate"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@SupplierName", System.Data.SqlDbType.VarChar, 0, "SupplierName"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@POAmount", System.Data.SqlDbType.Money, 0, "POAmount"),
            new System.Data.SqlClient.SqlParameter("@GSTAmount", System.Data.SqlDbType.Money, 0, "GSTAmount"),
            new System.Data.SqlClient.SqlParameter("@PSTAmount", System.Data.SqlDbType.Money, 0, "PSTAmount"),
            new System.Data.SqlClient.SqlParameter("@TotalPOAmount", System.Data.SqlDbType.Money, 0, "TotalPOAmount"),
            new System.Data.SqlClient.SqlParameter("@RecoveredAmount", System.Data.SqlDbType.Money, 0, "RecoveredAmount"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount1", System.Data.SqlDbType.Money, 0, "RetailAmount1"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount2", System.Data.SqlDbType.Money, 0, "RetailAmount2"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POCertificate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POCertificate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POCertificate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POCertificate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SupplierName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalPOAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalPOAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RecoveredAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RecoveredAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POCertificate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POCertificate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POCertificate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POCertificate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SupplierName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalPOAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalPOAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RecoveredAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RecoveredAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, null)});
            // 
            // daSummary
            // 
            this.daSummary.DeleteCommand = this.sqlDeleteCommand1;
            this.daSummary.InsertCommand = this.sqlInsertCommand1;
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpf_LotList", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("POCertificate", "POCertificate"),
                        new System.Data.Common.DataColumnMapping("Supplier", "Supplier"),
                        new System.Data.Common.DataColumnMapping("SupplierName", "SupplierName"),
                        new System.Data.Common.DataColumnMapping("CostingReference", "CostingReference"),
                        new System.Data.Common.DataColumnMapping("POAmount", "POAmount"),
                        new System.Data.Common.DataColumnMapping("GSTAmount", "GSTAmount"),
                        new System.Data.Common.DataColumnMapping("PSTAmount", "PSTAmount"),
                        new System.Data.Common.DataColumnMapping("TotalPOAmount", "TotalPOAmount"),
                        new System.Data.Common.DataColumnMapping("RecoveredAmount", "RecoveredAmount"),
                        new System.Data.Common.DataColumnMapping("RetailAmount1", "RetailAmount1"),
                        new System.Data.Common.DataColumnMapping("RetailAmount2", "RetailAmount2")})});
            this.daSummary.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // riteNumber
            // 
            this.riteNumber.AutoHeight = false;
            this.riteNumber.Mask.EditMask = "n2";
            this.riteNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumber.Name = "riteNumber";
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1280, 725);
            this.Load += new System.EventHandler(this.ucSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpfLotListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraEditors.DateEdit dePODate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private DevExpress.XtraEditors.SimpleButton btnPrintCertificates;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private dsSummary dsSummary1;
        private System.Windows.Forms.BindingSource workingldlpfLotListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPOCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colCostingReference;
        private DevExpress.XtraGrid.Columns.GridColumn colPOAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGSTAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPOAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRecoveredAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailAmount2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
    }
}
