using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProjInvestors
{
    public partial class ucProjInvestors : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gShares;
        TUC_GridG.GridG gGridDetail;
        private bool isFilling = false;
        private int iPriID = -1;
        private bool bReadOnly = false;
        private bool ReloadDetails = false;

        public ucProjInvestors(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;

            gShares = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvShares, daShares, dsShares1);
            gShares.AskBeforeDelete = false;
            gShares.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gShares_AllowDelete);
            gShares.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gShares_AfterUpdate);
            gShares.AllowTabCreateNewRecord = true;

            gGridDetail = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvDetail, daProjInvestorDetail, dsProjInvestorDetail1);
            gGridDetail.AskBeforeDelete = false;
            gGridDetail.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGridDetail_AllowDelete);
            gGridDetail.AllowTabCreateNewRecord = true;

        }
        void gShares_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            if (TUC_GridG.UpdateType.Delete != UType && ReloadDetails)
            {
                string sql = "declare @LD_PROJ_Investor_Header_ID int = " + gvShares.GetDataRow(gvShares.FocusedRowHandle)
                    ["shares_id"].ToString() + @"

delete LD_PROJ_Investor_Detail where LD_PROJ_Investor_Header_ID = @LD_PROJ_Investor_Header_ID
insert into LD_PROJ_Investor_Detail(LD_PROJ_Investor_Header_ID, BeneficalOwner_ID, Share)
select s.SHARES_ID, sd.BeneficalOwner_ID, sd.Share 
from LD_Shares s
join LD_Share_Owners h on h.ShareOwners_ID = s.SHAREOWNERS_ID
join LD_Investor_Detail sd on sd.Header_ID = h.ShareOwners_ID
where s.SHARES_ID = @LD_PROJ_Investor_Header_ID";
                con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error loading details from setup:" + con.SQLExecutor.Exception.Message);
                gvShares_FocusedRowChanged(gvShares, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvShares.FocusedRowHandle));
            }
        }
        bool gShares_AllowDelete(object sender, DataRow row)
        {
            if (dsProjInvestorDetail1.LD_PROJ_Investor_Detail.Rows.Count > 0)
            {
                pop.ShowPopup("You must delete all details before you can delete this record.");
                return false;
            }
            else
            {
                if (pop.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        private void ucProjInvestors_Load(object sender, EventArgs e)
        {
            SetReadOnlyMode(bReadOnly);
            tuc_mgr.FormInit(this);
        }
        public void RefreshDetails(int iProjHeaderID)
        {
            iPriID = iProjHeaderID;
            object oStatus = con.SQLExecutor.ExecuteScalar("Select pri_status From proj_header where pri_id = " + iPriID.ToString(), con.TRConnection);
            string sStatus = "";
            try { sStatus = oStatus.ToString(); }
            catch { }

            if (sStatus == "C" || sStatus == "X" || iPriID <= 0)
                bReadOnly = true;

            SetReadOnlyMode(bReadOnly);
            daShares.SelectCommand.Parameters["@PRI_ID"].Value = iPriID;

            try
            {

                dsSupplier1.Clear();daSupplier.Fill(dsSupplier1);
                dsCustomers1.Tables[0].Clear();daCustomers.Fill(dsCustomers1);
                dsBeneficalOwner1.Clear(); daBeneficalOwner.Fill(dsBeneficalOwner1);
                dsShareOwners1.Clear(); daShareOwners.Fill(dsShareOwners1);
                dsGLSubcode1.Clear(); daGLSubcode.Fill(dsGLSubcode1);
                dsGLMaster1.Clear(); daGLMaster.Fill(dsGLMaster1);
                
                dsInvestor1.Clear();daInvestor.Fill(dsInvestor1);
                
                isFilling = true;
                dsShares1.Tables[0].Clear();daShares.Fill(dsShares1);
                isFilling = false;
                gvShares_FocusedRowChanged(gvShares, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvShares.FocusedRowHandle));
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading project investors:" + ex.Message);
            }
        }
        public void SetReadOnlyMode(bool ReadOnly)
        {
            bReadOnly = ReadOnly;

            gvShares.OptionsBehavior.Editable = !bReadOnly;
            if (gShares != null)
                gShares.Event_ProcessGridKey_Enabled = !bReadOnly;

            gvDetail.OptionsBehavior.Editable = !bReadOnly;
            if (gGridDetail != null)
                gGridDetail.Event_ProcessGridKey_Enabled = !bReadOnly;
        }
               
        #region Details
        bool gGridDetail_AllowDelete(object sender, DataRow row)
        {
            if (pop.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                gvShares.SetFocusedRowCellValue("SetupComplete", false);
                daShares.Update(dsShares1);
                return true;
            }
            else
            {
                return false;
            }

        }
        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            ReloadDetails = false;
            DataRow row = gvDetail.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colLD_PROJ_Investor_Header_ID.FieldName] = gvShares.GetFocusedDataRow()["Shares_ID"];
            }
        }
        private void gvDetail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private void gvDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;
            decimal SharePercent = 0;
            decimal OtherSharePercent = 0;
            try
            {
                SharePercent = (decimal)drv[colShare.FieldName];
            }
            catch { }
            try
            {
                OtherSharePercent = GetOtherSharePercent(Convert.ToInt32(drv[colLD_PROJ_Investor_Header_ID.FieldName]), Convert.ToInt32(drv[colID1.FieldName]));
            }
            catch { }
            if (drv[colBeneficalOwner_ID.FieldName] == null || drv[colBeneficalOwner_ID.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Benifical owner is required.");
                e.Valid = false;
            }
            else if (IsLessThanZero(drv[colShare.FieldName], true))
            {
                pop.ShowPopup("Share can not be less than zero.");
                e.Valid = false;
            }
            else if (IsPercentToLarge(drv[colShare.FieldName]))
            {
                pop.ShowPopup("Share must be less than 100.");
                e.Valid = false;
            }
            else if (OtherSharePercent + SharePercent > 100)
            {
                pop.ShowPopup("Total share must not be greater than 100.");
                e.Valid = false;
            }
            else if (IsBeneficalOwnerUsed(drv))
            {
                pop.ShowPopup("Benefical owner must be unique.");
                e.Valid = false;
            }
            if (e.Valid)
            {
                if (OtherSharePercent + SharePercent != 100)
                {
                    pop.ShowPopup("Warning share percent total does not equal 100.");
                    if (Convert.ToBoolean(gvShares.GetFocusedDataRow()["SetupComplete"]) == true)
                    {
                        gvShares.SetFocusedRowCellValue("SetupComplete", false);
                        daShares.Update(dsShares1);
                    }
                }
                else
                {
                    if (Convert.ToBoolean(gvShares.GetFocusedDataRow()["SetupComplete"]) == false)
                    {
                        gvShares.SetFocusedRowCellValue("SetupComplete", true);
                        daShares.Update(dsShares1);
                    }
                }
            }
        }
        private decimal GetOtherSharePercent(int HeaderID, int ID)
        {
            decimal returnvalue = 0;
            string sql = "select sum(share) from LD_Proj_Investor_Detail where ld_proj_investor_header_id = " + HeaderID.ToString() + " and ID <> " + ID.ToString();


            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting total share amount." + con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

            return returnvalue;
        }
        private bool IsBeneficalOwnerUsed(DataRowView drv)
        {
            bool returnvalue = true;
            string sql = "select * from LD_Proj_Investor_Detail where BeneficalOwner_ID = " + drv["BeneficalOwner_ID"].ToString() + " and ID <> " + drv["ID"].ToString() + " and LD_PROJ_Investor_Header_ID  = " + drv[colLD_PROJ_Investor_Header_ID.FieldName].ToString();
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error checking if benefical owner is used:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    returnvalue = false;
                }
            }



            return returnvalue;
        }
        #endregion Details
       
        #region ShareOwners
        private void gvShares_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            dsProjInvestorDetail1.Tables[0].Clear();
            gGridDetail.Event_ProcessGridKey_Enabled = false;//disable adding new row with F7
            if (e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle && e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gvShares.GetDataRow(e.FocusedRowHandle);
                if (row != null)
                {
                    gGridDetail.Event_ProcessGridKey_Enabled = true;
                    daProjInvestorDetail.SelectCommand.Parameters["@LD_PROJ_Investor_Header_ID"].Value = row["Shares_ID"];
                    daProjInvestorDetail.Fill(dsProjInvestorDetail1);
                }
            }
        }
        private void gvShares_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvShares.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row["PRI_ID"] = iPriID;
                row["Responsibility"] = 0;
                row["Distribution"] = 0;
                row["SHARE_PCT"] = 0;
                row["SetupComplete"] = false;
            }
        }
        private void gvShares_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;

            decimal OtherResponsibility = 0;
            decimal OtherDistribution = 0;
            decimal OtherProportinate = 0;

            string sql = @"
