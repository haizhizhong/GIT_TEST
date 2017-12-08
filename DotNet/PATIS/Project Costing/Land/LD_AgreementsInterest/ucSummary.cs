using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_AgreementsInterest
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private string _searchUsername = "";
        Subledger_Preview.ucSubledger_Preview ucSubledgerPreview;
        private string isPre = "T";
        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, string searchusername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);

            _searchUsername = searchusername;
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            daSummary.SelectCommand.Parameters["@username"].Value = con.MLUser;

            ucSubledgerPreview = new Subledger_Preview.ucSubledger_Preview(con, tuc, Subledger_Preview.ucSubledger_Preview.Flavor.LD_AgreeInterest);
            ucSubledgerPreview.Dock = DockStyle.Fill;
            ucSubledgerPreview.Parent = dpSubledgerPreview;

        }

        public void RefreshMe(object period, string periodName, string year, DateTime InterestDate)
        {
            teYear.EditValue = year;
            tePeriod.EditValue = periodName;
            deInterestDate.EditValue = InterestDate;
            isPre = "T";
            

            string sql = "exec LD_AgreementInterestSummary '"+con.MLUser+"'";
            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading summary :" + con.SQLExecutor.Exception.Message);

            dsSummary1.Clear();
            daSummary.Fill(dsSummary1);

            ucSubledgerPreview.Reset();
            ucSubledgerPreview.AdditionalParams = new object[] { InterestDate.ToShortDateString() };
            ucSubledgerPreview.Year = Convert.ToInt32(year);
            ucSubledgerPreview.Period = Convert.ToInt32(period);
            ucSubledgerPreview.LoadPreview();

        }

        public bool ValidateSummary()
        {
            bool returnValue = true;

            return returnValue;
        }
        public void Finish()
        {
            isPre = "F";
            btnRegister.Text = "Print Register";
            ucSubledgerPreview.ProcessSelection();
        }

        private void ucSummary_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] saParam = new string[2, 6];
                saParam[0, 0] = "@username";
                saParam[1, 0] = con.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = isPre;
                saParam[0, 2] = "@InterestDate";
                saParam[1, 2] = deInterestDate.DateTime.ToShortDateString();
                saParam[0, 3] = "@Year";
                saParam[1, 3] = ucSubledgerPreview.Year.ToString();
                saParam[0, 4] = "@Period";
                saParam[1, 4] = ucSubledgerPreview.Period.ToString(); 
                saParam[0, 5] = "@SubledgerNum";
                saParam[1, 5] = ucSubledgerPreview.SubledgerNo;



                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(con, tuc_mgr, saParam, "LD_AgreeInterestRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    if (ReportPrinter.DialogResult == DialogResult.OK)
                        if (RegisterPrinted != null)
                            RegisterPrinted();

                }
            }
            catch(Exception ex)
            {
                pop.ShowPopup("Error loaing report:" + ex.Message);
            }
        }


        


    }
}
