using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testapp
{
    public partial class Form1 : Form
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;

        public Form1()
        {
            DevXMgr = new TUC_HMDevXManager.TUC_HMDevXManager();
            //Connection = new HMConnection.HMCon("web_strike_test", "dev1", 12, "adam");
            //Connection = new HMConnection.HMCon("web_gc_test", "DOTNETSQL\\DOTNETSQL", 12, "devgreg");
            Connection = new HMConnection.HMCon("web_demo_re_ath", "csm-2005\\SQL2008", 12, "devgreg");
            DevXMgr.AppInit(Connection.MLUser);
            InitializeComponent();
            LD_LotPreSale.frmLotPreSale fLPS = new LD_LotPreSale.frmLotPreSale(Connection, DevXMgr, 40, false);
            fLPS.ShowDialog();
        }
    }
}
