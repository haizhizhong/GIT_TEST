namespace ProjectUtilities
{
    partial class frmAddtionalDatesSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddtionalDatesSelection));
            this.gcSelection = new DevExpress.XtraGrid.GridControl();
            this.workingAddtionalDatesSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSelection1 = new ProjectUtilities.dsSelection();
            this.gvSelection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffSetDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffSetDaysDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSelection = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingAddtionalDatesSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcSelection
            // 
            this.gcSelection.DataSource = this.workingAddtionalDatesSelectBindingSource;
            this.gcSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelection.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSelection.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSelection.Location = new System.Drawing.Point(0, 0);
            this.gcSelection.MainView = this.gvSelection;
            this.gcSelection.Name = "gcSelection";
            this.gcSelection.Size = new System.Drawing.Size(1075, 573);
            this.gcSelection.TabIndex = 0;
            this.gcSelection.UseEmbeddedNavigator = true;
            this.gcSelection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelection});
            // 
            // workingAddtionalDatesSelectBindingSource
            // 
            this.workingAddtionalDatesSelectBindingSource.DataMember = "working_AddtionalDates_Select";
            this.workingAddtionalDatesSelectBindingSource.DataSource = this.dsSelection1;
            // 
            // dsSelection1
            // 
            this.dsSelection1.DataSetName = "dsSelection";
            this.dsSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSelection
            // 
            this.gvSelection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colOffSetDays,
            this.colOffSetDaysDesc,
            this.colSelected});
            this.gvSelection.GridControl = this.gcSelection;
            this.gvSelection.Name = "gvSelection";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // colOffSetDays
            // 
            this.colOffSetDays.Caption = "Offset Days";
            this.colOffSetDays.FieldName = "OffSetDays";
            this.colOffSetDays.Name = "colOffSetDays";
            this.colOffSetDays.OptionsColumn.AllowEdit = false;
            this.colOffSetDays.Visible = true;
            this.colOffSetDays.VisibleIndex = 1;
            // 
            // colOffSetDaysDesc
            // 
            this.colOffSetDaysDesc.Caption = "Offset Days Desc";
            this.colOffSetDaysDesc.FieldName = "OffSetDaysDesc";
            this.colOffSetDaysDesc.Name = "colOffSetDaysDesc";
            this.colOffSetDaysDesc.OptionsColumn.AllowEdit = false;
            this.colOffSetDaysDesc.Visible = true;
            this.colOffSetDaysDesc.VisibleIndex = 2;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Selected";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 573);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1075, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(977, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(896, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, "LD_AdditionalDates_ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@OffSetDays", System.Data.SqlDbType.Int, 0, "OffSetDays"),
            new System.Data.SqlClient.SqlParameter("@AdditionalDates_ID", System.Data.SqlDbType.Int, 0, "AdditionalDates_ID"),
            new System.Data.SqlClient.SqlParameter("@OffSetDaysDesc", System.Data.SqlDbType.VarChar, 0, "OffSetDaysDesc"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, "LD_AdditionalDates_ID"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@OffSetDays", System.Data.SqlDbType.Int, 0, "OffSetDays"),
            new System.Data.SqlClient.SqlParameter("@AdditionalDates_ID", System.Data.SqlDbType.Int, 0, "AdditionalDates_ID"),
            new System.Data.SqlClient.SqlParameter("@OffSetDaysDesc", System.Data.SqlDbType.VarChar, 0, "OffSetDaysDesc"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.Bit, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_AdditionalDates_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_AdditionalDates_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalDates_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdditionalDates_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDaysDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDaysDesc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDaysDesc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDaysDesc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_AdditionalDates_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_AdditionalDates_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdditionalDates_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AdditionalDates_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdditionalDates_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OffSetDaysDesc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OffSetDaysDesc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OffSetDaysDesc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OffSetDaysDesc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null)});
            // 
            // daSelection
            // 
            this.daSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daSelection.InsertCommand = this.sqlInsertCommand1;
            this.daSelection.SelectCommand = this.sqlSelectCommand1;
            this.daSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_AddtionalDates_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("LD_AdditionalDates_ID", "LD_AdditionalDates_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("OffSetDays", "OffSetDays"),
                        new System.Data.Common.DataColumnMapping("AdditionalDates_ID", "AdditionalDates_ID"),
                        new System.Data.Common.DataColumnMapping("OffSetDaysDesc", "OffSetDaysDesc"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")})});
            this.daSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // frmAddtionalDatesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 605);
            this.Controls.Add(this.gcSelection);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddtionalDatesSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional Date Selection";
            this.Load += new System.EventHandler(this.frmAddtionalDatesSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingAddtionalDatesSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSelection;
        private dsSelection dsSelection1;
        private System.Windows.Forms.BindingSource workingAddtionalDatesSelectBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colOffSetDays;
        private DevExpress.XtraGrid.Columns.GridColumn colOffSetDaysDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
    }
}