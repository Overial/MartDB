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
    public partial class AddOutletForm : Form
    {
        public AddOutletForm()
        {
            InitializeComponent();
        }

        private void AddOutletForm_Load(object sender, EventArgs e)
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

            // Fill combo box with trade profiles from TradeProfile table
            DataTable dtTP = new DataTable();
            string selectQueryTP = "SELECT trade_profile_name FROM TradeProfile";
            SqlDataAdapter daTP = new SqlDataAdapter(selectQueryTP,
                                                     this.sqlConnection);
            daTP.Fill(dtTP);
            this.tradeProfileComboBox.DataSource = dtTP;
            this.tradeProfileComboBox.DisplayMember = "trade_profile_name";
            this.tradeProfileComboBox.ValueMember = "trade_profile_name";

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
                this.orgNameComboBox.Text = UserData.UserName;
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
        }

        private void btnAddOutlet_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdProcAddOutlet.Parameters["@org_name"].Value = Convert.ToString(orgNameComboBox.Text);
                sqlCmdProcAddOutlet.Parameters["@area_id"].Value = Convert.ToInt32(areaIdComboBox.Text);
                sqlCmdProcAddOutlet.Parameters["@outlet_name"].Value = Convert.ToString(outletNameTextBox.Text);
                sqlCmdProcAddOutlet.Parameters["@trade_profile_name"].Value = Convert.ToString(tradeProfileComboBox.Text);
                sqlCmdProcAddOutlet.Parameters["@timetable"].Value = Convert.ToString(timetableTextBox.Text);
                sqlCmdProcAddOutlet.Parameters["@contact_person"].Value = Convert.ToString(contactPersonComboBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdProcAddOutlet.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Добавление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно добавлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
