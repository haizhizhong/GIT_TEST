using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotDiscount
{
    public partial class ucReview : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private bool _isFilling = false;
        private string _SearchUsername = "";

        public ucReview(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, string searchUsername)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            ucAccountingPicker1.ConnectionString = con.TRConnection;
            _SearchUsername = searchUsername;
            
            ucAccountingPicker1.ReadOnly = true;
            daDiscountReview.SelectCommand.Parameters["@username"].Value = searchUsername;
            daAgreementReview.SelectCommand.Parameters["@username"].Value = searchUsername;
        }


        public void RefreshMe(int GL_Year, int GL_Period, DateTime DiscountDate)
        {
            ucAccountingPicker1.SelectedPeriod = GL_Period;
            ucAccountingPicker1.SelectedYear = GL_Year;
            deDiscountDate.EditValue = DiscountDate;
           
            dsAgreementReview1.Clear();
            _isFilling = true;
            try
            {
                daAgreementReview.Fill(dsAgreementReview1);

            }
            catch (Exception ex)
            {
                pop.ShowPopup("Error loading discount review:" + ex.Message);
            }
            _isFilling = false;
            gvSelectedAgreements_FocusedRowChanged(gvSelectedAgreements, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(DevExpress.XtraGrid.GridControl.InvalidRowHandle, gvSelectedAgreements.FocusedRowHandle));
        }

        private void gvSelectedAgreements_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (_isFilling) return;
            dsDiscountReview1.Clear();
            if (e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle && e.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                DataRow row = gvSelectedAgreements.GetDataRow(e.FocusedRowHandle);
                dsDiscountReview1.Clear();
                if (row != null)
                {
                    daDiscountReview.SelectCommand.Parameters["@working_ld_lot_search_id"].Value = row[colID.FieldName];

                    try
                    {
                        daDiscountReview.Fill(dsDiscountReview1);
                    }
                    catch (Exception ex)
                    {
                        pop.ShowPopup("Error loading discounts:" + ex.Message);
                    }
                }
            }
        }
    }
}
