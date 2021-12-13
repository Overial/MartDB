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
    public partial class UpdateTradeProfileForm : Form
    {
        private string _tradeProfileId = "";
        private string _tradeProfileName = "";

        public UpdateTradeProfileForm(string tradeProfileId, string tradeProfileName)
        {
            InitializeComponent();

            this._tradeProfileId = tradeProfileId;
            this._tradeProfileName = tradeProfileName;
        }

        private void UpdateTradeProfileForm_Load(object sender, EventArgs e)
        {
            tradeProfileNameTextBox.Text = this._tradeProfileName;
        }

        private void btnUpdateTradeProfile_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdProcUpdateTradeProfile.Parameters["@trade_profile_id"].Value = this._tradeProfileId;
                sqlCmdProcUpdateTradeProfile.Parameters["@trade_profile_name"].Value = Convert.ToString(tradeProfileNameTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdProcUpdateTradeProfile.ExecuteNonQuery();

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
