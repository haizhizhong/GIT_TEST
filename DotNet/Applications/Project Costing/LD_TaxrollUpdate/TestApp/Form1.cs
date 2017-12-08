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
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConnection
        {
            get { return ReflexCon; }
            set { ReflexCon = value; }
        }

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        #endregion Properties

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReflexCon = new HMConnection.HMCon("WEB_GC_TEST", "DOTNETSQL\\DOTNETSQL", 12, "Mike");
            //ReflexCon = new HMConnection.HMCon("WEB_DEMO_RE", "CSM-2005\\SQL2008", 12, "Mike");
           
            dxStyle = new TUC_HMDevXManager.TUC_HMDevXManager();
            dxStyle.AppInit("Test");

            LD_TaxrollUpdate.ucLD_TaxrollUpdate TaxRollUpdate = new LD_TaxrollUpdate.ucLD_TaxrollUpdate(ReflexCon, dxStyle);
            TaxRollUpdate.Dock = DockStyle.Fill;
            TaxRollUpdate.Parent = this;

            dxStyle.FormInit(this);
        }
    }
}
