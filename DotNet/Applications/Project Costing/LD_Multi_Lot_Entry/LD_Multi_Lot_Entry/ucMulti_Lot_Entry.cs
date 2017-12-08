using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;

namespace LD_Multi_Lot_Entry
{
    public partial class ucMulti_Lot_Entry : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables declared here

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private WS_Popups.frmPopup Popups;
        private TUC_GridG.GridG GGLotEntry;

        private double CONST_SQ_FT_IN_ACRE = 43560;
        private double CONST_SQ_FT_IN_MT = 10.76391;
        private double CONST_SQ_MT_IN_HA = 10000;
        private string deleteStr = "Are you sure you want to delete?";
        private int _pri_id = 0;
        private int _lot_id = 0;
        private string _communities = "";

        private int classID = 0;
        private int SubClassID = 0;
        private string block_Num = "";
        private string plan_num = "";
        
        private string ma_prefix_dir = "";
	    private string ma_number= "";
	    private string ma_name = "";
	    private string ma_suffix = "";
	    private string ma_suffix_dir= "";
        private string ma_city = "";
        private string ma_prov = "";
        private string ma_postal = "";
        private string ma_site = "";

        private string address_1 = "";
        private string address_2 = "";
        private string city = "";
        private string prov = "";
        private string postal = "";
        

        public Form frm;

        #endregion

