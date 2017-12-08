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
            //HMConnection.HMCon ReflexCon = new HMConnection.HMCon("WEB_COMCO", "dev4", 12, "ying");
           
            TUC_HMDevXManager.TUC_HMDevXManager dxStyle = new TUC_HMDevXManager.TUC_HMDevXManager();
            dxStyle.AppInit("TEST");

            LD_ProgramFees.ucProgramFees ProgramFees = new LD_ProgramFees.ucProgramFees(ReflexCon, dxStyle);
            ProgramFees.Dock = DockStyle.Fill;
            ProgramFees.Parent = this;

            dxStyle.FormInit(this);
        }
    }
}
