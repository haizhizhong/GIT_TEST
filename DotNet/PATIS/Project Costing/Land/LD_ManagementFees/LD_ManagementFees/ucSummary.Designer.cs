namespace LD_ManagementFees
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
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.deRecoveryDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.workingldlmfLotListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSummary1 = new LD_ManagementFees.dsSummary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostingReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGST_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasteragreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPST_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpSubledgerPreview = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlmfLotListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpSubledgerPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintRegister);
            this.panelControl1.Controls.Add(this.deRecoveryDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1297, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRegister.Location = new System.Drawing.Point(1172, 10);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(120, 23);
            this.btnPrintRegister.TabIndex = 3;
            this.btnPrintRegister.Text = "Print Pre-Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // deRecoveryDate
            // 
            this.deRecoveryDate.EditValue = null;
            this.deRecoveryDate.Location = new System.Drawing.Point(380, 13);
            this.deRecoveryDate.Name = "deRecoveryDate";
            this.deRecoveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRecoveryDate.Properties.ReadOnly = true;
            this.deRecoveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deRecoveryDate.Size = new System.Drawing.Size(135, 20);
            this.deRecoveryDate.TabIndex = 2;
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
            this.gcSummary.DataSource = this.workingldlmfLotListBindingSource;
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
            this.gcSummary.Size = new System.Drawing.Size(1297, 305);
            this.gcSummary.TabIndex = 2;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // workingldlmfLotListBindingSource
            // 
            this.workingldlmfLotListBindingSource.DataMember = "working_ld_lmf_LotList";
            this.workingldlmfLotListBindingSource.DataSource = this.dsSummary1;
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplier,
            this.colSupplier_Name,
            this.colCostingReference,
            this.colAmount,
            this.colGST_Amount,
            this.colTotal_Amount,
            this.colCommunity,
            this.colProject,
            this.colPlan_num,
            this.colblock_num,
            this.collot_num,
            this.colAgreement_num,
            this.colMasteragreement_num,
            this.colPST_Amount});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 0;
            this.colSupplier.Width = 135;
            // 
            // colSupplier_Name
            // 
            this.colSupplier_Name.Caption = "Name";
            this.colSupplier_Name.FieldName = "Supplier_Name";
            this.colSupplier_Name.Name = "colSupplier_Name";
            this.colSupplier_Name.Visible = true;
            this.colSupplier_Name.VisibleIndex = 1;
            this.colSupplier_Name.Width = 135;
            // 
            // colCostingReference
            // 
            this.colCostingReference.Caption = "Costing Reference";
            this.colCostingReference.FieldName = "CostingReference";
            this.colCostingReference.Name = "colCostingReference";
            this.colCostingReference.Visible = true;
            this.colCostingReference.VisibleIndex = 5;
            this.colCostingReference.Width = 265;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.ColumnEdit = this.riteNumber;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 107;
            // 
            // riteNumber
            // 
            this.riteNumber.AutoHeight = false;
            this.riteNumber.Mask.EditMask = "n2";
            this.riteNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumber.Name = "riteNumber";
            // 
            // colGST_Amount
            // 
            this.colGST_Amount.Caption = "GST Amount";
            this.colGST_Amount.ColumnEdit = this.riteNumber;
            this.colGST_Amount.FieldName = "GST_Amount";
            this.colGST_Amount.Name = "colGST_Amount";
            this.colGST_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGST_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGST_Amount.Visible = true;
            this.colGST_Amount.VisibleIndex = 7;
            this.colGST_Amount.Width = 107;
            // 
            // colTotal_Amount
            // 
            this.colTotal_Amount.Caption = "Total Amount";
            this.colTotal_Amount.ColumnEdit = this.riteNumber;
            this.colTotal_Amount.FieldName = "Total_Amount";
            this.colTotal_Amount.Name = "colTotal_Amount";
            this.colTotal_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotal_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal_Amount.Visible = true;
            this.colTotal_Amount.VisibleIndex = 9;
            this.colTotal_Amount.Width = 112;
            // 
            // colCommunity
            // 
            this.colCommunity.Caption = "Community";
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.Width = 114;
            // 
            // colProject
            // 
            this.colProject.Caption = "Project";
            this.colProject.FieldName = "Project";
            this.colProject.Name = "colProject";
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 2;
            this.colProject.Width = 111;
            // 
            // colPlan_num
            // 
            this.colPlan_num.Caption = "Plan";
            this.colPlan_num.FieldName = "Plan_num";
            this.colPlan_num.Name = "colPlan_num";
            this.colPlan_num.Width = 42;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.Width = 48;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.Width = 54;
            // 
            // colAgreement_num
            // 
            this.colAgreement_num.Caption = "Agreement #";
            this.colAgreement_num.FieldName = "Agreement_num";
            this.colAgreement_num.Name = "colAgreement_num";
            this.colAgreement_num.Visible = true;
            this.colAgreement_num.VisibleIndex = 4;
            this.colAgreement_num.Width = 88;
            // 
            // colMasteragreement_num
            // 
            this.colMasteragreement_num.Caption = "Master Agreement #";
            this.colMasteragreement_num.FieldName = "Masteragreement_num";
            this.colMasteragreement_num.Name = "colMasteragreement_num";
            this.colMasteragreement_num.Visible = true;
            this.colMasteragreement_num.VisibleIndex = 3;
            this.colMasteragreement_num.Width = 122;
            // 
            // colPST_Amount
            // 
            this.colPST_Amount.Caption = "PST Amount";
            this.colPST_Amount.ColumnEdit = this.riteNumber;
            this.colPST_Amount.FieldName = "PST_Amount";
            this.colPST_Amount.Name = "colPST_Amount";
            this.colPST_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPST_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPST_Amount.Visible = true;
            this.colPST_Amount.VisibleIndex = 8;
            this.colPST_Amount.Width = 94;
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpSubledgerPreview});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpSubledgerPreview
            // 
            this.dpSubledgerPreview.Controls.Add(this.dockPanel1_Container);
            this.dpSubledgerPreview.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpSubledgerPreview.ID = new System.Guid("47c04533-b813-4727-b23c-2ccdb83caed4");
            this.dpSubledgerPreview.Location = new System.Drawing.Point(0, 347);
            this.dpSubledgerPreview.Name = "dpSubledgerPreview";
            this.dpSubledgerPreview.Size = new System.Drawing.Size(1297, 361);
            this.dpSubledgerPreview.Text = "Subledger Preview";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1291, 333);
            this.dockPanel1_Container.TabIndex = 0;
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
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.Int, 0, "Project"),
            new System.Data.SqlClient.SqlParameter("@Masteragreement_num", System.Data.SqlDbType.Int, 0, "Masteragreement_num"),
            new System.Data.SqlClient.SqlParameter("@Agreement_num", System.Data.SqlDbType.Int, 0, "Agreement_num"),
            new System.Data.SqlClient.SqlParameter("@Plan_num", System.Data.SqlDbType.VarChar, 0, "Plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@GST_Amount", System.Data.SqlDbType.Money, 0, "GST_Amount"),
            new System.Data.SqlClient.SqlParameter("@Total_Amount", System.Data.SqlDbType.Money, 0, "Total_Amount"),
            new System.Data.SqlClient.SqlParameter("@PrePaid", System.Data.SqlDbType.Bit, 0, "PrePaid"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@Supplier_Name", System.Data.SqlDbType.VarChar, 0, "Supplier_Name"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@PST_Amount", System.Data.SqlDbType.Money, 0, "PST_Amount")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.Int, 0, "Project"),
            new System.Data.SqlClient.SqlParameter("@Masteragreement_num", System.Data.SqlDbType.Int, 0, "Masteragreement_num"),
            new System.Data.SqlClient.SqlParameter("@Agreement_num", System.Data.SqlDbType.Int, 0, "Agreement_num"),
            new System.Data.SqlClient.SqlParameter("@Plan_num", System.Data.SqlDbType.VarChar, 0, "Plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@GST_Amount", System.Data.SqlDbType.Money, 0, "GST_Amount"),
            new System.Data.SqlClient.SqlParameter("@Total_Amount", System.Data.SqlDbType.Money, 0, "Total_Amount"),
            new System.Data.SqlClient.SqlParameter("@PrePaid", System.Data.SqlDbType.Bit, 0, "PrePaid"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@Supplier_Name", System.Data.SqlDbType.VarChar, 0, "Supplier_Name"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@PST_Amount", System.Data.SqlDbType.Money, 0, "PST_Amount"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masteragreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masteragreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masteragreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masteragreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Total_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Total_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Total_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PrePaid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrePaid", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PrePaid", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrePaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masteragreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masteragreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masteragreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Masteragreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Total_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Total_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Total_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PrePaid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrePaid", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PrePaid", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrePaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // daSummary
            // 
            this.daSummary.DeleteCommand = this.sqlDeleteCommand1;
            this.daSummary.InsertCommand = this.sqlInsertCommand1;
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lmf_LotList", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Community", "Community"),
                        new System.Data.Common.DataColumnMapping("Project", "Project"),
                        new System.Data.Common.DataColumnMapping("Masteragreement_num", "Masteragreement_num"),
                        new System.Data.Common.DataColumnMapping("Agreement_num", "Agreement_num"),
                        new System.Data.Common.DataColumnMapping("Plan_num", "Plan_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("GST_Amount", "GST_Amount"),
                        new System.Data.Common.DataColumnMapping("Total_Amount", "Total_Amount"),
                        new System.Data.Common.DataColumnMapping("PrePaid", "PrePaid"),
                        new System.Data.Common.DataColumnMapping("Supplier", "Supplier"),
                        new System.Data.Common.DataColumnMapping("Supplier_Name", "Supplier_Name"),
                        new System.Data.Common.DataColumnMapping("CostingReference", "CostingReference"),
                        new System.Data.Common.DataColumnMapping("PST_Amount", "PST_Amount")})});
            this.daSummary.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dpSubledgerPreview);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1297, 708);
            this.Load += new System.EventHandler(this.ucSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlmfLotListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpSubledgerPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit deRecoveryDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCostingReference;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGST_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Amount;
        private DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpSubledgerPreview;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private dsSummary dsSummary1;
        private System.Windows.Forms.BindingSource workingldlmfLotListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colPlan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colAgreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colMasteragreement_num;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPST_Amount;
    }
}
