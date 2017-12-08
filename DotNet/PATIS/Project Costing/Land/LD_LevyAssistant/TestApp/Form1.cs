using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc;

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(1600, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Test App";

            //con = new HMConnection.HMCon("web_dmd_gc_V11", "dev-sql2014\\dev2014", 13, "greg");

            con = new HMConnection.HMCon("WEB_DMD_CSM", "CSMSQL2012", 13, "greg");
            


            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();
            tuc.AppInit(con.MLUser);

            LD_LevyAssistant.ucLevyAssistant uc = new LD_LevyAssistant.ucLevyAssistant(con,tuc);
            uc.Dock = DockStyle.Fill;
            uc.Parent = this;


            tuc.FormInit(this);
        }

    }
}
