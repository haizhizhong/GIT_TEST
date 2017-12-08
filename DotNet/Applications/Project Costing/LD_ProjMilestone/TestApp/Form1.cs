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

        LD_ProjMilestone.ucProjMilestone uc;

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;


        public Form1()
        {
            InitializeComponent();
            lueProject.EditValue = -1;
            
            con = new HMConnection.HMCon("web_gc_test","dotnetsql\\dotnetsql",12,"DevGreg");


            tuc_mgr = new TUC_HMDevXManager.TUC_HMDevXManager();
            tuc_mgr.AppInit(con.MLUser);

            sqlConnection1.ConnectionString = con.TRConnection;
            daProjHeader.Fill(dsProjHeader1);
        }

        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                lueProject.EditValue = -1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if(uc == null)
            {
                uc = new LD_ProjMilestone.ucProjMilestone(con,tuc_mgr,null);
                uc.Dock = DockStyle.Fill;
                uc.Parent = this;
                uc.BringToFront();
                
            }
            
            uc.SetReadOnly(ceReadOnly.Checked);
            uc.RefreshMe(Convert.ToInt32(lueProject.EditValue));

        }





    }
}
