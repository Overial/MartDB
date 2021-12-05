
namespace MartDB
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panelBookingHandling = new System.Windows.Forms.Panel();
            this.btnCallHandleBookingForm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rightFloorBoundTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.leftFloorBoundTextBox = new System.Windows.Forms.TextBox();
            this.btnFloorSearch = new System.Windows.Forms.Button();
            this.dgvBookingHandling = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightSquareBoundtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leftSquareBoundTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchSquare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.listBoxFieldsForSort = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.martDBDataSet = new MartDB.MartDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBookingHandlingPanel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMoveToPanelMain = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnTradeProfilePanel = new System.Windows.Forms.Button();
            this.btnEmployeePanel = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new MartDB.MartDBDataSetTableAdapters.EmployeeTableAdapter();
            this.bookingTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingTableAdapter = new MartDB.MartDBDataSetTableAdapters.BookingTableAdapter();
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.areaTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.btnMoveToHandleEmployeesForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sortFieldsEmployeesListBox = new System.Windows.Forms.ListBox();
            this.btnSortEmployees = new System.Windows.Forms.Button();
            this.descEmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.ascEmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.queryEmployeeColListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.queryEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTradeProfiles = new System.Windows.Forms.Panel();
            this.btnMoveToHandlingTradeProfilesForm = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSortTradeProfile = new System.Windows.Forms.Button();
            this.descTradeProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.ascTradeProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.btnShowAllTradeProfiles = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.queryTradeProfileTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchTradeProfile = new System.Windows.Forms.Button();
            this.dgvTradeProfile = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.panelOutlets = new System.Windows.Forms.Panel();
            this.btnShowHandleOutletForm = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.sortColsOutletListBox = new System.Windows.Forms.ListBox();
            this.btnSortOutlets = new System.Windows.Forms.Button();
            this.descOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.ascOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnShowAllOutlets = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.queryOutletFieldColBox = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.queryOutletTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchOutlet = new System.Windows.Forms.Button();
            this.dgvOutlet = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.btnOutletPanel = new System.Windows.Forms.Button();
            this.outletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBookingHandling.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHandling)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.panelEmployees.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panelTradeProfiles.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeProfile)).BeginInit();
            this.panelOutlets.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBookingHandling
            // 
            this.panelBookingHandling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookingHandling.Controls.Add(this.btnCallHandleBookingForm);
            this.panelBookingHandling.Controls.Add(this.groupBox3);
            this.panelBookingHandling.Controls.Add(this.dgvBookingHandling);
            this.panelBookingHandling.Controls.Add(this.btnShowAll);
            this.panelBookingHandling.Controls.Add(this.groupBox2);
            this.panelBookingHandling.Controls.Add(this.groupBox1);
            this.panelBookingHandling.Controls.Add(this.label2);
            this.panelBookingHandling.Location = new System.Drawing.Point(12, 33);
            this.panelBookingHandling.Name = "panelBookingHandling";
            this.panelBookingHandling.Size = new System.Drawing.Size(948, 479);
            this.panelBookingHandling.TabIndex = 1;
            // 
            // btnCallHandleBookingForm
            // 
            this.btnCallHandleBookingForm.Location = new System.Drawing.Point(585, 408);
            this.btnCallHandleBookingForm.Name = "btnCallHandleBookingForm";
            this.btnCallHandleBookingForm.Size = new System.Drawing.Size(176, 57);
            this.btnCallHandleBookingForm.TabIndex = 20;
            this.btnCallHandleBookingForm.Text = "Управление арендами";
            this.btnCallHandleBookingForm.UseVisualStyleBackColor = true;
            this.btnCallHandleBookingForm.Click += new System.EventHandler(this.btnCallHandleBookingForm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rightFloorBoundTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.leftFloorBoundTextBox);
            this.groupBox3.Controls.Add(this.btnFloorSearch);
            this.groupBox3.Location = new System.Drawing.Point(15, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 106);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск по номеру этажа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Правая граница:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Левая граница:";
            // 
            // rightFloorBoundTextBox
            // 
            this.rightFloorBoundTextBox.Location = new System.Drawing.Point(147, 65);
            this.rightFloorBoundTextBox.Name = "rightFloorBoundTextBox";
            this.rightFloorBoundTextBox.Size = new System.Drawing.Size(119, 22);
            this.rightFloorBoundTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Введите запрос:";
            // 
            // leftFloorBoundTextBox
            // 
            this.leftFloorBoundTextBox.Location = new System.Drawing.Point(147, 37);
            this.leftFloorBoundTextBox.Name = "leftFloorBoundTextBox";
            this.leftFloorBoundTextBox.Size = new System.Drawing.Size(119, 22);
            this.leftFloorBoundTextBox.TabIndex = 6;
            // 
            // btnFloorSearch
            // 
            this.btnFloorSearch.Location = new System.Drawing.Point(272, 40);
            this.btnFloorSearch.Name = "btnFloorSearch";
            this.btnFloorSearch.Size = new System.Drawing.Size(119, 42);
            this.btnFloorSearch.TabIndex = 5;
            this.btnFloorSearch.Text = "Найти";
            this.btnFloorSearch.UseVisualStyleBackColor = true;
            this.btnFloorSearch.Click += new System.EventHandler(this.btnFloorSearch_Click);
            // 
            // dgvBookingHandling
            // 
            this.dgvBookingHandling.AllowUserToAddRows = false;
            this.dgvBookingHandling.AllowUserToDeleteRows = false;
            this.dgvBookingHandling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingHandling.Location = new System.Drawing.Point(418, 15);
            this.dgvBookingHandling.Name = "dgvBookingHandling";
            this.dgvBookingHandling.ReadOnly = true;
            this.dgvBookingHandling.RowHeadersWidth = 51;
            this.dgvBookingHandling.RowTemplate.Height = 24;
            this.dgvBookingHandling.Size = new System.Drawing.Size(511, 380);
            this.dgvBookingHandling.TabIndex = 19;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(158, 276);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(119, 42);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAllBookings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rightSquareBoundtextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.leftSquareBoundTextBox);
            this.groupBox2.Controls.Add(this.btnSearchSquare);
            this.groupBox2.Location = new System.Drawing.Point(13, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 108);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по площади";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Правая граница:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Левая граница:";
            // 
            // rightSquareBoundtextBox
            // 
            this.rightSquareBoundtextBox.Location = new System.Drawing.Point(147, 65);
            this.rightSquareBoundtextBox.Name = "rightSquareBoundtextBox";
            this.rightSquareBoundtextBox.Size = new System.Drawing.Size(119, 22);
            this.rightSquareBoundtextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Введите запрос:";
            // 
            // leftSquareBoundTextBox
            // 
            this.leftSquareBoundTextBox.Location = new System.Drawing.Point(147, 37);
            this.leftSquareBoundTextBox.Name = "leftSquareBoundTextBox";
            this.leftSquareBoundTextBox.Size = new System.Drawing.Size(119, 22);
            this.leftSquareBoundTextBox.TabIndex = 6;
            // 
            // btnSearchSquare
            // 
            this.btnSearchSquare.Location = new System.Drawing.Point(272, 40);
            this.btnSearchSquare.Name = "btnSearchSquare";
            this.btnSearchSquare.Size = new System.Drawing.Size(119, 42);
            this.btnSearchSquare.TabIndex = 5;
            this.btnSearchSquare.Text = "Найти";
            this.btnSearchSquare.UseVisualStyleBackColor = true;
            this.btnSearchSquare.Click += new System.EventHandler(this.btnSearchSquare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.radioButtonDesc);
            this.groupBox1.Controls.Add(this.radioButtonAsc);
            this.groupBox1.Controls.Add(this.listBoxFieldsForSort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(256, 93);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(119, 42);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSortBookings_Click);
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(256, 66);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(117, 21);
            this.radioButtonDesc.TabIndex = 3;
            this.radioButtonDesc.Text = "По убыванию";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(256, 39);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(137, 21);
            this.radioButtonAsc.TabIndex = 2;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "По возрастанию";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // listBoxFieldsForSort
            // 
            this.listBoxFieldsForSort.FormattingEnabled = true;
            this.listBoxFieldsForSort.ItemHeight = 16;
            this.listBoxFieldsForSort.Items.AddRange(new object[] {
            "Площадь помещения",
            "Номер этажа",
            "Стоимость аренды",
            "Начало периода аренды",
            "Конец периода аренды"});
            this.listBoxFieldsForSort.Location = new System.Drawing.Point(9, 39);
            this.listBoxFieldsForSort.Name = "listBoxFieldsForSort";
            this.listBoxFieldsForSort.Size = new System.Drawing.Size(241, 100);
            this.listBoxFieldsForSort.TabIndex = 1;
            this.listBoxFieldsForSort.SelectedIndexChanged += new System.EventHandler(this.listBoxFieldsForSort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Поле для сортировки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Панель управления: \"Аренда\"";
            // 
            // martDBDataSet
            // 
            this.martDBDataSet.DataSetName = "MartDBDataSet";
            this.martDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagesToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.bookingHandlingToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.tradeProfileToolStripMenuItem,
            this.outletToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.pagesToolStripMenuItem.Text = "Страницы";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.mainToolStripMenuItem.Text = "Главная";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // bookingHandlingToolStripMenuItem
            // 
            this.bookingHandlingToolStripMenuItem.Name = "bookingHandlingToolStripMenuItem";
            this.bookingHandlingToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.bookingHandlingToolStripMenuItem.Text = "Управление арендами";
            this.bookingHandlingToolStripMenuItem.Click += new System.EventHandler(this.bookingHandlingToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.employeeToolStripMenuItem.Text = "Управление сотрудниками";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // tradeProfileToolStripMenuItem
            // 
            this.tradeProfileToolStripMenuItem.Name = "tradeProfileToolStripMenuItem";
            this.tradeProfileToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.tradeProfileToolStripMenuItem.Text = "Управление торговыми профилями";
            this.tradeProfileToolStripMenuItem.Click += new System.EventHandler(this.tradeProfileToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.aboutToolStripMenuItem1.Text = "О программе";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(393, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Главная";
            // 
            // btnBookingHandlingPanel
            // 
            this.btnBookingHandlingPanel.Location = new System.Drawing.Point(21, 93);
            this.btnBookingHandlingPanel.Name = "btnBookingHandlingPanel";
            this.btnBookingHandlingPanel.Size = new System.Drawing.Size(286, 83);
            this.btnBookingHandlingPanel.TabIndex = 1;
            this.btnBookingHandlingPanel.Text = "Панель управления помещениями";
            this.btnBookingHandlingPanel.UseVisualStyleBackColor = true;
            this.btnBookingHandlingPanel.Click += new System.EventHandler(this.btnBookingHandling_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(666, 488);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 51);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Следующая страница";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMoveToPanelMain
            // 
            this.btnMoveToPanelMain.Location = new System.Drawing.Point(13, 484);
            this.btnMoveToPanelMain.Name = "btnMoveToPanelMain";
            this.btnMoveToPanelMain.Size = new System.Drawing.Size(290, 59);
            this.btnMoveToPanelMain.TabIndex = 8;
            this.btnMoveToPanelMain.Text = "На главную";
            this.btnMoveToPanelMain.UseVisualStyleBackColor = true;
            this.btnMoveToPanelMain.Click += new System.EventHandler(this.btnMoveToMain_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(493, 488);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(135, 51);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Предыдущая страница";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnOutletPanel);
            this.panelMain.Controls.Add(this.btnTradeProfilePanel);
            this.panelMain.Controls.Add(this.btnEmployeePanel);
            this.panelMain.Controls.Add(this.btnPrevious);
            this.panelMain.Controls.Add(this.btnMoveToPanelMain);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.btnBookingHandlingPanel);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Location = new System.Drawing.Point(12, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 560);
            this.panelMain.TabIndex = 13;
            // 
            // btnTradeProfilePanel
            // 
            this.btnTradeProfilePanel.Location = new System.Drawing.Point(401, 93);
            this.btnTradeProfilePanel.Name = "btnTradeProfilePanel";
            this.btnTradeProfilePanel.Size = new System.Drawing.Size(286, 83);
            this.btnTradeProfilePanel.TabIndex = 12;
            this.btnTradeProfilePanel.Text = "Панель управления торговыми профилями";
            this.btnTradeProfilePanel.UseVisualStyleBackColor = true;
            this.btnTradeProfilePanel.Click += new System.EventHandler(this.btnTradeProfilePanel_Click);
            // 
            // btnEmployeePanel
            // 
            this.btnEmployeePanel.Location = new System.Drawing.Point(21, 202);
            this.btnEmployeePanel.Name = "btnEmployeePanel";
            this.btnEmployeePanel.Size = new System.Drawing.Size(286, 83);
            this.btnEmployeePanel.TabIndex = 11;
            this.btnEmployeePanel.Text = "Панель управления сотрудниками";
            this.btnEmployeePanel.UseVisualStyleBackColor = true;
            this.btnEmployeePanel.Click += new System.EventHandler(this.btnEmployeePanel_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.martDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapterManager
            // 
            this.bookingTableAdapterManager.AreaTableAdapter = null;
            this.bookingTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.bookingTableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.bookingTableAdapterManager.EmployeeTableAdapter = null;
            this.bookingTableAdapterManager.OrganisationTableAdapter = null;
            this.bookingTableAdapterManager.OutletTableAdapter = null;
            this.bookingTableAdapterManager.ReviewTableAdapter = null;
            this.bookingTableAdapterManager.TradeProfileTableAdapter = null;
            this.bookingTableAdapterManager.UpdateOrder = MartDB.MartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapterManager
            // 
            this.areaTableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.areaTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.areaTableAdapterManager.BookingTableAdapter = null;
            this.areaTableAdapterManager.EmployeeTableAdapter = null;
            this.areaTableAdapterManager.OrganisationTableAdapter = null;
            this.areaTableAdapterManager.OutletTableAdapter = null;
            this.areaTableAdapterManager.ReviewTableAdapter = null;
            this.areaTableAdapterManager.TradeProfileTableAdapter = null;
            this.areaTableAdapterManager.UpdateOrder = MartDB.MartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.martDBDataSet;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.martDBDataSet;
            // 
            // employeeTableAdapterManager
            // 
            this.employeeTableAdapterManager.AreaTableAdapter = null;
            this.employeeTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.employeeTableAdapterManager.BookingTableAdapter = null;
            this.employeeTableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.employeeTableAdapterManager.OrganisationTableAdapter = null;
            this.employeeTableAdapterManager.OutletTableAdapter = null;
            this.employeeTableAdapterManager.ReviewTableAdapter = null;
            this.employeeTableAdapterManager.TradeProfileTableAdapter = null;
            this.employeeTableAdapterManager.UpdateOrder = MartDB.MartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelEmployees
            // 
            this.panelEmployees.Controls.Add(this.btnMoveToHandleEmployeesForm);
            this.panelEmployees.Controls.Add(this.groupBox5);
            this.panelEmployees.Controls.Add(this.btnShowAllEmployees);
            this.panelEmployees.Controls.Add(this.groupBox4);
            this.panelEmployees.Controls.Add(this.dgvEmployees);
            this.panelEmployees.Controls.Add(this.label4);
            this.panelEmployees.Location = new System.Drawing.Point(12, 33);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(948, 479);
            this.panelEmployees.TabIndex = 14;
            // 
            // btnMoveToHandleEmployeesForm
            // 
            this.btnMoveToHandleEmployeesForm.Location = new System.Drawing.Point(524, 385);
            this.btnMoveToHandleEmployeesForm.Name = "btnMoveToHandleEmployeesForm";
            this.btnMoveToHandleEmployeesForm.Size = new System.Drawing.Size(208, 60);
            this.btnMoveToHandleEmployeesForm.TabIndex = 14;
            this.btnMoveToHandleEmployeesForm.Text = "Управление сотрудниками";
            this.btnMoveToHandleEmployeesForm.UseVisualStyleBackColor = true;
            this.btnMoveToHandleEmployeesForm.Click += new System.EventHandler(this.btnMoveToHandleEmployeesForm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sortFieldsEmployeesListBox);
            this.groupBox5.Controls.Add(this.btnSortEmployees);
            this.groupBox5.Controls.Add(this.descEmployeeRadioButton);
            this.groupBox5.Controls.Add(this.ascEmployeeRadioButton);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(14, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 188);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сортировка";
            // 
            // sortFieldsEmployeesListBox
            // 
            this.sortFieldsEmployeesListBox.FormattingEnabled = true;
            this.sortFieldsEmployeesListBox.ItemHeight = 16;
            this.sortFieldsEmployeesListBox.Items.AddRange(new object[] {
            "Организация",
            "ФИО",
            "Пол",
            "Должность",
            "Телефонный номер",
            "Электронная почта"});
            this.sortFieldsEmployeesListBox.Location = new System.Drawing.Point(7, 39);
            this.sortFieldsEmployeesListBox.Name = "sortFieldsEmployeesListBox";
            this.sortFieldsEmployeesListBox.Size = new System.Drawing.Size(154, 116);
            this.sortFieldsEmployeesListBox.TabIndex = 13;
            this.sortFieldsEmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.sortFieldsEmployeesListBox_SelectedIndexChanged);
            // 
            // btnSortEmployees
            // 
            this.btnSortEmployees.Enabled = false;
            this.btnSortEmployees.Location = new System.Drawing.Point(174, 93);
            this.btnSortEmployees.Name = "btnSortEmployees";
            this.btnSortEmployees.Size = new System.Drawing.Size(119, 42);
            this.btnSortEmployees.TabIndex = 4;
            this.btnSortEmployees.Text = "Сортировать";
            this.btnSortEmployees.UseVisualStyleBackColor = true;
            this.btnSortEmployees.Click += new System.EventHandler(this.btnSortEmployees_Click);
            // 
            // descEmployeeRadioButton
            // 
            this.descEmployeeRadioButton.AutoSize = true;
            this.descEmployeeRadioButton.Location = new System.Drawing.Point(174, 66);
            this.descEmployeeRadioButton.Name = "descEmployeeRadioButton";
            this.descEmployeeRadioButton.Size = new System.Drawing.Size(117, 21);
            this.descEmployeeRadioButton.TabIndex = 3;
            this.descEmployeeRadioButton.Text = "По убыванию";
            this.descEmployeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ascEmployeeRadioButton
            // 
            this.ascEmployeeRadioButton.AutoSize = true;
            this.ascEmployeeRadioButton.Checked = true;
            this.ascEmployeeRadioButton.Location = new System.Drawing.Point(174, 39);
            this.ascEmployeeRadioButton.Name = "ascEmployeeRadioButton";
            this.ascEmployeeRadioButton.Size = new System.Drawing.Size(137, 21);
            this.ascEmployeeRadioButton.TabIndex = 2;
            this.ascEmployeeRadioButton.TabStop = true;
            this.ascEmployeeRadioButton.Text = "По возрастанию";
            this.ascEmployeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Поле для сортировки:";
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Location = new System.Drawing.Point(118, 218);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(119, 42);
            this.btnShowAllEmployees.TabIndex = 23;
            this.btnShowAllEmployees.Text = "Показать все";
            this.btnShowAllEmployees.UseVisualStyleBackColor = true;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowAllEmployees_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.queryEmployeeColListBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.queryEmployeeTextBox);
            this.groupBox4.Controls.Add(this.btnSearchEmployee);
            this.groupBox4.Location = new System.Drawing.Point(13, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 161);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Введите запрос:";
            // 
            // queryEmployeeColListBox
            // 
            this.queryEmployeeColListBox.FormattingEnabled = true;
            this.queryEmployeeColListBox.ItemHeight = 16;
            this.queryEmployeeColListBox.Items.AddRange(new object[] {
            "Организация",
            "ФИО",
            "Пол",
            "Должность",
            "Телефонный номер",
            "Электронная почта"});
            this.queryEmployeeColListBox.Location = new System.Drawing.Point(7, 38);
            this.queryEmployeeColListBox.Name = "queryEmployeeColListBox";
            this.queryEmployeeColListBox.Size = new System.Drawing.Size(154, 116);
            this.queryEmployeeColListBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Выберите поле поиска:";
            // 
            // queryEmployeeTextBox
            // 
            this.queryEmployeeTextBox.Location = new System.Drawing.Point(181, 63);
            this.queryEmployeeTextBox.Name = "queryEmployeeTextBox";
            this.queryEmployeeTextBox.Size = new System.Drawing.Size(119, 22);
            this.queryEmployeeTextBox.TabIndex = 6;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(181, 91);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(119, 42);
            this.btnSearchEmployee.TabIndex = 5;
            this.btnSearchEmployee.Text = "Найти";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(352, 43);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(578, 318);
            this.dgvEmployees.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Панель управления: \"Сотрудники\"";
            // 
            // panelTradeProfiles
            // 
            this.panelTradeProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTradeProfiles.Controls.Add(this.btnMoveToHandlingTradeProfilesForm);
            this.panelTradeProfiles.Controls.Add(this.groupBox6);
            this.panelTradeProfiles.Controls.Add(this.btnShowAllTradeProfiles);
            this.panelTradeProfiles.Controls.Add(this.groupBox7);
            this.panelTradeProfiles.Controls.Add(this.dgvTradeProfile);
            this.panelTradeProfiles.Controls.Add(this.label17);
            this.panelTradeProfiles.Location = new System.Drawing.Point(12, 33);
            this.panelTradeProfiles.Name = "panelTradeProfiles";
            this.panelTradeProfiles.Size = new System.Drawing.Size(948, 479);
            this.panelTradeProfiles.TabIndex = 15;
            // 
            // btnMoveToHandlingTradeProfilesForm
            // 
            this.btnMoveToHandlingTradeProfilesForm.Location = new System.Drawing.Point(524, 385);
            this.btnMoveToHandlingTradeProfilesForm.Name = "btnMoveToHandlingTradeProfilesForm";
            this.btnMoveToHandlingTradeProfilesForm.Size = new System.Drawing.Size(208, 60);
            this.btnMoveToHandlingTradeProfilesForm.TabIndex = 14;
            this.btnMoveToHandlingTradeProfilesForm.Text = "Управление торговыми профилями";
            this.btnMoveToHandlingTradeProfilesForm.UseVisualStyleBackColor = true;
            this.btnMoveToHandlingTradeProfilesForm.Click += new System.EventHandler(this.btnMoveToHandlingTradeProfilesForm_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSortTradeProfile);
            this.groupBox6.Controls.Add(this.descTradeProfileRadioButton);
            this.groupBox6.Controls.Add(this.ascTradeProfileRadioButton);
            this.groupBox6.Location = new System.Drawing.Point(14, 266);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(264, 165);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сортировка";
            // 
            // btnSortTradeProfile
            // 
            this.btnSortTradeProfile.Location = new System.Drawing.Point(68, 93);
            this.btnSortTradeProfile.Name = "btnSortTradeProfile";
            this.btnSortTradeProfile.Size = new System.Drawing.Size(119, 42);
            this.btnSortTradeProfile.TabIndex = 4;
            this.btnSortTradeProfile.Text = "Сортировать";
            this.btnSortTradeProfile.UseVisualStyleBackColor = true;
            this.btnSortTradeProfile.Click += new System.EventHandler(this.btnSortTradeProfile_Click);
            // 
            // descTradeProfileRadioButton
            // 
            this.descTradeProfileRadioButton.AutoSize = true;
            this.descTradeProfileRadioButton.Location = new System.Drawing.Point(70, 59);
            this.descTradeProfileRadioButton.Name = "descTradeProfileRadioButton";
            this.descTradeProfileRadioButton.Size = new System.Drawing.Size(117, 21);
            this.descTradeProfileRadioButton.TabIndex = 3;
            this.descTradeProfileRadioButton.Text = "По убыванию";
            this.descTradeProfileRadioButton.UseVisualStyleBackColor = true;
            // 
            // ascTradeProfileRadioButton
            // 
            this.ascTradeProfileRadioButton.AutoSize = true;
            this.ascTradeProfileRadioButton.Checked = true;
            this.ascTradeProfileRadioButton.Location = new System.Drawing.Point(70, 32);
            this.ascTradeProfileRadioButton.Name = "ascTradeProfileRadioButton";
            this.ascTradeProfileRadioButton.Size = new System.Drawing.Size(137, 21);
            this.ascTradeProfileRadioButton.TabIndex = 2;
            this.ascTradeProfileRadioButton.TabStop = true;
            this.ascTradeProfileRadioButton.Text = "По возрастанию";
            this.ascTradeProfileRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTradeProfiles
            // 
            this.btnShowAllTradeProfiles.Location = new System.Drawing.Point(84, 208);
            this.btnShowAllTradeProfiles.Name = "btnShowAllTradeProfiles";
            this.btnShowAllTradeProfiles.Size = new System.Drawing.Size(119, 42);
            this.btnShowAllTradeProfiles.TabIndex = 23;
            this.btnShowAllTradeProfiles.Text = "Показать все";
            this.btnShowAllTradeProfiles.UseVisualStyleBackColor = true;
            this.btnShowAllTradeProfiles.Click += new System.EventHandler(this.btnShowAllTradeProfiles_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.queryTradeProfileTextBox);
            this.groupBox7.Controls.Add(this.btnSearchTradeProfile);
            this.groupBox7.Location = new System.Drawing.Point(13, 45);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(265, 149);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Введите запрос:";
            // 
            // queryTradeProfileTextBox
            // 
            this.queryTradeProfileTextBox.Location = new System.Drawing.Point(71, 49);
            this.queryTradeProfileTextBox.Name = "queryTradeProfileTextBox";
            this.queryTradeProfileTextBox.Size = new System.Drawing.Size(119, 22);
            this.queryTradeProfileTextBox.TabIndex = 6;
            // 
            // btnSearchTradeProfile
            // 
            this.btnSearchTradeProfile.Location = new System.Drawing.Point(71, 90);
            this.btnSearchTradeProfile.Name = "btnSearchTradeProfile";
            this.btnSearchTradeProfile.Size = new System.Drawing.Size(119, 42);
            this.btnSearchTradeProfile.TabIndex = 5;
            this.btnSearchTradeProfile.Text = "Найти";
            this.btnSearchTradeProfile.UseVisualStyleBackColor = true;
            this.btnSearchTradeProfile.Click += new System.EventHandler(this.btnSearchTradeProfile_Click);
            // 
            // dgvTradeProfile
            // 
            this.dgvTradeProfile.AllowUserToAddRows = false;
            this.dgvTradeProfile.AllowUserToDeleteRows = false;
            this.dgvTradeProfile.AllowUserToOrderColumns = true;
            this.dgvTradeProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTradeProfile.Location = new System.Drawing.Point(352, 43);
            this.dgvTradeProfile.Name = "dgvTradeProfile";
            this.dgvTradeProfile.ReadOnly = true;
            this.dgvTradeProfile.RowHeadersWidth = 51;
            this.dgvTradeProfile.RowTemplate.Height = 24;
            this.dgvTradeProfile.Size = new System.Drawing.Size(578, 318);
            this.dgvTradeProfile.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(413, 28);
            this.label17.TabIndex = 21;
            this.label17.Text = "Панель управления: \"Торговые профили\"";
            // 
            // panelOutlets
            // 
            this.panelOutlets.Controls.Add(this.btnShowHandleOutletForm);
            this.panelOutlets.Controls.Add(this.groupBox8);
            this.panelOutlets.Controls.Add(this.btnShowAllOutlets);
            this.panelOutlets.Controls.Add(this.groupBox9);
            this.panelOutlets.Controls.Add(this.dgvOutlet);
            this.panelOutlets.Controls.Add(this.label19);
            this.panelOutlets.Location = new System.Drawing.Point(12, 33);
            this.panelOutlets.Name = "panelOutlets";
            this.panelOutlets.Size = new System.Drawing.Size(948, 479);
            this.panelOutlets.TabIndex = 16;
            // 
            // btnShowHandleOutletForm
            // 
            this.btnShowHandleOutletForm.Location = new System.Drawing.Point(524, 385);
            this.btnShowHandleOutletForm.Name = "btnShowHandleOutletForm";
            this.btnShowHandleOutletForm.Size = new System.Drawing.Size(208, 60);
            this.btnShowHandleOutletForm.TabIndex = 14;
            this.btnShowHandleOutletForm.Text = "Управление торговыми точками";
            this.btnShowHandleOutletForm.UseVisualStyleBackColor = true;
            this.btnShowHandleOutletForm.Click += new System.EventHandler(this.btnShowHandleOutletForm_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.sortColsOutletListBox);
            this.groupBox8.Controls.Add(this.btnSortOutlets);
            this.groupBox8.Controls.Add(this.descOutletRadioButton);
            this.groupBox8.Controls.Add(this.ascOutletRadioButton);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(14, 266);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(317, 188);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Сортировка";
            // 
            // sortColsOutletListBox
            // 
            this.sortColsOutletListBox.FormattingEnabled = true;
            this.sortColsOutletListBox.ItemHeight = 16;
            this.sortColsOutletListBox.Items.AddRange(new object[] {
            "Организация",
            "Код помещения",
            "Название торговой точки",
            "Тип торговой точки",
            "Расписание",
            "Рейтинг",
            "Контактное лицо"});
            this.sortColsOutletListBox.Location = new System.Drawing.Point(7, 39);
            this.sortColsOutletListBox.Name = "sortColsOutletListBox";
            this.sortColsOutletListBox.Size = new System.Drawing.Size(154, 116);
            this.sortColsOutletListBox.TabIndex = 13;
            this.sortColsOutletListBox.SelectedIndexChanged += new System.EventHandler(this.sortColsOutletListBox_SelectedIndexChanged);
            // 
            // btnSortOutlets
            // 
            this.btnSortOutlets.Enabled = false;
            this.btnSortOutlets.Location = new System.Drawing.Point(174, 93);
            this.btnSortOutlets.Name = "btnSortOutlets";
            this.btnSortOutlets.Size = new System.Drawing.Size(119, 42);
            this.btnSortOutlets.TabIndex = 4;
            this.btnSortOutlets.Text = "Сортировать";
            this.btnSortOutlets.UseVisualStyleBackColor = true;
            this.btnSortOutlets.Click += new System.EventHandler(this.btnSortOutlets_Click);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Поле для сортировки:";
            // 
            // btnShowAllOutlets
            // 
            this.btnShowAllOutlets.Location = new System.Drawing.Point(118, 218);
            this.btnShowAllOutlets.Name = "btnShowAllOutlets";
            this.btnShowAllOutlets.Size = new System.Drawing.Size(119, 42);
            this.btnShowAllOutlets.TabIndex = 23;
            this.btnShowAllOutlets.Text = "Показать все";
            this.btnShowAllOutlets.UseVisualStyleBackColor = true;
            this.btnShowAllOutlets.Click += new System.EventHandler(this.btnShowAllOutlets_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.queryOutletFieldColBox);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.queryOutletTextBox);
            this.groupBox9.Controls.Add(this.btnSearchOutlet);
            this.groupBox9.Location = new System.Drawing.Point(13, 45);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(317, 161);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Поиск";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(178, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Введите запрос:";
            // 
            // queryOutletFieldColBox
            // 
            this.queryOutletFieldColBox.FormattingEnabled = true;
            this.queryOutletFieldColBox.ItemHeight = 16;
            this.queryOutletFieldColBox.Items.AddRange(new object[] {
            "Организация",
            "Код помещения",
            "Название торговой точки",
            "Тип торговой точки",
            "Расписание",
            "Рейтинг",
            "Контактное лицо"});
            this.queryOutletFieldColBox.Location = new System.Drawing.Point(7, 38);
            this.queryOutletFieldColBox.Name = "queryOutletFieldColBox";
            this.queryOutletFieldColBox.Size = new System.Drawing.Size(154, 116);
            this.queryOutletFieldColBox.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Выберите поле поиска:";
            // 
            // queryOutletTextBox
            // 
            this.queryOutletTextBox.Location = new System.Drawing.Point(181, 63);
            this.queryOutletTextBox.Name = "queryOutletTextBox";
            this.queryOutletTextBox.Size = new System.Drawing.Size(119, 22);
            this.queryOutletTextBox.TabIndex = 6;
            // 
            // btnSearchOutlet
            // 
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
            this.dgvOutlet.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(8, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(383, 28);
            this.label19.TabIndex = 21;
            this.label19.Text = "Панель управления: \"Торговые точки\"";
            // 
            // btnOutletPanel
            // 
            this.btnOutletPanel.Location = new System.Drawing.Point(401, 202);
            this.btnOutletPanel.Name = "btnOutletPanel";
            this.btnOutletPanel.Size = new System.Drawing.Size(286, 83);
            this.btnOutletPanel.TabIndex = 13;
            this.btnOutletPanel.Text = "Панель управления торговыми точками";
            this.btnOutletPanel.UseVisualStyleBackColor = true;
            this.btnOutletPanel.Click += new System.EventHandler(this.btnOutletPanel_Click);
            // 
            // outletToolStripMenuItem
            // 
            this.outletToolStripMenuItem.Name = "outletToolStripMenuItem";
            this.outletToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.outletToolStripMenuItem.Text = "Управление торговыми точками";
            this.outletToolStripMenuItem.Click += new System.EventHandler(this.outletToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 605);
            this.Controls.Add(this.panelOutlets);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEmployees);
            this.Controls.Add(this.panelTradeProfiles);
            this.Controls.Add(this.panelBookingHandling);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "БД ТЦ \"Тессеракт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelBookingHandling.ResumeLayout(false);
            this.panelBookingHandling.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHandling)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            this.panelEmployees.ResumeLayout(false);
            this.panelEmployees.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panelTradeProfiles.ResumeLayout(false);
            this.panelTradeProfiles.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeProfile)).EndInit();
            this.panelOutlets.ResumeLayout(false);
            this.panelOutlets.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBookingHandling;
        private MartDBDataSet martDBDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.ListBox listBoxFieldsForSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchSquare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox leftSquareBoundTextBox;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvBookingHandling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBookingHandlingPanel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMoveToPanelMain;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem bookingHandlingToolStripMenuItem;
        private System.Windows.Forms.TextBox rightSquareBoundtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rightFloorBoundTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox leftFloorBoundTextBox;
        private System.Windows.Forms.Button btnFloorSearch;
        private System.Windows.Forms.Button btnCallHandleBookingForm;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MartDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager bookingTableAdapterManager;
        private MartDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager areaTableAdapterManager;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MartDBDataSetTableAdapters.TableAdapterManager employeeTableAdapterManager;
        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox queryEmployeeTextBox;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox queryEmployeeColListBox;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Button btnEmployeePanel;
        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox sortFieldsEmployeesListBox;
        private System.Windows.Forms.Button btnSortEmployees;
        private System.Windows.Forms.RadioButton descEmployeeRadioButton;
        private System.Windows.Forms.RadioButton ascEmployeeRadioButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMoveToHandleEmployeesForm;
        private System.Windows.Forms.Panel panelTradeProfiles;
        private System.Windows.Forms.Button btnMoveToHandlingTradeProfilesForm;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSortTradeProfile;
        private System.Windows.Forms.RadioButton descTradeProfileRadioButton;
        private System.Windows.Forms.RadioButton ascTradeProfileRadioButton;
        private System.Windows.Forms.Button btnShowAllTradeProfiles;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox queryTradeProfileTextBox;
        private System.Windows.Forms.Button btnSearchTradeProfile;
        private System.Windows.Forms.DataGridView dgvTradeProfile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem tradeProfileToolStripMenuItem;
        private System.Windows.Forms.Button btnTradeProfilePanel;
        private System.Windows.Forms.Panel panelOutlets;
        private System.Windows.Forms.Button btnShowHandleOutletForm;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox sortColsOutletListBox;
        private System.Windows.Forms.Button btnSortOutlets;
        private System.Windows.Forms.RadioButton descOutletRadioButton;
        private System.Windows.Forms.RadioButton ascOutletRadioButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnShowAllOutlets;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox queryOutletFieldColBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox queryOutletTextBox;
        private System.Windows.Forms.Button btnSearchOutlet;
        private System.Windows.Forms.DataGridView dgvOutlet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnOutletPanel;
        private System.Windows.Forms.ToolStripMenuItem outletToolStripMenuItem;
    }
}