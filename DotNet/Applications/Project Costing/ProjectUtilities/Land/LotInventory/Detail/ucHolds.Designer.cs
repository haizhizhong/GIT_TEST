namespace ProjectUtilities.Land.LotInventory.Detail
{
    partial class ucHolds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHolds));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.ceShowExpired = new DevExpress.XtraEditors.CheckEdit();
            this.txtPlan = new DevExpress.XtraEditors.TextEdit();
            this.txtLot = new DevExpress.XtraEditors.TextEdit();
            this.txtBlock = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcLotHold = new DevExpress.XtraGrid.GridControl();
            this.bsLotHold = new System.Windows.Forms.BindingSource(this.components);
            this.dsLotHold1 = new ProjectUtilities.Land.LotInventory.Detail.dsLotHold();
            this.gvLotHold = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproj_lot_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePriority = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colstart_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colend_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLotStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lueLotStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsLookups_Hold1 = new ProjectUtilities.Land.LotInventory.Detail.dsLookups_Hold();
            this.colsub_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLotSubStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lueLotSubStatus = new System.Windows.Forms.BindingSource(this.components);
            this.colpurchaser_type_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaserType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_luePurchaserType = new System.Windows.Forms.BindingSource(this.components);
            this.colpurchaser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_luePurchaser = new System.Windows.Forms.BindingSource(this.components);
            this.colphone_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teMax13 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colprice_quoted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.coltrans_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colcomments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowExpired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhasComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riComments = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colhold_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfirmed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bs_Priority_Static = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Priority_Static = new System.Data.DataSet();
            this.tblPriority = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.meComment = new DevExpress.XtraEditors.MemoEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daLotHold = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_lueLotStatus = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.da_lueLotSubStatus = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.da_luePurchaserType = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_luePurchaser = new System.Data.SqlClient.SqlDataAdapter();
            this.bs_lueLotSubStatus_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.bs_luePurchaser_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpAttachments = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dpPurchasers = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dpHistory = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowExpired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLotHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotHold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookups_Hold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotSubStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSubStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Priority_Static)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Priority_Static)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSubStatus_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaser_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dpAttachments.SuspendLayout();
            this.dpPurchasers.SuspendLayout();
            this.dpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.layoutControl3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1067, 45);
            this.panelControl3.TabIndex = 10;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl3.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl3.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl3.Controls.Add(this.ceShowExpired);
            this.layoutControl3.Controls.Add(this.txtPlan);
            this.layoutControl3.Controls.Add(this.txtLot);
            this.layoutControl3.Controls.Add(this.txtBlock);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(2, 2);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(1063, 41);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // ceShowExpired
            // 
            this.ceShowExpired.Location = new System.Drawing.Point(607, 7);
            this.ceShowExpired.Name = "ceShowExpired";
            this.ceShowExpired.Properties.Caption = "Show Expired";
            this.ceShowExpired.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ceShowExpired.Properties.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ceShowExpired.Properties.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ceShowExpired.Size = new System.Drawing.Size(90, 19);
            this.ceShowExpired.StyleController = this.layoutControl3;
            this.ceShowExpired.TabIndex = 15;
            this.ceShowExpired.EditValueChanged += new System.EventHandler(this.ceShowExpired_EditValueChanged);
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(435, 7);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Properties.ReadOnly = true;
            this.txtPlan.Size = new System.Drawing.Size(161, 20);
            this.txtPlan.StyleController = this.layoutControl3;
            this.txtPlan.TabIndex = 14;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(36, 7);
            this.txtLot.Name = "txtLot";
            this.txtLot.Properties.ReadOnly = true;
            this.txtLot.Size = new System.Drawing.Size(159, 20);
            this.txtLot.StyleController = this.layoutControl3;
            this.txtLot.TabIndex = 12;
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(235, 7);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Properties.ReadOnly = true;
            this.txtBlock.Size = new System.Drawing.Size(160, 20);
            this.txtBlock.StyleController = this.layoutControl3;
            this.txtBlock.TabIndex = 13;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup1";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1063, 41);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "layoutControlGroup1";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtLot;
            this.layoutControlItem5.CustomizationFormText = "Project #:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem9";
            this.layoutControlItem5.Size = new System.Drawing.Size(199, 39);
            this.layoutControlItem5.Text = "Lot:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtBlock;
            this.layoutControlItem6.CustomizationFormText = "Project Name:";
            this.layoutControlItem6.Location = new System.Drawing.Point(199, 0);
            this.layoutControlItem6.Name = "layoutControlItem10";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 39);
            this.layoutControlItem6.Text = "Block";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(24, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(701, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem1";
            this.emptySpaceItem2.Size = new System.Drawing.Size(360, 39);
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPlan;
            this.layoutControlItem1.CustomizationFormText = "Plan";
            this.layoutControlItem1.Location = new System.Drawing.Point(399, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(201, 39);
            this.layoutControlItem1.Text = "Plan";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceShowExpired;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(101, 39);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // gcLotHold
            // 
            this.gcLotHold.DataSource = this.bsLotHold;
            this.gcLotHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLotHold.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcLotHold_EmbeddedNavigator_ButtonClick);
            this.gcLotHold.Location = new System.Drawing.Point(0, 45);
            this.gcLotHold.MainView = this.gvLotHold;
            this.gcLotHold.Name = "gcLotHold";
            this.gcLotHold.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueLotStatus,
            this.ri_lueLotSubStatus,
            this.ri_luePurchaserType,
            this.ri_luePurchaser,
            this.ri_teReadOnly,
            this.ri_teMax13,
            this.ri_luePriority,
            this.riComments,
            this.riPrice});
            this.gcLotHold.Size = new System.Drawing.Size(1067, 300);
            this.gcLotHold.TabIndex = 11;
            this.gcLotHold.UseEmbeddedNavigator = true;
            this.gcLotHold.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotHold});
            // 
            // bsLotHold
            // 
            this.bsLotHold.DataMember = "PROJ_LOT_HOLD";
            this.bsLotHold.DataSource = this.dsLotHold1;
            // 
            // dsLotHold1
            // 
            this.dsLotHold1.DataSetName = "dsLotHold";
            this.dsLotHold1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLotHold
            // 
            this.gvLotHold.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproj_lot_id,
            this.colpri_id,
            this.colpriority,
            this.colstart_date,
            this.colend_date,
            this.collot_status_id,
            this.colsub_status_id,
            this.colpurchaser_type_id,
            this.colpurchaser_id,
            this.colphone_num,
            this.colprice_quoted,
            this.coltrans_date,
            this.colusername,
            this.colcomments,
            this.colShowExpired,
            this.colhasComments,
            this.colhold_id,
            this.colConfirmed});
            this.gvLotHold.GridControl = this.gcLotHold;
            this.gvLotHold.Name = "gvLotHold";
            this.gvLotHold.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLotHold_FocusedRowChanged);
            this.gvLotHold.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvLotHold_CellValueChanged);
            this.gvLotHold.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvLotHold_InitNewRow);
            this.gvLotHold.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvLotHold_RowUpdated);
            this.gvLotHold.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvLotHold_InvalidRowException);
            this.gvLotHold.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvLotHold_ValidateRow);
            // 
            // colproj_lot_id
            // 
            this.colproj_lot_id.FieldName = "proj_lot_id";
            this.colproj_lot_id.Name = "colproj_lot_id";
            this.colproj_lot_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpriority
            // 
            this.colpriority.Caption = "Priority";
            this.colpriority.ColumnEdit = this.ri_luePriority;
            this.colpriority.FieldName = "priority";
            this.colpriority.Name = "colpriority";
            this.colpriority.Visible = true;
            this.colpriority.VisibleIndex = 1;
            this.colpriority.Width = 80;
            // 
            // ri_luePriority
            // 
            this.ri_luePriority.AutoHeight = false;
            this.ri_luePriority.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_luePriority.Name = "ri_luePriority";
            this.ri_luePriority.NullText = "";
            // 
            // colstart_date
            // 
            this.colstart_date.Caption = "Start Date";
            this.colstart_date.FieldName = "start_date";
            this.colstart_date.Name = "colstart_date";
            this.colstart_date.Visible = true;
            this.colstart_date.VisibleIndex = 2;
            // 
            // colend_date
            // 
            this.colend_date.Caption = "End Date";
            this.colend_date.FieldName = "end_date";
            this.colend_date.Name = "colend_date";
            this.colend_date.Visible = true;
            this.colend_date.VisibleIndex = 3;
            // 
            // collot_status_id
            // 
            this.collot_status_id.Caption = "Status";
            this.collot_status_id.ColumnEdit = this.ri_lueLotStatus;
            this.collot_status_id.FieldName = "lot_status_id";
            this.collot_status_id.Name = "collot_status_id";
            this.collot_status_id.OptionsColumn.AllowEdit = false;
            this.collot_status_id.OptionsColumn.ReadOnly = true;
            this.collot_status_id.Visible = true;
            this.collot_status_id.VisibleIndex = 4;
            this.collot_status_id.Width = 80;
            // 
            // ri_lueLotStatus
            // 
            this.ri_lueLotStatus.AutoHeight = false;
            this.ri_lueLotStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLotStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lot_Status", "Status", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLotStatus.DataSource = this.bs_lueLotStatus;
            this.ri_lueLotStatus.DisplayMember = "Lot_Status";
            this.ri_lueLotStatus.Name = "ri_lueLotStatus";
            this.ri_lueLotStatus.NullText = "";
            this.ri_lueLotStatus.ValueMember = "Lot_Status_ID";
            // 
            // bs_lueLotStatus
            // 
            this.bs_lueLotStatus.DataMember = "LD_Lot_Status";
            this.bs_lueLotStatus.DataSource = this.dsLookups_Hold1;
            // 
            // dsLookups_Hold1
            // 
            this.dsLookups_Hold1.DataSetName = "dsLookups_Hold";
            this.dsLookups_Hold1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colsub_status_id
            // 
            this.colsub_status_id.Caption = "Sub Status";
            this.colsub_status_id.ColumnEdit = this.ri_lueLotSubStatus;
            this.colsub_status_id.FieldName = "sub_status_id";
            this.colsub_status_id.Name = "colsub_status_id";
            this.colsub_status_id.Visible = true;
            this.colsub_status_id.VisibleIndex = 5;
            this.colsub_status_id.Width = 80;
            // 
            // ri_lueLotSubStatus
            // 
            this.ri_lueLotSubStatus.AutoHeight = false;
            this.ri_lueLotSubStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLotSubStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sub_Status", "Sub-Status", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLotSubStatus.DataSource = this.bs_lueLotSubStatus;
            this.ri_lueLotSubStatus.DisplayMember = "Sub_Status";
            this.ri_lueLotSubStatus.Name = "ri_lueLotSubStatus";
            this.ri_lueLotSubStatus.NullText = "";
            this.ri_lueLotSubStatus.ValueMember = "Sub_Status_ID";
            this.ri_lueLotSubStatus.Enter += new System.EventHandler(this.ri_lueLotSubStatus_Enter);
            // 
            // bs_lueLotSubStatus
            // 
            this.bs_lueLotSubStatus.DataMember = "LD_Sub_Lot_Status";
            this.bs_lueLotSubStatus.DataSource = this.dsLookups_Hold1;
            // 
            // colpurchaser_type_id
            // 
            this.colpurchaser_type_id.Caption = "Purchaser Type";
            this.colpurchaser_type_id.ColumnEdit = this.ri_luePurchaserType;
            this.colpurchaser_type_id.FieldName = "purchaser_type_id";
            this.colpurchaser_type_id.Name = "colpurchaser_type_id";
            this.colpurchaser_type_id.Visible = true;
            this.colpurchaser_type_id.VisibleIndex = 6;
            this.colpurchaser_type_id.Width = 80;
            // 
            // ri_luePurchaserType
            // 
            this.ri_luePurchaserType.AutoHeight = false;
            this.ri_luePurchaserType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_luePurchaserType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaserType", "Purchaser Type", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_luePurchaserType.DataSource = this.bs_luePurchaserType;
            this.ri_luePurchaserType.DisplayMember = "PurchaserType";
            this.ri_luePurchaserType.Name = "ri_luePurchaserType";
            this.ri_luePurchaserType.NullText = "";
            this.ri_luePurchaserType.ValueMember = "LD_Purchaser_Type_ID";
            this.ri_luePurchaserType.EditValueChanged += new System.EventHandler(this.ri_luePurchaserType_EditValueChanged);
            // 
            // bs_luePurchaserType
            // 
            this.bs_luePurchaserType.DataMember = "LD_Purchaser_Type";
            this.bs_luePurchaserType.DataSource = this.dsLookups_Hold1;
            // 
            // colpurchaser_id
            // 
            this.colpurchaser_id.Caption = "Purchaser";
            this.colpurchaser_id.ColumnEdit = this.ri_luePurchaser;
            this.colpurchaser_id.FieldName = "purchaser_id";
            this.colpurchaser_id.Name = "colpurchaser_id";
            this.colpurchaser_id.Visible = true;
            this.colpurchaser_id.VisibleIndex = 7;
            this.colpurchaser_id.Width = 80;
            // 
            // ri_luePurchaser
            // 
            this.ri_luePurchaser.AutoHeight = false;
            this.ri_luePurchaser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "...", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.ri_luePurchaser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Purchaser", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMER_CODE", "Code", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_luePurchaser.DataSource = this.bs_luePurchaser;
            this.ri_luePurchaser.DisplayMember = "NAME";
            this.ri_luePurchaser.Name = "ri_luePurchaser";
            this.ri_luePurchaser.NullText = "";
            this.ri_luePurchaser.PopupWidth = 200;
            this.ri_luePurchaser.ValueMember = "CUSTOMER_ID";
            this.ri_luePurchaser.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ri_luePurchaser_ButtonClick);
            this.ri_luePurchaser.EditValueChanged += new System.EventHandler(this.ri_luePurchaser_EditValueChanged);
            this.ri_luePurchaser.Enter += new System.EventHandler(this.ri_luePurchaser_Enter);
            // 
            // bs_luePurchaser
            // 
            this.bs_luePurchaser.DataMember = "CUSTOMERS";
            this.bs_luePurchaser.DataSource = this.dsLookups_Hold1;
            // 
            // colphone_num
            // 
            this.colphone_num.Caption = "Phone #";
            this.colphone_num.ColumnEdit = this.ri_teMax13;
            this.colphone_num.FieldName = "phone_num";
            this.colphone_num.Name = "colphone_num";
            this.colphone_num.Visible = true;
            this.colphone_num.VisibleIndex = 8;
            this.colphone_num.Width = 80;
            // 
            // ri_teMax13
            // 
            this.ri_teMax13.AutoHeight = false;
            this.ri_teMax13.MaxLength = 13;
            this.ri_teMax13.Name = "ri_teMax13";
            // 
            // colprice_quoted
            // 
            this.colprice_quoted.Caption = "Price Quoted";
            this.colprice_quoted.ColumnEdit = this.riPrice;
            this.colprice_quoted.FieldName = "price_quoted";
            this.colprice_quoted.Name = "colprice_quoted";
            this.colprice_quoted.Visible = true;
            this.colprice_quoted.VisibleIndex = 9;
            this.colprice_quoted.Width = 80;
            // 
            // riPrice
            // 
            this.riPrice.AutoHeight = false;
            this.riPrice.Mask.EditMask = "n2";
            this.riPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riPrice.Mask.UseMaskAsDisplayFormat = true;
            this.riPrice.Name = "riPrice";
            // 
            // coltrans_date
            // 
            this.coltrans_date.Caption = "Logged At";
            this.coltrans_date.FieldName = "trans_date";
            this.coltrans_date.Name = "coltrans_date";
            this.coltrans_date.OptionsColumn.AllowEdit = false;
            this.coltrans_date.OptionsColumn.ReadOnly = true;
            this.coltrans_date.Visible = true;
            this.coltrans_date.VisibleIndex = 10;
            // 
            // colusername
            // 
            this.colusername.Caption = "Username";
            this.colusername.ColumnEdit = this.ri_teReadOnly;
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.ReadOnly = true;
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 11;
            this.colusername.Width = 77;
            // 
            // ri_teReadOnly
            // 
            this.ri_teReadOnly.AutoHeight = false;
            this.ri_teReadOnly.MaxLength = 50;
            this.ri_teReadOnly.Name = "ri_teReadOnly";
            this.ri_teReadOnly.ReadOnly = true;
            // 
            // colcomments
            // 
            this.colcomments.Caption = "Comments";
            this.colcomments.FieldName = "comments";
            this.colcomments.Name = "colcomments";
            // 
            // colShowExpired
            // 
            this.colShowExpired.FieldName = "ShowExpired";
            this.colShowExpired.Name = "colShowExpired";
            this.colShowExpired.OptionsColumn.ReadOnly = true;
            this.colShowExpired.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colhasComments
            // 
            this.colhasComments.Caption = "Has Comments";
            this.colhasComments.ColumnEdit = this.riComments;
            this.colhasComments.FieldName = "hasComments";
            this.colhasComments.Name = "colhasComments";
            this.colhasComments.OptionsColumn.AllowEdit = false;
            this.colhasComments.OptionsColumn.ReadOnly = true;
            this.colhasComments.Visible = true;
            this.colhasComments.VisibleIndex = 12;
            this.colhasComments.Width = 89;
            // 
            // riComments
            // 
            this.riComments.AutoHeight = false;
            this.riComments.Name = "riComments";
            this.riComments.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colhold_id
            // 
            this.colhold_id.FieldName = "hold_id";
            this.colhold_id.Name = "colhold_id";
            this.colhold_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colConfirmed
            // 
            this.colConfirmed.Caption = "Confirmed";
            this.colConfirmed.FieldName = "Confirmed";
            this.colConfirmed.Name = "colConfirmed";
            this.colConfirmed.Visible = true;
            this.colConfirmed.VisibleIndex = 0;
            // 
            // bs_Priority_Static
            // 
            this.bs_Priority_Static.DataMember = "tblPriority";
            this.bs_Priority_Static.DataSource = this.ds_Priority_Static;
            // 
            // ds_Priority_Static
            // 
            this.ds_Priority_Static.DataSetName = "NewDataSet";
            this.ds_Priority_Static.Tables.AddRange(new System.Data.DataTable[] {
            this.tblPriority});
            // 
            // tblPriority
            // 
            this.tblPriority.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.tblPriority.TableName = "tblPriority";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Priority";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "value";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.meComment);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 351);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1067, 134);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Comments";
            // 
            // meComment
            // 
            this.meComment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsLotHold, "comments", true));
            this.meComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meComment.Location = new System.Drawing.Point(2, 20);
            this.meComment.Name = "meComment";
            this.meComment.Size = new System.Drawing.Size(1063, 112);
            this.meComment.TabIndex = 0;
            this.meComment.EditValueChanged += new System.EventHandler(this.meComment_EditValueChanged);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 345);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1067, 6);
            this.splitterControl1.TabIndex = 13;
            this.splitterControl1.TabStop = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SHOW_EXPIRED", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@PROJ_LOT_ID", System.Data.SqlDbType.Int, 4, "proj_lot_id")});
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
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@priority", System.Data.SqlDbType.VarChar, 0, "priority"),
            new System.Data.SqlClient.SqlParameter("@start_date", System.Data.SqlDbType.DateTime, 0, "start_date"),
            new System.Data.SqlClient.SqlParameter("@end_date", System.Data.SqlDbType.DateTime, 0, "end_date"),
            new System.Data.SqlClient.SqlParameter("@lot_status_id", System.Data.SqlDbType.Int, 0, "lot_status_id"),
            new System.Data.SqlClient.SqlParameter("@sub_status_id", System.Data.SqlDbType.Int, 0, "sub_status_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_type_id", System.Data.SqlDbType.Int, 0, "purchaser_type_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id", System.Data.SqlDbType.Int, 0, "purchaser_id"),
            new System.Data.SqlClient.SqlParameter("@phone_num", System.Data.SqlDbType.VarChar, 0, "phone_num"),
            new System.Data.SqlClient.SqlParameter("@price_quoted", System.Data.SqlDbType.Money, 0, "price_quoted"),
            new System.Data.SqlClient.SqlParameter("@trans_date", System.Data.SqlDbType.DateTime, 0, "trans_date"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@comments", System.Data.SqlDbType.VarChar, 0, "comments"),
            new System.Data.SqlClient.SqlParameter("@Confirmed", System.Data.SqlDbType.Bit, 0, "Confirmed"),
            new System.Data.SqlClient.SqlParameter("@SHOW_EXPIRED", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@priority", System.Data.SqlDbType.VarChar, 0, "priority"),
            new System.Data.SqlClient.SqlParameter("@start_date", System.Data.SqlDbType.DateTime, 0, "start_date"),
            new System.Data.SqlClient.SqlParameter("@end_date", System.Data.SqlDbType.DateTime, 0, "end_date"),
            new System.Data.SqlClient.SqlParameter("@lot_status_id", System.Data.SqlDbType.Int, 0, "lot_status_id"),
            new System.Data.SqlClient.SqlParameter("@sub_status_id", System.Data.SqlDbType.Int, 0, "sub_status_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_type_id", System.Data.SqlDbType.Int, 0, "purchaser_type_id"),
            new System.Data.SqlClient.SqlParameter("@purchaser_id", System.Data.SqlDbType.Int, 0, "purchaser_id"),
            new System.Data.SqlClient.SqlParameter("@phone_num", System.Data.SqlDbType.VarChar, 0, "phone_num"),
            new System.Data.SqlClient.SqlParameter("@price_quoted", System.Data.SqlDbType.Money, 0, "price_quoted"),
            new System.Data.SqlClient.SqlParameter("@trans_date", System.Data.SqlDbType.DateTime, 0, "trans_date"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@comments", System.Data.SqlDbType.VarChar, 0, "comments"),
            new System.Data.SqlClient.SqlParameter("@Confirmed", System.Data.SqlDbType.Bit, 0, "Confirmed"),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "priority", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_priority", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "priority", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_start_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "start_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_start_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_end_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "end_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_end_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sub_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sub_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sub_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sub_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phone_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phone_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phone_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phone_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_price_quoted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "price_quoted", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_price_quoted", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price_quoted", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_trans_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "trans_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_trans_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "trans_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Confirmed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Confirmed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@SHOW_EXPIRED", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@hold_id", System.Data.SqlDbType.Int, 4, "hold_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_priority", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "priority", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_priority", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "priority", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_start_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "start_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_start_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_end_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "end_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_end_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sub_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sub_status_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sub_status_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sub_status_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_purchaser_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "purchaser_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_phone_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "phone_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_phone_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "phone_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_price_quoted", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "price_quoted", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_price_quoted", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price_quoted", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_trans_date", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "trans_date", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_trans_date", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "trans_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Confirmed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Confirmed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, null)});
            // 
            // daLotHold
            // 
            this.daLotHold.DeleteCommand = this.sqlDeleteCommand1;
            this.daLotHold.InsertCommand = this.sqlInsertCommand1;
            this.daLotHold.SelectCommand = this.sqlSelectCommand1;
            this.daLotHold.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LOT_HOLD", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("priority", "priority"),
                        new System.Data.Common.DataColumnMapping("start_date", "start_date"),
                        new System.Data.Common.DataColumnMapping("end_date", "end_date"),
                        new System.Data.Common.DataColumnMapping("lot_status_id", "lot_status_id"),
                        new System.Data.Common.DataColumnMapping("sub_status_id", "sub_status_id"),
                        new System.Data.Common.DataColumnMapping("purchaser_type_id", "purchaser_type_id"),
                        new System.Data.Common.DataColumnMapping("purchaser_id", "purchaser_id"),
                        new System.Data.Common.DataColumnMapping("phone_num", "phone_num"),
                        new System.Data.Common.DataColumnMapping("price_quoted", "price_quoted"),
                        new System.Data.Common.DataColumnMapping("trans_date", "trans_date"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("comments", "comments"),
                        new System.Data.Common.DataColumnMapping("ShowExpired", "ShowExpired"),
                        new System.Data.Common.DataColumnMapping("hasComments", "hasComments"),
                        new System.Data.Common.DataColumnMapping("hold_id", "hold_id"),
                        new System.Data.Common.DataColumnMapping("Confirmed", "Confirmed")})});
            this.daLotHold.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "select Lot_Status_ID,Lot_Status from LD_Lot_Status order by Lot_Status\r\n";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [LD_Lot_Status] ([Lot_Status_ID], [Lot_Status]) VALUES (@Lot_Status_I" +
                "D, @Lot_Status)";
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Lot_Status_ID", System.Data.SqlDbType.Int, 0, "Lot_Status_ID"),
            new System.Data.SqlClient.SqlParameter("@Lot_Status", System.Data.SqlDbType.VarChar, 0, "Lot_Status")});
            // 
            // da_lueLotStatus
            // 
            this.da_lueLotStatus.InsertCommand = this.sqlInsertCommand2;
            this.da_lueLotStatus.SelectCommand = this.sqlSelectCommand2;
            this.da_lueLotStatus.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Lot_Status", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Lot_Status_ID", "Lot_Status_ID"),
                        new System.Data.Common.DataColumnMapping("Lot_Status", "Lot_Status")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "select Sub_Status_ID,LD_Lot_Status_ID,Sub_Status from LD_Sub_Lot_Status order by " +
                "Sub_Status\r\n";
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = "INSERT INTO [LD_Sub_Lot_Status] ([Sub_Status_ID], [LD_Lot_Status_ID], [Sub_Status" +
                "]) VALUES (@Sub_Status_ID, @LD_Lot_Status_ID, @Sub_Status)";
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Sub_Status_ID", System.Data.SqlDbType.Int, 0, "Sub_Status_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_Lot_Status_ID", System.Data.SqlDbType.Int, 0, "LD_Lot_Status_ID"),
            new System.Data.SqlClient.SqlParameter("@Sub_Status", System.Data.SqlDbType.VarChar, 0, "Sub_Status")});
            // 
            // da_lueLotSubStatus
            // 
            this.da_lueLotSubStatus.InsertCommand = this.sqlInsertCommand3;
            this.da_lueLotSubStatus.SelectCommand = this.sqlSelectCommand3;
            this.da_lueLotSubStatus.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Sub_Lot_Status", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Sub_Status_ID", "Sub_Status_ID"),
                        new System.Data.Common.DataColumnMapping("LD_Lot_Status_ID", "LD_Lot_Status_ID"),
                        new System.Data.Common.DataColumnMapping("Sub_Status", "Sub_Status")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "select LD_Purchaser_Type_ID,PurchaserType from LD_Purchaser_Type\r\nwhere ld_purcha" +
                "ser_type_id != 4 order by PurchaserType\r\n";
            this.sqlSelectCommand4.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = "INSERT INTO [LD_Purchaser_Type] ([LD_Purchaser_Type_ID], [PurchaserType]) VALUES " +
                "(@LD_Purchaser_Type_ID, @PurchaserType)";
            this.sqlInsertCommand4.Connection = this.sqlTRConnection;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LD_Purchaser_Type_ID", System.Data.SqlDbType.Int, 0, "LD_Purchaser_Type_ID"),
            new System.Data.SqlClient.SqlParameter("@PurchaserType", System.Data.SqlDbType.VarChar, 0, "PurchaserType")});
            // 
            // da_luePurchaserType
            // 
            this.da_luePurchaserType.InsertCommand = this.sqlInsertCommand4;
            this.da_luePurchaserType.SelectCommand = this.sqlSelectCommand4;
            this.da_luePurchaserType.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Purchaser_Type", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LD_Purchaser_Type_ID", "LD_Purchaser_Type_ID"),
                        new System.Data.Common.DataColumnMapping("PurchaserType", "PurchaserType")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT     CUSTOMER_ID, CUSTOMER_CODE, NAME, PURCHASER_TYPE_ID, ACTIVE\r\nFROM     " +
                "    CUSTOMERS\r\nWHERE     (IS_PURCHASER = 1)\r\nORDER BY CUSTOMER_CODE";
            this.sqlSelectCommand5.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = resources.GetString("sqlInsertCommand5.CommandText");
            this.sqlInsertCommand5.Connection = this.sqlTRConnection;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, "CUSTOMER_CODE"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, "PURCHASER_TYPE_ID"),
            new System.Data.SqlClient.SqlParameter("@ACTIVE", System.Data.SqlDbType.VarChar, 0, "ACTIVE")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, "CUSTOMER_CODE"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, "PURCHASER_TYPE_ID"),
            new System.Data.SqlClient.SqlParameter("@ACTIVE", System.Data.SqlDbType.VarChar, 0, "ACTIVE"),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ACTIVE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ACTIVE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ACTIVE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ACTIVE", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PURCHASER_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PURCHASER_TYPE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ACTIVE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ACTIVE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ACTIVE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ACTIVE", System.Data.DataRowVersion.Original, null)});
            // 
            // da_luePurchaser
            // 
            this.da_luePurchaser.DeleteCommand = this.sqlDeleteCommand2;
            this.da_luePurchaser.InsertCommand = this.sqlInsertCommand5;
            this.da_luePurchaser.SelectCommand = this.sqlSelectCommand5;
            this.da_luePurchaser.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CUSTOMERS", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CUSTOMER_ID", "CUSTOMER_ID"),
                        new System.Data.Common.DataColumnMapping("CUSTOMER_CODE", "CUSTOMER_CODE"),
                        new System.Data.Common.DataColumnMapping("NAME", "NAME"),
                        new System.Data.Common.DataColumnMapping("PURCHASER_TYPE_ID", "PURCHASER_TYPE_ID"),
                        new System.Data.Common.DataColumnMapping("ACTIVE", "ACTIVE")})});
            this.da_luePurchaser.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // bs_lueLotSubStatus_Restricted
            // 
            this.bs_lueLotSubStatus_Restricted.DataMember = "LD_Sub_Lot_Status";
            this.bs_lueLotSubStatus_Restricted.DataSource = this.dsLookups_Hold1;
            // 
            // bs_luePurchaser_Restricted
            // 
            this.bs_luePurchaser_Restricted.DataMember = "CUSTOMERS";
            this.bs_luePurchaser_Restricted.DataSource = this.dsLookups_Hold1;
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.DockingOptions.ShowMaximizeButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dpAttachments;
            this.panelContainer1.Controls.Add(this.dpAttachments);
            this.panelContainer1.Controls.Add(this.dpPurchasers);
            this.panelContainer1.Controls.Add(this.dpHistory);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("203738ed-5608-4650-b240-c4ef8375c2c7");
            this.panelContainer1.Location = new System.Drawing.Point(0, 485);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.Size = new System.Drawing.Size(1067, 257);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dpAttachments
            // 
            this.dpAttachments.Controls.Add(this.dockPanel1_Container);
            this.dpAttachments.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpAttachments.FloatVertical = true;
            this.dpAttachments.ID = new System.Guid("02d658df-40c0-40fb-adc5-1cad9f556e14");
            this.dpAttachments.Location = new System.Drawing.Point(3, 25);
            this.dpAttachments.Name = "dpAttachments";
            this.dpAttachments.Size = new System.Drawing.Size(1061, 207);
            this.dpAttachments.Text = "Attachments";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1061, 207);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dpPurchasers
            // 
            this.dpPurchasers.Controls.Add(this.dockPanel2_Container);
            this.dpPurchasers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpPurchasers.ID = new System.Guid("8286fb28-f032-41a4-b788-5208a9de6a05");
            this.dpPurchasers.Location = new System.Drawing.Point(3, 25);
            this.dpPurchasers.Name = "dpPurchasers";
            this.dpPurchasers.Size = new System.Drawing.Size(1061, 207);
            this.dpPurchasers.Text = "Third Party Purchasers";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1061, 207);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dpHistory
            // 
            this.dpHistory.Controls.Add(this.dockPanel3_Container);
            this.dpHistory.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpHistory.ID = new System.Guid("1b8f0db3-5796-4f5f-a70d-54b7bb6f6db7");
            this.dpHistory.Location = new System.Drawing.Point(3, 25);
            this.dpHistory.Name = "dpHistory";
            this.dpHistory.Size = new System.Drawing.Size(1061, 207);
            this.dpHistory.Text = "History";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(1061, 207);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // ucHolds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcLotHold);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelContainer1);
            this.Name = "ucHolds";
            this.Size = new System.Drawing.Size(1067, 742);
            this.Load += new System.EventHandler(this.ucHolds_Load);
            this.Leave += new System.EventHandler(this.ucHolds_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceShowExpired.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLotHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotHold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookups_Hold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotSubStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSubStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Priority_Static)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Priority_Static)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSubStatus_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_luePurchaser_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dpAttachments.ResumeLayout(false);
            this.dpPurchasers.ResumeLayout(false);
            this.dpHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.TextEdit txtPlan;
        private DevExpress.XtraEditors.TextEdit txtLot;
        private DevExpress.XtraEditors.TextEdit txtBlock;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gcLotHold;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotHold;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit meComment;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daLotHold;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private dsLotHold dsLotHold1;
        private DevExpress.XtraEditors.CheckEdit ceShowExpired;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bsLotHold;
        private DevExpress.XtraGrid.Columns.GridColumn colproj_lot_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpriority;
        private DevExpress.XtraGrid.Columns.GridColumn colstart_date;
        private DevExpress.XtraGrid.Columns.GridColumn colend_date;
        private DevExpress.XtraGrid.Columns.GridColumn collot_status_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsub_status_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_type_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_num;
        private DevExpress.XtraGrid.Columns.GridColumn colprice_quoted;
        private DevExpress.XtraGrid.Columns.GridColumn coltrans_date;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colcomments;
        private DevExpress.XtraGrid.Columns.GridColumn colShowExpired;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_lueLotStatus;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlDataAdapter da_lueLotSubStatus;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlDataAdapter da_luePurchaserType;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_luePurchaser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLotStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLotSubStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaserType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaser;
        private dsLookups_Hold dsLookups_Hold1;
        private System.Windows.Forms.BindingSource bs_lueLotStatus;
        private System.Windows.Forms.BindingSource bs_lueLotSubStatus;
        private System.Windows.Forms.BindingSource bs_luePurchaserType;
        private System.Windows.Forms.BindingSource bs_luePurchaser;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teReadOnly;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teMax13;
        private DevExpress.XtraGrid.Columns.GridColumn colhasComments;
        private System.Data.DataSet ds_Priority_Static;
        private System.Data.DataTable tblPriority;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePriority;
        private System.Windows.Forms.BindingSource bs_Priority_Static;
        private DevExpress.XtraGrid.Columns.GridColumn colhold_id;
        private System.Windows.Forms.BindingSource bs_lueLotSubStatus_Restricted;
        private System.Windows.Forms.BindingSource bs_luePurchaser_Restricted;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riComments;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmed;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dpAttachments;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dpPurchasers;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dpHistory;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
    }
}
