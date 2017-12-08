namespace ProjectUtilities
{
    partial class frmChangeCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeCustomer));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.daCustomerLU = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsCustomerLU1 = new ProjectUtilities.dsCustomerLU();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CustomerLU = new DevExpress.XtraEditors.LookUpEdit();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerLU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(410, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "&Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(329, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=csmsql2016;Initial Catalog=TR_KELLER;Persist Security Info=True;User " +
    "ID=hmsqlsa;Password=hmsqlsa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // daCustomerLU
            // 
            this.daCustomerLU.DeleteCommand = this.sqlDeleteCommand2;
            this.daCustomerLU.InsertCommand = this.sqlInsertCommand2;
            this.daCustomerLU.SelectCommand = this.sqlSelectCommand4;
            this.daCustomerLU.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CUSTOMERS", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Customer", "Customer"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Prov/State", "Prov/State"),
                        new System.Data.Common.DataColumnMapping("customer_id", "customer_id")})});
            this.daCustomerLU.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_Customer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Customer", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Customer", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Customer", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prov/State", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prov/State", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_customer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "customer_id", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Customer", System.Data.SqlDbType.VarChar, 0, "Customer"),
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.VarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.VarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.VarChar, 0, "Prov/State"),
            new System.Data.SqlClient.SqlParameter("@customer_id", System.Data.SqlDbType.Int, 0, "customer_id"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 4, "CUSTOMER_ID")});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "select c.name [Customer], c.CUSTOMER_CODE [Code], c.BILL_ADDRESS_1 [Address], c.B" +
    "ILL_CITY [City], c.BILL_STATE [Prov/State], c.customer_id from customers c\r\nwher" +
    "e c.ACTIVE = \'T\'\r\norder by c.NAME";
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Customer", System.Data.SqlDbType.VarChar, 0, "Customer"),
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.VarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.VarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.VarChar, 0, "Prov/State"),
            new System.Data.SqlClient.SqlParameter("@customer_id", System.Data.SqlDbType.Int, 0, "customer_id"),
            new System.Data.SqlClient.SqlParameter("@IsNull_Customer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Customer", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Customer", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Customer", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prov/State", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prov/State", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_customer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "customer_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 4, "CUSTOMER_ID")});
            // 
            // dsCustomerLU1
            // 
            this.dsCustomerLU1.DataSetName = "dsCustomerLU";
            this.dsCustomerLU1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Change Customer:";
            // 
            // CustomerLU
            // 
            this.CustomerLU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerLU.Location = new System.Drawing.Point(110, 13);
            this.CustomerLU.Name = "CustomerLU";
            this.CustomerLU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerLU.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer", "Customer", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Prov/State", "Prov/State", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("customer_id", "customer_id", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.CustomerLU.Properties.DataSource = this.cUSTOMERSBindingSource;
            this.CustomerLU.Properties.DisplayMember = "Customer";
            this.CustomerLU.Properties.NullText = "*** Select";
            this.CustomerLU.Properties.PopupWidth = 600;
            this.CustomerLU.Properties.ValueMember = "customer_id";
            this.CustomerLU.Size = new System.Drawing.Size(375, 20);
            this.CustomerLU.TabIndex = 3;
            this.CustomerLU.EditValueChanged += new System.EventHandler(this.CustomerLU_EditValueChanged);
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.dsCustomerLU1;
            // 
            // frmChangeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 95);
            this.ControlBox = false;
            this.Controls.Add(this.CustomerLU);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.simpleButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerLU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter daCustomerLU;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private dsCustomerLU dsCustomerLU1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        public DevExpress.XtraEditors.LookUpEdit CustomerLU;
    }
}