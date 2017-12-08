using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectUtilities
{
    public partial class frmChangeCustomer : DevExpress.XtraEditors.XtraForm
    {
        public int Customer_ID = -1;
        public frmChangeCustomer(string TRConnectionString)
        {
            InitializeComponent();
            sqlConnection1.ConnectionString = TRConnectionString;
            daCustomerLU.Fill(dsCustomerLU1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerLU_EditValueChanged(object sender, EventArgs e)
        {
            if (CustomerLU.EditValue != null)
            {
                Customer_ID = Convert.ToInt32(CustomerLU.EditValue);
                btnOK.Enabled = true;
            }
            else
            {
                Customer_ID = -1;
                btnOK.Enabled = false;
            }
        }
    }
}