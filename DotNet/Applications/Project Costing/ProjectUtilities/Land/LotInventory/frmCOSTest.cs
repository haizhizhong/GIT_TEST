using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.LotInventory
{
    public partial class frmCOSTest : DevExpress.XtraEditors.XtraForm
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        int _proj_lot_id = -1;

        public frmCOSTest(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int proj_lot_id)
        {
            InitializeComponent();
            _proj_lot_id = proj_lot_id;
            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            //sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            DataTable dt = con.SQLExecutor.ExecuteDataAdapter("select lot_status_id,original_price,current_price, dbo.LD_fn_get_lot_COS(proj_lot_id)[COS_Calc] from PROJ_LOT where proj_lot_id = " + _proj_lot_id.ToString(), con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading lot price and COS calculation:" + con.SQLExecutor.Exception.Message);
            else if(dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["lot_status_id"].ToString() != "1")
                        teCurrentPrice.Enabled = false;
                    teOriginalPrice.EditValue = dt.Rows[0]["original_price"];
                    teCurrentPrice.EditValue = dt.Rows[0]["current_price"];
                    teCOSCalculation.EditValue = dt.Rows[0]["COS_Calc"];
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal( teCurrentPrice.Text ) < 0)
                pop.ShowPopup("Current price can not be less than zero.");
            else if(Convert.ToDecimal( teCurrentPrice.Text ) >  2147483647)
                pop.ShowPopup("Current price is too large.");
            else
            {
                string sql = "select dbo.LD_fn_get_lot_COS_PriceOverride("+_proj_lot_id.ToString()+","+teCurrentPrice.Text.Replace(",","")+")";
                Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error calculating COS:" + con.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    teCOSCalculation.EditValue = result;
                    pop.ShowPopup("Calculation Complete.");
                }
                else
                    pop.ShowPopup("Error calculating COS");
            }
        }



    }
}