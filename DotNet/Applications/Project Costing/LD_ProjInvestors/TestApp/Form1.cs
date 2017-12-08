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
        private HMConnection.HMCon con;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc;

        private LD_ProjInvestors.ucProjInvestors ucEditable;
        private LD_ProjInvestors.ucProjInvestors ucReadOnly;

        public Form1()
        {
            InitializeComponent();

            con = new HMConnection.HMCon("web_gc_test", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
            //con = new HMConnection.HMCon("web_dmd_gc", "DEV-SQL2014\\DEV2014", 13, "greg");


            tuc = new TUC_HMDevXManager.TUC_HMDevXManager();
            tuc.AppInit(con.MLUser);
            sqlTRConnection.ConnectionString = con.TRConnection;

            daProjHeader.Fill(dsProjHeader1);
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            if (lueProjHeader.EditValue != null && lueProjHeader.EditValue != DBNull.Value)
            {
                if (ucEditable == null)
                {
                    ucEditable = new LD_ProjInvestors.ucProjInvestors(con,tuc);
                    ucEditable.Dock = DockStyle.Fill;
                    ucEditable.Parent = xtraTabPage1;
                }

                if (ucReadOnly == null)
                {
                    ucReadOnly = new LD_ProjInvestors.ucProjInvestors(con, tuc);
                    ucReadOnly.Dock = DockStyle.Fill;
                    ucReadOnly.Parent = xtraTabPage2;
                    ucReadOnly.SetReadOnlyMode(true);
                }

                ucEditable.RefreshDetails((int)lueProjHeader.EditValue);
                ucReadOnly.RefreshDetails((int)lueProjHeader.EditValue);
            }


        }




    }
}
