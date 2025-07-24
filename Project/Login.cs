using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#Final.mdf;Integrated Security=True;Connect Timeout=30");

        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            UI objUi = new UI();
            this.Hide();
            objUi.Show();

            String username, password;

            username = txtUname.Text;
            password =txtPw.Text;

            try
            {
                String qry = "SELECT FROM SignUp WHERE Usename = '" + txtUname.Text + "' AND Password = '" + txtPw.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(qry,conn);

                DataTable dTable= new DataTable();
                adapter.Fill(dTable);

                if(dTable.Rows.Count > 0 ) 
                {
                    username = txtUname.Text;
                    password = txtPw.Text;

                    Dashboard objDash = new Dashboard();    
                    objDash.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUname.Clear();
                    txtPw.Clear();  
                
                }

            }

            catch (Exception ex) 
            {

            }

            finally 
            {
                conn.Close(); 
            }

        }
    }
}
