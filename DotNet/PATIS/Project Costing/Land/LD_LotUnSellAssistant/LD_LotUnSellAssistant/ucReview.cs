using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotUnSellAssistant
{
    public partial class ucReview : DevExpress.XtraEditors.XtraUserControl
    {
        private HMConnection.HMCon hmCon;
        private TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        private WS_Popups.frmPopup popup;
        private bool settingValues = false;
        private bool isFilling = false;
        private int _AgreementID = -1;
        KeyControlAccess.Validator KCA_Validator;
        //TUC_GridG.GridG gGrid;
        //GL_Account_Lookup_Rep.Repository_GL_Lookup glLookup;

        //private double gst_pct = 0;
        //private double pst_pct = 0;

        public ucReview(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, KeyControlAccess.Validator pKCA_Valadator)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            KCA_Validator = pKCA_Valadator;
            da_selectedLots.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "LotUnsellAssistant";
            settingValues = true;
            acctYearPeriod1.TRDBName = hmCon.TRDB;
            acctYearPeriod1.TRServerName = hmCon.CompanyServer;
            acctYearPeriod1.checkClose = "T"; //Turns on/off Open period check.
            acctYearPeriod1.MessageBoxHeaderText = "Lot Sale Assistant";
            settingValues = false;
            UpdateDate();

            if (hmCon.CountryCode == "U")
            {
                colprov.Caption = "State";
                colpostal.Caption = "Zip";
                colGST.Caption = "Tax 1";
                colPST.Caption = "Tax 2";
            }
            else if (hmCon.CountryCode == "C")
            {
                colprov.Caption = "Province";
                colpostal.Caption = "Postal Code";
                colGST.Caption = "GST";
                colPST.Caption = "PST";
            }

            //LoadLotSaleAdjustmentsGrid();

            LoadLevels();
        }

        private void LoadLevels()
        {
            string sLevels =  "Select lv1_land_desc [lv1_desc], lv2_land_desc [lv2_desc], lv3_land_desc [lv3_desc], lv4_land_desc [lv4_desc] From proj_cntl";

            DataTable dtLevels = hmCon.SQLExecutor.ExecuteDataAdapter(sLevels, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                popup.ShowPopup(hmCon.SQLExecutor.Exception.Message + "\r\n\r\n" + hmCon.SQLExecutor.Exception.StackTrace);
                return;
            }

            if (dtLevels.Rows.Count > 0)
            {
                if (dtLevels.Rows[0]["lv1_desc"] != DBNull.Value && dtLevels.Rows[0]["lv1_desc"] != null)
                {
                    colLevel1.Caption = dtLevels.Rows[0]["lv1_desc"].ToString();
                }

                if (dtLevels.Rows[0]["lv2_desc"] != DBNull.Value && dtLevels.Rows[0]["lv2_desc"] != null)
                {
                    colLevel2.Caption = dtLevels.Rows[0]["lv2_desc"].ToString();
                }
                else
                {
                    colLevel2.Visible = false;
                    colLevel2.OptionsColumn.ShowInCustomizationForm = false;
                }

                if (dtLevels.Rows[0]["lv3_desc"] != DBNull.Value && dtLevels.Rows[0]["lv3_desc"] != null)
                {
                    colLevel3.Caption = dtLevels.Rows[0]["lv3_desc"].ToString();
                }
                else
                {
                    colLevel3.Visible = false;
                    colLevel3.OptionsColumn.ShowInCustomizationForm = false;
                }

                if (dtLevels.Rows[0]["lv4_desc"] != DBNull.Value && dtLevels.Rows[0]["lv4_desc"] != null)
                {
                    colLevel4.Caption = dtLevels.Rows[0]["lv4_desc"].ToString();
                }
                else
                {
                    colLevel4.Visible = false;
                    colLevel4.OptionsColumn.ShowInCustomizationForm = false;
                }
            }
            
        }

        private void ucReview_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        public void RefreshMe()
        {
            isFilling = true;

            //Clear Sub Grids First
            //hmCon.SQLExecutor.ExecuteNonQuery("delete working_ld_lsa_lotsaleadjustments where username = '" + hmCon.MLUser + "'", hmCon.TRConnection);
            //if (hmCon.SQLExecutor.Exception != null)
            //{
            //    popup.ShowPopup("Error clearing working lot sale adjustments:" + hmCon.SQLExecutor.Exception.Message);

            //}
            tcDetail.SelectedTabPage = tpDeposits;
            try
            {
                UpdateDate();
                settingValues = true;
                //ds_lueCostingLevels1.Clear();
                //da_lueCostingLevels.Fill(ds_lueCostingLevels1);
                acctYearPeriod1.RefreshAcctPeriod();
                
                hmCon.SQLExecutor.ExecuteScalar("exec LD_Lot_Unsell_Calc_Restocking '" + hmCon.MLUser + "', '" + deUnSellDate.DateTime.ToShortDateString() + "',0", hmCon.TRConnection);
                ds_selectedLots1.Clear();
                da_selectedLots.Fill(ds_selectedLots1);
                //ds_LotSaleAdjustments1.Clear();
                //da_LotSaleAdjustments.Fill(ds_LotSaleAdjustments1);

                settingValues = false;
                
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }
            isFilling = false;
            gvReview_FocusedRowChanged(gvReview, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvReview.FocusedRowHandle));
        }

        public bool isValid()
        {
            bool bValid = true;

            object oPeriodOpen = hmCon.SQLExecutor.ExecuteScalar("Select IsNull(PERIOD_OPEN,'F') From AR_PERIODS Where AR_YEAR = " + acctYearPeriod1.luAcctYear.EditValue.ToString() + " And PERIOD = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + "", hmCon.TRConnection);
            if (oPeriodOpen == DBNull.Value || oPeriodOpen == null) oPeriodOpen = "F";

            if (oPeriodOpen.ToString() == "F")
            {
                popup.ShowPopup("Year and Period combination are not open.");
                bValid = false;
            }
            else if (isDateInValid())
            {
                bValid = false;
            }
            else if (UnupdatedPaymentsExist())
            {
                bValid = false;
            }
            else if (!ValidateDateNotBeforeSaleDate())
            {
                bValid = false;
            }

            return bValid;
        }

        private bool ValidateDateNotBeforeSaleDate()
        {
            bool bValid = true;
            if (deUnSellDate.EditValue == null || deUnSellDate.EditValue == DBNull.Value)
            {
                popup.ShowPopup("Unable to retrive un-sell date.");
                bValid = false;
            }
            else
            {
                string sql = @"select TRANSACTION_DATE from AR_DEPOSIT where agreement_id = " + _AgreementID.ToString()+
                    " union all "+
                    " select INVOICE_DATE from SO_TRN_HDR where agreement_id = " + _AgreementID.ToString() +
                    " union all "+
                    " select TRANSACTION_DATE from AR_PAYMENT_HEADERS where agreement_id = " + _AgreementID.ToString()+
                    " order by TRANSACTION_DATE desc";
                object oSaleDate = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                DateTime dtSaleDate = DateTime.MinValue;
                try { dtSaleDate = Convert.ToDateTime(oSaleDate); }
                catch { }

                if (dtSaleDate == DateTime.MinValue)
                {
                    popup.ShowPopup("No financial transaction have taken place for this lot.");
                    bValid = false;
                }
                else
                {
                    if (deUnSellDate.DateTime.CompareTo(dtSaleDate) < 0)
                    {
                        popup.ShowPopup("Un-Sell date is before the most recent transaction on this agreement("+dtSaleDate.ToShortDateString()+").");
                        bValid = false;
                    }
                }
            }
            return bValid;
        }

        private bool UnupdatedPaymentsExist()
        {
            bool bExist = false;

            string sSQL = @"select count(*) From AR_PAYMENT_HEADERS ph where ph.agreement_id = "+_AgreementID+@" and isnull(ph.BATCH_STAT,'I') = 'I'";
            if (Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection)) > 0)
            {
                bExist = true;
                popup.ShowPopup("Unable to proceed. There are unposted payment batches against this lot.");
            }

            return bExist;
        }

        private bool isDateInValid()
        {
            bool returnValue = true;
            if (deUnSellDate.EditValue != DBNull.Value && deUnSellDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deUnSellDate.DateTime.ToShortDateString() + "' and PERIOD <> 13  order by END_DATE";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting year and period from invoice date:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() == dt.Rows[0]["PERIOD"].ToString()
                           && acctYearPeriod1.luAcctYear.EditValue.ToString() == dt.Rows[0]["AR_YEAR"].ToString())
                        {
                            returnValue = false;
                        }
                    }
                }

                if (returnValue)
                {
                    popup.ShowPopup("Un-Sell date must be within the selected year/period.");
                }

            }
            else
                popup.ShowPopup("Un-Sell date is required.");



            return returnValue;
        }

       
        private void UpdateDate()
        {
            if (settingValues) return;
            int iYear = 0, iPeriod = 0, iMonth = 0;
            if (acctYearPeriod1.luAcctYear.EditValue != DBNull.Value && acctYearPeriod1.luAcctYear.EditValue != null)
                iYear = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue);
            if (acctYearPeriod1.luAcctPeriod.EditValue != DBNull.Value && acctYearPeriod1.luAcctPeriod.EditValue != null)
                iPeriod = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue);

            object oEndDate = hmCon.SQLExecutor.ExecuteScalar("Select END_DATE from AR_PERIODS where AR_YEAR = " + iYear.ToString() + " and PERIOD = " + iPeriod.ToString(), hmCon.TRConnection);

            try
            {
                DateTime dEndDate = Convert.ToDateTime(oEndDate);
                iMonth = dEndDate.Month;
                iYear = dEndDate.Year;
            }
            catch { }

            if (iYear != 0 && iMonth != 0)
            {
                int day = 1;
                if (iMonth == DateTime.Now.Month && iYear == DateTime.Now.Year)
                    day = DateTime.Now.Day;
                settingValues = true;
                deUnSellDate.DateTime = new DateTime(iYear, iMonth, day);
                settingValues = false;

            }
        }

        private void gvReview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;

            int iAgreement_ID = -1;

            DataRow row = gvReview.GetDataRow(e.FocusedRowHandle);
            if (row != null && e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
                && e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                try { iAgreement_ID = Convert.ToInt32(row[colagreement_id.FieldName]); }
                catch { }
            }
            _AgreementID = iAgreement_ID;
            RefreshDetailGrid(iAgreement_ID);
        }

        private void RefreshDetailGrid(int piAgreement_ID)
        {
            ds_deposits1.Clear();
            ds_Invoices1.Clear();
            ds_adjustments1.Clear();
            ds_payments1.Clear();
            dsPayoutIntrest1.Clear();
            ds_discounts1.Clear();
            if (tcDetail.SelectedTabPage == tpDeposits)
            {
                da_deposits.SelectCommand.Parameters["@agreement_id"].Value = piAgreement_ID;
                da_deposits.Fill(ds_deposits1);
            }
            else if (tcDetail.SelectedTabPage == tpInvoices)
            {
                da_Invoices.SelectCommand.Parameters["@agreement_id"].Value = piAgreement_ID;
                da_Invoices.Fill(ds_Invoices1);
            }
            else if (tcDetail.SelectedTabPage == tpAdjustments)
            {
                da_adjustments.SelectCommand.Parameters["@agreement_id"].Value = piAgreement_ID;
                da_adjustments.Fill(ds_adjustments1);
            }
            else if (tcDetail.SelectedTabPage == tpPayments)
            {
                da_payments.SelectCommand.Parameters["@agrement_id"].Value = piAgreement_ID;
                da_payments.Fill(ds_payments1);
            }
            else if (tcDetail.SelectedTabPage == tpPayoutInterest)
            {
                daPayoutIntrest.SelectCommand.Parameters["@agreement_id"].Value = piAgreement_ID;
                daPayoutIntrest.Fill(dsPayoutIntrest1);
            }
            else if (tcDetail.SelectedTabPage == tpDiscounts)
            {
                da_discounts.SelectCommand.Parameters["@agreement_id"].Value = piAgreement_ID;
                da_discounts.Fill(ds_discounts1);
            }
        }

        private void tcDetail_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            int iAgreement_ID = -1;
            try { iAgreement_ID = Convert.ToInt32(gvReview.GetFocusedDataRow()[colagreement_id.FieldName]); }
            catch{}

            RefreshDetailGrid(iAgreement_ID);
        }

        private void deUnSellDate_EditValueChanged(object sender, EventArgs e)
        {
            hmCon.SQLExecutor.ExecuteScalar("exec LD_Lot_Unsell_Calc_Restocking '"+hmCon.MLUser+"', '"+deUnSellDate.DateTime.ToShortDateString()+"',0", hmCon.TRConnection);
            isFilling = true;
            ds_selectedLots1.Clear();
            da_selectedLots.Fill(ds_selectedLots1);
            isFilling = false;
            gvReview_FocusedRowChanged(gvReview, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvReview.FocusedRowHandle));
        }

        private void gvRestocking_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow row = gvRestocking.GetDataRow(e.RowHandle);
            if (KCA_Validator.ValidatePassword(301))
            {
                if (!isGreaterThenZero(row[colInterestPercent.FieldName], true))
                {
                    popup.ShowPopup("Interest percent can not be less than zero.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
                else if(!isGreaterThenZero(row[colFlatFeeCharge.FieldName], true))
                {
                    popup.ShowPopup("Flat fee charge can not be less than zero.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
                else if (Convert.ToDouble(row[colInterestPercent.FieldName]) > 2147483647)
                {
                    popup.ShowPopup("Interest percent is to large.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
                else if (Convert.ToDouble(row[colFlatFeeCharge.FieldName]) > 2147483647)
                {
                    popup.ShowPopup("Flat fee charge is to large.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
            else
            {
                popup.ShowPopup("You do not have permission to change restocking values.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            

        }

        private void gvRestocking_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private bool isGreaterThenZero(object Value, bool AllowEqual)
        {
            double dValue = -1;
            try
            {
                dValue = Convert.ToDouble(Value);
            }
            catch { }

            if (dValue > 0)
                return true;
            else if (dValue == 0 && AllowEqual)
                return true;
            else
                return false;
        }

        private void gvRestocking_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            da_selectedLots.Update(ds_selectedLots1);
            hmCon.SQLExecutor.ExecuteScalar("exec LD_Lot_Unsell_Calc_Restocking '" + hmCon.MLUser + "', '" + deUnSellDate.DateTime.ToShortDateString() + "',1", hmCon.TRConnection);
            ds_selectedLots1.Clear();
            da_selectedLots.Fill(ds_selectedLots1);
        }
			

         
   
    }
}
