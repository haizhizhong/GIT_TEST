namespace LD_LotSaleAssistant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnARPayment = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpMain = new DevExpress.XtraTab.XtraTabPage();
            this.rgSaleType = new DevExpress.XtraEditors.RadioGroup();
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tpDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tpReview = new DevExpress.XtraTab.XtraTabPage();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgSaleType.Properties)).BeginInit();
            this.tpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).BeginInit();
            this.tcDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnARPayment);
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 643);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // btnARPayment
            // 
            this.btnARPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnARPayment.Location = new System.Drawing.Point(569, 6);
            this.btnARPayment.Name = "btnARPayment";
            this.btnARPayment.Size = new System.Drawing.Size(123, 23);
            this.btnARPayment.TabIndex = 3;
            this.btnARPayment.Text = "AR Payment";
            this.btnARPayment.Click += new System.EventHandler(this.btnARPayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(751, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "< Back ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(832, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(913, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpMain;
            this.tcMain.Size = new System.Drawing.Size(994, 643);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMain,
            this.tpDetails});
            this.tcMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcMain_SelectedPageChanged);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.rgSaleType);
            this.tpMain.Controls.Add(this.welcomeScreen1);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(988, 615);
            this.tpMain.Text = "Main";
            // 
            // rgSaleType
            // 
            this.rgSaleType.EditValue = "p";
            this.rgSaleType.Location = new System.Drawing.Point(231, 240);
            this.rgSaleType.Name = "rgSaleType";
            this.rgSaleType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("p", "Pre-Sale Deposits"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("d", "Down Payment"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("s", "Lot Sales")});
            this.rgSaleType.Size = new System.Drawing.Size(148, 63);
            this.rgSaleType.TabIndex = 1;
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.DescriptionCaption = "Use this assistant to help you in creating pre-sale deposits or in  creating lot " +
    "sales.";
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(988, 615);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = "Lot Sale Assistant";
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tcDetails);
            this.tpDetails.Controls.Add(this.topBanner1);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Size = new System.Drawing.Size(988, 615);
            this.tpDetails.Text = "Details";
            // 
            // tcDetails
            // 
            this.tcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetails.Location = new System.Drawing.Point(0, 106);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedTabPage = this.tpLotSelection;
            this.tcDetails.Size = new System.Drawing.Size(988, 509);
            this.tcDetails.TabIndex = 1;
            this.tcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpLotSelection,
            this.tpReview,
            this.tpSummary});
            this.tcDetails.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcDetails_SelectedPageChanged);
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(982, 481);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // tpReview
            // 
            this.tpReview.Name = "tpReview";
            this.tpReview.Size = new System.Drawing.Size(982, 456);
            this.tpReview.Text = "Review";
            // 
            // tpSummary
            // 
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(982, 456);
            this.tpSummary.Text = "Summary";
            // 
            // topBanner1
            // 
            this.topBanner1.BackColor = System.Drawing.Color.White;
            this.topBanner1.BannerTextCaption = null;
            this.topBanner1.BannerTitleCaption = null;
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(988, 106);
            this.topBanner1.TabIndex = 0;
            // 
            // ucPati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPati";
            this.Size = new System.Drawing.Size(994, 681);
            this.Load += new System.EventHandler(this.ucPati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgSaleType.Properties)).EndInit();
            this.tpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcDetails)).EndInit();
            this.tcDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpMain;
        private DevExpress.XtraTab.XtraTabPage tpDetails;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private DevExpress.XtraTab.XtraTabControl tcDetails;
        private DevExpress.XtraTab.XtraTabPage tpLotSelection;
        private DevExpress.XtraTab.XtraTabPage tpReview;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private DevExpress.XtraEditors.RadioGroup rgSaleType;
        private DevExpress.XtraEditors.SimpleButton btnARPayment;
    }
}
