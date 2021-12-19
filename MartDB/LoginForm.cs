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
        // Constraint login attempts count
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserData.IsCurrentUserAuthenticated = false;
            this.roleComboBox.Text = "Посетитель";
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
            bool successfulLoginFlag = false;

            // Variables to store user input (login and password)
            string login = "";
            string password = "";
            string role = "";

            try
            {
                login = Convert.ToString(loginTextBox.Text);
                password = Convert.ToString(passwordTextBox.Text);
                role = Convert.ToString(roleComboBox.Text);
            }
            catch
            {
                MessageBox.Show("Введена некорректная роль пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            switch (role)
            {
                case "Администратор":
                    role = "admin";
                    successfulLoginFlag = true;
                    break;
                case "Организация":
                    role = "organisation";
                    successfulLoginFlag = true;
                    break;
                case "Посетитель":
                    role = "customer";
                    successfulLoginFlag = true;
                    break;
                default:
                    MessageBox.Show("Введена некорректная роль пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Set global user UserName
            UserData.UserName = login;
            // Set global user UserRole
            UserData.UserRole = role;

            // Initialize SQL connection to database
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Get user from Users table
            SqlCommand sqlCommand = new SqlCommand("SELECT UserName, UserPassword, UserRole FROM Users " +
                                                   "WHERE UserName = '" + login + "' AND " +
                                                   "UserPassword = '" + password + "' AND " +
                                                   "UserRole = '" + role + "'",
                                                   sqlConnection);

            //SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //int id = 0;
            //sqlCommand.Parameters.Add("Id", SqlDbType.Int).Value = id;

            if (successfulLoginFlag)
            {
                // Using SqlDataReader for opening proper form
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    // If found matches
                    if (reader.Read())
                    {
                        RegisterForm registerForm = new RegisterForm();
                        registerForm.Close();

                        // Open form for admin
                        if (role == "admin" || role == "organisation")
                        {
                            this.Visible = false;
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        // Open form for customer
                        else if (role == "customer")
                        {
                            UserData.IsCurrentUserAuthenticated = true;

                            this.Visible = false;
                            CustomerForm userForm = new CustomerForm();
                            userForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else if (loginTextBox.Text.Length > 0 || passwordTextBox.Text.Length > 0)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Register form
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnEnterGuest_Click(object sender, EventArgs e)
        {
            // Generate random username
            Random random = new Random();
            int randomNumber = random.Next(0, 100000);
            UserData.UserName = "guest" + randomNumber;

            // Set guest role as customer
            UserData.UserRole = "customer";

            // Open form for customer
            this.Visible = false;
            CustomerForm userForm = new CustomerForm();
            userForm.ShowDialog();
            this.Close();
        }
    }
}
