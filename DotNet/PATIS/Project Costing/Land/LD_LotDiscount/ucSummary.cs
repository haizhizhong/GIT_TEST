using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotDiscount
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private string _searchUsername = "";
        Subledger_Preview.ucSubledger_Preview SubledgerPreview;
        public delegate void Delegate_PreRegisterPrinted();
        public event Delegate_PreRegisterPrinted PreRegisterPrinted;
        private bool _isPreRegister = true;
        private string _ActionType = "N";

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,string searchUsername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            _searchUsername = searchUsername;
            daAgreementSummary.SelectCommand.Parameters["@username"].Value = searchUsername;
            ucAccountingPicker1.ConnectionString = con.TRConnection;

            SubledgerPreview = new Subledger_Preview.ucSubledger_Preview(con, tuc_mgr, Subledger_Preview.ucSubledger_Preview.Flavor.LD_Discounts);
            SubledgerPreview.Dock = DockStyle.Fill;
            SubledgerPreview.Parent = dpSubledgerPreview;
        }

        public void RefreshMe(int GL_Year, int GL_Period, DateTime DiscountDate,string ActionType)
        {
            _ActionType = ActionType;
            _isPreRegister = true;
            btnRegister.Text = "Print Pre-Register";
            ucAccountingPicker1.SelectedPeriod = GL_Period;
            ucAccountingPicker1.SelectedYear = GL_Year;
            deDiscountDate.EditValue = DiscountDate;
            SubledgerPreview.Year = GL_Year;
            SubledgerPreview.Period = GL_Period;
            SubledgerPreview.AdditionalParams = new object[] { DiscountDate };
            SubledgerPreview.LoadPreview();

            try
            {
                dsAgreementSummary1.Clear();
                daAgreementSummary.Fill(dsAgreementSummary1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading summary:" + ex.Message);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            //LD_DiscountPati_Register @SearchUsername varchar(500),@ActionRequired varchar(1),@Year int,@Period int,@DiscountDate datetime,@subledger_number varchar(50)
            string[,] saParam = new string[2, 6];
            saParam[0, 0] = "@SearchUsername";
            saParam[1, 0] =_searchUsername;
            saParam[0, 1] = "@ActionRequired";
            saParam[1, 1] = _ActionType;
            saParam[0, 2] = "@Year";
            saParam[1, 2] = ucAccountingPicker1.SelectedYear.ToString();
            saParam[0, 3] = "@Period";
            saParam[1, 3] = ucAccountingPicker1.SelectedPeriod.ToString();
            saParam[0, 4] = "@DiscountDate";
            saParam[1, 4] = deDiscountDate.Text;
            saParam[0, 5] = "@subledger_number";
            saParam[1, 5] = SubledgerPreview.SubledgerNo;
           


            using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                new HM_Report_Printer.frmHM_Report_Printer(con, tuc_mgr, saParam, "LD_DiscountRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
            {
                DialogResult result =  ReportPrinter.ShowDialog();

                if(result == DialogResult.OK && PreRegisterPrinted != null && _isPreRegister)
                    PreRegisterPrinted();
            }

           
               
        }

        public bool Finish()
        {
            if (pop.ShowPopup("Are you sure you want to update?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                SubledgerPreview.ProcessSelection();
                btnRegister.Text = "Print Register";
                _isPreRegister = false;
                if(SubledgerPreview.ErrorMessage == "" || SubledgerPreview.ErrorMessage == "OK")
                    pop.ShowPopup("Update Complete");
                return true;
            }
            else
                return false;
        }
    }
}
