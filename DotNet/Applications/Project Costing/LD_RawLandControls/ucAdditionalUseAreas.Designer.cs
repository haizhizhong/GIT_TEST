namespace LD_RawLandControls
{
    partial class ucAdditionalUseAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdditionalUseAreas));
            this.gcAdditionalUseAreas = new DevExpress.XtraGrid.GridControl();
            this.bsAdditionalUseAreas = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdditionalUseAreas1 = new LD_RawLandControls.dsAdditionalUseAreas();
            this.gvAdditionalUseAreas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teText50 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colOriginal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colProjectAllocated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstimateAllocated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAreaRemaining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_meComment = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daAdditionalUseAreas = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdditionalUseAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdditionalUseAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionalUseAreas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdditionalUseAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComment)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAdditionalUseAreas
            // 
            this.gcAdditionalUseAreas.DataSource = this.bsAdditionalUseAreas;
            this.gcAdditionalUseAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAdditionalUseAreas.Location = new System.Drawing.Point(0, 0);
            this.gcAdditionalUseAreas.MainView = this.gvAdditionalUseAreas;
            this.gcAdditionalUseAreas.Name = "gcAdditionalUseAreas";
            this.gcAdditionalUseAreas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teText50,
            this.ri_teNumaric4,
            this.ri_meComment});
            this.gcAdditionalUseAreas.Size = new System.Drawing.Size(1306, 385);
            this.gcAdditionalUseAreas.TabIndex = 0;
            this.gcAdditionalUseAreas.UseEmbeddedNavigator = true;
            this.gcAdditionalUseAreas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdditionalUseAreas});
            // 
            // bsAdditionalUseAreas
            // 
            this.bsAdditionalUseAreas.DataMember = "PROJ_LD_AdditionalUseArea";
            this.bsAdditionalUseAreas.DataSource = this.dsAdditionalUseAreas1;
            // 
            // dsAdditionalUseAreas1
            // 
            this.dsAdditionalUseAreas1.DataSetName = "dsAdditionalUseAreas";
            this.dsAdditionalUseAreas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAdditionalUseAreas
            // 
            this.gvAdditionalUseAreas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPRI_ID,
            this.colDescription,
            this.colOriginal,
            this.colProjectAllocated,
            this.colEstimateAllocated,
            this.colAreaRemaining,
            this.colComment});
            this.gvAdditionalUseAreas.GridControl = this.gcAdditionalUseAreas;
            this.gvAdditionalUseAreas.Name = "gvAdditionalUseAreas";
            this.gvAdditionalUseAreas.OptionsView.ColumnAutoWidth = false;
            this.gvAdditionalUseAreas.OptionsView.ShowFooter = true;
            this.gvAdditionalUseAreas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvAdditionalUseAreas_CellValueChanged);
            this.gvAdditionalUseAreas.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvAdditionalUseAreas_InitNewRow);
            this.gvAdditionalUseAreas.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvAdditionalUseAreas_InvalidRowException);
            this.gvAdditionalUseAreas.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvAdditionalUseAreas_ValidateRow);
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
            // colDescription
            // 
            this.colDescription.ColumnEdit = this.ri_teText50;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 233;
            // 
            // ri_teText50
            // 
            this.ri_teText50.AutoHeight = false;
            this.ri_teText50.MaxLength = 50;
            this.ri_teText50.Name = "ri_teText50";
            // 
            // colOriginal
            // 
            this.colOriginal.ColumnEdit = this.ri_teNumaric4;
            this.colOriginal.FieldName = "Original";
            this.colOriginal.Name = "colOriginal";
            this.colOriginal.SummaryItem.DisplayFormat = "{0:n4}";
            this.colOriginal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOriginal.Visible = true;
            this.colOriginal.VisibleIndex = 1;
            this.colOriginal.Width = 137;
            // 
            // ri_teNumaric4
            // 
            this.ri_teNumaric4.AutoHeight = false;
            this.ri_teNumaric4.Mask.EditMask = "N4";
            this.ri_teNumaric4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric4.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric4.Name = "ri_teNumaric4";
            // 
            // colProjectAllocated
            // 
            this.colProjectAllocated.ColumnEdit = this.ri_teNumaric4;
            this.colProjectAllocated.FieldName = "ProjectAllocated";
            this.colProjectAllocated.Name = "colProjectAllocated";
            this.colProjectAllocated.OptionsColumn.AllowEdit = false;
            this.colProjectAllocated.OptionsColumn.ReadOnly = true;
            this.colProjectAllocated.SummaryItem.DisplayFormat = "{0:n4}";
            this.colProjectAllocated.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colProjectAllocated.Visible = true;
            this.colProjectAllocated.VisibleIndex = 2;
            this.colProjectAllocated.Width = 143;
            // 
            // colEstimateAllocated
            // 
            this.colEstimateAllocated.ColumnEdit = this.ri_teNumaric4;
            this.colEstimateAllocated.FieldName = "EstimateAllocated";
            this.colEstimateAllocated.Name = "colEstimateAllocated";
            this.colEstimateAllocated.OptionsColumn.AllowEdit = false;
            this.colEstimateAllocated.OptionsColumn.ReadOnly = true;
            this.colEstimateAllocated.SummaryItem.DisplayFormat = "{0:n4}";
            this.colEstimateAllocated.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colEstimateAllocated.Visible = true;
            this.colEstimateAllocated.VisibleIndex = 3;
            this.colEstimateAllocated.Width = 110;
            // 
            // colAreaRemaining
            // 
            this.colAreaRemaining.ColumnEdit = this.ri_teNumaric4;
            this.colAreaRemaining.FieldName = "AreaRemaining";
            this.colAreaRemaining.Name = "colAreaRemaining";
            this.colAreaRemaining.OptionsColumn.AllowEdit = false;
            this.colAreaRemaining.OptionsColumn.ReadOnly = true;
            this.colAreaRemaining.SummaryItem.DisplayFormat = "{0:n4}";
            this.colAreaRemaining.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAreaRemaining.Visible = true;
            this.colAreaRemaining.VisibleIndex = 4;
            this.colAreaRemaining.Width = 151;
            // 
            // colComment
            // 
            this.colComment.ColumnEdit = this.ri_meComment;
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 5;
            this.colComment.Width = 389;
            // 
            // ri_meComment
            // 
            this.ri_meComment.AutoHeight = false;
            this.ri_meComment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_meComment.Name = "ri_meComment";
            this.ri_meComment.ShowIcon = false;
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
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Original", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Original", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Original", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Original", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Original", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Original", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Original", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Original", System.Data.DataRowVersion.Original, null)});
            // 
            // daAdditionalUseAreas
            // 
            this.daAdditionalUseAreas.DeleteCommand = this.sqlDeleteCommand1;
            this.daAdditionalUseAreas.InsertCommand = this.sqlInsertCommand1;
            this.daAdditionalUseAreas.SelectCommand = this.sqlSelectCommand1;
            this.daAdditionalUseAreas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LD_AdditionalUseArea", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Original", "Original"),
                        new System.Data.Common.DataColumnMapping("ProjectAllocated", "ProjectAllocated"),
                        new System.Data.Common.DataColumnMapping("EstimateAllocated", "EstimateAllocated"),
                        new System.Data.Common.DataColumnMapping("AreaRemaining", "AreaRemaining"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment")})});
            this.daAdditionalUseAreas.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucAdditionalUseAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcAdditionalUseAreas);
            this.Name = "ucAdditionalUseAreas";
            this.Size = new System.Drawing.Size(1306, 385);
            this.Load += new System.EventHandler(this.ucAdditionalUseAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdditionalUseAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdditionalUseAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionalUseAreas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdditionalUseAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAdditionalUseAreas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdditionalUseAreas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daAdditionalUseAreas;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Windows.Forms.BindingSource bsAdditionalUseAreas;
        private dsAdditionalUseAreas dsAdditionalUseAreas1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teText50;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric4;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectAllocated;
        private DevExpress.XtraGrid.Columns.GridColumn colEstimateAllocated;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit ri_meComment;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaRemaining;
    }
}
