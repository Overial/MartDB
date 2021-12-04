using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Убрать навигаторы
// Опираться не на таблицы, а на функционал!!!
// Добавить различные функции и процедуры для функционала

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

        // (area) Save button of the form
        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.areaTableAdapterManager.UpdateAll(this.martDBDataSet);

            MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // (booking) Save button of the form
        private void bookingSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.bookingTableAdapterManager.UpdateAll(this.martDBDataSet);

            MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // (employee) Save button of the form
        private void employeeSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.employeeTableAdapterManager.UpdateAll(this.martDBDataSet);

            MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Actions on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'martDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.martDBDataSet.Employee);
            // Turning pages functionality
            this.listPanel.Add(this.panelMain);
            this.listPanel.Add(this.panelArea);
            this.listPanel.Add(this.panelBooking);
            this.listPanel.Add(this.panelEmployee);
            // Show first panel
            this.listPanel[this.index].BringToFront();

            // TODO: This line of code loads data into the 'martDBDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.martDBDataSet.Area);
            // TODO: This line of code loads data into the 'martDBDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.martDBDataSet.Booking);
        }

        // Turn back
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // While it's not the beginning
            if (this.index > 0)
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

        // Move to main panel
        private void btnMoveToMain_Click(object sender, EventArgs e)
        {
            this.index = 0;
            this.panelMain.BringToFront();
        }

        // Move to area panel
        private void btnMoveToPanelArea_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelArea.BringToFront();
        }

        // Move to booking panel
        private void btnMoveToBookingArea_Click(object sender, EventArgs e)
        {
            this.index = 2;
            this.panelBooking.BringToFront();
        }

        // Move to employee panel
        private void btnMoveToPanelEmployee_Click(object sender, EventArgs e)
        {
            this.index = 3;
            this.panelEmployee.BringToFront();
        }

        // Move to area panel (menuStrip)
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelArea.BringToFront();
        }

        // Move to booking panel (menuStrip)
        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 2;
            this.panelBooking.BringToFront();
        }

        // Move to booking panel (menuStrip)
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 3;
            this.panelEmployee.BringToFront();
        }

        // About (menuStrip)
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Enable button only if field for sort is selected
        private void listBoxFieldsForSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSort.Enabled = true;
        }

        // Button to initiate sorting
        private void btnSort_Click(object sender, EventArgs e)
        {
            // col to sort
            DataGridViewColumn col = default;

            // Get selected col to sort
            switch (this.listBoxFieldsForSort.SelectedIndex)
            {
                case 0:
                    col = this.areaDataGridViewTextBoxColumn1;
                    break;
                case 1:
                    col = this.areaDataGridViewTextBoxColumn2;
                    break;
                case 2:
                    col = this.areaDataGridViewTextBoxColumn3;
                    break;
            }

            // Get selected choice for sorting
            if (this.radioButtonAsc.Checked)
            {
                areaDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else if (this.radioButtonDesc.Checked)
            {
                areaDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        // Enable button only if field for search is selected
        private void listBoxFieldsForSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = true;
        }

        // Button to initiate searchin'
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get field for search
            //
            // HeaderText and Name of the columns are different, so
            // we need to get actual Name of selected column
            //
            string strFieldForSearch = this.listBoxFieldsForSearch.SelectedItem.ToString();
            string colForSearch = "";
            for (int i = 0; i < areaDataGridView.Columns.Count; ++i)
            {
                if (areaDataGridView.Columns[i].HeaderText == strFieldForSearch)
                {
                    colForSearch = areaDataGridView.Columns[i].DataPropertyName;
                }
            }

            // Start searching only if user has entered query for search
            if (this.queryForSearchTextBox.Text.Length > 0)
            {
                string queryForSearch = "";
                try
                {
                    queryForSearch = Convert.ToString(this.queryForSearchTextBox.Text);
                }
                // Prevent invalid user input
                catch
                {
                    MessageBox.Show("Введено некорректное значение запроса для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.queryForSearchTextBox.Clear();
                }

                // Filter data (approximate, not exact)
                this.areaBindingSource.Filter = string.Format("CONVERT(" + colForSearch + ", 'System.String') LIKE '%{0}%' ",
                                                              queryForSearch);
            }
        }

        // Button to show all data
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.areaBindingSource.Filter = "";
        }
    }
}
