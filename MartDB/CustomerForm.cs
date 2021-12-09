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
            this.currentUserLabel.Text = UserData.UserName + "!";

            // Fill outlet data grid view
            FillOutletsDGV();

            // Fill review data grid view
            FillReviewsDGV();
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
            string selectQuery = "SELECT " +
                                     "Outlet.outlet_name AS [Название торговой точки], " +
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
            this.dgvOutlet.ReadOnly = true;
            this.dgvOutlet.DataSource = dataSet.Tables[0];
        }

        // Get info about reviews
        private void FillReviewsDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "Outlet.outlet_name," +
                                     "Users.username," +
                                     "Review.rating," +
                                     "Review.review_content " +
                                     "FROM Review " +
                                 "JOIN Users ON Review.userid = Users.id " +
                                 "JOIN Outlet ON Review.org_id = Outlet.org_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvReview.ReadOnly = true;
            this.dgvReview.DataSource = dataSet.Tables[0];
        }

        // Button to change user at runtime
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form = new LoginForm();
            form.ShowDialog();
            this.Close();
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

        // Display selected outlet reviews
        private void dgvOutlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvReview.DataSource = null;

            // Get selected outlet
            string selectedOutlet = "";
            if (this.dgvOutlet.SelectedCells.Count == 1)
            {
                // MessageBox.Show(this.dgvOutlet.CurrentRow.Cells[0].Value.ToString());
                selectedOutlet = this.dgvOutlet.CurrentRow.Cells[0].Value.ToString();

                this.sqlCmdGetOutletReviews.Parameters["@outlet_name"].Value = selectedOutlet;
                this.sqlConnection.Open();
                DataTable dt = new DataTable();
                dt.Load(sqlCmdGetOutletReviews.ExecuteReader());
                this.dgvReview.DataSource = dt;
                this.sqlConnection.Close();
            }
        }

        private void dgvOutlet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvReview.DataSource = null;

            // Get selected outlet
            string selectedOutlet = "";
            // MessageBox.Show(this.dgvOutlet.CurrentRow.Cells[0].Value.ToString());
            selectedOutlet = this.dgvOutlet.CurrentRow.Cells[0].Value.ToString();

            this.sqlCmdGetOutletReviews.Parameters["@outlet_name"].Value = selectedOutlet;
            this.sqlConnection.Open();
            DataTable dt = new DataTable();
            dt.Load(sqlCmdGetOutletReviews.ExecuteReader());
            this.dgvReview.DataSource = dt;
            this.sqlConnection.Close();
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
                        addReviewForm.FormClosed += new FormClosedEventHandler(this.handleReviewForms_FormClosed);
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

        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            Int32 selectedCellsCount = this.dgvReview.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellsCount > 0)
            {
                if (this.dgvReview.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Изменить можно только один отзыв за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Initiate booking updating only if the whole row is selected
                    if (selectedCellsCount == this.dgvReview.Columns.GetColumnCount(DataGridViewElementStates.Visible))
                    {
                        string outletName = this.dgvReview.SelectedCells[0].Value.ToString();
                        string username = this.dgvReview.SelectedCells[1].Value.ToString();

                        // Pass data to UpdateBookingForm
                        if (username == UserData.UserName)
                        {
                            Form updateReviewForm = new UpdateReviewForm(outletName);
                            updateReviewForm.FormClosed += new FormClosedEventHandler(this.handleReviewForms_FormClosed);
                            updateReviewForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Выбран чужой отзыв!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            Int32 selectedCellsCount = this.dgvReview.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellsCount > 0)
            {
                if (this.dgvReview.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Удалить можно только один отзыв за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Initiate booking updating only if the whole row is selected
                    if (selectedCellsCount == this.dgvReview.Columns.GetColumnCount(DataGridViewElementStates.Visible))
                    {
                        string outletName = this.dgvReview.SelectedCells[0].Value.ToString();
                        string username = this.dgvReview.SelectedCells[1].Value.ToString();

                        // Pass data to UpdateBookingForm
                        if (username == UserData.UserName)
                        {
                            // Open DB connection
                            this.sqlConnection.Open();

                            // Call proc
                            try
                            {
                                // Initialize params
                                this.sqlCmdDeleteReview.Parameters["@username"].Value = UserData.UserName;
                                this.sqlCmdDeleteReview.Parameters["@outlet_name"].Value = outletName;

                                // Call proc
                                int iAffectedRowsCount = this.sqlCmdDeleteReview.ExecuteNonQuery();

                                // Show corresponding information
                                if (iAffectedRowsCount == 0)
                                {
                                    MessageBox.Show("Удаления данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Update dgvReview in case of success
                                    FillReviewsDGV();
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
                        else
                        {
                            MessageBox.Show("Выбран чужой отзыв!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите всю строку для удаления отзыва!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //sb.Append("Total: " + selectedCellsCount.ToString());
                    //MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }

        // Show only current user reviews
        private void ViewUserReviews()
        {
            FillReviewsDGV();

            // Filter area square data
            foreach (DataGridViewRow row in this.dgvReview.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(UserData.UserName))
                {
                    dgvReview.Rows[row.Index].Visible = true;
                }
                else
                {
                    dgvReview.CurrentCell = null;
                    dgvReview.Rows[row.Index].Visible = false;
                }
            }
        }

        private void btnUserReviewsForm_Click(object sender, EventArgs e)
        {
            ViewUserReviews();
        }

        private void btnReviewShowAll_Click(object sender, EventArgs e)
        {
            this.dgvReview.DataSource = null;
            FillReviewsDGV();
        }

        // Refresh booking table after any manipulations with it
        private void handleReviewForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FillOutletsDGV();
            //FillReviewsDGV();

            ViewUserReviews();
        }
    }
}
