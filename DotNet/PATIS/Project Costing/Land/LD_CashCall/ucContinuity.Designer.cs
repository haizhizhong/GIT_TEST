namespace LD_CashCall
{
    partial class ucContinuity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContinuity));
            this.sqlTRConnection = new System.Data.SqlClient.SqlConnection();
            this.daContinuitySchedules = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsContinuitySchedules1 = new LD_CashCall.dsContinuitySchedules();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProject1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvestor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionPercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalInvestment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreviousDisbursements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsContinuitySchedules1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlTRConnection
            // 
            this.sqlTRConnection.ConnectionString = "Data Source=DOTNETSQL\\DOTNETSQL;Initial Catalog=TR_GC_TEST;Persist Security Info=" +
                "True;User ID=hmsqlsa;Password=hmsqlsa";
            this.sqlTRConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // daContinuitySchedules
            // 
            this.daContinuitySchedules.DeleteCommand = this.sqlCommand1;
            this.daContinuitySchedules.InsertCommand = this.sqlCommand2;
            this.daContinuitySchedules.SelectCommand = this.sqlCommand3;
            this.daContinuitySchedules.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LD_ContinuitySchedule", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("Company", "Company"),
                        new System.Data.Common.DataColumnMapping("Project", "Project"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("Investor", "Investor"),
                        new System.Data.Common.DataColumnMapping("Shares_ID", "Shares_ID"),
                        new System.Data.Common.DataColumnMapping("DistributionPercentage", "DistributionPercentage"),
                        new System.Data.Common.DataColumnMapping("AsAtYear", "AsAtYear"),
                        new System.Data.Common.DataColumnMapping("AsAtPeriod", "AsAtPeriod"),
                        new System.Data.Common.DataColumnMapping("OriginalInvestment", "OriginalInvestment"),
                        new System.Data.Common.DataColumnMapping("PreviousDisbursements", "PreviousDisbursements"),
                        new System.Data.Common.DataColumnMapping("F1", "F1"),
                        new System.Data.Common.DataColumnMapping("F2", "F2"),
                        new System.Data.Common.DataColumnMapping("F3", "F3"),
                        new System.Data.Common.DataColumnMapping("F4", "F4"),
                        new System.Data.Common.DataColumnMapping("F5", "F5"),
                        new System.Data.Common.DataColumnMapping("F6", "F6"),
                        new System.Data.Common.DataColumnMapping("F7", "F7"),
                        new System.Data.Common.DataColumnMapping("F8", "F8"),
                        new System.Data.Common.DataColumnMapping("F9", "F9"),
                        new System.Data.Common.DataColumnMapping("F10", "F10"),
                        new System.Data.Common.DataColumnMapping("F11", "F11"),
                        new System.Data.Common.DataColumnMapping("F12", "F12"),
                        new System.Data.Common.DataColumnMapping("TotalProfitToDate", "TotalProfitToDate"),
                        new System.Data.Common.DataColumnMapping("Type1", "Type1"),
                        new System.Data.Common.DataColumnMapping("Type2", "Type2"),
                        new System.Data.Common.DataColumnMapping("Type3", "Type3"),
                        new System.Data.Common.DataColumnMapping("Type4", "Type4"),
                        new System.Data.Common.DataColumnMapping("Type5", "Type5"),
                        new System.Data.Common.DataColumnMapping("Type6", "Type6"),
                        new System.Data.Common.DataColumnMapping("Type7", "Type7"),
                        new System.Data.Common.DataColumnMapping("Type8", "Type8"),
                        new System.Data.Common.DataColumnMapping("Type9", "Type9"),
                        new System.Data.Common.DataColumnMapping("Type10", "Type10"),
                        new System.Data.Common.DataColumnMapping("Type11", "Type11"),
                        new System.Data.Common.DataColumnMapping("Type12", "Type12"),
                        new System.Data.Common.DataColumnMapping("Date1", "Date1"),
                        new System.Data.Common.DataColumnMapping("Date2", "Date2"),
                        new System.Data.Common.DataColumnMapping("Date3", "Date3"),
                        new System.Data.Common.DataColumnMapping("Date4", "Date4"),
                        new System.Data.Common.DataColumnMapping("Date5", "Date5"),
                        new System.Data.Common.DataColumnMapping("Date6", "Date6"),
                        new System.Data.Common.DataColumnMapping("Date7", "Date7"),
                        new System.Data.Common.DataColumnMapping("Date8", "Date8"),
                        new System.Data.Common.DataColumnMapping("Date9", "Date9"),
                        new System.Data.Common.DataColumnMapping("Date10", "Date10"),
                        new System.Data.Common.DataColumnMapping("Date11", "Date11"),
                        new System.Data.Common.DataColumnMapping("Date12", "Date12"),
                        new System.Data.Common.DataColumnMapping("GeneratedBy", "GeneratedBy"),
                        new System.Data.Common.DataColumnMapping("BatchID", "BatchID")})});
            this.daContinuitySchedules.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlTRConnection;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Company", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Company", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Shares_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Shares_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Shares_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Shares_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtYear", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtYear", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtPeriod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtPeriod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtPeriod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtPeriod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalInvestment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalInvestment", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalInvestment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalInvestment", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PreviousDisbursements", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreviousDisbursements", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PreviousDisbursements", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreviousDisbursements", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F3", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F4", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F5", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F6", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F7", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F8", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F9", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F10", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F11", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F12", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalProfitToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalProfitToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalProfitToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalProfitToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type4", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type5", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type6", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type7", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type8", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type9", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type10", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type11", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type12", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date4", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date5", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date6", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date7", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date8", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date9", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date10", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date11", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date12", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GeneratedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GeneratedBy", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GeneratedBy", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GeneratedBy", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BatchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BatchID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BatchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BatchID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlTRConnection;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Company", System.Data.SqlDbType.VarChar, 0, "Company"),
            new System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.VarChar, 0, "Project"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@Investor", System.Data.SqlDbType.VarChar, 0, "Investor"),
            new System.Data.SqlClient.SqlParameter("@Shares_ID", System.Data.SqlDbType.Int, 0, "Shares_ID"),
            new System.Data.SqlClient.SqlParameter("@AsAtYear", System.Data.SqlDbType.Int, 0, "AsAtYear"),
            new System.Data.SqlClient.SqlParameter("@AsAtPeriod", System.Data.SqlDbType.Int, 0, "AsAtPeriod"),
            new System.Data.SqlClient.SqlParameter("@OriginalInvestment", System.Data.SqlDbType.Money, 0, "OriginalInvestment"),
            new System.Data.SqlClient.SqlParameter("@PreviousDisbursements", System.Data.SqlDbType.Money, 0, "PreviousDisbursements"),
            new System.Data.SqlClient.SqlParameter("@F1", System.Data.SqlDbType.Money, 0, "F1"),
            new System.Data.SqlClient.SqlParameter("@F2", System.Data.SqlDbType.Money, 0, "F2"),
            new System.Data.SqlClient.SqlParameter("@F3", System.Data.SqlDbType.Money, 0, "F3"),
            new System.Data.SqlClient.SqlParameter("@F4", System.Data.SqlDbType.Money, 0, "F4"),
            new System.Data.SqlClient.SqlParameter("@F5", System.Data.SqlDbType.Money, 0, "F5"),
            new System.Data.SqlClient.SqlParameter("@F6", System.Data.SqlDbType.Money, 0, "F6"),
            new System.Data.SqlClient.SqlParameter("@F7", System.Data.SqlDbType.Money, 0, "F7"),
            new System.Data.SqlClient.SqlParameter("@F8", System.Data.SqlDbType.Money, 0, "F8"),
            new System.Data.SqlClient.SqlParameter("@F9", System.Data.SqlDbType.Money, 0, "F9"),
            new System.Data.SqlClient.SqlParameter("@F10", System.Data.SqlDbType.Money, 0, "F10"),
            new System.Data.SqlClient.SqlParameter("@F11", System.Data.SqlDbType.Money, 0, "F11"),
            new System.Data.SqlClient.SqlParameter("@F12", System.Data.SqlDbType.Money, 0, "F12"),
            new System.Data.SqlClient.SqlParameter("@TotalProfitToDate", System.Data.SqlDbType.Money, 0, "TotalProfitToDate"),
            new System.Data.SqlClient.SqlParameter("@Type1", System.Data.SqlDbType.VarChar, 0, "Type1"),
            new System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.VarChar, 0, "Type2"),
            new System.Data.SqlClient.SqlParameter("@Type3", System.Data.SqlDbType.VarChar, 0, "Type3"),
            new System.Data.SqlClient.SqlParameter("@Type4", System.Data.SqlDbType.VarChar, 0, "Type4"),
            new System.Data.SqlClient.SqlParameter("@Type5", System.Data.SqlDbType.VarChar, 0, "Type5"),
            new System.Data.SqlClient.SqlParameter("@Type6", System.Data.SqlDbType.VarChar, 0, "Type6"),
            new System.Data.SqlClient.SqlParameter("@Type7", System.Data.SqlDbType.VarChar, 0, "Type7"),
            new System.Data.SqlClient.SqlParameter("@Type8", System.Data.SqlDbType.VarChar, 0, "Type8"),
            new System.Data.SqlClient.SqlParameter("@Type9", System.Data.SqlDbType.VarChar, 0, "Type9"),
            new System.Data.SqlClient.SqlParameter("@Type10", System.Data.SqlDbType.VarChar, 0, "Type10"),
            new System.Data.SqlClient.SqlParameter("@Type11", System.Data.SqlDbType.VarChar, 0, "Type11"),
            new System.Data.SqlClient.SqlParameter("@Type12", System.Data.SqlDbType.VarChar, 0, "Type12"),
            new System.Data.SqlClient.SqlParameter("@Date1", System.Data.SqlDbType.VarChar, 0, "Date1"),
            new System.Data.SqlClient.SqlParameter("@Date2", System.Data.SqlDbType.VarChar, 0, "Date2"),
            new System.Data.SqlClient.SqlParameter("@Date3", System.Data.SqlDbType.VarChar, 0, "Date3"),
            new System.Data.SqlClient.SqlParameter("@Date4", System.Data.SqlDbType.VarChar, 0, "Date4"),
            new System.Data.SqlClient.SqlParameter("@Date5", System.Data.SqlDbType.VarChar, 0, "Date5"),
            new System.Data.SqlClient.SqlParameter("@Date6", System.Data.SqlDbType.VarChar, 0, "Date6"),
            new System.Data.SqlClient.SqlParameter("@Date7", System.Data.SqlDbType.VarChar, 0, "Date7"),
            new System.Data.SqlClient.SqlParameter("@Date8", System.Data.SqlDbType.VarChar, 0, "Date8"),
            new System.Data.SqlClient.SqlParameter("@Date9", System.Data.SqlDbType.VarChar, 0, "Date9"),
            new System.Data.SqlClient.SqlParameter("@Date10", System.Data.SqlDbType.VarChar, 0, "Date10"),
            new System.Data.SqlClient.SqlParameter("@Date11", System.Data.SqlDbType.VarChar, 0, "Date11"),
            new System.Data.SqlClient.SqlParameter("@Date12", System.Data.SqlDbType.VarChar, 0, "Date12"),
            new System.Data.SqlClient.SqlParameter("@GeneratedBy", System.Data.SqlDbType.VarChar, 0, "GeneratedBy"),
            new System.Data.SqlClient.SqlParameter("@BatchID", System.Data.SqlDbType.Int, 0, "BatchID")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlTRConnection;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 50, "GeneratedBy"),
            new System.Data.SqlClient.SqlParameter("@BatchID", System.Data.SqlDbType.Int, 4, "BatchID"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlTRConnection;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Company", System.Data.SqlDbType.VarChar, 0, "Company"),
            new System.Data.SqlClient.SqlParameter("@Project", System.Data.SqlDbType.VarChar, 0, "Project"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@Investor", System.Data.SqlDbType.VarChar, 0, "Investor"),
            new System.Data.SqlClient.SqlParameter("@Shares_ID", System.Data.SqlDbType.Int, 0, "Shares_ID"),
            new System.Data.SqlClient.SqlParameter("@AsAtYear", System.Data.SqlDbType.Int, 0, "AsAtYear"),
            new System.Data.SqlClient.SqlParameter("@AsAtPeriod", System.Data.SqlDbType.Int, 0, "AsAtPeriod"),
            new System.Data.SqlClient.SqlParameter("@OriginalInvestment", System.Data.SqlDbType.Money, 0, "OriginalInvestment"),
            new System.Data.SqlClient.SqlParameter("@PreviousDisbursements", System.Data.SqlDbType.Money, 0, "PreviousDisbursements"),
            new System.Data.SqlClient.SqlParameter("@F1", System.Data.SqlDbType.Money, 0, "F1"),
            new System.Data.SqlClient.SqlParameter("@F2", System.Data.SqlDbType.Money, 0, "F2"),
            new System.Data.SqlClient.SqlParameter("@F3", System.Data.SqlDbType.Money, 0, "F3"),
            new System.Data.SqlClient.SqlParameter("@F4", System.Data.SqlDbType.Money, 0, "F4"),
            new System.Data.SqlClient.SqlParameter("@F5", System.Data.SqlDbType.Money, 0, "F5"),
            new System.Data.SqlClient.SqlParameter("@F6", System.Data.SqlDbType.Money, 0, "F6"),
            new System.Data.SqlClient.SqlParameter("@F7", System.Data.SqlDbType.Money, 0, "F7"),
            new System.Data.SqlClient.SqlParameter("@F8", System.Data.SqlDbType.Money, 0, "F8"),
            new System.Data.SqlClient.SqlParameter("@F9", System.Data.SqlDbType.Money, 0, "F9"),
            new System.Data.SqlClient.SqlParameter("@F10", System.Data.SqlDbType.Money, 0, "F10"),
            new System.Data.SqlClient.SqlParameter("@F11", System.Data.SqlDbType.Money, 0, "F11"),
            new System.Data.SqlClient.SqlParameter("@F12", System.Data.SqlDbType.Money, 0, "F12"),
            new System.Data.SqlClient.SqlParameter("@TotalProfitToDate", System.Data.SqlDbType.Money, 0, "TotalProfitToDate"),
            new System.Data.SqlClient.SqlParameter("@Type1", System.Data.SqlDbType.VarChar, 0, "Type1"),
            new System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.VarChar, 0, "Type2"),
            new System.Data.SqlClient.SqlParameter("@Type3", System.Data.SqlDbType.VarChar, 0, "Type3"),
            new System.Data.SqlClient.SqlParameter("@Type4", System.Data.SqlDbType.VarChar, 0, "Type4"),
            new System.Data.SqlClient.SqlParameter("@Type5", System.Data.SqlDbType.VarChar, 0, "Type5"),
            new System.Data.SqlClient.SqlParameter("@Type6", System.Data.SqlDbType.VarChar, 0, "Type6"),
            new System.Data.SqlClient.SqlParameter("@Type7", System.Data.SqlDbType.VarChar, 0, "Type7"),
            new System.Data.SqlClient.SqlParameter("@Type8", System.Data.SqlDbType.VarChar, 0, "Type8"),
            new System.Data.SqlClient.SqlParameter("@Type9", System.Data.SqlDbType.VarChar, 0, "Type9"),
            new System.Data.SqlClient.SqlParameter("@Type10", System.Data.SqlDbType.VarChar, 0, "Type10"),
            new System.Data.SqlClient.SqlParameter("@Type11", System.Data.SqlDbType.VarChar, 0, "Type11"),
            new System.Data.SqlClient.SqlParameter("@Type12", System.Data.SqlDbType.VarChar, 0, "Type12"),
            new System.Data.SqlClient.SqlParameter("@Date1", System.Data.SqlDbType.VarChar, 0, "Date1"),
            new System.Data.SqlClient.SqlParameter("@Date2", System.Data.SqlDbType.VarChar, 0, "Date2"),
            new System.Data.SqlClient.SqlParameter("@Date3", System.Data.SqlDbType.VarChar, 0, "Date3"),
            new System.Data.SqlClient.SqlParameter("@Date4", System.Data.SqlDbType.VarChar, 0, "Date4"),
            new System.Data.SqlClient.SqlParameter("@Date5", System.Data.SqlDbType.VarChar, 0, "Date5"),
            new System.Data.SqlClient.SqlParameter("@Date6", System.Data.SqlDbType.VarChar, 0, "Date6"),
            new System.Data.SqlClient.SqlParameter("@Date7", System.Data.SqlDbType.VarChar, 0, "Date7"),
            new System.Data.SqlClient.SqlParameter("@Date8", System.Data.SqlDbType.VarChar, 0, "Date8"),
            new System.Data.SqlClient.SqlParameter("@Date9", System.Data.SqlDbType.VarChar, 0, "Date9"),
            new System.Data.SqlClient.SqlParameter("@Date10", System.Data.SqlDbType.VarChar, 0, "Date10"),
            new System.Data.SqlClient.SqlParameter("@Date11", System.Data.SqlDbType.VarChar, 0, "Date11"),
            new System.Data.SqlClient.SqlParameter("@Date12", System.Data.SqlDbType.VarChar, 0, "Date12"),
            new System.Data.SqlClient.SqlParameter("@GeneratedBy", System.Data.SqlDbType.VarChar, 0, "GeneratedBy"),
            new System.Data.SqlClient.SqlParameter("@BatchID", System.Data.SqlDbType.Int, 0, "BatchID"),
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Company", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Company", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Company", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Project", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Project", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Project", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Investor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Investor", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Investor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Shares_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Shares_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Shares_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Shares_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtYear", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtYear", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtYear", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsAtPeriod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsAtPeriod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsAtPeriod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsAtPeriod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OriginalInvestment", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OriginalInvestment", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OriginalInvestment", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OriginalInvestment", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PreviousDisbursements", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PreviousDisbursements", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PreviousDisbursements", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PreviousDisbursements", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F1", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F3", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F4", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F5", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F6", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F7", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F8", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F9", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F10", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F11", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_F12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "F12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_F12", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "F12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TotalProfitToDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TotalProfitToDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TotalProfitToDate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TotalProfitToDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type4", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type5", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type6", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type7", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type8", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type9", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type10", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type11", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Type12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Type12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Type12", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date4", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date5", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date6", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date7", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date7", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date7", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date8", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date8", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date8", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date9", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date9", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date9", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date10", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date10", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date10", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date11", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date11", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date11", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Date12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date12", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Date12", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date12", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GeneratedBy", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GeneratedBy", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GeneratedBy", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GeneratedBy", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BatchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BatchID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BatchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BatchID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // dsContinuitySchedules1
            // 
            this.dsContinuitySchedules1.DataSetName = "dsContinuitySchedules";
            this.dsContinuitySchedules1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gc
            // 
            this.gc.DataMember = "LD_ContinuitySchedule";
            this.gc.DataSource = this.dsContinuitySchedules1;
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gc.Location = new System.Drawing.Point(0, 0);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(924, 663);
            this.gc.TabIndex = 3;
            this.gc.UseEmbeddedNavigator = true;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gv.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.gv.ColumnPanelRowHeight = 100;
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProject1,
            this.colInvestor1,
            this.colDistributionPercentage,
            this.colOriginalInvestment,
            this.colPreviousDisbursements,
            this.colF1,
            this.colF2,
            this.colF3,
            this.colF4,
            this.colF5,
            this.colF6,
            this.colF7,
            this.colF8,
            this.colF9,
            this.colF10,
            this.colF11,
            this.colF12});
            this.gv.GridControl = this.gc;
            this.gv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DistributionPercentage", this.colDistributionPercentage, "{0:P8}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OriginalInvestment", this.colOriginalInvestment, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PreviousDisbursements", this.colPreviousDisbursements, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "F1", this.colF1, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F2", this.colF2, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F3", this.colF3, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F4", this.colF4, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F5", this.colF5, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F6", this.colF6, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F7", this.colF7, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F8", this.colF8, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F9", this.colF9, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F10", this.colF10, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F11", this.colF11, "{0:#,##.##;[#,###.##]}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "F12", this.colF12, "{0:#,##.##;[#,###.##]}")});
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsView.ColumnAutoWidth = false;
            this.gv.OptionsView.ShowFooter = true;
            // 
            // colProject1
            // 
            this.colProject1.FieldName = "Project";
            this.colProject1.Name = "colProject1";
            this.colProject1.Visible = true;
            this.colProject1.VisibleIndex = 0;
            this.colProject1.Width = 175;
            // 
            // colInvestor1
            // 
            this.colInvestor1.FieldName = "Investor";
            this.colInvestor1.Name = "colInvestor1";
            this.colInvestor1.Visible = true;
            this.colInvestor1.VisibleIndex = 1;
            this.colInvestor1.Width = 130;
            // 
            // colDistributionPercentage
            // 
            this.colDistributionPercentage.DisplayFormat.FormatString = "{0:P8}";
            this.colDistributionPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDistributionPercentage.FieldName = "DistributionPercentage";
            this.colDistributionPercentage.Name = "colDistributionPercentage";
            this.colDistributionPercentage.SummaryItem.DisplayFormat = "{0:P8}";
            this.colDistributionPercentage.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDistributionPercentage.Tag = "";
            this.colDistributionPercentage.Visible = true;
            this.colDistributionPercentage.VisibleIndex = 2;
            this.colDistributionPercentage.Width = 134;
            // 
            // colOriginalInvestment
            // 
            this.colOriginalInvestment.DisplayFormat.FormatString = "{0:#,#0.00;[#,##0.00]}";
            this.colOriginalInvestment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOriginalInvestment.FieldName = "OriginalInvestment";
            this.colOriginalInvestment.Name = "colOriginalInvestment";
            this.colOriginalInvestment.SummaryItem.DisplayFormat = "{0:#,#0.00;[#,##0.00]}";
            this.colOriginalInvestment.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOriginalInvestment.Visible = true;
            this.colOriginalInvestment.VisibleIndex = 3;
            this.colOriginalInvestment.Width = 116;
            // 
            // colPreviousDisbursements
            // 
            this.colPreviousDisbursements.DisplayFormat.FormatString = "{0:#,#0.00;[#,##0.00]}";
            this.colPreviousDisbursements.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPreviousDisbursements.FieldName = "PreviousDisbursements";
            this.colPreviousDisbursements.Name = "colPreviousDisbursements";
            this.colPreviousDisbursements.SummaryItem.DisplayFormat = "{0:#,#0.00;[#,##0.00]}";
            this.colPreviousDisbursements.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPreviousDisbursements.Visible = true;
            this.colPreviousDisbursements.VisibleIndex = 4;
            this.colPreviousDisbursements.Width = 136;
            // 
            // colF1
            // 
            this.colF1.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF1.FieldName = "F1";
            this.colF1.Name = "colF1";
            this.colF1.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF1.Width = 90;
            // 
            // colF2
            // 
            this.colF2.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF2.FieldName = "F2";
            this.colF2.Name = "colF2";
            this.colF2.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF2.Width = 90;
            // 
            // colF3
            // 
            this.colF3.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF3.FieldName = "F3";
            this.colF3.Name = "colF3";
            this.colF3.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF3.Width = 90;
            // 
            // colF4
            // 
            this.colF4.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF4.FieldName = "F4";
            this.colF4.Name = "colF4";
            this.colF4.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF4.Width = 90;
            // 
            // colF5
            // 
            this.colF5.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF5.FieldName = "F5";
            this.colF5.Name = "colF5";
            this.colF5.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF5.Width = 90;
            // 
            // colF6
            // 
            this.colF6.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF6.FieldName = "F6";
            this.colF6.Name = "colF6";
            this.colF6.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF6.Width = 90;
            // 
            // colF7
            // 
            this.colF7.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF7.FieldName = "F7";
            this.colF7.Name = "colF7";
            this.colF7.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF7.Width = 90;
            // 
            // colF8
            // 
            this.colF8.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF8.FieldName = "F8";
            this.colF8.Name = "colF8";
            this.colF8.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF8.Width = 90;
            // 
            // colF9
            // 
            this.colF9.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF9.FieldName = "F9";
            this.colF9.Name = "colF9";
            this.colF9.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF9.Width = 90;
            // 
            // colF10
            // 
            this.colF10.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF10.FieldName = "F10";
            this.colF10.Name = "colF10";
            this.colF10.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF10.Width = 90;
            // 
            // colF11
            // 
            this.colF11.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF11.FieldName = "F11";
            this.colF11.Name = "colF11";
            this.colF11.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF11.Width = 90;
            // 
            // colF12
            // 
            this.colF12.DisplayFormat.FormatString = "{0:#,##.##;[#,###.##]}";
            this.colF12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colF12.FieldName = "F12";
            this.colF12.Name = "colF12";
            this.colF12.SummaryItem.DisplayFormat = "{0:#,##.##;[#,###.##]}";
            this.colF12.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colF12.Width = 90;
            // 
            // ucContinuity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc);
            this.Name = "ucContinuity";
            this.Size = new System.Drawing.Size(924, 663);
            this.Load += new System.EventHandler(this.ucContinuity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContinuitySchedules1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlTRConnection;
        private System.Data.SqlClient.SqlDataAdapter daContinuitySchedules;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private dsContinuitySchedules dsContinuitySchedules1;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn colProject1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvestor1;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginalInvestment;
        private DevExpress.XtraGrid.Columns.GridColumn colPreviousDisbursements;
        private DevExpress.XtraGrid.Columns.GridColumn colF1;
        private DevExpress.XtraGrid.Columns.GridColumn colF2;
        private DevExpress.XtraGrid.Columns.GridColumn colF3;
        private DevExpress.XtraGrid.Columns.GridColumn colF4;
        private DevExpress.XtraGrid.Columns.GridColumn colF5;
        private DevExpress.XtraGrid.Columns.GridColumn colF6;
        private DevExpress.XtraGrid.Columns.GridColumn colF7;
        private DevExpress.XtraGrid.Columns.GridColumn colF8;
        private DevExpress.XtraGrid.Columns.GridColumn colF9;
        private DevExpress.XtraGrid.Columns.GridColumn colF10;
        private DevExpress.XtraGrid.Columns.GridColumn colF11;
        private DevExpress.XtraGrid.Columns.GridColumn colF12;
    }
}
