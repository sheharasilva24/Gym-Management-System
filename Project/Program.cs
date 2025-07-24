using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignUp());
            SqlConnection con = new SqlConnection(@"DataSource = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\GymApplication.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmm;
            SqlDataReader mdr;

        }

    }
}
