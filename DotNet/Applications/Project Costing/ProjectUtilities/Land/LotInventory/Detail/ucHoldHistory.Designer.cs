namespace ProjectUtilities.Land.LotInventory.Detail
{
    partial class ucHoldHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoldHistory));
            this.gcLotHold = new DevExpress.XtraGrid.GridControl();
            this.dsHoldHist = new ProjectUtilities.Land.LotInventory.Detail.dsHoldHist();
            this.gvLotHold = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproj_lot_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePriority = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colstart_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colend_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLotStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colsub_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLotSubStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colpurchaser_type_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaserType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colpurchaser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_luePurchaser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.TR_Conn = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daHoldHist = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotSubStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComments)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLotHold
            // 
            this.gcLotHold.DataMember = "CUSTOMERS";
            this.gcLotHold.DataSource = this.dsHoldHist;
            this.gcLotHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLotHold.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLotHold.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLotHold.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLotHold.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLotHold.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLotHold.Location = new System.Drawing.Point(0, 0);
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
            this.gcLotHold.Size = new System.Drawing.Size(1038, 482);
            this.gcLotHold.TabIndex = 12;
            this.gcLotHold.UseEmbeddedNavigator = true;
            this.gcLotHold.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotHold});
            // 
            // dsHoldHist
            // 
            this.dsHoldHist.DataSetName = "dsHoldHist";
            this.dsHoldHist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colpriority.FieldName = "priority";
            this.colpriority.Name = "colpriority";
            this.colpriority.OptionsColumn.AllowEdit = false;
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
            this.colstart_date.OptionsColumn.AllowEdit = false;
            this.colstart_date.Visible = true;
            this.colstart_date.VisibleIndex = 2;
            // 
            // colend_date
            // 
            this.colend_date.Caption = "End Date";
            this.colend_date.FieldName = "end_date";
            this.colend_date.Name = "colend_date";
            this.colend_date.OptionsColumn.AllowEdit = false;
            this.colend_date.Visible = true;
            this.colend_date.VisibleIndex = 3;
            // 
            // collot_status_id
            // 
            this.collot_status_id.Caption = "Status";
            this.collot_status_id.FieldName = "Lot_Status";
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
            this.ri_lueLotStatus.DisplayMember = "Lot_Status";
            this.ri_lueLotStatus.Name = "ri_lueLotStatus";
            this.ri_lueLotStatus.NullText = "";
            this.ri_lueLotStatus.ValueMember = "Lot_Status_ID";
            // 
            // colsub_status_id
            // 
            this.colsub_status_id.Caption = "Sub Status";
            this.colsub_status_id.FieldName = "Sub_Status";
            this.colsub_status_id.Name = "colsub_status_id";
            this.colsub_status_id.OptionsColumn.AllowEdit = false;
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
            this.ri_lueLotSubStatus.DisplayMember = "Sub_Status";
            this.ri_lueLotSubStatus.Name = "ri_lueLotSubStatus";
            this.ri_lueLotSubStatus.NullText = "";
            this.ri_lueLotSubStatus.ValueMember = "Sub_Status_ID";
            // 
            // colpurchaser_type_id
            // 
            this.colpurchaser_type_id.Caption = "Purchaser Type";
            this.colpurchaser_type_id.FieldName = "PurchaserType";
            this.colpurchaser_type_id.Name = "colpurchaser_type_id";
            this.colpurchaser_type_id.OptionsColumn.AllowEdit = false;
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
            this.ri_luePurchaserType.DisplayMember = "PurchaserType";
            this.ri_luePurchaserType.Name = "ri_luePurchaserType";
            this.ri_luePurchaserType.NullText = "";
            this.ri_luePurchaserType.ValueMember = "LD_Purchaser_Type_ID";
            // 
            // colpurchaser_id
            // 
            this.colpurchaser_id.Caption = "Purchaser";
            this.colpurchaser_id.FieldName = "NAME";
            this.colpurchaser_id.Name = "colpurchaser_id";
            this.colpurchaser_id.OptionsColumn.AllowEdit = false;
            this.colpurchaser_id.Visible = true;
            this.colpurchaser_id.VisibleIndex = 7;
            this.colpurchaser_id.Width = 80;
            // 
            // ri_luePurchaser
            // 
            this.ri_luePurchaser.AutoHeight = false;
            this.ri_luePurchaser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_luePurchaser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMER_CODE", "Code", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Purchaser", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_luePurchaser.DisplayMember = "CUSTOMER_CODE";
            this.ri_luePurchaser.Name = "ri_luePurchaser";
            this.ri_luePurchaser.NullText = "";
            this.ri_luePurchaser.PopupWidth = 200;
            this.ri_luePurchaser.ValueMember = "CUSTOMER_ID";
            // 
            // colphone_num
            // 
            this.colphone_num.Caption = "Phone #";
            this.colphone_num.ColumnEdit = this.ri_teMax13;
            this.colphone_num.FieldName = "phone_num";
            this.colphone_num.Name = "colphone_num";
            this.colphone_num.OptionsColumn.AllowEdit = false;
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
            this.colprice_quoted.OptionsColumn.AllowEdit = false;
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
            this.colConfirmed.OptionsColumn.AllowEdit = false;
            this.colConfirmed.Visible = true;
            this.colConfirmed.VisibleIndex = 0;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.TR_Conn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 4, "proj_lot_id")});
            // 
            // TR_Conn
            // 
            this.TR_Conn.ConnectionString = "Data Source=dev1;Initial Catalog=tr_strike_test10;Persist Security Info=True;User" +
                " ID=hmsqlsa;Password=hmsqlsa";
            this.TR_Conn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.TR_Conn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@hold_id", System.Data.SqlDbType.Int, 0, "hold_id"),
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
            new System.Data.SqlClient.SqlParameter("@Original_hold_hist_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_hist_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Confirmed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Confirmed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@hold_hist_id", System.Data.SqlDbType.Int, 4, "hold_hist_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.TR_Conn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_hold_hist_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_hist_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Confirmed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Confirmed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Confirmed", System.Data.DataRowVersion.Original, null)});
            // 
            // daHoldHist
            // 
            this.daHoldHist.DeleteCommand = this.sqlDeleteCommand1;
            this.daHoldHist.SelectCommand = this.sqlSelectCommand1;
            this.daHoldHist.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CUSTOMERS", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("hold_hist_id", "hold_hist_id"),
                        new System.Data.Common.DataColumnMapping("hold_id", "hold_id"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("priority", "priority"),
                        new System.Data.Common.DataColumnMapping("start_date", "start_date"),
                        new System.Data.Common.DataColumnMapping("end_date", "end_date"),
                        new System.Data.Common.DataColumnMapping("Lot_Status", "Lot_Status"),
                        new System.Data.Common.DataColumnMapping("Sub_Status", "Sub_Status"),
                        new System.Data.Common.DataColumnMapping("PurchaserType", "PurchaserType"),
                        new System.Data.Common.DataColumnMapping("NAME", "NAME"),
                        new System.Data.Common.DataColumnMapping("phone_num", "phone_num"),
                        new System.Data.Common.DataColumnMapping("price_quoted", "price_quoted"),
                        new System.Data.Common.DataColumnMapping("trans_date", "trans_date"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("comments", "comments"),
                        new System.Data.Common.DataColumnMapping("Confirmed", "Confirmed")})});
            this.daHoldHist.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucHoldHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcLotHold);
            this.Name = "ucHoldHistory";
            this.Size = new System.Drawing.Size(1038, 482);
            this.Load += new System.EventHandler(this.ucHoldHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLotSubStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_luePurchaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLotHold;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotHold;
        private DevExpress.XtraGrid.Columns.GridColumn colproj_lot_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpriority;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePriority;
        private DevExpress.XtraGrid.Columns.GridColumn colstart_date;
        private DevExpress.XtraGrid.Columns.GridColumn colend_date;
        private DevExpress.XtraGrid.Columns.GridColumn collot_status_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLotStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colsub_status_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLotSubStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_type_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaserType;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaser_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_luePurchaser;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_num;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teMax13;
        private DevExpress.XtraGrid.Columns.GridColumn colprice_quoted;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coltrans_date;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colcomments;
        private DevExpress.XtraGrid.Columns.GridColumn colShowExpired;
        private DevExpress.XtraGrid.Columns.GridColumn colhasComments;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riComments;
        private DevExpress.XtraGrid.Columns.GridColumn colhold_id;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmed;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection TR_Conn;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daHoldHist;
        private dsHoldHist dsHoldHist;
    }
}
