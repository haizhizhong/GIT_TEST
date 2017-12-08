using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities
{
    public partial class frmAddtionalDatesSelection : DevExpress.XtraEditors.XtraForm
    {

        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private int iPri_ID = -1;
        private TUC_GridG.GridG ggSelection;

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

        #endregion Properties

        public frmAddtionalDatesSelection(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, int pPri_ID)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            iPri_ID = pPri_ID;

            sqlTR.ConnectionString = ReflexCon.TRConnection;

            ReflexCon.SQLExecutor.ExecuteNonQuery(@"Delete working_AddtionalDates_Select where username = '" + ReflexCon.MLUser + @"'
Insert into working_AddtionalDates_Select(username, LD_AdditionalDates_ID, Description, OffsetDays, AdditionalDates_ID, OffSetDaysDesc, Selected)
Select '" + ReflexCon.MLUser + @"', AD.ID, AD.Description, AD.OffSetDays, AD.AdditinalDates_ID, OSD.Description, 0
From LD_AdditionalDates AD
Left Outer Join LD_AdditionalDates OSD on OSD.ID = AD.AdditinalDates_ID
Where AD.ID not in (Select LD_Proj_AdditionalDates.AdditionalDates_ID From LD_Proj_AdditionalDates where pri_id = " + iPri_ID.ToString() + @") ", ReflexCon.TRConnection);
        }

        private void frmAddtionalDatesSelection_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dsSelection1.Clear();
            daSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daSelection.Fill(dsSelection1);

            ggSelection = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvSelection, daSelection, dsSelection1);
            ggSelection.AskBeforeDelete = false;
            ggSelection.AllowTabCreateNewRecord = false;
            ggSelection.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(ggSelection_AllowDelete);

            dxStyle.FormInit(this);
        }

        private bool ggSelection_AllowDelete(object sender, DataRow row)
        {
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gvSelection.UpdateCurrentRow();

            object oCount = ReflexCon.SQLExecutor.ExecuteScalar("Select Count(1) From working_AddtionalDates_Select where username = '" + ReflexCon.MLUser + "' and Selected = 1", ReflexCon.TRConnection);
            int iCount = 0;
            try { iCount = Convert.ToInt32(oCount); }
            catch { }

            if (iCount <= 0)
            {
                frmMessageBox.ShowPopup("Please select at least one date.");
                return;
            }

            ReflexCon.SQLExecutor.ExecuteNonQuery(@"Insert into LD_Proj_AdditionalDates(pri_id, AdditionalDates_ID, OffsetDays, OffsetDate_ID)
Select " + iPri_ID.ToString() + @", ID, OffSetDays, AdditinalDates_ID
From LD_AdditionalDates
Where ID not in (Select LD_Proj_AdditionalDates.AdditionalDates_ID From LD_Proj_AdditionalDates where pri_id = " + iPri_ID.ToString() + @") 
	and ID in (Select LD_AdditionalDates_ID From working_AddtionalDates_Select where username = '" + ReflexCon.MLUser + @"' and Selected = 1)", ReflexCon.TRConnection);
            //and KeyDate = 0

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}