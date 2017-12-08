using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_CashCall
{
    public partial class ucProjectSelection : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private LD_CashCall.PatiType _patiType;

        public ucProjectSelection(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,LD_CashCall.PatiType ptype)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            _patiType = ptype;
        }

        public void RefreshProjectSelection()
        {

            dsSelection1.Clear();
            con.SQLExecutor.ExecuteNonQuery("exec LD_CashDist_SelectionFill '" + con.MLUser + "','" + (_patiType == PatiType.Cashcall ? "C" : "D") + "'", con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading projects : " + con.SQLExecutor.Exception.Message);
            else
            {
                daSelection.SelectCommand.Parameters["@username"].Value = con.MLUser;
                daSelection.SelectCommand.Parameters["@pati_type"].Value = (_patiType == PatiType.Cashcall ? "C" : "D");

                daSelection.Fill(dsSelection1);
            }

        }

        private void gvSelection_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daSelection.Update(dsSelection1);
        }

        private void SelectDeselect(bool select)
        {
            string sql = "update working_LD_CashDist_Selection set selected = "+ (select?"1":"0") + " where username = '"+
                daSelection.SelectCommand.Parameters["@username"].Value.ToString() + "' and pati_type = '" +
                daSelection.SelectCommand.Parameters["@pati_type"].Value+"'";

            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error in select/deselect : " + con.SQLExecutor.Exception.Message);
            else
            {
                dsSelection1.Clear();
                daSelection.Fill(dsSelection1);
            }

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectDeselect(true);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            SelectDeselect(false);
        }


        public bool IsValid()
        {
            bool returnvalue = true;

            string sql = "select count(*) from working_LD_CashDist_Selection where Selected = 1 and username = '" + con.MLUser + "' and pati_type = '" + (_patiType == PatiType.Cashcall ? "C" : "D") + "'";
            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (result == null || result == DBNull.Value)
                result = 0;

            if (Convert.ToInt32(result) == 0)
            {
                pop.ShowPopup("You must select at least one project.");
                returnvalue = false;
            }
            //else if (deDate.EditValue == null)
            //{
            //    pop.ShowPopup(lblDateText.Text+" is required.");
            //    returnvalue = false;
            //}

            return returnvalue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SelectRecords("1");
        }

        private void SelectRecords(string selected)
        {
            string sql = "update working_LD_CashDist_Selection set Selected = " + selected + " where id in (";
            for (int i = 0; i < gvSelection.RowCount; i++)
            {
                DataRow dr = gvSelection.GetDataRow(gvSelection.GetVisibleRowHandle(i));
                if (i + 1 == gvSelection.RowCount)
                    sql += dr["id"].ToString();
                else
                    sql += dr["id"].ToString() + ", ";
            }
            sql += ")";
            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            daSelection.Fill(dsSelection1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SelectRecords("0");
        }
    }
}
