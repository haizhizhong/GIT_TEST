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

namespace LD_AgreementsInterest
{
    public partial class ucCalculation : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private bool isFilling = false;
        private bool settingValues = false;
        private string _SearchUsername = "";
        public ucCalculation(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,string pSearchUsername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            _SearchUsername = pSearchUsername;
            daHeader.SelectCommand.Parameters["@SearchUsername"].Value = _SearchUsername;
            settingValues = true;
            acctYearPeriod1.TRDBName = con.TRDB;
            acctYearPeriod1.TRServerName = con.CompanyServer;
            acctYearPeriod1.checkClose = "T"; //Turns on/off Open period check.
            acctYearPeriod1.luAcctPeriod.EditValueChanged += new EventHandler(luAcctPeriod_EditValueChanged);
            acctYearPeriod1.luAcctYear.EditValueChanged += new EventHandler(luAcctYear_EditValueChanged);
            acctYearPeriod1.MessageBoxHeaderText = "Lot Sale Assistant";
            UpdateDate();
            settingValues = false;
        }

        private void gvHeader_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            ds_Interest1.Clear();
            
            if (isFilling) return;
            DataRow row = gvHeader.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                //detail grids can handle multipul lots being sold but as of now ONLY 1 lot can be selected.
                int iLotSearchID = -1;
                
                try { iLotSearchID = Convert.ToInt32(gvHeader.GetDataRow(e.FocusedRowHandle)[colID.FieldName]); }
                catch { }

               
                da_Interest.SelectCommand.Parameters["@username"].Value = con.MLUser;
                da_Interest.SelectCommand.Parameters["@working_ld_lotsearch_id"].Value = iLotSearchID;
                ds_Interest1.Clear();
                da_Interest.Fill(ds_Interest1);

              
            }
        }

        private void luAcctYear_EditValueChanged(object sender, EventArgs e)
        {
            if (!settingValues)
                UpdateDate();
        }

        private void luAcctPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (!settingValues)
                UpdateDate();
        }

        private void UpdateDate()
        {
            if (settingValues) return;
            int iYear = 0, iPeriod = 0, iMonth = 0;
            if (acctYearPeriod1.luAcctYear.EditValue != DBNull.Value && acctYearPeriod1.luAcctYear.EditValue != null)
                iYear = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue);
            if (acctYearPeriod1.luAcctPeriod.EditValue != DBNull.Value && acctYearPeriod1.luAcctPeriod.EditValue != null)
                iPeriod = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue);

            object oEndDate = con.SQLExecutor.ExecuteScalar("Select END_DATE from AR_PERIODS where AR_YEAR = " + iYear.ToString() + " and PERIOD = " + iPeriod.ToString(), con.TRConnection);

            try
            {
                DateTime dEndDate = Convert.ToDateTime(oEndDate);
                iMonth = dEndDate.Month;
                iYear = dEndDate.Year;
            }
            catch { }

            if (iYear != 0 && iMonth != 0)
            {
                settingValues = true;
                deInterestDate.DateTime = new DateTime(iYear, iMonth, 1);
                settingValues = false;

            }
        }

        private bool isDateInValid()
        {
            bool returnValue = true;
            if (deInterestDate.EditValue != DBNull.Value && deInterestDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInterestDate.DateTime.ToShortDateString() + "' and PERIOD <> 13 order by END_DATE";
                DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error setting year and period from interest date:" + con.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() == dt.Rows[0]["PERIOD"].ToString()
                           && acctYearPeriod1.luAcctYear.EditValue.ToString() == dt.Rows[0]["AR_YEAR"].ToString())
                        {
                            returnValue = false;
                        }
                    }
                }

                if (returnValue)
                {
                    pop.ShowPopup("Interest date must be within the selected year/period.");
                }

            }
            else
                pop.ShowPopup("Interest date is required.");



            return returnValue;
        }

        private void deInterestDate_EditValueChanged(object sender, EventArgs e)
        {

            if (deInterestDate.EditValue != DBNull.Value && deInterestDate.EditValue != null)
            {
                if (deInterestDate.DateTime.Year != 0001)
                {
                    string sql = "exec [LD_lpa_CalculateInterest] '" + con.MLUser + "','" + deInterestDate.DateTime.ToShortDateString() + "','',0,'"+_SearchUsername+"' ";
                    con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                        pop.ShowPopup("Error setting interest:" + con.SQLExecutor.Exception.Message);

                    gvHeader_FocusedRowChanged(gvHeader, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvHeader.FocusedRowHandle));

                    if (settingValues) return;

                    sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInterestDate.DateTime.ToShortDateString() + "' and PERIOD < 13 order by END_DATE";
                    DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                        pop.ShowPopup("Error setting year and period from date:" + con.SQLExecutor.Exception.Message);
                    else
                    {
                        if (dt.Rows.Count > 0)
                        {
                            settingValues = true;
                            acctYearPeriod1.luAcctPeriod.EditValue = dt.Rows[0]["PERIOD"];
                            acctYearPeriod1.luAcctYear.EditValue = dt.Rows[0]["AR_YEAR"];
                            settingValues = false;
                        }
                    }
                }


            }
        }


        public void RefreshMe()
        {
            isFilling = true;

            try
            {
                dsHeader1.Clear();
                daHeader.Fill(dsHeader1);
                settingValues = true;

                acctYearPeriod1.RefreshAcctPeriod();
                deInterestDate.EditValue = DateTime.Today;
                settingValues = false;
                deInterestDate_EditValueChanged(deInterestDate, null);
            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading selected lots:" + ex.Message);
            }


            isFilling = false;
            gvHeader_FocusedRowChanged(gvHeader, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvHeader.FocusedRowHandle));
        }

        public bool isValid()
        {
            bool returnValue = true;

            object oPeriodOpen = con.SQLExecutor.ExecuteScalar("Select IsNull(PERIOD_OPEN,'F') From AR_PERIODS Where AR_YEAR = " + acctYearPeriod1.luAcctYear.EditValue.ToString() + " And PERIOD = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + "", con.TRConnection);
            if (oPeriodOpen == DBNull.Value || oPeriodOpen == null) oPeriodOpen = "F";

            if (oPeriodOpen.ToString() == "F")
            {
                pop.ShowPopup("Year and Period combination are not open.");
                returnValue = false;
            }
            else
            {
                returnValue = !isDateInValid();
            }
            return returnValue;
        }

        private void ucCalculation_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }
    }
}
