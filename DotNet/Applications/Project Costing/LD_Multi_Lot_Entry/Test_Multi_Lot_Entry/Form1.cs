using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Multi_Lot_Entry
{
    public partial class Form1 : Form
    {
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevManager;

        public Form1()
        {
            InitializeComponent();
           // LoadUserControls();
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            hmDevManager = new TUC_HMDevXManager.TUC_HMDevXManager();
            hmDevManager.AppInit("ying");
            hmConn = new HMConnection.HMCon("WEB_COS_CONV_APR_V10", "DOTNETSQL\\DOTNETSQL", 12, "BRIAN BELL");

            int _Lot_ID = 6132;// 140;// 8;
            int _PriID = 64;// 127; //211;
            using (Form frmEntry = new Form())
            {

                using (LD_Multi_Lot_Entry.ucMulti_Lot_Entry multiLotEntry = new LD_Multi_Lot_Entry.ucMulti_Lot_Entry(hmConn, hmDevManager, _Lot_ID, _PriID))
                {
                    multiLotEntry.frm = frmEntry;
                    frmEntry.Size = new Size(multiLotEntry.Width, multiLotEntry.Height);
                    frmEntry.WindowState = FormWindowState.Maximized;
                    frmEntry.StartPosition = FormStartPosition.CenterScreen;
                    multiLotEntry.Parent = frmEntry;
                    multiLotEntry.Dock = DockStyle.Fill;


                    frmEntry.Text = "";
                   
                    frmEntry.ShowDialog();
                    frmEntry.Dispose();
                }

            }

            //LoadMultiEntry(_Lot_ID, _PriID);
        }

        private void LoadMultiEntry(int pLotID, int pPriID)
        {
            LD_Multi_Lot_Entry.frmEntry frm = new LD_Multi_Lot_Entry.frmEntry(hmConn, hmDevManager, pLotID, pPriID);

            frm.ShowDialog();
            frm.Dispose();
        }
        void frmEntry_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
