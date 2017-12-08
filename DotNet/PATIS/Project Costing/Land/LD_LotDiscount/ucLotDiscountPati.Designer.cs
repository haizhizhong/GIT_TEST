namespace LD_LotDiscount
{
    partial class ucLotDiscountPati
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
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpMain = new DevExpress.XtraTab.XtraTabPage();
            this.rgAction = new DevExpress.XtraEditors.RadioGroup();
            this.welcomeScreen1 = new HMProcessAssistantLib.WelcomeScreen();
            this.tpDetails = new DevExpress.XtraTab.XtraTabPage();
            this.tcDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpSearch = new DevExpress.XtraTab.XtraTabPage();
            this.tpChanges = new DevExpress.XtraTab.XtraTabPage();
            this.tpSummary = new DevExpress.XtraTab.XtraTabPage();
            this.topBanner1 = new HMProcessAssistantLib.TopBanner();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tpReview = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgAction.Properties)).BeginInit();
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
            this.tcMain.Size = new System.Drawing.Size(1217, 780);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMain,
            this.tpDetails});
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.rgAction);
            this.tpMain.Controls.Add(this.welcomeScreen1);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(1211, 752);
            this.tpMain.Text = "Main";
            // 
            // rgAction
            // 
            this.rgAction.EditValue = "N";
            this.rgAction.Location = new System.Drawing.Point(266, 306);
            this.rgAction.Name = "rgAction";
            this.rgAction.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Create New"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Modify Exsisting"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Reverse Existing")});
            this.rgAction.Size = new System.Drawing.Size(233, 117);
            this.rgAction.TabIndex = 1;
            // 
            // welcomeScreen1
            // 
            this.welcomeScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcomeScreen1.DescriptionCaption = "Use this Assistant to help in posting new lot discounts and modify or reverse exi" +
    "sting lot discounts. This assistant can only be used after a lot has been sold.";
            this.welcomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.welcomeScreen1.Name = "welcomeScreen1";
            this.welcomeScreen1.Size = new System.Drawing.Size(1211, 752);
            this.welcomeScreen1.TabIndex = 0;
            this.welcomeScreen1.TitleCaption = "Lot Discount Assistant";
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tcDetails);
            this.tpDetails.Controls.Add(this.topBanner1);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Size = new System.Drawing.Size(1211, 752);
            this.tpDetails.Text = "Details";
            // 
            // tcDetails
            // 
            this.tcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetails.Location = new System.Drawing.Point(0, 88);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedTabPage = this.tpSearch;
            this.tcDetails.Size = new System.Drawing.Size(1211, 664);
            this.tcDetails.TabIndex = 0;
            this.tcDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSearch,
            this.tpChanges,
            this.tpReview,
            this.tpSummary});
            // 
            // tpSearch
            // 
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(1205, 636);
            this.tpSearch.Text = "Search";
            // 
            // tpChanges
            // 
            this.tpChanges.Name = "tpChanges";
            this.tpChanges.Size = new System.Drawing.Size(1205, 636);
            this.tpChanges.Text = "Changes";
            // 
            // tpSummary
            // 
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(1205, 636);
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
            this.topBanner1.Size = new System.Drawing.Size(1211, 88);
            this.topBanner1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBack);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 780);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1217, 38);
            this.panelControl1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(963, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "< Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1044, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1125, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tpReview
            // 
            this.tpReview.Name = "tpReview";
            this.tpReview.Size = new System.Drawing.Size(1205, 636);
            this.tpReview.Text = "Review";
            // 
            // ucLotDiscountPati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucLotDiscountPati";
            this.Size = new System.Drawing.Size(1217, 818);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgAction.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabControl tcDetails;
        private DevExpress.XtraTab.XtraTabPage tpSearch;
        private DevExpress.XtraTab.XtraTabPage tpChanges;
        private HMProcessAssistantLib.WelcomeScreen welcomeScreen1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private HMProcessAssistantLib.TopBanner topBanner1;
        private DevExpress.XtraEditors.RadioGroup rgAction;
        private DevExpress.XtraTab.XtraTabPage tpSummary;
        private DevExpress.XtraTab.XtraTabPage tpReview;
    }
}
