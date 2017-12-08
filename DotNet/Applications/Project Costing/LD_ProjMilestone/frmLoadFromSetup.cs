using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProjMilestone
{
    public partial class frmLoadFromSetup : DevExpress.XtraEditors.XtraForm
    {

        public frmLoadFromSetup(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int pri_id)
        {
            InitializeComponent();
            ucLoadFromSetup uc = new ucLoadFromSetup(connection, tuc, pri_id);
            uc.Dock = DockStyle.Fill;
            uc.Parent = this;

        }
    }
}