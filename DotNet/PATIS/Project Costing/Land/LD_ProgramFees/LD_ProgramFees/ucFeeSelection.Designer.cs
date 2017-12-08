namespace LD_ProgramFees
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
            this.dePODate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.gcFeeSelection = new DevExpress.XtraGrid.GridControl();
            this.workingldlpfLotListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFeeSelection1 = new LD_ProgramFees.dsFeeSelection();
            this.gvFeeSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasteragreementnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecoveredAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colRetailAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGSTAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPOAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daFeeSelection = new System.Data.SqlClient.SqlDataAdapter();
            this.colRedeemed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_ceSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFeeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpfLotListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeeSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelectNone);
            this.panelControl1.Controls.Add(this.btnSelectAll);
            this.panelControl1.Controls.Add(this.dePODate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1299, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(581, 10);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(500, 10);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // dePODate
            // 
            this.dePODate.EditValue = null;
            this.dePODate.Location = new System.Drawing.Point(348, 13);
            this.dePODate.Name = "dePODate";
            this.dePODate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePODate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePODate.Size = new System.Drawing.Size(135, 20);
            this.dePODate.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(302, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PO Date";
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
            this.gcFeeSelection.DataSource = this.workingldlpfLotListBindingSource;
            this.gcFeeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFeeSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFeeSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFeeSelection.Location = new System.Drawing.Point(0, 42);
            this.gcFeeSelection.MainView = this.gvFeeSelection;
            this.gcFeeSelection.Name = "gcFeeSelection";
            this.gcFeeSelection.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteNumber,
            this.ri_ceSelected});
            this.gcFeeSelection.Size = new System.Drawing.Size(1299, 677);
            this.gcFeeSelection.TabIndex = 2;
            this.gcFeeSelection.UseEmbeddedNavigator = true;
            this.gcFeeSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFeeSelection});
            // 
            // workingldlpfLotListBindingSource
            // 
            this.workingldlpfLotListBindingSource.DataMember = "working_ld_lpf_LotList";
            this.workingldlpfLotListBindingSource.DataSource = this.dsFeeSelection1;
            // 
            // dsFeeSelection1
            // 
            this.dsFeeSelection1.DataSetName = "dsFeeSelection";
            this.dsFeeSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvFeeSelection
            // 
            this.gvFeeSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colCommunity,
            this.colpri_code,
            this.colpri_name,
            this.colagreement_num,
            this.colmasteragreementnum,
            this.colplan_num,
            this.colblock_num,
            this.collot_num,
            this.colRecoveredAmount,
            this.colRetailAmount1,
            this.colRetailAmount2,
            this.colPOAmount,
            this.colGSTAmount,
            this.colPSTAmount,
            this.colTotalPOAmount,
            this.colSupplier,
            this.colSupplierName,
            this.colRedeemed});
            this.gvFeeSelection.GridControl = this.gcFeeSelection;
            this.gvFeeSelection.Name = "gvFeeSelection";
            this.gvFeeSelection.OptionsView.ColumnAutoWidth = false;
            this.gvFeeSelection.OptionsView.ShowFooter = true;
            // 
            // colSelected
            // 
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 63;
            // 
            // colCommunity
            // 
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.OptionsColumn.AllowEdit = false;
            this.colCommunity.Visible = true;
            this.colCommunity.VisibleIndex = 1;
            this.colCommunity.Width = 150;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 2;
            this.colpri_code.Width = 56;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.OptionsColumn.AllowEdit = false;
            this.colpri_name.Width = 161;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.AllowEdit = false;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 3;
            this.colagreement_num.Width = 86;
            // 
            // colmasteragreementnum
            // 
            this.colmasteragreementnum.Caption = "Master Agreement #";
            this.colmasteragreementnum.FieldName = "masteragreementnum";
            this.colmasteragreementnum.Name = "colmasteragreementnum";
            this.colmasteragreementnum.OptionsColumn.AllowEdit = false;
            this.colmasteragreementnum.Visible = true;
            this.colmasteragreementnum.VisibleIndex = 4;
            this.colmasteragreementnum.Width = 122;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 5;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 6;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 7;
            // 
            // colRecoveredAmount
            // 
            this.colRecoveredAmount.Caption = "Recovered Amount";
            this.colRecoveredAmount.ColumnEdit = this.riteNumber;
            this.colRecoveredAmount.FieldName = "RecoveredAmount";
            this.colRecoveredAmount.Name = "colRecoveredAmount";
            this.colRecoveredAmount.OptionsColumn.AllowEdit = false;
            this.colRecoveredAmount.Visible = true;
            this.colRecoveredAmount.VisibleIndex = 8;
            this.colRecoveredAmount.Width = 127;
            // 
            // riteNumber
            // 
            this.riteNumber.AutoHeight = false;
            this.riteNumber.Mask.EditMask = "n2";
            this.riteNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumber.Name = "riteNumber";
            // 
            // colRetailAmount1
            // 
            this.colRetailAmount1.Caption = "Retail Amount 1";
            this.colRetailAmount1.ColumnEdit = this.riteNumber;
            this.colRetailAmount1.FieldName = "RetailAmount1";
            this.colRetailAmount1.Name = "colRetailAmount1";
            this.colRetailAmount1.OptionsColumn.AllowEdit = false;
            this.colRetailAmount1.Visible = true;
            this.colRetailAmount1.VisibleIndex = 9;
            this.colRetailAmount1.Width = 98;
            // 
            // colRetailAmount2
            // 
            this.colRetailAmount2.Caption = "Retail Amount 2";
            this.colRetailAmount2.ColumnEdit = this.riteNumber;
            this.colRetailAmount2.FieldName = "RetailAmount2";
            this.colRetailAmount2.Name = "colRetailAmount2";
            this.colRetailAmount2.OptionsColumn.AllowEdit = false;
            this.colRetailAmount2.Visible = true;
            this.colRetailAmount2.VisibleIndex = 10;
            this.colRetailAmount2.Width = 98;
            // 
            // colPOAmount
            // 
            this.colPOAmount.Caption = "PO Amount";
            this.colPOAmount.ColumnEdit = this.riteNumber;
            this.colPOAmount.FieldName = "POAmount";
            this.colPOAmount.Name = "colPOAmount";
            this.colPOAmount.OptionsColumn.AllowEdit = false;
            this.colPOAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPOAmount.Visible = true;
            this.colPOAmount.VisibleIndex = 11;
            this.colPOAmount.Width = 103;
            // 
            // colGSTAmount
            // 
            this.colGSTAmount.Caption = "GST Amount";
            this.colGSTAmount.ColumnEdit = this.riteNumber;
            this.colGSTAmount.FieldName = "GSTAmount";
            this.colGSTAmount.Name = "colGSTAmount";
            this.colGSTAmount.OptionsColumn.AllowEdit = false;
            this.colGSTAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colGSTAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colGSTAmount.Visible = true;
            this.colGSTAmount.VisibleIndex = 12;
            this.colGSTAmount.Width = 81;
            // 
            // colPSTAmount
            // 
            this.colPSTAmount.Caption = "PST Amount";
            this.colPSTAmount.ColumnEdit = this.riteNumber;
            this.colPSTAmount.FieldName = "PSTAmount";
            this.colPSTAmount.Name = "colPSTAmount";
            this.colPSTAmount.OptionsColumn.AllowEdit = false;
            this.colPSTAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colPSTAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPSTAmount.Visible = true;
            this.colPSTAmount.VisibleIndex = 13;
            this.colPSTAmount.Width = 80;
            // 
            // colTotalPOAmount
            // 
            this.colTotalPOAmount.Caption = "Total PO Amount";
            this.colTotalPOAmount.ColumnEdit = this.riteNumber;
            this.colTotalPOAmount.FieldName = "TotalPOAmount";
            this.colTotalPOAmount.Name = "colTotalPOAmount";
            this.colTotalPOAmount.OptionsColumn.AllowEdit = false;
            this.colTotalPOAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colTotalPOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalPOAmount.Visible = true;
            this.colTotalPOAmount.VisibleIndex = 14;
            this.colTotalPOAmount.Width = 103;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowEdit = false;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.OptionsColumn.AllowEdit = false;
            this.colSupplierName.Width = 182;
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
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@masteragreementnum", System.Data.SqlDbType.Int, 0, "masteragreementnum"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@RecoveredAmount", System.Data.SqlDbType.Money, 0, "RecoveredAmount"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount1", System.Data.SqlDbType.Money, 0, "RetailAmount1"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount2", System.Data.SqlDbType.Money, 0, "RetailAmount2"),
            new System.Data.SqlClient.SqlParameter("@POAmount", System.Data.SqlDbType.Money, 0, "POAmount"),
            new System.Data.SqlClient.SqlParameter("@GSTAmount", System.Data.SqlDbType.Money, 0, "GSTAmount"),
            new System.Data.SqlClient.SqlParameter("@PSTAmount", System.Data.SqlDbType.Money, 0, "PSTAmount"),
            new System.Data.SqlClient.SqlParameter("@TotalPOAmount", System.Data.SqlDbType.Money, 0, "TotalPOAmount"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@SupplierName", System.Data.SqlDbType.VarChar, 0, "SupplierName"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@masteragreement_id", System.Data.SqlDbType.Int, 0, "masteragreement_id"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_Flag", System.Data.SqlDbType.Bit, 0, "GST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Flag", System.Data.SqlDbType.Bit, 0, "PST_Flag"),
            new System.Data.SqlClient.SqlParameter("@GST_PCT", System.Data.SqlDbType.Money, 0, "GST_PCT"),
            new System.Data.SqlClient.SqlParameter("@PST_PCT", System.Data.SqlDbType.Money, 0, "PST_PCT"),
            new System.Data.SqlClient.SqlParameter("@Redeemed", System.Data.SqlDbType.Bit, 0, "Redeemed")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@masteragreementnum", System.Data.SqlDbType.Int, 0, "masteragreementnum"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@RecoveredAmount", System.Data.SqlDbType.Money, 0, "RecoveredAmount"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount1", System.Data.SqlDbType.Money, 0, "RetailAmount1"),
            new System.Data.SqlClient.SqlParameter("@RetailAmount2", System.Data.SqlDbType.Money, 0, "RetailAmount2"),
            new System.Data.SqlClient.SqlParameter("@POAmount", System.Data.SqlDbType.Money, 0, "POAmount"),
            new System.Data.SqlClient.SqlParameter("@GSTAmount", System.Data.SqlDbType.Money, 0, "GSTAmount"),
            new System.Data.SqlClient.SqlParameter("@PSTAmount", System.Data.SqlDbType.Money, 0, "PSTAmount"),
            new System.Data.SqlClient.SqlParameter("@TotalPOAmount", System.Data.SqlDbType.Money, 0, "TotalPOAmount"),
            new System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.VarChar, 0, "Supplier"),
            new System.Data.SqlClient.SqlParameter("@SupplierName", System.Data.SqlDbType.VarChar, 0, "SupplierName"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@masteragreement_id", System.Data.SqlDbType.Int, 0, "masteragreement_id"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_Flag", System.Data.SqlDbType.Bit, 0, "GST_Flag"),
            new System.Data.SqlClient.SqlParameter("@PST_Flag", System.Data.SqlDbType.Bit, 0, "PST_Flag"),
            new System.Data.SqlClient.SqlParameter("@GST_PCT", System.Data.SqlDbType.Money, 0, "GST_PCT"),
            new System.Data.SqlClient.SqlParameter("@PST_PCT", System.Data.SqlDbType.Money, 0, "PST_PCT"),
            new System.Data.SqlClient.SqlParameter("@Redeemed", System.Data.SqlDbType.Bit, 0, "Redeemed"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreementnum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreementnum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreementnum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreementnum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RecoveredAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RecoveredAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalPOAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalPOAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SupplierName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Redeemed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Redeemed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Redeemed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Redeemed", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreementnum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreementnum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreementnum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreementnum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RecoveredAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RecoveredAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RecoveredAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RetailAmount2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RetailAmount2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RetailAmount2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PSTAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PSTAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSTAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalPOAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalPOAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalPOAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SupplierName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SupplierName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SupplierName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_masteragreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "masteragreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_Flag", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_Flag", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_Flag", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Redeemed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Redeemed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Redeemed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Redeemed", System.Data.DataRowVersion.Original, null)});
            // 
            // daFeeSelection
            // 
            this.daFeeSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daFeeSelection.InsertCommand = this.sqlInsertCommand1;
            this.daFeeSelection.SelectCommand = this.sqlSelectCommand1;
            this.daFeeSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpf_LotList", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected"),
                        new System.Data.Common.DataColumnMapping("Community", "Community"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("masteragreementnum", "masteragreementnum"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("RecoveredAmount", "RecoveredAmount"),
                        new System.Data.Common.DataColumnMapping("RetailAmount1", "RetailAmount1"),
                        new System.Data.Common.DataColumnMapping("RetailAmount2", "RetailAmount2"),
                        new System.Data.Common.DataColumnMapping("POAmount", "POAmount"),
                        new System.Data.Common.DataColumnMapping("GSTAmount", "GSTAmount"),
                        new System.Data.Common.DataColumnMapping("PSTAmount", "PSTAmount"),
                        new System.Data.Common.DataColumnMapping("TotalPOAmount", "TotalPOAmount"),
                        new System.Data.Common.DataColumnMapping("Supplier", "Supplier"),
                        new System.Data.Common.DataColumnMapping("SupplierName", "SupplierName"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("masteragreement_id", "masteragreement_id"),
                        new System.Data.Common.DataColumnMapping("working_ld_LotSearch_ID", "working_ld_LotSearch_ID"),
                        new System.Data.Common.DataColumnMapping("Supplier_ID", "Supplier_ID"),
                        new System.Data.Common.DataColumnMapping("GST_Flag", "GST_Flag"),
                        new System.Data.Common.DataColumnMapping("PST_Flag", "PST_Flag"),
                        new System.Data.Common.DataColumnMapping("GST_PCT", "GST_PCT"),
                        new System.Data.Common.DataColumnMapping("PST_PCT", "PST_PCT"),
                        new System.Data.Common.DataColumnMapping("Redeemed", "Redeemed")})});
            this.daFeeSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // colRedeemed
            // 
            this.colRedeemed.FieldName = "Redeemed";
            this.colRedeemed.Name = "colRedeemed";
            this.colRedeemed.OptionsColumn.AllowEdit = false;
            this.colRedeemed.Visible = true;
            this.colRedeemed.VisibleIndex = 15;
            // 
            // ri_ceSelected
            // 
            this.ri_ceSelected.AutoHeight = false;
            this.ri_ceSelected.Name = "ri_ceSelected";
            this.ri_ceSelected.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ri_ceSelected_EditValueChanging);
            // 
            // ucFeeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcFeeSelection);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucFeeSelection";
            this.Size = new System.Drawing.Size(1299, 719);
            this.Load += new System.EventHandler(this.ucFeeSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFeeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpfLotListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeeSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.DateEdit dePODate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private DevExpress.XtraGrid.GridControl gcFeeSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFeeSelection;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daFeeSelection;
        private dsFeeSelection dsFeeSelection1;
        private System.Windows.Forms.BindingSource workingldlpfLotListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colmasteragreementnum;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colRecoveredAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailAmount2;
        private DevExpress.XtraGrid.Columns.GridColumn colPOAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGSTAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPOAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRedeemed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceSelected;
    }
}
