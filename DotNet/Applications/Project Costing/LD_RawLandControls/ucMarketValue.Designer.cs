namespace LD_RawLandControls
{
    partial class ucMarketValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMarketValue));
            this.gcMarketValue = new DevExpress.XtraGrid.GridControl();
            this.bsMarketValue = new System.Windows.Forms.BindingSource(this.components);
            this.dsMarketValue1 = new LD_RawLandControls.dsMarketValue();
            this.gvMarketValue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAsAtDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastChangedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastChangedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daMarketValue = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcMarketValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarketValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarketValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarketValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMarketValue
            // 
            this.gcMarketValue.DataSource = this.bsMarketValue;
            this.gcMarketValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMarketValue.Location = new System.Drawing.Point(0, 0);
            this.gcMarketValue.MainView = this.gvMarketValue;
            this.gcMarketValue.Name = "gcMarketValue";
            this.gcMarketValue.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teNumaric2});
            this.gcMarketValue.Size = new System.Drawing.Size(1239, 474);
            this.gcMarketValue.TabIndex = 0;
            this.gcMarketValue.UseEmbeddedNavigator = true;
            this.gcMarketValue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMarketValue});
            // 
            // bsMarketValue
            // 
            this.bsMarketValue.DataMember = "PROJ_LD_MarketValue";
            this.bsMarketValue.DataSource = this.dsMarketValue1;
            // 
            // dsMarketValue1
            // 
            this.dsMarketValue1.DataSetName = "dsMarketValue";
            this.dsMarketValue1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMarketValue
            // 
            this.gvMarketValue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPRI_ID,
            this.colMarketValue,
            this.colAsAtDate,
            this.colLastChangedDate,
            this.colLastChangedBy});
            this.gvMarketValue.GridControl = this.gcMarketValue;
            this.gvMarketValue.Name = "gvMarketValue";
            this.gvMarketValue.OptionsView.ColumnAutoWidth = false;
            this.gvMarketValue.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvMarketValue_InitNewRow);
            this.gvMarketValue.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvMarketValue_InvalidRowException);
            this.gvMarketValue.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvMarketValue_ValidateRow);
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
            // colMarketValue
            // 
            this.colMarketValue.ColumnEdit = this.ri_teNumaric2;
            this.colMarketValue.FieldName = "MarketValue";
            this.colMarketValue.Name = "colMarketValue";
            this.colMarketValue.Visible = true;
            this.colMarketValue.VisibleIndex = 1;
            this.colMarketValue.Width = 161;
            // 
            // ri_teNumaric2
            // 
            this.ri_teNumaric2.AutoHeight = false;
            this.ri_teNumaric2.Mask.EditMask = "N2";
            this.ri_teNumaric2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ri_teNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.ri_teNumaric2.Name = "ri_teNumaric2";
            // 
            // colAsAtDate
            // 
            this.colAsAtDate.FieldName = "AsAtDate";
            this.colAsAtDate.Name = "colAsAtDate";
            this.colAsAtDate.Visible = true;
            this.colAsAtDate.VisibleIndex = 0;
            this.colAsAtDate.Width = 142;
            // 
            // colLastChangedDate
            // 
            this.colLastChangedDate.FieldName = "LastChangedDate";
            this.colLastChangedDate.Name = "colLastChangedDate";
            this.colLastChangedDate.OptionsColumn.AllowEdit = false;
            this.colLastChangedDate.OptionsColumn.ReadOnly = true;
            this.colLastChangedDate.Visible = true;
            this.colLastChangedDate.VisibleIndex = 2;
            this.colLastChangedDate.Width = 176;
            // 
            // colLastChangedBy
            // 
            this.colLastChangedBy.FieldName = "LastChangedBy";
            this.colLastChangedBy.Name = "colLastChangedBy";
            this.colLastChangedBy.OptionsColumn.AllowEdit = false;
            this.colLastChangedBy.OptionsColumn.ReadOnly = true;
            this.colLastChangedBy.Visible = true;
            this.colLastChangedBy.VisibleIndex = 3;
            this.colLastChangedBy.Width = 173;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        ID, PRI_ID, MarketValue, AsAtDate, LastChangedDate, LastChangedBy\r\n" +
                "FROM            PROJ_LD_MarketValue\r\nwhere PRI_ID = @PRI_ID\r\nORDER BY AsAtDate";
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
            new System.Data.SqlClient.SqlParameter("@MarketValue", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "MarketValue", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AsAtDate", System.Data.SqlDbType.Date, 0, "AsAtDate"),
            new System.Data.SqlClient.SqlParameter("@LastChangedDate", System.Data.SqlDbType.Date, 0, "LastChangedDate"),
            new System.Data.SqlClient.SqlParameter("@LastChangedBy", System.Data.SqlDbType.VarChar, 0, "LastChangedBy")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@MarketValue", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "MarketValue", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@AsAtDate", System.Data.SqlDbType.Date, 0, "AsAtDate"),
            new System.Data.SqlClient.SqlParameter("@LastChangedDate", System.Data.SqlDbType.Date, 0, "LastChangedDate"),
            new System.Data.SqlClient.SqlParameter("@LastChangedBy", System.Data.SqlDbType.VarChar, 0, "LastChangedBy"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MarketValue", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MarketValue", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MarketValue", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "MarketValue", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LastChangedDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastChangedDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LastChangedDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastChangedDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LastChangedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastChangedBy", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LastChangedBy", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastChangedBy", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_MarketValue", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MarketValue", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MarketValue", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "MarketValue", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LastChangedDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastChangedDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LastChangedDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastChangedDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LastChangedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastChangedBy", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LastChangedBy", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastChangedBy", System.Data.DataRowVersion.Original, null)});
            // 
            // daMarketValue
            // 
            this.daMarketValue.DeleteCommand = this.sqlDeleteCommand1;
            this.daMarketValue.InsertCommand = this.sqlInsertCommand1;
            this.daMarketValue.SelectCommand = this.sqlSelectCommand1;
            this.daMarketValue.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LD_MarketValue", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("MarketValue", "MarketValue"),
                        new System.Data.Common.DataColumnMapping("AsAtDate", "AsAtDate"),
                        new System.Data.Common.DataColumnMapping("LastChangedDate", "LastChangedDate"),
                        new System.Data.Common.DataColumnMapping("LastChangedBy", "LastChangedBy")})});
            this.daMarketValue.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucMarketValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMarketValue);
            this.Name = "ucMarketValue";
            this.Size = new System.Drawing.Size(1239, 474);
            this.Load += new System.EventHandler(this.ucMarketValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMarketValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarketValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarketValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarketValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaric2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMarketValue;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarketValue;
        private System.Windows.Forms.BindingSource bsMarketValue;
        private dsMarketValue dsMarketValue1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketValue;
        private DevExpress.XtraGrid.Columns.GridColumn colAsAtDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastChangedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastChangedBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaric2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daMarketValue;
    }
}
