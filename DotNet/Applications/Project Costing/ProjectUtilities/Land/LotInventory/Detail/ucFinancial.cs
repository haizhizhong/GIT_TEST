using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucFinancial : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private int _LotID = -1;
        private int _PriID = -1;

        public ucFinancial(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            TR_Conn.ConnectionString = Connection.TRConnection;
            RunSetups();
        }

        #region Setups
        private void RunSetups()
        {
            SetupUnits();
        }

        private void SetupUnits()
        {
            if (Connection.CountryCode.Equals("U"))
            {
                lciGST.Text = "Tax 1";
                lciPST.Text = "Tax 2";
            }
        }

        private void LoadLotInfo()
        {
            txtLot.Text = "";
            txtBlock.Text = "";
            txtPlan.Text = "";
            txtAgreement.Text = "";

            string sSelect = "select lot_num, block_num, plan_num, (Select Top 1 a.agreement_num From PROJ_LOT_AGREEMENT a where a.proj_lot_id = proj_lot.proj_lot_id order by agreement_id desc) Agreement_Num from proj_lot where proj_lot_id=" + _LotID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        object oLot = dr["lot_num"];
                        if (oLot != null && oLot != DBNull.Value)
                            txtLot.Text = oLot.ToString();

                        object oBlock = dr["block_num"];
                        if (oBlock != null && oBlock != DBNull.Value)
                            txtBlock.Text = oBlock.ToString();

                        object oPlan = dr["plan_num"];
                        if (oPlan != null && oPlan != DBNull.Value)
                            txtPlan.Text = oPlan.ToString();

                        object oAgreement = dr["Agreement_Num"];
                        if (oAgreement != null && oAgreement != DBNull.Value)
                            txtAgreement.Text = oAgreement.ToString();
                    }
                }
            }
        }

        #endregion

        public void SetReadOnly(bool ReadOnly)
        {           
        }

        public void LoadLot(int LotID, int PriID)
        {
            _LotID = LotID;
            _PriID = PriID;
            LoadLotInfo();

            LoadFinancial(LotID);
            //loads the invoice grid
            ceIncludeHoldbackInv_CheckedChanged(ceIncludeHoldbackInv, null);
        }

        private void LoadFinancial(int LotID)
        {
            dsFinDeposits.Clear();
            string sSelect = "exec PC_GetLotFinancial " + _LotID;
            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        teBaseAmount.EditValue = dr["base_sale_amt"];
                        teGST.EditValue = dr["gst_amt"];
                        tePST.EditValue = dr["pst_amt"];
                        teTotalAmount.EditValue = dr["total_sale_amt"];
                        teDepositRemain.EditValue = dr["deposits_remain"];
                        teDownPaymentRemain.EditValue = dr["down_payment_remain"];
                        teInterestAccrued.EditValue = dr["interest_accrued"];
                        teTotalAdj.EditValue = dr["total_adj"];
                        teTotalPay.EditValue = dr["total_pay"];
                        teRemaningBalance.EditValue = dr["remain_bal"];                        
                        teDP_DepositAmount.EditValue = dr["dp_dep_amt"];
                        teDP_PaidToDate.EditValue = dr["dp_paid"];
                        teDP_RemainingBalance.EditValue = dr["dp_remain"];
                        teLotPayout.EditValue = dr["lot_payout_charges"];
                        teTotalDiscounts.EditValue = dr["Discounts"];
                        daFinDeposits.SelectCommand.Parameters["@lot_id"].Value = LotID;
                        dsFinDeposits.Clear();
                        daFinDeposits.Fill(dsFinDeposits);
                    }
                }
            }
        }

        private void ucFinancial_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void ceIncludeHoldbackInv_CheckedChanged(object sender, EventArgs e)
        {
            dsFinInvoices1.Clear();
            string sql = "exec PC_GetLotFinancialInvoices "+_LotID+","+(ceIncludeHoldbackInv.Checked?"1":"0");
            Connection.SQLExecutor.ExecuteNonQuery(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error loading invoice working table :" + Connection.SQLExecutor.Exception.Message);
            else
            {
                try
                {
                    daFinInvoices.SelectCommand.Parameters["@proj_lot_id"].Value = _LotID;
                    daFinInvoices.Fill(dsFinInvoices1);
                }
                catch(Exception ex)
                {
                    Popup.ShowPopup("Error loading invoices:" + ex.Message);
                }
            }
        }
    }
}
