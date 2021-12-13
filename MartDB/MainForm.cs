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
    public partial class MainForm : Form
    {
        // List with panels
        List<Panel> listPanel = new List<Panel>();
        // For panel list indexing
        int index = 0;

        // Panels:
        // 0: Main
        // 1: Area
        // 2: Booking
        // 3: Employee
        // 4: TradeProfile
        // 5: Outlet

        public MainForm()
        {
            InitializeComponent();
        }

        // Actions on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            ////// Display info about user //////
            
            // Display user name
            this.currentUserNameLabel.Text = "Текущий пользователь: " + UserData.UserName;

            // Parse user role and display it
            switch (UserData.UserRole)
            {
                case "admin":
                    this.currentUserRoleLabel.Text = "Текущая роль: Администратор";
                    break;
                case "organisation":
                    this.currentUserRoleLabel.Text = "Текущая роль: Организация";
                    break;
                default:
                    this.currentUserRoleLabel.Text = "Текущая роль: ?";
                    break;
            }

            // Turning pages functionality
            this.listPanel.Add(this.panelMain);
            this.listPanel.Add(this.panelArea);
            this.listPanel.Add(this.panelBooking);
            this.listPanel.Add(this.panelEmployee);
            this.listPanel.Add(this.panelTradeProfile);
            this.listPanel.Add(this.panelOutlet);
            
            // Show first panel
            this.listPanel[this.index].BringToFront();

            // Adjust form for organisations
            if (UserData.UserRole == "organisation")
            {
                this.btnAddBookingForm.Enabled = false;
            }

            ////// DGV loading //////

            // Fill area data grid view
            FillAreaDGV();

            // Fill booking data grid view
            FillBookingDGV();

            // Fill employees data grid view
            FillEmployeesDGV();

            // Fill trade profiles data grid view
            FillTradeProfilesDGV();

            // Fill outlet data grid view
            FillOutletsDGV();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;

            // Set booking data comboboxes
            this.sqlConnection.Open();

            this.bookingSearchDateComboBox1.BringToFront();
            this.bookingSearchDateComboBox2.BringToFront();
                
            DataTable dtBookingStartDates = new DataTable();
            SqlDataAdapter daBookingStartDates = new SqlDataAdapter("SELECT DISTINCT booking_start_date FROM Booking",
                                                                    this.sqlConnection);

            daBookingStartDates.Fill(dtBookingStartDates);
                
            this.bookingSearchDateComboBox1.DataSource = dtBookingStartDates;
            this.bookingSearchDateComboBox1.DisplayMember = "booking_start_date";
            this.bookingSearchDateComboBox1.ValueMember = "booking_start_date";

            DataTable dtBookingEndDates = new DataTable();
            SqlDataAdapter daBookingEndDates = new SqlDataAdapter("SELECT DISTINCT booking_end_date FROM Booking",
                                                                    this.sqlConnection);

            daBookingEndDates.Fill(dtBookingEndDates);

            this.bookingSearchDateComboBox2.DataSource = dtBookingEndDates;
            this.bookingSearchDateComboBox2.DisplayMember = "booking_end_date";
            this.bookingSearchDateComboBox2.ValueMember = "booking_end_date";

            this.sqlConnection.Close();
        }

        ////// Nav buttons //////

        // Turn back
        private void btnPreviousPanel_Click(object sender, EventArgs e)
        {
            // While it's not the beginning and not the main panel
            if (this.index > 1)
            {
                this.listPanel[--this.index].BringToFront();
            }
        }

        // Turn forward
        private void btnNextPanel_Click(object sender, EventArgs e)
        {
            // While it's not the end
            if (this.index < this.listPanel.Count - 1)
            {
                this.listPanel[++this.index].BringToFront();
            }
        }

        // Move to main panel
        private void btnPanelMain_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 0;

            // Bring main panel to front
            this.panelMain.BringToFront();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;
        }

        ////// Main panel buttons //////

        // Change current user
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }

        // Move to area panel
        private void btnPanelArea_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 1;

            // Bring booking handling panel to front
            this.panelArea.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        // Move to booking panel
        private void btnPanelBooking_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 2;

            // Bring booking handling panel to front
            this.panelBooking.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void btnPanelEmployee_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 3;

            // Bring booking handling panel to front
            this.panelEmployee.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void btnPanelTradeProfile_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 4;

            // Bring booking handling panel to front
            this.panelTradeProfile.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void btnPanelOutlet_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 5;

            // Bring booking handling panel to front
            this.panelOutlet.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        ////// Menu strip //////

        private void mainPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 0;
            this.panelMain.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelArea.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void bookingPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 2;
            this.panelBooking.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void employeePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 3;
            this.panelEmployee.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void tradeProfilePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 4;
            this.panelTradeProfile.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void outletPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 5;
            this.panelOutlet.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных ТЦ \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ////// Area panel //////

        // Get info about areas and bookings
        private void FillAreaDGV()
        {
            this.dgvArea.DataSource = null;

            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "Area.area_id," +
                                     "Area.area_square," +
                                     "Area.floor_number " +
                                     "FROM Area " +
                                 "LEFT JOIN Booking ON Area.area_id = Booking.area_id " +
                                 "WHERE Booking.area_id IS NULL";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvArea.DataSource = dataSet.Tables[0];
        }

        private void btnAreaSquareSearch_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.areaSearchSquareLeftBoundTextBox.Text.Length > 0 && this.areaSearchSquareRightBoundTextBox.Text.Length > 0)
            {
                string leftBound = "";
                string rightBound = "";
                try
                {
                    leftBound = Convert.ToString(this.areaSearchSquareLeftBoundTextBox.Text);
                    rightBound = Convert.ToString(this.areaSearchSquareRightBoundTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter data (approximate, not exact)
                // this.areaBindingSource.Filter = string.Format("CONVERT(" + colForSearch + ", 'System.String') LIKE '%{0}%' ",
                //                                                queryForSearch);

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvArea.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= Convert.ToInt32(leftBound) &&
                        Convert.ToInt32(row.Cells[0].Value) <= Convert.ToInt32(rightBound))
                    {
                        this.dgvArea.Rows[row.Index].Visible = true;
                        // dgvBookingHandling.Rows[row.Index].Selected = true;
                    }
                    else
                    {
                        this.dgvArea.CurrentCell = null;
                        this.dgvArea.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnAreaFloorSearch_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.areaSearchFloorLeftBoundTextBox.Text.Length > 0 && this.areaSearchFloorRightBoundTextBox.Text.Length > 0)
            {
                string leftBound = "";
                string rightBound = "";
                try
                {
                    leftBound = Convert.ToString(this.areaSearchFloorLeftBoundTextBox.Text);
                    rightBound = Convert.ToString(this.areaSearchFloorRightBoundTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvArea.Rows)
                {
                    if (Convert.ToInt32(row.Cells[2].Value) >= Convert.ToInt32(leftBound) &&
                        Convert.ToInt32(row.Cells[2].Value) <= Convert.ToInt32(rightBound))
                    {
                        this.dgvArea.Rows[row.Index].Visible = true;
                        // dgvBookingHandling.Rows[row.Index].Selected = true;
                    }
                    else
                    {
                        this.dgvArea.CurrentCell = null;
                        this.dgvArea.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnAreaShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvArea.Rows)
            {
                this.dgvArea.Rows[row.Index].Visible = true;
            }
        }

        private void areaSortColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAreaSort.Enabled = true;
        }

        private void btnAreaSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.areaSortColsListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvArea.Columns[0];
                    break;
                case 1:
                    col = this.dgvArea.Columns[1];
                    break;
                case 2:
                    col = this.dgvArea.Columns[2];
                    break;
            }

            // Get selected choice for sorting
            if (this.ascAreaRadioButton.Checked)
            {
                this.dgvArea.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descAreaRadioButton.Checked)
            {
                this.dgvArea.Sort(col, ListSortDirection.Descending);
            }
        }

        ////// Booking panel //////

        // Get info about areas and bookings
        private void FillBookingDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "";
            if (UserData.UserRole == "admin")
            {
                selectQuery = "SELECT " +
                                  "Booking.booking_id," +
                                  "Organisation.org_name AS [Название организации]," +
                                  "Area.area_id AS [Код помещения]," +
                                  "Area.area_square AS [Площадь помещения]," +
                                  "Area.floor_number AS [Номер этажа]," +
                                  "Booking.cost AS [Стоимость аренды]," +
                                  "Booking.booking_start_date AS [Начало периода аренды]," +
                                  "Booking.booking_end_date AS [Конец периода аренды] " +
                            "FROM Booking " +
                            "JOIN Organisation ON Booking.org_id = Organisation.org_id " +
                            "JOIN Area ON Booking.area_id = Area.area_id";
            }
            else if (UserData.UserRole == "organisation")
            {
                selectQuery = "SELECT " +
                                  "Booking.booking_id," +
                                  "Organisation.org_name AS [Название организации]," +
                                  "Area.area_id AS [Код помещения]," +
                                  "Area.area_square AS [Площадь помещения]," +
                                  "Area.floor_number AS [Номер этажа]," +
                                  "Booking.cost AS [Стоимость аренды]," +
                                  "Booking.booking_start_date AS [Начало периода аренды]," +
                                  "Booking.booking_end_date AS [Конец периода аренды] " +
                              "FROM Booking " +
                              "JOIN Organisation ON Booking.org_id = Organisation.org_id " +
                              "JOIN Area ON Booking.area_id = Area.area_id " +
                              "WHERE Organisation.org_name = \'" + UserData.UserName + "\'";
            }
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvBooking.DataSource = dataSet.Tables[0];
            this.dgvBooking.Columns[0].Visible = false;
        }

        // Button to initiate searchin'
        private void btnCostSearch_Click(object sender, EventArgs e)
        {
            // Get field for search
            //
            // HeaderText and Name of the columns are different, so
            // we need to get actual Name of selected column
            //

            // Field parser
            //string strFieldForSearch = this.listBoxFieldsForSearch.SelectedItem.ToString();
            //string colForSearch = "";
            //for (int i = 0; i < areaDataGridView.Columns.Count; ++i)
            //{
            //    if (areaDataGridView.Columns[i].HeaderText == strFieldForSearch)
            //    {
            //        colForSearch = areaDataGridView.Columns[i].DataPropertyName;
            //    }
            //}

            // Start searching only if user has entered query for search
            if (this.bookingSearchCostLeftBoundTextBox.Text.Length > 0 && this.bookingSearchCostRightBoundTextBox.Text.Length > 0)
            {
                string leftBound = "";
                string rightBound = "";
                try
                {
                    leftBound = Convert.ToString(this.bookingSearchCostLeftBoundTextBox.Text);
                    rightBound = Convert.ToString(this.bookingSearchCostRightBoundTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter data (approximate, not exact)
                // this.areaBindingSource.Filter = string.Format("CONVERT(" + colForSearch + ", 'System.String') LIKE '%{0}%' ",
                //                                                queryForSearch);

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvBooking.Rows)
                {
                    if (Convert.ToInt32(row.Cells[4].Value) >= Convert.ToInt32(leftBound) &&
                        Convert.ToInt32(row.Cells[4].Value) <= Convert.ToInt32(rightBound))
                    {
                        this.dgvBooking.Rows[row.Index].Visible = true;
                        // dgvBookingHandling.Rows[row.Index].Selected = true;
                    }
                    else
                    {
                        this.dgvBooking.CurrentCell = null;
                        this.dgvBooking.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        // Seaching by floor button
        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.bookingSearchDateComboBox1.Text.Length > 0 && this.bookingSearchDateComboBox2.Text.Length > 0)
            {
                DateTime leftBound;
                DateTime rightBound;
                try
                {
                    leftBound = DateTime.Parse(this.bookingSearchDateComboBox1.Text);
                    rightBound = DateTime.Parse(this.bookingSearchDateComboBox2.Text);

                    // Filter area square data
                    foreach (DataGridViewRow row in this.dgvBooking.Rows)
                    {
                        if (DateTime.Parse(row.Cells[6].Value.ToString()).Date >= leftBound.Date &&
                            DateTime.Parse(row.Cells[7].Value.ToString()).Date <= rightBound.Date)
                        {
                            this.dgvBooking.Rows[row.Index].Visible = true;
                            // dgvBookingHandling.Rows[row.Index].Selected = true;
                        }
                        else
                        {
                            this.dgvBooking.CurrentCell = null;
                            this.dgvBooking.Rows[row.Index].Visible = false;
                        }
                    }
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Button to show all data
        private void btnBookingShowAll_Click(object sender, EventArgs e)
        {
            // this.areaBindingSource.Filter = "";

            // dgvBookingHandling.Rows[0].Selected = true;

            // Display every row
            foreach (DataGridViewRow row in this.dgvBooking.Rows)
            {
                this.dgvBooking.Rows[row.Index].Visible = true;
            }
        }

        // Enable button only if field for sort is selected
        private void bookingSortColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnBookingSort.Enabled = true;
        }

        // Button to initiate sorting
        private void btnBookingSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.bookingSortColsListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvBooking.Columns[1];
                    break;
                case 1:
                    col = this.dgvBooking.Columns[2];
                    break;
                case 2:
                    col = this.dgvBooking.Columns[3];
                    break;
                case 3:
                    col = this.dgvBooking.Columns[4];
                    break;
                case 4:
                    col = this.dgvBooking.Columns[5];
                    break;
                case 5:
                    col = this.dgvBooking.Columns[6];
                    break;
                case 6:
                    col = this.dgvBooking.Columns[7];
                    break;
                default:
                    break;
            }

            // Get selected choice for sorting
            if (this.ascBookingRadioButton.Checked)
            {
                this.dgvBooking.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descBookingRadioButton.Checked)
            {
                this.dgvBooking.Sort(col, ListSortDirection.Descending);
            }
        }

        // Move to booking handling form
        private void btnAddBookingForm_Click(object sender, EventArgs e)
        {
            Form handleBookingForm = new AddBookingForm();
            handleBookingForm.FormClosed += new FormClosedEventHandler(this.handleBookingForms_FormClosed);
            handleBookingForm.Show();
        }

        // Get data from selected booking
        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgvBooking.SelectedCells[0].RowIndex;

            if (this.dgvBooking.SelectedCells.Count > 1)
            {
                MessageBox.Show("Изменить можно только одну аренду за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvBooking.SelectedCells.Count == 1)
            {
                // Get selected booking
                int booking_id = Convert.ToInt32(this.dgvBooking.Rows[rowIndex].Cells[0].Value);
                string orgName = this.dgvBooking.Rows[rowIndex].Cells[1].Value.ToString();
                int areaId = Convert.ToInt32(this.dgvBooking.Rows[rowIndex].Cells[2].Value);
                string bookingStartDate = this.dgvBooking.Rows[rowIndex].Cells[6].Value.ToString();
                string bookingEndDate = this.dgvBooking.Rows[rowIndex].Cells[7].Value.ToString();

                // Pass data to UpdateBookingForm
                Form updateBookingForm = new UpdateBookingForm(orgName, areaId, bookingStartDate, bookingEndDate);
                updateBookingForm.FormClosed += new FormClosedEventHandler(this.handleBookingForms_FormClosed);
                updateBookingForm.Show();
            }
        }

        // Refresh booking table after any manipulations with it
        private void handleBookingForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillBookingDGV();
        }

        ////// Employee panel //////

        // Get info about employees
        private void FillEmployeesDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "Employee.employee_id," +
                                     "Organisation.org_name AS [Организация]," +
                                     "Employee.fio AS [ФИО]," +
                                     "Employee.gender AS [Пол]," +
                                     "Employee.position AS [Должность]," +
                                     "Employee.phone_number AS [Телефонный номер]," +
                                     "Employee.email AS [Электронная почта] " +
                                 "FROM Employee " +
                                 "JOIN Organisation ON Employee.org_id = Organisation.org_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvEmployee.DataSource = dataSet.Tables[0];
            this.dgvEmployee.Columns[0].Visible = false;
        }

        // Search by query
        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            // Get field for search
            //
            // HeaderText and Name of the columns are different, so
            // we need to get actual Name of selected column
            //

            // Field parser
            string strFieldForSearch = this.employeeSearchColsListBox.SelectedItem.ToString();
            int iColIndex = 0;
            for (int i = 0; i < dgvEmployee.Columns.Count; ++i)
            {
                if (dgvEmployee.Columns[i].HeaderText == strFieldForSearch)
                {
                    iColIndex = i;
                }
            }

            // Start searching only if user has entered query for search
            if (this.employeeSearchQueryTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.employeeSearchQueryTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvEmployee.Rows)
                {
                    if (row.Cells[iColIndex].Value.ToString().Contains(query))
                    {
                        this.dgvEmployee.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        this.dgvEmployee.CurrentCell = null;
                        this.dgvEmployee.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnEmployeeShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvEmployee.Rows)
            {
                this.dgvEmployee.Rows[row.Index].Visible = true;
            }
        }

        // Enable sort button
        private void employeeSortColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEmployeeSort.Enabled = true;
        }

        // Get field for employee sorting
        private void btnEmployeeSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.employeeSortColsListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvEmployee.Columns[1];
                    break;
                case 1:
                    col = this.dgvEmployee.Columns[2];
                    break;
                case 2:
                    col = this.dgvEmployee.Columns[3];
                    break;
                case 3:
                    col = this.dgvEmployee.Columns[4];
                    break;
                case 4:
                    col = this.dgvEmployee.Columns[5];
                    break;
                case 5:
                    col = this.dgvEmployee.Columns[6];
                    break;
                default:
                    break;
            }

            // Get selected choice for sorting
            if (this.ascEmployeeRadioButton.Checked)
            {
                this.dgvEmployee.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descEmployeeRadioButton.Checked)
            {
                this.dgvEmployee.Sort(col, ListSortDirection.Descending);
            }
        }

        // Add employee button
        private void btnAddEmployeeForm_Click(object sender, EventArgs e)
        {
            // Pass data to UpdateBookingForm
            Form addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.FormClosed += new FormClosedEventHandler(this.handleEmployeeForms_FormClosed);
            addEmployeeForm.Show();
        }

        // Update employee button
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно изменить данные только одного сотрудника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvEmployee.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvEmployee.SelectedCells[0].RowIndex;

                if ((UserData.UserRole == "organisation" &&
                    this.dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString() == UserData.UserName) ||
                    UserData.UserRole == "admin")
                {
                    string employeeId = this.dgvEmployee.Rows[rowIndex].Cells[0].Value.ToString();
                    string orgName = this.dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                    string fio = this.dgvEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                    string gender = this.dgvEmployee.Rows[rowIndex].Cells[3].Value.ToString();
                    string position = this.dgvEmployee.Rows[rowIndex].Cells[4].Value.ToString();
                    string phoneNumber = this.dgvEmployee.Rows[rowIndex].Cells[5].Value.ToString();
                    string email = this.dgvEmployee.Rows[rowIndex].Cells[6].Value.ToString();

                    // Pass data to UpdateBookingForm
                    Form updateEmployeeForm = new UpdateEmployeeForm(employeeId, orgName, fio, gender, position, phoneNumber, email);
                    updateEmployeeForm.FormClosed += new FormClosedEventHandler(this.handleEmployeeForms_FormClosed);
                    updateEmployeeForm.Show();
                }
                else
                {
                    MessageBox.Show("Выбран чужой сотрудник!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete employee button
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.SelectedCells.Count > 1)
            {
                MessageBox.Show("Изменить можно только одну аренду за раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvEmployee.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvEmployee.SelectedCells[0].RowIndex;

                // Open DB connection
                sqlConnection.Open();

                // Initialize params
                try
                {
                    sqlCmdDeleteEmployee.Parameters["@org_name"].Value = this.dgvEmployee.Rows[rowIndex].Cells[0].Value.ToString();
                    sqlCmdDeleteEmployee.Parameters["@fio"].Value = this.dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                    sqlCmdDeleteEmployee.Parameters["@gender"].Value = this.dgvEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                    sqlCmdDeleteEmployee.Parameters["@position"].Value = this.dgvEmployee.Rows[rowIndex].Cells[3].Value.ToString();
                    sqlCmdDeleteEmployee.Parameters["@phone_number"].Value = this.dgvEmployee.Rows[rowIndex].Cells[4].Value.ToString();
                    sqlCmdDeleteEmployee.Parameters["@email"].Value = this.dgvEmployee.Rows[rowIndex].Cells[5].Value.ToString();

                    // Call proc
                    int iAffectedRowsCount = sqlCmdDeleteEmployee.ExecuteNonQuery();

                    // Show corresponding information
                    if (iAffectedRowsCount == 0)
                    {
                        MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillEmployeesDGV();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close DB connection
                sqlConnection.Close();
            }
        }

        private void handleEmployeeForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillEmployeesDGV();
        }

        ////// Trade profile panel //////

        // Get info about employees
        private void FillTradeProfilesDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT trade_profile_name FROM TradeProfile";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvTradeProfile.ReadOnly = true;
            this.dgvTradeProfile.DataSource = dataSet.Tables[0];
        }

        private void btnTradeProfileSearch_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.tradeProfileSearchQueryTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.tradeProfileSearchQueryTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvTradeProfile.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(query))
                    {
                        this.dgvTradeProfile.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        this.dgvTradeProfile.CurrentCell = null;
                        this.dgvTradeProfile.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnTradeProfileShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvTradeProfile.Rows)
            {
                this.dgvTradeProfile.Rows[row.Index].Visible = true;
            }
        }

        private void btnTradeProfileSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = this.dgvTradeProfile.Columns[0];

            // Get selected choice for sorting
            if (this.ascTradeProfileRadioButton.Checked)
            {
                this.dgvTradeProfile.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descTradeProfileRadioButton.Checked)
            {
                this.dgvTradeProfile.Sort(col, ListSortDirection.Descending);
            }
        }

        private void btnHandleTradeProfileForm_Click(object sender, EventArgs e)
        {
            Form form = new HandleTradeProfileForm();
            form.Show();
        }

        ////// Outlet panel //////

        // Get info about employees
        private void FillOutletsDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "Organisation.org_name AS [Организация]," +
                                     "Outlet.area_id AS [Код помещения]," +
                                     "Outlet.outlet_name AS [Название торговой точки]," +
                                     "Outlet.trade_profile_name AS [Торговая точка]," +
                                     "Outlet.timetable AS [Расписание]," +
                                     "Outlet.rating AS [Рейтинг]," +
                                     "Outlet.contact_person AS [Контактное лицо] " +
                                 "FROM Outlet " +
                                 "JOIN Organisation ON Outlet.org_id = Organisation.org_id";
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

        private void btnOutletSearch_Click(object sender, EventArgs e)
        {
            // Field parser
            string strFieldForSearch = this.outletSearchColsListBox.SelectedItem.ToString();
            int iColIndex = 0;
            for (int i = 0; i < this.dgvOutlet.Columns.Count; ++i)
            {
                if (this.dgvOutlet.Columns[i].HeaderText == strFieldForSearch)
                {
                    iColIndex = i;
                }
            }

            // Start searching only if user has entered query for search
            if (this.outletSearchQueryTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.outletSearchQueryTextBox.Text);
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

        private void btnOutletShowAll_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                this.dgvOutlet.Rows[row.Index].Visible = true;
            }
        }

        private void outletSortColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOutletSort.Enabled = true;
        }

        private void btnOutletSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.outletSortColsListBox.SelectedIndex)
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
                case 5:
                    col = this.dgvOutlet.Columns[5];
                    break;
                case 6:
                    col = this.dgvOutlet.Columns[6];
                    break;
                case 7:
                    col = this.dgvOutlet.Columns[7];
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

        private void btnHandleOutletForm_Click(object sender, EventArgs e)
        {
            Form form = new HandleOutletForm();
            form.Show();
        }
    }
}
