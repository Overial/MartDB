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
        int iLoginAttemptsCounter = 3;

        // For moving form with mouse functionality
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoginForm()
        {
            InitializeComponent();

            // Set start position to center
            this.StartPosition = FormStartPosition.CenterScreen;
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
            // Variables to store user input (login and password)
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            // Initialize SQL connection to database
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Get user from Users table
            SqlCommand sqlCommand = new SqlCommand("SELECT Username, Password, Role FROM Users " +
                                            "WHERE Username = '" + LoginBox.Text + "' AND " +
                                            "Password = '" + PasswordBox.Text + "'",
                                            sqlConnection);

            //SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //int id = 0;
            //sqlCommand.Parameters.Add("Id", SqlDbType.Int).Value = id;

            // Using SqlDataReader for opening proper form
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // If found matches
                if (reader.Read())
                {
                    string role = reader.GetString(2);

                    // Open form for admin
                    if (role == "admin")
                    {
                        this.Visible = false;
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    // Open form for customer
                    else if (role == "customer")
                    {
                        this.Visible = false;
                        UserForm userForm = new UserForm();
                        userForm.ShowDialog();
                        this.Close();
                    }
                }
                else if (LoginBox.Text.Length > 0 || PasswordBox.Text.Length > 0)
                {
                    // MessageBox.Show("Invalid login or password");

                    // Decrement failed login attempts counter
                    --this.iLoginAttemptsCounter;

                    // Show user data with remaining login attempts
                    if (this.iLoginAttemptsCounter > 0)
                    {
                        this.loginAttemptsCountLabel.Text = "Попыток авторизации осталось: " + this.iLoginAttemptsCounter;
                    }
                    else
                    {
                        this.loginAttemptsCountLabel.Text = "Попыток авторизации осталось: 0";
                    }

                    // Check for user surpassing login attempts max count
                    if (this.iLoginAttemptsCounter < 0)
                    {
                        MessageBox.Show("Вы превысили максимальное количество попыток авторизации. Попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                    else
                    {
                        // Display corresponding info
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // It's obligatory to close reader
                reader.Close();
            }

            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Login Successful!");
            //    this.Close();

            //    Close login form and open admin form
            //    this.Visible = false;
            //    MainForm mainForm = new MainForm();
            //    mainForm.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid login or password");
            //}

            // Close SQL connection
            sqlConnection.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
