namespace LD_CashCall
{
    partial class ucSummaryDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSummaryDistribution));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsSummary1 = new LD_CashCall.dsSummary();
            this.bsSummary = new System.Windows.Forms.BindingSource(this.components);
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpati_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLD_PROJ_Investor_Header_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvestor_Group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsibility = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistribution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProportinate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGL_Subcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1321, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // daSummary
            // 
            this.daSummary.DeleteCommand = this.sqlDeleteCommand1;
            this.daSummary.InsertCommand = this.sqlInsertCommand1;
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_LD_CashDistUpdate", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("pati_type", "pati_type"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_desc", "pri_desc"),
                        new System.Data.Common.DataColumnMapping("LD_PROJ_Investor_Header_ID", "LD_PROJ_Investor_Header_ID"),
                        new System.Data.Common.DataColumnMapping("Investor", "Investor"),
                        new System.Data.Common.DataColumnMapping("Investor_Group", "Investor_Group"),
                        new System.Data.Common.DataColumnMapping("Responsibility", "Responsibility"),
                        new System.Data.Common.DataColumnMapping("Distribution", "Distribution"),
                        new System.Data.Common.DataColumnMapping("Proportinate", "Proportinate"),
                        new System.Data.Common.DataColumnMapping("Supplier_ID", "Supplier_ID"),
                        new System.Data.Common.DataColumnMapping("GL_Subcode", "GL_Subcode"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            this.daSummary.UpdateCommand = this.sqlUpdateCommand1;
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
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_PROJ_Investor_Header_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_PROJ_Investor_Header_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor_Group", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor_Group", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor_Group", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor_Group", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Responsibility", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Responsibility", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Responsibility", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Responsibility", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Distribution", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Distribution", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Distribution", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Distribution", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proportinate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proportinate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proportinate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Proportinate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Subcode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Subcode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Subcode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Subcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pati_type", System.Data.SqlDbType.VarChar, 0, "pati_type"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_desc", System.Data.SqlDbType.VarChar, 0, "pri_desc"),
            new System.Data.SqlClient.SqlParameter("@LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, "LD_PROJ_Investor_Header_ID"),
            new System.Data.SqlClient.SqlParameter("@Investor", System.Data.SqlDbType.VarChar, 0, "Investor"),
            new System.Data.SqlClient.SqlParameter("@Investor_Group", System.Data.SqlDbType.VarChar, 0, "Investor_Group"),
            new System.Data.SqlClient.SqlParameter("@Responsibility", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Responsibility", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Distribution", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Distribution", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Proportinate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Proportinate", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Subcode", System.Data.SqlDbType.VarChar, 0, "GL_Subcode"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Amount", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 10, "username"),
            new System.Data.SqlClient.SqlParameter("@patitype", System.Data.SqlDbType.VarChar, 1, "pati_type")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@pati_type", System.Data.SqlDbType.VarChar, 0, "pati_type"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_desc", System.Data.SqlDbType.VarChar, 0, "pri_desc"),
            new System.Data.SqlClient.SqlParameter("@LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, "LD_PROJ_Investor_Header_ID"),
            new System.Data.SqlClient.SqlParameter("@Investor", System.Data.SqlDbType.VarChar, 0, "Investor"),
            new System.Data.SqlClient.SqlParameter("@Investor_Group", System.Data.SqlDbType.VarChar, 0, "Investor_Group"),
            new System.Data.SqlClient.SqlParameter("@Responsibility", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Responsibility", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Distribution", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Distribution", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Proportinate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Proportinate", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Supplier_ID", System.Data.SqlDbType.Int, 0, "Supplier_ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Subcode", System.Data.SqlDbType.VarChar, 0, "GL_Subcode"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Amount", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pati_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pati_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pati_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_PROJ_Investor_Header_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_PROJ_Investor_Header_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_PROJ_Investor_Header_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor_Group", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor_Group", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor_Group", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor_Group", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Responsibility", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Responsibility", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Responsibility", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Responsibility", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Distribution", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Distribution", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Distribution", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Distribution", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proportinate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proportinate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proportinate", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Proportinate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Supplier_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Supplier_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Subcode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Subcode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Subcode", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Subcode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(8)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsSummary
            // 
            this.bsSummary.DataMember = "working_LD_CashDistUpdate";
            this.bsSummary.DataSource = this.dsSummary1;
            this.bsSummary.Sort = "pri_code,Investor";
            // 
            // gcSummary
            // 
            this.gcSummary.DataSource = this.bsSummary;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 41);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.Size = new System.Drawing.Size(1321, 711);
            this.gcSummary.TabIndex = 1;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colpati_type,
            this.colpri_id,
            this.colpri_code,
            this.colpri_desc,
            this.colLD_PROJ_Investor_Header_ID,
            this.colInvestor,
            this.colInvestor_Group,
            this.colResponsibility,
            this.colDistribution,
            this.colProportinate,
            this.colSupplier_ID,
            this.colGL_Subcode,
            this.colAmount});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Width = 23;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.Width = 59;
            // 
            // colpati_type
            // 
            this.colpati_type.FieldName = "pati_type";
            this.colpati_type.Name = "colpati_type";
            this.colpati_type.OptionsColumn.AllowEdit = false;
            this.colpati_type.Width = 58;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.AllowEdit = false;
            this.colpri_id.Width = 38;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project Code";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 0;
            this.colpri_code.Width = 105;
            // 
            // colpri_desc
            // 
            this.colpri_desc.Caption = "Project Description";
            this.colpri_desc.FieldName = "pri_desc";
            this.colpri_desc.Name = "colpri_desc";
            this.colpri_desc.OptionsColumn.AllowEdit = false;
            this.colpri_desc.Visible = true;
            this.colpri_desc.VisibleIndex = 1;
            this.colpri_desc.Width = 255;
            // 
            // colLD_PROJ_Investor_Header_ID
            // 
            this.colLD_PROJ_Investor_Header_ID.FieldName = "LD_PROJ_Investor_Header_ID";
            this.colLD_PROJ_Investor_Header_ID.Name = "colLD_PROJ_Investor_Header_ID";
            this.colLD_PROJ_Investor_Header_ID.OptionsColumn.AllowEdit = false;
            this.colLD_PROJ_Investor_Header_ID.Width = 161;
            // 
            // colInvestor
            // 
            this.colInvestor.Caption = "Investor";
            this.colInvestor.FieldName = "Investor";
            this.colInvestor.Name = "colInvestor";
            this.colInvestor.OptionsColumn.AllowEdit = false;
            this.colInvestor.Visible = true;
            this.colInvestor.VisibleIndex = 2;
            this.colInvestor.Width = 208;
            // 
            // colInvestor_Group
            // 
            this.colInvestor_Group.Caption = "Investor Group";
            this.colInvestor_Group.FieldName = "Investor_Group";
            this.colInvestor_Group.Name = "colInvestor_Group";
            this.colInvestor_Group.OptionsColumn.AllowEdit = false;
            this.colInvestor_Group.Visible = true;
            this.colInvestor_Group.VisibleIndex = 3;
            this.colInvestor_Group.Width = 479;
            // 
            // colResponsibility
            // 
            this.colResponsibility.FieldName = "Responsibility";
            this.colResponsibility.Name = "colResponsibility";
            this.colResponsibility.OptionsColumn.AllowEdit = false;
            this.colResponsibility.Width = 77;
            // 
            // colDistribution
            // 
            this.colDistribution.FieldName = "Distribution";
            this.colDistribution.Name = "colDistribution";
            this.colDistribution.OptionsColumn.AllowEdit = false;
            this.colDistribution.Width = 66;
            // 
            // colProportinate
            // 
            this.colProportinate.FieldName = "Proportinate";
            this.colProportinate.Name = "colProportinate";
            this.colProportinate.OptionsColumn.AllowEdit = false;
            this.colProportinate.Width = 72;
            // 
            // colSupplier_ID
            // 
            this.colSupplier_ID.FieldName = "Supplier_ID";
            this.colSupplier_ID.Name = "colSupplier_ID";
            this.colSupplier_ID.OptionsColumn.AllowEdit = false;
            this.colSupplier_ID.Width = 67;
            // 
            // colGL_Subcode
            // 
            this.colGL_Subcode.Caption = "GL Subcode";
            this.colGL_Subcode.FieldName = "GL_Subcode";
            this.colGL_Subcode.Name = "colGL_Subcode";
            this.colGL_Subcode.OptionsColumn.AllowEdit = false;
            this.colGL_Subcode.Visible = true;
            this.colGL_Subcode.VisibleIndex = 4;
            this.colGL_Subcode.Width = 134;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "N2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.SummaryItem.DisplayFormat = "{0:N0}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            this.colAmount.Width = 269;
            // 
            // ucSummaryDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSummaryDistribution";
            this.Size = new System.Drawing.Size(1321, 752);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private dsSummary dsSummary1;
        private System.Windows.Forms.BindingSource bsSummary;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colpati_type;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_PROJ_Investor_Header_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvestor;
        private DevExpress.XtraGrid.Columns.GridColumn colInvestor_Group;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsibility;
        private DevExpress.XtraGrid.Columns.GridColumn colDistribution;
        private DevExpress.XtraGrid.Columns.GridColumn colProportinate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGL_Subcode;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    }
}
