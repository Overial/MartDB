using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartDB
{
    public partial class HandleBookingForm : Form
    {
        public HandleBookingForm()
        {
            InitializeComponent();
        }

        private void btnHandleBooking_Click(object sender, EventArgs e)
        {
            // Initialize params
            mySqlCommand.Parameters["@booking_id"].Value = bookingIdTextBox.Text;
            mySqlCommand.Parameters["@area_id"].Value = areaIdTextBox.Text;
            mySqlCommand.Parameters["@cost"].Value = costTextBox.Text;
            mySqlCommand.Parameters["@booking_start_date"].Value = bookingStartDateTextBox.Text;
            mySqlCommand.Parameters["@booking_end_date"].Value = bookingEndDateTextBox.Text;

            // Open DB connection
            mySqlConnection.Open();

            // Implement exception handling

            // Call proc
            mySqlCommand.ExecuteNonQuery();

            // Show corresponding information
            MessageBox.Show("Данные успешно сохранены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close DB connection
            mySqlConnection.Close();
        }
    }
}
