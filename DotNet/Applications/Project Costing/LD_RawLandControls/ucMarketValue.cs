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
    public partial class ucMarketValue : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;
        int iPriID = -1;
        private bool bReadOnly = false;

        public ucMarketValue(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
        }

        private void ucMarketValue_Load(object sender, EventArgs e)
        {
            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvMarketValue, daMarketValue, dsMarketValue1);
            gGrid.AskBeforeDelete = false;
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


            daMarketValue.SelectCommand.Parameters["@PRI_ID"].Value = iPriID;

            dsMarketValue1.Clear();
            daMarketValue.Fill(dsMarketValue1);
        }

        public void SetReadOnlyMode(bool ReadOnly)
        {
            bReadOnly = ReadOnly;
            gvMarketValue.OptionsBehavior.Editable = !bReadOnly;
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

        private void gvMarketValue_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvMarketValue.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colPRI_ID.FieldName] = iPriID;
                row[colMarketValue.FieldName] = 0;
                row[colAsAtDate.FieldName] = DateTime.Now;
                row[colLastChangedBy.FieldName] = con.MLUser;
                row[colLastChangedDate.FieldName] = DateTime.Now;
            }
        }

        private void gvMarketValue_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvMarketValue_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;
            

            if (!IsGreaterThenZero(drv[colMarketValue.FieldName], true))
            {
                pop.ShowPopup("Market Value must be greater than or equal to zero.");
                e.Valid = false;
            }
            else if (DateAlreadyUsed(drv))
            {
                pop.ShowPopup("As At Date has already been used.");
                e.Valid = false;
            }
            else if(IsNumberToLarge(drv[colMarketValue.FieldName]))
            {
                pop.ShowPopup("Market Value is too large.");
                e.Valid = false;
            }

            if (e.Valid)
            {
                DataRow row = drv.Row;
                row[colLastChangedDate.FieldName] = DateTime.Now;
                row[colLastChangedBy.FieldName] = con.MLUser;
            }

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

        private bool DateAlreadyUsed(DataRowView drv)
        {
            bool returnvalue = false;
           


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



    }
}
