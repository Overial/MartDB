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
    public partial class UpdateEmployeeForm : Form
    {
        private string _employeeId = "";
        private string _orgName = "";
        private string _fio = "";
        private string _gender = "";
        private string _position = "";
        private string _phoneNumber = "";
        private string _email = "";

        public UpdateEmployeeForm(string employeeId, string orgName, string fio, string gender, string position, string phoneNumber, string email)
        {
            InitializeComponent();

            this._employeeId = employeeId;
            this._orgName = orgName;
            this._fio = fio;
            this._gender = gender;
            this._position = position;
            this._phoneNumber = phoneNumber;
            this._email = email;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            // Fill combo box with org names from Organisation table
            DataTable dtOrgNames = new DataTable();
            SqlDataAdapter daOrgNames = new SqlDataAdapter("SELECT DISTINCT org_name FROM Organisation",
                                                           this.sqlConnection);
            daOrgNames.Fill(dtOrgNames);
            this.orgNameComboBox.DataSource = dtOrgNames;
            this.orgNameComboBox.DisplayMember = "org_name";
            this.orgNameComboBox.ValueMember = "org_name";

            this.orgNameComboBox.Text = this._orgName;
            this.fioTextBox.Text = this._fio;
            this.genderComboBox.Text = this._gender;
            this.positionComboBox.Text = this._position;
            this.phoneNumberTextBox.Text = this._phoneNumber;
            this.emailTextBox.Text = this._email;

            if (UserData.UserRole == "organisation")
            {
                orgNameComboBox.Enabled = false;
                orgNameComboBox.Text = UserData.UserName;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                this.sqlCmdUpdateEmployee.Parameters["@employee_id"].Value = this._employeeId;
                this.sqlCmdUpdateEmployee.Parameters["@org_name"].Value = this.orgNameComboBox.Text;
                this.sqlCmdUpdateEmployee.Parameters["@fio"].Value = this.fioTextBox.Text;
                this.sqlCmdUpdateEmployee.Parameters["@gender"].Value = this.genderComboBox.Text;
                this.sqlCmdUpdateEmployee.Parameters["@position"].Value = this.positionComboBox.Text;
                this.sqlCmdUpdateEmployee.Parameters["@phone_number"].Value = this.phoneNumberTextBox.Text;
                this.sqlCmdUpdateEmployee.Parameters["@email"].Value = this.emailTextBox.Text;

                // Call proc
                int iAffectedRowsCount = sqlCmdUpdateEmployee.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Изменение данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно изменены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Изменение данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            sqlConnection.Close();
        }
    }
}
