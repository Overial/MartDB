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
    public partial class UpdateOutletForm : Form
    {
        private string _outletId = "";
        private string _orgName = "";
        private string _areaId = "";
        private string _outletName = "";
        private string _tradeProfileName = "";
        private string _timetable = "";
        private string _rating = "";
        private string _contact_person = "";

        public UpdateOutletForm(string outletId, string orgName, string areaId, string outletName,
                                string tradeProfileName, string timetable, string rating, string contact_person)
        {
            InitializeComponent();

            this._outletId = outletId;
            this._orgName = orgName;
            this._areaId = areaId;
            this._outletName = outletName;
            this._tradeProfileName = tradeProfileName;
            this._timetable = timetable;
            this._rating = rating;
            this._contact_person = contact_person;
        }

        private void HandleOutletForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            // Fill combo box with organisations from Organisation table
            DataTable dtOrgNames = new DataTable();
            string selectQueryOrgNames = "SELECT DISTINCT org_name FROM Organisation";
            SqlDataAdapter daOrgNames = new SqlDataAdapter(selectQueryOrgNames,
                                                           this.sqlConnection);
            daOrgNames.Fill(dtOrgNames);
            this.orgNameComboBox.DataSource = dtOrgNames;
            this.orgNameComboBox.DisplayMember = "org_name";
            this.orgNameComboBox.ValueMember = "org_name";

            // Constraint organisations
            if (UserData.UserRole == "organisation")
            {
                // Fill combo box with available area IDs with info from Area table
                DataTable dt = new DataTable();
                string selectQuery = "SELECT DISTINCT area_id FROM Booking " +
                                     "JOIN Organisation ON Booking.org_id = Organisation.org_id " +
                                     "WHERE Organisation.org_name = '" + UserData.UserName + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectQuery,
                                                       this.sqlConnection);
                da.Fill(dt);
                this.areaIdComboBox.DataSource = dt;
                this.areaIdComboBox.DisplayMember = "area_id";
                this.areaIdComboBox.ValueMember = "area_id";

                // Fill combo box with available area IDs with info from Area table
                DataTable dtCP = new DataTable();
                string selectQueryCP = "SELECT Employee.fio FROM Employee " +
                                       "JOIN Organisation ON Employee.org_id = Organisation.org_id " +
                                       "WHERE Organisation.org_name = '" + UserData.UserName + "'";
                SqlDataAdapter daCP = new SqlDataAdapter(selectQueryCP,
                                                         this.sqlConnection);
                daCP.Fill(dtCP);
                this.contactPersonComboBox.DataSource = dtCP;
                this.contactPersonComboBox.DisplayMember = "fio";
                this.contactPersonComboBox.ValueMember = "fio";

                // Org constraint
                this.orgNameComboBox.Enabled = false;
            }
            else if (UserData.UserRole == "admin")
            {
                // Fill combo box with area IDs with info from Area table
                DataTable dt = new DataTable();
                string selectQuery = "SELECT area_id FROM Area";
                SqlDataAdapter da = new SqlDataAdapter(selectQuery,
                                                       this.sqlConnection);
                da.Fill(dt);
                this.areaIdComboBox.DataSource = dt;
                this.areaIdComboBox.DisplayMember = "area_id";
                this.areaIdComboBox.ValueMember = "area_id";

                // Fill combo box with all employees
                DataTable dtCP = new DataTable();
                string selectQueryCP = "SELECT Employee.fio FROM Employee";
                SqlDataAdapter daCP = new SqlDataAdapter(selectQueryCP,
                                                         this.sqlConnection);
                daCP.Fill(dtCP);
                this.contactPersonComboBox.DataSource = dtCP;
                this.contactPersonComboBox.DisplayMember = "fio";
                this.contactPersonComboBox.ValueMember = "fio";
            }

            sqlConnection.Close();

            this.orgNameComboBox.Text = this._orgName;
            this.areaIdComboBox.Text = this._areaId;
            this.outletNameTextBox.Text = this._outletName;
            this.tradeProfileTextBox.Text = this._tradeProfileName;
            this.timetableTextBox.Text = this._timetable;
            this.ratingTextBox.Text = this._rating;
            this.contactPersonComboBox.Text = this._contact_person;

            // Orgs cannot change their ratings by themselves
            this.ratingTextBox.Enabled = false;
        }

        private void btnUpdateOutlet_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdProcUpdateOutlet.Parameters["@outlet_id"].Value = Convert.ToInt32(this._outletId);
                sqlCmdProcUpdateOutlet.Parameters["@org_name"].Value = Convert.ToString(orgNameComboBox.Text);
                sqlCmdProcUpdateOutlet.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
                sqlCmdProcUpdateOutlet.Parameters["@outlet_name"].Value = Convert.ToString(outletNameTextBox.Text);
                sqlCmdProcUpdateOutlet.Parameters["@trade_profile_name"].Value = Convert.ToString(tradeProfileTextBox.Text);
                sqlCmdProcUpdateOutlet.Parameters["@timetable"].Value = Convert.ToString(timetableTextBox.Text);
                sqlCmdProcUpdateOutlet.Parameters["@contact_person"].Value = Convert.ToString(contactPersonComboBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdProcUpdateOutlet.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Обновление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно обновлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Обновление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close DB connection
            sqlConnection.Close();
        }
    }
}


//// Open DB connection
//sqlConnection.Open();

//// Initialize params
//try
//{
//    if (UserData.UserRole == "admin")
//    {
//        sqlCmdDeleteOutlet.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
//    }

//    sqlCmdDeleteOutlet.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
//    sqlCmdDeleteOutlet.Parameters["@outlet_name"].Value = Convert.ToString(outletNameTextBox.Text);
//    sqlCmdDeleteOutlet.Parameters["@outlet_type"].Value = Convert.ToString(outletTypeTextBox.Text);
//    sqlCmdDeleteOutlet.Parameters["@timetable"].Value = Convert.ToString(timetableTextBox.Text);
//    sqlCmdDeleteOutlet.Parameters["@rating"].Value = ratingTextBox.Text;
//    sqlCmdDeleteOutlet.Parameters["@contact_person"].Value = Convert.ToString(contactPersonTextBox.Text);

//    // Call proc
//    int iAffectedRowsCount = sqlCmdDeleteOutlet.ExecuteNonQuery();

//    // Show corresponding information
//    if (iAffectedRowsCount == 0)
//    {
//        MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//    else
//    {
//        MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//}
//catch (FormatException)
//{
//    MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}
//catch (SqlException)
//{
//    MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}

//// Close DB connection
//sqlConnection.Close();