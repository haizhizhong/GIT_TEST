using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HMBaseReporting;

namespace LD_CashCall
{
    public partial class ucSummaryCashCall : DevExpress.XtraEditors.XtraUserControl
    {
        
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        public int BatchID = -1;
        Subledger_Preview.ucSubledger_Preview sp;
        PatiType _type;
        ucCashCallPati ccp;
        bool RoutingActive = false;
        WordMerge2003.ucDocumentMerge doc;
                

        public ucSummaryCashCall(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, int _BatchID,
            PatiType type, ucCashCallPati _ccp)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            _type = type;
            ccp = _ccp;
            pop = new WS_Popups.frmPopup(tuc);
            BatchID = _BatchID;
            sqlTRConnection.ConnectionString = con.TRConnection;
            sqlWEBConnection.ConnectionString = con.WebConnection;
            if (type == PatiType.Cashcall)
            {
                sp = new Subledger_Preview.ucSubledger_Preview(con, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_Cashcall);
                sp.Dock = DockStyle.Fill;
                sp.Parent = dockPanel1;
            }
            else
            {
                //no sp for this one
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                object oRoutingActive = con.SQLExecutor.ExecuteScalar(" select count(*) from approval_topic where active = 1 and id = 84",
                con.WebConnection);
                if (oRoutingActive != null && oRoutingActive != DBNull.Value && Convert.ToInt32(oRoutingActive) > 0)
                    RoutingActive = true;
            }
            acctYearPeriod1.TRDBName = con.TRDB;
            acctYearPeriod1.TRServerName = con.CompanyServer;
            acctYearPeriod1.RefreshAcctPeriod();
            deInvoiceDate.DateTime = DateTime.Now;
        }

