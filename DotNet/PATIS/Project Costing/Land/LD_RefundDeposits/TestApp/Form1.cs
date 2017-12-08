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
        LD_RefundDeposits.ucRefundDeposits pati;
        public Form1()
        {
            InitializeComponent();
            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();

            //con = new HMConnection.HMCon("web_test2", "dev12", 12, "ying");
            con = new HMConnection.HMCon("web_gc_test", "dotnetsql\\dotnetsql", 12, "DevGreg");
            pati = new LD_RefundDeposits.ucRefundDeposits(con, tuc);
            pati.Dock = DockStyle.Fill;
            pati.Parent = this;
            tuc.AppInit(con.MLUser);
        }
    }
}
