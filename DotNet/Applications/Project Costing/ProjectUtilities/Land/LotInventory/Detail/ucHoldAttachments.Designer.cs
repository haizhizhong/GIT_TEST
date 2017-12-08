namespace ProjectUtilities.Land.LotInventory.Detail
{
    partial class ucHoldAttachments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoldAttachments));
            this.gcAttach = new DevExpress.XtraGrid.GridControl();
            this.dsAttach = new ProjectUtilities.Land.LotInventory.Detail.dsAttach();
            this.gvAttach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.TR_Conn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daAttach = new System.Data.SqlClient.SqlDataAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gcAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riView)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAttach
            // 
            this.gcAttach.DataMember = "WS_ChatAttachment";
            this.gcAttach.DataSource = this.dsAttach;
            this.gcAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAttach.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAttach.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAttach.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAttach.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcAttach_EmbeddedNavigator_ButtonClick);
            this.gcAttach.Location = new System.Drawing.Point(0, 0);
            this.gcAttach.MainView = this.gvAttach;
            this.gcAttach.Name = "gcAttach";
            this.gcAttach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riView});
            this.gcAttach.Size = new System.Drawing.Size(865, 346);
            this.gcAttach.TabIndex = 1;
            this.gcAttach.UseEmbeddedNavigator = true;
            this.gcAttach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAttach});
            // 
            // dsAttach
            // 
            this.dsAttach.DataSetName = "dsAttach";
            this.dsAttach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAttach
            // 
            this.gvAttach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn4});
            this.gvAttach.GridControl = this.gcAttach;
            this.gvAttach.Name = "gvAttach";
            this.gvAttach.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "File Name";
            this.gridColumn1.FieldName = "CAtch_FileName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 211;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "File Type";
            this.gridColumn2.FieldName = "CAtch_Type";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 162;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Size (Bytes)";
            this.gridColumn3.FieldName = "CAtch_Length";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 96;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date/Time Uploaded";
            this.gridColumn5.DisplayFormat.FormatString = "{0: MMM dd/yy hh:mm tt}";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn5.FieldName = "CAtch_UploadDtTm";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 119;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Contact";
            this.gridColumn6.FieldName = "Contact";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 186;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "View File";
            this.gridColumn4.ColumnEdit = this.riView;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 65;
            // 
            // riView
            // 
            this.riView.AutoHeight = false;
            this.riView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "View", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.riView.Name = "riView";
            this.riView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riView.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riView_ButtonClick);
            // 
            // TR_Conn
            // 
            this.TR_Conn.ConnectionString = "Data Source=dev1;Initial Catalog=tr_strike_test10;Persist Security Info=True;User" +
                " ID=hmsqlsa;Password=hmsqlsa";
            this.TR_Conn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.TR_Conn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CLog_FieldLink_ID", System.Data.SqlDbType.Int, 4, "CLog_FieldLink_ID"),
            new System.Data.SqlClient.SqlParameter("@CLog_IDValue", System.Data.SqlDbType.Int, 4, "CLog_IDValue")});
            // 
            // daAttach
            // 
            this.daAttach.SelectCommand = this.sqlSelectCommand1;
            this.daAttach.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "WS_ChatAttachment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CAtch_ID", "CAtch_ID"),
                        new System.Data.Common.DataColumnMapping("CAtch_FileName", "CAtch_FileName"),
                        new System.Data.Common.DataColumnMapping("CAtch_Type", "CAtch_Type"),
                        new System.Data.Common.DataColumnMapping("CAtch_Length", "CAtch_Length"),
                        new System.Data.Common.DataColumnMapping("CAtch_UploadDtTm", "CAtch_UploadDtTm"),
                        new System.Data.Common.DataColumnMapping("Contact", "Contact")})});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            // 
            // ucHoldAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcAttach);
            this.Name = "ucHoldAttachments";
            this.Size = new System.Drawing.Size(865, 346);
            this.Load += new System.EventHandler(this.ucHoldAttachments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAttach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riView;
        private System.Data.SqlClient.SqlConnection TR_Conn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter daAttach;
        private dsAttach dsAttach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
