namespace LD_LotPayoutAssistant
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
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tpDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tpReview = new DevExpress.XtraTab.XtraTabPage();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
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
            this.tcMain.Size = new System.Drawing.Size(900, 644);
            this.tcMain.TabIndex = 2;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMain,
            this.tpDetails});
            this.tcMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcMain_SelectedPageChanged);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.welcomeScreen1);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(891, 613);
            this.tpMain.Text = "Main";
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.BackgroundImage")));
            this.welcomeScreen1.DescriptionCaption = "Use this assistant to help in creating lot payouts. This assistant will calculate" +
                " payout interest and allow the entry of additional charges/fees.";
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(891, 613);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = "Lot Payout Assistant";
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tcDetails);
            this.tpDetails.Controls.Add(this.topBanner1);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Size = new System.Drawing.Size(891, 613);
            this.tpDetails.Text = "Details";
            // 
            // tcDetails
            // 
            this.tcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetails.Location = new System.Drawing.Point(0, 88);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedTabPage = this.tpLotSelection;
            this.tcDetails.Size = new System.Drawing.Size(891, 525);
            this.tcDetails.TabIndex = 0;
            this.tcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpLotSelection,
            this.tpReview,
            this.tpSummary});
            this.tcDetails.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcDetails_SelectedPageChanged);
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(882, 494);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // tpReview
            // 
            this.tpReview.Name = "tpReview";
            this.tpReview.Size = new System.Drawing.Size(882, 494);
            this.tpReview.Text = "Review";
            // 
            // tpSummary
            // 
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(882, 494);
            this.tpSummary.Text = "Summary";
            // 
            // topBanner1
            // 
            this.topBanner1.BannerTextCaption = null;
            this.topBanner1.BannerTitleCaption = null;
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(891, 88);
            this.topBanner1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 644);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 35);
            this.panelControl1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(651, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "< Back ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(732, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(813, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucPati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPati";
            this.Size = new System.Drawing.Size(900, 679);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
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
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private DevExpress.XtraTab.XtraTabPage tpDetails;
        private DevExpress.XtraTab.XtraTabControl tcDetails;
        private DevExpress.XtraTab.XtraTabPage tpLotSelection;
        private DevExpress.XtraTab.XtraTabPage tpReview;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

    }
}
