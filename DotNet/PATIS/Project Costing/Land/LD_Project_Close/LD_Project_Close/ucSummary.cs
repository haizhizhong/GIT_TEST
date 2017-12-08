using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Project_Close
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
            da_header.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(hmCon, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_ProjectClose);
            ucSubledgerPreview.Dock = DockStyle.Fill;
            ucSubledgerPreview.Parent = dpnlSubledgerPreview;
            LoadSegmentDescriptions();
        }

        private void LoadSegmentDescriptions()
        {
            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("exec dbo.sp_Proj_GLSwapSegs_WhseCount '" + hmCon.MLUser + "'", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error loading segment descriptions:" + hmCon.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Seg_Name"].ToString() != "")
                        colseg_2.Caption = dt.Rows[0]["Seg_Name"].ToString();
                    else
                    {
                        colseg_2.Visible = false;
                        colseg_2.OptionsColumn.ShowInCustomizationForm = false;
                    }
                    if (dt.Rows[0]["PC_Name"].ToString() != "")
                        colseg_3.Caption = dt.Rows[0]["PC_Name"].ToString();
                    else
                    {
                        colseg_3.Visible = false;
                        colseg_3.OptionsColumn.ShowInCustomizationForm = false;
                    }
                }
            }
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
                deInvoiceDate.DateTime = invoiceDate;
                ds_header1.Clear();
                da_header.Fill(ds_header1);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected project:" + ex.Message);
            }
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] saParam = new string[2, 5];
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


                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_ProjectCloseRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
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
            ucSubledgerPreview.ProcessSelection();
            if (ucSubledgerPreview.SubledgerValid)
            {
                isPre = "F";
                btnReporting.Text = "Print Register";
                btnReporting_Click(btnReporting, null);
                return true;
            }
            return false;
        }





    }
}
