using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotAgreementAssistant
{
    public partial class frmMasterAgreeemntSelection : DevExpress.XtraEditors.XtraForm
    {

        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        int iPri_ID = -1;
        int purchaser1_ID = -1;
        int purchaser2_ID = -1;
        int purchaser3_ID = -1;
        bool hasAgreementsInSelection = false;
        

        public frmMasterAgreeemntSelection(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, int pPriID,int pur1_ID,int pur2_ID,int pur3_ID,bool HasAgreeInSelect)
        {
            InitializeComponent();
            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            iPri_ID = pPriID;
            purchaser1_ID = pur1_ID;
            purchaser2_ID = pur2_ID;
            purchaser3_ID = pur3_ID;
            hasAgreementsInSelection = HasAgreeInSelect;

            popup = new WS_Popups.frmPopup(tuc);
			
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lueMasterAgreement.EditValue != null && lueMasterAgreement.EditValue != DBNull.Value)
            {
                if(hasAgreementsInSelection)
                {
                    object result = hmCon.SQLExecutor.ExecuteScalar(@"select COUNT(*) from PROJ_LOT_MASTER_AGREEMENT_DETAIL d
                    join PROJ_LOT_AGREEMENT a on a.agreement_id = d.LOT_AGREEMENT_ID
                    where ISNULL(a.purchaser_id,-1) != "+purchaser1_ID.ToString()+
                    " or ISNULL(a.purchaser_id2,-1) != "+purchaser2_ID.ToString()+
                    " or ISNULL(a.purchaser_id3,-1) != "+purchaser3_ID.ToString(),hmCon.TRConnection);

                    int iCount = 0;
                    try { iCount = Convert.ToInt32(result); }
                    catch { }

                    if (iCount > 0)
                    {
                        popup.ShowPopup("The purchasers on the agreement(s) selected do not match the purchasers on the master agreement.");
                        return;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            else
                popup.ShowPopup("Please select a master agreement number.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmMasterAgreeemntSelection_Load(object sender, EventArgs e)
        {
            ds_MasterAgreement1.Clear();
            da_MasterAgrement.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            da_MasterAgrement.Fill(ds_MasterAgreement1);
        }
    }
}