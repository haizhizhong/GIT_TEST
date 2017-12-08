using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandControls
{
    public partial class ucProjectAllocated : DevExpress.XtraEditors.XtraUserControl
    {

        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;

        public ucProjectAllocated(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;

            daProjectAllocated.SelectCommand.Parameters["@username"].Value = con.MLUser;
            SetupSegments();
        }



        private void SetupSegments()
        {
            string sSelect = "select isnull(clear_seg,2) from gl_setup";
            object obj = con.SQLExecutor.ExecuteScalar(sSelect, con.TRConnection);
            if (obj != null && obj.GetType() != typeof(DBNull))
            {
                int Column = Convert.ToInt32(obj);
                string ColumnName = "SEG_" + Column + "_DESC";

                
                sSelect = "select " + ColumnName + " from gl_setup";
                

                obj = con.SQLExecutor.ExecuteScalar(sSelect, con.TRConnection);
                if (obj != null && obj.GetType() != typeof(DBNull))
                {
                    coldivision_code.Caption = obj.ToString();
                    coldivision_desc.Caption = obj.ToString() + " Description";
                   
                }
            }

            sSelect = "select isnull(PROFIT_CENTER_SEG,3) from SO_SETUP";
            obj = con.SQLExecutor.ExecuteScalar(sSelect, con.TRConnection);
            if (obj != null && obj.GetType() != typeof(DBNull))
            {
                int Column = Convert.ToInt32(obj);
                string ColumnName = "SEG_" + Column + "_DESC";


                sSelect = "select " + ColumnName + " from gl_setup";


                obj = con.SQLExecutor.ExecuteScalar(sSelect, con.TRConnection);
                if (obj != null && obj.GetType() != typeof(DBNull))
                {
                    colprofit_code.Caption = obj.ToString();
                    colprofit_desc.Caption = obj.ToString()+" Description";

                }
            }
        }


        public void RefreshMe(int pri_id)
        {
            daProjectAllocated.SelectCommand.Parameters["@pri_id"].Value = pri_id;

            try
            {
                dsProjectAllocated1.Clear();
                daProjectAllocated.Fill(dsProjectAllocated1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading allocated project's:" + ex.Message);
            }

        }



    }
}
