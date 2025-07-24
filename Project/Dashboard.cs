using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            UI objnw= new UI();
            pnlMembers objNew = new pnlMembers();
            objNew.TopLevel = false;
            
            objNew.BringToFront();
            objNew.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }
    }
}
