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
    public partial class AddOrgForm : Form
    {
        public AddOrgForm()
        {
            InitializeComponent();
        }

        private void AddOrgForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            // Fill combo box with employees
            DataTable dtCP = new DataTable();
            string selectQueryCP = "SELECT fio FROM Employee ";
            SqlDataAdapter daCP = new SqlDataAdapter(selectQueryCP,
                                                     this.sqlConnection);
            daCP.Fill(dtCP);
            this.contactPersonComboBox.DataSource = dtCP;
            this.contactPersonComboBox.DisplayMember = "fio";
            this.contactPersonComboBox.ValueMember = "fio";

            sqlConnection.Close();
        }

        private void btnAddOrg_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdProcAddOrg.Parameters["@org_name"].Value = Convert.ToString(orgNameTextBox.Text);
                sqlCmdProcAddOrg.Parameters["@country"].Value = Convert.ToString(countryTextBox.Text);
                sqlCmdProcAddOrg.Parameters["@payment_terms"].Value = Convert.ToString(paymentTermsComboBox.Text);
                sqlCmdProcAddOrg.Parameters["@delivery_method"].Value = Convert.ToString(deliveryMethodComboBox.Text);
                sqlCmdProcAddOrg.Parameters["@contact_person"].Value = Convert.ToString(contactPersonComboBox.Text);
                sqlCmdProcAddOrg.Parameters["@userpassword"].Value = Convert.ToString(userpasswordTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdProcAddOrg.ExecuteNonQuery();

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
