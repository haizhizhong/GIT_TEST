using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HMConnection;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucHoldHistory : DevExpress.XtraEditors.XtraUserControl
    {
        private HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;

        public ucHoldHistory(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            this.Popup = new WS_Popups.frmPopup(DevXMgr);

            InitializeComponent();

            TR_Conn.ConnectionString = Connection.TRConnection;
        }

        private void ucHoldHistory_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        public int Proj_Lot_ID
        {
            set
            {
                dsHoldHist.Clear();
                if (value != -1)
                {
                    daHoldHist.SelectCommand.Parameters["@proj_lot_id"].Value = value;
                    daHoldHist.Fill(dsHoldHist);
                }
            }
        }
    }
}
