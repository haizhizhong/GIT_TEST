namespace LD_LotPreSale
{
    partial class frmLotPreSale
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotPreSale));
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPost = new DevExpress.XtraEditors.SimpleButton();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.dsSummary1 = new LD_LotPreSale.dsSummary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpre_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_ceBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colsell_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.gcDeposit = new DevExpress.XtraGrid.GridControl();
            this.dsDeposits1 = new LD_LotPreSale.dsDeposits();
            this.gvDeposit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposit_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposit_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloff_set_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRef_Deposits_Det_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigional_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresaleSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pSummary = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucAccountingPicker1 = new AccountingPicker.ucAccountingPicker();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.TR_Conn = new System.Data.SqlClient.SqlConnection();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daDeposits = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeposits1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSummary)).BeginInit();
            this.pSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBanner1
            // 
            this.topBanner1.BackColor = System.Drawing.Color.White;
            this.topBanner1.BannerTextCaption = "Review the agreement, and then click the post button.";
            this.topBanner1.BannerTitleCaption = "Lot Presale Deposit Update";
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(1100, 88);
            this.topBanner1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 682);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1100, 40);
            this.panelControl3.TabIndex = 3;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.btnCancel);
            this.panelControl4.Controls.Add(this.btnPost);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(898, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(200, 36);
            this.panelControl4.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(24, 8);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // gcSummary
            // 
            this.gcSummary.DataMember = "working_ld_LotSearch";
            this.gcSummary.DataSource = this.dsSummary1;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(2, 42);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_ceBool});
            this.gcSummary.Size = new System.Drawing.Size(1096, 375);
            this.gcSummary.TabIndex = 4;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colagreement_num,
            this.collot_num,
            this.colblock_num,
            this.colplan_num,
            this.colpre_sale,
            this.colsell_price,
            this.colgst,
            this.colpst,
            this.colTotalSellPrice});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
            this.gvSummary.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSummary_FocusedRowChanged);
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.AllowEdit = false;
            this.colagreement_num.OptionsColumn.ReadOnly = true;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 0;
            this.colagreement_num.Width = 76;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.OptionsColumn.ReadOnly = true;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 1;
            this.collot_num.Width = 27;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.OptionsColumn.ReadOnly = true;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 2;
            this.colblock_num.Width = 36;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.OptionsColumn.ReadOnly = true;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 3;
            this.colplan_num.Width = 32;
            // 
            // colpre_sale
            // 
            this.colpre_sale.Caption = "Pre-Sale";
            this.colpre_sale.ColumnEdit = this.ri_ceBool;
            this.colpre_sale.FieldName = "pre_sale";
            this.colpre_sale.Name = "colpre_sale";
            this.colpre_sale.OptionsColumn.AllowEdit = false;
            this.colpre_sale.OptionsColumn.ReadOnly = true;
            this.colpre_sale.Visible = true;
            this.colpre_sale.VisibleIndex = 4;
            this.colpre_sale.Width = 52;
            // 
            // ri_ceBool
            // 
            this.ri_ceBool.AutoHeight = false;
            this.ri_ceBool.Name = "ri_ceBool";
            this.ri_ceBool.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colsell_price
            // 
            this.colsell_price.Caption = "Sell Price";
            this.colsell_price.DisplayFormat.FormatString = "N2";
            this.colsell_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsell_price.FieldName = "agreement_sell_price";
            this.colsell_price.Name = "colsell_price";
            this.colsell_price.OptionsColumn.AllowEdit = false;
            this.colsell_price.OptionsColumn.ReadOnly = true;
            this.colsell_price.Visible = true;
            this.colsell_price.VisibleIndex = 5;
            this.colsell_price.Width = 54;
            // 
            // colgst
            // 
            this.colgst.Caption = "GST";
            this.colgst.ColumnEdit = this.ri_ceBool;
            this.colgst.FieldName = "gst";
            this.colgst.Name = "colgst";
            this.colgst.OptionsColumn.AllowEdit = false;
            this.colgst.OptionsColumn.ReadOnly = true;
            this.colgst.Visible = true;
            this.colgst.VisibleIndex = 6;
            this.colgst.Width = 31;
            // 
            // colpst
            // 
            this.colpst.Caption = "PST";
            this.colpst.ColumnEdit = this.ri_ceBool;
            this.colpst.FieldName = "pst";
            this.colpst.Name = "colpst";
            this.colpst.OptionsColumn.AllowEdit = false;
            this.colpst.OptionsColumn.ReadOnly = true;
            this.colpst.Visible = true;
            this.colpst.VisibleIndex = 7;
            this.colpst.Width = 30;
            // 
            // colTotalSellPrice
            // 
            this.colTotalSellPrice.Caption = "Total Sell Price";
            this.colTotalSellPrice.DisplayFormat.FormatString = "N2";
            this.colTotalSellPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSellPrice.FieldName = "total_sell_price";
            this.colTotalSellPrice.Name = "colTotalSellPrice";
            this.colTotalSellPrice.OptionsColumn.AllowEdit = false;
            this.colTotalSellPrice.OptionsColumn.ReadOnly = true;
            this.colTotalSellPrice.Visible = true;
            this.colTotalSellPrice.VisibleIndex = 8;
            this.colTotalSellPrice.Width = 81;
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.DockingOptions.ShowMaximizeButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // gcDeposit
            // 
            this.gcDeposit.DataMember = "PROJ_LOT_AGREEMENT_DEPOSITS";
            this.gcDeposit.DataSource = this.dsDeposits1;
            this.gcDeposit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDeposit.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDeposit.Location = new System.Drawing.Point(2, 423);
            this.gcDeposit.MainView = this.gvDeposit;
            this.gcDeposit.Name = "gcDeposit";
            this.gcDeposit.Size = new System.Drawing.Size(1096, 169);
            this.gcDeposit.TabIndex = 5;
            this.gcDeposit.UseEmbeddedNavigator = true;
            this.gcDeposit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeposit});
            // 
            // dsDeposits1
            // 
            this.dsDeposits1.DataSetName = "dsDeposits";
            this.dsDeposits1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDeposit
            // 
            this.gvDeposit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colusername,
            this.colagreement_id,
            this.coldeposit_amt,
            this.coldeposit_id,
            this.coloff_set_days,
            this.colRef_Deposits_Det_ID,
            this.colOrigional_ID,
            this.colPresaleSeq});
            this.gvDeposit.GridControl = this.gcDeposit;
            this.gvDeposit.Name = "gvDeposit";
            this.gvDeposit.OptionsBehavior.Editable = false;
            this.gvDeposit.OptionsView.ShowFooter = true;
            this.gvDeposit.OptionsView.ShowGroupPanel = false;
            this.gvDeposit.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDeposit_RowCellStyle);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // coldeposit_amt
            // 
            this.coldeposit_amt.Caption = "Deposit";
            this.coldeposit_amt.DisplayFormat.FormatString = "N2";
            this.coldeposit_amt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldeposit_amt.FieldName = "deposit_amt";
            this.coldeposit_amt.Name = "coldeposit_amt";
            this.coldeposit_amt.OptionsColumn.AllowEdit = false;
            this.coldeposit_amt.SummaryItem.DisplayFormat = "{0:n}";
            this.coldeposit_amt.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.coldeposit_amt.Visible = true;
            this.coldeposit_amt.VisibleIndex = 0;
            // 
            // coldeposit_id
            // 
            this.coldeposit_id.Caption = "Type";
            this.coldeposit_id.FieldName = "Description";
            this.coldeposit_id.Name = "coldeposit_id";
            this.coldeposit_id.OptionsColumn.AllowEdit = false;
            this.coldeposit_id.Visible = true;
            this.coldeposit_id.VisibleIndex = 1;
            // 
            // coloff_set_days
            // 
            this.coloff_set_days.Caption = "Offset Days";
            this.coloff_set_days.FieldName = "off_set_days";
            this.coloff_set_days.Name = "coloff_set_days";
            this.coloff_set_days.OptionsColumn.AllowEdit = false;
            this.coloff_set_days.Visible = true;
            this.coloff_set_days.VisibleIndex = 2;
            // 
            // colRef_Deposits_Det_ID
            // 
            this.colRef_Deposits_Det_ID.FieldName = "Ref_Deposits_Det_ID";
            this.colRef_Deposits_Det_ID.Name = "colRef_Deposits_Det_ID";
            this.colRef_Deposits_Det_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOrigional_ID
            // 
            this.colOrigional_ID.FieldName = "Origional_ID";
            this.colOrigional_ID.Name = "colOrigional_ID";
            this.colOrigional_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPresaleSeq
            // 
            this.colPresaleSeq.Caption = "Pre-Sale Sequence";
            this.colPresaleSeq.FieldName = "PresaleSeq";
            this.colPresaleSeq.Name = "colPresaleSeq";
            this.colPresaleSeq.OptionsColumn.AllowEdit = false;
            this.colPresaleSeq.Visible = true;
            this.colPresaleSeq.VisibleIndex = 3;
            // 
            // pSummary
            // 
            this.pSummary.Controls.Add(this.gcSummary);
            this.pSummary.Controls.Add(this.panelControl1);
            this.pSummary.Controls.Add(this.splitterControl1);
            this.pSummary.Controls.Add(this.gcDeposit);
            this.pSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSummary.Location = new System.Drawing.Point(0, 88);
            this.pSummary.Name = "pSummary";
            this.pSummary.Size = new System.Drawing.Size(1100, 594);
            this.pSummary.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintRegister);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.ucAccountingPicker1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1096, 40);
            this.panelControl1.TabIndex = 7;
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRegister.Location = new System.Drawing.Point(889, 11);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(194, 23);
            this.btnPrintRegister.TabIndex = 2;
            this.btnPrintRegister.Text = "Presale Deposit Pre-Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(351, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Invoice Date";
            // 
            // ucAccountingPicker1
            // 
            this.ucAccountingPicker1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ucAccountingPicker1.Appearance.Options.UseBackColor = true;
            this.ucAccountingPicker1.LLayout = AccountingPicker.ucAccountingPicker.enmLayout.Horizontal;
            this.ucAccountingPicker1.Location = new System.Drawing.Point(10, 5);
            this.ucAccountingPicker1.Name = "ucAccountingPicker1";
            this.ucAccountingPicker1.SelectedPeriod = 0;
            this.ucAccountingPicker1.SelectedYear = 0;
            this.ucAccountingPicker1.Size = new System.Drawing.Size(520, 29);
            this.ucAccountingPicker1.TabIndex = 0;
            this.ucAccountingPicker1.UserName = "";
            this.ucAccountingPicker1.SelectedPeriodChanged += new AccountingPicker.ucAccountingPicker.SelectedPeriodChangedDelegate(this.ucAccountingPicker1_SelectedPeriodChanged);
            this.ucAccountingPicker1.SelectedYearChanged += new AccountingPicker.ucAccountingPicker.SelectedYearChangedDelegate(this.ucAccountingPicker1_SelectedYearChanged);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(2, 417);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1096, 6);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.TR_Conn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // TR_Conn
            // 
            this.TR_Conn.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa";
            this.TR_Conn.FireInfoMessageEventOnUserErrors = false;
            // 
            // daSummary
            // 
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_LotSearch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("pre_sale", "pre_sale"),
                        new System.Data.Common.DataColumnMapping("agreement_sell_price", "agreement_sell_price"),
                        new System.Data.Common.DataColumnMapping("gst", "gst"),
                        new System.Data.Common.DataColumnMapping("pst", "pst"),
                        new System.Data.Common.DataColumnMapping("total_sell_price", "total_sell_price")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.TR_Conn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "agreement_id")});
            // 
            // daDeposits
            // 
            this.daDeposits.SelectCommand = this.sqlSelectCommand2;
            this.daDeposits.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LOT_AGREEMENT_DEPOSITS", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("deposit_amt", "deposit_amt"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("off_set_days", "off_set_days"),
                        new System.Data.Common.DataColumnMapping("PresaleSeq", "PresaleSeq")})});
            // 
            // frmLotPreSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 722);
            this.Controls.Add(this.pSummary);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.topBanner1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLotPreSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lot Presale Deposit";
            this.Load += new System.EventHandler(this.frmLotPreSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeposits1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSummary)).EndInit();
            this.pSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnPost;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colpre_sale;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceBool;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_price;
        private DevExpress.XtraGrid.Columns.GridColumn colgst;
        private DevExpress.XtraGrid.Columns.GridColumn colpst;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSellPrice;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gcDeposit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposit_amt;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposit_id;
        private DevExpress.XtraGrid.Columns.GridColumn coloff_set_days;
        private DevExpress.XtraGrid.Columns.GridColumn colRef_Deposits_Det_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigional_ID;
        private DevExpress.XtraEditors.PanelControl pSummary;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection TR_Conn;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private dsSummary dsSummary1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private AccountingPicker.ucAccountingPicker ucAccountingPicker1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daDeposits;
        private dsDeposits dsDeposits1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraGrid.Columns.GridColumn colPresaleSeq;
    }
}