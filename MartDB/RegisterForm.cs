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
using System.Runtime.InteropServices;

namespace MartDB
{
    public partial class RegisterForm : Form
    {
        // For moving form with mouse functionality
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public RegisterForm()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int flag = 0;
            bool successfulRegisterFlag = false;

            // Set initial values
            mySqlCommand.Parameters["@username"].Value = usernameTextBox.Text;
            mySqlCommand.Parameters["@password"].Value = passwordTextBox.Text;

            // Parse UserRole
            string role = roleComboBox.Text;
            switch (role)
            {
                case "Администратор":
                    role = "admin";
                    successfulRegisterFlag = true;
                    break;
                case "Организация":
                    role = "organisation";
                    successfulRegisterFlag = true;
                    break;
                case "Посетитель":
                    role = "customer";
                    successfulRegisterFlag = true;
                    break;
                default:
                    MessageBox.Show("Введена некорректная роль пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            mySqlCommand.Parameters["@UserRole"].Value = role;

            mySqlCommand.Parameters["@flag"].Value = flag;

            if (successfulRegisterFlag)
            {
                // Open DB connection
                mySqlConnection.Open();

                // Call proc
                mySqlCommand.ExecuteNonQuery();

                // Close DB connection
                mySqlConnection.Close();

                // Get flag of registration status
                flag = Convert.ToInt32(mySqlCommand.Parameters["@flag"].Value);

                // Show corresponding message
                if (flag == 0)
                {
                    MessageBox.Show("Регистрация проведена успешно!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }
    }
}
