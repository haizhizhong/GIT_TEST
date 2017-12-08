namespace LD_TaxrollUpdate
{
    partial class ucLD_TaxrollUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLD_TaxrollUpdate));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadNewYear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.lueYears = new DevExpress.XtraEditors.LookUpEdit();
            this.aRPERIODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsARYears1 = new LD_TaxrollUpdate.dsARYears();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueProjects = new DevExpress.XtraEditors.LookUpEdit();
            this.pROJHEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProjects1 = new LD_TaxrollUpdate.dsProjects();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcTaxRollUpdate = new DevExpress.XtraGrid.GridControl();
            this.pROJLOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTaxRollUpdate1 = new LD_TaxrollUpdate.dsTaxRollUpdate();
            this.gvTaxRollUpdate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltax_roll_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colblock_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplan_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltax_adj_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colassessment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueAssessmentList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDAssesmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAssessmentList1 = new LD_TaxrollUpdate.dsAssessmentList();
            this.colassessment_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colassessment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.coltaxes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colpri_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcertificate_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXTERNAL_REF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotSubStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprcl_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprcl_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstp_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallment1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallment2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallment3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daProjects = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daARYears = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daTaxRollUpdate = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daAssessmentList = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueYears.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRPERIODSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARYears1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProjects.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjects1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaxRollUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJLOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaxRollUpdate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaxRollUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAssessmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDAssesmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAssessmentList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadNewYear);
            this.panelControl1.Controls.Add(this.btnClear);
            this.panelControl1.Controls.Add(this.btnFilter);
            this.panelControl1.Controls.Add(this.lueYears);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lueProjects);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1269, 34);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLoadNewYear
            // 
            this.btnLoadNewYear.Location = new System.Drawing.Point(745, 6);
            this.btnLoadNewYear.Name = "btnLoadNewYear";
            this.btnLoadNewYear.Size = new System.Drawing.Size(88, 23);
            this.btnLoadNewYear.TabIndex = 6;
            this.btnLoadNewYear.Text = "Load New Year";
            this.btnLoadNewYear.Click += new System.EventHandler(this.btnLoadNewYear_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(651, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(555, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(88, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lueYears
            // 
            this.lueYears.Location = new System.Drawing.Point(399, 8);
            this.lueYears.Name = "lueYears";
            this.lueYears.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueYears.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("year", "Year", 69, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lueYears.Properties.DataSource = this.aRPERIODSBindingSource;
            this.lueYears.Properties.DisplayMember = "year";
            this.lueYears.Properties.NullText = "";
            this.lueYears.Properties.ValueMember = "year";
            this.lueYears.Size = new System.Drawing.Size(124, 20);
            this.lueYears.TabIndex = 3;
            // 
            // aRPERIODSBindingSource
            // 
            this.aRPERIODSBindingSource.DataMember = "PROJ_LOT_TAX_DET";
            this.aRPERIODSBindingSource.DataSource = this.dsARYears1;
            // 
            // dsARYears1
            // 
            this.dsARYears1.DataSetName = "dsARYears";
            this.dsARYears1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(337, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tax Year";
            // 
            // lueProjects
            // 
            this.lueProjects.Location = new System.Drawing.Point(54, 8);
            this.lueProjects.Name = "lueProjects";
            this.lueProjects.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProjects.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_code", "Project #", 51, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_name", "Description", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueProjects.Properties.DataSource = this.pROJHEADERBindingSource;
            this.lueProjects.Properties.DisplayMember = "pri_name";
            this.lueProjects.Properties.NullText = "";
            this.lueProjects.Properties.ValueMember = "pri_id";
            this.lueProjects.Size = new System.Drawing.Size(263, 20);
            this.lueProjects.TabIndex = 1;
            // 
            // pROJHEADERBindingSource
            // 
            this.pROJHEADERBindingSource.DataMember = "PROJ_HEADER";
            this.pROJHEADERBindingSource.DataSource = this.dsProjects1;
            // 
            // dsProjects1
            // 
            this.dsProjects1.DataSetName = "dsProjects";
            this.dsProjects1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Project";
            // 
            // gcTaxRollUpdate
            // 
            this.gcTaxRollUpdate.DataSource = this.pROJLOTBindingSource;
            this.gcTaxRollUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTaxRollUpdate.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTaxRollUpdate.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTaxRollUpdate.Location = new System.Drawing.Point(0, 34);
            this.gcTaxRollUpdate.MainView = this.gvTaxRollUpdate;
            this.gcTaxRollUpdate.Name = "gcTaxRollUpdate";
            this.gcTaxRollUpdate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueAssessmentList,
            this.riteNumber,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemCheckEdit1});
            this.gcTaxRollUpdate.Size = new System.Drawing.Size(1269, 708);
            this.gcTaxRollUpdate.TabIndex = 1;
            this.gcTaxRollUpdate.UseEmbeddedNavigator = true;
            this.gcTaxRollUpdate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaxRollUpdate});
            // 
            // pROJLOTBindingSource
            // 
            this.pROJLOTBindingSource.DataMember = "LD_LotCounty";
            this.pROJLOTBindingSource.DataSource = this.dsTaxRollUpdate1;
            // 
            // dsTaxRollUpdate1
            // 
            this.dsTaxRollUpdate1.DataSetName = "dsTaxRollUpdate";
            this.dsTaxRollUpdate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTaxRollUpdate
            // 
            this.gvTaxRollUpdate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltax_roll_num,
            this.colyear,
            this.collot_num,
            this.colblock_num,
            this.colplan_num,
            this.coltax_adj_date,
            this.colassessment_id,
            this.colassessment_desc,
            this.colassessment,
            this.coltaxes,
            this.colcomment,
            this.colPaid,
            this.colpri_code,
            this.colpri_name,
            this.colcertificate_num,
            this.colCounty,
            this.colEXTERNAL_REF,
            this.colAcres,
            this.colLot_Status,
            this.colLotSubStatus,
            this.colprcl_code,
            this.colprcl_desc,
            this.colRegion,
            this.colstp_desc,
            this.colInstallment1,
            this.colInstallment2,
            this.colInstallment3});
            this.gvTaxRollUpdate.GridControl = this.gcTaxRollUpdate;
            this.gvTaxRollUpdate.Name = "gvTaxRollUpdate";
            this.gvTaxRollUpdate.OptionsView.ColumnAutoWidth = false;
            this.gvTaxRollUpdate.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTaxRollUpdate_RowUpdated);
            this.gvTaxRollUpdate.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvTaxRollUpdate_InvalidRowException);
            this.gvTaxRollUpdate.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvTaxRollUpdate_ValidateRow);
            // 
            // coltax_roll_num
            // 
            this.coltax_roll_num.Caption = "Tax Roll #";
            this.coltax_roll_num.FieldName = "tax_roll_num";
            this.coltax_roll_num.Name = "coltax_roll_num";
            this.coltax_roll_num.OptionsColumn.AllowEdit = false;
            this.coltax_roll_num.Visible = true;
            this.coltax_roll_num.VisibleIndex = 2;
            this.coltax_roll_num.Width = 121;
            // 
            // colyear
            // 
            this.colyear.Caption = "Year";
            this.colyear.FieldName = "year";
            this.colyear.Name = "colyear";
            this.colyear.OptionsColumn.AllowEdit = false;
            this.colyear.Visible = true;
            this.colyear.VisibleIndex = 3;
            // 
            // collot_num
            // 
            this.collot_num.Caption = "Lot";
            this.collot_num.FieldName = "lot_num";
            this.collot_num.Name = "collot_num";
            this.collot_num.OptionsColumn.AllowEdit = false;
            this.collot_num.Visible = true;
            this.collot_num.VisibleIndex = 4;
            // 
            // colblock_num
            // 
            this.colblock_num.Caption = "Block";
            this.colblock_num.FieldName = "block_num";
            this.colblock_num.Name = "colblock_num";
            this.colblock_num.OptionsColumn.AllowEdit = false;
            this.colblock_num.Visible = true;
            this.colblock_num.VisibleIndex = 5;
            // 
            // colplan_num
            // 
            this.colplan_num.Caption = "Plan";
            this.colplan_num.FieldName = "plan_num";
            this.colplan_num.Name = "colplan_num";
            this.colplan_num.OptionsColumn.AllowEdit = false;
            this.colplan_num.Visible = true;
            this.colplan_num.VisibleIndex = 6;
            // 
            // coltax_adj_date
            // 
            this.coltax_adj_date.Caption = "Tax Adjustment Date";
            this.coltax_adj_date.FieldName = "tax_adj_date";
            this.coltax_adj_date.Name = "coltax_adj_date";
            this.coltax_adj_date.Visible = true;
            this.coltax_adj_date.VisibleIndex = 7;
            this.coltax_adj_date.Width = 124;
            // 
            // colassessment_id
            // 
            this.colassessment_id.Caption = "Assessment Code";
            this.colassessment_id.ColumnEdit = this.rilueAssessmentList;
            this.colassessment_id.FieldName = "assessment_id";
            this.colassessment_id.Name = "colassessment_id";
            this.colassessment_id.Visible = true;
            this.colassessment_id.VisibleIndex = 8;
            this.colassessment_id.Width = 107;
            // 
            // rilueAssessmentList
            // 
            this.rilueAssessmentList.AutoHeight = false;
            this.rilueAssessmentList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueAssessmentList.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueAssessmentList.DataSource = this.lDAssesmentBindingSource;
            this.rilueAssessmentList.DisplayMember = "Code";
            this.rilueAssessmentList.Name = "rilueAssessmentList";
            this.rilueAssessmentList.NullText = "";
            this.rilueAssessmentList.ValueMember = "Assesment_ID";
            this.rilueAssessmentList.EditValueChanged += new System.EventHandler(this.rilueAssessmentList_EditValueChanged);
            // 
            // lDAssesmentBindingSource
            // 
            this.lDAssesmentBindingSource.DataMember = "LD_Assesment";
            this.lDAssesmentBindingSource.DataSource = this.dsAssessmentList1;
            // 
            // dsAssessmentList1
            // 
            this.dsAssessmentList1.DataSetName = "dsAssessmentList";
            this.dsAssessmentList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colassessment_desc
            // 
            this.colassessment_desc.Caption = "Assessment Description";
            this.colassessment_desc.FieldName = "assessment_desc";
            this.colassessment_desc.Name = "colassessment_desc";
            this.colassessment_desc.OptionsColumn.AllowEdit = false;
            this.colassessment_desc.Visible = true;
            this.colassessment_desc.VisibleIndex = 9;
            this.colassessment_desc.Width = 135;
            // 
            // colassessment
            // 
            this.colassessment.Caption = "Assessed Value";
            this.colassessment.ColumnEdit = this.riteNumber;
            this.colassessment.FieldName = "assessment";
            this.colassessment.Name = "colassessment";
            this.colassessment.Visible = true;
            this.colassessment.VisibleIndex = 10;
            this.colassessment.Width = 96;
            // 
            // riteNumber
            // 
            this.riteNumber.AutoHeight = false;
            this.riteNumber.DisplayFormat.FormatString = "n2";
            this.riteNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riteNumber.EditFormat.FormatString = "n2";
            this.riteNumber.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riteNumber.Mask.EditMask = "n2";
            this.riteNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteNumber.Mask.UseMaskAsDisplayFormat = true;
            this.riteNumber.Name = "riteNumber";
            // 
            // coltaxes
            // 
            this.coltaxes.Caption = "Taxes";
            this.coltaxes.ColumnEdit = this.riteNumber;
            this.coltaxes.FieldName = "taxes";
            this.coltaxes.Name = "coltaxes";
            this.coltaxes.Visible = true;
            this.coltaxes.VisibleIndex = 11;
            this.coltaxes.Width = 102;
            // 
            // colcomment
            // 
            this.colcomment.Caption = "Additional Comments";
            this.colcomment.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 12;
            this.colcomment.Width = 230;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colPaid
            // 
            this.colPaid.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 13;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colpri_code
            // 
            this.colpri_code.Caption = "Project #";
            this.colpri_code.FieldName = "pri_code";
            this.colpri_code.Name = "colpri_code";
            this.colpri_code.OptionsColumn.AllowEdit = false;
            this.colpri_code.Visible = true;
            this.colpri_code.VisibleIndex = 0;
            this.colpri_code.Width = 81;
            // 
            // colpri_name
            // 
            this.colpri_name.Caption = "Project Name";
            this.colpri_name.FieldName = "pri_name";
            this.colpri_name.Name = "colpri_name";
            this.colpri_name.OptionsColumn.AllowEdit = false;
            this.colpri_name.Visible = true;
            this.colpri_name.VisibleIndex = 1;
            this.colpri_name.Width = 167;
            // 
            // colcertificate_num
            // 
            this.colcertificate_num.Caption = "Certificate of Title#";
            this.colcertificate_num.FieldName = "certificate_num";
            this.colcertificate_num.Name = "colcertificate_num";
            this.colcertificate_num.OptionsColumn.AllowEdit = false;
            // 
            // colCounty
            // 
            this.colCounty.Caption = "Lot County";
            this.colCounty.FieldName = "County";
            this.colCounty.Name = "colCounty";
            this.colCounty.OptionsColumn.AllowEdit = false;
            // 
            // colEXTERNAL_REF
            // 
            this.colEXTERNAL_REF.Caption = "Project External Reference";
            this.colEXTERNAL_REF.FieldName = "EXTERNAL_REF";
            this.colEXTERNAL_REF.Name = "colEXTERNAL_REF";
            this.colEXTERNAL_REF.OptionsColumn.AllowEdit = false;
            // 
            // colAcres
            // 
            this.colAcres.FieldName = "Acres";
            this.colAcres.Name = "colAcres";
            this.colAcres.OptionsColumn.AllowEdit = false;
            // 
            // colLot_Status
            // 
            this.colLot_Status.Caption = "Lot Status";
            this.colLot_Status.FieldName = "Lot_Status";
            this.colLot_Status.Name = "colLot_Status";
            this.colLot_Status.OptionsColumn.AllowEdit = false;
            // 
            // colLotSubStatus
            // 
            this.colLotSubStatus.FieldName = "LotSubStatus";
            this.colLotSubStatus.Name = "colLotSubStatus";
            this.colLotSubStatus.OptionsColumn.AllowEdit = false;
            // 
            // colprcl_code
            // 
            this.colprcl_code.Caption = "Project Class Code";
            this.colprcl_code.FieldName = "prcl_code";
            this.colprcl_code.Name = "colprcl_code";
            this.colprcl_code.OptionsColumn.AllowEdit = false;
            // 
            // colprcl_desc
            // 
            this.colprcl_desc.Caption = "Project Class Description";
            this.colprcl_desc.FieldName = "prcl_desc";
            this.colprcl_desc.Name = "colprcl_desc";
            this.colprcl_desc.OptionsColumn.AllowEdit = false;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.OptionsColumn.AllowEdit = false;
            // 
            // colstp_desc
            // 
            this.colstp_desc.Caption = "Project Province";
            this.colstp_desc.FieldName = "stp_desc";
            this.colstp_desc.Name = "colstp_desc";
            this.colstp_desc.OptionsColumn.AllowEdit = false;
            // 
            // colInstallment1
            // 
            this.colInstallment1.Caption = "1st Installment";
            this.colInstallment1.ColumnEdit = this.riteNumber;
            this.colInstallment1.FieldName = "Installment1";
            this.colInstallment1.Name = "colInstallment1";
            // 
            // colInstallment2
            // 
            this.colInstallment2.Caption = "2nd Installment";
            this.colInstallment2.ColumnEdit = this.riteNumber;
            this.colInstallment2.FieldName = "Installment2";
            this.colInstallment2.Name = "colInstallment2";
            // 
            // colInstallment3
            // 
            this.colInstallment3.Caption = "3rd Installment";
            this.colInstallment3.ColumnEdit = this.riteNumber;
            this.colInstallment3.FieldName = "Installment3";
            this.colInstallment3.Name = "colInstallment3";
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     pri_id, pri_code, pri_name\r\nFROM         PROJ_HEADER\r\nWHERE     (pri_t" +
                "ype = \'PLC\')\r\nORDER BY pri_code";
            this.sqlSelectCommand1.Connection = this.sqlTR;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [PROJ_HEADER] ([pri_code], [pri_name]) VALUES (@pri_code, @pri_name);" +
                "\r\nSELECT pri_id, pri_code, pri_name FROM PROJ_HEADER WHERE (pri_id = SCOPE_IDENT" +
                "ITY()) ORDER BY pri_code";
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@pri_name", System.Data.SqlDbType.VarChar, 0, "pri_name"),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_name", System.Data.DataRowVersion.Original, null)});
            // 
            // daProjects
            // 
            this.daProjects.DeleteCommand = this.sqlDeleteCommand1;
            this.daProjects.InsertCommand = this.sqlInsertCommand1;
            this.daProjects.SelectCommand = this.sqlSelectCommand1;
            this.daProjects.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_HEADER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name")})});
            this.daProjects.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT DISTINCT year\r\nFROM         PROJ_LOT_TAX_DET\r\nORDER BY year DESC";
            this.sqlSelectCommand2.Connection = this.sqlTR;
            // 
            // daARYears
            // 
            this.daARYears.SelectCommand = this.sqlSelectCommand2;
            this.daARYears.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_LOT_TAX_DET", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("year", "year")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlTR;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Year", System.Data.SqlDbType.Int, 4, "year"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // daTaxRollUpdate
            // 
            this.daTaxRollUpdate.SelectCommand = this.sqlSelectCommand3;
            this.daTaxRollUpdate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_LotCounty", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("tax_roll_num", "tax_roll_num"),
                        new System.Data.Common.DataColumnMapping("year", "year"),
                        new System.Data.Common.DataColumnMapping("lot_num", "lot_num"),
                        new System.Data.Common.DataColumnMapping("block_num", "block_num"),
                        new System.Data.Common.DataColumnMapping("plan_num", "plan_num"),
                        new System.Data.Common.DataColumnMapping("tax_adj_date", "tax_adj_date"),
                        new System.Data.Common.DataColumnMapping("assessment_id", "assessment_id"),
                        new System.Data.Common.DataColumnMapping("assessment_desc", "assessment_desc"),
                        new System.Data.Common.DataColumnMapping("assessment", "assessment"),
                        new System.Data.Common.DataColumnMapping("taxes", "taxes"),
                        new System.Data.Common.DataColumnMapping("comment", "comment"),
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("tax_roll_id", "tax_roll_id"),
                        new System.Data.Common.DataColumnMapping("Paid", "Paid"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_name", "pri_name"),
                        new System.Data.Common.DataColumnMapping("PROJ_LOT_TAX_ROLL_ID", "PROJ_LOT_TAX_ROLL_ID"),
                        new System.Data.Common.DataColumnMapping("prcl_code", "prcl_code"),
                        new System.Data.Common.DataColumnMapping("prcl_desc", "prcl_desc"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("stp_desc", "stp_desc"),
                        new System.Data.Common.DataColumnMapping("EXTERNAL_REF", "EXTERNAL_REF"),
                        new System.Data.Common.DataColumnMapping("Lot_Status", "Lot_Status"),
                        new System.Data.Common.DataColumnMapping("LotSubStatus", "LotSubStatus"),
                        new System.Data.Common.DataColumnMapping("certificate_num", "certificate_num"),
                        new System.Data.Common.DataColumnMapping("Acres", "Acres"),
                        new System.Data.Common.DataColumnMapping("County", "County"),
                        new System.Data.Common.DataColumnMapping("Installment1", "Installment1"),
                        new System.Data.Common.DataColumnMapping("Installment2", "Installment2"),
                        new System.Data.Common.DataColumnMapping("Installment3", "Installment3")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT     Assesment_ID, Code, Description\r\nFROM         LD_Assesment\r\nORDER BY C" +
                "ode";
            this.sqlSelectCommand4.Connection = this.sqlTR;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [LD_Assesment] ([Code], [Description]) VALUES (@Code, @Description);\r" +
                "\nSELECT Assesment_ID, Code, Description FROM LD_Assesment WHERE (Assesment_ID = " +
                "SCOPE_IDENTITY()) ORDER BY Code";
            this.sqlInsertCommand2.Connection = this.sqlTR;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlTR;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.VarChar, 0, "Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_Assesment_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Assesment_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Assesment_ID", System.Data.SqlDbType.Int, 4, "Assesment_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [LD_Assesment] WHERE (([Assesment_ID] = @Original_Assesment_ID) AND (" +
                "[Code] = @Original_Code) AND ([Description] = @Original_Description))";
            this.sqlDeleteCommand2.Connection = this.sqlTR;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Assesment_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Assesment_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // daAssessmentList
            // 
            this.daAssessmentList.DeleteCommand = this.sqlDeleteCommand2;
            this.daAssessmentList.InsertCommand = this.sqlInsertCommand2;
            this.daAssessmentList.SelectCommand = this.sqlSelectCommand4;
            this.daAssessmentList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_Assesment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Assesment_ID", "Assesment_ID"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daAssessmentList.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // ucLD_TaxrollUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcTaxRollUpdate);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucLD_TaxrollUpdate";
            this.Size = new System.Drawing.Size(1269, 742);
            this.Load += new System.EventHandler(this.ucLD_TaxrollUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueYears.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRPERIODSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsARYears1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProjects.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjects1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaxRollUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJLOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaxRollUpdate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaxRollUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueAssessmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDAssesmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAssessmentList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcTaxRollUpdate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaxRollUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueProjects;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.LookUpEdit lueYears;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnLoadNewYear;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daProjects;
        private System.Windows.Forms.BindingSource pROJHEADERBindingSource;
        private dsProjects dsProjects1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daARYears;
        private dsARYears dsARYears1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter daTaxRollUpdate;
        private dsTaxRollUpdate dsTaxRollUpdate1;
        private System.Windows.Forms.BindingSource aRPERIODSBindingSource;
        private System.Windows.Forms.BindingSource pROJLOTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltax_roll_num;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn collot_num;
        private DevExpress.XtraGrid.Columns.GridColumn colblock_num;
        private DevExpress.XtraGrid.Columns.GridColumn colplan_num;
        private DevExpress.XtraGrid.Columns.GridColumn coltax_adj_date;
        private DevExpress.XtraGrid.Columns.GridColumn colassessment_id;
        private DevExpress.XtraGrid.Columns.GridColumn colassessment_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colassessment;
        private DevExpress.XtraGrid.Columns.GridColumn coltaxes;
        private DevExpress.XtraGrid.Columns.GridColumn colcomment;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daAssessmentList;
        private dsAssessmentList dsAssessmentList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueAssessmentList;
        private System.Windows.Forms.BindingSource lDAssesmentBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_code;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcertificate_num;
        private DevExpress.XtraGrid.Columns.GridColumn colCounty;
        private DevExpress.XtraGrid.Columns.GridColumn colEXTERNAL_REF;
        private DevExpress.XtraGrid.Columns.GridColumn colAcres;
        private DevExpress.XtraGrid.Columns.GridColumn colLot_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colLotSubStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colprcl_code;
        private DevExpress.XtraGrid.Columns.GridColumn colprcl_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colstp_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallment1;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallment2;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallment3;
    }
}
