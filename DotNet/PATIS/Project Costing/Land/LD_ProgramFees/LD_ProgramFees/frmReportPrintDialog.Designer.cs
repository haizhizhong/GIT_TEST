namespace LD_ProgramFees
{
    partial class frmReportPrintDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPrintDialog));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrintCertificate = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(16, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Please print register.";
            // 
            // btnPrintCertificate
            // 
            this.btnPrintCertificate.Location = new System.Drawing.Point(16, 46);
            this.btnPrintCertificate.Name = "btnPrintCertificate";
            this.btnPrintCertificate.Size = new System.Drawing.Size(95, 23);
            this.btnPrintCertificate.TabIndex = 12;
            this.btnPrintCertificate.Text = "Print Certificate";
            this.btnPrintCertificate.Click += new System.EventHandler(this.btnPrintCertificate_Click);
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Location = new System.Drawing.Point(117, 46);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(95, 23);
            this.btnPrintRegister.TabIndex = 13;
            this.btnPrintRegister.Text = "Print Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Cancel";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReportPrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 80);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintRegister);
            this.Controls.Add(this.btnPrintCertificate);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Reports";
            this.Load += new System.EventHandler(this.frmReportPrintDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintCertificate;
        private DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}