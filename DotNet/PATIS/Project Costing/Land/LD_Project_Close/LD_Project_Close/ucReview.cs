using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_Project_Close
{
    public partial class ucReview : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        private bool settingValues = false;

        public ucReview(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_header.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            da_detail.SelectCommand.Parameters["@username"].Value = hmCon.MLUser;
            settingValues = true;
            acctYearPeriod1.TRDBName = hmCon.TRDB;
            acctYearPeriod1.TRServerName = hmCon.CompanyServer;
            acctYearPeriod1.checkClose = "T"; //Turns on/off Open period check.
            acctYearPeriod1.luAcctPeriod.EditValueChanged += new EventHandler(luAcctPeriod_EditValueChanged);
            acctYearPeriod1.luAcctYear.EditValueChanged += new EventHandler(luAcctYear_EditValueChanged);
            acctYearPeriod1.MessageBoxHeaderText = "Lot Sale Assistant";
            settingValues = false;
            UpdateDate();
            LoadLevels();
            LoadSegmentDescriptions();       


        }

        private void LoadSegmentDescriptions()
        {
            DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter("exec dbo.sp_Proj_GLSwapSegs_WhseCount '"+hmCon.MLUser+"'", hmCon.TRConnection);
            if (hmCon.SQLExecutor.Exception != null)
                popup.ShowPopup("Error loading segment descriptions:" + hmCon.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Seg_Name"].ToString() != "")
                        colseg_2.Caption = dt.Rows[0]["Seg_Name"].ToString();
                    else
                    {
                        colseg_2.Visible = false;
                        colseg_2.OptionsColumn.ShowInCustomizationForm = false;
                    }
                    if (dt.Rows[0]["PC_Name"].ToString() != "")
                        colseg_3.Caption = dt.Rows[0]["PC_Name"].ToString();
                    else
                    {
                        colseg_3.Visible = false;
                        colseg_3.OptionsColumn.ShowInCustomizationForm = false;
                    }
                }
            }
        }

        private void LoadLevels()
        {
            collvl_1_Code.Caption = "";
            collvl_2_Code.Caption = "";
            collvl_3_Code.Caption = "";
            collvl_4_Code.Caption = "";
            collvl_1_Description.Caption = "";
            collvl_2_Description.Caption = "";
            collvl_3_Description.Caption = "";
            collvl_4_Description.Caption = "";

            string sSelect = "select isnull(use_land,'F')lv1_active, isnull(lv2_active_land,'F')lv2_active, isnull(lv3_active_land,'F')lv3_active, " +
                "isnull(lv4_active_land,'F')lv4_active, isnull(lv1_land_desc,'')lv1_desc, isnull(lv2_land_desc,'')lv2_desc, isnull(lv3_land_desc,'')lv3_desc, " +
                "isnull(lv4_land_desc,'')lv4_desc from proj_cntl";

            DataTable dtActive = hmCon.SQLExecutor.ExecuteDataAdapter(sSelect, hmCon.TRConnection);
                if (dtActive != null)
                {
                    for (int i = 0; i < dtActive.Rows.Count && i < 1; i++)
                    {
                        DataRow dr = dtActive.Rows[i];
                        if (dr != null)
                        {
                            
                            collvl_1_Code.Caption = dr["lv1_desc"].ToString();
                            collvl_2_Code.Caption = dr["lv2_desc"].ToString();
                            collvl_3_Code.Caption = dr["lv3_desc"].ToString();
                            collvl_4_Code.Caption = dr["lv4_desc"].ToString();
                            collvl_1_Description.Caption = dr["lv1_desc"].ToString() + " Description";
                            collvl_2_Description.Caption = dr["lv2_desc"].ToString() + " Description";
                            collvl_3_Description.Caption = dr["lv3_desc"].ToString() + " Description";
                            collvl_4_Description.Caption = dr["lv4_desc"].ToString() + " Description";


                            collvl_1_Code.Visible = false;
                            collvl_2_Code.Visible = false;
                            collvl_3_Code.Visible = false;
                            collvl_4_Code.Visible = false;
                            collvl_1_Description.Visible = false;
                            collvl_2_Description.Visible = false;
                            collvl_3_Description.Visible = false;
                            collvl_4_Description.Visible = false;




                            object o1 = dr["lv1_active"];
                            if (o1 == null || o1 == DBNull.Value || o1.Equals("F"))
                            {
                                collvl_1_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_2_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_3_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_1_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_2_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_3_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Description.OptionsColumn.ShowInCustomizationForm = false;
                                return;
                            }
                            else
                            {
                                collvl_1_Code.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_1_Description.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_1_Code.Visible = true;
                                collvl_1_Description.Visible = true;
                                
                            }
                            object o2 = dr["lv2_active"];
                            if (o2 == null || o2 == DBNull.Value || o2.Equals("F"))
                            {
                                collvl_2_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_3_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_2_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_3_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Description.OptionsColumn.ShowInCustomizationForm = false;
                                return;
                            }
                            else
                            {
                                collvl_2_Code.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_2_Description.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_2_Code.Visible = true;
                                collvl_2_Description.Visible = true;
                            }
                            object o3 = dr["lv3_active"];
                            if (o3 == null || o3 == DBNull.Value || o3.Equals("F"))
                            {
                                collvl_3_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_3_Description.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Description.OptionsColumn.ShowInCustomizationForm = false;
                                return;
                            }
                            else
                            {
                                collvl_3_Code.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_3_Description.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_3_Code.Visible = true;
                                collvl_3_Description.Visible = true;
                            }
                            object o4 = dr["lv4_active"];
                            if (o4 == null || o4 == DBNull.Value || o4.Equals("F"))
                            {
                                collvl_4_Code.OptionsColumn.ShowInCustomizationForm = false;
                                collvl_4_Description.OptionsColumn.ShowInCustomizationForm = false;
                                return;
                            }
                            else
                            {
                                collvl_4_Code.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_4_Description.OptionsColumn.ShowInCustomizationForm = true;
                                collvl_4_Code.Visible = true;
                                collvl_4_Description.Visible = true;
                            }
                        }
                    }
                }
                
            
        }

        public void RefreshMe(int pri_id)
        {
           
            try
            {
                settingValues = true;
                acctYearPeriod1.RefreshAcctPeriod();
                hmCon.SQLExecutor.ExecuteNonQuery("exec LD_pca_LoadSummary '"+hmCon.MLUser+"',"+pri_id.ToString(), hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    throw hmCon.SQLExecutor.Exception;

                ds_header1.Clear();
                da_header.Fill(ds_header1);

                ds_detail1.Clear();
                da_detail.Fill(ds_detail1);

                settingValues = false;
                UpdateDate();
            }
            catch (Exception ex)
            {
                popup.ShowPopup("Error loading selected lots:" + ex.Message);
            }
            
            
        }

        private void luAcctYear_EditValueChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void luAcctPeriod_EditValueChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            if (settingValues) return;
            int iYear = 0, iPeriod = 0, iMonth = 0;
            if (acctYearPeriod1.luAcctYear.EditValue != DBNull.Value && acctYearPeriod1.luAcctYear.EditValue != null)
                iYear = Convert.ToInt32(acctYearPeriod1.luAcctYear.EditValue);
            if (acctYearPeriod1.luAcctPeriod.EditValue != DBNull.Value && acctYearPeriod1.luAcctPeriod.EditValue != null)
                iPeriod = Convert.ToInt32(acctYearPeriod1.luAcctPeriod.EditValue);

            object oEndDate = hmCon.SQLExecutor.ExecuteScalar("Select END_DATE from AR_PERIODS where AR_YEAR = " + iYear.ToString() + " and PERIOD = " + iPeriod.ToString(), hmCon.TRConnection);

            try
            {
                DateTime dEndDate = Convert.ToDateTime(oEndDate);
                iMonth = dEndDate.Month;
                iYear = dEndDate.Year;
            }
            catch { }

            if (iYear != 0 && iMonth != 0)
            {
                settingValues = true;
                deInvoiceDate.DateTime = new DateTime(iYear, iMonth, 1);
                settingValues = false;

            }
        }

        private bool isDateInValid()
        {
            bool returnValue = true;
            if (deInvoiceDate.EditValue != DBNull.Value && deInvoiceDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInvoiceDate.DateTime.ToShortDateString() + "' and period <> 13 order by END_DATE";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting year and period from invoice date:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (acctYearPeriod1.luAcctPeriod.EditValue.ToString() == dt.Rows[0]["PERIOD"].ToString()
                           && acctYearPeriod1.luAcctYear.EditValue.ToString() == dt.Rows[0]["AR_YEAR"].ToString())
                        {
                            returnValue = false;
                        }
                    }
                }

                if (returnValue)
                {
                    popup.ShowPopup("Payout date must be within the selected year/period.");
                }

            }
            else
                popup.ShowPopup("Payout date is required.");



            return returnValue;
        }

        private void deInvoiceDate_EditValueChanged(object sender, EventArgs e)
        {
            if (settingValues) return;
            if (deInvoiceDate.EditValue != DBNull.Value && deInvoiceDate.EditValue != null)
            {
                string sql = "select top 1 AR_YEAR,PERIOD from AR_PERIODS where END_DATE >= '" + deInvoiceDate.DateTime.ToShortDateString() + "' and period <> 13 order by END_DATE";
                DataTable dt = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
                if (hmCon.SQLExecutor.Exception != null)
                    popup.ShowPopup("Error setting year and period from invoice date:" + hmCon.SQLExecutor.Exception.Message);
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        settingValues = true;
                        acctYearPeriod1.luAcctPeriod.EditValue = dt.Rows[0]["PERIOD"];
                        acctYearPeriod1.luAcctYear.EditValue = dt.Rows[0]["AR_YEAR"];
                        settingValues = false;
                    }
                }
            }
        }
       
        public bool isValid()
        {
            bool returnValue = true;


            return returnValue;
        }


    }
}
