namespace ProjectUtilities.Land.LotInventory.Detail
{
    partial class frmAgreementDateSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgreementDateSelection));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deAgreementDate = new DevExpress.XtraEditors.DateEdit();
            this.deSaleDate = new DevExpress.XtraEditors.DateEdit();
            this.seSellPrice = new DevExpress.XtraEditors.SpinEdit();
            this.ceUseLotPrice = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseLotPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Agreement Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sale Date";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Actual Sale Price";
            // 
            // deAgreementDate
            // 
            this.deAgreementDate.EditValue = null;
            this.deAgreementDate.Location = new System.Drawing.Point(120, 13);
            this.deAgreementDate.Name = "deAgreementDate";
            this.deAgreementDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAgreementDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deAgreementDate.Size = new System.Drawing.Size(100, 20);
            this.deAgreementDate.TabIndex = 5;
            // 
            // deSaleDate
            // 
            this.deSaleDate.EditValue = null;
            this.deSaleDate.Location = new System.Drawing.Point(120, 39);
            this.deSaleDate.Name = "deSaleDate";
            this.deSaleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSaleDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deSaleDate.Size = new System.Drawing.Size(100, 20);
            this.deSaleDate.TabIndex = 6;
            // 
            // seSellPrice
            // 
            this.seSellPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSellPrice.Location = new System.Drawing.Point(120, 68);
            this.seSellPrice.Name = "seSellPrice";
            this.seSellPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.seSellPrice.Properties.Mask.EditMask = "n2";
            this.seSellPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.seSellPrice.Size = new System.Drawing.Size(100, 20);
            this.seSellPrice.TabIndex = 7;
            // 
            // ceUseLotPrice
            // 
            this.ceUseLotPrice.Location = new System.Drawing.Point(120, 91);
            this.ceUseLotPrice.Name = "ceUseLotPrice";
            this.ceUseLotPrice.Properties.Caption = "";
            this.ceUseLotPrice.Size = new System.Drawing.Size(75, 19);
            this.ceUseLotPrice.TabIndex = 8;
            this.ceUseLotPrice.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ceUseLotPrice_EditValueChanging);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Use Current Lot Price";
            // 
            // frmAgreementDateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 148);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ceUseLotPrice);
            this.Controls.Add(this.seSellPrice);
            this.Controls.Add(this.deSaleDate);
            this.Controls.Add(this.deAgreementDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 175);
            this.Name = "frmAgreementDateSelection";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Selection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAgreementDateSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAgreementDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSellPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseLotPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.SpinEdit seSellPrice;
        public DevExpress.XtraEditors.DateEdit deAgreementDate;
        public DevExpress.XtraEditors.DateEdit deSaleDate;
        private DevExpress.XtraEditors.CheckEdit ceUseLotPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}