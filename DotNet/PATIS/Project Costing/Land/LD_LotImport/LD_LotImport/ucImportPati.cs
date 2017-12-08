using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SSI = SpreadSheetImport;


namespace LD_LotImport
{
    public partial class ucImportPati : DevExpress.XtraEditors.XtraUserControl
    {


        HMConnection.HMCon hmCon;
        TUC_HMDevXManager.TUC_HMDevXManager tuc_mgr;
        WS_Popups.frmPopup popup;
        TUC_GridG.GridG gGrid;
        private SSI.ReflexImportSpec RISpec;
        private SpreadSheetImport.ucSSI SSIControl;
        private ucValidate ucValidation;
        private int _pri_id = -1;
        private string csWorkingTable = "";
        private bool UseMunicipalAddress = false;
        public delegate void hButtonCancelClick();
        public event hButtonCancelClick ButtonCancelClick;

        public delegate void hFinished();
        public event hFinished Finished;

        public ucImportPati(HMConnection.HMCon connection, TUC_HMDevXManager.TUC_HMDevXManager tuc, int pri_id)
        {
            InitializeComponent();

            hmCon = connection;
            tuc_mgr = tuc;
            _pri_id = pri_id;
            sqlTRConnection.ConnectionString = hmCon.TRConnection;
            popup = new WS_Popups.frmPopup(tuc);
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpImport;
            csWorkingTable = "LD_LOT_IMPORT_" + hmCon.MLUser;

            try
            {
                UseMunicipalAddress = Convert.ToBoolean(hmCon.SQLExecutor.ExecuteScalar(
                    "select isnull(UseMunicipalAddr,0) from ld_setup", hmCon.TRConnection));
            }
            catch { }

            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcDetails.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void ucImportPati_Load(object sender, EventArgs e)
        {
            tuc_mgr.FormInit(this);
        }


        private void Reset()
        {
            tcMain.SelectedTabPage = tpMain;
            tcDetails.SelectedTabPage = tpImport;
            btnNext.Text = "Next";
            btnBack.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                if (tcDetails.SelectedTabPage == tpImport)
                {
                    tcMain.SelectedTabPage = tpMain;
                    btnBack.Enabled = false;
                }
                else if (tcDetails.SelectedTabPage == tpValidate)
                {
                    tcDetails.SelectedTabPage = tpImport;
                    btnNext.Text = "Next";
                    
                }

            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTabPage == tpMain)
            {
                btnBack.Enabled = true;
                tcMain.SelectedTabPage = tpDetails;
                tcDetails.SelectedTabPage = tpImport;
                LoadSpreadSheetImporter();
            }
            else
            {
                if (tcDetails.SelectedTabPage == tpImport)
                {
                    if (ValidateSreadSheetImporter())
                    {
                        if(ucValidation == null)
                        {
                            ucValidation = new ucValidate(hmCon, tuc_mgr,_pri_id);
                            ucValidation.Dock = DockStyle.Fill;
                            ucValidation.Parent = tpValidate;
                        }
                        else
                            ucValidation.RefreshMe();
                        
                        tcDetails.SelectedTabPage = tpValidate;
                        btnNext.Text = "Finish";
                        btnBack.Enabled = false;
                    }
                }
                else if (tcDetails.SelectedTabPage == tpValidate)
                {
                    if (btnNext.Text == "Finish")
                    {
                        if (ucValidation.Finish())
                        {
                            btnNext.Text = "Restart";
                            if (Finished != null)
                                Finished();
                        }
                    }
                    else
                        Reset();
                }
                 
            }
        }


        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if( popup.ShowPopup("Are you sure you want to cancel?",WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                if(ButtonCancelClick != null)
                    ButtonCancelClick();
                Reset();
            }
        }

        private void LoadSpreadSheetImporter()
        {
            if (RISpec == null)
            {
                RISpec = new SSI.ReflexImportSpec(csWorkingTable, SSI.ReflexImportSpec.DatabaseFlavourEnum.TR);

                //New			
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Lot", SSI.ReflexImportField.EnumFieldType.String, 5, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Block", SSI.ReflexImportField.EnumFieldType.String, 5, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Plan", SSI.ReflexImportField.EnumFieldType.String, 12, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Class", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Sub Class", SSI.ReflexImportField.EnumFieldType.String, 25, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Parcel Number", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Title", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Frontage", SSI.ReflexImportField.EnumFieldType.Float, 40, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Acres", SSI.ReflexImportField.EnumFieldType.Float, 40, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Depth", SSI.ReflexImportField.EnumFieldType.Float, 40, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Zone", SSI.ReflexImportField.EnumFieldType.String, 25, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Shape", SSI.ReflexImportField.EnumFieldType.String, 25, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Original Price", SSI.ReflexImportField.EnumFieldType.Float, 40, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Current Price", SSI.ReflexImportField.EnumFieldType.Float, 40, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Building Restriction", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Easement", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Acknowledgement", SSI.ReflexImportField.EnumFieldType.String, 20, true));

                if (UseMunicipalAddress)
                {
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Prefix Direction", SSI.ReflexImportField.EnumFieldType.String, 2, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Street Number", SSI.ReflexImportField.EnumFieldType.String, 10, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Street Name", SSI.ReflexImportField.EnumFieldType.String, 30, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Site", SSI.ReflexImportField.EnumFieldType.String, 50, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Suffix", SSI.ReflexImportField.EnumFieldType.String, 6, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Suffix Direction", SSI.ReflexImportField.EnumFieldType.String, 2, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("City", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Province", SSI.ReflexImportField.EnumFieldType.String, 2, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Postal", SSI.ReflexImportField.EnumFieldType.String, 10, true));


                }
                else
                {
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Address 1", SSI.ReflexImportField.EnumFieldType.String, 40, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Address 2", SSI.ReflexImportField.EnumFieldType.String, 40, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("City", SSI.ReflexImportField.EnumFieldType.String, 20, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Province", SSI.ReflexImportField.EnumFieldType.String, 2, true));
                    RISpec.FieldCollection.AddImportField(new SSI.ReflexImportField("Postal", SSI.ReflexImportField.EnumFieldType.String, 10, true));
                }



                SSIControl = new SpreadSheetImport.ucSSI(hmCon, tuc_mgr, RISpec);
                SSIControl.Dock = DockStyle.Fill;
                SSIControl.Parent = tpImport;
            }
           

            
        }


        private bool ValidateSreadSheetImporter()
        {
            bool bReturn = SSIControl.Complete;

            if (!bReturn)
                popup.ShowPopup(this, "Spreadsheet is not loaded or there was a problem in loading. Please correct this in order to continue");
            else
                hmCon.SQLExecutor.ExecuteNonQuery("alter table "+csWorkingTable+" add Import_ID int identity(1,1)",hmCon.TRConnection);


            return bReturn;
        }

        private void tcDetails_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tpImport)
            {
                topBanner1.BannerText = "Select a spreadsheet to import and click on validate.";
                topBanner1.BannerTitle = "Lot Import";
            }
            else if (e.Page == tpValidate)
            {
                topBanner1.BannerText = "Fix any errors highlighted in red and click on finish.";
                topBanner1.BannerTitle = "Lot Import";
            }
            topBanner1.RefreshLabels();
        }

        

    }
}
