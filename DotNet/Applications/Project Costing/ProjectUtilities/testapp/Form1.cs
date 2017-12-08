using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMConnection;

namespace testapp
{
    public partial class Form1 : Form
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private HMCon Connection;

        public Form1()
        {
            DevXMgr = new TUC_HMDevXManager.TUC_HMDevXManager();
            DevXMgr.AppInit("adam");

            //Connection = new HMCon("web_resg_demo_c", "dev11", 12, "adam");
            Connection = new HMCon("web_test2", "dev12", 12, "ying");
            InitializeComponent();
                      
            //ProjectUtilities.Land.Processing.ucLOC pair = new ProjectUtilities.Land.Processing.ucLOC(Connection, DevXMgr);
            //pair.Dock = DockStyle.Fill;
            //pair.Parent = this;
                                    
            ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit LetterOfCredit = new ProjectUtilities.Land.Letter_Of_Credit.ucLetterOfCredit(Connection, DevXMgr);
            LetterOfCredit.RefreshMe(105);
            LetterOfCredit.Dock = DockStyle.Fill;
            LetterOfCredit.Parent = this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }
    }
}
