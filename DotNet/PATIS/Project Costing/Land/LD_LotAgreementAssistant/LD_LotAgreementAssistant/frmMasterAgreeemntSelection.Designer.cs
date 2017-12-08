namespace LD_LotAgreementAssistant
{
    partial class frmMasterAgreeemntSelection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterAgreeemntSelection));
            this.lueMasterAgreement = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_masterAgreement = new System.Windows.Forms.BindingSource(this.components);
            this.ds_MasterAgreement1 = new LD_LotAgreementAssistant.ds_MasterAgreement();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.da_MasterAgrement = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.lueMasterAgreement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MasterAgreement1)).BeginInit();
            this.SuspendLayout();
            // 
            // lueMasterAgreement
            // 
            this.lueMasterAgreement.Location = new System.Drawing.Point(24, 12);
            this.lueMasterAgreement.Name = "lueMasterAgreement";
            this.lueMasterAgreement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMasterAgreement.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASTER_AGREEMENT_NUM", "Number", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASTER_DATE", "Date", 100, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", 150, "Project")});
            this.lueMasterAgreement.Properties.DataSource = this.bs_masterAgreement;
            this.lueMasterAgreement.Properties.DisplayMember = "MASTER_AGREEMENT_NUM";
            this.lueMasterAgreement.Properties.NullText = "";
            this.lueMasterAgreement.Properties.PopupWidth = 325;
            this.lueMasterAgreement.Properties.ValueMember = "ID";
            this.lueMasterAgreement.Size = new System.Drawing.Size(217, 20);
            this.lueMasterAgreement.TabIndex = 0;
            // 
            // bs_masterAgreement
            // 
            this.bs_masterAgreement.DataMember = "PROJ_LOT_MASTER_AGREEMENT";
            this.bs_masterAgreement.DataSource = this.ds_MasterAgreement1;
            // 
            // ds_MasterAgreement1
            // 
            this.ds_MasterAgreement1.DataSetName = "ds_MasterAgreement";
            this.ds_MasterAgreement1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 38);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // da_MasterAgrement
            // 
            this.da_MasterAgrement.SelectCommand = this.sqlSelectCommand3;
            this.da_MasterAgrement.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LOT_MASTER_AGREEMENT", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("MASTER_AGREEMENT_NUM", "MASTER_AGREEMENT_NUM"),
                        new System.Data.Common.DataColumnMapping("Project", "Project"),
                        new System.Data.Common.DataColumnMapping("MASTER_DATE", "MASTER_DATE")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmMasterAgreeemntSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 72);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lueMasterAgreement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMasterAgreeemntSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Agreement Selection";
            this.Load += new System.EventHandler(this.frmMasterAgreeemntSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueMasterAgreement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MasterAgreement1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Data.SqlClient.SqlDataAdapter da_MasterAgrement;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private ds_MasterAgreement ds_MasterAgreement1;
        private System.Windows.Forms.BindingSource bs_masterAgreement;
        public DevExpress.XtraEditors.LookUpEdit lueMasterAgreement;
    }
}