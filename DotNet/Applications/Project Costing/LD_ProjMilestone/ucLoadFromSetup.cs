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
    public partial class ucLoadFromSetup : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        private int _pri_id = -1;

        public ucLoadFromSetup(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int pri_id)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            _pri_id = pri_id;

            
            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvMilestones, daWorkingMilestones, dsWorkingMilestones1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            con.SQLExecutor.ExecuteScalar("exec LD_Milestone_LoadFromSetup '"+con.MLUser+"',"+_pri_id.ToString(), con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading from setup:" + con.SQLExecutor.Exception.Message);

            daWorkingMilestones.SelectCommand.Parameters["@username"].Value = con.MLUser;
            try
            {
                dsWorkingMilestones1.Clear();
                daWorkingMilestones.Fill(dsWorkingMilestones1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading milestones." + ex.Message);
            }

        }

        bool gGrid_AllowDelete(object sender, DataRow row)
        {
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pop.ShowPopup("Are you sure you want cancel?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                if (this.ParentForm != null)
                    this.ParentForm.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void gvMilestones_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataRow row = gvMilestones.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (Convert.ToBoolean(row[colAlreadyUsed.FieldName]))
                {
                    if (e.Column == colActualDate || e.Column == colTargetDate)
                        e.RepositoryItem = ri_deReadOnly;
                    else if (e.Column == colSelected)
                        e.RepositoryItem = ri_ceReadOnly;
                }
            }
        }

        private void gvMilestones_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
             DataRow row = gvMilestones.GetDataRow(e.RowHandle);
             if (row != null)
             {
                 if (Convert.ToBoolean(row[colAlreadyUsed.FieldName]))
                 {
                     e.Appearance.BackColor = Color.LightGray;
                     e.Appearance.ForeColor = Color.Black;
                     
                 }
             }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(con.SQLExecutor.ExecuteScalar("select count(*) from LD_working_Proj_Milestone where username = '"+con.MLUser+"' and isnull(selected,0) = 1", con.TRConnection)) == 0)
            {
                pop.ShowPopup("Please select a milestone.");
            }
            else
            {
                string sql = @"insert into LD_Proj_Milestone( pri_id,Milestone_ID,TargetDate,ActualDate)
select pri_id,Milestone_ID,TargetDate,ActualDate from LD_working_Proj_Milestone where selected = 1 and username = '"+con.MLUser+"'";
                con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error loading selected milestones from setup:" + con.SQLExecutor.Exception.Message);
                else if (this.ParentForm != null)
                    this.ParentForm.DialogResult = DialogResult.OK;

            }
        }





    }
}
