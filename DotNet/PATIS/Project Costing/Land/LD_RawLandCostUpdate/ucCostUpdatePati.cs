using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandCostUpdate
{
    public partial class ucCostUpdatePati : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private int _Proj_LD_RawLandHolding_ID = -1;
        ucCostSelection ucSelection;
        ucSummary ucSumm;

        public ucCostUpdatePati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
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

        public void RefreshPati(int PROJ_LD_RawLandHolding_ID)
        {
            _Proj_LD_RawLandHolding_ID = PROJ_LD_RawLandHolding_ID;
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpSelection;
            btnBack.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcDetails.SelectedTabPage == tpSelection)
            {
                RefreshPati(_Proj_LD_RawLandHolding_ID);
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                tcDetails.SelectedTabPage = tpSelection;
                btnNext.Enabled = true;
                btnNext.Text = "Next";
            }
            SetTopBannerText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                LoadSelection();
                tcMain.SelectedTabPage = tpDetails;
                btnBack.Enabled = true;
            }
            else if (tcDetails.SelectedTabPage == tpSelection)
            {
                if (SelectionValid())
                {
                    btnNext.Enabled = false;
                    LoadSummary();
                    btnNext.Text = "Finish";
                    
                    tcDetails.SelectedTabPage = tpSummary;
                    
                }
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                
                    if (ucSumm.Finish())
                    {
                        btnNext.Enabled = false;
                        btnBack.Enabled = false;
                    }
                
            }
            SetTopBannerText();
        }

        private void SetTopBannerText()
        {
            if (tcDetails.SelectedTabPage == tpSelection)
            {
                topBanner.BannerText = "Select filter criteria and click on refresh.";
                topBanner.BannerTitle = "Cost Selection";
            }
            else if (tcDetails.SelectedTabPage == tpSummary)
            {
                topBanner.BannerText = "Print Pre-Register then click Finish to update pati.";
                topBanner.BannerTitle = "Cost Summary";
            }
            topBanner.RefreshLabels();
        }

        private void LoadSelection()
        {
            if (ucSelection == null)
            {
                ucSelection = new ucCostSelection(con, tuc_mgr);
                ucSelection.Dock = DockStyle.Fill;
                ucSelection.Parent = tpSelection;
            }
            ucSelection.RefreshSelection(_Proj_LD_RawLandHolding_ID);
        }

        private bool SelectionValid()
        {
            bool returnValue = false;
            object result = con.SQLExecutor.ExecuteScalar("select count(*) from working_ld_costs_to_transfer where username = '" + con.MLUser + "' and isnull(NewTransferAmount,0) != 0", con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error validing selections:" + con.SQLExecutor.Exception.Message);
            else if (result != null && result != DBNull.Value)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    returnValue = true;
                }
                else
                {
                    pop.ShowPopup("At leaset one cost must have a new transfer amount.");
                    return false;
                }
            }

            if (ucSelection.MatchLevel.Equals("M"))
            {
                string sSQL = @"select count(*)
                from working_ld_costs_to_transfer 
                where username='" + con.MLUser + @"' and isnull(levelsvalid,0) = 0 and isnull(NewTransferAmount,0) <> 0";
                object oCNT = con.SQLExecutor.ExecuteScalar(sSQL, con.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;

                if (Convert.ToInt32(oCNT) > 0)
                {
                    pop.ShowPopup("At leaset one development project cost code does not exist for the corresponding raw land project cost code. Either use 'Single Cost Code' transfer option, zero out the 'New Transfer Amount' or setup the corresponding cost codes on the development project and try again.");
                    return false;
                }
                else
                {
                    returnValue = true;
                }
            }


            return returnValue;
        }

        private void LoadSummary()
        {
            if (ucSumm == null)
            {
                ucSumm = new ucSummary(con, tuc_mgr);
                ucSumm.Dock = DockStyle.Fill;
                ucSumm.Parent = tpSummary;
                ucSumm.PrintPreRegisterClick += new ucSummary.DelegatePrintPreRegisterClick(ucSumm_PrintPreRegisterClick);
            }
            ucSumm.RefreshSummary(ucSelection.GL_Year,ucSelection.GL_Period);
        }

        void ucSumm_PrintPreRegisterClick()
        {
            if(btnBack.Enabled)
                btnNext.Enabled = true;
        }


    }
}
