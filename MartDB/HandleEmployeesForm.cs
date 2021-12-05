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
    public partial class HandleEmployeesForm : Form
    {
        public HandleEmployeesForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdAddEmployee.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                sqlCmdAddEmployee.Parameters["@fio"].Value = Convert.ToString(fioTextBox.Text);
                sqlCmdAddEmployee.Parameters["@gender"].Value = Convert.ToString(genderComboBox.Text);
                sqlCmdAddEmployee.Parameters["@position"].Value = Convert.ToString(positionTextBox.Text);
                sqlCmdAddEmployee.Parameters["@phone_number"].Value = Convert.ToString(phoneNumberTextBox.Text);
                sqlCmdAddEmployee.Parameters["@email"].Value = Convert.ToString(emailTextBox.Text);

                // Call proc
                sqlCmdAddEmployee.ExecuteNonQuery();

                // Show corresponding information
                MessageBox.Show("Данные успешно сохранены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
