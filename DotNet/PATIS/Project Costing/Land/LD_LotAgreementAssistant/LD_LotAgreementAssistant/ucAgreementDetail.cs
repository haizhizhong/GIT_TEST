using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAgreementAssistant
{
    public partial class ucAgreementDetail : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        TUC_GridG.GridG gGrid;
        TUC_GridG.GridG gGridAgree;
        TUC_GridG.GridG gGridDiscount;
        bool isFilling = false;
        private bool isTierPresale = false;


        public ucAgreementDetail(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_AgreementDetails.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_depositsDetail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            daLevyDetail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            daDiscountDetail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            if (hmCon.CountryCode == "C")
            {
                colgst.Caption = "GST";
                colpst.Caption = "PST";
            }
            else if (hmCon.CountryCode == "U")
            {
                colgst.Caption = "Tax 1";
                colpst.Caption = "Tax 2";
            }

            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvDeposits, da_depositsDetail, ds_depositsDetail1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvDiscounts, daDiscountDetail, dsDiscountDetail1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);


            gGridAgree = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvAgreementDetails, da_AgreementDetails, ds_AgreementDetails1);

            SetupLevels();

            Object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", hmCon.TRConnection);
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

        private void SetupLevels()
        {
            string sSQL = @"select  isnull(lv1_land_desc,'')[lv1_land_desc], isnull(lv2_land_desc,'')[lv2_land_desc],
                isnull(lv3_land_desc,'')[lv3_land_desc], isnull(lv4_land_desc,'')[lv4_land_desc], 
                isnull(lv1_active_land,'F')[lv1_active_land], isnull(lv2_active_land,'F')[lv2_active_land], 
                isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] 
            from proj_cntl";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        collv1id.Caption = dr["lv1_land_desc"].ToString();
                        collv2id.Caption = dr["lv2_land_desc"].ToString();
                        collv3id.Caption = dr["lv3_land_desc"].ToString();
                        collv4id.Caption = dr["lv4_land_desc"].ToString();

                        collv1id.OptionsColumn.ShowInCustomizationForm = collv1id.Visible = (dr["lv1_active_land"].ToString() == "T");
                        collv2id.OptionsColumn.ShowInCustomizationForm = collv2id.Visible = (dr["lv2_active_land"].ToString() == "T");
                        collv3id.OptionsColumn.ShowInCustomizationForm = collv3id.Visible = (dr["lv3_active_land"].ToString() == "T");
                        collv4id.OptionsColumn.ShowInCustomizationForm = collv4id.Visible = (dr["lv4_active_land"].ToString() == "T");
                    }
                }
            }
        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }			

        public void RefreshMe(string ActionSelected,object masterAgreeID)
        {
            LoadActions(ActionSelected,masterAgreeID);            

            try
            {
                isFilling = true;
                ds_purchasers1.Clear();
                da_Purchasers.Fill(ds_purchasers1);
                ds_lueDepositType1.Clear();
                da_lueDepositType.Fill(ds_lueDepositType1);
                dsLevyDetail1.Clear();
                ds_AgreementDetails1.Clear();
                da_AgreementDetails.Fill(ds_AgreementDetails1);
                
                ds_lueDiscountType1.Clear();
                da_lueDiscountType.Fill(ds_lueDiscountType1);
                ds_lueValueType1.Clear();
                da_lueValueType.Fill(ds_lueValueType1);

                isFilling = false;

            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error in refresh me:" + ex.Message);
            }
            gvAgreementDetails_FocusedRowChanged(gvAgreementDetails,new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle,gvAgreementDetails.FocusedRowHandle));
            CheckForHolds();
        }


        private void CheckForHolds()
        {
            string sql = "declare @username varchar(500) = '" + hmCon.MLUser + "'  " +

                 @"select l.lot_num+' : '+l.block_num[Lot],c.NAME + '('+c.CUSTOMER_CODE+')'[Purchaser] From PROJ_LOT_HOLD h
                    join PROJ_LOT l on l.proj_lot_id = h.proj_lot_id
                    join CUSTOMERS c on c.CUSTOMER_ID = h.purchaser_id
                    join working_ld_laa_proj_lot_agreement s on s.proj_lot_id = h.proj_lot_id 
                    where s.username = @username and CONVERT(date,h.start_date) <= s.agreement_date and CONVERT(date,h.end_date,101) >= s.agreement_date
                    and h.purchaser_id <> s.purchaser_id";


            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for holds: " + hmCon.SQLExecutor.Exception.Message);
            else
            {
                if (dt.Rows.Count > 0)
                {
                    string Message = "There are current holds on the following :\r\n";
                    foreach (DataRow row in dt.Rows)
                    {
                        Message += "Lot/Block :" + row["Lot"].ToString() + "\r\n Purchaser : " + row["Purchaser"].ToString() + "\r\n\r\n";
                    }
                    popup.ShowPopup(Message);

                }
            }

        }

        public bool ValidateReservation()
        {
            bool bValid = true;

            string sPur1, sPur2, sPur3;
            string sSQL = @"select proj_lot_id, isnull(purchaser_id,-1) [p1], isnull(purchaser_id2,-1) [p2], isnull(purchaser_id3,-1) [p3] 
                from working_ld_laa_proj_lot_agreement 
                where username='" + hmCon.MLUser + @"'";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr != null)
                        {
                            sPur1 = "null";
                            if (dr["p1"] != null && dr["p1"] != DBNull.Value)
                                sPur1 = dr["p1"].ToString();
                            sPur2 = "null";
                            if (dr["p2"] != null && dr["p2"] != DBNull.Value)
                                sPur2 = dr["p2"].ToString();
                            sPur3 = "null";
                            if (dr["p3"] != null && dr["p3"] != DBNull.Value)
                                sPur3 = dr["p3"].ToString();

                            sSQL = "exec LD_Agreement_ValidateReservation " + dr["proj_lot_id"] + ", " + sPur1 + ", " + sPur2 + ", " + sPur3;
                            object oResult = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                            if (oResult != null && oResult != DBNull.Value)
                            {
                                if (!oResult.ToString().Equals("OK"))
                                {
                                    popup.ShowPopup(oResult.ToString());
                                    return false;
                                }
                            }
                            else
                            {
                                popup.ShowPopup("Error validating lot reservation.");
                                return false;
                            }
                        }
                    }
                }
            }
			

            return bValid;
        }

        

        private void LoadActions(string a,object masterAgreeID)
        {
            string sql = "LD_laa_UpdateDetails";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql);
            cmd.Connection = new System.Data.SqlClient.SqlConnection(hmCon.TRConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@ActionType", SqlDbType.VarChar);
            cmd.Parameters.Add("@masterAgreeID", SqlDbType.Int);

            cmd.Parameters["@masterAgreeID"].Value = masterAgreeID;
            cmd.Parameters["@username"].Value = hmCon.MLUser;
            cmd.Parameters["@ActionType"].Value = a;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error :" + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

        }

        private void gvAgreementDetails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            DataRow row = gvAgreementDetails.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                da_depositsDetail.SelectCommand.Parameters["@agreement_id"].Value =  row[colagreement_id.FieldName];
                ds_depositsDetail1.Clear();
                da_depositsDetail.Fill(ds_depositsDetail1);

                daLevyDetail.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                dsLevyDetail1.Clear();
                daLevyDetail.Fill(dsLevyDetail1);

                daDiscountDetail.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                dsDiscountDetail1.Clear();
                daDiscountDetail.Fill(dsDiscountDetail1);
            }
        }

        private void gvDeposits_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;

            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { coldeposit_id, coldeposit_amt, coloff_set_days, }, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[coldeposit_amt.FieldName], false))
            {
                popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (isPreSaleSeqInvalid((DataRowView)e.Row))
            {
                popup.ShowPopup("Pre-sale sequence must be between 1 and 10.");
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

        private bool isPreSaleSeqInvalid(DataRowView drv)
        {
            bool returnValue = false;
            if (isTierPresale)
            {
                if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(drv[coldeposit_id.FieldName])).Type == "P")
                {
                    int PresaleSeq = -1;
                    try
                    {
                        PresaleSeq = Convert.ToInt32(drv[colPresaleSeq.FieldName]);
                    }
                    catch { }
                    if (PresaleSeq > 10 || PresaleSeq < 1)
                        returnValue = true;
                }

            }


            return returnValue;
        }

        private void gvDeposits_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void ri_lueDeposists_EditValueChanged(object sender, EventArgs e)
        {
            object Offset = ((LookUpEdit)sender).GetColumnValue("Off_Set_Days");

            gvDeposits.SetFocusedRowCellValue(coloff_set_days, Offset);

            LookUpEdit lue = (LookUpEdit)sender;
            if (lue.EditValue != null && lue.EditValue != DBNull.Value && isTierPresale)
            {
                try
                {
                    if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(lue.EditValue)).Type == "P")
                    {
                        object sequence = hmCon.SQLExecutor.ExecuteScalar(@"
select max(isnull(t.presaleseq,0)) from working_ld_laa_proj_lot_agreement_deposits t
join LD_Deposits d on d.Deposit_ID = t.Deposit_ID
where d.Type = 'P' and t.username = '" + hmCon.MLUser + "' and t.agreement_id =" + da_depositsDetail.SelectCommand.Parameters["@agreement_id"].Value.ToString(), hmCon.TRConnection);
                        if (sequence != null && sequence != DBNull.Value)
                            sequence = Convert.ToInt32(sequence) + 1;
                        else
                            sequence = 1;
                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, sequence);
                    }
                    else
                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value);
                }
                catch { gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value); }
            }
        }

        private void gvDeposits_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvDeposits.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colagreement_id.FieldName] = gvAgreementDetails.GetFocusedRowCellValue(colagreement_id.FieldName);
                row[colusername.FieldName] = hmCon.MLUser;

            }
        }

        private void gvDeposits_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == coldeposit_amt)
                e.RepositoryItem = ri_seNumaric2;

            else if (e.Column == colPresaleSeq)
            {
                DataRow row = gvDeposits.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row[coldeposit_id.FieldName] != null && row[coldeposit_id.FieldName] != DBNull.Value)
                    {
                        try
                        {
                            if (ds_lueDepositType1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(row[coldeposit_id.FieldName])).Type == "P")
                                e.RepositoryItem = ri_teNumaric0;
                            else
                                e.RepositoryItem = ri_teReadOnly;
                        }
                        catch { e.RepositoryItem = ri_teReadOnly; }
                    }
                    else
                        e.RepositoryItem = ri_teReadOnly;
                }
            }
        }

        private void gvAgreementDetails_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colsell_price)
            {
                DataRow row = gvAgreementDetails.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    double sellPrice = 0, gst = 0, pst = 0;

                    try
                    {
                        sellPrice = Convert.ToDouble(row[colsell_price.FieldName]);
                    }
                    catch { }
                    try
                    {
                        if (Convert.ToBoolean(row[colgst.FieldName]))
                            gst = Convert.ToDouble(row[colGST_PCT.FieldName]);
                    }
                    catch { }
                    try
                    {
                        if (Convert.ToBoolean(row[colpst.FieldName]))
                            pst = Convert.ToDouble(row[colPST_PCT.FieldName]);
                    }
                    catch { }

                    row[colTotalSellPrice.FieldName] = sellPrice + (sellPrice * pst / 100) + (sellPrice * gst / 100);


                    string sql = @"select COUNT(d.ID) from working_ld_laa_proj_lot_agreement_deposits d
                        join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                        where username = '" + hmCon.MLUser + "' and dep.DepositType = 'P' and d.agreement_id ="+row[colagreement_id.FieldName].ToString();
                    object result = hmCon.SQLExecutor.ExecuteScalar(sql, hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                        popup.ShowPopup("Error checking for percentage deposits:" + hmCon.SQLExecutor.Exception.Message);
                    else if (result != null && result != DBNull.Value)
                    {
                        if (Convert.ToInt32(result) > 0)
                        {
                            if (popup.ShowPopup("Would you like to re-calculate deposit amounts?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                            {
                                sql = @"update working_ld_laa_proj_lot_agreement_deposits set
                                deposit_amt = " + sellPrice.ToString().Replace(",", "") + @" * dep.AmountPercent / 100 
                                from working_ld_laa_proj_lot_agreement_deposits d
                                join LD_Standard_Terms_Deposits_Det dep on dep.ID = d.Ref_Deposits_Det_ID
                                where username = '" + hmCon.MLUser + "' and dep.DepositType = 'P' and d.agreement_id ="+row[colagreement_id.FieldName].ToString();
                                hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                                if (hmCon.SQLExecutor.Exception != null)
                                    popup.ShowPopup("Error setting percentage deposits:" + hmCon.SQLExecutor.Exception.Message);
                                ds_depositsDetail1.Clear();
                                da_depositsDetail.Fill(ds_depositsDetail1);
                            }
                        }
                    }


                }
            }
           
        }

        private void gvAgreementDetails_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;
            if (rv != null)
            {


                if( !isGreaterThenZero( rv[colsell_price.FieldName],true))
                {
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    popup.ShowPopup("Sell Price must be greater than zero.");
                }
                else if( !isGreaterThenZero( rv[coldown_payment.FieldName],true))
                {
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    popup.ShowPopup("Actual Down Payment must be greater than zero.");
                }
                else if (Convert.ToDecimal(rv[coldown_payment.FieldName]) > int.MaxValue)
                {
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    popup.ShowPopup("Down Payment is too large.");
                }
                else if (Convert.ToDecimal(rv[colsell_price.FieldName]) > int.MaxValue)
                {
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    popup.ShowPopup("Sell Price is too large.");
                }
                else if (Convert.ToDecimal(rv[coldown_payment.FieldName]) > Convert.ToDecimal(rv[colsell_price.FieldName]))
                {
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    popup.ShowPopup("Sell price must be greater than Actual Down Payment.");
                }
            }

        }

        private void gvAgreementDetails_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvDiscounts_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvDiscounts.GetDataRow(e.RowHandle);
            dr[colagreement_id2.FieldName] = gvAgreementDetails.GetFocusedRowCellValue(colagreement_id.FieldName);
            dr[colprocessed.FieldName] = false;
            dr[colusername2.FieldName] = hmCon.MLUser;
        }

        private void gvDiscounts_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvDiscounts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colLD_Discounts_ID, colType, colValue }, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[colValue.FieldName], false))
            {
                popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (IsNumberToLarge(((DataRowView)e.Row)[colValue.FieldName]))
            {
                popup.ShowPopup("Value is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
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


