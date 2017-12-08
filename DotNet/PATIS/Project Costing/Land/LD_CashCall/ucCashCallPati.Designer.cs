namespace LD_CashCall
{
    partial class ucCashCallPati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCashCallPati));
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpMain = new DevExpress.XtraTab.XtraTabPage();
            this.luBatches = new DevExpress.XtraEditors.LookUpEdit();
            this.lDCashcallDisbursementHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBatches1 = new LD_CashCall.dsBatches();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tpDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpProjSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tpCalculations = new DevExpress.XtraTab.XtraTabPage();
            this.pcCashflow = new DevExpress.XtraEditors.PanelControl();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner = new HMProcessAssistantLib.TopBanner();
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dsGL1 = new Subledger_Preview.dsGL();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.daBatches = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luBatches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDCashcallDisbursementHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatches1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).BeginInit();
            this.tcDetails.SuspendLayout();
            this.tpCalculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCashflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGL1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpMain;
            this.tcMain.Size = new System.Drawing.Size(1168, 530);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMain,
            this.tpDetails});
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.luBatches);
            this.tpMain.Controls.Add(this.radioGroup1);
            this.tpMain.Controls.Add(this.welcomeScreen1);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(1159, 499);
            this.tpMain.Text = "Main";
            // 
            // luBatches
            // 
            this.luBatches.Location = new System.Drawing.Point(732, 442);
            this.luBatches.Name = "luBatches";
            this.luBatches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Delete")});
            this.luBatches.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Batch", "Batch", 50, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Created", "Created", 49, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Created By", "Created By", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("As At Date", "As At Date", 62, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luBatches.Properties.DataSource = this.lDCashcallDisbursementHeaderBindingSource;
            this.luBatches.Properties.DisplayMember = "Batch";
            this.luBatches.Properties.NullText = "*** Select a batch";
            this.luBatches.Properties.PopupWidth = 600;
            this.luBatches.Properties.ValueMember = "Batch";
            this.luBatches.Size = new System.Drawing.Size(234, 20);
            this.luBatches.TabIndex = 2;
            this.luBatches.Visible = false;
            this.luBatches.EditValueChanged += new System.EventHandler(this.luBatches_EditValueChanged);
            this.luBatches.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.luBatches_QueryPopUp);
            this.luBatches.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luBatches_ButtonPressed);
            // 
            // lDCashcallDisbursementHeaderBindingSource
            // 
            this.lDCashcallDisbursementHeaderBindingSource.DataMember = "LD_CashcallDisbursementHeader";
            this.lDCashcallDisbursementHeaderBindingSource.DataSource = this.dsBatches1;
            // 
            // dsBatches1
            // 
            this.dsBatches1.DataSetName = "dsBatches";
            this.dsBatches1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(732, 370);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Create a new batch"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Select an existing batch")});
            this.radioGroup1.Size = new System.Drawing.Size(234, 66);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.DescriptionCaption = null;
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(1159, 499);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = null;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tcDetails);
            this.tpDetails.Controls.Add(this.topBanner);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Size = new System.Drawing.Size(1159, 499);
            this.tpDetails.Text = "Details";
            // 
            // tcDetails
            // 
            this.tcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetails.Location = new System.Drawing.Point(0, 88);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedTabPage = this.tpProjSelection;
            this.tcDetails.Size = new System.Drawing.Size(1159, 411);
            this.tcDetails.TabIndex = 0;
            this.tcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpProjSelection,
            this.tpCalculations,
            this.tpSummary});
            // 
            // tpProjSelection
            // 
            this.tpProjSelection.Name = "tpProjSelection";
            this.tpProjSelection.Size = new System.Drawing.Size(1150, 380);
            this.tpProjSelection.Text = "Project Selection";
            // 
            // tpCalculations
            // 
            this.tpCalculations.Controls.Add(this.pcCashflow);
            this.tpCalculations.Name = "tpCalculations";
            this.tpCalculations.Size = new System.Drawing.Size(1150, 380);
            this.tpCalculations.Text = "Calculations";
            // 
            // pcCashflow
            // 
            this.pcCashflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCashflow.Location = new System.Drawing.Point(0, 0);
            this.pcCashflow.Name = "pcCashflow";
            this.pcCashflow.Size = new System.Drawing.Size(1150, 380);
            this.pcCashflow.TabIndex = 0;
            // 
            // tpSummary
            // 
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(1150, 380);
            this.tpSummary.Text = "Summary";
            // 
            // topBanner
            // 
            this.topBanner.BackColor = System.Drawing.Color.White;
            this.topBanner.BannerTextCaption = null;
            this.topBanner.BannerTitleCaption = null;
            this.topBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner.Location = new System.Drawing.Point(0, 0);
            this.topBanner.Name = "topBanner";
            this.topBanner.Size = new System.Drawing.Size(1159, 88);
            this.topBanner.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 530);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1168, 32);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(809, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(906, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(144, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1056, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dsGL1
            // 
            this.dsGL1.DataSetName = "dsGL";
            this.dsGL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.VarChar, 20, "Type"),
            new System.Data.SqlClient.SqlParameter("@CompanyID", System.Data.SqlDbType.Int, 4, "CompanyID")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=CSMSQL2008;Initial Catalog=WEB_LENMAK;Persist Security Info=True;User" +
                " ID=hmsqlsa;Password=hmsqlsa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // daBatches
            // 
            this.daBatches.SelectCommand = this.sqlSelectCommand1;
            this.daBatches.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_CashcallDisbursementHeader", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Batch", "Batch"),
                        new System.Data.Common.DataColumnMapping("Created", "Created"),
                        new System.Data.Common.DataColumnMapping("Created By", "Created By"),
                        new System.Data.Common.DataColumnMapping("As At Date", "As At Date"),
                        new System.Data.Common.DataColumnMapping("Status", "Status")})});
            // 
            // ucCashCallPati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pnlButtons);
            this.Name = "ucCashCallPati";
            this.Size = new System.Drawing.Size(1168, 562);
            this.Load += new System.EventHandler(this.ucCashCallPati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luBatches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDCashcallDisbursementHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatches1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.tpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).EndInit();
            this.tcDetails.ResumeLayout(false);
            this.tpCalculations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCashflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGL1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpMain;
        private DevExpress.XtraTab.XtraTabPage tpDetails;
        private DevExpress.XtraTab.XtraTabControl tcDetails;
        private DevExpress.XtraTab.XtraTabPage tpProjSelection;
        private DevExpress.XtraTab.XtraTabPage tpCalculations;
        private HMProcessAssistantLib.TopBanner topBanner;
        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private DevExpress.XtraEditors.PanelControl pcCashflow;
        private Subledger_Preview.dsGL dsGL1;
        private DevExpress.XtraEditors.LookUpEdit luBatches;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter daBatches;
        private dsBatches dsBatches1;
        private System.Windows.Forms.BindingSource lDCashcallDisbursementHeaderBindingSource;
        public DevExpress.XtraEditors.SimpleButton btnNext;
    }
}
