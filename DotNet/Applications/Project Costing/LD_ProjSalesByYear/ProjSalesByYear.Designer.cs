namespace LD_ProjSalesByYear
{
    partial class ProjSalesByYear
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
            this.dmMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpSearch = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.lDProjRevByYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProjSalesByYear1 = new LD_ProjSalesByYear.dsProjSalesByYear();
            this.fieldProjName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGeographicArea = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRegion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMunicipality = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCommunities = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCatCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCatDesc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldClassCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldClassDesc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProjStatus = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDivision = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProfitCenter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPerFrontage = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProjectManager = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSelectedYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProjCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalFrontage = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPerAcres = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalAcres = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daProjSalesByYear = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dmMain)).BeginInit();
            this.dpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProjRevByYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjSalesByYear1)).BeginInit();
            this.SuspendLayout();
            // 
            // dmMain
            // 
            this.dmMain.DockingOptions.ShowCloseButton = false;
            this.dmMain.Form = this;
            this.dmMain.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpSearch});
            this.dmMain.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpSearch
            // 
            this.dpSearch.Controls.Add(this.dockPanel1_Container);
            this.dpSearch.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dpSearch.ID = new System.Guid("164f111c-7723-46bc-b88f-0c7538c8e629");
            this.dpSearch.Location = new System.Drawing.Point(978, 0);
            this.dpSearch.Name = "dpSearch";
            this.dpSearch.Size = new System.Drawing.Size(329, 690);
            this.dpSearch.Text = "Search";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(323, 662);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.lDProjRevByYearBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProjName,
            this.fieldGeographicArea,
            this.fieldRegion,
            this.fieldMunicipality,
            this.fieldCommunities,
            this.fieldCatCode,
            this.fieldCatDesc,
            this.fieldClassCode,
            this.fieldClassDesc,
            this.fieldProjStatus,
            this.fieldDivision,
            this.fieldProfitCenter,
            this.fieldSales,
            this.fieldPerFrontage,
            this.fieldProjectManager,
            this.fieldSelectedYear,
            this.fieldProjCode,
            this.fieldTotalFrontage,
            this.fieldPerAcres,
            this.fieldTotalAcres});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(978, 690);
            this.pivotGridControl1.TabIndex = 1;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            // 
            // lDProjRevByYearBindingSource
            // 
            this.lDProjRevByYearBindingSource.DataMember = "LD_ProjRevByYear";
            this.lDProjRevByYearBindingSource.DataSource = this.dsProjSalesByYear1;
            // 
            // dsProjSalesByYear1
            // 
            this.dsProjSalesByYear1.DataSetName = "dsProjSalesByYear";
            this.dsProjSalesByYear1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldProjName
            // 
            this.fieldProjName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProjName.AreaIndex = 0;
            this.fieldProjName.Caption = "Project Name";
            this.fieldProjName.FieldName = "ProjName";
            this.fieldProjName.Name = "fieldProjName";
            this.fieldProjName.Width = 200;
            // 
            // fieldGeographicArea
            // 
            this.fieldGeographicArea.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldGeographicArea.AreaIndex = 1;
            this.fieldGeographicArea.Caption = "Geographic Area";
            this.fieldGeographicArea.FieldName = "GeographicArea";
            this.fieldGeographicArea.Name = "fieldGeographicArea";
            // 
            // fieldRegion
            // 
            this.fieldRegion.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldRegion.AreaIndex = 2;
            this.fieldRegion.Caption = "Region";
            this.fieldRegion.FieldName = "Region";
            this.fieldRegion.Name = "fieldRegion";
            // 
            // fieldMunicipality
            // 
            this.fieldMunicipality.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldMunicipality.AreaIndex = 3;
            this.fieldMunicipality.Caption = "Municipality";
            this.fieldMunicipality.FieldName = "Municipality";
            this.fieldMunicipality.Name = "fieldMunicipality";
            // 
            // fieldCommunities
            // 
            this.fieldCommunities.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldCommunities.AreaIndex = 4;
            this.fieldCommunities.Caption = "Communities";
            this.fieldCommunities.FieldName = "Communities";
            this.fieldCommunities.Name = "fieldCommunities";
            // 
            // fieldCatCode
            // 
            this.fieldCatCode.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldCatCode.AreaIndex = 5;
            this.fieldCatCode.Caption = "Category Code";
            this.fieldCatCode.FieldName = "CatCode";
            this.fieldCatCode.Name = "fieldCatCode";
            // 
            // fieldCatDesc
            // 
            this.fieldCatDesc.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldCatDesc.AreaIndex = 6;
            this.fieldCatDesc.Caption = "Category Desc";
            this.fieldCatDesc.FieldName = "CatDesc";
            this.fieldCatDesc.Name = "fieldCatDesc";
            // 
            // fieldClassCode
            // 
            this.fieldClassCode.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldClassCode.AreaIndex = 7;
            this.fieldClassCode.Caption = "Class Code";
            this.fieldClassCode.FieldName = "ClassCode";
            this.fieldClassCode.Name = "fieldClassCode";
            // 
            // fieldClassDesc
            // 
            this.fieldClassDesc.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldClassDesc.AreaIndex = 8;
            this.fieldClassDesc.Caption = "Class Desc";
            this.fieldClassDesc.FieldName = "ClassDesc";
            this.fieldClassDesc.Name = "fieldClassDesc";
            // 
            // fieldProjStatus
            // 
            this.fieldProjStatus.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldProjStatus.AreaIndex = 9;
            this.fieldProjStatus.Caption = "Status";
            this.fieldProjStatus.FieldName = "ProjStatus";
            this.fieldProjStatus.Name = "fieldProjStatus";
            // 
            // fieldDivision
            // 
            this.fieldDivision.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldDivision.AreaIndex = 10;
            this.fieldDivision.Caption = "Division";
            this.fieldDivision.FieldName = "Division";
            this.fieldDivision.Name = "fieldDivision";
            // 
            // fieldProfitCenter
            // 
            this.fieldProfitCenter.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldProfitCenter.AreaIndex = 11;
            this.fieldProfitCenter.Caption = "Profit Center";
            this.fieldProfitCenter.FieldName = "ProfitCenter";
            this.fieldProfitCenter.Name = "fieldProfitCenter";
            // 
            // fieldSales
            // 
            this.fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSales.AreaIndex = 0;
            this.fieldSales.Caption = "Sales";
            this.fieldSales.CellFormat.FormatString = "{0:n2}";
            this.fieldSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSales.EmptyCellText = "0.00";
            this.fieldSales.EmptyValueText = "0.00";
            this.fieldSales.FieldName = "Sales";
            this.fieldSales.MinWidth = 100;
            this.fieldSales.Name = "fieldSales";
            // 
            // fieldPerFrontage
            // 
            this.fieldPerFrontage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPerFrontage.AreaIndex = 1;
            this.fieldPerFrontage.Caption = "Per Frontage";
            this.fieldPerFrontage.CellFormat.FormatString = "{0:n2}";
            this.fieldPerFrontage.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPerFrontage.EmptyCellText = "0.00";
            this.fieldPerFrontage.EmptyValueText = "0.00";
            this.fieldPerFrontage.FieldName = "PerFrontage";
            this.fieldPerFrontage.GrandTotalCellFormat.FormatString = "n2";
            this.fieldPerFrontage.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPerFrontage.MinWidth = 100;
            this.fieldPerFrontage.Name = "fieldPerFrontage";
            this.fieldPerFrontage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.fieldPerFrontage.TotalCellFormat.FormatString = "n2";
            this.fieldPerFrontage.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPerFrontage.Width = 150;
            // 
            // fieldProjectManager
            // 
            this.fieldProjectManager.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldProjectManager.AreaIndex = 12;
            this.fieldProjectManager.Caption = "Project Manager";
            this.fieldProjectManager.FieldName = "ProjectManager";
            this.fieldProjectManager.Name = "fieldProjectManager";
            // 
            // fieldSelectedYear
            // 
            this.fieldSelectedYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSelectedYear.AreaIndex = 0;
            this.fieldSelectedYear.Caption = "Selected Year";
            this.fieldSelectedYear.FieldName = "SelectedYear";
            this.fieldSelectedYear.Name = "fieldSelectedYear";
            // 
            // fieldProjCode
            // 
            this.fieldProjCode.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldProjCode.AreaIndex = 0;
            this.fieldProjCode.Caption = "Project #";
            this.fieldProjCode.FieldName = "ProjCode";
            this.fieldProjCode.Name = "fieldProjCode";
            // 
            // fieldTotalFrontage
            // 
            this.fieldTotalFrontage.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTotalFrontage.AreaIndex = 1;
            this.fieldTotalFrontage.FieldName = "TotalFrontage";
            this.fieldTotalFrontage.Name = "fieldTotalFrontage";
            this.fieldTotalFrontage.Options.ShowInCustomizationForm = false;
            this.fieldTotalFrontage.Visible = false;
            // 
            // fieldPerAcres
            // 
            this.fieldPerAcres.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.fieldPerAcres.AreaIndex = 13;
            this.fieldPerAcres.Caption = "Per Acres";
            this.fieldPerAcres.CellFormat.FormatString = "{0:n2}";
            this.fieldPerAcres.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPerAcres.EmptyCellText = "0.00";
            this.fieldPerAcres.EmptyValueText = "0.00";
            this.fieldPerAcres.FieldName = "PerAcres";
            this.fieldPerAcres.Name = "fieldPerAcres";
            this.fieldPerAcres.Options.AllowEdit = false;
            this.fieldPerAcres.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // fieldTotalAcres
            // 
            this.fieldTotalAcres.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTotalAcres.AreaIndex = 2;
            this.fieldTotalAcres.FieldName = "TotalAcres";
            this.fieldTotalAcres.Name = "fieldTotalAcres";
            this.fieldTotalAcres.Options.AllowEdit = false;
            this.fieldTotalAcres.Options.ShowInCustomizationForm = false;
            this.fieldTotalAcres.Visible = false;
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=sa;Password=sa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.LD_ProjRevByYear";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@pri_type", System.Data.SqlDbType.VarChar, 5),
            new System.Data.SqlClient.SqlParameter("@GeographicArea_ID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Regions_ID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Municipality_ID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Communities_ID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@proj_manager_ID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@CatCode", System.Data.SqlDbType.VarChar, 6),
            new System.Data.SqlClient.SqlParameter("@ClassCode", System.Data.SqlDbType.VarChar, 6),
            new System.Data.SqlClient.SqlParameter("@ProjStatus", System.Data.SqlDbType.VarChar, 1),
            new System.Data.SqlClient.SqlParameter("@Division", System.Data.SqlDbType.VarChar, 6),
            new System.Data.SqlClient.SqlParameter("@ProfitCenter", System.Data.SqlDbType.VarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FromYear", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@ToYear", System.Data.SqlDbType.Int, 4)});
            // 
            // daProjSalesByYear
            // 
            this.daProjSalesByYear.SelectCommand = this.sqlSelectCommand1;
            this.daProjSalesByYear.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ProjRevByYear", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProjCode", "ProjCode"),
                        new System.Data.Common.DataColumnMapping("ProjName", "ProjName"),
                        new System.Data.Common.DataColumnMapping("GeographicArea", "GeographicArea"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("Municipality", "Municipality"),
                        new System.Data.Common.DataColumnMapping("Communities", "Communities"),
                        new System.Data.Common.DataColumnMapping("CatCode", "CatCode"),
                        new System.Data.Common.DataColumnMapping("CatDesc", "CatDesc"),
                        new System.Data.Common.DataColumnMapping("ClassCode", "ClassCode"),
                        new System.Data.Common.DataColumnMapping("ClassDesc", "ClassDesc"),
                        new System.Data.Common.DataColumnMapping("ProjStatus", "ProjStatus"),
                        new System.Data.Common.DataColumnMapping("Division", "Division"),
                        new System.Data.Common.DataColumnMapping("ProfitCenter", "ProfitCenter"),
                        new System.Data.Common.DataColumnMapping("Sales", "Sales"),
                        new System.Data.Common.DataColumnMapping("PerFrontage", "PerFrontage"),
                        new System.Data.Common.DataColumnMapping("ProjectManager", "ProjectManager"),
                        new System.Data.Common.DataColumnMapping("SelectedYear", "SelectedYear"),
                        new System.Data.Common.DataColumnMapping("TotalFrontage", "TotalFrontage"),
                        new System.Data.Common.DataColumnMapping("PerAcres", "PerAcres"),
                        new System.Data.Common.DataColumnMapping("TotalAcres", "TotalAcres")})});
            // 
            // ProjSalesByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dpSearch);
            this.Name = "ProjSalesByYear";
            this.Size = new System.Drawing.Size(1307, 690);
            this.Load += new System.EventHandler(this.ProjSalesByYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dmMain)).EndInit();
            this.dpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDProjRevByYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjSalesByYear1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dmMain;
        private DevExpress.XtraBars.Docking.DockPanel dpSearch;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter daProjSalesByYear;
        private dsProjSalesByYear dsProjSalesByYear1;
        private System.Windows.Forms.BindingSource lDProjRevByYearBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProjName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGeographicArea;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRegion;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMunicipality;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCommunities;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCatCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCatDesc;
        private DevExpress.XtraPivotGrid.PivotGridField fieldClassCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldClassDesc;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProjStatus;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDivision;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProfitCenter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPerFrontage;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProjectManager;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSelectedYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProjCode;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalFrontage;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPerAcres;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalAcres;
    }
}
