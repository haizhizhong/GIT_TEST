namespace ProjectUtilities.Land.Letter_Of_Credit
{
    partial class ucLogging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogging));
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.gcLogging = new DevExpress.XtraGrid.GridControl();
            this.bsLogging = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogging1 = new ProjectUtilities.dsLogging();
            this.gvLogging = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDateTime = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riMemExtChange = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daLogging = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogging1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riMemExtChange)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=dev12;Initial Catalog=TR_Test2;Persist Security Info=True;User ID=hms" +
                "qlsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // gcLogging
            // 
            this.gcLogging.DataSource = this.bsLogging;
            this.gcLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLogging.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLogging.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLogging.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLogging.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLogging.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLogging.Location = new System.Drawing.Point(0, 0);
            this.gcLogging.MainView = this.gvLogging;
            this.gcLogging.Name = "gcLogging";
            this.gcLogging.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDateTime,
            this.riMemExtChange});
            this.gcLogging.Size = new System.Drawing.Size(778, 539);
            this.gcLogging.TabIndex = 0;
            this.gcLogging.UseEmbeddedNavigator = true;
            this.gcLogging.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLogging});
            // 
            // bsLogging
            // 
            this.bsLogging.DataMember = "LD_PROJ_LetterOfCredit_Logging";
            this.bsLogging.DataSource = this.dsLogging1;
            // 
            // dsLogging1
            // 
            this.dsLogging1.DataSetName = "dsLogging";
            this.dsLogging1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLogging
            // 
            this.gvLogging.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDateChanged,
            this.colChange,
            this.colNote});
            this.gvLogging.GridControl = this.gcLogging;
            this.gvLogging.Name = "gvLogging";
            this.gvLogging.OptionsView.ColumnAutoWidth = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDateChanged
            // 
            this.colDateChanged.ColumnEdit = this.txtDateTime;
            this.colDateChanged.DisplayFormat.FormatString = "d";
            this.colDateChanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateChanged.FieldName = "DateChanged";
            this.colDateChanged.Name = "colDateChanged";
            this.colDateChanged.OptionsColumn.AllowEdit = false;
            this.colDateChanged.Visible = true;
            this.colDateChanged.VisibleIndex = 0;
            this.colDateChanged.Width = 126;
            // 
            // txtDateTime
            // 
            this.txtDateTime.AutoHeight = false;
            this.txtDateTime.Mask.EditMask = "g";
            this.txtDateTime.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateTime.Mask.UseMaskAsDisplayFormat = true;
            this.txtDateTime.Name = "txtDateTime";
            // 
            // colChange
            // 
            this.colChange.ColumnEdit = this.riMemExtChange;
            this.colChange.FieldName = "Change";
            this.colChange.Name = "colChange";
            this.colChange.OptionsColumn.ReadOnly = true;
            this.colChange.Visible = true;
            this.colChange.VisibleIndex = 2;
            this.colChange.Width = 199;
            // 
            // riMemExtChange
            // 
            this.riMemExtChange.AutoHeight = false;
            this.riMemExtChange.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riMemExtChange.Name = "riMemExtChange";
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            this.colNote.Width = 664;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LetterOfCredit_ID", System.Data.SqlDbType.Int, 4, "LetterOfCredit_ID")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DateChanged", System.Data.SqlDbType.DateTime, 0, "DateChanged"),
            new System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 0, "Username"),
            new System.Data.SqlClient.SqlParameter("@LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, "LetterOfCredit_ID"),
            new System.Data.SqlClient.SqlParameter("@New_StartDate", System.Data.SqlDbType.DateTime, 0, "New_StartDate"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.DateTime, 0, "Original_StartDate"),
            new System.Data.SqlClient.SqlParameter("@New_ExpiryDate", System.Data.SqlDbType.DateTime, 0, "New_ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@p4", System.Data.SqlDbType.DateTime, 0, "Original_ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@New_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, "New_EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@p7", System.Data.SqlDbType.DateTime, 0, "Original_EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@New_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, "New_ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@p10", System.Data.SqlDbType.DateTime, 0, "Original_ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@New_Amount", System.Data.SqlDbType.Money, 0, "New_Amount"),
            new System.Data.SqlClient.SqlParameter("@p13", System.Data.SqlDbType.Money, 0, "Original_Amount"),
            new System.Data.SqlClient.SqlParameter("@New_LOC_Type", System.Data.SqlDbType.VarChar, 0, "New_LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@p16", System.Data.SqlDbType.VarChar, 0, "Original_LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@Change", System.Data.SqlDbType.VarChar, 0, "Change"),
            new System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.VarChar, 0, "Note")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DateChanged", System.Data.SqlDbType.DateTime, 0, "DateChanged"),
            new System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 0, "Username"),
            new System.Data.SqlClient.SqlParameter("@LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, "LetterOfCredit_ID"),
            new System.Data.SqlClient.SqlParameter("@New_StartDate", System.Data.SqlDbType.DateTime, 0, "New_StartDate"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.DateTime, 0, "Original_StartDate"),
            new System.Data.SqlClient.SqlParameter("@New_ExpiryDate", System.Data.SqlDbType.DateTime, 0, "New_ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@p4", System.Data.SqlDbType.DateTime, 0, "Original_ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@New_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, "New_EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@p7", System.Data.SqlDbType.DateTime, 0, "Original_EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@New_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, "New_ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@p10", System.Data.SqlDbType.DateTime, 0, "Original_ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@New_Amount", System.Data.SqlDbType.Money, 0, "New_Amount"),
            new System.Data.SqlClient.SqlParameter("@p13", System.Data.SqlDbType.Money, 0, "Original_Amount"),
            new System.Data.SqlClient.SqlParameter("@New_LOC_Type", System.Data.SqlDbType.VarChar, 0, "New_LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@p16", System.Data.SqlDbType.VarChar, 0, "Original_LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@Change", System.Data.SqlDbType.VarChar, 0, "Change"),
            new System.Data.SqlClient.SqlParameter("@Note", System.Data.SqlDbType.VarChar, 0, "Note"),
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateChanged", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateChanged", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_ExpiryDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_ExpiryDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p5", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_EstimatedReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p8", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_ActualReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p11", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p14", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_LOC_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_LOC_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_LOC_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p18", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p17", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_LOC_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateChanged", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateChanged", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_ExpiryDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_ExpiryDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p5", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_EstimatedReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p8", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_ActualReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p11", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p14", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_New_LOC_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "New_LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_New_LOC_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "New_LOC_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p18", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Original_LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p17", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Original_LOC_Type", System.Data.DataRowVersion.Original, null)});
            // 
            // daLogging
            // 
            this.daLogging.DeleteCommand = this.sqlDeleteCommand1;
            this.daLogging.InsertCommand = this.sqlInsertCommand1;
            this.daLogging.SelectCommand = this.sqlSelectCommand1;
            this.daLogging.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_PROJ_LetterOfCredit_Logging", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("DateChanged", "DateChanged"),
                        new System.Data.Common.DataColumnMapping("Username", "Username"),
                        new System.Data.Common.DataColumnMapping("LetterOfCredit_ID", "LetterOfCredit_ID"),
                        new System.Data.Common.DataColumnMapping("New_StartDate", "New_StartDate"),
                        new System.Data.Common.DataColumnMapping("Original_StartDate", "Original_StartDate"),
                        new System.Data.Common.DataColumnMapping("New_ExpiryDate", "New_ExpiryDate"),
                        new System.Data.Common.DataColumnMapping("Original_ExpiryDate", "Original_ExpiryDate"),
                        new System.Data.Common.DataColumnMapping("New_EstimatedReleaseDate", "New_EstimatedReleaseDate"),
                        new System.Data.Common.DataColumnMapping("Original_EstimatedReleaseDate", "Original_EstimatedReleaseDate"),
                        new System.Data.Common.DataColumnMapping("New_ActualReleaseDate", "New_ActualReleaseDate"),
                        new System.Data.Common.DataColumnMapping("Original_ActualReleaseDate", "Original_ActualReleaseDate"),
                        new System.Data.Common.DataColumnMapping("New_Amount", "New_Amount"),
                        new System.Data.Common.DataColumnMapping("Original_Amount", "Original_Amount"),
                        new System.Data.Common.DataColumnMapping("New_LOC_Type", "New_LOC_Type"),
                        new System.Data.Common.DataColumnMapping("Original_LOC_Type", "Original_LOC_Type"),
                        new System.Data.Common.DataColumnMapping("Change", "Change"),
                        new System.Data.Common.DataColumnMapping("Note", "Note")})});
            this.daLogging.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcLogging);
            this.Name = "ucLogging";
            this.Size = new System.Drawing.Size(778, 539);
            this.Load += new System.EventHandler(this.ucLogging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLogging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogging1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLogging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riMemExtChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private DevExpress.XtraGrid.GridControl gcLogging;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLogging;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daLogging;
        private dsLogging dsLogging1;
        private System.Windows.Forms.BindingSource bsLogging;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDateChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colChange;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit riMemExtChange;
    }
}
