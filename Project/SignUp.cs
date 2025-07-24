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
using System.Data.SqlClient;


namespace Project
{
    public partial class SignUp : Form
    {
        
        
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SignPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Login objLog = new Login();
            this.Hide();
            objLog.Show();
            
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#Final.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "INSERT INTO SignUp(Name,Birthday,Contact Info,E-mail,User Name,Password) values('" + txtName + "','" + txtDate + "','" + txtContact + "','" + txtEmail + "','" + txtUsername + "','" + txtPassword + "')";
            SqlCommand cmm = new SqlCommand(qry, con);
            try 
            {
                con.Open();
                cmm.ExecuteNonQuery();
                MessageBox.Show("Account Created");
                
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login objLog= new Login();
            this.Hide();
            objLog.Show();
        }

        private void SignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
