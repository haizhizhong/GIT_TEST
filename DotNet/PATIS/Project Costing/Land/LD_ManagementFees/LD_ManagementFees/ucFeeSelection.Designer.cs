namespace LD_ManagementFees
{
    partial class ucFeeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFeeSelection));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.deRecoveryDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.gcFeeSelection = new DevExpress.XtraGrid.GridControl();
            this.workingldlmfLotListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFeeSelection1 = new LD_ManagementFees.dsFeeSelection();
            this.gvFeeSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasteragreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGST_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrePaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPST_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daFeeSelection = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFeeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlmfLotListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeeSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelectNone);
            this.panelControl1.Controls.Add(this.btnSelectAll);
            this.panelControl1.Controls.Add(this.deRecoveryDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1293, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(626, 10);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(545, 10);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // deRecoveryDate
            // 
            this.deRecoveryDate.EditValue = null;
            this.deRecoveryDate.Location = new System.Drawing.Point(380, 13);
            this.deRecoveryDate.Name = "deRecoveryDate";
            this.deRecoveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            // gcFeeSelection
            // 
            this.gcFeeSelection.DataSource = this.workingldlmfLotListBindingSource;
            this.gcFeeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFeeSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFeeSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFeeSelection.Location = new System.Drawing.Point(0, 42);
            this.gcFeeSelection.MainView = this.gvFeeSelection;
            this.gcFeeSelection.Name = "gcFeeSelection";
            this.gcFeeSelection.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteNumber});
            this.gcFeeSelection.Size = new System.Drawing.Size(1293, 626);
            this.gcFeeSelection.TabIndex = 1;
            this.gcFeeSelection.UseEmbeddedNavigator = true;
            this.gcFeeSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFeeSelection});
            // 
            // workingldlmfLotListBindingSource
            // 
            this.workingldlmfLotListBindingSource.DataMember = "working_ld_lmf_LotList";
            this.workingldlmfLotListBindingSource.DataSource = this.dsFeeSelection1;
            // 
            // dsFeeSelection1
            // 
            this.dsFeeSelection1.DataSetName = "dsFeeSelection";
            this.dsFeeSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvFeeSelection
            // 
            this.gvFeeSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCommunity,
            this.colProject,
            this.colMasteragreement_num,
            this.colAgreement_num,
            this.colPlan_num,
            this.colblock_num,
            this.collot_num,
            this.colAmount,
            this.colGST_Amount,
            this.colTotal_Amount,
            this.colPrePaid,
            this.colSelected,
            this.colSupplier,
            this.colSupplier_Name,
            this.colPST_Amount,
            this.colProjectName});
            this.gvFeeSelection.GridControl = this.gcFeeSelection;
            this.gvFeeSelection.Name = "gvFeeSelection";
            this.gvFeeSelection.OptionsView.ColumnAutoWidth = false;
            this.gvFeeSelection.OptionsView.ShowFooter = true;
            this.gvFeeSelection.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvFeeSelection_CellValueChanged);
            // 
            // colCommunity
            // 
            this.colCommunity.Caption = "Community";
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.OptionsColumn.AllowEdit = false;
            this.colCommunity.Visible = true;
            this.colCommunity.VisibleIndex = 1;
            this.colCommunity.Width = 147;
            // 
            // colProject
            // 
            this.colProject.Caption = "Project";
            this.colProject.FieldName = "Project";
            this.colProject.Name = "colProject";
            this.colProject.OptionsColumn.AllowEdit = false;
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 2;
            // 
            // colMasteragreement_num
            // 
            this.colMasteragreement_num.Caption = "Master Agreement #";
            this.colMasteragreement_num.FieldName = "Masteragreement_num";
            this.colMasteragreement_num.Name = "colMasteragreement_num";
            this.colMasteragreement_num.OptionsColumn.AllowEdit = false;
            this.colMasteragreement_num.Visible = true;
            this.colMasteragreement_num.VisibleIndex = 4;
            this.colMasteragreement_num.Width = 122;
            // 
            // colAgreement_num
            // 
            this.colAgreement_num.Caption = "Agreement #";
            this.colAgreement_num.FieldName = "Agreement_num";
            this.colAgreement_num.Name = "colAgreement_num";
            this.colAgreement_num.OptionsColumn.AllowEdit = false;
            this.colAgreement_num.Visible = true;
            this.colAgreement_num.VisibleIndex = 5;
            this.colAgreement_num.Width = 86;
            // 
            // colPlan_num
            // 
            this.colPlan_num.Caption = "Plan";
            this.colPlan_num.FieldName = "Plan_num";
            this.colPlan_num.Name = "colPlan_num";
            this.colPlan_num.OptionsColumn.AllowEdit = false;
            this.colPlan_num.Visible = true;
            this.colPlan_num.VisibleIndex = 6;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 7;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 8;
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
            this.colAmount.VisibleIndex = 9;
            this.colAmount.Width = 93;
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
            this.colGST_Amount.OptionsColumn.AllowEdit = false;
            this.colGST_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGST_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGST_Amount.Visible = true;
            this.colGST_Amount.VisibleIndex = 10;
            this.colGST_Amount.Width = 99;
            // 
            // colTotal_Amount
            // 
            this.colTotal_Amount.Caption = "Total Amount";
            this.colTotal_Amount.ColumnEdit = this.riteNumber;
            this.colTotal_Amount.FieldName = "Total_Amount";
            this.colTotal_Amount.Name = "colTotal_Amount";
            this.colTotal_Amount.OptionsColumn.AllowEdit = false;
            this.colTotal_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotal_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal_Amount.Visible = true;
            this.colTotal_Amount.VisibleIndex = 12;
            this.colTotal_Amount.Width = 86;
            // 
            // colPrePaid
            // 
            this.colPrePaid.Caption = "Prepaid";
            this.colPrePaid.FieldName = "PrePaid";
            this.colPrePaid.Name = "colPrePaid";
            this.colPrePaid.Visible = true;
            this.colPrePaid.VisibleIndex = 13;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Select";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 51;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowEdit = false;
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 14;
            // 
            // colSupplier_Name
            // 
            this.colSupplier_Name.Caption = "Name";
            this.colSupplier_Name.FieldName = "Supplier_Name";
            this.colSupplier_Name.Name = "colSupplier_Name";
            this.colSupplier_Name.OptionsColumn.AllowEdit = false;
            this.colSupplier_Name.Visible = true;
            this.colSupplier_Name.VisibleIndex = 15;
            this.colSupplier_Name.Width = 177;
            // 
            // colPST_Amount
            // 
            this.colPST_Amount.Caption = "PST Amount";
            this.colPST_Amount.ColumnEdit = this.riteNumber;
            this.colPST_Amount.FieldName = "PST_Amount";
            this.colPST_Amount.Name = "colPST_Amount";
            this.colPST_Amount.OptionsColumn.AllowEdit = false;
            this.colPST_Amount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPST_Amount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPST_Amount.Visible = true;
            this.colPST_Amount.VisibleIndex = 11;
            this.colPST_Amount.Width = 95;
            // 
            // colProjectName
            // 
            this.colProjectName.Caption = "Project Name";
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 3;
            this.colProjectName.Width = 109;
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
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "Username")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
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
            new System.Data.SqlClient.SqlParameter("@GST_PCT", System.Data.SqlDbType.Money, 0, "GST_PCT"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@ManagementFee_ID", System.Data.SqlDbType.Int, 0, "ManagementFee_ID"),
            new System.Data.SqlClient.SqlParameter("@Agreement_ID", System.Data.SqlDbType.Int, 0, "Agreement_ID"),
            new System.Data.SqlClient.SqlParameter("@Pri_id", System.Data.SqlDbType.Int, 0, "Pri_id"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_Flag", System.Data.SqlDbType.Bit, 0, "GST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Flag", System.Data.SqlDbType.Bit, 0, "PST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Amount", System.Data.SqlDbType.Money, 0, "PST_Amount"),
            new System.Data.SqlClient.SqlParameter("@PST_PCT", System.Data.SqlDbType.Money, 0, "PST_PCT"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
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
            new System.Data.SqlClient.SqlParameter("@GST_PCT", System.Data.SqlDbType.Money, 0, "GST_PCT"),
            new System.Data.SqlClient.SqlParameter("@CostingReference", System.Data.SqlDbType.VarChar, 0, "CostingReference"),
            new System.Data.SqlClient.SqlParameter("@ManagementFee_ID", System.Data.SqlDbType.Int, 0, "ManagementFee_ID"),
            new System.Data.SqlClient.SqlParameter("@Agreement_ID", System.Data.SqlDbType.Int, 0, "Agreement_ID"),
            new System.Data.SqlClient.SqlParameter("@Pri_id", System.Data.SqlDbType.Int, 0, "Pri_id"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_Flag", System.Data.SqlDbType.Bit, 0, "GST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Flag", System.Data.SqlDbType.Bit, 0, "PST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Amount", System.Data.SqlDbType.Money, 0, "PST_Amount"),
            new System.Data.SqlClient.SqlParameter("@PST_PCT", System.Data.SqlDbType.Money, 0, "PST_PCT"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agreement_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agreement_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agreement_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agreement_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostingReference", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostingReference", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostingReference", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManagementFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManagementFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agreement_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agreement_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agreement_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agreement_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null)});
            // 
            // daFeeSelection
            // 
            this.daFeeSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daFeeSelection.InsertCommand = this.sqlInsertCommand1;
            this.daFeeSelection.SelectCommand = this.sqlSelectCommand1;
            this.daFeeSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lmf_LotList", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected"),
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
                        new System.Data.Common.DataColumnMapping("GST_PCT", "GST_PCT"),
                        new System.Data.Common.DataColumnMapping("CostingReference", "CostingReference"),
                        new System.Data.Common.DataColumnMapping("ManagementFee_ID", "ManagementFee_ID"),
                        new System.Data.Common.DataColumnMapping("Agreement_ID", "Agreement_ID"),
                        new System.Data.Common.DataColumnMapping("Pri_id", "Pri_id"),
                        new System.Data.Common.DataColumnMapping("Supplier_ID", "Supplier_ID"),
                        new System.Data.Common.DataColumnMapping("GST_Flag", "GST_Flag"),
                        new System.Data.Common.DataColumnMapping("PST_Flag", "PST_Flag"),
                        new System.Data.Common.DataColumnMapping("PST_Amount", "PST_Amount"),
                        new System.Data.Common.DataColumnMapping("PST_PCT", "PST_PCT"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName")})});
            this.daFeeSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucFeeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcFeeSelection);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucFeeSelection";
            this.Size = new System.Drawing.Size(1293, 668);
            this.Load += new System.EventHandler(this.ucFeeSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRecoveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFeeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlmfLotListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeeSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private DevExpress.XtraEditors.DateEdit deRecoveryDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcFeeSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFeeSelection;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colMasteragreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colAgreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colPlan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGST_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaid;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daFeeSelection;
        private dsFeeSelection dsFeeSelection1;
        private System.Windows.Forms.BindingSource workingldlmfLotListBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPST_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
    }
}
