using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_LotImport
{
    public partial class ucValidate : DevExpress.XtraEditors.XtraUserControl
    {


        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        TUC_GridG.GridG gGrid;
        DataTable dt_Invalid_LotBlockPlan;
        private int _pri_id = -1;


        public ucValidate(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc,int pPri_id)
        {
            InitializeComponent();
            _pri_id = pPri_id;
            hmCon = connection;
            tuc_mgr = tuc;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            da_working_proj_lot.SelectCommand.Parameters["@username"].Value = hmCon.MLUser + "-Import";
        }

        public void RefreshMe()
        {
            hmCon.SQLExecutor.ExecuteNonQuery("exec LD_ImportTo_workingprojlot '" + hmCon.MLUser + "'", hmCon.TRConnection);
            hmCon.SQLExecutor.ExecuteNonQuery("update working_proj_lot set pri_id = " + _pri_id.ToString() + " where username = '" + hmCon.MLUser + "-Import'", hmCon.TRConnection);

            string sql = @"
declare @username varchar(100) = '"+hmCon.MLUser+@"'


select distinct w.Import_ID from Working_PROJ_LOT w
join Working_PROJ_LOT l on l.username = @username and w.lot_num = l.lot_num and w.block_num = l.block_num 
where w.username = @username +'-Import'
union
select distinct w.Import_ID from Working_PROJ_LOT w
join PROJ_LOT l on l.pri_id = w.pri_id and w.lot_num = l.lot_num and w.block_num = l.block_num 
where w.username = @username +'-Import'";
            
            dt_Invalid_LotBlockPlan = hmCon.SQLExecutor.ExecuteDataAdapter(sql, hmCon.TRConnection);
            dt_Invalid_LotBlockPlan.PrimaryKey = new DataColumn[] { dt_Invalid_LotBlockPlan.Columns[0] };

            ds_working_proj_lot1.Clear();
            da_working_proj_lot.Fill(ds_working_proj_lot1);

            RefreshLookups();
        }

        private void RefreshLookups()
        {
            ds_lueLotClass1.Clear();
            da_lueLotClass.Fill(ds_lueLotClass1);

            ds_lueLotSubClass1.Clear();
            da_lueLotSubClass.Fill(ds_lueLotSubClass1);

            ds_lueShape1.Clear();
            da_lueShape.Fill(ds_lueShape1);

            ds_lueZoning1.Clear();
            da_lueZoning.Fill(ds_lueZoning1);

            ds_lueStateProv1.Clear();
            da_lueStateProv.Fill(ds_lueStateProv1);

            ds_lueBuildingRestrictions1.Clear();
            da_lueBuildingRestrictions.Fill(ds_lueBuildingRestrictions1);

        }

        private void ucValidate_Load(object sender, EventArgs e)
        {
            gGrid = new TUC_GridG.GridG(hmCon.CompanyServer, hmCon.TRDB, gvImportedLots, da_working_proj_lot, ds_working_proj_lot1);
            gGrid.AskBeforeDelete = false;
            gGrid.AllowTabCreateNewRecord = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);
            SetupAddress();
            RefreshMe();
        }



        private void SetupAddress()
        {
            bool bUseMunicipalAddr = false;
            string sqlStr = "  SELECT  ISNULL(UseMunicipalAddr,0) FROM LD_Setup";
            object obj = hmCon.SQLExecutor.ExecuteScalar(sqlStr, hmCon.TRConnection);
            if (obj != null && obj != DBNull.Value)
                bUseMunicipalAddr = Convert.ToBoolean(obj);

            if (bUseMunicipalAddr)
            {
                colma_city.Visible = true;
                colma_name.Visible = true;
                colma_number.Visible = true;
                colma_postal.Visible = true;
                colma_prefix_dir.Visible = true;
                colma_prov.Visible = true;
                colma_site.Visible = true;
                colma_suffix.Visible = true;
                colma_suffix_dir.Visible = true;

                colma_city.OptionsColumn.ShowInCustomizationForm = true;
                colma_name.OptionsColumn.ShowInCustomizationForm = true;
                colma_number.OptionsColumn.ShowInCustomizationForm = true;
                colma_postal.OptionsColumn.ShowInCustomizationForm = true;
                colma_prefix_dir.OptionsColumn.ShowInCustomizationForm = true;
                colma_prov.OptionsColumn.ShowInCustomizationForm = true;
                colma_site.OptionsColumn.ShowInCustomizationForm = true;
                colma_suffix.OptionsColumn.ShowInCustomizationForm = true;
                colma_suffix_dir.OptionsColumn.ShowInCustomizationForm = true;

                coladdress_1.Visible = false;
                coladdress_2.Visible = false;
                colcity.Visible = false;
                colprov.Visible = false;
                colpostal.Visible = false;

                coladdress_1.OptionsColumn.ShowInCustomizationForm = false;
                coladdress_2.OptionsColumn.ShowInCustomizationForm = false;
                colcity.OptionsColumn.ShowInCustomizationForm = false;
                colprov.OptionsColumn.ShowInCustomizationForm = false;
                colpostal.OptionsColumn.ShowInCustomizationForm = false;
            }
            else
            {
                colma_city.Visible = false;
                colma_name.Visible = false;
                colma_number.Visible = false;
                colma_postal.Visible = false;
                colma_prefix_dir.Visible = false;
                colma_prov.Visible = false;
                colma_site.Visible = false;
                colma_suffix.Visible = false;
                colma_suffix_dir.Visible = false;

                colma_city.OptionsColumn.ShowInCustomizationForm = false;
                colma_name.OptionsColumn.ShowInCustomizationForm = false;
                colma_number.OptionsColumn.ShowInCustomizationForm = false;
                colma_postal.OptionsColumn.ShowInCustomizationForm = false;
                colma_prefix_dir.OptionsColumn.ShowInCustomizationForm = false;
                colma_prov.OptionsColumn.ShowInCustomizationForm = false;
                colma_site.OptionsColumn.ShowInCustomizationForm = false;
                colma_suffix.OptionsColumn.ShowInCustomizationForm = false;
                colma_suffix_dir.OptionsColumn.ShowInCustomizationForm = false;


                coladdress_1.Visible = true;
                coladdress_2.Visible = true;
                colcity.Visible = true;
                colprov.Visible = true;
                colpostal.Visible = true;

                coladdress_1.OptionsColumn.ShowInCustomizationForm = true;
                coladdress_2.OptionsColumn.ShowInCustomizationForm = true;
                colcity.OptionsColumn.ShowInCustomizationForm = true;
                colprov.OptionsColumn.ShowInCustomizationForm = true;
                colpostal.OptionsColumn.ShowInCustomizationForm = true;
            }
        }
        
        bool gGrid_AllowDelete(object sender, DataRow row)
        {

            if (popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;

        }
			

        private void gvImportedLots_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column == collot_class_id || e.Column == collot_sub_class_id )
            {
                if (e.CellValue == DBNull.Value && e.CellValue == null)
                {
                    e.Appearance.BackColor = Color.Red;
                }
                else if (e.CellValue.ToString() == "-1")
                {
                    e.Appearance.BackColor = Color.Red;
                }
            }
            else if (e.Column == collot_num || e.Column == colblock_num )
            {
                DataRow row = gvImportedLots.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row[colImport_ID.FieldName] != null && row[colImport_ID.FieldName] != DBNull.Value)
                    {
                        

                        if (dt_Invalid_LotBlockPlan != null)
                        {
                            if (dt_Invalid_LotBlockPlan.Rows.Find(new object[] { row[colImport_ID.FieldName] }) != null)
                            {
                                e.Appearance.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void ri_lueLotSubClass_QueryPopUp(object sender, CancelEventArgs e)
        {
            bs_lueSubClass.Filter = "1=2";
            if (sender != null)
            {
                LookUpEdit edit = (LookUpEdit)sender;
                DataRow row = gvImportedLots.GetDataRow(gvImportedLots.FocusedRowHandle);
                if (row != null)
                {
                    if (row[collot_class_id.FieldName] != null && row[collot_class_id.FieldName] != DBNull.Value)
                    {
                        bs_lueSubClass.Filter = "LD_Lot_Class_ID =" + row[collot_class_id.FieldName];
                    }
                }
            }


        }

       


        private void gvImportedLots_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvImportedLots.GetDataRow(gvImportedLots.FocusedRowHandle);
            if (dr != null)
            {
                object obj = dr["lot_class_id"];
                if (obj == System.DBNull.Value || obj == null)
                {
                    popup.ShowPopup("Lot class is required.");
                    e.Valid = false;
                    return;
                }
                else if (Convert.ToInt32(obj) == -1)
                {
                    popup.ShowPopup("Lot class is required.");
                    e.Valid = false;
                    return;

                }
                obj = dr["lot_sub_class_id"];
                if (obj == System.DBNull.Value || obj == null)
                {
                    popup.ShowPopup("Lot sub class is required.");
                    e.Valid = false;
                    return;
                }
                else if (Convert.ToInt32(obj) == -1)
                {
                    popup.ShowPopup("Lot sub class is required.");
                    e.Valid = false;
                    return;

                }
                obj = dr["lot_num"];
                if (obj == System.DBNull.Value || obj == null)
                {
                    popup.ShowPopup("A lot # is required.");
                    e.Valid = false;
                    return;
                }

                else if (obj.ToString() == "")
                {
                    popup.ShowPopup("A lot # is required.");
                    e.Valid = false;
                    return;
                }
                obj = dr["block_num"];
                if (obj == System.DBNull.Value || obj == null)
                {
                    popup.ShowPopup("A block # is required.");
                    e.Valid = false;
                    return;
                }
                else if (obj.ToString() == "")
                {
                    popup.ShowPopup("A block # is required.");
                    e.Valid = false;
                    return;
                }

                string lot_num = dr["lot_num"].ToString().Replace("'", "''");
                string block_num = dr["block_num"].ToString().Replace("'", "''");
                int proj_lot_id = 0;
                obj = dr["proj_lot_id"];

                if (obj != DBNull.Value && obj != null)
                {
                    proj_lot_id = Convert.ToInt32(obj);
                }

                string sSelect = "select COUNT(*) from PROJ_LOT where pri_id = " + _pri_id.ToString() + " and lot_num = '" + lot_num + "'" +
                    " and block_num = '" + block_num + "'";
                if (Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection)) > 0)
                {
                    popup.ShowPopup("The combination of lot # and block # entered already exists for this project.");
                    e.Valid = false;
                    return;
                }
                sSelect = "select COUNT(*) from Working_PROJ_LOT where pri_id = " + _pri_id.ToString() + " and lot_num = '" + lot_num + "'" +
                    " and block_num = '" + block_num + "'" + " and  proj_lot_id <> " + proj_lot_id.ToString() +
                    " and username = '" + hmCon.MLUser + "'";
                if (Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(sSelect, hmCon.TRConnection)) > 0)
                {
                    popup.ShowPopup("The combination of lot # and block # entered already exists for this project.");
                    e.Valid = false;
                    return;
                }

                string msg = ValidMoneyTypeValue("depth", "Depth");
                if (msg != "")
                {
                    popup.ShowPopup(msg);
                    e.Valid = false;
                    return;
                }
                msg = ValidMoneyTypeValue("frontage", "Frontage");
                if (msg != "")
                {
                    popup.ShowPopup(msg);
                    e.Valid = false;
                    return;
                }

                //msg = ValidMoneyTypeValue("area_metre", "Sq Meters");
                //if (msg != "")
                //{
                //    popup.ShowPopup(msg);
                //    e.Valid = false;
                //    return;
                //}
                //msg = ValidMoneyTypeValue("area_hectares", "Hectares");
                //if (msg != "")
                //{
                //    popup.ShowPopup(msg);
                //    e.Valid = false;
                //    return;
                //}
                msg = ValidMoneyTypeValue("original_price", "Original Price");
                if (msg != "")
                {
                    popup.ShowPopup(msg);
                    e.Valid = false;
                    return;
                }
                msg = ValidMoneyTypeValue("current_price", "Current Price");
                if (msg != "")
                {
                    popup.ShowPopup(msg);
                    e.Valid = false;
                    return;
                }
                //msg = ValidMoneyTypeValue("commission_amt", "Commission Amount");
                //if (msg != "")
                //{
                //    popup.ShowPopup(msg);
                //    e.Valid = false;
                //    return;
                //}
                //msg = ValidMoneyTypeValue("commission_pct", "Commission Percent");
                //if (msg != "")
                //{
                //    popup.ShowPopup(msg);
                //    e.Valid = false;
                //    return;
                //}
                msg = ValidMoneyTypeValue("area_acres", "Acres");
                if (msg != "")
                {
                    popup.ShowPopup(msg);
                    e.Valid = false;
                    return;
                }
                //msg = ValidMoneyTypeValue("area_ft", "Sq Ft");
                //if (msg != "")
                //{
                //    popup.ShowPopup(msg);
                //    e.Valid = false;
                //    return;
                //}

                //
                obj = dr["plan_num"];
                if (obj == DBNull.Value || obj == null)
                {
                    dr["plan_num"] = "Unregistered";
                }
                else if (obj.ToString() == "")
                {
                    dr["plan_num"] = "Unregistered";
                }
                //lot block combo is valid. remove from validation table.
                DataRow row = dt_Invalid_LotBlockPlan.Rows.Find(new object[]{dr[colImport_ID.FieldName]});
                if (row != null)
                {
                    dt_Invalid_LotBlockPlan.Rows.Remove(row);
                }

            }
        }


        private string ValidMoneyTypeValue(string fieldName, string captionName)
        {
            string msg = "";
            DataRow dr = gvImportedLots.GetDataRow(gvImportedLots.FocusedRowHandle);
            if (dr != null)
            {
                object obj = dr[fieldName];
                if (obj != null && obj != DBNull.Value)
                {
                    
                    if (Convert.ToDouble(obj) < 0)
                    {
                        msg = captionName + " is required to be greater than zero.";
                    }
                    else if (Convert.ToDouble(obj) > 922337203685477.5808)
                    {
                        msg = captionName + " is to large of a number.";
                    }

                }
            }
            return msg;
        }

        private void gvImportedLots_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        public bool Finish()
        {
            bool returnValue = true;
            int InvalidClassSubClass = 0;
            try
            {
                InvalidClassSubClass = Convert.ToInt32(hmCon.SQLExecutor.ExecuteScalar(@"select count(*) from Working_PROJ_LOT where 
username = '" + hmCon.MLUser + "-Import' and (isnull(lot_class_id,-1) = -1 or isnull(lot_sub_class_id,-1) = -1 )", hmCon.TRConnection));
            }
            catch { }

            if (dt_Invalid_LotBlockPlan.Rows.Count > 0)
            {
                popup.ShowPopup("One or more of the lots imported have an invalid Lot/Block Combination (Highlighted Red).");
                returnValue = false;

            }
            else if (InvalidClassSubClass > 0)
            {
                popup.ShowPopup("One or more of the lots imported are missing Class and Sub Class(Highlighted Red).");
                returnValue = false;
            }

            if (returnValue)
            {
                hmCon.SQLExecutor.ExecuteNonQuery("update Working_PROJ_LOT set username = '" + hmCon.MLUser + "' where username = '" + hmCon.MLUser + "-Import'", hmCon.TRConnection);
                
            }
            return returnValue;
        }

        private void ri_lueLotClass_EditValueChanged(object sender, EventArgs e)
        {
            DataRow dr = gvImportedLots.GetDataRow(gvImportedLots.FocusedRowHandle);
            if (dr != null)
            {
                dr[collot_sub_class_id.FieldName] = DBNull.Value;

            }
        }
     
       
    }
}
