using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_CashCall
{
    public partial class ucSummaryDistribution : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;

        public ucSummaryDistribution(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            daSummary.SelectCommand.Parameters["@username"].Value = con.MLUser;
            daSummary.SelectCommand.Parameters["@patitype"].Value = "D";
        }

        public void RefreshSummary()
        {
            try
            {
                dsSummary1.Clear();
                daSummary.Fill(dsSummary1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading summary : " + ex.Message);
            }
        }

    }
}
