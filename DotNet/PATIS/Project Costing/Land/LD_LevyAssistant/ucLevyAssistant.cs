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
    public partial class ucLevyAssistant : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;

        LD_LotSearch.ucLotSearch ucSearch;
        ucUpdate ucLevyUpdate;
        public ucLevyAssistant(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            //sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False ;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Reset();
        }

        private void SetBannerLabels()
        {
            if (tcDetails.SelectedTabPage == tpSearch)
            {
                topBanner1.BannerTitle = "Lot / Agreement Selection";
                topBanner1.BannerText = "Select the lot(s) you want to process.";
            }
            else if (tcDetails.SelectedTabPage == tpUpdate)
            {
                topBanner1.BannerTitle = "Levy Update";
                topBanner1.BannerText = "Enter changes manually and use the update button to update all.";
            }

            topBanner1.RefreshLabels();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcDetails.SelectedTabPage == tpUpdate)
            {
                btnNext.Text = "Next";
                btnNext.Enabled = true;
                tcDetails.SelectedTabPage = tpSearch;
            }
            else if (tcDetails.SelectedTabPage == tpSearch)
            {
                btnNext.Enabled = true;
                btnBack.Enabled = false;
                btnCancel.Enabled = false;
                tcMain.SelectedTabPage = tpMain;
            }
            SetBannerLabels();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                btnBack.Enabled = true;
                btnCancel.Enabled = true;
                if (ucSearch == null)
                    LoadSearch();
                ucSearch.RefreshMe();
                tcMain.SelectedTabPage = tpDetails;
            }
            else if (tcDetails.SelectedTabPage == tpSearch)
            {
                if (SearchValid())
                {
                    btnNext.Text = "Restart";
                    btnNext.Enabled = false;
                    if (ucLevyUpdate == null)
                        LoadUpdate();
                    ucLevyUpdate.RefreshMe();
                    tcDetails.SelectedTabPage = tpUpdate;
                }

            }
            else if(tcDetails.SelectedTabPage == tpUpdate)
            {
                Reset();
            }
            SetBannerLabels();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(pop.ShowPopup("Are you sure you want to cancel?",WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                Reset();
        }

        private void Reset()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpSearch;
            btnNext.Text = "Next";
            btnBack.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void LoadSearch()
        {
            ucSearch = new LD_LotSearch.ucLotSearch(con, tuc_mgr, LD_LotSearch.LotSearchType.LevyManagement);
            ucSearch.Dock = DockStyle.Fill;
            ucSearch.Parent = tpSearch;
            ucSearch.AllowSelected += UcSearch_AllowSelected;
            ucSearch.SelectAllNoneOverride += UcSearch_SelectAllNoneOverride;
        }

        private void UcSearch_SelectAllNoneOverride(bool bSelected)
        {
            string sql = "";
            if (bSelected)
            {
               
                    sql = @"Update working_ld_LotSearch Set Selected = 1
from working_ld_LotSearch s
where username = '" + ucSearch.SearchUsername.Replace("'", "''") + @"'
and s.proj_lot_id in(select l.proj_lot_id from PROJ_LOT l
join PROJ_LOT_AGREEMENT a on a.proj_lot_id = l.proj_lot_id and a.agreement_status_id <> 2/*Canceled*/
join PROJ_LOT_AGREEMENT_LEVY al on al.agreement_id = a.agreement_id and al.Matched = 0

)";
                    
               
            }
            else
            {//always unselect all
                sql = "Update working_ld_LotSearch Set Selected = 0 where username = '" + ucSearch.SearchUsername.Replace("'", "''") + "' ";
            }

            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Unable to update selection: " + con.SQLExecutor.Exception.Message);
        }

        private bool UcSearch_AllowSelected(int proj_lot_id)
        {
            bool returnvalue = false;
            string sql = @"select count(*) from PROJ_LOT l
join PROJ_LOT_AGREEMENT a on a.proj_lot_id = l.proj_lot_id and a.agreement_status_id <> 2/*Canceled*/
join PROJ_LOT_AGREEMENT_LEVY al on al.agreement_id = a.agreement_id and al.Matched = 0
where l.proj_lot_id = " + proj_lot_id.ToString();


            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) > 0)
                    returnvalue = true;
                else
                    pop.ShowPopup("Agreement does not have any unmatched levies.");
            }

            return returnvalue;
        }

        private bool SearchValid()
        {
            bool returnValue = true;

            string sql = "select count(*) from working_ld_LotSearch s where s.selected = 1 and s.username = '" + ucSearch.SearchUsername.Replace("'", "''") + "'";
            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
            {
                pop.ShowPopup("Error checking for selections:" + con.SQLExecutor.Exception.Message);
                returnValue = false;
            }
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) == 0)
                {
                    pop.ShowPopup("You must select at least one agreement.");
                    returnValue = false;
                }
            }


            return returnValue;
        }
        private void LoadUpdate()
        {
            ucLevyUpdate = new ucUpdate(con, tuc_mgr,ucSearch.SearchUsername);
            ucLevyUpdate.Dock = DockStyle.Fill;
            ucLevyUpdate.Parent = tpUpdate;
            ucLevyUpdate.Updated += UcLevyUpdate_Updated;

        }

        private void UcLevyUpdate_Updated()
        {
            btnBack.Enabled = false;
            btnCancel.Enabled = false;
            btnNext.Enabled = true;
        }
    }
}
