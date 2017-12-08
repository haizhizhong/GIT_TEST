using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc;

        public Form1()
        {
            InitializeComponent();
            //con = new HMConnection.HMCon("WEB_DGGROUP_TEST", "CSMSQL2014", 18, "adam");
            //con = new HMConnection.HMCon("web_dmd_dev", "csmsql2012", 13, "robg");
            //con = new HMConnection.HMCon("web_gc_test", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
            //con = new HMConnection.HMCon("web_dmd_gc", "DEV-SQL2014\\DEV2014", 13, "greg");
            con = new HMConnection.HMCon("web_qa_re", "csmsql2012", 12, "Rob");

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();
            tuc.AppInit(con.MLUser);

            WS_Popups.frmPopup pop = new WS_Popups.frmPopup(tuc);

            LD_CashCall.PatiType type;

            if (pop.ShowPopup("Yes = Cash Call \r\n No == Distribution",WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                type = LD_CashCall.PatiType.Cashcall;
            else
                type = LD_CashCall.PatiType.Distribution;

            LD_CashCall.ucCashCallPati uc = new LD_CashCall.ucCashCallPati(con, tuc, type);
            uc.Dock = DockStyle.Fill;
            uc.Parent = this;
            
            
        }
    }
}
