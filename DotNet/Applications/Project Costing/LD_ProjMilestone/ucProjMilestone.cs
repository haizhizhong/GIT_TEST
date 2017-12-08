using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProjMilestone
{

    public partial class ucProjMilestone : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        private int _pri_id = -1;
        private KeyControlAccess.Validator KCA_Validator;
        private const int CONST_KEYCONTROL_EDIT_DATE = 368;

        public ucProjMilestone(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,KeyControlAccess.Validator pKCA_Validator)
        {
            InitializeComponent();
            KCA_Validator = pKCA_Validator;
            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvMilestone, daProjMilestone, dsProjMilestone1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

        }

        private void ucProjMilestone_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        bool gGrid_AllowDelete(object sender, DataRow row)
        {

            if (pop.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                return true;
            }
            else
                return false;

        }

        public void SetReadOnly(bool readOnly)
        {
            gvMilestone.OptionsBehavior.Editable = !readOnly;
            btnLoadAll.Enabled = !readOnly;
            btnLoadSelected.Enabled = !readOnly;
        }

        public void RefreshMe(int pri_id)
        {
            _pri_id = pri_id;
            daProjMilestone.SelectCommand.Parameters["@pri_id"].Value = pri_id;
            try
            {
                dsMilestone1.Clear();
                daMilestone.Fill(dsMilestone1);

                dsProjMilestone1.Clear();
                daProjMilestone.Fill(dsProjMilestone1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading milestones." + ex.Message);
            }

        }

        private void gvMilestone_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvMilestone.GetDataRow(e.RowHandle);
            row[colpri_id.FieldName] = daMilestone.SelectCommand.Parameters["@pri_id"].Value;
        }

        private void gvMilestone_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;

            if (rv[colMilestone_ID.FieldName] == null || rv[colMilestone_ID.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Milestone is required.");
                e.Valid = false;
            }
            else if (rv[colMilestone_ID.FieldName].ToString().Trim() == "")
            {
                pop.ShowPopup("Milestone is required.");
                e.Valid = false;
            }
            else if (isMilestoneInUse(rv))
            {
                pop.ShowPopup("Milestone is already in this project.");
                e.Valid = false;
            }
        }

        private bool isMilestoneInUse( DataRowView drv)
        {
            bool returnvalue = false;
            object result = con.SQLExecutor.ExecuteScalar("select count(*) from LD_Proj_Milestone where Proj_Milestone_ID <> "+drv[colProj_Milestone_ID.FieldName].ToString()+
                " and pri_id = "+drv[colpri_id.FieldName].ToString()+" and Milestone_ID = "+drv[colMilestone_ID.FieldName].ToString(),con.TRConnection);
            int count = 0;

            try { count = Convert.ToInt32(result); }
            catch { }

            if (count > 0)
                returnvalue = true;

            return returnvalue;
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            using( frmLoadFromSetup frm = new frmLoadFromSetup(con,tuc_mgr,_pri_id))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        dsProjMilestone1.Clear();
                        daProjMilestone.Fill(dsProjMilestone1);
                    }
                    catch (Exception ex)
                    {
                        pop.ShowPopup("Error refreshing load from setup milestones." + ex.Message);
                    }
                }
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            if (pop.ShowPopup("Are you sure you want load from setup?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                con.SQLExecutor.ExecuteNonQuery("exec LD_Milestone_LoadAll " + daProjMilestone.SelectCommand.Parameters["@pri_id"].Value.ToString(), con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error loading all:" + con.SQLExecutor.Exception.Message);
                else
                {
                    try
                    {
                        dsProjMilestone1.Clear();
                        daProjMilestone.Fill(dsProjMilestone1);
                    }
                    catch (Exception ex)
                    {
                        pop.ShowPopup("Error refreshing load all milestones." + ex.Message);
                    }
                }
            }
        }

        private void ri_deTargetDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvMilestone.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && gvMilestone.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                object result = con.SQLExecutor.ExecuteScalar("select TargetDate from LD_Proj_Milestone where Proj_Milestone_ID = "+gvMilestone.GetFocusedRowCellValue(colProj_Milestone_ID).ToString(), con.TRConnection);
                if (result != DBNull.Value)
                {
                    if (!KCA_Validator.ValidatePassword(CONST_KEYCONTROL_EDIT_DATE))
                    {
                        pop.ShowPopup("Target date can not be changed once it has been set.");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ri_lueMilestone_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvMilestone.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle && gvMilestone.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                object result = con.SQLExecutor.ExecuteScalar("select TargetDate from LD_Proj_Milestone where Proj_Milestone_ID = " + gvMilestone.GetFocusedRowCellValue(colProj_Milestone_ID).ToString(), con.TRConnection);
                if (result != DBNull.Value)
                {
                    pop.ShowPopup("Milestone can not be changed once a target date has been set.");
                    e.Cancel = true;
                }
            }
        }

        private void gvMilestone_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }



    }
}
