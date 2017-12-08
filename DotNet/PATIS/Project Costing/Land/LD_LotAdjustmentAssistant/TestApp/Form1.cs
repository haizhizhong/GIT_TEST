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
        LD_LotAdjustmentAssistant.ucLotAdjustments pati;

        public Form1()
        {
            InitializeComponent();
            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();


            //con = new HMConnection.HMCon("web_strike_test", "dev1", 12, "adam");
            con = new HMConnection.HMCon("web_gc_test", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");




            pati = new LD_LotAdjustmentAssistant.ucLotAdjustments(con, tuc);
            pati.Dock = DockStyle.Fill;
            pati.Parent = this;
            tuc.AppInit(con.MLUser);
        }
    }
}
