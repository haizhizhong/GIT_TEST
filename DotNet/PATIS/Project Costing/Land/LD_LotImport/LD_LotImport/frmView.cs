using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotImport
{
    public partial class frmView : DevExpress.XtraEditors.XtraForm
    {

        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;



        public frmView(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int pri_id)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;

            LD_LotImport.ucImportPati ucpati = new LD_LotImport.ucImportPati(hmCon, tuc_mgr,pri_id);
            ucpati.Dock = DockStyle.Fill;
            ucpati.ButtonCancelClick += new ucImportPati.hButtonCancelClick(ucpati_ButtonCancelClick);
            ucpati.Finished += new ucImportPati.hFinished(ucpati_Finished);
            ucpati.Parent = this;
            ucpati.BringToFront();
            
			
        }

        void ucpati_Finished()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void ucpati_ButtonCancelClick()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}