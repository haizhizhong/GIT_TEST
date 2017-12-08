using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class frmAgreementDateSelection : DevExpress.XtraEditors.XtraForm
    {

        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        int _proj_lot_id = -1;
       

        public frmAgreementDateSelection(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int proj_lot_id)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);
            _proj_lot_id = proj_lot_id;

            object result = hmCon.SQLExecutor.ExecuteScalar("select case when ISNULL(current_price,0) = 0 then ISNULL(original_price,0) else current_price end from proj_lot where proj_lot_id = " + _proj_lot_id.ToString(), hmCon.TRConnection);
            if (result != null && result != DBNull.Value)
            {
                if (Convert.ToDouble(result) == 0)
                {
                    popup.ShowPopup("Lot price is 0.");
                    seSellPrice.Enabled = true;
                    seSellPrice.EditValue = 0.00;
                }
                else
                {
                    seSellPrice.EditValue = result;
                    seSellPrice.Enabled = false;
                    ceUseLotPrice.Checked = true;
                }
            }
			
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (deAgreementDate.EditValue == DBNull.Value || deAgreementDate.EditValue == null)
            {
                TopMost = false;
                popup.ShowPopup("Agreement Date is required.");
                TopMost = true;
                return;
            }
            if (deSaleDate.EditValue == DBNull.Value || deSaleDate.EditValue == null)
            {
                TopMost = false;
                popup.ShowPopup("Sale Date is required");
                TopMost = true;
                return;
            }

            if (deAgreementDate.DateTime.CompareTo(deSaleDate.DateTime) > 0)
            {
                TopMost = false;
                popup.ShowPopup("Agreement date cannot be greater then sale date.");
                TopMost = true;
                return;
            }
            if (seSellPrice.EditValue == DBNull.Value || seSellPrice.EditValue == null)
            {
                TopMost = false;
                popup.ShowPopup("Actual Sell Price must be greater then 0.");
                TopMost = true;
                return;
            }
            if (seSellPrice.Value <= 0)
            {
                TopMost = false;
                popup.ShowPopup("Actual Sell Price must be greater then 0.");
                TopMost = true;
                return;
            }

            this.DialogResult = DialogResult.OK;

        }

        private void frmAgreementDateSelection_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        private void ceUseLotPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Convert.ToBoolean(e.NewValue))
            {
                object result = hmCon.SQLExecutor.ExecuteScalar("select case when ISNULL(current_price,0) = 0 then ISNULL(original_price,0) else current_price end from proj_lot where proj_lot_id = " + _proj_lot_id.ToString(), hmCon.TRConnection);
                if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToDouble(result) == 0)
                    {
                        popup.ShowPopup("Lot price is 0.");
                        e.Cancel = true;
                    }
                    else
                    {
                        seSellPrice.EditValue = result;
                        seSellPrice.Enabled = false;
                    }
                }
                else
                    e.Cancel = true;
            }
            else
            {
                seSellPrice.EditValue = 0.00;
                seSellPrice.Enabled = true;
            }
        }

       
    }
}