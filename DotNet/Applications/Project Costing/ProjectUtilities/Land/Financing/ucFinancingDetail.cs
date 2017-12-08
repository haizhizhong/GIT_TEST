using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;

namespace ProjectUtilities.Land.Financing
{
    public partial class ucFinancingDetail : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private bool isFilling = false;
        private TUC_GridG.GridG gGridFinancing;
        private TUC_GridG.GridG gGridRepaymentType;
        private TUC_GridG.GridG gGridMinRepaySch;
        private bool _ReadOnly = false;
        private int _PRI_ID = -1;
        private int _Financing_ID = -1;

        public ucFinancingDetail(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            
            RunSetups();
        }

        private void RunSetups()
        {
            radRepayment.EditValue = "P";

            gGridFinancing = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvFinancing, da_Financing, ds_Financing1);
            gGridFinancing.AskBeforeDelete = false;
            gGridFinancing.AllowTabCreateNewRecord = true;
            gGridFinancing.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGridFinancing_AllowDelete);
            gGridFinancing.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGridFinancing_AfterUpdate);

            gGridRepaymentType = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvRepaymentType, da_Repayment, ds_Repayment1);
            gGridRepaymentType.AllowTabCreateNewRecord = true;
            gGridRepaymentType.AskBeforeDelete = false;
            gGridRepaymentType.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGridRepaymentType_AllowDelete);

            gGridMinRepaySch = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvMinRepaySch, da_MinRepaySched, ds_MinRepaySched1);
            gGridMinRepaySch.AllowTabCreateNewRecord = true;
            gGridMinRepaySch.AskBeforeDelete = false;
            gGridMinRepaySch.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGridMinRepaySch_AllowDelete);
			
        }

        void gGridFinancing_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            DataRow row =  gvFinancing.GetDataRow(gvFinancing.FocusedRowHandle);

            if (row != null)
            {
                SetFinancing(row[colFINANCING_ID.FieldName]);
            }

        }

        private bool gGridMinRepaySch_AllowDelete(object sender, DataRow row)
        {
            bool returnValue = false;
            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
            {
                returnValue = true;
                
            }
            return returnValue;   
        }

        private bool gGridRepaymentType_AllowDelete(object sender, DataRow row)
        {
            bool returnValue = false;
            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
            {
                returnValue = true;
                
            }
            return returnValue;   
        }

        private bool gGridFinancing_AllowDelete(object sender, DataRow row)
        {
            bool returnValue = false;
            if (Popup.ShowPopup("Are you sure you want to delete the selected financing and all details?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
            {
                returnValue = true;
                Connection.SQLExecutor.ExecuteNonQuery(
                    "delete LD_Repayment where FINANCING_ID = " + _Financing_ID.ToString() +
                    " delete LD_Min_Repay where FINANCING_ID = " + _Financing_ID.ToString(), Connection.TRConnection);
            }

            return returnValue;               

        }

        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;
            ceDownPaymentIncluded.Enabled = !ReadOnly;
            ceIsLoanClosed.Enabled = !ReadOnly;
            radRepayment.Enabled = !ReadOnly;
            lueLoantype.Enabled = !ReadOnly;
            teAllowableDraws.Enabled = !ReadOnly;
            teDrawsToDate.Enabled = !ReadOnly;
            teEquityPosition.Enabled = !ReadOnly;
            teFinanceablePortion.Enabled = !ReadOnly;
            teInterestPaidToDate.Enabled = !ReadOnly;
            teInterestRate.Enabled = !ReadOnly;
            teLoanBalance.Enabled = !ReadOnly;
            teMaxLoan.Enabled = !ReadOnly;
            teRepaymentsToDate.Enabled = !ReadOnly;
            gvFinancing.OptionsBehavior.Editable = !ReadOnly;
            gvMinRepaySch.OptionsBehavior.Editable = !ReadOnly;
            gvRepaymentType.OptionsBehavior.Editable = !ReadOnly;
            teRenewalPct.Enabled = !ReadOnly;
            teStandByChargePct.Enabled = !ReadOnly;
            txtRepayPct.Enabled = !ReadOnly;
        }

        public void LoadProject(int PriID)
        {
            _PRI_ID = PriID;
            isFilling = true;
            da_Financing.SelectCommand.Parameters["@PRI_ID"].Value = PriID;
            ds_Financing1.Clear();
            da_Financing.Fill(ds_Financing1);
            FillLookups();
            isFilling = false;
            gvFinancing_FocusedRowChanged(gvFinancing,new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle,gvFinancing.FocusedRowHandle));
        }

        private void ucFinancingDetail_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void FillLookups()
        {
            ds_Lookups_Financing1.Clear();

            da_lueLender.Fill(ds_Lookups_Financing1);
            da_lueFinancingType.Fill(ds_Lookups_Financing1);
            da_lueLoanType.Fill(ds_Lookups_Financing1);
            da_lueLotClass.Fill(ds_Lookups_Financing1);
            da_lueLotSubClass.Fill(ds_Lookups_Financing1);
            da_lue_ShareOwners.SelectCommand.Parameters["@Pri_ID"].Value = _PRI_ID;
            da_lue_ShareOwners.Fill(ds_lue_ShareOwners1);            
        }



        private void radRepayment_EditValueChanged(object sender, EventArgs e)
        {
            
            if (radRepayment.EditValue.Equals("P"))
            {
                txtRepayPct.Enabled = true;
            }
            else
            {
                txtRepayPct.Enabled = false;
                txtRepayPct.EditValue = 0;
            }
        }

        private void gvFinancing_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvFinancing.GetDataRow(e.RowHandle);
            if (row != null)
            {
                object op = Connection.SQLExecutor.ExecuteScalar("select isnull((select max(precedence) from LD_Financing where pri_id = " + _PRI_ID.ToString() + "),0) + 1",
                    Connection.TRConnection);
                int precedence = 0;
                try { precedence = Convert.ToInt32(op); }
                catch { }
                row[colPRI_ID.FieldName] = _PRI_ID;
                row["Precedence"] = precedence;
                row["Financed_By"] = "Lender";
                row[colFINANCING_TYPE_ID.FieldName] = 1; //standard
                row[colDRAW_DATE.FieldName] = DateTime.Now.ToShortDateString();
                row[colEXPIRY_DATE.FieldName] = DateTime.Now.ToShortDateString();
                row[colLOAN_TYPE_ID.FieldName] = 1;//Maximum Project
                row[colMAX_LOAN_AMT.FieldName] = 0;
                row[colINTEREST_RATE.FieldName] = 0;
                row[colLOAN_BALANCE.FieldName] = 0;
                row[colDRAWS_TODATE.FieldName] = 0;
                row[colREPAY_TODATE.FieldName] = 0;
                row[colINTEREST_PAID_TODATE.FieldName] = 0;
                row[colFINANCEABLE_PORTION.FieldName] = 0;
                row[colREPAY_TYPE.FieldName] = "P";
                row[colREPAY_PCT_RECEIPTS.FieldName] = 0;
                row[colLOAN_CLOSED.FieldName] = false;
                row[colDOWN_PAY_INC.FieldName] = false;
                row[colALLOWABLE_DRAWS.FieldName] = 0;
                row[colEQUITY_REQUIRED.FieldName] = 0;
                row[colRenewal_Pct.FieldName] = 0;
                row[colStandByCharge_Pct.FieldName] = 0;
            }
        }

        private void gvFinancing_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            DataRow row = gvFinancing.GetDataRow(e.FocusedRowHandle);
            ds_MinRepaySched1.Clear();
            ds_Repayment1.Clear();
            if (row == null)
            {
                _Financing_ID = -1;
                ceDownPaymentIncluded.Enabled = false;
                ceIsLoanClosed.Enabled = false;
                radRepayment.Enabled = false;
                lueLoantype.Enabled = false;
                teAllowableDraws.Enabled = false;
                teDrawsToDate.Enabled = false;
                teEquityPosition.Enabled = false;
                teFinanceablePortion.Enabled = false;
                teInterestPaidToDate.Enabled = false;
                teInterestRate.Enabled = false;
                teLoanBalance.Enabled = false;
                teMaxLoan.Enabled = false;
                teRepaymentsToDate.Enabled = false;
                gvMinRepaySch.OptionsBehavior.Editable = false;
                gvRepaymentType.OptionsBehavior.Editable = false;

                da_MinRepaySched.SelectCommand.Parameters["@Financing_ID"].Value = -1;
                da_Repayment.SelectCommand.Parameters["@Financing_ID"].Value = -1;
                teLoanBalance.EditValue = 0.00;
                teDrawsToDate.EditValue = 0.00;
                teRepaymentsToDate.EditValue = 0.00;
                teInterestPaidToDate.EditValue = 0.00;
            }
            else
            {
                _Financing_ID = Convert.ToInt32(row[colFINANCING_ID.FieldName]);
                ceDownPaymentIncluded.Enabled = !_ReadOnly;
                ceIsLoanClosed.Enabled = !_ReadOnly;
                radRepayment.Enabled = !_ReadOnly;
                lueLoantype.Enabled = !_ReadOnly;
                teAllowableDraws.Enabled = !_ReadOnly;
                teDrawsToDate.Enabled = !_ReadOnly;
                teEquityPosition.Enabled = !_ReadOnly;
                teFinanceablePortion.Enabled = !_ReadOnly;
                teInterestPaidToDate.Enabled = !_ReadOnly;
                teInterestRate.Enabled = !_ReadOnly;
                teLoanBalance.Enabled = !_ReadOnly;
                teMaxLoan.Enabled = !_ReadOnly;
                teRepaymentsToDate.Enabled = !_ReadOnly;
                gvMinRepaySch.OptionsBehavior.Editable = !_ReadOnly;
                gvRepaymentType.OptionsBehavior.Editable = !_ReadOnly;

                da_MinRepaySched.SelectCommand.Parameters["@Financing_ID"].Value = row[colFINANCING_ID.FieldName];
                da_MinRepaySched.Fill(ds_MinRepaySched1);

                da_Repayment.SelectCommand.Parameters["@Financing_ID"].Value = row[colFINANCING_ID.FieldName];
                da_Repayment.Fill(ds_Repayment1);
                SetFinancing(row[colFINANCING_ID.FieldName]);
                
            }
        }

        private void SetFinancing(object financingID)
        {
            double dLoandBalance = 0.00, dDrawsToDate = 0.00, dRepaymentsToDate = 0.00,dInterestToDate = 0.00;
            using (SqlConnection sqlCon = new SqlConnection(Connection.TRConnection))
            {
                SqlCommand sqlCmd = new SqlCommand("exec LD_FinancingGetLoanBalance " + _PRI_ID.ToString() + ", " + financingID.ToString(), sqlCon);
                sqlCon.Open();
                using (SqlDataReader dr = sqlCmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            if (dr["Draws"] != DBNull.Value && dr["Draws"] != null)
                            {
                                try { dDrawsToDate = Convert.ToDouble(dr["Draws"]); }
                                catch { }
                            }

                            if (dr["Repayments"] != DBNull.Value && dr["Repayments"] != null)
                            {
                                try { dRepaymentsToDate = Convert.ToDouble(dr["Repayments"]); }
                                catch { }
                            }
                            if (dr["Interest"] != DBNull.Value && dr["Interest"] != null)
                            {
                                try { dInterestToDate = Convert.ToDouble(dr["Interest"]); }
                                catch { }
                            }
                            dLoandBalance = dDrawsToDate + dRepaymentsToDate;
                        }
                    }
                    dr.Close();
                }
                sqlCon.Close();
            }
            teLoanBalance.EditValue = dLoandBalance;
            teDrawsToDate.EditValue = dDrawsToDate;
            teRepaymentsToDate.EditValue = dRepaymentsToDate;
            teInterestPaidToDate.EditValue = dInterestToDate;
        }



        private void radRepayment_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvRepaymentType.RowCount > 0 && radRepayment.ContainsFocus)
            {
                if (Popup.ShowPopup("Switching the repayment type will zero out all data in the repayment table, Are you sure you want to continue?",WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                {

                    string sql = "Update LD_Repayment set Amount = 0,Percentage = 0, use_amount = '" + (e.NewValue.ToString() == "P" ? "F" : "T") + "' where Financing_ID = " + da_Repayment.SelectCommand.Parameters["@Financing_ID"].Value;
                    Connection.SQLExecutor.ExecuteNonQuery(sql, Connection.TRConnection);
                    if (Connection.SQLExecutor.Exception != null)
                        Popup.ShowPopup("Error updating LD_Repayment:" + Connection.SQLExecutor.Exception.Message);
                    else
                    {
                        ds_Repayment1.Clear();
                        da_Repayment.Fill(ds_Repayment1);
                    }
                }
                else
                    e.Cancel = true;

            }
        }

        #region Grids validation

        private void AllGrids_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
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
  

        private void gvFinancing_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
            if( (ErrorMessage = ValidateColumnsRequired( (DataRowView)e.Row,new DevExpress.XtraGrid.Columns.GridColumn[]{
               colFINANCING_TYPE_ID },false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (rv[colDRAW_DATE.FieldName] != DBNull.Value && rv[colEXPIRY_DATE.FieldName] != DBNull.Value)
            {
                if (Convert.ToDateTime(rv[colDRAW_DATE.FieldName]).CompareTo(Convert.ToDateTime(rv[colEXPIRY_DATE.FieldName])) > 0)
                {
                    Popup.ShowPopup(colDRAW_DATE.Caption+" must be less then or equal to "+colEXPIRY_DATE.Caption);
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
            if (rv["Financed_By"].ToString() == "Lender" && (rv["Lenders_ID"] == DBNull.Value || rv["Lenders_ID"].ToString() == ""))
            {
                Popup.ShowPopup("Please select a lender.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (rv["Financed_By"].ToString() == "Share Owner" && (rv["ShareOwners_ID"] == DBNull.Value || rv["ShareOwners_ID"].ToString() == ""))
            {
                Popup.ShowPopup("Please select a share owner.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!IsPrecedenceUnique((DataRowView)e.Row))
            {
                Popup.ShowPopup("Precedence is already used.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (rv[colDESCRIPTION.FieldName] == DBNull.Value || rv[colDESCRIPTION.FieldName].ToString() == "")
            {
                Popup.ShowPopup("Description is required.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            

            
        }


 
        private void gvRepaymentType_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRow row = gvRepaymentType.GetDataRow(e.RowHandle);
            if (row != null)
            {
                DevExpress.XtraGrid.Columns.GridColumn usedColumn;
                if (row[colUSE_AMOUNT.FieldName].ToString() == "T")
                    usedColumn = colAMOUNT;
                else
                    usedColumn = colPERCENTAGE;

                if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[]{
                colLOT_CLASS_ID,colLOT_SUB_CLASS_ID,usedColumn}, false)) != "")
                {
                    Popup.ShowPopup(ErrorMessage);
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
                else if (!isGreaterThenZero(row[usedColumn.FieldName],true))
                {
                    Popup.ShowPopup(usedColumn.Caption+" can not be negative.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
        }
 
        private void gvMinRepaySch_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
            DateTime FirstAvalDate = DateTime.MaxValue;
            try
            {
                FirstAvalDate = (DateTime)gvFinancing.GetFocusedDataRow()[colDRAW_DATE.FieldName];
            }
            catch { }

            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[]{
                colREPAY_DATE,colAMOUNT1}, false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (gvMinRepaySch.GetDataRow(e.RowHandle) != null && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                if (!isGreaterThenZero(gvMinRepaySch.GetDataRow(e.RowHandle)[colAMOUNT1.FieldName], true))
                {
                    Popup.ShowPopup("Repayment amount must be greater than 0.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
            if (e.Valid)
            {
                if (Convert.ToDateTime(rv[colREPAY_DATE.FieldName]).CompareTo(FirstAvalDate) < 0)
                {
                    Popup.ShowPopup("Repayment date must occur after the first draw date.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
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

        #endregion Grids validation

        private void ri_lueLotSubClass_Enter(object sender, EventArgs e)
        {
            DataRow row = gvRepaymentType.GetDataRow(gvRepaymentType.FocusedRowHandle);
            if (row != null)
            {
                string classID = "-99";
                if(row[colLOT_CLASS_ID.FieldName] != DBNull.Value && row[colLOT_CLASS_ID.FieldName] != null)
                    classID = row[colLOT_CLASS_ID.FieldName].ToString();
                bs_lueLotSubClass_Restricted.Filter = "LD_Lot_Class_ID =" + classID;
                ((LookUpEdit)sender).Properties.DataSource = bs_lueLotSubClass_Restricted;
            }
        }

        private void gvRepaymentType_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvRepaymentType.GetDataRow(gvRepaymentType.FocusedRowHandle);
            if (row != null)
            {
                row[colPRI_ID1.FieldName] = _PRI_ID;
                row[colFINANCING_ID1.FieldName] = da_Repayment.SelectCommand.Parameters["@Financing_ID"].Value;
                row[colUSE_AMOUNT.FieldName] = (radRepayment.EditValue.ToString() == "P"?"F":"T" );

            }
        }

        private void gvMinRepaySch_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvMinRepaySch.GetDataRow(gvMinRepaySch.FocusedRowHandle);
            if (row != null)
            {
                row[colPRI_ID2.FieldName] = _PRI_ID;
                row[colFINANCING_ID2.FieldName] = da_MinRepaySched.SelectCommand.Parameters["@Financing_ID"].Value;
               
            }
        }

        private void gvRepaymentType_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow row = gvRepaymentType.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if(row[colUSE_AMOUNT.FieldName] != null && row[colUSE_AMOUNT.FieldName] != DBNull.Value)
                {
                    if (row[colUSE_AMOUNT.FieldName].ToString() == "T")
                    {
                        if (e.Column == colPERCENTAGE)
                        {
                            e.RepositoryItem = ri_teReadOnly;
                        }
                    }
                    else
                    {
                        if (e.Column == colAMOUNT)
                        {
                            e.RepositoryItem = ri_teReadOnly;
                        }
                    }

                }
            }


            
           
        }

        private void ri_lueLotClass_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = gvRepaymentType.GetDataRow(gvRepaymentType.FocusedRowHandle);
            if (row != null)
            {
                row[colLOT_SUB_CLASS_ID.FieldName] = DBNull.Value;
            }
        }

        private void ucFinancingDetail_Leave(object sender, EventArgs e)
        {
            if( gvFinancing.FocusedRowHandle >= 0 )
                gGridFinancing.SaveRecord(gvFinancing.FocusedRowHandle);
        }

        
        private string ValidatePercentage(object percent)
        {
            double value = 0;
            try
            {
                value = Convert.ToDouble(percent);
            }
            catch { }

            if (value > 100 || value < 0)
                return "Value must be between 0 and 100.";
            else
                return "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDetailsValid())
            {
                BindingContext[ds_Financing1, ds_Financing1.LD_Financing.TableName].EndCurrentEdit();
                //tell grid g to not ignore columns when save button is clicked.
                gGridFinancing.IgnoreFieldList = null;
                gGridFinancing.SaveRecord(gvFinancing.FocusedRowHandle);
                string[] columns = new string[] { colLOAN_TYPE_ID.FieldName, colMAX_LOAN_AMT.FieldName, colINTEREST_RATE.FieldName, colLOAN_BALANCE.FieldName, colDRAWS_TODATE.FieldName, colREPAY_DATE.FieldName, colINTEREST_PAID_TODATE.FieldName, colFINANCEABLE_PORTION.FieldName, colEQUITY_REQUIRED.FieldName, colALLOWABLE_DRAWS.FieldName, colREPAY_TYPE.FieldName, colREPAY_PCT_RECEIPTS.FieldName, colLOAN_CLOSED.FieldName, colDOWN_PAY_INC.FieldName, colRenewal_Pct.FieldName, colStandByCharge_Pct.FieldName };
                gGridFinancing.IgnoreFieldList = columns;
            }


        }

        private bool IsDetailsValid()
        {
            bool returnValue = true;
            if (ValidatePercentage(teInterestRate.EditValue) != "")
            {
                Popup.ShowPopup("Interest Rate must be between 0 and 100");
                returnValue = false;
            }
            else if (ValidatePercentage(teAllowableDraws.EditValue) != "")
            {
                Popup.ShowPopup("Allowable Draws must be between 0 and 100");
                returnValue = false;
            }
            else if (ValidatePercentage(txtRepayPct.EditValue) != "")
            {
                Popup.ShowPopup("% Of Receipts must be between 0 and 100");
                returnValue = false;
            }
            else if (ValidatePercentage(teRenewalPct.EditValue) != "")
            {
                Popup.ShowPopup("Renewal % must be between 0 and 100");
                returnValue = false;
            }
            else if (ValidatePercentage(teStandByChargePct.EditValue) != "")
            {
                Popup.ShowPopup("Stand By Charge % must be between 0 and 100");
                returnValue = false;
            }
            





            return returnValue; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BindingContext[ds_Financing1, ds_Financing1.LD_Financing.TableName].CancelCurrentEdit();
        }

        private void MoneyField_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit te = sender as TextEdit;
            if (te != null)
            {
                double dNewValue = 0;
                object oNewValue = e.NewValue;
                if( oNewValue != null && oNewValue != DBNull.Value )
                    dNewValue = Convert.ToDouble(oNewValue );

                if (dNewValue < -900000000000000 || dNewValue > 900000000000000)
                    e.Cancel = true;
            }
        }

       

        private void gvFinancing_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow row = gvFinancing.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (row[colFinanced_By.FieldName] != null)
                {
                    if(e.Column == colLenders_ID || e.Column == colShareOwners_ID)
                    {
                        if (row[colFinanced_By.FieldName].ToString() == "Lender" && e.Column == colShareOwners_ID)
                            e.RepositoryItem = ri_teReadOnly;
                        else if (row[colFinanced_By.FieldName].ToString() != "Lender" && e.Column == colLenders_ID)
                            e.RepositoryItem = ri_teReadOnly;
                    }

                }

            }
        }

        private void ri_cboFinanceBy_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = gvFinancing.GetDataRow(gvFinancing.FocusedRowHandle);
            if (row != null)
            {
                row[colLenders_ID.FieldName] = DBNull.Value;
                row[colShareOwners_ID.FieldName] = DBNull.Value;
            }
        }
        

 
           
       
        private bool IsPrecedenceUnique(DataRowView row)
        {

            bool isUnique = true;

            if (row != null)
            {   
                string sql = "select COUNT(*) from LD_Financing where PRI_ID = "+_PRI_ID+" and FINANCING_ID <> "+row[colFINANCING_ID.FieldName].ToString()+" and Precedence = "+ row[colPrecedence.FieldName].ToString();
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                {
                    Popup.ShowPopup("Error validating precedence to be unique :" + Connection.SQLExecutor.Exception.Message + "\r\n\r\n" + Connection.SQLExecutor.Exception.StackTrace);

                }
                int count = -1;
                try { count = Convert.ToInt32(result); }
                catch { }

                if (count != 0)
                {
                    isUnique = false;

                }
                
            }
            return isUnique;
        }

        
    }
}
