namespace LD_SpecHomeUpdate
{
    partial class ucSpecHomeUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSpecHomeUpdate));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpWelcome = new DevExpress.XtraTab.XtraTabPage();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.topBanner2 = new HMProcessAssistantLib.TopBanner();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpLotSelection.SuspendLayout();
            this.tpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 444);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1050, 50);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btnCancel);
            this.panelControl6.Controls.Add(this.btnBack);
            this.panelControl6.Controls.Add(this.btnNext);
            this.panelControl6.Controls.Add(this.btnFinish);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(682, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(368, 50);
            this.panelControl6.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(104, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "< Back";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(192, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(192, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpWelcome;
            this.tcMain.Size = new System.Drawing.Size(1050, 444);
            this.tcMain.TabIndex = 7;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpWelcome,
            this.tpLotSelection,
            this.tpSummary});
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.welcomeScreen1);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Size = new System.Drawing.Size(1041, 413);
            this.tpWelcome.Text = "Welcome";
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Controls.Add(this.topBanner1);
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(1041, 413);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // tpSummary
            // 
            this.tpSummary.Controls.Add(this.topBanner2);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(1041, 413);
            this.tpSummary.Text = "Summary";
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.Appearance.Image")));
            this.welcomeScreen1.Appearance.Options.UseBackColor = true;
            this.welcomeScreen1.Appearance.Options.UseImage = true;
            this.welcomeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeScreen1.BackgroundImage")));
            this.welcomeScreen1.DescriptionCaption = null;
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(1041, 413);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = null;
            // 
            // topBanner1
            // 
            this.topBanner1.BannerTextCaption = null;
            this.topBanner1.BannerTitleCaption = null;
            this.topBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner1.Location = new System.Drawing.Point(0, 0);
            this.topBanner1.Name = "topBanner1";
            this.topBanner1.Size = new System.Drawing.Size(1041, 129);
            this.topBanner1.TabIndex = 0;
            // 
            // topBanner2
            // 
            this.topBanner2.BannerTextCaption = null;
            this.topBanner2.BannerTitleCaption = null;
            this.topBanner2.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner2.Location = new System.Drawing.Point(0, 0);
            this.topBanner2.Name = "topBanner2";
            this.topBanner2.Size = new System.Drawing.Size(1041, 88);
            this.topBanner2.TabIndex = 0;
            // 
            // ucSpecHomeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSpecHomeUpdate";
            this.Size = new System.Drawing.Size(1050, 494);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpLotSelection.ResumeLayout(false);
            this.tpSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        public DevExpress.XtraEditors.SimpleButton btnFinish;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpWelcome;
        private DevExpress.XtraTab.XtraTabPage tpLotSelection;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private HMProcessAssistantLib.TopBanner topBanner2;
    }
}
