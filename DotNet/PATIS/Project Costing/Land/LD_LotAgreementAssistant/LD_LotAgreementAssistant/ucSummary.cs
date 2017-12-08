using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAgreementAssistant
{
    public partial class ucSummary : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        bool isFilling = false;
        private string _type = "";
        private string isPre = "T";
        public delegate void Delegate_Action_Clicked();
        public event Delegate_Action_Clicked RegisterPrinted;
        public object MasterAgreementID = "Started";
        public int Agreement_ID = -1;
        private string sReportType = "A";
        private bool isTierPresale = false;

        public ucSummary(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
           sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_AgreementDetails.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_depositsDetail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            daLevyDetail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            daDiscountSummary.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;

            if (hmCon.CountryCode == "C")
            {
                colgst.Caption = "GST";
                colpst.Caption = "PST";
            }
            else if (hmCon.CountryCode == "U")
            {
                colgst.Caption = "Tax 1";
                colpst.Caption = "Tax 2";
            }

            SetupLevels();

            object result = hmCon.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error checking for Tier Pre-Sale:" + hmCon.SQLExecutor.Exception.Message);
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

        private void SetupLevels()
        {
            string sSQL = @"select  isnull(lv1_land_desc,'')[lv1_land_desc], isnull(lv2_land_desc,'')[lv2_land_desc],
                isnull(lv3_land_desc,'')[lv3_land_desc], isnull(lv4_land_desc,'')[lv4_land_desc], 
                isnull(lv1_active_land,'F')[lv1_active_land], isnull(lv2_active_land,'F')[lv2_active_land], 
                isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] 
            from proj_cntl";

            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        collv1id.Caption = dr["lv1_land_desc"].ToString();
                        collv2id.Caption = dr["lv2_land_desc"].ToString();
                        collv3id.Caption = dr["lv3_land_desc"].ToString();
                        collv4id.Caption = dr["lv4_land_desc"].ToString();

                        collv1id.OptionsColumn.ShowInCustomizationForm = collv1id.Visible = (dr["lv1_active_land"].ToString() == "T");
                        collv2id.OptionsColumn.ShowInCustomizationForm = collv2id.Visible = (dr["lv2_active_land"].ToString() == "T");
                        collv3id.OptionsColumn.ShowInCustomizationForm = collv3id.Visible = (dr["lv3_active_land"].ToString() == "T");
                        collv4id.OptionsColumn.ShowInCustomizationForm = collv4id.Visible = (dr["lv4_active_land"].ToString() == "T");
                    }
                }
            }
        }

        public bool PostDeposits
        {
            get
            {
                return cePostPreSale.Checked;
            }
        }

        public int NumberOfAgreements
        {
            get
            {
                return gvSummary.RowCount;
            }
        }


        public void RefreshMe(string type)
        {
            isPre = "T";
            _type = type;
            btnAgreementDocuments.Visible = false;
            btnMastAgreeDoc.Visible = false;
            if (_type == "Edit" || _type == "NewAgree")
            {
               btnPrintRegister.Text = "Print Pre-Register";
               sReportType = "A";
            }
            else
            {
                btnPrintRegister.Text = "Print Master Agreement Pre-Register";
                sReportType = "M";

                try
                {
                    int masterID = Convert.ToInt32(MasterAgreementID);
                    string sql = "update working_ld_laa_proj_lot_agreement set master_agree_id = "+masterID.ToString()+" where username = '"+hmCon.MLUser+"'";
                    hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                }
                catch { }
            }
            try
            {
                isFilling = true;
                

                ds_purchasers1.Clear();
                da_purchasers.Fill(ds_purchasers1);
                ds_lueDepositType1.Clear();
                da_lueDepositType.Fill(ds_lueDepositType1);
                dsLevyDetail.Clear();

                ds_summary1.Clear();
                da_AgreementDetails.Fill(ds_summary1);
                deAgreementDate.DateTime = getAgreementDate();
                isFilling = false;

                object oCount = hmCon.SQLExecutor.ExecuteScalar("SELECT Count(pre_sale) FROM working_ld_laa_proj_lot_agreement WHERE IsNull(pre_sale,0) = 1 and (username = '" + hmCon.MLUser + "')", hmCon.TRConnection);
                int iCount = -1;
                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount > 0)
                {
                    cePostPreSale.Visible = true;
                }
                else
                {
                    cePostPreSale.Visible = false;
                    cePostPreSale.Checked = false;
                }

            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error in refresh me:" + ex.Message);
            }
            gvSummary_FocusedRowChanged(gvSummary, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvSummary.FocusedRowHandle));

        }

        public DateTime getAgreementDate()
        {
            DateTime date = DateTime.Now;
            if (gvSummary.RowCount > 0)
            {
                try
                {
                    date = Convert.ToDateTime( gvSummary.GetDataRow(gvSummary.FocusedRowHandle)["agreement_date"]);
                }
                catch
                {

                }
            }

            return date;
        }


        private void gvSummary_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            DataRow row = gvSummary.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                da_depositsDetail.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                ds_depositsDetail1.Clear();
                da_depositsDetail.Fill(ds_depositsDetail1);

                daLevyDetail.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                dsLevyDetail.Clear();
                daLevyDetail.Fill(dsLevyDetail);

                daDiscountSummary.SelectCommand.Parameters["@agreement_id"].Value = row[colagreement_id.FieldName];
                dsDiscountSummary1.Clear();
                daDiscountSummary.Fill(dsDiscountSummary1);
            }
        }

        public bool Finish()
        {
            bool completed = true;
            string sql = "LD_laa_FinishAssistant";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql);
            cmd.Connection = new System.Data.SqlClient.SqlConnection(hmCon.TRConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@message", SqlDbType.VarChar,8000).Direction = ParameterDirection.InputOutput;
            cmd.Parameters["@message"].Value = MasterAgreementID.ToString();

            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = hmCon.MLUser;

            cmd.Parameters.Add("@type", SqlDbType.VarChar);
            cmd.Parameters["@type"].Value = _type;

            
            try
            {
                cmd.Connection.Open();
                object result = cmd.ExecuteScalar();
                Agreement_ID = Convert.ToInt32(result);
                cmd.Connection.Close();

                if (cmd.Parameters["@message"].Value.ToString().ToLower() == "ok")
                {
                    popup.ShowPopup("Update complete.");
                    if (_type == "Edit" || _type == "NewAgree")
                        btnPrintRegister.Text = "Print Register";
                    else
                        btnPrintRegister.Text = "Print Master Agreement Register";
                    btnAgreementDocuments.Visible = true;                    
                    isPre = "F";
                    da_AgreementDetails.Fill(ds_summary1);

                    object oMaster_agreement_num = gvSummary.GetFocusedRowCellValue("master_agreement_num");
                    if (oMaster_agreement_num != null && oMaster_agreement_num != DBNull.Value)
                    {
                        if( Convert.ToInt32(oMaster_agreement_num) > 0 )
                            btnMastAgreeDoc.Visible = true;
                    }                    
                }
                else
                {
                    popup.ShowPopup(cmd.Parameters["@message"].Value.ToString());
                    completed = false;
                }
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error :" + ex.Message);
                completed = false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }            

            return completed;
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] saParam = new string[2, 3];
                saParam[0, 0] = "@Username";
                saParam[1, 0] = hmCon.MLUser;
                saParam[0, 1] = "@PreReport";
                saParam[1, 1] = isPre;
                saParam[0, 2] = "@Type";
                saParam[1, 2] = sReportType;

               
                using (HM_Report_Printer.frmHM_Report_Printer ReportPrinter =
                    new HM_Report_Printer.frmHM_Report_Printer(hmCon, tuc_mgr, saParam, "LD_MasterAgreementRegX.rpt", HM_Report_Printer.frmHM_Report_Printer.DBFlavor.TR))
                {
                    ReportPrinter.ShowDialog();
                }
            }
            catch {}

            if (RegisterPrinted != null)
                RegisterPrinted();
        }

        private void btnAgreementDocuments_Click(object sender, EventArgs e)
        {   
            DataRow dr = gvSummary.GetDataRow(gvSummary.FocusedRowHandle);
            if (dr != null)
            {
                using (LD_Agree_WordMerge.frmAgreeDocs frm = new LD_Agree_WordMerge.frmAgreeDocs(hmCon, tuc_mgr, Convert.ToInt32(dr[colagreement_id.FieldName]) ))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void btnMastAgreeDoc_Click(object sender, EventArgs e)
        {
            DataRow dr = gvSummary.GetFocusedDataRow();
            if (dr != null)
            {
                object oAgreement_ID = dr["agreement_id"];
                if (oAgreement_ID == null || oAgreement_ID == DBNull.Value)
                    oAgreement_ID = -1;
                string sSQL = @"select lot_master_agreement_id from PROJ_LOT_MASTER_AGREEMENT_DETAIL where LOT_AGREEMENT_ID=" + oAgreement_ID;
                object oMasterAgreement_ID = hmCon.SQLExecutor.ExecuteScalar(sSQL, hmCon.TRConnection);
                if (oMasterAgreement_ID != null && oMasterAgreement_ID != DBNull.Value)
                {
                    using (LD_MastAgree_WordMerge.frmMastAgreeDocs frm = new LD_MastAgree_WordMerge.frmMastAgreeDocs(hmCon, tuc_mgr, Convert.ToInt32(oMasterAgreement_ID)))
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    popup.ShowPopup("Error loading master agreement.");
                }
            }
        }

        private void dockPanel3_Click(object sender, EventArgs e)
        {

        }
    }
}
