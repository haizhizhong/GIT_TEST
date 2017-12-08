using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ManagementFees
{
    public partial class ucFeeSelection : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private TUC_GridG.GridG ggFeeSelection;

        #endregion Local Variables

        #region Properties

        private HMConnection.HMCon ReflexCon;
        public HMConnection.HMCon ReflexConnection
        {
            get { return ReflexCon; }
            set { ReflexCon = value; }
        }

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        public int Year
        {
            get
            {
                int iYear = -1;
                try { iYear = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue); }
                catch { }

                return iYear;
            }
        }

        public int Period
        {
            get
            {
                int iPeriod = -1;
                try { iPeriod = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue); }
                catch { }

                return iPeriod;
            }
        }

        public DateTime RecoveryDate
        {
            get { return deRecoveryDate.DateTime; }
        }

        #endregion Properties

        public ucFeeSelection(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;

            sqlTR.ConnectionString = ReflexCon.TRConnection;

            //Update Column names to new name after tie in.
            if (ReflexCon.CountryCode == "C")
            {
                colGST_Amount.Caption = "GST Amount";
                colPST_Amount.Caption = "PST Amount";
            }
            else
            {
                colGST_Amount.Caption = "Tax 1 Amount";
                colPST_Amount.Caption = "Tax 2 Amount";
            }

            acctYearPeriod1.TRDBName = ReflexCon.TRDB;
            acctYearPeriod1.TRServerName = ReflexCon.CompanyServer;

            ggFeeSelection = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvFeeSelection, daFeeSelection, dsFeeSelection1);
            ggFeeSelection.AllowTabCreateNewRecord = false;
            ggFeeSelection.AskBeforeDelete = false;
            ggFeeSelection.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggFeeSelection_AllowDelete);
        }

        private void ucFeeSelection_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        public void RefreshFeeSelection(int iManagementFee_ID)
        {
           
            DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter("select p.PERIOD,p.AR_YEAR,p.END_DATE from AR_PERIODS p join AR_SETUP s on case when s.CURRENT_PERIOD = 13 then 12 else s.CURRENT_PERIOD end = p.PERIOD and s.CURRENT_YEAR = p.AR_YEAR", ReflexCon.TRConnection);

            if (dt.Rows.Count > 0)
            {
                acctYearPeriod1.luAcctYear.EditValue = dt.Rows[0]["AR_YEAR"];
                acctYearPeriod1.luAcctPeriod.EditValue = dt.Rows[0]["PERIOD"];
                deRecoveryDate.DateTime = Convert.ToDateTime( dt.Rows[0]["END_DATE"]);
            }
            
            ReflexCon.SQLExecutor.ExecuteNonQuery("exec LD_lmf_LoadFeeSelection '" + ReflexCon.MLUser + "', " + iManagementFee_ID.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
                frmMessageBox.ShowPopup("Unable to load fee selection: " + ReflexCon.SQLExecutor.Exception.Message);

            dsFeeSelection1.Clear();
            daFeeSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daFeeSelection.Fill(dsFeeSelection1);
        }

        private void gvFeeSelection_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colAmount)
            {
                bool bGST = false, bPST = false;
                try { bGST = Convert.ToBoolean(gvFeeSelection.GetDataRow(e.RowHandle)["GST_Flag"]); }
                catch { }
                try { bPST = Convert.ToBoolean(gvFeeSelection.GetDataRow(e.RowHandle)["PST_Flag"]); }
                catch { }

                double dAmount = 0, dGST_PCT = 0, dPST_PCT = 0, dGSTAmount = 0, dPSTAmount = 0;
                try { dAmount = Convert.ToDouble(e.Value); }
                catch { }

                try { dGST_PCT = Convert.ToDouble(gvFeeSelection.GetDataRow(e.RowHandle)["GST_PCT"]); }
                catch { }
                try { dPST_PCT = Convert.ToDouble(gvFeeSelection.GetDataRow(e.RowHandle)["PST_PCT"]); }
                catch { }

                if (bGST)
                    dGSTAmount = Math.Round(dAmount * (dGST_PCT / 100), 2, MidpointRounding.AwayFromZero);
                if (bPST)
                    dPSTAmount = Math.Round(dAmount * (dPST_PCT / 100), 2, MidpointRounding.AwayFromZero);

                gvFeeSelection.GetDataRow(e.RowHandle)["GST_Amount"] = dGSTAmount;
                gvFeeSelection.GetDataRow(e.RowHandle)["PST_Amount"] = dPSTAmount;
                gvFeeSelection.GetDataRow(e.RowHandle)["Total_Amount"] = dAmount + dGSTAmount + dPSTAmount;
            }
        }

        private bool ggFeeSelection_AllowDelete(object sender, DataRow row)
        {
            return false;
        }

        public bool ValidateFeeSelection()
        {

            if (deRecoveryDate.EditValue == DBNull.Value || deRecoveryDate.EditValue == null)
            {
                frmMessageBox.ShowPopup("Please select a recovery date.");
                return false;
            }

            if (acctYearPeriod1.luAcctPeriod.EditValue == DBNull.Value || acctYearPeriod1.luAcctPeriod.EditValue == null ||
                acctYearPeriod1.luAcctYear.EditValue == DBNull.Value || acctYearPeriod1.luAcctYear.EditValue == null)
            {
                frmMessageBox.ShowPopup("Please select a year and period.");
                return false;
            }

            object oPeriodOpen = ReflexCon.SQLExecutor.ExecuteScalar("Select IsNull(PERIOD_OPEN,'F') From AR_PERIODS Where AR_YEAR = " + acctYearPeriod1.luAcctYear.EditValue.ToString() + " And PERIOD = " + acctYearPeriod1.luAcctPeriod.EditValue.ToString() + "", ReflexCon.TRConnection);
            if (oPeriodOpen == DBNull.Value || oPeriodOpen == null) oPeriodOpen = "F";
            if (oPeriodOpen.ToString() == "F")
            {
                frmMessageBox.ShowPopup("Year and Period combination are not open.");
                return false;
            }

            string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deRecoveryDate.DateTime.ToShortDateString() + "' and PERIOD <> 13  order by END_DATE";
            DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Error setting year and period from invoice date:" + ReflexCon.SQLExecutor.Exception.Message);
                return false;
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() != dt.Rows[0]["PERIOD"].ToString()
                       || acctYearPeriod1.luAcctYear.EditValue.ToString() != dt.Rows[0]["AR_YEAR"].ToString())
                    {
                        frmMessageBox.ShowPopup("Recovery date must be within the selected year/period.");
                        return false;   
                    }
                }
            }

            object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From working_ld_lmf_LotList Where Selected = 1 and username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
            int iCount = -1;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount <= 0)
            {
                frmMessageBox.ShowPopup("You must select at least one management fee to continue.");
                return false;
            }

            oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From working_ld_lmf_LotList Where Selected = 1 and IsNull(Amount,0) = 0 and username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
            iCount = -1;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount > 0)
            {
                frmMessageBox.ShowPopup("One or more selected management fee's have a zero amount.");
                return false;
            }

            return true;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SetSelected(true);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            SetSelected(false);
        }

        private void SetSelected(bool pSelected)
        {
            ReflexCon.SQLExecutor.ExecuteNonQuery("Update working_ld_lmf_LotList Set Selected = " + (pSelected ? "1" : "0") + " where username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
                frmMessageBox.ShowPopup("Unable to set selection: " + ReflexCon.SQLExecutor.Exception.Message);

            dsFeeSelection1.Clear();
            daFeeSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daFeeSelection.Fill(dsFeeSelection1);
        }
    }
}