        public ucMulti_Lot_Entry(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg, int pLotID, int pPriID)
        {
            InitializeComponent();
            gcLotEntry.ForceInitialize();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            _lot_id = pLotID;
            _pri_id = pPriID;
            sqlConnTR.ConnectionString = hmConn.TRConnection;
            Popups = new WS_Popups.frmPopup(hmDevMgr);
            
            RunSetups();
            SetupGridG();
            ActivateLookups();
            GetLotDefaults();
           
            
        }
        private void SetupGridG()
        {
            GGLotEntry = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvLotEntry, daLotEntry,dsLotEntry1);
            GGLotEntry.AskBeforeDelete = false;
            GGLotEntry.AllowTabCreateNewRecord = true;
            GGLotEntry.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(GGLotEntry_AllowDelete);
        }

        bool GGLotEntry_AllowDelete(object sender, DataRow row)
        {
            return AllowDelete();
        }

        private bool AllowDelete()
        {
            bool doDeleting = false;
            try
            {

                if (this.Popups.ShowPopup(this, deleteStr, "Confirmation", WS_Popups.frmPopup.PopupType.Yes_No)
                    == WS_Popups.frmPopup.PopupResult.Yes)
                {
                     doDeleting = true;
                }

            }
            catch (Exception ex)
            {
                doDeleting = false;
                MessageBox.Show(String.Format("Error found in deleting process: ", ex.Message));
            }

            return doDeleting;

        }


        private void ucMulti_Lot_Entry_Load(object sender, EventArgs e)
        {
            hmDevMgr.FormInit(this);
            if (_lot_id > 0)
            {
               gcLotEntry.EmbeddedNavigator.Buttons.DoClick(gcLotEntry.EmbeddedNavigator.Buttons.Append);
               
            }
                      
             gcLotEntry.Focus();
            
           
        }
        private void ActivateLookups()
        {
            dsLotEntryLookups1.Clear();
            daLotEntryLookups.Fill(dsLotEntryLookups1);
            ds_lueBuildingRestrictions1.Clear();
            da_lueBuildingRestrictions.Fill(ds_lueBuildingRestrictions1);
            dsLotEntry1.Clear();
            daLotEntry.SelectCommand.Parameters["@username"].Value = hmConn.MLUser;
            daLotEntry.Fill(dsLotEntry1);
        }

        private void gvLotEntry_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            
            DataRow dr = gvLotEntry.GetDataRow(e.RowHandle);
            if (dr != null)
            {

                gvLotEntry.GetDataRow(e.RowHandle)["pri_id"] = _pri_id;
                gvLotEntry.GetDataRow(e.RowHandle)["frontage"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["depth"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["area_metre"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["area_hectares"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["original_price"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["current_price"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["commission_amt"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["commission_pct"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["area_ft"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["area_acres"] = 0;
                gvLotEntry.GetDataRow(e.RowHandle)["corner"] = "F";
                gvLotEntry.GetDataRow(e.RowHandle)["curb_treatment"] = "F";
                gvLotEntry.GetDataRow(e.RowHandle)["rear_side_treatment"] = "F";
                gvLotEntry.GetDataRow(e.RowHandle)["lot_status_id"] = 1;
                gvLotEntry.GetDataRow(e.RowHandle)["sub_status_id"] = 1;
                gvLotEntry.GetDataRow(e.RowHandle)["username"] = hmConn.MLUser;

                gvLotEntry.GetDataRow(e.RowHandle)["lot_class_id"] = classID;
                gvLotEntry.GetDataRow(e.RowHandle)["lot_sub_class_id"] = SubClassID;
                gvLotEntry.GetDataRow(e.RowHandle)["block_num"] = block_Num;
                gvLotEntry.GetDataRow(e.RowHandle)["plan_num"] = plan_num;

                gvLotEntry.GetDataRow(e.RowHandle)["ma_prefix_dir"] = ma_prefix_dir;
                //gvLotEntry.GetDataRow(e.RowHandle)["ma_number"] = ma_number;//Removed bug Item PR21
                gvLotEntry.GetDataRow(e.RowHandle)["ma_name"] = ma_name;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_suffix"] = ma_suffix;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_suffix_dir"] = ma_suffix_dir;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_city"] = ma_city;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_prov"] = ma_prov;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_postal"] = ma_postal;
                gvLotEntry.GetDataRow(e.RowHandle)["ma_site"] = ma_site;

                gvLotEntry.GetDataRow(e.RowHandle)["address_1"] = address_1;
                gvLotEntry.GetDataRow(e.RowHandle)["address_2"] = address_2;
                gvLotEntry.GetDataRow(e.RowHandle)["city"] = city;
                gvLotEntry.GetDataRow(e.RowHandle)["prov"] = prov;
                gvLotEntry.GetDataRow(e.RowHandle)["postal"] = postal;
                gvLotEntry.RefreshRow(e.RowHandle);
               
            }

        }

     
        private void RunSetups()
        {
            bool bUseMunicipalAddr = false;
            string sUOM = "M";
            int priCode = 0;
            string priName = "";
            string sqlStr = "  SELECT  ISNULL(UseMunicipalAddr,0) FROM LD_Setup";
            object obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
                bUseMunicipalAddr = Convert.ToBoolean(obj);

            sqlStr = "select ISNULL(UOM,'M') from PROJ_DEV_INFO where PRI_ID=" +  _pri_id.ToString();
            obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
                sUOM = obj.ToString();
                       

            sqlStr = "select  pri_name from PROJ_HEADER where pri_id = " + _pri_id.ToString();
            obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
                priName = obj.ToString();

            sqlStr = "select pri_code from PROJ_HEADER where pri_id = " + _pri_id.ToString();
            obj = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (obj != null && obj != DBNull.Value)
                priCode = Convert.ToInt32(obj);

            sqlStr = "select lc.Communities from PROJ_DEV_INFO di join LD_Communities lc on lc.Communities_ID=di.COMMUNITIES_ID where PRI_ID = " + _pri_id.ToString();
            _communities = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();

            txtPri_Code.Text = priCode.ToString();
            txtPri_Name.Text = priName;

            sqlStr = "delete Working_PROJ_LOT where username = '" + hmConn.MLUser + "'";
            hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
            if (hmConn.SQLExecutor.Exception != null)
            {
                Popups.ShowPopup("Error found in the delete working table  process: " + hmConn.SQLExecutor.Exception.Message);
            }

            if (sUOM == "M")
            {
                colarea_hectares.Visible = true;
                colarea_metre.Visible = true;
                colarea_hectares.OptionsColumn.ReadOnly = false;
                colarea_metre.OptionsColumn.ReadOnly = false;

                colarea_ft.Visible = false;
                colarea_acres.Visible = false;
                colarea_ft.OptionsColumn.ReadOnly = true;
                colarea_acres.OptionsColumn.ReadOnly = true;

            }
            else if (sUOM == "I")
            {
                colarea_hectares.Visible = false;
                colarea_metre.Visible = false;
                colarea_hectares.OptionsColumn.ReadOnly = true;
                colarea_metre.OptionsColumn.ReadOnly = true;

                colarea_ft.Visible = true;
                colarea_acres.Visible = true;
                colarea_ft.OptionsColumn.ReadOnly = false;
                colarea_acres.OptionsColumn.ReadOnly = false;
            }

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
        private void GetLotDefaults()
        {
            object[] lotInfo;
            string sqlStr = "select  block_num, plan_num, lot_class_id, lot_sub_class_id, address_1, address_2, city, prov, postal, ma_prefix_dir, ma_number, ma_name, " +
                           "  ma_suffix, ma_suffix_dir, ma_city, ma_prov, ma_postal,ma_site from PROJ_LOT where proj_lot_id = " +  _lot_id.ToString();
            lotInfo = FADO.DB.Global.Get1ArraySQL(hmConn.CompanyServer, hmConn.TRDB, sqlStr, "300");
            if (lotInfo != null)
            {
                block_Num = FADO.ObjConv.str(lotInfo[0]);
                plan_num = FADO.ObjConv.str(lotInfo[1]);
                classID = FADO.ObjConv.Int(lotInfo[2]);
                SubClassID = FADO.ObjConv.Int(lotInfo[3]);

                address_1 = FADO.ObjConv.str(lotInfo[4]);
                address_2 = FADO.ObjConv.str(lotInfo[5]);
                city = FADO.ObjConv.str(lotInfo[6]);
                prov = FADO.ObjConv.str(lotInfo[7]);
                postal = FADO.ObjConv.str(lotInfo[8]);

                ma_prefix_dir = FADO.ObjConv.str(lotInfo[9]);
                ma_number = FADO.ObjConv.str(lotInfo[10]);
                ma_name = FADO.ObjConv.str(lotInfo[11]);
                ma_suffix = FADO.ObjConv.str(lotInfo[12]);
                ma_suffix_dir = FADO.ObjConv.str(lotInfo[13]);
                ma_city = FADO.ObjConv.str(lotInfo[14]);
                ma_prov = FADO.ObjConv.str(lotInfo[15]);
                ma_postal = FADO.ObjConv.str(lotInfo[16]);
                ma_site = FADO.ObjConv.str(lotInfo[17]);

                
            }
        }
        private void gvLotEntry_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DataRow dr = gvLotEntry.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    double dArea_ft = 0;
                    double dArea_metre = 0;
                    double dAmt = 0;
                    double dCurrentPrice = 0;
                    double dOriginalPrice = 0;

                    if (dr["original_price"] != null && dr["original_price"] != DBNull.Value)
                        dOriginalPrice = Convert.ToDouble(dr["original_price"]);

                    if (dr["current_price"] != null && dr["current_price"] != DBNull.Value)
                        dCurrentPrice = Convert.ToDouble(dr["current_price"]);
                    if (e.Column == coloriginal_price)
                    {
                       // if (dCurrentPrice ==0)
                            dr["current_price"] = dOriginalPrice;
                    }
                    else if (e.Column == colarea_ft)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        dr["area_acres"] = Math.Round(dAmt / CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
                        CalculateMetricArea(dAmt);

                    }
                    else if (e.Column == colarea_acres)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        dArea_ft = Math.Round(dAmt * CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
                        dr["area_ft"] = dArea_ft;
                        CalculateMetricArea(dArea_ft);
                    }
                    else if (e.Column == colarea_metre)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        dr["area_hectares"] = Math.Round(dAmt / CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
                        CalculateImperialArea(dAmt);
                    }
                    else if (e.Column == colarea_hectares)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        dArea_metre = Math.Round(dAmt * CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
                        dr["area_metre"] = dArea_metre;
                        CalculateImperialArea(dArea_metre);
                    }
                    else if (e.Column == colcommission_amt)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        if (dCurrentPrice != 0)
                            dr["commission_pct"] = Math.Round(dAmt / dCurrentPrice * 100, 2, MidpointRounding.AwayFromZero);
                    }
                    else if (e.Column == colcommission_pct)
                    {
                        dAmt = 0;
                        if (e.Value != null && e.Value != DBNull.Value)
                        {
                            dAmt = Convert.ToDouble(e.Value);
                        }
                        dr["commission_amt"] = Math.Round((dAmt * .01) * dCurrentPrice, 2, MidpointRounding.AwayFromZero);
                    }
                }
            }
            catch (Exception ex)
            {
                Popups.ShowPopup("Exception found in Calculation:" + ex.Message.ToString());
            }
        }
        private void CalculateImperialArea(double dSqMt)
        {
            DataRow dr = gvLotEntry.GetDataRow(gvLotEntry.FocusedRowHandle);
            if (dr != null)
            {
                dr["area_ft"] = Math.Round(dSqMt * CONST_SQ_FT_IN_MT, 4, MidpointRounding.AwayFromZero);
                dr["area_acres"] = Math.Round((dSqMt * CONST_SQ_FT_IN_MT) / CONST_SQ_FT_IN_ACRE, 4, MidpointRounding.AwayFromZero);
            }

        }
        private void CalculateMetricArea(double dSqFt)
        {
            DataRow dr = gvLotEntry.GetDataRow(gvLotEntry.FocusedRowHandle);
            if (dr != null)
            {
                dr["area_metre"]  = Math.Round(dSqFt / CONST_SQ_FT_IN_MT, 4, MidpointRounding.AwayFromZero);
                dr["area_hectares"] = Math.Round((dSqFt / CONST_SQ_FT_IN_MT) / CONST_SQ_MT_IN_HA, 4, MidpointRounding.AwayFromZero);
            }

        }

        private void gvLotEntry_ShownEditor(object sender, EventArgs e)
        {
            DataView clone = null;
            DevExpress.XtraGrid.Views.Grid.GridView view;
            view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.FocusedColumn.FieldName == "lot_sub_class_id" && view.ActiveEditor is DevExpress.XtraEditors.LookUpEdit)
            {
                DevExpress.XtraEditors.LookUpEdit edit;
                edit = (DevExpress.XtraEditors.LookUpEdit)view.ActiveEditor;

                DataTable table = edit.Properties.DataSource as DataTable;
                clone = dsLotEntryLookups1.Table1.DefaultView;
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                if (row["Lot_Class_ID"] != null && row["Lot_Class_ID"] != DBNull.Value)
                {
                    clone.RowFilter = "[LD_Lot_Class_ID] = " + row["Lot_Class_ID"].ToString();

                }
                else
                {
                    clone.RowFilter = " [LD_Lot_Class_ID] = 0";
                }

                edit.Properties.DataSource = clone;
            }
        }

        private void gvLotEntry_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //****Validation may also need to be implemented in LD_LotImport******
             DataRow dr = gvLotEntry.GetDataRow(gvLotEntry.FocusedRowHandle);
             if (dr != null)
             {
                 object obj = dr["lot_class_id"];
                 if (obj == System.DBNull.Value || obj == null)
                 {
                     Popups.ShowPopup("Lot class is required.");
                     e.Valid = false;
                     return;
                 }
                 else if (Convert.ToInt32(obj)== 0)
                 {
                     Popups.ShowPopup("Lot class is required.");
                     e.Valid = false;
                     return;

                 }
                 obj = dr["lot_sub_class_id"];
                 if (obj == System.DBNull.Value || obj == null)
                 {
                     Popups.ShowPopup("Lot sub class is required.");
                     e.Valid = false;
                     return;
                 }
                 else if (Convert.ToInt32(obj) == 0)
                 {
                     Popups.ShowPopup("Lot sub class is required.");
                     e.Valid = false;
                     return;

                 }
                 obj = dr["lot_num"];
                 if (obj == System.DBNull.Value || obj == null)
                 {
                     Popups.ShowPopup("A lot # is required.");
                     e.Valid = false;
                     return;
                 }
                
                 else if (obj.ToString() == "")
                 {
                     Popups.ShowPopup("A lot # is required.");
                     e.Valid = false;
                     return;
                 }
                 obj = dr["block_num"];
                 if (obj == System.DBNull.Value || obj == null)
                 {
                     Popups.ShowPopup("A block # is required.");
                     e.Valid = false;
                     return;
                 }
                 else if (obj.ToString() == "")
                 {
                     Popups.ShowPopup("A block # is required.");
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
                 if (Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sSelect, hmConn.TRConnection)) > 0)
                 {
                     Popups.ShowPopup("The combination of lot # and block # entered already exists for this project.");
                     e.Valid = false;
                     return;
                 }
                 sSelect = "select COUNT(*) from Working_PROJ_LOT where pri_id = " + _pri_id.ToString() + " and lot_num = '" + lot_num + "'" +
                     " and block_num = '" + block_num + "'" + " and  proj_lot_id <> " + proj_lot_id.ToString() + 
                     " and username = '" + hmConn.MLUser+"'";
                 if (Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sSelect, hmConn.TRConnection)) > 0)
                 {
                     Popups.ShowPopup("The combination of lot # and block # entered already exists for this project.");
                     e.Valid = false;
                     return;
                 }

                 string msg = ValidMoneyTypeValue("depth", "Depth");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("frontage", "Frontage");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("area_metre", "Sq Meters");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("area_hectares", "Hectares");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("original_price", "Original Price");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("current_price", "Current Price");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("commission_amt", "Commission Amount");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("commission_pct", "Commission Percent");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("area_acres", "Acres");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }
                 msg = ValidMoneyTypeValue("area_ft", "Sq Ft");
                 if (msg != "")
                 {
                     Popups.ShowPopup(msg);
                     e.Valid = false;
                     return;
                 }

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

                 //****Validation may also need to be implemented in LD_LotImport******
             }
        }

        private string ValidMoneyTypeValue(string fieldName, string captionName)
        {
            string msg = "";
            DataRow dr = gvLotEntry.GetDataRow(gvLotEntry.FocusedRowHandle);
            if (dr != null)
            {
                object obj = dr[fieldName];
                if (obj != null && obj != DBNull.Value)
                {
                    if (Convert.ToDouble(obj) < 0 )
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
     
        
        private void gvLotEntry_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                 
           frm.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gvLotEntry.RowCount == 0)
            {
                Popups.ShowPopup("There is nothing to enter.");
                return;
            }
            if (Popups.ShowPopup("Are you sure you want to add these lots to project " + txtPri_Name.Text + "?", frmPopup.PopupType.Yes_No)
                        == frmPopup.PopupResult.Yes)
            {
                string sqlStr = "declare @username varchar(max) = '" + hmConn.MLUser + "' " +
                                 " insert PROJ_LOT ( pri_id, lot_num, block_num, plan_num, lot_class_id, lot_sub_class_id, lot_status_id, sub_status_id, parcel_number, " +
                                 " title_number, long_legal, frontage, depth, area_metre, area_hectares, corner, zoning_id, shapes_id, curb_treatment, " +
                                 " rear_side_treatment, paired_proj_lot_id, address_1, address_2, city, prov, postal, ma_prefix_dir, ma_number, ma_name, " +
                                 " ma_site, ma_suffix, ma_suffix_dir, ma_city, ma_prov, ma_postal, original_price, current_price, commission_amt, commission_pct,  " +
                                 " grading_id, buildtype_id, orientation_id, amenity_id, area_ft, area_acres,ExpectedSaleAmount,LeaseAmount, date_created ) " +
                                 " select pri_id, lot_num, block_num, plan_num, lot_class_id, lot_sub_class_id, lot_status_id, sub_status_id, parcel_number, " +
                                 " title_number, long_legal, frontage, depth, area_metre, area_hectares, corner, zoning_id, shapes_id, curb_treatment, " +
                                 " rear_side_treatment, paired_proj_lot_id, address_1, address_2, city, prov, postal, ma_prefix_dir, ma_number, ma_name, " +
                                 " ma_site, ma_suffix, ma_suffix_dir, ma_city, ma_prov, ma_postal, original_price, current_price, commission_amt, commission_pct,  " +
                                 " grading_id, buildtype_id, orientation_id, amenity_id, area_ft, area_acres,0,0, cast(getdate() as date)  " +
                                 " from Working_PROJ_LOT where username = @username " +

                                " insert into PROJ_LOT_RESTRICTION(proj_lot_id,RestrictionType_ID,Description,Building_Restrictions_ID)" +
                                " select pl.proj_lot_id,1,br.ExDescription,br.Building_Restrictions_ID from working_proj_lot l" +
                                " join LD_Building_Restrictions br on br.Building_Restrictions_ID = l.Acknowledgement_Restriction_ID" +
                                " join PROJ_LOT pl on pl.pri_id = l.pri_id and pl.lot_num = l.lot_num and pl.block_num = l.block_num " +
                                " where l.username = @username" +
                                " union all" +
                                " select pl.proj_lot_id,2,br.ExDescription,br.Building_Restrictions_ID from working_proj_lot l" +
                                " join LD_Building_Restrictions br on br.Building_Restrictions_ID = l.Building_Restriction_ID" +
                                " join PROJ_LOT pl on pl.pri_id = l.pri_id and pl.lot_num = l.lot_num and pl.block_num = l.block_num " +
                                " where l.username = @username" +
                                " union all" +
                                " select pl.proj_lot_id,3,br.ExDescription,br.Building_Restrictions_ID from working_proj_lot l" +
                                " join LD_Building_Restrictions br on br.Building_Restrictions_ID = l.Easement_Restriction_ID" +
                                " join PROJ_LOT pl on pl.pri_id = l.pri_id and pl.lot_num = l.lot_num and pl.block_num = l.block_num " +
                                " where l.username = @username";

                hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
                if (hmConn.SQLExecutor.Exception != null)
                    Popups.ShowPopup("Error found in the inserting process: " + hmConn.SQLExecutor.Exception.Message);
                

                else
                {
                    frm.DialogResult = DialogResult.OK;
                    frm.Close();
                }
                
            }
        }

        
        private void gvLotEntry_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
             DataRow dr = gvLotEntry.GetDataRow(gvLotEntry.FocusedRowHandle);
             if (dr != null)
             {
                 classID = Convert.ToInt32(dr["lot_class_id"]);
                 SubClassID = Convert.ToInt32(dr["lot_sub_class_id"]); ;
                 block_Num = dr["block_num"].ToString();
                 plan_num = dr["plan_num"].ToString();

                 ma_prefix_dir = dr["ma_prefix_dir"].ToString();
                 ma_number = dr["ma_number"].ToString();
                 ma_name = dr["ma_name"].ToString();
                 ma_suffix = dr["ma_suffix"].ToString();
                 ma_suffix_dir = dr["ma_suffix_dir"].ToString();
                 ma_city = dr["ma_city"].ToString();
                 ma_prov = dr["ma_prov"].ToString();
                 ma_postal = dr["ma_postal"].ToString();
                 ma_site = dr["ma_site"].ToString();

                 address_1 = dr["address_1"].ToString();
                 address_2 = dr["address_2"].ToString();
                 city = dr["city"].ToString();
                 prov = dr["prov"].ToString();
                 postal = dr["postal"].ToString();

             }
          
        }

        private void gvLotEntry_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DataRow row = ((gvLotEntry.DataSource as IList)[e.ListSourceRowIndex] as DataRowView).Row;
            if (row!=null)
            {
                if (e.Column.FieldName == "grdPriName" && e.IsGetData)
                {
                    e.Value = txtPri_Name.Text;
                }
                else if (e.Column.FieldName == "grdCommunity" && e.IsGetData)
                {
                    
                    e.Value = _communities;
                }
            }
        }

       
        private void btnLotImport_Click(object sender, EventArgs e)
        {
            using (LD_LotImport.frmView frm = new LD_LotImport.frmView(hmConn, hmDevMgr, _pri_id))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dsLotEntry1.Clear();
                    daLotEntry.Fill(dsLotEntry1);
                }
            }
        }

       

    }
}
