using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotPayoutAssistant
{
    public partial class ucReview : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        private bool settingValues = false;
        private bool isFilling = false;
        TUC_GridG.GridG gGridAddFee;
        TUC_GridG.GridG ggProgramFees;
        private KeyControlAccess.Validator KCA_Validator;
        private const int CONST_LOT_PAY_INTEREST_ADJUST = 367;
        private bool settingAdjustCheck = false;
        private string _SearchUsername = "";

        public ucReview(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, KeyControlAccess.Validator pKCA_Validator)
        {
            InitializeComponent();
            KCA_Validator = pKCA_Validator;
            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            _SearchUsername = hmCon.MLUser + "LotPayoutAssistant";
            da_selectedLots.SelectCommand.Parameters["@username"].Value = _SearchUsername;
            settingValues = true;
            acctYearPeriod1.TRDBName = hmCon.TRDB;
            acctYearPeriod1.TRServerName = hmCon.CompanyServer;
            acctYearPeriod1.checkClose = "T"; //Turns on/off Open period check.
            acctYearPeriod1.luAcctPeriod.EditValueChanged += new EventHandler(luAcctPeriod_EditValueChanged);
            acctYearPeriod1.luAcctYear.EditValueChanged += new EventHandler(luAcctYear_EditValueChanged);
            acctYearPeriod1.MessageBoxHeaderText = "Lot Sale Assistant";
            UpdateDate();
            settingValues = false;
            


            gGridAddFee = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvAdditionalFees, da_AdditionalFees, ds_AdditionalFees1);
            gGridAddFee.AllowTabCreateNewRecord = true;
            gGridAddFee.AskBeforeDelete = false;
            gGridAddFee.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            ggProgramFees = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvProgramFees, daProgramFees, dsProgramFees1);
            ggProgramFees.AllowTabCreateNewRecord = true;
            ggProgramFees.AskBeforeDelete = false;
            ggProgramFees.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

  
            if (hmCon.CountryCode == "U")
            {
                colprov.Caption = "State";
                colpostal.Caption = "Zip";
            }
            else if (hmCon.CountryCode == "C")
            {
                colprov.Caption = "Province";
                colpostal.Caption = "Postal Code";
            }

            object result = connection.SQLExecutor.ExecuteScalar("select isnull(LotPayIntAdjust,0) from LD_Setup", connection.TRConnection);
            if (connection.SQLExecutor.Exception != null)
            {
                popup.ShowPopup("Error checking for Intrest adjustment flag:" + connection.SQLExecutor.Exception.Message);
                pnlIntAdj.Visible = false;
            }
            else if (result == null || result == DBNull.Value)
            {
                pnlIntAdj.Visible = false;
            }
            else if (!Convert.ToBoolean(result))
            {
                pnlIntAdj.Visible = false;
            }



        }

        private void ucReview_Load(object sender, EventArgs e)
        {
            SetupLevels();
        }

        private void SetupLevels()
        {
            string sql = "select  isnull(lv1_land_desc,'')[lv1_land_desc] , isnull(lv2_land_desc,'')[lv2_land_desc] , isnull(lv3_land_desc,'')[lv3_land_desc] , isnull(lv4_land_desc,'')[lv4_land_desc] ," +
                "isnull(lv1_active_land,'F')[lv1_active_land] , isnull(lv2_active_land,'F')[lv2_active_land] , isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl ";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                if (popup != null)
                    popup.ShowPopup("Error loading costing reference setup:" + hmCon.SQLExecutor.Exception.Message);
                else
                    MessageBox.Show("Error loading costing reference setup:" + hmCon.SQLExecutor.Exception.Message);
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
                colGST.Caption = "GST";
                colPST.Caption = "PST";
            }
            else if (hmCon.CountryCode == "U")
            {
                colGST.Caption = "Tax 1";
                colPST.Caption = "Tax 2";
            }
        }

        private void SetCostingReferenceColumns(DataRow row)
        {
            collv1ID.Caption = row["lv1_land_desc"].ToString();
            collv2ID.Caption = row["lv2_land_desc"].ToString();
            collv3ID.Caption = row["lv3_land_desc"].ToString();
            collv4ID.Caption = row["lv4_land_desc"].ToString();

            collv1ID.OptionsColumn.ShowInCustomizationForm = collv1ID.Visible = (row["lv1_active_land"].ToString() == "T");
            collv2ID.OptionsColumn.ShowInCustomizationForm = collv2ID.Visible = (row["lv2_active_land"].ToString() == "T");
            collv3ID.OptionsColumn.ShowInCustomizationForm = collv3ID.Visible = (row["lv3_active_land"].ToString() == "T");
            collv4ID.OptionsColumn.ShowInCustomizationForm = collv4ID.Visible = (row["lv4_active_land"].ToString() == "T");

            collv1ID1.Caption = row["lv1_land_desc"].ToString();
            collv2ID1.Caption = row["lv2_land_desc"].ToString();
            collv3ID1.Caption = row["lv3_land_desc"].ToString();
            collv4ID1.Caption = row["lv4_land_desc"].ToString();

            collv1ID1.OptionsColumn.ShowInCustomizationForm = collv1ID1.Visible = (row["lv1_active_land"].ToString() == "T");
            collv2ID1.OptionsColumn.ShowInCustomizationForm = collv2ID1.Visible = (row["lv2_active_land"].ToString() == "T");
            collv3ID1.OptionsColumn.ShowInCustomizationForm = collv3ID1.Visible = (row["lv3_active_land"].ToString() == "T");
            collv4ID1.OptionsColumn.ShowInCustomizationForm = collv4ID1.Visible = (row["lv4_active_land"].ToString() == "T");
        }

      
        bool gGrid_AllowDelete(object sender, DataRow row)
        {

            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;

        }

        public void RefreshMe()
        {
            isFilling = true;
            cePreviousPerDiem.Checked = false;
            ceCreateInterim.Checked = false;
            string sql = 
                "delete working_ld_lpa_AdditionalFees where username = '" + hmCon.MLUser + "' "+
                "delete working_ld_lpa_Interest where username = '" + hmCon.MLUser + "'  "+
                "exec LD_lpa_FillCashToClose '" + hmCon.MLUser + "', " + (dePayoutDate.EditValue == DBNull.Value || dePayoutDate.EditValue == null ? "null" : "'" + dePayoutDate.DateTime.ToShortDateString() + "'") + " " +
                "exec LD_lpa_LoadAdditionalFees '" + hmCon.MLUser + "' " +
                "exec LD_lpa_LoadProgramFees '" + hmCon.MLUser + "' ";
            hmCon.SQLExecutor.ExecuteNonQuery(sql , hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
            {
                popup.ShowPopup("Error clearing working tables:" + hmCon.SQLExecutor.Exception.Message);

            }
            
           
            try
            {
                settingValues = true;
            
                acctYearPeriod1.RefreshAcctPeriod();
                ds_selectedLots1.Clear();
                da_selectedLots.Fill(ds_selectedLots1);
                dsLevel1Codes1.Clear();
                daLevel1Codes.Fill(dsLevel1Codes1);
                dsLevel2Codes1.Clear();
                daLevel2Codes.Fill(dsLevel2Codes1);
                dsLevel3Codes1.Clear();
                daLevel3Codes.Fill(dsLevel3Codes1);
                dsLevel4Codes1.Clear();
                daLevel4Codes.Fill(dsLevel4Codes1);
                //moved to focused row changed
                //ds_AdditionalFees1.Clear();
                //da_AdditionalFees.SelectCommand.Parameters["@Username"].Value = hmCon.MLUser;
                //da_AdditionalFees.Fill(ds_AdditionalFees1);
                //dsProgramFees1.Clear();
                //daProgramFees.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
                //daProgramFees.Fill(dsProgramFees1);
                tcPayoutDetails.SelectedTabPage = tpCashToClose;

                settingValues = false;
                //UpdateDate();
                dePayoutDate.EditValue = DateTime.Today;
                deInvoiceDate_EditValueChanged(dePayoutDate, null);
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }
            isFilling = false;
            gvReview_FocusedRowChanged(gvReview, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvReview.FocusedRowHandle));
        }

        private void luAcctYear_EditValueChanged(object sender, EventArgs e)
        {
            if(!settingValues)
                UpdateDate();
        }

        private void luAcctPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (!settingValues)
                UpdateDate();
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
                dePayoutDate.DateTime = new DateTime(iYear, iMonth, 1);
                settingValues = false;

            }
        }

        private bool isDateInValid()
        {
            bool returnValue = true;
            if (dePayoutDate.EditValue != DBNull.Value && dePayoutDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + dePayoutDate.DateTime.ToShortDateString() + "' and PERIOD <> 13 order by END_DATE";
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
                    popup.ShowPopup("Payout date must be within the selected year/period.");
                }

            }
            else
                popup.ShowPopup("Payout date is required.");



            return returnValue;
        }

        private void deInvoiceDate_EditValueChanged(object sender, EventArgs e)
        {           
            
            if (dePayoutDate.EditValue != DBNull.Value && dePayoutDate.EditValue != null)
            {
                if (dePayoutDate.DateTime.Year != 0001)
                {
                    string sql = "exec [LD_lpa_CalculateInterest] '" + hmCon.MLUser + "','" + dePayoutDate.DateTime.ToShortDateString() + "','', " + (cePreviousPerDiem.Checked ? "1" : "0") +",'"+_SearchUsername+"' "+
                        "exec LD_lpa_FillCashToClose '" + hmCon.MLUser + "', " + (dePayoutDate.EditValue == DBNull.Value || dePayoutDate.EditValue == null ? "null" : "'" + dePayoutDate.DateTime.ToShortDateString() + "'") + " ";
                    hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                        popup.ShowPopup("Error setting interest:" + hmCon.SQLExecutor.Exception.Message);

                    gvReview_FocusedRowChanged(gvReview, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle,gvReview.FocusedRowHandle));

                    if (settingValues) return;

                    sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + dePayoutDate.DateTime.ToShortDateString() + "' and PERIOD < 13 order by END_DATE";
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

                
            }
        }


        public bool isValid()
        {
            bool returnValue = true;

            object oPeriodOpen = hmCon.SQLExecutor.ExecuteScalar("Select IsNull(PERIOD_OPEN,'F') From AR_PERIODS Where AR_YEAR = " + acctYearPeriod1.luAcctYear.EditValue.ToString() + " And PERIOD = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + "", hmCon.TRConnection);
            if (oPeriodOpen == DBNull.Value || oPeriodOpen == null) oPeriodOpen = "F";

            if (oPeriodOpen.ToString() == "F")
            {
                popup.ShowPopup("Year and Period combination are not open.");
                returnValue = false;
            }
            else
            {
                returnValue = !isDateInValid();
            }

            if (returnValue)
            {
                object result = hmCon.SQLExecutor.ExecuteScalar("select Convert(DateTime,Convert(varchar,agreement_date,101)) from PROJ_LOT_AGREEMENT where agreement_id = " + gvReview.GetFocusedRowCellValue(colagreement_id).ToString(), hmCon.TRConnection);
                if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToDateTime(result).CompareTo(dePayoutDate.DateTime) > 0)
                    {
                        popup.ShowPopup("Payout date must be greater then or equal to the agreement date");
                        returnValue = false;
                    }
                }
                else
                {
                    returnValue = false;
                    popup.ShowPopup("Error agreement start date not set");
                }
            }
            
            


            return returnValue;
        }

        private void gvAdditionalFees_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colLD_Additional_Fees_ID) //This is actuall the agreemts additional fees level ID.
            {
                int iAgreementFees_ID = -1;
                try { iAgreementFees_ID = Convert.ToInt32(e.Value); }
                catch{}

                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(@"Select af.Additional_Fees_ID, af.GL_Account,
lv1.lv1ID AS Level1, lv2.lv2ID AS Level2, lv3.lv3ID AS Level3, lv4.lv4ID AS Level4, af.GST, af.PST, af.Amount
From LD_Additional_Fees af
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = af.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = af.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = af.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = af.lv4ID
Inner Join LD_Proj_Agreement_AdditionalFees aaf on aaf.Additional_Fees_ID = af.Additional_Fees_ID
Where aaf.ID = " + iAgreementFees_ID.ToString(), hmCon.TRConnection);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gvAdditionalFees.GetDataRow(e.RowHandle)["GL_Account"] = dt.Rows[0]["GL_Account"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["Amount"] = dt.Rows[0]["Amount"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["lv1ID"] = dt.Rows[0]["Level1"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["lv2ID"] = dt.Rows[0]["Level2"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["lv3ID"] = dt.Rows[0]["Level3"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["lv4ID"] = dt.Rows[0]["Level4"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["GST"] = dt.Rows[0]["GST"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["PST"] = dt.Rows[0]["PST"];
                        gvAdditionalFees.GetDataRow(e.RowHandle)["LD_Additional_Fees_ID"] = dt.Rows[0]["Additional_Fees_ID"];
                    }
                }                
            }
        }

        private void gvReview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dslueProgramFees1.Clear();
            ds_lueAdditionalFees1.Clear();
            ds_Interest1.Clear();
            ds_CashToClose1.Clear();

            if (isFilling) return;
            DataRow row = gvReview.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
               //detail grids can handle multipul lots being sold but as of now ONLY 1 lot can be selected.
                int iLotSearchID = -1;
                int iAgreement_ID = -1;
                try { iAgreement_ID = Convert.ToInt32(gvReview.GetDataRow(e.FocusedRowHandle)["agreement_id"]); }
                catch { }
                try { iLotSearchID = Convert.ToInt32(gvReview.GetDataRow(e.FocusedRowHandle)[colID.FieldName]); }
                catch { }

                da_lueAdditionalFees.SelectCommand.Parameters["@agreement_id"].Value = iAgreement_ID;
                da_lueAdditionalFees.Fill(ds_lueAdditionalFees1);
                dalueProgramFees.SelectCommand.Parameters["@agreement_id"].Value = iAgreement_ID;
                dalueProgramFees.Fill(dslueProgramFees1);

                ds_AdditionalFees1.Clear();
                da_AdditionalFees.SelectCommand.Parameters["@Username"].Value = hmCon.MLUser;
                da_AdditionalFees.SelectCommand.Parameters["@working_ld_lotsearch_id"].Value = iLotSearchID;
                da_AdditionalFees.Fill(ds_AdditionalFees1);
                
                dsProgramFees1.Clear();
                daProgramFees.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
                daProgramFees.SelectCommand.Parameters["@working_ld_lotsearch_id"].Value = iLotSearchID;
                daProgramFees.Fill(dsProgramFees1);

                da_Interest.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
                da_Interest.SelectCommand.Parameters["@working_ld_lotsearch_id"].Value = iLotSearchID;
                ds_Interest1.Clear();
                da_Interest.Fill(ds_Interest1);

                da_CashToClose.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
                da_CashToClose.SelectCommand.Parameters["@working_ld_lotsearch_id"].Value = iLotSearchID;
                ds_CashToClose1.Clear();
                da_CashToClose.Fill(ds_CashToClose1);

                
                object result = hmCon.SQLExecutor.ExecuteScalar("select InterestAmount from working_ld_lpa_Interest where Transactiontype = 'Adjustment' and username = '" + hmCon.MLUser + "' and working_ld_lotSearch_id = " + gvReview.GetFocusedRowCellValue(colID).ToString(), hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error checking for interest adjustment : " + hmCon.SQLExecutor.Exception.Message);
                settingAdjustCheck = true;
                if (result != null && result != DBNull.Value)
                {
                    teInterestAdj.EditValue = result;
                    teInterestAdj.Enabled = false;
                    ceIntAdj.Checked = true;
                }
                else
                {
                    teInterestAdj.EditValue = DBNull.Value;
                    teInterestAdj.Enabled = true;
                    ceIntAdj.Checked = false;
                }
                settingAdjustCheck = false;
               
                
            }
        }

        private void gvAdditionalFees_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvAdditionalFees.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colusername.FieldName] = hmCon.MLUser;
                row[colworking_ld_LotSearch_ID.FieldName] = gvReview.GetFocusedDataRow()[colID.FieldName];
            }

        }
       

        private void GridsInvalidRow(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvAdditionalFees_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colLD_Additional_Fees_ID, colAmount }, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (GetAmount(rv[colAmount.FieldName]) == 0)
            {
                popup.ShowPopup("Amount must not be zero.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else
            {
                int iLD_Proj_Agreement_Additional_ID = -1, iID = -2;
                try { iID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)["working_ld_lss_AdditionalFees_ID"]); }
                catch { }
                try { iLD_Proj_Agreement_Additional_ID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)[colLD_Additional_Fees_ID.FieldName]); }
                catch { }

                int iCount = -1;
                object oCount = hmCon.SQLExecutor.ExecuteScalar("Select Count(1) from working_ld_lpa_AdditionalFees where Username = '" + hmCon.MLUser + "' " +
                    " and LD_Agreement_Additional_Fees_ID = " + iLD_Proj_Agreement_Additional_ID.ToString() + " " +
                    " and working_ld_lss_AdditionalFees_ID <> " + iID.ToString(), hmCon.TRConnection);

                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount > 0)
                {
                    popup.ShowPopup("Additional Fee already exists.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
        }

    
        private double GetAmount(object Value)
        {
            double dValue = 0;
            try
            {
                dValue = Convert.ToDouble(Value);
            }
            catch { }

            return dValue;
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

        private void gvCashToClose_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colAmount1)
                e.RepositoryItem = ri_seAmount;
        }

        private void gvProgramFees_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colLD_Agreement_ProgramFee_ID) //This is actuall the agreemts additional fees level ID.
            {
                int iProgramFees_ID = -1;
                try { iProgramFees_ID = Convert.ToInt32(e.Value); }
                catch { }

                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(@"Select pf.ID ProgramFee_ID, pf.GL_Account,
lv1.lv1ID AS Level1, lv2.lv2ID AS Level2, lv3.lv3ID AS Level3, lv4.lv4ID AS Level4, ppf.GST, ppf.PST, ppf.PurchaserPortion Amount
From LD_ProgramFees pf
Left Outer Join Level1_Codes lv1 on lv1.lv1ID = pf.lv1ID
Left Outer Join Level2_Codes lv2 on lv2.lv2ID = pf.lv2ID
Left Outer Join Level3_Codes lv3 on lv3.lv3ID = pf.lv3ID
Left Outer Join Level4_Codes lv4 on lv4.lv4ID = pf.lv4ID
Inner Join LD_Proj_Agreement_ProgramFees apf on apf.ProgramFees_ID = pf.ID
Inner Join LD_Proj_ProgramFees ppf on ppf.ID = apf.LD_Proj_ProgramFees_ID and ppf.ProgramFees_ID = pf.ID
Where apf.ID = " + iProgramFees_ID.ToString(), hmCon.TRConnection);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gvProgramFees.GetDataRow(e.RowHandle)["GL_Account"] = dt.Rows[0]["GL_Account"];
                        gvProgramFees.GetDataRow(e.RowHandle)["Amount"] = dt.Rows[0]["Amount"];
                        gvProgramFees.GetDataRow(e.RowHandle)["lv1ID"] = dt.Rows[0]["Level1"];
                        gvProgramFees.GetDataRow(e.RowHandle)["lv2ID"] = dt.Rows[0]["Level2"];
                        gvProgramFees.GetDataRow(e.RowHandle)["lv3ID"] = dt.Rows[0]["Level3"];
                        gvProgramFees.GetDataRow(e.RowHandle)["lv4ID"] = dt.Rows[0]["Level4"];
                        gvProgramFees.GetDataRow(e.RowHandle)["GST"] = dt.Rows[0]["GST"];
                        gvProgramFees.GetDataRow(e.RowHandle)["PST"] = dt.Rows[0]["PST"];
                        gvProgramFees.GetDataRow(e.RowHandle)["LD_ProgramFee_ID"] = dt.Rows[0]["ProgramFee_ID"];
                    }
                }
            }
        }

        private void gvProgramFees_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvProgramFees.GetDataRow(e.RowHandle)["Username"] = hmCon.MLUser;
            gvProgramFees.GetDataRow(e.RowHandle)["working_ld_LotSearch_ID"] = gvReview.GetFocusedDataRow()[colID.FieldName];
        }

        private void gvProgramFees_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView rv = (DataRowView)e.Row;
            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colLD_Agreement_ProgramFee_ID, colAmount3 }, false)) != "")
            {
                popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (GetAmount(rv[colAmount.FieldName]) < 0)
            {
                popup.ShowPopup("Amount must at least be 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else
            {
                int iLD_Proj_Agreement_ProgramFee_ID = -1, iID = -2;
                try { iID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)["ID"]); }
                catch { }
                try { iLD_Proj_Agreement_ProgramFee_ID = Convert.ToInt32(gvProgramFees.GetDataRow(e.RowHandle)[colLD_Agreement_ProgramFee_ID.FieldName]); }
                catch { }

                int iCount = -1;
                object oCount = hmCon.SQLExecutor.ExecuteScalar("Select Count(1) from working_ld_lpa_ProgramFees where Username = '" + hmCon.MLUser + "' " +
                    " and LD_Agreement_ProgramFee_ID = " + iLD_Proj_Agreement_ProgramFee_ID.ToString() + " " +
                    " and ID <> " + iID.ToString(), hmCon.TRConnection);

                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount > 0)
                {
                    popup.ShowPopup("Program Fee already exists.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                }
            }
        }

        private void tcPayoutDetails_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
            if (e.Page.Name == tpCashToClose.Name)
            {
                hmCon.SQLExecutor.ExecuteNonQuery("exec LD_lpa_FillCashToClose '" + hmCon.MLUser + "', " + (dePayoutDate.EditValue == DBNull.Value || dePayoutDate.EditValue == null ? "null" : "'" + dePayoutDate.DateTime.ToShortDateString() + "'") + " ", hmCon.TRConnection);
                ds_CashToClose1.Clear();
                da_CashToClose.Fill(ds_CashToClose1);

            }
        }

        private void ceIntAdj_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (settingAdjustCheck) return;

            bool isChecked = false;

            try
            {
                isChecked = Convert.ToBoolean(e.NewValue);
            }
            catch{}

            if (isChecked)
            {
                if (KCA_Validator.ValidatePassword(CONST_LOT_PAY_INTEREST_ADJUST))
                {
                    object result = hmCon.SQLExecutor.ExecuteScalar("select Amount*-1 from working_ld_lpa_CashToClose where SortOrder = 13 and working_ld_lotsearch_id =" + gvReview.GetFocusedRowCellValue(colID).ToString(), hmCon.TRConnection);
                    if (hmCon.SQLExecutor.Exception != null)
                        popup.ShowPopup("Error adding adjustment : " + hmCon.SQLExecutor.Exception.Message);
                    else if (result == null || result == DBNull.Value)
                    {
                        result = 0;
                    }


                    if (teInterestAdj.EditValue != null && teInterestAdj.EditValue != DBNull.Value)
                    {
                        if (Convert.ToDecimal(teInterestAdj.EditValue) > 2000000000)
                        {
                            popup.ShowPopup("Adjustment value is too large.");
                            e.Cancel = true;
                            return;
                        }
                        else if (Convert.ToDecimal(result) > Convert.ToDecimal(teInterestAdj.EditValue))
                        {
                            popup.ShowPopup("Adjustment value can not bring interest owing below zero.");
                            e.Cancel = true;
                            return;
                        }


                        string InsertSql = "declare @amount money = " + teInterestAdj.EditValue.ToString() + @"
insert into working_ld_lpa_Interest (username, working_ld_LotSearch_ID, FromDate, ToDate, InterestRatePct, InterestAmount, PrincipleBalance, RunningInterest, PerDiem, Days, DaysInYear, Transactiontype, InterestType, Compounded, Commencement, Amount)
select top 1 i.username,i.working_ld_lotsearch_id,ToDate,ToDate,0,@amount,i.PrincipleBalance, i.RunningInterest + @amount,0,0,i.DaysInYear,'Adjustment','Adjustment',0,'',0
from working_ld_lpa_Interest i
where i.username = '" + hmCon.MLUser + "' and i.working_ld_lotSearch_id = " + gvReview.GetFocusedRowCellValue(colID).ToString() + @"
order by i.ToDate desc update working_ld_lpa_CashToClose set Amount = Amount + @amount where SortOrder in(13,99) and working_ld_lotsearch_id = " + gvReview.GetFocusedRowCellValue(colID).ToString();
                        teInterestAdj.Enabled = false;
                        hmCon.SQLExecutor.ExecuteNonQuery(InsertSql, hmCon.TRConnection);
                        if (hmCon.SQLExecutor.Exception != null)
                            popup.ShowPopup("Error adding adjustment : " + hmCon.SQLExecutor.Exception.Message);
                        ds_Interest1.Clear();
                        da_Interest.Fill(ds_Interest1);
                        ds_CashToClose1.Clear();
                        da_CashToClose.Fill(ds_CashToClose1);
                    }
                    else
                    {
                        popup.ShowPopup("Please enter an adjustment value.");
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                
                teInterestAdj.Enabled = true;
                hmCon.SQLExecutor.ExecuteNonQuery("delete working_ld_lpa_Interest where Transactiontype = 'Adjustment' and InterestType = 'Adjustment' and username = '" + hmCon.MLUser + "' and working_ld_lotSearch_id = " + gvReview.GetFocusedRowCellValue(colID).ToString() + @"
update working_ld_lpa_CashToClose set Amount = Amount - " + teInterestAdj.EditValue.ToString() + " where SortOrder in(13,99) and working_ld_lotsearch_id = " + gvReview.GetFocusedRowCellValue(colID).ToString(), hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error removing adjustment : " + hmCon.SQLExecutor.Exception.Message);
                ds_Interest1.Clear();
                da_Interest.Fill(ds_Interest1);
                ds_CashToClose1.Clear();
                da_CashToClose.Fill(ds_CashToClose1);
            }
        }
    }
}
