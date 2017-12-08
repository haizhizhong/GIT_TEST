namespace LD_DownPaymentDue
{
    partial class ucSummary
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deNotification = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintRegister = new DevExpress.XtraEditors.SimpleButton();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.dsSummary1 = new LD_DownPaymentDue.dsSummary();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collot_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterAgreementNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommunity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactual_release_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalesManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhomebuilder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSummary = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNotification.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNotification.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1086, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.deNotification);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(260, 40);
            this.panelControl3.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Notification Date";
            // 
            // deNotification
            // 
            this.deNotification.EditValue = null;
            this.deNotification.Location = new System.Drawing.Point(119, 11);
            this.deNotification.Name = "deNotification";
            this.deNotification.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNotification.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deNotification.Size = new System.Drawing.Size(100, 20);
            this.deNotification.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Controls.Add(this.btnPrintRegister);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(676, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(408, 40);
            this.panelControl2.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(300, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Pre-Register";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Location = new System.Drawing.Point(200, 8);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(94, 23);
            this.btnPrintRegister.TabIndex = 7;
            this.btnPrintRegister.Text = "Print Register";
            this.btnPrintRegister.Click += new System.EventHandler(this.btnPrintRegister_Click);
            // 
            // gcSummary
            // 
            this.gcSummary.DataMember = "WS_GetAgreementLotInfo";
            this.gcSummary.DataSource = this.dsSummary1;
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSummary.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSummary.Location = new System.Drawing.Point(0, 44);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.Size = new System.Drawing.Size(1086, 630);
            this.gcSummary.TabIndex = 1;
            this.gcSummary.UseEmbeddedNavigator = true;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // dsSummary1
            // 
            this.dsSummary1.DataSetName = "dsSummary";
            this.dsSummary1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collot_class_desc,
            this.collot_sub_class_desc,
            this.colplan_num,
            this.colblock_num,
            this.collot_num,
            this.colagreement_num,
            this.colMasterAgreementNum,
            this.colpri_name,
            this.colCommunity,
            this.colactual_release_date,
            this.colsalesManager,
            this.colhomebuilder});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            // 
            // collot_class_desc
            // 
            this.collot_class_desc.Caption = "Class";
            this.collot_class_desc.FieldName = "lot_class_desc";
            this.collot_class_desc.Name = "collot_class_desc";
            this.collot_class_desc.Visible = true;
            this.collot_class_desc.VisibleIndex = 4;
            this.collot_class_desc.Width = 102;
            // 
            // collot_sub_class_desc
            // 
            this.collot_sub_class_desc.Caption = "Sub Class";
            this.collot_sub_class_desc.FieldName = "lot_sub_class_desc";
            this.collot_sub_class_desc.Name = "collot_sub_class_desc";
            this.collot_sub_class_desc.Visible = true;
            this.collot_sub_class_desc.VisibleIndex = 5;
            this.collot_sub_class_desc.Width = 123;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 6;
            this.colplan_num.Width = 113;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 7;
            this.colblock_num.Width = 83;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 8;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 2;
            this.colagreement_num.Width = 86;
            // 
            // colMasterAgreementNum
            // 
            this.colMasterAgreementNum.Caption = "Master Agreement #";
            this.colMasterAgreementNum.FieldName = "MasterAgreementNum";
            this.colMasterAgreementNum.Name = "colMasterAgreementNum";
            this.colMasterAgreementNum.Visible = true;
            this.colMasterAgreementNum.VisibleIndex = 3;
            this.colMasterAgreementNum.Width = 123;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.Visible = true;
            this.colpri_name.VisibleIndex = 1;
            this.colpri_name.Width = 171;
            // 
            // colCommunity
            // 
            this.colCommunity.FieldName = "Community";
            this.colCommunity.Name = "colCommunity";
            this.colCommunity.Visible = true;
            this.colCommunity.VisibleIndex = 0;
            this.colCommunity.Width = 153;
            // 
            // colactual_release_date
            // 
            this.colactual_release_date.Caption = "Actual Release Date";
            this.colactual_release_date.FieldName = "actual_release_date";
            this.colactual_release_date.Name = "colactual_release_date";
            this.colactual_release_date.Visible = true;
            this.colactual_release_date.VisibleIndex = 9;
            this.colactual_release_date.Width = 119;
            // 
            // colsalesManager
            // 
            this.colsalesManager.Caption = "Sales Manager/ Account Manager";
            this.colsalesManager.FieldName = "salesManager";
            this.colsalesManager.Name = "colsalesManager";
            this.colsalesManager.Visible = true;
            this.colsalesManager.VisibleIndex = 11;
            this.colsalesManager.Width = 183;
            // 
            // colhomebuilder
            // 
            this.colhomebuilder.Caption = "Home Builder";
            this.colhomebuilder.FieldName = "homebuilder";
            this.colhomebuilder.Name = "colhomebuilder";
            this.colhomebuilder.Visible = true;
            this.colhomebuilder.VisibleIndex = 10;
            this.colhomebuilder.Width = 207;
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=DEV4;Initial Catalog=TR_COMCO;Persist Security Info=True;User ID=hmsq" +
                "lsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.WS_GetAgreementLotInfo";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500),
            new System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.VarChar, 200)});
            // 
            // daSummary
            // 
            this.daSummary.SelectCommand = this.sqlSelectCommand1;
            this.daSummary.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "WS_GetAgreementLotInfo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("COMPANYNAME", "COMPANYNAME"),
                        new System.Data.Common.DataColumnMapping("ADD1", "ADD1"),
                        new System.Data.Common.DataColumnMapping("PHONE", "PHONE"),
                        new System.Data.Common.DataColumnMapping("FAX", "FAX"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_code", "lot_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_desc", "lot_class_desc"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_code", "lot_sub_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_desc", "lot_sub_class_desc"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("current_price", "current_price"),
                        new System.Data.Common.DataColumnMapping("lot_status", "lot_status"),
                        new System.Data.Common.DataColumnMapping("lot_sub_status", "lot_sub_status"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("MasterAgreementNum", "MasterAgreementNum"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("Total_Deposit", "Total_Deposit"),
                        new System.Data.Common.DataColumnMapping("DepositReceived", "DepositReceived"),
                        new System.Data.Common.DataColumnMapping("agreement_sell_price", "agreement_sell_price"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("Community", "Community"),
                        new System.Data.Common.DataColumnMapping("estimated_release_date", "estimated_release_date"),
                        new System.Data.Common.DataColumnMapping("actual_release_date", "actual_release_date"),
                        new System.Data.Common.DataColumnMapping("agreement_date", "agreement_date"),
                        new System.Data.Common.DataColumnMapping("Final_Pay_Date", "Final_Pay_Date"),
                        new System.Data.Common.DataColumnMapping("ShowHome", "ShowHome"),
                        new System.Data.Common.DataColumnMapping("spechome", "spechome"),
                        new System.Data.Common.DataColumnMapping("homebuilder_id", "homebuilder_id"),
                        new System.Data.Common.DataColumnMapping("homebuilder", "homebuilder"),
                        new System.Data.Common.DataColumnMapping("salesManager_id", "salesManager_id"),
                        new System.Data.Common.DataColumnMapping("salesManager", "salesManager"),
                        new System.Data.Common.DataColumnMapping("username", "username")})});
            // 
            // ucSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSummary";
            this.Size = new System.Drawing.Size(1086, 674);
            this.Load += new System.EventHandler(this.ucSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNotification.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNotification.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        public DevExpress.XtraEditors.SimpleButton btnPrintRegister;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSummary;
        private dsSummary dsSummary1;
        private DevExpress.XtraGrid.Columns.GridColumn collot_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterAgreementNum;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colCommunity;
        private DevExpress.XtraGrid.Columns.GridColumn colactual_release_date;
        private DevExpress.XtraGrid.Columns.GridColumn colsalesManager;
        private DevExpress.XtraGrid.Columns.GridColumn colhomebuilder;
        public DevExpress.XtraEditors.DateEdit deNotification;
    }
}
