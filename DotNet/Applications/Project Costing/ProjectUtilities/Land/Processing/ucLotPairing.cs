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
    public partial class ucLotPairing : DevExpress.XtraEditors.XtraUserControl
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;
        private ComboSearch.Util CBOUtil;
        private Rectangle dragBox;

        public ucLotPairing(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool bFieldsEmpty = true;

            if (!lueProjCode.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daPairingSearch.SelectCommand.Parameters["@pri_code"].Value = lueProjCode.EditValue;
            }
            else
            {
                daPairingSearch.SelectCommand.Parameters["@pri_code"].Value = DBNull.Value;
            }

            if (!luePriName.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daPairingSearch.SelectCommand.Parameters["@pri_name"].Value = luePriName.EditValue;
            }
            else
            {
                daPairingSearch.SelectCommand.Parameters["@pri_name"].Value = DBNull.Value;
            }
            
            if (!cboLot.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daPairingSearch.SelectCommand.Parameters["@lot_num"].Value = cboLot.Text.Replace("'", "''");
            }
            else
            {
                daPairingSearch.SelectCommand.Parameters["@lot_num"].Value = DBNull.Value;
            }

            if (!cboBlock.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daPairingSearch.SelectCommand.Parameters["@block_num"].Value = cboBlock.Text.Replace("'", "''");
            }
            else
            {
                daPairingSearch.SelectCommand.Parameters["@block_num"].Value = DBNull.Value;
            }

            if (!cboPlan.Text.Trim().Equals(""))
            {
                bFieldsEmpty = false;
                daPairingSearch.SelectCommand.Parameters["@plan_num"].Value = cboPlan.Text.Replace("'", "''");
            }
            else
            {
                daPairingSearch.SelectCommand.Parameters["@plan_num"].Value = DBNull.Value;
            }
            if (bFieldsEmpty)
            {
                if (Popup.ShowPopup("Search criteria is empty, are you sure you would like to perform search?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    CL_Dialog.PleaseWait.Show("Loading Search...", null);
                    dsPairingSearch.Clear();
                    daPairingSearch.Fill(dsPairingSearch);
                    gvSearch_FocusedRowChanged(null, null);
                    CL_Dialog.PleaseWait.Hide();
                }
            }
            else
            {
                CL_Dialog.PleaseWait.Show("Loading Search...", null);
                dsPairingSearch.Clear();
                daPairingSearch.Fill(dsPairingSearch);
                gvSearch_FocusedRowChanged(null, null);
                CL_Dialog.PleaseWait.Hide();
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

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void hlRefresh_Click(object sender, EventArgs e)
        {
            dsProjectLU.Clear();
            daProject.Fill(dsProjectLU);
        }

        private void hlNew_Click(object sender, EventArgs e)
        {
            gvSearch.AddNewRow();
            gvSearch.Focus();
            gvSearch.FocusedColumn = colProjNo;
        }

        private void gvSearch_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvSearch.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                object oPriID = dr["pri_id"];
                if (oPriID == null || oPriID == DBNull.Value)
                {                    
                    e.ErrorText = "Project is required.";
                    gvSearch.FocusedColumn = colProjNo;
                    e.Valid = false;
                    return;
                }

                if (dr.RowState != DataRowState.Added)
                {
                    object oLotPairID = dr["Lot_Pair_ID"];
                    if (oLotPairID != null && oLotPairID != DBNull.Value)
                    {
                        string sSelect = "select count(*) from LD_Lot_Pair_Det where lot_pair_id="+oLotPairID;
                        if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) > 0)
                        {
                            e.ErrorText = "Lots have already been paired to the current project, remove the lots before changing the project.";                            
                            e.Valid = false;
                            return;
                        }
                    }
                }
            }
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
                    else
                    {
                        object oOrgPriID = dr["pri_id", DataRowVersion.Original];
                        if (oOrgPriID != dr["pri_id"])
                            bNew = true;
                    }
                    SqlCommand cmd = new SqlCommand("PC_LotPairIU @lot_pair_id, @pri_id", new SqlConnection(Connection.TRConnection));

                    object oLot_Pair_ID = dr["Lot_Pair_ID"];
                    if (oLot_Pair_ID == null || oLot_Pair_ID.Equals(0))
                        oLot_Pair_ID = DBNull.Value;

                    cmd.Parameters.Add("@lot_pair_id", SqlDbType.Int);
                    cmd.Parameters["@lot_pair_id"].Value = oLot_Pair_ID;
                    cmd.Parameters.Add("@pri_id", SqlDbType.Int);
                    cmd.Parameters["@pri_id"].Value = dr["pri_id"];

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
                                    dr["Lot_Pair_ID"] = dtdr["lot_pair_id"];
                                    dr["seq"] = dtdr["seq"];
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
                        hlEdit_Click(hlEdit, new EventArgs());
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboBlock.EditValue = null;
            cboLot.EditValue = null;
            cboPlan.EditValue = null;
            luePriName.EditValue = DBNull.Value;
            lueProjCode.EditValue = DBNull.Value;
        }

        private void gvSearch_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;		
        }

        private void gcSearch_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete this pairing?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                {
                    DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
                    if (dr != null)
                    {
                        object oID = dr["Lot_Pair_ID"];
                        if (oID != null && oID != DBNull.Value)
                        {
                            string sDelete = "delete from LD_Lot_Pair_Det where Lot_Pair_ID=" + oID+" "+
                                "delete from LD_Lot_Pair_Hdr where Lot_Pair_ID=" + oID;
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
                dr["Lot_Pair_ID"] = 0;
            }
        }

        private void gvSearch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsPairingDet.Clear();
            dsPairingLots.Clear();
            DataRow dr = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
            if (dr != null)
            {
                object oPairID = dr["Lot_Pair_ID"];
                if (oPairID != null && oPairID != DBNull.Value)
                {
                    if (daPairingDet.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daPairingDet.SelectCommand.Parameters["@lot_pair_id"].Value = oPairID;
                        daPairingDet.Fill(dsPairingDet);
                    }
                }

                object oPriID = dr["pri_id"];
                if (oPriID != null && oPriID != DBNull.Value)
                {
                    if (daPairingDet.SelectCommand.Connection.State == ConnectionState.Closed)
                    {
                        daPairingLots.SelectCommand.Parameters["@pri_id"].Value = oPriID;
                        daPairingLots.Fill(dsPairingLots);
                    }
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

        private void gcDet_DragDrop(object sender, DragEventArgs e)
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
                        int AlreadyPaired = 0;
                        int HasAgreements = 0;
                        for (int i = 0; i < iRows.Length; i++)
                        {
                            dr = gvLots.GetDataRow(iRows[i]);

                            if (dr["Paired"].Equals("F"))
                            {
                                object oLotID = dr["proj_lot_id"];
                                if (oLotID != null && oLotID != DBNull.Value)
                                {
                                    if (HasAgreement(Convert.ToInt32(oLotID)))
                                    {
                                        HasAgreements++;
                                    }
                                    else
                                    {

                                        object oLotPairID = daPairingDet.SelectCommand.Parameters["@lot_pair_id"].Value;
                                        string sSelect = "select p.lot_num, p.block_num, p.plan_num, c.Description [Class], s.Description [Sub_Class] " +
                                            "from proj_lot p " +
                                            "left outer join LD_Lot_Class c on c.Lot_Class_ID=p.lot_class_id " +
                                            "left outer join LD_Lot_Sub_Class s on s.Lot_Sub_Class_ID=p.lot_sub_class_id " +
                                            "where p.proj_lot_id=" + oLotID;
                                        DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSelect, Connection.TRConnection);
                                        if (dt != null)
                                        {
                                            if (dt.Rows.Count > 0)
                                            {
                                                DataRow dr1 = dt.Rows[0];
                                                if (dr1 != null)
                                                {
                                                    string sInsert = "insert into LD_Lot_Pair_Det (lot_pair_id, proj_lot_id) select " + oLotPairID + ", " + oLotID + " select @@identity";
                                                    object oID = Connection.SQLExecutor.ExecuteScalar(sInsert, Connection.TRConnection);
                                                    dsPairingDet.Tables[0].Rows.Add(new object[] { oID, oLotID, dr1["lot_num"], dr1["block_num"], dr1["plan_num"], dr1["Class"], dr1["Sub_Class"] });
                                                    dr["Paired"] = "T";
                                                }
                                            }
                                        }

                                        object oRef = Connection.SQLExecutor.ExecuteScalar("exec PC_LotPairRefU " + oLotPairID, Connection.TRConnection);
                                        DataRow drSearch = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
                                        if (drSearch != null)
                                        {
                                            drSearch["lot_reference"] = oRef;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                AlreadyPaired++;
                            }
                        }
                        if (AlreadyPaired > 0)
                        {
                            if (AlreadyPaired == 1)
                                Popup.ShowPopup("One of the selected lots is already paired and cannot be added."); 
                            else
                                Popup.ShowPopup("More then one of the selected lots are already paired and cannot be added.");
                        }
                        if (HasAgreements > 0)
                        {
                            if (HasAgreements == 1)
                                Popup.ShowPopup("One of the selected lots has an agreement and cannot be added.");
                            else
                                Popup.ShowPopup("More then one of the selected lots have an agreement and cannot be added.");
                        }
                    }
                }
            }
        }

        private void gcDet_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void gcDet_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                DataRow dr = gvDet.GetDataRow(gvDet.FocusedRowHandle);
                if (dr != null)
                {
                    if(HasAgreement( Convert.ToInt32( dr[colproj_lot_id.FieldName]) ))
                    {
                        Popup.ShowPopup("Can not remove lots that currently have an agreement.");
                        e.Handled = true;
                    }
                    else
                    {
                        if (Popup.ShowPopup("Are you sure you want to remove this lot?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
                        {

                            object oID = dr["id"];

                            if (oID != null && oID != DBNull.Value)
                            {
                                DataRow drSearch = gvSearch.GetDataRow(gvSearch.FocusedRowHandle);
                                if (drSearch != null)
                                {
                                    object oLotPairID = drSearch["Lot_Pair_ID"];
                                    string sDelete = "delete from ld_lot_pair_det where id=" + oID;
                                    Connection.SQLExecutor.ExecuteNonQuery(sDelete, Connection.TRConnection);

                                    object oRef = Connection.SQLExecutor.ExecuteScalar("exec PC_LotPairRefU " + oLotPairID, Connection.TRConnection);
                                    drSearch["lot_reference"] = oRef;

                                    int iHandle = gvLots.FocusedRowHandle;
                                    dsPairingLots.Clear();
                                    daPairingLots.Fill(dsPairingLots);
                                    gvLots.FocusedRowHandle = iHandle;
                                }
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void hlEdit_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void ucLotPairing_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private bool HasAgreement(int proj_lot_id)
        {
            bool hasAgree = true;
            string sql = "select proj_lot_id from PROJ_LOT_AGREEMENT where agreement_status_id <> 2 and proj_lot_id = " + proj_lot_id.ToString();
            object result = Connection.SQLExecutor.ExecuteScalar(sql,Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for agreement on lot:" + Connection.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
                hasAgree = true;
            else
                hasAgree = false;
            
            return hasAgree;
        }



    }
}
