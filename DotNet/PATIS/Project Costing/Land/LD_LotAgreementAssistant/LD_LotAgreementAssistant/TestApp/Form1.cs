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
        LD_LotAgreementAssistant.ucPati pati;
        public Form1()
        {
            InitializeComponent();

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();


            //con = new HMConnection.HMCon("web_strike_test","dev1",12,"adam");
            con = new HMConnection.HMCon("web_dmd_gc_v11", "dev-sql2014\\dev2014", 13, "greg");
           

            KeyControlAccess.Validator KCA_Validator = new KeyControlAccess.Validator(con, tuc, 45, "PCL");


            pati = new LD_LotAgreementAssistant.ucPati(con, tuc);
            pati.KCA_Validator = KCA_Validator;
            pati.Dock = DockStyle.Fill;
            pati.Parent = this;
            tuc.AppInit(con.MLUser);
        }
    }
}
