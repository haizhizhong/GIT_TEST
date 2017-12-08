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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ProjectUtilities.Land.Processing
{
    public partial class ucLOC : DevExpress.XtraEditors.XtraUserControl
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;
        private ComboSearch.Util CBOUtil;
        private Rectangle dragBox;

        public ucLOC(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            CBOUtil = new ComboSearch.Util(DevXMgr);
            Popup = new frmPopup(DevXMgr);
            InitializeComponent();
            RunSetups();
        }

        private void RunSetups()
        {
            TR_Conn.ConnectionString = Connection.TRConnection;
            hlRefresh_Click(null, null);
        }

        #region Search Functionality

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool bFieldsEmpty = true;

            if (deStartDate.EditValue != DBNull.Value && deStartDate.EditValue != null &&
                deToStartDate.EditValue != DBNull.Value && deToStartDate.EditValue != null)
            {
                if (deStartDate.DateTime.CompareTo(deToStartDate.DateTime) == 1)
                {
                    Popup.ShowPopup("From start date cannot be greater than to start date.");
                    return;
                }
            }

            if (deFromExpiryDate.EditValue != DBNull.Value && deFromExpiryDate.EditValue != null &&
                deExpiryDate.EditValue != DBNull.Value && deExpiryDate.EditValue != null)
            {
                if (deFromExpiryDate.DateTime.CompareTo(deExpiryDate.DateTime) == 1)
                {
                    Popup.ShowPopup("From expiry date cannot be greater than to expiry date.");
                    return;
                }
            }

            if (deEstRel_From.EditValue != DBNull.Value && deEstRel_From.EditValue != null &&
                deEstRel_To.EditValue != DBNull.Value && deEstRel_To.EditValue != null)
            {
                if (deEstRel_From.DateTime.CompareTo(deEstRel_To.DateTime) == 1)
                {
                    Popup.ShowPopup("From estimated release date cannot be greater than to estimated release date.");
                    return;
                }
            }

            if (deActRel_From.EditValue != DBNull.Value && deActRel_From.EditValue != null &&
                deActRel_To.EditValue != DBNull.Value && deActRel_To.EditValue != null)
            {
                if (deActRel_From.DateTime.CompareTo(deActRel_To.DateTime) == 1)
                {
                    Popup.ShowPopup("From actual release date cannot be greater than to actual release date.");
                    return;
                }
            }

            if (luePurchaser.EditValue != null && luePurchaser.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@purchaser_id"].Value = luePurchaser.EditValue;
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@purchaser_id"].Value = DBNull.Value;
            }

            if (!txtRef.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@ref"].Value = txtRef.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@ref"].Value = DBNull.Value;
            }

            if (!deExpiryDate.Text.Trim().Equals("")) //To Expiry Date
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_to_expiry"].Value = deExpiryDate.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_to_expiry"].Value = DBNull.Value;
            }

            if (!deFromExpiryDate.Text.Trim().Equals("")) // From Expiry Date
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_from_expiry"].Value = deFromExpiryDate.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_from_expiry"].Value = DBNull.Value;
            }

            if (!deStartDate.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_from_start_date"].Value = deStartDate.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_from_start_date"].Value = DBNull.Value;
            }

            if (!deToStartDate.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_to_start_date"].Value = deToStartDate.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_to_start_date"].Value = DBNull.Value;
            }

            if (!deEstRel_From.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_from_Est_Rel_date"].Value = deEstRel_From.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_from_Est_Rel_date"].Value = DBNull.Value;
            }

            if (!deEstRel_To.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_to_Est_Rel_date"].Value = deEstRel_To.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_to_Est_Rel_date"].Value = DBNull.Value;
            }
            if (!deActRel_From.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_from_Act_Rel_date"].Value = deActRel_From.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_from_Act_Rel_date"].Value = DBNull.Value;
            }

            if (!deActRel_To.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@loc_to_Act_Rel_date"].Value = deActRel_To.DateTime.ToShortDateString();
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@loc_to_Act_Rel_date"].Value = DBNull.Value;
            }








            if (lueLender.EditValue != null && lueLender.EditValue != DBNull.Value)
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@lender_id"].Value = lueLender.EditValue;
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@lender_id"].Value = DBNull.Value;
            }

            if (!cboProjNo.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@pri_code"].Value = cboProjNo.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@pri_code"].Value = DBNull.Value;
            }

            if (!cboProjName.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@pri_name"].Value = cboProjName.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@pri_name"].Value = DBNull.Value;
            }

            if (!cboLot.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@lot_num"].Value = cboLot.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@lot_num"].Value = DBNull.Value;
            }

            if (!cboBlock.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@block_num"].Value = cboBlock.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@block_num"].Value = DBNull.Value;
            }

            if (!cboPlan.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daLOCSearch.SelectCommand.Parameters["@plan_num"].Value = cboPlan.Text.Replace("'", "''");
            }
            else
            {
                daLOCSearch.SelectCommand.Parameters["@plan_num"].Value = DBNull.Value;
            }


            if (bFieldsEmpty)
            {
                if (Popup.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    CL_Dialog.PleaseWait.Show("Loading Search...", null);
                    dsLOCSearch.Clear();
                    daLOCSearch.Fill(dsLOCSearch);
                    gvSearch_FocusedRowChanged(null, null);
                    CL_Dialog.PleaseWait.Hide();
                }
            }
            else
            {
                CL_Dialog.PleaseWait.Show("Loading Search...", null);
                dsLOCSearch.Clear();
                daLOCSearch.Fill(dsLOCSearch);
                gvSearch_FocusedRowChanged(null, null);
                CL_Dialog.PleaseWait.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            luePurchaser.EditValue = null;
            txtRef.EditValue = null;
            deFromExpiryDate.EditValue = null;
            deExpiryDate.EditValue = null;
            deStartDate.EditValue = null;
            deToStartDate.EditValue = null;
            lueLender.EditValue = null;
            cboBlock.EditValue = null;
            cboLot.EditValue = null;
            cboPlan.EditValue = null;
            cboProjName.EditValue = null;
            cboProjNo.EditValue = null;
            deEstRel_From.EditValue = null;
            deEstRel_To.EditValue = null;
            deActRel_From.EditValue = null;
            deActRel_To.EditValue = null;

        }

        private void cboProjNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, true,
                    "select distinct pri_code from proj_header where pri_type = 'PLC' order by pri_code");
            }
        }

        private void cboProjName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct pri_name from proj_header where pri_type = 'PLC' order by pri_name");
            }	
        }

        private void cboLot_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct lot_num from proj_lot order by lot_num");
            }
        }

        private void cboBlock_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct block_num from proj_lot order by block_num");
            }	
        }

        private void cboPlan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Down)
            {
                CBOUtil.loadDropDown(sender as DevExpress.XtraEditors.ComboBoxEdit, Connection, false,
                    "select distinct plan_num from proj_lot order by plan_num");
            }
        }

        #endregion

        private void hlRefresh_Click(object sender, EventArgs e)
        {
            dsLOCLookups.Clear();            
            daLOCLookups.Fill(dsLOCLookups);
            daPurchasers.Fill(dsLOCLookups);
            dsPurchaser.Clear();
            daPurchaser.Fill(dsPurchaser);

            dsLOCLookups.Tables["LD_Communities"].Rows.Add(new object[] { -1, "N/A" });
            daCommunity.Fill(dsLOCLookups);
            dsLOCLookups.Tables["PROJ_HEADER"].Rows.Add(new object[] { -1, DBNull.Value, "All Projects" });
            daProjects.Fill(dsLOCLookups);            
        }        

        private void hlNew_Click(object sender, EventArgs e)
        {
            gvSearch.AddNewRow();
            gvSearch.Focus();
            gvSearch.FocusedColumn = colPurchaser;
        }

        private void hlEdit_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        #region GV_Search

        private void gvSearch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsLOCDet.Clear();
            dsLotSelect.Clear();
            dsLotSubDet.Clear();
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oLOC_ID = dr["LOC_ID"];
                if (oLOC_ID != null && oLOC_ID != DBNull.Value)
                {
                    if (daLOCDet.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daLOCDet.SelectCommand.Parameters["@LOC_ID"].Value = oLOC_ID;
                        daLOCDet.Fill(dsLOCDet);
                        gvDet_FocusedRowChanged(gvDet, 
                            new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(gvDet.FocusedRowHandle, gvDet.FocusedRowHandle));
                    }
                }
            }
        }

        private void gcSearch_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete this letter of credit?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["LOC_ID"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from LD_LOC_Hdr where LOC_ID=" + oID + " " +
                                "delete from LD_LOC_Det where LOC_ID=" + oID + " " +
                                "delete from LD_LOC_SubDet where LOC_ID=" + oID;
                            Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void gvSearch_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["LOC_ID"] = 0;
            }
        }

        private void gvSearch_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;		
        }

        private void gvSearch_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView drv = e.Row as DataRowView;
            if (drv != null)
            {
                DataRow dr = drv.Row;
                if (dr != null)
                {
                    bool bNew = false;
                    if (dr.RowState == DataRowState.Added)
                        bNew = true;
                    SqlCommand cmd = new SqlCommand("PC_LOC_IU @LOC_ID, @purchaser_id, @ref, @amt, @start, @expiry, @lender_id,@EstRelDate ,@ActRelDate,@Comments ", new SqlConnection(Connection.TRConnection));

                    object oLOC_ID = dr["LOC_ID"];
                    if (oLOC_ID == null || oLOC_ID.Equals(0))
                        oLOC_ID = DBNull.Value;

                    cmd.Parameters.Add("@LOC_ID", SqlDbType.Int);
                    cmd.Parameters["@LOC_ID"].Value = oLOC_ID;
                    cmd.Parameters.Add("@purchaser_id", SqlDbType.Int);
                    cmd.Parameters["@purchaser_id"].Value = dr["purchaser_id"];
                    cmd.Parameters.Add("@ref", SqlDbType.VarChar);
                    cmd.Parameters["@ref"].Value = dr["loc_reference"];
                    cmd.Parameters.Add("@amt", SqlDbType.Money);
                    cmd.Parameters["@amt"].Value = dr["loc_amount"];
                    cmd.Parameters.Add("@start", SqlDbType.DateTime);
                    cmd.Parameters["@start"].Value = dr["loc_start"];
                    cmd.Parameters.Add("@expiry", SqlDbType.DateTime);
                    cmd.Parameters["@expiry"].Value = dr["loc_expiry"];
                    cmd.Parameters.Add("@lender_id", SqlDbType.Int);
                    cmd.Parameters["@lender_id"].Value = dr["lender_id"];
                    cmd.Parameters.Add("@EstRelDate", SqlDbType.DateTime);
                    cmd.Parameters["@EstRelDate"].Value = dr["EstimatedReleaseDate"];
                    cmd.Parameters.Add("@ActRelDate", SqlDbType.DateTime);
                    cmd.Parameters["@ActRelDate"].Value = dr["ActualReleaseDate"];
                    cmd.Parameters.Add("@Comments", SqlDbType.VarChar);
                    cmd.Parameters["@Comments"].Value = dr["Comments"];

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    try
                    {
                        da.Fill(dt);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtdr = dt.Rows[0];
                                if (dtdr != null)
                                {
                                    dr.BeginEdit();
                                    dr["LOC_ID"] = dtdr["LOC_ID"];
                                    dr.AcceptChanges();
                                }
                            }
                        }
                    }
                    catch (SqlException)
                    {
                        Popup.ShowPopup("Error saving record.");
                    }
                    finally
                    {
                        if (cmd.Connection.State == System.Data.ConnectionState.Open)
                            cmd.Connection.Close();
                        cmd.Connection.Dispose();
                        cmd.Dispose();
                        da.Dispose();
                    }

                    if (bNew)
                    {
                        gvSearch_FocusedRowChanged(null, null);
                        //hlEdit_Click(hlEdit, new EventArgs());
                    }
                }
            }
        }

        private void gvSearch_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                object oPurchID = dr["purchaser_id"];
                if (oPurchID == null || oPurchID == DBNull.Value)
                {
                    e.ErrorText = "Purchaser is required.";
                    gvSearch.FocusedColumn = colPurchaser;
                    e.Valid = false;
                    return;
                }

                object oRef = dr["loc_reference"];
                if (oRef == null || oRef == DBNull.Value)
                {
                    e.ErrorText = "Reference is required.";
                    gvSearch.FocusedColumn = colRef;
                    e.Valid = false;
                    return;
                }
                else if (oRef.ToString().Trim().Equals(""))
                {
                    e.ErrorText = "Reference is required.";
                    gvSearch.FocusedColumn = colRef;
                    e.Valid = false;
                    return;
                }

                object oAmt = dr["loc_amount"];
                if (oAmt == null || oAmt == DBNull.Value)
                {
                    e.ErrorText = "Amount must be greater than zero.";
                    gvSearch.FocusedColumn = colAmount;
                    e.Valid = false;
                    return;
                }
                else if (Convert.ToDouble(oAmt) <= 0)
                {
                    e.ErrorText = "Amount must be greater than zero.";
                    gvSearch.FocusedColumn = colAmount;
                    e.Valid = false;
                    return;
                }

                object oStart = dr["loc_start"];
                if (oStart == null || oStart == DBNull.Value)
                {
                    e.ErrorText = "Start date is required.";
                    gvSearch.FocusedColumn = colStart;
                    e.Valid = false;
                    return;
                }

                object oExpiry = dr["loc_expiry"];
                if (oExpiry == null || oExpiry == DBNull.Value)
                {
                    e.ErrorText = "Expiry date is required.";
                    gvSearch.FocusedColumn = colExpiry;
                    e.Valid = false;
                    return;
                }

                if (Convert.ToDateTime(oExpiry) < Convert.ToDateTime(oStart))
                {
                    e.ErrorText = "Expiry date must be greater than or equal to start date.";
                    gvSearch.FocusedColumn = colExpiry;
                    e.Valid = false;
                    return;
                }

                object oLender = dr["lender_id"];
                if (oLender == null || oLender == DBNull.Value)
                {
                    e.ErrorText = "Financial lender is required.";
                    gvSearch.FocusedColumn = colLender;
                    e.Valid = false;
                    return;
                }
            }
        }

        #endregion

        #region GV_Det

        private void gvDet_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;		
        }

        private void gvDet_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                object oComm = dr["communities_id"];
                if (oComm == null || oComm == DBNull.Value)
                {
                    e.ErrorText = "Community is required.";
                    gvSearch.FocusedColumn = colcommunities_id;
                    e.Valid = false;
                    return;
                }

                object oPriID = dr["pri_id"];
                if (oPriID == null || oPriID == DBNull.Value)
                {
                    e.ErrorText = "Project is required.";
                    gvSearch.FocusedColumn = colpri_id;
                    e.Valid = false;
                    return;
                }
            }
        }

        private void gvDet_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daLOCDet.Update(dsLOCDet);
            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                object oID = dr["id"];
                if (oID != null && oID != DBNull.Value)
                {
                    string sSQL = "exec PC_LOC_ClearInactiveLots "+oID;
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);

                    if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from ld_loc_subdet where loc_det_id=" + oID, Connection.TRConnection)) == 0)
                        SetAllLots("T", oID);
                }
            }
            gvDet_FocusedRowChanged(null, null);
        }

        private void gcDet_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (gvSearch.RowCount <= 0)
                {
                    Popup.ShowPopup("Select or create a new letter of credit before adding details.");
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (e.Button.ButtonType == NavigatorButtonType.Remove)
                {
                    if (Popup.ShowPopup("Are you sure you want to delete this record?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                    {
                        DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
                        if (dr != null)
                        {
                            object oID = dr["id"];
                            if (oID != null && oID != DBNull.Value)
                            {
                                string sDelete = "delete from LD_LOC_Det where id=" + oID + " " +
                                    "delete from LD_LOC_SubDet where LOC_DET_ID=" + oID;
                                Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);
                            }
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void gvDet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gvDet.FocusedColumn = colcommunities_id;
            dsProjComm.Clear();       
            dsLotSelect.Clear();
            dsSClassSelect.Clear();
            dsLotSubDet.Clear();
            dsLotSubClass.Clear();
            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                object oID = dr["id"];
                if (oID != null && oID != DBNull.Value)
                {
                    if (daLotSelect.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daLotSelect.SelectCommand.Parameters["@LOC_DET_ID"].Value = oID;
                        daLotSelect.Fill(dsLotSelect);
                        gvLots.ExpandAllGroups();
                    }
                    if (daSClassSelect.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daSClassSelect.SelectCommand.Parameters["@LOC_DET_ID"].Value = oID;
                        daSClassSelect.Fill(dsSClassSelect);
                    }
                    if (daLotSubDet.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daLotSubDet.SelectCommand.Parameters["@LOT_DET_ID"].Value = oID;
                        daLotSubDet.Fill(dsLotSubDet);
                        gvSubDet.ExpandAllGroups();
                    }
                    if (daLotSubClass.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daLotSubClass.SelectCommand.Parameters["@LOT_DET_ID"].Value = oID;
                        daLotSubClass.Fill(dsLotSubClass);
                    }
                }

                object oComm = dr["communities_id"];
                FillProjComm(oComm);
            }
        }

        private void riCommunity_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvDet.SetFocusedRowCellValue("pri_id", DBNull.Value);
            FillProjComm(e.NewValue);            
        }

        private void FillProjComm(object oComm)
        {
            dsProjComm.Clear();

            if (oComm == null)
                oComm = DBNull.Value;
            if (oComm != null && oComm != DBNull.Value)
            {
                if( Convert.ToInt32( oComm ) > 0 )
                    dsProjComm.Tables["LD_LOC_Projects"].Rows.Add(new object[] { -1, DBNull.Value, "All Projects" });
            }

            if (daProjComm.SelectCommand.Connection.State == ConnectionState.Closed)
            {

                daProjComm.SelectCommand.Parameters["@comm_id"].Value = oComm;
                daProjComm.Fill(dsProjComm);
            }            
        }

        private void gvDet_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["all_lots"] = "T";
                dr["all_sub_classes"] = "T";
                dr["LOC_ID"] = gvSearch.GetFocusedRowCellValue("LOC_ID");
                gvSearch.FocusedColumn = colcommunities_id;
            }
        }

        private void gvDet_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colpri_id)
            {
                if (e.RowHandle == gvDet.FocusedRowHandle)
                {
                    e.RepositoryItem = riProjComm;
                }
                else
                {
                    e.RepositoryItem = riProj;
                }                
            }
            else if (e.Column == colProjName)
            {
                if (e.RowHandle == gvDet.FocusedRowHandle)
                {
                    e.RepositoryItem = riProjNameComm;
                }
                else
                {
                    e.RepositoryItem = riProjName;
                }
            }
        }

        #endregion

        #region Drag_Drop

        private void gcSubDet_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(object[])))
            {
                object[] oDrop = (object[])e.Data.GetData(typeof(object[]));
                if (oDrop != null)
                {
                    if (oDrop[0].ToString() == "Lot")
                    {
                        int[] iRows = oDrop[1] as int[];
                        DataRow dr = null;
                        string sSelect = "";
                        for (int i = 0; i < iRows.Length; i++)
                        {
                            dr = gvLots.GetDataRow(iRows[i]);
                            sSelect = "select count(*) from LD_LOC_SubDet where proj_lot_id=" + dr["proj_lot_id"] + " and LOC_DET_ID=" + dr["LOC_DET_ID"];
                            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) == 0)
                            {   
                                sSelect = "select p.lot_num, p.block_num, p.plan_num, c.Description [Class], s.Description [Sub_Class], h.pri_code, h.pri_name " +
                                    "from proj_lot p " +
                                    "join proj_header h on h.pri_id=p.pri_id "+
                                    "left outer join LD_Lot_Class c on c.Lot_Class_ID=p.lot_class_id " +
                                    "left outer join LD_Lot_Sub_Class s on s.Lot_Sub_Class_ID=p.lot_sub_class_id " +
                                    "where p.proj_lot_id=" + dr["proj_lot_id"];
                                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
                                if (dt != null)
                                {
                                    if (dt.Rows.Count > 0)
                                    {
                                        DataRow dr1 = dt.Rows[0];
                                        if (dr1 != null)
                                        {
                                            object oLOC_ID = gvDet.GetFocusedRowCellValue("LOC_ID");
                                            string sInsert = "insert into LD_LOC_SubDet (LOC_ID, LOC_DET_ID, proj_lot_id) select " + oLOC_ID+ ", "+ dr["LOC_DET_ID"] + ", " + dr["proj_lot_id"] + " select @@identity";
                                            object oID = Connection.SQLExecutor.ExecuteScalar(sInsert, Connection.TRConnection);
                                            dsLotSubDet.Tables[0].Rows.Add(new object[] { oID, dr["proj_lot_id"], dr1["lot_num"], dr1["block_num"], dr1["plan_num"], dr1["Class"], dr1["Sub_Class"], dr["pri_code"], dr["pri_name"] });
                                            SetAllLots("F", dr["LOC_DET_ID"]);
                                        }
                                    }
                                }
                                                               
                            }
                        }
                    }
                    gvSubDet.ExpandAllGroups();
                }
            }
        }

        private void SetAllLots(string AllLots, object LOT_DET_ID)
        {
            string sUpdate = "update LD_LOC_Det set all_lots='"+AllLots+"' where id=" + LOT_DET_ID;
            Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);

            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["all_lots"] = AllLots;
                dr.EndEdit();
                dr.AcceptChanges();
            }            
        }

        private void gcSubDet_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void gcSubDet_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (gvSubDet.FocusedRowHandle < 0)
                {
                    Popup.ShowPopup("Unable to delete a group row, please select a detail row.");
                    e.Handled = true;
                    return;
                }
                if (Popup.ShowPopup("Are you sure you want to remove this lot?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvSubDet.GetDataRow(gvSubDet.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["id"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from LD_LOC_SubDet where id=" + oID;
                            Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);

                            object oLOC_DET_ID = gvDet.GetFocusedRowCellValue("id");
                            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from ld_loc_subdet where loc_det_id=" + oLOC_DET_ID, Connection.TRConnection)) == 0)
                                SetAllLots("T", oLOC_DET_ID);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void gcLots_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = gvLots.CalcHitInfo(e.X, e.Y);
            if (hitInfo.InRow)
            {
                Size dragSize = SystemInformation.DragSize;
                this.dragBox = new Rectangle(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height);
            }
        }

        private void gcLots_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            if (dragBox != Rectangle.Empty && !dragBox.Contains(pt))
            {
                DoLotDrag();
                dragBox = Rectangle.Empty;
            }
        }

        private void DoLotDrag()
        {
            if (gvLots.RowCount > 0)
            {
                int[] iRows = gvLots.GetSelectedRows();
                if (iRows != null)
                {
                    gvLots.GridControl.DoDragDrop(new object[] { "Lot", iRows }, DragDropEffects.All);
                }
            }
        }


        //SUB CLASSES DRAG DROP
        private void gcSelSubClasses_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(object[])))
            {
                object[] oDrop = (object[])e.Data.GetData(typeof(object[]));
                if (oDrop != null)
                {
                    if (oDrop[0].ToString() == "SubClass")
                    {
                        int[] iRows = oDrop[1] as int[];
                        DataRow dr = null;
                        string sSelect = "";
                        for (int i = 0; i < iRows.Length; i++)
                        {
                            dr = gvSubClasses.GetDataRow(iRows[i]);
                            sSelect = "select count(*) from LD_LOC_SubClass where Lot_Sub_Class_ID=" + dr["Lot_Sub_Class_ID"] + " and LOC_DET_ID=" + dr["LOC_DET_ID"];
                            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) == 0)
                            {
                                sSelect = "select c.Description [Class], s.Description [SubClass] "+
                                    "from LD_Lot_Sub_Class s "+
                                    "join LD_Lot_Class c on c.Lot_Class_ID=s.LD_Lot_Class_ID "+
                                    "where s.Lot_Sub_Class_ID=" + dr["Lot_Sub_Class_ID"];
                                DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
                                if (dt != null)
                                {
                                    if (dt.Rows.Count > 0)
                                    {
                                        DataRow dr1 = dt.Rows[0];
                                        if (dr1 != null)
                                        {
                                            object oLOC_ID = gvDet.GetFocusedRowCellValue("LOC_ID");
                                            string sInsert = "insert into LD_LOC_SubClass (LOC_ID, LOC_DET_ID, Lot_Sub_Class_ID) select " + oLOC_ID + ", " + dr["LOC_DET_ID"] + ", " + dr["Lot_Sub_Class_ID"] + " select @@identity";
                                            object oID = Connection.SQLExecutor.ExecuteScalar(sInsert, Connection.TRConnection);
                                            dsLotSubClass.Tables[0].Rows.Add(new object[] { oID, dr["LOC_DET_ID"], dr1["Class"], dr1["SubClass"] });
                                            SetAllSubClasses("F", dr["LOC_DET_ID"]);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }

        private void SetAllSubClasses(string AllSubClass, object LOT_DET_ID)
        {
            string sUpdate = "update LD_LOC_Det set all_sub_classes='" + AllSubClass + "' where id=" + LOT_DET_ID;
            Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);

            DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
            if (dr != null)
            {
                dr.BeginEdit();
                dr["all_sub_classes"] = AllSubClass;
                dr.EndEdit();
                dr.AcceptChanges();
            }
        }

        private void gcSelSubClasses_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void gcSelSubClasses_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (gvSelSubClasses.FocusedRowHandle < 0)
                {
                    Popup.ShowPopup("Unable to delete a group row, please select a detail row.");
                    e.Handled = true;
                    return;
                }
                if (Popup.ShowPopup("Are you sure you want to remove this sub class?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvSelSubClasses.GetDataRow(gvSelSubClasses.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["id"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from LD_LOC_SubClass where id=" + oID;
                            Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);

                            object oLOC_DET_ID = gvDet.GetFocusedRowCellValue("id");
                            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar("select count(*) from LD_LOC_SubClass where loc_det_id=" + oLOC_DET_ID, Connection.TRConnection)) == 0)
                                SetAllSubClasses("T", oLOC_DET_ID);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void gcSubClasses_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = gvSubClasses.CalcHitInfo(e.X, e.Y);
            if (hitInfo.InRow)
            {
                Size dragSize = SystemInformation.DragSize;
                this.dragBox = new Rectangle(e.X - dragSize.Width / 2, e.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height);
            }
        }

        private void gcSubClasses_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            if (dragBox != Rectangle.Empty && !dragBox.Contains(pt))
            {
                DoSubClassDrag();
                dragBox = Rectangle.Empty;
            }
        }

        private void DoSubClassDrag()
        {
            if (gvSubClasses.RowCount > 0)
            {
                int[] iRows = gvSubClasses.GetSelectedRows();
                if (iRows != null)
                {
                    gvSubClasses.GridControl.DoDragDrop(new object[] { "SubClass", iRows }, DragDropEffects.All);
                }
            }
        }

        #endregion

        private void ucLOC_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        

        

        
    }
}
