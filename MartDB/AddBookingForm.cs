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
    public partial class AddBookingForm : Form
    {
        public AddBookingForm()
        {
            InitializeComponent();
        }

        private void HandleBookingForm_Load(object sender, EventArgs e)
        {
            // Fill combo box with org names from Area table
            DataTable dtOrgNames = new DataTable();
            SqlDataAdapter daOrgNames = new SqlDataAdapter("SELECT org_name FROM Organisation",
                                                    this.sqlConnection);
            daOrgNames.Fill(dtOrgNames);
            this.orgNameComboBox.DataSource = dtOrgNames;
            this.orgNameComboBox.DisplayMember = "org_name";
            this.orgNameComboBox.ValueMember = "org_name";

            // Fill combo box with area ids from Area table
            DataTable dtAreaIds = new DataTable();
            SqlDataAdapter daAreaIds = new SqlDataAdapter("SELECT area_id FROM Area",
                                                    this.sqlConnection);
            daAreaIds.Fill(dtAreaIds);
            this.areaIdComboBox.DataSource = dtAreaIds;
            this.areaIdComboBox.DisplayMember = "area_id";
            this.areaIdComboBox.ValueMember = "area_id";
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                sqlCmdAddBooking.Parameters["@org_name"].Value = orgNameComboBox.Text;
                sqlCmdAddBooking.Parameters["@area_id"].Value = areaIdComboBox.Text;
                sqlCmdAddBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                sqlCmdAddBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                // Call proc
                sqlCmdAddBooking.ExecuteNonQuery();

                // Show corresponding information
                MessageBox.Show("Данные успешно добавлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close this form in case of success
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Добавление данных завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            sqlConnection.Close();
        }
    }
}
