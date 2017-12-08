namespace LD_DateManagement
{
    partial class ucDateManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDateManagement));
            this.welcomeScreen = new HMProcessAssistantLib.WelcomeScreen();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpWelcome = new DevExpress.XtraTab.XtraTabPage();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.pcLotSelection = new DevExpress.XtraEditors.PanelControl();
            this.topBanner_LotSelection = new HMProcessAssistantLib.TopBanner();
            this.tpDateUpdate = new DevExpress.XtraTab.XtraTabPage();
            this.pcDateUpdate = new DevExpress.XtraEditors.PanelControl();
            this.topBanner_DateUpdates = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpLotSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLotSelection)).BeginInit();
            this.tpDateUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcDateUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeScreen
            // 
            this.welcomeScreen.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.welcomeScreen.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("welcomeScreen.Appearance.Image")));
            this.welcomeScreen.Appearance.Options.UseBackColor = true;
            this.welcomeScreen.Appearance.Options.UseImage = true;
            this.welcomeScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeScreen.BackgroundImage")));
            this.welcomeScreen.DescriptionCaption = null;
            this.welcomeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen.Name = "welcomeScreen";
            this.welcomeScreen.Size = new System.Drawing.Size(1238, 519);
            this.welcomeScreen.TabIndex = 0;
            this.welcomeScreen.TitleCaption = "Date Management";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpWelcome;
            this.tcMain.Size = new System.Drawing.Size(1247, 550);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpWelcome,
            this.tpLotSelection,
            this.tpDateUpdate});
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.welcomeScreen);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Size = new System.Drawing.Size(1238, 519);
            this.tpWelcome.Text = "Welcome";
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Controls.Add(this.pcLotSelection);
            this.tpLotSelection.Controls.Add(this.topBanner_LotSelection);
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(1238, 519);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // pcLotSelection
            // 
            this.pcLotSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLotSelection.Location = new System.Drawing.Point(0, 91);
            this.pcLotSelection.Name = "pcLotSelection";
            this.pcLotSelection.Size = new System.Drawing.Size(1238, 428);
            this.pcLotSelection.TabIndex = 1;
            // 
            // topBanner_LotSelection
            // 
            this.topBanner_LotSelection.BannerTextCaption = null;
            this.topBanner_LotSelection.BannerTitleCaption = null;
            this.topBanner_LotSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner_LotSelection.Location = new System.Drawing.Point(0, 0);
            this.topBanner_LotSelection.Name = "topBanner_LotSelection";
            this.topBanner_LotSelection.Size = new System.Drawing.Size(1238, 91);
            this.topBanner_LotSelection.TabIndex = 0;
            // 
            // tpDateUpdate
            // 
            this.tpDateUpdate.Controls.Add(this.pcDateUpdate);
            this.tpDateUpdate.Controls.Add(this.topBanner_DateUpdates);
            this.tpDateUpdate.Name = "tpDateUpdate";
            this.tpDateUpdate.Size = new System.Drawing.Size(1238, 519);
            this.tpDateUpdate.Text = "Date Update";
            // 
            // pcDateUpdate
            // 
            this.pcDateUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcDateUpdate.Location = new System.Drawing.Point(0, 88);
            this.pcDateUpdate.Name = "pcDateUpdate";
            this.pcDateUpdate.Size = new System.Drawing.Size(1238, 431);
            this.pcDateUpdate.TabIndex = 1;
            // 
            // topBanner_DateUpdates
            // 
            this.topBanner_DateUpdates.BannerTextCaption = null;
            this.topBanner_DateUpdates.BannerTitleCaption = null;
            this.topBanner_DateUpdates.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner_DateUpdates.Location = new System.Drawing.Point(0, 0);
            this.topBanner_DateUpdates.Name = "topBanner_DateUpdates";
            this.topBanner_DateUpdates.Size = new System.Drawing.Size(1238, 88);
            this.topBanner_DateUpdates.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 550);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1247, 50);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btnCancel);
            this.panelControl6.Controls.Add(this.btnBack);
            this.panelControl6.Controls.Add(this.btnNext);
            this.panelControl6.Controls.Add(this.btnFinish);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(879, 0);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(104, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(192, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(192, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ucDateManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDateManagement";
            this.Size = new System.Drawing.Size(1247, 600);
            this.Load += new System.EventHandler(this.ucDateManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpLotSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLotSelection)).EndInit();
            this.tpDateUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcDateUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HMProcessAssistantLib.WelcomeScreen welcomeScreen;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpWelcome;
        private DevExpress.XtraTab.XtraTabPage tpLotSelection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        public DevExpress.XtraEditors.SimpleButton btnFinish;
        private DevExpress.XtraTab.XtraTabPage tpDateUpdate;
        private HMProcessAssistantLib.TopBanner topBanner_LotSelection;
        private HMProcessAssistantLib.TopBanner topBanner_DateUpdates;
        private DevExpress.XtraEditors.PanelControl pcLotSelection;
        private DevExpress.XtraEditors.PanelControl pcDateUpdate;
    }
}
