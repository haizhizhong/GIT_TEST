using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotUnSellAssistant
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private HMConnection.HMCon hmCon;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        private WS_Popups.frmPopup popup;
        private Subledger_Preview.ucSubledger_Preview ucSubledgerPreview;
        private string isPre = "T";

        #endregion Local Variables

        #region Delegates and Events

        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;

        #endregion Delegates and Events

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_selectedLots.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "LotUnsellAssistant";
            ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(hmCon, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_LotUnSellAssistant);
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

        }

        private void ucSummary_Load(object sender, EventArgs e)
        {
            //tuc_mgr.FormInit(this);
        }

        public void RefreshMe(object period, string periodName, string year, DateTime invoiceDate)
        {
            ucSubledgerPreview.Reset();
            ucSubledgerPreview.AdditionalParams = new object[] { invoiceDate.ToShortDateString() };
            ucSubledgerPreview.Year = Convert.ToInt32(year);
            ucSubledgerPreview.Period = Convert.ToInt32(period);

            btnReporting.Text = "Print Pre-Register";
            try
            {
                isPre = "T";
                ucSubledgerPreview.LoadPreview();
                tePeriod.Text = periodName;
                teYear.Text = year;
                deUnSellDate.DateTime = invoiceDate;
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
                saParam[1, 4] = deUnSellDate.Text;
                saParam[0, 5] = "@Subledger";
                saParam[1, 5] = ucSubledgerPreview.SubledgerNo;


                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_LotUnSellRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
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

        public bool Finish()
        {
            if (popup.ShowPopup("Are you sure you want to process the listed lots and post to " + ucSubledgerPreview.GetPeriodName().Replace(ucSubledgerPreview.Period.ToString() + ", ", "") + " " + ucSubledgerPreview.Year.ToString() + " (Period " + ucSubledgerPreview.Period.ToString() + ")?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
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
    }
}
