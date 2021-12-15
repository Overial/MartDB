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
            this.listPanel.Add(this.panelOrg);
            
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
            UpdateExistingBookingDates();
            FillBookingDGV();

            // Fill employees data grid view
            FillEmployeesDGV();

            // Fill trade profiles data grid view
            FillTradeProfilesDGV();

            // Fill outlet data grid view
            UpdateAllOutletsRatings();
            FillOutletsDGV();

            // Fill org data grid view
            FillOrgsDGV();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;

            if (UserData.UserRole == "organisation")
            {
                this.btnPanelOrg.Visible = false;
            }
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

            if (UserData.UserRole == "admin")
            {
                this.btnPanelOrg.Visible = true;
            }

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void btnPanelOrganisation_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 6;

            // Bring booking handling panel to front
            this.panelOrg.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            this.btnPanelOrg.Visible = false;

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

            if (UserData.UserRole == "admin")
            {
                this.btnPanelOrg.Visible = true;
            }

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

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

            this.btnPanelOrg.Visible = false;

            // Show nav buttons
            this.btnPanelMain.Visible = true;
            this.btnNextPanel.Visible = true;
            this.btnPreviousPanel.Visible = true;
        }

        private void orgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 6;
            this.panelOrg.BringToFront();

            // Bring nav buttons to front
            this.btnPanelMain.BringToFront();
            this.btnNextPanel.BringToFront();
            this.btnPreviousPanel.BringToFront();

            this.btnPanelOrg.Visible = false;

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
            FillAreaDGV();

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
                                  "Booking.booking_start_date AS [Начало периода аренды]," +
                                  "Booking.booking_end_date AS [Конец периода аренды]," +
                                  "Booking.cost AS [Стоимость аренды]," +
                                  "Area.area_id AS [Код помещения]," +
                                  "Area.area_square AS [Площадь помещения]," +
                                  "Area.floor_number AS [Номер этажа] " +
                            "FROM Booking " +
                            "JOIN Organisation ON Booking.org_id = Organisation.org_id " +
                            "JOIN Area ON Booking.area_id = Area.area_id";
            }
            else if (UserData.UserRole == "organisation")
            {
                selectQuery = "SELECT " +
                                  "Booking.booking_id," +
                                  "Organisation.org_name AS [Название организации]," +
                                  "Booking.booking_start_date AS [Начало периода аренды]," +
                                  "Booking.booking_end_date AS [Конец периода аренды]," +
                                  "Booking.cost AS [Стоимость аренды]," +
                                  "Area.area_id AS [Код помещения]," +
                                  "Area.area_square AS [Площадь помещения]," +
                                  "Area.floor_number AS [Номер этажа] " +
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

            FillBookingDGV();

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
                string bookingId = Convert.ToString(this.dgvBooking.Rows[rowIndex].Cells[0].Value);
                string orgName = this.dgvBooking.Rows[rowIndex].Cells[1].Value.ToString();
                string areaId = Convert.ToString(this.dgvBooking.Rows[rowIndex].Cells[5].Value);
                string bookingStartDate = this.dgvBooking.Rows[rowIndex].Cells[2].Value.ToString();
                string bookingEndDate = this.dgvBooking.Rows[rowIndex].Cells[3].Value.ToString();

                // Pass data to UpdateBookingForm
                Form updateBookingForm = new UpdateBookingForm(bookingId, orgName, areaId, bookingStartDate, bookingEndDate);
                updateBookingForm.FormClosed += new FormClosedEventHandler(this.handleBookingForms_FormClosed);
                updateBookingForm.Show();
            }
        }

        void UpdateExistingBookingDates()
        {
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

        // Refresh booking table after any manipulations with it
        private void handleBookingForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillBookingDGV();
            UpdateExistingBookingDates();
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
            FillEmployeesDGV();

            // Display every row
            foreach (DataGridViewRow row in this.dgvEmployee.Rows)
            {
                this.dgvEmployee.Rows[row.Index].Visible = true;
            }
        }

        private void employeeSearchColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEmployeeSearch.Enabled = true;
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
                MessageBox.Show("За раз можно удалить данные только одного сотрудника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvEmployee.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvEmployee.SelectedCells[0].RowIndex;

                if ((UserData.UserRole == "organisation" &&
                    this.dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString() == UserData.UserName) ||
                    UserData.UserRole == "admin")
                {
                    // Open DB connection
                    sqlConnection.Open();

                    // Initialize params
                    try
                    {
                        sqlCmdProcDeleteEmployee.Parameters["@org_name"].Value = this.dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString();
                        sqlCmdProcDeleteEmployee.Parameters["@fio"].Value = this.dgvEmployee.Rows[rowIndex].Cells[2].Value.ToString();
                        sqlCmdProcDeleteEmployee.Parameters["@gender"].Value = this.dgvEmployee.Rows[rowIndex].Cells[3].Value.ToString();
                        sqlCmdProcDeleteEmployee.Parameters["@position"].Value = this.dgvEmployee.Rows[rowIndex].Cells[4].Value.ToString();
                        sqlCmdProcDeleteEmployee.Parameters["@phone_number"].Value = this.dgvEmployee.Rows[rowIndex].Cells[5].Value.ToString();
                        sqlCmdProcDeleteEmployee.Parameters["@email"].Value = this.dgvEmployee.Rows[rowIndex].Cells[6].Value.ToString();

                        // Call proc
                        int iAffectedRowsCount = sqlCmdProcDeleteEmployee.ExecuteNonQuery();

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
                else
                {
                    MessageBox.Show("Выбран чужой сотрудник!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            string selectQuery = "SELECT " +
                                     "trade_profile_id," +
                                     "trade_profile_name AS [Название торгового профиля] " +
                                 "FROM TradeProfile";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvTradeProfile.DataSource = dataSet.Tables[0];
            this.dgvTradeProfile.Columns[0].Visible = false;
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
                    if (row.Cells[1].Value.ToString().Contains(query))
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
            FillTradeProfilesDGV();

            // Display every row
            foreach (DataGridViewRow row in this.dgvTradeProfile.Rows)
            {
                this.dgvTradeProfile.Rows[row.Index].Visible = true;
            }
        }

        private void btnTradeProfileSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = this.dgvTradeProfile.Columns[1];

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

        private void btnAddTradeProfileForm_Click(object sender, EventArgs e)
        {
            Form addTradeProfileForm = new AddTradeProfileForm();
            addTradeProfileForm.FormClosed += new FormClosedEventHandler(this.handleTradeProfileForms_FormClosed);
            addTradeProfileForm.Show();
        }

        private void btnUpdateTradeProfileForm_Click(object sender, EventArgs e)
        {
            if (this.dgvTradeProfile.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно изменить данные только одного торгового профиля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvTradeProfile.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvTradeProfile.SelectedCells[0].RowIndex;

                string tradeProfileId = this.dgvTradeProfile.Rows[rowIndex].Cells[0].Value.ToString();
                string tradeProfileName = this.dgvTradeProfile.Rows[rowIndex].Cells[1].Value.ToString();

                // Pass data to UpdateBookingForm
                Form updateTradeProfileForm = new UpdateTradeProfileForm(tradeProfileId, tradeProfileName);
                updateTradeProfileForm.FormClosed += new FormClosedEventHandler(this.handleTradeProfileForms_FormClosed);
                updateTradeProfileForm.Show();
            }
        }

        private void btnDeleteTradeProfile_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно удалить данные только одного торгового профиля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvEmployee.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvEmployee.SelectedCells[0].RowIndex;

                // Open DB connection
                sqlConnection.Open();

                // Initialize params
                try
                {
                    sqlCmdProcDeleteTradeProfile.Parameters["@trade_profile_id"].Value = this.dgvTradeProfile.Rows[rowIndex].Cells[0].Value.ToString();

                    // Call proc
                    int iAffectedRowsCount = sqlCmdProcDeleteTradeProfile.ExecuteNonQuery();

                    // Show corresponding information
                    if (iAffectedRowsCount == 0)
                    {
                        MessageBox.Show("Удаление данных завершилось с ошибкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FillTradeProfilesDGV();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введены некорректные значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Удаление данных завершилось с ошибкой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void handleTradeProfileForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillTradeProfilesDGV();
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
                                     "Outlet.outlet_id," +
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

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvOutlet.DataSource = dataSet.Tables[0];
            this.dgvOutlet.Columns[0].Visible = false;
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
            FillOutletsDGV();

            // Display every row
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                this.dgvOutlet.Rows[row.Index].Visible = true;
            }
        }

        private void outletSearchColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOutletSearch.Enabled = true;
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
                    col = this.dgvOutlet.Columns[1];
                    break;
                case 1:
                    col = this.dgvOutlet.Columns[2];
                    break;
                case 2:
                    col = this.dgvOutlet.Columns[3];
                    break;
                case 3:
                    col = this.dgvOutlet.Columns[4];
                    break;
                case 4:
                    col = this.dgvOutlet.Columns[5];
                    break;
                case 5:
                    col = this.dgvOutlet.Columns[6];
                    break;
                case 6:
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

        private void btnAddOutletForm_Click(object sender, EventArgs e)
        {
            // Pass data to AddOutletForm
            Form addOutletForm = new AddOutletForm();
            addOutletForm.FormClosed += new FormClosedEventHandler(this.handleOutletForms_FormClosed);
            addOutletForm.Show();
        }

        private void btnUpdateOutletForm_Click(object sender, EventArgs e)
        {
            if (this.dgvOutlet.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно изменить данные только одной торговой точки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvOutlet.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvOutlet.SelectedCells[0].RowIndex;

                if ((UserData.UserRole == "organisation" &&
                    this.dgvOutlet.Rows[rowIndex].Cells[1].Value.ToString() == UserData.UserName) ||
                    UserData.UserRole == "admin")
                {
                    string outletId = this.dgvOutlet.Rows[rowIndex].Cells[0].Value.ToString();
                    string orgName = this.dgvOutlet.Rows[rowIndex].Cells[1].Value.ToString();
                    string areaId = this.dgvOutlet.Rows[rowIndex].Cells[2].Value.ToString();
                    string outletName = this.dgvOutlet.Rows[rowIndex].Cells[3].Value.ToString();
                    string tradeProfileName = this.dgvOutlet.Rows[rowIndex].Cells[4].Value.ToString();
                    string timetable = this.dgvOutlet.Rows[rowIndex].Cells[5].Value.ToString();
                    string rating = this.dgvOutlet.Rows[rowIndex].Cells[6].Value.ToString();
                    string contact_person = this.dgvOutlet.Rows[rowIndex].Cells[7].Value.ToString();

                    // Pass data to UpdateBookingForm
                    Form updateOutletForm = new UpdateOutletForm(outletId, orgName, areaId, outletName, tradeProfileName, timetable, rating, contact_person);
                    updateOutletForm.FormClosed += new FormClosedEventHandler(this.handleOutletForms_FormClosed);
                    updateOutletForm.Show();
                }
                else
                {
                    MessageBox.Show("Выбрана чужая торговая точка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteOutlet_Click(object sender, EventArgs e)
        {
            if (this.dgvOutlet.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно удалить данные только одной торговой точки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvOutlet.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvOutlet.SelectedCells[0].RowIndex;

                if ((UserData.UserRole == "organisation" &&
                   this.dgvOutlet.Rows[rowIndex].Cells[1].Value.ToString() == UserData.UserName) ||
                   UserData.UserRole == "admin")
                {
                    // Open DB connection
                    sqlConnection.Open();

                    // Initialize params
                    try
                    {
                        sqlCmdProcDeleteOutlet.Parameters["@outlet_id"].Value = this.dgvOutlet.Rows[rowIndex].Cells[0].Value.ToString();

                        // Call proc
                        int iAffectedRowsCount = sqlCmdProcDeleteOutlet.ExecuteNonQuery();

                        // Show corresponding information
                        if (iAffectedRowsCount == 0)
                        {
                            MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UpdateAllOutletsRatings();
                            FillOutletsDGV();
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введены некорректные значения!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Выбрана чужая торговая точка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateOutletRating(string outletName)
        {
            // Open DB connection
            if (this.sqlConnection.State == ConnectionState.Closed)
            {
                this.sqlConnection.Open();
            }

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
                    // MessageBox.Show("Обновление рейтингов завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (SqlException)
            {
                MessageBox.Show("Обновление рейтингов завершилось с ошибкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void UpdateAllOutletsRatings()
        {
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                string outletName = row.Cells[3].Value.ToString();
                UpdateOutletRating(outletName);
            }
        }

        private void handleOutletForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateAllOutletsRatings();
            FillOutletsDGV();
        }

        ////// Org panel //////

        // Get info about employees
        private void FillOrgsDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "org_id," +
                                     "org_name AS [Организация]," +
                                     "country AS [Страна]," +
                                     "payment_terms AS [Тип оплаты]," +
                                     "delivery_method AS [Метод доставки]," +
                                     "contact_person AS [Контактное лицо] " +
                                 "FROM Organisation ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            this.dgvOrg.DataSource = dataSet.Tables[0];
            this.dgvOrg.Columns[0].Visible = false;
        }

        private void btnOrgSearch_Click(object sender, EventArgs e)
        {
            // Field parser
            string strFieldForSearch = this.orgSearchColsListBox.SelectedItem.ToString();
            int iColIndex = 0;
            for (int i = 0; i < this.dgvOrg.Columns.Count; ++i)
            {
                if (this.dgvOrg.Columns[i].HeaderText == strFieldForSearch)
                {
                    iColIndex = i;
                }
            }

            // Start searching only if user has entered query for search
            if (this.orgSearchQueryTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.orgSearchQueryTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvOrg.Rows)
                {
                    if (row.Cells[iColIndex].Value.ToString().Contains(query))
                    {
                        this.dgvOrg.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        this.dgvOrg.CurrentCell = null;
                        this.dgvOrg.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnOrgShowAll_Click(object sender, EventArgs e)
        {
            FillOrgsDGV();

            // Display every row
            foreach (DataGridViewRow row in this.dgvOrg.Rows)
            {
                this.dgvOrg.Rows[row.Index].Visible = true;
            }
        }

        private void orgSearchColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOrgSearch.Enabled = true;
        }

        private void orgSortColsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOrgSort.Enabled = true;
        }

        private void btnOrgSort_Click(object sender, EventArgs e)
        {
            // Col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.orgSortColsListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvOrg.Columns[1];
                    break;
                case 1:
                    col = this.dgvOrg.Columns[2];
                    break;
                case 2:
                    col = this.dgvOrg.Columns[3];
                    break;
                case 3:
                    col = this.dgvOrg.Columns[4];
                    break;
                case 4:
                    col = this.dgvOrg.Columns[5];
                    break;
                default:
                    break;
            }

            // Get selected choice for sorting
            if (this.ascOrgRadioButton.Checked)
            {
                this.dgvOrg.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descOrgRadioButton.Checked)
            {
                this.dgvOrg.Sort(col, ListSortDirection.Descending);
            }
        }

        private void btnAddOrgForm_Click(object sender, EventArgs e)
        {
            // Pass data to AddOutletForm
            Form addOrgForm = new AddOrgForm();
            addOrgForm.FormClosed += new FormClosedEventHandler(this.handleOrgForms_FormClosed);
            addOrgForm.Show();
        }

        private void btnUpdateOrgForm_Click(object sender, EventArgs e)
        {
            if (this.dgvOrg.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно изменить данные только одной организации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvOrg.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvOrg.SelectedCells[0].RowIndex;

                string orgId = this.dgvOrg.Rows[rowIndex].Cells[0].Value.ToString();
                string orgName = this.dgvOrg.Rows[rowIndex].Cells[1].Value.ToString();
                string country = this.dgvOrg.Rows[rowIndex].Cells[2].Value.ToString();
                string payment_terms = this.dgvOrg.Rows[rowIndex].Cells[3].Value.ToString();
                string delivery_method = this.dgvOrg.Rows[rowIndex].Cells[4].Value.ToString();
                string contact_person = this.dgvOrg.Rows[rowIndex].Cells[5].Value.ToString();

                // Pass data to UpdateBookingForm
                Form updateOutletForm = new UpdateOrgForm(orgId, orgName, country, payment_terms, delivery_method, contact_person);
                updateOutletForm.FormClosed += new FormClosedEventHandler(this.handleOutletForms_FormClosed);
                updateOutletForm.Show();
            }
        }

        private void btnDeleteOrg_Click(object sender, EventArgs e)
        {
            if (this.dgvOrg.SelectedCells.Count > 1)
            {
                MessageBox.Show("За раз можно удалить данные только одной организации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.dgvOrg.SelectedCells.Count == 1)
            {
                int rowIndex = this.dgvOrg.SelectedCells[0].RowIndex;

                // Open DB connection
                sqlConnection.Open();

                // Initialize params
                try
                {
                    sqlCmdProcDeleteOrg.Parameters["@org_id"].Value = this.dgvOrg.Rows[rowIndex].Cells[0].Value.ToString();

                    // Call proc
                    int iAffectedRowsCount = sqlCmdProcDeleteOrg.ExecuteNonQuery();

                    // Show corresponding information
                    if (iAffectedRowsCount == 0)
                    {
                        MessageBox.Show("Удаление данных завершилось с ошибкой!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Данные успешно удалены!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FillOrgsDGV();
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

        private void handleOrgForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillOrgsDGV();
        }
    }
}
