using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;
using HM_Report_Printer;

namespace LD_DateManagement
{
    public partial class ucDateUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables declared here

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private WS_Popups.frmPopup Popups;
        private TUC_GridG.GridG GGDateHdr;
        public ucDateManagement dateManagement_Main;
        
        #endregion

        public ucDateUpdate(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            sqlConnTR.ConnectionString = hmConn.TRConnection;
            sqlConnTR2.ConnectionString = hmConn.TRConnection;
            Popups = new WS_Popups.frmPopup(hmDevMgr);
            SetupGridG();
            ActivateLookup();
        }

        private void SetupGridG()
        {
            GGDateHdr = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvDateHdr, daDateHdr, dsDateHdr1);
            GGDateHdr.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(GGDateHdr_AfterUpdate);
            

        }

        void GGDateHdr_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            if (UType == TUC_GridG.UpdateType.Update)
            {
                //string sqlStr = "";
                //hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
            }
        }

        public void RefreshDateHdr()
        {
            string sqlStr = "exec WS_FillDateHdr " + "'" + hmConn.MLUser + "'";
            hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
            LoadDateHdr();
            daDateHdr.Fill(dsDateHdr1);
        }
        private void LoadDateHdr()
        {
            dsDateHdr1.Clear();
            daDateHdr.SelectCommand.Parameters["@username"].Value = hmConn.MLUser;
            daDateHdr.Fill(dsDateHdr1);
        }

        private void ActivateLookup()
        {
            dsDateType1.Clear();
            daDateType.Fill(dsDateType1);

            dsOffsetDate1.Clear();
            daOffsetDate.Fill(dsOffsetDate1);
        }

        private void gvDateHdr_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int headID = 0;
            DataRow dr = gvDateHdr.GetDataRow(gvDateHdr.FocusedRowHandle);
            if (dr != null)
            {
                headID = Convert.ToInt32(dr["Head_ID"]);
            }
            dsDateDet1.Clear();
            daDateDet.SelectCommand.Parameters["@username"].Value = hmConn.MLUser;
            daDateDet.SelectCommand.Parameters["@headID"].Value = headID;
            daDateDet.Fill(dsDateDet1);
        }

        private void LoadDateDetail()
        {
            int headID = 0;
            DataRow dr = gvDateHdr.GetDataRow(gvDateHdr.FocusedRowHandle);
            if (dr != null)
            {
                headID = Convert.ToInt32(dr["Head_ID"]);
            }
            dsDateDet1.Clear();
            daDateDet.SelectCommand.Parameters["@username"].Value = hmConn.MLUser;
            daDateDet.SelectCommand.Parameters["@headID"].Value = headID;
            daDateDet.Fill(dsDateDet1);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreRegister("T");
                dateManagement_Main.btnFinish.Enabled = true;
                btnPrintRegister.BringToFront();
                btnPrintRegister.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found btnPrint_Click process:" + ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int dateID = 0, offsetDate_id = 0;
            string newDate = null;
            int offsetDays = 0;
            
            if (deNewDate.EditValue != null && deNewDate.EditValue != DBNull.Value)
                 newDate = deNewDate.DateTime.ToString();
            if (luDateType.EditValue != null && luDateType.EditValue != DBNull.Value)
                dateID = Convert.ToInt32(luDateType.EditValue);
            if (seOffsetDays.Text.ToString() != "")
                offsetDays = Convert.ToInt32(seOffsetDays.EditValue);
            if (luOffsetDate.EditValue != null && luOffsetDate.EditValue != DBNull.Value)
                offsetDate_id = Convert.ToInt32(luOffsetDate.EditValue);

            if (dateID == 0)
            {
                Popups.ShowPopup("Date type is required");
                return;
            }
            
            if ((newDate == null && offsetDate_id == 0) || (newDate != null && offsetDate_id != 0))
            {
                Popups.ShowPopup("You need to select either a new date or an off set date");
                return;
            }
            
            if ( (dateID == 1 || dateID == 2 || dateID == 3) && offsetDate_id != 0)//only agreement,closing and sale date can not have offset dates
            {
                Popups.ShowPopup(luDateType.Text + " cannot be setup with an off set date." );
                return;
            }
            if (dateID == offsetDate_id && dateID > 0 ) 
            {
                Popups.ShowPopup("You cannot select the off set date same as the date you want to change.");
                return;
            }

            // looping validation

            string msg = Loopvalidation(dateID, offsetDate_id);
            if (msg != "")
            {
                Popups.ShowPopup("The selected off set date would cause a loop and can not be selected");
                return;
            }
            //

            string sqlStr = "exec WS_UpdateDateWorkingTbls " + dateID.ToString() + "," + "'"+newDate+"'," +
                           offsetDays.ToString() + "," + offsetDate_id.ToString() + ",'" + hmConn.MLUser+"'," + "'%'";
            if (  newDate == null)
                sqlStr = "exec WS_UpdateDateWorkingTbls " + dateID.ToString() + "," + "null," +
                           offsetDays.ToString() + "," + offsetDate_id.ToString() + ",'" + hmConn.MLUser + "'," +"'%'"; ;
            FADO.DB.Global.RunSql(hmConn.CompanyServer, hmConn.TRDB, sqlStr, "111");
            LoadDateHdr();
            gvDateHdr_FocusedRowChanged(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
        public  void ClearSelection()
        {
            luDateType.EditValue = null;
            deNewDate.EditValue = null;
            seOffsetDays.EditValue = 0;
            luOffsetDate.EditValue = null;
        }
        private string Loopvalidation(int dateId, int offsetDateID)
        {
            string msg = "";
            string errMsg = "";
            int agreeID = 0;
            if (dateId > 0 && offsetDateID>0)
            {
                DataRow dr = gvDateHdr.GetDataRow(gvDateHdr.FocusedRowHandle);
                if (dr != null)
                {
                    for (int i = 0; i < gvDateHdr.RowCount; i++)
                    {
                        dr = gvDateHdr.GetDataRow(i);
                        agreeID = Convert.ToInt32(dr["Agreement_ID"]);
                        string sqlStr = "exec LD_Proj_Agreement_AdditionalDatesValidation_DateUpdate " + dateId.ToString() + "," +
                             offsetDateID.ToString() + "," + agreeID.ToString()+",'"+hmConn.MLUser+"'";
                        msg = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();
                        if (msg != "ok")
                        {
                            errMsg = errMsg +  msg;
                        }
                        
                    }
                }
            }

            return errMsg;
        }

        private void luOffsetDate_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luOffsetDate.EditValue = null;
            }

        }

        private void gvDateHdr_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //DataRow dr = gvDateHdr.GetDataRow(e.RowHandle);
            //if (dr != null)
            //{
            //    CheckFieldValueChanged();

            //}
        }

        private void gvDateHdr_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string  filedNameDesc = "";
            int agreementID = 0;
            DataRow dr = gvDateHdr.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                string fieldName = e.Column.FieldName.ToString();
                string sqlStr = "select [dbo].[fn_LD_GetIDByDateName]('" + fieldName + "')";
                int dateID = Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString());

                sqlStr = " select Description from LD_AdditionalDates where id = " + dateID.ToString();

                filedNameDesc =  hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();
                                   
                agreementID = Convert.ToInt32(dr["agreement_id"]);

                if(e.Value != DBNull.Value)
                    CheckManageFieldManually(fieldName, filedNameDesc, agreementID, dateID, Convert.ToDateTime(e.Value));
                else
                    CheckManageFieldManually(fieldName, filedNameDesc, agreementID, dateID, null);
             
                if ( e.Column.FieldName == "Closing_Date" || e.Column.FieldName == "Interest_Adjustment_Date" || e.Column.FieldName == "Arrears_Interest_Date"
                     || e.Column.FieldName == "Expected_Payout_Date" || e.Column.FieldName == "Original_Arrears_Date"
                     || e.Column.FieldName == "Estimated_Release_Date" || e.Column.FieldName == "Actual_Release_Date")
                {
                    if (e.Value == DBNull.Value)
                    {
                        UpdateDateValue(dateID, null, agreementID);
                    }
                    else
                    {
                        UpdateDateValue(dateID, Convert.ToDateTime(e.Value), agreementID);
                    }
                }
               
            }
        }

        private void UpdateDateValue(int dateID, DateTime? newDate , int agreeID)
        {
            GGDateHdr.SaveRecord(gvDateHdr.FocusedRowHandle);
            string sqlStr;
            if (newDate != null)
            {
                sqlStr = " exec WS_UpdateDateWorkingTbls  " + dateID.ToString() + ",'" + newDate.ToString() + "'" + " ,0, 0, "
                    + "'" + hmConn.MLUser + "'," + agreeID.ToString();
            }
            else
            {
                sqlStr = " exec WS_UpdateDateWorkingTbls  " + dateID.ToString() + ",null" + " ,0, 0, "
                    + "'" + hmConn.MLUser + "'," + agreeID.ToString();
            }
            hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
            daDateHdr.Fill(dsDateHdr1);
            LoadDateDetail();
        }

        private void CheckManageFieldManually(string filedName, string filedNameDesc, int agreementID, int dateID, DateTime? newDate)
        {
            string msg = "";
            string offsetDate_field = GetOffsetDateField(filedName, agreementID);

            if (offsetDate_field != "" && needCheck == "T")
            {
                msg = filedNameDesc + " is currently linked to " + offsetDate_field.ToString() + ". Would you like to manage this manually? ";
                if (this.Popups.ShowPopup(this, msg, frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.No)
                {
                    needCheck = "F";
                    gvDateHdr.SetFocusedRowCellValue("Agreement_Receipt_Date", currDate);


                }
                else
                {
                    UpdateDateValue(dateID, newDate, agreementID);
                }

            }
            else
            {
                UpdateDateValue(dateID, newDate, agreementID);
            }
            
        }
        private string GetOffsetDateField(string fieldName, int agreementID)
        {
            int offsetDate_id = 0;
            string offsetDate_field = "";
            string sqlStr = "select [dbo].[fn_LD_GetIDByDateName]('" + fieldName + "')";
            int dateID = Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString()); ;

            sqlStr = " select OffsetDate_ID from Working_Agreement_Date_Det where AdditionalDates_ID = " + dateID.ToString() +
                "  and agreement_id = " + agreementID.ToString() + " and username = '" + hmConn.MLUser + "'";
            object obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
            {
                offsetDate_id = Convert.ToInt32(obj);
                //
            }
            sqlStr = " select Description from LD_AdditionalDates where id = " + offsetDate_id.ToString() ;
            obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
            {
                offsetDate_field = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();
                //
            }
            

            return offsetDate_field;
        }

        string needCheck = "F";
        DateTime currDate = System.DateTime.Today;
        private void gvDateHdr_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int agreementID = 0;
            DataRow dr = gvDateHdr.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                agreementID = Convert.ToInt32(dr["agreement_id"]);
                
                if (e.Column.FieldName == "Customer_Hold_Check_Receipt_Date")
                {
                    currDate = GetCurrentDate("Customer_Hold_Check_Receipt_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Agreement_Receipt_Date")
                {
                    currDate = GetCurrentDate("Agreement_Receipt_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Lot_Payout_Generation_Date")
                {
                    currDate = GetCurrentDate("Lot_Payout_Generation_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Transfer_Date")
                {
                    currDate = GetCurrentDate("Transfer_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Possession_Date")
                {
                    currDate = GetCurrentDate("Possession_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Construction_Start_Date")
                {
                    currDate = GetCurrentDate("Construction_Start_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Construction_Start_Date_Extension")
                {
                    currDate = GetCurrentDate("Construction_Start_Date_Extension", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Construction_End_Date")
                {
                    currDate = GetCurrentDate("Construction_End_Date", agreementID);
                    needCheck = "T";

                }
                else if (e.Column.FieldName == "Construction_End_Date_Extension")
                {
                    currDate = GetCurrentDate("Construction_End_Date_Extension", agreementID);
                    needCheck = "T";
                }

                else if (e.Column.FieldName == "Architectural_Inspection_Fee_Due_Date")
                {
                    currDate = GetCurrentDate("Architectural_Inspection_Fee_Due_Date", agreementID);
                    needCheck = "T";
                }
                else if (e.Column.FieldName == "Initial_Inspection_Date")
                {
                    currDate = GetCurrentDate("Initial_Inspection_Date", agreementID);
                    needCheck = "T";
                }
                else if (e.Column.FieldName == "Inspection_Request_Date")
                {
                    currDate = GetCurrentDate("Inspection_Request_Date", agreementID);
                    needCheck = "T";
                }
                else if (e.Column.FieldName == "Final_Inspection_Date")
                {
                    currDate = GetCurrentDate("Final_Inspection_Date", agreementID);
                    needCheck = "T";
                }
                else if (e.Column.FieldName == "Approval_Date")
                {
                    currDate = GetCurrentDate("Approval_Date", agreementID);
                    needCheck = "T";
                }

                
            }
        }

        private DateTime GetCurrentDate(string fieldName, int agreementID)
        {
            DateTime currDate = System.DateTime.Today;
            string sqlStr = "select [dbo].[fn_LD_GetIDByDateName]('" + fieldName + "')";
            int dateID = Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString()); 
            sqlStr = " select [dbo].[fn_LD_GetWorkingDate] (" + dateID.ToString() + "," +  agreementID.ToString() + ", " + "'"+hmConn.MLUser+"')";
            object obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
                currDate =  Convert.ToDateTime(obj);

            return currDate;
        }
        private void CheckFieldValueChanged()
        {
            int OffsetDate_ID = 0,  agreementID = 0;
            DateTime dateValue = System.DateTime.Today;
            string fieldName = "Agreement_Receipt_Date";
            DateTime currDate = System.DateTime.Today;
            DataRow dr = gvDateHdr.GetDataRow(gvDateHdr.FocusedRowHandle);
            if (dr != null)
            {
                agreementID =Convert.ToInt32( dr["agreement_id"]);
                currDate = Convert.ToDateTime(dr[fieldName]);
                for (int i = 1; i < 24; i++)
                {
                    string sqlStr = "select [dbo].[fn_LD_GetDateName](" + i.ToString() + ")";
                    fieldName = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();
                    sqlStr = " select OffsetDate_ID from Working_Agreement_Date_Det where AdditionalDates_ID = " + i.ToString() + 
                        "  and agreement_id = " + agreementID.ToString() + " and username = '"+hmConn.MLUser+"'";
                    object obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
                    if (obj != null && obj != DBNull.Value)
                    {
                        OffsetDate_ID = Convert.ToInt32(obj);
                        //
                    }

                }

            }
           
           
        }

               

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            PrintPreRegister("F");
        }

        public void PrintPreRegister(string preRegister)
        {
            try
            {
                string[,] saParams = new string[2, 2];
                saParams[0, 0] = "@USERNAME";
                saParams[1, 0] = this.hmConn.MLUser;
                saParams[0, 1] = "@prereg";
                saParams[1, 1] = preRegister;
                frmHM_Report_Printer HMRP = new frmHM_Report_Printer(this.hmConn, this.hmDevMgr, saParams, "WS_AgreeDateChangeRegX.rpt", frmHM_Report_Printer.DBFlavor.TR);
                HMRP.ShowDialog();
                IDisposable dispose = HMRP;
                dispose.Dispose();


            }
            catch (Exception ex)
            {
                this.Popups.ShowPopup("Error found in btnPrint_Click in ucDateUpdate:" + ex.Message + ex.StackTrace);
            }


        }

        public void SetupControls()
        {
            btnPrintRegister.SendToBack();
            btnUpdate.Enabled = true;
            //ClearSelection();
        }

       
    }
}
