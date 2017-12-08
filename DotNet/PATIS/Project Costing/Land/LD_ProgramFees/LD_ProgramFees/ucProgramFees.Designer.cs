namespace LD_ProgramFees
{
    partial class ucProgramFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProgramFees));
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpWelcome = new DevExpress.XtraTab.XtraTabPage();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lueProgramFeesList = new DevExpress.XtraEditors.LookUpEdit();
            this.lDProgramFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgramFeesList1 = new LD_ProgramFees.dsProgramFeesList();
            this.tpContent = new DevExpress.XtraTab.XtraTabPage();
            this.tcContent = new DevExpress.XtraTab.XtraTabControl();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tcLotSelection = new DevExpress.XtraTab.XtraTabControl();
            this.tpCreateCertificate = new DevExpress.XtraTab.XtraTabPage();
            this.tpCancelCertificate = new DevExpress.XtraTab.XtraTabPage();
            this.tpFeeSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daProgramFeesList = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProgramFeesList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProgramFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgramFeesList1)).BeginInit();
            this.tpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcContent)).BeginInit();
            this.tcContent.SuspendLayout();
            this.tpLotSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcLotSelection)).BeginInit();
            this.tcLotSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.BackgroundImage")));
            this.welcomeScreen1.DescriptionCaption = "Use this Assistant to help you in processing your program fees. Select the Fee yo" +
                "u want to process and click next to continue.";
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(1224, 691);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = "Program Fees";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpWelcome;
            this.tcMain.Size = new System.Drawing.Size(1233, 722);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpWelcome,
            this.tpContent});
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.rgType);
            this.tpWelcome.Controls.Add(this.groupControl1);
            this.tpWelcome.Controls.Add(this.welcomeScreen1);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Size = new System.Drawing.Size(1224, 691);
            this.tpWelcome.Text = "Welcome";
            // 
            // rgType
            // 
            this.rgType.EditValue = "N";
            this.rgType.Location = new System.Drawing.Point(230, 282);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Create Certificate"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Cancel Certificates")});
            this.rgType.Size = new System.Drawing.Size(240, 27);
            this.rgType.TabIndex = 2;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lueProgramFeesList);
            this.groupControl1.Location = new System.Drawing.Point(230, 334);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(240, 65);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Fee Selection";
            // 
            // lueProgramFeesList
            // 
            this.lueProgramFeesList.Location = new System.Drawing.Point(5, 23);
            this.lueProgramFeesList.Name = "lueProgramFeesList";
            this.lueProgramFeesList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProgramFeesList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueProgramFeesList.Properties.DataSource = this.lDProgramFeesBindingSource;
            this.lueProgramFeesList.Properties.DisplayMember = "Description";
            this.lueProgramFeesList.Properties.NullText = "";
            this.lueProgramFeesList.Properties.ValueMember = "ID";
            this.lueProgramFeesList.Size = new System.Drawing.Size(214, 20);
            this.lueProgramFeesList.TabIndex = 0;
            // 
            // lDProgramFeesBindingSource
            // 
            this.lDProgramFeesBindingSource.DataMember = "LD_ProgramFees";
            this.lDProgramFeesBindingSource.DataSource = this.dsProgramFeesList1;
            // 
            // dsProgramFeesList1
            // 
            this.dsProgramFeesList1.DataSetName = "dsProgramFeesList";
            this.dsProgramFeesList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpContent
            // 
            this.tpContent.Controls.Add(this.tcContent);
            this.tpContent.Controls.Add(this.topBanner1);
            this.tpContent.Name = "tpContent";
            this.tpContent.Size = new System.Drawing.Size(1224, 691);
            this.tpContent.Text = "Content";
            // 
            // tcContent
            // 
            this.tcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcContent.Location = new System.Drawing.Point(0, 88);
            this.tcContent.Name = "tcContent";
            this.tcContent.SelectedTabPage = this.tpLotSelection;
            this.tcContent.Size = new System.Drawing.Size(1224, 603);
            this.tcContent.TabIndex = 1;
            this.tcContent.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpLotSelection,
            this.tpFeeSelection,
            this.tpSummary});
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Controls.Add(this.tcLotSelection);
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(1215, 572);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // tcLotSelection
            // 
            this.tcLotSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLotSelection.Location = new System.Drawing.Point(0, 0);
            this.tcLotSelection.Name = "tcLotSelection";
            this.tcLotSelection.SelectedTabPage = this.tpCreateCertificate;
            this.tcLotSelection.Size = new System.Drawing.Size(1215, 572);
            this.tcLotSelection.TabIndex = 0;
            this.tcLotSelection.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpCreateCertificate,
            this.tpCancelCertificate});
            // 
            // tpCreateCertificate
            // 
            this.tpCreateCertificate.Name = "tpCreateCertificate";
            this.tpCreateCertificate.Size = new System.Drawing.Size(1206, 541);
            this.tpCreateCertificate.Text = "Create Certificate";
            // 
            // tpCancelCertificate
            // 
            this.tpCancelCertificate.Name = "tpCancelCertificate";
            this.tpCancelCertificate.Size = new System.Drawing.Size(1206, 541);
            this.tpCancelCertificate.Text = "Cancel Certificate";
            // 
            // tpFeeSelection
            // 
            this.tpFeeSelection.Name = "tpFeeSelection";
            this.tpFeeSelection.Size = new System.Drawing.Size(1215, 572);
            this.tpFeeSelection.Text = "Fee Selection";
            // 
            // tpSummary
            // 
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(1215, 572);
            this.tpSummary.Text = "Summary";
            // 
            // topBanner1
            // 
            this.topBanner1.BannerTextCaption = null;
            this.topBanner1.BannerTitleCaption = null;
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(1224, 88);
            this.topBanner1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 722);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1233, 35);
            this.panelControl1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(993, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "< Back ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1074, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1155, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     ID, Description\r\nFROM         LD_ProgramFees\r\nORDER BY Description";
            this.sqlSelectCommand1.Connection = this.sqlTR;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [LD_ProgramFees] ([Description]) VALUES (@Description);\r\nSELECT ID, D" +
                "escription FROM LD_ProgramFees WHERE (ID = SCOPE_IDENTITY()) ORDER BY Descriptio" +
                "n";
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [LD_ProgramFees] WHERE (([ID] = @Original_ID) AND ((@IsNull_Descripti" +
                "on = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)))";
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // daProgramFeesList
            // 
            this.daProgramFeesList.DeleteCommand = this.sqlDeleteCommand1;
            this.daProgramFeesList.InsertCommand = this.sqlInsertCommand1;
            this.daProgramFeesList.SelectCommand = this.sqlSelectCommand1;
            this.daProgramFeesList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ProgramFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daProgramFeesList.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ucProgramFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucProgramFees";
            this.Size = new System.Drawing.Size(1233, 757);
            this.Load += new System.EventHandler(this.ucProgramFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueProgramFeesList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProgramFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgramFeesList1)).EndInit();
            this.tpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcContent)).EndInit();
            this.tcContent.ResumeLayout(false);
            this.tpLotSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcLotSelection)).EndInit();
            this.tcLotSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpWelcome;
        private DevExpress.XtraTab.XtraTabPage tpContent;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lueProgramFeesList;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraTab.XtraTabControl tcContent;
        private DevExpress.XtraTab.XtraTabPage tpLotSelection;
        private DevExpress.XtraTab.XtraTabPage tpFeeSelection;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daProgramFeesList;
        private dsProgramFeesList dsProgramFeesList1;
        private System.Windows.Forms.BindingSource lDProgramFeesBindingSource;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraTab.XtraTabControl tcLotSelection;
        private DevExpress.XtraTab.XtraTabPage tpCreateCertificate;
        private DevExpress.XtraTab.XtraTabPage tpCancelCertificate;
    }
}
