// IDB-19-07
// Afanasyev Vadim
// 2021

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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ////// Display info about user //////

            // Display user name at main window label
            this.panelOutletLabel.Text = "Добро пожаловать, " + UserData.UserName + "!";

            // Display user name at panel label
            this.currentUserNameLabel.Text = "Текущий пользователь: " + UserData.UserName;

            // Fill outlet data grid view
            FillOutletsDGV();
        }

        ////// Menu strip //////

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных ТЦ \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ////// Outlet panel //////

        // Get info about outlets
        private void FillOutletsDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT Outlet.outlet_name AS [Название торговой точки], " +
                                 "Outlet.outlet_type AS [Тип торговой точки]," +
                                 "Area.floor_number AS [Номер этажа]," +
                                 "Outlet.timetable AS [Расписание]," +
                                 "Outlet.rating AS [Рейтинг] " +
                                 "FROM Outlet " +
                                 "JOIN Area ON Outlet.area_id = Area.area_id " +
                                 "JOIN Organisation ON Outlet.org_id = Organisation.org_id ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            dgvOutlet.ReadOnly = true;
            dgvOutlet.DataSource = dataSet.Tables[0];
        }

        private void searchColsOutletListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSearchOutlet.Enabled = true;
        }

        private void btnSearchOutlet_Click(object sender, EventArgs e)
        {
            // Field parser
            int iColIndex = 0;
            
            if (this.searchColsOutletListBox.SelectedItem != null)
            {
                string strFieldForSearch = this.searchColsOutletListBox.SelectedItem.ToString();

                for (int i = 0; i < dgvOutlet.Columns.Count; ++i)
                {
                    if (dgvOutlet.Columns[i].HeaderText == strFieldForSearch)
                    {
                        iColIndex = i;
                    }
                }
            }

            // Start searching only if user has entered query for search
            if (this.searchQueryOutletTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.searchQueryOutletTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvOutlet.Rows)
                {
                    if (row.Cells[iColIndex].Value.ToString().Contains(query))
                    {
                        dgvOutlet.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        dgvOutlet.CurrentCell = null;
                        dgvOutlet.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnOutletShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                dgvOutlet.Rows[row.Index].Visible = true;
            }
        }

        private void sortColsOutletListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSortOutlet.Enabled = true;
        }

        private void btnSortOutlet_Click(object sender, EventArgs e)
        {
            // col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.sortColsOutletListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvOutlet.Columns[0];
                    break;
                case 1:
                    col = this.dgvOutlet.Columns[1];
                    break;
                case 2:
                    col = this.dgvOutlet.Columns[2];
                    break;
                case 3:
                    col = this.dgvOutlet.Columns[3];
                    break;
                case 4:
                    col = this.dgvOutlet.Columns[4];
                    break;
                default:
                    break;
            }

            // Get selected choice for sorting
            if (this.ascOutletRadioButton.Checked)
            {
                dgvOutlet.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descOutletRadioButton.Checked)
            {
                dgvOutlet.Sort(col, ListSortDirection.Descending);
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            Int32 selectedCellsCount = this.dgvOutlet.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellsCount > 0)
            {
                if (this.dgvOutlet.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Добавить можно только один отзыв за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    // Initiate booking updating only if the whole row is selected
                    if (selectedCellsCount == this.dgvOutlet.Columns.GetColumnCount(DataGridViewElementStates.Visible))
                    {
                        string outletName = this.dgvOutlet.SelectedCells[0].Value.ToString();

                        // Pass data to UpdateBookingForm
                        Form addReviewForm = new AddReviewForm(outletName);
                        addReviewForm.FormClosed += new FormClosedEventHandler(this.hanldleReviewForms_FormClosed);
                        addReviewForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Выберите всю строку для изменения информации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //sb.Append("Total: " + selectedCellsCount.ToString());
                    //MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }

        // Refresh booking table after any manipulations with it
        private void hanldleReviewForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillOutletsDGV();
        }

        // Button to change user at runtime
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
