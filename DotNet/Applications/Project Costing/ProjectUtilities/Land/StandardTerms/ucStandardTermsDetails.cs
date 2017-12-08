using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using WS_Popups;

namespace ProjectUtilities.Land.StandardTerms
{
    public partial class ucStandardTermsDetails : DevExpress.XtraEditors.XtraUserControl
    {
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        public HMCon Connection;
        private frmPopup Popup;
        private Supplier_Lookup_Rep.Repository_Supplier_Lookup Supp_Repository;
        private bool isFilling = false;
        private int _PriID = -1;
        private TUC_GridG.GridG gGrid;
        private TUC_GridG.GridG gGridDiscounts;
        private bool _ReadOnly = false;

        private bool _lv1_active = false;
        private bool _lv2_active = false;
        private bool _lv3_active = false;
        private bool _lv4_active = false;
        private bool isTierPresale = false;


        public ucStandardTermsDetails(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            sqlTRConnection.ConnectionString = Connection.TRConnection;
            sqlTRConnection1.ConnectionString = Connection.TRConnection;
            TR_Conn.ConnectionString = Connection.TRConnection;
            Popup = new frmPopup(DevXMgr);
    
            for( int i = 0; i < dsStandardTermsDet1.LD_Load_StandardTerms_det.Columns.Count; i++ )
            {
                if( !dsStandardTermsDet1.LD_Load_StandardTerms_det.Columns[i].ColumnName.Equals("STANDARD_TERMS_DET_ID") )
                    dsStandardTermsDet1.LD_Load_StandardTerms_det.Columns[i].ReadOnly = false;
            }

            gGrid = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvDeposits, daDeposits, ds_Deposits1);
            gGrid.AllowTabCreateNewRecord = true;
            gGrid.AskBeforeDelete = false;
            gGrid.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            gGridDiscounts = new TUC_GridG.GridG(Connection.CompanyServer, Connection.TRDB, gvDiscounts, daDiscounts, ds_Discounts1);
            gGridDiscounts.AllowTabCreateNewRecord = true;
            gGridDiscounts.AskBeforeDelete = false;
            gGridDiscounts.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(gGrid_AllowDelete);

            SetupLevels();
            SetupSupplierLU();

            object result = Connection.SQLExecutor.ExecuteScalar("select isnull(TierPreSale,0) from LD_Setup", Connection.TRConnection);
            if (Connection.SQLExecutor.Exception != null)
                Popup.ShowPopup("Error checking for Tier Pre-Sale:" + Connection.SQLExecutor.Exception.Message);
            else if (Convert.ToBoolean(result))
            {
                isTierPresale = true;
            }
            else
            {
                colPresaleSeq.Visible = false;
                colPresaleSeq.OptionsColumn.ShowInCustomizationForm = false;
            }

           

        }

