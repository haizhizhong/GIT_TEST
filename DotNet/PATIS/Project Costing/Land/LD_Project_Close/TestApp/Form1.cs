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
        LD_Project_Close.ucProjectClose pati;


        public Form1()
        {
            InitializeComponent();

            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();


            con = new HMConnection.HMCon("web_gc_test", "dotnetsql\\dotnetsql", 12, "DevGreg");
            //con = new HMConnection.HMCon("WEB_WREDCO", "dev2", 12, "DevGreg");




            pati = new LD_Project_Close.ucProjectClose(con, tuc,null);
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
