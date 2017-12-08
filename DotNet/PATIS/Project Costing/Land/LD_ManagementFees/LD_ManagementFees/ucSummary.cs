using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ManagementFees
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private Subledger_Preview.ucSubledger_Preview SubledgerPreview;
        private string sPreReg = "T";
        private int iYear = 0;
        private int iPeriod = 0;

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
                colGST_Amount.Caption = "GST Amount";
                colPST_Amount.Caption = "PST Amount";
            }
            else
            {
                colGST_Amount.Caption = "Tax 1 Amount";
                colPST_Amount.Caption = "Tax 2 Amount";
            }

            SubledgerPreview = new Subledger_Preview.ucSubledger_Preview(ReflexCon, dxStyle, Subledger_Preview.ucSubledger_Preview.Flavor.LD_LotManagementFeesAssistant);
            SubledgerPreview.Dock = DockStyle.Fill;
            SubledgerPreview.Parent = dpSubledgerPreview;

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

        public void RefreshSummary(int Year, int Period, DateTime RecoveryDate)
        {
            acctYearPeriod1.luAcctYear.EditValue = Year;
            acctYearPeriod1.luAcctPeriod.EditValue = Period;
            deRecoveryDate.DateTime = RecoveryDate;
            iYear = Year;
            iPeriod = Period;

            SubledgerPreview.Year = iYear;
            SubledgerPreview.Period = iPeriod;
            SubledgerPreview.AdditionalParams = new object[] { RecoveryDate.ToShortDateString() };
            SubledgerPreview.LoadPreview();

            sPreReg = "T";
            btnPrintRegister.Text = "Print Pre-Register";

            dsSummary1.Clear();
            daSummary.SelectCommand.Parameters["@Username"].Value = ReflexCon.MLUser;
            daSummary.Fill(dsSummary1);
        }

        public bool ProcessSummary()
        {
            if (frmMessageBox.ShowPopup("Are you sure you want to process the selected invoices, and post to  " + acctYearPeriod1.luAcctPeriod.Text +
                        " " + iYear.ToString() + " (Period " + iPeriod.ToString() + ") ?", WS_Popups.frmPopup.PopupType.OK_Cancel) != WS_Popups.frmPopup.PopupResult.OK)
                return false;

            SubledgerPreview.ProcessSelection();

            if (SubledgerPreview.SubledgerValid)
            {
                sPreReg = "F";
                btnPrintRegister.Text = "Print Register";
                btnPrintRegister_Click(btnPrintRegister, new EventArgs());
                return true;
            }
            else
            {
                frmMessageBox.ShowPopup(SubledgerPreview.ErrorMessage);
                return false;
            }
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            ReflexCon.SQLExecutor.ExecuteNonQuery("Update working_ld_lmf_LotList Set SelectedYear = " + iYear.ToString() + ", SelectedPeriod = '" + acctYearPeriod1.luAcctPeriod.Text.Trim() + "', " +
                                                  " AR_Period = " + iPeriod.ToString() + ", SubledgerNumber = '" + SubledgerPreview.SubledgerNo + "', " +
                                                  " CompanyName = '" + ReflexCon.CompanyName + "' " +
                                                  " Where username = '" + ReflexCon.MLUser + "' and selected = 1", ReflexCon.TRConnection);

            try
            {
                string[,] saParam = new string[2, 3];
                saParam[0, 0] = "@username";
                saParam[1, 0] = ReflexCon.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = sPreReg;
                saParam[0, 2] = "@RecoveryDate";
                saParam[1, 2] = deRecoveryDate.DateTime.ToShortDateString();

                if (System.IO.File.Exists(ReflexCon.ReportPath + "\\LD_LotManagementFeesRegX.rpt"))
                {
                    using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                        new HM_Report_Printer.frmHM_Report_Printer(ReflexCon, dxStyle, saParam, "LD_LotManagementFeesRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                    {
                        ReportPrinter.ShowDialog();
                    }
                }
                else
                {
                    frmMessageBox.ShowPopup("Unable to locate report: " + ReflexCon.ReportPath + "\\LD_LotManagementFeesRegX.rpt");
                }
            }
            catch
            {

            }

            if (Printed != null)
                Printed();
        }
    }
}
