namespace LD_LotPayoutAssistant
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSummary));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpnlSubledgerPreview = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.ds_selectedLots1 = new LD_LotPayoutAssistant.ds_selectedLots();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselected = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.coltitle_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhold_expiry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_legal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparcel_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshape = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_prefix_dir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_suffix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_suffix_dir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterAgreementNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWordMerged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_ceReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colWordMergeButton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBeWordMerge = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lueSolicitor = new DevExpress.XtraEditors.LookUpEdit();
            this.bsSolicitor = new System.Windows.Forms.BindingSource(this.components);
            this.dsSolicitor1 = new LD_LotPayoutAssistant.dsSolicitor();
            this.btnCashToClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnReporting = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.tePeriod = new DevExpress.XtraEditors.TextEdit();
            this.teYear = new DevExpress.XtraEditors.TextEdit();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.da_selectedLots = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daSolicitor = new System.Data.SqlClient.SqlDataAdapter();
            this.lblInterimMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpnlSubledgerPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBeWordMerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSolicitor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSolicitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).BeginInit();
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
            this.dpnlSubledgerPreview.ID = new System.Guid("edbc35df-03ce-444d-9fef-834d081f128a");
            this.dpnlSubledgerPreview.Location = new System.Drawing.Point(0, 474);
            this.dpnlSubledgerPreview.Name = "dpnlSubledgerPreview";
            this.dpnlSubledgerPreview.OriginalSize = new System.Drawing.Size(1330, 278);
            this.dpnlSubledgerPreview.Size = new System.Drawing.Size(1330, 278);
            this.dpnlSubledgerPreview.Text = "Subledger Preview";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1322, 250);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gcSummary
            // 
            this.gcSummary.DataMember = "working_ld_LotSearch";
            this.gcSummary.DataSource = this.ds_selectedLots1;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 34);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riBeWordMerge,
            this.ri_ceReadOnly});
            this.gcSummary.Size = new System.Drawing.Size(1330, 440);
            this.gcSummary.TabIndex = 7;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // ds_selectedLots1
            // 
            this.ds_selectedLots1.DataSetName = "ds_selectedLots";
            this.ds_selectedLots1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colselected,
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
            this.coltitle_number,
            this.coladdress_1,
            this.coladdress_2,
            this.colcity,
            this.colhold_expiry,
            this.collong_legal,
            this.colparcel_number,
            this.colpostal,
            this.colprov,
            this.colshape,
            this.colma_name,
            this.colma_number,
            this.colma_prefix_dir,
            this.colma_suffix,
            this.colma_suffix_dir,
            this.colpri_id,
            this.colagreement_num,
            this.colMasterAgreementNum,
            this.colPurchaser_Code,
            this.colPurchaser_Name,
            this.colpri_name,
            this.colagreement_id,
            this.colWordMerged,
            this.colWordMergeButton});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colma_suffix, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.Width = 23;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername.Width = 59;
            // 
            // colselected
            // 
            this.colselected.FieldName = "selected";
            this.colselected.Name = "colselected";
            this.colselected.OptionsColumn.AllowEdit = false;
            this.colselected.OptionsColumn.ShowInCustomizationForm = false;
            this.colselected.Width = 52;
            // 
            // colproj_lot_id
            // 
            this.colproj_lot_id.FieldName = "proj_lot_id";
            this.colproj_lot_id.Name = "colproj_lot_id";
            this.colproj_lot_id.OptionsColumn.AllowEdit = false;
            this.colproj_lot_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colproj_lot_id.Width = 63;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 2;
            this.colpri_code.Width = 76;
            // 
            // collot_class_code
            // 
            this.collot_class_code.Caption = "Class";
            this.collot_class_code.FieldName = "lot_class_code";
            this.collot_class_code.Name = "collot_class_code";
            this.collot_class_code.OptionsColumn.AllowEdit = false;
            this.collot_class_code.Visible = true;
            this.collot_class_code.VisibleIndex = 4;
            this.collot_class_code.Width = 64;
            // 
            // collot_class_desc
            // 
            this.collot_class_desc.Caption = "Class Description";
            this.collot_class_desc.FieldName = "lot_class_desc";
            this.collot_class_desc.Name = "collot_class_desc";
            this.collot_class_desc.OptionsColumn.AllowEdit = false;
            this.collot_class_desc.Width = 103;
            // 
            // collot_sub_class_code
            // 
            this.collot_sub_class_code.Caption = "Sub Class";
            this.collot_sub_class_code.FieldName = "lot_sub_class_code";
            this.collot_sub_class_code.Name = "collot_sub_class_code";
            this.collot_sub_class_code.OptionsColumn.AllowEdit = false;
            this.collot_sub_class_code.Visible = true;
            this.collot_sub_class_code.VisibleIndex = 5;
            this.collot_sub_class_code.Width = 68;
            // 
            // collot_sub_class_desc
            // 
            this.collot_sub_class_desc.Caption = "Sub Class Description";
            this.collot_sub_class_desc.FieldName = "lot_sub_class_desc";
            this.collot_sub_class_desc.Name = "collot_sub_class_desc";
            this.collot_sub_class_desc.OptionsColumn.AllowEdit = false;
            this.collot_sub_class_desc.Width = 124;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 6;
            this.colplan_num.Width = 65;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 7;
            this.colblock_num.Width = 73;
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
            // colfrontage
            // 
            this.colfrontage.Caption = "Frontage";
            this.colfrontage.DisplayFormat.FormatString = "n2";
            this.colfrontage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colfrontage.FieldName = "frontage";
            this.colfrontage.Name = "colfrontage";
            this.colfrontage.OptionsColumn.AllowEdit = false;
            this.colfrontage.Visible = true;
            this.colfrontage.VisibleIndex = 9;
            this.colfrontage.Width = 66;
            // 
            // colcurrent_price
            // 
            this.colcurrent_price.Caption = "Current Price";
            this.colcurrent_price.DisplayFormat.FormatString = "n2";
            this.colcurrent_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcurrent_price.FieldName = "current_price";
            this.colcurrent_price.Name = "colcurrent_price";
            this.colcurrent_price.OptionsColumn.AllowEdit = false;
            this.colcurrent_price.Visible = true;
            this.colcurrent_price.VisibleIndex = 10;
            this.colcurrent_price.Width = 85;
            // 
            // collot_status
            // 
            this.collot_status.Caption = "Status";
            this.collot_status.FieldName = "lot_status";
            this.collot_status.Name = "collot_status";
            this.collot_status.OptionsColumn.AllowEdit = false;
            this.collot_status.Visible = true;
            this.collot_status.VisibleIndex = 11;
            this.collot_status.Width = 80;
            // 
            // collot_sub_status
            // 
            this.collot_sub_status.Caption = "Sub Status";
            this.collot_sub_status.FieldName = "lot_sub_status";
            this.collot_sub_status.Name = "collot_sub_status";
            this.collot_sub_status.OptionsColumn.AllowEdit = false;
            this.collot_sub_status.Visible = true;
            this.collot_sub_status.VisibleIndex = 12;
            this.collot_sub_status.Width = 93;
            // 
            // coltitle_number
            // 
            this.coltitle_number.Caption = "Title";
            this.coltitle_number.FieldName = "title_number";
            this.coltitle_number.Name = "coltitle_number";
            this.coltitle_number.OptionsColumn.AllowEdit = false;
            this.coltitle_number.Visible = true;
            this.coltitle_number.VisibleIndex = 13;
            this.coltitle_number.Width = 51;
            // 
            // coladdress_1
            // 
            this.coladdress_1.Caption = "Address 1";
            this.coladdress_1.FieldName = "address_1";
            this.coladdress_1.Name = "coladdress_1";
            this.coladdress_1.OptionsColumn.AllowEdit = false;
            this.coladdress_1.Width = 70;
            // 
            // coladdress_2
            // 
            this.coladdress_2.Caption = "Address 2";
            this.coladdress_2.FieldName = "address_2";
            this.coladdress_2.Name = "coladdress_2";
            this.coladdress_2.OptionsColumn.AllowEdit = false;
            this.coladdress_2.Width = 70;
            // 
            // colcity
            // 
            this.colcity.Caption = "City";
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.OptionsColumn.AllowEdit = false;
            this.colcity.Width = 41;
            // 
            // colhold_expiry
            // 
            this.colhold_expiry.Caption = "Hold Expiry";
            this.colhold_expiry.FieldName = "hold_expiry";
            this.colhold_expiry.Name = "colhold_expiry";
            this.colhold_expiry.OptionsColumn.AllowEdit = false;
            this.colhold_expiry.Width = 76;
            // 
            // collong_legal
            // 
            this.collong_legal.Caption = "Long Legal";
            this.collong_legal.FieldName = "long_legal";
            this.collong_legal.Name = "collong_legal";
            this.collong_legal.OptionsColumn.AllowEdit = false;
            this.collong_legal.Width = 73;
            // 
            // colparcel_number
            // 
            this.colparcel_number.Caption = "Parcel";
            this.colparcel_number.FieldName = "parcel_number";
            this.colparcel_number.Name = "colparcel_number";
            this.colparcel_number.OptionsColumn.AllowEdit = false;
            this.colparcel_number.Width = 51;
            // 
            // colpostal
            // 
            this.colpostal.Caption = "Postal";
            this.colpostal.FieldName = "postal";
            this.colpostal.Name = "colpostal";
            this.colpostal.OptionsColumn.AllowEdit = false;
            this.colpostal.Width = 51;
            // 
            // colprov
            // 
            this.colprov.Caption = "Province";
            this.colprov.FieldName = "prov";
            this.colprov.Name = "colprov";
            this.colprov.OptionsColumn.AllowEdit = false;
            this.colprov.Width = 63;
            // 
            // colshape
            // 
            this.colshape.Caption = "Shape";
            this.colshape.FieldName = "shape";
            this.colshape.Name = "colshape";
            this.colshape.OptionsColumn.AllowEdit = false;
            this.colshape.Width = 52;
            // 
            // colma_name
            // 
            this.colma_name.Caption = "Street Name";
            this.colma_name.FieldName = "ma_name";
            this.colma_name.Name = "colma_name";
            this.colma_name.OptionsColumn.AllowEdit = false;
            this.colma_name.Width = 82;
            // 
            // colma_number
            // 
            this.colma_number.Caption = "Street Number";
            this.colma_number.FieldName = "ma_number";
            this.colma_number.Name = "colma_number";
            this.colma_number.OptionsColumn.AllowEdit = false;
            this.colma_number.Width = 92;
            // 
            // colma_prefix_dir
            // 
            this.colma_prefix_dir.Caption = "Street Prefix Direction";
            this.colma_prefix_dir.FieldName = "ma_prefix_dir";
            this.colma_prefix_dir.Name = "colma_prefix_dir";
            this.colma_prefix_dir.OptionsColumn.AllowEdit = false;
            this.colma_prefix_dir.Width = 128;
            // 
            // colma_suffix
            // 
            this.colma_suffix.Caption = "Street Suffix";
            this.colma_suffix.FieldName = "ma_suffix";
            this.colma_suffix.Name = "colma_suffix";
            this.colma_suffix.OptionsColumn.AllowEdit = false;
            this.colma_suffix.Width = 83;
            // 
            // colma_suffix_dir
            // 
            this.colma_suffix_dir.Caption = "Street Suffix Direction";
            this.colma_suffix_dir.FieldName = "ma_suffix_dir";
            this.colma_suffix_dir.Name = "colma_suffix_dir";
            this.colma_suffix_dir.OptionsColumn.AllowEdit = false;
            this.colma_suffix_dir.Width = 128;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.AllowEdit = false;
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colpri_id.Width = 38;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.AllowEdit = false;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 0;
            this.colagreement_num.Width = 86;
            // 
            // colMasterAgreementNum
            // 
            this.colMasterAgreementNum.Caption = "Master Agreement #";
            this.colMasterAgreementNum.FieldName = "MasterAgreementNum";
            this.colMasterAgreementNum.Name = "colMasterAgreementNum";
            this.colMasterAgreementNum.OptionsColumn.AllowEdit = false;
            this.colMasterAgreementNum.Visible = true;
            this.colMasterAgreementNum.VisibleIndex = 1;
            this.colMasterAgreementNum.Width = 122;
            // 
            // colPurchaser_Code
            // 
            this.colPurchaser_Code.Caption = "Purchaser Code";
            this.colPurchaser_Code.FieldName = "Purchaser_Code";
            this.colPurchaser_Code.Name = "colPurchaser_Code";
            // 
            // colPurchaser_Name
            // 
            this.colPurchaser_Name.Caption = "Purchaser Name";
            this.colPurchaser_Name.FieldName = "Purchaser_Name";
            this.colPurchaser_Name.Name = "colPurchaser_Name";
            this.colPurchaser_Name.Visible = true;
            this.colPurchaser_Name.VisibleIndex = 3;
            this.colPurchaser_Name.Width = 133;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colWordMerged
            // 
            this.colWordMerged.ColumnEdit = this.ri_ceReadOnly;
            this.colWordMerged.FieldName = "WordMerged";
            this.colWordMerged.Name = "colWordMerged";
            this.colWordMerged.Visible = true;
            this.colWordMerged.VisibleIndex = 15;
            this.colWordMerged.Width = 93;
            // 
            // ri_ceReadOnly
            // 
            this.ri_ceReadOnly.AutoHeight = false;
            this.ri_ceReadOnly.Name = "ri_ceReadOnly";
            this.ri_ceReadOnly.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ri_ceReadOnly.ReadOnly = true;
            // 
            // colWordMergeButton
            // 
            this.colWordMergeButton.Caption = "Documents";
            this.colWordMergeButton.ColumnEdit = this.riBeWordMerge;
            this.colWordMergeButton.Name = "colWordMergeButton";
            this.colWordMergeButton.Visible = true;
            this.colWordMergeButton.VisibleIndex = 14;
            // 
            // riBeWordMerge
            // 
            this.riBeWordMerge.AutoHeight = false;
            this.riBeWordMerge.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Word Merge", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false)});
            this.riBeWordMerge.Name = "riBeWordMerge";
            this.riBeWordMerge.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBeWordMerge.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riBeWordMerge_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblInterimMessage);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lueSolicitor);
            this.panelControl1.Controls.Add(this.btnCashToClose);
            this.panelControl1.Controls.Add(this.btnRegister);
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
            this.panelControl1.Size = new System.Drawing.Size(1330, 34);
            this.panelControl1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Solicitor";
            // 
            // lueSolicitor
            // 
            this.lueSolicitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueSolicitor.Location = new System.Drawing.Point(721, 7);
            this.lueSolicitor.Name = "lueSolicitor";
            this.lueSolicitor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSolicitor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Solicitor_ID", "Solicitor_ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 29, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Addr", "Addr", 33, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSolicitor.Properties.DataSource = this.bsSolicitor;
            this.lueSolicitor.Properties.DisplayMember = "Name";
            this.lueSolicitor.Properties.NullText = "";
            this.lueSolicitor.Properties.ValueMember = "Solicitor_ID";
            this.lueSolicitor.Size = new System.Drawing.Size(184, 20);
            this.lueSolicitor.TabIndex = 9;
            // 
            // bsSolicitor
            // 
            this.bsSolicitor.DataMember = "LD_Solicitor";
            this.bsSolicitor.DataSource = this.dsSolicitor1;
            // 
            // dsSolicitor1
            // 
            this.dsSolicitor1.DataSetName = "dsSolicitor";
            this.dsSolicitor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCashToClose
            // 
            this.btnCashToClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashToClose.Location = new System.Drawing.Point(1051, 6);
            this.btnCashToClose.Name = "btnCashToClose";
            this.btnCashToClose.Size = new System.Drawing.Size(134, 23);
            this.btnCashToClose.TabIndex = 8;
            this.btnCashToClose.Text = "Cash To Close";
            this.btnCashToClose.Click += new System.EventHandler(this.btnCashToClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(911, 6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Print Pre-Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporting.Location = new System.Drawing.Point(1191, 6);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(134, 23);
            this.btnReporting.TabIndex = 6;
            this.btnReporting.Text = "Lot Payout Statement";
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(223, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Payout Date";
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, false)});
            this.deInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
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
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
    "True;User ID=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // da_selectedLots
            // 
            this.da_selectedLots.DeleteCommand = this.sqlDeleteCommand1;
            this.da_selectedLots.InsertCommand = this.sqlInsertCommand1;
            this.da_selectedLots.SelectCommand = this.sqlSelectCommand1;
            this.da_selectedLots.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_LotSearch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("selected", "selected"),
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
                        new System.Data.Common.DataColumnMapping("title_number", "title_number"),
                        new System.Data.Common.DataColumnMapping("address_1", "address_1"),
                        new System.Data.Common.DataColumnMapping("address_2", "address_2"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("hold_expiry", "hold_expiry"),
                        new System.Data.Common.DataColumnMapping("long_legal", "long_legal"),
                        new System.Data.Common.DataColumnMapping("parcel_number", "parcel_number"),
                        new System.Data.Common.DataColumnMapping("postal", "postal"),
                        new System.Data.Common.DataColumnMapping("prov", "prov"),
                        new System.Data.Common.DataColumnMapping("shape", "shape"),
                        new System.Data.Common.DataColumnMapping("ma_name", "ma_name"),
                        new System.Data.Common.DataColumnMapping("ma_number", "ma_number"),
                        new System.Data.Common.DataColumnMapping("ma_prefix_dir", "ma_prefix_dir"),
                        new System.Data.Common.DataColumnMapping("ma_suffix", "ma_suffix"),
                        new System.Data.Common.DataColumnMapping("ma_suffix_dir", "ma_suffix_dir"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("MasterAgreementNum", "MasterAgreementNum"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Code", "Purchaser_Code"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Name", "Purchaser_Name"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("WordMerged", "WordMerged")})});
            this.da_selectedLots.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_expiry", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_expiry", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_long_legal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_long_legal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_parcel_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_parcel_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_postal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prov", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prov", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_shape", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_shape", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_prefix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_WordMerged", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WordMerged", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WordMerged", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WordMerged", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@selected", System.Data.SqlDbType.Bit, 0, "selected"),
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
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number"),
            new System.Data.SqlClient.SqlParameter("@address_1", System.Data.SqlDbType.VarChar, 0, "address_1"),
            new System.Data.SqlClient.SqlParameter("@address_2", System.Data.SqlDbType.VarChar, 0, "address_2"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@hold_expiry", System.Data.SqlDbType.DateTime, 0, "hold_expiry"),
            new System.Data.SqlClient.SqlParameter("@long_legal", System.Data.SqlDbType.VarChar, 0, "long_legal"),
            new System.Data.SqlClient.SqlParameter("@parcel_number", System.Data.SqlDbType.VarChar, 0, "parcel_number"),
            new System.Data.SqlClient.SqlParameter("@postal", System.Data.SqlDbType.VarChar, 0, "postal"),
            new System.Data.SqlClient.SqlParameter("@prov", System.Data.SqlDbType.VarChar, 0, "prov"),
            new System.Data.SqlClient.SqlParameter("@shape", System.Data.SqlDbType.VarChar, 0, "shape"),
            new System.Data.SqlClient.SqlParameter("@ma_name", System.Data.SqlDbType.VarChar, 0, "ma_name"),
            new System.Data.SqlClient.SqlParameter("@ma_number", System.Data.SqlDbType.VarChar, 0, "ma_number"),
            new System.Data.SqlClient.SqlParameter("@ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, "ma_prefix_dir"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix", System.Data.SqlDbType.VarChar, 0, "ma_suffix"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, "ma_suffix_dir"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@WordMerged", System.Data.SqlDbType.Bit, 0, "WordMerged")});
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
            new System.Data.SqlClient.SqlParameter("@selected", System.Data.SqlDbType.Bit, 0, "selected"),
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
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number"),
            new System.Data.SqlClient.SqlParameter("@address_1", System.Data.SqlDbType.VarChar, 0, "address_1"),
            new System.Data.SqlClient.SqlParameter("@address_2", System.Data.SqlDbType.VarChar, 0, "address_2"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@hold_expiry", System.Data.SqlDbType.DateTime, 0, "hold_expiry"),
            new System.Data.SqlClient.SqlParameter("@long_legal", System.Data.SqlDbType.VarChar, 0, "long_legal"),
            new System.Data.SqlClient.SqlParameter("@parcel_number", System.Data.SqlDbType.VarChar, 0, "parcel_number"),
            new System.Data.SqlClient.SqlParameter("@postal", System.Data.SqlDbType.VarChar, 0, "postal"),
            new System.Data.SqlClient.SqlParameter("@prov", System.Data.SqlDbType.VarChar, 0, "prov"),
            new System.Data.SqlClient.SqlParameter("@shape", System.Data.SqlDbType.VarChar, 0, "shape"),
            new System.Data.SqlClient.SqlParameter("@ma_name", System.Data.SqlDbType.VarChar, 0, "ma_name"),
            new System.Data.SqlClient.SqlParameter("@ma_number", System.Data.SqlDbType.VarChar, 0, "ma_number"),
            new System.Data.SqlClient.SqlParameter("@ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, "ma_prefix_dir"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix", System.Data.SqlDbType.VarChar, 0, "ma_suffix"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, "ma_suffix_dir"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@WordMerged", System.Data.SqlDbType.Bit, 0, "WordMerged"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_expiry", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_expiry", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_long_legal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_long_legal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_parcel_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_parcel_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_postal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prov", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prov", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_shape", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_shape", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_prefix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_WordMerged", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WordMerged", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WordMerged", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WordMerged", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     Solicitor_ID, Name, Title, City, Addr\r\nFROM         LD_Solicitor AS s\r" +
    "\nORDER BY Name";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 0, "Name"),
            new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.VarChar, 0, "Title"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.VarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Addr", System.Data.SqlDbType.VarChar, 0, "Addr")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 0, "Name"),
            new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.VarChar, 0, "Title"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.VarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Addr", System.Data.SqlDbType.VarChar, 0, "Addr"),
            new System.Data.SqlClient.SqlParameter("@Original_Solicitor_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Solicitor_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Addr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Addr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Addr", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Addr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Solicitor_ID", System.Data.SqlDbType.Int, 4, "Solicitor_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Solicitor_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Solicitor_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Title", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Addr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Addr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Addr", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Addr", System.Data.DataRowVersion.Original, null)});
            // 
            // daSolicitor
            // 
            this.daSolicitor.DeleteCommand = this.sqlDeleteCommand2;
            this.daSolicitor.InsertCommand = this.sqlInsertCommand2;
            this.daSolicitor.SelectCommand = this.sqlSelectCommand2;
            this.daSolicitor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Solicitor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Solicitor_ID", "Solicitor_ID"),
                        new System.Data.Common.DataColumnMapping("Name", "Name"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Addr", "Addr")})});
            this.daSolicitor.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // lblInterimMessage
            // 
            this.lblInterimMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInterimMessage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInterimMessage.Appearance.Options.UseFont = true;
            this.lblInterimMessage.Appearance.Options.UseForeColor = true;
            this.lblInterimMessage.Location = new System.Drawing.Point(414, 9);
            this.lblInterimMessage.Name = "lblInterimMessage";
            this.lblInterimMessage.Size = new System.Drawing.Size(192, 13);
            this.lblInterimMessage.TabIndex = 11;
            this.lblInterimMessage.Text = "***Interim Payout Statement***";
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dpnlSubledgerPreview);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1330, 752);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpnlSubledgerPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBeWordMerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSolicitor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSolicitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colselected;
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
        private DevExpress.XtraGrid.Columns.GridColumn coltitle_number;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_1;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_2;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn colhold_expiry;
        private DevExpress.XtraGrid.Columns.GridColumn collong_legal;
        private DevExpress.XtraGrid.Columns.GridColumn colparcel_number;
        private DevExpress.XtraGrid.Columns.GridColumn colpostal;
        private DevExpress.XtraGrid.Columns.GridColumn colprov;
        private DevExpress.XtraGrid.Columns.GridColumn colshape;
        private DevExpress.XtraGrid.Columns.GridColumn colma_name;
        private DevExpress.XtraGrid.Columns.GridColumn colma_number;
        private DevExpress.XtraGrid.Columns.GridColumn colma_prefix_dir;
        private DevExpress.XtraGrid.Columns.GridColumn colma_suffix;
        private DevExpress.XtraGrid.Columns.GridColumn colma_suffix_dir;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterAgreementNum;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReporting;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deInvoiceDate;
        private DevExpress.XtraEditors.TextEdit tePeriod;
        private DevExpress.XtraEditors.TextEdit teYear;
        private DevExpress.XtraBars.Docking.DockPanel dpnlSubledgerPreview;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlDataAdapter da_selectedLots;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private ds_selectedLots ds_selectedLots1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnCashToClose;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraEditors.LookUpEdit lueSolicitor;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daSolicitor;
        private System.Windows.Forms.Label label1;
        private dsSolicitor dsSolicitor1;
        private System.Windows.Forms.BindingSource bsSolicitor;
        private DevExpress.XtraGrid.Columns.GridColumn colWordMerged;
        private DevExpress.XtraGrid.Columns.GridColumn colWordMergeButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBeWordMerge;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceReadOnly;
        private DevExpress.XtraEditors.LabelControl lblInterimMessage;
    }
}
