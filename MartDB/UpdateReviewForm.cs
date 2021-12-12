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
    public partial class UpdateReviewForm : Form
    {
        private int _reviewId = 0;
        private string _outletName = "";

        public UpdateReviewForm(int reviewId, string outletName)
        {
            InitializeComponent();

            this._reviewId = reviewId;
            this._outletName = outletName;
        }

        private void UpdateReviewForm_Load(object sender, EventArgs e)
        {
            this.usernameTextBox.Text = UserData.UserName;
            this.outletNameComboBox.Text = this._outletName;
        }

        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            // Open DB connection
            this.sqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                this.sqlCmdProcUpdateReview.Parameters["@review_id"].Value = this._reviewId;
                this.sqlCmdProcUpdateReview.Parameters["@rating"].Value = this.ratingComboBox.Text;
                this.sqlCmdProcUpdateReview.Parameters["@review_content"].Value = this.reviewContentTextBox.Text;

                // Call proc
                int iAffectedRowsCount = this.sqlCmdProcUpdateReview.ExecuteNonQuery();

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
            catch (SqlException ex)
            {
                //MessageBox.Show("Добавление данных завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            }

            // Close DB connection
            this.sqlConnection.Close();
        }
    }
}
