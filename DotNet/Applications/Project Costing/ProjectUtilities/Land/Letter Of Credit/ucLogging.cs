using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.Letter_Of_Credit
{
    public partial class ucLogging : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager dev;
        WS_Popups.frmPopup pop;


        public ucLogging(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMgr)
        {
            InitializeComponent();
            con = pConn;
            dev = pDevMgr;
            pop = new WS_Popups.frmPopup(dev);
            sqlConnTR.ConnectionString = con.TRConnection;
        }

        public void LoadLogging(int LetterOfCredit_ID)
        {
            dsLogging1.Clear();
            daLogging.SelectCommand.Parameters["@LetterOfCredit_ID"].Value = LetterOfCredit_ID;
            daLogging.Fill(dsLogging1);
        }

        private void ucLogging_Load(object sender, EventArgs e)
        {
            dev.FormInit(this);
           
        }
    }
}
