using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotPayoutAssistant
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        private int iPeriod = 0;
        Subledger_Preview.ucSubledger_Preview ucSubledgerPreview;
        private string isPre = "T";
        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;
        private bool IsMaster = false;
        private bool IsSingleDocProcessing = false;
        private bool IsInterim = false;

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_selectedLots.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "LotPayoutAssistant";
            ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(hmCon, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_LotPayoutAssistant);
            ucSubledgerPreview.Dock = DockStyle.Fill;
            ucSubledgerPreview.Parent = dpnlSubledgerPreview;
            if (hmCon.CountryCode == "U")
            {
                colprov.Caption = "State";
                colpostal.Caption = "Zip";
            }
            else if (hmCon.CountryCode == "C")
            {
                colprov.Caption = "Province";
                colpostal.Caption = "Postal Code";
            }

            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(Payout_SingleLotMasterDocuments,0) from LD_Setup", hmCon.TRConnection);
                        if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for Single Document Processing:" + hmCon.SQLExecutor.Exception.Message);
            else
            {
                try
                {
                    IsSingleDocProcessing = Convert.ToBoolean(result);
                     
                }
                catch { }

            }

        }

        public void RefreshMe(object period, string periodName, string year, DateTime invoiceDate,bool pIsInterim)
        {
            IsInterim = pIsInterim;
            if (IsInterim)
            {
                dpnlSubledgerPreview.Hide();
                btnRegister.Visible = false;
                lblInterimMessage.Visible = true;

            }
            else
            {
                
                dpnlSubledgerPreview.Show();
                btnRegister.Visible = true;
                lblInterimMessage.Visible = false;
            }

            btnRegister.Text = "Print Pre-Register";
            SetSolicitorDropDown();
            object result = hmCon.SQLExecutor.ExecuteScalar("select count(*) from working_ld_LotSearch where MasterAgreementNum is not null and selected = 1 and username = '" + hmCon.MLUser + "LotPayoutAssistant'", hmCon.TRConnection);
            IsMaster = false;
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for master agreement selection:" + hmCon.SQLExecutor.Exception.Message);
            else
            {
                try
                {
                    if (Convert.ToInt32(result) > 0)
                        IsMaster = true;
                }
                catch { }

            }
            try
            {
                colWordMergeButton.Visible = false;
                colWordMergeButton.OptionsColumn.ShowInCustomizationForm = false;
                colWordMerged.Visible = false;
                colWordMerged.OptionsColumn.ShowInCustomizationForm = false;

                dsSolicitor1.Clear();
                daSolicitor.Fill(dsSolicitor1);
                //call fill to update any additional/program fee changes.
                hmCon.SQLExecutor.ExecuteNonQuery("exec LD_lpa_FillCashToClose '" + hmCon.MLUser + "', " + (invoiceDate == null ? "null" : "'" + invoiceDate.ToShortDateString() + "'") + " ", hmCon.TRConnection);
                isPre = "T";
                ucSubledgerPreview.Reset();
                ucSubledgerPreview.AdditionalParams = new object[] { invoiceDate.ToShortDateString() };
                ucSubledgerPreview.Year = Convert.ToInt32(year);
                ucSubledgerPreview.Period = Convert.ToInt32(period);
                ucSubledgerPreview.LoadPreview();
                tePeriod.Text = periodName;
                teYear.Text = year;
                iPeriod = Convert.ToInt32(period);
                deInvoiceDate.DateTime = invoiceDate;
                ds_selectedLots1.Clear();
                da_selectedLots.Fill(ds_selectedLots1);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }
        }

        private void SetSolicitorDropDown()
        {

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("select top 1 r.Solicitor_ID from LD_Solicitor_Relation r join PROJ_LOT_AGREEMENT a on a.purchaser_id = r.Customer_ID where a.agreement_id in(select s.agreement_id from working_ld_LotSearch s where s.selected = 1 and s.username = '" + hmCon.MLUser + "LotPayoutAssistant')", hmCon.TRConnection);
            if (dt != null)
                if (dt.Rows.Count > 0)
                {
                    lueSolicitor.EditValue = dt.Rows[0]["Solicitor_ID"];
                    
                }
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            try
            {
                string reportName = "LD_LotPayoutStatmentX.rpt";

                string[,] saParam;
                if (IsMaster && !IsSingleDocProcessing)
                {
                    reportName = "LD_LotPayoutStatmentMstrX.rpt";
                    saParam = new string[2, 3];
                    saParam[0, 0] = "@Username";
                    saParam[1, 0] = hmCon.MLUser;
                    saParam[0, 1] = "@PayoutDate";
                    saParam[1, 1] = deInvoiceDate.Text;
                    saParam[0, 2] = "@Solicitor";
                    saParam[1, 2] = lueSolicitor.Text;
                }
                else
                {
                    saParam = new string[2, 6];
                    saParam[0, 0] = "@Username";
                    saParam[1, 0] = hmCon.MLUser;
                    saParam[0, 1] = "@PreReport";
                    saParam[1, 1] = isPre;
                    saParam[0, 2] = "@Year";
                    saParam[1, 2] = teYear.Text;
                    saParam[0, 3] = "@Period";
                    saParam[1, 3] = tePeriod.Text;
                    saParam[0, 4] = "@Date";
                    saParam[1, 4] = deInvoiceDate.Text;
                    saParam[0, 5] = "@RptType";
                    saParam[1, 5] = "P";
                }

                
               
                    

                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, reportName, HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    if (ReportPrinter.DialogResult == DialogResult.OK)
                    {
                        
                        string sql = "declare @username varchar(500) = '" + hmCon.MLUser.Replace("'", "''") + "',@Payout_Date datetime = '"+deInvoiceDate.DateTime.ToShortDateString()+"'" + @"
    update PROJ_LOT_AGREEMENT set
	Interest_Last_PerDiem_Statment = isnull((select top 1 PerDiem from working_ld_lpa_Interest where username = @username and working_ld_LotSearch_ID = w.ID order by ToDate Desc),0),
	Interest_Last_Payout_Date_Statment = @Payout_Date
	From PROJ_LOT_AGREEMENT la
	join working_ld_LotSearch w on w.agreement_id = la.agreement_id
	where w.username=@username+'LotPayoutAssistant' and w.selected = 1";

                        hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                        if (hmCon.SQLExecutor.Exception != null)
                            popup.ShowPopup("Error storing Per Diem Rate:" + hmCon.SQLExecutor.Exception.Message);
                    }
                     

                }
            }
            catch
            {

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isPre != "F")
            {
                object oCount = hmCon.SQLExecutor.ExecuteScalar("Select Count(0) From working_gl where username = '" + hmCon.MLUser + "' ", hmCon.TRConnection);
                int iCount = 0;
                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount <= 0)
                {
                    popup.ShowPopup("Register has no transactions to show.");
                    return;
                }
            }

            try
            {
                string[,] saParam = new string[2, 6];
                saParam[0, 0] = "@username";
                saParam[1, 0] = hmCon.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = isPre;
                saParam[0, 2] = "@PayoutDate";
                saParam[1, 2] = deInvoiceDate.DateTime.ToShortDateString();
                saParam[0, 3] = "@Year";
                saParam[1, 3] = teYear.Text;
                saParam[0, 4] = "@Period";
                saParam[1, 4] = iPeriod.ToString(); //tePeriod.Text;
                saParam[0, 5] = "@SubledgerNum";
                saParam[1, 5] = ucSubledgerPreview.SubledgerNo;



                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_LotPayoutRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    if (ReportPrinter.DialogResult == DialogResult.OK)
                        if (RegisterPrinted != null)
                            RegisterPrinted();

                }
            }
            catch
            {

            }
        }

        public bool ValidateSummary()
        {
            bool bValid = true;
            if (IsInterim)
            {

            }
            else
            {
                if (ucSubledgerPreview.ErrorMessage.Trim() != "" && ucSubledgerPreview.ErrorMessage.Trim() != "No Subledger Entry To Process.")
                {
                    popup.ShowPopup(ucSubledgerPreview.ErrorMessage.Trim());
                    bValid = false;
                }
            }
            return bValid;
        }

        public void Finish()
        {
            if (IsInterim)
            {
                
                string sql = "exec LD_lpa_SaveInterim '"+hmCon.MLUser+"'";
                hmCon.SQLExecutor.ExecuteNonQuery(sql,hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error saving interim:" + hmCon.SQLExecutor.Exception.Message);
            }
            else
            {
                ucSubledgerPreview.ProcessSelection();
                if (!IsSingleDocProcessing && IsMaster)
                {
                    //do nothing
                }
                else
                {
                    colWordMergeButton.Visible = true;
                    colWordMergeButton.OptionsColumn.ShowInCustomizationForm = true;
                    colWordMerged.Visible = true;
                    colWordMerged.OptionsColumn.ShowInCustomizationForm = true;
                }

                isPre = "F";
                btnRegister.Text = "Print Register";
                int AgreementID = -1;
                try
                {
                    if (!IsMaster)
                        AgreementID = Convert.ToInt32(gvSummary.GetDataRow(gvSummary.FocusedRowHandle)[colagreement_id.FieldName]);
                }
                catch
                {

                }

                using (frmReports ReportsFrm = new frmReports(hmCon, tuc_mgr, AgreementID))
                {
                    //Add Events
                    ReportsFrm.PrintRegister += new frmReports.DelegatePrintRegister(ReportsFrm_PrintRegister);
                    ReportsFrm.PrintStatement += new frmReports.DelegatePrintStatement(ReportsFrm_PrintStatement);
                    ReportsFrm.PrintCashToClose += new frmReports.DelegatePrintCashToClose(ReportsFrm_PrintCashToClose);

                    //Show dialog for printing
                    ReportsFrm.ShowDialog();

                    //Remove old event pointers for memory clean-up
                    ReportsFrm.PrintRegister -= new frmReports.DelegatePrintRegister(ReportsFrm_PrintRegister);
                    ReportsFrm.PrintStatement -= new frmReports.DelegatePrintStatement(ReportsFrm_PrintStatement);
                    ReportsFrm.PrintCashToClose -= new frmReports.DelegatePrintCashToClose(ReportsFrm_PrintCashToClose);



                }
            }
           
        }

        private void ReportsFrm_PrintCashToClose()
        {
            btnCashToClose_Click(btnCashToClose, new EventArgs());
        }

        private void ReportsFrm_PrintStatement()
        {
            btnReporting_Click(btnReporting, new EventArgs());
        }

        private void ReportsFrm_PrintRegister()
        {
            btnRegister_Click(btnRegister, new EventArgs());
        }

        private void btnCashToClose_Click(object sender, EventArgs e)
        {
            string report = "LD_CashToCloseX.rpt";

            if (IsMaster)
                report = "LD_CashToCloseMstrX.rpt";
            try
            {
                string[,] saParam = new string[2, 6];
                saParam[0, 0] = "@Username";
                saParam[1, 0] = hmCon.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = isPre;
                saParam[0, 2] = "@Year";
                saParam[1, 2] = teYear.Text;
                saParam[0, 3] = "@Period";
                saParam[1, 3] = tePeriod.Text;
                saParam[0, 4] = "@Date";
                saParam[1, 4] = deInvoiceDate.Text;
                saParam[0, 5] = "@RptType";
                saParam[1, 5] = "C";

                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, report, HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    if (ReportPrinter.DialogResult == DialogResult.OK)
                        if (RegisterPrinted != null)
                            RegisterPrinted();

                }
            }
            catch
            {

            }
        }

        private void riBeWordMerge_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            object oAgreementID = gvSummary.GetFocusedRowCellValue(colagreement_id);
            if (oAgreementID != DBNull.Value)
            {
                using (LD_Agree_WordMerge.frmAgreeDocs frm = new LD_Agree_WordMerge.frmAgreeDocs(hmCon, tuc_mgr, Convert.ToInt32(oAgreementID)))
                {
                    frm.DockType = LD_Agree_WordMerge.DocumentType.Payout;
                    frm.ShowDialog();
                    gvSummary.SetFocusedRowCellValue(colWordMerged, true);
                }
            }
        }

      
    }
}
