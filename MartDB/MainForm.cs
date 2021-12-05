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
        // ...

        public MainForm()
        {
            InitializeComponent();

            // Set start position to center
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Actions on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Turning pages functionality
            this.listPanel.Add(this.panelMain);
            this.listPanel.Add(this.panelBookingHandling);
            this.listPanel.Add(this.panelEmployees);
            this.listPanel.Add(this.panelTradeProfiles);
            
            // Show first panel
            this.listPanel[this.index].BringToFront();

            // Adjust form for organisations
            if (UserData.UserRole == "organisation")
            {
                this.btnCallHandleBookingForm.Enabled = false;
            }

            // Fill area and booking data grid view
            FillAreaAndBookingDGV();

            // Fill employees data grid view
            FillEmployeesDGV();

            // Fill trade profiles data grid view
            FillTradeProfileDGV();

            // Fill outlet data grid view
            FillOutletDGV();

            // TODO: This line of code loads data into the 'martDBDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.martDBDataSet.Area);
            // TODO: This line of code loads data into the 'martDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.martDBDataSet.Booking);
            // TODO: This line of code loads data into the 'martDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.martDBDataSet.Employee);
        }

        ////// Nav buttons //////

        // Turn back
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // While it's not the beginning and not the main panel
            if (this.index > 1)
            {
                this.listPanel[--this.index].BringToFront();
            }
        }

        // Turn forward
        private void btnNext_Click(object sender, EventArgs e)
        {
            // While it's not the end
            if (this.index < this.listPanel.Count - 1)
            {
                this.listPanel[++this.index].BringToFront();
            }
        }

        ////// Main panel buttons //////

        // Move to main panel
        private void btnMoveToMain_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 0;

            // Bring main panel to front
            this.panelMain.BringToFront();

            // Hide nav buttons
            this.btnMoveToPanelMain.Visible = false;
            this.btnNext.Visible = false;
            this.btnPrevious.Visible = false;
        }

        // Move to area panel
        private void btnBookingHandling_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 1;

            // Bring booking handling panel to front
            this.panelBookingHandling.BringToFront();

            // Bring nav buttons to front
            this.btnMoveToPanelMain.BringToFront();
            this.btnNext.BringToFront();
            this.btnPrevious.BringToFront();

            // Show nav buttons
            this.btnMoveToPanelMain.Visible = true;
            this.btnNext.Visible = true;
            this.btnPrevious.Visible = true;
        }

        private void btnEmployeePanel_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 2;

            // Bring booking handling panel to front
            this.panelEmployees.BringToFront();

            // Bring nav buttons to front
            this.btnMoveToPanelMain.BringToFront();
            this.btnNext.BringToFront();
            this.btnPrevious.BringToFront();

            // Show nav buttons
            this.btnMoveToPanelMain.Visible = true;
            this.btnNext.Visible = true;
            this.btnPrevious.Visible = true;
        }

        private void btnTradeProfilePanel_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 3;

            // Bring booking handling panel to front
            this.panelTradeProfiles.BringToFront();

            // Bring nav buttons to front
            this.btnMoveToPanelMain.BringToFront();
            this.btnNext.BringToFront();
            this.btnPrevious.BringToFront();

            // Show nav buttons
            this.btnMoveToPanelMain.Visible = true;
            this.btnNext.Visible = true;
            this.btnPrevious.Visible = true;
        }

        private void btnOutletPanel_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 4;

            // Bring booking handling panel to front
            this.panelOutlets.BringToFront();

            // Bring nav buttons to front
            this.btnMoveToPanelMain.BringToFront();
            this.btnNext.BringToFront();
            this.btnPrevious.BringToFront();

            // Show nav buttons
            this.btnMoveToPanelMain.Visible = true;
            this.btnNext.Visible = true;
            this.btnPrevious.Visible = true;
        }

        ////// Menu strip //////

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 0;
            this.panelMain.BringToFront();
        }

        private void bookingHandlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelBookingHandling.BringToFront();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 2;
            this.panelEmployees.BringToFront();
        }

        private void tradeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 3;
            this.panelTradeProfiles.BringToFront();
        }

        private void outletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 4;
            this.panelOutlets.BringToFront();
        }

        // About (menuStrip)
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ////// Booking handling panel //////

        // Get info about areas and bookings
        private void FillAreaAndBookingDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT " +
                                     "area_square AS [Площадь помещения]," +
                                     "floor_number AS [Номер этажа]," +
                                     "cost AS [Стоимость аренды]," +
                                     "booking_start_date AS [Начало периода аренды]," +
                                     "booking_end_date AS [Конец периода аренды]" +
                                 "FROM Booking " +
                                 "JOIN Area ON Booking.area_id = Area.area_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            dgvBookingHandling.ReadOnly = true;
            dgvBookingHandling.DataSource = dataSet.Tables[0];
        }

        // Enable button only if field for sort is selected
        private void listBoxFieldsForSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSort.Enabled = true;
        }

        // Button to initiate sorting
        private void btnSortBookings_Click(object sender, EventArgs e)
        {
            // col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.listBoxFieldsForSort.SelectedIndex)
            {
                case 0:
                    col = this.dgvBookingHandling.Columns[0];
                    break;
                case 1:
                    col = this.dgvBookingHandling.Columns[1];
                    break;
                case 2:
                    col = this.dgvBookingHandling.Columns[2];
                    break;
                case 3:
                    col = this.dgvBookingHandling.Columns[3];
                    break;
                case 4:
                    col = this.dgvBookingHandling.Columns[4];
                    break;
            }

            // Get selected choice for sorting
            if (this.radioButtonAsc.Checked)
            {
                dgvBookingHandling.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.radioButtonDesc.Checked)
            {
                dgvBookingHandling.Sort(col, ListSortDirection.Descending);
            }
        }

        // Enable button only if field for search is selected
        private void listBoxFieldsForSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSearchSquare.Enabled = true;
        }

        // Button to initiate searchin'
        private void btnSearchSquare_Click(object sender, EventArgs e)
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
            if (this.leftSquareBoundTextBox.Text.Length > 0 && this.rightSquareBoundtextBox.Text.Length > 0)
            {
                string leftBound = "";
                string rightBound = "";
                try
                {
                    leftBound = Convert.ToString(this.leftSquareBoundTextBox.Text);
                    rightBound = Convert.ToString(this.rightSquareBoundtextBox.Text);
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
                foreach (DataGridViewRow row in this.dgvBookingHandling.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= Convert.ToInt32(leftBound) &&
                        Convert.ToInt32(row.Cells[0].Value) <= Convert.ToInt32(rightBound))
                    {
                        dgvBookingHandling.Rows[row.Index].Visible = true;
                        // dgvBookingHandling.Rows[row.Index].Selected = true;
                    }
                    else
                    {
                        dgvBookingHandling.CurrentCell = null;
                        dgvBookingHandling.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        // Seaching by floor button
        private void btnFloorSearch_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.leftFloorBoundTextBox.Text.Length > 0 && this.rightFloorBoundTextBox.Text.Length > 0)
            {
                string leftBound = "";
                string rightBound = "";
                try
                {
                    leftBound = Convert.ToString(this.leftFloorBoundTextBox.Text);
                    rightBound = Convert.ToString(this.rightFloorBoundTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvBookingHandling.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) >= Convert.ToInt32(leftBound) &&
                        Convert.ToInt32(row.Cells[1].Value) <= Convert.ToInt32(rightBound))
                    {
                        dgvBookingHandling.Rows[row.Index].Visible = true;
                        // dgvBookingHandling.Rows[row.Index].Selected = true;
                    }
                    else
                    {
                        dgvBookingHandling.CurrentCell = null;
                        dgvBookingHandling.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        // Button to show all data
        private void btnShowAllBookings_Click(object sender, EventArgs e)
        {
            // this.areaBindingSource.Filter = "";

            // dgvBookingHandling.Rows[0].Selected = true;

            // Display every row
            foreach (DataGridViewRow row in this.dgvBookingHandling.Rows)
            {
                dgvBookingHandling.Rows[row.Index].Visible = true;
            }
        }

        // Move to booking handling form
        private void btnCallHandleBookingForm_Click(object sender, EventArgs e)
        {
            Form handleBookingForm = new HandleBookingForm();
            handleBookingForm.Show();
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
                                     "Organisation.org_name AS [Организация]," +
                                     "Employee.fio AS [ФИО]," +
                                     "Employee.gender AS [Пол]," +
                                     "Employee.position AS [Должность]," +
                                     "Employee.phone_number AS [Телефонный номер]," +
                                     "Employee.email AS [Электронная почта] " +
                                 "FROM Employee " +
                                 "JOIN Organisation ON Employee.org_id = Organisation.area_id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);

            // Set command builder
            // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            // Fill data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Fill DGV
            dgvEmployees.ReadOnly = true;
            dgvEmployees.DataSource = dataSet.Tables[0];
        }

        // Search by query
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            // Get field for search
            //
            // HeaderText and Name of the columns are different, so
            // we need to get actual Name of selected column
            //

            // Field parser
            string strFieldForSearch = this.queryEmployeeColListBox.SelectedItem.ToString();
            int iColIndex = 0;
            for (int i = 0; i < dgvEmployees.Columns.Count; ++i)
            {
                if (dgvEmployees.Columns[i].HeaderText == strFieldForSearch)
                {
                    iColIndex = i;
                }
            }

            // Start searching only if user has entered query for search
            if (this.queryEmployeeTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.queryEmployeeTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Filter area square data
                foreach (DataGridViewRow row in this.dgvEmployees.Rows)
                {
                    if (row.Cells[iColIndex].Value.ToString().Contains(query))
                    {
                        dgvEmployees.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        dgvEmployees.CurrentCell = null;
                        dgvEmployees.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvEmployees.Rows)
            {
                dgvEmployees.Rows[row.Index].Visible = true;
            }
        }

        // Enable sort button
        private void sortFieldsEmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSortEmployees.Enabled = true;
        }

        // Get field for employee sorting
        private void btnSortEmployees_Click(object sender, EventArgs e)
        {
            // col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.sortFieldsEmployeesListBox.SelectedIndex)
            {
                case 0:
                    col = this.dgvEmployees.Columns[0];
                    break;
                case 1:
                    col = this.dgvEmployees.Columns[1];
                    break;
                case 2:
                    col = this.dgvEmployees.Columns[2];
                    break;
                case 3:
                    col = this.dgvEmployees.Columns[3];
                    break;
                case 4:
                    col = this.dgvEmployees.Columns[4];
                    break;
                case 5:
                    col = this.dgvEmployees.Columns[5];
                    break;
            }

            // Get selected choice for sorting
            if (this.ascEmployeeRadioButton.Checked)
            {
                dgvEmployees.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descEmployeeRadioButton.Checked)
            {
                dgvEmployees.Sort(col, ListSortDirection.Descending);
            }
        }

        private void btnMoveToHandleEmployeesForm_Click(object sender, EventArgs e)
        {
            Form form = new HandleEmployeeForm();
            form.Show();
        }

        ////// Trade profile panel //////
        
        // Get info about employees
        private void FillTradeProfileDGV()
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
            dgvTradeProfile.ReadOnly = true;
            dgvTradeProfile.DataSource = dataSet.Tables[0];
        }

        private void btnSearchTradeProfile_Click(object sender, EventArgs e)
        {
            // Start searching only if user has entered query for search
            if (this.queryTradeProfileTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.queryTradeProfileTextBox.Text);
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
                        dgvTradeProfile.Rows[row.Index].Visible = true;
                    }
                    else
                    {
                        dgvTradeProfile.CurrentCell = null;
                        dgvTradeProfile.Rows[row.Index].Visible = false;
                    }
                }
            }
        }

        private void btnShowAllTradeProfiles_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvTradeProfile.Rows)
            {
                dgvTradeProfile.Rows[row.Index].Visible = true;
            }
        }

        private void btnSortTradeProfile_Click(object sender, EventArgs e)
        {
            // col to sort
            DataGridViewColumn col = this.dgvTradeProfile.Columns[0];

            // Get selected choice for sorting
            if (this.ascTradeProfileRadioButton.Checked)
            {
                dgvTradeProfile.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.descTradeProfileRadioButton.Checked)
            {
                dgvTradeProfile.Sort(col, ListSortDirection.Descending);
            }
        }

        private void btnMoveToHandlingTradeProfilesForm_Click(object sender, EventArgs e)
        {
            Form form = new HandleTradeProfileForm();
            form.Show();
        }

        ////// Outlet panel //////
        
        // Get info about employees
        private void FillOutletDGV()
        {
            // Establish connection
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            sqlConnection.Open();

            // Create query
            string selectQuery = "SELECT Organisation.org_name AS [Организация]," +
                                 "Outlet.area_id AS [Код помещения]," +
                                 "Outlet.outlet_name AS [Название торговой точки]," +
                                 "Outlet.outlet_type AS [Тип торговой точки]," +
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
            dgvOutlet.ReadOnly = true;
            dgvOutlet.DataSource = dataSet.Tables[0];
        }

        private void btnSearchOutlet_Click(object sender, EventArgs e)
        {
            // Field parser
            string strFieldForSearch = this.queryOutletFieldColBox.SelectedItem.ToString();
            int iColIndex = 0;
            for (int i = 0; i < dgvOutlet.Columns.Count; ++i)
            {
                if (dgvOutlet.Columns[i].HeaderText == strFieldForSearch)
                {
                    iColIndex = i;
                }
            }

            // Start searching only if user has entered query for search
            if (this.queryOutletTextBox.Text.Length > 0)
            {
                string query = "";
                try
                {
                    query = Convert.ToString(this.queryOutletTextBox.Text);
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

        private void btnShowAllOutlets_Click(object sender, EventArgs e)
        {
            // Display every row
            foreach (DataGridViewRow row in this.dgvOutlet.Rows)
            {
                dgvOutlet.Rows[row.Index].Visible = true;
            }
        }

        private void sortColsOutletListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSortOutlets.Enabled = true;
        }

        private void btnSortOutlets_Click(object sender, EventArgs e)
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
                case 5:
                    col = this.dgvOutlet.Columns[5];
                    break;
                case 6:
                    col = this.dgvOutlet.Columns[6];
                    break;
                case 7:
                    col = this.dgvOutlet.Columns[7];
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

        private void btnShowHandleOutletForm_Click(object sender, EventArgs e)
        {
            Form form = new HandleOutletForm();
            form.Show();
        }
    }
}
