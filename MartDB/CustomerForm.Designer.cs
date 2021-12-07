
namespace MartDB
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOutletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainLabel = new System.Windows.Forms.Label();
            this.btnNextPanel = new System.Windows.Forms.Button();
            this.btnPreviousPanel = new System.Windows.Forms.Button();
            this.btnPanelMain = new System.Windows.Forms.Button();
            this.btnPanelOutlet = new System.Windows.Forms.Button();
            this.panelOutlet = new System.Windows.Forms.Panel();
            this.btnUpdateDGVOutlet = new System.Windows.Forms.Button();
            this.btnShowOutletDetailsForm = new System.Windows.Forms.Button();
            this.sortOutletGroupBox = new System.Windows.Forms.GroupBox();
            this.sortColsOutletListBox = new System.Windows.Forms.ListBox();
            this.btnSortOutlet = new System.Windows.Forms.Button();
            this.descOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.ascOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.sortColOutletLabel = new System.Windows.Forms.Label();
            this.btnOutletShowAll = new System.Windows.Forms.Button();
            this.searchOutletGroupBox = new System.Windows.Forms.GroupBox();
            this.searchQueryOutletGroupBox = new System.Windows.Forms.Label();
            this.searchColsOutletListBox = new System.Windows.Forms.ListBox();
            this.searchOutletLabel = new System.Windows.Forms.Label();
            this.searchQueryOutletTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchOutlet = new System.Windows.Forms.Button();
            this.dgvOutlet = new System.Windows.Forms.DataGridView();
            this.panelOutletLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOutlet.SuspendLayout();
            this.sortOutletGroupBox.SuspendLayout();
            this.searchOutletGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelsToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelsToolStripMenuItem
            // 
            this.panelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelMainToolStripMenuItem,
            this.panelOutletToolStripMenuItem,
            this.panelReviewToolStripMenuItem});
            this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            this.panelsToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.panelsToolStripMenuItem.Text = "Страницы";
            // 
            // panelMainToolStripMenuItem
            // 
            this.panelMainToolStripMenuItem.Name = "panelMainToolStripMenuItem";
            this.panelMainToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelMainToolStripMenuItem.Text = "Главная";
            this.panelMainToolStripMenuItem.Click += new System.EventHandler(this.panelMainToolStripMenuItem_Click);
            // 
            // panelOutletToolStripMenuItem
            // 
            this.panelOutletToolStripMenuItem.Name = "panelOutletToolStripMenuItem";
            this.panelOutletToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelOutletToolStripMenuItem.Text = "Просмотр торговых точек";
            this.panelOutletToolStripMenuItem.Click += new System.EventHandler(this.panelOutletToolStripMenuItem_Click);
            // 
            // panelReviewToolStripMenuItem
            // 
            this.panelReviewToolStripMenuItem.Name = "panelReviewToolStripMenuItem";
            this.panelReviewToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelReviewToolStripMenuItem.Text = "Просмотр личных отзывов";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelMainLabel);
            this.panelMain.Controls.Add(this.btnNextPanel);
            this.panelMain.Controls.Add(this.btnPreviousPanel);
            this.panelMain.Controls.Add(this.btnPanelMain);
            this.panelMain.Controls.Add(this.btnPanelOutlet);
            this.panelMain.Location = new System.Drawing.Point(12, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 560);
            this.panelMain.TabIndex = 1;
            // 
            // panelMainLabel
            // 
            this.panelMainLabel.AutoSize = true;
            this.panelMainLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMainLabel.Location = new System.Drawing.Point(290, 9);
            this.panelMainLabel.Name = "panelMainLabel";
            this.panelMainLabel.Size = new System.Drawing.Size(338, 46);
            this.panelMainLabel.TabIndex = 4;
            this.panelMainLabel.Text = "Добро пожаловать!";
            // 
            // btnNextPanel
            // 
            this.btnNextPanel.Location = new System.Drawing.Point(666, 488);
            this.btnNextPanel.Name = "btnNextPanel";
            this.btnNextPanel.Size = new System.Drawing.Size(135, 51);
            this.btnNextPanel.TabIndex = 3;
            this.btnNextPanel.Text = "Предыдущая страница";
            this.btnNextPanel.UseVisualStyleBackColor = true;
            this.btnNextPanel.Click += new System.EventHandler(this.btnNextPanel_Click);
            // 
            // btnPreviousPanel
            // 
            this.btnPreviousPanel.Location = new System.Drawing.Point(493, 488);
            this.btnPreviousPanel.Name = "btnPreviousPanel";
            this.btnPreviousPanel.Size = new System.Drawing.Size(135, 51);
            this.btnPreviousPanel.TabIndex = 2;
            this.btnPreviousPanel.Text = "Предыдущая страница";
            this.btnPreviousPanel.UseVisualStyleBackColor = true;
            this.btnPreviousPanel.Click += new System.EventHandler(this.btnPreviousPanel_Click);
            // 
            // btnPanelMain
            // 
            this.btnPanelMain.Location = new System.Drawing.Point(13, 484);
            this.btnPanelMain.Name = "btnPanelMain";
            this.btnPanelMain.Size = new System.Drawing.Size(290, 59);
            this.btnPanelMain.TabIndex = 1;
            this.btnPanelMain.Text = "На главную";
            this.btnPanelMain.UseVisualStyleBackColor = true;
            this.btnPanelMain.Click += new System.EventHandler(this.btnPanelMain_Click);
            // 
            // btnPanelOutlet
            // 
            this.btnPanelOutlet.Location = new System.Drawing.Point(112, 130);
            this.btnPanelOutlet.Name = "btnPanelOutlet";
            this.btnPanelOutlet.Size = new System.Drawing.Size(196, 75);
            this.btnPanelOutlet.TabIndex = 0;
            this.btnPanelOutlet.Text = "Просмотр торговых точек";
            this.btnPanelOutlet.UseVisualStyleBackColor = true;
            this.btnPanelOutlet.Click += new System.EventHandler(this.btnPanelOutlet_Click);
            // 
            // panelOutlet
            // 
            this.panelOutlet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutlet.Controls.Add(this.btnUpdateDGVOutlet);
            this.panelOutlet.Controls.Add(this.btnShowOutletDetailsForm);
            this.panelOutlet.Controls.Add(this.sortOutletGroupBox);
            this.panelOutlet.Controls.Add(this.btnOutletShowAll);
            this.panelOutlet.Controls.Add(this.searchOutletGroupBox);
            this.panelOutlet.Controls.Add(this.dgvOutlet);
            this.panelOutlet.Controls.Add(this.panelOutletLabel);
            this.panelOutlet.Location = new System.Drawing.Point(12, 33);
            this.panelOutlet.Name = "panelOutlet";
            this.panelOutlet.Size = new System.Drawing.Size(948, 479);
            this.panelOutlet.TabIndex = 5;
            // 
            // btnUpdateDGVOutlet
            // 
            this.btnUpdateDGVOutlet.Location = new System.Drawing.Point(666, 397);
            this.btnUpdateDGVOutlet.Name = "btnUpdateDGVOutlet";
            this.btnUpdateDGVOutlet.Size = new System.Drawing.Size(208, 60);
            this.btnUpdateDGVOutlet.TabIndex = 32;
            this.btnUpdateDGVOutlet.Text = "Обновить таблицу";
            this.btnUpdateDGVOutlet.UseVisualStyleBackColor = true;
            // 
            // btnShowOutletDetailsForm
            // 
            this.btnShowOutletDetailsForm.Location = new System.Drawing.Point(401, 397);
            this.btnShowOutletDetailsForm.Name = "btnShowOutletDetailsForm";
            this.btnShowOutletDetailsForm.Size = new System.Drawing.Size(208, 60);
            this.btnShowOutletDetailsForm.TabIndex = 26;
            this.btnShowOutletDetailsForm.Text = "Управление торговыми точками";
            this.btnShowOutletDetailsForm.UseVisualStyleBackColor = true;
            // 
            // sortOutletGroupBox
            // 
            this.sortOutletGroupBox.Controls.Add(this.sortColsOutletListBox);
            this.sortOutletGroupBox.Controls.Add(this.btnSortOutlet);
            this.sortOutletGroupBox.Controls.Add(this.descOutletRadioButton);
            this.sortOutletGroupBox.Controls.Add(this.ascOutletRadioButton);
            this.sortOutletGroupBox.Controls.Add(this.sortColOutletLabel);
            this.sortOutletGroupBox.Location = new System.Drawing.Point(14, 266);
            this.sortOutletGroupBox.Name = "sortOutletGroupBox";
            this.sortOutletGroupBox.Size = new System.Drawing.Size(317, 188);
            this.sortOutletGroupBox.TabIndex = 31;
            this.sortOutletGroupBox.TabStop = false;
            this.sortOutletGroupBox.Text = "Сортировка";
            // 
            // sortColsOutletListBox
            // 
            this.sortColsOutletListBox.FormattingEnabled = true;
            this.sortColsOutletListBox.ItemHeight = 16;
            this.sortColsOutletListBox.Items.AddRange(new object[] {
            "Организация",
            "Название торговой точки",
            "Тип торговой точки",
            "Расписание",
            "Рейтинг"});
            this.sortColsOutletListBox.Location = new System.Drawing.Point(7, 39);
            this.sortColsOutletListBox.Name = "sortColsOutletListBox";
            this.sortColsOutletListBox.Size = new System.Drawing.Size(154, 116);
            this.sortColsOutletListBox.TabIndex = 13;
            this.sortColsOutletListBox.SelectedIndexChanged += new System.EventHandler(this.sortColsOutletListBox_SelectedIndexChanged);
            // 
            // btnSortOutlet
            // 
            this.btnSortOutlet.Enabled = false;
            this.btnSortOutlet.Location = new System.Drawing.Point(174, 93);
            this.btnSortOutlet.Name = "btnSortOutlet";
            this.btnSortOutlet.Size = new System.Drawing.Size(119, 42);
            this.btnSortOutlet.TabIndex = 4;
            this.btnSortOutlet.Text = "Сортировать";
            this.btnSortOutlet.UseVisualStyleBackColor = true;
            this.btnSortOutlet.Click += new System.EventHandler(this.btnSortOutlet_Click);
            // 
            // descOutletRadioButton
            // 
            this.descOutletRadioButton.AutoSize = true;
            this.descOutletRadioButton.Location = new System.Drawing.Point(174, 66);
            this.descOutletRadioButton.Name = "descOutletRadioButton";
            this.descOutletRadioButton.Size = new System.Drawing.Size(117, 21);
            this.descOutletRadioButton.TabIndex = 3;
            this.descOutletRadioButton.Text = "По убыванию";
            this.descOutletRadioButton.UseVisualStyleBackColor = true;
            // 
            // ascOutletRadioButton
            // 
            this.ascOutletRadioButton.AutoSize = true;
            this.ascOutletRadioButton.Checked = true;
            this.ascOutletRadioButton.Location = new System.Drawing.Point(174, 39);
            this.ascOutletRadioButton.Name = "ascOutletRadioButton";
            this.ascOutletRadioButton.Size = new System.Drawing.Size(137, 21);
            this.ascOutletRadioButton.TabIndex = 2;
            this.ascOutletRadioButton.TabStop = true;
            this.ascOutletRadioButton.Text = "По возрастанию";
            this.ascOutletRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortColOutletLabel
            // 
            this.sortColOutletLabel.AutoSize = true;
            this.sortColOutletLabel.Location = new System.Drawing.Point(6, 18);
            this.sortColOutletLabel.Name = "sortColOutletLabel";
            this.sortColOutletLabel.Size = new System.Drawing.Size(154, 17);
            this.sortColOutletLabel.TabIndex = 0;
            this.sortColOutletLabel.Text = "Поле для сортировки:";
            // 
            // btnOutletShowAll
            // 
            this.btnOutletShowAll.Location = new System.Drawing.Point(118, 218);
            this.btnOutletShowAll.Name = "btnOutletShowAll";
            this.btnOutletShowAll.Size = new System.Drawing.Size(119, 42);
            this.btnOutletShowAll.TabIndex = 30;
            this.btnOutletShowAll.Text = "Показать все";
            this.btnOutletShowAll.UseVisualStyleBackColor = true;
            this.btnOutletShowAll.Click += new System.EventHandler(this.btnOutletShowAll_Click);
            // 
            // searchOutletGroupBox
            // 
            this.searchOutletGroupBox.Controls.Add(this.searchQueryOutletGroupBox);
            this.searchOutletGroupBox.Controls.Add(this.searchColsOutletListBox);
            this.searchOutletGroupBox.Controls.Add(this.searchOutletLabel);
            this.searchOutletGroupBox.Controls.Add(this.searchQueryOutletTextBox);
            this.searchOutletGroupBox.Controls.Add(this.btnSearchOutlet);
            this.searchOutletGroupBox.Location = new System.Drawing.Point(13, 45);
            this.searchOutletGroupBox.Name = "searchOutletGroupBox";
            this.searchOutletGroupBox.Size = new System.Drawing.Size(317, 161);
            this.searchOutletGroupBox.TabIndex = 27;
            this.searchOutletGroupBox.TabStop = false;
            this.searchOutletGroupBox.Text = "Поиск";
            // 
            // searchQueryOutletGroupBox
            // 
            this.searchQueryOutletGroupBox.AutoSize = true;
            this.searchQueryOutletGroupBox.Location = new System.Drawing.Point(178, 43);
            this.searchQueryOutletGroupBox.Name = "searchQueryOutletGroupBox";
            this.searchQueryOutletGroupBox.Size = new System.Drawing.Size(117, 17);
            this.searchQueryOutletGroupBox.TabIndex = 12;
            this.searchQueryOutletGroupBox.Text = "Введите запрос:";
            // 
            // searchColsOutletListBox
            // 
            this.searchColsOutletListBox.FormattingEnabled = true;
            this.searchColsOutletListBox.ItemHeight = 16;
            this.searchColsOutletListBox.Items.AddRange(new object[] {
            "Организация",
            "Название торговой точки",
            "Тип торговой точки",
            "Расписание",
            "Рейтинг"});
            this.searchColsOutletListBox.Location = new System.Drawing.Point(7, 38);
            this.searchColsOutletListBox.Name = "searchColsOutletListBox";
            this.searchColsOutletListBox.Size = new System.Drawing.Size(154, 116);
            this.searchColsOutletListBox.TabIndex = 11;
            this.searchColsOutletListBox.SelectedIndexChanged += new System.EventHandler(this.searchColsOutletListBox_SelectedIndexChanged);
            // 
            // searchOutletLabel
            // 
            this.searchOutletLabel.AutoSize = true;
            this.searchOutletLabel.Location = new System.Drawing.Point(6, 18);
            this.searchOutletLabel.Name = "searchOutletLabel";
            this.searchOutletLabel.Size = new System.Drawing.Size(164, 17);
            this.searchOutletLabel.TabIndex = 7;
            this.searchOutletLabel.Text = "Выберите поле поиска:";
            // 
            // searchQueryOutletTextBox
            // 
            this.searchQueryOutletTextBox.Location = new System.Drawing.Point(181, 63);
            this.searchQueryOutletTextBox.Name = "searchQueryOutletTextBox";
            this.searchQueryOutletTextBox.Size = new System.Drawing.Size(119, 22);
            this.searchQueryOutletTextBox.TabIndex = 6;
            // 
            // btnSearchOutlet
            // 
            this.btnSearchOutlet.Enabled = false;
            this.btnSearchOutlet.Location = new System.Drawing.Point(181, 91);
            this.btnSearchOutlet.Name = "btnSearchOutlet";
            this.btnSearchOutlet.Size = new System.Drawing.Size(119, 42);
            this.btnSearchOutlet.TabIndex = 5;
            this.btnSearchOutlet.Text = "Найти";
            this.btnSearchOutlet.UseVisualStyleBackColor = true;
            this.btnSearchOutlet.Click += new System.EventHandler(this.btnSearchOutlet_Click);
            // 
            // dgvOutlet
            // 
            this.dgvOutlet.AllowUserToAddRows = false;
            this.dgvOutlet.AllowUserToDeleteRows = false;
            this.dgvOutlet.AllowUserToOrderColumns = true;
            this.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutlet.Location = new System.Drawing.Point(352, 43);
            this.dgvOutlet.Name = "dgvOutlet";
            this.dgvOutlet.ReadOnly = true;
            this.dgvOutlet.RowHeadersWidth = 51;
            this.dgvOutlet.RowTemplate.Height = 24;
            this.dgvOutlet.Size = new System.Drawing.Size(578, 318);
            this.dgvOutlet.TabIndex = 29;
            // 
            // panelOutletLabel
            // 
            this.panelOutletLabel.AutoSize = true;
            this.panelOutletLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutletLabel.Location = new System.Drawing.Point(8, 9);
            this.panelOutletLabel.Name = "panelOutletLabel";
            this.panelOutletLabel.Size = new System.Drawing.Size(291, 28);
            this.panelOutletLabel.TabIndex = 28;
            this.panelOutletLabel.Text = "Просмотр: \"Торговые точки\"";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 605);
            this.Controls.Add(this.panelOutlet);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД ТЦ \"Тессеракт\" – Навигатор посетителя";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOutlet.ResumeLayout(false);
            this.panelOutlet.PerformLayout();
            this.sortOutletGroupBox.ResumeLayout(false);
            this.sortOutletGroupBox.PerformLayout();
            this.searchOutletGroupBox.ResumeLayout(false);
            this.searchOutletGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelOutletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelMainToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnPanelOutlet;
        private System.Windows.Forms.Button btnPanelMain;
        private System.Windows.Forms.Button btnPreviousPanel;
        private System.Windows.Forms.Button btnNextPanel;
        private System.Windows.Forms.Label panelMainLabel;
        private System.Windows.Forms.Panel panelOutlet;
        private System.Windows.Forms.Button btnUpdateDGVOutlet;
        private System.Windows.Forms.Button btnShowOutletDetailsForm;
        private System.Windows.Forms.GroupBox sortOutletGroupBox;
        private System.Windows.Forms.ListBox sortColsOutletListBox;
        private System.Windows.Forms.Button btnSortOutlet;
        private System.Windows.Forms.RadioButton descOutletRadioButton;
        private System.Windows.Forms.RadioButton ascOutletRadioButton;
        private System.Windows.Forms.Label sortColOutletLabel;
        private System.Windows.Forms.Button btnOutletShowAll;
        private System.Windows.Forms.GroupBox searchOutletGroupBox;
        private System.Windows.Forms.Label searchQueryOutletGroupBox;
        private System.Windows.Forms.ListBox searchColsOutletListBox;
        private System.Windows.Forms.Label searchOutletLabel;
        private System.Windows.Forms.TextBox searchQueryOutletTextBox;
        private System.Windows.Forms.Button btnSearchOutlet;
        private System.Windows.Forms.DataGridView dgvOutlet;
        private System.Windows.Forms.Label panelOutletLabel;
    }
}