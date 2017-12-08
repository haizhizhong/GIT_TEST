namespace LD_RawLandControls
{
    partial class ucRawLandHolding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRawLandHolding));
            this.gcRawLand = new DevExpress.XtraGrid.GridControl();
            this.bsRawLandHolding = new System.Windows.Forms.BindingSource(this.components);
            this.dsRawLandHolding1 = new LD_RawLandControls.dsRawLandHolding();
            this.gvRawLand = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawLand_PRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueProjCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_ProjHeader_Code = new System.Windows.Forms.BindingSource(this.components);
            this.dsRawLandProject1 = new LD_RawLandControls.dsRawLandProject();
            this.colRawLand_PRI_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueProjName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_ProjHeader_Name = new System.Windows.Forms.BindingSource(this.components);
            this.colAdditionalUse_Area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNetArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_meComments = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colPROJ_LD_AdditionalUseArea_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLueAdditionalUseArea = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsProjAdditionalUseArea_All = new System.Windows.Forms.BindingSource(this.components);
            this.dsProjAdditionalUseArea1 = new LD_RawLandControls.dsProjAdditionalUseArea();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daRawLandHolding = new System.Data.SqlClient.SqlDataAdapter();
            this.daRawLandProject = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daProjAdditionalUseArea = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.bsProjAdditionalUseArea = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.hleTransferCosts = new ReflexEditors.RHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRawLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRawLandHolding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRawLandHolding1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRawLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProjCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProjHeader_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRawLandProject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProjName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProjHeader_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLueAdditionalUseArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjAdditionalUseArea_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjAdditionalUseArea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjAdditionalUseArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hleTransferCosts.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcRawLand
            // 
            this.gcRawLand.DataSource = this.bsRawLandHolding;
            this.gcRawLand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRawLand.Location = new System.Drawing.Point(0, 32);
            this.gcRawLand.MainView = this.gvRawLand;
            this.gcRawLand.Name = "gcRawLand";
            this.gcRawLand.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueProjCode,
            this.ri_lueProjName,
            this.ri_meComments,
            this.ri_teNumaric4,
            this.riLueAdditionalUseArea});
            this.gcRawLand.Size = new System.Drawing.Size(1371, 332);
            this.gcRawLand.TabIndex = 0;
            this.gcRawLand.UseEmbeddedNavigator = true;
            this.gcRawLand.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRawLand});
            // 
            // bsRawLandHolding
            // 
            this.bsRawLandHolding.DataMember = "PROJ_LD_RawLandHolding";
            this.bsRawLandHolding.DataSource = this.dsRawLandHolding1;
            // 
            // dsRawLandHolding1
            // 
            this.dsRawLandHolding1.DataSetName = "dsRawLandHolding";
            this.dsRawLandHolding1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvRawLand
            // 
            this.gvRawLand.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPRI_ID,
            this.colRawLand_PRI_ID,
            this.colRawLand_PRI_ID1,
            this.colAdditionalUse_Area,
            this.colNetArea,
            this.colTotalArea,
            this.colComment,
            this.colPROJ_LD_AdditionalUseArea_ID});
            this.gvRawLand.GridControl = this.gcRawLand;
            this.gvRawLand.Name = "gvRawLand";
            this.gvRawLand.OptionsView.ColumnAutoWidth = false;
            this.gvRawLand.OptionsView.ShowFooter = true;
            this.gvRawLand.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvRawLand_InitNewRow);
            this.gvRawLand.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvRawLand_CellValueChanged);
            this.gvRawLand.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvRawLand_InvalidRowException);
            this.gvRawLand.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvRawLand_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPRI_ID
            // 
            this.colPRI_ID.FieldName = "PRI_ID";
            this.colPRI_ID.Name = "colPRI_ID";
            this.colPRI_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colRawLand_PRI_ID
            // 
            this.colRawLand_PRI_ID.Caption = "Raw Land Project";
            this.colRawLand_PRI_ID.ColumnEdit = this.ri_lueProjCode;
            this.colRawLand_PRI_ID.FieldName = "RawLand_PRI_ID";
            this.colRawLand_PRI_ID.Name = "colRawLand_PRI_ID";
            this.colRawLand_PRI_ID.Visible = true;
            this.colRawLand_PRI_ID.VisibleIndex = 0;
            this.colRawLand_PRI_ID.Width = 131;
            // 
            // ri_lueProjCode
            // 
            this.ri_lueProjCode.AutoHeight = false;
            this.ri_lueProjCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueProjCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_id", "pri_id", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_code", "Code", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_name", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_status", "pri_status", 58, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueProjCode.DataSource = this.bs_ProjHeader_Code;
            this.ri_lueProjCode.DisplayMember = "pri_code";
            this.ri_lueProjCode.Name = "ri_lueProjCode";
            this.ri_lueProjCode.NullText = "";
            this.ri_lueProjCode.PopupWidth = 200;
            this.ri_lueProjCode.ValueMember = "pri_id";
            // 
            // bs_ProjHeader_Code
            // 
            this.bs_ProjHeader_Code.DataMember = "PROJ_HEADER";
            this.bs_ProjHeader_Code.DataSource = this.dsRawLandProject1;
            this.bs_ProjHeader_Code.Sort = "pri_code";
            // 
            // dsRawLandProject1
            // 
            this.dsRawLandProject1.DataSetName = "dsRawLandProject";
            this.dsRawLandProject1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colRawLand_PRI_ID1
            // 
            this.colRawLand_PRI_ID1.Caption = "Raw Land Description";
            this.colRawLand_PRI_ID1.ColumnEdit = this.ri_lueProjName;
            this.colRawLand_PRI_ID1.FieldName = "RawLand_PRI_ID";
            this.colRawLand_PRI_ID1.Name = "colRawLand_PRI_ID1";
            this.colRawLand_PRI_ID1.Visible = true;
            this.colRawLand_PRI_ID1.VisibleIndex = 1;
            this.colRawLand_PRI_ID1.Width = 278;
            // 
            // ri_lueProjName
            // 
            this.ri_lueProjName.AutoHeight = false;
            this.ri_lueProjName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueProjName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_id", "pri_id", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_name", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_code", "Code", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_status", "pri_status", 58, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueProjName.DataSource = this.bs_ProjHeader_Name;
            this.ri_lueProjName.DisplayMember = "pri_name";
            this.ri_lueProjName.Name = "ri_lueProjName";
            this.ri_lueProjName.NullText = "";
            this.ri_lueProjName.PopupWidth = 200;
            this.ri_lueProjName.ValueMember = "pri_id";
            // 
            // bs_ProjHeader_Name
            // 
            this.bs_ProjHeader_Name.DataMember = "PROJ_HEADER";
            this.bs_ProjHeader_Name.DataSource = this.dsRawLandProject1;
            this.bs_ProjHeader_Name.Sort = "pri_name";
            // 
            // colAdditionalUse_Area
            // 
            this.colAdditionalUse_Area.Caption = "Additional Use Area";
            this.colAdditionalUse_Area.ColumnEdit = this.ri_teNumaric4;
            this.colAdditionalUse_Area.FieldName = "AdditionalUse_Area";
            this.colAdditionalUse_Area.Name = "colAdditionalUse_Area";
            this.colAdditionalUse_Area.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdditionalUse_Area", "{0:n4}")});
            this.colAdditionalUse_Area.Visible = true;
            this.colAdditionalUse_Area.VisibleIndex = 4;
            this.colAdditionalUse_Area.Width = 116;
            // 
            // ri_teNumaric4
            // 
            this.ri_teNumaric4.AutoHeight = false;
            this.ri_teNumaric4.Mask.EditMask = "N4";
            this.ri_teNumaric4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric4.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric4.Name = "ri_teNumaric4";
            // 
            // colNetArea
            // 
            this.colNetArea.ColumnEdit = this.ri_teNumaric4;
            this.colNetArea.FieldName = "NetArea";
            this.colNetArea.Name = "colNetArea";
            this.colNetArea.OptionsColumn.AllowEdit = false;
            this.colNetArea.OptionsColumn.ReadOnly = true;
            this.colNetArea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetArea", "{0:n4}")});
            this.colNetArea.Visible = true;
            this.colNetArea.VisibleIndex = 5;
            this.colNetArea.Width = 98;
            // 
            // colTotalArea
            // 
            this.colTotalArea.ColumnEdit = this.ri_teNumaric4;
            this.colTotalArea.FieldName = "TotalArea";
            this.colTotalArea.Name = "colTotalArea";
            this.colTotalArea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalArea", "{0:n4}")});
            this.colTotalArea.Visible = true;
            this.colTotalArea.VisibleIndex = 3;
            this.colTotalArea.Width = 114;
            // 
            // colComment
            // 
            this.colComment.ColumnEdit = this.ri_meComments;
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 6;
            this.colComment.Width = 369;
            // 
            // ri_meComments
            // 
            this.ri_meComments.AutoHeight = false;
            this.ri_meComments.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_meComments.Name = "ri_meComments";
            this.ri_meComments.ShowIcon = false;
            // 
            // colPROJ_LD_AdditionalUseArea_ID
            // 
            this.colPROJ_LD_AdditionalUseArea_ID.Caption = "Use Area";
            this.colPROJ_LD_AdditionalUseArea_ID.ColumnEdit = this.riLueAdditionalUseArea;
            this.colPROJ_LD_AdditionalUseArea_ID.FieldName = "PROJ_LD_AdditionalUseArea_ID";
            this.colPROJ_LD_AdditionalUseArea_ID.Name = "colPROJ_LD_AdditionalUseArea_ID";
            this.colPROJ_LD_AdditionalUseArea_ID.Visible = true;
            this.colPROJ_LD_AdditionalUseArea_ID.VisibleIndex = 2;
            this.colPROJ_LD_AdditionalUseArea_ID.Width = 227;
            // 
            // riLueAdditionalUseArea
            // 
            this.riLueAdditionalUseArea.AutoHeight = false;
            this.riLueAdditionalUseArea.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLueAdditionalUseArea.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRI_ID", "PRI_ID", 44, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Original", "Original", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comment", "Comment", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_status", "pri_status", 58, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.riLueAdditionalUseArea.DataSource = this.bsProjAdditionalUseArea_All;
            this.riLueAdditionalUseArea.DisplayMember = "Description";
            this.riLueAdditionalUseArea.Name = "riLueAdditionalUseArea";
            this.riLueAdditionalUseArea.NullText = "";
            this.riLueAdditionalUseArea.ValueMember = "ID";
            this.riLueAdditionalUseArea.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.riLueAdditionalUseArea_QueryPopUp);
            // 
            // bsProjAdditionalUseArea_All
            // 
            this.bsProjAdditionalUseArea_All.DataMember = "PROJ_LD_AdditionalUseArea";
            this.bsProjAdditionalUseArea_All.DataSource = this.dsProjAdditionalUseArea1;
            // 
            // dsProjAdditionalUseArea1
            // 
            this.dsProjAdditionalUseArea1.DataSetName = "dsProjAdditionalUseArea";
            this.dsProjAdditionalUseArea1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 4, "PRI_ID")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
    "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, "RawLand_PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, "PROJ_LD_AdditionalUseArea_ID"),
            new System.Data.SqlClient.SqlParameter("@AdditionalUse_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUse_Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, "RawLand_PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, "PROJ_LD_AdditionalUseArea_ID"),
            new System.Data.SqlClient.SqlParameter("@AdditionalUse_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUse_Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RawLand_PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RawLand_PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PROJ_LD_AdditionalUseArea_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PROJ_LD_AdditionalUseArea_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalUse_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalUse_Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalUse_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUse_Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RawLand_PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RawLand_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RawLand_PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PROJ_LD_AdditionalUseArea_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PROJ_LD_AdditionalUseArea_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PROJ_LD_AdditionalUseArea_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalUse_Area", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalUse_Area", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalUse_Area", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUse_Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null)});
            // 
            // daRawLandHolding
            // 
            this.daRawLandHolding.DeleteCommand = this.sqlDeleteCommand1;
            this.daRawLandHolding.InsertCommand = this.sqlInsertCommand1;
            this.daRawLandHolding.SelectCommand = this.sqlSelectCommand1;
            this.daRawLandHolding.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LD_RawLandHolding", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("RawLand_PRI_ID", "RawLand_PRI_ID"),
                        new System.Data.Common.DataColumnMapping("PROJ_LD_AdditionalUseArea_ID", "PROJ_LD_AdditionalUseArea_ID"),
                        new System.Data.Common.DataColumnMapping("AdditionalUse_Area", "AdditionalUse_Area"),
                        new System.Data.Common.DataColumnMapping("NetArea", "NetArea"),
                        new System.Data.Common.DataColumnMapping("TotalArea", "TotalArea"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment")})});
            this.daRawLandHolding.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // daRawLandProject
            // 
            this.daRawLandProject.DeleteCommand = this.sqlDeleteCommand2;
            this.daRawLandProject.InsertCommand = this.sqlInsertCommand2;
            this.daRawLandProject.SelectCommand = this.sqlSelectCommand2;
            this.daRawLandProject.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_HEADER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("pri_status", "pri_status")})});
            this.daRawLandProject.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_status", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@pri_status", System.Data.SqlDbType.VarChar, 0, "pri_status")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        pri_id, pri_code, pri_name, pri_status\r\nFROM            PROJ_HEADER" +
    "\r\nWHERE        (LandSubType = \'R\') AND (pri_type = \'PLC\')";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@pri_status", System.Data.SqlDbType.VarChar, 0, "pri_status"),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // daProjAdditionalUseArea
            // 
            this.daProjAdditionalUseArea.SelectCommand = this.sqlSelectCommand3;
            this.daProjAdditionalUseArea.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LD_AdditionalUseArea", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Original", "Original"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
                        new System.Data.Common.DataColumnMapping("pri_status", "pri_status")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // bsProjAdditionalUseArea
            // 
            this.bsProjAdditionalUseArea.DataMember = "PROJ_LD_AdditionalUseArea";
            this.bsProjAdditionalUseArea.DataSource = this.dsProjAdditionalUseArea1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.hleTransferCosts);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1371, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // hleTransferCosts
            // 
            this.hleTransferCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hleTransferCosts.EditValue = "Transfer costs from RLH";
            this.hleTransferCosts.Location = new System.Drawing.Point(1200, 5);
            this.hleTransferCosts.Name = "hleTransferCosts";
            this.hleTransferCosts.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hleTransferCosts.Properties.Appearance.Options.UseBackColor = true;
            this.hleTransferCosts.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hleTransferCosts.Properties.Image = ((System.Drawing.Image)(resources.GetObject("hleTransferCosts.Properties.Image")));
            this.hleTransferCosts.RESG_ImageType = ReflexImgSrc.Image.ImageType.ConvertToRange;
            this.hleTransferCosts.Size = new System.Drawing.Size(166, 30);
            this.hleTransferCosts.TabIndex = 0;
            this.hleTransferCosts.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hleTransferCosts_OpenLink);
            // 
            // ucRawLandHolding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcRawLand);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucRawLandHolding";
            this.Size = new System.Drawing.Size(1371, 364);
            this.Load += new System.EventHandler(this.ucRawLandHolding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcRawLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRawLandHolding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRawLandHolding1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRawLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProjCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProjHeader_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRawLandProject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueProjName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ProjHeader_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLueAdditionalUseArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjAdditionalUseArea_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjAdditionalUseArea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjAdditionalUseArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hleTransferCosts.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcRawLand;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRawLand;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daRawLandHolding;
        private dsRawLandHolding dsRawLandHolding1;
        private System.Data.SqlClient.SqlDataAdapter daRawLandProject;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private dsRawLandProject dsRawLandProject1;
        private System.Windows.Forms.BindingSource bs_ProjHeader_Code;
        private System.Windows.Forms.BindingSource bs_ProjHeader_Name;
        private System.Windows.Forms.BindingSource bsRawLandHolding;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRawLand_PRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalUse_Area;
        private DevExpress.XtraGrid.Columns.GridColumn colNetArea;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalArea;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueProjCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueProjName;
        private DevExpress.XtraGrid.Columns.GridColumn colRawLand_PRI_ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit ri_meComments;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric4;
        private System.Data.SqlClient.SqlDataAdapter daProjAdditionalUseArea;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private dsProjAdditionalUseArea dsProjAdditionalUseArea1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJ_LD_AdditionalUseArea_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLueAdditionalUseArea;
        private System.Windows.Forms.BindingSource bsProjAdditionalUseArea_All;
        private System.Windows.Forms.BindingSource bsProjAdditionalUseArea;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private ReflexEditors.RHyperLinkEdit hleTransferCosts;
    }
}
