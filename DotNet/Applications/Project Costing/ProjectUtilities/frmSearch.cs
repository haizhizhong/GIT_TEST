using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProjectTypes;

namespace ProjectUtilities
{
    public partial class frmSearch : DevExpress.XtraEditors.XtraForm
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private ProjectType _Flavour;
        private ucSearch ProjSearch;

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

        private int iPri_ID = -1;
        public int Pri_ID
        {
            get { return iPri_ID; }
            private set { iPri_ID = value; }
        }

        #endregion Properties

        public frmSearch(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, ProjectType Flavour )
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            _Flavour = Flavour;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            ProjSearch = new ucSearch(ReflexCon, dxStyle, _Flavour);
            ProjSearch.ProjectChange_Event += new ucSearch.ProjectChange_Delegate(ProjSearch_ProjectChange_Event);
            ProjSearch.ClearNonSearchPanels = true;
            ProjSearch.Dock = DockStyle.Fill;
            ProjSearch.Parent = pcSearch;
            dxStyle.FormInit(ProjSearch);
        }

        private void ProjSearch_ProjectChange_Event(int ProjectID)
        {
            iPri_ID = ProjectID;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (iPri_ID == -1)
            {
                if (frmMessageBox.ShowPopup("No project selected are you sure you wish to continue?", WS_Popups.frmPopup.PopupType.Yes_No) != WS_Popups.frmPopup.PopupResult.Yes)
                {
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            iPri_ID = -1;
            Close();
        }

        
    }
}