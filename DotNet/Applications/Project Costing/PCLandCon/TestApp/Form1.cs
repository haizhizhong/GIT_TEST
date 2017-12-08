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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TUC_HMDevXManager.TUC_HMDevXManager dev = new TUC_HMDevXManager.TUC_HMDevXManager();
            //PCLandCon.ucPCLandCon pc = new PCLandCon.ucPCLandCon("web_demo_re", "dotnetsql\\dotnetsql", "12", "ken", dev);
            //PCLandCon.ucPCLandCon pc = new PCLandCon.ucPCLandCon("web_demo_re", "csm-2005\\sql2008", "12", "ken", dev);
            //PCLandCon.ucPCLandCon pc = new PCLandCon.ucPCLandCon("web_gc_test", "dotnetsql\\dotnetsql", "12", "DevGreg", dev);
            PCLandCon.ucPCLandCon pc = new PCLandCon.ucPCLandCon("web_test", "dev12", "12", "ying", dev);
            pc.Dock = DockStyle.Fill;
            pc.Parent = xtraTabPage1;


            //HMConnection.HMCon con = new HMConnection.HMCon("web_demo_re", "dotnetsql\\dotnetsql", 12, "ken");
            HMConnection.HMCon con = new HMConnection.HMCon("web_gc_test", "dotnetsql\\dotnetsql", 12, "DevGreg");
            CashFlow.ucSetup s = new CashFlow.ucSetup(con, dev, true);
            s.Dock = DockStyle.Fill;
            s.Parent = xtraTabPage2;
            s.InternalCreator = true;

            dev.AppInit(con.MLUser);
            dev.FormInit(this);
        }
    }
}