        public void GenerateCashcall(bool Update)
        {
            try
            {
                labelControl2.Text = "Batch #" + BatchID;
                FillProjects();
                object oStatus = con.SQLExecutor.ExecuteScalar(@"
select BatchStatus FROM LD_CashcallDisbursementHeader WHERE id = " + BatchID, con.WebConnection);
                if (oStatus != null && oStatus.ToString() == "Posted")
                {
                    ccp.btnCancel.Enabled = false;
                    ccp.btnNext.Enabled = false;
                }
                /*
               else if (oStatus != null && oStatus.ToString() == "Approved")
               {
                   ccp.btnCancel.Enabled = true;
                   ccp.btnNext.Enabled = true;
                   ccp.btnNext.Text = "&Post Entries";
               }
               else if (oStatus != null && oStatus.ToString() == "Routed")
               {
                   ccp.btnCancel.Enabled = true;
                   ccp.btnNext.Enabled = false;
               }
               else if (oStatus != null && oStatus.ToString() == "Declined")
               {
                   ccp.btnCancel.Enabled = true;
                   ccp.btnNext.Enabled = false;
               }
                */
                else if (oStatus != null && oStatus.ToString() == "Created")
                {
                    ccp.btnCancel.Enabled = true;
                    ccp.btnNext.Enabled = true;

                    sp.ExecString = @"
BEGIN TRAN 
	declare @subledger_number int, @message varchar(500) 
	set @subledger_number = -1 
	set @message = '' 

    exec LD_UpdateARCashCall " + BatchID + ", " + acctYearPeriod1.luAcctYear.EditValue.ToString() +
            ", " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + ", 'F', '" + con.MLUser + "', '" + deInvoiceDate.DateTime + @"',
    @subledger_number output, @message output

	if( @message = 'OK' ) 
	begin 
	COMMIT TRAN  
end 
else 
begin 
	ROLLBACK TRAN 
end 	
	Select cast(@subledger_number as varchar(10))+'~'+@Message
";
                    if (Update)
                    {
                        sp.ExecString = @"
BEGIN TRAN 
	declare @subledger_number int, @message varchar(500) 
	set @subledger_number = -1 
	set @message = '' 

exec LD_UpdateARCashCall " + BatchID + ", " + acctYearPeriod1.luAcctYear.EditValue.ToString() +
        ", " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + ", 'T', '" + con.MLUser + "', '" + deInvoiceDate.DateTime + @"',
    @subledger_number output, @message output

	if( @message = 'OK' ) 
	begin 
	COMMIT TRAN  
end 
else 
begin 
	ROLLBACK TRAN 
end 	
	Select cast(@subledger_number as varchar(10))+'~'+@Message";

                        sp.ProcessSelection();
                    }
                    else
                    {
                        sp.LoadPreview();
                    }
                }
                RefreshLetters();
            }
            catch
            {
                pop.ShowPopup("Reflex has detected that this batch will not result in any cash calls being generated. Please review the previous screen to continue.");
                //return to previous page
                ccp.ResetCalculationsTab();
            }
        }
        public void GenerateDistribution(bool Update)
        {
            try
            {
                labelControl2.Text = "Batch #" + BatchID;
                FillProjects();
                //reorder columns to be distribution based
                colProject.Visible = false;
                colInvestor.Visible = false;
                colCallDate.Visible = false;
                colRequired.Visible = false;
                colDistribution.Visible = false;
                colAmount.Visible = false;
                colDate.Visible = false;
                colSite.Visible = false;
                colAddress.Visible = false;
                colCity.Visible = false;
                colState.Visible = false;
                colProportinate.Visible = false;
                colResponsibility.Visible = false;

                colProject.VisibleIndex = 0;
                colProject.Visible = true;
                colInvestor.VisibleIndex = 1;
                colInvestor.Visible = true;
                colCallDate.VisibleIndex = 2;
                colCallDate.Visible = true;
                colRequired.VisibleIndex = 3;
                colRequired.Visible = true;
                colDistribution.VisibleIndex = 4;
                colDistribution.Visible = true;
                colAmount.VisibleIndex = 5;
                colAmount.Visible = true;
                colDate.VisibleIndex = 6;
                colDate.Visible = true;
                colSite.VisibleIndex = 7; ;
                colSite.Visible = true;
                colAddress.VisibleIndex = 8;
                colAddress.Visible = true;
                colCity.VisibleIndex = 9;
                colCity.Visible = true;
                colState.VisibleIndex = 10;
                colState.Visible = true;
                colProportinate.VisibleIndex = 11;
                colProportinate.Visible = true;
                colResponsibility.VisibleIndex = 12;
                colResponsibility.Visible = true;
                gvProjects.BestFitColumns();
                ccp.btnNext.Text = "&Finish";
                object oStatus = con.SQLExecutor.ExecuteScalar(@"
select BatchStatus FROM LD_CashcallDisbursementHeader WHERE id = " + BatchID, con.WebConnection);
                if (oStatus != null && oStatus.ToString() == "Posted")
                {
                    ccp.btnCancel.Enabled = false;
                    ccp.btnNext.Enabled = false;
                }
                else if (oStatus != null && oStatus.ToString() == "Approved")
                {
                    ccp.btnCancel.Enabled = true;
                    ccp.btnNext.Enabled = true;
                    ccp.btnNext.Text = "&Create A/P Invoice";
                }
                else if (oStatus != null && oStatus.ToString() == "Routed")
                {
                    ccp.btnCancel.Enabled = true;
                    ccp.btnNext.Enabled = true;
                    if (!RoutingActive)
                        ccp.btnNext.Text = "&Create A/P Invoice";
                    else
                        ccp.btnNext.Text = "&Re-Route For Approval";
                }
                else if (oStatus != null && oStatus.ToString() == "Declined")
                {
                    ccp.btnCancel.Enabled = true;
                    ccp.btnNext.Enabled = true;
                    if (!RoutingActive)
                        ccp.btnNext.Text = "&Create A/P Invoice";
                    else
                        ccp.btnNext.Text = "&Re-Route For Approval";
                }
                else if (oStatus != null && oStatus.ToString() == "Created")
                {
                    ccp.btnCancel.Enabled = true;
                    ccp.btnNext.Enabled = true;
                    if (!RoutingActive)
                        ccp.btnNext.Text = "&Create A/P Invoice";
                    else
                        ccp.btnNext.Text = "&Route For Approval";
                }
                if (oStatus.ToString() == "Created" || oStatus.ToString() == "Declined" || oStatus.ToString() == "Routed"
                     || oStatus.ToString() == "Approved")
                {
                    string ExecString = @"
BEGIN TRAN 
	declare @message varchar(500) 
	set @message = '' 

    exec LD_UpdateAPDistribution " + BatchID + ", " + acctYearPeriod1.luAcctYear.EditValue.ToString() +
            ", " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + ", 'F', '" + con.MLUser + "', '" + deInvoiceDate.DateTime + @"',
    @message output

	if( @message = 'OK' ) 
	begin 
	COMMIT TRAN  
end 
else 
begin 
	ROLLBACK TRAN 
end 	
	Select @Message
";
                    if (Update)
                    {
                        ExecString = @"
BEGIN TRAN 
	declare @message varchar(500) 
	set @message = '' 

exec LD_UpdateAPDistribution " + BatchID + ", " + acctYearPeriod1.luAcctYear.EditValue.ToString() +
        ", " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + ", 'T', '" + con.MLUser + "', '" + deInvoiceDate.DateTime + @"',
    @message output

	if( @message = 'OK' ) 
	begin 
	COMMIT TRAN  
end 
else 
begin 
	ROLLBACK TRAN 
end 	
	Select @Message";
                        object obj = con.SQLExecutor.ExecuteScalar(ExecString, con.TRConnection);
                        if (obj != null)
                        {
                            string Message = obj.ToString();
                            if (Message != "OK")
                            {
                                pop.ShowPopup(Message);
                                //return to previous page
                                ccp.ResetCalculationsTab();
                            }
                        }
                    }
                    else
                    {
                        object obj = con.SQLExecutor.ExecuteScalar(ExecString, con.TRConnection);
                        if (obj != null)
                        {
                            string Message = obj.ToString();
                            if (Message != "OK")
                            {
                                pop.ShowPopup(Message);
                                //return to previous page
                                ccp.ResetCalculationsTab();
                            }
                        }
                    }
                }
                RefreshLetters();
                RefreshContinuitySchedules();
            }
            catch
            {
                pop.ShowPopup("Reflex has detected that this batch will not result in any distributions being generated. Please review the previous screen to continue.");
                //return to previous page
                ccp.ResetCalculationsTab();
            }
        }
        public bool RefreshData = false;//used to refresh without recreating tabs
        private void RefreshContinuitySchedules()
        {
            tpCS.PageVisible = true;
            con.SQLExecutor.ExecuteNonQuery(@"                
    exec LD_DistributionContinuitySchedule " + acctYearPeriod1.luAcctYear.EditValue.ToString() +
        ", " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + ", '" + con.MLUser + "', " + BatchID, con.TRConnection);

            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(@"
select distinct pri_id, Project from LD_ContinuitySchedule where BatchID = " + BatchID + " and GeneratedBy = '" + con.MLUser + "'", con.TRConnection);
            dsContinuityProjects1.Tables[0].Clear();
            daContinuityProjects.SelectCommand.Parameters["@username"].Value = con.MLUser;
            daContinuityProjects.SelectCommand.Parameters["@BatchID"].Value = BatchID;
            daContinuityProjects.Fill(dsContinuityProjects1);
            if (!RefreshData)
            {
                while (tcCS.TabPages.Count > 1)
                    tcCS.TabPages.RemoveAt(1);//keep the first page
                foreach (DataRow dr in dt.Rows)
                {
                    DevExpress.XtraTab.XtraTabPage tp = tcCS.TabPages.Add(dr["Project"].ToString());
                    ucContinuity uc = new ucContinuity(con, tuc_mgr, BatchID, Convert.ToInt32(dr["pri_id"]));
                    tp.Tag = uc;
                    uc.Tag = dr;
                    uc.Dock = DockStyle.Fill;
                    uc.Parent = tp;
                }
            }
            else
            {
                foreach (DevExpress.XtraTab.XtraTabPage tp in tcCS.TabPages)
                {
                    ucContinuity uc = (ucContinuity)tp.Tag;
                    uc.RefreshData();
                }
            }
        }
        private void FillProjects()
        {
            daProjects.SelectCommand.Parameters["@Type"].Value = _type.ToString();
            daProjects.SelectCommand.Parameters["@BatchID"].Value = BatchID;
            dsProjects1.Tables[0].Clear();
            daProjects.Fill(dsProjects1);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        bool Loaded = false;
        private void ucSummaryCashCall_Load(object sender, EventArgs e)
        {
            if (_type == PatiType.Cashcall)
                GenerateCashcall(false);   
            else
                GenerateDistribution(false);
            Loaded = true;
            tuc_mgr.FormInit(this);
        }

        private void deInvoiceDate_EditValueChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                if (_type == PatiType.Cashcall)
                    GenerateCashcall(false);
                else
                    GenerateDistribution(false);
            }
        }

        private void tcSummary_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            RefreshLetters();
        }

        private void RefreshLetters()
        {
            if (_type == PatiType.Cashcall)
            {
                if (doc == null)
                {
                    doc = new WordMerge2003.ucDocumentMerge(con, tuc_mgr, (int)3, "LAND_CC", BatchID);
                    doc.HideElectronicSave();
                    doc.Dock = DockStyle.Fill;
                    doc.Parent = tpMerge;
                    doc.BringToFront();
                }
                else
                    doc.RefreshMe(BatchID, "LAND_CC");
            }
            else
            {
                if (doc == null)
                {
                    doc = new WordMerge2003.ucDocumentMerge(con, tuc_mgr, (int)5, "LAND_DISB", BatchID);
                    doc.HideElectronicSave();
                    doc.Dock = DockStyle.Fill;
                    doc.Parent = tpMerge;
                    doc.BringToFront();
                }
                else
                    doc.RefreshMe(BatchID, "LAND_DISB");
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            string[,] saParams;
            saParams = new string[2, 2];
            saParams[0, 0] = "@username";
            saParams[1, 0] = con.MLUser;
            saParams[0, 1] = "@batch_id";
            saParams[1, 1] = BatchID.ToString();
            HMReport rpt;
            rpt = new HMReport(con.ReportPath + "\\LD_ContinuitySched.rpt", con.CompanyServer, con.TRDB, saParams, con.CompanyID);
            rpt.ViewReport();	
        }

        private void gvProjects_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colRequired)
            {
                DataRow dr = gvProjects.GetDataRow(e.RowHandle);
                if (dr == null)
                    return;

                if (_type == PatiType.Cashcall)
                {
                    con.SQLExecutor.ExecuteNonQuery(@"
declare @Required money = " + e.Value.ToString() + @", 
@BatchID int = " + dr["BatchID"].ToString() + @", 
@Pri_ID int = " + dr["pri_ID"].ToString() + @"
update LD_CashcallDisbursementDetail set
[Required] = @Required,
Amount = (@Required * (Responsibility / 100)) * -1 
where BatchID = @BatchID
and pri_id = @Pri_ID
", con.WebConnection);
                }
                else
                {
                    con.SQLExecutor.ExecuteNonQuery(@"
declare @Required money = " + e.Value.ToString() + @", 
@BatchID int = " + dr["BatchID"].ToString() + @", 
@Pri_ID int = " + dr["pri_ID"].ToString() + @"
update LD_CashcallDisbursementDetail set
[Required] = @Required,
Amount = (@Required * (Distribution / 100))
where BatchID = @BatchID
and pri_id = @Pri_ID
", con.WebConnection);
                }
                FillProjects();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //setup report options & project driver tables
            con.SQLExecutor.ExecuteNonQuery(@"
declare @username varchar(10) = '"+con.MLUser+ @"',
@TO_YEAR int = "+acctYearPeriod1.luAcctYear.EditValue.ToString()+ @",
@TO_Period int = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + @"
delete LD_Report_Project_List where username = @username
delete LD_REPORT_OPTIONS where username = @username
insert LD_REPORT_OPTIONS(Run_Description, TO_YEAR, TO_PERIOD, username)
select 'All Projects Included - Run From Distribution Assistant', @TO_YEAR, @TO_PERIOD, @username
", con.TRConnection);
            string[,] saParams;
            saParams = new string[2, 1];
            saParams[0, 0] = "@username";
            saParams[1, 0] = con.MLUser;
            HMReport rpt;
            rpt = new HMReport(con.ReportPath + "\\LD_ContinuitySchedConsolidated.rpt", con.CompanyServer, con.TRDB, saParams, con.CompanyID);
            rpt.ViewReport();
        }
    }
}