select sum(Responsibility)[Responsibility], 
sum(Distribution)[Distribution],
sum(SHARE_PCT)[Proportinate] 
from LD_Shares 
where pri_id = " + iPriID.ToString() + @" 
and shares_id <> " + drv["shares_id"].ToString();
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting other percentages:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    try { OtherResponsibility = Convert.ToDecimal(dt.Rows[0]["Responsibility"]); }
                    catch { }
                    try { OtherDistribution = Convert.ToDecimal(dt.Rows[0]["Distribution"]); }
                    catch { }
                    try { OtherProportinate = Convert.ToDecimal(dt.Rows[0]["Proportinate"]); }
                    catch { }
                }
            }
            if (drv["ShareOwners_ID"] == null || drv["ShareOwners_ID"] == DBNull.Value)
            {
                pop.ShowPopup("Investor is required.");
                e.Valid = false;
            }
            else if (IsLessThanZero(drv["Responsibility"], true))
            {
                pop.ShowPopup("Responsibility can not be less than zero.");
                e.Valid = false;
            }
            else if (IsLessThanZero(drv["Distribution"], true))
            {
                pop.ShowPopup("Distribution can not be less than zero.");
                e.Valid = false;
            }
            else if (IsLessThanZero(drv["share_pct"], true))
            {
                pop.ShowPopup("Proportionate can not be less than zero.");
                e.Valid = false;
            }
            else if (drv["Supplier_ID"] == null || drv["Supplier_ID"] == DBNull.Value)
            {
                pop.ShowPopup("Supplier is required.");
                e.Valid = false;
            }
            else if (drv["Customer_ID"] == null || drv["Customer_ID"] == DBNull.Value)
            {
                pop.ShowPopup("Customer is required.");
                e.Valid = false;
            }
            else if (drv["GL_Subcode"] == null || drv["GL_Subcode"] == DBNull.Value)
            {
                pop.ShowPopup("GL Subcode is required.");
                e.Valid = false;
            }
            else if (IsPercentToLarge(drv["Responsibility"]))
            {
                pop.ShowPopup("Responsibility can not be greater than 100.");
                e.Valid = false;
            }
            else if (IsPercentToLarge(drv["Distribution"]))
            {
                pop.ShowPopup("Distribution can not be greater than 100.");
                e.Valid = false;
            }
            else if (IsPercentToLarge(drv["share_pct"]))
            {
                pop.ShowPopup("Proportionate can not be greater than 100.");
                e.Valid = false;
            }
            else if (IsSOUnique(drv))
            {
                pop.ShowPopup("Investor must be unique.");
                e.Valid = false;
            }
            else if (Convert.ToDecimal(drv["share_pct"]) + OtherProportinate > 100)
            {
                pop.ShowPopup("Total proportionate share can not be greater than 100.");
                e.Valid = false;
            }
            else if (Convert.ToDecimal(drv["Responsibility"]) + OtherResponsibility > 100)
            {
                pop.ShowPopup("Total responsibility can not be greater than 100.");
                e.Valid = false;
            }
            else if (Convert.ToDecimal(drv["Distribution"]) + OtherDistribution > 100)
            {
                pop.ShowPopup("Total distribution can not be greater than 100.");
                e.Valid = false;
            }
        }
        private bool IsSOUnique(DataRowView drv)
        {
            bool returnvalue = true;
            string sql = "select * from LD_Shares where pri_id = " + iPriID.ToString() + " and shareowners_id = " + drv["shareowners_id"].ToString() + " and shares_ID <> " + drv["shares_ID"].ToString();
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error checking if investor is unique:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    returnvalue = false;
                }
            }
            return returnvalue;
        }
        private void gvShares_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;   
        }
        private void riLUShareOwners_EditValueChanged(object sender, EventArgs e)
        {
            if (((LookUpEdit)sender).EditValue != null && ((LookUpEdit)sender).EditValue != DBNull.Value)
            {
                if (pop.ShowPopup("Would you like to load from setup?\r\nThis will clear any existing details.", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    ReloadDetails = true;
                    string sql = @"
select Responsibility, Distribution, share_pct, Supplier_ID, customer_id, GL_Subcode, 
LoanDrawAccount, LoanRepayAccount, SetupComplete 
from LD_Share_Owners where shareowners_id = " + ((LookUpEdit)sender).EditValue.ToString();
                    DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                        pop.ShowPopup("Error setting header default's:" + con.SQLExecutor.Exception.Message);
                    else if (dt.Rows.Count == 0)
                        pop.ShowPopup("No default's found ");
                    else
                    {
                        DataRow dr = gvShares.GetFocusedDataRow();
                        dr["customer_id"] = dt.Rows[0]["Customer_ID"];
                        gvShares.SetFocusedRowCellValue("Responsibility", dt.Rows[0]["Responsibility"]);
                        gvShares.SetFocusedRowCellValue("Distribution", dt.Rows[0]["Distribution"]);
                        gvShares.SetFocusedRowCellValue("SHARE_PCT", dt.Rows[0]["SHARE_PCT"]);
                        gvShares.SetFocusedRowCellValue("Supplier_ID", dt.Rows[0]["Supplier_ID"]);
                        //gvShares.SetFocusedRowCellValue("Customer_ID", dt.Rows[0]["Customer_ID"]);
                        gvShares.SetFocusedRowCellValue("GL_Subcode", dt.Rows[0]["GL_Subcode"]);
                        gvShares.SetFocusedRowCellValue("LoanDrawAccount", dt.Rows[0]["LoanDrawAccount"]);
                        gvShares.SetFocusedRowCellValue("LoanRepayAccount", dt.Rows[0]["LoanRepayAccount"]);
                        gvShares.SetFocusedRowCellValue("SetupComplete", dt.Rows[0]["SetupComplete"]);
                    }
                }
                else
                    ReloadDetails = false;
            }

        }
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.CancelEdit)
                ReloadDetails = false;
        }
        #endregion ShareOwners


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
        private bool IsPercentToLarge(object value)
        {
            bool returnValue = false;
            decimal dValue = 101;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue > 100)
                returnValue = true;

            return returnValue;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
