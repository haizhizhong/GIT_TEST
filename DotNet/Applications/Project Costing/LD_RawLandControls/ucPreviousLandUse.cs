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
    public partial class ucPreviousLandUse : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        TUC_GridG.GridG gGrid;


        public ucPreviousLandUse(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            

            gGrid = new TUC_GridG.GridG(con.CompanyServer, con.TRDB, gvPreviousLandUse, da_PreviousLandUse, ds_PreviousLandUse1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
        }



        private void ucPreviousLandUse_Load(object sender, EventArgs e)
        {
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
            gvPreviousLandUse.OptionsBehavior.Editable = !readOnly;
            
        }


        public void RefreshMe(int pri_id)
        {
            da_PreviousLandUse.SelectCommand.Parameters["@pri_id"].Value = pri_id;
            try
            {
                ds_PreviousLandUse1.Clear();
                da_PreviousLandUse.Fill(ds_PreviousLandUse1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading Previous Land Use." + ex.Message);
            }
           
        }

        private void gvPreviousLandUse_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvPreviousLandUse.GetDataRow(e.RowHandle);
            row[colpri_id.FieldName] = da_PreviousLandUse.SelectCommand.Parameters["@pri_id"].Value;
            row[colTotalArea.FieldName] = 0;
            row[colAdditionaUseArea.FieldName] = 0;
            row[colNetArea.FieldName] = 0;
        }

        private void gvPreviousLandUse_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;

            if (rv[colProjectName.FieldName] == null || rv[colProjectName.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("Project name is required.");
                e.Valid = false;
            }
            else if (rv[colProjectName.FieldName].ToString().Trim() == "")
            {
                pop.ShowPopup("Project name is required.");
                e.Valid = false;
            }
            else if(IsLessThanZero( rv[colTotalArea.FieldName],true))
            {
                pop.ShowPopup("Total area cannot be less than zero.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(rv[colTotalArea.FieldName]))
            {
                pop.ShowPopup("Total area is too large.");
                e.Valid = false;
            }
            else if (IsLessThanZero(rv[colAdditionaUseArea.FieldName], true))
            {
                pop.ShowPopup("Additional use area cannot be less than zero.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(rv[colAdditionaUseArea.FieldName]))
            {
                pop.ShowPopup("Additional use area is too large.");
                e.Valid = false;
            }
            else if (IsLessThanZero(rv[colNetArea.FieldName], true))
            {
                pop.ShowPopup("Net area cannot be less than zero.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(rv[colNetArea.FieldName]))
            {
                pop.ShowPopup("Net area is too large.");
                e.Valid = false;
            }


        }

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

        private void gvPreviousLandUse_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}
