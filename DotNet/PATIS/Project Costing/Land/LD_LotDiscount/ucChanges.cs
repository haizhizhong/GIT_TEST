using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotDiscount
{
    public partial class ucChanges : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private TUC_GridG.GridG gGrid;


        private string _ActionType = "N";
        private bool _isFilling = false;
        private string _SearchUsername = "";

        public int SelectedYear
        {
            get { return ucAccountingPicker1.SelectedYear; }
        }
        public int SelectedPeriod
        {
            get { return ucAccountingPicker1.SelectedPeriod; }
        }

        public DateTime DiscountDate
        {
            get { return deDiscountDate.DateTime; }
        }

        public ucChanges(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, string searchUsername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            _SearchUsername = searchUsername;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            daSelectedAgreements.SelectCommand.Parameters["@username"].Value = searchUsername;
            ucAccountingPicker1.ConnectionString = con.TRConnection;

            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvDiscounts, daDiscountModifications, dsDiscountModifications1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;


            daDiscountModifications.SelectCommand.Parameters["@username"].Value = searchUsername;
            daDiscountModifications.SelectCommand.Parameters["@working_ld_lot_search_id"].Value = -1;


            try
            {
                daDiscountType.Fill(dsDiscountType1);
                da_LD_Discounts.Fill(ds_LD_Discounts1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading lookup's:" + ex.Message);
            }

        }

       

        public void RefreshMe(string actionType)
        {

            string sql = "exec LD_DiscountPati_LoadChanges '" + _SearchUsername.Replace("'","''")+"', '"+actionType+"'";
            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading discounts:" + con.SQLExecutor.Exception.Message);


            _ActionType = actionType;
            ucAccountingPicker1.setDefaults();
            deDiscountDate.EditValue = ucAccountingPicker1.SelectedEntryDate;
            if (actionType == "N")
            {
                colAmount.OptionsColumn.ShowInCustomizationForm = false;
                colAmount.Visible = false;

                colSelected.OptionsColumn.ShowInCustomizationForm = false;
                colSelected.Visible = false;

                gcDiscounts.EmbeddedNavigator.Buttons.Append.Visible = true;
                gcDiscounts.EmbeddedNavigator.Buttons.Remove.Visible = true;

            }
            else
            {
                colAmount.OptionsColumn.ShowInCustomizationForm = true;
                colAmount.Visible = true;

                colSelected.OptionsColumn.ShowInCustomizationForm = true;
                colSelected.Visible = true;

                gcDiscounts.EmbeddedNavigator.Buttons.Append.Visible = true;
                gcDiscounts.EmbeddedNavigator.Buttons.Remove.Visible = true;
            }


            _isFilling = true;

            dsSelectedAgreements1.Clear();
            dsDiscountModifications1.Clear();
            try
            {
                daSelectedAgreements.Fill(dsSelectedAgreements1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading selections:" + ex.Message);
            }

            _isFilling = false;
            gvSelectedAgreements_FocusedRowChanged(gvSelectedAgreements, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvSelectedAgreements.FocusedRowHandle));

        }

        private void gvSelectedAgreements_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (_isFilling) return;
            DataRow row = gvSelectedAgreements.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                daDiscountModifications.SelectCommand.Parameters["@working_ld_lot_search_id"].Value = row[colID.FieldName];
            }

            if (_ActionType == "M" || _ActionType == "R")
                LoadDiscounts();



        }



        private void LoadDiscounts()
        {
            try
            {
                if (_ActionType != "A")
                {
                    dsDiscountModifications1.Clear();
                    daDiscountModifications.Fill(dsDiscountModifications1);
                }
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading discounts:" + ex.Message);
            }
        }

        private void gvDiscounts_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvDiscounts.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colusername1.FieldName] = _SearchUsername;
                row[colActionRequired.FieldName] = _ActionType;
                row[colSelected.FieldName] = true;

            }
        }

        private void gvDiscounts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle) return;

            if (_ActionType != "N" && (e.Column == colType || e.Column == colValue))
            {//new discounts get amount field filled in review proc.
                object oType = gvDiscounts.GetFocusedRowCellValue(colType);
                object oValue = gvDiscounts.GetFocusedRowCellValue(colValue);
                if (oType != DBNull.Value && oValue != DBNull.Value)
                {
                    if (gvSelectedAgreements.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && gvSelectedAgreements.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    {
                        string sql = "declare @AgreementID int = " + gvSelectedAgreements.GetFocusedRowCellValue(colagreement_id).ToString() + "," +
                            "@Type varchar(1) = '" + oType.ToString() + "'," +
                            "@Value decimal(16,4) = " + oValue.ToString() + @" 
select round(case when @Type = 'P' then ISNULL(h.ORIGINAL_INV_AMOUNT,0) *@Value / 100 else @Value end,2)[DiscountAmount] from SO_TRN_HDR h
 where h.agreement_id = @AgreementID and h.SO_TYPE_ID in(select t.SO_TYPE_ID from SO_TYPE t where t.SO_TYPE_CODE = 'LS')";
                        Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
                        if (con.SQLExecutor.Exception != null)
                            pop.ShowPopup("Error setting discount amount:" + con.SQLExecutor.Exception.Message);
                        else if (result != null && result != DBNull.Value)
                        {
                            gvDiscounts.SetFocusedRowCellValue(colAmount, result);
                            gvDiscounts.SetFocusedRowCellValue(colSelected, true);
                        }
                    }
                }
            }
            else if(e.Column == colLD_DISCOUNTS_ID || e.Column == colLD_DISCOUNTS_ID1)
            {
                
                if (_ActionType == "N" && e.Value != null && e.Value != DBNull.Value)
                {
                    string sql = @"select Type,Value from LD_Discounts where LD_Discounts_ID = " + e.Value.ToString();
                    DataTable dt  = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                        pop.ShowPopup("Error setting discount amount:" + con.SQLExecutor.Exception.Message);
                    else if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            gvDiscounts.SetFocusedRowCellValue(colType, dt.Rows[0][0]);
                            gvDiscounts.SetFocusedRowCellValue(colValue, dt.Rows[0][1]);
                        }
                    }
                }
 

            }
        }

        private void gvDiscounts_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            pop.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvDiscounts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;


            if (drv[colLD_DISCOUNTS_ID.FieldName] == null || drv[colLD_DISCOUNTS_ID.FieldName] == DBNull.Value)
            {
                e.Valid = false;
                e.ErrorText = "Code is required.";
            }
            else if (drv[colType.FieldName] == null || drv[colType.FieldName] == DBNull.Value)
            {
                e.Valid = false;
                e.ErrorText = "Type is required.";
            }
            else if (IsLessThanZero(drv[colValue.FieldName], false))
            {
                e.Valid = false;
                e.ErrorText = "Value must be greater than zero.";
            }
            else if (IsNumberToLarge(drv[colValue.FieldName]))
            {
                e.Valid = false;
                e.ErrorText = "Value is too large.";
            }
            

            if (_ActionType == "M" && e.Valid)
            {
                if (Convert.ToBoolean(drv[colSelected.FieldName]))
                {
                    string sql = @"select a.Type,a.Value from working_ld_discounts d 
join PROJ_LOT_AGREEMENT_DISCOUNTS a on a.PROJ_LOT_AGREEMENT_DISCOUNTS_ID = d.PROJ_LOT_AGREEMENT_DISCOUNTS_ID
where d.id = " + drv[colID1.FieldName];
                    DataTable result = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                        pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
                    else if (result != null)
                    {
                        if (result.Rows.Count > 0)
                        {
                            if (drv[colType.FieldName].ToString() == result.Rows[0][0].ToString() &&
                                    Convert.ToDecimal(drv[colValue.FieldName]) == Convert.ToDecimal(result.Rows[0][1]))
                            {
                                e.Valid = false;
                                e.ErrorText = "You can only select discounts that have been modified from the original.";
                            }


                        }   
                    }
                }
            }
        }


        private bool IsLessThanZero(object value, bool AllowZero)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try { dValue = Convert.ToDecimal(value); }
            catch { }

            if (dValue == 0 && !AllowZero)
                returnValue = true;
            else if (dValue < 0)
                returnValue = true;
            return returnValue;
        }


        private bool IsNumberToLarge(object value)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue > 9999999999)
                returnValue = true;

            return returnValue;
        }

    }
}
