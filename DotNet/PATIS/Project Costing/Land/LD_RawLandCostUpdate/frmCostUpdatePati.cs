using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandCostUpdate
{
    public partial class frmCostUpdatePati : DevExpress.XtraEditors.XtraForm
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;


        public frmCostUpdatePati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, int PROJ_LD_RawLandHolding_ID)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;

            ucCostUpdatePati uc = new ucCostUpdatePati(connection, tuc);
            uc.Dock = DockStyle.Fill;
            uc.RefreshPati(PROJ_LD_RawLandHolding_ID);
            uc.btnClose.Click += new EventHandler(btnClose_Click);
            uc.Parent = this;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            if (pop == null)
                pop = new WS_Popups.frmPopup(tuc_mgr);
            if (pop.ShowPopup("Are you sure you want to close?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                this.Close();

        }
    }
}