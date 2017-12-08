namespace LD_RawLandControls
{
    partial class ucPreviousLandUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPreviousLandUse));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_PreviousLandUse = new System.Data.SqlClient.SqlDataAdapter();
            this.ds_PreviousLandUse1 = new LD_RawLandControls.ds_PreviousLandUse();
            this.gcPreviousLandUse = new DevExpress.XtraGrid.GridControl();
            this.lDPreviousLandUseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPreviousLandUse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAdditionaUseArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teText50 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PreviousLandUse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPreviousLandUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDPreviousLandUseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreviousLandUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        ID, pri_id, ProjectName, TotalArea, AdditionaUseArea, NetArea\r\nFROM" +
                "            LD_Previous_LandUse\r\nWHERE        (pri_id = @pri_id)";
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
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
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AdditionaUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionaUseArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NetArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NetArea", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AdditionaUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionaUseArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NetArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NetArea", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionaUseArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionaUseArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionaUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionaUseArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NetArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NetArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NetArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NetArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "TotalArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionaUseArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionaUseArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionaUseArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "AdditionaUseArea", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NetArea", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NetArea", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NetArea", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "NetArea", System.Data.DataRowVersion.Original, null)});
            // 
            // da_PreviousLandUse
            // 
            this.da_PreviousLandUse.DeleteCommand = this.sqlDeleteCommand1;
            this.da_PreviousLandUse.InsertCommand = this.sqlInsertCommand1;
            this.da_PreviousLandUse.SelectCommand = this.sqlSelectCommand1;
            this.da_PreviousLandUse.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Previous_LandUse", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"),
                        new System.Data.Common.DataColumnMapping("TotalArea", "TotalArea"),
                        new System.Data.Common.DataColumnMapping("AdditionaUseArea", "AdditionaUseArea"),
                        new System.Data.Common.DataColumnMapping("NetArea", "NetArea")})});
            this.da_PreviousLandUse.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ds_PreviousLandUse1
            // 
            this.ds_PreviousLandUse1.DataSetName = "ds_PreviousLandUse";
            this.ds_PreviousLandUse1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcPreviousLandUse
            // 
            this.gcPreviousLandUse.DataSource = this.lDPreviousLandUseBindingSource;
            this.gcPreviousLandUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPreviousLandUse.Location = new System.Drawing.Point(0, 0);
            this.gcPreviousLandUse.MainView = this.gvPreviousLandUse;
            this.gcPreviousLandUse.Name = "gcPreviousLandUse";
            this.gcPreviousLandUse.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teNumaric4,
            this.ri_teText50});
            this.gcPreviousLandUse.Size = new System.Drawing.Size(1123, 347);
            this.gcPreviousLandUse.TabIndex = 0;
            this.gcPreviousLandUse.UseEmbeddedNavigator = true;
            this.gcPreviousLandUse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPreviousLandUse});
            // 
            // lDPreviousLandUseBindingSource
            // 
            this.lDPreviousLandUseBindingSource.DataMember = "LD_Previous_LandUse";
            this.lDPreviousLandUseBindingSource.DataSource = this.ds_PreviousLandUse1;
            // 
            // gvPreviousLandUse
            // 
            this.gvPreviousLandUse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colpri_id,
            this.colProjectName,
            this.colTotalArea,
            this.colAdditionaUseArea,
            this.colNetArea});
            this.gvPreviousLandUse.GridControl = this.gcPreviousLandUse;
            this.gvPreviousLandUse.Name = "gvPreviousLandUse";
            this.gvPreviousLandUse.OptionsView.ColumnAutoWidth = false;
            this.gvPreviousLandUse.OptionsView.ShowFooter = true;
            this.gvPreviousLandUse.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvPreviousLandUse_InitNewRow);
            this.gvPreviousLandUse.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvPreviousLandUse_InvalidRowException);
            this.gvPreviousLandUse.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvPreviousLandUse_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colProjectName
            // 
            this.colProjectName.ColumnEdit = this.ri_teText50;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 0;
            this.colProjectName.Width = 256;
            // 
            // colTotalArea
            // 
            this.colTotalArea.ColumnEdit = this.ri_teNumaric4;
            this.colTotalArea.FieldName = "TotalArea";
            this.colTotalArea.Name = "colTotalArea";
            this.colTotalArea.SummaryItem.DisplayFormat = "{0:n4}";
            this.colTotalArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalArea.Visible = true;
            this.colTotalArea.VisibleIndex = 1;
            this.colTotalArea.Width = 166;
            // 
            // ri_teNumaric4
            // 
            this.ri_teNumaric4.AutoHeight = false;
            this.ri_teNumaric4.Mask.EditMask = "n4";
            this.ri_teNumaric4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric4.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric4.Name = "ri_teNumaric4";
            // 
            // colAdditionaUseArea
            // 
            this.colAdditionaUseArea.Caption = "Additional Use Area";
            this.colAdditionaUseArea.ColumnEdit = this.ri_teNumaric4;
            this.colAdditionaUseArea.FieldName = "AdditionaUseArea";
            this.colAdditionaUseArea.Name = "colAdditionaUseArea";
            this.colAdditionaUseArea.SummaryItem.DisplayFormat = "{0:n4}";
            this.colAdditionaUseArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAdditionaUseArea.Visible = true;
            this.colAdditionaUseArea.VisibleIndex = 2;
            this.colAdditionaUseArea.Width = 168;
            // 
            // colNetArea
            // 
            this.colNetArea.ColumnEdit = this.ri_teNumaric4;
            this.colNetArea.FieldName = "NetArea";
            this.colNetArea.Name = "colNetArea";
            this.colNetArea.SummaryItem.DisplayFormat = "{0:n4}";
            this.colNetArea.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNetArea.Visible = true;
            this.colNetArea.VisibleIndex = 3;
            this.colNetArea.Width = 151;
            // 
            // ri_teText50
            // 
            this.ri_teText50.AutoHeight = false;
            this.ri_teText50.MaxLength = 50;
            this.ri_teText50.Name = "ri_teText50";
            // 
            // ucPreviousLandUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcPreviousLandUse);
            this.Name = "ucPreviousLandUse";
            this.Size = new System.Drawing.Size(1123, 347);
            this.Load += new System.EventHandler(this.ucPreviousLandUse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_PreviousLandUse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPreviousLandUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDPreviousLandUseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreviousLandUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teText50)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter da_PreviousLandUse;
        private ds_PreviousLandUse ds_PreviousLandUse1;
        private DevExpress.XtraGrid.GridControl gcPreviousLandUse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPreviousLandUse;
        private System.Windows.Forms.BindingSource lDPreviousLandUseBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalArea;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionaUseArea;
        private DevExpress.XtraGrid.Columns.GridColumn colNetArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teText50;
    }
}
