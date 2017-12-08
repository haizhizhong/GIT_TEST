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
    public partial class ucRawLandHolding : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        int iPriID = -1;
        private bool bReadOnly = false;

        public ucRawLandHolding(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
        }

        private void ucRawLandHolding_Load(object sender, EventArgs e)
        {
            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvRawLand, daRawLandHolding, dsRawLandHolding1);
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


            daRawLandHolding.SelectCommand.Parameters["@PRI_ID"].Value = iPriID;


            try
            {

                dsRawLandHolding1.Clear();
                daRawLandHolding.Fill(dsRawLandHolding1);

                dsRawLandProject1.Clear();
                daRawLandProject.Fill(dsRawLandProject1);

                dsProjAdditionalUseArea1.Clear();
                daProjAdditionalUseArea.Fill(dsProjAdditionalUseArea1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading Raw Land Holding:" + ex.Message);
            }
        }

        public void SetReadOnlyMode(bool ReadOnly)
        {
            bReadOnly = ReadOnly;
            gvRawLand.OptionsBehavior.Editable = !bReadOnly;
            if (gGrid != null)
                gGrid.Event_ProcessGridKey_Enabled = !bReadOnly;
            hleTransferCosts.Enabled = !bReadOnly;
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


        private void gvRawLand_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvRawLand.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colPRI_ID.FieldName] = iPriID;
                row[colAdditionalUse_Area.FieldName] = 0;
                row[colTotalArea.FieldName] = 0;
                row[colNetArea.FieldName] = 0;
            }
        }

        private void gvRawLand_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvRawLand_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = gvRawLand.GetDataRow(e.RowHandle);
            if (row != null)
            {
                if (e.Column == colAdditionalUse_Area || e.Column == colTotalArea)
                {
                    decimal AdditionalUseArea = 0;
                    decimal TotalArea = 0;

                    try
                    {
                        AdditionalUseArea = (decimal)row[colAdditionalUse_Area.FieldName];
                        TotalArea = (decimal)row[colTotalArea.FieldName];
                    }
                    catch { }

                    row[colNetArea.FieldName] = TotalArea - AdditionalUseArea;
                }
                else if (e.Column == colRawLand_PRI_ID || e.Column == colRawLand_PRI_ID1)
                {
                    row[colPROJ_LD_AdditionalUseArea_ID.FieldName] = DBNull.Value;
                }
            }
        }

        private void gvRawLand_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;
            decimal AdditionalUseArea = 0;
            decimal TotalArea = 0;
            decimal CurrentAdditionalUseAreaAllocated = 0;
            decimal OriginalAdditionalUseArea = 0;
            decimal CurrentTotalAreaAllocated = 0;
            decimal OriginalTotalArea = 0;

            try
            {
                AdditionalUseArea = (decimal)drv[colAdditionalUse_Area.FieldName];
                TotalArea = (decimal)drv[colTotalArea.FieldName];
            }
            catch { }

            try
            {
                CurrentAdditionalUseAreaAllocated = GetCurrentAdditionalUseAreaAllocated(Convert.ToInt32(drv[colPROJ_LD_AdditionalUseArea_ID.FieldName]), Convert.ToInt32(drv[colID.FieldName]));
            }
            catch { }
            try
            {
                OriginalAdditionalUseArea = GetCurrentAdditionalUseArea(Convert.ToInt32(drv[colPROJ_LD_AdditionalUseArea_ID.FieldName]));
            }
            catch { }

            try
            {
                CurrentTotalAreaAllocated = GetCurrentTotalAreaAllocated(Convert.ToInt32(drv[colPROJ_LD_AdditionalUseArea_ID.FieldName]), Convert.ToInt32(drv[colID.FieldName]));
            }
            catch { }
            try
            {
                OriginalTotalArea = GetCurrentProjectTotalArea(Convert.ToInt32(drv[colRawLand_PRI_ID.FieldName]));
            }
            catch { }

            if (drv[colRawLand_PRI_ID.FieldName] != null && drv[colRawLand_PRI_ID.FieldName] != DBNull.Value)
            {
                string sSQL = @"select isnull(area_uom, 'X') from PROJ_DEV_INFO where pri_id = " + iPriID;
                object oPriUOM = con.SQLExecutor.ExecuteScalar(sSQL, con.TRConnection);
                if (oPriUOM == null || oPriUOM == DBNull.Value)
                    oPriUOM = "X";

                sSQL = @"select isnull(area_uom, 'Z') from PROJ_DEV_INFO where pri_id = " + drv[colRawLand_PRI_ID.FieldName]; ;
                object oRLPriUOM = con.SQLExecutor.ExecuteScalar(sSQL, con.TRConnection);
                if (oRLPriUOM == null || oRLPriUOM == DBNull.Value)
                    oRLPriUOM = "Z";

                if (oPriUOM.Equals("X"))
                {
                    pop.ShowPopup("The Area UOM needs to be set on this project before you can select a raw land holding.");
                    e.Valid = false;
                    return;
                }

                if (oRLPriUOM.Equals("Z"))
                {
                    pop.ShowPopup("The Area UOM needs to be set on the selected raw land project before you can select it.");
                    e.Valid = false;
                    return;
                }

                if (!oPriUOM.Equals(oRLPriUOM))
                {
                    pop.ShowPopup("The Area UOM needs to be the same on both this project and the selected raw land project before you can select it.");
                    e.Valid = false;
                    return;
                }
            }

            if (drv[colRawLand_PRI_ID.FieldName] == null || drv[colRawLand_PRI_ID.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Raw Land Project is required");
                e.Valid = false;
            }
            else if (drv[colPROJ_LD_AdditionalUseArea_ID.FieldName] == null || drv[colPROJ_LD_AdditionalUseArea_ID.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Use Area is required");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colAdditionalUse_Area.FieldName], true))
            {
                pop.ShowPopup("Additional Use Area must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(drv[colTotalArea.FieldName]))
            {
                pop.ShowPopup("Total Area is too large.");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colAdditionalUse_Area.FieldName], true))
            {
                pop.ShowPopup("Additional Use Area is too large.");
                e.Valid = false;
            }
            else if (!IsGreaterThenZero(drv[colTotalArea.FieldName], true))
            {
                pop.ShowPopup("Total Area must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if(TotalArea < AdditionalUseArea)
            {
                pop.ShowPopup("Total Area must be greater than or equal to Additional Use Area.");
                e.Valid = false;
            }
            else if (OriginalAdditionalUseArea < (CurrentAdditionalUseAreaAllocated + AdditionalUseArea))
            {
                pop.ShowPopup("Additional use area can not be greater then unallocated area on the projects additional use.\r\n" +
                    "The current available area is " + (OriginalAdditionalUseArea - CurrentAdditionalUseAreaAllocated).ToString("0.0000"));
                e.Valid = false;
            }
            else if (OriginalTotalArea < (CurrentTotalAreaAllocated + TotalArea))
            {
                pop.ShowPopup("Total area can not be greater then unallocated area on the raw land project.\r\n" +
                    "The current available area is " + (OriginalTotalArea - CurrentTotalAreaAllocated).ToString("0.0000"));
                e.Valid = false;
            }

        }


        private decimal GetCurrentAdditionalUseAreaAllocated(int PROJ_LD_AdditionalUseArea_ID,int RawLandHoldingID)
        {
            decimal returnvalue = 0;
            string sql = "select sum(h.AdditionalUse_Area) from PROJ_LD_RawLandHolding h "+
                "join PROJ_HEADER ph on ph.pri_id = h.PRI_ID " +
                " where ph.pri_status <> 'X' and h.ID <> " + RawLandHoldingID.ToString() + " and h.PROJ_LD_AdditionalUseArea_ID = " + PROJ_LD_AdditionalUseArea_ID;
            

            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting additiona use area on Project"+con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

            return returnvalue;
        }

        private decimal GetCurrentAdditionalUseArea(int PROJ_LD_AdditionalUseArea_ID)
        {
            decimal returnvalue = 0;
            string sql = "select Original from PROJ_LD_AdditionalUseArea where ID = " + PROJ_LD_AdditionalUseArea_ID.ToString();


            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting Original area on projects additiona use:" + con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

            return returnvalue;
        }

        private decimal GetCurrentTotalAreaAllocated(int PROJ_LD_AdditionalUseArea_ID, int RawLandHoldingID)
        {
            decimal returnvalue = 0;
            string sql = "select sum(h.TotalArea) from PROJ_LD_RawLandHolding h " +
                "join PROJ_HEADER ph on ph.pri_id = h.PRI_ID " +
                " where ph.pri_status <> 'X' and h.ID <> " + RawLandHoldingID.ToString() + " and h.PROJ_LD_AdditionalUseArea_ID = " + PROJ_LD_AdditionalUseArea_ID;


            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting total area on Project" + con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

            return returnvalue;
        }

        private decimal GetCurrentProjectTotalArea(int pri_id)
        {
            decimal returnvalue = 0;
            string sql = "select isnull(Area,0) from PROJ_DEV_INFO where pri_id =  " + pri_id.ToString();


            object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error getting area on project header:" + con.SQLExecutor.Exception.Message);
            if (result != DBNull.Value && result != null)
            {
                try { returnvalue = Convert.ToDecimal(result); }
                catch { }
            }

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
        private void riLueAdditionalUseArea_QueryPopUp(object sender, CancelEventArgs e)
        {
            int pri_id = -1;
            try
            {
                pri_id = Convert.ToInt32(gvRawLand.GetDataRow(gvRawLand.FocusedRowHandle)[colRawLand_PRI_ID.FieldName]);
            }
            catch { }
            bsProjAdditionalUseArea.Filter = "pri_status <> 'X' and PRI_ID = " + pri_id.ToString();
            ((LookUpEdit)sender).Properties.DataSource = bsProjAdditionalUseArea;
        }

        private void hleTransferCosts_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            e.Handled = true;
            int id = -1;
            try
            {
                id = Convert.ToInt32(gvRawLand.GetDataRow(gvRawLand.FocusedRowHandle)[colID.FieldName]);
            }
            catch { }
            if (id > 0)
            {
                LD_RawLandCostUpdate.frmCostUpdatePati frm = new LD_RawLandCostUpdate.frmCostUpdatePati(con, tuc_mgr, id);
                frm.ShowDialog();
            }


        }

      
       


    }
}
