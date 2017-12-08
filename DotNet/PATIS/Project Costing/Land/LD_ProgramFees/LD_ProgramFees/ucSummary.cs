using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProgramFees
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private string sPreReg = "T";
        private int iYear = 0;
        private int iPeriod = 0;
        private int iProgramFee_ID = -1;
        private bool bCancelMode = false;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConnection
        {
            get { return ReflexCon; }
            set { ReflexCon = value; }
        }

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        #endregion Properties

        #region Delegates and events

        public delegate void PrintedDelegate();
        public event PrintedDelegate Printed;

        #endregion Delegates and events

        public ucSummary(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;

            sqlTR.ConnectionString = ReflexCon.TRConnection;

            //Update Column names to new name after tie in.
            if (ReflexCon.CountryCode == "C")
            {
                colGSTAmount.Caption = "GST Amount";
                colPSTAmount.Caption = "PST Amount";
            }
            else
            {
                colGSTAmount.Caption = "Tax 1 Amount";
                colPSTAmount.Caption = "Tax 2 Amount";
            }

            acctYearPeriod1.TRDBName = ReflexCon.TRDB;
            acctYearPeriod1.TRServerName = ReflexCon.CompanyServer;
            acctYearPeriod1.luAcctYear.Properties.ReadOnly = true;
            acctYearPeriod1.luAcctPeriod.Properties.ReadOnly = true;
        }

        private void ucSummary_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        public void RefreshSummary(int Year, int Period, DateTime PODate, int ProgramFee_ID, bool CancelMode)
        {
            bCancelMode = CancelMode;
            acctYearPeriod1.luAcctYear.EditValue = Year;
            acctYearPeriod1.luAcctPeriod.EditValue = Period;
            dePODate.DateTime = PODate;
            iYear = Year;
            iPeriod = Period;
            iProgramFee_ID = ProgramFee_ID;

            sPreReg = "T";
            btnPrintRegister.Text = "Print Pre-Register";
            btnPrintCertificates.Enabled = false;

            dsSummary1.Clear();
            daSummary.SelectCommand.Parameters["@Username"].Value = ReflexCon.MLUser;
            daSummary.Fill(dsSummary1);
        }

        public bool ProcessSummary()
        {
            

            if (frmMessageBox.ShowPopup("Are you sure you want to process the selected PO's?", WS_Popups.frmPopup.PopupType.OK_Cancel) != WS_Popups.frmPopup.PopupResult.OK)
                return false;

            if (CreatePOs())
            {
                dsSummary1.Clear();
                daSummary.SelectCommand.Parameters["@Username"].Value = ReflexCon.MLUser;
                daSummary.Fill(dsSummary1);

                sPreReg = "F";
                btnPrintRegister.Text = "Print Register";
                if (!bCancelMode)
                    btnPrintCertificates.Enabled = true;
                else
                    btnPrintCertificates.Enabled = false;

                if (!bCancelMode)
                {
                    using (frmReportPrintDialog PrintDialog = new frmReportPrintDialog(ReflexCon, dxStyle, bCancelMode))
                    {
                        PrintDialog.PrintClick += new frmReportPrintDialog.PrintClickDelegate(PrintDialog_PrintClick);
                        PrintDialog.ShowDialog();
                    }
                }
                else
                    btnPrintRegister_Click(btnPrintRegister, new EventArgs());

                return true;
            }
            else
                return false;
        }

        private bool CreatePOs()
        {
            bool bUpdate = false;
            using (SqlConnection sqlCon = new SqlConnection(ReflexCon.TRConnection))
            {
                SqlTransaction sqlTrn = null;
                sqlCon.Open();

                try
                {
                    sqlTrn = sqlCon.BeginTransaction();
                    string sqlStr= "" ;
                    object result = DBNull.Value;
                    if (!bCancelMode)
                    {
                        sqlStr = "exec LD_lpf_UpdateProgramFees '" + ReflexCon.MLUser + "', " + iProgramFee_ID.ToString() + ", '" + dePODate.DateTime.ToShortDateString() + "' ";
                        SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlCon, sqlTrn);
                        result = sqlCmd.ExecuteScalar();
                        
                        if (result != null && result != DBNull.Value)
                        {
                            if (result.ToString() != "")
                            {
                                frmMessageBox.ShowPopup(result.ToString());
                                bUpdate = false;
                                sqlTrn.Rollback();
                                return false;
                            }
                        }
                        sqlTrn.Commit();
                        bUpdate = true;
                    }
                    else
                    {
                        result = ReflexCon.SQLExecutor.ExecuteScalar(@"select COUNT(* )
from LD_Proj_Agreement_ProgramFees a
join working_ld_lpf_LotList w on w.agreement_id = a.Agreement_ID and a.ProgramFees_ID = " + iProgramFee_ID.ToString() + @"
join PO_REC_HEADER h on h.PO_ID = a.PO_ID
join AP_GL_ALLOC ap on ap.PO_REC_ID = h.PO_REC_ID
where w.Username = '" + ReflexCon.MLUser + "' and w.Selected = 1", ReflexCon.TRConnection);
                        if (ReflexCon.SQLExecutor.Exception != null)
                            throw ReflexCon.SQLExecutor.Exception;
                        else if (Convert.ToInt32(result) > 0)
                        {
                            frmMessageBox.ShowPopup("An AP Invoice has been entered while you were canceling certificate.Certificate can not be canceled");
                            return false;
                        }

                        sqlStr = "exec LD_lpf_CancelProgramFees '" + ReflexCon.MLUser + "', " + iProgramFee_ID.ToString();
                        SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlCon, sqlTrn);
                        sqlCmd.ExecuteNonQuery();
                        sqlTrn.Commit();
                        bUpdate = true;

                    }
                    
                    
                }
                catch (SqlException ex)
                {
                    frmMessageBox.ShowPopup("Unable to update Program fees: " + ex.Message);
                    if (sqlTrn != null)
                        sqlTrn.Rollback();
                }
                catch(Exception ex)
                {
                    frmMessageBox.ShowPopup("Unable to update Program fees: " + ex.Message);
                    if (sqlTrn != null)
                        sqlTrn.Rollback();
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }

            return bUpdate;
        }

        private void PrintDialog_PrintClick(string Type)
        {
            if (Type == "R")
                btnPrintRegister_Click(btnPrintRegister, new EventArgs());
            else if (Type == "C")
                btnPrintCertificates_Click(btnPrintCertificates, new EventArgs());
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            ReflexCon.SQLExecutor.ExecuteNonQuery("Update working_ld_lpf_LotList Set SelectedYear = " + iYear.ToString() + ", SelectedPeriod = '" + acctYearPeriod1.luAcctPeriod.Text.Trim() + "', " +
                                                  " AR_Period = " + iPeriod.ToString() + ", " +
                                                  " CompanyName = '" + ReflexCon.CompanyName + "' " +
                                                  " Where username = '" + ReflexCon.MLUser + "' and selected = 1", ReflexCon.TRConnection);

            try
            {
                string[,] saParam = new string[2, 5];
                saParam[0, 0] = "@username";
                saParam[1, 0] = ReflexCon.MLUser;
                saParam[0, 1] = "@ProgramFee_ID";
                saParam[1, 1] = iProgramFee_ID.ToString();
                saParam[0, 2] = "@PODate";
                saParam[1, 2] = dePODate.DateTime.ToShortDateString();
                saParam[0, 3] = "@PreReport";
                saParam[1, 3] = sPreReg;
                saParam[0, 4] = "@CancelMode";
                saParam[1, 4] = bCancelMode ? "T" : "F";

                if (System.IO.File.Exists(ReflexCon.ReportPath + "\\LD_LotProgramFeeRegX.rpt"))
                {
                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(ReflexCon, dxStyle, saParam, "LD_LotProgramFeeRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        ReportPrinter.ShowDialog();
                    }
                }
                else
                {
                    frmMessageBox.ShowPopup("Unable to locate report: " + ReflexCon.ReportPath + "\\LD_LotProgramFeeRegX.rpt");
                }
            }
            catch
            {

            }

            if (Printed != null)
                Printed();
        }

        private void btnPrintCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] saParam = new string[2, 2];
                saParam[0, 0] = "@username";
                saParam[1, 0] = ReflexCon.MLUser;
                saParam[0, 1] = "@ProgramFee_ID";
                saParam[1, 1] = iProgramFee_ID.ToString();

                if (System.IO.File.Exists(ReflexCon.ReportPath + "\\LD_LotProgramFeeCertificateX.rpt"))
                {
                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(ReflexCon, dxStyle, saParam, "LD_LotProgramFeeCertificateX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        if (DialogResult.OK == ReportPrinter.ShowDialog())
                        {
                            string sql = "declare @username varchar(500) = '"+ReflexCon.MLUser+"',@ProgramFee_ID int = "+iProgramFee_ID.ToString()+ @"
UPDATE PO_HEADER set PRINTED = 'T',Status = case when status = 'Complete' then 'Complete' else 'Printed' end
from PO_Header h
join working_ld_lpf_LotList w on w.PO_ID = h.po_ID
Inner Join LD_Proj_ProgramFees ppf on ppf.pri_id = w.pri_id and ppf.ProgramFees_ID = @ProgramFee_ID
where w.Username = @username and w.Selected = 1";
                            ReflexCon.SQLExecutor.ExecuteNonQuery(sql, ReflexCon.TRConnection);
                            if(ReflexCon.SQLExecutor.Exception != null)
                                frmMessageBox.ShowPopup("Error updating po status to printed:" + ReflexCon.SQLExecutor.Exception.Message);
			
                        }
                    }
                }
                else
                {
                    frmMessageBox.ShowPopup("Unable to locate report: " + ReflexCon.ReportPath + "\\LD_LotProgramFeeCertificateX.rpt");
                }
            }
            catch
            {

            }
        }
    }
}
