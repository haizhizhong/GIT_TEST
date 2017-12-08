using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms; 
using DevExpress.XtraEditors;

namespace LD_LotSaleAssistant
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        Subledger_Preview.ucSubledger_Preview ucSubledgerPreview;
        private string isPre = "T";
        private bool bPreSales = false;
        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;
        private string _SaleType = "S";
        private int PreSaleSeq = -1;
        private bool isTierPresale = false;


        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;

            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            sqlTR.ConnectionString = hmCon.TRConnection;

            popup = new WS_Popups.frmPopup(tuc);
            da_selectedLots.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "LotSaleAssistant";
            ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(hmCon, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_LotSaleAssistant);
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

            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for Tier Pre-Sale:" + hmCon.SQLExecutor.Exception.Message);
            else if (Convert.ToBoolean(result))
            {
                isTierPresale = true;
            }
            else
            {
                colPresaleSeq.Visible = false;
                colPresaleSeq.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        public void RefreshMe(object period,string periodName,string year,DateTime invoiceDate,string PresaleType)
        {
            _SaleType = PresaleType;
            ucSubledgerPreview.Reset();
            ucSubledgerPreview.AdditionalParams = new object[] { invoiceDate.ToShortDateString(), PresaleType };
            ucSubledgerPreview.Year = Convert.ToInt32(year);
            ucSubledgerPreview.Period = Convert.ToInt32(period);

            bPreSales = (PresaleType.ToLower() == "p");

            if (bPreSales)
            {
                splitterControl1.Visible = gctlDeposits.Visible = true;
            }
            else
            {
                splitterControl1.Visible = gctlDeposits.Visible = false;
            }
            
            btnReporting.Text = "Print Pre-Register";
            try
            {
                isPre = "T";                
                ucSubledgerPreview.LoadPreview();
                tePeriod.Text = periodName;
                teYear.Text = year;
                deInvoiceDate.DateTime = invoiceDate;  
                ds_selectedLots1.Clear();
                da_selectedLots.Fill(ds_selectedLots1);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            if (bPreSales)
            {
                try
                {

                    hmCon.SQLExecutor.ExecuteNonQuery("exec LD_lsa_LoadPreSalesRPTInfo '" + hmCon.MLUser + "'", hmCon.TRConnection);

                    string[,] saParam = new string[2, 7];
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
                    saParam[0, 5] = "@SubNo";
                    saParam[1, 5] = ucSubledgerPreview.SubledgerNo;
                    saParam[0, 6] = "@Calling_Function";
                    saParam[1, 6] = "LSP";
                   

                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_LotPreSaleRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        ReportPrinter.ShowDialog();
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    string[,] saParam = new string[2, 7];
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
                    saParam[0, 5] = "@SubNo";
                    saParam[1, 5] = ucSubledgerPreview.SubledgerNo;
                    saParam[0, 6] = "@saleType";
                    saParam[1, 6] = _SaleType;


                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_LotSaleRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        ReportPrinter.ShowDialog();
                    }
                }
                catch
                {

                }
            }

            if (RegisterPrinted != null)
                RegisterPrinted();
        }

        public bool Finish()
        {
            if (popup.ShowPopup("Are you sure you want to process the following lots and post to " + ucSubledgerPreview.GetPeriodName().Replace( ucSubledgerPreview.Period.ToString() + ", ","") + " " + ucSubledgerPreview.Year.ToString() + " (Period " + ucSubledgerPreview.Period.ToString() + ")?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
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
            return false;
        }

        private void gvSummary_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bPreSales)
            {
                dsDepositsSummary1.Clear();

                if (e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle &&
                    e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle && gvSummary.GetDataRow(e.FocusedRowHandle) != null)
                {
                    int iAgreementID = 0;
                    try { iAgreementID = Convert.ToInt32(gvSummary.GetDataRow(e.FocusedRowHandle)["agreement_id"]); }
                    catch { }

                    string presql = @"select min(isnull(dep.PresaleSeq,-1))
		from PROJ_LOT_AGREEMENT_DEPOSITS dep
		join LD_Deposits d on d.Deposit_ID = dep.deposit_id
		join working_ld_LotSearch h on h.agreement_id=dep.agreement_id	
		where h.username='" + hmCon.MLUser + @"LotSaleAssistant' and h.selected = 1 and 
		ISNULL(d.type,'') = 'P' and isnull(dep.processed,'F') = 'F' and dep.agreement_id =" + iAgreementID.ToString();
                    object preresult = hmCon.SQLExecutor.ExecuteScalar(presql, hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                    {
                        popup.ShowPopup("Error checking for pre-sale sequence:" + hmCon.SQLExecutor.Exception.Message);

                    }
                    else if (preresult != null && preresult != DBNull.Value)
                    {
                        PreSaleSeq = Convert.ToInt32(preresult);
                    }
                    else
                        PreSaleSeq = -1;


                    daDepositsSummary.SelectCommand.Parameters["@agreement_id"].Value = iAgreementID;
                    daDepositsSummary.Fill(dsDepositsSummary1);
                }
            }
        }

        private void gvDeposit_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (isTierPresale && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                DataRow row = gvDeposit.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    int rowSeq = -1;
                    try { rowSeq = Convert.ToInt32(row[colPresaleSeq.FieldName]); }
                    catch { }
                    if (rowSeq != PreSaleSeq)
                    {
                        e.Appearance.BackColor = Color.LightGray;
                        e.Appearance.BackColor2 = Color.LightGray;

                    }
                }
            }
        }


    }
}
