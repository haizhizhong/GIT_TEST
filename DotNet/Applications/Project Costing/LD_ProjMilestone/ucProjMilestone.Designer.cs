namespace LD_ProjMilestone
{
    partial class ucProjMilestone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProjMilestone));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daProjMilestone = new System.Data.SqlClient.SqlDataAdapter();
            this.dsProjMilestone1 = new LD_ProjMilestone.dsProjMilestone();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadSelected = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadAll = new DevExpress.XtraEditors.SimpleButton();
            this.gcMilestone = new DevExpress.XtraGrid.GridControl();
            this.bsProjMilestone = new System.Windows.Forms.BindingSource(this.components);
            this.gvMilestone = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProj_Milestone_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilestone_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueMilestone = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsMilestone = new System.Windows.Forms.BindingSource(this.components);
            this.dsMilestone1 = new LD_ProjMilestone.dsMilestone();
            this.colTargetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_deTargetDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colActualDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daMilestone = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjMilestone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMilestone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deTargetDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deTargetDate.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Proj_Milestone_ID, pri_id, Milestone_ID, TargetDate, ActualDate\r\nFR" +
                "OM            LD_Proj_Milestone\r\nWHERE        (pri_id = @pri_id)";
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
            new System.Data.SqlClient.SqlParameter("@Milestone_ID", System.Data.SqlDbType.Int, 0, "Milestone_ID"),
            new System.Data.SqlClient.SqlParameter("@TargetDate", System.Data.SqlDbType.Date, 0, "TargetDate"),
            new System.Data.SqlClient.SqlParameter("@ActualDate", System.Data.SqlDbType.Date, 0, "ActualDate")});
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
            new System.Data.SqlClient.SqlParameter("@Original_Proj_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proj_Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TargetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TargetDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Proj_Milestone_ID", System.Data.SqlDbType.Int, 4, "Proj_Milestone_ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Proj_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proj_Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Milestone_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Milestone_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TargetDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TargetDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TargetDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null)});
            // 
            // daProjMilestone
            // 
            this.daProjMilestone.DeleteCommand = this.sqlDeleteCommand1;
            this.daProjMilestone.InsertCommand = this.sqlInsertCommand1;
            this.daProjMilestone.SelectCommand = this.sqlSelectCommand1;
            this.daProjMilestone.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Proj_Milestone", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Proj_Milestone_ID", "Proj_Milestone_ID"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("Milestone_ID", "Milestone_ID"),
                        new System.Data.Common.DataColumnMapping("TargetDate", "TargetDate"),
                        new System.Data.Common.DataColumnMapping("ActualDate", "ActualDate")})});
            this.daProjMilestone.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsProjMilestone1
            // 
            this.dsProjMilestone1.DataSetName = "dsProjMilestone";
            this.dsProjMilestone1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadSelected);
            this.panelControl1.Controls.Add(this.btnLoadAll);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(763, 31);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.Location = new System.Drawing.Point(104, 4);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(93, 23);
            this.btnLoadSelected.TabIndex = 1;
            this.btnLoadSelected.Text = "Load Selected";
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(5, 4);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(93, 23);
            this.btnLoadAll.TabIndex = 0;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // gcMilestone
            // 
            this.gcMilestone.DataSource = this.bsProjMilestone;
            this.gcMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMilestone.Location = new System.Drawing.Point(0, 31);
            this.gcMilestone.MainView = this.gvMilestone;
            this.gcMilestone.Name = "gcMilestone";
            this.gcMilestone.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueMilestone,
            this.ri_deTargetDate});
            this.gcMilestone.Size = new System.Drawing.Size(763, 600);
            this.gcMilestone.TabIndex = 1;
            this.gcMilestone.UseEmbeddedNavigator = true;
            this.gcMilestone.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMilestone});
            // 
            // bsProjMilestone
            // 
            this.bsProjMilestone.DataMember = "LD_Proj_Milestone";
            this.bsProjMilestone.DataSource = this.dsProjMilestone1;
            // 
            // gvMilestone
            // 
            this.gvMilestone.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProj_Milestone_ID,
            this.colpri_id,
            this.colMilestone_ID,
            this.colTargetDate,
            this.colActualDate});
            this.gvMilestone.GridControl = this.gcMilestone;
            this.gvMilestone.Name = "gvMilestone";
            this.gvMilestone.OptionsView.ColumnAutoWidth = false;
            this.gvMilestone.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvMilestone_InitNewRow);
            this.gvMilestone.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvMilestone_InvalidRowException);
            this.gvMilestone.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvMilestone_ValidateRow);
            // 
            // colProj_Milestone_ID
            // 
            this.colProj_Milestone_ID.FieldName = "Proj_Milestone_ID";
            this.colProj_Milestone_ID.Name = "colProj_Milestone_ID";
            this.colProj_Milestone_ID.OptionsColumn.ReadOnly = true;
            this.colProj_Milestone_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colMilestone_ID
            // 
            this.colMilestone_ID.Caption = "Milestone";
            this.colMilestone_ID.ColumnEdit = this.ri_lueMilestone;
            this.colMilestone_ID.FieldName = "Milestone_ID";
            this.colMilestone_ID.Name = "colMilestone_ID";
            this.colMilestone_ID.Visible = true;
            this.colMilestone_ID.VisibleIndex = 0;
            this.colMilestone_ID.Width = 198;
            // 
            // ri_lueMilestone
            // 
            this.ri_lueMilestone.AutoHeight = false;
            this.ri_lueMilestone.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueMilestone.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Milestone_ID", "Milestone_ID", 85, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Milestone", "Milestone", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueMilestone.DataSource = this.bsMilestone;
            this.ri_lueMilestone.DisplayMember = "Milestone";
            this.ri_lueMilestone.Name = "ri_lueMilestone";
            this.ri_lueMilestone.NullText = "";
            this.ri_lueMilestone.ValueMember = "Milestone_ID";
            this.ri_lueMilestone.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ri_lueMilestone_EditValueChanging);
            // 
            // bsMilestone
            // 
            this.bsMilestone.DataMember = "LD_Milestone";
            this.bsMilestone.DataSource = this.dsMilestone1;
            // 
            // dsMilestone1
            // 
            this.dsMilestone1.DataSetName = "dsMilestone";
            this.dsMilestone1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colTargetDate
            // 
            this.colTargetDate.ColumnEdit = this.ri_deTargetDate;
            this.colTargetDate.FieldName = "TargetDate";
            this.colTargetDate.Name = "colTargetDate";
            this.colTargetDate.Visible = true;
            this.colTargetDate.VisibleIndex = 1;
            this.colTargetDate.Width = 80;
            // 
            // ri_deTargetDate
            // 
            this.ri_deTargetDate.AutoHeight = false;
            this.ri_deTargetDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_deTargetDate.Name = "ri_deTargetDate";
            this.ri_deTargetDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ri_deTargetDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ri_deTargetDate_EditValueChanging);
            // 
            // colActualDate
            // 
            this.colActualDate.FieldName = "ActualDate";
            this.colActualDate.Name = "colActualDate";
            this.colActualDate.Visible = true;
            this.colActualDate.VisibleIndex = 2;
            this.colActualDate.Width = 76;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Milestone_ID, Milestone\r\nFROM            LD_Milestone\r\nORDER BY Mil" +
                "estone";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
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
            // ucProjMilestone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMilestone);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucProjMilestone";
            this.Size = new System.Drawing.Size(763, 631);
            this.Load += new System.EventHandler(this.ucProjMilestone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProjMilestone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMilestone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deTargetDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_deTargetDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daProjMilestone;
        private dsProjMilestone dsProjMilestone1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcMilestone;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMilestone;
        private System.Windows.Forms.BindingSource bsProjMilestone;
        private DevExpress.XtraGrid.Columns.GridColumn colProj_Milestone_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colMilestone_ID;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daMilestone;
        private dsMilestone dsMilestone1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueMilestone;
        private System.Windows.Forms.BindingSource bsMilestone;
        private DevExpress.XtraEditors.SimpleButton btnLoadSelected;
        private DevExpress.XtraEditors.SimpleButton btnLoadAll;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colActualDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ri_deTargetDate;
    }
}
