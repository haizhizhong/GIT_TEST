namespace LD_LotDiscount
{
    partial class ucChanges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChanges));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deDiscountDate = new DevExpress.XtraEditors.DateEdit();
            this.ucAccountingPicker1 = new AccountingPicker.ucAccountingPicker();
            this.gcSelectedAgreements = new DevExpress.XtraGrid.GridControl();
            this.dsSelectedAgreements1 = new LD_LotDiscount.dsSelectedAgreements();
            this.gvSelectedAgreements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproj_lot_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_class_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_class_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrontage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterAgreementNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgreementPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcDiscounts = new DevExpress.XtraGrid.GridControl();
            this.dsDiscountModifications1 = new LD_LotDiscount.dsDiscountModifications();
            this.gvDiscounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_lot_search_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionRequired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLD_DISCOUNTS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLD_Discounts_Code = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_LD_Discounts = new System.Windows.Forms.BindingSource(this.components);
            this.ds_LD_Discounts1 = new LD_LotDiscount.ds_LD_Discounts();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLD_DISCOUNTS_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLD_Discounts_Desc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueDiscountType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDiscountType1 = new LD_LotDiscount.dsDiscountType();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSelectedAgreements = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daDiscountModifications = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.da_LD_Discounts = new System.Data.SqlClient.SqlDataAdapter();
            this.daDiscountType = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDiscountDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDiscountDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelectedAgreements1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountModifications1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLD_Discounts_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_LD_Discounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LD_Discounts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLD_Discounts_Desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueDiscountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deDiscountDate);
            this.panelControl1.Controls.Add(this.ucAccountingPicker1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1286, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(399, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Discount Date";
            // 
            // deDiscountDate
            // 
            this.deDiscountDate.EditValue = null;
            this.deDiscountDate.Location = new System.Drawing.Point(489, 11);
            this.deDiscountDate.Name = "deDiscountDate";
            this.deDiscountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDiscountDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDiscountDate.Size = new System.Drawing.Size(100, 20);
            this.deDiscountDate.TabIndex = 1;
            // 
            // ucAccountingPicker1
            // 
            this.ucAccountingPicker1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ucAccountingPicker1.Appearance.Options.UseBackColor = true;
            this.ucAccountingPicker1.HasEntryDate = false;
            this.ucAccountingPicker1.LLayout = AccountingPicker.ucAccountingPicker.enmLayout.Horizontal;
            this.ucAccountingPicker1.Location = new System.Drawing.Point(20, 5);
            this.ucAccountingPicker1.Name = "ucAccountingPicker1";
            this.ucAccountingPicker1.SelectedPeriod = 0;
            this.ucAccountingPicker1.SelectedYear = 0;
            this.ucAccountingPicker1.Size = new System.Drawing.Size(352, 30);
            this.ucAccountingPicker1.TabIndex = 0;
            this.ucAccountingPicker1.UserName = "";
            // 
            // gcSelectedAgreements
            // 
            this.gcSelectedAgreements.DataMember = "working_ld_LotSearch";
            this.gcSelectedAgreements.DataSource = this.dsSelectedAgreements1;
            this.gcSelectedAgreements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelectedAgreements.Location = new System.Drawing.Point(0, 0);
            this.gcSelectedAgreements.MainView = this.gvSelectedAgreements;
            this.gcSelectedAgreements.Name = "gcSelectedAgreements";
            this.gcSelectedAgreements.Size = new System.Drawing.Size(1286, 377);
            this.gcSelectedAgreements.TabIndex = 1;
            this.gcSelectedAgreements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectedAgreements});
            // 
            // dsSelectedAgreements1
            // 
            this.dsSelectedAgreements1.DataSetName = "dsSelectedAgreements";
            this.dsSelectedAgreements1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSelectedAgreements
            // 
            this.gvSelectedAgreements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colproj_lot_id,
            this.colpri_code,
            this.collot_class_code,
            this.collot_class_desc,
            this.collot_sub_class_code,
            this.collot_sub_class_desc,
            this.colplan_num,
            this.colblock_num,
            this.collot_num,
            this.colfrontage,
            this.colcurrent_price,
            this.collot_status,
            this.collot_sub_status,
            this.colpri_id,
            this.colagreement_num,
            this.colMasterAgreementNum,
            this.colagreement_id,
            this.colPurchaser_Code,
            this.colPurchaser_Name,
            this.colpri_name,
            this.colAgreementPrice,
            this.coltitle_number});
            this.gvSelectedAgreements.GridControl = this.gcSelectedAgreements;
            this.gvSelectedAgreements.Name = "gvSelectedAgreements";
            this.gvSelectedAgreements.OptionsView.ColumnAutoWidth = false;
            this.gvSelectedAgreements.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSelectedAgreements_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.Width = 23;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ReadOnly = true;
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername.Width = 59;
            // 
            // colproj_lot_id
            // 
            this.colproj_lot_id.FieldName = "proj_lot_id";
            this.colproj_lot_id.Name = "colproj_lot_id";
            this.colproj_lot_id.OptionsColumn.ReadOnly = true;
            this.colproj_lot_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colproj_lot_id.Width = 63;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project";
            this.colpri_code.DisplayFormat.FormatString = "n0";
            this.colpri_code.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.ReadOnly = true;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 2;
            this.colpri_code.Width = 112;
            // 
            // collot_class_code
            // 
            this.collot_class_code.Caption = "Class";
            this.collot_class_code.FieldName = "lot_class_code";
            this.collot_class_code.Name = "collot_class_code";
            this.collot_class_code.OptionsColumn.ReadOnly = true;
            this.collot_class_code.Visible = true;
            this.collot_class_code.VisibleIndex = 3;
            this.collot_class_code.Width = 90;
            // 
            // collot_class_desc
            // 
            this.collot_class_desc.Caption = "Class Description";
            this.collot_class_desc.FieldName = "lot_class_desc";
            this.collot_class_desc.Name = "collot_class_desc";
            this.collot_class_desc.OptionsColumn.ReadOnly = true;
            this.collot_class_desc.Width = 196;
            // 
            // collot_sub_class_code
            // 
            this.collot_sub_class_code.Caption = "Sub Class";
            this.collot_sub_class_code.FieldName = "lot_sub_class_code";
            this.collot_sub_class_code.Name = "collot_sub_class_code";
            this.collot_sub_class_code.OptionsColumn.ReadOnly = true;
            this.collot_sub_class_code.Visible = true;
            this.collot_sub_class_code.VisibleIndex = 4;
            this.collot_sub_class_code.Width = 112;
            // 
            // collot_sub_class_desc
            // 
            this.collot_sub_class_desc.Caption = "Sub Class Description";
            this.collot_sub_class_desc.FieldName = "lot_sub_class_desc";
            this.collot_sub_class_desc.Name = "collot_sub_class_desc";
            this.collot_sub_class_desc.OptionsColumn.ReadOnly = true;
            this.collot_sub_class_desc.Width = 218;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.ReadOnly = true;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 5;
            this.colplan_num.Width = 95;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.ReadOnly = true;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 6;
            this.colblock_num.Width = 82;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.ReadOnly = true;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 7;
            this.collot_num.Width = 93;
            // 
            // colfrontage
            // 
            this.colfrontage.Caption = "Frontage";
            this.colfrontage.FieldName = "frontage";
            this.colfrontage.Name = "colfrontage";
            this.colfrontage.OptionsColumn.ReadOnly = true;
            this.colfrontage.Visible = true;
            this.colfrontage.VisibleIndex = 8;
            this.colfrontage.Width = 120;
            // 
            // colcurrent_price
            // 
            this.colcurrent_price.Caption = "Current Price";
            this.colcurrent_price.DisplayFormat.FormatString = "N2";
            this.colcurrent_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcurrent_price.FieldName = "current_price";
            this.colcurrent_price.Name = "colcurrent_price";
            this.colcurrent_price.OptionsColumn.AllowEdit = false;
            this.colcurrent_price.OptionsColumn.ReadOnly = true;
            this.colcurrent_price.Visible = true;
            this.colcurrent_price.VisibleIndex = 9;
            this.colcurrent_price.Width = 135;
            // 
            // collot_status
            // 
            this.collot_status.Caption = "Lot Status";
            this.collot_status.FieldName = "lot_status";
            this.collot_status.Name = "collot_status";
            this.collot_status.OptionsColumn.ReadOnly = true;
            this.collot_status.Visible = true;
            this.collot_status.VisibleIndex = 10;
            this.collot_status.Width = 71;
            // 
            // collot_sub_status
            // 
            this.collot_sub_status.Caption = "Lot Sub Status";
            this.collot_sub_status.FieldName = "lot_sub_status";
            this.collot_sub_status.Name = "collot_sub_status";
            this.collot_sub_status.OptionsColumn.ReadOnly = true;
            this.collot_sub_status.Visible = true;
            this.collot_sub_status.VisibleIndex = 11;
            this.collot_sub_status.Width = 92;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ReadOnly = true;
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colpri_id.Width = 38;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.ReadOnly = true;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 0;
            this.colagreement_num.Width = 86;
            // 
            // colMasterAgreementNum
            // 
            this.colMasterAgreementNum.Caption = "Master Agreement #";
            this.colMasterAgreementNum.FieldName = "MasterAgreementNum";
            this.colMasterAgreementNum.Name = "colMasterAgreementNum";
            this.colMasterAgreementNum.OptionsColumn.ReadOnly = true;
            this.colMasterAgreementNum.Visible = true;
            this.colMasterAgreementNum.VisibleIndex = 1;
            this.colMasterAgreementNum.Width = 122;
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ReadOnly = true;
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colagreement_id.Width = 78;
            // 
            // colPurchaser_Code
            // 
            this.colPurchaser_Code.Caption = "Purchaser Code";
            this.colPurchaser_Code.FieldName = "Purchaser_Code";
            this.colPurchaser_Code.Name = "colPurchaser_Code";
            this.colPurchaser_Code.OptionsColumn.ReadOnly = true;
            this.colPurchaser_Code.Width = 98;
            // 
            // colPurchaser_Name
            // 
            this.colPurchaser_Name.Caption = "Purchaser Name";
            this.colPurchaser_Name.FieldName = "Purchaser_Name";
            this.colPurchaser_Name.Name = "colPurchaser_Name";
            this.colPurchaser_Name.OptionsColumn.ReadOnly = true;
            this.colPurchaser_Name.Width = 153;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Description";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.OptionsColumn.ReadOnly = true;
            this.colpri_name.Width = 183;
            // 
            // colAgreementPrice
            // 
            this.colAgreementPrice.DisplayFormat.FormatString = "N2";
            this.colAgreementPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAgreementPrice.FieldName = "AgreementPrice";
            this.colAgreementPrice.Name = "colAgreementPrice";
            this.colAgreementPrice.OptionsColumn.ReadOnly = true;
            this.colAgreementPrice.OptionsColumn.ShowInCustomizationForm = false;
            this.colAgreementPrice.Width = 115;
            // 
            // coltitle_number
            // 
            this.coltitle_number.Caption = "Title";
            this.coltitle_number.FieldName = "title_number";
            this.coltitle_number.Name = "coltitle_number";
            this.coltitle_number.OptionsColumn.AllowEdit = false;
            this.coltitle_number.OptionsColumn.ReadOnly = true;
            this.coltitle_number.Visible = true;
            this.coltitle_number.VisibleIndex = 12;
            this.coltitle_number.Width = 151;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 38);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcSelectedAgreements);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1286, 663);
            this.splitContainerControl1.SplitterPosition = 377;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcDiscounts
            // 
            this.gcDiscounts.DataMember = "working_ld_discounts";
            this.gcDiscounts.DataSource = this.dsDiscountModifications1;
            this.gcDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiscounts.Location = new System.Drawing.Point(2, 20);
            this.gcDiscounts.MainView = this.gvDiscounts;
            this.gcDiscounts.Name = "gcDiscounts";
            this.gcDiscounts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueLD_Discounts_Code,
            this.ri_lueLD_Discounts_Desc,
            this.ri_lueDiscountType,
            this.riteNumaric2});
            this.gcDiscounts.Size = new System.Drawing.Size(1282, 259);
            this.gcDiscounts.TabIndex = 0;
            this.gcDiscounts.UseEmbeddedNavigator = true;
            this.gcDiscounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscounts});
            // 
            // dsDiscountModifications1
            // 
            this.dsDiscountModifications1.DataSetName = "dsDiscountModifications";
            this.dsDiscountModifications1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDiscounts
            // 
            this.gvDiscounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colusername1,
            this.colworking_ld_lot_search_id,
            this.colActionRequired,
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID,
            this.colLD_DISCOUNTS_ID,
            this.colAmount,
            this.colSelected,
            this.colLD_DISCOUNTS_ID1,
            this.colType,
            this.colValue});
            this.gvDiscounts.GridControl = this.gcDiscounts;
            this.gvDiscounts.Name = "gvDiscounts";
            this.gvDiscounts.OptionsView.ColumnAutoWidth = false;
            this.gvDiscounts.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDiscounts_InitNewRow);
            this.gvDiscounts.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDiscounts_CellValueChanged);
            this.gvDiscounts.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvDiscounts_InvalidRowException);
            this.gvDiscounts.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDiscounts_ValidateRow);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.ShowInCustomizationForm = false;
            this.colID1.Width = 140;
            // 
            // colusername1
            // 
            this.colusername1.FieldName = "username";
            this.colusername1.Name = "colusername1";
            this.colusername1.OptionsColumn.AllowEdit = false;
            this.colusername1.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername1.Width = 140;
            // 
            // colworking_ld_lot_search_id
            // 
            this.colworking_ld_lot_search_id.FieldName = "working_ld_lot_search_id";
            this.colworking_ld_lot_search_id.Name = "colworking_ld_lot_search_id";
            this.colworking_ld_lot_search_id.OptionsColumn.AllowEdit = false;
            this.colworking_ld_lot_search_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colworking_ld_lot_search_id.Width = 140;
            // 
            // colActionRequired
            // 
            this.colActionRequired.FieldName = "ActionRequired";
            this.colActionRequired.Name = "colActionRequired";
            this.colActionRequired.OptionsColumn.AllowEdit = false;
            this.colActionRequired.OptionsColumn.ShowInCustomizationForm = false;
            this.colActionRequired.Width = 140;
            // 
            // colPROJ_LOT_AGREEMENT_DISCOUNTS_ID
            // 
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID.FieldName = "PROJ_LOT_AGREEMENT_DISCOUNTS_ID";
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID.Name = "colPROJ_LOT_AGREEMENT_DISCOUNTS_ID";
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID.OptionsColumn.AllowEdit = false;
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID.OptionsColumn.ShowInCustomizationForm = false;
            this.colPROJ_LOT_AGREEMENT_DISCOUNTS_ID.Width = 138;
            // 
            // colLD_DISCOUNTS_ID
            // 
            this.colLD_DISCOUNTS_ID.Caption = "Code";
            this.colLD_DISCOUNTS_ID.ColumnEdit = this.ri_lueLD_Discounts_Code;
            this.colLD_DISCOUNTS_ID.FieldName = "LD_DISCOUNTS_ID";
            this.colLD_DISCOUNTS_ID.Name = "colLD_DISCOUNTS_ID";
            this.colLD_DISCOUNTS_ID.Visible = true;
            this.colLD_DISCOUNTS_ID.VisibleIndex = 0;
            this.colLD_DISCOUNTS_ID.Width = 162;
            // 
            // ri_lueLD_Discounts_Code
            // 
            this.ri_lueLD_Discounts_Code.AutoHeight = false;
            this.ri_lueLD_Discounts_Code.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLD_Discounts_Code.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LD_Discounts_ID", "LD_Discounts_ID", 104, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RevenueAccount", "Revenue Account", 95, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LiabilityAccount", "Liability Account", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 36, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MgmtFeeApplicable", "Mgmt Fee Applicable", 108, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLD_Discounts_Code.DataSource = this.bs_LD_Discounts;
            this.ri_lueLD_Discounts_Code.DisplayMember = "Code";
            this.ri_lueLD_Discounts_Code.Name = "ri_lueLD_Discounts_Code";
            this.ri_lueLD_Discounts_Code.NullText = "";
            this.ri_lueLD_Discounts_Code.ValueMember = "LD_Discounts_ID";
            // 
            // bs_LD_Discounts
            // 
            this.bs_LD_Discounts.DataMember = "LD_Discounts";
            this.bs_LD_Discounts.DataSource = this.ds_LD_Discounts1;
            // 
            // ds_LD_Discounts1
            // 
            this.ds_LD_Discounts1.DataSetName = "ds_LD_Discounts";
            this.ds_LD_Discounts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colAmount
            // 
            this.colAmount.ColumnEdit = this.riteNumaric2;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 145;
            // 
            // riteNumaric2
            // 
            this.riteNumaric2.AutoHeight = false;
            this.riteNumaric2.Mask.EditMask = "n2";
            this.riteNumaric2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumaric2.Name = "riteNumaric2";
            // 
            // colSelected
            // 
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 5;
            this.colSelected.Width = 78;
            // 
            // colLD_DISCOUNTS_ID1
            // 
            this.colLD_DISCOUNTS_ID1.Caption = "Description";
            this.colLD_DISCOUNTS_ID1.ColumnEdit = this.ri_lueLD_Discounts_Desc;
            this.colLD_DISCOUNTS_ID1.FieldName = "LD_DISCOUNTS_ID";
            this.colLD_DISCOUNTS_ID1.Name = "colLD_DISCOUNTS_ID1";
            this.colLD_DISCOUNTS_ID1.Visible = true;
            this.colLD_DISCOUNTS_ID1.VisibleIndex = 1;
            this.colLD_DISCOUNTS_ID1.Width = 245;
            // 
            // ri_lueLD_Discounts_Desc
            // 
            this.ri_lueLD_Discounts_Desc.AutoHeight = false;
            this.ri_lueLD_Discounts_Desc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLD_Discounts_Desc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LD_Discounts_ID", "LD_Discounts_ID", 104, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RevenueAccount", "Revenue Account", 95, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LiabilityAccount", "Liability Account", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 36, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MgmtFeeApplicable", "Mgmt Fee Applicable", 108, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLD_Discounts_Desc.DataSource = this.bs_LD_Discounts;
            this.ri_lueLD_Discounts_Desc.DisplayMember = "Description";
            this.ri_lueLD_Discounts_Desc.Name = "ri_lueLD_Discounts_Desc";
            this.ri_lueLD_Discounts_Desc.NullText = "";
            this.ri_lueLD_Discounts_Desc.ValueMember = "LD_Discounts_ID";
            // 
            // colType
            // 
            this.colType.ColumnEdit = this.ri_lueDiscountType;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 141;
            // 
            // ri_lueDiscountType
            // 
            this.ri_lueDiscountType.AutoHeight = false;
            this.ri_lueDiscountType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueDiscountType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 36, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueDiscountType.DataSource = this.tableBindingSource;
            this.ri_lueDiscountType.DisplayMember = "Description";
            this.ri_lueDiscountType.Name = "ri_lueDiscountType";
            this.ri_lueDiscountType.NullText = "";
            this.ri_lueDiscountType.ValueMember = "Value";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dsDiscountType1;
            // 
            // dsDiscountType1
            // 
            this.dsDiscountType1.DataSetName = "dsDiscountType";
            this.dsDiscountType1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colValue
            // 
            this.colValue.ColumnEdit = this.riteNumaric2;
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 3;
            this.colValue.Width = 168;
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
            this.sqlTRConnection.ConnectionString = "Data Source=DEVSQL2008R2;Initial Catalog=TR_V11_GC;User ID=hmsqlsa;Password=hmsql" +
    "sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_code", System.Data.SqlDbType.VarChar, 0, "lot_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_class_desc"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_desc"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@frontage", System.Data.SqlDbType.Money, 0, "frontage"),
            new System.Data.SqlClient.SqlParameter("@current_price", System.Data.SqlDbType.Money, 0, "current_price"),
            new System.Data.SqlClient.SqlParameter("@lot_status", System.Data.SqlDbType.VarChar, 0, "lot_status"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_status", System.Data.SqlDbType.VarChar, 0, "lot_sub_status"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@AgreementPrice", System.Data.SqlDbType.Money, 0, "AgreementPrice"),
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_code", System.Data.SqlDbType.VarChar, 0, "lot_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_class_desc"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_desc"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@frontage", System.Data.SqlDbType.Money, 0, "frontage"),
            new System.Data.SqlClient.SqlParameter("@current_price", System.Data.SqlDbType.Money, 0, "current_price"),
            new System.Data.SqlClient.SqlParameter("@lot_status", System.Data.SqlDbType.VarChar, 0, "lot_status"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_status", System.Data.SqlDbType.VarChar, 0, "lot_sub_status"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@AgreementPrice", System.Data.SqlDbType.Money, 0, "AgreementPrice"),
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_frontage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_frontage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_current_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_current_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AgreementPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AgreementPrice", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AgreementPrice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AgreementPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_frontage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_frontage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_current_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_current_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AgreementPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AgreementPrice", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AgreementPrice", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AgreementPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null)});
            // 
            // daSelectedAgreements
            // 
            this.daSelectedAgreements.DeleteCommand = this.sqlDeleteCommand1;
            this.daSelectedAgreements.InsertCommand = this.sqlInsertCommand1;
            this.daSelectedAgreements.SelectCommand = this.sqlSelectCommand1;
            this.daSelectedAgreements.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_LotSearch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_code", "lot_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_desc", "lot_class_desc"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_code", "lot_sub_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_desc", "lot_sub_class_desc"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("frontage", "frontage"),
                        new System.Data.Common.DataColumnMapping("current_price", "current_price"),
                        new System.Data.Common.DataColumnMapping("lot_status", "lot_status"),
                        new System.Data.Common.DataColumnMapping("lot_sub_status", "lot_sub_status"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("MasterAgreementNum", "MasterAgreementNum"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Code", "Purchaser_Code"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Name", "Purchaser_Name"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("AgreementPrice", "AgreementPrice"),
                        new System.Data.Common.DataColumnMapping("title_number", "title_number")})});
            this.daSelectedAgreements.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lot_search_id", System.Data.SqlDbType.Int, 4, "working_ld_lot_search_id")});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, "working_ld_lot_search_id"),
            new System.Data.SqlClient.SqlParameter("@ActionRequired", System.Data.SqlDbType.VarChar, 0, "ActionRequired"),
            new System.Data.SqlClient.SqlParameter("@PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, "PROJ_LOT_AGREEMENT_DISCOUNTS_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, "LD_DISCOUNTS_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Amount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, "working_ld_lot_search_id"),
            new System.Data.SqlClient.SqlParameter("@ActionRequired", System.Data.SqlDbType.VarChar, 0, "ActionRequired"),
            new System.Data.SqlClient.SqlParameter("@PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, "PROJ_LOT_AGREEMENT_DISCOUNTS_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, "LD_DISCOUNTS_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Amount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_lot_search_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lot_search_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActionRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActionRequired", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActionRequired", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActionRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_DISCOUNTS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_DISCOUNTS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_lot_search_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lot_search_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lot_search_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActionRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActionRequired", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActionRequired", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActionRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PROJ_LOT_AGREEMENT_DISCOUNTS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_DISCOUNTS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_DISCOUNTS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_DISCOUNTS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Original, null)});
            // 
            // daDiscountModifications
            // 
            this.daDiscountModifications.DeleteCommand = this.sqlDeleteCommand2;
            this.daDiscountModifications.InsertCommand = this.sqlInsertCommand2;
            this.daDiscountModifications.SelectCommand = this.sqlSelectCommand2;
            this.daDiscountModifications.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_discounts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("working_ld_lot_search_id", "working_ld_lot_search_id"),
                        new System.Data.Common.DataColumnMapping("ActionRequired", "ActionRequired"),
                        new System.Data.Common.DataColumnMapping("PROJ_LOT_AGREEMENT_DISCOUNTS_ID", "PROJ_LOT_AGREEMENT_DISCOUNTS_ID"),
                        new System.Data.Common.DataColumnMapping("LD_DISCOUNTS_ID", "LD_DISCOUNTS_ID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected"),
                        new System.Data.Common.DataColumnMapping("Type", "Type"),
                        new System.Data.Common.DataColumnMapping("Value", "Value")})});
            this.daDiscountModifications.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        LD_Discounts_ID, Code, Description, RevenueAccount, LiabilityAccoun" +
    "t, Type, Value, MgmtFeeApplicable\r\nFROM            LD_Discounts\r\nORDER BY Code";
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@RevenueAccount", System.Data.SqlDbType.VarChar, 0, "RevenueAccount"),
            new System.Data.SqlClient.SqlParameter("@LiabilityAccount", System.Data.SqlDbType.VarChar, 0, "LiabilityAccount"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MgmtFeeApplicable", System.Data.SqlDbType.Bit, 0, "MgmtFeeApplicable")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@RevenueAccount", System.Data.SqlDbType.VarChar, 0, "RevenueAccount"),
            new System.Data.SqlClient.SqlParameter("@LiabilityAccount", System.Data.SqlDbType.VarChar, 0, "LiabilityAccount"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 0, "Type"),
            new System.Data.SqlClient.SqlParameter("@Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@MgmtFeeApplicable", System.Data.SqlDbType.Bit, 0, "MgmtFeeApplicable"),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Discounts_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Discounts_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevenueAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevenueAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevenueAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevenueAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LiabilityAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LiabilityAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LiabilityAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LiabilityAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MgmtFeeApplicable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MgmtFeeApplicable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MgmtFeeApplicable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MgmtFeeApplicable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@LD_Discounts_ID", System.Data.SqlDbType.Int, 4, "LD_Discounts_ID")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_LD_Discounts_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Discounts_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RevenueAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RevenueAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RevenueAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RevenueAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LiabilityAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LiabilityAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LiabilityAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LiabilityAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Value", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Value", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Value", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Value", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MgmtFeeApplicable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MgmtFeeApplicable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MgmtFeeApplicable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MgmtFeeApplicable", System.Data.DataRowVersion.Original, null)});
            // 
            // da_LD_Discounts
            // 
            this.da_LD_Discounts.DeleteCommand = this.sqlDeleteCommand3;
            this.da_LD_Discounts.InsertCommand = this.sqlInsertCommand3;
            this.da_LD_Discounts.SelectCommand = this.sqlSelectCommand3;
            this.da_LD_Discounts.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Discounts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LD_Discounts_ID", "LD_Discounts_ID"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("RevenueAccount", "RevenueAccount"),
                        new System.Data.Common.DataColumnMapping("LiabilityAccount", "LiabilityAccount"),
                        new System.Data.Common.DataColumnMapping("Type", "Type"),
                        new System.Data.Common.DataColumnMapping("Value", "Value"),
                        new System.Data.Common.DataColumnMapping("MgmtFeeApplicable", "MgmtFeeApplicable")})});
            this.da_LD_Discounts.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // daDiscountType
            // 
            this.daDiscountType.SelectCommand = this.sqlSelectCommand12;
            this.daDiscountType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Value", "Value")})});
            // 
            // sqlSelectCommand12
            // 
            this.sqlSelectCommand12.CommandText = "select \'Amount\' [Description], \'A\' [Value]\r\nunion all\r\nselect \'Percent\' [Descript" +
    "ion], \'P\' [Value]";
            this.sqlSelectCommand12.Connection = this.sqlTRConnection;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcDiscounts);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1286, 281);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Discounts";
            // 
            // ucChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucChanges";
            this.Size = new System.Drawing.Size(1286, 701);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDiscountDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDiscountDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectedAgreements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelectedAgreements1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedAgreements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountModifications1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLD_Discounts_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_LD_Discounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LD_Discounts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLD_Discounts_Desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueDiscountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiscountType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcSelectedAgreements;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelectedAgreements;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcDiscounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscounts;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSelectedAgreements;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private dsSelectedAgreements dsSelectedAgreements1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colproj_lot_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_class_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_class_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colfrontage;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_price;
        private DevExpress.XtraGrid.Columns.GridColumn collot_status;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_status;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterAgreementNum;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colAgreementPrice;
        private dsDiscountModifications dsDiscountModifications1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername1;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_lot_search_id;
        private DevExpress.XtraGrid.Columns.GridColumn colActionRequired;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJ_LOT_AGREEMENT_DISCOUNTS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_DISCOUNTS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daDiscountModifications;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLD_Discounts_Code;
        private System.Windows.Forms.BindingSource bs_LD_Discounts;
        private ds_LD_Discounts ds_LD_Discounts1;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_DISCOUNTS_ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLD_Discounts_Desc;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter da_LD_Discounts;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        public AccountingPicker.ucAccountingPicker ucAccountingPicker1;
        public DevExpress.XtraEditors.DateEdit deDiscountDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumaric2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueDiscountType;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dsDiscountType dsDiscountType1;
        private System.Data.SqlClient.SqlDataAdapter daDiscountType;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand12;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle_number;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
