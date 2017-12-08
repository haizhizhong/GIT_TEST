using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HM_Report_Printer;

namespace LD_SpecHomeOwnerUpdate
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables declared here

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private WS_Popups.frmPopup Popups;
        

        public ucSpecHomeOwnerUpdate specHomeOwnerUpdateMain;
        
        #endregion


        public ucSummary(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            sqlConnTR.ConnectionString = hmConn.TRConnection;
            Popups = new WS_Popups.frmPopup(hmDevMgr);
           
            
        }
        public void SetupPrintButtons()
        {
            btnPrintRegister.SendToBack();
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            PrintPreRegister("F");
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PrintPreRegister("T");
        //        specHomeOwnerUpdateMain.btnFinish.Enabled = true;
        //        btnPrintRegister.BringToFront();
        //        btnPrintRegister.Enabled = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        Popups.ShowPopup("Error found btnPrint_Click process:" + ex.Message.ToString());
        //    }
        //}
        private void PrintPreRegister(string preRegister)
        {
            try
            {
                string[,] saParams = new string[2, 2];
                saParams[0, 0] = "@username";
                saParams[1, 0] = this.hmConn.MLUser;
                saParams[0, 1] = "@PreReg";
                saParams[1, 1] = preRegister;
                frmHM_Report_Printer HMRP = new frmHM_Report_Printer(this.hmConn, this.hmDevMgr, saParams, "WS_SpecHomeOwnerUpdateRegX.rpt", frmHM_Report_Printer.DBFlavor.TR);
                HMRP.ShowDialog();
                IDisposable dispose = HMRP;
                dispose.Dispose();


            }
            catch (Exception ex)
            {
                this.Popups.ShowPopup("Error found in btnPrint_Click in ucSummary:" + ex.Message + ex.StackTrace);
            }
            
        }

        public void LoadSummary(string sStype)
        {
            dsSummary1.Clear();
            daSummary.SelectCommand.Parameters["@username"].Value = hmConn.MLUser;
            daSummary.SelectCommand.Parameters["@type"].Value = sStype;
            daSummary.Fill(dsSummary1);
        }

        public string VerifySelection()
        {
            string msg = "";
            if (dsSummary1.Tables[0].Rows.Count == 0)
                msg = "Any records that do not have an area manager associated will not show in the summary screen.";
            return msg;
        }
        //
    }
}
