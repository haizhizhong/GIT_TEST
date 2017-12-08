namespace LD_CashCall
{
    partial class ucProjectSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjectSelection));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSelection = new System.Data.SqlClient.SqlDataAdapter();
            this.dsSelection1 = new LD_CashCall.dsSelection();
            this.gcSelection = new DevExpress.XtraGrid.GridControl();
            this.bsSelection = new System.Windows.Forms.BindingSource(this.components);
            this.gvSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpati_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_site1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsite_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsite_city = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsite_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 10, "username"),
            new System.Data.SqlClient.SqlParameter("@pati_type", System.Data.SqlDbType.VarChar, 1, "pati_type")});
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
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pati_type", System.Data.SqlDbType.VarChar, 0, "pati_type"),
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@ProjectCode", System.Data.SqlDbType.Int, 0, "ProjectCode"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@pri_site1", System.Data.SqlDbType.VarChar, 0, "pri_site1"),
            new System.Data.SqlClient.SqlParameter("@site_address", System.Data.SqlDbType.VarChar, 0, "site_address"),
            new System.Data.SqlClient.SqlParameter("@site_city", System.Data.SqlDbType.VarChar, 0, "site_city"),
            new System.Data.SqlClient.SqlParameter("@site_state", System.Data.SqlDbType.VarChar, 0, "site_state")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pati_type", System.Data.SqlDbType.VarChar, 0, "pati_type"),
            new System.Data.SqlClient.SqlParameter("@PRI_ID", System.Data.SqlDbType.Int, 0, "PRI_ID"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@ProjectCode", System.Data.SqlDbType.Int, 0, "ProjectCode"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@pri_site1", System.Data.SqlDbType.VarChar, 0, "pri_site1"),
            new System.Data.SqlClient.SqlParameter("@site_address", System.Data.SqlDbType.VarChar, 0, "site_address"),
            new System.Data.SqlClient.SqlParameter("@site_city", System.Data.SqlDbType.VarChar, 0, "site_city"),
            new System.Data.SqlClient.SqlParameter("@site_state", System.Data.SqlDbType.VarChar, 0, "site_state"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pati_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pati_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_site1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_site1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_site1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_site1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_state", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_state", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_state", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_state", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_pati_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pati_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRI_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRI_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProjectName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProjectName", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_site1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_site1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_site1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_site1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_site_state", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "site_state", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_site_state", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "site_state", System.Data.DataRowVersion.Original, null)});
            // 
            // daSelection
            // 
            this.daSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daSelection.InsertCommand = this.sqlInsertCommand1;
            this.daSelection.SelectCommand = this.sqlSelectCommand1;
            this.daSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_LD_CashDist_Selection", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("pati_type", "pati_type"),
                        new System.Data.Common.DataColumnMapping("PRI_ID", "PRI_ID"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected"),
                        new System.Data.Common.DataColumnMapping("ProjectCode", "ProjectCode"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"),
                        new System.Data.Common.DataColumnMapping("pri_site1", "pri_site1"),
                        new System.Data.Common.DataColumnMapping("site_address", "site_address"),
                        new System.Data.Common.DataColumnMapping("site_city", "site_city"),
                        new System.Data.Common.DataColumnMapping("site_state", "site_state")})});
            this.daSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsSelection1
            // 
            this.dsSelection1.DataSetName = "dsSelection";
            this.dsSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcSelection
            // 
            this.gcSelection.DataSource = this.bsSelection;
            this.gcSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSelection.Location = new System.Drawing.Point(0, 39);
            this.gcSelection.MainView = this.gvSelection;
            this.gcSelection.Name = "gcSelection";
            this.gcSelection.Size = new System.Drawing.Size(1180, 771);
            this.gcSelection.TabIndex = 1;
            this.gcSelection.UseEmbeddedNavigator = true;
            this.gcSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelection});
            // 
            // bsSelection
            // 
            this.bsSelection.DataMember = "working_LD_CashDist_Selection";
            this.bsSelection.DataSource = this.dsSelection1;
            this.bsSelection.Sort = "ProjectCode";
            // 
            // gvSelection
            // 
            this.gvSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colpati_type,
            this.colPRI_ID,
            this.colSelected,
            this.colProjectCode,
            this.colProjectName,
            this.colpri_site1,
            this.colsite_address,
            this.colsite_city,
            this.colsite_state});
            this.gvSelection.GridControl = this.gcSelection;
            this.gvSelection.Name = "gvSelection";
            this.gvSelection.OptionsView.ColumnAutoWidth = false;
            this.gvSelection.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvSelection_RowUpdated);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpati_type
            // 
            this.colpati_type.FieldName = "pati_type";
            this.colpati_type.Name = "colpati_type";
            this.colpati_type.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPRI_ID
            // 
            this.colPRI_ID.FieldName = "PRI_ID";
            this.colPRI_ID.Name = "colPRI_ID";
            this.colPRI_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Select";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 56;
            // 
            // colProjectCode
            // 
            this.colProjectCode.DisplayFormat.FormatString = "D";
            this.colProjectCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProjectCode.FieldName = "ProjectCode";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.OptionsColumn.AllowEdit = false;
            this.colProjectCode.OptionsColumn.ReadOnly = true;
            this.colProjectCode.Visible = true;
            this.colProjectCode.VisibleIndex = 1;
            this.colProjectCode.Width = 112;
            // 
            // colProjectName
            // 
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.OptionsColumn.ReadOnly = true;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 2;
            this.colProjectName.Width = 333;
            // 
            // colpri_site1
            // 
            this.colpri_site1.Caption = "Site";
            this.colpri_site1.FieldName = "pri_site1";
            this.colpri_site1.Name = "colpri_site1";
            this.colpri_site1.OptionsColumn.AllowEdit = false;
            this.colpri_site1.Visible = true;
            this.colpri_site1.VisibleIndex = 3;
            this.colpri_site1.Width = 156;
            // 
            // colsite_address
            // 
            this.colsite_address.Caption = "Site Address";
            this.colsite_address.FieldName = "site_address";
            this.colsite_address.Name = "colsite_address";
            this.colsite_address.OptionsColumn.AllowEdit = false;
            this.colsite_address.Visible = true;
            this.colsite_address.VisibleIndex = 4;
            this.colsite_address.Width = 156;
            // 
            // colsite_city
            // 
            this.colsite_city.Caption = "Site City";
            this.colsite_city.FieldName = "site_city";
            this.colsite_city.Name = "colsite_city";
            this.colsite_city.OptionsColumn.AllowEdit = false;
            this.colsite_city.Visible = true;
            this.colsite_city.VisibleIndex = 5;
            this.colsite_city.Width = 156;
            // 
            // colsite_state
            // 
            this.colsite_state.Caption = "Site Prov / State";
            this.colsite_state.FieldName = "site_state";
            this.colsite_state.Name = "colsite_state";
            this.colsite_state.OptionsColumn.AllowEdit = false;
            this.colsite_state.Visible = true;
            this.colsite_state.VisibleIndex = 6;
            this.colsite_state.Width = 168;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1180, 39);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(88, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Select &None";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(6, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Select &All";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ucProjectSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSelection);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucProjectSelection";
            this.Size = new System.Drawing.Size(1180, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dsSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSelection;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private dsSelection dsSelection1;
        private DevExpress.XtraGrid.GridControl gcSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelection;
        private System.Windows.Forms.BindingSource bsSelection;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpati_type;
        private DevExpress.XtraGrid.Columns.GridColumn colPRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_site1;
        private DevExpress.XtraGrid.Columns.GridColumn colsite_address;
        private DevExpress.XtraGrid.Columns.GridColumn colsite_city;
        private DevExpress.XtraGrid.Columns.GridColumn colsite_state;
    }
}
