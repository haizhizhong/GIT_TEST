using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities.Land.LotInventory
{
    public partial class frmGradeSlip : DevExpress.XtraEditors.XtraForm
    {
        private HMConnection.HMCon Connection;
        private TUC_HMDevXManager.TUC_HMDevXManager DevXMgr;
        private int _iProj_Lot_ID = -1;

        public frmGradeSlip(HMConnection.HMCon Connection, TUC_HMDevXManager.TUC_HMDevXManager DevXMgr, int iPROJ_LOT_ID)
        {
            this.Connection = Connection;
            this.DevXMgr = DevXMgr;
            _iProj_Lot_ID = iPROJ_LOT_ID;
            InitializeComponent();
        }

        private void beFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                beFile.Text = openFileDialog1.FileName;
                btnUpload.Enabled = true;
            }            
        }

        private void frmGradeSlip_Load(object sender, EventArgs e)
        {
            DevXMgr.FormInit(this);
        }

        private string GetFileMimeType()
        {
            string sMIME = "";

            string sExtension = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(".")+1);
            switch (sExtension)
            {
                case "pdf":
                    sMIME = "application/pdf";
                    break;
                case "doc":
                    sMIME = "application/msword";
                    break;
                case "docx":
                    sMIME = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "xls":
                    sMIME = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    sMIME = "application/vnd.ms-excel";
                    break;
                case "png":
                    sMIME = "image/png";
                    break;
                case "jpg":
                    sMIME = "image/jpeg";
                    break;
                case "jpeg":
                    sMIME = "image/jpeg";
                    break;
                case "gif":
                    sMIME = "image/gif";
                    break;
                case "bmp":
                    sMIME = "image/bmp";
                    break;
            }

            return sMIME;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string sFileName = beFile.Text.Substring(beFile.Text.LastIndexOf(@"\")+1).Replace("'", "''");
            if (System.IO.File.Exists(beFile.Text))
            {
                btnUpload.Text = "Uploading...";
                btnUpload.Enabled = false;
                byte[] baFileInfo = null;

                try { baFileInfo = System.IO.File.ReadAllBytes(beFile.Text); }
                catch { }

                if (baFileInfo != null)
                {
                    string sInsert = @"
                        update proj_lot set 
                            Grade_Slip_Attached_TF = 'T',
                            Grade_Slip_File=@FileData,
                            Grade_Slip_File_Name='" + sFileName + @"',
                            Grade_Slip_Mime='"+GetFileMimeType()+@"'
                        where proj_lot_id="+_iProj_Lot_ID;

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
                btnUpload.Text = "Upload";
                btnUpload.Enabled = true;
            }
            this.Cursor = Cursors.Default;
            this.DialogResult = DialogResult.OK;
        }

    }
}