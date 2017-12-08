namespace LD_LotPayoutAssistant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceCreateInterim = new DevExpress.XtraEditors.CheckEdit();
            this.cePreviousPerDiem = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dePayoutDate = new DevExpress.XtraEditors.DateEdit();
            this.acctYearPeriod1 = new AccountYearPeriod.AcctYearPeriod();
            this.da_selectedLots = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ds_selectedLots1 = new LD_LotPayoutAssistant.ds_selectedLots();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tcPayoutDetails = new DevExpress.XtraTab.XtraTabControl();
            this.tpCashToClose = new DevExpress.XtraTab.XtraTabPage();
            this.gcCashToClose = new DevExpress.XtraGrid.GridControl();
            this.ds_CashToClose1 = new LD_LotPayoutAssistant.ds_CashToClose();
            this.gvCashToClose = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_lotsearch_id2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpAdditionalFees = new DevExpress.XtraTab.XtraTabPage();
            this.gcAdditionalFees = new DevExpress.XtraGrid.GridControl();
            this.ds_AdditionalFees1 = new LD_LotPayoutAssistant.ds_AdditionalFees();
            this.gvAdditionalFees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colworking_ld_lss_AdditionalFees_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_LotSearch_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_seAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colLD_Additional_Fees_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_lueAdditionalFees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bs_lueAdditionalFees = new System.Windows.Forms.BindingSource(this.components);
            this.ds_lueAdditionalFees1 = new LD_LotPayoutAssistant.ds_lueAdditionalFees();
            this.collv1ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level1CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel1Codes1 = new LD_LotPayoutAssistant.dsLevel1Codes();
            this.collv2ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level2CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel2Codes1 = new LD_LotPayoutAssistant.dsLevel2Codes();
            this.collv3ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level3CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel3Codes1 = new LD_LotPayoutAssistant.dsLevel3Codes();
            this.collv4ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.level4CodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLevel4Codes1 = new LD_LotPayoutAssistant.dsLevel4Codes();
            this.colGL_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceDefault = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colPST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpInterest = new DevExpress.XtraTab.XtraTabPage();
            this.gcInterest = new DevExpress.XtraGrid.GridControl();
            this.ds_Interest1 = new LD_LotPayoutAssistant.ds_Interest();
            this.gvInterest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusername2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_LotSearch_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterestRatePct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ri_seNumaric2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colInterestAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colworking_ld_lpa_Interest_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrincipleBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunningInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysInYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactiontype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterestType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompounded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommencement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlIntAdj = new DevExpress.XtraEditors.PanelControl();
            this.teInterestAdj = new DevExpress.XtraEditors.TextEdit();
            this.ceIntAdj = new DevExpress.XtraEditors.CheckEdit();
            this.tpProgramFees = new DevExpress.XtraTab.XtraTabPage();
            this.gcProgramFees = new DevExpress.XtraGrid.GridControl();
            this.workingldlpaProgramFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProgramFees1 = new LD_LotPayoutAssistant.dsProgramFees();
            this.gvProgramFees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAmount3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riseNumber = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colLD_Agreement_ProgramFee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueProgramFees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDProgramFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dslueProgramFees1 = new LD_LotPayoutAssistant.dslueProgramFees();
            this.collv1ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel11 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.collv2ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel21 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.collv3ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel31 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.collv4ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueLevel41 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGL_Account1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGST1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceDefault1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colPST1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLD_ProgramFee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.da_AdditionalFees = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.da_Interest = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.da_lueAdditionalFees = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand5 = new System.Data.SqlClient.SqlCommand();
            this.da_CashToClose = new System.Data.SqlClient.SqlDataAdapter();
            this.daLevel1Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.daLevel2Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.daLevel3Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand6 = new System.Data.SqlClient.SqlCommand();
            this.daLevel4Codes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.daProgramFees = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.dalueProgramFees = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCreateInterim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePreviousPerDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePayoutDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePayoutDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPayoutDetails)).BeginInit();
            this.tcPayoutDetails.SuspendLayout();
            this.tpCashToClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCashToClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CashToClose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashToClose)).BeginInit();
            this.tpAdditionalFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdditionalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_AdditionalFees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdditionalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueAdditionalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueAdditionalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueAdditionalFees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel1Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel2Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel3Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel4Codes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDefault)).BeginInit();
            this.tpInterest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Interest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seNumaric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIntAdj)).BeginInit();
            this.pnlIntAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teInterestAdj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIntAdj.Properties)).BeginInit();
            this.tpProgramFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProgramFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpaProgramFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgramFees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgramFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueProgramFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProgramFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslueProgramFees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDefault1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ceCreateInterim);
            this.panelControl1.Controls.Add(this.cePreviousPerDiem);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dePayoutDate);
            this.panelControl1.Controls.Add(this.acctYearPeriod1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1422, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // ceCreateInterim
            // 
            this.ceCreateInterim.Location = new System.Drawing.Point(768, 12);
            this.ceCreateInterim.Name = "ceCreateInterim";
            this.ceCreateInterim.Properties.Caption = "Create Interim Statement";
            this.ceCreateInterim.Size = new System.Drawing.Size(211, 19);
            this.ceCreateInterim.TabIndex = 4;
            // 
            // cePreviousPerDiem
            // 
            this.cePreviousPerDiem.Location = new System.Drawing.Point(495, 12);
            this.cePreviousPerDiem.Name = "cePreviousPerDiem";
            this.cePreviousPerDiem.Properties.Caption = "Use Previous Statement/Payout Per Diem Interest ";
            this.cePreviousPerDiem.Size = new System.Drawing.Size(367, 19);
            this.cePreviousPerDiem.TabIndex = 3;
            this.cePreviousPerDiem.CheckedChanged += new System.EventHandler(this.deInvoiceDate_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(296, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Payout Date";
            // 
            // dePayoutDate
            // 
            this.dePayoutDate.EditValue = null;
            this.dePayoutDate.Location = new System.Drawing.Point(365, 12);
            this.dePayoutDate.Name = "dePayoutDate";
            this.dePayoutDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePayoutDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePayoutDate.Size = new System.Drawing.Size(100, 20);
            this.dePayoutDate.TabIndex = 1;
            this.dePayoutDate.EditValueChanged += new System.EventHandler(this.deInvoiceDate_EditValueChanged);
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
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
    "True;User ID=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tcPayoutDetails);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 355);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1422, 512);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Lot Payout Details";
            // 
            // tcPayoutDetails
            // 
            this.tcPayoutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPayoutDetails.Location = new System.Drawing.Point(2, 20);
            this.tcPayoutDetails.Name = "tcPayoutDetails";
            this.tcPayoutDetails.SelectedTabPage = this.tpCashToClose;
            this.tcPayoutDetails.Size = new System.Drawing.Size(1418, 490);
            this.tcPayoutDetails.TabIndex = 0;
            this.tcPayoutDetails.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpCashToClose,
            this.tpAdditionalFees,
            this.tpInterest,
            this.tpProgramFees});
            this.tcPayoutDetails.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcPayoutDetails_SelectedPageChanged);
            // 
            // tpCashToClose
            // 
            this.tpCashToClose.Controls.Add(this.gcCashToClose);
            this.tpCashToClose.Name = "tpCashToClose";
            this.tpCashToClose.Size = new System.Drawing.Size(1412, 462);
            this.tpCashToClose.Text = "Cash To Close / Payout";
            // 
            // gcCashToClose
            // 
            this.gcCashToClose.DataMember = "working_ld_lpa_CashToClose";
            this.gcCashToClose.DataSource = this.ds_CashToClose1;
            this.gcCashToClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCashToClose.Location = new System.Drawing.Point(0, 0);
            this.gcCashToClose.MainView = this.gvCashToClose;
            this.gcCashToClose.Name = "gcCashToClose";
            this.gcCashToClose.Size = new System.Drawing.Size(1412, 462);
            this.gcCashToClose.TabIndex = 0;
            this.gcCashToClose.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCashToClose});
            // 
            // ds_CashToClose1
            // 
            this.ds_CashToClose1.DataSetName = "ds_CashToClose";
            this.ds_CashToClose1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCashToClose
            // 
            this.gvCashToClose.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colusername3,
            this.colworking_ld_lotsearch_id2,
            this.colDescription,
            this.colAmount1});
            this.gvCashToClose.GridControl = this.gcCashToClose;
            this.gvCashToClose.Name = "gvCashToClose";
            this.gvCashToClose.OptionsView.ColumnAutoWidth = false;
            this.gvCashToClose.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvCashToClose_CustomRowCellEdit);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername3
            // 
            this.colusername3.FieldName = "username";
            this.colusername3.Name = "colusername3";
            this.colusername3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colworking_ld_lotsearch_id2
            // 
            this.colworking_ld_lotsearch_id2.FieldName = "working_ld_lotsearch_id";
            this.colworking_ld_lotsearch_id2.Name = "colworking_ld_lotsearch_id2";
            this.colworking_ld_lotsearch_id2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 303;
            // 
            // colAmount1
            // 
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.OptionsColumn.AllowEdit = false;
            this.colAmount1.OptionsColumn.ReadOnly = true;
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 1;
            this.colAmount1.Width = 144;
            // 
            // tpAdditionalFees
            // 
            this.tpAdditionalFees.Controls.Add(this.gcAdditionalFees);
            this.tpAdditionalFees.Name = "tpAdditionalFees";
            this.tpAdditionalFees.Size = new System.Drawing.Size(1412, 462);
            this.tpAdditionalFees.Text = "Additional Fees";
            // 
            // gcAdditionalFees
            // 
            this.gcAdditionalFees.DataMember = "working_ld_lpa_AdditionalFees";
            this.gcAdditionalFees.DataSource = this.ds_AdditionalFees1;
            this.gcAdditionalFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAdditionalFees.Location = new System.Drawing.Point(0, 0);
            this.gcAdditionalFees.MainView = this.gvAdditionalFees;
            this.gcAdditionalFees.Name = "gcAdditionalFees";
            this.gcAdditionalFees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_lueAdditionalFees,
            this.ri_seAmount,
            this.riceDefault,
            this.rilueLevel1,
            this.rilueLevel2,
            this.rilueLevel3,
            this.rilueLevel4});
            this.gcAdditionalFees.Size = new System.Drawing.Size(1412, 462);
            this.gcAdditionalFees.TabIndex = 0;
            this.gcAdditionalFees.UseEmbeddedNavigator = true;
            this.gcAdditionalFees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdditionalFees});
            // 
            // ds_AdditionalFees1
            // 
            this.ds_AdditionalFees1.DataSetName = "ds_AdditionalFees";
            this.ds_AdditionalFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAdditionalFees
            // 
            this.gvAdditionalFees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colworking_ld_lss_AdditionalFees_ID,
            this.colusername1,
            this.colworking_ld_LotSearch_ID,
            this.colAmount,
            this.colLD_Additional_Fees_ID,
            this.collv1ID,
            this.collv2ID,
            this.collv3ID,
            this.collv4ID,
            this.colGL_Account,
            this.colGST,
            this.colPST});
            this.gvAdditionalFees.GridControl = this.gcAdditionalFees;
            this.gvAdditionalFees.Name = "gvAdditionalFees";
            this.gvAdditionalFees.OptionsView.ColumnAutoWidth = false;
            this.gvAdditionalFees.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvAdditionalFees_InitNewRow);
            this.gvAdditionalFees.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvAdditionalFees_CellValueChanged);
            this.gvAdditionalFees.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GridsInvalidRow);
            this.gvAdditionalFees.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvAdditionalFees_ValidateRow);
            // 
            // colworking_ld_lss_AdditionalFees_ID
            // 
            this.colworking_ld_lss_AdditionalFees_ID.FieldName = "working_ld_lss_AdditionalFees_ID";
            this.colworking_ld_lss_AdditionalFees_ID.Name = "colworking_ld_lss_AdditionalFees_ID";
            this.colworking_ld_lss_AdditionalFees_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colusername1
            // 
            this.colusername1.FieldName = "username";
            this.colusername1.Name = "colusername1";
            this.colusername1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colworking_ld_LotSearch_ID
            // 
            this.colworking_ld_LotSearch_ID.FieldName = "working_ld_LotSearch_ID";
            this.colworking_ld_LotSearch_ID.Name = "colworking_ld_LotSearch_ID";
            this.colworking_ld_LotSearch_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.ColumnEdit = this.ri_seAmount;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            this.colAmount.Width = 176;
            // 
            // ri_seAmount
            // 
            this.ri_seAmount.AutoHeight = false;
            this.ri_seAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ri_seAmount.Mask.EditMask = "n2";
            this.ri_seAmount.Mask.UseMaskAsDisplayFormat = true;
            this.ri_seAmount.Name = "ri_seAmount";
            // 
            // colLD_Additional_Fees_ID
            // 
            this.colLD_Additional_Fees_ID.Caption = "Description";
            this.colLD_Additional_Fees_ID.ColumnEdit = this.ri_lueAdditionalFees;
            this.colLD_Additional_Fees_ID.FieldName = "LD_Agreement_AdditionalFess_ID";
            this.colLD_Additional_Fees_ID.Name = "colLD_Additional_Fees_ID";
            this.colLD_Additional_Fees_ID.Visible = true;
            this.colLD_Additional_Fees_ID.VisibleIndex = 0;
            this.colLD_Additional_Fees_ID.Width = 242;
            // 
            // ri_lueAdditionalFees
            // 
            this.ri_lueAdditionalFees.AutoHeight = false;
            this.ri_lueAdditionalFees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ri_lueAdditionalFees.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FeeDescription", "Description", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ri_lueAdditionalFees.DataSource = this.bs_lueAdditionalFees;
            this.ri_lueAdditionalFees.DisplayMember = "FeeDescription";
            this.ri_lueAdditionalFees.Name = "ri_lueAdditionalFees";
            this.ri_lueAdditionalFees.NullText = "";
            this.ri_lueAdditionalFees.ValueMember = "ID";
            // 
            // bs_lueAdditionalFees
            // 
            this.bs_lueAdditionalFees.DataMember = "LD_Additional_Fees";
            this.bs_lueAdditionalFees.DataSource = this.ds_lueAdditionalFees1;
            // 
            // ds_lueAdditionalFees1
            // 
            this.ds_lueAdditionalFees1.DataSetName = "ds_lueAdditionalFees";
            this.ds_lueAdditionalFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collv1ID
            // 
            this.collv1ID.Caption = "Level 1";
            this.collv1ID.ColumnEdit = this.rilueLevel1;
            this.collv1ID.FieldName = "lv1ID";
            this.collv1ID.Name = "collv1ID";
            this.collv1ID.OptionsColumn.AllowEdit = false;
            this.collv1ID.Visible = true;
            this.collv1ID.VisibleIndex = 2;
            this.collv1ID.Width = 203;
            // 
            // rilueLevel1
            // 
            this.rilueLevel1.AutoHeight = false;
            this.rilueLevel1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel1.DataSource = this.level1CodesBindingSource;
            this.rilueLevel1.DisplayMember = "Level1";
            this.rilueLevel1.Name = "rilueLevel1";
            this.rilueLevel1.NullText = "";
            this.rilueLevel1.PopupWidth = 500;
            this.rilueLevel1.ValueMember = "lv1ID";
            // 
            // level1CodesBindingSource
            // 
            this.level1CodesBindingSource.DataMember = "Level1_Codes";
            this.level1CodesBindingSource.DataSource = this.dsLevel1Codes1;
            // 
            // dsLevel1Codes1
            // 
            this.dsLevel1Codes1.DataSetName = "dsLevel1Codes";
            this.dsLevel1Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collv2ID
            // 
            this.collv2ID.Caption = "Level 2";
            this.collv2ID.ColumnEdit = this.rilueLevel2;
            this.collv2ID.FieldName = "lv2ID";
            this.collv2ID.Name = "collv2ID";
            this.collv2ID.OptionsColumn.AllowEdit = false;
            this.collv2ID.Visible = true;
            this.collv2ID.VisibleIndex = 3;
            this.collv2ID.Width = 153;
            // 
            // rilueLevel2
            // 
            this.rilueLevel2.AutoHeight = false;
            this.rilueLevel2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel2.DataSource = this.level2CodesBindingSource;
            this.rilueLevel2.DisplayMember = "Level2";
            this.rilueLevel2.Name = "rilueLevel2";
            this.rilueLevel2.NullText = "";
            this.rilueLevel2.PopupWidth = 500;
            this.rilueLevel2.ValueMember = "lv2ID";
            // 
            // level2CodesBindingSource
            // 
            this.level2CodesBindingSource.DataMember = "Level2_Codes";
            this.level2CodesBindingSource.DataSource = this.dsLevel2Codes1;
            // 
            // dsLevel2Codes1
            // 
            this.dsLevel2Codes1.DataSetName = "dsLevel2Codes";
            this.dsLevel2Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collv3ID
            // 
            this.collv3ID.Caption = "Level 3";
            this.collv3ID.ColumnEdit = this.rilueLevel3;
            this.collv3ID.FieldName = "lv3ID";
            this.collv3ID.Name = "collv3ID";
            this.collv3ID.OptionsColumn.AllowEdit = false;
            this.collv3ID.Visible = true;
            this.collv3ID.VisibleIndex = 4;
            this.collv3ID.Width = 149;
            // 
            // rilueLevel3
            // 
            this.rilueLevel3.AutoHeight = false;
            this.rilueLevel3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel3.DataSource = this.level3CodesBindingSource;
            this.rilueLevel3.DisplayMember = "Level3";
            this.rilueLevel3.Name = "rilueLevel3";
            this.rilueLevel3.NullText = "";
            this.rilueLevel3.PopupWidth = 500;
            this.rilueLevel3.ValueMember = "lv3ID";
            // 
            // level3CodesBindingSource
            // 
            this.level3CodesBindingSource.DataMember = "Level3_Codes";
            this.level3CodesBindingSource.DataSource = this.dsLevel3Codes1;
            // 
            // dsLevel3Codes1
            // 
            this.dsLevel3Codes1.DataSetName = "dsLevel3Codes";
            this.dsLevel3Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collv4ID
            // 
            this.collv4ID.Caption = "Level 4";
            this.collv4ID.ColumnEdit = this.rilueLevel4;
            this.collv4ID.FieldName = "lv4ID";
            this.collv4ID.Name = "collv4ID";
            this.collv4ID.OptionsColumn.AllowEdit = false;
            this.collv4ID.Visible = true;
            this.collv4ID.VisibleIndex = 5;
            this.collv4ID.Width = 149;
            // 
            // rilueLevel4
            // 
            this.rilueLevel4.AutoHeight = false;
            this.rilueLevel4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel4.DataSource = this.level4CodesBindingSource;
            this.rilueLevel4.DisplayMember = "lv4ID";
            this.rilueLevel4.Name = "rilueLevel4";
            this.rilueLevel4.NullText = "";
            this.rilueLevel4.PopupWidth = 500;
            this.rilueLevel4.ValueMember = "lv4ID";
            // 
            // level4CodesBindingSource
            // 
            this.level4CodesBindingSource.DataMember = "Level4_Codes";
            this.level4CodesBindingSource.DataSource = this.dsLevel4Codes1;
            // 
            // dsLevel4Codes1
            // 
            this.dsLevel4Codes1.DataSetName = "dsLevel4Codes";
            this.dsLevel4Codes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colGL_Account
            // 
            this.colGL_Account.Caption = "GL Account";
            this.colGL_Account.FieldName = "GL_Account";
            this.colGL_Account.Name = "colGL_Account";
            this.colGL_Account.OptionsColumn.AllowEdit = false;
            this.colGL_Account.Visible = true;
            this.colGL_Account.VisibleIndex = 6;
            this.colGL_Account.Width = 121;
            // 
            // colGST
            // 
            this.colGST.Caption = "GST";
            this.colGST.ColumnEdit = this.riceDefault;
            this.colGST.FieldName = "GST";
            this.colGST.Name = "colGST";
            this.colGST.OptionsColumn.AllowEdit = false;
            this.colGST.Visible = true;
            this.colGST.VisibleIndex = 7;
            // 
            // riceDefault
            // 
            this.riceDefault.AutoHeight = false;
            this.riceDefault.Name = "riceDefault";
            this.riceDefault.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colPST
            // 
            this.colPST.Caption = "PST";
            this.colPST.ColumnEdit = this.riceDefault;
            this.colPST.FieldName = "PST";
            this.colPST.Name = "colPST";
            this.colPST.OptionsColumn.AllowEdit = false;
            this.colPST.Visible = true;
            this.colPST.VisibleIndex = 8;
            // 
            // tpInterest
            // 
            this.tpInterest.Controls.Add(this.gcInterest);
            this.tpInterest.Controls.Add(this.pnlIntAdj);
            this.tpInterest.Name = "tpInterest";
            this.tpInterest.Size = new System.Drawing.Size(1412, 462);
            this.tpInterest.Text = "Interest";
            // 
            // gcInterest
            // 
            this.gcInterest.DataMember = "working_ld_lpa_Interest";
            this.gcInterest.DataSource = this.ds_Interest1;
            this.gcInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInterest.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcInterest.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcInterest.Location = new System.Drawing.Point(0, 37);
            this.gcInterest.MainView = this.gvInterest;
            this.gcInterest.Name = "gcInterest";
            this.gcInterest.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ri_seNumaric2});
            this.gcInterest.Size = new System.Drawing.Size(1412, 425);
            this.gcInterest.TabIndex = 0;
            this.gcInterest.UseEmbeddedNavigator = true;
            this.gcInterest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInterest});
            // 
            // ds_Interest1
            // 
            this.ds_Interest1.DataSetName = "ds_Interest";
            this.ds_Interest1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvInterest
            // 
            this.gvInterest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusername2,
            this.colworking_ld_LotSearch_ID1,
            this.colFromDate,
            this.colToDate,
            this.colInterestRatePct,
            this.colInterestAmount,
            this.colworking_ld_lpa_Interest_ID,
            this.colPrincipleBalance,
            this.colRunningInterest,
            this.colPerDiem,
            this.colDays,
            this.colDaysInYear,
            this.colTransactiontype,
            this.colInterestType,
            this.colCompounded,
            this.colCommencement,
            this.colAmount2});
            this.gvInterest.GridControl = this.gcInterest;
            this.gvInterest.Name = "gvInterest";
            this.gvInterest.OptionsBehavior.Editable = false;
            this.gvInterest.OptionsView.ColumnAutoWidth = false;
            this.gvInterest.OptionsView.ShowFooter = true;
            this.gvInterest.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GridsInvalidRow);
            // 
            // colusername2
            // 
            this.colusername2.FieldName = "username";
            this.colusername2.Name = "colusername2";
            this.colusername2.OptionsColumn.ShowInCustomizationForm = false;
            this.colusername2.Width = 59;
            // 
            // colworking_ld_LotSearch_ID1
            // 
            this.colworking_ld_LotSearch_ID1.FieldName = "working_ld_LotSearch_ID";
            this.colworking_ld_LotSearch_ID1.Name = "colworking_ld_LotSearch_ID1";
            this.colworking_ld_LotSearch_ID1.OptionsColumn.ShowInCustomizationForm = false;
            this.colworking_ld_LotSearch_ID1.Width = 137;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 0;
            this.colFromDate.Width = 72;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 1;
            this.colToDate.Width = 68;
            // 
            // colInterestRatePct
            // 
            this.colInterestRatePct.Caption = "Interest %";
            this.colInterestRatePct.ColumnEdit = this.ri_seNumaric2;
            this.colInterestRatePct.FieldName = "InterestRatePct";
            this.colInterestRatePct.Name = "colInterestRatePct";
            this.colInterestRatePct.Visible = true;
            this.colInterestRatePct.VisibleIndex = 4;
            // 
            // ri_seNumaric2
            // 
            this.ri_seNumaric2.AutoHeight = false;
            this.ri_seNumaric2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ri_seNumaric2.Mask.EditMask = "n2";
            this.ri_seNumaric2.Mask.UseMaskAsDisplayFormat = true;
            this.ri_seNumaric2.Name = "ri_seNumaric2";
            // 
            // colInterestAmount
            // 
            this.colInterestAmount.ColumnEdit = this.ri_seNumaric2;
            this.colInterestAmount.FieldName = "InterestAmount";
            this.colInterestAmount.Name = "colInterestAmount";
            this.colInterestAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InterestAmount", "{0:n2}")});
            this.colInterestAmount.Visible = true;
            this.colInterestAmount.VisibleIndex = 7;
            this.colInterestAmount.Width = 101;
            // 
            // colworking_ld_lpa_Interest_ID
            // 
            this.colworking_ld_lpa_Interest_ID.FieldName = "working_ld_lpa_Interest_ID";
            this.colworking_ld_lpa_Interest_ID.Name = "colworking_ld_lpa_Interest_ID";
            this.colworking_ld_lpa_Interest_ID.OptionsColumn.ReadOnly = true;
            this.colworking_ld_lpa_Interest_ID.OptionsColumn.ShowInCustomizationForm = false;
            this.colworking_ld_lpa_Interest_ID.Width = 145;
            // 
            // colPrincipleBalance
            // 
            this.colPrincipleBalance.Caption = "Principal Balance";
            this.colPrincipleBalance.ColumnEdit = this.ri_seNumaric2;
            this.colPrincipleBalance.FieldName = "PrincipleBalance";
            this.colPrincipleBalance.Name = "colPrincipleBalance";
            this.colPrincipleBalance.Visible = true;
            this.colPrincipleBalance.VisibleIndex = 6;
            this.colPrincipleBalance.Width = 101;
            // 
            // colRunningInterest
            // 
            this.colRunningInterest.ColumnEdit = this.ri_seNumaric2;
            this.colRunningInterest.FieldName = "RunningInterest";
            this.colRunningInterest.Name = "colRunningInterest";
            this.colRunningInterest.Visible = true;
            this.colRunningInterest.VisibleIndex = 8;
            this.colRunningInterest.Width = 103;
            // 
            // colPerDiem
            // 
            this.colPerDiem.ColumnEdit = this.ri_seNumaric2;
            this.colPerDiem.FieldName = "PerDiem";
            this.colPerDiem.Name = "colPerDiem";
            this.colPerDiem.Visible = true;
            this.colPerDiem.VisibleIndex = 9;
            this.colPerDiem.Width = 64;
            // 
            // colDays
            // 
            this.colDays.FieldName = "Days";
            this.colDays.Name = "colDays";
            this.colDays.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Days", "{0:n0}")});
            this.colDays.Visible = true;
            this.colDays.VisibleIndex = 10;
            this.colDays.Width = 46;
            // 
            // colDaysInYear
            // 
            this.colDaysInYear.FieldName = "DaysInYear";
            this.colDaysInYear.Name = "colDaysInYear";
            this.colDaysInYear.Visible = true;
            this.colDaysInYear.VisibleIndex = 11;
            this.colDaysInYear.Width = 84;
            // 
            // colTransactiontype
            // 
            this.colTransactiontype.Caption = "Transaction Type";
            this.colTransactiontype.FieldName = "Transactiontype";
            this.colTransactiontype.Name = "colTransactiontype";
            this.colTransactiontype.Visible = true;
            this.colTransactiontype.VisibleIndex = 2;
            this.colTransactiontype.Width = 105;
            // 
            // colInterestType
            // 
            this.colInterestType.FieldName = "InterestType";
            this.colInterestType.Name = "colInterestType";
            this.colInterestType.Visible = true;
            this.colInterestType.VisibleIndex = 3;
            this.colInterestType.Width = 88;
            // 
            // colCompounded
            // 
            this.colCompounded.FieldName = "Compounded";
            this.colCompounded.Name = "colCompounded";
            this.colCompounded.Visible = true;
            this.colCompounded.VisibleIndex = 12;
            this.colCompounded.Width = 85;
            // 
            // colCommencement
            // 
            this.colCommencement.FieldName = "Commencement";
            this.colCommencement.Name = "colCommencement";
            this.colCommencement.Visible = true;
            this.colCommencement.VisibleIndex = 13;
            this.colCommencement.Width = 98;
            // 
            // colAmount2
            // 
            this.colAmount2.ColumnEdit = this.ri_seNumaric2;
            this.colAmount2.FieldName = "Amount";
            this.colAmount2.Name = "colAmount2";
            this.colAmount2.Visible = true;
            this.colAmount2.VisibleIndex = 5;
            this.colAmount2.Width = 99;
            // 
            // pnlIntAdj
            // 
            this.pnlIntAdj.Controls.Add(this.teInterestAdj);
            this.pnlIntAdj.Controls.Add(this.ceIntAdj);
            this.pnlIntAdj.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIntAdj.Location = new System.Drawing.Point(0, 0);
            this.pnlIntAdj.Name = "pnlIntAdj";
            this.pnlIntAdj.Size = new System.Drawing.Size(1412, 37);
            this.pnlIntAdj.TabIndex = 1;
            // 
            // teInterestAdj
            // 
            this.teInterestAdj.Location = new System.Drawing.Point(211, 8);
            this.teInterestAdj.Name = "teInterestAdj";
            this.teInterestAdj.Properties.Mask.EditMask = "n";
            this.teInterestAdj.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teInterestAdj.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teInterestAdj.Size = new System.Drawing.Size(100, 20);
            this.teInterestAdj.TabIndex = 1;
            // 
            // ceIntAdj
            // 
            this.ceIntAdj.Location = new System.Drawing.Point(17, 9);
            this.ceIntAdj.Name = "ceIntAdj";
            this.ceIntAdj.Properties.Caption = "Lot Payout Interest Adjustment";
            this.ceIntAdj.Size = new System.Drawing.Size(187, 19);
            this.ceIntAdj.TabIndex = 0;
            this.ceIntAdj.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ceIntAdj_EditValueChanging);
            // 
            // tpProgramFees
            // 
            this.tpProgramFees.Controls.Add(this.gcProgramFees);
            this.tpProgramFees.Name = "tpProgramFees";
            this.tpProgramFees.Size = new System.Drawing.Size(1412, 462);
            this.tpProgramFees.Text = "Program Fees";
            // 
            // gcProgramFees
            // 
            this.gcProgramFees.DataMember = null;
            this.gcProgramFees.DataSource = this.workingldlpaProgramFeesBindingSource;
            this.gcProgramFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProgramFees.Location = new System.Drawing.Point(0, 0);
            this.gcProgramFees.MainView = this.gvProgramFees;
            this.gcProgramFees.Name = "gcProgramFees";
            this.gcProgramFees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueProgramFees,
            this.riseNumber,
            this.riceDefault1,
            this.rilueLevel11,
            this.rilueLevel21,
            this.rilueLevel31,
            this.rilueLevel41});
            this.gcProgramFees.Size = new System.Drawing.Size(1412, 462);
            this.gcProgramFees.TabIndex = 1;
            this.gcProgramFees.UseEmbeddedNavigator = true;
            this.gcProgramFees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProgramFees});
            // 
            // workingldlpaProgramFeesBindingSource
            // 
            this.workingldlpaProgramFeesBindingSource.DataMember = "working_ld_lpa_ProgramFees";
            this.workingldlpaProgramFeesBindingSource.DataSource = this.dsProgramFees1;
            // 
            // dsProgramFees1
            // 
            this.dsProgramFees1.DataSetName = "dsProgramFees";
            this.dsProgramFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProgramFees
            // 
            this.gvProgramFees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAmount3,
            this.colLD_Agreement_ProgramFee_ID,
            this.collv1ID1,
            this.collv2ID1,
            this.collv3ID1,
            this.collv4ID1,
            this.colGL_Account1,
            this.colGST1,
            this.colPST1,
            this.colLD_ProgramFee_ID});
            this.gvProgramFees.GridControl = this.gcProgramFees;
            this.gvProgramFees.Name = "gvProgramFees";
            this.gvProgramFees.OptionsView.ColumnAutoWidth = false;
            this.gvProgramFees.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvProgramFees_InitNewRow);
            this.gvProgramFees.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvProgramFees_CellValueChanged);
            this.gvProgramFees.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GridsInvalidRow);
            this.gvProgramFees.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvProgramFees_ValidateRow);
            // 
            // colAmount3
            // 
            this.colAmount3.Caption = "Amount";
            this.colAmount3.ColumnEdit = this.riseNumber;
            this.colAmount3.FieldName = "Amount";
            this.colAmount3.Name = "colAmount3";
            this.colAmount3.Visible = true;
            this.colAmount3.VisibleIndex = 1;
            this.colAmount3.Width = 176;
            // 
            // riseNumber
            // 
            this.riseNumber.AutoHeight = false;
            this.riseNumber.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riseNumber.Mask.EditMask = "n2";
            this.riseNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riseNumber.Name = "riseNumber";
            // 
            // colLD_Agreement_ProgramFee_ID
            // 
            this.colLD_Agreement_ProgramFee_ID.Caption = "Description";
            this.colLD_Agreement_ProgramFee_ID.ColumnEdit = this.rilueProgramFees;
            this.colLD_Agreement_ProgramFee_ID.FieldName = "LD_Agreement_ProgramFee_ID";
            this.colLD_Agreement_ProgramFee_ID.Name = "colLD_Agreement_ProgramFee_ID";
            this.colLD_Agreement_ProgramFee_ID.Visible = true;
            this.colLD_Agreement_ProgramFee_ID.VisibleIndex = 0;
            this.colLD_Agreement_ProgramFee_ID.Width = 242;
            // 
            // rilueProgramFees
            // 
            this.rilueProgramFees.AutoHeight = false;
            this.rilueProgramFees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueProgramFees.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueProgramFees.DataSource = this.lDProgramFeesBindingSource;
            this.rilueProgramFees.DisplayMember = "Description";
            this.rilueProgramFees.Name = "rilueProgramFees";
            this.rilueProgramFees.NullText = "";
            this.rilueProgramFees.ValueMember = "ID";
            // 
            // lDProgramFeesBindingSource
            // 
            this.lDProgramFeesBindingSource.DataMember = "LD_ProgramFees";
            this.lDProgramFeesBindingSource.DataSource = this.dslueProgramFees1;
            // 
            // dslueProgramFees1
            // 
            this.dslueProgramFees1.DataSetName = "dslueProgramFees";
            this.dslueProgramFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collv1ID1
            // 
            this.collv1ID1.Caption = "Level 1";
            this.collv1ID1.ColumnEdit = this.rilueLevel11;
            this.collv1ID1.FieldName = "lv1ID";
            this.collv1ID1.Name = "collv1ID1";
            this.collv1ID1.OptionsColumn.AllowEdit = false;
            this.collv1ID1.Visible = true;
            this.collv1ID1.VisibleIndex = 2;
            this.collv1ID1.Width = 203;
            // 
            // rilueLevel11
            // 
            this.rilueLevel11.AutoHeight = false;
            this.rilueLevel11.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel11.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv1_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel11.DataSource = this.level1CodesBindingSource;
            this.rilueLevel11.DisplayMember = "Level1";
            this.rilueLevel11.Name = "rilueLevel11";
            this.rilueLevel11.NullText = "";
            this.rilueLevel11.PopupWidth = 500;
            this.rilueLevel11.ValueMember = "lv1ID";
            // 
            // collv2ID1
            // 
            this.collv2ID1.Caption = "Level 2";
            this.collv2ID1.ColumnEdit = this.rilueLevel21;
            this.collv2ID1.FieldName = "lv2ID";
            this.collv2ID1.Name = "collv2ID1";
            this.collv2ID1.OptionsColumn.AllowEdit = false;
            this.collv2ID1.Visible = true;
            this.collv2ID1.VisibleIndex = 3;
            this.collv2ID1.Width = 153;
            // 
            // rilueLevel21
            // 
            this.rilueLevel21.AutoHeight = false;
            this.rilueLevel21.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel21.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv2_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel21.DataSource = this.level2CodesBindingSource;
            this.rilueLevel21.DisplayMember = "Level2";
            this.rilueLevel21.Name = "rilueLevel21";
            this.rilueLevel21.NullText = "";
            this.rilueLevel21.PopupWidth = 500;
            this.rilueLevel21.ValueMember = "lv2ID";
            // 
            // collv3ID1
            // 
            this.collv3ID1.Caption = "Level 3";
            this.collv3ID1.ColumnEdit = this.rilueLevel31;
            this.collv3ID1.FieldName = "lv3ID";
            this.collv3ID1.Name = "collv3ID1";
            this.collv3ID1.OptionsColumn.AllowEdit = false;
            this.collv3ID1.Visible = true;
            this.collv3ID1.VisibleIndex = 4;
            this.collv3ID1.Width = 149;
            // 
            // rilueLevel31
            // 
            this.rilueLevel31.AutoHeight = false;
            this.rilueLevel31.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel31.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv3_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel31.DataSource = this.level3CodesBindingSource;
            this.rilueLevel31.DisplayMember = "Level3";
            this.rilueLevel31.Name = "rilueLevel31";
            this.rilueLevel31.NullText = "";
            this.rilueLevel31.PopupWidth = 500;
            this.rilueLevel31.ValueMember = "lv3ID";
            // 
            // collv4ID1
            // 
            this.collv4ID1.Caption = "Level 4";
            this.collv4ID1.ColumnEdit = this.rilueLevel41;
            this.collv4ID1.FieldName = "lv4ID";
            this.collv4ID1.Name = "collv4ID1";
            this.collv4ID1.OptionsColumn.AllowEdit = false;
            this.collv4ID1.Visible = true;
            this.collv4ID1.VisibleIndex = 5;
            this.collv4ID1.Width = 149;
            // 
            // rilueLevel41
            // 
            this.rilueLevel41.AutoHeight = false;
            this.rilueLevel41.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueLevel41.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_code", "Code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lv4_desc", "Description", 425, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueLevel41.DataSource = this.level4CodesBindingSource;
            this.rilueLevel41.DisplayMember = "lv4ID";
            this.rilueLevel41.Name = "rilueLevel41";
            this.rilueLevel41.NullText = "";
            this.rilueLevel41.PopupWidth = 500;
            this.rilueLevel41.ValueMember = "lv4ID";
            // 
            // colGL_Account1
            // 
            this.colGL_Account1.Caption = "GL Account";
            this.colGL_Account1.FieldName = "GL_Account";
            this.colGL_Account1.Name = "colGL_Account1";
            this.colGL_Account1.OptionsColumn.AllowEdit = false;
            this.colGL_Account1.Visible = true;
            this.colGL_Account1.VisibleIndex = 6;
            this.colGL_Account1.Width = 121;
            // 
            // colGST1
            // 
            this.colGST1.Caption = "GST";
            this.colGST1.ColumnEdit = this.riceDefault1;
            this.colGST1.FieldName = "GST";
            this.colGST1.Name = "colGST1";
            this.colGST1.OptionsColumn.AllowEdit = false;
            this.colGST1.Visible = true;
            this.colGST1.VisibleIndex = 7;
            // 
            // riceDefault1
            // 
            this.riceDefault1.AutoHeight = false;
            this.riceDefault1.Name = "riceDefault1";
            this.riceDefault1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colPST1
            // 
            this.colPST1.Caption = "PST";
            this.colPST1.ColumnEdit = this.riceDefault1;
            this.colPST1.FieldName = "PST";
            this.colPST1.Name = "colPST1";
            this.colPST1.OptionsColumn.AllowEdit = false;
            this.colPST1.Visible = true;
            this.colPST1.VisibleIndex = 8;
            // 
            // colLD_ProgramFee_ID
            // 
            this.colLD_ProgramFee_ID.FieldName = "LD_ProgramFee_ID";
            this.colLD_ProgramFee_ID.Name = "colLD_ProgramFee_ID";
            this.colLD_ProgramFee_ID.OptionsColumn.ShowInCustomizationForm = false;
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
            this.gcReview.Location = new System.Drawing.Point(0, 40);
            this.gcReview.MainView = this.gvReview;
            this.gcReview.Name = "gcReview";
            this.gcReview.Size = new System.Drawing.Size(1422, 310);
            this.gcReview.TabIndex = 4;
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
            this.collot_class_code.VisibleIndex = 4;
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
            this.collot_sub_class_code.VisibleIndex = 5;
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
            this.colplan_num.VisibleIndex = 6;
            this.colplan_num.Width = 65;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 7;
            this.colblock_num.Width = 73;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 8;
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
            this.colfrontage.VisibleIndex = 9;
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
            this.colcurrent_price.VisibleIndex = 10;
            this.colcurrent_price.Width = 85;
            // 
            // collot_status
            // 
            this.collot_status.Caption = "Status";
            this.collot_status.FieldName = "lot_status";
            this.collot_status.Name = "collot_status";
            this.collot_status.OptionsColumn.AllowEdit = false;
            this.collot_status.Visible = true;
            this.collot_status.VisibleIndex = 11;
            this.collot_status.Width = 80;
            // 
            // collot_sub_status
            // 
            this.collot_sub_status.Caption = "Sub Status";
            this.collot_sub_status.FieldName = "lot_sub_status";
            this.collot_sub_status.Name = "collot_sub_status";
            this.collot_sub_status.OptionsColumn.AllowEdit = false;
            this.collot_sub_status.Visible = true;
            this.collot_sub_status.VisibleIndex = 12;
            this.collot_sub_status.Width = 93;
            // 
            // coltitle_number
            // 
            this.coltitle_number.Caption = "Title";
            this.coltitle_number.FieldName = "title_number";
            this.coltitle_number.Name = "coltitle_number";
            this.coltitle_number.OptionsColumn.AllowEdit = false;
            this.coltitle_number.Visible = true;
            this.coltitle_number.VisibleIndex = 13;
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
            this.colPurchaser_Name.Visible = true;
            this.colPurchaser_Name.VisibleIndex = 3;
            this.colPurchaser_Name.Width = 141;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 350);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1422, 5);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTRConnection;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 4, "working_ld_LotSearch_ID")});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlTRConnection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, "LD_Additional_Fees_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, "LD_Agreement_AdditionalFess_ID"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 0, "lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 0, "GL_Account"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, "LD_Additional_Fees_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, "LD_Agreement_AdditionalFess_ID"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 0, "lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 0, "GL_Account"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST"),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lss_AdditionalFees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lss_AdditionalFees_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Additional_Fees_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Additional_Fees_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Agreement_AdditionalFess_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Agreement_AdditionalFess_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Account", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@working_ld_lss_AdditionalFees_ID", System.Data.SqlDbType.Int, 4, "working_ld_lss_AdditionalFees_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lss_AdditionalFees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lss_AdditionalFees_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Additional_Fees_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Additional_Fees_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Additional_Fees_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Agreement_AdditionalFess_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Agreement_AdditionalFess_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Agreement_AdditionalFess_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Account", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null)});
            // 
            // da_AdditionalFees
            // 
            this.da_AdditionalFees.DeleteCommand = this.sqlDeleteCommand2;
            this.da_AdditionalFees.InsertCommand = this.sqlInsertCommand2;
            this.da_AdditionalFees.SelectCommand = this.sqlSelectCommand2;
            this.da_AdditionalFees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpa_AdditionalFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("working_ld_lss_AdditionalFees_ID", "working_ld_lss_AdditionalFees_ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("working_ld_LotSearch_ID", "working_ld_LotSearch_ID"),
                        new System.Data.Common.DataColumnMapping("LD_Additional_Fees_ID", "LD_Additional_Fees_ID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("LD_Agreement_AdditionalFess_ID", "LD_Agreement_AdditionalFess_ID"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"),
                        new System.Data.Common.DataColumnMapping("GST", "GST"),
                        new System.Data.Common.DataColumnMapping("PST", "PST")})});
            this.da_AdditionalFees.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTRConnection;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 4, "working_ld_LotSearch_ID")});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlTRConnection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.DateTime, 0, "FromDate"),
            new System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.DateTime, 0, "ToDate"),
            new System.Data.SqlClient.SqlParameter("@InterestRatePct", System.Data.SqlDbType.Money, 0, "InterestRatePct"),
            new System.Data.SqlClient.SqlParameter("@InterestAmount", System.Data.SqlDbType.Money, 0, "InterestAmount"),
            new System.Data.SqlClient.SqlParameter("@PrincipleBalance", System.Data.SqlDbType.Money, 0, "PrincipleBalance"),
            new System.Data.SqlClient.SqlParameter("@RunningInterest", System.Data.SqlDbType.Money, 0, "RunningInterest"),
            new System.Data.SqlClient.SqlParameter("@PerDiem", System.Data.SqlDbType.Money, 0, "PerDiem"),
            new System.Data.SqlClient.SqlParameter("@Days", System.Data.SqlDbType.Int, 0, "Days"),
            new System.Data.SqlClient.SqlParameter("@DaysInYear", System.Data.SqlDbType.Int, 0, "DaysInYear"),
            new System.Data.SqlClient.SqlParameter("@Transactiontype", System.Data.SqlDbType.VarChar, 0, "Transactiontype"),
            new System.Data.SqlClient.SqlParameter("@InterestType", System.Data.SqlDbType.VarChar, 0, "InterestType"),
            new System.Data.SqlClient.SqlParameter("@Compounded", System.Data.SqlDbType.Bit, 0, "Compounded"),
            new System.Data.SqlClient.SqlParameter("@Commencement", System.Data.SqlDbType.VarChar, 0, "Commencement"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.DateTime, 0, "FromDate"),
            new System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.DateTime, 0, "ToDate"),
            new System.Data.SqlClient.SqlParameter("@InterestRatePct", System.Data.SqlDbType.Money, 0, "InterestRatePct"),
            new System.Data.SqlClient.SqlParameter("@InterestAmount", System.Data.SqlDbType.Money, 0, "InterestAmount"),
            new System.Data.SqlClient.SqlParameter("@PrincipleBalance", System.Data.SqlDbType.Money, 0, "PrincipleBalance"),
            new System.Data.SqlClient.SqlParameter("@RunningInterest", System.Data.SqlDbType.Money, 0, "RunningInterest"),
            new System.Data.SqlClient.SqlParameter("@PerDiem", System.Data.SqlDbType.Money, 0, "PerDiem"),
            new System.Data.SqlClient.SqlParameter("@Days", System.Data.SqlDbType.Int, 0, "Days"),
            new System.Data.SqlClient.SqlParameter("@DaysInYear", System.Data.SqlDbType.Int, 0, "DaysInYear"),
            new System.Data.SqlClient.SqlParameter("@Transactiontype", System.Data.SqlDbType.VarChar, 0, "Transactiontype"),
            new System.Data.SqlClient.SqlParameter("@InterestType", System.Data.SqlDbType.VarChar, 0, "InterestType"),
            new System.Data.SqlClient.SqlParameter("@Compounded", System.Data.SqlDbType.Bit, 0, "Compounded"),
            new System.Data.SqlClient.SqlParameter("@Commencement", System.Data.SqlDbType.VarChar, 0, "Commencement"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FromDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FromDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FromDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FromDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ToDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestRatePct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestRatePct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestRatePct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestRatePct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lpa_Interest_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lpa_Interest_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PrincipleBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrincipleBalance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PrincipleBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrincipleBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RunningInterest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RunningInterest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RunningInterest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RunningInterest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PerDiem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PerDiem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PerDiem", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PerDiem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Days", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DaysInYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DaysInYear", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DaysInYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DaysInYear", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Transactiontype", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Transactiontype", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Transactiontype", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Transactiontype", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Compounded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Compounded", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Compounded", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Compounded", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Commencement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Commencement", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Commencement", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commencement", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@working_ld_lpa_Interest_ID", System.Data.SqlDbType.Int, 4, "working_ld_lpa_Interest_ID")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FromDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FromDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FromDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FromDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ToDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestRatePct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestRatePct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestRatePct", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestRatePct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestAmount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestAmount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestAmount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lpa_Interest_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lpa_Interest_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PrincipleBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrincipleBalance", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PrincipleBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrincipleBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RunningInterest", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RunningInterest", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RunningInterest", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RunningInterest", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PerDiem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PerDiem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PerDiem", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PerDiem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Days", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Days", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Days", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DaysInYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DaysInYear", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DaysInYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DaysInYear", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Transactiontype", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Transactiontype", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Transactiontype", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Transactiontype", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InterestType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InterestType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InterestType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InterestType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Compounded", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Compounded", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Compounded", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Compounded", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Commencement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Commencement", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Commencement", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commencement", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // da_Interest
            // 
            this.da_Interest.DeleteCommand = this.sqlDeleteCommand3;
            this.da_Interest.InsertCommand = this.sqlInsertCommand3;
            this.da_Interest.SelectCommand = this.sqlSelectCommand3;
            this.da_Interest.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpa_Interest", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("working_ld_LotSearch_ID", "working_ld_LotSearch_ID"),
                        new System.Data.Common.DataColumnMapping("FromDate", "FromDate"),
                        new System.Data.Common.DataColumnMapping("ToDate", "ToDate"),
                        new System.Data.Common.DataColumnMapping("InterestRatePct", "InterestRatePct"),
                        new System.Data.Common.DataColumnMapping("InterestAmount", "InterestAmount"),
                        new System.Data.Common.DataColumnMapping("working_ld_lpa_Interest_ID", "working_ld_lpa_Interest_ID"),
                        new System.Data.Common.DataColumnMapping("PrincipleBalance", "PrincipleBalance"),
                        new System.Data.Common.DataColumnMapping("RunningInterest", "RunningInterest"),
                        new System.Data.Common.DataColumnMapping("PerDiem", "PerDiem"),
                        new System.Data.Common.DataColumnMapping("Days", "Days"),
                        new System.Data.Common.DataColumnMapping("DaysInYear", "DaysInYear"),
                        new System.Data.Common.DataColumnMapping("Transactiontype", "Transactiontype"),
                        new System.Data.Common.DataColumnMapping("InterestType", "InterestType"),
                        new System.Data.Common.DataColumnMapping("Compounded", "Compounded"),
                        new System.Data.Common.DataColumnMapping("Commencement", "Commencement"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            this.da_Interest.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlTRConnection;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "Agreement_ID")});
            // 
            // da_lueAdditionalFees
            // 
            this.da_lueAdditionalFees.SelectCommand = this.sqlSelectCommand4;
            this.da_lueAdditionalFees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Additional_Fees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Additional_Fees_ID", "Additional_Fees_ID"),
                        new System.Data.Common.DataColumnMapping("FeeDescription", "FeeDescription"),
                        new System.Data.Common.DataColumnMapping("ID", "ID")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlTRConnection;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 4, "working_ld_lotsearch_id")});
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = resources.GetString("sqlInsertCommand5.CommandText");
            this.sqlInsertCommand5.Connection = this.sqlTRConnection;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, "working_ld_lotsearch_id"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount")});
            // 
            // sqlUpdateCommand5
            // 
            this.sqlUpdateCommand5.CommandText = resources.GetString("sqlUpdateCommand5.CommandText");
            this.sqlUpdateCommand5.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, "working_ld_lotsearch_id"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_lotsearch_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lotsearch_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand5
            // 
            this.sqlDeleteCommand5.CommandText = resources.GetString("sqlDeleteCommand5.CommandText");
            this.sqlDeleteCommand5.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_lotsearch_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_lotsearch_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_lotsearch_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // da_CashToClose
            // 
            this.da_CashToClose.DeleteCommand = this.sqlDeleteCommand5;
            this.da_CashToClose.InsertCommand = this.sqlInsertCommand5;
            this.da_CashToClose.SelectCommand = this.sqlSelectCommand5;
            this.da_CashToClose.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpa_CashToClose", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("working_ld_lotsearch_id", "working_ld_lotsearch_id"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            this.da_CashToClose.UpdateCommand = this.sqlUpdateCommand5;
            // 
            // daLevel1Codes
            // 
            this.daLevel1Codes.DeleteCommand = this.sqlCommand1;
            this.daLevel1Codes.InsertCommand = this.sqlCommand2;
            this.daLevel1Codes.SelectCommand = this.sqlCommand3;
            this.daLevel1Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level1_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv1_code", "lv1_code"),
                        new System.Data.Common.DataColumnMapping("lv1_desc", "lv1_desc"),
                        new System.Data.Common.DataColumnMapping("Level1", "Level1")})});
            this.daLevel1Codes.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlTRConnection;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlTRConnection;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     lv1ID, lv1_code, lv1_desc, lv1_code + \' \' + lv1_desc AS Level1\r\nFROM  " +
    "       Level1_Codes\r\nWHERE     (ProjType = \'L\')\r\nORDER BY lv1_code";
            this.sqlCommand3.Connection = this.sqlTRConnection;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlTRConnection;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv1_code", System.Data.SqlDbType.VarChar, 0, "lv1_code"),
            new System.Data.SqlClient.SqlParameter("@lv1_desc", System.Data.SqlDbType.VarChar, 0, "lv1_desc"),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 4, "lv1ID")});
            // 
            // daLevel2Codes
            // 
            this.daLevel2Codes.DeleteCommand = this.sqlCommand5;
            this.daLevel2Codes.InsertCommand = this.sqlCommand6;
            this.daLevel2Codes.SelectCommand = this.sqlCommand7;
            this.daLevel2Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level2_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv2_code", "lv2_code"),
                        new System.Data.Common.DataColumnMapping("lv2_desc", "lv2_desc"),
                        new System.Data.Common.DataColumnMapping("Level2", "Level2"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID")})});
            this.daLevel2Codes.UpdateCommand = this.sqlCommand8;
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = resources.GetString("sqlCommand5.CommandText");
            this.sqlCommand5.Connection = this.sqlTRConnection;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlTRConnection;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = "SELECT     lv2ID, lv2_code, lv2_desc, lv2_code + \' \' + lv2_desc AS Level2, lv1ID\r" +
    "\nFROM         Level2_Codes\r\nORDER BY lv2_code";
            this.sqlCommand7.Connection = this.sqlTRConnection;
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlTRConnection;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv2_code", System.Data.SqlDbType.VarChar, 0, "lv2_code"),
            new System.Data.SqlClient.SqlParameter("@lv2_desc", System.Data.SqlDbType.VarChar, 0, "lv2_desc"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 4, "lv2ID")});
            // 
            // daLevel3Codes
            // 
            this.daLevel3Codes.DeleteCommand = this.sqlDeleteCommand6;
            this.daLevel3Codes.InsertCommand = this.sqlCommand9;
            this.daLevel3Codes.SelectCommand = this.sqlSelectCommand6;
            this.daLevel3Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level3_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv3_code", "lv3_code"),
                        new System.Data.Common.DataColumnMapping("lv3_desc", "lv3_desc"),
                        new System.Data.Common.DataColumnMapping("Level3", "Level3"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID")})});
            this.daLevel3Codes.UpdateCommand = this.sqlUpdateCommand6;
            // 
            // sqlDeleteCommand6
            // 
            this.sqlDeleteCommand6.CommandText = resources.GetString("sqlDeleteCommand6.CommandText");
            this.sqlDeleteCommand6.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = resources.GetString("sqlCommand9.CommandText");
            this.sqlCommand9.Connection = this.sqlTRConnection;
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID")});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT     lv3ID, lv3_code, lv3_desc, lv3_code + \' \' + lv3_desc AS Level3, lv2ID\r" +
    "\nFROM         Level3_Codes\r\nORDER BY lv3_code";
            this.sqlSelectCommand6.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand6
            // 
            this.sqlUpdateCommand6.CommandText = resources.GetString("sqlUpdateCommand6.CommandText");
            this.sqlUpdateCommand6.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv3_code", System.Data.SqlDbType.VarChar, 0, "lv3_code"),
            new System.Data.SqlClient.SqlParameter("@lv3_desc", System.Data.SqlDbType.VarChar, 0, "lv3_desc"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 4, "lv3ID")});
            // 
            // daLevel4Codes
            // 
            this.daLevel4Codes.DeleteCommand = this.sqlDeleteCommand7;
            this.daLevel4Codes.InsertCommand = this.sqlInsertCommand6;
            this.daLevel4Codes.SelectCommand = this.sqlSelectCommand7;
            this.daLevel4Codes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Level4_Codes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("lv4_code", "lv4_code"),
                        new System.Data.Common.DataColumnMapping("lv4_desc", "lv4_desc"),
                        new System.Data.Common.DataColumnMapping("Level4", "Level4"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID")})});
            this.daLevel4Codes.UpdateCommand = this.sqlUpdateCommand7;
            // 
            // sqlDeleteCommand7
            // 
            this.sqlDeleteCommand7.CommandText = resources.GetString("sqlDeleteCommand7.CommandText");
            this.sqlDeleteCommand7.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand6
            // 
            this.sqlInsertCommand6.CommandText = resources.GetString("sqlInsertCommand6.CommandText");
            this.sqlInsertCommand6.Connection = this.sqlTRConnection;
            this.sqlInsertCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID")});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT     lv4ID, lv4_code, lv4_desc, lv4_code + \' \' + lv4_desc AS Level4, lv3ID\r" +
    "\nFROM         Level4_Codes\r\nORDER BY lv4_code";
            this.sqlSelectCommand7.Connection = this.sqlTRConnection;
            // 
            // sqlUpdateCommand7
            // 
            this.sqlUpdateCommand7.CommandText = resources.GetString("sqlUpdateCommand7.CommandText");
            this.sqlUpdateCommand7.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@lv4_code", System.Data.SqlDbType.VarChar, 0, "lv4_code"),
            new System.Data.SqlClient.SqlParameter("@lv4_desc", System.Data.SqlDbType.VarChar, 0, "lv4_desc"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 4, "lv4ID")});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = resources.GetString("sqlSelectCommand8.CommandText");
            this.sqlSelectCommand8.Connection = this.sqlTRConnection;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 500, "Username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_lotsearch_id", System.Data.SqlDbType.Int, 4, "working_ld_LotSearch_ID")});
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlTRConnection;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 0, "Username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, "LD_ProgramFee_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, "LD_Agreement_ProgramFee_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 0, "lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 0, "GL_Account"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST")});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlTRConnection;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.VarChar, 0, "Username"),
            new System.Data.SqlClient.SqlParameter("@working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, "working_ld_LotSearch_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, "LD_ProgramFee_ID"),
            new System.Data.SqlClient.SqlParameter("@LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, "LD_Agreement_ProgramFee_ID"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@lv1ID", System.Data.SqlDbType.Int, 0, "lv1ID"),
            new System.Data.SqlClient.SqlParameter("@lv2ID", System.Data.SqlDbType.Int, 0, "lv2ID"),
            new System.Data.SqlClient.SqlParameter("@lv3ID", System.Data.SqlDbType.Int, 0, "lv3ID"),
            new System.Data.SqlClient.SqlParameter("@lv4ID", System.Data.SqlDbType.Int, 0, "lv4ID"),
            new System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 0, "GL_Account"),
            new System.Data.SqlClient.SqlParameter("@GST", System.Data.SqlDbType.Bit, 0, "GST"),
            new System.Data.SqlClient.SqlParameter("@PST", System.Data.SqlDbType.Bit, 0, "PST"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_ProgramFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_ProgramFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Agreement_ProgramFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Agreement_ProgramFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Account", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.sqlTRConnection;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_working_ld_LotSearch_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "working_ld_LotSearch_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_ProgramFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_ProgramFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LD_Agreement_ProgramFee_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LD_Agreement_ProgramFee_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LD_Agreement_ProgramFee_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv1ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv1ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv2ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv2ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv3ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv3ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_lv4ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "lv4ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GL_Account", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GL_Account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PST", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PST", System.Data.DataRowVersion.Original, null)});
            // 
            // daProgramFees
            // 
            this.daProgramFees.DeleteCommand = this.sqlDeleteCommand4;
            this.daProgramFees.InsertCommand = this.sqlInsertCommand4;
            this.daProgramFees.SelectCommand = this.sqlSelectCommand8;
            this.daProgramFees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_ld_lpa_ProgramFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Username", "Username"),
                        new System.Data.Common.DataColumnMapping("working_ld_LotSearch_ID", "working_ld_LotSearch_ID"),
                        new System.Data.Common.DataColumnMapping("LD_ProgramFee_ID", "LD_ProgramFee_ID"),
                        new System.Data.Common.DataColumnMapping("LD_Agreement_ProgramFee_ID", "LD_Agreement_ProgramFee_ID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("lv1ID", "lv1ID"),
                        new System.Data.Common.DataColumnMapping("lv2ID", "lv2ID"),
                        new System.Data.Common.DataColumnMapping("lv3ID", "lv3ID"),
                        new System.Data.Common.DataColumnMapping("lv4ID", "lv4ID"),
                        new System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"),
                        new System.Data.Common.DataColumnMapping("GST", "GST"),
                        new System.Data.Common.DataColumnMapping("PST", "PST")})});
            this.daProgramFees.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = resources.GetString("sqlSelectCommand9.CommandText");
            this.sqlSelectCommand9.Connection = this.sqlTRConnection;
            this.sqlSelectCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@agreement_id", System.Data.SqlDbType.Int, 4, "Agreement_ID")});
            // 
            // dalueProgramFees
            // 
            this.dalueProgramFees.SelectCommand = this.sqlSelectCommand9;
            this.dalueProgramFees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ProgramFees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProgramFee_ID", "ProgramFee_ID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("ID", "ID")})});
            // 
            // ucReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcReview);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucReview";
            this.Size = new System.Drawing.Size(1422, 867);
            this.Load += new System.EventHandler(this.ucReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCreateInterim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePreviousPerDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePayoutDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePayoutDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_selectedLots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPayoutDetails)).EndInit();
            this.tcPayoutDetails.ResumeLayout(false);
            this.tpCashToClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCashToClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CashToClose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashToClose)).EndInit();
            this.tpAdditionalFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdditionalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_AdditionalFees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdditionalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_lueAdditionalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_lueAdditionalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lueAdditionalFees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel1Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel2Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel3Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4CodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLevel4Codes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDefault)).EndInit();
            this.tpInterest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Interest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri_seNumaric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIntAdj)).EndInit();
            this.pnlIntAdj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teInterestAdj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIntAdj.Properties)).EndInit();
            this.tpProgramFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProgramFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingldlpaProgramFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProgramFees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProgramFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueProgramFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProgramFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslueProgramFees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueLevel41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceDefault1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit dePayoutDate;
        public AccountYearPeriod.AcctYearPeriod acctYearPeriod1;
        private System.Data.SqlClient.SqlDataAdapter da_selectedLots;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private ds_selectedLots ds_selectedLots1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl tcPayoutDetails;
        private DevExpress.XtraTab.XtraTabPage tpAdditionalFees;
        private DevExpress.XtraTab.XtraTabPage tpInterest;
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
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gcAdditionalFees;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdditionalFees;
        private DevExpress.XtraGrid.GridControl gcInterest;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInterest;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter da_AdditionalFees;
        private ds_AdditionalFees ds_AdditionalFees1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername1;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_LotSearch_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter da_Interest;
        private ds_Interest ds_Interest1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter da_lueAdditionalFees;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_Additional_Fees_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ri_lueAdditionalFees;
        private ds_lueAdditionalFees ds_lueAdditionalFees1;
        private System.Windows.Forms.BindingSource bs_lueAdditionalFees;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_lss_AdditionalFees_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit ri_seAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit ri_seNumaric2;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraTab.XtraTabPage tpCashToClose;
        private DevExpress.XtraGrid.GridControl gcCashToClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCashToClose;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand5;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand5;
        private System.Data.SqlClient.SqlDataAdapter da_CashToClose;
        private ds_CashToClose ds_CashToClose1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername3;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_lotsearch_id2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colusername2;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_LotSearch_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInterestRatePct;
        private DevExpress.XtraGrid.Columns.GridColumn colInterestAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colworking_ld_lpa_Interest_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPrincipleBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colRunningInterest;
        private DevExpress.XtraGrid.Columns.GridColumn colPerDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colDays;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysInYear;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactiontype;
        private DevExpress.XtraGrid.Columns.GridColumn colInterestType;
        private DevExpress.XtraGrid.Columns.GridColumn colCompounded;
        private DevExpress.XtraGrid.Columns.GridColumn colCommencement;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount2;
        private DevExpress.XtraGrid.Columns.GridColumn collv1ID;
        private DevExpress.XtraGrid.Columns.GridColumn collv2ID;
        private DevExpress.XtraGrid.Columns.GridColumn collv3ID;
        private DevExpress.XtraGrid.Columns.GridColumn collv4ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGL_Account;
        private DevExpress.XtraGrid.Columns.GridColumn colGST;
        private DevExpress.XtraGrid.Columns.GridColumn colPST;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceDefault;
        private System.Data.SqlClient.SqlDataAdapter daLevel1Codes;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private dsLevel1Codes dsLevel1Codes1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel1;
        private System.Windows.Forms.BindingSource level1CodesBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel2Codes;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private dsLevel2Codes dsLevel2Codes1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel2;
        private System.Windows.Forms.BindingSource level2CodesBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel3Codes;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand6;
        private dsLevel3Codes dsLevel3Codes1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel3;
        private System.Windows.Forms.BindingSource level3CodesBindingSource;
        private System.Data.SqlClient.SqlDataAdapter daLevel4Codes;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand7;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand6;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand7;
        private dsLevel4Codes dsLevel4Codes1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel4;
        private System.Windows.Forms.BindingSource level4CodesBindingSource;
        private DevExpress.XtraTab.XtraTabPage tpProgramFees;
        private DevExpress.XtraGrid.GridControl gcProgramFees;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProgramFees;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_Agreement_ProgramFee_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueProgramFees;
        private DevExpress.XtraGrid.Columns.GridColumn collv1ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel11;
        private DevExpress.XtraGrid.Columns.GridColumn collv2ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel21;
        private DevExpress.XtraGrid.Columns.GridColumn collv3ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel31;
        private DevExpress.XtraGrid.Columns.GridColumn collv4ID1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueLevel41;
        private DevExpress.XtraGrid.Columns.GridColumn colGL_Account1;
        private DevExpress.XtraGrid.Columns.GridColumn colGST1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceDefault1;
        private DevExpress.XtraGrid.Columns.GridColumn colPST1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter daProgramFees;
        private dsProgramFees dsProgramFees1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
        private System.Data.SqlClient.SqlDataAdapter dalueProgramFees;
        private dslueProgramFees dslueProgramFees1;
        private System.Windows.Forms.BindingSource workingldlpaProgramFeesBindingSource;
        private System.Windows.Forms.BindingSource lDProgramFeesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLD_ProgramFee_ID;
        private DevExpress.XtraEditors.CheckEdit cePreviousPerDiem;
        private DevExpress.XtraEditors.PanelControl pnlIntAdj;
        private DevExpress.XtraEditors.CheckEdit ceIntAdj;
        private DevExpress.XtraEditors.TextEdit teInterestAdj;
        public DevExpress.XtraEditors.CheckEdit ceCreateInterim;
    }
}
