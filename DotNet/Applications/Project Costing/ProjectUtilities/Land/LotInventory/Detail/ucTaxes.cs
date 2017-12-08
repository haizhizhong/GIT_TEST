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
using System.Data.SqlClient;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucTaxes : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private int _LotID = -1;
        private int _PriID = -1;
        private TUC_GridG.GridG gGrid;

        public ucTaxes(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            RunSetups();

            gcTaxDet.ForceInitialize();
            gvTaxDet.FocusedColumn = null;
            gcHist.ForceInitialize();
            gvHist.FocusedColumn = null;
        }

        #region Setups

        private void RunSetups()
        {
            dsTaxDet.PROJ_LOT_TAX_DET.idColumn.ReadOnly = false;

            daAssessment.Fill(dsAssessment);
            daARYear.Fill(dsARYear);

            gGrid = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvTaxRolls, daTaxRolls, dsTaxRolls1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (Popup.ShowPopup("All detail and history will be deleted as well, are you sure you want to delete this record?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
            {
                DataRow dr = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
                if (dr != null)
                {
                    string sDelete = @"delete from proj_lot_tax_history where tax_roll_id=" + dr["id"] + @"
                            delete from proj_lot_tax_det where tax_roll_id=" + dr["id"];
                    Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);
                }
                return true;
            }
            else
                return false;            
        }

        private void LoadLotInfo()
        {
            txtLot.Text = "";
            txtBlock.Text = "";
            txtPlan.Text = "";

            string sSelect = "select lot_num, block_num, plan_num from proj_lot where proj_lot_id=" + _LotID;
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
                    }
                }
            }
        }

        #endregion

        public void SetReadOnly(bool ReadOnly)
        {
            gvTaxRolls.OptionsBehavior.Editable = !ReadOnly;
            gvTaxDet.OptionsBehavior.Editable = !ReadOnly;
        }

        public void LoadLot(int LotID, int PriID)
        {
            _LotID = LotID;
            _PriID = PriID;
            daTaxRolls.SelectCommand.Parameters["@PROJ_LOT_ID"].Value = _LotID;

            dsTaxRolls1.Clear();
            daTaxRolls.Fill(dsTaxRolls1);
            gvTaxRolls_FocusedRowChanged(null, null);

            LoadLotInfo();
        }

        private void ucTaxes_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void gvTaxRolls_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvTaxRolls.GetDataRow(e.RowHandle);
            if (row != null)
            {
                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter("select lot_range,lot_section, meridian,lot_township from proj_lot where proj_lot_id = "+_LotID, Connection.TRConnection);
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        row[colRange.FieldName] = dt.Rows[0]["lot_range"];
                        row[colSection.FieldName] = dt.Rows[0]["lot_section"];
                        row[colMeridian.FieldName] = dt.Rows[0]["meridian"];
                        row[colTownship.FieldName] = dt.Rows[0]["lot_township"];
                    }
                }
                row[colpri_id.FieldName] = _PriID;
                row[colproj_lot_id.FieldName] = _LotID;
                row[colassessment.FieldName] = 0;
                row[coltaxes.FieldName] = 0;
                row[colInstallment1.FieldName] = 0;
                row[colInstallment2.FieldName] = 0;
                row[colInstallment3.FieldName] = 0;
            }
        }

        private void gvTaxRolls_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvTaxRolls_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            

            object oID;
            string ErrorMessage, sSelect;
            DataRowView vRow = (DataRowView)e.Row;
            if( (ErrorMessage = ValidateColumnsRequired( (DataRowView)e.Row,new DevExpress.XtraGrid.Columns.GridColumn[]{
                coltax_roll_num},false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            try
            {
                object oOrig = vRow.Row["tax_roll_num", DataRowVersion.Original];
                object oNew = vRow.Row["tax_roll_num", DataRowVersion.Proposed];
                oID = vRow.Row["id"];
                if (!oOrig.Equals(oNew))
                {
                    sSelect = "select count(*) from PROJ_LOT_TAX_HISTORY where proj_lot_id=" + _LotID + " and tax_roll_id=" + oID;
                    if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
                    {
                        Popup.ShowPopup("The tax roll number cannot be changed as history already exists for it.");
                        e.ErrorText = "DeveloperThrownError";
                        e.Valid = false;
                        return;
                    }
                }
            }catch{}

            sSelect = "select count(*) from PROJ_LOT_TAX_ROLL where id <> " + vRow["id"] + " and proj_lot_id=" + _LotID + " and tax_roll_num='" + vRow["tax_roll_num"] + "'";
            if(Convert.ToInt32( Connection.SQLExecutor.ExecuteScalar( sSelect, Connection.TRConnection ) ) > 0)
            {
                Popup.ShowPopup("The tax roll number already exists for this lot and must be unique.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if(!isGreaterThenZero( vRow[colassessment.FieldName],true))
            {
                Popup.ShowPopup(GetColumnsCaption(colassessment)+ " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (!isGreaterThenZero(vRow[coltaxes.FieldName], true))
            {
                Popup.ShowPopup(GetColumnsCaption(coltaxes) + " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            if (!isGreaterThenZero(vRow[colSection.FieldName], true) && vRow[colSection.FieldName] != DBNull.Value)
            {
                Popup.ShowPopup(GetColumnsCaption(colSection) + " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            if (vRow[colSection.FieldName] != DBNull.Value && Convert.ToDecimal(vRow[colSection.FieldName]) > 922337203685477)
            {
                Popup.ShowPopup("Section is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            if (!isGreaterThenZero(vRow[colInstallment1.FieldName], true))
            {
                Popup.ShowPopup(GetColumnsCaption(colInstallment1) + " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            if (!isGreaterThenZero(vRow[colInstallment2.FieldName], true))
            {
                Popup.ShowPopup(GetColumnsCaption(colInstallment2) + " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            if (!isGreaterThenZero(vRow[colInstallment3.FieldName], true))
            {
                Popup.ShowPopup(GetColumnsCaption(colInstallment3) + " must be greater then or equal to 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (IsNumberToLarge(vRow[colInstallment1.FieldName]))
            {
                Popup.ShowPopup("1st Installment is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (IsNumberToLarge(vRow[colInstallment2.FieldName]))
            {
                Popup.ShowPopup("2nd Installment is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (IsNumberToLarge(vRow[colInstallment3.FieldName]))
            {
                Popup.ShowPopup("3rd Installment is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }


            if (vRow[colAcres.FieldName] != DBNull.Value)
            {
                object result = Connection.SQLExecutor.ExecuteScalar("select isnull(area_acres,0) from PROJ_LOT where proj_lot_id ="+_LotID,Connection.TRConnection);
                double lot_acres = 0;
                double tax_acres = 0;
                try
                {
                    tax_acres = Convert.ToDouble(vRow[colAcres.FieldName]);
                    lot_acres = Convert.ToDouble(result);
                }
                catch { }
                if (!isGreaterThenZero(vRow[colAcres.FieldName], true))
                {
                    Popup.ShowPopup(GetColumnsCaption(colAcres) + " must be greater then or equal to 0.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }
                else if (lot_acres < tax_acres)
                {
                    Popup.ShowPopup("Acres must be less then or equal to acres on the lot ( "+lot_acres.ToString()+" ).");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }
               


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

        private void gvTaxRolls_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsTaxDet.Clear();
            DataRow dr = gvTaxRolls.GetDataRow( gvTaxRolls.FocusedRowHandle );
            if (dr != null)
            {
                object oID = dr["id"];
                if (oID != null && oID != DBNull.Value)
                {
                    if (daTaxDet.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daTaxDet.SelectCommand.Parameters["@tax_roll_id"].Value = oID;
                        daTaxDet.Fill(dsTaxDet);
                        gvTaxDet_FocusedRowChanged(null, null);
                    }
                }
            }
        }

        private void gvTaxDet_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvTaxDet.GetDataRow(gvTaxDet.FocusedRowHandle);
            if (dr != null)
            {
                object oYear = dr["year"];
                if (oYear == null || oYear == DBNull.Value)
                {
                    e.ErrorText = "Tax year is required.";
                    gvTaxDet.FocusedColumn = colYear;
                    e.Valid = false;
                    return;
                }

                object oDate = dr["tax_adj_date"];
                if (oDate == null || oDate == DBNull.Value)
                {
                    e.ErrorText = "Tax adjustment date is required.";
                    gvTaxDet.FocusedColumn = colDate;
                    e.Valid = false;
                    return;
                }
                else
                {
                    DateTime dtAdjDate = DateTime.MinValue;
                    int iYear = 1900;

                    try { dtAdjDate = Convert.ToDateTime(oDate); }
                    catch { }
                    try { iYear = Convert.ToInt32(oYear); }
                    catch { }

                    if (dtAdjDate != DateTime.MinValue)
                    {
                        if (iYear != dtAdjDate.Year)
                        {
                            e.ErrorText = "Tax adjustment date year must match the year.";
                            gvTaxDet.FocusedColumn = colDate;
                            e.Valid = false;
                            return;
                        }
                    }
                    else
                    {
                        e.ErrorText = "Tax adjustment date is required.";
                        gvTaxDet.FocusedColumn = colDate;
                        e.Valid = false;
                        return;
                    }
                }

                object oCode = dr["assessment_id"];
                if (oCode == null || oCode == DBNull.Value)
                {
                    e.ErrorText = "Tax assessment code is required.";
                    gvTaxDet.FocusedColumn = colCode;
                    e.Valid = false;
                    return;
                }

                object oValue = dr["assessment"];
                if (oValue == null || oValue == DBNull.Value)
                {
                    e.ErrorText = "Tax assessment amount is required.";
                    gvTaxDet.FocusedColumn = colValue;
                    e.Valid = false;
                    return;
                }
                else
                {
                    if (Convert.ToDouble(oValue) <= 0)
                    {
                        e.ErrorText = "Tax assessment amount must be greater than zero.";
                        gvTaxDet.FocusedColumn = colValue;
                        e.Valid = false;
                        return;
                    }
                    else if (IsNumberToLarge(oValue))
                    {
                        e.ErrorText = "Taxes assessment is too large.";
                        gvTaxDet.FocusedColumn = colValue;
                        e.Valid = false;
                        return;
                    }
                }

                object oTaxes = dr["taxes"];
                if (oTaxes == null || oTaxes == DBNull.Value)
                {
                    e.ErrorText = "Taxes amount is required.";
                    gvTaxDet.FocusedColumn = colTaxesAmt;
                    e.Valid = false;
                    return;
                }
                else
                {
                    if (Convert.ToDouble(oTaxes) <= 0)
                    {
                        e.ErrorText = "Taxes amount must be greater than zero.";
                        gvTaxDet.FocusedColumn = colTaxesAmt;
                        e.Valid = false;
                        return;
                    }
                    else if(IsNumberToLarge(oTaxes))
                    {
                        e.ErrorText = "Taxes amount is too large.";
                        gvTaxDet.FocusedColumn = colTaxesAmt;
                        e.Valid = false;
                        return;
                    }
                }

                if (!isYearAndCodeUnique(dr["ID"].ToString(),dr["year"].ToString(), dr["assessment_id"].ToString(), daTaxDet.SelectCommand.Parameters["@tax_roll_id"].Value.ToString()))
                {
                    e.ErrorText = "Year and Assesment Code combination is already in use.";
                    e.Valid = false;
                    return;
                }

            }            
       }


        private bool isYearAndCodeUnique(string ID ,string year,string assessmentID,string TaxRollID)
        {
            bool returnValue = true;
            string sql = "SELECT count(*) FROM PROJ_LOT_TAX_DET "+
                "WHERE        (tax_roll_id = "+TaxRollID+") and ID <> "+ID+" and year = "+year+" and assessment_id = "+assessmentID;
            object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
            {
                Popup.ShowPopup("Error checking for duplicate year/assessment code combinations:" + Connection.SQLExecutor.Exception.Message);
                returnValue = false;
            }
            else if (result != DBNull.Value && result != null)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    returnValue = false;
                }
            }
            else
            {
                Popup.ShowPopup("Error in return value checking for duplicate year/assessment code:" + Connection.SQLExecutor.Exception.Message);
                returnValue = false;
            }



            return returnValue;
        }



        private void riAssCode_EditValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                LookUpEdit lue = sender as LookUpEdit;
                if (lue != null)
                {
                    DataRow dr = gvTaxDet.GetDataRow(gvTaxDet.FocusedRowHandle);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        dr["assessment_desc"] = lue.GetColumnValue("Description");
                    }
                }
            }
        }

        private void gcTaxDet_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (gvTaxRolls.RowCount == 0)
                {
                    Popup.ShowPopup("You must create a header record first.");
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("All history will be deleted, are you sure you want to delete this record?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvTaxDet.GetDataRow(gvTaxDet.FocusedRowHandle);
                    if (dr != null)
                    {
                        string sDelete = @"delete from proj_lot_tax_history where tax_roll_det_id=" + dr["id"] + @"
                            delete from proj_lot_tax_det where id=" + dr["id"];
                        Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);


                        SqlCommand cmd = new SqlCommand("LD_TaxRollInsertUpdate @id, @tax_roll_id, @year, @assessment, @taxes, @tax_adj_date, @assessment_id, @assessment_desc, @comment, @Paid",
                            new SqlConnection(Connection.TRConnection));

                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = dr["id"];
                        cmd.Parameters.Add("@tax_roll_id", SqlDbType.Int);
                        cmd.Parameters["@tax_roll_id"].Value = dr["tax_roll_id"];
                        cmd.Parameters.Add("@year", SqlDbType.Int);
                        cmd.Parameters["@year"].Value = dr["year"];
                        cmd.Parameters.Add("@assessment", SqlDbType.Money);
                        cmd.Parameters["@assessment"].Value = dr["assessment"];
                        cmd.Parameters.Add("@taxes", SqlDbType.Money);
                        cmd.Parameters["@taxes"].Value = dr["taxes"];
                        cmd.Parameters.Add("@tax_adj_date", SqlDbType.DateTime);
                        cmd.Parameters["@tax_adj_date"].Value = dr["tax_adj_date"];
                        cmd.Parameters.Add("@assessment_id", SqlDbType.Int);
                        cmd.Parameters["@assessment_id"].Value = dr["assessment_id"];
                        cmd.Parameters.Add("@assessment_desc", SqlDbType.VarChar);
                        cmd.Parameters["@assessment_desc"].Value = dr["assessment_desc"];
                        cmd.Parameters.Add("@comment", SqlDbType.VarChar);
                        cmd.Parameters["@comment"].Value = dr["comment"];
                        cmd.Parameters.Add("@Paid", SqlDbType.Bit);
                        cmd.Parameters["@Paid"].Value = dr["Paid"];

                        try
                        {
                            cmd.Connection.Open();

                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            if (dt != null)
                            {
                                if (dt.Rows.Count > 0)
                                {
                                    DataRow exdr = dt.Rows[0];
                                    if (exdr != null)
                                    {
                                        object oID = exdr["id"];
                                        if (oID != null && oID != DBNull.Value)
                                        {
                                            dr.BeginEdit();
                                            dr["id"] = Convert.ToInt32(oID);
                                            dr.EndEdit();
                                            dr.AcceptChanges();

                                            DataRow drH = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
                                            if (drH != null)
                                            {
                                                drH.BeginEdit();
                                                drH["assessment"] = exdr["total_assessment"];
                                                drH["taxes"] = exdr["total_taxes"];
                                                drH["tax_adj_date"] = exdr["max_date"];
                                                drH.EndEdit();
                                                drH.AcceptChanges();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Popup.ShowPopup(ex.Message);
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }

                        dsHist.Clear();
                        daHist.Fill(dsHist);

                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

            if(!e.Handled)
                colYear.OptionsColumn.AllowEdit = false;
        }

        private void gvTaxDet_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRow dr = gvTaxDet.GetDataRow(gvTaxDet.FocusedRowHandle);
            DataRow drHDR = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
            if (dr != null)
            {
                SqlCommand cmd = new SqlCommand("LD_TaxRollInsertUpdate @id, @tax_roll_id, @year, @assessment, @taxes, @tax_adj_date, @assessment_id, @assessment_desc, @comment,@Paid,@Install1 ,@Install2 ,@Install3 ", 
                    new SqlConnection(Connection.TRConnection));

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = dr["id"];
                cmd.Parameters.Add("@tax_roll_id", SqlDbType.Int);
                cmd.Parameters["@tax_roll_id"].Value = dr["tax_roll_id"]; 
                cmd.Parameters.Add("@year", SqlDbType.Int);
                cmd.Parameters["@year"].Value = dr["year"];
                cmd.Parameters.Add("@assessment", SqlDbType.Money);
                cmd.Parameters["@assessment"].Value = dr["assessment"];
                cmd.Parameters.Add("@taxes", SqlDbType.Money);
                cmd.Parameters["@taxes"].Value = dr["taxes"];
                cmd.Parameters.Add("@tax_adj_date", SqlDbType.DateTime);
                cmd.Parameters["@tax_adj_date"].Value = dr["tax_adj_date"];
                cmd.Parameters.Add("@assessment_id", SqlDbType.Int);
                cmd.Parameters["@assessment_id"].Value = dr["assessment_id"];
                cmd.Parameters.Add("@assessment_desc", SqlDbType.VarChar);
                cmd.Parameters["@assessment_desc"].Value = dr["assessment_desc"];
                cmd.Parameters.Add("@comment", SqlDbType.VarChar);
                cmd.Parameters["@comment"].Value = dr["comment"];
                cmd.Parameters.Add("@Paid", SqlDbType.Bit);
                cmd.Parameters["@Paid"].Value = dr["Paid"];
                cmd.Parameters.Add("@Install1", SqlDbType.Money);
                cmd.Parameters["@Install1"].Value = drHDR["Installment1"];
                cmd.Parameters.Add("@Install2", SqlDbType.Money);
                cmd.Parameters["@Install2"].Value = drHDR["Installment2"];
                cmd.Parameters.Add("@Install3", SqlDbType.Money);
                cmd.Parameters["@Install3"].Value = drHDR["Installment3"];



                try
                {
                    cmd.Connection.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            DataRow exdr = dt.Rows[0];
                            if (exdr != null)
                            {
                                object oID = exdr["id"];
                                if (oID != null && oID != DBNull.Value)
                                {
                                    dr.BeginEdit();
                                    dr["id"] = Convert.ToInt32(oID);
                                    dr.EndEdit();
                                    dr.AcceptChanges();

                                    DataRow drH = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
                                    if (drH != null)
                                    {
                                        drH.BeginEdit();
                                        drH["assessment"] = exdr["total_assessment"];
                                        drH["taxes"] = exdr["total_taxes"];
                                        drH["tax_adj_date"] = exdr["max_date"];
                                        drH.EndEdit();
                                        drH.AcceptChanges();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Popup.ShowPopup(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }

                dsHist.Clear();
                daHist.Fill(dsHist);
            }

            colYear.OptionsColumn.AllowEdit = false;
        }

        private void gvTaxDet_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvTaxDet.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                DataRow drH = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
                if (dr != null)
                {
                    dr.BeginEdit();
                    dr["id"] = -1;
                    dr["assessment"] = 0.0;
                    dr["taxes"] = 0.0;
                    dr["tax_roll_id"] = drH["id"];
                }
            }
            colYear.OptionsColumn.AllowEdit = true;
        }

        private void gvTaxDet_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvTaxDet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsHist.Clear();
            DataRow dr = gvTaxDet.GetDataRow(gvTaxDet.FocusedRowHandle);
            if (dr != null)
            {
                object oID = dr["id"];
                if (oID != null && oID != DBNull.Value)
                {
                    if (daHist.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daHist.SelectCommand.Parameters["@id"].Value = oID;
                        daHist.Fill(dsHist);
                    }
                }
            }
        }

        private void ricbeYears_Enter(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.ComboBoxEdit)
            {
                DevExpress.XtraEditors.ComboBoxEdit cbo = (DevExpress.XtraEditors.ComboBoxEdit)sender;
                cbo.Properties.Items.Clear();

                System.Collections.ArrayList alYears = new System.Collections.ArrayList();
                using (SqlConnection sqlCon = new SqlConnection(Connection.TRConnection))
                {
                    SqlCommand sqlCmd = new SqlCommand("Select distinct year From PROJ_LOT_TAX_DET Where IsNull([year],-1) <> -1", sqlCon);
                    sqlCon.Open();
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
                        if(dr.HasRows)
                            while (dr.Read())
                            {
                                if(dr["year"] != null && dr["year"] != DBNull.Value)
                                    alYears.Add((object)dr["year"].ToString());
                            }
                    }

                    sqlCon.Close();
                }

                cbo.Properties.Items.AddRange(alYears.ToArray());
            }
        }

        private void ri_seNumaric0_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                ((SpinEdit)sender).EditValue = DBNull.Value;
            }
        }

        private void gvTaxRolls_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (e.ErrorText == "Value was either too large or too small for an Int32.")
            {
                e.ErrorText = "Value is too large.";
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            }
        }

        private void ri_seNumaric0_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            double value = 0;
            try
            {
                value = Convert.ToDouble(e.NewValue);
            }
            catch { }
            if (value > 214783647)
            {
                Popup.ShowPopup("The Value of "+value+" is too large.");
                e.Cancel = true;
            }

        }

        
			
    }
}
