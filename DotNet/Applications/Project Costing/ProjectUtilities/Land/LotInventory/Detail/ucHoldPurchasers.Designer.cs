namespace ProjectUtilities.Land.LotInventory.Detail
{
    partial class ucHoldPurchasers
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.TR_Conn = new System.Data.SqlClient.SqlConnection();
            this.daHoldPurch = new System.Data.SqlClient.SqlDataAdapter();
            this.gcPurch = new DevExpress.XtraGrid.GridControl();
            this.dsHoldPurch = new ProjectUtilities.Land.LotInventory.Detail.dsHoldPurch();
            this.gvPurch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldPurch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurch)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.LD_HoldPurchasers_Get";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.TR_Conn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@hold_id", System.Data.SqlDbType.Int, 4)});
            // 
            // TR_Conn
            // 
            this.TR_Conn.ConnectionString = "Data Source=dev11;Initial Catalog=tr_strike_test10;Persist Security Info=True;Use" +
                "r ID=hmsqlsa;Password=hmsqlsa";
            this.TR_Conn.FireInfoMessageEventOnUserErrors = false;
            // 
            // daHoldPurch
            // 
            this.daHoldPurch.SelectCommand = this.sqlSelectCommand1;
            this.daHoldPurch.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_HoldPurchasers_Get", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("Address1", "Address1"),
                        new System.Data.Common.DataColumnMapping("Address2", "Address2"),
                        new System.Data.Common.DataColumnMapping("Address3", "Address3"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Prov", "Prov"),
                        new System.Data.Common.DataColumnMapping("Postal", "Postal"),
                        new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("Cell", "Cell"),
                        new System.Data.Common.DataColumnMapping("Email", "Email")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("Address1", "Address1"),
                        new System.Data.Common.DataColumnMapping("Address2", "Address2"),
                        new System.Data.Common.DataColumnMapping("Address3", "Address3"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Prov", "Prov"),
                        new System.Data.Common.DataColumnMapping("Postal", "Postal"),
                        new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("Cell", "Cell"),
                        new System.Data.Common.DataColumnMapping("Email", "Email")})});
            // 
            // gcPurch
            // 
            this.gcPurch.DataMember = "LD_HoldPurchasers_Get";
            this.gcPurch.DataSource = this.dsHoldPurch;
            this.gcPurch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPurch.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPurch.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPurch.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPurch.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPurch.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPurch.Location = new System.Drawing.Point(0, 0);
            this.gcPurch.MainView = this.gvPurch;
            this.gcPurch.Name = "gcPurch";
            this.gcPurch.Size = new System.Drawing.Size(1110, 449);
            this.gcPurch.TabIndex = 0;
            this.gcPurch.UseEmbeddedNavigator = true;
            this.gcPurch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurch});
            // 
            // dsHoldPurch
            // 
            this.dsHoldPurch.DataSetName = "dsHoldPurch";
            this.dsHoldPurch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPurch
            // 
            this.gvPurch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colAddress1,
            this.colAddress2,
            this.colAddress3,
            this.colCity,
            this.colProv,
            this.colPostal,
            this.colTelephone,
            this.colFax,
            this.colCell,
            this.colEmail});
            this.gvPurch.GridControl = this.gcPurch;
            this.gvPurch.Name = "gvPurch";
            this.gvPurch.OptionsBehavior.Editable = false;
            this.gvPurch.OptionsView.ShowGroupPanel = false;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // colAddress1
            // 
            this.colAddress1.FieldName = "Address1";
            this.colAddress1.Name = "colAddress1";
            this.colAddress1.OptionsColumn.AllowEdit = false;
            this.colAddress1.Visible = true;
            this.colAddress1.VisibleIndex = 2;
            // 
            // colAddress2
            // 
            this.colAddress2.FieldName = "Address2";
            this.colAddress2.Name = "colAddress2";
            this.colAddress2.OptionsColumn.AllowEdit = false;
            this.colAddress2.Visible = true;
            this.colAddress2.VisibleIndex = 3;
            // 
            // colAddress3
            // 
            this.colAddress3.FieldName = "Address3";
            this.colAddress3.Name = "colAddress3";
            this.colAddress3.OptionsColumn.AllowEdit = false;
            this.colAddress3.Visible = true;
            this.colAddress3.VisibleIndex = 4;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            // 
            // colProv
            // 
            this.colProv.FieldName = "Prov";
            this.colProv.Name = "colProv";
            this.colProv.OptionsColumn.AllowEdit = false;
            this.colProv.Visible = true;
            this.colProv.VisibleIndex = 6;
            // 
            // colPostal
            // 
            this.colPostal.FieldName = "Postal";
            this.colPostal.Name = "colPostal";
            this.colPostal.OptionsColumn.AllowEdit = false;
            this.colPostal.Visible = true;
            this.colPostal.VisibleIndex = 7;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.OptionsColumn.AllowEdit = false;
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 8;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 9;
            // 
            // colCell
            // 
            this.colCell.FieldName = "Cell";
            this.colCell.Name = "colCell";
            this.colCell.OptionsColumn.AllowEdit = false;
            this.colCell.Visible = true;
            this.colCell.VisibleIndex = 10;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 11;
            // 
            // ucHoldPurchasers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcPurch);
            this.Name = "ucHoldPurchasers";
            this.Size = new System.Drawing.Size(1110, 449);
            this.Load += new System.EventHandler(this.ucHoldPurchasers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPurch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldPurch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection TR_Conn;
        private System.Data.SqlClient.SqlDataAdapter daHoldPurch;
        private DevExpress.XtraGrid.GridControl gcPurch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurch;
        private dsHoldPurch dsHoldPurch;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress2;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress3;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colProv;
        private DevExpress.XtraGrid.Columns.GridColumn colPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCell;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
    }
}
