using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.Letter_Of_Credit
{
    public partial class ucLetterOfCredit : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        TUC_GridG.GridG gGrid;
        private int iPri_ID = -1;
        private ucLogging logging;
        
        public ucLetterOfCredit(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);

            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvLetterOfCredit, da_letterOfCredit, dsLetterOfCredit1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGrid.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGrid_AfterUpdate);
            logging = new ucLogging(hmCon, tuc);
            logging.Dock = DockStyle.Fill;
            logging.Parent = this.dpNotes;
        }

        void gGrid_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
           
            RefreshLogging();
           
        }

        public void SetReadOnly(bool readOnly)
        {
            gvLetterOfCredit.OptionsBehavior.Editable = !readOnly;
            meNotes.Enabled = !readOnly;
        }

        public void RefreshMe(int pri_id)
        {
            iPri_ID = pri_id;
            da_letterOfCredit.SelectCommand.Parameters["@pri_id"].Value = pri_id;
            try
            {
                dsLender1.Clear();
                daLender.Fill(dsLender1);
                dsBeneficiary1.Clear();
                daBeneficiary.Fill(dsBeneficiary1);
                dsLetterOfCredit1.Clear();
                da_letterOfCredit.Fill(dsLetterOfCredit1);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading letter of credit."+ex.Message);
            }
            gvLetterOfCredit_RowCountChanged(null, null);
        }

        
        bool gGrid_AllowDelete(object sender, DataRow row)
        {

            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                int LetterOfCredit_ID = Convert.ToInt32(row["LetterOfCredit_ID"]);
                string sqlStr = " delete LD_PROJ_LetterOfCredit_Logging where  LetterOfCredit_ID=  " + LetterOfCredit_ID.ToString() ;
                hmCon.SQLExecutor.ExecuteNonQuery(sqlStr, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                {
                    popup.ShowPopup("Exception found in Deleting Logging:" + hmCon.SQLExecutor.Exception.Message.ToString());
                    return false;
                }
                else
                    return true;
            }
            else
                return false;

        }

        private void gvLetterOfCredit_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
            else if (e.ErrorText == "LogError")
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
            }
        }

        private void gvLetterOfCredit_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           
             string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
                        
            if( (ErrorMessage = ValidateColumnsRequired( (DataRowView)e.Row,new DevExpress.XtraGrid.Columns.GridColumn[]{
                colReferenceNum,colLOC_Type,colLOC_Description,colLender_ID,colStartDate,colAmount},false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if ( (ErrorMessage = IsColumnUnique((DataRowView)e.Row,colReferenceNum ,colLetterOfCredit_ID )) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(rv[colAmount.FieldName], true))
            {
                popup.ShowPopup("Amount can not be less than zero.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (CompareDates(rv[colStartDate.FieldName], rv[colExpiryDate.FieldName], 0) > 0)
            {
                popup.ShowPopup("Start Date must be less than or equal to Expiry Date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (CompareDates(rv[colStartDate.FieldName], rv[colEstimatedReleaseDate.FieldName], 0) > 0)
            {
                popup.ShowPopup("Start Date must be less than or equal to Estimated Release Date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (CompareDates(rv[colStartDate.FieldName], rv[colActualReleaseDate.FieldName], 0) > 0)
            {
                popup.ShowPopup("Start Date must be less than or equal to Actual Release Date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
           
            else if (CompareDates(rv[colExpiryDate.FieldName], rv[colEstimatedReleaseDate.FieldName], 0) > 0)
            {
                popup.ShowPopup("Expiry Date must be less than or equal to Estimated Release Date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (CompareDates(rv[colExpiryDate.FieldName], rv[colActualReleaseDate.FieldName], 0) > 0)
            {
                popup.ShowPopup("Expiry Date must be less than or equal to Actual Release Date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            if (e.Valid)
            {
                if (PopLogging())
                {
                    _requireLog = false;
                    popup.ShowPopup("Notes are required in order to save changes to this line.");
                    e.ErrorText = "LogError";
                    e.Valid = false;
                }
            }

        }

        private int CompareDates(object start, object end, int nullValueResult)
        {
            int returnValue = nullValueResult;
            try
            {
                returnValue = Convert.ToDateTime(start).CompareTo(Convert.ToDateTime(end));
            }
            catch
            { }

            return returnValue;
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



        private void gvLetterOfCredit_RowCountChanged(object sender, EventArgs e)
        {
            meNotes.Enabled = (gvLetterOfCredit.RowCount != 0);
        }

        private void meNotes_Leave(object sender, EventArgs e)
        {
            if (!gvLetterOfCredit.OptionsBehavior.Editable) return;
            try
            {
                bs_letterOfCredit.EndEdit();
                daLender.Update(dsLender1);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error saving notes" + ex.Message);
            }
        }

        private void gvLetterOfCredit_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvLetterOfCredit.GetDataRow(e.RowHandle)["pri_id"] = iPri_ID;
        }

        private void ucLetterOfCredit_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        private void gvLetterOfCredit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshLogging();
        }

        bool _requireLog = false;
        string _notes = "";
        private bool PopLogging()
        {
            bool result = false;
            if (_requireLog)
            {
                result = true;
                //popup to allow them to enter the note
                frmNotes frm = new frmNotes();
                //frm.richEditControl1.SpellChecker = richEditControl1.SpellChecker;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.richEditControl1.Text != "")
                    {
                        _notes = frm.richEditControl1.Text;

                        SetMemoTable();
                        _requireLog = false;
                        result = false;
                    }
                }
            }
            return result;
        }

        private void gvLetterOfCredit_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
            if (e.Column.FieldName == "LOC_Type" || e.Column.FieldName == "StartDate" || e.Column.FieldName == "Amount"
                || e.Column.FieldName == "ExpiryDate" || e.Column.FieldName == "EstimatedReleaseDate" || e.Column.FieldName == "ActualReleaseDate")
            {
                _requireLog = true;
            }
            
        }

        private void SetMemoTable()
        {
            string sqlStr = @" 
declare  @Note varchar(max)
select @Note = '" + _notes.Replace("'", "''") + @"'
if exists (select * from LD_PROJ_LetterOfCredit_Notes )
    update LD_PROJ_LetterOfCredit_Notes set Note = @Note
else
    insert LD_PROJ_LetterOfCredit_Notes (note)
    select @note ";
            hmCon.SQLExecutor.ExecuteNonQuery(sqlStr, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                popup.ShowPopup("error found in Set MemoTable: " + hmCon.SQLExecutor.Exception.Message.ToString());
            }
            _notes = "";
        }
              
        private void RefreshLogging()
        {
            int LetterOfCredit_ID = 0;
            DataRow dr = gvLetterOfCredit.GetDataRow(gvLetterOfCredit.FocusedRowHandle);
            if (dr != null)
            {
                object obj = dr["LetterOfCredit_ID"];
                if (obj != null && obj != DBNull.Value)
                {
                    LetterOfCredit_ID = Convert.ToInt32(obj);
                }
            }
            logging.LoadLogging(LetterOfCredit_ID);
        }
    }
}
