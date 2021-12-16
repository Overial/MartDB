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
        private string _bookingId = "";
        private string _orgName = "";
        private string _areaId = "";
        private string _bookingStartDate = "";
        private string _bookingEndDate = "";

        public UpdateBookingForm(string bookingId, string orgName, string areaId, string bookingStartDate, string bookingEndDate)
        {
            InitializeComponent();

            this._bookingId = bookingId;
            this._orgName = orgName;
            this._areaId = areaId;
            this._bookingStartDate = bookingStartDate;
            this._bookingEndDate = bookingEndDate;
        }

        private void UpdateBookingForm_Load(object sender, EventArgs e)
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
            DataTable dtFreeAreaIds = new DataTable();
            string selectQuery = "SELECT Area.area_id FROM Area ";
            SqlDataAdapter daFreeAreaIds = new SqlDataAdapter(selectQuery,
                                                              this.sqlConnection);
            daFreeAreaIds.Fill(dtFreeAreaIds);
            this.areaIdComboBox.DataSource = dtFreeAreaIds;
            this.areaIdComboBox.DisplayMember = "area_id";
            this.areaIdComboBox.ValueMember = "area_id";

            this.dtpBookingStartDate.Text = this._bookingStartDate;
            if (UserData.UserRole == "admin")
            {
                this.orgNameComboBox.Enabled = true;
                this.areaIdComboBox.Enabled = true;
                this.dtpBookingStartDate.Enabled = true;
                this.bCostCheckBox.Enabled = true;
            }

            this.orgNameComboBox.Text = this._orgName;
            this.areaIdComboBox.Text = this._areaId.ToString();
            this.dtpBookingEndDate.Text = this._bookingEndDate;
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            // Open DB connection
            this.sqlConnection.Open();

            try
            {
                // Initialize params
                this.sqlCmdUpdateBooking.Parameters["@org_name"].Value = orgNameComboBox.Text.ToString();
                this.sqlCmdUpdateBooking.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
                this.sqlCmdUpdateBooking.Parameters["@booking_start_date"].Value = dtpBookingStartDate.Text;
                this.sqlCmdUpdateBooking.Parameters["@booking_end_date"].Value = dtpBookingEndDate.Text;

                DateTime.TryParse(this._bookingEndDate, out DateTime oldBookingEndDate);
                if (UserData.UserRole == "organisation" && dtpBookingEndDate.Value > oldBookingEndDate)
                {
                    MessageBox.Show("Невозможно продлить аренду! Обратитесь к администратору.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dtpBookingStartDate.Value <= dtpBookingEndDate.Value)
                    {
                        int iAffectedRowsCount2 = this.sqlCmdUpdateBooking.ExecuteNonQuery();

                        // Show corresponding information
                        if (iAffectedRowsCount2 == 0)
                        {
                            MessageBox.Show("Изменение данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (this.bCostCheckBox.Checked)
                            {
                                this.sqlCmdProcUpdateBookingCost.Parameters["@booking_id"].Value = Convert.ToInt32(this._bookingId);
                                int iAffectedRowsCount1 = this.sqlCmdProcUpdateBookingCost.ExecuteNonQuery();
                                if (iAffectedRowsCount1 == 0)
                                {
                                    MessageBox.Show("Обновление стоимости завершилось с ошибкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Стоимость успешно обновлена!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Close this form in case of success
                                    this.Close();
                                }
                            }

                            MessageBox.Show("Данные успешно изменены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Close this form in case of success
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введены некорректные значения периодов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "Error");

                MessageBox.Show("Изменение данных завершилось с ошибкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            this.sqlConnection.Close();
        }
    }
}
