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
            HMConnection.HMCon ReflexCon = new HMConnection.HMCon("WEB_GC_TEST", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
            //HMConnection.HMCon ReflexCon = new HMConnection.HMCon("WEB_QA_RE", "csm-2005\\sql2008", 12, "ying");
            //HMConnection.HMCon ReflexCon = new HMConnection.HMCon("WEB_RGCF", "DOTNETSQL\\DOTNETSQL", 12, "mike");
            TUC_HMDevXManager.TUC_HMDevXManager dxStyle = new TUC_HMDevXManager.TUC_HMDevXManager();
            dxStyle.AppInit("Test");

            LD_ManagementFees.ucManagementFees ManagmentFees = new LD_ManagementFees.ucManagementFees(ReflexCon, dxStyle);
            ManagmentFees.Dock = DockStyle.Fill;
            ManagmentFees.Parent = this;
        }
    }
}
