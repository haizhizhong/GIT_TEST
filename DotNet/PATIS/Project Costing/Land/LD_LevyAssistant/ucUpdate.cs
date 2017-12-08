using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LevyAssistant
{
    public partial class ucUpdate : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        string _SearchUsername = "";
        string _PreReport = "T";
        bool _isClearing = false;
        public delegate void Delegate_Updated();
        public event Delegate_Updated Updated;


        public ucUpdate(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,string SearchUsername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            _SearchUsername = SearchUsername;
            daLevyUpdate.SelectCommand.Parameters["@username"].Value = SearchUsername;
            btnClear_Click(btnClear, null);
        }

        public void RefreshMe()
        {
            bsLevyUpdate.Filter = "";
            gcLevyUpdate.Enabled = true;
            btnUpdate.Enabled = true;
            RefreshDatasets();
            _PreReport = "F";//Prereport no longer needed.
            btnPrintPreRegister.Text = "Print Register";
            btnPrintPreRegister.Enabled = false;
            string sql = "exec LD_LevyManagement_Fill '"+_SearchUsername+"'";
            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading levies:" + con.SQLExecutor.Exception.Message);


            dsLevyUpdate1.Clear();
            daLevyUpdate.Fill(dsLevyUpdate1);
        }

        private void RefreshDatasets()
        {
            try
            {
                dsLevy1.Clear();
                daLevy.Fill(dsLevy1);

                dsLevyType1.Clear();
                daLevyType.Fill(dsLevyType1);

                dsLotClass1.Clear();
                daLotClass.Fill(dsLotClass1);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading datasets :" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

            _isClearing = true;
            lueLevyType.EditValue = DBNull.Value;
            lueLotClass.EditValue = DBNull.Value;
            lueDescription.EditValue = DBNull.Value;
            teNewAmount.EditValue = "";

            _isClearing = false;
            

        }

 
        private void btnPrintPreRegister_Click(object sender, EventArgs e)
        {

 
                //LD_LevyManagement_Register(@SearchUsername varchar(500),@PreReport varchar(1),@VisibleRows varchar(max))
                string[,] saParam = new string[2, 3];
                saParam[0, 0] = "@SearchUsername";
                saParam[1, 0] = _SearchUsername;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = _PreReport;
                saParam[0, 2] = "@VisibleRows";
                saParam[1, 2] = GetVisibleRows();




                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(con, tuc_mgr, saParam, "LD_LevyMgmtRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    DialogResult result = ReportPrinter.ShowDialog();


                }
    

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string visibleRows = GetVisibleRows();
            if (visibleRows == "")
                pop.ShowPopup("You must have at least one row to update.");
            else
            {
                if (ValidateUpdate())
                {
                    if (pop.ShowPopup("Are you sure you want to update?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                    {
                        daLevyUpdate.Update(dsLevyUpdate1);
                        _PreReport = "F";
                        btnPrintPreRegister.Text = "Print Register";

                        string sql = "LD_LevyManagement_Update '" + _SearchUsername + "','" + visibleRows + "'," + teNewAmount.Text.Replace(",", "");
                        con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
                        if (con.SQLExecutor.Exception != null)
                            pop.ShowPopup("Error updating levies:" + con.SQLExecutor.Exception.Message);

                        dsLevyUpdate1.Clear();
                        daLevyUpdate.Fill(dsLevyUpdate1);
                        btnPrintPreRegister.Enabled = true;
                        if (Updated != null)
                            Updated();
                        pop.ShowPopup("Update Complete.");
                    }
                }
                    
            }
        }

        private bool ValidateUpdate()
        {
            bool returnvalue = true;

            if (lueLevyType.EditValue == null || lueLevyType.EditValue == DBNull.Value)
            {
                pop.ShowPopup("Levy Type is required.");
                returnvalue = false;
            }

            else if (lueDescription.EditValue == null || lueDescription.EditValue == DBNull.Value)
            {
                pop.ShowPopup("Description is required.");
                    returnvalue = false;
            }
            else if (IsNumberToLarge(teNewAmount.EditValue))
            {
                pop.ShowPopup("Amount is too large.");
                    returnvalue = false;
            }
            else if (IsNumberToSmall(teNewAmount.EditValue))
            {
                pop.ShowPopup("Amount is too small.");
                returnvalue = false;
            }
            else if (IsZero(teNewAmount.EditValue))
            {
                pop.ShowPopup("Amount can not be zero.");
                returnvalue = false;
            }

            return returnvalue;
        }

        private string GetVisibleRows()
        {
            string returnValue = "";
            int rowHandle = 0;
            bool RowFound = true;
            gvLevyUpdate.ExpandAllGroups();

            
            do
            {
                DataRow row = gvLevyUpdate.GetDataRow(rowHandle);
                if (row != null)
                {
                    if (FitsSearchCriteria(row))
                    {

                        if (returnValue == "")
                            returnValue = row[colProj_lot_agreement_levy_id.FieldName].ToString();
                        else
                            returnValue = returnValue + "," + row[colProj_lot_agreement_levy_id.FieldName].ToString();
                    }
                    rowHandle++;
                }
                else
                    RowFound = false;

            } while (RowFound);


            return returnValue;
        }


        private bool FitsSearchCriteria(DataRow dr)
        {
            bool returnvalue = true;

            if (lueLevyType.EditValue != null && lueLevyType.EditValue != DBNull.Value)
            {
                if (dr["LevyType_ID"].ToString() != lueLevyType.EditValue.ToString())
                    returnvalue = false;
            }

            if (lueDescription.EditValue != null && lueDescription.EditValue != DBNull.Value)
            {
                if (dr["Levy_ID"].ToString() != lueDescription.EditValue.ToString())
                    returnvalue = false;
            }
            if (lueLotClass.EditValue != null && lueLotClass.EditValue != DBNull.Value)
            {
                if (dr["Lot_Class_ID"].ToString() != lueLotClass.EditValue.ToString())
                    returnvalue = false;
            }

            return returnvalue;
        }

        private void gvLevyUpdate_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;
            if (IsNumberToLarge(drv[colNewAmount.FieldName]))
            {
                e.Valid = false;
                e.ErrorText = "New Amount is too large.";
            }
            else if (IsNumberToLarge(drv[colNewAmount.FieldName]))
            {
                e.Valid = false;
                e.ErrorText = "New Amount is too small.";
            }
            else if (IsZero(drv[colNewAmount.FieldName]))
            {
                e.Valid = false;
                e.ErrorText = "New Amount cannot be zero.";
            }

        }

        private bool IsZero(object value)
        {
            bool returnValue = false;
            decimal dValue = 0;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue == 0)
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
        private bool IsNumberToSmall(object value)
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

            if (dValue < -9999999999)
                returnValue = true;

            return returnValue;
        }

        private void gvLevyUpdate_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            pop.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

       

        private void gvLevyUpdate_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                return;
            if (e.Column == colUpdated)
            {
                DataRow row = gvLevyUpdate.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (FitsSearchCriteria(row))
                        e.Appearance.BackColor = Color.Green;

            }
            }
        }
    }
}
