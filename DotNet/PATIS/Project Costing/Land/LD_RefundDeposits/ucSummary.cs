using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RefundDeposits
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        Subledger_Preview.ucSubledger_Preview ucSubledgerPreview;
        private string isPre = "T";
        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();
            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);

            acctYearPeriod1.TRDBName = hmCon.TRDB;
            acctYearPeriod1.TRServerName = hmCon.CompanyServer;
            acctYearPeriod1.checkClose = "T"; //Turns on/off Open period check.
           
         
           ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(hmCon, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_DepositRefund);
            ucSubledgerPreview.Dock = DockStyle.Fill;
            ucSubledgerPreview.Parent = dpnlSubledgerPreview;

        }
        public bool Finish()
        {
            if (RefundPastPayment())
            {
                if (isDateInValid())
                {
                }
                else
                {
                    ucSubledgerPreview.Reset();
                    ucSubledgerPreview.AdditionalParams = new object[] { deDate.DateTime.ToShortDateString() };
                    ucSubledgerPreview.Year = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue);
                    ucSubledgerPreview.Period = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue);
                    if (popup.ShowPopup("Are you sure you want to continue and post to " + ucSubledgerPreview.GetPeriodName().Replace(ucSubledgerPreview.Period.ToString() + ", ", "") + " " + ucSubledgerPreview.Year.ToString() + " (Period " + ucSubledgerPreview.Period.ToString() + ")?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                    {
                        ucSubledgerPreview.ProcessSelection();
                        if (ucSubledgerPreview.SubledgerValid)
                        {
                            isPre = "F";
                            btnReporting.Text = "Print Register";
                            btnReporting_Click(btnReporting, null);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            if (isDateInValid())
            {
            }
            else if (RefundPastPayment())
            {
                try
                {
                    string[,] saParam = new string[2, 6];
                    saParam[0, 0] = "@Username";
                    saParam[1, 0] = hmCon.MLUser;
                    saParam[0, 1] = "@PreReport";
                    saParam[1, 1] = isPre;
                    saParam[0, 2] = "@Year";
                    saParam[1, 2] = acctYearPeriod1.luAcctYear.EditValue.ToString();
                    saParam[0, 3] = "@Period";
                    saParam[1, 3] = acctYearPeriod1.luAcctPeriod.Text.ToString();
                    saParam[0, 4] = "@Date";
                    saParam[1, 4] = deDate.Text;
                    saParam[0, 5] = "@Subledger";
                    saParam[1, 5] = ucSubledgerPreview.SubledgerNo;


                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_DepositRefundRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        ReportPrinter.ShowDialog();
                    }
                }
                catch
                {

                }

                if (RegisterPrinted != null)
                    RegisterPrinted();
            }
        }
        public void RefreshMe()
        {
            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("select p.PERIOD,p.AR_YEAR,p.END_DATE from AR_PERIODS p join AR_SETUP s on case when s.CURRENT_PERIOD = 13 then 12 else s.CURRENT_PERIOD end = p.PERIOD and s.CURRENT_YEAR = p.AR_YEAR", hmCon.TRConnection);

            if (dt.Rows.Count > 0)
            {
                acctYearPeriod1.luAcctYear.EditValue = dt.Rows[0]["AR_YEAR"];
                acctYearPeriod1.luAcctPeriod.EditValue = dt.Rows[0]["PERIOD"];
                deDate.DateTime = Convert.ToDateTime(dt.Rows[0]["END_DATE"]);
            }
          
            ucSubledgerPreview.Reset();
            ucSubledgerPreview.AdditionalParams = new object[] { deDate.DateTime.ToShortDateString() };
            ucSubledgerPreview.Year = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue);
            ucSubledgerPreview.Period = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue);

            btnReporting.Text = "Print Pre-Register";
            try
            {
                isPre = "T";
                ucSubledgerPreview.LoadPreview();
                       
                dsSummary1.Clear();
                daSummary.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "RefundDeposit";
                daSummary.Fill(dsSummary1);

            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected Refund Info" + ex.Message);
            }
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            isDateInValid();
        }

        private bool RefundPastPayment()
        {
            bool returnvalue = false;
            string sql = "declare @year int = "+acctYearPeriod1.luAcctYear.EditValue.ToString()+",@period int = "+acctYearPeriod1.luAcctPeriod.EditValue.ToString()+@"
select agreement_num,deposit_type,deposit_amt from working_ld_LotSearch where username = '"+hmCon.MLUser+@"RefundDeposit' and selected = 1 
and ((gl_year = @year and gl_period > @period) or gl_year > @year  )";
            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for deposit payment period:" + hmCon.SQLExecutor.Exception.Message);
            else
            {
                if (dt.Rows.Count > 0)
                {
                    popup.ShowPopup(dt.Rows[0]["deposit_type"].ToString() + " deposit payment of " + String.Format("{0:N2}", dt.Rows[0]["deposit_amt"]) + " for agreement " + dt.Rows[0]["agreement_num"].ToString() + " was made after selected year/period.");
                }
                else
                    returnvalue = true;
            }
        


            return returnvalue;
        }


        private bool isDateInValid()
        {
            bool returnValue = true;
            if (deDate.EditValue != DBNull.Value && deDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deDate.DateTime.ToShortDateString() + "' and PERIOD <> 13  order by END_DATE";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting year and period from invoice date:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() == dt.Rows[0]["PERIOD"].ToString()
                           && acctYearPeriod1.luAcctYear.EditValue.ToString() == dt.Rows[0]["AR_YEAR"].ToString())
                        {
                            returnValue = false;
                        }
                    }
                }

                if (returnValue)
                {
                    popup.ShowPopup("Refund date must be within the selected year/period.");
                    
                }

            }
            else
            {
                popup.ShowPopup("Refund date is required.");
                
            }



            return returnValue;
        }
        //
    }
}
