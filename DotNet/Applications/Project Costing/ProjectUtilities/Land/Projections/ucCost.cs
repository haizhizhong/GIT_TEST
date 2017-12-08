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
    public partial class ucCost : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;

        public ucCost(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
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
            lueDistMethod.Properties.ReadOnly = ReadOnly;
            txtOBud.Properties.ReadOnly = ReadOnly;
            txtABud.Properties.ReadOnly = ReadOnly;
            txtRBud.Properties.ReadOnly = ReadOnly;
            txtCostToDate.Properties.ReadOnly = ReadOnly;
            txtRemaining.Properties.ReadOnly = ReadOnly;
            txtAvailBud.Properties.ReadOnly = ReadOnly;
            gvCost.OptionsBehavior.Editable = !ReadOnly;
        }

        public void LoadProject( int PriID ) 
        {
        }

        private void ucCost_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }
    }
}
