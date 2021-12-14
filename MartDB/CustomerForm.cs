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

            if (!UserData.IsCurrentUserAuthenticated)
            {
                this.btnViewUserReviews.Enabled = false;
                this.btnAddReview.Enabled = false;
                this.btnUpdateReview.Enabled = false;
                this.btnDeleteReview.Enabled = false;
            }
        }

        ////// Menu strip //////

        // Get info about app
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
                                     "Outlet.trade_profile_name AS [Торговый профиль]," +
                                     "Area.floor_number AS [Номер этажа]," +
                                     "Outlet.timetable AS [Расписание]," +
                                     "Outlet.rating AS [Рейтинг] " +
                                     "FROM Outlet " +
                                 "JOIN Area ON Outlet.area_id = Area.area_id " +
                                 "JOIN Organisation ON Outlet.org_id = Organisation.org_id ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvOutlet.DataSource = dataSet.Tables[0];
            this.dgvOutlet.Columns[2].Width = 50;
            this.dgvOutlet.Columns[4].Width = 50;
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
                                     "Review.review_id," +
                                     "Outlet.outlet_name," +
                                     "Review.rating AS [Рейтинг]," +
                                     "Review.review_content AS [Комментарий]," +
                                     "Users.username AS [Имя пользователя] " +
                                 "FROM Review " +
                                 "JOIN Outlet ON Review.outlet_id = Outlet.outlet_id " +
                                 "JOIN Users ON Review.userid = Users.userid";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvReview.DataSource = dataSet.Tables[0];
            this.dgvReview.Columns[0].Visible = false;
            this.dgvReview.Columns[1].Visible = false;
            this.dgvReview.Columns[2].Width = 50;
        }

        private void UpdateOutletRating(string outletName)
        {
            // Open DB connection
            this.sqlConnection.Open();

            // Call proc
            try
            {
                // Initialize params
                this.sqlCmdProcUpdateOutletRating.Parameters["@outlet_name"].Value = outletName;

                // Call proc
                int iAffectedRowsCount = this.sqlCmdProcUpdateOutletRating.ExecuteNonQuery();

                // Show corresponding information
                if (iAffectedRowsCount == 0)
                {
                    MessageBox.Show("Обновление рейтингов завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // MessageBox.Show("Рейтинги успешно обновлены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateAllOutletsRatings()
        {
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                string outletName = row.Cells[0].Value.ToString();
                UpdateOutletRating(outletName);
            }
        }

        // Button to change user at runtime
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }

        // Prevent user from searching without selected col
        private void searchColsOutletListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSearchOutlet.Enabled = true;

            this.comboBox1.Visible = false;
            this.comboBox2.Visible = false;

            this.sqlConnection.Open();

            // Get selected col to sort
            switch (this.searchColsOutletListBox.SelectedIndex)
            {
                case 0:
                    this.searchQueryOutletComboBox.BringToFront();
                    DataTable dtOutletNames = new DataTable();
                    SqlDataAdapter daOutletNames = new SqlDataAdapter("SELECT outlet_name FROM Outlet",
                                                                      this.sqlConnection);
                    daOutletNames.Fill(dtOutletNames);
                    this.searchQueryOutletComboBox.DataSource = dtOutletNames;
                    this.searchQueryOutletComboBox.DisplayMember = "outlet_name";
                    this.searchQueryOutletComboBox.ValueMember = "outlet_name";
                    break;
                case 1:
                    this.searchQueryOutletComboBox.BringToFront();
                    DataTable dtTradeProfileNames = new DataTable();
                    SqlDataAdapter daTradeProfileNames = new SqlDataAdapter("SELECT trade_profile_name FROM Outlet",
                                                                            this.sqlConnection);
                    daTradeProfileNames.Fill(dtTradeProfileNames);
                    this.searchQueryOutletComboBox.DataSource = dtTradeProfileNames;
                    this.searchQueryOutletComboBox.DisplayMember = "trade_profile_name";
                    this.searchQueryOutletComboBox.ValueMember = "trade_profile_name";
                    break;
                case 2:
                    this.searchQueryOutletComboBox.BringToFront();
                    DataTable dtFloorNumbers = new DataTable();
                    SqlDataAdapter daFloorNumbers = new SqlDataAdapter("SELECT DISTINCT floor_number FROM Area " +
                                                                       "JOIN Outlet ON Outlet.area_id = Area.area_id",
                                                                       this.sqlConnection);
                    daFloorNumbers.Fill(dtFloorNumbers);
                    this.searchQueryOutletComboBox.DataSource = dtFloorNumbers;
                    this.searchQueryOutletComboBox.DisplayMember = "floor_number";
                    this.searchQueryOutletComboBox.ValueMember = "floor_number";
                    break;
                case 3:
                    this.searchQueryOutletComboBox.BringToFront();
                    DataTable dtTimeTables = new DataTable();
                    SqlDataAdapter daTimeTables = new SqlDataAdapter("SELECT DISTINCT timetable FROM Outlet",
                                                                      this.sqlConnection);
                    daTimeTables.Fill(dtTimeTables);
                    this.searchQueryOutletComboBox.DataSource = dtTimeTables;
                    this.searchQueryOutletComboBox.DisplayMember = "timetable";
                    this.searchQueryOutletComboBox.ValueMember = "timetable";
                    break;
                case 4:
                    this.comboBox1.Visible = true;
                    this.comboBox1.BringToFront();
                    this.comboBox2.Visible = true;
                    this.comboBox2.BringToFront();
                    break;
                default:
                    break;
            }

            this.sqlConnection.Close();
        }

        // Button for searching
        private void btnSearchOutlet_Click(object sender, EventArgs e)
        {
            // Field parser
            int iColIndex = 0;
            if (this.searchColsOutletListBox.SelectedItem != null)
            {
                string strFieldForSearch = this.searchColsOutletListBox.SelectedItem.ToString();
                for (int i = 0; i < dgvOutlet.Columns.Count; ++i)
                {
                    if (this.dgvOutlet.Columns[i].HeaderText == strFieldForSearch)
                    {
                        iColIndex = i;
                        break;
                    }
                }
            }

            // Start searching only if user has entered query for search
            if (iColIndex != 4)
            {
                if (this.searchQueryOutletComboBox.Text.Length > 0)
                {
                    // Prevent invalid user input
                    string query = "";
                    try
                    {
                        query = Convert.ToString(this.searchQueryOutletComboBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Filter area square data
                    foreach (DataGridViewRow row in this.dgvOutlet.Rows)
                    {
                        if (row.Cells[iColIndex].Value.ToString().Contains(query))
                        {
                            this.dgvOutlet.Rows[row.Index].Visible = true;
                        }
                        else
                        {
                            this.dgvOutlet.CurrentCell = null;
                            this.dgvOutlet.Rows[row.Index].Visible = false;
                        }
                    }
                }
            }
            else
            {
                if (this.comboBox1.Text.Length > 0 && this.comboBox2.Text.Length > 0)
                {
                    int leftRatingBound = Convert.ToInt32(this.comboBox1.Text);
                    int rightRatingBound = Convert.ToInt32(this.comboBox2.Text);

                    // Filter area square data
                    foreach (DataGridViewRow row in this.dgvOutlet.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[iColIndex].Value) >= leftRatingBound &&
                            Convert.ToInt32(row.Cells[iColIndex].Value) <= rightRatingBound)
                        {
                            this.dgvOutlet.Rows[row.Index].Visible = true;
                        }
                        else
                        {
                            this.dgvOutlet.CurrentCell = null;
                            this.dgvOutlet.Rows[row.Index].Visible = false;
                        }
                    }
                }
            }
        }

        // Show all outlets
        private void btnOutletShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                this.dgvOutlet.Rows[row.Index].Visible = true;
            }
        }

        // Prevent user from sorting without selected col
        private void sortColsOutletListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSortOutlet.Enabled = true;
        }

        // Button for sorting
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
                this.dgvOutlet.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descOutletRadioButton.Checked)
            {
                this.dgvOutlet.Sort(col, ListSortDirection.Descending);
            }
        }

        // Display selected outlet reviews
        private void dgvOutlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewSelectedOutletReviews();
        }

        // Add review button
        private void btnAddReview_Click(object sender, EventArgs e)
        {
            // Get selected outlet
            int rowIndex = this.dgvOutlet.SelectedCells[0].RowIndex;
            string outletName = this.dgvOutlet.Rows[rowIndex].Cells[0].Value.ToString();

            // Show addReviewForm and pass outletName there
            Form addReviewForm = new AddReviewForm(outletName);
            addReviewForm.FormClosed += new FormClosedEventHandler(this.handleReviewForms_FormClosed);
            addReviewForm.Show();
        }

        // Update review button
        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            if (this.dgvReview.AreAllCellsSelected(true))
            {
                MessageBox.Show("Изменить можно только один отзыв за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Get selected review
                int rowIndex = this.dgvReview.SelectedCells[0].RowIndex;
                int reviewId = Convert.ToInt32(this.dgvReview.Rows[rowIndex].Cells[0].Value);
                string outletName = this.dgvReview.Rows[rowIndex].Cells[1].Value.ToString();
                string username = this.dgvReview.Rows[rowIndex].Cells[4].Value.ToString();

                // Pass data to UpdateBookingForm
                if (username == UserData.UserName)
                {
                    Form updateReviewForm = new UpdateReviewForm(reviewId, outletName);
                    updateReviewForm.FormClosed += new FormClosedEventHandler(this.handleReviewForms_FormClosed);
                    updateReviewForm.Show();
                }
                else
                {
                    MessageBox.Show("Выбран чужой отзыв!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete review button
        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (this.dgvReview.AreAllCellsSelected(true))
            {
                MessageBox.Show("Удалить можно только один отзыв за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Get selected review
                int rowIndex = this.dgvReview.SelectedCells[0].RowIndex;
                string reviewId = this.dgvReview.Rows[rowIndex].Cells[0].Value.ToString();
                string username = this.dgvReview.Rows[rowIndex].Cells[4].Value.ToString();

                // Pass data to UpdateBookingForm
                if (username == UserData.UserName)
                {
                    // Open DB connection
                    this.sqlConnection.Open();

                    // Call proc
                    try
                    {
                        // Initialize params
                        this.sqlCmdProcDeleteReview.Parameters["@review_id"].Value = reviewId;
                        this.sqlCmdProcDeleteReview.Parameters["@username"].Value = username;

                        // Call proc
                        int iAffectedRowsCount = this.sqlCmdProcDeleteReview.ExecuteNonQuery();

                        // Show corresponding information
                        if (iAffectedRowsCount == 0)
                        {
                            MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Update dgvReview in case of success
                            ViewSelectedOutletReviews();
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
        }

        // Show only selected outlet reviews
        private void ViewSelectedOutletReviews()
        {
            // Clear review DGV
            this.dgvReview.DataSource = null;

            // Get selected outlet
            if (this.dgvOutlet.SelectedCells.Count > 0)
            {
                int rowIndex = this.dgvOutlet.SelectedCells[0].RowIndex;
                string outletName = this.dgvOutlet.Rows[rowIndex].Cells[0].Value.ToString();

                // Call SQL fn
                this.sqlCmdFnGetOutletReviews.Parameters["@outlet_name"].Value = outletName;
                if (this.sqlConnection.State == ConnectionState.Closed)
                {
                    this.sqlConnection.Open();
                }
                DataTable dt = new DataTable();
                dt.Load(sqlCmdFnGetOutletReviews.ExecuteReader());

                // Set review DGV design
                this.dgvReview.DataSource = dt;
                this.dgvReview.Columns[0].Visible = false;
                this.dgvReview.Columns[1].Visible = false;
                this.dgvReview.Columns[2].Width = 50;
                this.dgvReview.Columns[2].HeaderText = "Рейтинг";
                this.dgvReview.Columns[3].HeaderText = "Комментарий";
                this.dgvReview.Columns[4].HeaderText = "Имя пользователя";

                this.sqlConnection.Close();
            }
        }

        // Show only current user reviews
        private void ViewUserReviews()
        {
            FillReviewsDGV();

            // Filter area square data
            foreach (DataGridViewRow row in this.dgvReview.Rows)
            {
                if (row.Cells[4].Value.ToString().Contains(UserData.UserName))
                {
                    this.dgvReview.Rows[row.Index].Visible = true;
                }
                else
                {
                    this.dgvReview.CurrentCell = null;
                    this.dgvReview.Rows[row.Index].Visible = false;
                }
            }
        }

        // Button to show user reviews
        private void btnUserReviewsForm_Click(object sender, EventArgs e)
        {
            ViewUserReviews();
        }

        // Button to show all reviews
        private void btnReviewShowAll_Click(object sender, EventArgs e)
        {
            this.dgvReview.DataSource = null;
            FillReviewsDGV();
        }

        // Update review DGV after manipulations
        private void handleReviewForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateAllOutletsRatings();
            FillOutletsDGV();
            ViewSelectedOutletReviews();
        }
    }
}
