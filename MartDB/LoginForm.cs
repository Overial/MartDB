using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MartDB
{
    public partial class LoginForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoginForm()
        {
            InitializeComponent();
        }

        // Moving login window with mouse
        private void menuStrip1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM Users " +
                "WHERE Username = '" + LoginBox.Text + "' AND " +
                "Password = '" + PasswordBox.Text + "'", sqlConnection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }

            sqlConnection.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных \"Тессеракт\"");
        }
    }
}
