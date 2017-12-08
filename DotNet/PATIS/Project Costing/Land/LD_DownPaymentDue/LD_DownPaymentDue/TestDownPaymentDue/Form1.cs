using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace TestDownPaymentDue
{
    public partial class Form1 : Form
    {
        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevManager;
        

        public Form1()
        {
            InitializeComponent();
            LoadUserControls();
        }

        private void LoadUserControls()
        {
            hmDevManager = new TUC_HMDevXManager.TUC_HMDevXManager();
            hmDevManager.AppInit("ying");
           // hmConn = new HMConnection.HMCon("web_comco", "dev4", 12, "ying");
            hmConn = new HMConnection.HMCon("WEB_strike_test", "dev1", 12, "adam");
            //hmConn = new HMConnection.HMCon("web_QA_RE", "CSM-2005\\SQL2008", 12, "ying");
            LD_DownPaymentDue.ucDownPaymentDue DownPaymentDue = new LD_DownPaymentDue.ucDownPaymentDue(hmConn, hmDevManager);
            DownPaymentDue.Dock = DockStyle.Fill;
            DownPaymentDue.Parent = this;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = @"c:\temp\MyTest.txt";

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //Create the file.
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "This is some text");
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");
                AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

                for (int i = 1; i < 120; i++)
                {
                    AddText(fs, Convert.ToChar(i).ToString());

                }
            }

            //Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                    //MessageBox.Show(temp.GetString(b));
                }
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }


       
    }
}
