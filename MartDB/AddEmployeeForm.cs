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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        // Set organisation constraint
        private void HandleEmployeesForm_Load(object sender, EventArgs e)
        {
            // Fill combo box with org names from Organisation table
            DataTable dtOrgNames = new DataTable();
            SqlDataAdapter daOrgNames = new SqlDataAdapter("SELECT DISTINCT org_name FROM Organisation",
                                                           this.sqlConnection);
            daOrgNames.Fill(dtOrgNames);
            this.orgNameComboBox.DataSource = dtOrgNames;
            this.orgNameComboBox.DisplayMember = "org_name";
            this.orgNameComboBox.ValueMember = "org_name";

            // Add +7 to phone number text box
            this.phoneNumberTextBox.Text = "+7";

            if (UserData.UserRole == "organisation")
            {
                orgNameComboBox.Enabled = false;
                orgNameComboBox.Text = UserData.UserName;
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
                sqlCmdAddEmployee.Parameters["@org_name"].Value = Convert.ToString(orgNameComboBox.Text);
                sqlCmdAddEmployee.Parameters["@fio"].Value = Convert.ToString(fioTextBox.Text);
                sqlCmdAddEmployee.Parameters["@gender"].Value = Convert.ToString(genderComboBox.Text);
                sqlCmdAddEmployee.Parameters["@position"].Value = Convert.ToString(positionComboBox.Text);
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

                    // Close this form in case of success
                    this.Close();
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
    }
}
