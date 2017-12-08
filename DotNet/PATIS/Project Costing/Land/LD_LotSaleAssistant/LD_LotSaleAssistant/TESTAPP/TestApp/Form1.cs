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
        LD_LotSaleAssistant.ucPati pati;
        private KeyControlAccess.Validator KCA_Validator;
       
        private const int CONST_KCA_PROJECT_COSTING = 45;
        private string CONST_LAND_CONSTRUCTION_TYPE = "PCL";

        public Form1()
        {
            InitializeComponent();

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();

           
          //  con = new HMConnection.HMCon("web_gc_test", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
          
            con = new HMConnection.HMCon("WEB_test_v11", "dev12", 12, "ying");


            KCA_Validator = new KeyControlAccess.Validator(con, tuc, CONST_KCA_PROJECT_COSTING, CONST_LAND_CONSTRUCTION_TYPE);

            
            pati = new LD_LotSaleAssistant.ucPati(con, tuc, KCA_Validator);
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