        private bool gGrid_AllowDelete(object sender, DataRow row)
        {
            if (Popup.ShowPopup("Are you sure you want to delete?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;
            else
                return false;
        }

        private void SetupSupplierLU()
        {
            Supp_Repository = new Supplier_Lookup_Rep.Repository_Supplier_Lookup();            
            Supp_Repository.HMConnection = Connection;
            Supp_Repository.DevXMgr = DevXMgr;
            Supp_Repository.ActiveSuppliers = true;
            Supp_Repository.ValueMember = "SUPPLIER_ID";
            colSupplier.ColumnEdit = Supp_Repository;
        }

        public void SetReadOnly(bool ReadOnly)
        {
            _ReadOnly = ReadOnly;
            gvDeposits.OptionsBehavior.Editable = !ReadOnly;
            btnCancel.Enabled = !ReadOnly;
            btnSave.Enabled = !ReadOnly;
            btnDelete.Enabled = !ReadOnly;
            btnLoadFromSetup.Enabled = !ReadOnly;
            ceRequired.Properties.ReadOnly = ReadOnly;
            rgDiscountType.Properties.ReadOnly = ReadOnly;
            rgPenaltyType.Properties.ReadOnly = ReadOnly;            
            
            seArrIntSpread.Properties.ReadOnly = ReadOnly;
            seArrMaxInt.Properties.ReadOnly = ReadOnly;
            seArrMinInt.Properties.ReadOnly = ReadOnly;
           
            seDiscountAmount.Properties.ReadOnly = ReadOnly;
            seDiscountPercent.Properties.ReadOnly = ReadOnly;
            seDownPayment.Properties.ReadOnly = ReadOnly;
            teOffsetInterest.Properties.ReadOnly = ReadOnly;
            teOffsetMaturity.Properties.ReadOnly = ReadOnly;
            sePenaltyAmount.Properties.ReadOnly = ReadOnly;
            sePenaltyPercent.Properties.ReadOnly = ReadOnly;
            seRegIntSpread.Properties.ReadOnly = ReadOnly;
            seRegMaxInt.Properties.ReadOnly = ReadOnly;
            seRegMinInt.Properties.ReadOnly = ReadOnly;

            lueArrFrequency.Properties.ReadOnly = ReadOnly;
            lueArrRateBasedOn.Properties.ReadOnly = ReadOnly;
            lueArrRateType.Properties.ReadOnly = ReadOnly;
            luePrimeSource.Properties.ReadOnly = ReadOnly;
            lueRegFrequency.Properties.ReadOnly = ReadOnly;
            lueRegRateBasedOn.Properties.ReadOnly = ReadOnly;
            lueRegRateType.Properties.ReadOnly = ReadOnly;

            gvLevy.OptionsBehavior.Editable = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Append.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Edit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.EndEdit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.CancelEdit.Visible = !ReadOnly;
            gcLevy.EmbeddedNavigator.Buttons.Remove.Visible = !ReadOnly;
        }

        public void LoadProject(int PriID)
        {
            _PriID = PriID;
            daStandardTermsDet.SelectCommand.Parameters["@PRI_ID"].Value = PriID;
            daStandardTermsDet.UpdateCommand.Parameters["@pri_id"].Value = PriID;

            dsStandardTermsDet1.Clear();
            daStandardTermsDet.Fill(dsStandardTermsDet1);
            FillLookups();
            gvStandardTerms.ExpandAllGroups();
        }

        private void FillLookups()
        {
            ds_StandardTerms_Lookups1.Clear();

            da_lueFrequency.Fill(ds_StandardTerms_Lookups1);
            da_luePrimeSource.Fill(ds_StandardTerms_Lookups1);
            da_lueRateBasedOn.Fill(ds_StandardTerms_Lookups1);
            da_lueRateType.Fill(ds_StandardTerms_Lookups1);
            da_lueDeposits.Fill(ds_StandardTerms_Lookups1);
            da_lueDepType.Fill(ds_StandardTerms_Lookups1);

            daLv1.Fill(dsLv1);
            daLv2.Fill(dsLv2);
            daLv3.Fill(dsLv3);
            daLv4.Fill(dsLv4);
            daLotClass.Fill(dsLotClass);
            daLevyType.Fill(dsLevyType);

            ds_lueDiscounts1.Clear();
            da_lueDiscounts.Fill(ds_lueDiscounts1);

        }


        private void ucStandardTermsDetails_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid(gvStandardTerms.FocusedRowHandle, true))
            {                
                DataRow row = gvStandardTerms.GetDataRow(gvStandardTerms.FocusedRowHandle);

                if (row != null)
                {
                    row.BeginEdit();
                    row["isSetup"] = true;
                    row.EndEdit();
                }

                daStandardTermsDet.Update(dsStandardTermsDet1);
                Popup.ShowPopup("Save Complete");
            }
        }

