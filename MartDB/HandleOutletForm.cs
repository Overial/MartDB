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
    public partial class HandleOutletForm : Form
    {
        public HandleOutletForm()
        {
            InitializeComponent();
        }

        private void HandleOutletForm_Load(object sender, EventArgs e)
        {
            // Fill combo box with area IDs with info from Area table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT area_id FROM Area",
                                                    this.sqlConnection);
            da.Fill(dt);
            this.areaIdComboBox.DataSource = dt;
            this.areaIdComboBox.DisplayMember = "area_id";
            this.areaIdComboBox.ValueMember = "area_id";

            // Constraint organisations
            if (UserData.UserRole == "organisation")
            {
                orgNameTextBox.Enabled = false;
                orgNameTextBox.Text = UserData.UserName;
                sqlCmdAddOutlet.Parameters["@org_name"].Value = UserData.UserName;
            }
        }

        private void btnAddOutlet_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                if (UserData.UserRole == "admin")
                {
                    sqlCmdAddOutlet.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                }

                sqlCmdAddOutlet.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
                sqlCmdAddOutlet.Parameters["@outlet_name"].Value = Convert.ToString(outletNameTextBox.Text);
                sqlCmdAddOutlet.Parameters["@outlet_type"].Value = Convert.ToString(outletTypeTextBox.Text);
                sqlCmdAddOutlet.Parameters["@timetable"].Value = Convert.ToString(timetableTextBox.Text);
                sqlCmdAddOutlet.Parameters["@rating"].Value = ratingTextBox.Text;
                sqlCmdAddOutlet.Parameters["@contact_person"].Value = Convert.ToString(contactPersonTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdAddOutlet.ExecuteNonQuery();

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

        private void btnDeleteOutlet_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                if (UserData.UserRole == "admin")
                {
                    sqlCmdDeleteOutlet.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                }

                sqlCmdDeleteOutlet.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
                sqlCmdDeleteOutlet.Parameters["@outlet_name"].Value = Convert.ToString(outletNameTextBox.Text);
                sqlCmdDeleteOutlet.Parameters["@outlet_type"].Value = Convert.ToString(outletTypeTextBox.Text);
                sqlCmdDeleteOutlet.Parameters["@timetable"].Value = Convert.ToString(timetableTextBox.Text);
                sqlCmdDeleteOutlet.Parameters["@rating"].Value = ratingTextBox.Text;
                sqlCmdDeleteOutlet.Parameters["@contact_person"].Value = Convert.ToString(contactPersonTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdDeleteOutlet.ExecuteNonQuery();

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
