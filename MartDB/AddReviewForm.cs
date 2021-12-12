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
    public partial class AddReviewForm : Form
    {
        private string _outletName = "";

        public AddReviewForm(string outletName)
        {
            InitializeComponent();

            this._outletName = outletName;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            // Fill combo box with org names from Area table
            DataTable dtOrgNames = new DataTable();
            SqlDataAdapter daOrgNames = new SqlDataAdapter("SELECT outlet_name FROM Outlet",
                                                           this.sqlConnection);
            daOrgNames.Fill(dtOrgNames);
            this.outletNameComboBox.DataSource = dtOrgNames;
            this.outletNameComboBox.DisplayMember = "outlet_name";
            this.outletNameComboBox.ValueMember = "outlet_name";

            // Set chosen outlet name
            this.outletNameComboBox.Text = this._outletName;
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            // Open DB connection
            this.sqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                this.sqlCmdAddReview.Parameters["@username"].Value = UserData.UserName;
                this.sqlCmdAddReview.Parameters["@outlet_name"].Value = this.outletNameComboBox.Text;
                this.sqlCmdAddReview.Parameters["@rating"].Value = this.ratingComboBox.Text;
                this.sqlCmdAddReview.Parameters["@review_content"].Value = this.reviewContentTextBox.Text;
                
                // Call proc
                int iAffectedRowsCount = this.sqlCmdAddReview.ExecuteNonQuery();

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
                MessageBox.Show("Вы уже оставляли отзыв для данной торговой точки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            this.sqlConnection.Close();
        }
    }
}
