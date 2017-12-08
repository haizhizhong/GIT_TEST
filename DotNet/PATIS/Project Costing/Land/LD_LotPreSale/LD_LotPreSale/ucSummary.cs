using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotPreSale
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public Subledger_Preview.ucSubledger_Preview ucSP;

        public ucSummary(HMConnection.HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            InitializeComponent();
            ucSP = new Subledger_Preview.ucSubledger_Preview(Connection, DevXMgr, Subledger_Preview.ucSubledger_Preview.Flavor.LD_LotAgreementScreen);
            ucSP.Dock = DockStyle.Fill;
            ucSP.Parent = dockPanel1;
        }

        private void ucSummary_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }
    }
}
