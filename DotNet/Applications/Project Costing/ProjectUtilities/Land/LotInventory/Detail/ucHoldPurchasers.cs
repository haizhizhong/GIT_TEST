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
    public partial class ucHoldPurchasers : DevExpress.XtraEditors.XtraUserControl
    {
        private HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;

        public ucHoldPurchasers(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            this.Popup = new WS_Popups.frmPopup(DevXMgr);

            InitializeComponent();

            TR_Conn.ConnectionString = Connection.TRConnection;
        }

        private void ucHoldPurchasers_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        public int HoldID
        {
            set
            {
                dsHoldPurch.Clear();
                if (value != -1)
                {
                    daHoldPurch.SelectCommand.Parameters["@hold_id"].Value = value;
                    daHoldPurch.Fill(dsHoldPurch);
                }
            }
        }
    }
}
