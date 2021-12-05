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

namespace MartDB
{
    public partial class HandleEmployeeForm : Form
    {
        public HandleEmployeeForm()
        {
            InitializeComponent();
        }

        // Set organisation constraint
        private void HandleEmployeesForm_Load(object sender, EventArgs e)
        {
            if (UserData.UserRole == "organisation")
            {
                orgNameTextBox.Enabled = false;
                orgNameTextBox.Text = UserData.UserName;
                sqlCmdAddEmployee.Parameters["@org_name"].Value = UserData.UserName;
            }
        }

        // Add employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                if (UserData.UserRole == "admin")
                {
                    sqlCmdAddEmployee.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                }

                sqlCmdAddEmployee.Parameters["@fio"].Value = Convert.ToString(fioTextBox.Text);
                sqlCmdAddEmployee.Parameters["@gender"].Value = Convert.ToString(genderComboBox.Text);
                sqlCmdAddEmployee.Parameters["@position"].Value = Convert.ToString(positionTextBox.Text);
                sqlCmdAddEmployee.Parameters["@phone_number"].Value = Convert.ToString(phoneNumberTextBox.Text);
                sqlCmdAddEmployee.Parameters["@email"].Value = Convert.ToString(emailTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdAddEmployee.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Добавление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно добавлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Добавление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            sqlConnection.Close();
        }

        // Delete employee
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdDeleteEmployee.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                sqlCmdDeleteEmployee.Parameters["@fio"].Value = Convert.ToString(fioTextBox.Text);
                sqlCmdDeleteEmployee.Parameters["@gender"].Value = Convert.ToString(genderComboBox.Text);
                sqlCmdDeleteEmployee.Parameters["@position"].Value = Convert.ToString(positionTextBox.Text);
                sqlCmdDeleteEmployee.Parameters["@phone_number"].Value = Convert.ToString(phoneNumberTextBox.Text);
                sqlCmdDeleteEmployee.Parameters["@email"].Value = Convert.ToString(emailTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdDeleteEmployee.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            sqlConnection.Close();
        }
    }
}
