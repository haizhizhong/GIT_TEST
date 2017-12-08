namespace ProjectUtilities.Land.Letter_Of_Credit
{
    partial class ucLetterOfCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLetterOfCredit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grpNotes = new DevExpress.XtraEditors.GroupControl();
            this.meNotes = new DevExpress.XtraEditors.MemoEdit();
            this.bs_letterOfCredit = new System.Windows.Forms.BindingSource(this.components);
            this.dsLetterOfCredit1 = new ProjectUtilities.Land.Letter_Of_Credit.dsLetterOfCredit();
            this.grpLetterOfCredit = new DevExpress.XtraEditors.GroupControl();
            this.gcLetterOfCredit = new DevExpress.XtraGrid.GridControl();
            this.gvLetterOfCredit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLetterOfCredit_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teMax25 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLOC_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teMax50 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLender_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLenders = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDLenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLender1 = new ProjectUtilities.Land.Letter_Of_Credit.dsLender();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_seAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualReleaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstimatedReleaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficiary_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBeneficiary = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBeneficiary = new System.Windows.Forms.BindingSource(this.components);
            this.dsBeneficiary1 = new ProjectUtilities.dsBeneficiary();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da_letterOfCredit = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daLender = new System.Data.SqlClient.SqlDataAdapter();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpNotes = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daBeneficiary = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpNotes)).BeginInit();
            this.grpNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_letterOfCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLetterOfCredit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLetterOfCredit)).BeginInit();
            this.grpLetterOfCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLetterOfCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLetterOfCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLenders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBeneficiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeneficiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.grpNotes);
            this.layoutControl1.Controls.Add(this.grpLetterOfCredit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1147, 413);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.meNotes);
            this.grpNotes.Location = new System.Drawing.Point(7, 294);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(1134, 113);
            this.grpNotes.TabIndex = 5;
            this.grpNotes.Text = "Notes";
            // 
            // meNotes
            // 
            this.meNotes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs_letterOfCredit, "Notes", true));
            this.meNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meNotes.Location = new System.Drawing.Point(2, 20);
            this.meNotes.Name = "meNotes";
            this.meNotes.Size = new System.Drawing.Size(1130, 91);
            this.meNotes.TabIndex = 0;
            this.meNotes.Leave += new System.EventHandler(this.meNotes_Leave);
            // 
            // bs_letterOfCredit
            // 
            this.bs_letterOfCredit.DataMember = "LD_PROJ_LetterOfCredit";
            this.bs_letterOfCredit.DataSource = this.dsLetterOfCredit1;
            // 
            // dsLetterOfCredit1
            // 
            this.dsLetterOfCredit1.DataSetName = "dsLetterOfCredit";
            this.dsLetterOfCredit1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpLetterOfCredit
            // 
            this.grpLetterOfCredit.Controls.Add(this.gcLetterOfCredit);
            this.grpLetterOfCredit.Location = new System.Drawing.Point(7, 7);
            this.grpLetterOfCredit.Name = "grpLetterOfCredit";
            this.grpLetterOfCredit.Size = new System.Drawing.Size(1134, 276);
            this.grpLetterOfCredit.TabIndex = 4;
            this.grpLetterOfCredit.Text = "Letter Of Credit";
            // 
            // gcLetterOfCredit
            // 
            this.gcLetterOfCredit.DataSource = this.bs_letterOfCredit;
            this.gcLetterOfCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLetterOfCredit.Location = new System.Drawing.Point(2, 20);
            this.gcLetterOfCredit.MainView = this.gvLetterOfCredit;
            this.gcLetterOfCredit.Name = "gcLetterOfCredit";
            this.gcLetterOfCredit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teMax25,
            this.ri_teMax50,
            this.ri_seAmount,
            this.ri_lueLenders,
            this.riBeneficiary});
            this.gcLetterOfCredit.Size = new System.Drawing.Size(1130, 254);
            this.gcLetterOfCredit.TabIndex = 0;
            this.gcLetterOfCredit.UseEmbeddedNavigator = true;
            this.gcLetterOfCredit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLetterOfCredit});
            // 
            // gvLetterOfCredit
            // 
            this.gvLetterOfCredit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLetterOfCredit_ID,
            this.colpri_id,
            this.colReferenceNum,
            this.colLOC_Type,
            this.colLOC_Description,
            this.colLender_ID,
            this.colStartDate,
            this.colExpiryDate,
            this.colAmount,
            this.colNotes,
            this.colActualReleaseDate,
            this.colEstimatedReleaseDate,
            this.colBeneficiary_id});
            this.gvLetterOfCredit.GridControl = this.gcLetterOfCredit;
            this.gvLetterOfCredit.Name = "gvLetterOfCredit";
            this.gvLetterOfCredit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvLetterOfCredit_FocusedRowChanged);
            this.gvLetterOfCredit.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvLetterOfCredit_CellValueChanged);
            this.gvLetterOfCredit.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvLetterOfCredit_InitNewRow);
            this.gvLetterOfCredit.RowCountChanged += new System.EventHandler(this.gvLetterOfCredit_RowCountChanged);
            this.gvLetterOfCredit.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvLetterOfCredit_InvalidRowException);
            this.gvLetterOfCredit.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvLetterOfCredit_ValidateRow);
            // 
            // colLetterOfCredit_ID
            // 
            this.colLetterOfCredit_ID.FieldName = "LetterOfCredit_ID";
            this.colLetterOfCredit_ID.Name = "colLetterOfCredit_ID";
            this.colLetterOfCredit_ID.OptionsColumn.ReadOnly = true;
            this.colLetterOfCredit_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colReferenceNum
            // 
            this.colReferenceNum.Caption = "Reference #";
            this.colReferenceNum.ColumnEdit = this.ri_teMax25;
            this.colReferenceNum.FieldName = "ReferenceNum";
            this.colReferenceNum.Name = "colReferenceNum";
            this.colReferenceNum.Visible = true;
            this.colReferenceNum.VisibleIndex = 0;
            this.colReferenceNum.Width = 110;
            // 
            // ri_teMax25
            // 
            this.ri_teMax25.AutoHeight = false;
            this.ri_teMax25.MaxLength = 25;
            this.ri_teMax25.Name = "ri_teMax25";
            // 
            // colLOC_Type
            // 
            this.colLOC_Type.Caption = "Type";
            this.colLOC_Type.ColumnEdit = this.ri_teMax25;
            this.colLOC_Type.FieldName = "LOC_Type";
            this.colLOC_Type.Name = "colLOC_Type";
            this.colLOC_Type.Visible = true;
            this.colLOC_Type.VisibleIndex = 1;
            this.colLOC_Type.Width = 110;
            // 
            // colLOC_Description
            // 
            this.colLOC_Description.Caption = "Description";
            this.colLOC_Description.ColumnEdit = this.ri_teMax50;
            this.colLOC_Description.FieldName = "LOC_Description";
            this.colLOC_Description.Name = "colLOC_Description";
            this.colLOC_Description.Visible = true;
            this.colLOC_Description.VisibleIndex = 2;
            this.colLOC_Description.Width = 110;
            // 
            // ri_teMax50
            // 
            this.ri_teMax50.AutoHeight = false;
            this.ri_teMax50.MaxLength = 50;
            this.ri_teMax50.Name = "ri_teMax50";
            // 
            // colLender_ID
            // 
            this.colLender_ID.Caption = "Lender";
            this.colLender_ID.ColumnEdit = this.ri_lueLenders;
            this.colLender_ID.FieldName = "Lender_ID";
            this.colLender_ID.Name = "colLender_ID";
            this.colLender_ID.Visible = true;
            this.colLender_ID.VisibleIndex = 3;
            this.colLender_ID.Width = 110;
            // 
            // ri_lueLenders
            // 
            this.ri_lueLenders.AutoHeight = false;
            this.ri_lueLenders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLenders.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lender", "Lender", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLenders.DataSource = this.lDLenderBindingSource;
            this.ri_lueLenders.DisplayMember = "Lender";
            this.ri_lueLenders.Name = "ri_lueLenders";
            this.ri_lueLenders.NullText = "";
            this.ri_lueLenders.ValueMember = "LD_Lender_ID";
            // 
            // lDLenderBindingSource
            // 
            this.lDLenderBindingSource.DataMember = "LD_Lender";
            this.lDLenderBindingSource.DataSource = this.dsLender1;
            // 
            // dsLender1
            // 
            this.dsLender1.DataSetName = "dsLender";
            this.dsLender1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            this.colStartDate.Width = 110;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.FieldName = "ExpiryDate";
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.Visible = true;
            this.colExpiryDate.VisibleIndex = 7;
            this.colExpiryDate.Width = 110;
            // 
            // colAmount
            // 
            this.colAmount.ColumnEdit = this.ri_seAmount;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            this.colAmount.Width = 91;
            // 
            // ri_seAmount
            // 
            this.ri_seAmount.AutoHeight = false;
            this.ri_seAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.ri_seAmount.Mask.EditMask = "n2";
            this.ri_seAmount.Mask.UseMaskAsDisplayFormat = true;
            this.ri_seAmount.Name = "ri_seAmount";
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 10;
            this.colNotes.Width = 101;
            // 
            // colActualReleaseDate
            // 
            this.colActualReleaseDate.FieldName = "ActualReleaseDate";
            this.colActualReleaseDate.Name = "colActualReleaseDate";
            this.colActualReleaseDate.Visible = true;
            this.colActualReleaseDate.VisibleIndex = 5;
            this.colActualReleaseDate.Width = 122;
            // 
            // colEstimatedReleaseDate
            // 
            this.colEstimatedReleaseDate.FieldName = "EstimatedReleaseDate";
            this.colEstimatedReleaseDate.Name = "colEstimatedReleaseDate";
            this.colEstimatedReleaseDate.Visible = true;
            this.colEstimatedReleaseDate.VisibleIndex = 6;
            this.colEstimatedReleaseDate.Width = 135;
            // 
            // colBeneficiary_id
            // 
            this.colBeneficiary_id.Caption = "Beneficiary";
            this.colBeneficiary_id.ColumnEdit = this.riBeneficiary;
            this.colBeneficiary_id.FieldName = "Beneficiary_id";
            this.colBeneficiary_id.Name = "colBeneficiary_id";
            this.colBeneficiary_id.Visible = true;
            this.colBeneficiary_id.VisibleIndex = 9;
            // 
            // riBeneficiary
            // 
            this.riBeneficiary.AutoHeight = false;
            this.riBeneficiary.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riBeneficiary.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIER", "Code", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Description", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIER_ID", "SUPPLIER_ID", 74, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.riBeneficiary.DataSource = this.bsBeneficiary;
            this.riBeneficiary.DisplayMember = "NAME";
            this.riBeneficiary.Name = "riBeneficiary";
            this.riBeneficiary.NullText = "";
            this.riBeneficiary.PopupWidth = 300;
            this.riBeneficiary.ValueMember = "SUPPLIER_ID";
            // 
            // bsBeneficiary
            // 
            this.bsBeneficiary.DataMember = "SUPPLIER_MASTER";
            this.bsBeneficiary.DataSource = this.dsBeneficiary1;
            // 
            // dsBeneficiary1
            // 
            this.dsBeneficiary1.DataSetName = "dsBeneficiary";
            this.dsBeneficiary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1147, 413);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grpLetterOfCredit;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1145, 287);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grpNotes;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 287);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1145, 124);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=dev12;Initial Catalog=TR_Test2;Persist Security Info=True;User ID=hms" +
                "qlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ReferenceNum", System.Data.SqlDbType.VarChar, 0, "ReferenceNum"),
            new System.Data.SqlClient.SqlParameter("@LOC_Type", System.Data.SqlDbType.VarChar, 0, "LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@LOC_Description", System.Data.SqlDbType.VarChar, 0, "LOC_Description"),
            new System.Data.SqlClient.SqlParameter("@Lender_ID", System.Data.SqlDbType.Int, 0, "Lender_ID"),
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 0, "StartDate"),
            new System.Data.SqlClient.SqlParameter("@ExpiryDate", System.Data.SqlDbType.DateTime, 0, "ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.VarChar, 0, "Notes"),
            new System.Data.SqlClient.SqlParameter("@EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, "EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, "ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@Beneficiary_id", System.Data.SqlDbType.Int, 0, "Beneficiary_id")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ReferenceNum", System.Data.SqlDbType.VarChar, 0, "ReferenceNum"),
            new System.Data.SqlClient.SqlParameter("@LOC_Type", System.Data.SqlDbType.VarChar, 0, "LOC_Type"),
            new System.Data.SqlClient.SqlParameter("@LOC_Description", System.Data.SqlDbType.VarChar, 0, "LOC_Description"),
            new System.Data.SqlClient.SqlParameter("@Lender_ID", System.Data.SqlDbType.Int, 0, "Lender_ID"),
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime, 0, "StartDate"),
            new System.Data.SqlClient.SqlParameter("@ExpiryDate", System.Data.SqlDbType.DateTime, 0, "ExpiryDate"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.VarChar, 0, "Notes"),
            new System.Data.SqlClient.SqlParameter("@EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, "EstimatedReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, "ActualReleaseDate"),
            new System.Data.SqlClient.SqlParameter("@Beneficiary_id", System.Data.SqlDbType.Int, 0, "Beneficiary_id"),
            new System.Data.SqlClient.SqlParameter("@Original_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReferenceNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReferenceNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReferenceNum", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReferenceNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOC_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOC_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOC_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOC_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOC_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOC_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOC_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lender_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lender_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpiryDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpiryDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EstimatedReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Beneficiary_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Beneficiary_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Beneficiary_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Beneficiary_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@LetterOfCredit_ID", System.Data.SqlDbType.Int, 4, "LetterOfCredit_ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_LetterOfCredit_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LetterOfCredit_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReferenceNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReferenceNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReferenceNum", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReferenceNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOC_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOC_Type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOC_Type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOC_Type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOC_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOC_Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOC_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOC_Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lender_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lender_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StartDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StartDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpiryDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpiryDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpiryDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpiryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EstimatedReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EstimatedReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EstimatedReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EstimatedReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ActualReleaseDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualReleaseDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ActualReleaseDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualReleaseDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Beneficiary_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Beneficiary_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Beneficiary_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Beneficiary_id", System.Data.DataRowVersion.Original, null)});
            // 
            // da_letterOfCredit
            // 
            this.da_letterOfCredit.DeleteCommand = this.sqlDeleteCommand1;
            this.da_letterOfCredit.InsertCommand = this.sqlInsertCommand1;
            this.da_letterOfCredit.SelectCommand = this.sqlSelectCommand1;
            this.da_letterOfCredit.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_PROJ_LetterOfCredit", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LetterOfCredit_ID", "LetterOfCredit_ID"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("ReferenceNum", "ReferenceNum"),
                        new System.Data.Common.DataColumnMapping("LOC_Type", "LOC_Type"),
                        new System.Data.Common.DataColumnMapping("LOC_Description", "LOC_Description"),
                        new System.Data.Common.DataColumnMapping("Lender_ID", "Lender_ID"),
                        new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
                        new System.Data.Common.DataColumnMapping("ExpiryDate", "ExpiryDate"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                        new System.Data.Common.DataColumnMapping("EstimatedReleaseDate", "EstimatedReleaseDate"),
                        new System.Data.Common.DataColumnMapping("ActualReleaseDate", "ActualReleaseDate"),
                        new System.Data.Common.DataColumnMapping("Beneficiary_id", "Beneficiary_id")})});
            this.da_letterOfCredit.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     LD_Lender_ID, Lender, isBank, BANK_ID\r\nFROM         LD_Lender\r\nORDER B" +
                "Y Lender";
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Lender", System.Data.SqlDbType.VarChar, 0, "Lender"),
            new System.Data.SqlClient.SqlParameter("@isBank", System.Data.SqlDbType.Bit, 0, "isBank"),
            new System.Data.SqlClient.SqlParameter("@BANK_ID", System.Data.SqlDbType.Int, 0, "BANK_ID")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Lender", System.Data.SqlDbType.VarChar, 0, "Lender"),
            new System.Data.SqlClient.SqlParameter("@isBank", System.Data.SqlDbType.Bit, 0, "isBank"),
            new System.Data.SqlClient.SqlParameter("@BANK_ID", System.Data.SqlDbType.Int, 0, "BANK_ID"),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Lender_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lender", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_isBank", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "isBank", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BANK_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BANK_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BANK_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BANK_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@LD_Lender_ID", System.Data.SqlDbType.Int, 4, "LD_Lender_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_LD_Lender_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Lender_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lender", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lender", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_isBank", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "isBank", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BANK_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BANK_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BANK_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BANK_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // daLender
            // 
            this.daLender.DeleteCommand = this.sqlDeleteCommand2;
            this.daLender.InsertCommand = this.sqlInsertCommand2;
            this.daLender.SelectCommand = this.sqlSelectCommand2;
            this.daLender.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Lender", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LD_Lender_ID", "LD_Lender_ID"),
                        new System.Data.Common.DataColumnMapping("Lender", "Lender"),
                        new System.Data.Common.DataColumnMapping("isBank", "isBank"),
                        new System.Data.Common.DataColumnMapping("BANK_ID", "BANK_ID")})});
            this.daLender.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.HideImmediatelyOnAutoHide = true;
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpNotes});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpNotes
            // 
            this.dpNotes.Controls.Add(this.dockPanel1_Container);
            this.dpNotes.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpNotes.ID = new System.Guid("9a0bbfad-283e-42fb-af8f-374cc14ca3b0");
            this.dpNotes.Location = new System.Drawing.Point(0, 413);
            this.dpNotes.Name = "dpNotes";
            this.dpNotes.Size = new System.Drawing.Size(1147, 216);
            this.dpNotes.Text = "Notes/ Logging";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1141, 188);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "\r\nselect SUPPLIER, NAME, SUPPLIER_ID from SUPPLIER_MASTER\r\norder by SUPPLIER, NAM" +
                "E";
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SUPPLIER", System.Data.SqlDbType.VarChar, 0, "SUPPLIER"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@SUPPLIER_ID", System.Data.SqlDbType.Int, 0, "SUPPLIER_ID")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SUPPLIER", System.Data.SqlDbType.VarChar, 0, "SUPPLIER"),
            new System.Data.SqlClient.SqlParameter("@NAME", System.Data.SqlDbType.VarChar, 0, "NAME"),
            new System.Data.SqlClient.SqlParameter("@SUPPLIER_ID", System.Data.SqlDbType.Int, 0, "SUPPLIER_ID"),
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLIER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLIER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SUPPLIER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SUPPLIER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLIER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLIER_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLIER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLIER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SUPPLIER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SUPPLIER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLIER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLIER_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // daBeneficiary
            // 
            this.daBeneficiary.DeleteCommand = this.sqlDeleteCommand3;
            this.daBeneficiary.InsertCommand = this.sqlInsertCommand3;
            this.daBeneficiary.SelectCommand = this.sqlSelectCommand3;
            this.daBeneficiary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SUPPLIER_MASTER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SUPPLIER", "SUPPLIER"),
                        new System.Data.Common.DataColumnMapping("NAME", "NAME"),
                        new System.Data.Common.DataColumnMapping("SUPPLIER_ID", "SUPPLIER_ID")})});
            this.daBeneficiary.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // ucLetterOfCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dpNotes);
            this.Name = "ucLetterOfCredit";
            this.Size = new System.Drawing.Size(1147, 629);
            this.Load += new System.EventHandler(this.ucLetterOfCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpNotes)).EndInit();
            this.grpNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_letterOfCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLetterOfCredit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLetterOfCredit)).EndInit();
            this.grpLetterOfCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLetterOfCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLetterOfCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teMax50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLenders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDLenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBeneficiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeneficiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl grpNotes;
        private DevExpress.XtraEditors.GroupControl grpLetterOfCredit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcLetterOfCredit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLetterOfCredit;
        private DevExpress.XtraEditors.MemoEdit meNotes;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter da_letterOfCredit;
        private dsLetterOfCredit dsLetterOfCredit1;
        private System.Windows.Forms.BindingSource bs_letterOfCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colLetterOfCredit_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNum;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teMax25;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teMax50;
        private DevExpress.XtraGrid.Columns.GridColumn colLender_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit ri_seAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLenders;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daLender;
        private dsLender dsLender1;
        private System.Windows.Forms.BindingSource lDLenderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colActualReleaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEstimatedReleaseDate;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpNotes;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficiary_id;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter daBeneficiary;
        private dsBeneficiary dsBeneficiary1;
        private System.Windows.Forms.BindingSource bsBeneficiary;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riBeneficiary;
    }
}
