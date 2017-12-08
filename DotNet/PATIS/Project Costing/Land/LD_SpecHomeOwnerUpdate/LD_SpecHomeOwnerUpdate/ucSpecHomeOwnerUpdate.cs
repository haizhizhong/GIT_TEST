using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WS_Popups;
using System.Data.SqlClient;
using System.IO;


namespace LD_SpecHomeOwnerUpdate
{
    public partial class ucSpecHomeOwnerUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        #region Local Variables

        private WS_Popups.frmPopup frmMessageBox;
        private LD_LotSearch.ucLotSearch lotSearch;
        private ucSummary specHomeOwnerUpdateSummary;

        private string sType = "SpecHomeOwnerUpdateReminder";

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


        public ucSpecHomeOwnerUpdate(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle)
        {
            InitializeComponent();
            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            LoadUserControls();
        }
        private void LoadUserControls()
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);
            
            lotSearch = new LD_LotSearch.ucLotSearch(ReflexCon, dxStyle, LD_LotSearch.LotSearchType.SpecHomeOwnerUpdateReminder);
            lotSearch.Dock = DockStyle.Fill;
            lotSearch.Parent = pcLotSelection;
            lotSearch.BringToFront();
            lotSearch.RefreshMe();

            specHomeOwnerUpdateSummary = new ucSummary(ReflexCon, dxStyle);
            specHomeOwnerUpdateSummary.Dock = DockStyle.Fill;
            specHomeOwnerUpdateSummary.Parent = tpSummary;
            specHomeOwnerUpdateSummary.BringToFront();
            specHomeOwnerUpdateSummary.specHomeOwnerUpdateMain = this;
        }

        private void SetupButtons()
        {
            btnCancel.Enabled = true;
            btnFinish.SendToBack();

            btnNext.Enabled = (tcMain.SelectedTabPageIndex < tcMain.TabPages.Count - 1);
            btnBack.Enabled = (tcMain.SelectedTabPageIndex > 0);

            if (tcMain.SelectedTabPage == tpSummary)
            {
                if (specHomeOwnerUpdateSummary != null)
                {
                    btnFinish.BringToFront();
                    specHomeOwnerUpdateSummary.SetupPrintButtons();
                }
            }
            
        }
        private void SetTabPageNext()
        {
            try
            {
                string msg = VerifySelection();
                if (msg != "")
                {
                    frmMessageBox.ShowPopup(this, msg);
                    return;
                }
                else
                {
                    this.tcMain.SelectedTabPageIndex++;
                    //if (tcMain.SelectedTabPage == tpSummary)
                    //{
                    //    if (specHomeOwnerUpdateSummary != null)
                    //        specHomeOwnerUpdateSummary.LoadSummary(sType);
                    //}

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found in SetTabPageNext process in ucSpecHomeOwnerUpdate: " + ex.StackTrace.ToString());
            }
        }

        private string VerifySelection()
        {
            string msg = "";
            if (tcMain.SelectedTabPage == tpLotSelection)
            {
                string sqlstr = " select COUNT(*) from working_ld_LotSearch where username = "
                     + "'" + ReflexCon.MLUser + sType + "'"
                      + " and isnull(agreement_id,0) <> 0 and selected =1";
                int count = Convert.ToInt32(ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection));
                if (count == 0)
                    msg = "You need to select at least one agreement to continue.";
                else
                {
                    if (specHomeOwnerUpdateSummary != null)
                    {
                        specHomeOwnerUpdateSummary.LoadSummary(sType);
                        msg = specHomeOwnerUpdateSummary.VerifySelection();
                    }
                }

            }
           
            return msg;
        }
        private void SetupControls()
        {
            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            tcMain.SelectedTabPage = tpWelcome;

            // WelcomeScreen

            welcomeScreen.Title = "Spec Home Owner Update Reminder Assistant";
            welcomeScreen.Description = "Use this assistant to help you in sending out Spec Home Owner Update reminders.";
            welcomeScreen.RefreshLabels();

            // Lot Selection
            topBanner_LotSelection.BannerTitle = "Lot / Agreement Selection";
            topBanner_LotSelection.BannerText = "Select the lot / agreement(s) you want to include in the reminders.";
            topBanner_LotSelection.RefreshLabels();
                       
            // Summary
            topBanner_Summary.BannerTitle = "Summary";
            topBanner_Summary.BannerText = "Review the selected lot / agreements and click finish to send reminders.";
            topBanner_Summary.RefreshLabels();

        }

        private void ucSpecHomeOwnerUpdate_Load(object sender, EventArgs e)
        {
            SetupControls();
            SetupButtons();
            dxStyle.FormInit(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetTabPageNext();
            SetupButtons();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetTabPageBack();
            SetupButtons();
        }
        private void SetTabPageBack()
        {
            this.tcMain.SelectedTabPageIndex--;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmMessageBox.ShowPopup(this, "Cancel Process Assistant?", frmPopup.PopupType.OK_Cancel) == frmPopup.PopupResult.OK)
            {
                ResetPati();
            }
        }


        private void ResetPati()
        {
            btnFinish.Text = "Finish";
            tcMain.SelectedTabPageIndex = 0;
            lotSearch.RefreshMe();
            SetupButtons();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (this.btnFinish.Text == "Finish")
            {
                string msg = specHomeOwnerUpdateSummary.VerifySelection();
                if (msg != "")
                {
                    frmMessageBox.ShowPopup(msg);
                    return;
                }
                if (frmMessageBox.ShowPopup("Are you sure you want to continue? ", frmPopup.PopupType.OK_Cancel)
                        == frmPopup.PopupResult.OK)
                {
                    string PDFPath = "";
                    string sqlStr = "select PDF_Attachment_Path from WS_Setup";
                    object obj = ReflexCon.SQLExecutor.ExecuteScalar(sqlStr, ReflexCon.TRConnection);
                    if (obj != null && obj != DBNull.Value)
                    {
                        if (obj.ToString() != "")
                            PDFPath = obj.ToString();
                    }
                    if (PDFPath == "")
                    {
                        frmMessageBox.ShowPopup("PDF Attachment is not setup cannot continue.");
                        return;
                    }
                    CL_Dialog.PleaseWait.Show("Creating PDF...", null);
                    SpecHomeOwnerUpdate(PDFPath);
                    CL_Dialog.PleaseWait.Hide();
                    btnBack.Enabled = false;
                    btnFinish.Text = "Restart";
                    specHomeOwnerUpdateSummary.btnPrintRegister.Enabled = true;
                }
            }
            else
            {
                ResetPati();
            }
        }

        private void SpecHomeOwnerUpdate(string PDFPath)
        {
            string sql = "exec WS_SpecHomeOwnerUpdate '" +ReflexCon.MLUser + "'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sql, ReflexCon.TRConnection);
            CreatePDFFile(PDFPath, "WS_SpecHomeOwnerUpdateX.rpt", "Spec Home Owner Update Lot List");
        }
        private byte[] FileToByteArray(string _FileName)
        {
            byte[] _Buffer = null;
            try
            {
                System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.BinaryReader _BinaryReader = new System.IO.BinaryReader(_FileStream);
                long _TotalBytes = new System.IO.FileInfo(_FileName).Length;
                _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);
                _FileStream.Close();
                _FileStream.Dispose();
                _BinaryReader.Close();
            }
            catch (Exception ex)
            {
                frmMessageBox.ShowPopup("Exception caught in process: " + ex.Message.ToString());
            }
            return _Buffer;
        }

        private void CreatePDFFile(string PDFPath, string rptName, string attchName)
        {
            int taskID = 0;
            SqlDataReader dataReader;
            SqlCommand cmd = new SqlCommand();
            SqlConnection sConn = new SqlConnection();
            sConn.ConnectionString = ReflexCon.TRConnection;
            cmd.Connection = sConn;
            sConn.Open();

            string sUserName = ReflexCon.MLUser + sType;
            cmd.CommandText = "select WS_ST_ID, Purchaser_Code, Purchaser_Name, Proj_Code, Proj_Name from Working_Task_Hdr where username =  '" + sUserName + "'";
            dataReader = cmd.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    taskID = Convert.ToInt32(dataReader["WS_ST_ID"]);
                    string[,] saParams = new string[2, 2];
                    saParams[0, 0] = "@taskID";
                    saParams[1, 0] = taskID.ToString();
                    saParams[0, 1] = "@username";
                    saParams[1, 1] = ReflexCon.MLUser;

                    string filePath = ReflexCon.ReportPath + "\\" + rptName;
                    string sAttchName = attchName + " - " + dataReader["Purchaser_Code"] + " - " + dataReader["Proj_Code"] + ".pdf";
                    string attchPath = PDFPath + "\\";
                    string despath = attchPath + sAttchName;

                    HMBaseReporting.HMReport hmReport = new HMBaseReporting.HMReport(filePath, ReflexCon.CompanyServer, ReflexCon.TRDB, saParams);
                    hmReport.ExportReportToPDF(despath);


                    long fileLength = new System.IO.FileInfo(despath).Length;

                    System.Data.SqlClient.SqlConnection _SqlConnection = new SqlConnection();
                    _SqlConnection.ConnectionString = ReflexCon.TRConnection;
                    try
                    {
                        _SqlConnection.Open();
                        //  sqlStr = "insert into WS_SUB_TASK_DET_ATTACH (WS_ST_ID, ATTACHMENT_NAME, ATTACHMENT ) VALUES (" + taskID.ToString() + ",'" + attchName + "'," + "@attach)";
                        string sqlStr = @"DECLARE @FieldLink_ID int

                    DECLARE @TmpFieldLink TABLE(FieldLinkID int)
                    INSERT @TmpFieldLink EXEC sp_WS_ChatFieldLinkGetID 'WS_SUB_TASK_HDR.WS_ST_ID', 'Tasks'

                    SELECT @FieldLink_ID=FieldLinkID FROM @TmpFieldLink

                    insert into WS_ChatAttachment (CLog_FieldLink_ID, CLog_IDValue, CAtch_FileName, CAtch_Type, CAtch_Length, CAtch_UploadDtTm, Catch_SessionDtTm, CAtch_Image, WebContact_ID)
                    select @FieldLink_ID, " + taskID + ", '" + sAttchName + "', 'application/pdf', " + fileLength + ", getdate(), getdate(), @attach, " + ReflexCon.ContactID;

                        System.Data.SqlClient.SqlCommand _SqlCommand = new SqlCommand(sqlStr, _SqlConnection);
                        SqlParameter _SqlParameter = new SqlParameter("@attach", SqlDbType.VarBinary);
                        _SqlParameter.Value = FileToByteArray(despath);
                        _SqlCommand.Parameters.Add(_SqlParameter);
                        _SqlCommand.ExecuteNonQuery();
                        _SqlCommand.Dispose();
                        _SqlCommand = null;


                    }
                    catch (Exception ex)
                    {
                        frmMessageBox.ShowPopup("Exception caught in inserting process: " + ex.Message.ToString());
                    }
                    _SqlConnection.Close();
                    try
                    {
                        File.Delete(despath);
                    }
                    catch { };

                }
                dataReader.Close();
                sConn.Close();

            }

            catch (Exception ex)
            {
                frmMessageBox.ShowPopup("Exception caught in CreatePDFFile process: " + ex.Message);
            }

        }
        
        //
    }
}
