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
        LD_LotPayoutAssistant.ucPati pati;
        private const int CONST_KCA_PROJECT_COSTING = 45;
        private string CONST_LAND_CONSTRUCTION_TYPE = "PCL";

        public Form1()
        {
            InitializeComponent();

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();


            con = new HMConnection.HMCon("web_dmd_gc_v11", "dev-sql2014\\dev2014", 13, "greg");
            //con = new HMConnection.HMCon("web_QA_RE", "csm-2005\\sql2008", 12, "JohnB");
            

            KeyControlAccess.Validator KCA_Validator = new KeyControlAccess.Validator(con, tuc, CONST_KCA_PROJECT_COSTING, CONST_LAND_CONSTRUCTION_TYPE);
            KCA_Validator.MenuBar = bar2;

            pati = new LD_LotPayoutAssistant.ucPati(con, tuc, KCA_Validator);
            pati.Dock = DockStyle.Fill;
            pati.Parent = this;
            tuc.AppInit(con.MLUser);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tuc.FormInit(this);
        }


    }
}
