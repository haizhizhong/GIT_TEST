using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_TaxrollUpdate
{
    public partial class frmLoadNewYear : DevExpress.XtraEditors.XtraForm
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;

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

        private int iPri_ID = -1;
        public int Pri_ID
        {
            get { return iPri_ID; }
        }

        private int iYear = -1;
        public int Year
        {
            get { return iYear; }
        }

        #endregion Properties

        public frmLoadNewYear(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, int Pri_ID, int Year)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            iPri_ID = Pri_ID;
            iYear = Year;

            sqlTR.ConnectionString = ReflexCon.TRConnection;

            if (iYear == -1)
                iYear = DateTime.Now.Year + 1;
        }

        private void frmLoadNewYear_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            if (iYear != -1)
                txtYear.EditValue = iYear.ToString();
            if (iPri_ID != -1)
                lueProjList.EditValue = iPri_ID;

            dsProjList1.Clear();
            daProjList.Fill(dsProjList1);

            dxStyle.FormInit(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Trim() == "")
            {
                frmMessageBox.ShowPopup("Year is required.");
                return;
            }
            else
            {
                try{iYear = Convert.ToInt32(txtYear.EditValue);}
                catch{}

                if(iYear == -1)
                {
                    frmMessageBox.ShowPopup("Unable to get year.");
                    return;
                }
            }

            if (deTaxAdjDate.EditValue != DBNull.Value && deTaxAdjDate.EditValue != null)
            {
                if (iYear != deTaxAdjDate.DateTime.Year)
                {
                    frmMessageBox.ShowPopup("Date must have the same year selected.");
                    return;
                }
            }

            try { iPri_ID = Convert.ToInt32(lueProjList.EditValue); }
            catch { }

            if (iPri_ID <= 0)
                iPri_ID = -1;
                
            //object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From PROJ_LOT_TAX_DET Where Year = " + iYear.ToString() +
            //    (iPri_ID == -1 ? "" : " and tax_roll_id in (select tr.id From PROJ_LOT_TAX_ROLL tr where pri_id = " + iPri_ID.ToString() + ")"), ReflexCon.TRConnection);
            //int iCount = -1;

            //try { iCount = Convert.ToInt32(oCount); }
            //catch { }

            //if (iCount > 0)
            //{
            //    frmMessageBox.ShowPopup("Year already loaded.");
            //    return;
            //}

            object result = ReflexCon.SQLExecutor.ExecuteScalar("select COUNT(*) from PROJ_LOT_TAX_DET d join PROJ_LOT_TAX_ROLL r on r.id = d.tax_roll_id where d.YEAR = " + (iYear - 1).ToString() + " and r.pri_id = " + Pri_ID.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("There was a checking for this project's previous year: " + ReflexCon.SQLExecutor.Exception.Message);
                return;
            }
            else if (Convert.ToInt32(result) == 0)
            {
                frmMessageBox.ShowPopup("No tax information was found for " + lueProjList.Text + " in the previous year of " + (iYear).ToString() + ".");
            }
            else
            {

                ReflexCon.SQLExecutor.ExecuteNonQuery("exec LD_LOT_TAX_LoadNewYear '" + ReflexCon.MLUser + "', " + iPri_ID.ToString() + ", " + iYear.ToString() + ", " + (deTaxAdjDate.EditValue == null || deTaxAdjDate.EditValue == DBNull.Value ? "null" : "'" + deTaxAdjDate.DateTime.ToString() + "'"), ReflexCon.TRConnection);
                if (ReflexCon.SQLExecutor.Exception != null)
                {
                    frmMessageBox.ShowPopup("There was a problem processing your new year load: " + ReflexCon.SQLExecutor.Exception.Message);
                    return;
                }

                frmMessageBox.ShowPopup("New year loaded.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}