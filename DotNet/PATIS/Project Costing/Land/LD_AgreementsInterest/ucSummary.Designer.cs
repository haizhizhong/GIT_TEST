namespace LD_AgreementsInterest
{
    partial class ucSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSummary));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpSubledgerPreview = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.dsSummary1 = new LD_AgreementsInterest.dsSummary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBlock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipleBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutstandingInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArrears = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tePeriod = new DevExpress.XtraEditors.TextEdit();
            this.teYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deInterestDate = new DevExpress.XtraEditors.DateEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            this.riteNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.riteFixed0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpSubledgerPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInterestDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInterestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteFixed0)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpSubledgerPreview});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dpSubledgerPreview
            // 
            this.dpSubledgerPreview.Controls.Add(this.dockPanel1_Container);
            this.dpSubledgerPreview.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpSubledgerPreview.ID = new System.Guid("01a2ea6a-075d-48b0-9375-0afd4e1d9917");
            this.dpSubledgerPreview.Location = new System.Drawing.Point(0, 406);
            this.dpSubledgerPreview.Name = "dpSubledgerPreview";
            this.dpSubledgerPreview.OriginalSize = new System.Drawing.Size(200, 278);
            this.dpSubledgerPreview.Size = new System.Drawing.Size(1268, 278);
            this.dpSubledgerPreview.Text = "Subledger Preview";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1260, 250);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gcSummary
            // 
            this.gcSummary.DataMember = "working_ld_agreement_interest";
            this.gcSummary.DataSource = this.dsSummary1;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 38);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteNumaric2,
            this.riteFixed0});
            this.gcSummary.Size = new System.Drawing.Size(1268, 368);
            this.gcSummary.TabIndex = 1;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusername,
            this.colagreement_id,
            this.colagreement_num,
            this.colProjectName,
            this.colBlock,
            this.colLot,
            this.colPrincipleBalance,
            this.colOutstandingInterest,
            this.colRegular,
            this.colArrears,
            this.colTotal});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.ColumnEdit = this.riteFixed0;
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 0;
            this.colagreement_num.Width = 89;
            // 
            // colProjectName
            // 
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            this.colProjectName.Width = 227;
            // 
            // colBlock
            // 
            this.colBlock.FieldName = "Block";
            this.colBlock.Name = "colBlock";
            this.colBlock.Visible = true;
            this.colBlock.VisibleIndex = 2;
            // 
            // colLot
            // 
            this.colLot.FieldName = "Lot";
            this.colLot.Name = "colLot";
            this.colLot.Visible = true;
            this.colLot.VisibleIndex = 3;
            // 
            // colPrincipleBalance
            // 
            this.colPrincipleBalance.ColumnEdit = this.riteNumaric2;
            this.colPrincipleBalance.FieldName = "PrincipleBalance";
            this.colPrincipleBalance.Name = "colPrincipleBalance";
            this.colPrincipleBalance.Visible = true;
            this.colPrincipleBalance.VisibleIndex = 4;
            this.colPrincipleBalance.Width = 126;
            // 
            // colOutstandingInterest
            // 
            this.colOutstandingInterest.ColumnEdit = this.riteNumaric2;
            this.colOutstandingInterest.FieldName = "OutstandingInterest";
            this.colOutstandingInterest.Name = "colOutstandingInterest";
            this.colOutstandingInterest.Visible = true;
            this.colOutstandingInterest.VisibleIndex = 5;
            this.colOutstandingInterest.Width = 121;
            // 
            // colRegular
            // 
            this.colRegular.ColumnEdit = this.riteNumaric2;
            this.colRegular.FieldName = "Regular";
            this.colRegular.Name = "colRegular";
            this.colRegular.Visible = true;
            this.colRegular.VisibleIndex = 6;
            this.colRegular.Width = 133;
            // 
            // colArrears
            // 
            this.colArrears.ColumnEdit = this.riteNumaric2;
            this.colArrears.FieldName = "Arrears";
            this.colArrears.Name = "colArrears";
            this.colArrears.Visible = true;
            this.colArrears.VisibleIndex = 7;
            this.colArrears.Width = 130;
            // 
            // colTotal
            // 
            this.colTotal.ColumnEdit = this.riteNumaric2;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 111;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tePeriod);
            this.panelControl1.Controls.Add(this.teYear);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deInterestDate);
            this.panelControl1.Controls.Add(this.btnRegister);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1268, 38);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(155, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Period";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Year";
            // 
            // tePeriod
            // 
            this.tePeriod.Location = new System.Drawing.Point(212, 7);
            this.tePeriod.Name = "tePeriod";
            this.tePeriod.Properties.ReadOnly = true;
            this.tePeriod.Size = new System.Drawing.Size(83, 20);
            this.tePeriod.TabIndex = 9;
            // 
            // teYear
            // 
            this.teYear.Location = new System.Drawing.Point(66, 7);
            this.teYear.Name = "teYear";
            this.teYear.Properties.ReadOnly = true;
            this.teYear.Size = new System.Drawing.Size(72, 20);
            this.teYear.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(301, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Interest Date";
            // 
            // deInterestDate
            // 
            this.deInterestDate.EditValue = null;
            this.deInterestDate.Enabled = false;
            this.deInterestDate.Location = new System.Drawing.Point(388, 7);
            this.deInterestDate.Name = "deInterestDate";
            this.deInterestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInterestDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInterestDate.Size = new System.Drawing.Size(100, 20);
            this.deInterestDate.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(1103, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Print Pre-Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DEVSQL2008R2;Initial Catalog=TR_V11_GC;User ID=hmsqlsa;Password=hmsql" +
    "sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@ProjectName", System.Data.SqlDbType.VarChar, 0, "ProjectName"),
            new System.Data.SqlClient.SqlParameter("@Block", System.Data.SqlDbType.VarChar, 0, "Block"),
            new System.Data.SqlClient.SqlParameter("@Lot", System.Data.SqlDbType.VarChar, 0, "Lot"),
            new System.Data.SqlClient.SqlParameter("@PrincipleBalance", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "PrincipleBalance", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@OutstandingInterest", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "OutstandingInterest", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Regular", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Regular", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Arrears", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Arrears", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(16)), ((byte)(4)), "Total", System.Data.DataRowVersion.Current, null)});
            // 
            // daSummary
            // 
            this.daSummary.InsertCommand = this.sqlInsertCommand1;
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_agreement_interest", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"),
                        new System.Data.Common.DataColumnMapping("Block", "Block"),
                        new System.Data.Common.DataColumnMapping("Lot", "Lot"),
                        new System.Data.Common.DataColumnMapping("PrincipleBalance", "PrincipleBalance"),
                        new System.Data.Common.DataColumnMapping("OutstandingInterest", "OutstandingInterest"),
                        new System.Data.Common.DataColumnMapping("Regular", "Regular"),
                        new System.Data.Common.DataColumnMapping("Arrears", "Arrears"),
                        new System.Data.Common.DataColumnMapping("Total", "Total")})});
            // 
            // riteNumaric2
            // 
            this.riteNumaric2.AutoHeight = false;
            this.riteNumaric2.Mask.EditMask = "n";
            this.riteNumaric2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumaric2.Name = "riteNumaric2";
            // 
            // riteFixed0
            // 
            this.riteFixed0.AutoHeight = false;
            this.riteFixed0.Mask.EditMask = "f0";
            this.riteFixed0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteFixed0.Mask.UseMaskAsDisplayFormat = true;
            this.riteFixed0.Name = "riteFixed0";
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.dpSubledgerPreview);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1268, 684);
            this.Load += new System.EventHandler(this.ucSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpSubledgerPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInterestDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInterestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteFixed0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpSubledgerPreview;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit deInterestDate;
        private dsSummary dsSummary1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colBlock;
        private DevExpress.XtraGrid.Columns.GridColumn colLot;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipleBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colOutstandingInterest;
        private DevExpress.XtraGrid.Columns.GridColumn colRegular;
        private DevExpress.XtraGrid.Columns.GridColumn colArrears;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private DevExpress.XtraEditors.TextEdit tePeriod;
        private DevExpress.XtraEditors.TextEdit teYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteFixed0;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumaric2;
    }
}
