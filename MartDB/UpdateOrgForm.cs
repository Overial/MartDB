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
    public partial class UpdateOrgForm : Form
    {
        private string _orgId = "";
        private string _oldOrgName = "";
        private string _country = "";
        private string _paymentTerms = "";
        private string _deliveryMethod = "";
        private string _contactPerson = "";

        public UpdateOrgForm(string orgId, string oldOrgName, string country, string paymentTerms, string deliveryMethod, string contactPerson)
        {
            InitializeComponent();

            this._orgId = orgId;
            this._oldOrgName = oldOrgName;
            this._country = country;
            this._paymentTerms = paymentTerms;
            this._deliveryMethod = deliveryMethod;
            this._contactPerson = contactPerson;
        }

        private void UpdateOrgForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            // Fill combo box with employees
            DataTable dtCP = new DataTable();
            string selectQueryCP = "SELECT fio FROM Employee";
            SqlDataAdapter daCP = new SqlDataAdapter(selectQueryCP,
                                                     this.sqlConnection);
            daCP.Fill(dtCP);
            this.contactPersonComboBox.DataSource = dtCP;
            this.contactPersonComboBox.DisplayMember = "fio";
            this.contactPersonComboBox.ValueMember = "fio";

            sqlConnection.Close();

            this.orgNameTextBox.Text = this._oldOrgName;
            this.countryTextBox.Text = this._country;
            this.paymentTermsComboBox.Text = this._paymentTerms;
            this.deliveryMethodComboBox.Text = this._deliveryMethod;
            this.contactPersonComboBox.Text = this._contactPerson;
        }

        private void btnUpdateOrg_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdProcUpdateOrg.Parameters["@org_id"].Value = Convert.ToInt32(this._orgId);
                sqlCmdProcUpdateOrg.Parameters["@old_org_name"].Value = this._oldOrgName.ToString();
                sqlCmdProcUpdateOrg.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                sqlCmdProcUpdateOrg.Parameters["@country"].Value = Convert.ToString(countryTextBox.Text);
                sqlCmdProcUpdateOrg.Parameters["@payment_terms"].Value = Convert.ToString(paymentTermsComboBox.Text);
                sqlCmdProcUpdateOrg.Parameters["@delivery_method"].Value = Convert.ToString(deliveryMethodComboBox.Text);
                sqlCmdProcUpdateOrg.Parameters["@contact_person"].Value = Convert.ToString(contactPersonComboBox.Text);
                sqlCmdProcUpdateOrg.Parameters["@userpassword"].Value = Convert.ToString(userpasswordTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdProcUpdateOrg.ExecuteNonQuery();

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
            }

            // Close DB connection
            sqlConnection.Close();
        }
    }
}
