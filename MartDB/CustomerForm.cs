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
            // Turning pages functionality
            this.listPanel.Add(this.panelMain);

            // Show first panel
            this.listPanel[this.index].BringToFront();
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
        }

        private void panelOutletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.index = 1;
            this.panelOutlet.BringToFront();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных ТЦ \"Тессеракт\"", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
