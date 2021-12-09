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
    public partial class UpdateBookingForm : Form
    {
        private string _orgName = "";
        private string _areaId = "";
        private string _bookingStartDate = "";
        private string _bookingEndDate = "";

        public UpdateBookingForm(string orgName, string areaId, string bookingStartDate, string bookingEndDate)
        {
            InitializeComponent();

            this._orgName = orgName;
            this._areaId = areaId;
            this._bookingStartDate = bookingStartDate;
            this._bookingEndDate = bookingEndDate;
        }

        private void UpdateBookingForm_Load(object sender, EventArgs e)
        {
            this.orgNameComboBox.Text = this._orgName;
            this.areaIdComboBox.Text = this._areaId;
            this.dtpBookingStartDate.Text = this._bookingStartDate;
            this.dtpBookingEndDate.Text = this._bookingEndDate;
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            // Open DB connection
            this.sqlConnection.Open();

            try
            {
                // Initialize params
                this.sqlCmdUpdateBooking.Parameters["@org_name"].Value = orgNameComboBox.Text;
                this.sqlCmdUpdateBooking.Parameters["@area_id"].Value = areaIdComboBox.Text;
                this.sqlCmdUpdateBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                this.sqlCmdUpdateBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                // Call proc
                int iAffectedRowsCount = this.sqlCmdUpdateBooking.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Изменение данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно изменены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                //StringBuilder errorMessages = new StringBuilder();
                //for (int i = 0; i < ex.Errors.Count; i++)
                //{
                //    errorMessages.Append("Index #" + i + "\n" +
                //        "Message: " + ex.Errors[i].Message + "\n" +
                //        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                //        "Source: " + ex.Errors[i].Source + "\n" +
                //        "Procedure: " + ex.Errors[i].Procedure + "\n");
                //}
                //MessageBox.Show(errorMessages.ToString(), "Error");
                
                MessageBox.Show("Изменение данных завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            this.sqlConnection.Close();
        }
    }
}
