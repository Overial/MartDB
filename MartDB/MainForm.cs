﻿using System;
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

        public MainForm()
        {
            InitializeComponent();

            // Set start position to center
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Save button of the form
        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.martDBDataSet);
        }

        // Actions on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Turning pages functionality
            this.listPanel.Add(this.panelMain);
            this.listPanel.Add(this.panelArea);
            this.listPanel.Add(this.panelBooking);
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

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelArea.BringToFront();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 2;
            this.panelBooking.BringToFront();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
