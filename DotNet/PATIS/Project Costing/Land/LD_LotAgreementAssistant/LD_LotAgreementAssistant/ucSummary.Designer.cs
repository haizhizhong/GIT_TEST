namespace LD_LotAgreementAssistant
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSummary));
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.ds_summary1 = new LD_LotAgreementAssistant.ds_summary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colagreement_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpre_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_ceBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colsell_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colgst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldown_payment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpurchaser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaserCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_purchasercode = new System.Windows.Forms.BindingSource(this.components);
            this.ds_purchasers1 = new LD_LotAgreementAssistant.ds_purchasers();
            this.colpurchaser_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaserDesc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_purchaserdesc = new System.Windows.Forms.BindingSource(this.components);
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprcl_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprcl_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_Class_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_Class_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_SubClass_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_SubClass_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaster_agreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDeposit = new DevExpress.XtraGrid.GridControl();
            this.ds_depositsDetail1 = new LD_LotAgreementAssistant.ds_depositsDetail();
            this.gvDeposit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposit_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeposit_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueDepositType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dslueDepositType1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_lueDepositType1 = new LD_LotAgreementAssistant.ds_lueDepositType();
            this.coloff_set_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRef_Deposits_Det_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigional_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresaleSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMastAgreeDoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgreementDocuments = new DevExpress.XtraEditors.SimpleButton();
            this.cePostPreSale = new DevExpress.XtraEditors.CheckEdit();
            this.deAgreementDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.da_AgreementDetails = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_depositsDetail = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_lueDepositType = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.da_purchasers = new System.Data.SqlClient.SqlDataAdapter();
            this.dockManager2 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpDiscounts = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcLevies = new DevExpress.XtraGrid.GridControl();
            this.dsLevyDetail = new LD_LotAgreementAssistant.dsLevyDetail();
            this.gvLevies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collv1id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collv2id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collv3id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collv4id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.daLevyDetail = new System.Data.SqlClient.SqlDataAdapter();
            this.gcDiscounts = new DevExpress.XtraGrid.GridControl();
            this.gvDiscounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.daDiscountSummary = new System.Data.SqlClient.SqlDataAdapter();
            this.dsDiscountSummary1 = new LD_LotAgreementAssistant.dsDiscountSummary();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_summary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchasercode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_purchasers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchaserdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_depositsDetail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueDepositType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslueDepositType1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueDepositType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cePostPreSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager2)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dpDiscounts.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLevies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLevies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountSummary1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSummary
            // 
            this.gcSummary.DataMember = "working_ld_laa_proj_lot_agreement";
            this.gcSummary.DataSource = this.ds_summary1;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 41);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_ceBool,
            this.repositoryItemTextEdit1,
            this.ri_luePurchaserCode,
            this.ri_luePurchaserDesc});
            this.gcSummary.Size = new System.Drawing.Size(929, 457);
            this.gcSummary.TabIndex = 0;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // ds_summary1
            // 
            this.ds_summary1.DataSetName = "ds_summary";
            this.ds_summary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colagreement_type,
            this.colagreement_num,
            this.collot_num,
            this.colblock_num,
            this.colplan_num,
            this.colpre_sale,
            this.colsell_price,
            this.colgst,
            this.colpst,
            this.colTotalSellPrice,
            this.coldown_payment,
            this.colpurchaser_id,
            this.colpurchaser_id1,
            this.colpri_code,
            this.colpri_name,
            this.colprcl_code,
            this.colprcl_desc,
            this.colLot_Class_Code,
            this.colLot_Class_Desc,
            this.colLot_SubClass_Code,
            this.colLot_SubClass_Desc,
            this.colCommunity,
            this.colmaster_agreement_num});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            this.gvSummary.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSummary_FocusedRowChanged);
            // 
            // colagreement_type
            // 
            this.colagreement_type.Caption = "Agreement Type";
            this.colagreement_type.FieldName = "agreement_type";
            this.colagreement_type.Name = "colagreement_type";
            this.colagreement_type.OptionsColumn.AllowEdit = false;
            this.colagreement_type.OptionsColumn.ReadOnly = true;
            this.colagreement_type.Visible = true;
            this.colagreement_type.VisibleIndex = 0;
            this.colagreement_type.Width = 104;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.AllowEdit = false;
            this.colagreement_num.OptionsColumn.ReadOnly = true;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 2;
            this.colagreement_num.Width = 97;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.OptionsColumn.ReadOnly = true;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 3;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.OptionsColumn.ReadOnly = true;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 4;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.OptionsColumn.ReadOnly = true;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 5;
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
            this.colpre_sale.VisibleIndex = 6;
            this.colpre_sale.Width = 62;
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
            this.colsell_price.ColumnEdit = this.repositoryItemTextEdit1;
            this.colsell_price.DisplayFormat.FormatString = "N2";
            this.colsell_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsell_price.FieldName = "sell_price";
            this.colsell_price.Name = "colsell_price";
            this.colsell_price.OptionsColumn.AllowEdit = false;
            this.colsell_price.OptionsColumn.ReadOnly = true;
            this.colsell_price.Visible = true;
            this.colsell_price.VisibleIndex = 7;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colgst
            // 
            this.colgst.ColumnEdit = this.ri_ceBool;
            this.colgst.FieldName = "gst";
            this.colgst.Name = "colgst";
            this.colgst.OptionsColumn.AllowEdit = false;
            this.colgst.OptionsColumn.ReadOnly = true;
            this.colgst.Visible = true;
            this.colgst.VisibleIndex = 8;
            this.colgst.Width = 56;
            // 
            // colpst
            // 
            this.colpst.ColumnEdit = this.ri_ceBool;
            this.colpst.FieldName = "pst";
            this.colpst.Name = "colpst";
            this.colpst.OptionsColumn.AllowEdit = false;
            this.colpst.OptionsColumn.ReadOnly = true;
            this.colpst.Visible = true;
            this.colpst.VisibleIndex = 9;
            this.colpst.Width = 65;
            // 
            // colTotalSellPrice
            // 
            this.colTotalSellPrice.ColumnEdit = this.repositoryItemTextEdit1;
            this.colTotalSellPrice.DisplayFormat.FormatString = "N2";
            this.colTotalSellPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSellPrice.FieldName = "TotalSellPrice";
            this.colTotalSellPrice.Name = "colTotalSellPrice";
            this.colTotalSellPrice.OptionsColumn.AllowEdit = false;
            this.colTotalSellPrice.OptionsColumn.ReadOnly = true;
            this.colTotalSellPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSellPrice", "{0:n2}")});
            this.colTotalSellPrice.Visible = true;
            this.colTotalSellPrice.VisibleIndex = 11;
            this.colTotalSellPrice.Width = 92;
            // 
            // coldown_payment
            // 
            this.coldown_payment.Caption = "Actual Down Payment";
            this.coldown_payment.ColumnEdit = this.repositoryItemTextEdit1;
            this.coldown_payment.DisplayFormat.FormatString = "n2";
            this.coldown_payment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldown_payment.FieldName = "down_payment";
            this.coldown_payment.Name = "coldown_payment";
            this.coldown_payment.OptionsColumn.AllowEdit = false;
            this.coldown_payment.OptionsColumn.ReadOnly = true;
            this.coldown_payment.Visible = true;
            this.coldown_payment.VisibleIndex = 10;
            this.coldown_payment.Width = 127;
            // 
            // colpurchaser_id
            // 
            this.colpurchaser_id.Caption = "Purchaser Code";
            this.colpurchaser_id.ColumnEdit = this.ri_luePurchaserCode;
            this.colpurchaser_id.FieldName = "purchaser_id";
            this.colpurchaser_id.Name = "colpurchaser_id";
            this.colpurchaser_id.OptionsColumn.AllowEdit = false;
            this.colpurchaser_id.OptionsColumn.ReadOnly = true;
            this.colpurchaser_id.Width = 98;
            // 
            // ri_luePurchaserCode
            // 
            this.ri_luePurchaserCode.AutoHeight = false;
            this.ri_luePurchaserCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_luePurchaserCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMER_CODE", "Code", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_luePurchaserCode.DataSource = this.bs_purchasercode;
            this.ri_luePurchaserCode.DisplayMember = "CUSTOMER_CODE";
            this.ri_luePurchaserCode.Name = "ri_luePurchaserCode";
            this.ri_luePurchaserCode.NullText = "";
            this.ri_luePurchaserCode.ValueMember = "CUSTOMER_ID";
            // 
            // bs_purchasercode
            // 
            this.bs_purchasercode.DataMember = "CUSTOMERS";
            this.bs_purchasercode.DataSource = this.ds_purchasers1;
            // 
            // ds_purchasers1
            // 
            this.ds_purchasers1.DataSetName = "ds_purchasers";
            this.ds_purchasers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colpurchaser_id1
            // 
            this.colpurchaser_id1.Caption = "Purchaser";
            this.colpurchaser_id1.ColumnEdit = this.ri_luePurchaserDesc;
            this.colpurchaser_id1.FieldName = "purchaser_id";
            this.colpurchaser_id1.Name = "colpurchaser_id1";
            this.colpurchaser_id1.OptionsColumn.AllowEdit = false;
            this.colpurchaser_id1.OptionsColumn.ReadOnly = true;
            // 
            // ri_luePurchaserDesc
            // 
            this.ri_luePurchaserDesc.AutoHeight = false;
            this.ri_luePurchaserDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_luePurchaserDesc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Purchaser", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_luePurchaserDesc.DataSource = this.bs_purchaserdesc;
            this.ri_luePurchaserDesc.DisplayMember = "NAME";
            this.ri_luePurchaserDesc.Name = "ri_luePurchaserDesc";
            this.ri_luePurchaserDesc.NullText = "";
            this.ri_luePurchaserDesc.ValueMember = "CUSTOMER_ID";
            // 
            // bs_purchaserdesc
            // 
            this.bs_purchaserdesc.DataMember = "CUSTOMERS";
            this.bs_purchaserdesc.DataSource = this.ds_purchasers1;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project #";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.OptionsColumn.ReadOnly = true;
            this.colpri_code.Width = 84;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.OptionsColumn.AllowEdit = false;
            this.colpri_name.OptionsColumn.ReadOnly = true;
            this.colpri_name.Width = 86;
            // 
            // colprcl_code
            // 
            this.colprcl_code.Caption = "Project Class Code";
            this.colprcl_code.FieldName = "prcl_code";
            this.colprcl_code.Name = "colprcl_code";
            this.colprcl_code.OptionsColumn.AllowEdit = false;
            this.colprcl_code.OptionsColumn.ReadOnly = true;
            this.colprcl_code.Width = 112;
            // 
            // colprcl_desc
            // 
            this.colprcl_desc.Caption = "Project Class Description";
            this.colprcl_desc.FieldName = "prcl_desc";
            this.colprcl_desc.Name = "colprcl_desc";
            this.colprcl_desc.OptionsColumn.AllowEdit = false;
            this.colprcl_desc.OptionsColumn.ReadOnly = true;
            this.colprcl_desc.Width = 140;
            // 
            // colLot_Class_Code
            // 
            this.colLot_Class_Code.Caption = "Lot Class Code";
            this.colLot_Class_Code.FieldName = "Lot_Class_Code";
            this.colLot_Class_Code.Name = "colLot_Class_Code";
            this.colLot_Class_Code.OptionsColumn.AllowEdit = false;
            this.colLot_Class_Code.OptionsColumn.ReadOnly = true;
            this.colLot_Class_Code.Width = 93;
            // 
            // colLot_Class_Desc
            // 
            this.colLot_Class_Desc.Caption = "Lot Class Description";
            this.colLot_Class_Desc.FieldName = "Lot_Class_Desc";
            this.colLot_Class_Desc.Name = "colLot_Class_Desc";
            this.colLot_Class_Desc.OptionsColumn.AllowEdit = false;
            this.colLot_Class_Desc.OptionsColumn.ReadOnly = true;
            this.colLot_Class_Desc.Width = 121;
            // 
            // colLot_SubClass_Code
            // 
            this.colLot_SubClass_Code.Caption = "Lot Sub Class Code";
            this.colLot_SubClass_Code.FieldName = "Lot_SubClass_Code";
            this.colLot_SubClass_Code.Name = "colLot_SubClass_Code";
            this.colLot_SubClass_Code.OptionsColumn.AllowEdit = false;
            this.colLot_SubClass_Code.OptionsColumn.ReadOnly = true;
            this.colLot_SubClass_Code.Width = 114;
            // 
            // colLot_SubClass_Desc
            // 
            this.colLot_SubClass_Desc.Caption = "Lot Sub Class Description";
            this.colLot_SubClass_Desc.FieldName = "Lot_SubClass_Desc";
            this.colLot_SubClass_Desc.Name = "colLot_SubClass_Desc";
            this.colLot_SubClass_Desc.OptionsColumn.AllowEdit = false;
            this.colLot_SubClass_Desc.OptionsColumn.ReadOnly = true;
            this.colLot_SubClass_Desc.Width = 142;
            // 
            // colCommunity
            // 
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.OptionsColumn.AllowEdit = false;
            this.colCommunity.OptionsColumn.ReadOnly = true;
            // 
            // colmaster_agreement_num
            // 
            this.colmaster_agreement_num.Caption = "Master Agreement #";
            this.colmaster_agreement_num.FieldName = "master_agreement_num";
            this.colmaster_agreement_num.Name = "colmaster_agreement_num";
            this.colmaster_agreement_num.OptionsColumn.AllowEdit = false;
            this.colmaster_agreement_num.Visible = true;
            this.colmaster_agreement_num.VisibleIndex = 1;
            this.colmaster_agreement_num.Width = 127;
            // 
            // gcDeposit
            // 
            this.gcDeposit.DataMember = "working_ld_laa_proj_lot_agreement_deposits";
            this.gcDeposit.DataSource = this.ds_depositsDetail1;
            this.gcDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDeposit.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDeposit.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDeposit.Location = new System.Drawing.Point(0, 0);
            this.gcDeposit.MainView = this.gvDeposit;
            this.gcDeposit.Name = "gcDeposit";
            this.gcDeposit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teNumaric2,
            this.ri_lueDepositType});
            this.gcDeposit.Size = new System.Drawing.Size(351, 624);
            this.gcDeposit.TabIndex = 0;
            this.gcDeposit.UseEmbeddedNavigator = true;
            this.gcDeposit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeposit});
            // 
            // ds_depositsDetail1
            // 
            this.ds_depositsDetail1.DataSetName = "ds_depositsDetail";
            this.ds_depositsDetail1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.coldeposit_amt.Visible = true;
            this.coldeposit_amt.VisibleIndex = 0;
            // 
            // coldeposit_id
            // 
            this.coldeposit_id.Caption = "Type";
            this.coldeposit_id.ColumnEdit = this.ri_lueDepositType;
            this.coldeposit_id.FieldName = "deposit_id";
            this.coldeposit_id.Name = "coldeposit_id";
            this.coldeposit_id.Visible = true;
            this.coldeposit_id.VisibleIndex = 1;
            // 
            // ri_lueDepositType
            // 
            this.ri_lueDepositType.AutoHeight = false;
            this.ri_lueDepositType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueDepositType.DataSource = this.dslueDepositType1BindingSource;
            this.ri_lueDepositType.DisplayMember = "Description";
            this.ri_lueDepositType.Name = "ri_lueDepositType";
            this.ri_lueDepositType.NullText = "";
            this.ri_lueDepositType.ValueMember = "Deposit_ID";
            // 
            // dslueDepositType1BindingSource
            // 
            this.dslueDepositType1BindingSource.DataMember = "LD_Deposits";
            this.dslueDepositType1BindingSource.DataSource = this.ds_lueDepositType1;
            // 
            // ds_lueDepositType1
            // 
            this.ds_lueDepositType1.DataSetName = "ds_lueDepositType";
            this.ds_lueDepositType1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloff_set_days
            // 
            this.coloff_set_days.Caption = "Offset Days";
            this.coloff_set_days.FieldName = "off_set_days";
            this.coloff_set_days.Name = "coloff_set_days";
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
            this.colPresaleSeq.FieldName = "PresaleSeq";
            this.colPresaleSeq.Name = "colPresaleSeq";
            this.colPresaleSeq.OptionsColumn.AllowEdit = false;
            this.colPresaleSeq.Visible = true;
            this.colPresaleSeq.VisibleIndex = 3;
            // 
            // ri_teNumaric2
            // 
            this.ri_teNumaric2.AutoHeight = false;
            this.ri_teNumaric2.Mask.EditMask = "n";
            this.ri_teNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric2.Name = "ri_teNumaric2";
            this.ri_teNumaric2.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnMastAgreeDoc);
            this.panelControl1.Controls.Add(this.btnAgreementDocuments);
            this.panelControl1.Controls.Add(this.cePostPreSale);
            this.panelControl1.Controls.Add(this.deAgreementDate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnPrintRegister);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 41);
            this.panelControl1.TabIndex = 2;
            // 
            // btnMastAgreeDoc
            // 
            this.btnMastAgreeDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMastAgreeDoc.Location = new System.Drawing.Point(387, 12);
            this.btnMastAgreeDoc.Name = "btnMastAgreeDoc";
            this.btnMastAgreeDoc.Size = new System.Drawing.Size(166, 23);
            this.btnMastAgreeDoc.TabIndex = 5;
            this.btnMastAgreeDoc.Text = "Master Agreement Documents";
            this.btnMastAgreeDoc.Click += new System.EventHandler(this.btnMastAgreeDoc_Click);
            // 
            // btnAgreementDocuments
            // 
            this.btnAgreementDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgreementDocuments.Location = new System.Drawing.Point(559, 12);
            this.btnAgreementDocuments.Name = "btnAgreementDocuments";
            this.btnAgreementDocuments.Size = new System.Drawing.Size(134, 23);
            this.btnAgreementDocuments.TabIndex = 4;
            this.btnAgreementDocuments.Text = "Agreement Documents";
            this.btnAgreementDocuments.Click += new System.EventHandler(this.btnAgreementDocuments_Click);
            // 
            // cePostPreSale
            // 
            this.cePostPreSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cePostPreSale.Location = new System.Drawing.Point(248, 13);
            this.cePostPreSale.Name = "cePostPreSale";
            this.cePostPreSale.Properties.Caption = "Post Pre-Sale Deposits";
            this.cePostPreSale.Size = new System.Drawing.Size(133, 19);
            this.cePostPreSale.TabIndex = 3;
            // 
            // deAgreementDate
            // 
            this.deAgreementDate.EditValue = null;
            this.deAgreementDate.Location = new System.Drawing.Point(100, 12);
            this.deAgreementDate.Name = "deAgreementDate";
            this.deAgreementDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false)});
            this.deAgreementDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deAgreementDate.Properties.ReadOnly = true;
            this.deAgreementDate.Size = new System.Drawing.Size(132, 20);
            this.deAgreementDate.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Agreement Date";
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRegister.Location = new System.Drawing.Point(699, 12);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(209, 23);
            this.btnPrintRegister.TabIndex = 0;
            this.btnPrintRegister.Text = "Print Master Agreement Pre-Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DEVSQL2008R2;Initial Catalog=TR_V11_GC;User ID=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // da_AgreementDetails
            // 
            this.da_AgreementDetails.DeleteCommand = this.sqlDeleteCommand1;
            this.da_AgreementDetails.InsertCommand = this.sqlInsertCommand1;
            this.da_AgreementDetails.SelectCommand = this.sqlSelectCommand1;
            this.da_AgreementDetails.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_laa_proj_lot_agreement", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("pre_sale", "pre_sale"),
                        new System.Data.Common.DataColumnMapping("sales_type_id", "sales_type_id"),
                        new System.Data.Common.DataColumnMapping("gst", "gst"),
                        new System.Data.Common.DataColumnMapping("pst", "pst"),
                        new System.Data.Common.DataColumnMapping("sell_price", "sell_price"),
                        new System.Data.Common.DataColumnMapping("sales_deposit", "sales_deposit"),
                        new System.Data.Common.DataColumnMapping("down_payment", "down_payment"),
                        new System.Data.Common.DataColumnMapping("damage_deposit", "damage_deposit"),
                        new System.Data.Common.DataColumnMapping("discount_pct", "discount_pct"),
                        new System.Data.Common.DataColumnMapping("discount_amt", "discount_amt"),
                        new System.Data.Common.DataColumnMapping("penalty_pct", "penalty_pct"),
                        new System.Data.Common.DataColumnMapping("penalty_amt", "penalty_amt"),
                        new System.Data.Common.DataColumnMapping("purchaser_type_id", "purchaser_type_id"),
                        new System.Data.Common.DataColumnMapping("purchaser_id", "purchaser_id"),
                        new System.Data.Common.DataColumnMapping("purchaser_id2", "purchaser_id2"),
                        new System.Data.Common.DataColumnMapping("purchaser_id3", "purchaser_id3"),
                        new System.Data.Common.DataColumnMapping("agreement_date", "agreement_date"),
                        new System.Data.Common.DataColumnMapping("closing_date", "closing_date"),
                        new System.Data.Common.DataColumnMapping("sale_date", "sale_date"),
                        new System.Data.Common.DataColumnMapping("interest_adjustment_date", "interest_adjustment_date"),
                        new System.Data.Common.DataColumnMapping("arrears_interest_date", "arrears_interest_date"),
                        new System.Data.Common.DataColumnMapping("payout_date", "payout_date"),
                        new System.Data.Common.DataColumnMapping("original_arrears_date", "original_arrears_date"),
                        new System.Data.Common.DataColumnMapping("r_rate_type_id", "r_rate_type_id"),
                        new System.Data.Common.DataColumnMapping("r_rate_based_on_id", "r_rate_based_on_id"),
                        new System.Data.Common.DataColumnMapping("r_frequency_id", "r_frequency_id"),
                        new System.Data.Common.DataColumnMapping("r_min_interest", "r_min_interest"),
                        new System.Data.Common.DataColumnMapping("r_interest_rate", "r_interest_rate"),
                        new System.Data.Common.DataColumnMapping("r_max_interest", "r_max_interest"),
                        new System.Data.Common.DataColumnMapping("a_rate_type_id", "a_rate_type_id"),
                        new System.Data.Common.DataColumnMapping("a_rate_based_on_id", "a_rate_based_on_id"),
                        new System.Data.Common.DataColumnMapping("a_frequency_id", "a_frequency_id"),
                        new System.Data.Common.DataColumnMapping("a_min_interest", "a_min_interest"),
                        new System.Data.Common.DataColumnMapping("a_interest_rate", "a_interest_rate"),
                        new System.Data.Common.DataColumnMapping("a_max_interest", "a_max_interest"),
                        new System.Data.Common.DataColumnMapping("builders_id", "builders_id"),
                        new System.Data.Common.DataColumnMapping("wcb", "wcb"),
                        new System.Data.Common.DataColumnMapping("wcb_provider", "wcb_provider"),
                        new System.Data.Common.DataColumnMapping("hoa_applicable", "hoa_applicable"),
                        new System.Data.Common.DataColumnMapping("hoa_received", "hoa_received"),
                        new System.Data.Common.DataColumnMapping("hoa_amount", "hoa_amount"),
                        new System.Data.Common.DataColumnMapping("hoa_date", "hoa_date"),
                        new System.Data.Common.DataColumnMapping("hoa_comment", "hoa_comment"),
                        new System.Data.Common.DataColumnMapping("agreement_status_id", "agreement_status_id"),
                        new System.Data.Common.DataColumnMapping("agreement_type", "agreement_type"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("TotalSellPrice", "TotalSellPrice"),
                        new System.Data.Common.DataColumnMapping("Community", "Community"),
                        new System.Data.Common.DataColumnMapping("prc_code", "prc_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("prcl_code", "prcl_code"),
                        new System.Data.Common.DataColumnMapping("prcl_desc", "prcl_desc"),
                        new System.Data.Common.DataColumnMapping("Lot_Class_Code", "Lot_Class_Code"),
                        new System.Data.Common.DataColumnMapping("Lot_Class_Desc", "Lot_Class_Desc"),
                        new System.Data.Common.DataColumnMapping("Lot_SubClass_Code", "Lot_SubClass_Code"),
                        new System.Data.Common.DataColumnMapping("Lot_SubClass_Desc", "Lot_SubClass_Desc"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("master_agreement_num", "master_agreement_num")})});
            this.da_AgreementDetails.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pre_sale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pre_sale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sales_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sales_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sales_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sales_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sales_deposit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sales_deposit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sales_deposit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sales_deposit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_down_payment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "down_payment", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_down_payment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "down_payment", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_damage_deposit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "damage_deposit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_damage_deposit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "damage_deposit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_discount_pct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "discount_pct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_discount_pct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "discount_pct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_discount_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "discount_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_discount_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "discount_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_penalty_pct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "penalty_pct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_penalty_pct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "penalty_pct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_penalty_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "penalty_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_penalty_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "penalty_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_closing_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "closing_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_closing_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "closing_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sale_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sale_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sale_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sale_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_interest_adjustment_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "interest_adjustment_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_interest_adjustment_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "interest_adjustment_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_arrears_interest_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "arrears_interest_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_arrears_interest_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "arrears_interest_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_payout_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "payout_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_payout_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "payout_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "original_arrears_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "original_arrears_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_rate_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_rate_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_rate_based_on_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_rate_based_on_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_min_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_min_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_min_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_min_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_interest_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_interest_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_interest_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_interest_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_max_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_max_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_max_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_max_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_rate_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_rate_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_rate_based_on_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_rate_based_on_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_min_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_min_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_min_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_min_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_interest_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_interest_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_interest_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_interest_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_max_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_max_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_max_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_max_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_builders_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "builders_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_builders_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "builders_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wcb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wcb", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wcb", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wcb", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wcb_provider", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wcb_provider", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wcb_provider", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wcb_provider", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_applicable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_applicable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_applicable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_applicable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_received", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_received", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_received", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_received", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalSellPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalSellPrice", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalSellPrice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalSellPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prc_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prc_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prcl_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prcl_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prcl_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prcl_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prcl_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prcl_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prcl_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prcl_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_Desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_Desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_Desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_Desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_SubClass_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_SubClass_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_SubClass_Desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_SubClass_Desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_master_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "master_agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_master_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "master_agreement_num", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@pre_sale", System.Data.SqlDbType.Bit, 0, "pre_sale"),
            new System.Data.SqlClient.SqlParameter("@sales_type_id", System.Data.SqlDbType.Int, 0, "sales_type_id"),
            new System.Data.SqlClient.SqlParameter("@gst", System.Data.SqlDbType.Bit, 0, "gst"),
            new System.Data.SqlClient.SqlParameter("@pst", System.Data.SqlDbType.Bit, 0, "pst"),
            new System.Data.SqlClient.SqlParameter("@sell_price", System.Data.SqlDbType.Money, 0, "sell_price"),
            new System.Data.SqlClient.SqlParameter("@sales_deposit", System.Data.SqlDbType.Money, 0, "sales_deposit"),
            new System.Data.SqlClient.SqlParameter("@down_payment", System.Data.SqlDbType.Money, 0, "down_payment"),
            new System.Data.SqlClient.SqlParameter("@damage_deposit", System.Data.SqlDbType.Money, 0, "damage_deposit"),
            new System.Data.SqlClient.SqlParameter("@discount_pct", System.Data.SqlDbType.Money, 0, "discount_pct"),
            new System.Data.SqlClient.SqlParameter("@discount_amt", System.Data.SqlDbType.Money, 0, "discount_amt"),
            new System.Data.SqlClient.SqlParameter("@penalty_pct", System.Data.SqlDbType.Money, 0, "penalty_pct"),
            new System.Data.SqlClient.SqlParameter("@penalty_amt", System.Data.SqlDbType.Money, 0, "penalty_amt"),
            new System.Data.SqlClient.SqlParameter("@purchaser_type_id", System.Data.SqlDbType.Int, 0, "purchaser_type_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id", System.Data.SqlDbType.Int, 0, "purchaser_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id2", System.Data.SqlDbType.Int, 0, "purchaser_id2"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id3", System.Data.SqlDbType.Int, 0, "purchaser_id3"),
            new System.Data.SqlClient.SqlParameter("@agreement_date", System.Data.SqlDbType.DateTime, 0, "agreement_date"),
            new System.Data.SqlClient.SqlParameter("@closing_date", System.Data.SqlDbType.DateTime, 0, "closing_date"),
            new System.Data.SqlClient.SqlParameter("@sale_date", System.Data.SqlDbType.DateTime, 0, "sale_date"),
            new System.Data.SqlClient.SqlParameter("@interest_adjustment_date", System.Data.SqlDbType.DateTime, 0, "interest_adjustment_date"),
            new System.Data.SqlClient.SqlParameter("@arrears_interest_date", System.Data.SqlDbType.DateTime, 0, "arrears_interest_date"),
            new System.Data.SqlClient.SqlParameter("@payout_date", System.Data.SqlDbType.DateTime, 0, "payout_date"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.DateTime, 0, "original_arrears_date"),
            new System.Data.SqlClient.SqlParameter("@r_rate_type_id", System.Data.SqlDbType.Int, 0, "r_rate_type_id"),
            new System.Data.SqlClient.SqlParameter("@r_rate_based_on_id", System.Data.SqlDbType.Int, 0, "r_rate_based_on_id"),
            new System.Data.SqlClient.SqlParameter("@r_frequency_id", System.Data.SqlDbType.Int, 0, "r_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@r_min_interest", System.Data.SqlDbType.Money, 0, "r_min_interest"),
            new System.Data.SqlClient.SqlParameter("@r_interest_rate", System.Data.SqlDbType.Money, 0, "r_interest_rate"),
            new System.Data.SqlClient.SqlParameter("@r_max_interest", System.Data.SqlDbType.Money, 0, "r_max_interest"),
            new System.Data.SqlClient.SqlParameter("@a_rate_type_id", System.Data.SqlDbType.Int, 0, "a_rate_type_id"),
            new System.Data.SqlClient.SqlParameter("@a_rate_based_on_id", System.Data.SqlDbType.Int, 0, "a_rate_based_on_id"),
            new System.Data.SqlClient.SqlParameter("@a_frequency_id", System.Data.SqlDbType.Int, 0, "a_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@a_min_interest", System.Data.SqlDbType.Money, 0, "a_min_interest"),
            new System.Data.SqlClient.SqlParameter("@a_interest_rate", System.Data.SqlDbType.Money, 0, "a_interest_rate"),
            new System.Data.SqlClient.SqlParameter("@a_max_interest", System.Data.SqlDbType.Money, 0, "a_max_interest"),
            new System.Data.SqlClient.SqlParameter("@builders_id", System.Data.SqlDbType.Int, 0, "builders_id"),
            new System.Data.SqlClient.SqlParameter("@wcb", System.Data.SqlDbType.Bit, 0, "wcb"),
            new System.Data.SqlClient.SqlParameter("@wcb_provider", System.Data.SqlDbType.VarChar, 0, "wcb_provider"),
            new System.Data.SqlClient.SqlParameter("@hoa_applicable", System.Data.SqlDbType.Bit, 0, "hoa_applicable"),
            new System.Data.SqlClient.SqlParameter("@hoa_received", System.Data.SqlDbType.Bit, 0, "hoa_received"),
            new System.Data.SqlClient.SqlParameter("@hoa_amount", System.Data.SqlDbType.Money, 0, "hoa_amount"),
            new System.Data.SqlClient.SqlParameter("@hoa_date", System.Data.SqlDbType.DateTime, 0, "hoa_date"),
            new System.Data.SqlClient.SqlParameter("@hoa_comment", System.Data.SqlDbType.VarChar, 0, "hoa_comment"),
            new System.Data.SqlClient.SqlParameter("@agreement_status_id", System.Data.SqlDbType.Int, 0, "agreement_status_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_type", System.Data.SqlDbType.VarChar, 0, "agreement_type"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@TotalSellPrice", System.Data.SqlDbType.Money, 0, "TotalSellPrice"),
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@prc_code", System.Data.SqlDbType.VarChar, 0, "prc_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@prcl_code", System.Data.SqlDbType.VarChar, 0, "prcl_code"),
            new System.Data.SqlClient.SqlParameter("@prcl_desc", System.Data.SqlDbType.VarChar, 0, "prcl_desc"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_Code", System.Data.SqlDbType.VarChar, 0, "Lot_Class_Code"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_Desc", System.Data.SqlDbType.VarChar, 0, "Lot_Class_Desc"),
            new System.Data.SqlClient.SqlParameter("@Lot_SubClass_Code", System.Data.SqlDbType.VarChar, 0, "Lot_SubClass_Code"),
            new System.Data.SqlClient.SqlParameter("@Lot_SubClass_Desc", System.Data.SqlDbType.VarChar, 0, "Lot_SubClass_Desc"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@master_agreement_num", System.Data.SqlDbType.Int, 0, "master_agreement_num")});
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
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@pre_sale", System.Data.SqlDbType.Bit, 0, "pre_sale"),
            new System.Data.SqlClient.SqlParameter("@sales_type_id", System.Data.SqlDbType.Int, 0, "sales_type_id"),
            new System.Data.SqlClient.SqlParameter("@gst", System.Data.SqlDbType.Bit, 0, "gst"),
            new System.Data.SqlClient.SqlParameter("@pst", System.Data.SqlDbType.Bit, 0, "pst"),
            new System.Data.SqlClient.SqlParameter("@sell_price", System.Data.SqlDbType.Money, 0, "sell_price"),
            new System.Data.SqlClient.SqlParameter("@sales_deposit", System.Data.SqlDbType.Money, 0, "sales_deposit"),
            new System.Data.SqlClient.SqlParameter("@down_payment", System.Data.SqlDbType.Money, 0, "down_payment"),
            new System.Data.SqlClient.SqlParameter("@damage_deposit", System.Data.SqlDbType.Money, 0, "damage_deposit"),
            new System.Data.SqlClient.SqlParameter("@discount_pct", System.Data.SqlDbType.Money, 0, "discount_pct"),
            new System.Data.SqlClient.SqlParameter("@discount_amt", System.Data.SqlDbType.Money, 0, "discount_amt"),
            new System.Data.SqlClient.SqlParameter("@penalty_pct", System.Data.SqlDbType.Money, 0, "penalty_pct"),
            new System.Data.SqlClient.SqlParameter("@penalty_amt", System.Data.SqlDbType.Money, 0, "penalty_amt"),
            new System.Data.SqlClient.SqlParameter("@purchaser_type_id", System.Data.SqlDbType.Int, 0, "purchaser_type_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id", System.Data.SqlDbType.Int, 0, "purchaser_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id2", System.Data.SqlDbType.Int, 0, "purchaser_id2"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id3", System.Data.SqlDbType.Int, 0, "purchaser_id3"),
            new System.Data.SqlClient.SqlParameter("@agreement_date", System.Data.SqlDbType.DateTime, 0, "agreement_date"),
            new System.Data.SqlClient.SqlParameter("@closing_date", System.Data.SqlDbType.DateTime, 0, "closing_date"),
            new System.Data.SqlClient.SqlParameter("@sale_date", System.Data.SqlDbType.DateTime, 0, "sale_date"),
            new System.Data.SqlClient.SqlParameter("@interest_adjustment_date", System.Data.SqlDbType.DateTime, 0, "interest_adjustment_date"),
            new System.Data.SqlClient.SqlParameter("@arrears_interest_date", System.Data.SqlDbType.DateTime, 0, "arrears_interest_date"),
            new System.Data.SqlClient.SqlParameter("@payout_date", System.Data.SqlDbType.DateTime, 0, "payout_date"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.DateTime, 0, "original_arrears_date"),
            new System.Data.SqlClient.SqlParameter("@r_rate_type_id", System.Data.SqlDbType.Int, 0, "r_rate_type_id"),
            new System.Data.SqlClient.SqlParameter("@r_rate_based_on_id", System.Data.SqlDbType.Int, 0, "r_rate_based_on_id"),
            new System.Data.SqlClient.SqlParameter("@r_frequency_id", System.Data.SqlDbType.Int, 0, "r_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@r_min_interest", System.Data.SqlDbType.Money, 0, "r_min_interest"),
            new System.Data.SqlClient.SqlParameter("@r_interest_rate", System.Data.SqlDbType.Money, 0, "r_interest_rate"),
            new System.Data.SqlClient.SqlParameter("@r_max_interest", System.Data.SqlDbType.Money, 0, "r_max_interest"),
            new System.Data.SqlClient.SqlParameter("@a_rate_type_id", System.Data.SqlDbType.Int, 0, "a_rate_type_id"),
            new System.Data.SqlClient.SqlParameter("@a_rate_based_on_id", System.Data.SqlDbType.Int, 0, "a_rate_based_on_id"),
            new System.Data.SqlClient.SqlParameter("@a_frequency_id", System.Data.SqlDbType.Int, 0, "a_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@a_min_interest", System.Data.SqlDbType.Money, 0, "a_min_interest"),
            new System.Data.SqlClient.SqlParameter("@a_interest_rate", System.Data.SqlDbType.Money, 0, "a_interest_rate"),
            new System.Data.SqlClient.SqlParameter("@a_max_interest", System.Data.SqlDbType.Money, 0, "a_max_interest"),
            new System.Data.SqlClient.SqlParameter("@builders_id", System.Data.SqlDbType.Int, 0, "builders_id"),
            new System.Data.SqlClient.SqlParameter("@wcb", System.Data.SqlDbType.Bit, 0, "wcb"),
            new System.Data.SqlClient.SqlParameter("@wcb_provider", System.Data.SqlDbType.VarChar, 0, "wcb_provider"),
            new System.Data.SqlClient.SqlParameter("@hoa_applicable", System.Data.SqlDbType.Bit, 0, "hoa_applicable"),
            new System.Data.SqlClient.SqlParameter("@hoa_received", System.Data.SqlDbType.Bit, 0, "hoa_received"),
            new System.Data.SqlClient.SqlParameter("@hoa_amount", System.Data.SqlDbType.Money, 0, "hoa_amount"),
            new System.Data.SqlClient.SqlParameter("@hoa_date", System.Data.SqlDbType.DateTime, 0, "hoa_date"),
            new System.Data.SqlClient.SqlParameter("@hoa_comment", System.Data.SqlDbType.VarChar, 0, "hoa_comment"),
            new System.Data.SqlClient.SqlParameter("@agreement_status_id", System.Data.SqlDbType.Int, 0, "agreement_status_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_type", System.Data.SqlDbType.VarChar, 0, "agreement_type"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@TotalSellPrice", System.Data.SqlDbType.Money, 0, "TotalSellPrice"),
            new System.Data.SqlClient.SqlParameter("@Community", System.Data.SqlDbType.VarChar, 0, "Community"),
            new System.Data.SqlClient.SqlParameter("@prc_code", System.Data.SqlDbType.VarChar, 0, "prc_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@prcl_code", System.Data.SqlDbType.VarChar, 0, "prcl_code"),
            new System.Data.SqlClient.SqlParameter("@prcl_desc", System.Data.SqlDbType.VarChar, 0, "prcl_desc"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_Code", System.Data.SqlDbType.VarChar, 0, "Lot_Class_Code"),
            new System.Data.SqlClient.SqlParameter("@Lot_Class_Desc", System.Data.SqlDbType.VarChar, 0, "Lot_Class_Desc"),
            new System.Data.SqlClient.SqlParameter("@Lot_SubClass_Code", System.Data.SqlDbType.VarChar, 0, "Lot_SubClass_Code"),
            new System.Data.SqlClient.SqlParameter("@Lot_SubClass_Desc", System.Data.SqlDbType.VarChar, 0, "Lot_SubClass_Desc"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@master_agreement_num", System.Data.SqlDbType.Int, 0, "master_agreement_num"),
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pre_sale", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pre_sale", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pre_sale", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sales_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sales_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sales_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sales_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_gst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_gst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pst", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sell_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sell_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sell_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sales_deposit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sales_deposit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sales_deposit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sales_deposit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_down_payment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "down_payment", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_down_payment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "down_payment", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_damage_deposit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "damage_deposit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_damage_deposit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "damage_deposit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_discount_pct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "discount_pct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_discount_pct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "discount_pct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_discount_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "discount_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_discount_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "discount_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_penalty_pct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "penalty_pct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_penalty_pct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "penalty_pct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_penalty_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "penalty_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_penalty_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "penalty_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_closing_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "closing_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_closing_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "closing_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sale_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sale_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sale_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sale_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_interest_adjustment_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "interest_adjustment_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_interest_adjustment_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "interest_adjustment_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_arrears_interest_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "arrears_interest_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_arrears_interest_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "arrears_interest_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_payout_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "payout_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_payout_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "payout_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "original_arrears_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "original_arrears_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_rate_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_rate_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_rate_based_on_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_rate_based_on_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_min_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_min_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_min_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_min_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_interest_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_interest_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_interest_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_interest_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_r_max_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "r_max_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_r_max_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "r_max_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_rate_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_rate_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_rate_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_rate_based_on_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_rate_based_on_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_rate_based_on_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_min_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_min_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_min_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_min_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_interest_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_interest_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_interest_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_interest_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_a_max_interest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "a_max_interest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_a_max_interest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "a_max_interest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_builders_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "builders_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_builders_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "builders_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wcb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wcb", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wcb", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wcb", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wcb_provider", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wcb_provider", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wcb_provider", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wcb_provider", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_applicable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_applicable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_applicable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_applicable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_received", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_received", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_received", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_received", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hoa_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hoa_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hoa_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hoa_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalSellPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalSellPrice", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalSellPrice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalSellPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Community", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Community", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Community", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prc_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prc_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prcl_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prcl_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prcl_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prcl_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prcl_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prcl_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prcl_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prcl_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_Class_Desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_Class_Desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_Class_Desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_Class_Desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_SubClass_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_SubClass_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lot_SubClass_Desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lot_SubClass_Desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lot_SubClass_Desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_master_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "master_agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_master_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "master_agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // da_depositsDetail
            // 
            this.da_depositsDetail.DeleteCommand = this.sqlDeleteCommand2;
            this.da_depositsDetail.InsertCommand = this.sqlInsertCommand2;
            this.da_depositsDetail.SelectCommand = this.sqlSelectCommand2;
            this.da_depositsDetail.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_laa_proj_lot_agreement_deposits", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("deposit_amt", "deposit_amt"),
                        new System.Data.Common.DataColumnMapping("deposit_id", "deposit_id"),
                        new System.Data.Common.DataColumnMapping("off_set_days", "off_set_days"),
                        new System.Data.Common.DataColumnMapping("Ref_Deposits_Det_ID", "Ref_Deposits_Det_ID"),
                        new System.Data.Common.DataColumnMapping("Origional_ID", "Origional_ID"),
                        new System.Data.Common.DataColumnMapping("PresaleSeq", "PresaleSeq")})});
            this.da_depositsDetail.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_deposit_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "deposit_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_deposit_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "deposit_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_deposit_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "deposit_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_deposit_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "deposit_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_off_set_days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "off_set_days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_off_set_days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "off_set_days", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ref_Deposits_Det_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ref_Deposits_Det_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origional_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origional_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origional_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origional_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PresaleSeq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PresaleSeq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PresaleSeq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PresaleSeq", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@deposit_amt", System.Data.SqlDbType.Money, 0, "deposit_amt"),
            new System.Data.SqlClient.SqlParameter("@deposit_id", System.Data.SqlDbType.Int, 0, "deposit_id"),
            new System.Data.SqlClient.SqlParameter("@off_set_days", System.Data.SqlDbType.Int, 0, "off_set_days"),
            new System.Data.SqlClient.SqlParameter("@Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, "Ref_Deposits_Det_ID"),
            new System.Data.SqlClient.SqlParameter("@Origional_ID", System.Data.SqlDbType.Int, 0, "Origional_ID"),
            new System.Data.SqlClient.SqlParameter("@PresaleSeq", System.Data.SqlDbType.Int, 0, "PresaleSeq")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "agreement_id")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@deposit_amt", System.Data.SqlDbType.Money, 0, "deposit_amt"),
            new System.Data.SqlClient.SqlParameter("@deposit_id", System.Data.SqlDbType.Int, 0, "deposit_id"),
            new System.Data.SqlClient.SqlParameter("@off_set_days", System.Data.SqlDbType.Int, 0, "off_set_days"),
            new System.Data.SqlClient.SqlParameter("@Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, "Ref_Deposits_Det_ID"),
            new System.Data.SqlClient.SqlParameter("@Origional_ID", System.Data.SqlDbType.Int, 0, "Origional_ID"),
            new System.Data.SqlClient.SqlParameter("@PresaleSeq", System.Data.SqlDbType.Int, 0, "PresaleSeq"),
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_deposit_amt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "deposit_amt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_deposit_amt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "deposit_amt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_deposit_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "deposit_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_deposit_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "deposit_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_off_set_days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "off_set_days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_off_set_days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "off_set_days", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ref_Deposits_Det_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ref_Deposits_Det_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ref_Deposits_Det_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Origional_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Origional_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Origional_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Origional_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PresaleSeq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PresaleSeq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PresaleSeq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PresaleSeq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // da_lueDepositType
            // 
            this.da_lueDepositType.DeleteCommand = this.sqlDeleteCommand4;
            this.da_lueDepositType.InsertCommand = this.sqlInsertCommand3;
            this.da_lueDepositType.SelectCommand = this.sqlSelectCommand5;
            this.da_lueDepositType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Deposits", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Deposit_ID", "Deposit_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Type", "Type"),
                        new System.Data.Common.DataColumnMapping("Off_Set_Days", "Off_Set_Days")})});
            this.da_lueDepositType.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Deposit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Deposit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Off_Set_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Off_Set_Days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Off_Set_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Off_Set_Days", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Off_Set_Days", System.Data.SqlDbType.Int, 0, "Off_Set_Days")});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT     Deposit_ID, Description, Type, Off_Set_Days\r\nFROM         LD_Deposits\r" +
    "\nORDER BY Description";
            this.sqlSelectCommand5.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Off_Set_Days", System.Data.SqlDbType.Int, 0, "Off_Set_Days"),
            new System.Data.SqlClient.SqlParameter("@Original_Deposit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Deposit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Off_Set_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Off_Set_Days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Off_Set_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Off_Set_Days", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Deposit_ID", System.Data.SqlDbType.Int, 4, "Deposit_ID")});
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT     CUSTOMER_ID, CUSTOMER_CODE, NAME, PURCHASER_TYPE_ID\r\nFROM         CUST" +
    "OMERS\r\nWHERE     (ISNULL(IS_PURCHASER, 0) = 1)";
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlTRConnection;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, "CUSTOMER_CODE"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, "PURCHASER_TYPE_ID")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, "CUSTOMER_CODE"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, "PURCHASER_TYPE_ID"),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // da_purchasers
            // 
            this.da_purchasers.DeleteCommand = this.sqlDeleteCommand3;
            this.da_purchasers.InsertCommand = this.sqlInsertCommand4;
            this.da_purchasers.SelectCommand = this.sqlSelectCommand3;
            this.da_purchasers.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CUSTOMERS", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CUSTOMER_ID", "CUSTOMER_ID"),
                        new System.Data.Common.DataColumnMapping("CUSTOMER_CODE", "CUSTOMER_CODE"),
                        new System.Data.Common.DataColumnMapping("NAME", "NAME"),
                        new System.Data.Common.DataColumnMapping("PURCHASER_TYPE_ID", "PURCHASER_TYPE_ID")})});
            this.da_purchasers.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // dockManager2
            // 
            this.dockManager2.DockingOptions.ShowCloseButton = false;
            this.dockManager2.DockingOptions.ShowMaximizeButton = false;
            this.dockManager2.Form = this;
            this.dockManager2.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.dockPanel2});
            this.dockManager2.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel1;
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dpDiscounts);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("ed1a60ee-2f33-4d8b-8bca-17c35a572c0c");
            this.panelContainer1.Location = new System.Drawing.Point(929, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(360, 678);
            this.panelContainer1.Size = new System.Drawing.Size(360, 678);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dpDiscounts
            // 
            this.dpDiscounts.Controls.Add(this.dockPanel3_Container);
            this.dpDiscounts.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpDiscounts.ID = new System.Guid("837ab652-af59-4be5-a4ce-973e655d178f");
            this.dpDiscounts.Location = new System.Drawing.Point(5, 23);
            this.dpDiscounts.Name = "dpDiscounts";
            this.dpDiscounts.OriginalSize = new System.Drawing.Size(200, 200);
            this.dpDiscounts.Size = new System.Drawing.Size(351, 624);
            this.dpDiscounts.Text = "Discounts";
            this.dpDiscounts.Click += new System.EventHandler(this.dockPanel3_Click);
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.gcDiscounts);
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(351, 624);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.ID = new System.Guid("a21ab94a-0d5f-41f4-b6cb-052b33a2583c");
            this.dockPanel1.Location = new System.Drawing.Point(5, 23);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(351, 624);
            this.dockPanel1.Text = "Deposits";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gcDeposit);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(351, 624);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.ID = new System.Guid("24c9b87d-632d-4a16-b087-3a122fece871");
            this.dockPanel2.Location = new System.Drawing.Point(0, 498);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(929, 180);
            this.dockPanel2.Size = new System.Drawing.Size(929, 180);
            this.dockPanel2.Text = "Lot Levies";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.gcLevies);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(921, 152);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // gcLevies
            // 
            this.gcLevies.DataMember = "Level1_Codes";
            this.gcLevies.DataSource = this.dsLevyDetail;
            this.gcLevies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLevies.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLevies.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLevies.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLevies.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLevies.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLevies.Location = new System.Drawing.Point(0, 0);
            this.gcLevies.MainView = this.gvLevies;
            this.gcLevies.Name = "gcLevies";
            this.gcLevies.Size = new System.Drawing.Size(921, 152);
            this.gcLevies.TabIndex = 5;
            this.gcLevies.UseEmbeddedNavigator = true;
            this.gcLevies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLevies});
            // 
            // dsLevyDetail
            // 
            this.dsLevyDetail.DataSetName = "dsLevyDetail";
            this.dsLevyDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLevies
            // 
            this.gvLevies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.collv1id,
            this.collv2id,
            this.collv3id,
            this.collv4id,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvLevies.GridControl = this.gcLevies;
            this.gvLevies.Name = "gvLevies";
            this.gvLevies.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Levy Description";
            this.gridColumn1.FieldName = "Levy";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // collv1id
            // 
            this.collv1id.Caption = "Level 1";
            this.collv1id.FieldName = "lv1_code";
            this.collv1id.Name = "collv1id";
            this.collv1id.OptionsColumn.AllowEdit = false;
            this.collv1id.Visible = true;
            this.collv1id.VisibleIndex = 1;
            // 
            // collv2id
            // 
            this.collv2id.Caption = "Level 2";
            this.collv2id.FieldName = "lv2_code";
            this.collv2id.Name = "collv2id";
            this.collv2id.OptionsColumn.AllowEdit = false;
            this.collv2id.Visible = true;
            this.collv2id.VisibleIndex = 2;
            // 
            // collv3id
            // 
            this.collv3id.Caption = "Level 3";
            this.collv3id.FieldName = "lv3_code";
            this.collv3id.Name = "collv3id";
            this.collv3id.OptionsColumn.AllowEdit = false;
            this.collv3id.Visible = true;
            this.collv3id.VisibleIndex = 3;
            // 
            // collv4id
            // 
            this.collv4id.Caption = "Level 4";
            this.collv4id.FieldName = "lv4_code";
            this.collv4id.Name = "collv4id";
            this.collv4id.OptionsColumn.AllowEdit = false;
            this.collv4id.Visible = true;
            this.collv4id.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Amount";
            this.gridColumn6.DisplayFormat.FormatString = "n2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Amount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Supplier";
            this.gridColumn7.FieldName = "Supplier";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Levy Type";
            this.gridColumn8.FieldName = "LevyType";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlTRConnection;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 50, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "agreement_id")});
            // 
            // daLevyDetail
            // 
            this.daLevyDetail.SelectCommand = this.sqlSelectCommand4;
            this.daLevyDetail.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level1_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Levy", "Levy"),
                        new System.Data.Common.DataColumnMapping("LevyType", "LevyType"),
                        new System.Data.Common.DataColumnMapping("lv1_code", "lv1_code"),
                        new System.Data.Common.DataColumnMapping("lv2_code", "lv2_code"),
                        new System.Data.Common.DataColumnMapping("lv3_code", "lv3_code"),
                        new System.Data.Common.DataColumnMapping("lv4_code", "lv4_code"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Supplier", "Supplier")})});
            // 
            // gcDiscounts
            // 
            this.gcDiscounts.DataMember = "working_ld_laa_proj_lot_agreement_discounts";
            this.gcDiscounts.DataSource = this.dsDiscountSummary1;
            this.gcDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiscounts.Location = new System.Drawing.Point(0, 0);
            this.gcDiscounts.MainView = this.gvDiscounts;
            this.gcDiscounts.Name = "gcDiscounts";
            this.gcDiscounts.Size = new System.Drawing.Size(351, 624);
            this.gcDiscounts.TabIndex = 0;
            this.gcDiscounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscounts});
            // 
            // gvDiscounts
            // 
            this.gvDiscounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colType,
            this.colValue});
            this.gvDiscounts.GridControl = this.gcDiscounts;
            this.gvDiscounts.Name = "gvDiscounts";
            this.gvDiscounts.OptionsBehavior.Editable = false;
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = resources.GetString("sqlSelectCommand6.CommandText");
            this.sqlSelectCommand6.Connection = this.sqlTRConnection;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "agreement_id")});
            // 
            // daDiscountSummary
            // 
            this.daDiscountSummary.SelectCommand = this.sqlSelectCommand6;
            this.daDiscountSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_laa_proj_lot_agreement_discounts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Type", "Type"),
                        new System.Data.Common.DataColumnMapping("Value", "Value")})});
            // 
            // dsDiscountSummary1
            // 
            this.dsDiscountSummary1.DataSetName = "dsDiscountSummary";
            this.dsDiscountSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCode
            // 
            this.colCode.Caption = "Discount";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // colValue
            // 
            this.colValue.DisplayFormat.FormatString = "N2";
            this.colValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 2;
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.panelContainer1);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1289, 678);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_summary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceBool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchasercode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_purchasers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_purchaserdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_depositsDetail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueDepositType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslueDepositType1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueDepositType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cePostPreSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager2)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dpDiscounts.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLevies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevyDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLevies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountSummary1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.GridControl gcDeposit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeposit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraEditors.DateEdit deAgreementDate;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlDataAdapter da_AgreementDetails;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private ds_summary ds_summary1;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_type;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colpre_sale;
        private DevExpress.XtraGrid.Columns.GridColumn colsell_price;
        private DevExpress.XtraGrid.Columns.GridColumn colgst;
        private DevExpress.XtraGrid.Columns.GridColumn colpst;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSellPrice;
        private System.Data.SqlClient.SqlDataAdapter da_depositsDetail;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_lueDepositType;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private ds_depositsDetail ds_depositsDetail1;
        private ds_lueDepositType ds_lueDepositType1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposit_amt;
        private DevExpress.XtraGrid.Columns.GridColumn coldeposit_id;
        private DevExpress.XtraGrid.Columns.GridColumn coloff_set_days;
        private DevExpress.XtraGrid.Columns.GridColumn colRef_Deposits_Det_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigional_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueDepositType;
        private System.Windows.Forms.BindingSource dslueDepositType1BindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceBool;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.CheckEdit cePostPreSale;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter da_purchasers;
        private ds_purchasers ds_purchasers1;
        private DevExpress.XtraGrid.Columns.GridColumn coldown_payment;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_id1;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colprcl_code;
        private DevExpress.XtraGrid.Columns.GridColumn colprcl_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_Class_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_Class_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_SubClass_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_SubClass_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaserCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaserDesc;
        private System.Windows.Forms.BindingSource bs_purchaserdesc;
        private System.Windows.Forms.BindingSource bs_purchasercode;
        private DevExpress.XtraEditors.SimpleButton btnAgreementDocuments;
        private DevExpress.XtraGrid.Columns.GridColumn colmaster_agreement_num;
        private DevExpress.XtraEditors.SimpleButton btnMastAgreeDoc;
        private DevExpress.XtraBars.Docking.DockManager dockManager2;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gcLevies;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLevies;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn collv1id;
        private DevExpress.XtraGrid.Columns.GridColumn collv2id;
        private DevExpress.XtraGrid.Columns.GridColumn collv3id;
        private DevExpress.XtraGrid.Columns.GridColumn collv4id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter daLevyDetail;
        private dsLevyDetail dsLevyDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPresaleSeq;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dpDiscounts;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraGrid.GridControl gcDiscounts;
        private dsDiscountSummary dsDiscountSummary1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscounts;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlDataAdapter daDiscountSummary;
    }
}
