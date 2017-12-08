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

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucHolds : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private ucHoldAttachments Attachments;
        private ucHoldHistory History;
        private ucHoldPurchasers Purchasers;
        public HMCon Connection;
        private frmPopup Popup;
        private int _LotID = -1;
        private int _PriID = -1;
        private TUC_GridG.GridG gGrid;
        private bool _SendAlert = false;
        private bool _ReadOnly = false;
        private bool FocusedRowChanging = false;

        public ucHolds(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            RunSetups();            
        }

        #region Setups

        private void RunSetups()
        {
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            gGrid = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvLotHold, daLotHold, dsLotHold1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.IgnoreFieldList = new string[] { colShowExpired.FieldName,colhasComments.FieldName };
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGrid.AfterUpdate += new TUC_GridG.GridG.AfterUpdateDelegate(gGrid_AfterUpdate);

            DataTable dtPriority = new DataTable("dtPriority");
            dtPriority.Columns.Add("ID");
            dtPriority.Columns.Add("DESC");

            dtPriority.Rows.Add( new object[] { "P", "Primary" });
            dtPriority.Rows.Add(new object[] { "S", "Secondary" });

            ri_luePriority.DataSource = dtPriority;
            ri_luePriority.DisplayMember = "DESC";
            ri_luePriority.ValueMember = "ID";
            ri_luePriority.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESC", "Priority"));

            Attachments = new ucHoldAttachments(Connection, DevXMgr);
            Attachments.Dock = DockStyle.Fill;
            Attachments.Parent = dpAttachments;
            Attachments.HoldID = -1;

            History = new ucHoldHistory(Connection, DevXMgr);
            History.Dock = DockStyle.Fill;
            History.Parent = dpHistory;

            Purchasers = new ucHoldPurchasers(Connection, DevXMgr);
            Purchasers.Dock = DockStyle.Fill;
            Purchasers.Parent = dpPurchasers;
        }

        void gGrid_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            if (UType == TUC_GridG.UpdateType.Delete)
            {
                ceShowExpired_EditValueChanged(ceShowExpired, new EventArgs());
            }
        }


        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            string sSQL = @"if exists( select * from LD_Lot_Pair_Det where proj_lot_id="+_LotID+@" )
                    select 1
                else
                    select 0";
            if (Convert.ToBoolean(Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection)))
            {
                if (Popup.ShowPopup("Lot pairing exists for this lot, deleting this hold will remove the hold on the paired lots as well. Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    sSQL = @"declare @Lot_Pair_ID int
                        select @Lot_Pair_ID=lot_pair_id from LD_Lot_Pair_Det where proj_lot_id="+_LotID+@"

                        select h.hold_id
                        from proj_lot_hold h
                        join ld_lot_pair_det d on d.proj_lot_id=h.proj_lot_id
                        where d.lot_pair_id=@Lot_Pair_ID and h.start_date='"+row["start_date"]+@"' and h.end_date='"+row["end_date"]+@"' and h.purchaser_id="+row["purchaser_id"];
                    DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSQL, Connection.TRConnection);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            DeleteHold(dr);
                            try
                            {
                                if (Convert.ToInt32(dr["hold_id"]) != Convert.ToInt32(row["hold_id"]))
                                    Connection.SQLExecutor.ExecuteNonQuery(@"delete proj_lot_hold where hold_id=" + dr["hold_id"], Connection.TRConnection);
                            }
                            catch { }
                        }
                    }                    
                    return true;
                }
                else
                    return false;
            }





            if (row[colpriority.FieldName].ToString() == "P")
            {
                //see if another hold exists in the future.
                Object result = Connection.SQLExecutor.ExecuteScalar("select count(hold_id) from proj_lot_hold where proj_lot_id = " + _LotID + " and (GETDATE() <= start_date or GETDATE() between start_date and end_date ) and hold_id <> " + row[colhold_id.FieldName].ToString(), Connection.TRConnection);
                if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) > 0)
                    {
                        if (Popup.ShowPopup("Would you like to promote the next available secondary hold?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                        {
                            result = -1;
                            result = Connection.SQLExecutor.ExecuteScalar("select top 1 hold_id from proj_lot_hold where proj_lot_id = " + _LotID + " and GETDATE() between start_date and end_date order by start_date and hold_id <> " + row[colhold_id.FieldName].ToString(), Connection.TRConnection);
                            if (result == null || result == DBNull.Value)
                            {
                                Popup.ShowPopup("Today's date must be in the start / end date range.");
                                return true;
                            }
                            else
                            {
                                Connection.SQLExecutor.ExecuteNonQuery("update proj_lot_hold set priority = 'P' where hold_id =" + result.ToString(), Connection.TRConnection);
                                DeleteHold(row);
                                return true;
                            }

                        }
                    }
                }
            }
                
            



            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                DeleteHold(row);
                return true;
            }
            else
                return false;

        }

        private void DeleteHold(DataRow row)
        {
            string sSQL = @"declare @ProjLotID int = " + _LotID + @"
                    if( (select COUNT(*) from PROJ_LOT_HOLD where hold_id <> " + row["hold_id"].ToString() + @" and proj_lot_id = @ProjLotID and end_date >= GETDATE()) = 0 )
                    begin 
                        update proj_lot set lot_status_ID = 1, sub_status_ID = 1 where proj_lot_id = @ProjLotID
                    end";
            Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
            {
                Popup.ShowPopup("Error changing lot status" + Connection.SQLExecutor.Exception.Message);
            }

            sSQL = @"update WS_LotHoldRequest set route_status='X' where proj_lot_id=" + _LotID + @" and hold_id=" + row["hold_id"];
            Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);

            sSQL = @"declare @hold_id int, @contact_id int, @sql varchar(max), @ChatLink_Sub int
	            select @hold_id=" + row["hold_id"] + @", @contact_id="+Connection.ContactID+@"

	            if exists (select * from tempdb..sysobjects where id = object_id(N'tempdb..#ChatLink')) 
		            drop table #ChatLink 
            	
	            create table #ChatLink(LinkID int)

	            select @sql =
		            'delete #ChatLink
		            insert #ChatLink
		            exec sp_WS_ChatFieldLinkGetID ''WS_SUB_TASK_HDR.WS_ST_ID'', ''Tasks'''
	            exec(@sql)
	            select @ChatLink_Sub=LinkID from #ChatLink
            	
	            declare @ws_st_id int
            	
	            select @ws_st_id=isnull((select ws_st_id 
	            from WS_LotHoldRequest r
	            where r.hold_id=@hold_id),-1)
            	
                if( @ws_st_id <> -1 )
                begin
	                update ws_sub_task_hdr set status='D' where ws_st_id=@ws_st_id
            	
	                insert into WS_EVENT_HISTORY (DETAIL_ID, EVENT_DATE, CONTACT_ID, EVENT, NOTES, ST_TYPE_ID) 
	                select @ws_st_id, GETDATE(), @contact_id, 'Lot hold has been deleted.', '', 19
                end";
            Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
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
            gvLotHold.OptionsBehavior.Editable = !ReadOnly;
            meComment.Properties.ReadOnly = ReadOnly;
            Attachments.Readonly = ReadOnly;
            _ReadOnly = ReadOnly;
        }

        public void LoadLot(int LotID, int PriID)
        {
            _LotID = LotID;
            _PriID = PriID;
            LoadLotInfo();
            RefreshLookups();
            daLotHold.SelectCommand.Parameters["@PROJ_LOT_ID"].Value = LotID;
            ceShowExpired_EditValueChanged(ceShowExpired, new EventArgs());
            History.Proj_Lot_ID = LotID;
        }

        private void RefreshLookups()
        {
            dsLookups_Hold1.Clear();

            da_lueLotStatus.Fill(dsLookups_Hold1);
            da_lueLotSubStatus.Fill(dsLookups_Hold1);
            da_luePurchaser.Fill(dsLookups_Hold1);
            da_luePurchaserType.Fill(dsLookups_Hold1);
        }
        private void ucHolds_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void ceShowExpired_EditValueChanged(object sender, EventArgs e)
        {
            if (ceShowExpired.EditValue != null)
            {
                if (Convert.ToBoolean(ceShowExpired.EditValue) == false)
                {
                    gvLotHold.OptionsBehavior.Editable = !_ReadOnly;
                    ceShowExpired.EditValue = 0;
                }
                else
                    gvLotHold.OptionsBehavior.Editable = false;
                
            }
            daLotHold.SelectCommand.Parameters["@SHOW_EXPIRED"].Value = ceShowExpired.EditValue;
            daLotHold.UpdateCommand.Parameters["@SHOW_EXPIRED"].Value = ceShowExpired.EditValue;
            daLotHold.InsertCommand.Parameters["@SHOW_EXPIRED"].Value = ceShowExpired.EditValue;
            dsLotHold1.Clear();
            daLotHold.Fill(dsLotHold1);
        }

        private void gvLotHold_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvLotHold.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colConfirmed.FieldName] = false;
                row[colpri_id.FieldName] = _PriID;
                row[colproj_lot_id.FieldName] = _LotID;
                row[collot_status_id.FieldName] =  2;// Hold
                row[colusername.FieldName] = Connection.MLUser;
                row[coltrans_date.FieldName] = DateTime.Now.ToShortDateString();
                object obj = Connection.SQLExecutor.ExecuteScalar("select isnull(current_price,0) from PROJ_LOT where proj_lot_id = " + _LotID.ToString(), Connection.TRConnection);
                if( obj == null || obj == DBNull.Value )
                    obj = 0;
                row[colprice_quoted.FieldName] = obj;
            }
        }

        private void gvLotHold_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvLotHold_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            DataRowView DRV = (DataRowView)e.Row;
            object oPriority = DRV.Row["priority"];

            object result = Connection.SQLExecutor.ExecuteScalar("select COUNT(*) from PROJ_LOT_AGREEMENT where proj_lot_id = " + _LotID.ToString() + " and agreement_status_id <> 2", Connection.TRConnection);
            if (result != DBNull.Value && result != null)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    Popup.ShowPopup("Holds can not be added or modified after an agreement has been created.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }

            }

            if( (ErrorMessage = ValidateColumnsRequired( (DataRowView)e.Row,new DevExpress.XtraGrid.Columns.GridColumn[]{
            colpriority,colstart_date,colend_date,colsub_status_id,colpurchaser_type_id,colpurchaser_id},false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (oPriority.Equals("P"))
            {
                if (HasPrimary((DataRowView)e.Row))
                {
                    Popup.ShowPopup("There can only be one primary.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }
            }
            else
            {
                if (!HasPrimary((DataRowView)e.Row))
                {
                    Popup.ShowPopup("There must be at least one primary hold to add a secondary hold.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }
            }
            
            if (Convert.ToDateTime(((DataRowView)e.Row)[colstart_date.FieldName]).CompareTo(Convert.ToDateTime(((DataRowView)e.Row)[colend_date.FieldName])) > 0)
            {
                Popup.ShowPopup("Start date must be less then or equal to end date.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if(!isGreaterThenZero(((DataRowView)e.Row)[colprice_quoted.FieldName],false))
            {
                Popup.ShowPopup("Price Quoted must be greater than zero.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }
            else if (Convert.ToDecimal(((DataRowView)e.Row)[colprice_quoted.FieldName]) > 922337203685477)
            {
                Popup.ShowPopup("Price Quoted is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }


            DateTime dtStart = Convert.ToDateTime(DRV.Row["start_date"]);
            DateTime dtEnd = Convert.ToDateTime(DRV.Row["end_date"]);
            if (oPriority.Equals("P"))
            {
                if (dtStart > DateTime.Now || dtEnd < DateTime.Today)
                {
                    Popup.ShowPopup("Today's date must be in the start / end date range.");
                    e.ErrorText = "DeveloperThrownError";
                    e.Valid = false;
                    return;
                }
            }

            string sSelect = "declare @start datetime, @end datetime "+
                "select @start = '" + dtStart.ToShortDateString() + "', @end = '" + dtEnd .ToShortDateString()+ "' " +
                "select COUNT(*) from PROJ_LOT_HOLD "+
                "where "+
                "((@start BETWEEN start_date AND end_date) or (start_date BETWEEN @start and @end)) "+
                "and proj_lot_id=" +_LotID + " and hold_id <> "+DRV.Row["hold_id"];
            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
            {
                Popup.ShowPopup("The hold's date range cannot overlap any other hold's date range.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
                return;
            }

            if (e.Valid)
            {
                _SendAlert = false;
                sSelect = "select count(*) from proj_lot where proj_lot_id="+_LotID+" and lot_status=2 and sub_status_id="+DRV.Row["sub_status_id"];
                if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) == 0)
                {
                    int iPurchaserID = -1;
                    try { iPurchaserID = Convert.ToInt32(DRV.Row["purchaser_id"]); }
                    catch { }
                    string sPhone = "";
                    try { sPhone = DRV.Row["phone_num"].ToString(); }
                    catch { }

                    string sUpdate = @"Insert Into PROJ_LOT_STATUS_HISTORY(proj_lot_id, change_date, lot_status_id, sub_status_id, purchaser_id, price_quoted, end_date, phone_num,
									username, comments)
Select l.proj_lot_id, GETDATE(), l.lot_status_id, l.sub_status_id, " + iPurchaserID.ToString() + @", l.current_price, '" + dtEnd.ToShortDateString() + @"', '" + sPhone + @"', 
(select FULL_NAME from mluser where name = '" + Connection.MLUser + @"'), null From Proj_Lot l where proj_lot_id = " + _LotID.ToString() + " " + 
                        " update proj_lot set lot_status_id=2, sub_status_id=" + DRV.Row["sub_status_id"] + " where proj_lot_id=" + _LotID.ToString();
                    Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);
                    _SendAlert = true;
                    
                }
                // OR need to check if record was secondary now being set to primary
                try
                {
                    object oOrigPriority = DRV.Row["priority", DataRowVersion.Original];
                    object oNewPriority = DRV.Row["priority", DataRowVersion.Proposed];
                    if (!oOrigPriority.Equals(oNewPriority) && oNewPriority.Equals("P"))
                    {
                        _SendAlert = true;
                    }
                }catch{}                 
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
			

        private bool HasPrimary(DataRowView rv)
        {
            bool returnValue = false;
            string sql = "select count(hold_id) from PROJ_LOT_HOLD where priority = 'P' and " +
                "proj_lot_id = " + _LotID + " and pri_id = " + _PriID + " and hold_id <> " + rv[colhold_id.FieldName].ToString() +
" and cast(GETDATE()as date) between start_date and end_date ";
            object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
            {
                Popup.ShowPopup("Error checking for duplicate primary." + Connection.SQLExecutor.Exception.Message);
            }
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) != 0)
                    returnValue = true;
            }
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
        


        private void ri_lueLotSubStatus_Enter(object sender, EventArgs e)
        {
            DataRow row = gvLotHold.GetDataRow(gvLotHold.FocusedRowHandle);
            if (row != null)
            {
                if (sender is LookUpEdit)
                {
                    if (row[collot_status_id.FieldName] != DBNull.Value)
                    {
                        
                        bs_lueLotSubStatus_Restricted.Filter = "LD_Lot_Status_ID = " + row[collot_status_id.FieldName].ToString();
                        ((LookUpEdit)sender).Properties.DataSource = bs_lueLotSubStatus_Restricted;
                    }
                    else
                        ((LookUpEdit)sender).Properties.DataSource = null;
                }
            }
        }

        private void ri_luePurchaser_Enter(object sender, EventArgs e)
        {
            DataRow row = gvLotHold.GetDataRow(gvLotHold.FocusedRowHandle);
            if (row != null)
            {
                if (sender is LookUpEdit)
                {
                    if (row[colpurchaser_type_id.FieldName] != DBNull.Value)
                    {

                        bs_luePurchaser_Restricted.Filter = "PURCHASER_TYPE_ID = " + row[colpurchaser_type_id.FieldName].ToString() + " and ACTIVE = 'T'";
                        ((LookUpEdit)sender).Properties.DataSource = bs_luePurchaser_Restricted;
                    }
                    else
                        ((LookUpEdit)sender).Properties.DataSource = null;
                }
            }
        }

        private void ri_luePurchaserType_EditValueChanged(object sender, EventArgs e)
        {
            gvLotHold.SetFocusedRowCellValue(colpurchaser_id, DBNull.Value);
        }

        private void ri_luePurchaser_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue != null)
            {
                object obj = lue.EditValue;
                if (obj != null && obj != DBNull.Value)
                {
                    object purch_type = lue.GetColumnValue("PURCHASER_TYPE_ID");
                    gvLotHold.SetFocusedRowCellValue(colpurchaser_type_id, purch_type);

                    string sSelect = "select ISNULL(TELEPHONE,'') from customers where CUSTOMER_ID="+obj;
                    obj = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
                    gvLotHold.SetFocusedRowCellValue(colphone_num, obj);
                }
                else
                {
                    gvLotHold.SetFocusedRowCellValue(colpurchaser_type_id, DBNull.Value);
                }
            }
        }

        private void ucHolds_Leave(object sender, EventArgs e)
        {
            if (gvLotHold.FocusedRowHandle >= 0)
                gGrid.SaveRecord(gvLotHold.FocusedRowHandle);
        }

        private void gvLotHold_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daLotHold.Update(dsLotHold1);
            DataRow dr = gvLotHold.GetDataRow(gvLotHold.FocusedRowHandle);
            if (dr != null)
            {
                //SEND ALERT THAT LOT HAS BEEN PUT ON HOLD
                if (_SendAlert)
                {
                    string sSQL = "exec PC_LandLotOnHoldAlert '" + Connection.MLUser + "', " + dr["hold_id"];
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);

                    _SendAlert = false;
                }
                
                object oHoldID = dr["hold_id"];
                if (oHoldID != null && oHoldID != DBNull.Value)
                {
                    Attachments.HoldID = (int)oHoldID;
                }
            }                
        }

        private void gvLotHold_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colcomments)
            {
                bool isChecked = false;
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    if (e.Value.ToString().Trim() != "")
                    {
                        isChecked = true;
                    }
                }
                gvLotHold.SetRowCellValue(e.RowHandle, colhasComments, isChecked);

            }
        }

        private void gvLotHold_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FocusedRowChanging = true;
            Attachments.HoldID = -1;
            Purchasers.HoldID = -1;
            DataRow dr = gvLotHold.GetDataRow(gvLotHold.FocusedRowHandle);
            if (dr != null)
            {
                object oHoldID = dr["hold_id"];
                if (oHoldID != null && oHoldID != DBNull.Value)
                {
                    Attachments.HoldID = (int)oHoldID;
                    Purchasers.HoldID = (int)oHoldID;
                }
            }
            FocusedRowChanging = false;
        }

        private void meComment_EditValueChanged(object sender, EventArgs e)
        {
            if (FocusedRowChanging)//prevents row going into edit mode when changing focused rows.
                return;
            int iHandle = gvLotHold.FocusedRowHandle;
            if (iHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || iHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle || iHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                return;
            if (gvLotHold.RowCount > 0)
            {
                if (((MemoEdit)sender).Text.Trim() != "")
                    gvLotHold.SetFocusedRowCellValue(colhasComments, true);
                else
                    gvLotHold.SetFocusedRowCellValue(colhasComments, false);
            }
        }

        private void gcLotHold_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
           
        }

        private void ri_luePurchaser_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            DataRow row = gvLotHold.GetDataRow(gvLotHold.FocusedRowHandle);
            if (row != null)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
                {
                    if (row[colpurchaser_type_id.FieldName] != DBNull.Value && row[colpurchaser_type_id.FieldName] != null)
                    {
                        using (LD_PurchaserMaster.frmPurchaserSelect frm = new LD_PurchaserMaster.frmPurchaserSelect(Connection, DevXMgr, Convert.ToInt32(row[colpurchaser_type_id.FieldName])))
                        {
                            DialogResult result = frm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                da_luePurchaser.Fill(dsLookups_Hold1);
                                ((LookUpEdit)sender).EditValue = frm.Purchaser_ID;
                                //row[colpurchaser_id.FieldName] = frm.Purchaser_ID;
                            }
                        }
                    }
                    else
                        Popup.ShowPopup("You must select a purchaser type.");
                }
            }
        }

       
    }
}
