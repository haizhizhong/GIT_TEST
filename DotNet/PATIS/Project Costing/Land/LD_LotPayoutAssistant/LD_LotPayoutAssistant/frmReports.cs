using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotPayoutAssistant
{
    public partial class frmReports : DevExpress.XtraEditors.XtraForm
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private int _AgreementID = -1;

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

        public delegate void DelegatePrintRegister();
        public event DelegatePrintRegister PrintRegister;
        public delegate void DelegatePrintStatement();
        public event DelegatePrintStatement PrintStatement;
        public delegate void DelegatePrintCashToClose();
        public event DelegatePrintCashToClose PrintCashToClose;
        

        public frmReports(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle,int pAgreementID)
        {
            InitializeComponent();
            _AgreementID = pAgreementID;
            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            if (pAgreementID == -1)
                btnPayoutDocuments.Enabled = false;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (PrintRegister != null)
                PrintRegister();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            if (PrintStatement != null)
                PrintStatement();
        }

        private void btnCashToClose_Click(object sender, EventArgs e)
        {
            if (PrintCashToClose != null)
                PrintCashToClose();
        }


        private void btnPayoutDocuments_Click(object sender, EventArgs e)
        {

            using (LD_Agree_WordMerge.frmAgreeDocs frm = new LD_Agree_WordMerge.frmAgreeDocs(ReflexCon, dxStyle, _AgreementID))
            {
                frm.DockType = LD_Agree_WordMerge.DocumentType.Payout;
                frm.ShowDialog();
            }

        }

      
    }
}