namespace LD_DownPaymentDue
{
    partial class ucDownPaymentDue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDownPaymentDue));
            this.welcomeScreen = new HMProcessAssistantLib.WelcomeScreen();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpWelcome = new DevExpress.XtraTab.XtraTabPage();
            this.tpLotSelection = new DevExpress.XtraTab.XtraTabPage();
            this.pcLotSelection = new DevExpress.XtraEditors.PanelControl();
            this.topBanner_LotSelection = new HMProcessAssistantLib.TopBanner();
            this.tpNotification = new DevExpress.XtraTab.XtraTabPage();
            this.tbRichTxt_Notification = new ToolBarRichTextEdit.TBRichTextEdit();
            this.topBanner_Notificitions = new HMProcessAssistantLib.TopBanner();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner_Summary = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpLotSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLotSelection)).BeginInit();
            this.tpNotification.SuspendLayout();
            this.tpSummary.SuspendLayout();
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
            this.welcomeScreen.Size = new System.Drawing.Size(1258, 668);
            this.welcomeScreen.TabIndex = 0;
            this.welcomeScreen.TitleCaption = "Down Payment Due";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpWelcome;
            this.tcMain.Size = new System.Drawing.Size(1267, 699);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpWelcome,
            this.tpLotSelection,
            this.tpNotification,
            this.tpSummary});
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.welcomeScreen);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Size = new System.Drawing.Size(1258, 668);
            this.tpWelcome.Text = "Welcome";
            // 
            // tpLotSelection
            // 
            this.tpLotSelection.Controls.Add(this.pcLotSelection);
            this.tpLotSelection.Controls.Add(this.topBanner_LotSelection);
            this.tpLotSelection.Name = "tpLotSelection";
            this.tpLotSelection.Size = new System.Drawing.Size(1258, 668);
            this.tpLotSelection.Text = "Lot Selection";
            // 
            // pcLotSelection
            // 
            this.pcLotSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLotSelection.Location = new System.Drawing.Point(0, 88);
            this.pcLotSelection.Name = "pcLotSelection";
            this.pcLotSelection.Size = new System.Drawing.Size(1258, 580);
            this.pcLotSelection.TabIndex = 2;
            // 
            // topBanner_LotSelection
            // 
            this.topBanner_LotSelection.BannerTextCaption = null;
            this.topBanner_LotSelection.BannerTitleCaption = null;
            this.topBanner_LotSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner_LotSelection.Location = new System.Drawing.Point(0, 0);
            this.topBanner_LotSelection.Name = "topBanner_LotSelection";
            this.topBanner_LotSelection.Size = new System.Drawing.Size(1258, 88);
            this.topBanner_LotSelection.TabIndex = 0;
            // 
            // tpNotification
            // 
            this.tpNotification.Controls.Add(this.tbRichTxt_Notification);
            this.tpNotification.Controls.Add(this.topBanner_Notificitions);
            this.tpNotification.Name = "tpNotification";
            this.tpNotification.Size = new System.Drawing.Size(1258, 668);
            this.tpNotification.Text = "Notification";
            // 
            // tbRichTxt_Notification
            // 
            this.tbRichTxt_Notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRichTxt_Notification.Location = new System.Drawing.Point(0, 87);
            this.tbRichTxt_Notification.Name = "tbRichTxt_Notification";
            this.tbRichTxt_Notification.RtfText = "{\\rtf1\\deff0{\\fonttbl{\\f0 Times New Roman;}}{\\colortbl\\red0\\green0\\blue0 ;}{\\*\\li" +
                "stoverridetable}{\\stylesheet {\\ql\\cf0 Normal;}{\\*\\cs1\\cf0 Default Paragraph Font" +
                ";}}{\\sectd\\pard\\plain\\ql\\par}}";
            this.tbRichTxt_Notification.Size = new System.Drawing.Size(1258, 581);
            this.tbRichTxt_Notification.Style = null;
            this.tbRichTxt_Notification.TabIndex = 1;
            // 
            // topBanner_Notificitions
            // 
            this.topBanner_Notificitions.BannerTextCaption = null;
            this.topBanner_Notificitions.BannerTitleCaption = null;
            this.topBanner_Notificitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner_Notificitions.Location = new System.Drawing.Point(0, 0);
            this.topBanner_Notificitions.Name = "topBanner_Notificitions";
            this.topBanner_Notificitions.Size = new System.Drawing.Size(1258, 87);
            this.topBanner_Notificitions.TabIndex = 0;
            // 
            // tpSummary
            // 
            this.tpSummary.Controls.Add(this.topBanner_Summary);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(1258, 668);
            this.tpSummary.Text = "Summary";
            // 
            // topBanner_Summary
            // 
            this.topBanner_Summary.BannerTextCaption = null;
            this.topBanner_Summary.BannerTitleCaption = null;
            this.topBanner_Summary.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBanner_Summary.Location = new System.Drawing.Point(0, 0);
            this.topBanner_Summary.Name = "topBanner_Summary";
            this.topBanner_Summary.Size = new System.Drawing.Size(1258, 88);
            this.topBanner_Summary.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 699);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1267, 50);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btnCancel);
            this.panelControl6.Controls.Add(this.btnBack);
            this.panelControl6.Controls.Add(this.btnNext);
            this.panelControl6.Controls.Add(this.btnFinish);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(899, 0);
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
            // ucDownPaymentDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucDownPaymentDue";
            this.Size = new System.Drawing.Size(1267, 749);
            this.Load += new System.EventHandler(this.ucDownPaymentDue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpLotSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLotSelection)).EndInit();
            this.tpNotification.ResumeLayout(false);
            this.tpSummary.ResumeLayout(false);
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
        private DevExpress.XtraTab.XtraTabPage tpNotification;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private DevExpress.XtraEditors.PanelControl pcLotSelection;
        private HMProcessAssistantLib.TopBanner topBanner_LotSelection;
        private HMProcessAssistantLib.TopBanner topBanner_Notificitions;
        private HMProcessAssistantLib.TopBanner topBanner_Summary;
        private ToolBarRichTextEdit.TBRichTextEdit tbRichTxt_Notification;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
