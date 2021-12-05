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
    public partial class HandleTradeProfilesForm : Form
    {
        public HandleTradeProfilesForm()
        {
            InitializeComponent();
        }

        private void btnAddTradeProfile_Click(object sender, EventArgs e)
        {
            // Open DB connection
            sqlConnection.Open();

            // Initialize params
            try
            {
                sqlCmdCreateTradeProfile.Parameters["@trade_profile_name"].Value = Convert.ToString(tradeProfileNameTextBox.Text);

                // Call proc
                int iAffectedRowsCount = sqlCmdCreateTradeProfile.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Добавление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Данные успешно добавлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
