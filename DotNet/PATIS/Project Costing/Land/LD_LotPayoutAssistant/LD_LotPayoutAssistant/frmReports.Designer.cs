namespace LD_LotPayoutAssistant
{
    partial class frmReports
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnReporting = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCashToClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayoutDocuments = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(17, 59);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Print Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporting.Location = new System.Drawing.Point(157, 88);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(134, 23);
            this.btnReporting.TabIndex = 8;
            this.btnReporting.Text = "Lot Payout Statement";
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(97, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Please print the register.";
            // 
            // btnCashToClose
            // 
            this.btnCashToClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashToClose.Location = new System.Drawing.Point(157, 59);
            this.btnCashToClose.Name = "btnCashToClose";
            this.btnCashToClose.Size = new System.Drawing.Size(134, 23);
            this.btnCashToClose.TabIndex = 11;
            this.btnCashToClose.Text = "Cash To Close";
            this.btnCashToClose.Click += new System.EventHandler(this.btnCashToClose_Click);
            // 
            // btnPayoutDocuments
            // 
            this.btnPayoutDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayoutDocuments.Location = new System.Drawing.Point(17, 88);
            this.btnPayoutDocuments.Name = "btnPayoutDocuments";
            this.btnPayoutDocuments.Size = new System.Drawing.Size(134, 23);
            this.btnPayoutDocuments.TabIndex = 12;
            this.btnPayoutDocuments.Text = "Lot Payout Documents";
            this.btnPayoutDocuments.Click += new System.EventHandler(this.btnPayoutDocuments_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 129);
            this.Controls.Add(this.btnPayoutDocuments);
            this.Controls.Add(this.btnCashToClose);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnReporting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnReporting;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCashToClose;
        private DevExpress.XtraEditors.SimpleButton btnPayoutDocuments;
    }
}