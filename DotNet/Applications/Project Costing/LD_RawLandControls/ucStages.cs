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
    public partial class ucStages : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        int iPriID = -1;
        private bool bReadOnly = false;

        public ucStages(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
        }



        private void ucStages_Load(object sender, EventArgs e)
        {

            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvStages, daStages, dsStages1);
            gGrid.AskBeforeDelete = false;
            gGrid.IgnoreFieldList = new string[] { colNetArea.FieldName };
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


            daStages.SelectCommand.Parameters["@PRI_ID"].Value = iPriID;

            dsStages1.Clear();
            daStages.Fill(dsStages1);
        }

        public void SetReadOnlyMode(bool ReadOnly)
        {
            bReadOnly = ReadOnly;
            gvStages.OptionsBehavior.Editable = !bReadOnly;
            if (gGrid != null)
                gGrid.Event_ProcessGridKey_Enabled = !bReadOnly;
        }

        bool gGrid_AllowDelete(object sender, DataRow row)
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

        private void gvStages_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvStages.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colPRI_ID.FieldName] = iPriID;
                row[colTotalArea.FieldName] = 0;
                row[colAdditionalUseArea.FieldName] = 0;
                row[colNetArea.FieldName] = 0;
            }
        }

        private void gvStages_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;
            decimal AdditionalUseArea = 0;
            decimal TotalArea = 0;

            try
            {
                AdditionalUseArea = (decimal)drv[colAdditionalUseArea.FieldName];
                TotalArea = (decimal)drv[colTotalArea.FieldName];
            }
            catch { }

            if (drv[colCode.FieldName] == null || drv[colCode.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Code is required");
                e.Valid = false;
            }
            else if (drv[colDescription.FieldName] == null || drv[colDescription.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Description is required");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colAdditionalUseArea.FieldName], true))
            {
                pop.ShowPopup("Additional Use Area must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colTotalArea.FieldName], true))
            {
                pop.ShowPopup("Total Area must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if (TotalArea < AdditionalUseArea)
            {
                pop.ShowPopup("Total Area must be greater than or equal to Additional Use Area.");
                e.Valid = false;
            }
            else if (StagesOverLimit(drv))
            {
                pop.ShowPopup("Total Area must be less than or equal to the Project's Area.");
                e.Valid = false;
            }

        }

        private bool StagesOverLimit(DataRowView drv)
        {
            bool returnvalue = false;
            string sql = "select isnull(sum(case when ID = " + drv[colID.FieldName].ToString() + " then 0 else TotalArea end),0)+ " + drv[colTotalArea.FieldName].ToString() + " from PROJ_LD_Stages where PRI_ID = " + iPriID.ToString();
            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error checking for stage area:" + con.SQLExecutor.Exception.Message);
            decimal stageArea = 0;
            try { stageArea = (decimal)result; }
            catch { }
            sql = "select isnull(area,0) from PROJ_DEV_INFO where PRI_ID = " + iPriID.ToString();
            result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error checking for project area:" + con.SQLExecutor.Exception.Message);
            decimal ProjectArea = 0;
            try { ProjectArea = (decimal)result; }
            catch { }

            if (stageArea > ProjectArea)
                returnvalue = true;



            return returnvalue;
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

        private void gvStages_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvStages_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = gvStages.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colAdditionalUseArea || e.Column == colTotalArea)
                {
                    decimal AdditionalUseArea = 0;
                    decimal TotalArea = 0;

                    try
                    {
                        AdditionalUseArea = (decimal)row[colAdditionalUseArea.FieldName];
                        TotalArea = (decimal)row[colTotalArea.FieldName];
                    }
                    catch { }

                    row[colNetArea.FieldName] = TotalArea - AdditionalUseArea;
                }
            }
        }


    }
}
