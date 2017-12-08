namespace ProjectUtilities.Land.LotInventory
{
    partial class frmCOSTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCOSTest));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.teOriginalPrice = new DevExpress.XtraEditors.TextEdit();
            this.teCurrentPrice = new DevExpress.XtraEditors.TextEdit();
            this.teCOSCalculation = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.teOriginalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurrentPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCOSCalculation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Original Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Current Price";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "COS Calculation";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(17, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(155, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // teOriginalPrice
            // 
            this.teOriginalPrice.Enabled = false;
            this.teOriginalPrice.Location = new System.Drawing.Point(130, 46);
            this.teOriginalPrice.Name = "teOriginalPrice";
            this.teOriginalPrice.Properties.Mask.EditMask = "n2";
            this.teOriginalPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teOriginalPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teOriginalPrice.Size = new System.Drawing.Size(100, 20);
            this.teOriginalPrice.TabIndex = 5;
            // 
            // teCurrentPrice
            // 
            this.teCurrentPrice.Location = new System.Drawing.Point(130, 89);
            this.teCurrentPrice.Name = "teCurrentPrice";
            this.teCurrentPrice.Properties.Mask.EditMask = "n2";
            this.teCurrentPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teCurrentPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teCurrentPrice.Size = new System.Drawing.Size(100, 20);
            this.teCurrentPrice.TabIndex = 6;
            // 
            // teCOSCalculation
            // 
            this.teCOSCalculation.Enabled = false;
            this.teCOSCalculation.Location = new System.Drawing.Point(130, 134);
            this.teCOSCalculation.Name = "teCOSCalculation";
            this.teCOSCalculation.Properties.Mask.EditMask = "n2";
            this.teCOSCalculation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teCOSCalculation.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teCOSCalculation.Size = new System.Drawing.Size(100, 20);
            this.teCOSCalculation.TabIndex = 7;
            // 
            // frmCOSTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 231);
            this.Controls.Add(this.teCOSCalculation);
            this.Controls.Add(this.teCurrentPrice);
            this.Controls.Add(this.teOriginalPrice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCOSTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cost of Sales Test";
            ((System.ComponentModel.ISupportInitialize)(this.teOriginalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurrentPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCOSCalculation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit teOriginalPrice;
        private DevExpress.XtraEditors.TextEdit teCurrentPrice;
        private DevExpress.XtraEditors.TextEdit teCOSCalculation;
    }
}