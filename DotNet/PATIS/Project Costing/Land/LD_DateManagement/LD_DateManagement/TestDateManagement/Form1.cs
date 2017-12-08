using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDateManagement
{
    public partial class Form1 : Form
    {
        
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevManager;
        

        public Form1()
        {
            InitializeComponent();
            LoadUserControls();
        }

        private void LoadUserControls()
        {
            hmDevManager = new TUC_HMDevXManager.TUC_HMDevXManager();
            hmDevManager.AppInit("ying");
            hmConn = new HMConnection.HMCon("web_comco", "dev4", 12, "ying");
           //  hmConn = new HMConnection.HMCon("web_qa_re", "csm-2005\\sql2008", 12, "hm");
            //hmConn = new HMConnection.HMCon("web_strike_test", "dev1", 12, "ying");
            hmConn = new HMConnection.HMCon("web_gc_test", "dotnetsql\\dotnetsql", 12, "DevGreg");
            LD_DateManagement.ucDateManagement dateManagement = new LD_DateManagement.ucDateManagement(hmConn, hmDevManager);
            dateManagement.Parent = this;
            dateManagement.Dock = DockStyle.Fill;
           

        }

    }
}
