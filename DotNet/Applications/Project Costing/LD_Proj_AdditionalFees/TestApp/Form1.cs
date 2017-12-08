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
            HMConnection.HMCon ReflexCon = new HMConnection.HMCon("WEB_GC_TEST", "DOTNETSQL\\DOTNETSQL", 12, "DevGreg");
            TUC_HMDevXManager.TUC_HMDevXManager dxStyle = new TUC_HMDevXManager.TUC_HMDevXManager();
            dxStyle.AppInit("Test");

            LD_Proj_AdditionalFees.ucProjAdditionalFees ProjAdditionalFees = new LD_Proj_AdditionalFees.ucProjAdditionalFees(ReflexCon, dxStyle);
            ProjAdditionalFees.Dock = DockStyle.Fill;
            ProjAdditionalFees.Parent = this;
            ProjAdditionalFees.LoadAdditionalFees(53, false);

            dxStyle.FormInit(this);
        }
    }
}
