using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotPreSale
{
    public partial class frmLotPreSale : DevExpress.XtraEditors.XtraForm
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;
        private ucSummary ucSumm;
        private string isPre = "T";
        private int iAgreementID = -1;

        private bool bAgreementPATI = false;
        public bool AgreementPATI
        {
            set { bAgreementPATI = value; }
            get { return bAgreementPATI; }
        }

        private int PreSaleSeq = -1;

        private bool isTierPresale = false;

        public frmLotPreSale(HMConnection.HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, int AgreementID, bool IsMaster)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            this.Popup = new WS_Popups.frmPopup(DevXMgr);

            InitializeComponent();
            TR_Conn.ConnectionString = Connection.TRConnection;

            ucAccountingPicker1.UserName = Connection.MLUser;
            ucAccountingPicker1.ConnectionString = Connection.TRConnection;

            ucSumm = new ucSummary(Connection, DevXMgr);
            ucSumm.Dock = DockStyle.Fill;
            ucSumm.Parent = this;
            ucSumm.BringToFront();
            pSummary.Parent = ucSumm;

            if (Connection.CountryCode.ToUpper().Equals("U"))
            {
                colgst.Caption = "Tax 1";
                colpst.Caption = "Tax 2";
            }

            string sIsMaster = "'F'";
            if( IsMaster )
                sIsMaster = "'T'";
            Connection.SQLExecutor.ExecuteNonQuery("exec LD_FillLotAgreementScreen " + AgreementID + ", '" + Connection.MLUser + "', " + sIsMaster, Connection.TRConnection);

            iAgreementID = AgreementID;

            ucSumm.ucSP.Reset();
            ucSumm.ucSP.AdditionalParams = new object[] { ((DateTime)ucAccountingPicker1.SelectedEntryDate).ToShortDateString() };
            ucSumm.ucSP.Year = Convert.ToInt32(ucAccountingPicker1.SelectedYear);
            ucSumm.ucSP.Period = Convert.ToInt32(ucAccountingPicker1.SelectedPeriod);
            ucSumm.ucSP.LoadPreview();
            
            daSummary.SelectCommand.Parameters["@username"].Value = Connection.MLUser;
            dsSummary1.Clear();
            daSummary.Fill(dsSummary1);
            gvSummary_FocusedRowChanged(null, null);
            btnPost.Enabled = false;

             object result = Connection.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for Tier Pre-Sale:" + Connection.SQLExecutor.Exception.Message);
            else if (Convert.ToBoolean(result))
            {
                isTierPresale = true;
            }
            else
            {
                colPresaleSeq.Visible = false;
                colPresaleSeq.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void frmLotPreSale_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (Popup.ShowPopup(this, "Are you sure you want to update the presale deposits, and post to " + PeriodName(ucAccountingPicker1.SelectedPeriod) +
                    " " + ucAccountingPicker1.SelectedYear + " (Period " + ucAccountingPicker1.SelectedPeriod + ") ?", WS_Popups.frmPopup.PopupType.OK_Cancel)
                    == WS_Popups.frmPopup.PopupResult.OK)
            {
                ucSumm.ucSP.AdditionalParams = new object[] { ((DateTime)ucAccountingPicker1.SelectedEntryDate).ToShortDateString() };
                ucSumm.ucSP.Year = Convert.ToInt32(ucAccountingPicker1.SelectedYear);
                ucSumm.ucSP.Period = Convert.ToInt32(ucAccountingPicker1.SelectedPeriod);

                ucSumm.ucSP.ProcessSelection();
                if (ucSumm.ucSP.SubledgerValid)
                {
                    isPre = "F";
                    btnPrintRegister.Text = "Print Presale Deposit Register";
                    btnPost.Enabled = false;
                    btnCancel.Text = "Close";
                    btnPrintRegister_Click(btnPrintRegister, null);
                    
                }
            }
        }

        private string PeriodName(int period)
        {
            string PeriodName = "";
            string sSelect = "select top 1 datename( M, end_date) from gl_periods where period = " + period;
            object oPeriod = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            if (oPeriod != null && oPeriod != DBNull.Value)
            {
                PeriodName = oPeriod.ToString();
            }
            return PeriodName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "Close")
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ucAccountingPicker1_SelectedPeriodChanged(object sender, EventArgs e)
        {
            if (ucSumm != null)
                ucSumm.ucSP.Period = Convert.ToInt32(ucAccountingPicker1.SelectedPeriod);
        }

        private void ucAccountingPicker1_SelectedYearChanged(object sender, EventArgs e)
        {
            if( ucSumm != null )
                ucSumm.ucSP.Year = Convert.ToInt32(ucAccountingPicker1.SelectedYear);
        }

        private void gvSummary_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dsDeposits1.Clear();
            DataRow dr = gvSummary.GetDataRow(gvSummary.FocusedRowHandle);
            if (dr != null)
            {
                daDeposits.SelectCommand.Parameters["@agreement_id"].Value = dr["agreement_id"];                
                daDeposits.Fill(dsDeposits1);

                string sql = @"select min(isnull(dep.PresaleSeq,-1))
		from PROJ_LOT_AGREEMENT_DEPOSITS dep
		join LD_Deposits d on d.Deposit_ID = dep.deposit_id
		join working_ld_LotSearch h on h.agreement_id=dep.agreement_id	
		where h.username='"+Connection.MLUser+@"LotAgreementScreen' and h.selected = 1 and 
		ISNULL(d.type,'') = 'P' and isnull(dep.processed,'F') = 'F' and dep.agreement_id =" + dr["agreement_id"];
                object result = Connection.SQLExecutor.ExecuteScalar(sql, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                {
                    Popup.ShowPopup("Error checking for pre-sale sequence:"+Connection.SQLExecutor.Exception.Message);

                }
                else if (result != null && result != DBNull.Value)
                {
                    PreSaleSeq = Convert.ToInt32(result);
                }
                else
                    PreSaleSeq = -1;

            }
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //NEED TO RE-DO REPORT PROC TO HAVE THIS WORK OFF SOMETHING OTHER THAN THE AGREEMENT WORKING TABLES
                //if(!bAgreementPATI)
                //    Connection.SQLExecutor.ExecuteNonQuery("exec LD_laa_AgreementEdit_Fill '" + Connection.MLUser + "', " + iAgreementID.ToString(), Connection.TRConnection);
                //else
                //    Connection.SQLExecutor.ExecuteNonQuery("exec LD_laa_AgreementEdit_Fill '" + Connection.MLUser + "LPS', " + iAgreementID.ToString(), Connection.TRConnection);

                string[,] saParam = new string[2, 7];
                saParam[0, 0] = "@Username";
                saParam[1, 0] = Connection.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = isPre;
                saParam[0, 2] = "@Year";
                saParam[1, 2] = ucAccountingPicker1.SelectedYear.ToString();
                saParam[0, 3] = "@Period";
                saParam[1, 3] = PeriodName( ucAccountingPicker1.SelectedPeriod);
                saParam[0, 4] = "@Date";
                saParam[1, 4] = ucAccountingPicker1.editEntryDate.DateTime.ToShortDateString();
                saParam[0, 5] = "@SubNo";
                saParam[1, 5] = ucSumm.ucSP.SubledgerNo;
                saParam[0, 6] = "@Calling_Function";
                saParam[1, 6] = "LAS";
                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(Connection, DevXMgr, saParam, "LD_LotPreSaleRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                    
                    if(isPre == "T")
                        btnPost.Enabled = true;
                }
            }
            catch { }

            
        }

       

        private void gvDeposit_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (isTierPresale && e.RowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                DataRow row = gvDeposit.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    int rowSeq = -1;
                    try { rowSeq = Convert.ToInt32(row[colPresaleSeq.FieldName]); }
                    catch { }
                    if (rowSeq != PreSaleSeq)
                    {
                        e.Appearance.BackColor = Color.LightGray;
                        e.Appearance.BackColor2 = Color.LightGray;

                    }
                }
            }
        }
    }
}