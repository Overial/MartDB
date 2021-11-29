using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        // (booking) Save button of the form
        private void bookingSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.bookingTableAdapterManager.UpdateAll(this.martDBDataSet);
        }

        // (employee) Save button of the form
        private void employeeSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.employeeTableAdapterManager.UpdateAll(this.martDBDataSet);
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
            this.panelBooking.BringToFront();
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
            // Col to sort
            DataGridViewColumn Col = default;

            // Get selected col to sort
            switch (this.listBoxFieldsForSort.SelectedIndex)
            {
                case 0:
                    Col = this.areaDataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = this.areaDataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = this.areaDataGridViewTextBoxColumn3;
                    break;
            }

            // Get selected choice for sorting
            if (this.radioButtonAsc.Checked)
            {
                areaDataGridView.Sort(Col, ListSortDirection.Ascending);
            }
            else if (this.radioButtonDesc.Checked)
            {
                areaDataGridView.Sort(Col, ListSortDirection.Descending);
            }
        }
    }
}
