using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;

namespace ProjectUtilities.Land.LotInventory
{
    public partial class frmComments : DevExpress.XtraEditors.XtraForm
    {
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;

        private frmPopup Popup;
        private int _lot_id = -1;
        private double _previousPrice = 0;

        public frmComments(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg, int lotID, double previousPrice)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            Popup = new frmPopup(hmDevMgr);
            _lot_id = lotID;
            _previousPrice = previousPrice;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           if (memComments.Text.ToString() =="")
            {
                Popup.ShowPopup("Comments cannot be empty.");
                return;
            }
            string sqlstr = @"insert LD_Lot_CurrentPriceChange_Log(UserName, DateSaved, Comments,proj_lot_id,Previous_Current_Price)
                        select '" + hmConn.MLUser + "', getdate(),'" + memComments.Text.ToString().Replace("'", "''").Trim() + "'," + _lot_id.ToString() + "," + _previousPrice.ToString();

            
            hmConn.SQLExecutor.ExecuteNonQuery(sqlstr, hmConn.TRConnection);
            if (hmConn.SQLExecutor.Exception != null)
            {
                Popup.ShowPopup(sqlstr + " Exception found in CurrentPriceLogFileEntry:" + hmConn.SQLExecutor.Exception.Message.ToString());
            }
            else
            {
                this.Close();
            }


        }
    }
}