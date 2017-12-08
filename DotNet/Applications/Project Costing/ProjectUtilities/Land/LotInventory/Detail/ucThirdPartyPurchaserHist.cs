using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucThirdPartyPurchaserHist : DevExpress.XtraEditors.XtraUserControl
    {
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;

        public ucThirdPartyPurchaserHist(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            sqlConnTR.ConnectionString = hmConn.TRConnection;

        }

        public void LoadHist(int agreeID)
        {
            dsThirdPartyPurchaserHist1.Clear();
            daThirdPartyPurchaserHist.SelectCommand.Parameters["@agreement_id"].Value = agreeID;
            daThirdPartyPurchaserHist.Fill(dsThirdPartyPurchaserHist1);
        }
    }
}
