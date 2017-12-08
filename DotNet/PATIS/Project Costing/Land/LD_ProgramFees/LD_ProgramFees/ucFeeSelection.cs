using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProgramFees
{
    public partial class ucFeeSelection : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private TUC_GridG.GridG ggFeeSelection;
        private int iProgramFee_ID = -1;
        private bool bCancelMode = false;

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

        public DateTime PODate
        {
            get { return dePODate.DateTime; }
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
                colGSTAmount.Caption = "GST Amount";
                colPSTAmount.Caption = "PST Amount";
            }
            else
            {
                colGSTAmount.Caption = "Tax 1 Amount";
                colPSTAmount.Caption = "Tax 2 Amount";
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

        public void RefreshFeeSelection(int pProgramFee_ID, bool CancelMode)
        {
            iProgramFee_ID = pProgramFee_ID;
            bCancelMode = CancelMode;

            object oPeriod = ReflexCon.SQLExecutor.ExecuteScalar("Select Top 1 PERIOD from AR_PERIODS where period <> 13 and DATEPART(M,END_DATE) = " + DateTime.Today.Month.ToString(), ReflexCon.TRConnection);
            int iPeriod = -1;
            try { iPeriod = Convert.ToInt32(oPeriod); }
            catch { }

            acctYearPeriod1.luAcctYear.EditValue = DateTime.Today.Year;
            acctYearPeriod1.luAcctPeriod.EditValue = iPeriod;
            dePODate.DateTime = DateTime.Today;

            string processType = bCancelMode ? "CancelCertificatesAssistant" : "ProgramFeesAssistant";

            ReflexCon.SQLExecutor.ExecuteNonQuery("exec LD_lpf_LoadFeeSelection '" + ReflexCon.MLUser+ "', " + iProgramFee_ID.ToString()+ ",'" + processType+"'", ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
                frmMessageBox.ShowPopup("Unable to load fee selection: " + ReflexCon.SQLExecutor.Exception.Message);

            dsFeeSelection1.Clear();
            daFeeSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daFeeSelection.Fill(dsFeeSelection1);
        }

        private bool ggFeeSelection_AllowDelete(object sender, DataRow row)
        {
            return false;
        }

        public bool ValidateFeeSelection()
        {

            if (dePODate.EditValue == DBNull.Value || dePODate.EditValue == null)
            {
                frmMessageBox.ShowPopup("Please select a PO date.");
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

            string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + dePODate.DateTime.ToShortDateString() + "' and period <> 13 order by END_DATE";
            DataTable dt = ReflexCon.SQLExecutor.ExecuteDataAdapter(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Error setting year and period from po date:" + ReflexCon.SQLExecutor.Exception.Message);
                return false;
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() != dt.Rows[0]["PERIOD"].ToString()
                       || acctYearPeriod1.luAcctYear.EditValue.ToString() != dt.Rows[0]["AR_YEAR"].ToString())
                    {
                        frmMessageBox.ShowPopup("PO date must be within the selected year/period.");
                        return false;
                    }
                }
            }

            object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From working_ld_lpf_LotList Where Selected = 1 and username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
            int iCount = -1;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount <= 0)
            {
                frmMessageBox.ShowPopup("You must select at least one lot to continue.");
                return false;
            }

            oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From working_ld_lpf_LotList Where Selected = 1 and IsNull(POAmount,0) = 0 and username = '" + ReflexCon.MLUser + "' ", ReflexCon.TRConnection);
            iCount = -1;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount > 0)
            {
                frmMessageBox.ShowPopup("One or more selected lots have a zero PO amount.");
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
            string sql = "Update working_ld_lpf_LotList Set Selected = " + (pSelected ? "1" : "0") + " where username = '" + ReflexCon.MLUser + "' ";
            if (pSelected)
                sql += " and isnull(redeemed,0) = 0";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
                frmMessageBox.ShowPopup("Unable to set selection: " + ReflexCon.SQLExecutor.Exception.Message);

            dsFeeSelection1.Clear();
            daFeeSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daFeeSelection.Fill(dsFeeSelection1);

        }

        private void ri_ceSelected_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gvFeeSelection.GetDataRow(gvFeeSelection.FocusedRowHandle);
            if (row != null)
            {

                if (Convert.ToBoolean(row[colRedeemed.FieldName]))
                {
                    if (e.NewValue != null && e.NewValue != DBNull.Value && Convert.ToBoolean(e.NewValue))
                    {
                        frmMessageBox.ShowPopup("Can not Cancel Certificate.AP Invoice has been entered.");
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
