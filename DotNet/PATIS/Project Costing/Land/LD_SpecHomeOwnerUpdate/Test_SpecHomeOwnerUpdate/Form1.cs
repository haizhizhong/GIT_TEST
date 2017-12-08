using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_SpecHomeUpdate
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
            
             hmConn = new HMConnection.HMCon("WEB_test", "dev12", 12, "ying");
          //  hmConn = new HMConnection.HMCon("web_qa_re", "csm-2005\\sql2008", 12, "ying");
            LD_SpecHomeOwnerUpdate.ucSpecHomeOwnerUpdate specHomeUpdate = new LD_SpecHomeOwnerUpdate.ucSpecHomeOwnerUpdate(hmConn, hmDevManager);
            specHomeUpdate.Dock = DockStyle.Fill;
            specHomeUpdate.Parent = this;
           
           


        }
    }
}
