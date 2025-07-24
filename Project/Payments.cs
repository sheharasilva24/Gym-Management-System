using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class pnlPayments : Form
    {
        public pnlPayments()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int memberName = int.Parse(txtName.Text);
            string PayMethodList=string.Empty;
            string paymentMethod = radioCash.Checked ? "Cash" : "Credit/Debit";
            DateTime selectedDateTime = dateTimePicker1.Value;

            
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblDateofJoin_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
