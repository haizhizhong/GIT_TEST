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
        private HMConnection.HMCon con;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc;
        private LD_LotUnSellAssistant.ucPati pati;

        public Form1()
        {
            InitializeComponent();

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();

            //con = new HMConnection.HMCon("web_strike_test", "dev1", 12, "adam");
            con = new HMConnection.HMCon("WEB_GC_QA", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
            
            pati = new LD_LotUnSellAssistant.ucPati(con, tuc,null);
            pati.Dock = DockStyle.Fill;
            pati.Parent = this;
            tuc.AppInit(con.MLUser);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tuc.FormInit(this);
        }
    }
}
