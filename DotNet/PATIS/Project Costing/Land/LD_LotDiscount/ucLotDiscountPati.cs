using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotDiscount
{
    public partial class ucLotDiscountPati : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;

        LD_LotSearch.ucLotSearch ucSearch;
        ucChanges ucChange;
        ucReview ucRev;
        ucSummary ucSumm;
        

        public ucLotDiscountPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            //sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void SetBannerLabels()
        {
            if (tcDetails.SelectedTabPage == tpSearch)
            {
                topBanner1.BannerTitle = "Lot Selection";
                topBanner1.BannerText = "Select the lot(s) you want to process";
            }
            else if (tcDetails.SelectedTabPage == tpChanges)
            {
                topBanner1.BannerTitle = "Lot Discounts";
                if (rgAction.EditValue.ToString() == "N")
                    topBanner1.BannerText = "Enter your discounts and click next to continue.";
                else if (rgAction.EditValue.ToString() == "M")
                    topBanner1.BannerText = "Modify the discounts and click next to continue.";
                else if (rgAction.EditValue.ToString() == "R")
                    topBanner1.BannerText = "Select the discounts to reverse and click next to continue.";
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                topBanner1.BannerTitle = "Lot Discounts";
                if (rgAction.EditValue.ToString() == "N")
                    topBanner1.BannerText = "Review lot discounts and click next to continue.";
                else if (rgAction.EditValue.ToString() == "M")
                    topBanner1.BannerText = "";
                else if (rgAction.EditValue.ToString() == "R")
                    topBanner1.BannerText = "";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner1.BannerTitle = "Lot Discounts Summary";
                topBanner1.BannerText = "Review the lot discounts and click finish to complete the transaction";
            }

            topBanner1.RefreshLabels();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcDetails.SelectedTabPage == tpSearch)
            {
                btnBack.Enabled = false;
                tcMain.SelectedTabPage = tpMain;
            }
            else if (tcDetails.SelectedTabPage == tpChanges)
            {
                tcDetails.SelectedTabPage = tpSearch;
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                tcDetails.SelectedTabPage = tpChanges;
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                btnNext.Text = "Next";
                btnNext.Enabled = true;
                if (rgAction.EditValue.ToString() == "N")
                    tcDetails.SelectedTabPage = tpReview;
                else
                    tcDetails.SelectedTabPage = tpChanges;
            }
            SetBannerLabels();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                if (ucSearch == null)
                    LoadSearch();
                tcDetails.SelectedTabPage = tpSearch;
                ucSearch.RefreshMe();
                tcMain.SelectedTabPage = tpDetails;
                btnBack.Enabled = true;
            }
            else if (tcDetails.SelectedTabPage == tpSearch)
            {
                if (SearchValid())
                {
                    if (ucChange == null)
                        LoadChanges();
                    ucChange.RefreshMe(rgAction.EditValue.ToString());
                    tcDetails.SelectedTabPage = tpChanges;
                }
            }
            else if (tcDetails.SelectedTabPage == tpChanges)
            {
                if (ChangesValid())
                {
                    if (rgAction.EditValue.ToString() == "N")
                    {
                        if (ucRev == null)
                            LoadReview();
                        ucRev.RefreshMe(ucChange.SelectedYear, ucChange.SelectedPeriod, ucChange.DiscountDate);
                        tcDetails.SelectedTabPage = tpReview;
                    }
                    else
                    {
                        btnNext.Text = "Finish";
                        btnNext.Enabled = false;
                        if (ucSumm == null)
                            LoadSummary();
                        ucSumm.RefreshMe(ucChange.SelectedYear, ucChange.SelectedPeriod, ucChange.DiscountDate,rgAction.EditValue.ToString());
                        tcDetails.SelectedTabPage = tpSummary;
                    }
                }
            }
            else if (tcDetails.SelectedTabPage == tpReview)
            {
                btnNext.Text = "Finish";
                btnNext.Enabled = false;
                if (ucSumm == null)
                    LoadSummary();
                ucSumm.RefreshMe(ucChange.SelectedYear, ucChange.SelectedPeriod, ucChange.DiscountDate,rgAction.EditValue.ToString());
                tcDetails.SelectedTabPage = tpSummary;

            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                if (btnNext.Text == "Restart")
                {
                    if (pop.ShowPopup("Are you sure you want to restart?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                        Reset();
                   
                }
                else if (ucSumm.Finish())
                {
                    btnBack.Enabled = false;
                    btnNext.Text = "Restart";
                }
            }
            SetBannerLabels();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(pop.ShowPopup("Are you sure you want to cancel?",WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                Reset();
        }

        public void Reset()
        {
            btnNext.Enabled = true;
            btnBack.Enabled = false;
            btnNext.Text = "Next";
            tcDetails.SelectedTabPage = tpSearch;
            tcMain.SelectedTabPage = tpMain;
        }

        private void LoadSearch()
        {
            ucSearch = new LD_LotSearch.ucLotSearch(con, tuc_mgr, LD_LotSearch.LotSearchType.LotDiscounts);
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
                if (rgAction.EditValue.ToString() == "N")
                {
                    sql = "Update working_ld_LotSearch Set Selected = 1 where username = '" + ucSearch.SearchUsername.Replace("'", "''") + "' ";
                }
                else if (rgAction.EditValue.ToString() == "M")
                {
                   sql = @"Update working_ld_LotSearch Set Selected = 1
from working_ld_LotSearch s
where username = '" + ucSearch.SearchUsername.Replace("'", "''") + @"'
and s.proj_lot_id in(
select l.proj_lot_id from PROJ_LOT l
join PROJ_LOT_AGREEMENT a on a.proj_lot_id = l.proj_lot_id and a.agreement_status_id <> 2/*Canceled*/
join PROJ_LOT_AGREEMENT_DISCOUNTS d on d.agreement_id = a.agreement_id and d.unsoldReversed = 0
)";
                    pop.ShowPopup("Agreements with no discounts will not be selected.");
                }
                else if (rgAction.EditValue.ToString() == "R")
                {
                    sql = @"Update working_ld_LotSearch Set Selected = 1
from working_ld_LotSearch s
where username = '" + ucSearch.SearchUsername.Replace("'", "''") + @"'
and s.proj_lot_id in(
select l.proj_lot_id from PROJ_LOT l
join PROJ_LOT_AGREEMENT a on a.proj_lot_id = l.proj_lot_id and a.agreement_status_id <> 2/*Canceled*/
join PROJ_LOT_AGREEMENT_DISCOUNTS d on d.agreement_id = a.agreement_id and d.unsoldReversed = 0
)";
                    pop.ShowPopup("Agreements with no discounts will not be selected.");
                }
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
            bool returnValue = true;



            if (rgAction.EditValue.ToString() == "N")
            {

            }
            else if (rgAction.EditValue.ToString() == "M")
            {
                if (!HasDiscounts(proj_lot_id))
                {
                    pop.ShowPopup("Agreement does not have any discounts.");
                    returnValue = false;
                }
            }
            else if (rgAction.EditValue.ToString() == "R")
            {
                if (!HasDiscounts(proj_lot_id))
                {
                    pop.ShowPopup("Agreement does not have any discounts.");
                    returnValue = false;
                }
            }




            return returnValue;
        }

        private bool HasDiscounts(int proj_lot_id)
        {
            bool returnvalue = false;
            string sql = @"select count(*) from PROJ_LOT l
join PROJ_LOT_AGREEMENT a on a.proj_lot_id = l.proj_lot_id and a.agreement_status_id <> 2/*Canceled*/
join PROJ_LOT_AGREEMENT_DISCOUNTS d on d.agreement_id = a.agreement_id and d.unsoldReversed = 0
where l.proj_lot_id = "+ proj_lot_id.ToString();


            Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) > 0)
                    returnvalue = true;
            }

            return returnvalue;
        }



        private void LoadChanges()
        {
            ucChange = new ucChanges(con, tuc_mgr, ucSearch.SearchUsername);
            ucChange.Dock = DockStyle.Fill;
            ucChange.Parent = tpChanges;
            tuc_mgr.FormInit(ucChange);
        }

        private void LoadReview()
        {
            ucRev = new ucReview(con, tuc_mgr, ucSearch.SearchUsername);
            ucRev.Dock = DockStyle.Fill;
            ucRev.Parent = tpReview;
            tuc_mgr.FormInit(ucRev);
        }

        private void LoadSummary()
        {
            ucSumm = new ucSummary(con, tuc_mgr, ucSearch.SearchUsername);
            ucSumm.Dock = DockStyle.Fill;
            ucSumm.PreRegisterPrinted += UcSumm_PreRegisterPrinted;
            ucSumm.Parent = tpSummary;
            tuc_mgr.FormInit(ucSumm);
        }

        private void UcSumm_PreRegisterPrinted()
        {
            btnNext.Enabled = true;

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
        private bool ChangesValid()
        {
            bool returnvalue = true;

            //validate changes are after a lot sale
            string sql = @"select top 1 p.AR_YEAR,p.PERIOD from working_ld_LotSearch s
join SO_TRN_HDR h on h.agreement_id = s.agreement_id and h.SO_TYPE_ID in(select t.SO_TYPE_ID from SO_TYPE t where t.SO_TYPE_CODE = 'LS')
join AR_PERIODS p on p.AR_YEAR = h.ACCT_YEAR and p.PERIOD = h.ACCT_PERIOD
where s.username = '"+ucSearch.SearchUsername.Replace("'","''")+"' and s.selected = 1 order by p.END_DATE desc";

            DataTable dtResult = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
            else if (dtResult != null)
            {
                if (dtResult.Rows.Count > 0)
                {
                    int MaxYear = Convert.ToInt32(dtResult.Rows[0][0]);
                    int MaxPeriod = Convert.ToInt32(dtResult.Rows[0][1]);
                    string message = "";
                    if (MaxYear > ucChange.ucAccountingPicker1.SelectedYear)
                    {
                        message = "Discount modifications can only happen after a lot sale. \r\n Please select a period equal to or later than " + MaxYear.ToString() + "/" + MaxPeriod;
                    }
                    else if (MaxYear == ucChange.ucAccountingPicker1.SelectedYear && MaxPeriod > ucChange.ucAccountingPicker1.SelectedPeriod)
                    {
                        message = "Discount modifications can only happen after a lot sale. \r\n Please select a period equal to or later than " + MaxYear.ToString() + "/" + MaxPeriod;
                    }
                    if (message != "")
                    {
                        pop.ShowPopup(message);
                        returnvalue = false;
                    }

                }

               
            }

            if(returnvalue)
            {
                if (rgAction.EditValue.ToString() == "N")
                {//add the 'V' records as new discount's are one(discount record) to many(agreements).
                    sql = "exec LD_DiscountPati_LoadReview '" + ucSearch.SearchUsername.Replace("'", "''") + "'";
                    con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
                    if (con.SQLExecutor.Exception != null)
                    {
                        pop.ShowPopup("Error validating invoice balances: " + con.SQLExecutor.Exception.Message);
                    }

                }
                sql = @"select s.agreement_num,h.BALANCE + isnull(ad.AmountDiscounted,0)[Remaining],h.BALANCE
from working_ld_discounts d
join working_ld_LotSearch s on s.ID = d.working_ld_lot_search_id
join SO_TRN_HDR h on h.agreement_id = s.agreement_id and h.SO_TYPE_ID in(select t.SO_TYPE_ID from SO_TYPE t where t.SO_TYPE_CODE = 'LS')
left outer join PROJ_LOT_AGREEMENT_DISCOUNTS ad on ad.PROJ_LOT_AGREEMENT_DISCOUNTS_ID = d.PROJ_LOT_AGREEMENT_DISCOUNTS_ID and d.ActionRequired = 'M'
/*only add the original discount for modifications*/
where s.username = '" + ucSearch.SearchUsername.Replace("'", "''") + @"' and s.selected = 1 and d.selected = 1
group by s.agreement_num,h.BALANCE,isnull(ad.AmountDiscounted, 0)
having sum(d.amount) > h.BALANCE + isnull(ad.AmountDiscounted, 0)";
                dtResult = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
                else if (dtResult != null)
                {
                    if (dtResult.Rows.Count > 0)
                    {
                       
                        string message = "The following agreement(s) discounts are too large .";

                        foreach (DataRow row in dtResult.Rows)
                        {
                          
                            message = message + "\r\n Agreement #: " + row[0].ToString() + "  Maximum discount:" + Convert.ToDecimal( row[1]).ToString("N");
                        }
                            pop.ShowPopup(message);
                            returnvalue = false;
                    }



                }
            }


            if (returnvalue)
            {

                sql = "select count(*) from working_ld_discounts where selected = 1 and username = '"+ ucSearch.SearchUsername.Replace("'", "''") + "'";
                Object result = con.SQLExecutor.ExecuteScalar(sql, con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error :" + con.SQLExecutor.Exception.Message);
                else if (result != null && result != DBNull.Value)
                {
                    if (Convert.ToInt32(result) == 0)
                    {
                        if(rgAction.EditValue.ToString() == "N")
                            pop.ShowPopup("You must add at least one discount to process.");
                        else
                            pop.ShowPopup("You must select at least one discount to process.");
                        returnvalue = false;
                    }
                }
            }




            return returnvalue;
        }

        private bool FinishClicked()
        {
            bool returnValue = false;

            if (ucSumm.Finish())
            {
                returnValue = true;
                this.btnBack.Enabled = false;
                this.btnNext.Text = "Restart";
            }


            return returnValue;
        }

    }
}
