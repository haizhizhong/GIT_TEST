namespace LD_LotAdjustmentAssistant
{
    partial class ucReview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReview));
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.da_selectedLots = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ds_selectedLots1 = new LD_LotAdjustmentAssistant.ds_selectedLots();
            this.gcReview = new DevExpress.XtraGrid.GridControl();
            this.gvReview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproj_lot_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_class_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_class_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_class_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrontage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_sub_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhold_expiry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_legal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparcel_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshape = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_prefix_dir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_suffix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colma_suffix_dir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterAgreementNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagreement_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.da_lueCostingLevels = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.ds_lueCostingLevels1 = new LD_LotAdjustmentAssistant.ds_lueCostingLevels();
            this.da_LotSaleAdjustments = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.ds_LotSaleAdjustments1 = new LD_LotAdjustmentAssistant.ds_LotSaleAdjustments();
            this.bs_lueLotSaleAdjustmentsDescription = new System.Windows.Forms.BindingSource(this.components);
            this.bs_lueLotSaleAdjustmentsCode = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC4_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.bs_LotSaleAdj = new System.Windows.Forms.BindingSource(this.components);
            this.ds_lotSaleAdj1 = new LD_LotAdjustmentAssistant.ds_lotSaleAdj();
            this.bs_CC3_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC2_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC1_Restricted = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC4 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC3 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC2 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CC1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpLotAdjustments = new DevExpress.XtraEditors.GroupControl();
            this.gcLotSale = new DevExpress.XtraGrid.GridControl();
            this.gvLotSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLotSaleAdjustments_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLSAcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLotSaleAdjustments_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueLSAdescription = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCostRecoverable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenseAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_seNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTax1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teNumaricReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colExtendedDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLV_1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueCostingCode1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLV_2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueCostingCode2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLV_3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueCostingCode3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLV_4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueCostingCode4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLEM_COMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_lsa_lotsaleadjustments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_LotSearch_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_teCode = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ri_teDesc = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ri_lueNotEditable = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.da_lotSaleAdj = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueCostingLevels1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LotSaleAdjustments1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSaleAdjustmentsDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSaleAdjustmentsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC4_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_LotSaleAdj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lotSaleAdj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC3_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC2_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC1_Restricted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLotAdjustments)).BeginInit();
            this.grpLotAdjustments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLSAcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLSAdescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaricReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueNotEditable)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deInvoiceDate);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1055, 46);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(296, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Adjustment Date";
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.Location = new System.Drawing.Point(383, 12);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.deInvoiceDate.TabIndex = 1;
            this.deInvoiceDate.EditValueChanged += new System.EventHandler(this.deInvoiceDate_EditValueChanged);
            // 
            // acctYearPeriod1
            // 
            this.acctYearPeriod1.Location = new System.Drawing.Point(3, 4);
            this.acctYearPeriod1.Name = "acctYearPeriod1";
            this.acctYearPeriod1.Size = new System.Drawing.Size(290, 36);
            this.acctYearPeriod1.TabIndex = 0;
            // 
            // da_selectedLots
            // 
            this.da_selectedLots.DeleteCommand = this.sqlDeleteCommand1;
            this.da_selectedLots.InsertCommand = this.sqlInsertCommand1;
            this.da_selectedLots.SelectCommand = this.sqlSelectCommand1;
            this.da_selectedLots.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_LotSearch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("selected", "selected"),
                        new System.Data.Common.DataColumnMapping("proj_lot_id", "proj_lot_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_code", "lot_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_class_desc", "lot_class_desc"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_code", "lot_sub_class_code"),
                        new System.Data.Common.DataColumnMapping("lot_sub_class_desc", "lot_sub_class_desc"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("frontage", "frontage"),
                        new System.Data.Common.DataColumnMapping("current_price", "current_price"),
                        new System.Data.Common.DataColumnMapping("lot_status", "lot_status"),
                        new System.Data.Common.DataColumnMapping("lot_sub_status", "lot_sub_status"),
                        new System.Data.Common.DataColumnMapping("title_number", "title_number"),
                        new System.Data.Common.DataColumnMapping("address_1", "address_1"),
                        new System.Data.Common.DataColumnMapping("address_2", "address_2"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("hold_expiry", "hold_expiry"),
                        new System.Data.Common.DataColumnMapping("long_legal", "long_legal"),
                        new System.Data.Common.DataColumnMapping("parcel_number", "parcel_number"),
                        new System.Data.Common.DataColumnMapping("postal", "postal"),
                        new System.Data.Common.DataColumnMapping("prov", "prov"),
                        new System.Data.Common.DataColumnMapping("shape", "shape"),
                        new System.Data.Common.DataColumnMapping("ma_name", "ma_name"),
                        new System.Data.Common.DataColumnMapping("ma_number", "ma_number"),
                        new System.Data.Common.DataColumnMapping("ma_prefix_dir", "ma_prefix_dir"),
                        new System.Data.Common.DataColumnMapping("ma_suffix", "ma_suffix"),
                        new System.Data.Common.DataColumnMapping("ma_suffix_dir", "ma_suffix_dir"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("agreement_num", "agreement_num"),
                        new System.Data.Common.DataColumnMapping("MasterAgreementNum", "MasterAgreementNum"),
                        new System.Data.Common.DataColumnMapping("agreement_id", "agreement_id"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Code", "Purchaser_Code"),
                        new System.Data.Common.DataColumnMapping("Purchaser_Name", "Purchaser_Name"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name")})});
            this.da_selectedLots.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_frontage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_frontage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_current_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_current_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_expiry", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_expiry", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_long_legal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_long_legal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_parcel_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_parcel_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_postal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prov", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prov", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_shape", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_shape", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_prefix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTRConnection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@selected", System.Data.SqlDbType.Bit, 0, "selected"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_code", System.Data.SqlDbType.VarChar, 0, "lot_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_class_desc"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_desc"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@frontage", System.Data.SqlDbType.Money, 0, "frontage"),
            new System.Data.SqlClient.SqlParameter("@current_price", System.Data.SqlDbType.Money, 0, "current_price"),
            new System.Data.SqlClient.SqlParameter("@lot_status", System.Data.SqlDbType.VarChar, 0, "lot_status"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_status", System.Data.SqlDbType.VarChar, 0, "lot_sub_status"),
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number"),
            new System.Data.SqlClient.SqlParameter("@address_1", System.Data.SqlDbType.VarChar, 0, "address_1"),
            new System.Data.SqlClient.SqlParameter("@address_2", System.Data.SqlDbType.VarChar, 0, "address_2"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@hold_expiry", System.Data.SqlDbType.DateTime, 0, "hold_expiry"),
            new System.Data.SqlClient.SqlParameter("@long_legal", System.Data.SqlDbType.VarChar, 0, "long_legal"),
            new System.Data.SqlClient.SqlParameter("@parcel_number", System.Data.SqlDbType.VarChar, 0, "parcel_number"),
            new System.Data.SqlClient.SqlParameter("@postal", System.Data.SqlDbType.VarChar, 0, "postal"),
            new System.Data.SqlClient.SqlParameter("@prov", System.Data.SqlDbType.VarChar, 0, "prov"),
            new System.Data.SqlClient.SqlParameter("@shape", System.Data.SqlDbType.VarChar, 0, "shape"),
            new System.Data.SqlClient.SqlParameter("@ma_name", System.Data.SqlDbType.VarChar, 0, "ma_name"),
            new System.Data.SqlClient.SqlParameter("@ma_number", System.Data.SqlDbType.VarChar, 0, "ma_number"),
            new System.Data.SqlClient.SqlParameter("@ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, "ma_prefix_dir"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix", System.Data.SqlDbType.VarChar, 0, "ma_suffix"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, "ma_suffix_dir"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlTRConnection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@selected", System.Data.SqlDbType.Bit, 0, "selected"),
            new System.Data.SqlClient.SqlParameter("@proj_lot_id", System.Data.SqlDbType.Int, 0, "proj_lot_id"),
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_code", System.Data.SqlDbType.VarChar, 0, "lot_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_class_desc"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_code"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, "lot_sub_class_desc"),
            new System.Data.SqlClient.SqlParameter("@plan_num", System.Data.SqlDbType.VarChar, 0, "plan_num"),
            new System.Data.SqlClient.SqlParameter("@block_num", System.Data.SqlDbType.VarChar, 0, "block_num"),
            new System.Data.SqlClient.SqlParameter("@lot_num", System.Data.SqlDbType.VarChar, 0, "lot_num"),
            new System.Data.SqlClient.SqlParameter("@frontage", System.Data.SqlDbType.Money, 0, "frontage"),
            new System.Data.SqlClient.SqlParameter("@current_price", System.Data.SqlDbType.Money, 0, "current_price"),
            new System.Data.SqlClient.SqlParameter("@lot_status", System.Data.SqlDbType.VarChar, 0, "lot_status"),
            new System.Data.SqlClient.SqlParameter("@lot_sub_status", System.Data.SqlDbType.VarChar, 0, "lot_sub_status"),
            new System.Data.SqlClient.SqlParameter("@title_number", System.Data.SqlDbType.VarChar, 0, "title_number"),
            new System.Data.SqlClient.SqlParameter("@address_1", System.Data.SqlDbType.VarChar, 0, "address_1"),
            new System.Data.SqlClient.SqlParameter("@address_2", System.Data.SqlDbType.VarChar, 0, "address_2"),
            new System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 0, "city"),
            new System.Data.SqlClient.SqlParameter("@hold_expiry", System.Data.SqlDbType.DateTime, 0, "hold_expiry"),
            new System.Data.SqlClient.SqlParameter("@long_legal", System.Data.SqlDbType.VarChar, 0, "long_legal"),
            new System.Data.SqlClient.SqlParameter("@parcel_number", System.Data.SqlDbType.VarChar, 0, "parcel_number"),
            new System.Data.SqlClient.SqlParameter("@postal", System.Data.SqlDbType.VarChar, 0, "postal"),
            new System.Data.SqlClient.SqlParameter("@prov", System.Data.SqlDbType.VarChar, 0, "prov"),
            new System.Data.SqlClient.SqlParameter("@shape", System.Data.SqlDbType.VarChar, 0, "shape"),
            new System.Data.SqlClient.SqlParameter("@ma_name", System.Data.SqlDbType.VarChar, 0, "ma_name"),
            new System.Data.SqlClient.SqlParameter("@ma_number", System.Data.SqlDbType.VarChar, 0, "ma_number"),
            new System.Data.SqlClient.SqlParameter("@ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, "ma_prefix_dir"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix", System.Data.SqlDbType.VarChar, 0, "ma_suffix"),
            new System.Data.SqlClient.SqlParameter("@ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, "ma_suffix_dir"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@agreement_num", System.Data.SqlDbType.Int, 0, "agreement_num"),
            new System.Data.SqlClient.SqlParameter("@MasterAgreementNum", System.Data.SqlDbType.Int, 0, "MasterAgreementNum"),
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 0, "agreement_id"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Code", System.Data.SqlDbType.VarChar, 0, "Purchaser_Code"),
            new System.Data.SqlClient.SqlParameter("@Purchaser_Name", System.Data.SqlDbType.VarChar, 0, "Purchaser_Name"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_selected", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_proj_lot_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "proj_lot_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_class_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_class_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_class_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_plan_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_plan_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "plan_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_block_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_block_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "block_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_num", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_frontage", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_frontage", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "frontage", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_current_price", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_current_price", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "current_price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lot_sub_status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lot_sub_status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lot_sub_status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_title_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_title_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "title_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_address_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_address_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "address_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_city", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "city", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_hold_expiry", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_hold_expiry", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "hold_expiry", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_long_legal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_long_legal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "long_legal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_parcel_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_parcel_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "parcel_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_postal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_postal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "postal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_prov", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_prov", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "prov", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_shape", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_shape", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "shape", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_number", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_prefix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_prefix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_prefix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ma_suffix_dir", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ma_suffix_dir", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ma_suffix_dir", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MasterAgreementNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MasterAgreementNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_agreement_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "agreement_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Purchaser_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Purchaser_Name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Purchaser_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // ds_selectedLots1
            // 
            this.ds_selectedLots1.DataSetName = "ds_selectedLots";
            this.ds_selectedLots1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcReview
            // 
            this.gcReview.DataMember = "working_ld_LotSearch";
            this.gcReview.DataSource = this.ds_selectedLots1;
            this.gcReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReview.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcReview.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcReview.Location = new System.Drawing.Point(0, 46);
            this.gcReview.MainView = this.gvReview;
            this.gcReview.Name = "gcReview";
            this.gcReview.Size = new System.Drawing.Size(1055, 354);
            this.gcReview.TabIndex = 7;
            this.gcReview.UseEmbeddedNavigator = true;
            this.gcReview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReview});
            // 
            // gvReview
            // 
            this.gvReview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colusername,
            this.colselected,
            this.colproj_lot_id,
            this.colpri_code,
            this.collot_class_code,
            this.collot_class_desc,
            this.collot_sub_class_code,
            this.collot_sub_class_desc,
            this.colplan_num,
            this.colblock_num,
            this.collot_num,
            this.colfrontage,
            this.colcurrent_price,
            this.collot_status,
            this.collot_sub_status,
            this.coltitle_number,
            this.coladdress_1,
            this.coladdress_2,
            this.colcity,
            this.colhold_expiry,
            this.collong_legal,
            this.colparcel_number,
            this.colpostal,
            this.colprov,
            this.colshape,
            this.colma_name,
            this.colma_number,
            this.colma_prefix_dir,
            this.colma_suffix,
            this.colma_suffix_dir,
            this.colpri_id,
            this.colagreement_num,
            this.colMasterAgreementNum,
            this.colagreement_id,
            this.colPurchaser_Code,
            this.colPurchaser_Name,
            this.colpri_name});
            this.gvReview.GridControl = this.gcReview;
            this.gvReview.Name = "gvReview";
            this.gvReview.OptionsView.ColumnAutoWidth = false;
            this.gvReview.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colma_suffix, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvReview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvReview_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.Width = 23;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername.Width = 59;
            // 
            // colselected
            // 
            this.colselected.FieldName = "selected";
            this.colselected.Name = "colselected";
            this.colselected.OptionsColumn.AllowEdit = false;
            this.colselected.OptionsColumn.ShowInCustomizationForm = false;
            this.colselected.Width = 52;
            // 
            // colproj_lot_id
            // 
            this.colproj_lot_id.FieldName = "proj_lot_id";
            this.colproj_lot_id.Name = "colproj_lot_id";
            this.colproj_lot_id.OptionsColumn.AllowEdit = false;
            this.colproj_lot_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colproj_lot_id.Width = 63;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 2;
            this.colpri_code.Width = 76;
            // 
            // collot_class_code
            // 
            this.collot_class_code.Caption = "Class";
            this.collot_class_code.FieldName = "lot_class_code";
            this.collot_class_code.Name = "collot_class_code";
            this.collot_class_code.OptionsColumn.AllowEdit = false;
            this.collot_class_code.Visible = true;
            this.collot_class_code.VisibleIndex = 3;
            this.collot_class_code.Width = 64;
            // 
            // collot_class_desc
            // 
            this.collot_class_desc.Caption = "Class Description";
            this.collot_class_desc.FieldName = "lot_class_desc";
            this.collot_class_desc.Name = "collot_class_desc";
            this.collot_class_desc.OptionsColumn.AllowEdit = false;
            this.collot_class_desc.Width = 103;
            // 
            // collot_sub_class_code
            // 
            this.collot_sub_class_code.Caption = "Sub Class";
            this.collot_sub_class_code.FieldName = "lot_sub_class_code";
            this.collot_sub_class_code.Name = "collot_sub_class_code";
            this.collot_sub_class_code.OptionsColumn.AllowEdit = false;
            this.collot_sub_class_code.Visible = true;
            this.collot_sub_class_code.VisibleIndex = 4;
            this.collot_sub_class_code.Width = 68;
            // 
            // collot_sub_class_desc
            // 
            this.collot_sub_class_desc.Caption = "Sub Class Description";
            this.collot_sub_class_desc.FieldName = "lot_sub_class_desc";
            this.collot_sub_class_desc.Name = "collot_sub_class_desc";
            this.collot_sub_class_desc.OptionsColumn.AllowEdit = false;
            this.collot_sub_class_desc.Width = 124;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 5;
            this.colplan_num.Width = 65;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 6;
            this.colblock_num.Width = 73;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 7;
            // 
            // colfrontage
            // 
            this.colfrontage.Caption = "Frontage";
            this.colfrontage.DisplayFormat.FormatString = "n2";
            this.colfrontage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colfrontage.FieldName = "frontage";
            this.colfrontage.Name = "colfrontage";
            this.colfrontage.OptionsColumn.AllowEdit = false;
            this.colfrontage.Visible = true;
            this.colfrontage.VisibleIndex = 8;
            this.colfrontage.Width = 66;
            // 
            // colcurrent_price
            // 
            this.colcurrent_price.Caption = "Current Price";
            this.colcurrent_price.DisplayFormat.FormatString = "n2";
            this.colcurrent_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcurrent_price.FieldName = "current_price";
            this.colcurrent_price.Name = "colcurrent_price";
            this.colcurrent_price.OptionsColumn.AllowEdit = false;
            this.colcurrent_price.Visible = true;
            this.colcurrent_price.VisibleIndex = 9;
            this.colcurrent_price.Width = 85;
            // 
            // collot_status
            // 
            this.collot_status.Caption = "Status";
            this.collot_status.FieldName = "lot_status";
            this.collot_status.Name = "collot_status";
            this.collot_status.OptionsColumn.AllowEdit = false;
            this.collot_status.Visible = true;
            this.collot_status.VisibleIndex = 10;
            this.collot_status.Width = 80;
            // 
            // collot_sub_status
            // 
            this.collot_sub_status.Caption = "Sub Status";
            this.collot_sub_status.FieldName = "lot_sub_status";
            this.collot_sub_status.Name = "collot_sub_status";
            this.collot_sub_status.OptionsColumn.AllowEdit = false;
            this.collot_sub_status.Visible = true;
            this.collot_sub_status.VisibleIndex = 11;
            this.collot_sub_status.Width = 93;
            // 
            // coltitle_number
            // 
            this.coltitle_number.Caption = "Title";
            this.coltitle_number.FieldName = "title_number";
            this.coltitle_number.Name = "coltitle_number";
            this.coltitle_number.OptionsColumn.AllowEdit = false;
            this.coltitle_number.Visible = true;
            this.coltitle_number.VisibleIndex = 12;
            this.coltitle_number.Width = 79;
            // 
            // coladdress_1
            // 
            this.coladdress_1.Caption = "Address 1";
            this.coladdress_1.FieldName = "address_1";
            this.coladdress_1.Name = "coladdress_1";
            this.coladdress_1.OptionsColumn.AllowEdit = false;
            this.coladdress_1.Width = 70;
            // 
            // coladdress_2
            // 
            this.coladdress_2.Caption = "Address 2";
            this.coladdress_2.FieldName = "address_2";
            this.coladdress_2.Name = "coladdress_2";
            this.coladdress_2.OptionsColumn.AllowEdit = false;
            this.coladdress_2.Width = 70;
            // 
            // colcity
            // 
            this.colcity.Caption = "City";
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.OptionsColumn.AllowEdit = false;
            this.colcity.Width = 41;
            // 
            // colhold_expiry
            // 
            this.colhold_expiry.Caption = "Hold Expiry";
            this.colhold_expiry.FieldName = "hold_expiry";
            this.colhold_expiry.Name = "colhold_expiry";
            this.colhold_expiry.OptionsColumn.AllowEdit = false;
            this.colhold_expiry.Width = 76;
            // 
            // collong_legal
            // 
            this.collong_legal.Caption = "Long Legal";
            this.collong_legal.FieldName = "long_legal";
            this.collong_legal.Name = "collong_legal";
            this.collong_legal.OptionsColumn.AllowEdit = false;
            this.collong_legal.Width = 73;
            // 
            // colparcel_number
            // 
            this.colparcel_number.Caption = "Parcel";
            this.colparcel_number.FieldName = "parcel_number";
            this.colparcel_number.Name = "colparcel_number";
            this.colparcel_number.OptionsColumn.AllowEdit = false;
            this.colparcel_number.Width = 51;
            // 
            // colpostal
            // 
            this.colpostal.Caption = "Postal";
            this.colpostal.FieldName = "postal";
            this.colpostal.Name = "colpostal";
            this.colpostal.OptionsColumn.AllowEdit = false;
            this.colpostal.Width = 51;
            // 
            // colprov
            // 
            this.colprov.Caption = "Province";
            this.colprov.FieldName = "prov";
            this.colprov.Name = "colprov";
            this.colprov.OptionsColumn.AllowEdit = false;
            this.colprov.Width = 63;
            // 
            // colshape
            // 
            this.colshape.Caption = "Shape";
            this.colshape.FieldName = "shape";
            this.colshape.Name = "colshape";
            this.colshape.OptionsColumn.AllowEdit = false;
            this.colshape.Width = 52;
            // 
            // colma_name
            // 
            this.colma_name.Caption = "Street Name";
            this.colma_name.FieldName = "ma_name";
            this.colma_name.Name = "colma_name";
            this.colma_name.OptionsColumn.AllowEdit = false;
            this.colma_name.Width = 82;
            // 
            // colma_number
            // 
            this.colma_number.Caption = "Street Number";
            this.colma_number.FieldName = "ma_number";
            this.colma_number.Name = "colma_number";
            this.colma_number.OptionsColumn.AllowEdit = false;
            this.colma_number.Width = 92;
            // 
            // colma_prefix_dir
            // 
            this.colma_prefix_dir.Caption = "Street Prefix Direction";
            this.colma_prefix_dir.FieldName = "ma_prefix_dir";
            this.colma_prefix_dir.Name = "colma_prefix_dir";
            this.colma_prefix_dir.OptionsColumn.AllowEdit = false;
            this.colma_prefix_dir.Width = 128;
            // 
            // colma_suffix
            // 
            this.colma_suffix.Caption = "Street Suffix";
            this.colma_suffix.FieldName = "ma_suffix";
            this.colma_suffix.Name = "colma_suffix";
            this.colma_suffix.OptionsColumn.AllowEdit = false;
            this.colma_suffix.Width = 83;
            // 
            // colma_suffix_dir
            // 
            this.colma_suffix_dir.Caption = "Street Suffix Direction";
            this.colma_suffix_dir.FieldName = "ma_suffix_dir";
            this.colma_suffix_dir.Name = "colma_suffix_dir";
            this.colma_suffix_dir.OptionsColumn.AllowEdit = false;
            this.colma_suffix_dir.Width = 128;
            // 
            // colpri_id
            // 
            this.colpri_id.FieldName = "pri_id";
            this.colpri_id.Name = "colpri_id";
            this.colpri_id.OptionsColumn.AllowEdit = false;
            this.colpri_id.OptionsColumn.ShowInCustomizationForm = false;
            this.colpri_id.Width = 38;
            // 
            // colagreement_num
            // 
            this.colagreement_num.Caption = "Agreement #";
            this.colagreement_num.FieldName = "agreement_num";
            this.colagreement_num.Name = "colagreement_num";
            this.colagreement_num.OptionsColumn.AllowEdit = false;
            this.colagreement_num.Visible = true;
            this.colagreement_num.VisibleIndex = 0;
            this.colagreement_num.Width = 86;
            // 
            // colMasterAgreementNum
            // 
            this.colMasterAgreementNum.Caption = "Master Agreement #";
            this.colMasterAgreementNum.FieldName = "MasterAgreementNum";
            this.colMasterAgreementNum.Name = "colMasterAgreementNum";
            this.colMasterAgreementNum.OptionsColumn.AllowEdit = false;
            this.colMasterAgreementNum.Visible = true;
            this.colMasterAgreementNum.VisibleIndex = 1;
            this.colMasterAgreementNum.Width = 122;
            // 
            // colagreement_id
            // 
            this.colagreement_id.FieldName = "agreement_id";
            this.colagreement_id.Name = "colagreement_id";
            this.colagreement_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPurchaser_Code
            // 
            this.colPurchaser_Code.Caption = "Purchaser Code";
            this.colPurchaser_Code.FieldName = "Purchaser_Code";
            this.colPurchaser_Code.Name = "colPurchaser_Code";
            // 
            // colPurchaser_Name
            // 
            this.colPurchaser_Name.Caption = "Purchaser Name";
            this.colPurchaser_Name.FieldName = "Purchaser_Name";
            this.colPurchaser_Name.Name = "colPurchaser_Name";
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            // 
            // da_lueCostingLevels
            // 
            this.da_lueCostingLevels.SelectCommand = this.sqlSelectCommand2;
            this.da_lueCostingLevels.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CostingCodeLookups", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv1_code", "lv1_code"),
                        new System.Data.Common.DataColumnMapping("lv1_desc", "lv1_desc")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv2_code", "lv2_code"),
                        new System.Data.Common.DataColumnMapping("lv2_desc", "lv2_desc"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID")}),
            new System.Data.Common.DataTableMapping("Table2", "Table2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv3_code", "lv3_code"),
                        new System.Data.Common.DataColumnMapping("lv3_desc", "lv3_desc"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID")}),
            new System.Data.Common.DataTableMapping("Table3", "Table3", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("lv4_code", "lv4_code"),
                        new System.Data.Common.DataColumnMapping("lv4_desc", "lv4_desc"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.CostingCodeLookups";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ProjType", System.Data.SqlDbType.VarChar, 5)});
            // 
            // ds_lueCostingLevels1
            // 
            this.ds_lueCostingLevels1.DataSetName = "ds_lueCostingLevels";
            this.ds_lueCostingLevels1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // da_LotSaleAdjustments
            // 
            this.da_LotSaleAdjustments.DeleteCommand = this.sqlDeleteCommand2;
            this.da_LotSaleAdjustments.InsertCommand = this.sqlInsertCommand2;
            this.da_LotSaleAdjustments.SelectCommand = this.sqlSelectCommand3;
            this.da_LotSaleAdjustments.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_LotSaleAdjustments", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LotSaleAdjustments_ID", "LotSaleAdjustments_ID"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("CostRecoverable", "CostRecoverable"),
                        new System.Data.Common.DataColumnMapping("ExpenseAccount", "ExpenseAccount"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Tax1", "Tax1"),
                        new System.Data.Common.DataColumnMapping("Tax2", "Tax2"),
                        new System.Data.Common.DataColumnMapping("ExtendedDescription", "ExtendedDescription"),
                        new System.Data.Common.DataColumnMapping("LV_1_ID", "LV_1_ID"),
                        new System.Data.Common.DataColumnMapping("LV_2_ID", "LV_2_ID"),
                        new System.Data.Common.DataColumnMapping("LV_3_ID", "LV_3_ID"),
                        new System.Data.Common.DataColumnMapping("LV_4_ID", "LV_4_ID"),
                        new System.Data.Common.DataColumnMapping("LEM_COMP", "LEM_COMP")})});
            this.da_LotSaleAdjustments.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRecoverable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRecoverable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpenseAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpenseAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LEM_COMP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LEM_COMP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@CostRecoverable", System.Data.SqlDbType.Bit, 0, "CostRecoverable"),
            new System.Data.SqlClient.SqlParameter("@ExpenseAccount", System.Data.SqlDbType.VarChar, 0, "ExpenseAccount"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Tax1", System.Data.SqlDbType.Bit, 0, "Tax1"),
            new System.Data.SqlClient.SqlParameter("@Tax2", System.Data.SqlDbType.Bit, 0, "Tax2"),
            new System.Data.SqlClient.SqlParameter("@ExtendedDescription", System.Data.SqlDbType.VarChar, 0, "ExtendedDescription"),
            new System.Data.SqlClient.SqlParameter("@LV_1_ID", System.Data.SqlDbType.Int, 0, "LV_1_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_2_ID", System.Data.SqlDbType.Int, 0, "LV_2_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_3_ID", System.Data.SqlDbType.Int, 0, "LV_3_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_4_ID", System.Data.SqlDbType.Int, 0, "LV_4_ID"),
            new System.Data.SqlClient.SqlParameter("@LEM_COMP", System.Data.SqlDbType.VarChar, 0, "LEM_COMP")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@CostRecoverable", System.Data.SqlDbType.Bit, 0, "CostRecoverable"),
            new System.Data.SqlClient.SqlParameter("@ExpenseAccount", System.Data.SqlDbType.VarChar, 0, "ExpenseAccount"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Tax1", System.Data.SqlDbType.Bit, 0, "Tax1"),
            new System.Data.SqlClient.SqlParameter("@Tax2", System.Data.SqlDbType.Bit, 0, "Tax2"),
            new System.Data.SqlClient.SqlParameter("@ExtendedDescription", System.Data.SqlDbType.VarChar, 0, "ExtendedDescription"),
            new System.Data.SqlClient.SqlParameter("@LV_1_ID", System.Data.SqlDbType.Int, 0, "LV_1_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_2_ID", System.Data.SqlDbType.Int, 0, "LV_2_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_3_ID", System.Data.SqlDbType.Int, 0, "LV_3_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_4_ID", System.Data.SqlDbType.Int, 0, "LV_4_ID"),
            new System.Data.SqlClient.SqlParameter("@LEM_COMP", System.Data.SqlDbType.VarChar, 0, "LEM_COMP"),
            new System.Data.SqlClient.SqlParameter("@Original_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRecoverable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRecoverable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpenseAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpenseAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LEM_COMP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LEM_COMP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 4, "LotSaleAdjustments_ID")});
            // 
            // ds_LotSaleAdjustments1
            // 
            this.ds_LotSaleAdjustments1.DataSetName = "ds_LotSaleAdjustments";
            this.ds_LotSaleAdjustments1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_lueLotSaleAdjustmentsDescription
            // 
            this.bs_lueLotSaleAdjustmentsDescription.DataMember = "LD_LotSaleAdjustments";
            this.bs_lueLotSaleAdjustmentsDescription.DataSource = this.ds_LotSaleAdjustments1;
            // 
            // bs_lueLotSaleAdjustmentsCode
            // 
            this.bs_lueLotSaleAdjustmentsCode.DataMember = "LD_LotSaleAdjustments";
            this.bs_lueLotSaleAdjustmentsCode.DataSource = this.ds_LotSaleAdjustments1;
            // 
            // bs_CC4_Restricted
            // 
            this.bs_CC4_Restricted.DataMember = "Table3";
            this.bs_CC4_Restricted.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_LotSaleAdj
            // 
            this.bs_LotSaleAdj.DataMember = "working_ld_lsa_lotsaleadjustments";
            this.bs_LotSaleAdj.DataSource = this.ds_lotSaleAdj1;
            // 
            // ds_lotSaleAdj1
            // 
            this.ds_lotSaleAdj1.DataSetName = "ds_lotSaleAdj";
            this.ds_lotSaleAdj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_CC3_Restricted
            // 
            this.bs_CC3_Restricted.DataMember = "Table2";
            this.bs_CC3_Restricted.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC2_Restricted
            // 
            this.bs_CC2_Restricted.DataMember = "Table1";
            this.bs_CC2_Restricted.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC1_Restricted
            // 
            this.bs_CC1_Restricted.DataMember = "CostingCodeLookups";
            this.bs_CC1_Restricted.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC4
            // 
            this.bs_CC4.DataMember = "Table3";
            this.bs_CC4.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC3
            // 
            this.bs_CC3.DataMember = "Table2";
            this.bs_CC3.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC2
            // 
            this.bs_CC2.DataMember = "Table1";
            this.bs_CC2.DataSource = this.ds_lueCostingLevels1;
            // 
            // bs_CC1
            // 
            this.bs_CC1.DataMember = "CostingCodeLookups";
            this.bs_CC1.DataSource = this.ds_lueCostingLevels1;
            // 
            // grpLotAdjustments
            // 
            this.grpLotAdjustments.Controls.Add(this.gcLotSale);
            this.grpLotAdjustments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpLotAdjustments.Location = new System.Drawing.Point(0, 406);
            this.grpLotAdjustments.Name = "grpLotAdjustments";
            this.grpLotAdjustments.Size = new System.Drawing.Size(1055, 259);
            this.grpLotAdjustments.TabIndex = 8;
            this.grpLotAdjustments.Text = "Lot Sale Adjustments";
            // 
            // gcLotSale
            // 
            this.gcLotSale.DataSource = this.bs_LotSaleAdj;
            this.gcLotSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLotSale.Location = new System.Drawing.Point(2, 20);
            this.gcLotSale.MainView = this.gvLotSale;
            this.gcLotSale.Name = "gcLotSale";
            this.gcLotSale.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_teCode,
            this.ri_teDesc,
            this.ri_seNumaric2,
            this.ri_lueCostingCode1,
            this.ri_lueCostingCode2,
            this.ri_lueCostingCode3,
            this.ri_lueCostingCode4,
            this.ri_lueNotEditable,
            this.ri_lueLSAcode,
            this.ri_lueLSAdescription,
            this.ri_teReadOnly,
            this.ri_teNumaricReadOnly});
            this.gcLotSale.Size = new System.Drawing.Size(1051, 237);
            this.gcLotSale.TabIndex = 5;
            this.gcLotSale.UseEmbeddedNavigator = true;
            this.gcLotSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotSale});
            // 
            // gvLotSale
            // 
            this.gvLotSale.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLotSaleAdjustments_ID,
            this.colLotSaleAdjustments_ID1,
            this.colCostRecoverable,
            this.colExpenseAccount,
            this.colAmount,
            this.colTax1,
            this.colTax2,
            this.colExtendedAmount,
            this.colExtendedDescription,
            this.colLV_1_ID,
            this.colLV_2_ID,
            this.colLV_3_ID,
            this.colLV_4_ID,
            this.colLEM_COMP,
            this.colusername1,
            this.colworking_ld_lsa_lotsaleadjustments,
            this.colworking_ld_LotSearch_ID});
            this.gvLotSale.GridControl = this.gcLotSale;
            this.gvLotSale.Name = "gvLotSale";
            this.gvLotSale.OptionsView.ColumnAutoWidth = false;
            this.gvLotSale.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvLotSale_CellValueChanged);
            this.gvLotSale.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvLotSale_InitNewRow);
            this.gvLotSale.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvLotSale_CustomRowCellEdit);
            this.gvLotSale.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvLotSale_InvalidRowException);
            this.gvLotSale.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvLotSale_ValidateRow);
            // 
            // colLotSaleAdjustments_ID
            // 
            this.colLotSaleAdjustments_ID.Caption = "Code";
            this.colLotSaleAdjustments_ID.ColumnEdit = this.ri_lueLSAcode;
            this.colLotSaleAdjustments_ID.FieldName = "LotSaleAdjustments_ID";
            this.colLotSaleAdjustments_ID.Name = "colLotSaleAdjustments_ID";
            this.colLotSaleAdjustments_ID.Visible = true;
            this.colLotSaleAdjustments_ID.VisibleIndex = 0;
            this.colLotSaleAdjustments_ID.Width = 84;
            // 
            // ri_lueLSAcode
            // 
            this.ri_lueLSAcode.AutoHeight = false;
            this.ri_lueLSAcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLSAcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLSAcode.DataSource = this.bs_lueLotSaleAdjustmentsCode;
            this.ri_lueLSAcode.DisplayMember = "Code";
            this.ri_lueLSAcode.Name = "ri_lueLSAcode";
            this.ri_lueLSAcode.NullText = "";
            this.ri_lueLSAcode.PopupWidth = 200;
            this.ri_lueLSAcode.ValueMember = "LotSaleAdjustments_ID";
            // 
            // colLotSaleAdjustments_ID1
            // 
            this.colLotSaleAdjustments_ID1.Caption = "Description";
            this.colLotSaleAdjustments_ID1.ColumnEdit = this.ri_lueLSAdescription;
            this.colLotSaleAdjustments_ID1.FieldName = "LotSaleAdjustments_ID";
            this.colLotSaleAdjustments_ID1.Name = "colLotSaleAdjustments_ID1";
            this.colLotSaleAdjustments_ID1.Visible = true;
            this.colLotSaleAdjustments_ID1.VisibleIndex = 1;
            this.colLotSaleAdjustments_ID1.Width = 89;
            // 
            // ri_lueLSAdescription
            // 
            this.ri_lueLSAdescription.AutoHeight = false;
            this.ri_lueLSAdescription.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueLSAdescription.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueLSAdescription.DataSource = this.bs_lueLotSaleAdjustmentsDescription;
            this.ri_lueLSAdescription.DisplayMember = "Description";
            this.ri_lueLSAdescription.Name = "ri_lueLSAdescription";
            this.ri_lueLSAdescription.NullText = "";
            this.ri_lueLSAdescription.ValueMember = "LotSaleAdjustments_ID";
            // 
            // colCostRecoverable
            // 
            this.colCostRecoverable.FieldName = "CostRecoverable";
            this.colCostRecoverable.Name = "colCostRecoverable";
            this.colCostRecoverable.Visible = true;
            this.colCostRecoverable.VisibleIndex = 2;
            this.colCostRecoverable.Width = 110;
            // 
            // colExpenseAccount
            // 
            this.colExpenseAccount.ColumnEdit = this.ri_teReadOnly;
            this.colExpenseAccount.FieldName = "ExpenseAccount";
            this.colExpenseAccount.Name = "colExpenseAccount";
            this.colExpenseAccount.Visible = true;
            this.colExpenseAccount.VisibleIndex = 3;
            this.colExpenseAccount.Width = 195;
            // 
            // ri_teReadOnly
            // 
            this.ri_teReadOnly.AutoHeight = false;
            this.ri_teReadOnly.Name = "ri_teReadOnly";
            this.ri_teReadOnly.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.ColumnEdit = this.ri_seNumaric2;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 110;
            // 
            // ri_seNumaric2
            // 
            this.ri_seNumaric2.AutoHeight = false;
            this.ri_seNumaric2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.ri_seNumaric2.Mask.EditMask = "n";
            this.ri_seNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.ri_seNumaric2.Name = "ri_seNumaric2";
            // 
            // colTax1
            // 
            this.colTax1.FieldName = "Tax1";
            this.colTax1.Name = "colTax1";
            this.colTax1.Visible = true;
            this.colTax1.VisibleIndex = 5;
            this.colTax1.Width = 71;
            // 
            // colTax2
            // 
            this.colTax2.FieldName = "Tax2";
            this.colTax2.Name = "colTax2";
            this.colTax2.Visible = true;
            this.colTax2.VisibleIndex = 6;
            this.colTax2.Width = 70;
            // 
            // colExtendedAmount
            // 
            this.colExtendedAmount.ColumnEdit = this.ri_teNumaricReadOnly;
            this.colExtendedAmount.FieldName = "ExtendedAmount";
            this.colExtendedAmount.Name = "colExtendedAmount";
            this.colExtendedAmount.Visible = true;
            this.colExtendedAmount.VisibleIndex = 7;
            this.colExtendedAmount.Width = 107;
            // 
            // ri_teNumaricReadOnly
            // 
            this.ri_teNumaricReadOnly.AutoHeight = false;
            this.ri_teNumaricReadOnly.DisplayFormat.FormatString = "n2";
            this.ri_teNumaricReadOnly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ri_teNumaricReadOnly.EditFormat.FormatString = "n2";
            this.ri_teNumaricReadOnly.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ri_teNumaricReadOnly.Name = "ri_teNumaricReadOnly";
            this.ri_teNumaricReadOnly.ReadOnly = true;
            // 
            // colExtendedDescription
            // 
            this.colExtendedDescription.FieldName = "ExtendedDescription";
            this.colExtendedDescription.Name = "colExtendedDescription";
            this.colExtendedDescription.Visible = true;
            this.colExtendedDescription.VisibleIndex = 8;
            this.colExtendedDescription.Width = 199;
            // 
            // colLV_1_ID
            // 
            this.colLV_1_ID.ColumnEdit = this.ri_lueCostingCode1;
            this.colLV_1_ID.FieldName = "LV_1_ID";
            this.colLV_1_ID.Name = "colLV_1_ID";
            this.colLV_1_ID.Visible = true;
            this.colLV_1_ID.VisibleIndex = 9;
            this.colLV_1_ID.Width = 100;
            // 
            // ri_lueCostingCode1
            // 
            this.ri_lueCostingCode1.AutoHeight = false;
            this.ri_lueCostingCode1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueCostingCode1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueCostingCode1.DataSource = this.bs_CC1;
            this.ri_lueCostingCode1.DisplayMember = "lv1_code";
            this.ri_lueCostingCode1.Name = "ri_lueCostingCode1";
            this.ri_lueCostingCode1.NullText = "";
            this.ri_lueCostingCode1.PopupWidth = 200;
            this.ri_lueCostingCode1.ValueMember = "lv1ID";
            // 
            // colLV_2_ID
            // 
            this.colLV_2_ID.ColumnEdit = this.ri_lueCostingCode2;
            this.colLV_2_ID.FieldName = "LV_2_ID";
            this.colLV_2_ID.Name = "colLV_2_ID";
            this.colLV_2_ID.Visible = true;
            this.colLV_2_ID.VisibleIndex = 10;
            this.colLV_2_ID.Width = 96;
            // 
            // ri_lueCostingCode2
            // 
            this.ri_lueCostingCode2.AutoHeight = false;
            this.ri_lueCostingCode2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueCostingCode2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueCostingCode2.DataSource = this.bs_CC2;
            this.ri_lueCostingCode2.DisplayMember = "lv2_code";
            this.ri_lueCostingCode2.Name = "ri_lueCostingCode2";
            this.ri_lueCostingCode2.NullText = "";
            this.ri_lueCostingCode2.PopupWidth = 200;
            this.ri_lueCostingCode2.ValueMember = "lv2ID";
            this.ri_lueCostingCode2.Enter += new System.EventHandler(this.ri_lueCostingCode2_Enter);
            // 
            // colLV_3_ID
            // 
            this.colLV_3_ID.ColumnEdit = this.ri_lueCostingCode3;
            this.colLV_3_ID.FieldName = "LV_3_ID";
            this.colLV_3_ID.Name = "colLV_3_ID";
            this.colLV_3_ID.Visible = true;
            this.colLV_3_ID.VisibleIndex = 11;
            this.colLV_3_ID.Width = 93;
            // 
            // ri_lueCostingCode3
            // 
            this.ri_lueCostingCode3.AutoHeight = false;
            this.ri_lueCostingCode3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueCostingCode3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueCostingCode3.DataSource = this.bs_CC3;
            this.ri_lueCostingCode3.DisplayMember = "lv3_code";
            this.ri_lueCostingCode3.Name = "ri_lueCostingCode3";
            this.ri_lueCostingCode3.NullText = "";
            this.ri_lueCostingCode3.PopupWidth = 200;
            this.ri_lueCostingCode3.ValueMember = "lv3ID";
            this.ri_lueCostingCode3.Enter += new System.EventHandler(this.ri_lueCostingCode3_Enter);
            // 
            // colLV_4_ID
            // 
            this.colLV_4_ID.ColumnEdit = this.ri_lueCostingCode4;
            this.colLV_4_ID.FieldName = "LV_4_ID";
            this.colLV_4_ID.Name = "colLV_4_ID";
            this.colLV_4_ID.Visible = true;
            this.colLV_4_ID.VisibleIndex = 12;
            this.colLV_4_ID.Width = 93;
            // 
            // ri_lueCostingCode4
            // 
            this.ri_lueCostingCode4.AutoHeight = false;
            this.ri_lueCostingCode4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueCostingCode4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 140, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueCostingCode4.DataSource = this.bs_CC4;
            this.ri_lueCostingCode4.DisplayMember = "lv4_code";
            this.ri_lueCostingCode4.Name = "ri_lueCostingCode4";
            this.ri_lueCostingCode4.NullText = "";
            this.ri_lueCostingCode4.PopupWidth = 200;
            this.ri_lueCostingCode4.ValueMember = "lv4ID";
            this.ri_lueCostingCode4.Enter += new System.EventHandler(this.ri_lueCostingCode4_Enter);
            // 
            // colLEM_COMP
            // 
            this.colLEM_COMP.FieldName = "LEM_COMP";
            this.colLEM_COMP.Name = "colLEM_COMP";
            this.colLEM_COMP.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername1
            // 
            this.colusername1.FieldName = "username";
            this.colusername1.Name = "colusername1";
            this.colusername1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colworking_ld_lsa_lotsaleadjustments
            // 
            this.colworking_ld_lsa_lotsaleadjustments.FieldName = "working_ld_lsa_lotsaleadjustments";
            this.colworking_ld_lsa_lotsaleadjustments.Name = "colworking_ld_lsa_lotsaleadjustments";
            this.colworking_ld_lsa_lotsaleadjustments.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colworking_ld_LotSearch_ID
            // 
            this.colworking_ld_LotSearch_ID.FieldName = "working_ld_LotSearch_ID";
            this.colworking_ld_LotSearch_ID.Name = "colworking_ld_LotSearch_ID";
            this.colworking_ld_LotSearch_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ri_teCode
            // 
            this.ri_teCode.AutoHeight = false;
            this.ri_teCode.MaxLength = 10;
            this.ri_teCode.Name = "ri_teCode";
            // 
            // ri_teDesc
            // 
            this.ri_teDesc.AutoHeight = false;
            this.ri_teDesc.MaxLength = 50;
            this.ri_teDesc.Name = "ri_teDesc";
            // 
            // ri_lueNotEditable
            // 
            this.ri_lueNotEditable.AutoHeight = false;
            this.ri_lueNotEditable.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.ri_lueNotEditable.Name = "ri_lueNotEditable";
            this.ri_lueNotEditable.NullText = "";
            this.ri_lueNotEditable.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // da_lotSaleAdj
            // 
            this.da_lotSaleAdj.DeleteCommand = this.sqlCommand1;
            this.da_lotSaleAdj.InsertCommand = this.sqlCommand2;
            this.da_lotSaleAdj.SelectCommand = this.sqlCommand3;
            this.da_lotSaleAdj.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lsa_lotsaleadjustments", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LotSaleAdjustments_ID", "LotSaleAdjustments_ID"),
                        new System.Data.Common.DataColumnMapping("CostRecoverable", "CostRecoverable"),
                        new System.Data.Common.DataColumnMapping("ExpenseAccount", "ExpenseAccount"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Tax1", "Tax1"),
                        new System.Data.Common.DataColumnMapping("Tax2", "Tax2"),
                        new System.Data.Common.DataColumnMapping("ExtendedAmount", "ExtendedAmount"),
                        new System.Data.Common.DataColumnMapping("ExtendedDescription", "ExtendedDescription"),
                        new System.Data.Common.DataColumnMapping("LV_1_ID", "LV_1_ID"),
                        new System.Data.Common.DataColumnMapping("LV_2_ID", "LV_2_ID"),
                        new System.Data.Common.DataColumnMapping("LV_3_ID", "LV_3_ID"),
                        new System.Data.Common.DataColumnMapping("LV_4_ID", "LV_4_ID"),
                        new System.Data.Common.DataColumnMapping("LEM_COMP", "LEM_COMP"),
                        new System.Data.Common.DataColumnMapping("working_ld_lsa_lotsaleadjustments", "working_ld_lsa_lotsaleadjustments"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("working_ld_LotSearch_ID", "working_ld_LotSearch_ID"),
                        new System.Data.Common.DataColumnMapping("isNew", "isNew")})});
            this.da_lotSaleAdj.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlTRConnection;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRecoverable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRecoverable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpenseAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpenseAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExtendedAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExtendedAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExtendedAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExtendedAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LEM_COMP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LEM_COMP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lsa_lotsaleadjustments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lsa_lotsaleadjustments", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_isNew", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "isNew", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_isNew", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "isNew", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlTRConnection;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, "LotSaleAdjustments_ID"),
            new System.Data.SqlClient.SqlParameter("@CostRecoverable", System.Data.SqlDbType.Bit, 0, "CostRecoverable"),
            new System.Data.SqlClient.SqlParameter("@ExpenseAccount", System.Data.SqlDbType.VarChar, 0, "ExpenseAccount"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Tax1", System.Data.SqlDbType.Bit, 0, "Tax1"),
            new System.Data.SqlClient.SqlParameter("@Tax2", System.Data.SqlDbType.Bit, 0, "Tax2"),
            new System.Data.SqlClient.SqlParameter("@ExtendedAmount", System.Data.SqlDbType.Money, 0, "ExtendedAmount"),
            new System.Data.SqlClient.SqlParameter("@ExtendedDescription", System.Data.SqlDbType.VarChar, 0, "ExtendedDescription"),
            new System.Data.SqlClient.SqlParameter("@LV_1_ID", System.Data.SqlDbType.Int, 0, "LV_1_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_2_ID", System.Data.SqlDbType.Int, 0, "LV_2_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_3_ID", System.Data.SqlDbType.Int, 0, "LV_3_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_4_ID", System.Data.SqlDbType.Int, 0, "LV_4_ID"),
            new System.Data.SqlClient.SqlParameter("@LEM_COMP", System.Data.SqlDbType.VarChar, 0, "LEM_COMP"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@isNew", System.Data.SqlDbType.Bit, 0, "isNew")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlTRConnection;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 4, "working_ld_LotSearch_ID")});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlTRConnection;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, "LotSaleAdjustments_ID"),
            new System.Data.SqlClient.SqlParameter("@CostRecoverable", System.Data.SqlDbType.Bit, 0, "CostRecoverable"),
            new System.Data.SqlClient.SqlParameter("@ExpenseAccount", System.Data.SqlDbType.VarChar, 0, "ExpenseAccount"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Tax1", System.Data.SqlDbType.Bit, 0, "Tax1"),
            new System.Data.SqlClient.SqlParameter("@Tax2", System.Data.SqlDbType.Bit, 0, "Tax2"),
            new System.Data.SqlClient.SqlParameter("@ExtendedAmount", System.Data.SqlDbType.Money, 0, "ExtendedAmount"),
            new System.Data.SqlClient.SqlParameter("@ExtendedDescription", System.Data.SqlDbType.VarChar, 0, "ExtendedDescription"),
            new System.Data.SqlClient.SqlParameter("@LV_1_ID", System.Data.SqlDbType.Int, 0, "LV_1_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_2_ID", System.Data.SqlDbType.Int, 0, "LV_2_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_3_ID", System.Data.SqlDbType.Int, 0, "LV_3_ID"),
            new System.Data.SqlClient.SqlParameter("@LV_4_ID", System.Data.SqlDbType.Int, 0, "LV_4_ID"),
            new System.Data.SqlClient.SqlParameter("@LEM_COMP", System.Data.SqlDbType.VarChar, 0, "LEM_COMP"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@isNew", System.Data.SqlDbType.Bit, 0, "isNew"),
            new System.Data.SqlClient.SqlParameter("@IsNull_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LotSaleAdjustments_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LotSaleAdjustments_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRecoverable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRecoverable", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRecoverable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExpenseAccount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExpenseAccount", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExpenseAccount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tax2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ExtendedAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ExtendedAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ExtendedAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ExtendedAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_2_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_2_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_3_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_3_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LV_4_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LV_4_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LEM_COMP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LEM_COMP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LEM_COMP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lsa_lotsaleadjustments", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lsa_lotsaleadjustments", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_isNew", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "isNew", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_isNew", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "isNew", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@working_ld_lsa_lotsaleadjustments", System.Data.SqlDbType.Int, 4, "working_ld_lsa_lotsaleadjustments")});
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 400);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1055, 6);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
            // 
            // ucReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcReview);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.grpLotAdjustments);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucReview";
            this.Size = new System.Drawing.Size(1055, 665);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueCostingLevels1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LotSaleAdjustments1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSaleAdjustmentsDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueLotSaleAdjustmentsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC4_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_LotSaleAdj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lotSaleAdj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC3_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC2_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC1_Restricted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpLotAdjustments)).EndInit();
            this.grpLotAdjustments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLSAcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueLSAdescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teNumaricReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueCostingCode4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_teDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueNotEditable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit deInvoiceDate;
        public AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private System.Data.SqlClient.SqlDataAdapter da_selectedLots;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private ds_selectedLots ds_selectedLots1;
        private DevExpress.XtraGrid.GridControl gcReview;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReview;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colselected;
        private DevExpress.XtraGrid.Columns.GridColumn colproj_lot_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_class_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_class_code;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_class_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colfrontage;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_price;
        private DevExpress.XtraGrid.Columns.GridColumn collot_status;
        private DevExpress.XtraGrid.Columns.GridColumn collot_sub_status;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle_number;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_1;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_2;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn colhold_expiry;
        private DevExpress.XtraGrid.Columns.GridColumn collong_legal;
        private DevExpress.XtraGrid.Columns.GridColumn colparcel_number;
        private DevExpress.XtraGrid.Columns.GridColumn colpostal;
        private DevExpress.XtraGrid.Columns.GridColumn colprov;
        private DevExpress.XtraGrid.Columns.GridColumn colshape;
        private DevExpress.XtraGrid.Columns.GridColumn colma_name;
        private DevExpress.XtraGrid.Columns.GridColumn colma_number;
        private DevExpress.XtraGrid.Columns.GridColumn colma_prefix_dir;
        private DevExpress.XtraGrid.Columns.GridColumn colma_suffix;
        private DevExpress.XtraGrid.Columns.GridColumn colma_suffix_dir;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_id;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_num;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterAgreementNum;
        private DevExpress.XtraGrid.Columns.GridColumn colagreement_id;
        private System.Data.SqlClient.SqlDataAdapter da_lueCostingLevels;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private ds_lueCostingLevels ds_lueCostingLevels1;
        private System.Data.SqlClient.SqlDataAdapter da_LotSaleAdjustments;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private ds_LotSaleAdjustments ds_LotSaleAdjustments1;
        private System.Windows.Forms.BindingSource bs_lueLotSaleAdjustmentsDescription;
        private System.Windows.Forms.BindingSource bs_lueLotSaleAdjustmentsCode;
        private System.Windows.Forms.BindingSource bs_CC4_Restricted;
        private System.Windows.Forms.BindingSource bs_LotSaleAdj;
        private System.Windows.Forms.BindingSource bs_CC3_Restricted;
        private System.Windows.Forms.BindingSource bs_CC2_Restricted;
        private System.Windows.Forms.BindingSource bs_CC1_Restricted;
        private System.Windows.Forms.BindingSource bs_CC4;
        private System.Windows.Forms.BindingSource bs_CC3;
        private System.Windows.Forms.BindingSource bs_CC2;
        private System.Windows.Forms.BindingSource bs_CC1;
        private DevExpress.XtraEditors.GroupControl grpLotAdjustments;
        private DevExpress.XtraGrid.GridControl gcLotSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotSale;
        private DevExpress.XtraGrid.Columns.GridColumn colLotSaleAdjustments_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLSAcode;
        private DevExpress.XtraGrid.Columns.GridColumn colLotSaleAdjustments_ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueLSAdescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCostRecoverable;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenseAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit ri_seNumaric2;
        private DevExpress.XtraGrid.Columns.GridColumn colTax1;
        private DevExpress.XtraGrid.Columns.GridColumn colTax2;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teNumaricReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLV_1_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueCostingCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colLV_2_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueCostingCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colLV_3_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueCostingCode3;
        private DevExpress.XtraGrid.Columns.GridColumn colLV_4_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueCostingCode4;
        private DevExpress.XtraGrid.Columns.GridColumn colLEM_COMP;
        private DevExpress.XtraGrid.Columns.GridColumn colusername1;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_lsa_lotsaleadjustments;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_LotSearch_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ri_teDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueNotEditable;
        private System.Data.SqlClient.SqlDataAdapter da_lotSaleAdj;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private ds_lotSaleAdj ds_lotSaleAdj1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
    }
}
