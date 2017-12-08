namespace LD_RawLandControls
{
    partial class ucProjectAllocated
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
            this.gcAllocated = new DevExpress.XtraGrid.GridControl();
            this.dsProjectAllocated1 = new LD_RawLandControls.dsProjectAllocated();
            this.gvAllocated = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprofit_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprofit_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldivision_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldivision_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproject_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladd_use_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.daProjectAllocated = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcAllocated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjectAllocated1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllocated)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAllocated
            // 
            this.gcAllocated.DataMember = "LD_ProjectAllocated_RLH";
            this.gcAllocated.DataSource = this.dsProjectAllocated1;
            this.gcAllocated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAllocated.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAllocated.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAllocated.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAllocated.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAllocated.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAllocated.Location = new System.Drawing.Point(0, 0);
            this.gcAllocated.MainView = this.gvAllocated;
            this.gcAllocated.Name = "gcAllocated";
            this.gcAllocated.Size = new System.Drawing.Size(1141, 390);
            this.gcAllocated.TabIndex = 0;
            this.gcAllocated.UseEmbeddedNavigator = true;
            this.gcAllocated.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAllocated});
            // 
            // dsProjectAllocated1
            // 
            this.dsProjectAllocated1.DataSetName = "dsProjectAllocated";
            this.dsProjectAllocated1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAllocated
            // 
            this.gvAllocated.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpri_code,
            this.colpri_name,
            this.colpri_status,
            this.colprofit_code,
            this.colprofit_desc,
            this.coldivision_code,
            this.coldivision_desc,
            this.colproject_area,
            this.coladd_use_area,
            this.coltotal_area});
            this.gvAllocated.GridControl = this.gcAllocated;
            this.gvAllocated.Name = "gvAllocated";
            this.gvAllocated.OptionsView.ColumnAutoWidth = false;
            this.gvAllocated.OptionsView.ShowFooter = true;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 0;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.OptionsColumn.AllowEdit = false;
            this.colpri_name.Visible = true;
            this.colpri_name.VisibleIndex = 1;
            this.colpri_name.Width = 135;
            // 
            // colpri_status
            // 
            this.colpri_status.Caption = "Status";
            this.colpri_status.FieldName = "pri_status";
            this.colpri_status.Name = "colpri_status";
            this.colpri_status.OptionsColumn.AllowEdit = false;
            this.colpri_status.Visible = true;
            this.colpri_status.VisibleIndex = 2;
            // 
            // colprofit_code
            // 
            this.colprofit_code.FieldName = "profit_code";
            this.colprofit_code.Name = "colprofit_code";
            this.colprofit_code.OptionsColumn.AllowEdit = false;
            this.colprofit_code.Visible = true;
            this.colprofit_code.VisibleIndex = 3;
            // 
            // colprofit_desc
            // 
            this.colprofit_desc.FieldName = "profit_desc";
            this.colprofit_desc.Name = "colprofit_desc";
            this.colprofit_desc.OptionsColumn.AllowEdit = false;
            this.colprofit_desc.Visible = true;
            this.colprofit_desc.VisibleIndex = 4;
            this.colprofit_desc.Width = 111;
            // 
            // coldivision_code
            // 
            this.coldivision_code.FieldName = "division_code";
            this.coldivision_code.Name = "coldivision_code";
            this.coldivision_code.OptionsColumn.AllowEdit = false;
            this.coldivision_code.Visible = true;
            this.coldivision_code.VisibleIndex = 5;
            this.coldivision_code.Width = 87;
            // 
            // coldivision_desc
            // 
            this.coldivision_desc.FieldName = "division_desc";
            this.coldivision_desc.Name = "coldivision_desc";
            this.coldivision_desc.OptionsColumn.AllowEdit = false;
            this.coldivision_desc.Visible = true;
            this.coldivision_desc.VisibleIndex = 6;
            this.coldivision_desc.Width = 167;
            // 
            // colproject_area
            // 
            this.colproject_area.Caption = "Project Area";
            this.colproject_area.DisplayFormat.FormatString = "n4";
            this.colproject_area.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colproject_area.FieldName = "project_area";
            this.colproject_area.Name = "colproject_area";
            this.colproject_area.OptionsColumn.AllowEdit = false;
            this.colproject_area.SummaryItem.DisplayFormat = "{0:n4}";
            this.colproject_area.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colproject_area.Visible = true;
            this.colproject_area.VisibleIndex = 7;
            this.colproject_area.Width = 106;
            // 
            // coladd_use_area
            // 
            this.coladd_use_area.Caption = "Additional Use Area";
            this.coladd_use_area.DisplayFormat.FormatString = "n4";
            this.coladd_use_area.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coladd_use_area.FieldName = "add_use_area";
            this.coladd_use_area.Name = "coladd_use_area";
            this.coladd_use_area.OptionsColumn.AllowEdit = false;
            this.coladd_use_area.SummaryItem.DisplayFormat = "{0:n4}";
            this.coladd_use_area.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.coladd_use_area.Visible = true;
            this.coladd_use_area.VisibleIndex = 8;
            this.coladd_use_area.Width = 116;
            // 
            // coltotal_area
            // 
            this.coltotal_area.Caption = "Total Area";
            this.coltotal_area.DisplayFormat.FormatString = "n4";
            this.coltotal_area.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_area.FieldName = "total_area";
            this.coltotal_area.Name = "coltotal_area";
            this.coltotal_area.OptionsColumn.AllowEdit = false;
            this.coltotal_area.SummaryItem.DisplayFormat = "{0:n4}";
            this.coltotal_area.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.coltotal_area.Visible = true;
            this.coltotal_area.VisibleIndex = 9;
            this.coltotal_area.Width = 114;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.LD_ProjectAllocated_RLH";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // daProjectAllocated
            // 
            this.daProjectAllocated.SelectCommand = this.sqlSelectCommand1;
            this.daProjectAllocated.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ProjectAllocated_RLH", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("pri_status", "pri_status"),
                        new System.Data.Common.DataColumnMapping("profit_code", "profit_code"),
                        new System.Data.Common.DataColumnMapping("profit_desc", "profit_desc"),
                        new System.Data.Common.DataColumnMapping("division_code", "division_code"),
                        new System.Data.Common.DataColumnMapping("division_desc", "division_desc"),
                        new System.Data.Common.DataColumnMapping("project_area", "project_area"),
                        new System.Data.Common.DataColumnMapping("add_use_area", "add_use_area"),
                        new System.Data.Common.DataColumnMapping("total_area", "total_area")})});
            // 
            // ucProjectAllocated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcAllocated);
            this.Name = "ucProjectAllocated";
            this.Size = new System.Drawing.Size(1141, 390);
            ((System.ComponentModel.ISupportInitialize)(this.gcAllocated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjectAllocated1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllocated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAllocated;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAllocated;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter daProjectAllocated;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private dsProjectAllocated dsProjectAllocated1;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_status;
        private DevExpress.XtraGrid.Columns.GridColumn colprofit_code;
        private DevExpress.XtraGrid.Columns.GridColumn colprofit_desc;
        private DevExpress.XtraGrid.Columns.GridColumn coldivision_code;
        private DevExpress.XtraGrid.Columns.GridColumn coldivision_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colproject_area;
        private DevExpress.XtraGrid.Columns.GridColumn coladd_use_area;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_area;
    }
}
