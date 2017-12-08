using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotSaleAssistant
{
    public partial class ucReview : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        private bool settingValues = false;
        private bool isFilling = false;
        TUC_GridG.GridG gGrid;
        TUC_GridG.GridG ggReview;
        GL_Account_Lookup_Rep.Repository_GL_Lookup glLookup;
        private string _saleType = "P";
        private double gst_pct = 0;
        private double pst_pct = 0;
        private int PreSaleSeq = -1;
        private bool isTierPresale = false;


        public ucReview(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();
            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_selectedLots.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "LotSaleAssistant";
            settingValues = true;
            acctYearPeriod1.TRDBName = hmCon.TRDB;
            acctYearPeriod1.TRServerName = hmCon.CompanyServer;
            acctYearPeriod1.checkClose = "T" ; //Turns on/off Open period check.
            acctYearPeriod1.MessageBoxHeaderText = "Lot Sale Assistant";
            settingValues = false;
            UpdateDate();
            tcDetail.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

            LoadLotSaleAdjustmentsGrid();

            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for Tier Pre-Sale:" + hmCon.SQLExecutor.Exception.Message);
            else if (Convert.ToBoolean(result))
            {
                isTierPresale = true;
            }
            else
            {
                colPresaleSeq.Visible = false;
                colPresaleSeq.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void LoadLotSaleAdjustmentsGrid()
        {
            da_lotSaleAdj.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_lueCostingLevels.SelectCommand.Parameters["@ProjType"].Value = "L";
            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvLotSale, da_lotSaleAdj, ds_lotSaleAdj11);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            ggReview = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvReview, da_selectedLots, ds_selectedLots1);
            ggReview.AllowTabCreateNewRecord = false;
            ggReview.AskBeforeDelete = false;
            ggReview.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggReview_AllowDelete);

            glLookup = new GL_Account_Lookup_Rep.Repository_GL_Lookup();
            glLookup.HideVailidation = true;
            glLookup.HideSubCode = true;
            glLookup.HMConnection = hmCon;
            glLookup.DevXMgr = tuc_mgr;            

            string sql = "select  isnull(lv1_land_desc,'')[lv1_land_desc] , isnull(lv2_land_desc,'')[lv2_land_desc] , isnull(lv3_land_desc,'')[lv3_land_desc] , isnull(lv4_land_desc,'')[lv4_land_desc] ," +
                "isnull(lv1_active_land,'F')[lv1_active_land] , isnull(lv2_active_land,'F')[lv2_active_land] , isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl ";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                popup.ShowPopup("Error loading costing reference setup:" + hmCon.SQLExecutor.Exception.Message);
                gcLotSale.Enabled = false;
            }
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    SetCostingReferenceColumns(dt.Rows[0]);
                }
            }
            if (hmCon.CountryCode == "C")
            {
                colTax1.Caption = "GST";
                colTax2.Caption = "PST"; 
                colprov.Caption = "Province";
                colpostal.Caption = "Postal Code";
            }
            else if (hmCon.CountryCode == "U")
            {
                colTax1.Caption = "Tax 1";
                colTax2.Caption = "Tax 2";
                colprov.Caption = "State";
                colpostal.Caption = "Zip";
            }
          


        }

        

        private void SetCostingReferenceColumns(DataRow row)
        {
            colLV_1_ID.Caption = row["lv1_land_desc"].ToString();
            colLV_2_ID.Caption = row["lv2_land_desc"].ToString();
            colLV_3_ID.Caption = row["lv3_land_desc"].ToString();
            colLV_4_ID.Caption = row["lv4_land_desc"].ToString();

            colLV_1_ID.OptionsColumn.ShowInCustomizationForm = colLV_1_ID.Visible = (row["lv1_active_land"].ToString() == "T");
            colLV_2_ID.OptionsColumn.ShowInCustomizationForm = colLV_2_ID.Visible = (row["lv2_active_land"].ToString() == "T");
            colLV_3_ID.OptionsColumn.ShowInCustomizationForm = colLV_3_ID.Visible = (row["lv3_active_land"].ToString() == "T");
            colLV_4_ID.OptionsColumn.ShowInCustomizationForm = colLV_4_ID.Visible = (row["lv4_active_land"].ToString() == "T");

        }
      
        bool gGrid_AllowDelete(object sender, DataRow row)
        {

            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;

        }
			

        public void RefreshMe(string saleType)
        {
            isFilling = true;
            hmCon.SQLExecutor.ExecuteNonQuery("delete working_ld_lsa_lotsaleadjustments where username = '"+hmCon.MLUser+"'",hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                popup.ShowPopup("Error clearing working lot sale adjustments:" + hmCon.SQLExecutor.Exception.Message);
                
            }

            _saleType = saleType;

            
            if (saleType == "p")
            {
                //splitterControl1.Visible = grpLotAdjustments.Visible = false;
                tcDetail.SelectedTabPage = tpPreSaleDeposits;
                gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.Edit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                colagreement_sell_price.OptionsColumn.AllowEdit = false;

            }
            else if (saleType == "d")
            {
                splitterControl1.Visible = grpLotAdjustments.Visible = false;
                tcDetail.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.Edit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                colagreement_sell_price.OptionsColumn.AllowEdit = false;

            }
            else
            {
                //splitterControl1.Visible = grpLotAdjustments.Visible = true;
                tcDetail.SelectedTabPage = tpLotSalesAdjstments;
                gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.Edit.Visible = false;
                gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                colagreement_sell_price.OptionsColumn.AllowEdit = false;

                //bug fix....agreenemt sell price should not be allowed to be changed( Item pa103)
                //gcReview.EmbeddedNavigator.Buttons.CancelEdit.Visible = true;
                //gcReview.EmbeddedNavigator.Buttons.Edit.Visible = true;
                //gcReview.EmbeddedNavigator.Buttons.EndEdit.Visible = true;
                //colagreement_sell_price.OptionsColumn.AllowEdit = true;
            }

            try
            {
                settingValues = true;
                ds_lueCostingLevels1.Clear();
                da_lueCostingLevels.Fill(ds_lueCostingLevels1);
                acctYearPeriod1.RefreshAcctPeriod();
                ds_selectedLots1.Clear();
                da_selectedLots.Fill(ds_selectedLots1);
                ds_LotSaleAdjustments1.Clear();
                da_LotSaleAdjustments.Fill(ds_LotSaleAdjustments1);
                settingValues = false;
                UpdateDate();
                deInvoiceDate.DateTime = DateTime.Today;
                if (settingValues) return;

                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInvoiceDate.DateTime.ToShortDateString() + "' and PERIOD <> 13 order by END_DATE";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting year and period from date:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        settingValues = true;
                        acctYearPeriod1.luAcctPeriod.EditValue = dt.Rows[0]["PERIOD"];
                        acctYearPeriod1.luAcctYear.EditValue = dt.Rows[0]["AR_YEAR"];
                        settingValues = false;
                    }
                }
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }

            isFilling = false;
            gvReview_FocusedRowChanged(gvReview, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvReview.FocusedRowHandle));
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
                settingValues = true;
                deInvoiceDate.DateTime = new DateTime(iYear, iMonth, 1);
                settingValues = false;

            }
        }

        private bool isDateInValid()
        {
            bool returnValue = true;

            //Due to issues with possibly slow database this prevents the date from being 1/1/0001 for invalid values.
            if (deInvoiceDate.DateTime == DateTime.MinValue)
                UpdateDate();

            if (deInvoiceDate.EditValue != DBNull.Value && deInvoiceDate.EditValue != null)
            {
                string sSQL = @"select dbo.fn_SubledgerPeriodValid( '" + deInvoiceDate.DateTime.ToShortDateString() + @"', " + acctYearPeriod1.luAcctPeriod.EditValue + @", " + acctYearPeriod1.luAcctYear.EditValue.ToString() + @" )";
                object oResult = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (oResult == null || oResult == DBNull.Value)
                    oResult = "F";

                if (oResult.Equals( "F" ))
                    returnValue = false;

                if (!returnValue)
                {
                    popup.ShowPopup("Invoice date must be within the selected year/period.");
                }

                sSQL = "select agreement_num from PROJ_LOT_AGREEMENT a where a.agreement_date > '" + deInvoiceDate.DateTime.ToShortDateString() + "' and  a.agreement_id in(" +
                "SELECT w.agreement_id FROM working_ld_LotSearch w WHERE     (w.username = '"+hmCon.MLUser+"LotSaleAssistant') AND (w.selected = 1) )";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error validating invoice date later then agreement date" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            popup.ShowPopup("Invoice Date can not be less then the agreement date.");
                            returnValue = false;
                        }
                    }
                }

            }
            else
            {
                popup.ShowPopup("Invoice date is required.");
            }

            return returnValue;
        }

        //private bool isDateInValid()
        //{
        //    bool returnValue = true;
        //    if (deInvoiceDate.EditValue != DBNull.Value && deInvoiceDate.EditValue != null)
        //    {
        //        string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInvoiceDate.DateTime.ToShortDateString() + "' and PERIOD <> 13 order by END_DATE";
        //        DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
        //        if (hmCon.SQLExecutor.Exception != null)
        //            popup.ShowPopup("Error setting year and period from invoice date:" + hmCon.SQLExecutor.Exception.Message);
        //        else
        //        {
        //            if (dt.Rows.Count > 0)
        //            {
        //                if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() == dt.Rows[0]["PERIOD"].ToString()
        //                   && acctYearPeriod1.luAcctYear.EditValue.ToString() == dt.Rows[0]["AR_YEAR"].ToString())
        //                {
        //                    returnValue = false;
        //                }
        //            }
        //        }

        //        if (returnValue)
        //        {
        //            popup.ShowPopup("Invoice date must be within the selected year/period.");
        //        }

        //    }
        //    else
        //        popup.ShowPopup("Invoice date is required.");



        //    return returnValue;
        //}

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
            else if (!isDateInValid())
            {
                bValid = false;
            }

            return bValid;
        }

        private bool isPeriodSelectionValid(bool showMessage)
        {
            bool returnValue = true;

            if (acctYearPeriod1.luAcctYear.EditValue != null && acctYearPeriod1.luAcctYear.EditValue != DBNull.Value && acctYearPeriod1.luAcctPeriod.EditValue != null && acctYearPeriod1.luAcctPeriod.EditValue != DBNull.Value)
            {
                object oPeriodOpen = hmCon.SQLExecutor.ExecuteScalar("Select IsNull(PERIOD_OPEN,'F') From AR_PERIODS Where AR_YEAR = " + acctYearPeriod1.luAcctYear.EditValue.ToString() + " And PERIOD = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + "", hmCon.TRConnection);
                if (oPeriodOpen == DBNull.Value || oPeriodOpen == null) oPeriodOpen = "F";

                if (oPeriodOpen.ToString() == "F")
                {
                    if (showMessage)
                        popup.ShowPopup("Year and Period combination are not open.");
                    returnValue = false;
                }
            }
            else
            {
                if (showMessage)
                    popup.ShowPopup("Please select a year and period.");
                returnValue = false;
            }

            return returnValue;
        }

        private void gvLotSale_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colworking_ld_LotSearch_ID.FieldName] = gvReview.GetFocusedDataRow()[colID.FieldName];
                row[colusername1.FieldName] = hmCon.MLUser;
                row[colTax1.FieldName] = false;
                row[colTax2.FieldName] = false;
                row[colCostRecoverable.FieldName] = false;
                row[colAmount.FieldName] = 0;
                row[colLV_1_ID.FieldName] = -1;
                row[colLV_2_ID.FieldName] = -1;
                row[colLV_3_ID.FieldName] = -1;
                row[colLV_4_ID.FieldName] = -1;
                row[colLEM_COMP.FieldName] = "O";
                row[colExtendedDescription.FieldName] = "";
            }
        }
        private void gvLotSale_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }
        private void gvLotSale_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
            DevExpress.XtraGrid.Columns.GridColumn[] requiredColumns;
            if (Convert.ToBoolean(rv[colCostRecoverable.FieldName]))
            {
                if (colLV_4_ID.OptionsColumn.ShowInCustomizationForm)
                    requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1, colLV_1_ID, colLV_2_ID, colLV_3_ID, colLV_4_ID };
                else if (colLV_3_ID.OptionsColumn.ShowInCustomizationForm)
                    requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1, colLV_1_ID, colLV_2_ID, colLV_3_ID };
                else if (colLV_2_ID.OptionsColumn.ShowInCustomizationForm)
                    requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1, colLV_1_ID, colLV_2_ID };
                else if (colLV_1_ID.OptionsColumn.ShowInCustomizationForm)
                    requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1, colLV_1_ID };
                else
                    requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1 };

            }
            else
            {
                requiredColumns = new DevExpress.XtraGrid.Columns.GridColumn[] { colLotSaleAdjustments_ID, colLotSaleAdjustments_ID1, colExpenseAccount };
            }


            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, requiredColumns, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            
        }

        private string ValidateColumnsRequired(DataRowView RowView, DevExpress.XtraGrid.Columns.GridColumn[] gridColumns, bool multiLine)
        {
            string returnValue = "";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridColumns)
            {
                bool Process = false;
                if (RowView[col.FieldName] == DBNull.Value || RowView[col.FieldName] == null)
                {
                    Process = true;
                }
                else if (RowView[col.FieldName].ToString().Trim() == "")
                {
                    Process = true;
                }
                else if (RowView[col.FieldName].ToString() == "-1")
                {
                    Process = true;
                }

                if (Process)
                {

                    returnValue += GetColumnsCaption(col) + " is required.";
                    if (!multiLine)
                        break;
                    else
                        returnValue += "\r\n";

                }
            }

            return returnValue;
        }
        private string GetColumnsCaption(DevExpress.XtraGrid.Columns.GridColumn col)
        {
            StringBuilder newText = new StringBuilder();
            if (col.Caption.ToString().Trim() == "")
            {
                if (string.IsNullOrEmpty(col.FieldName))
                    return "";

                newText.Append(col.FieldName[0]);
                for (int i = 1; i < col.FieldName.Length; i++)
                {
                    if (char.IsUpper(col.FieldName[i]))
                        newText.Append(' ');
                    newText.Append(col.FieldName[i]);
                }
            }
            else
                newText.Append(col.Caption);


            return newText.ToString();
        }
        private string IsColumnUnique(DataRowView row, DevExpress.XtraGrid.Columns.GridColumn validateStringColumn, DevExpress.XtraGrid.Columns.GridColumn IDColumn)
        {

            string errorMessage = "";

            if (row != null)
            {
                string sql = "select count(" + validateStringColumn.FieldName + ") from " + row.Row.Table.TableName + " where " + validateStringColumn.FieldName + " = '" + row[validateStringColumn.FieldName].ToString().Replace("'", "''") +
                        "' and " + IDColumn.FieldName + " != " + row[IDColumn.FieldName].ToString();
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                {
                    errorMessage = "Error validating " + validateStringColumn.Caption + " :" + hmCon.SQLExecutor.Exception.Message + "\r\n\r\n" + hmCon.SQLExecutor.Exception.StackTrace;

                }
                int count = -1;
                try { count = Convert.ToInt32(result); }
                catch { }

                if (count != 0)
                {
                    errorMessage = "Column " + GetColumnsCaption(validateStringColumn) + " already exists.";

                }
                else
                {
                    errorMessage = "";
                }
            }
            return errorMessage;
        }
     
        private void ri_lueCostingCode2_Enter(object sender, EventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(gvLotSale.FocusedRowHandle);
            if (row != null)
            {
                int LvID = -1;
                try
                {
                    LvID = Convert.ToInt32(row[colLV_1_ID.FieldName]);
                }
                catch { }

                bs_CC2_Restricted.Filter = "lv1ID =" + LvID.ToString();
                ((LookUpEdit)sender).Properties.DataSource = bs_CC2_Restricted;
            }
        }
        private void ri_lueCostingCode3_Enter(object sender, EventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(gvLotSale.FocusedRowHandle);
            if (row != null)
            {
                int LvID = -1;
                try
                {
                    LvID = Convert.ToInt32(row[colLV_2_ID.FieldName]);
                }
                catch { }

                bs_CC3_Restricted.Filter = "lv2ID =" + LvID.ToString();
                ((LookUpEdit)sender).Properties.DataSource = bs_CC3_Restricted;
            }
        }
        private void ri_lueCostingCode4_Enter(object sender, EventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(gvLotSale.FocusedRowHandle);
            if (row != null)
            {
                int LvID = -1;
                try
                {
                    LvID = Convert.ToInt32(row[colLV_3_ID.FieldName]);
                }
                catch { }

                bs_CC4_Restricted.Filter = "lv3ID =" + LvID.ToString();
                ((LookUpEdit)sender).Properties.DataSource = bs_CC4_Restricted;

            }
        }
        private void gvLotSale_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colCostRecoverable)
                {
                    bool bChecked = false;
                    try { bChecked = Convert.ToBoolean(e.Value); }
                    catch { }

                    if (row[colLotSaleAdjustments_ID1.FieldName] != null && row[colLotSaleAdjustments_ID1.FieldName] != DBNull.Value)
                    {
                        DataRowView rv = (DataRowView)ri_lueLSAcode.GetDataSourceRowByKeyValue(row[colLotSaleAdjustments_ID1.FieldName]);
                        row[colExpenseAccount.FieldName] = getExpenseAccount(e.Value, rv[colExpenseAccount.FieldName]);

                        if (bChecked)
                        {
                            row[colLV_1_ID.FieldName] = rv[colLV_1_ID.FieldName];
                            row[colLV_2_ID.FieldName] = rv[colLV_2_ID.FieldName];
                            row[colLV_3_ID.FieldName] = rv[colLV_3_ID.FieldName];
                            row[colLV_4_ID.FieldName] = rv[colLV_4_ID.FieldName];
                        }
                        else
                        {
                            row[colLV_1_ID.FieldName] = -1;
                            row[colLV_2_ID.FieldName] = -1;
                            row[colLV_3_ID.FieldName] = -1;
                            row[colLV_4_ID.FieldName] = -1;
                        }
                    }
                    else
                    {
                        row[colExpenseAccount.FieldName] = "";
                        row[colLV_1_ID.FieldName] = -1;
                        row[colLV_2_ID.FieldName] = -1;
                        row[colLV_3_ID.FieldName] = -1;
                        row[colLV_4_ID.FieldName] = -1;
                    }
                }
                else if (e.Column == colLV_1_ID)
                {
                    row[colLV_2_ID.FieldName] = -1;
                    row[colLV_3_ID.FieldName] = -1;
                    row[colLV_4_ID.FieldName] = -1;
                }
                else if (e.Column == colLV_2_ID)
                {
                    row[colLV_3_ID.FieldName] = -1;
                    row[colLV_4_ID.FieldName] = -1;
                }
                else if (e.Column == colLV_3_ID)
                {
                    row[colLV_2_ID.FieldName] = -1;
                    row[colLV_3_ID.FieldName] = -1;
                    row[colLV_4_ID.FieldName] = -1;
                }
                else if (e.Column == colLotSaleAdjustments_ID || e.Column == colLotSaleAdjustments_ID1)
                {
                    SetSaleAdjustmentDefaults(row);
                }
                else if (e.Column == colAmount || e.Column == colTax1 || e.Column == colTax2)
                {
                    setExtendedAmount(row);
                }
            }
        }

        private void SetSaleAdjustmentDefaults(DataRow row)
        {
            DataRowView rv = (DataRowView)ri_lueLSAcode.GetDataSourceRowByKeyValue(row[colLotSaleAdjustments_ID1.FieldName]);
            row[colCostRecoverable.FieldName] = rv[colCostRecoverable.FieldName];
            row[colExpenseAccount.FieldName] = getExpenseAccount(rv[colCostRecoverable.FieldName], rv[colExpenseAccount.FieldName]);
            row[colAmount.FieldName] = rv[colAmount.FieldName];
            row[colTax1.FieldName] = rv[colTax1.FieldName];
            row[colTax2.FieldName] = rv[colTax2.FieldName];
            setExtendedAmount(row);
            row[colExtendedDescription.FieldName] = rv[colExtendedDescription.FieldName];
            row[colLV_1_ID.FieldName] = rv[colLV_1_ID.FieldName];
            row[colLV_2_ID.FieldName] = rv[colLV_2_ID.FieldName];
            row[colLV_3_ID.FieldName] = rv[colLV_3_ID.FieldName];
            row[colLV_4_ID.FieldName] = rv[colLV_4_ID.FieldName];
        }

        private object getExpenseAccount(object costRecoverable,object ExpAcct)
        {
            object returnObject = "";
            try
            {
                if (Convert.ToBoolean(costRecoverable))
                {
                    returnObject = hmCon.SQLExecutor.ExecuteScalar("select dbo.fn_get_projwo_account (" + gvReview.GetFocusedRowCellValue(colpri_id).ToString() + " ,'O', 'W')", hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                    {
                        popup.ShowPopup("Error loading WIP account");
                        returnObject = "";
                    }
                }
                else
                {
                    int iAdj_ID = -1, iPri_id = -1;
                    try { iAdj_ID = Convert.ToInt32(gvLotSale.GetDataRow(gvLotSale.FocusedRowHandle)["LotSaleAdjustments_ID"]); }
                    catch { }
                    try { iPri_id = Convert.ToInt32(gvReview.GetFocusedRowCellValue(colpri_id)); }
                    catch { }

                    object oExpenseAccount = hmCon.SQLExecutor.ExecuteScalar("Select dbo.SwapGLSegment(ExpenseAccount,(Select pri_division from PRoj_header where pri_id = " + iPri_id.ToString() + ")) From LD_LotSaleAdjustments where LotSaleAdjustments_ID =" + iAdj_ID.ToString(), hmCon.TRConnection);
                    returnObject = (oExpenseAccount == null ? (object)DBNull.Value : oExpenseAccount);
                }
            }
            catch { }

            return returnObject;
        }
        private void setExtendedAmount(DataRow row)
        {
            double Amount = 0;
            double gst = 0;
            double pst = 0;

            try{Amount = Convert.ToDouble(row[colAmount.FieldName]);}catch { }

            try
            {
                if (Convert.ToBoolean(row[colTax1.FieldName]))
                {
                    gst = Amount * gst_pct / 100;
                }
            }catch{}
            try
            {
                if (Convert.ToBoolean(row[colTax2.FieldName]))
                {
                    pst = Amount * pst_pct / 100;
                }
            }catch { }

            row[colExtendedAmount.FieldName] = Amount + gst + pst;
        
        }

        private void gvLotSale_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow row = gvLotSale.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (row[colCostRecoverable.FieldName] != null && row[colCostRecoverable.FieldName] != DBNull.Value)
                {
                    if (!Convert.ToBoolean(row[colCostRecoverable.FieldName]))
                    {
                        if (e.Column == colLV_1_ID || e.Column == colLV_2_ID || e.Column == colLV_3_ID || e.Column == colLV_4_ID)
                        {
                            e.RepositoryItem = ri_lueNotEditable;
                        }
                        else if (e.Column == colExpenseAccount)
                        {
                            e.RepositoryItem = glLookup;
                        }

                    }
                }

            }
        }

        private void gvReview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;  
            DataRow row = gvReview.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                if (tcDetail.SelectedTabPage == tpLotSalesAdjstments)
                {
                    da_lotSaleAdj.SelectCommand.Parameters["@working_ld_LotSearch_ID"].Value = row[colID.FieldName];
                    ds_lotSaleAdj11.Clear();
                    da_lotSaleAdj.Fill(ds_lotSaleAdj11);
                }
                else if (tcDetail.SelectedTabPage == tpPreSaleDeposits)
                {
                    string presql = @"select min(isnull(dep.PresaleSeq,-1))
		from PROJ_LOT_AGREEMENT_DEPOSITS dep
		join LD_Deposits d on d.Deposit_ID = dep.deposit_id
		join working_ld_LotSearch h on h.agreement_id=dep.agreement_id	
		where h.username='" + hmCon.MLUser + @"LotSaleAssistant' and h.selected = 1 and 
		ISNULL(d.type,'') = 'P' and isnull(dep.processed,'F') = 'F' and dep.agreement_id =" + row["agreement_id"];
                    object preresult = hmCon.SQLExecutor.ExecuteScalar(presql, hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                    {
                        popup.ShowPopup("Error checking for pre-sale sequence:" + hmCon.SQLExecutor.Exception.Message);

                    }
                    else if (preresult != null && preresult != DBNull.Value)
                    {
                        PreSaleSeq = Convert.ToInt32(preresult);
                    }
                    else
                        PreSaleSeq = -1;

                    dsDeposits1.Clear();
                    daDeposits.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                    daDeposits.Fill(dsDeposits1);
                }

                gst_pct = 0;
                pst_pct = 0;
                string sql = "select gst.GST_PCT from PROJ_LOT_AGREEMENT a " +
                "join CUSTOMERS c on c.CUSTOMER_ID = a.purchaser_id "+
                "left outer join GST_CODES gst on gst.GST_CODE = c.GST_CODE "+
                "where agreement_id = "+row[colagreement_id.FieldName].ToString();
                object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting gst percent:" + hmCon.SQLExecutor.Exception.Message);
                try { gst_pct = Convert.ToDouble(result); }
                catch { }
                sql = "select pst.SALES_TAX from PROJ_LOT_AGREEMENT a " +
                "join CUSTOMERS c on c.CUSTOMER_ID = a.purchaser_id " +
                "left outer join SALES_TAXES pst on pst.SALES_TAX_ID = c.SALES_TAX_ID " +
                "where agreement_id = " + row[colagreement_id.FieldName].ToString();
                result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting pst percent:" + hmCon.SQLExecutor.Exception.Message);
                try { pst_pct = Convert.ToDouble(result); }
                catch { }


            }
        }


        private bool ggReview_AllowDelete(object sender, DataRow row)
        {
            return false;
        }

        private void gvDeposit_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (isTierPresale && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                DataRow row = gvDeposit.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    int rowSeq = -1;
                    try { rowSeq = Convert.ToInt32(row[colPresaleSeq.FieldName]); }
                    catch { }
                    if (rowSeq != PreSaleSeq)
                    {
                        e.Appearance.BackColor = Color.LightGray;
                        e.Appearance.BackColor2 = Color.LightGray;

                    }
                }
            }
        }
       
    }
}