        private bool isValid(int RowHandle, bool ShowMessage)
        {
            bs_StandardTerms.EndEdit();
            bool returnValue = true;
            string ErrorMessage = "";
            if (luePrimeSource.EditValue == null || luePrimeSource.EditValue == DBNull.Value)
            {
                luePrimeSource.Focus();
                ErrorMessage += "Prime source is required.\r\n";
                goto Error;
            }
            if (lueRegRateType.EditValue == null || lueRegRateType.EditValue == DBNull.Value)
            {
                lueRegRateType.Focus();
                ErrorMessage += "Regular interest rate type is required.\r\n";
                goto Error;
            }
            if (lueRegRateBasedOn.EditValue == null || lueRegRateBasedOn.EditValue == DBNull.Value)
            {
                lueRegRateBasedOn.Focus();
                ErrorMessage += "Regular interest rate based on is required.\r\n";
                goto Error;
            }
            if (lueRegFrequency.EditValue == null || lueRegFrequency.EditValue == DBNull.Value)
            {
                lueRegFrequency.Focus();
                ErrorMessage += "Regular interest Compound Frequency is required.\r\n";
                goto Error;
            }
            if (lueArrRateType.EditValue == null || lueArrRateType.EditValue == DBNull.Value)
            {
                lueArrRateType.Focus();
                ErrorMessage += "Arrears interest rate type is required.\r\n";
                goto Error;
            }
            if (lueArrRateBasedOn.EditValue == null || lueArrRateBasedOn.EditValue == DBNull.Value)
            {
                lueArrRateBasedOn.Focus();
                ErrorMessage += "Arrears interest rate based on is required.\r\n";
                goto Error;
            }
            if (lueArrFrequency.EditValue == null || lueArrFrequency.EditValue == DBNull.Value)
            {
                lueArrFrequency.Focus();
                ErrorMessage += "Arrears interest Compound Frequency is required.\r\n";
                goto Error;
            }
            if( ValidatePercentage( seDownPayment.EditValue ) != "" )
            {
                seDownPayment.Focus();
                ErrorMessage += "Down Payment % must be between 0 and 100.\r\n";
                goto Error;
            }
            if( !isGreaterThenZero(seDiscountAmount.EditValue,true) )
            {
                seDiscountAmount.Focus();
                ErrorMessage += "Discount amount can not be negative.\r\n";
                goto Error;
            
            }
            if (ValidatePercentage(seDiscountPercent.EditValue) != "")
            {
                seDiscountPercent.Focus();
                ErrorMessage += "Discount % must be between 0 and 100.\r\n";
                goto Error;
            }
            if (!isGreaterThenZero(sePenaltyAmount.EditValue, true))
            {
                sePenaltyAmount.Focus();
                ErrorMessage += "Penalty amount can not be negative.\r\n";
                goto Error;

            }
            if (ValidatePercentage(sePenaltyPercent.EditValue) != "")
            {
                sePenaltyPercent.Focus();
                ErrorMessage += "Penalty % must be between 0 and 100.\r\n";
                goto Error;
            }
            if (ValidatePercentage(seRegMinInt.EditValue) != "")
            {
                seRegMinInt.Focus();
                ErrorMessage += "Min Interest Rate must be between 0 and 100.\r\n";
                goto Error;
            }
            if (ValidatePercentage(seRegIntSpread.EditValue) != "")
            {
                seRegIntSpread.Focus();
                ErrorMessage += "Interest Rate/Spread must be between 0 and 100.\r\n";
                goto Error;
            }
            if (ValidatePercentage(seRegMaxInt.EditValue) != "")
            {
                seRegMaxInt.Focus();
                ErrorMessage += "Max Interest Rate must be between 0 and 100.\r\n";
                goto Error;
            }

            if (ValidatePercentage(seArrMinInt.EditValue) != "")
            {
                seArrMinInt.Focus();
                ErrorMessage += "Arrears Min Interest Rate must be between 0 and 100.\r\n";
                goto Error;
            }
            if (ValidatePercentage(seArrIntSpread.EditValue) != "")
            {
                seArrIntSpread.Focus();
                ErrorMessage += "Arrears Interest Rate/Spread must be between 0 and 100.\r\n";
                goto Error;
            }
            if (ValidatePercentage(seArrMaxInt.EditValue) != "")
            {
                seArrMaxInt.Focus();
                ErrorMessage += "Arrears Max Interest Rate must be between 0 and 100.\r\n";
                goto Error;
            }
            if (!isGreaterThenZero(teOffsetInterest.EditValue, true))
            {
                teOffsetInterest.Focus();
                ErrorMessage += "Offset Interest can not be negative.\r\n";
                goto Error;

            }
            if (!isGreaterThenZero(teOffsetMaturity.EditValue, true))
            {
                teOffsetMaturity.Focus();
                ErrorMessage += "Offset Maturity can not be negative.\r\n";
                goto Error;

            }
            if (seDownPayment.Value > 2147483647)
            {
                seDownPayment.Focus();
                ErrorMessage += "Down Payment % is too large.\r\n";
                goto Error;
            }
            if (seDiscountAmount.Value > 2147483647)
            {
                seDiscountAmount.Focus();
                ErrorMessage += "Discount Amount is too large.\r\n";
                goto Error;
            }
            if (sePenaltyAmount.Value > 2147483647)
            {
                sePenaltyAmount.Focus();
                ErrorMessage += "Penalty Amount is too large.\r\n";
                goto Error;
            }
            if (seRegMinInt.Value > 2147483647)
            {
                seRegMinInt.Focus();
                ErrorMessage += "Regular Min Interest Rate is too large.\r\n";
                goto Error;
            }
            if (seRegMaxInt.Value > 2147483647)
            {
                seRegMaxInt.Focus();
                ErrorMessage += "Regular Max Interest Rate is too large.\r\n";
                goto Error;
            }
            if (seRegIntSpread.Value > 2147483647)
            {
                seRegIntSpread.Focus();
                ErrorMessage += "Regular Interest Rate / Spread is too large.\r\n";
                goto Error;
            }
            if (seArrMinInt.Value > 2147483647)
            {
                seArrMinInt.Focus();
                ErrorMessage += "Arrears Min Interest Rate is too large.\r\n";
                goto Error;
            }
            if (seArrMaxInt.Value > 2147483647)
            {
                seArrMaxInt.Focus();
                ErrorMessage += "Arrears Max Interest Rate is too large.\r\n";
                goto Error;
            }
            if (seArrIntSpread.Value > 2147483647)
            {
                seArrIntSpread.Focus();
                ErrorMessage += "Arrears Interest Rate / Spread is too large.\r\n";
                goto Error;
            }
            if (teOffsetInterest.Text == "")
                teOffsetInterest.EditValue = 0;
            if (Convert.ToDouble( teOffsetInterest.EditValue) > 2147483647)
            {
                teOffsetInterest.Focus();
                ErrorMessage += "Offset Interest is too large.\r\n";
                goto Error;
            }
            if (teOffsetMaturity.Text == "")
                teOffsetMaturity.EditValue = 0;
            if (Convert.ToDouble(teOffsetMaturity.EditValue) > 2147483647)
            {
                teOffsetMaturity.Focus();
                ErrorMessage += "To Offset Maturity is too large.\r\n";
                goto Error;
            }




            Error:

            if (ErrorMessage != "")
            {
                returnValue = false;
                if (ShowMessage)
                    Popup.ShowPopup(ErrorMessage);
            }

            return returnValue;
        }
        private bool isDataSaved(int RowHandle)
        {
            if (isFilling) return true;
            lueArrFrequency.BindingManager.EndCurrentEdit();
            bool returnValue = true;
            DataRow row = gvStandardTerms.GetDataRow(RowHandle);
            if (row != null)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    if (Popup.ShowPopup("Data has not been saved. Are you sure you want to continue?", WS_Popups.frmPopup.PopupType.Yes_No) != WS_Popups.frmPopup.PopupResult.Yes)
                    {
                        returnValue = false;
                    }
                    else
                        row.RejectChanges();

                }
            }
            return returnValue;
        }

        private void gvStandardTerms_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            e.Allow = isDataSaved(e.RowHandle);
        }

        private void gvStandardTerms_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isFilling) return;
            ds_Deposits1.Clear();
            gcDeposits.Enabled = false;
            dsLevy1.Clear();
            gcLevy.Enabled = false;
            ds_Discounts1.Clear();
            gcDiscounts.Enabled = false;
            DataRow row = gvStandardTerms.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                grpStandardTerms.Enabled = true;
                if (row["STANDARD_TERMS_DET_ID"] != DBNull.Value && row["STANDARD_TERMS_DET_ID"] != null)
                {
                    //enable grid if its not readonly.
                    gcDeposits.Enabled = !_ReadOnly;
                    daDeposits.SelectCommand.Parameters["@StandardTerms_Det_ID"].Value = row["STANDARD_TERMS_DET_ID"];
                    daDeposits.Fill(ds_Deposits1);

                    gcLevy.Enabled = !_ReadOnly;
                    daLevy.SelectCommand.Parameters["@StandardTerms_Det_ID"].Value = row["STANDARD_TERMS_DET_ID"];
                    daLevy.Fill(dsLevy1);

                    gcDiscounts.Enabled = !_ReadOnly;
                    daDiscounts.SelectCommand.Parameters["@LD_StandardTerms_Det_ID"].Value = row["STANDARD_TERMS_DET_ID"];
                    daDiscounts.Fill(ds_Discounts1);
                }
            }
            else
            {
                grpStandardTerms.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lueArrFrequency.BindingManager.EndCurrentEdit();
            dsStandardTermsDet1.RejectChanges();
        }

        private void btnLoadFromSetup_Click(object sender, EventArgs e)
        {
            if (Popup.ShowPopup("This will not overwrite the standard terms that are currently setup on this project.\r\nAre you sure you want to load the standard terms from the setup?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
            {
                string sSQL = @"select REGIONS_ID from PROJ_DEV_INFO where pri_id = " + _PriID;
                object oRegionID = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (Connection.SQLExecutor.Exception != null)
                {
                    Popup.ShowPopup("Error loading from setup(region):" + Connection.SQLExecutor.Exception.Message);
                }
                else
                {
                    if (oRegionID != null && oRegionID != DBNull.Value)
                    {
                        sSQL = @"exec LD_Load_StandardTerms_Det_FromSetup " + _PriID + @", " + oRegionID;
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                        if (Connection.SQLExecutor.Exception != null)
                        {
                            Popup.ShowPopup("Error loading from setup:" + Connection.SQLExecutor.Exception.Message);
                        }
                        else
                        {
                            LoadProject(_PriID);
                            Popup.ShowPopup("Load from setup complete");
                        }
                    }
                    else
                    {
                        Popup.ShowPopup("Region must be setup on project header to load standard terms from setup.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow row = gvStandardTerms.GetDataRow(gvStandardTerms.FocusedRowHandle);
            if (row != null)
            {
                if (Convert.ToBoolean(row[colisSetup.FieldName]))
                {
                    if (Popup.ShowPopup("Are you sure you want to delete the selected standard term?", WS_Popups.frmPopup.PopupType.Yes_No) == frmPopup.PopupResult.Yes)
                    {
                        string sSQL = @"exec LD_Delete_StandardTerms_Det " + row["STANDARD_TERMS_DET_ID"];
                        Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                        if (Connection.SQLExecutor.Exception != null)
                            Popup.ShowPopup("Error deleting standard term:" + Connection.SQLExecutor.Exception.Message);
                        LoadProject(_PriID);
                    }
                }
                else
                {
                    Popup.ShowPopup("Standard terms must be setup to delete.");
                }
            }
        }

        private void gvDeposits_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow row = gvDeposits.GetDataRow(e.RowHandle);
            if (row != null)
            {
                row[colLD_StandardTerms_Det_ID.FieldName] = daDeposits.SelectCommand.Parameters["@StandardTerms_Det_ID"].Value;
            }
        }

        private void gvDeposits_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;

            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colDepositType, colLD_Deposits_ID, colDepositType, colAmountPercent, coloff_set_days }, false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[colAmountPercent.FieldName], false))
            {
                Popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (isPreSaleSeqInvalid((DataRowView)e.Row))
            {
                Popup.ShowPopup("Pre-sale sequence must be between 1 and 10.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }



        }

        private string ValidateColumnsRequired(DataRowView RowView, DevExpress.XtraGrid.Columns.GridColumn[] gridColumns, bool multiLine)
        {
            string returnValue = "";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridColumns)
            {
                bool Process = false;
                if (RowView[col.FieldName] == DBNull.Value || RowView[col.FieldName] == null)
                {
                    Process = true;
                }
                else if (RowView[col.FieldName].ToString().Trim() == "")
                {
                    Process = true;
                }
                if (Process)
                {

                    returnValue += GetColumnsCaption(col) + " is required.";
                    if (!multiLine)
                        break;
                    else
                        returnValue += "\r\n";

                }
            }

            return returnValue;
        }
        private string GetColumnsCaption(DevExpress.XtraGrid.Columns.GridColumn col)
        {
            StringBuilder newText = new StringBuilder();
            if (col.Caption.ToString().Trim() == "")
            {
                if (string.IsNullOrEmpty(col.FieldName))
                    return "";

                newText.Append(col.FieldName[0]);
                for (int i = 1; i < col.FieldName.Length; i++)
                {
                    if (char.IsUpper(col.FieldName[i]))
                        newText.Append(' ');
                    newText.Append(col.FieldName[i]);
                }
            }
            else
                newText.Append(col.Caption);


            return newText.ToString();
        }
        private bool isGreaterThenZero(object Value, bool AllowEqual)
        {
            double dValue = -1;
            try
            {
                dValue = Convert.ToDouble(Value);
            }
            catch { }

            if (dValue > 0)
                return true;
            else if (dValue == 0 && AllowEqual)
                return true;
            else
                return false;
        }
        private bool isPreSaleSeqInvalid(DataRowView drv)
        {
            bool returnValue = false;
            if (isTierPresale)
            {
                if (ds_StandardTerms_Lookups1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(drv[colLD_Deposits_ID.FieldName])).Type == "P")
                {
                    int PresaleSeq = -1;
                    try
                    {
                        PresaleSeq = Convert.ToInt32(drv[colPresaleSeq.FieldName]);
                    }
                    catch { }
                    if (PresaleSeq > 10 || PresaleSeq < 1)
                        returnValue = true;
                }

            }


            return returnValue;
        }

        private void gvDeposits_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void ri_lueDeposit_EditValueChanged(object sender, EventArgs e)
        {
            object Offset = ((LookUpEdit)sender).GetColumnValue("Off_Set_Days");

            gvDeposits.SetFocusedRowCellValue(coloff_set_days, Offset);

            LookUpEdit lue = (LookUpEdit)sender;
            if (lue.EditValue != null && lue.EditValue != DBNull.Value && isTierPresale)
            {
                try
                {
                    if (ds_StandardTerms_Lookups1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(lue.EditValue)).Type == "P")
                    {
                        object sequence = Connection.SQLExecutor.ExecuteScalar(@"select max(isnull(t.presaleseq,0)) from LD_Standard_Terms_Deposits_Det t
join LD_Deposits d on d.Deposit_ID = t.LD_Deposits_ID
where d.Type = 'P' and t.LD_StandardTerms_Det_ID =" + daDeposits.SelectCommand.Parameters["@StandardTerms_Det_ID"].Value, Connection.TRConnection);
                        if (sequence != null && sequence != DBNull.Value)
                            sequence = Convert.ToInt32(sequence) + 1;
                        else
                            sequence = 1;

                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, sequence);
                    }
                    else
                        gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value);
                }
                catch { gvDeposits.SetFocusedRowCellValue(colPresaleSeq, DBNull.Value); }
            }
        }

       


        private string ValidatePercentage(object percent)
        {
            double value = 0;
            try
            {
                value = Convert.ToDouble(percent);
            }
            catch { }

            if (value > 100 || value < 0)
                return "Value must be between 0 and 100.";
            else
                return "";
        }

        #region Levy

        private void SetupLevels()
        {
            daLv1.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv2.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv3.SelectCommand.Parameters["@projtype"].Value = "L";
            daLv4.SelectCommand.Parameters["@projtype"].Value = "L";

            string sSQL = @"select  isnull(lv1_land_desc,'')[lv1_land_desc], isnull(lv2_land_desc,'')[lv2_land_desc],
                isnull(lv3_land_desc,'')[lv3_land_desc], isnull(lv4_land_desc,'')[lv4_land_desc], 
                isnull(lv1_active_land,'F')[lv1_active_land], isnull(lv2_active_land,'F')[lv2_active_land], 
                isnull(lv3_active_land,'F')[lv3_active_land] , isnull(lv4_active_land,'F')[lv4_active_land] 
            from proj_cntl";

            DataTable dt = Connection.SQLExecutor.ExecuteDataAdapter(sSQL, Connection.TRConnection);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (dr != null)
                    {
                        collv1id.Caption = dr["lv1_land_desc"].ToString();
                        collv2id.Caption = dr["lv2_land_desc"].ToString();
                        collv3id.Caption = dr["lv3_land_desc"].ToString();
                        collv4id.Caption = dr["lv4_land_desc"].ToString();

                        collv1id.OptionsColumn.ShowInCustomizationForm = collv1id.Visible = _lv1_active = (dr["lv1_active_land"].ToString() == "T");
                        collv2id.OptionsColumn.ShowInCustomizationForm = collv2id.Visible = _lv2_active = (dr["lv2_active_land"].ToString() == "T");
                        collv3id.OptionsColumn.ShowInCustomizationForm = collv3id.Visible = _lv3_active = (dr["lv3_active_land"].ToString() == "T");
                        collv4id.OptionsColumn.ShowInCustomizationForm = collv4id.Visible = _lv4_active = (dr["lv4_active_land"].ToString() == "T");
                    }
                }
            }
        }

        private void riAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object oAmount = e.NewValue;
            if (oAmount == null || oAmount == DBNull.Value)
                oAmount = 0;

            double dAmout = Convert.ToDouble(oAmount);
            if (dAmout < -999999999999999.99 || dAmout > 999999999999999.99)
            {
                e.Cancel = true;
                return;
            }
        }

        private void riLevel2_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv1ID = dr["lv1id"];
                if (oLv1ID == null || oLv1ID == DBNull.Value)
                    oLv1ID = -1;

                bsLv2Filtered.Filter = "lv1id = " + oLv1ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv2Filtered;
            }
        }

        private void riLevel3_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv2ID = dr["lv2id"];
                if (oLv2ID == null || oLv2ID == DBNull.Value)
                    oLv2ID = -1;

                bsLv3Filtered.Filter = "lv2id = " + oLv2ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv3Filtered;
            }
        }

        private void riLevel4_Enter(object sender, EventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLv3ID = dr["lv3id"];
                if (oLv3ID == null || oLv3ID == DBNull.Value)
                    oLv3ID = -1;

                bsLv4Filtered.Filter = "lv3id = " + oLv3ID;
                ((LookUpEdit)sender).Properties.DataSource = bsLv4Filtered;
            }
        }

        private void riLevel1_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv2id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel2_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv3id", DBNull.Value);
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void riLevel3_EditValueChanged(object sender, EventArgs e)
        {
            gvLevy.SetFocusedRowCellValue("lv4id", DBNull.Value);
        }

        private void gvLevy_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                object oLD_Levy_ID = dr["LD_Levy_ID"];
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                {
                    e.Valid = false;
                    e.ErrorText = "'Levy' is required.";
                    gvLevy.FocusedColumn = colLD_Levy_ID;
                    return;
                }

                if (_lv1_active)
                {
                    object olv1id = dr["lv1id"];
                    if (olv1id == null || olv1id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv1id.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv1id;
                        return;
                    }
                }

                if (_lv2_active)
                {
                    object olv2id = dr["lv2id"];
                    if (olv2id == null || olv2id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv2id.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv2id;
                        return;
                    }
                }

                if (_lv3_active)
                {
                    object olv3id = dr["lv3id"];
                    if (olv3id == null || olv3id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv3id.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv3id;
                        return;
                    }
                }

                if (_lv4_active)
                {
                    object olv4id = dr["lv4id"];
                    if (olv4id == null || olv4id == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'" + collv4id.Caption + "' is required.";
                        gvLevy.FocusedColumn = collv4id;
                        return;
                    }
                }

                object oAmount = dr["Amount"];
                if (oAmount == null || oAmount == DBNull.Value)
                    oAmount = 0;

                if (Convert.ToDouble(oAmount) == 0)
                {
                    e.Valid = false;
                    e.ErrorText = "'Amount' is required.";
                    gvLevy.FocusedColumn = colAmount;
                    return;
                }

                // supplier only needs to be validated if the type = 'other'
                string sSQL = @"select count(*) 
                from LD_Levy l 
                join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
                object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;
                if (Convert.ToInt32(oCNT) == 1)
                {
                    object oSupplier_ID = dr["Supplier_ID"];
                    if (oSupplier_ID == null || oSupplier_ID == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "'Supplier' is required.";
                        gvLevy.FocusedColumn = colSupplier;
                        return;
                    }
                }
            }
        }

        private void gvLevy_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            daLevy.Update(dsLevy1);
        }

        private void gcLevy_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete the selected 'Levy'?", WS_Popups.frmPopup.PopupType.OK_Cancel) ==
                     WS_Popups.frmPopup.PopupResult.OK)
                {
                    gvLevy.DeleteRow(gvLevy.FocusedRowHandle);
                    daLevy.Update(dsLevy1);
                }
                e.Handled = true;
            }
        }

        private void gvLevy_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            Popup.ShowPopup(e.ErrorText);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvLevy_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvLevy.GetFocusedDataRow();
            if (dr != null)
            {
                dr["LD_StandardTerms_Det_ID"] = daLevy.SelectCommand.Parameters["@StandardTerms_Det_ID"].Value;
            }
        }

        private void riLevy_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object oLD_Levy_ID = e.NewValue;
            if( oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value )
                oLD_Levy_ID = -1;
            string sSQL = @"select count(*) 
                from LD_Levy l 
                join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
            object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
            if (oCNT == null || oCNT == DBNull.Value)
                oCNT = 0;
            if (Convert.ToInt32(oCNT) == 0)
            {
                gvLevy.SetFocusedRowCellValue("Supplier_ID", DBNull.Value);
            }
        }

        private void gvLevy_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colSupplier)
            {
                object oLD_Levy_ID = gvLevy.GetFocusedRowCellValue("LD_Levy_ID");
                if (oLD_Levy_ID == null || oLD_Levy_ID == DBNull.Value)
                    oLD_Levy_ID = -1;
                string sSQL = @"select count(*) 
                from LD_Levy l 
                join LD_LevyType t on t.LevyType_ID=l.LevyType_ID
                where l.Levy_ID=" + oLD_Levy_ID + @" and t.PaidTo='O'";
                object oCNT = Connection.SQLExecutor.ExecuteScalar(sSQL, Connection.TRConnection);
                if (oCNT == null || oCNT == DBNull.Value)
                    oCNT = 0;
                if (Convert.ToInt32(oCNT) == 1)
                    e.RepositoryItem = Supp_Repository;
                else
                    e.RepositoryItem = riRO;
            }
        }

        #endregion

        private void ri_lueDepositType_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void gvDeposits_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colPresaleSeq)
            {
                DataRow row = gvDeposits.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row[colLD_Deposits_ID.FieldName] != null && row[colLD_Deposits_ID.FieldName] != DBNull.Value)
                    {
                        try
                        {
                            if (ds_StandardTerms_Lookups1.LD_Deposits.FindByDeposit_ID(Convert.ToInt32(row[colLD_Deposits_ID.FieldName])).Type == "P")
                                e.RepositoryItem = ri_teNumaric0;
                            else
                                e.RepositoryItem = ri_teReadOnly;
                        }
                        catch { e.RepositoryItem = ri_teReadOnly; }
                    }
                    else
                        e.RepositoryItem = ri_teReadOnly;
                }
            }
        }

        private void gvDiscounts_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvDiscounts.GetDataRow(e.RowHandle);
            dr[colLD_Standard_Terms_Det_ID.FieldName] = daDiscounts.SelectCommand.Parameters["@LD_StandardTerms_Det_ID"].Value;
        }

        private void gvDiscounts_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText == "DeveloperThrownError")
            {
                //was handled in the validate row and message was shown there
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvDiscounts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string ErrorMessage;
            if ((ErrorMessage = ValidateColumnsRequired((DataRowView)e.Row, new DevExpress.XtraGrid.Columns.GridColumn[] { colLD_Discounts_ID, colType, colValue }, false)) != "")
            {
                Popup.ShowPopup(ErrorMessage);
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (!isGreaterThenZero(((DataRowView)e.Row)[colValue.FieldName], false))
            {
                Popup.ShowPopup("Value must be greater then 0.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
            else if (IsNumberToLarge(((DataRowView)e.Row)[colValue.FieldName]))
            {
                Popup.ShowPopup("Value is too large.");
                e.ErrorText = "DeveloperThrownError";
                e.Valid = false;
            }
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

        private void rilueDiscount_EditValueChanged(object sender, EventArgs e)
        {
            if (gvDiscounts.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                LookUpEdit lue = (LookUpEdit)sender;

                if (lue.EditValue != null && lue.EditValue != DBNull.Value)
                {
                    DataRowView row = (DataRowView)lue.GetSelectedDataRow();
                    if (row != null)
                    {
                        object cellValue = gvDiscounts.GetFocusedRowCellValue(colValue);
                        if (cellValue == null || cellValue == DBNull.Value)
                            gvDiscounts.SetFocusedRowCellValue(colValue, row["Value"]);
                        cellValue = gvDiscounts.GetFocusedRowCellValue(colType);
                        if (cellValue == null || cellValue == DBNull.Value)
                            gvDiscounts.SetFocusedRowCellValue(colType, row["Type"]);
                    }
                }
            }
        }
    }
}
