using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_TaxrollUpdate
{
    public partial class ucLD_TaxrollUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;

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

        public ucLD_TaxrollUpdate(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            sqlTR.ConnectionString = ReflexCon.TRConnection;
        }

        private void ucLD_TaxrollUpdate_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            RefreshTaxrollUpdate();
            if (ReflexCon.CountryCode.Equals("U"))
            {
                colstp_desc.Caption = "Project State";
            }
            dxStyle.FormInit(this);
        }

        public void RefreshTaxrollUpdate()
        {
            dsProjects1.Clear();
            daProjects.Fill(dsProjects1);
            dsARYears1.Clear();
            daARYears.Fill(dsARYears1);
            dsAssessmentList1.Clear();
            daAssessmentList.Fill(dsAssessmentList1);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (lueYears.EditValue == DBNull.Value || lueYears.EditValue == null)
            {
                frmMessageBox.ShowPopup("Please select a tax year");
                return;
            }

            dsTaxRollUpdate1.Clear();
            daTaxRollUpdate.SelectCommand.Parameters["@pri_id"].Value = (lueProjects.EditValue == DBNull.Value || lueProjects.EditValue == null ? "%" : lueProjects.EditValue.ToString());
            daTaxRollUpdate.SelectCommand.Parameters["@Year"].Value = Convert.ToInt32(lueYears.EditValue);
            daTaxRollUpdate.Fill(dsTaxRollUpdate1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dsTaxRollUpdate1.Clear();
            lueProjects.EditValue = DBNull.Value;
            lueYears.EditValue = DBNull.Value;
        }

        private void gvTaxRollUpdate_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvTaxRollUpdate.GetDataRow(gvTaxRollUpdate.FocusedRowHandle);
            if (dr != null)
            {
                object oYear = dr["year"];
                if (oYear == null || oYear == DBNull.Value)
                {
                    e.ErrorText = "Tax year is required.";
                    gvTaxRollUpdate.FocusedColumn = colyear;
                    e.Valid = false;
                    return;
                }

                object oDate = dr["tax_adj_date"];
                if (oDate == null || oDate == DBNull.Value)
                {
                    e.ErrorText = "Tax adjustment date is required.";
                    gvTaxRollUpdate.FocusedColumn = coltax_adj_date;
                    e.Valid = false;
                    return;
                }

                object oCode = dr["assessment_id"];
                if (oCode == null || oCode == DBNull.Value)
                {
                    e.ErrorText = "Tax assessment code is required.";
                    gvTaxRollUpdate.FocusedColumn = colassessment_id;
                    e.Valid = false;
                    return;
                }

                object oValue = dr["assessment"];
                if (oValue == null || oValue == DBNull.Value)
                {
                    e.ErrorText = "Tax assessment amount is required.";
                    gvTaxRollUpdate.FocusedColumn = colassessment;
                    e.Valid = false;
                    return;
                }
                else
                {
                    if (Convert.ToDouble(oValue) <= 0)
                    {
                        e.ErrorText = "Tax assessment amount must be greater than zero.";
                        gvTaxRollUpdate.FocusedColumn = colassessment;
                        e.Valid = false;
                        return;
                    }
                }

                object oTaxes = dr["taxes"];
                if (oTaxes == null || oTaxes == DBNull.Value)
                {
                    e.ErrorText = "Taxes amount is required.";
                    gvTaxRollUpdate.FocusedColumn = coltaxes;
                    e.Valid = false;
                    return;
                }
                else
                {
                    if (Convert.ToDouble(oTaxes) <= 0)
                    {
                        e.ErrorText = "Taxes amount must be greater than zero.";
                        gvTaxRollUpdate.FocusedColumn = coltaxes;
                        e.Valid = false;
                        return;
                    }
                }

                object oInstallmentAmt = dr["Installment1"];
                if (oInstallmentAmt != null && oInstallmentAmt != DBNull.Value)
                {
                    if (Convert.ToDouble(oInstallmentAmt) < 0)
                    {
                        e.ErrorText = "1st Installment amount can not be less than zero.";
                        gvTaxRollUpdate.FocusedColumn = colInstallment1;
                        e.Valid = false;
                        return;
                    }
                }
                oInstallmentAmt = dr["Installment2"];
                if (oInstallmentAmt != null && oInstallmentAmt != DBNull.Value)
                {
                    if (Convert.ToDouble(oInstallmentAmt) < 0)
                    {
                        e.ErrorText = "2nd Installment amount can not be less than zero.";
                        gvTaxRollUpdate.FocusedColumn = colInstallment2;
                        e.Valid = false;
                        return;
                    }
                }
                oInstallmentAmt = dr["Installment3"];
                if (oInstallmentAmt != null && oInstallmentAmt != DBNull.Value)
                {
                    if (Convert.ToDouble(oInstallmentAmt) < 0)
                    {
                        e.ErrorText = "1st Installment amount can not be less than zero.";
                        gvTaxRollUpdate.FocusedColumn = colInstallment3;
                        e.Valid = false;
                        return;
                    }
                }


                if (!isYearAndCodeUnique(dr["ID"].ToString(), dr["year"].ToString(), dr["assessment_id"].ToString(), dr["tax_roll_id"].ToString()))
                {
                    e.ErrorText = "Year and Assesment Code combination is already in use.";
                    e.Valid = false;
                    return;
                }




            }
        }



        private bool isYearAndCodeUnique(string ID, string year, string assessmentID, string TaxRollID)
        {
            bool returnValue = true;
            string sql = "SELECT count(*) FROM PROJ_LOT_TAX_DET " +
                "WHERE        (tax_roll_id = " + TaxRollID + ") and ID <> " + ID + " and year = " + year + " and assessment_id = " + assessmentID;
            object result = ReflexCon.SQLExecutor.ExecuteScalar(sql, ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Error checking for duplicate year/assessment code combinations:" + ReflexCon.SQLExecutor.Exception.Message);
                returnValue = false;
            }
            else if (result != DBNull.Value && result != null)
            {
                if (Convert.ToInt32(result) > 0)
                {
                    returnValue = false;
                }
            }
            else
            {
                frmMessageBox.ShowPopup("Error in return value checking for duplicate year/assessment code:" + ReflexCon.SQLExecutor.Exception.Message);
                returnValue = false;
            }



            return returnValue;
        }



        private void rilueAssessmentList_EditValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                LookUpEdit lue = sender as LookUpEdit;
                if (lue != null)
                {
                    DataRow dr = gvTaxRollUpdate.GetDataRow(gvTaxRollUpdate.FocusedRowHandle);
                    if (dr != null)
                    {
                        dr.BeginEdit();
                        dr["assessment_desc"] = lue.GetColumnValue("Description");
                    }
                }
            }
        }

        private void gvTaxRollUpdate_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRow dr = gvTaxRollUpdate.GetDataRow(gvTaxRollUpdate.FocusedRowHandle);
            if (dr != null)
            {
                SqlCommand cmd = new SqlCommand("LD_TaxRollInsertUpdate @id, @tax_roll_id, @year, @assessment, @taxes, @tax_adj_date, @assessment_id, @assessment_desc, @comment, @Paid,@Install1,@Install2,@Install3",
                    new SqlConnection(ReflexCon.TRConnection));

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = dr["id"];
                cmd.Parameters.Add("@tax_roll_id", SqlDbType.Int);
                cmd.Parameters["@tax_roll_id"].Value = dr["tax_roll_id"];
                cmd.Parameters.Add("@year", SqlDbType.Int);
                cmd.Parameters["@year"].Value = dr["year"];
                cmd.Parameters.Add("@assessment", SqlDbType.Money);
                cmd.Parameters["@assessment"].Value = dr["assessment"];
                cmd.Parameters.Add("@taxes", SqlDbType.Money);
                cmd.Parameters["@taxes"].Value = dr["taxes"];
                cmd.Parameters.Add("@tax_adj_date", SqlDbType.DateTime);
                cmd.Parameters["@tax_adj_date"].Value = dr["tax_adj_date"];
                cmd.Parameters.Add("@assessment_id", SqlDbType.Int);
                cmd.Parameters["@assessment_id"].Value = dr["assessment_id"];
                cmd.Parameters.Add("@assessment_desc", SqlDbType.VarChar);
                cmd.Parameters["@assessment_desc"].Value = dr["assessment_desc"];
                cmd.Parameters.Add("@comment", SqlDbType.VarChar);
                cmd.Parameters["@comment"].Value = dr["comment"];
                cmd.Parameters.Add("@Paid", SqlDbType.Bit);
                cmd.Parameters["@Paid"].Value = dr["Paid"];
                cmd.Parameters.Add("@Install1", SqlDbType.Money);
                cmd.Parameters["@Install1"].Value = dr["Installment1"];
                cmd.Parameters.Add("@Install2", SqlDbType.Money);
                cmd.Parameters["@Install2"].Value = dr["Installment2"];
                cmd.Parameters.Add("@Install3", SqlDbType.Money);
                cmd.Parameters["@Install3"].Value = dr["Installment3"];
                

                try
                {
                    
                    cmd.Connection.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    //if (dt != null)
                    //{
                    //    if (dt.Rows.Count > 0)
                    //    {
                    //        DataRow exdr = dt.Rows[0];
                    //        if (exdr != null)
                    //        {
                    //            object oID = exdr["id"];
                    //            if (oID != null && oID != DBNull.Value)
                    //            {
                    //                dr.BeginEdit();
                    //                dr["id"] = Convert.ToInt32(oID);
                    //                dr.EndEdit();
                    //                dr.AcceptChanges();

                    //                DataRow drH = gvTaxRolls.GetDataRow(gvTaxRolls.FocusedRowHandle);
                    //                if (drH != null)
                    //                {
                    //                    drH.BeginEdit();
                    //                    drH["assessment"] = exdr["total_assessment"];
                    //                    drH["taxes"] = exdr["total_taxes"];
                    //                    drH["tax_adj_date"] = exdr["max_date"];
                    //                    drH.EndEdit();
                    //                    drH.AcceptChanges();
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    frmMessageBox.ShowPopup(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }

        private void gvTaxRollUpdate_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            frmMessageBox.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnLoadNewYear_Click(object sender, EventArgs e)
        {
            int iProjID = -1, iYear = -1;

            if (lueProjects.EditValue != DBNull.Value && lueProjects.EditValue != null)
            {
                try { iProjID = Convert.ToInt32(lueProjects.EditValue); }
                catch { }
            }

            if (lueYears.EditValue != DBNull.Value && lueYears.EditValue == null)
            {
                try { iYear = Convert.ToInt32(lueYears.EditValue); }
                catch { }
            }

            if (iYear <= 0)
                iYear = -1;

            using (frmLoadNewYear LoadNewYear = new frmLoadNewYear(ReflexCon, dxStyle, iProjID, iYear))
            {
                if (LoadNewYear.ShowDialog() == DialogResult.OK)
                {
                    RefreshTaxrollUpdate();
                    if (LoadNewYear.Pri_ID != -1)
                        lueProjects.EditValue = LoadNewYear.Pri_ID;
                    lueYears.EditValue = LoadNewYear.Year;

                    RefreshTaxrollUpdate();
                    btnFilter_Click(btnFilter, new EventArgs());
                }
            }
        }

        
    }
}
