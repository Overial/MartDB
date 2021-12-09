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
            this.sqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                this.sqlCmdAddBooking.Parameters["@org_name"].Value = orgNameComboBox.Text;
                this.sqlCmdAddBooking.Parameters["@area_id"].Value = areaIdComboBox.Text;
                this.sqlCmdAddBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                this.sqlCmdAddBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                // Call proc
                int iAffectedRowsCount = sqlCmdAddBooking.ExecuteNonQuery();

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
                MessageBox.Show("Введены некорректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Добавление данных завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            this.sqlConnection.Close();
        }
    }
}
