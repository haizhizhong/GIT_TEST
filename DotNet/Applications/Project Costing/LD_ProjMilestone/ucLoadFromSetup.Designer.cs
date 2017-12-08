namespace LD_ProjMilestone
{
    partial class ucLoadFromSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLoadFromSetup));
            this.gcMilestones = new DevExpress.XtraGrid.GridControl();
            this.bsWorkingMilestones = new System.Windows.Forms.BindingSource(this.components);
            this.dsWorkingMilestones1 = new LD_ProjMilestone.dsWorkingMilestones();
            this.gvMilestones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilestone_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilestone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlreadyUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_deReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ri_ceReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlOK = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daWorkingMilestones = new System.Data.SqlClient.SqlDataAdapter();
            this.daMilestone = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsMilestone1 = new LD_ProjMilestone.dsMilestone();
            ((System.ComponentModel.ISupportInitialize)(this.gcMilestones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkingMilestones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkingMilestones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMilestones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deReadOnly.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOK)).BeginInit();
            this.pnlOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMilestone1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMilestones
            // 
            this.gcMilestones.DataSource = this.bsWorkingMilestones;
            this.gcMilestones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMilestones.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcMilestones.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcMilestones.Location = new System.Drawing.Point(0, 0);
            this.gcMilestones.MainView = this.gvMilestones;
            this.gcMilestones.Name = "gcMilestones";
            this.gcMilestones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_deReadOnly,
            this.ri_ceReadOnly});
            this.gcMilestones.Size = new System.Drawing.Size(752, 588);
            this.gcMilestones.TabIndex = 0;
            this.gcMilestones.UseEmbeddedNavigator = true;
            this.gcMilestones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMilestones});
            // 
            // bsWorkingMilestones
            // 
            this.bsWorkingMilestones.DataMember = "LD_working_Proj_Milestone";
            this.bsWorkingMilestones.DataSource = this.dsWorkingMilestones1;
            // 
            // dsWorkingMilestones1
            // 
            this.dsWorkingMilestones1.DataSetName = "dsWorkingMilestones";
            this.dsWorkingMilestones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMilestones
            // 
            this.gvMilestones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpri_id,
            this.colMilestone_ID,
            this.colMilestone,
            this.colTargetDate,
            this.colActualDate,
            this.colSelected,
            this.colusername,
            this.colAlreadyUsed,
            this.colID});
            this.gvMilestones.GridControl = this.gcMilestones;
            this.gvMilestones.Name = "gvMilestones";
            this.gvMilestones.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMilestone, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvMilestones.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvMilestones_CustomRowCellEdit);
            this.gvMilestones.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvMilestones_CustomDrawCell);
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMilestone_ID
            // 
            this.colMilestone_ID.FieldName = "Milestone_ID";
            this.colMilestone_ID.Name = "colMilestone_ID";
            this.colMilestone_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMilestone
            // 
            this.colMilestone.FieldName = "Milestone";
            this.colMilestone.Name = "colMilestone";
            this.colMilestone.OptionsColumn.AllowEdit = false;
            this.colMilestone.OptionsColumn.ReadOnly = true;
            this.colMilestone.Visible = true;
            this.colMilestone.VisibleIndex = 0;
            // 
            // colTargetDate
            // 
            this.colTargetDate.FieldName = "TargetDate";
            this.colTargetDate.Name = "colTargetDate";
            this.colTargetDate.Visible = true;
            this.colTargetDate.VisibleIndex = 1;
            // 
            // colActualDate
            // 
            this.colActualDate.FieldName = "ActualDate";
            this.colActualDate.Name = "colActualDate";
            this.colActualDate.Visible = true;
            this.colActualDate.VisibleIndex = 2;
            // 
            // colSelected
            // 
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 3;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colAlreadyUsed
            // 
            this.colAlreadyUsed.FieldName = "AlreadyUsed";
            this.colAlreadyUsed.Name = "colAlreadyUsed";
            this.colAlreadyUsed.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ri_deReadOnly
            // 
            this.ri_deReadOnly.AutoHeight = false;
            this.ri_deReadOnly.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_deReadOnly.Name = "ri_deReadOnly";
            this.ri_deReadOnly.ReadOnly = true;
            this.ri_deReadOnly.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // ri_ceReadOnly
            // 
            this.ri_ceReadOnly.AutoHeight = false;
            this.ri_ceReadOnly.Name = "ri_ceReadOnly";
            this.ri_ceReadOnly.ReadOnly = true;
            // 
            // pnlOK
            // 
            this.pnlOK.Controls.Add(this.btnCancel);
            this.pnlOK.Controls.Add(this.btnOK);
            this.pnlOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOK.Location = new System.Drawing.Point(0, 588);
            this.pnlOK.Name = "pnlOK";
            this.pnlOK.Size = new System.Drawing.Size(752, 41);
            this.pnlOK.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(658, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(567, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        ID, pri_id, Milestone_ID, TargetDate, ActualDate, Selected, usernam" +
                "e, AlreadyUsed, Milestone\r\nFROM            LD_working_Proj_Milestone\r\nWHERE     " +
                "   (username = @username)";
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 100, "username")});
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
            new System.Data.SqlClient.SqlParameter("@Milestone_ID", System.Data.SqlDbType.Int, 0, "Milestone_ID"),
            new System.Data.SqlClient.SqlParameter("@TargetDate", System.Data.SqlDbType.Date, 0, "TargetDate"),
            new System.Data.SqlClient.SqlParameter("@ActualDate", System.Data.SqlDbType.Date, 0, "ActualDate"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@AlreadyUsed", System.Data.SqlDbType.Bit, 0, "AlreadyUsed"),
            new System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.VarChar, 0, "Milestone")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@Milestone_ID", System.Data.SqlDbType.Int, 0, "Milestone_ID"),
            new System.Data.SqlClient.SqlParameter("@TargetDate", System.Data.SqlDbType.Date, 0, "TargetDate"),
            new System.Data.SqlClient.SqlParameter("@ActualDate", System.Data.SqlDbType.Date, 0, "ActualDate"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@AlreadyUsed", System.Data.SqlDbType.Bit, 0, "AlreadyUsed"),
            new System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.VarChar, 0, "Milestone"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TargetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TargetDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlreadyUsed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlreadyUsed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlreadyUsed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlreadyUsed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TargetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TargetDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlreadyUsed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlreadyUsed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlreadyUsed", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AlreadyUsed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, null)});
            // 
            // daWorkingMilestones
            // 
            this.daWorkingMilestones.DeleteCommand = this.sqlDeleteCommand1;
            this.daWorkingMilestones.InsertCommand = this.sqlInsertCommand1;
            this.daWorkingMilestones.SelectCommand = this.sqlSelectCommand1;
            this.daWorkingMilestones.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_working_Proj_Milestone", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("Milestone_ID", "Milestone_ID"),
                        new System.Data.Common.DataColumnMapping("TargetDate", "TargetDate"),
                        new System.Data.Common.DataColumnMapping("ActualDate", "ActualDate"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("AlreadyUsed", "AlreadyUsed"),
                        new System.Data.Common.DataColumnMapping("Milestone", "Milestone")})});
            this.daWorkingMilestones.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // daMilestone
            // 
            this.daMilestone.DeleteCommand = this.sqlDeleteCommand2;
            this.daMilestone.InsertCommand = this.sqlInsertCommand2;
            this.daMilestone.SelectCommand = this.sqlSelectCommand2;
            this.daMilestone.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Milestone", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Milestone_ID", "Milestone_ID"),
                        new System.Data.Common.DataColumnMapping("Milestone", "Milestone")})});
            this.daMilestone.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [LD_Milestone] WHERE (([Milestone_ID] = @Original_Milestone_ID) AND (" +
                "(@IsNull_Milestone = 1 AND [Milestone] IS NULL) OR ([Milestone] = @Original_Mile" +
                "stone)))";
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [LD_Milestone] ([Milestone]) VALUES (@Milestone);\r\nSELECT Milestone_I" +
                "D, Milestone FROM LD_Milestone WHERE (Milestone_ID = SCOPE_IDENTITY()) ORDER BY " +
                "Milestone";
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.VarChar, 0, "Milestone")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Milestone_ID, Milestone\r\nFROM            LD_Milestone\r\nORDER BY Mil" +
                "estone";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Milestone", System.Data.SqlDbType.VarChar, 0, "Milestone"),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Milestone_ID", System.Data.SqlDbType.Int, 4, "Milestone_ID")});
            // 
            // dsMilestone1
            // 
            this.dsMilestone1.DataSetName = "dsMilestone";
            this.dsMilestone1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucLoadFromSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMilestones);
            this.Controls.Add(this.pnlOK);
            this.Name = "ucLoadFromSetup";
            this.Size = new System.Drawing.Size(752, 629);
            ((System.ComponentModel.ISupportInitialize)(this.gcMilestones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkingMilestones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkingMilestones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMilestones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deReadOnly.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_ceReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOK)).EndInit();
            this.pnlOK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMilestone1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMilestones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMilestones;
        private DevExpress.XtraEditors.PanelControl pnlOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daWorkingMilestones;
        private dsWorkingMilestones dsWorkingMilestones1;
        private System.Windows.Forms.BindingSource bsWorkingMilestones;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colMilestone_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colActualDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colAlreadyUsed;
        private System.Data.SqlClient.SqlDataAdapter daMilestone;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private dsMilestone dsMilestone1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMilestone;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ri_deReadOnly;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ri_ceReadOnly;
    }
}
