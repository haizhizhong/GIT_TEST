using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LD_RawLandCostUpdate
{
    public partial class ucCostSelection : DevExpress.XtraEditors.XtraUserControl
    {
        HMConnection.HMCon con;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup pop;
        private PC_CostCodesLU.PopupCostCodeLookup PopupCostCode;
        private int _RawLand_Pri_ID = -1;
        private int _Proj_Pri_ID = -1;
        private int _PROJ_LD_RawLandHolding_ID;

        public int GL_Year
        {
            get { return ucAccountingPicker1.SelectedYear; }
        }

        public int GL_Period
        {
            get { return ucAccountingPicker1.SelectedPeriod; }
        }

        public string MatchLevel
        {
            get { return rgCostComparision.EditValue.ToString(); }
        }

        public ucCostSelection(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc)
        {
            InitializeComponent();

            con = connection;
            tuc_mgr = tuc;
            pop = new WS_Popups.frmPopup(tuc);
            sqlTRConnection.ConnectionString = con.TRConnection;
            //sqlWebConnection.ConnectionString = con.WebConnection;
            
            this.PopupCostCode = new PC_CostCodesLU.PopupCostCodeLookup(con, ProjectTypes.ProjectType.PC_Land_Construction);
            this.PopupCostCode.ProjType = ProjectTypes.ProjectType.PC_Land_Construction;
            this.PopupCostCode.Disable_LEMOS = true;
            this.PopupCostCode.QueryPopUp += new CancelEventHandler(PopupCostCode_QueryPopUp);
            //this.PopupCostCode.Closed += PopupCostCode_Closed;
            this.PopupCostCode.Parent = pnlSelections;
            this.PopupCostCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupCostCode.Location = new System.Drawing.Point(716, 45);
            //this.PopupCostCode.MenuManager = this.barManager1;
            this.PopupCostCode.Name = "PopupCostCode";
            this.PopupCostCode.Size = new System.Drawing.Size(200, 20);
            this.PopupCostCode.TabIndex = 1;
            this.PopupCostCode.CostCodeLookup.ClearLEMOS();
            this.PopupCostCode.CostCodeLookup.AddSubContract();
            PopupCostCode.EditValueChanged += PopupCostCode_EditValueChanged;
            PopupCostCode.EditValueChanging += PopupCostCode_EditValueChanging;

            rgBudgetActual.EditValue = "A";
            rgActOptions.EditValue = "T";
            rgCostComparision.EditValue = "M";


            LoadLevels();
            gvCostSelection.BestFitColumns();
            


            da_working_ld_costs_to_transfer.SelectCommand.Parameters["@username"].Value = con.MLUser;
            ucAccountingPicker1.ConnectionString = con.TRConnection;
            ucAccountingPicker1.UserName = con.MLUser;
        }

        private void PopupCostCode_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if(rgCostComparision.EditValue.Equals("S"))
            {
                if( e.NewValue != null && e.NewValue != DBNull.Value && e.OldValue != null && e.OldValue != DBNull.Value)
                {
                    if( pop.ShowPopup("Changing the cost code will reset the grid, are you sure you want to continue?", WS_Popups.frmPopup.PopupType.OK_Cancel) != WS_Popups.frmPopup.PopupResult.OK)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else if( e.NewValue == null || e.NewValue == DBNull.Value)
                {
                    pop.ShowPopup("The single cost code must be set.");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void PopupCostCode_EditValueChanged(object sender, EventArgs e)
        {
            if( PopupCostCode.EditValue != null )
                FillSelectionGrid();
        }

        void PopupCostCode_QueryPopUp(object sender, CancelEventArgs e)
        {
            if(PopupCostCode.CostCodeLookup.Pri_ID == -1)
                this.PopupCostCode.CostCodeLookup.LoadCostCode(-1, -1, -1, -1, _Proj_Pri_ID, "S", "", -1);
        }

        private void ucCostSelection_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }

        public void RefreshSelection(int PROJ_LD_RawLandHolding_ID)
        {
            con.SQLExecutor.ExecuteNonQuery("delete working_ld_costs_to_transfer where username = '"+con.MLUser+"'", con.TRConnection);
            _PROJ_LD_RawLandHolding_ID = PROJ_LD_RawLandHolding_ID;
            _Proj_Pri_ID = -1;
            _RawLand_Pri_ID = -1;
            DataTable dt = con.SQLExecutor.ExecuteDataAdapter("select PRI_ID,RawLand_PRI_ID from PROJ_LD_RawLandHolding where ID = " + PROJ_LD_RawLandHolding_ID.ToString(), con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading project information:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    _Proj_Pri_ID = Convert.ToInt32(dt.Rows[0]["PRI_ID"]);
                    _RawLand_Pri_ID = Convert.ToInt32(dt.Rows[0]["RawLand_PRI_ID"]);
                }
            }
            RefreshDatasets();

            this.PopupCostCode.CostCodeLookup.LoadCostCode(-1, -1, -1, -1,_Proj_Pri_ID, "S", "", -1);
        }



        private void LoadLevels()
        {
            string sql = "select lv1_land_desc,isnull(lv1_active_land,'F')[lv1_active_land],lv2_land_desc,isnull(lv2_active_land,'F')[lv2_active_land],lv3_land_desc,isnull(lv3_active_land,'F')[lv3_active_land],lv4_land_desc,isnull(lv4_active_land,'F')[lv4_active_land] from proj_cntl";

            DataTable dt = con.SQLExecutor.ExecuteDataAdapter(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error loading level information:" + con.SQLExecutor.Exception.Message);
            else if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    
                    if (dt.Rows[0]["lv1_active_land"].ToString() == "T")
                    {
                        colDev_lvl1ID.Caption = "Project " + dt.Rows[0]["lv1_land_desc"].ToString();
                        colRaw_lvl1ID.Caption = "RLH " + dt.Rows[0]["lv1_land_desc"].ToString();
                        colDev_lvl1ID_Desc.Caption = "Project " + dt.Rows[0]["lv1_land_desc"].ToString()+" Description";
                        colRaw_lvl1ID_Desc.Caption = "RLH " + dt.Rows[0]["lv1_land_desc"].ToString()+" Description";
                    }
                    else
                    {
                        colDev_lvl1ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl1ID.Visible = false;
                        colRaw_lvl1ID.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl1ID.Visible = false;
                        colDev_lvl1ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl1ID_Desc.Visible = false;
                        colRaw_lvl1ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl1ID_Desc.Visible = false;
                    }
                    if (dt.Rows[0]["lv2_active_land"].ToString() == "T")
                    {
                        colDev_lvl2ID.Caption = "Project " + dt.Rows[0]["lv2_land_desc"].ToString();
                        colRaw_lvl2ID.Caption = "RLH " + dt.Rows[0]["lv2_land_desc"].ToString();
                        colDev_lvl2ID_Desc.Caption = "Project " + dt.Rows[0]["lv2_land_desc"].ToString()+" Description";
                        colRaw_lvl2ID_Desc.Caption = "RLH " + dt.Rows[0]["lv2_land_desc"].ToString() + " Description";
                    }
                    else
                    {
                        colDev_lvl2ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl2ID.Visible = false;
                        colRaw_lvl2ID.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl2ID.Visible = false;
                        colDev_lvl2ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl2ID_Desc.Visible = false;
                        colRaw_lvl2ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl2ID_Desc.Visible = false;
                    }
                    if (dt.Rows[0]["lv3_active_land"].ToString() == "T")
                    {
                        colDev_lvl3ID.Caption = "Project " + dt.Rows[0]["lv3_land_desc"].ToString();
                        colRaw_lvl3ID.Caption = "RLH " + dt.Rows[0]["lv3_land_desc"].ToString();
                        colDev_lvl3ID_Desc.Caption = "Project " + dt.Rows[0]["lv3_land_desc"].ToString()+" Description";
                        colRaw_lvl3ID_Desc.Caption = "RLH " + dt.Rows[0]["lv3_land_desc"].ToString()+" Description";
                    }
                    else
                    {
                        colDev_lvl3ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl3ID.Visible = false;
                        colRaw_lvl3ID.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl3ID.Visible = false;
                        colDev_lvl3ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl3ID_Desc.Visible = false;
                        colRaw_lvl3ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl3ID_Desc.Visible = false;
                    }
                    if (dt.Rows[0]["lv4_active_land"].ToString() == "T")
                    {
                        colDev_lvl4ID.Caption = "Project " + dt.Rows[0]["lv4_land_desc"].ToString();
                        colRaw_lvl4ID.Caption = "RLH " + dt.Rows[0]["lv4_land_desc"].ToString();
                        colDev_lvl4ID_Desc.Caption = "Project " + dt.Rows[0]["lv4_land_desc"].ToString()+" Description";
                        colRaw_lvl4ID_Desc.Caption = "RLH " + dt.Rows[0]["lv4_land_desc"].ToString()+" Description";
                    }
                    else
                    {
                        colDev_lvl4ID.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl4ID.Visible = false;
                        colRaw_lvl4ID.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl4ID.Visible = false;
                        colDev_lvl4ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colDev_lvl4ID_Desc.Visible = false;
                        colRaw_lvl4ID_Desc.OptionsColumn.ShowInCustomizationForm = false;
                        colRaw_lvl4ID_Desc.Visible = false;
                    }

                }
            }
            


        }

        private void RefreshDatasets()
        {
            ds_ALL_Levels1.Clear();
            if (colDev_lvl1ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level1.SelectCommand.Parameters["@pri_id"].Value = _Proj_Pri_ID;
                da_Level1.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl2ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level2.SelectCommand.Parameters["@pri_id"].Value = _Proj_Pri_ID;
                da_Level2.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl3ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level3.SelectCommand.Parameters["@pri_id"].Value = _Proj_Pri_ID;
                da_Level3.Fill(ds_ALL_Levels1);
            }
            if (colDev_lvl4ID.OptionsColumn.ShowInCustomizationForm)
            {
                da_Level4.SelectCommand.Parameters["@pri_id"].Value = _Proj_Pri_ID;
                da_Level4.Fill(ds_ALL_Levels1);
            }


        }


        private void rgBudgetActual_EditValueChanged(object sender, EventArgs e)
        {
            if (rgBudgetActual.EditValue != null && rgBudgetActual.EditValue != DBNull.Value)
            {
                if (rgBudgetActual.EditValue.ToString() == "A")
                {
                    rgActOptions.Enabled = true;
                    rgActOptions.EditValue = "T";
                }
                else
                {
                    rgActOptions.Enabled = false;
                    rgActOptions.EditValue = "P";
                }
            }
        }

        private void rgCostComparision_EditValueChanged(object sender, EventArgs e)
        {
            if (rgCostComparision.EditValue != null && rgCostComparision.EditValue != DBNull.Value)
            {
                if (rgCostComparision.EditValue.ToString() == "M")
                {
                    PopupCostCode.Enabled = false;
                    PopupCostCode.EditValue = null;
                    gvCostSelection.FormatRules[0].Enabled = true;
                }
                else
                {
                    PopupCostCode.Enabled = true;
                    gvCostSelection.FormatRules[0].Enabled = false;
                }

                string sSQL = @"delete working_ld_costs_to_transfer where username='"+con.MLUser+@"'";
                con.SQLExecutor.ExecuteNonQuery(sSQL, con.TRConnection);
                ds_working_ld_costs_to_transfer1.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (rgCostComparision.EditValue.ToString() == "S")
            {
                object result = con.SQLExecutor.ExecuteScalar("select PRI_ID from costing_budget where PRI_ID = " + PopupCostCode.CostCodeLookup.Pri_ID.ToString() + " and lv1ID = " + PopupCostCode.CostCodeLookup.Lv1_ID.ToString() +
                    " and isnull(lv2ID,-1) = " + PopupCostCode.CostCodeLookup.Lv2_ID.ToString() + " and isnull(lv3ID,-1) = " + PopupCostCode.CostCodeLookup.Lv3_ID.ToString() + " and isnull(lv4ID,-1) = " + PopupCostCode.CostCodeLookup.Lv4_ID.ToString() + " and LEM_COMP = 'S'", con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                    pop.ShowPopup("Error checking cost code is in project budget:" + con.SQLExecutor.Exception.Message);
                else if (result == DBNull.Value || result == null)
                {
                    pop.ShowPopup("Cost code combination not in development project's budget.");
                    return;
                }


            }
            if (ds_working_ld_costs_to_transfer1.working_ld_costs_to_transfer.Rows.Count > 0)
            {
                if (pop.ShowPopup("Warning this will clear any modifications made. Are you sure you want to continue?", WS_Popups.frmPopup.PopupType.Yes_No) != WS_Popups.frmPopup.PopupResult.Yes)
                    return;
            }

            FillSelectionGrid();
        }

        private void FillSelectionGrid()
        {
            ds_working_ld_costs_to_transfer1.Clear();
            string sql = "exec [LD_CostTransfer_SelectionFill] '" + con.MLUser + "'," + _PROJ_LD_RawLandHolding_ID.ToString() + ",'" + rgBudgetActual.EditValue.ToString() +
                "','" + rgActOptions.EditValue.ToString() + "'," + (ceShowZero.Checked ? "1" : "0");
            con.SQLExecutor.ExecuteNonQuery(sql, con.TRConnection);
            if (con.SQLExecutor.Exception != null)
            {
                pop.ShowPopup("Error loading cost code amount calcualtions:" + con.SQLExecutor.Exception.Message);
                return;
            }

            if (rgCostComparision.EditValue.ToString() == "S")
            {
                con.SQLExecutor.ExecuteNonQuery(@"update working_ld_costs_to_transfer set 

Dev_lvl1ID = " + PopupCostCode.CostCodeLookup.Lv1_ID.ToString() + @",
Dev_lvl2ID = " + PopupCostCode.CostCodeLookup.Lv2_ID.ToString() + @",
Dev_lvl3ID = " + PopupCostCode.CostCodeLookup.Lv3_ID.ToString() + @",
Dev_lvl4ID = " + PopupCostCode.CostCodeLookup.Lv4_ID.ToString() + @",
Dev_Matched = 1
where username = '" + con.MLUser + "'", con.TRConnection);
                if (con.SQLExecutor.Exception != null)
                {
                    pop.ShowPopup("Error setting single cost code:" + con.SQLExecutor.Exception.Message);
                    return;
                }
            }
            da_working_ld_costs_to_transfer.Fill(ds_working_ld_costs_to_transfer1);
        }

        #region Level Code Lookup Events

        private void ri_lueAll_Levels_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (gvCostSelection.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Cancel = RestrictLevel_LookupEdit((LookUpEdit)sender,gvCostSelection.GetFocusedDataRow());
                
            }
        }

        private bool RestrictLevel_LookupEdit(LookUpEdit lue, DataRow row)
        {
            try { //only allow unmatched level's be changed
                if(Convert.ToBoolean(row[colDev_Matched.FieldName]))
                {
                    pop.ShowPopup("You can not change a matched cost code.");
                return true;
                }
            }
            catch { }

            string sDisplayMember = lue.Properties.DisplayMember;
            string sValueMember = lue.Properties.ValueMember;
            //dont allow raw land to be edited
            if (sValueMember.Contains("Raw")) return true;

            int level = -1;
            int prevousLevelID = -1;
            if (sDisplayMember.Contains("1"))
            {
                level = 1;
                lue.Properties.DataSource = bs_lv1_Filtered;
            }
            else if (sDisplayMember.Contains("2"))
            {
                level = 2;
                lue.Properties.DataSource = bs_lv2_Filtered;
            }
            else if (sDisplayMember.Contains("3"))
            {
                level = 3;
                lue.Properties.DataSource = bs_lv3_Filtered;
            }
            else if (sDisplayMember.Contains("4"))
            {
                level = 4;
                lue.Properties.DataSource = bs_lv4_Filtered;
            }

            //only allow selections that are in the costin_budget table.
            string WhereFilter = "DevPri_ID <> null";
            
            //restrict to previous level selection
            if(level != 1)
            {
                try{prevousLevelID = Convert.ToInt32( row["colDev_lvl"+(level -1).ToString()+"ID"]);}catch{}
                WhereFilter += " and LV"+(level - 1).ToString()+"ID = "+prevousLevelID.ToString();
            }

            ((BindingSource)lue.Properties.DataSource).Filter = WhereFilter;
            ((BindingSource)lue.Properties.DataSource).Sort = sDisplayMember;
            return false;


        }
        private void ri_lueALLLevels_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                try
                { //only allow unmatched level's be changed
                    if (Convert.ToBoolean(gvCostSelection.GetDataRow(gvCostSelection.FocusedRowHandle)[colDev_Matched.FieldName]))
                    {
                        pop.ShowPopup("You can not change a matched cost code.");
                        return;
                    }
                }
                catch { }

                int level = -1;
                
                if (((LookUpEdit)sender).Properties.DisplayMember.Contains("1"))
                    level = 1;
                else if (((LookUpEdit)sender).Properties.DisplayMember.Contains("2"))
                    level = 2;
                else if (((LookUpEdit)sender).Properties.DisplayMember.Contains("3"))
                    level = 3;
                else if (((LookUpEdit)sender).Properties.DisplayMember.Contains("4"))
                    level = 4;
                
                gvCostSelection.GetDataRow(gvCostSelection.FocusedRowHandle)[colDev_lvl4ID.FieldName] = -1;
                if (level <= 3)
                    gvCostSelection.GetDataRow(gvCostSelection.FocusedRowHandle)[colDev_lvl3ID.FieldName] = -1;
                if (level <= 2)
                    gvCostSelection.GetDataRow(gvCostSelection.FocusedRowHandle)[colDev_lvl2ID.FieldName] = -1;
                if (level <= 1)
                    gvCostSelection.GetDataRow(gvCostSelection.FocusedRowHandle)[colDev_lvl1ID.FieldName] = -1;
            }
        }

        #endregion #region Level Code Lookup Events



        private void gvCostSelection_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;
            object result = con.SQLExecutor.ExecuteScalar("select PRI_ID from costing_budget where PRI_ID = " + rv[colDev_Pri_ID.FieldName].ToString() + " and lv1ID = " + rv[colDev_lvl1ID.FieldName].ToString() + " and isnull(lv2ID,-1) = " + rv[colDev_lvl2ID.FieldName].ToString() + " and isnull(lv3ID,-1) = " + rv[colDev_lvl3ID.FieldName].ToString() + " and isnull(lv4ID,-1) = " + rv[colDev_lvl4ID.FieldName].ToString() + " and LEM_COMP = '" + rv[colDev_LEMOS.FieldName].ToString() + "'", con.TRConnection);
            if (con.SQLExecutor.Exception != null)
                pop.ShowPopup("Error checking cost code is in project budget:" + con.SQLExecutor.Exception.Message);
            else if (result == DBNull.Value || result == null)
            {
                pop.ShowPopup("Cost code combination not in development project's budget.");
                e.Valid = false;
            }
            else if (rv[colNewTransferAmount.FieldName] == null || rv[colNewTransferAmount.FieldName] == DBNull.Value)
            {
                pop.ShowPopup("New Transfer Amount is required.");
                e.Valid = false;
            }
            else if (IsNumberToLarge(rv[colNewTransferAmount.FieldName]))
            {
                pop.ShowPopup("New Transfer Amount is to large.");
                e.Valid = false;
            }

        }

        private bool IsLessThenZero(object value, bool AllowZero)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try { dValue = Convert.ToDecimal(value); }
            catch { }

            if (dValue == 0 && !AllowZero)
                returnValue = true;
            else if (dValue < 0)
                returnValue = true;
            return returnValue;
        }

        private bool IsNumberToLarge(object value)
        {
            bool returnValue = false;
            decimal dValue = -1;
            try
            {
                dValue = Convert.ToDecimal(value);
            }
            catch
            {

            }

            if (dValue > 9999999999)
                returnValue = true;

            return returnValue;
        }



        private void gvCostSelection_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            da_working_ld_costs_to_transfer.Update(ds_working_ld_costs_to_transfer1);
        }

        private void gvCostSelection_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void rgCostComparision_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvCostSelection.RowCount > 0)
            {
                if (pop.ShowPopup("Changing the cost code matching option will cause the grid to reset, are you sure you want to continue?", WS_Popups.frmPopup.PopupType.OK_Cancel) != WS_Popups.frmPopup.PopupResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
