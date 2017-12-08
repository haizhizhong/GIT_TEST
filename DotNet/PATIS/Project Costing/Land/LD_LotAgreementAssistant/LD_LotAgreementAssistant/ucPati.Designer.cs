namespace LD_LotAgreementAssistant
{
    partial class ucPati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPati));
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpMain = new DevExpress.XtraTab.XtraTabPage();
            this.rgProcessType = new DevExpress.XtraEditors.RadioGroup();
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tpDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpdAgreement = new DevExpress.XtraTab.XtraTabPage();
            this.tpdLot = new DevExpress.XtraTab.XtraTabPage();
            this.tpdAgreementEdit = new DevExpress.XtraTab.XtraTabPage();
            this.tpdUpdate = new DevExpress.XtraTab.XtraTabPage();
            this.tpdSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.btnARPayment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgProcessType.Properties)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).BeginInit();
            this.tcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpMain;
            this.tcMain.Size = new System.Drawing.Size(948, 607);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMain,
            this.tpDetails});
            this.tcMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcMain_SelectedPageChanged);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.rgProcessType);
            this.tpMain.Controls.Add(this.welcomeScreen1);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(942, 579);
            this.tpMain.Text = "Main";
            // 
            // rgProcessType
            // 
            this.rgProcessType.EditValue = "N";
            this.rgProcessType.Location = new System.Drawing.Point(271, 309);
            this.rgProcessType.Name = "rgProcessType";
            this.rgProcessType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Create New Agreement"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Edit Existing Agreement")});
            this.rgProcessType.Size = new System.Drawing.Size(171, 64);
            this.rgProcessType.TabIndex = 1;
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.DescriptionCaption = "Use this assistant to help you in creating individual or master lot agreements. T" +
    "his assistant can also be used to append to an existing master agreement.";
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(942, 579);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = "Lot Agreement Assistant";
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tcDetails);
            this.tpDetails.Controls.Add(this.topBanner1);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Size = new System.Drawing.Size(942, 579);
            this.tpDetails.Text = "Details";
            // 
            // tcDetails
            // 
            this.tcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetails.Location = new System.Drawing.Point(0, 88);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedTabPage = this.tpdAgreement;
            this.tcDetails.Size = new System.Drawing.Size(942, 491);
            this.tcDetails.TabIndex = 0;
            this.tcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpdAgreement,
            this.tpdLot,
            this.tpdAgreementEdit,
            this.tpdUpdate,
            this.tpdSummary});
            this.tcDetails.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcDetails_SelectedPageChanged);
            // 
            // tpdAgreement
            // 
            this.tpdAgreement.Name = "tpdAgreement";
            this.tpdAgreement.Size = new System.Drawing.Size(936, 463);
            this.tpdAgreement.Text = "Agreement";
            // 
            // tpdLot
            // 
            this.tpdLot.Name = "tpdLot";
            this.tpdLot.Size = new System.Drawing.Size(936, 463);
            this.tpdLot.Text = "Lot";
            // 
            // tpdAgreementEdit
            // 
            this.tpdAgreementEdit.Name = "tpdAgreementEdit";
            this.tpdAgreementEdit.Size = new System.Drawing.Size(936, 463);
            this.tpdAgreementEdit.Text = "Agreement Edit";
            // 
            // tpdUpdate
            // 
            this.tpdUpdate.Name = "tpdUpdate";
            this.tpdUpdate.Size = new System.Drawing.Size(936, 463);
            this.tpdUpdate.Text = "Update";
            // 
            // tpdSummary
            // 
            this.tpdSummary.Name = "tpdSummary";
            this.tpdSummary.Size = new System.Drawing.Size(936, 463);
            this.tpdSummary.Text = "Summary";
            // 
            // topBanner1
            // 
            this.topBanner1.BackColor = System.Drawing.Color.White;
            this.topBanner1.BannerTextCaption = null;
            this.topBanner1.BannerTitleCaption = null;
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(942, 88);
            this.topBanner1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnARPayment);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 607);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(948, 31);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(849, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(687, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(768, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
    "True;User ID=sa;Password=sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnARPayment
            // 
            this.btnARPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnARPayment.Location = new System.Drawing.Point(506, 5);
            this.btnARPayment.Name = "btnARPayment";
            this.btnARPayment.Size = new System.Drawing.Size(123, 23);
            this.btnARPayment.TabIndex = 4;
            this.btnARPayment.Text = "AR Payment";
            this.btnARPayment.Click += new System.EventHandler(this.btnARPayment_Click);
            // 
            // ucPati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPati";
            this.Size = new System.Drawing.Size(948, 638);
            this.Load += new System.EventHandler(this.ucPati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgProcessType.Properties)).EndInit();
            this.tpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).EndInit();
            this.tcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpMain;
        private DevExpress.XtraTab.XtraTabPage tpDetails;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraTab.XtraTabControl tcDetails;
        private DevExpress.XtraTab.XtraTabPage tpdAgreement;
        private DevExpress.XtraTab.XtraTabPage tpdLot;
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraEditors.RadioGroup rgProcessType;
        private DevExpress.XtraTab.XtraTabPage tpdAgreementEdit;
        private DevExpress.XtraTab.XtraTabPage tpdUpdate;
        private DevExpress.XtraTab.XtraTabPage tpdSummary;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private DevExpress.XtraEditors.SimpleButton btnARPayment;
    }
}
