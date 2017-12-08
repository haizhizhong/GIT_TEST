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
    public partial class ucContinuity : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager dev;
        public ucContinuity(HMConnection.HMCon _con, TUC_HMDevXManager.TUC_HMDevXManager _dev, int BatchID, int pri_id)
        {
            InitializeComponent();
            con = _con;
            dev = _dev;
            sqlTRConnection.ConnectionString = con.TRConnection;
            daContinuitySchedules.SelectCommand.Parameters["@username"].Value = con.MLUser;
            daContinuitySchedules.SelectCommand.Parameters["@BatchID"].Value = BatchID;
            daContinuitySchedules.SelectCommand.Parameters["@pri_id"].Value = pri_id;
            RefreshData();
        }
        public void RefreshData()
        {
            dsContinuitySchedules1.Tables[0].Clear();
            daContinuitySchedules.Fill(dsContinuitySchedules1);
            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gv.Columns)
            {
                if (c.FieldName.StartsWith("F"))
                    c.Visible = false;
            }

            colProject1.VisibleIndex = 0;
            colInvestor1.VisibleIndex = 1;
            colInvestor1.Caption = "\n\n\n\n\nInvestor";
            colDistributionPercentage.VisibleIndex = 2;
            colDistributionPercentage.Caption = "\n\n\n\nDistribution\nPercentage";
            colOriginalInvestment.VisibleIndex = 3;
            colOriginalInvestment.Caption = "\n\n\n\nOriginal\nInvestment";
            colPreviousDisbursements.VisibleIndex = 4;
            colPreviousDisbursements.Caption = "\n\n\n\nPrevious\nDisbursements";
            
            if (dsContinuitySchedules1.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dsContinuitySchedules1.Tables[0].Rows[0];
                int max = 4;
                for (int x = 1; x < 13; x++)
                {
                    if (dr["Type" + x].ToString() == "PROC")
                    {
                        DevExpress.XtraGrid.Columns.GridColumn c = gv.Columns["F" + x];
                        c.VisibleIndex = max + x;
                        c.Visible = true;
                        c.Caption = "Partial\nReturn Of\nCapital\n\n\nDisbursed\n" + dr["Date"+x].ToString();
                    }
                    else if (dr["Type" + x].ToString() == "PD")
                    {
                        DevExpress.XtraGrid.Columns.GridColumn c = gv.Columns["F" + x];
                        c.VisibleIndex = max + x;
                        c.Visible = true;
                        c.Caption = "\nProfit\nDistribution\n\n\nDisbursed\n" + dr["Date" + x].ToString();
                    }
                    else if (dr["Type" + x].ToString() == "BOI")
                    {
                        DevExpress.XtraGrid.Columns.GridColumn c = gv.Columns["F" + x];
                        c.VisibleIndex = max + x;
                        c.Visible = true;
                        c.Caption = "\n\n\nBalance\nOf\nInvestment";
                    }
                    else if (dr["Type" + x].ToString() == "PDTD")
                    {
                        DevExpress.XtraGrid.Columns.GridColumn c = gv.Columns["F" + x];
                        c.VisibleIndex = max + x;
                        c.Visible = true;
                        c.Caption = "\n\n\nProfit\nDistributed\nTo Date";
                    }
                }                
            }
        }

        private void ucContinuity_Load(object sender, EventArgs e)
        {
            dev.FormInit(this);
        }
    }
}
