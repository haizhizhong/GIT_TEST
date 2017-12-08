using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Multi_Lot_Entry
{
    public partial class frmEntry : DevExpress.XtraEditors.XtraForm
    {
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private LD_Multi_Lot_Entry.ucMulti_Lot_Entry multiLotEntry;

      
       
        public frmEntry(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg, int pLotID, int pPriID)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;

            multiLotEntry = new ucMulti_Lot_Entry(hmConn, hmDevMgr, pLotID, pPriID);
            multiLotEntry.Dock = DockStyle.Fill;
            multiLotEntry.Parent = this;

        }

        
        private void frmEntry_Load(object sender, EventArgs e)
        {
           // multiLotEntry.gcLotEntry.EmbeddedNavigator.Buttons.DoClick(multiLotEntry.gcLotEntry.EmbeddedNavigator.Buttons.Append);
          //  multiLotEntry.gvLotEntry.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gvLotEntry_InitNewRow);
           // multiLotEntry.gvLotEntry.RefreshData();

        }

        void gvLotEntry_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

           // multiLotEntry.SetDefault();
        }
    }
}