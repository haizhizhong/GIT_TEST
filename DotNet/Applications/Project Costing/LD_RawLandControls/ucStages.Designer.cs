namespace LD_RawLandControls
{
    partial class ucStages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStages));
            this.gcStages = new DevExpress.XtraGrid.GridControl();
            this.bsStages = new System.Windows.Forms.BindingSource(this.components);
            this.dsStages1 = new LD_RawLandControls.dsStages();
            this.gvStages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teText20 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teText50 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTotalArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAdditionalUseArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_meComment = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daStages = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcStages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStages1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComment)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStages
            // 
            this.gcStages.DataSource = this.bsStages;
            this.gcStages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStages.Location = new System.Drawing.Point(0, 0);
            this.gcStages.MainView = this.gvStages;
            this.gcStages.Name = "gcStages";
            this.gcStages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teText20,
            this.ri_teText50,
            this.ri_teNumaric4,
            this.ri_meComment});
            this.gcStages.Size = new System.Drawing.Size(1370, 410);
            this.gcStages.TabIndex = 0;
            this.gcStages.UseEmbeddedNavigator = true;
            this.gcStages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStages});
            // 
            // bsStages
            // 
            this.bsStages.DataMember = "PROJ_LD_Stages";
            this.bsStages.DataSource = this.dsStages1;
            // 
            // dsStages1
            // 
            this.dsStages1.DataSetName = "dsStages";
            this.dsStages1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvStages
            // 
            this.gvStages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPRI_ID,
            this.colCode,
            this.colDescription,
            this.colTotalArea,
            this.colAdditionalUseArea,
            this.colNetArea,
            this.colComment});
            this.gvStages.GridControl = this.gcStages;
            this.gvStages.Name = "gvStages";
            this.gvStages.OptionsView.ColumnAutoWidth = false;
            this.gvStages.OptionsView.ShowFooter = true;
            this.gvStages.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvStages_CellValueChanged);
            this.gvStages.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvStages_InitNewRow);
            this.gvStages.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvStages_InvalidRowException);
            this.gvStages.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvStages_ValidateRow);
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
            // colCode
            // 
            this.colCode.ColumnEdit = this.ri_teText20;
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 133;
            // 
            // ri_teText20
            // 
            this.ri_teText20.AutoHeight = false;
            this.ri_teText20.MaxLength = 20;
            this.ri_teText20.Name = "ri_teText20";
            // 
            // colDescription
            // 
            this.colDescription.ColumnEdit = this.ri_teText50;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 357;
            // 
            // ri_teText50
            // 
            this.ri_teText50.AutoHeight = false;
            this.ri_teText50.MaxLength = 50;
            this.ri_teText50.Name = "ri_teText50";
            // 
            // colTotalArea
            // 
            this.colTotalArea.ColumnEdit = this.ri_teNumaric4;
            this.colTotalArea.FieldName = "TotalArea";
            this.colTotalArea.Name = "colTotalArea";
            this.colTotalArea.SummaryItem.DisplayFormat = "{0:N4}";
            this.colTotalArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalArea.Visible = true;
            this.colTotalArea.VisibleIndex = 2;
            this.colTotalArea.Width = 142;
            // 
            // ri_teNumaric4
            // 
            this.ri_teNumaric4.AutoHeight = false;
            this.ri_teNumaric4.Mask.EditMask = "N4";
            this.ri_teNumaric4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric4.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric4.Name = "ri_teNumaric4";
            // 
            // colAdditionalUseArea
            // 
            this.colAdditionalUseArea.ColumnEdit = this.ri_teNumaric4;
            this.colAdditionalUseArea.FieldName = "AdditionalUseArea";
            this.colAdditionalUseArea.Name = "colAdditionalUseArea";
            this.colAdditionalUseArea.SummaryItem.DisplayFormat = "{0:N4}";
            this.colAdditionalUseArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAdditionalUseArea.Visible = true;
            this.colAdditionalUseArea.VisibleIndex = 3;
            this.colAdditionalUseArea.Width = 132;
            // 
            // colNetArea
            // 
            this.colNetArea.ColumnEdit = this.ri_teNumaric4;
            this.colNetArea.FieldName = "NetArea";
            this.colNetArea.Name = "colNetArea";
            this.colNetArea.OptionsColumn.AllowEdit = false;
            this.colNetArea.OptionsColumn.ReadOnly = true;
            this.colNetArea.SummaryItem.DisplayFormat = "{0:N4}";
            this.colNetArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNetArea.Visible = true;
            this.colNetArea.VisibleIndex = 4;
            this.colNetArea.Width = 135;
            // 
            // colComment
            // 
            this.colComment.ColumnEdit = this.ri_meComment;
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 5;
            this.colComment.Width = 428;
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
            this.sqlSelectCommand1.CommandText = "SELECT        ID, PRI_ID, Code, Description, TotalArea, AdditionalUseArea, isnull" +
                "( TotalArea, 0) - isnull(AdditionalUseArea, 0)[NetArea],Comment\r\nFROM           " +
                " PROJ_LD_Stages\r\nwhere PRI_ID = @PRI_ID";
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
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AdditionalUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUseArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AdditionalUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUseArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.VarChar, 0, "Comment"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalUseArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalUseArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUseArea", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalUseArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalUseArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionalUseArea", System.Data.DataRowVersion.Original, null)});
            // 
            // daStages
            // 
            this.daStages.DeleteCommand = this.sqlDeleteCommand1;
            this.daStages.InsertCommand = this.sqlInsertCommand1;
            this.daStages.SelectCommand = this.sqlSelectCommand1;
            this.daStages.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LD_Stages", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("TotalArea", "TotalArea"),
                        new System.Data.Common.DataColumnMapping("AdditionalUseArea", "AdditionalUseArea"),
                        new System.Data.Common.DataColumnMapping("NetArea", "NetArea"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment")})});
            this.daStages.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucStages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcStages);
            this.Name = "ucStages";
            this.Size = new System.Drawing.Size(1370, 410);
            this.Load += new System.EventHandler(this.ucStages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStages1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_meComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStages;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStages;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daStages;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private dsStages dsStages1;
        private System.Windows.Forms.BindingSource bsStages;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teText20;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teText50;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric4;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalUseArea;
        private DevExpress.XtraGrid.Columns.GridColumn colNetArea;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit ri_meComment;
    }
}
