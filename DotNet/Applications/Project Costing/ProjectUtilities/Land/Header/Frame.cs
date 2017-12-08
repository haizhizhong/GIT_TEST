using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HMConnection;
using ProjectTypes;
using WS_Popups;

namespace ProjectUtilities.Land.Header
{
    public partial class Frame : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private ProjectType _Flavour;
        private GL_Account_Lookup_Rep.Repository_GL_Lookup GLLookup;
        private string sLandSubType = "P";


        public Frame(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, ProjectType Flavour,string LandSubType)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.sqlTRConnection.ConnectionString = Connection.TRConnection;
            this.DevXMgr = DevXMgr;
            Popup = new frmPopup(DevXMgr);
            _Flavour = Flavour;
            sLandSubType = LandSubType;

        }

        private void Frame_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);

          
        }

        public void LoadProject(int ProjectID)
        {
            

                    
        }



        
    }
}
