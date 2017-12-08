using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ProjectUtilities
{
    public partial class frmAgreementExt : DevExpress.XtraEditors.XtraForm
    {


        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        DateTime _OldExpPayoutDate;
        int _AgreementID = -1;

        public frmAgreementExt(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int Agreement_ID)
        {
            InitializeComponent();
            _AgreementID = Agreement_ID;
            hmCon = connection;
            tuc_mgr = tuc;
            popup = new WS_Popups.frmPopup(tuc);
            object result = hmCon.SQLExecutor.ExecuteScalar("select payout_date from PROJ_LOT_AGREEMENT where agreement_id = " + Agreement_ID, hmCon.TRConnection);

            if (result != null && result != DBNull.Value)
            {
                _OldExpPayoutDate = (DateTime)result;
            }
            

			
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(deNewDate.EditValue == null || deNewDate.EditValue == DBNull.Value)
            {
                popup.ShowPopup("New date is required.");
            }
            else if (_OldExpPayoutDate != null && _OldExpPayoutDate.CompareTo(deNewDate.DateTime) > 0)
            {
                popup.ShowPopup("New date must be later then the current date.");
            }
            else
            {
                                   
                string sql = "insert into Proj_Lot_Agreement_Extension_Hist (Agreement_ID,PreviousDate,NewDate,Comment,ExtendedBy,DateModified,SendNotification)" +
                    "select " + _AgreementID + "," + ((_OldExpPayoutDate.Year == 0001) ? "null" : "'" + _OldExpPayoutDate.ToShortDateString() + "'") + " , '" + deNewDate.DateTime.ToShortDateString() + "','" + memoEdit1.Text.Replace("'", "''") +"','"+hmCon.MLUser+"',getdate(),"+(ceSndNotification.Checked?"1":"0") +
                    " UPDATE PROJ_LOT_AGREEMENT set payout_date = '" + deNewDate.DateTime.ToShortDateString() + "' where agreement_id = " + _AgreementID +
                    " update LD_Proj_Agreement_AddDates set OffsetDays = 0, OffsetDate_ID = null where AdditionalDates_ID = 6 and  Agreement_ID = "+_AgreementID;
                hmCon.SQLExecutor.ExecuteNonQuery(sql, hmCon.TRConnection);
                if ( ceSndNotification.Checked)
                    ExecPayoutExtensionReminder();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void ExecPayoutExtensionReminder()
        {
            int agreeID = _AgreementID;
            string sSQL = "exec PC_PayoutExtensionReminder " + agreeID.ToString() + ",'" + deNewDate.DateTime.ToShortDateString() +"'";
            DataTable dtAlert = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);

            string startPath = Application.StartupPath + @"\tmp\PayoutExtensionReminder";
            int iAlertID;
            foreach (DataRow dr in dtAlert.Rows)
            {
                iAlertID = Convert.ToInt32(dr["alert_id"]);

                SqlParameter[] sqlparams = new SqlParameter[5];

                sqlparams[0] = new SqlParameter("@Agreement_ID", agreeID);
                sqlparams[1] = new SqlParameter("@SkipTransfer", DBNull.Value);
                sqlparams[2] = new SqlParameter("@MLUser", DBNull.Value);
                sqlparams[3] = new SqlParameter("@Solicitor_ID", DBNull.Value);
                sqlparams[4] = new SqlParameter("@SigName", DBNull.Value);

                bool bSuccess = true;
                try
                {
                    sSQL = @"declare @AAP_ID int select @AAP_ID = 45
                        select DocMergeLibrary_ID from alert_land_reminder_docMerge where AlertID=@AAP_ID";
                    DataTable dtDocLib = hmCon.SQLExecutor.ExecuteDataAdapter(sSQL, hmCon.TRConnection);
                    if (dtDocLib != null)
                    {
                        foreach (DataRow drLib in dtDocLib.Rows)
                        {
                            object oDocMergeLibrary_ID = drLib["DocMergeLibrary_ID"];
                            if (oDocMergeLibrary_ID != null && oDocMergeLibrary_ID != DBNull.Value)
                            {
                                WordMerge2003.DocMergeElf elf = new WordMerge2003.DocMergeElf(hmCon);
                                bSuccess = elf.MergeItem(iAlertID, Convert.ToInt32(oDocMergeLibrary_ID), startPath, sqlparams);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    bSuccess = false;
                    LogException(e, "ALERT NOTIFICATION SERVICE", hmCon.WebConnection);
                }

                if (bSuccess)
                {
                    sSQL = @"update Alert set Complete_TF='T' where ID=" + iAlertID;
                    hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
                }
                else
                {
                    sSQL = @"exec AlertDelete " + iAlertID;
                    hmCon.SQLExecutor.ExecuteNonQuery(sSQL, hmCon.TRConnection);
                }
            }
        }

        private void LogException(Exception ex, string CmdText, string ConnStr)
        {
            string Username = "SERVER";

            string sInsert = "insert into SYSTEM_EXCEPTION ( USERNAME, COMPANYID, ERROR_DATE, COMMAND_TEXT, CONNECTION_STRING, EX_MESSAGE, EX_STACKTRACE ) " +
                "values ( '" + Username + "', " + hmCon.CompanyID + ", getdate(), '" + CmdText.Replace("'", "''") + "', '" + ConnStr.Replace("'", "") + "', '" + ex.Message.Replace("'", "") + "', '" + ex.StackTrace.Replace("'", "") + "' )";
            SqlCommand cmd = new SqlCommand(sInsert, new SqlConnection(hmCon.WebConnection));
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                    cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
        }
    }
}