using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandControls
{
    public partial class ucAdditionalUseAreas : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        int iPriID = -1;
        private bool bReadOnly = false;

        public ucAdditionalUseAreas(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
        }

        private void ucAdditionalUseAreas_Load(object sender, EventArgs e)
        {
            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvAdditionalUseAreas, daAdditionalUseAreas, dsAdditionalUseAreas1);
            gGrid.AskBeforeDelete = false;
            gGrid.IgnoreFieldList = new string[] { colAreaRemaining.FieldName,colProjectAllocated.FieldName,colEstimateAllocated.FieldName };
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.Event_ProcessGridKey_Enabled = !bReadOnly;
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
            else
                bReadOnly = false;


            SetReadOnlyMode(bReadOnly);


            daAdditionalUseAreas.SelectCommand.Parameters["@PRI_ID"].Value = iPriID;

            dsAdditionalUseAreas1.Clear();
            daAdditionalUseAreas.Fill(dsAdditionalUseAreas1);
        }

        public void SetReadOnlyMode(bool ReadOnly)
        {
            bReadOnly = ReadOnly;
            gvAdditionalUseAreas.OptionsBehavior.Editable = !bReadOnly;
            if (gGrid != null)
                gGrid.Event_ProcessGridKey_Enabled = !bReadOnly;
        }

        bool gGrid_AllowDelete(object sender, DataRow row)
        {
            string sql = "select count(*) from PROJ_LD_RawLandHolding where PROJ_LD_AdditionalUseArea_ID = " + row[colID.FieldName].ToString();
            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
            {
                pop.ShowPopup("Error validating additional use allocations.");
                return false;
            }
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    pop.ShowPopup("Additional Use has been allocated and can not be deleted.");
                    return false;
                }
            }

            if (pop.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void gvAdditionalUseAreas_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvAdditionalUseAreas.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colPRI_ID.FieldName] = iPriID;
                row[colOriginal.FieldName] = 0;
                row[colProjectAllocated.FieldName] = 0;
                row[colEstimateAllocated.FieldName] = 0;
                row[colAreaRemaining.FieldName] = 0;
            }
        }

        private void gvAdditionalUseAreas_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;

            decimal original = 0;
            decimal projectAllocated = 0;
            int AdditionalUseArea_ID = -1;

            try
            {
                AdditionalUseArea_ID = (int)drv[colID.FieldName];
            }
            catch { }

            

            try
            {
                original = (decimal)drv[colOriginal.FieldName];
                projectAllocated = (decimal)drv[colProjectAllocated.FieldName];
            }
            catch { }
            //update the allocated values incase it has changed.
            drv.Row[colProjectAllocated.FieldName] = GetCurrentAllocated(AdditionalUseArea_ID, true);
            drv.Row[colAreaRemaining.FieldName] = original - GetCurrentAllocated(AdditionalUseArea_ID, true);


            if (drv[colDescription.FieldName] == null || drv[colDescription.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Description is required");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colOriginal.FieldName], true))
            {
                pop.ShowPopup("Original must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(drv[colOriginal.FieldName]))
            {
                pop.ShowPopup("Original is too large.");
                e.Valid = false;
            }
            else if (original < projectAllocated)
            {
                pop.ShowPopup("Original must be greater than or equal to Project Allocated.");
                e.Valid = false;
            }
            else if (ProjectArea() < SumOfOriginal(drv))
            {
                pop.ShowPopup("Sum of original must be less than or equal to area on project header.");
                e.Valid = false;
            }
            

        }

        private double ProjectArea()
        {
            string sql = "select isnull(Area,0) from PROJ_DEV_INFO where PRI_ID = "+iPriID.ToString();
            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (result == null || result == DBNull.Value)
                result = 0;


            return Convert.ToDouble(result);
        }

        private double SumOfOriginal(DataRowView drv)
        {
            double returnvalue = 0;

            string sql = "select isnull(sum(original),0)[OriginalTotal] from PROJ_LD_AdditionalUseArea where id <> "+drv[colID.FieldName].ToString()+" and PRI_ID = "+drv[colPRI_ID.FieldName].ToString();
            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                try
                {
                    returnvalue = Convert.ToDouble(result);
                }
                catch { }
                try
                {
                    returnvalue = returnvalue + Convert.ToDouble(drv[colOriginal.FieldName]);
                }
                catch { }
            }


            return returnvalue;
        }


        private void gvAdditionalUseAreas_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private bool IsGreaterThenZero(object value, bool AllowZero)
        {
            bool returnValue = true;
            decimal dValue = -1;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue == 0 && !AllowZero)
                returnValue = false;
            else if (dValue < 0)
                returnValue = false;
            return returnValue;
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

        private void gvAdditionalUseAreas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = gvAdditionalUseAreas.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colOriginal )
                {
                    decimal original = 0;
                    int AdditionalUseArea_ID = -1;

                    try
                    {
                        original = (decimal)row[colOriginal.FieldName];
                        AdditionalUseArea_ID = (int)row[colID.FieldName];
                    }
                    catch { }

                    row[colProjectAllocated.FieldName] = GetCurrentAllocated(AdditionalUseArea_ID, true);
                    row[colAreaRemaining.FieldName] = original - GetCurrentAllocated(AdditionalUseArea_ID,true);
                }
            }
        }

        private decimal GetCurrentAllocated(int PROJ_LD_AdditionalUseArea_ID,bool IsProject)
        {
            decimal returnvalue = 0;
            string sql;

            if (IsProject)
                sql = "select sum(h.AdditionalUse_Area) from PROJ_LD_RawLandHolding h "+
                    "join PROJ_HEADER ph on ph.pri_id = h.PRI_ID " +
                    " where ph.pri_status <> 'X' and h.PROJ_LD_AdditionalUseArea_ID = " + PROJ_LD_AdditionalUseArea_ID;
            else
                sql = "select sum(h.AdditionalUse_Area) from EST_LD_RawLandHolding h "+
                    "join est_header eh on eh.ID = h.EST_ID"+
                    "where eh.est_status not in ('X','C') and h.PROJ_LD_AdditionalUseArea_ID = " + PROJ_LD_AdditionalUseArea_ID;

            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting additional use area on " + (IsProject ? "Project" : "Estimate") + con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

            return returnvalue;
        }

    }
}
