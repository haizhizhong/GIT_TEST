using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAgreementAssistant
{
    public partial class frmAgreementDateSelection : DevExpress.XtraEditors.XtraForm
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;


        public frmAgreementDateSelection(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);
            ceUseCurrentPrice.Checked = true;
            seSellPrice.Enabled = false;
            

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


            if (!ceUseCurrentPrice.Checked)
            {


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
            }
            this.DialogResult = DialogResult.OK;

        }

        private void frmAgreementDateSelection_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        private void ceUseCurrentPrice_CheckedChanged(object sender, EventArgs e)
        {
            seSellPrice.Enabled = !ceUseCurrentPrice.Checked;
            if (ceUseCurrentPrice.Checked)
            {
                seSellPrice.EditValue = DBNull.Value;
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("select ISNULL(proj_lot_id,0) from working_ld_laa_proj_lot_agreement where username = '" + hmCon.MLUser + "'", hmCon.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][0] != DBNull.Value)
                            seSellPrice.EditValue = hmCon.SQLExecutor.ExecuteScalar("select isnull(current_price,0) from PROJ_LOT where proj_lot_id = " + dt.Rows[0][0].ToString(), hmCon.TRConnection);
                    }
                }
                
            }
            else
            {
                seSellPrice.EditValue = 0.00;
            }
        }


    }
}