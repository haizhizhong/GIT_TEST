using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_ProgramFees
{
    public partial class frmReportPrintDialog : DevExpress.XtraEditors.XtraForm
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private bool bCancelMode = false;

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

        #region Delegates and Events

        public delegate void PrintClickDelegate(string Type);
        public event PrintClickDelegate PrintClick;

        #endregion Delegates and Events

        public frmReportPrintDialog(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, bool CancelMode)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            bCancelMode = CancelMode;

            if (bCancelMode)
                btnPrintCertificate.Enabled = false;
        }

        private void frmReportPrintDialog_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dxStyle.FormInit(this);
        }

        private void btnPrintCertificate_Click(object sender, EventArgs e)
        {
            //This is a shell that calls back to the summary user control to execute the reports as needed based on type
            if (PrintClick != null)
                PrintClick("C");
        }

        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            //This is a shell that calls back to the summary user control to execute the reports as needed based on type
            if (PrintClick != null)
                PrintClick("R");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}