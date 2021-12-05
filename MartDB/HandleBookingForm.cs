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
    public partial class HandleBookingForm : Form
    {
        public HandleBookingForm()
        {
            InitializeComponent();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            // Open DB connection
            mySqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdCreateBooking.Parameters["@org_id"].Value = Convert.ToInt32(orgIdTextBox.Text);
                sqlCmdCreateBooking.Parameters["@area_id"].Value = Convert.ToInt32(areaIdTextBox.Text);
                sqlCmdCreateBooking.Parameters["@cost"].Value = Convert.ToInt32(costTextBox.Text);
                sqlCmdCreateBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                sqlCmdCreateBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                // Call proc
                sqlCmdCreateBooking.ExecuteNonQuery();

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
            mySqlConnection.Close();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            // Open DB connection
            mySqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                sqlCmdDeleteBooking.Parameters["@org_id"].Value = orgIdTextBox.Text;
                sqlCmdDeleteBooking.Parameters["@area_id"].Value = areaIdTextBox.Text;
                sqlCmdDeleteBooking.Parameters["@cost"].Value = costTextBox.Text;
                sqlCmdDeleteBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                sqlCmdDeleteBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                // Call proc
                sqlCmdDeleteBooking.ExecuteNonQuery();

                // Show corresponding information
                MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Удаление данных завершилась с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            mySqlConnection.Close();
        }
    }
}
