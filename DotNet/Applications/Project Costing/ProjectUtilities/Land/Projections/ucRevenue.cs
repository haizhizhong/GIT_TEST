using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;

namespace ProjectUtilities.Land.Projections
{
    public partial class ucRevenue : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;

        public ucRevenue(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
        }

        public void SetReadOnly(bool ReadOnly)
        {
            lueBPeriod.Properties.ReadOnly = ReadOnly;
            lueBYear.Properties.ReadOnly = ReadOnly;
            radBeginning.Properties.ReadOnly = ReadOnly;
            lueEPeriod.Properties.ReadOnly = ReadOnly;
            lueEYear.Properties.ReadOnly = ReadOnly;
            luePayDist.Properties.ReadOnly = ReadOnly;
            txtOBud.Properties.ReadOnly = ReadOnly;
            txtABud.Properties.ReadOnly = ReadOnly;
            txtRBud.Properties.ReadOnly = ReadOnly;
            txtALots.Properties.ReadOnly = ReadOnly;
            txtDiscPct.Properties.ReadOnly = ReadOnly;
            txtDistStart.Properties.ReadOnly = ReadOnly;
            txtDPPct.Properties.ReadOnly = ReadOnly;
            txtIntAdjStart.Properties.ReadOnly = ReadOnly;
            txtIntPct.Properties.ReadOnly = ReadOnly;
            txtSoldLots.Properties.ReadOnly = ReadOnly;
            txtStartPay.Properties.ReadOnly = ReadOnly;
            txtTotalLots.Properties.ReadOnly = ReadOnly;
            gvRev.OptionsBehavior.Editable = !ReadOnly;
        }

        public void LoadProject(int PriID)
        {
        }

        private void ucRevenue_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }
    }
}
