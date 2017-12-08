using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp_LD_LotImport
{
    public partial class Form1 : Form
    {

        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;

        private LD_LotImport.ucImportPati ucpati;
        

        public Form1()
        {
            DevXMgr = new TUC_HMDevXManager.TUC_HMDevXManager();
            //Connection = new HMConnection.HMCon("web_strike_test", "dev1", 12, "adam");
            Connection = new HMConnection.HMCon("web_dmd_gc_v11", "dev-sql2014\\dev2014", 13, "greg");
            
            DevXMgr.AppInit(Connection.MLUser);
            InitializeComponent();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ucpati == null)
            {
                ucpati = new LD_LotImport.ucImportPati(Connection, DevXMgr,105);
                ucpati.Dock = DockStyle.Fill;
                ucpati.Parent = this;
                ucpati.BringToFront();
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            LD_LotImport.frmView frmpati = new LD_LotImport.frmView(Connection, DevXMgr,105);

                frmpati.ShowDialog();

                this.Text ="DialogResult = "+ frmpati.DialogResult.ToString();
            
        }
    }
}
