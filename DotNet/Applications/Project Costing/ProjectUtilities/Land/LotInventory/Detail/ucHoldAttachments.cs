using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HMConnection;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProjectUtilities.Land.LotInventory.Detail
{
    public partial class ucHoldAttachments : DevExpress.XtraEditors.XtraUserControl
    {
        private HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private WS_Popups.frmPopup Popup;
        private int _HoldID = -1;
        private int _AgreementID = -1;
        private object _CLog_FieldLink_ID_Hold = -1;
        private object _CLog_FieldLink_ID_Agreement = -1;
        private bool _Readonly = false;

        public ucHoldAttachments(HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            this.Popup = new WS_Popups.frmPopup(DevXMgr);

            InitializeComponent();

            TR_Conn.ConnectionString = Connection.TRConnection;

            _CLog_FieldLink_ID_Hold = Connection.SQLExecutor.ExecuteScalar("exec dbo.sp_WS_ChatFieldLinkGetID 'PROJ_LOT_HOLD.HOLD_ID', 'HoldAttachments'", Connection.TRConnection);
            _CLog_FieldLink_ID_Agreement = Connection.SQLExecutor.ExecuteScalar("exec dbo.sp_WS_ChatFieldLinkGetID 'PROJ_LOT_AGREEMENT.AGREEMENT_ID', 'HoldAttachments'", Connection.TRConnection);
            daAttach.SelectCommand.CommandText = daAttach.SelectCommand.CommandText.Replace("web_strike_test", Connection.WebDB);
        }

        public bool Readonly
        {
            set
            {
                _Readonly = value;
                gcAttach.EmbeddedNavigator.Buttons.Append.Visible = !value;
                gcAttach.EmbeddedNavigator.Buttons.Remove.Visible = !value;
            }
        }

        public int HoldID
        {
            set
            {
                _HoldID = value;
                dsAttach.Clear();
                if (value == -1)
                {
                    gvAttach.OptionsBehavior.Editable = false;
                }
                else
                {
                    gvAttach.OptionsBehavior.Editable = true;
                    daAttach.SelectCommand.Parameters["@CLog_FieldLink_ID"].Value = _CLog_FieldLink_ID_Hold;
                    daAttach.SelectCommand.Parameters["@CLog_IDValue"].Value = value;
                    daAttach.Fill(dsAttach);
                }
            }
        }

        public int AgreementID
        {
            set
            {
                _AgreementID = value;
                dsAttach.Clear();
                if (value == -1)
                {
                    gvAttach.OptionsBehavior.Editable = false;
                }
                else
                {
                    gvAttach.OptionsBehavior.Editable = true;
                    daAttach.SelectCommand.Parameters["@CLog_FieldLink_ID"].Value = _CLog_FieldLink_ID_Agreement;
                    daAttach.SelectCommand.Parameters["@CLog_IDValue"].Value = value;
                    daAttach.Fill(dsAttach);
                }
            }
        }

        private void ucHoldAttachments_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private void riView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gvAttach.GetDataRow(gvAttach.FocusedRowHandle);
            if (dr != null)
            {
                object oID = dr["CAtch_ID"];
                if (oID != null && oID != DBNull.Value)
                {
                    GetFile(dr["CAtch_FileName"].ToString(), Convert.ToInt32(oID));
                }
            }
        }

        public void GetFile(string FileName, int ID)
        {
            FileStream fs = null;
            BinaryWriter bw = null;
            SqlDataReader sdr = null;
            SqlCommand cmd = new SqlCommand();
            string FileLocation = "";
            //The bytes returned from the GetBytes
            long blob;
            //Size of the BLOB Buffer
            int bufferSize = 255;
            //The BLOB byte[] buffer to be filled by GetBytes
            byte[] outBuffer = new byte[bufferSize];
            //The starting position of the BLOB output
            int startIndex;
            try
            {
                cmd.Connection = TR_Conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "WS_DL_File";
                cmd.CommandTimeout = 300;
                cmd.Parameters.AddWithValue("@CAtch_ID", ID);

                if (TR_Conn.State != ConnectionState.Open)
                    cmd.Connection.Open();

                sdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);

                while (sdr.Read())
                {
                    //Get saving location in the temporary folder
                    FileLocation = Path.GetTempPath() + FileName;
                    //Create a file to hold the output
                    fs = new FileStream(FileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    bw = new BinaryWriter(fs);
                    //Reset the starting index to new BLOB
                    startIndex = 0;
                    //Read byte into outBuffer[] and retained the number of bytes returned
                    blob = sdr.GetBytes(0, startIndex, outBuffer, 0, bufferSize);
                    //Continue while there are bytes beyond the size of the buffer
                    while (blob == bufferSize)
                    {
                        bw.Write(outBuffer);
                        bw.Flush();
                        //Reposition start index to the end of the last buffer and fill buffer
                        startIndex += bufferSize;
                        blob = sdr.GetBytes(0, startIndex, outBuffer, 0, bufferSize);
                    }
                    //Write the remaining buffer
                    bw.Write(outBuffer, 0, (int)blob - 1);
                    bw.Flush();
                    //Close output file
                    bw.Close();
                    fs.Close();
                }
                //Close reader and connection
                sdr.Close();
                Process.Start(FileLocation);
            }
            catch (Exception ex)
            {
                Popup.ShowPopup(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private void gcAttach_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Popup.ShowPopup("Are you sure you want to delete the selected attachement?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    string sSQL = @"delete from WS_ChatAttachment where CAtch_ID = "+gvAttach.GetFocusedRowCellValue("CAtch_ID");
                    Connection.SQLExecutor.ExecuteNonQuery(sSQL, Connection.TRConnection);
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    UploadFile(openFileDialog1.FileName, (new FileInfo(openFileDialog1.FileName)).Length );
                    HoldID = _HoldID;
                }
                e.Handled = true;
            }
        }

        private string FileType(string sFileName)
        {
            string FileType = "other";
            string sExtension = sFileName.Substring(sFileName.LastIndexOf(".") + 1);

            switch (sExtension)
            {
                case "pdf":
                    FileType = "application/pdf";
                    break;
                case "doc":
                    FileType = "application/msword";
                    break;
                case "docx":
                    FileType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "xls":
                    FileType = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    FileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "ppt":
                    FileType = "application/vnd.ms-powerpoint";
                    break;
                case "pptx":
                    FileType = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                    break;
                case "sxw":
                    FileType = "application/vnd.sun.xml.writer";
                    break;
                case "sxc":
                    FileType = "application/vnd.sun.xml.calc";
                    break;
                case "sxi":
                    FileType = "application/vnd.sun.xml.impress";
                    break;
                case "jpg":
                    FileType = "image/jpeg";
                    break;
                case "jpeg":
                    FileType = "image/jpeg";
                    break;
                case "png":
                    FileType = "image/png";
                    break;
                case "bmp":
                    FileType = "image/bmp";
                    break;
                case "tiff":
                    FileType = "image/tif";
                    break;
                case "tif":
                    FileType = "image/tif";
                    break;
                case "gif":
                    FileType = "image/gif";
                    break;
                case "txt":
                    FileType = "text/plain";
                    break;
                case "rtf":
                    FileType = "text/rtf";
                    break;
                case "zip":
                    FileType = "application/zip";
                    break;
                case "rar":
                    FileType = "application/zip";
                    break;  
            }

            return FileType;
        }

        private void UploadFile( string File, long FileSize )
        {
            this.Cursor = Cursors.WaitCursor;
            string sFileName = File.Substring(File.LastIndexOf(@"\") + 1).Replace("'", "''");
            if (System.IO.File.Exists(File))
            {                
                gcAttach.EmbeddedNavigator.Buttons.Append.Enabled = false;
                byte[] baFileInfo = null;

                try { baFileInfo = System.IO.File.ReadAllBytes(File); }
                catch { }

                if (baFileInfo != null)
                {
                    string sInsert = @"
                        insert into WS_ChatAttachment (CLog_FieldLink_ID, CLog_IDValue, CAtch_FileName, CAtch_Type, CAtch_Length, CAtch_UploadDtTm, 
                            CAtch_SessionDtTm, CAtch_Image, WebContact_ID, CAtch_Description)
                        select " + _CLog_FieldLink_ID_Hold + @", " + _HoldID + @", '" + sFileName + @"', '" + FileType(sFileName) + @"', " + FileSize + @", getdate(), 
                            getdate(), @FileData, " +Connection.ContactID+@", null";

                    using (System.Data.SqlClient.SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(Connection.TRConnection))
                    {
                        System.Data.SqlClient.SqlCommand sqlCmd = new System.Data.SqlClient.SqlCommand(sInsert, sqlCon);

                        try
                        {
                            sqlCmd.Parameters.Add("FileData", SqlDbType.VarBinary);
                            sqlCmd.Parameters["FileData"].Value = baFileInfo;
                            sqlCon.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlCon.Close();
                        }
                        catch
                        {
                            if (sqlCmd != null)
                                sqlCmd.Dispose();
                            if (sqlCon != null)
                                sqlCon.Dispose();
                        }
                    }
                }                
                gcAttach.EmbeddedNavigator.Buttons.Append.Enabled = true;
            }
            this.Cursor = Cursors.Default;
        }
    }
}
