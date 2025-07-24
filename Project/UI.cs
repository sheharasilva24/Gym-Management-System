using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project
{
    public partial class UI : Form
    {

        [DllImport("Gdi32.dll", EntryPoint="CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
int nleftRect,

int nTopRect,

int nRightRect,

int nBottonRect,

int nWidthEllipse,

int nHeightEllips );

        public UI()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height= btnDashboard.Height; 
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left= PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Dashboard objDash = new Dashboard();
            objDash.TopLevel = false;
            panel2.Controls.Add(objDash);
            objDash.BringToFront();
            objDash.Show();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnMembership.Height; 
            PnlNav.Top = btnMembership.Top;
            btnMembership.BackColor = Color.FromArgb(46, 51, 73);
            pnlMembers objMem = new pnlMembers();
            objMem.TopLevel= false;
            panel2.Controls.Add(objMem);
            objMem.BringToFront();
            objMem.Show();

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnPayments.Height;
            PnlNav.Top = btnPayments.Top;
            btnPayments.BackColor = Color.FromArgb(46, 51, 73);
            pnlPayments objPay = new pnlPayments();
            objPay.TopLevel = false;
            panel2.Controls.Add(objPay);
            objPay.BringToFront();
            objPay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnTrainers.Height;
            PnlNav.Top = btnTrainers.Top;
            btnTrainers.BackColor = Color.FromArgb(46, 51, 73);
            Trainers objTr = new Trainers();
            objTr.TopLevel = false;
            panel2.Controls.Add(objTr);
            objTr.BringToFront();
            objTr.Show();
        }
       private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnEquipments.Height;
            PnlNav.Top = btnEquipments.Top;
            btnEquipments.BackColor = Color.FromArgb(46, 51, 73);
            Equipments objEq = new Equipments();
            objEq.TopLevel = false;
            panel2.Controls.Add(objEq);
            objEq.BringToFront();
            objEq.Show();
        }

 
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMembership_Leave(object sender, EventArgs e)
        {
            btnMembership.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPayments_Leave(object sender, EventArgs e)
        {
            btnPayments.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAttendance_Leave(object sender, EventArgs e)
        {
            btnTrainers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnEquipments.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            pnlMembers objMem = new pnlMembers();
            objMem.TopLevel = false;
            panel2.Controls.Add(objMem);
            objMem.BringToFront();
            objMem.Show();
        }
    }
}
