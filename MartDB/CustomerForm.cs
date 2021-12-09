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
        // List with panels
        List<Panel> listPanel = new List<Panel>();
        // For panel list indexing
        int index = 0;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Display user name info
            this.panelMainLabel.Text = "Добро пожаловать, " + UserData.UserName;
            
            // Turning pages functionality
            this.listPanel.Add(this.panelMain);

            // Show first panel
            this.listPanel[this.index].BringToFront();

            // Fill outlet data grid view
            FillOutletsDGV();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;
        }

        ////// Nav buttons //////
        
        private void btnPreviousPanel_Click(object sender, EventArgs e)
        {
            // While it's not the beginning and not the main panel
            if (this.index > 1)
            {
                this.listPanel[--this.index].BringToFront();
            }
        }

        private void btnNextPanel_Click(object sender, EventArgs e)
        {
            // While it's not the end
            if (this.index < this.listPanel.Count - 1)
            {
                this.listPanel[++this.index].BringToFront();
            }
        }

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
        
        private void btnPanelOutlet_Click(object sender, EventArgs e)
        {
            // Set panel index
            this.index = 1;

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

        private void panelMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 0;
            this.panelMain.BringToFront();

            // Hide nav buttons
            this.btnPanelMain.Visible = false;
            this.btnNextPanel.Visible = false;
            this.btnPreviousPanel.Visible = false;
        }

        private void panelOutletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
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

        ////// Outlet panel //////

        // Get info about employees
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
    }
}
