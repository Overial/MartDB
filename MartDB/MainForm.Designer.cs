
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
            this.panelBooking = new System.Windows.Forms.Panel();
            this.btnHandleBookingForm = new System.Windows.Forms.Button();
            this.btnUpdateBookingDGV = new System.Windows.Forms.Button();
            this.bookingSearchFloorGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rightFloorBoundTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.leftFloorBoundTextBox = new System.Windows.Forms.TextBox();
            this.btnFloorSearch = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.btnShowAllBookings = new System.Windows.Forms.Button();
            this.bookingSquareSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightSquareBoundtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leftSquareBoundTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchSquare = new System.Windows.Forms.Button();
            this.bookingSortColGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.listBoxFieldsForSort = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookingPanelLabel = new System.Windows.Forms.Label();
            this.martDBDataSet = new MartDB.MartDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainLabel = new System.Windows.Forms.Label();
            this.btnNextPanel = new System.Windows.Forms.Button();
            this.btnPanelMain = new System.Windows.Forms.Button();
            this.btnPreviousPanel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnPanelBooking = new System.Windows.Forms.Button();
            this.btnPanelOutlet = new System.Windows.Forms.Button();
            this.btnPanelTradeProfile = new System.Windows.Forms.Button();
            this.btnPanelEmployee = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new MartDB.MartDBDataSetTableAdapters.EmployeeTableAdapter();
            this.bookingTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingTableAdapter = new MartDB.MartDBDataSetTableAdapters.BookingTableAdapter();
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.areaTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.btnUpdateEmployeeDGV = new System.Windows.Forms.Button();
            this.btnHandleEmployeeForm = new System.Windows.Forms.Button();
            this.employeeSortGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeSortColListBox = new System.Windows.Forms.ListBox();
            this.btnSortEmployees = new System.Windows.Forms.Button();
            this.descEmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.ascEmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeSortColLabel = new System.Windows.Forms.Label();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.employeeSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeQueryLabel = new System.Windows.Forms.Label();
            this.employeeSearchColListBox = new System.Windows.Forms.ListBox();
            this.employeeSearchColLabel = new System.Windows.Forms.Label();
            this.employeeQueryTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTradeProfile = new System.Windows.Forms.Panel();
            this.btnUpdateTradeProfileDGV = new System.Windows.Forms.Button();
            this.btnHandleTradeProfileForm = new System.Windows.Forms.Button();
            this.tradeProfileSortGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSortTradeProfile = new System.Windows.Forms.Button();
            this.descTradeProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.ascTradeProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.btnShowAllTradeProfiles = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tradeProfileQueryLabel = new System.Windows.Forms.Label();
            this.queryTradeProfileTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchTradeProfile = new System.Windows.Forms.Button();
            this.dgvTradeProfile = new System.Windows.Forms.DataGridView();
            this.employeePanelLabel = new System.Windows.Forms.Label();
            this.panelOutlet = new System.Windows.Forms.Panel();
            this.btnUpdateOutletDGV = new System.Windows.Forms.Button();
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
            this.panelBooking.SuspendLayout();
            this.bookingSearchFloorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.bookingSquareSearchGroupBox.SuspendLayout();
            this.bookingSortColGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.panelEmployee.SuspendLayout();
            this.employeeSortGroupBox.SuspendLayout();
            this.employeeSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panelTradeProfile.SuspendLayout();
            this.tradeProfileSortGroupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeProfile)).BeginInit();
            this.panelOutlet.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBooking
            // 
            this.panelBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBooking.Controls.Add(this.btnHandleBookingForm);
            this.panelBooking.Controls.Add(this.btnUpdateBookingDGV);
            this.panelBooking.Controls.Add(this.bookingSearchFloorGroupBox);
            this.panelBooking.Controls.Add(this.dgvBooking);
            this.panelBooking.Controls.Add(this.btnShowAllBookings);
            this.panelBooking.Controls.Add(this.bookingSquareSearchGroupBox);
            this.panelBooking.Controls.Add(this.bookingSortColGroupBox);
            this.panelBooking.Controls.Add(this.bookingPanelLabel);
            this.panelBooking.Location = new System.Drawing.Point(12, 33);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(948, 479);
            this.panelBooking.TabIndex = 1;
            // 
            // btnHandleBookingForm
            // 
            this.btnHandleBookingForm.Location = new System.Drawing.Point(470, 411);
            this.btnHandleBookingForm.Name = "btnHandleBookingForm";
            this.btnHandleBookingForm.Size = new System.Drawing.Size(176, 57);
            this.btnHandleBookingForm.TabIndex = 22;
            this.btnHandleBookingForm.Text = "Управление арендами";
            this.btnHandleBookingForm.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBookingDGV
            // 
            this.btnUpdateBookingDGV.Location = new System.Drawing.Point(714, 408);
            this.btnUpdateBookingDGV.Name = "btnUpdateBookingDGV";
            this.btnUpdateBookingDGV.Size = new System.Drawing.Size(176, 57);
            this.btnUpdateBookingDGV.TabIndex = 21;
            this.btnUpdateBookingDGV.Text = "Обновить таблицу";
            this.btnUpdateBookingDGV.UseVisualStyleBackColor = true;
            this.btnUpdateBookingDGV.Click += new System.EventHandler(this.btnUpdateBookingDGV_Click);
            // 
            // bookingSearchFloorGroupBox
            // 
            this.bookingSearchFloorGroupBox.Controls.Add(this.label8);
            this.bookingSearchFloorGroupBox.Controls.Add(this.label9);
            this.bookingSearchFloorGroupBox.Controls.Add(this.rightFloorBoundTextBox);
            this.bookingSearchFloorGroupBox.Controls.Add(this.label10);
            this.bookingSearchFloorGroupBox.Controls.Add(this.leftFloorBoundTextBox);
            this.bookingSearchFloorGroupBox.Controls.Add(this.btnFloorSearch);
            this.bookingSearchFloorGroupBox.Location = new System.Drawing.Point(15, 162);
            this.bookingSearchFloorGroupBox.Name = "bookingSearchFloorGroupBox";
            this.bookingSearchFloorGroupBox.Size = new System.Drawing.Size(397, 106);
            this.bookingSearchFloorGroupBox.TabIndex = 19;
            this.bookingSearchFloorGroupBox.TabStop = false;
            this.bookingSearchFloorGroupBox.Text = "Поиск по номеру этажа";
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
            this.btnFloorSearch.Click += new System.EventHandler(this.btnSearchFloors_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(418, 15);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(511, 380);
            this.dgvBooking.TabIndex = 19;
            // 
            // btnShowAllBookings
            // 
            this.btnShowAllBookings.Location = new System.Drawing.Point(158, 276);
            this.btnShowAllBookings.Name = "btnShowAllBookings";
            this.btnShowAllBookings.Size = new System.Drawing.Size(119, 42);
            this.btnShowAllBookings.TabIndex = 8;
            this.btnShowAllBookings.Text = "Показать все";
            this.btnShowAllBookings.UseVisualStyleBackColor = true;
            this.btnShowAllBookings.Click += new System.EventHandler(this.btnShowAllBookings_Click);
            // 
            // bookingSquareSearchGroupBox
            // 
            this.bookingSquareSearchGroupBox.Controls.Add(this.label6);
            this.bookingSquareSearchGroupBox.Controls.Add(this.label1);
            this.bookingSquareSearchGroupBox.Controls.Add(this.rightSquareBoundtextBox);
            this.bookingSquareSearchGroupBox.Controls.Add(this.label7);
            this.bookingSquareSearchGroupBox.Controls.Add(this.leftSquareBoundTextBox);
            this.bookingSquareSearchGroupBox.Controls.Add(this.btnSearchSquare);
            this.bookingSquareSearchGroupBox.Location = new System.Drawing.Point(13, 42);
            this.bookingSquareSearchGroupBox.Name = "bookingSquareSearchGroupBox";
            this.bookingSquareSearchGroupBox.Size = new System.Drawing.Size(399, 108);
            this.bookingSquareSearchGroupBox.TabIndex = 18;
            this.bookingSquareSearchGroupBox.TabStop = false;
            this.bookingSquareSearchGroupBox.Text = "Поиск по площади";
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
            this.btnSearchSquare.Click += new System.EventHandler(this.btnSearchSquares_Click);
            // 
            // bookingSortColGroupBox
            // 
            this.bookingSortColGroupBox.Controls.Add(this.btnSort);
            this.bookingSortColGroupBox.Controls.Add(this.radioButtonDesc);
            this.bookingSortColGroupBox.Controls.Add(this.radioButtonAsc);
            this.bookingSortColGroupBox.Controls.Add(this.listBoxFieldsForSort);
            this.bookingSortColGroupBox.Controls.Add(this.label5);
            this.bookingSortColGroupBox.Location = new System.Drawing.Point(13, 318);
            this.bookingSortColGroupBox.Name = "bookingSortColGroupBox";
            this.bookingSortColGroupBox.Size = new System.Drawing.Size(399, 147);
            this.bookingSortColGroupBox.TabIndex = 17;
            this.bookingSortColGroupBox.TabStop = false;
            this.bookingSortColGroupBox.Text = "Сортировка";
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
            this.listBoxFieldsForSort.SelectedIndexChanged += new System.EventHandler(this.bookingSortColListBox_SelectedIndexChanged);
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
            // bookingPanelLabel
            // 
            this.bookingPanelLabel.AutoSize = true;
            this.bookingPanelLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingPanelLabel.Location = new System.Drawing.Point(8, 9);
            this.bookingPanelLabel.Name = "bookingPanelLabel";
            this.bookingPanelLabel.Size = new System.Drawing.Size(299, 28);
            this.bookingPanelLabel.TabIndex = 6;
            this.bookingPanelLabel.Text = "Панель управления: \"Аренда\"";
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
            this.panelsToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelsToolStripMenuItem
            // 
            this.panelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.bookingHandlingToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.tradeProfileToolStripMenuItem,
            this.outletToolStripMenuItem});
            this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            this.panelsToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.panelsToolStripMenuItem.Text = "Страницы";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.mainToolStripMenuItem.Text = "Главная";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainPanelToolStripMenuItem_Click);
            // 
            // bookingHandlingToolStripMenuItem
            // 
            this.bookingHandlingToolStripMenuItem.Name = "bookingHandlingToolStripMenuItem";
            this.bookingHandlingToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.bookingHandlingToolStripMenuItem.Text = "Управление арендами";
            this.bookingHandlingToolStripMenuItem.Click += new System.EventHandler(this.bookingPanelToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.employeeToolStripMenuItem.Text = "Управление сотрудниками";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeePanelToolStripMenuItem_Click);
            // 
            // tradeProfileToolStripMenuItem
            // 
            this.tradeProfileToolStripMenuItem.Name = "tradeProfileToolStripMenuItem";
            this.tradeProfileToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.tradeProfileToolStripMenuItem.Text = "Управление торговыми профилями";
            this.tradeProfileToolStripMenuItem.Click += new System.EventHandler(this.tradeProfilePanelToolStripMenuItem_Click);
            // 
            // outletToolStripMenuItem
            // 
            this.outletToolStripMenuItem.Name = "outletToolStripMenuItem";
            this.outletToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.outletToolStripMenuItem.Text = "Управление торговыми точками";
            this.outletToolStripMenuItem.Click += new System.EventHandler(this.outletPanelToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "О программе";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // panelMainLabel
            // 
            this.panelMainLabel.AutoSize = true;
            this.panelMainLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMainLabel.Location = new System.Drawing.Point(393, 13);
            this.panelMainLabel.Name = "panelMainLabel";
            this.panelMainLabel.Size = new System.Drawing.Size(149, 46);
            this.panelMainLabel.TabIndex = 0;
            this.panelMainLabel.Text = "Главная";
            // 
            // btnNextPanel
            // 
            this.btnNextPanel.Location = new System.Drawing.Point(666, 488);
            this.btnNextPanel.Name = "btnNextPanel";
            this.btnNextPanel.Size = new System.Drawing.Size(135, 51);
            this.btnNextPanel.TabIndex = 10;
            this.btnNextPanel.Text = "Следующая страница";
            this.btnNextPanel.UseVisualStyleBackColor = true;
            this.btnNextPanel.Click += new System.EventHandler(this.btnNextPanel_Click);
            // 
            // btnPanelMain
            // 
            this.btnPanelMain.Location = new System.Drawing.Point(13, 484);
            this.btnPanelMain.Name = "btnPanelMain";
            this.btnPanelMain.Size = new System.Drawing.Size(290, 59);
            this.btnPanelMain.TabIndex = 8;
            this.btnPanelMain.Text = "На главную";
            this.btnPanelMain.UseVisualStyleBackColor = true;
            this.btnPanelMain.Click += new System.EventHandler(this.btnMainPanel_Click);
            // 
            // btnPreviousPanel
            // 
            this.btnPreviousPanel.Location = new System.Drawing.Point(493, 488);
            this.btnPreviousPanel.Name = "btnPreviousPanel";
            this.btnPreviousPanel.Size = new System.Drawing.Size(135, 51);
            this.btnPreviousPanel.TabIndex = 9;
            this.btnPreviousPanel.Text = "Предыдущая страница";
            this.btnPreviousPanel.UseVisualStyleBackColor = true;
            this.btnPreviousPanel.Click += new System.EventHandler(this.btnPreviousPanel_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnPanelBooking);
            this.panelMain.Controls.Add(this.btnPanelOutlet);
            this.panelMain.Controls.Add(this.btnPanelTradeProfile);
            this.panelMain.Controls.Add(this.btnPanelEmployee);
            this.panelMain.Controls.Add(this.btnPreviousPanel);
            this.panelMain.Controls.Add(this.btnPanelMain);
            this.panelMain.Controls.Add(this.btnNextPanel);
            this.panelMain.Controls.Add(this.panelMainLabel);
            this.panelMain.Location = new System.Drawing.Point(12, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 560);
            this.panelMain.TabIndex = 13;
            // 
            // btnPanelBooking
            // 
            this.btnPanelBooking.Location = new System.Drawing.Point(126, 116);
            this.btnPanelBooking.Name = "btnPanelBooking";
            this.btnPanelBooking.Size = new System.Drawing.Size(286, 83);
            this.btnPanelBooking.TabIndex = 14;
            this.btnPanelBooking.Text = "Панель управления арендами";
            this.btnPanelBooking.UseVisualStyleBackColor = true;
            // 
            // btnPanelOutlet
            // 
            this.btnPanelOutlet.Location = new System.Drawing.Point(550, 224);
            this.btnPanelOutlet.Name = "btnPanelOutlet";
            this.btnPanelOutlet.Size = new System.Drawing.Size(286, 83);
            this.btnPanelOutlet.TabIndex = 13;
            this.btnPanelOutlet.Text = "Панель управления торговыми точками";
            this.btnPanelOutlet.UseVisualStyleBackColor = true;
            this.btnPanelOutlet.Click += new System.EventHandler(this.btnOutletPanel_Click);
            // 
            // btnPanelTradeProfile
            // 
            this.btnPanelTradeProfile.Location = new System.Drawing.Point(550, 116);
            this.btnPanelTradeProfile.Name = "btnPanelTradeProfile";
            this.btnPanelTradeProfile.Size = new System.Drawing.Size(286, 83);
            this.btnPanelTradeProfile.TabIndex = 12;
            this.btnPanelTradeProfile.Text = "Панель управления торговыми профилями";
            this.btnPanelTradeProfile.UseVisualStyleBackColor = true;
            this.btnPanelTradeProfile.Click += new System.EventHandler(this.btnTradeProfilePanel_Click);
            // 
            // btnPanelEmployee
            // 
            this.btnPanelEmployee.Location = new System.Drawing.Point(126, 224);
            this.btnPanelEmployee.Name = "btnPanelEmployee";
            this.btnPanelEmployee.Size = new System.Drawing.Size(286, 83);
            this.btnPanelEmployee.TabIndex = 11;
            this.btnPanelEmployee.Text = "Панель управления сотрудниками";
            this.btnPanelEmployee.UseVisualStyleBackColor = true;
            this.btnPanelEmployee.Click += new System.EventHandler(this.btnEmployeePanel_Click);
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
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.btnUpdateEmployeeDGV);
            this.panelEmployee.Controls.Add(this.btnHandleEmployeeForm);
            this.panelEmployee.Controls.Add(this.employeeSortGroupBox);
            this.panelEmployee.Controls.Add(this.btnShowAllEmployees);
            this.panelEmployee.Controls.Add(this.employeeSearchGroupBox);
            this.panelEmployee.Controls.Add(this.dgvEmployee);
            this.panelEmployee.Controls.Add(this.label4);
            this.panelEmployee.Location = new System.Drawing.Point(12, 33);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(948, 479);
            this.panelEmployee.TabIndex = 14;
            // 
            // btnUpdateEmployeeDGV
            // 
            this.btnUpdateEmployeeDGV.Location = new System.Drawing.Point(667, 394);
            this.btnUpdateEmployeeDGV.Name = "btnUpdateEmployeeDGV";
            this.btnUpdateEmployeeDGV.Size = new System.Drawing.Size(208, 60);
            this.btnUpdateEmployeeDGV.TabIndex = 25;
            this.btnUpdateEmployeeDGV.Text = "Обновить таблицу";
            this.btnUpdateEmployeeDGV.UseVisualStyleBackColor = true;
            this.btnUpdateEmployeeDGV.Click += new System.EventHandler(this.btnUpdateEmployeeDGV_Click);
            // 
            // btnHandleEmployeeForm
            // 
            this.btnHandleEmployeeForm.Location = new System.Drawing.Point(419, 394);
            this.btnHandleEmployeeForm.Name = "btnHandleEmployeeForm";
            this.btnHandleEmployeeForm.Size = new System.Drawing.Size(208, 60);
            this.btnHandleEmployeeForm.TabIndex = 14;
            this.btnHandleEmployeeForm.Text = "Управление сотрудниками";
            this.btnHandleEmployeeForm.UseVisualStyleBackColor = true;
            this.btnHandleEmployeeForm.Click += new System.EventHandler(this.btnHandleEmployeeForm_Click);
            // 
            // employeeSortGroupBox
            // 
            this.employeeSortGroupBox.Controls.Add(this.employeeSortColListBox);
            this.employeeSortGroupBox.Controls.Add(this.btnSortEmployees);
            this.employeeSortGroupBox.Controls.Add(this.descEmployeeRadioButton);
            this.employeeSortGroupBox.Controls.Add(this.ascEmployeeRadioButton);
            this.employeeSortGroupBox.Controls.Add(this.employeeSortColLabel);
            this.employeeSortGroupBox.Location = new System.Drawing.Point(14, 266);
            this.employeeSortGroupBox.Name = "employeeSortGroupBox";
            this.employeeSortGroupBox.Size = new System.Drawing.Size(317, 188);
            this.employeeSortGroupBox.TabIndex = 24;
            this.employeeSortGroupBox.TabStop = false;
            this.employeeSortGroupBox.Text = "Сортировка";
            // 
            // employeeSortColListBox
            // 
            this.employeeSortColListBox.FormattingEnabled = true;
            this.employeeSortColListBox.ItemHeight = 16;
            this.employeeSortColListBox.Items.AddRange(new object[] {
            "Организация",
            "ФИО",
            "Пол",
            "Должность",
            "Телефонный номер",
            "Электронная почта"});
            this.employeeSortColListBox.Location = new System.Drawing.Point(7, 39);
            this.employeeSortColListBox.Name = "employeeSortColListBox";
            this.employeeSortColListBox.Size = new System.Drawing.Size(154, 116);
            this.employeeSortColListBox.TabIndex = 13;
            this.employeeSortColListBox.SelectedIndexChanged += new System.EventHandler(this.employeeSortColListBox_SelectedIndexChanged);
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
            // employeeSortColLabel
            // 
            this.employeeSortColLabel.AutoSize = true;
            this.employeeSortColLabel.Location = new System.Drawing.Point(6, 18);
            this.employeeSortColLabel.Name = "employeeSortColLabel";
            this.employeeSortColLabel.Size = new System.Drawing.Size(154, 17);
            this.employeeSortColLabel.TabIndex = 0;
            this.employeeSortColLabel.Text = "Поле для сортировки:";
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
            // employeeSearchGroupBox
            // 
            this.employeeSearchGroupBox.Controls.Add(this.employeeQueryLabel);
            this.employeeSearchGroupBox.Controls.Add(this.employeeSearchColListBox);
            this.employeeSearchGroupBox.Controls.Add(this.employeeSearchColLabel);
            this.employeeSearchGroupBox.Controls.Add(this.employeeQueryTextBox);
            this.employeeSearchGroupBox.Controls.Add(this.btnSearchEmployee);
            this.employeeSearchGroupBox.Location = new System.Drawing.Point(13, 45);
            this.employeeSearchGroupBox.Name = "employeeSearchGroupBox";
            this.employeeSearchGroupBox.Size = new System.Drawing.Size(317, 161);
            this.employeeSearchGroupBox.TabIndex = 20;
            this.employeeSearchGroupBox.TabStop = false;
            this.employeeSearchGroupBox.Text = "Поиск";
            // 
            // employeeQueryLabel
            // 
            this.employeeQueryLabel.AutoSize = true;
            this.employeeQueryLabel.Location = new System.Drawing.Point(178, 43);
            this.employeeQueryLabel.Name = "employeeQueryLabel";
            this.employeeQueryLabel.Size = new System.Drawing.Size(117, 17);
            this.employeeQueryLabel.TabIndex = 12;
            this.employeeQueryLabel.Text = "Введите запрос:";
            // 
            // employeeSearchColListBox
            // 
            this.employeeSearchColListBox.FormattingEnabled = true;
            this.employeeSearchColListBox.ItemHeight = 16;
            this.employeeSearchColListBox.Items.AddRange(new object[] {
            "Организация",
            "ФИО",
            "Пол",
            "Должность",
            "Телефонный номер",
            "Электронная почта"});
            this.employeeSearchColListBox.Location = new System.Drawing.Point(7, 38);
            this.employeeSearchColListBox.Name = "employeeSearchColListBox";
            this.employeeSearchColListBox.Size = new System.Drawing.Size(154, 116);
            this.employeeSearchColListBox.TabIndex = 11;
            // 
            // employeeSearchColLabel
            // 
            this.employeeSearchColLabel.AutoSize = true;
            this.employeeSearchColLabel.Location = new System.Drawing.Point(6, 18);
            this.employeeSearchColLabel.Name = "employeeSearchColLabel";
            this.employeeSearchColLabel.Size = new System.Drawing.Size(164, 17);
            this.employeeSearchColLabel.TabIndex = 7;
            this.employeeSearchColLabel.Text = "Выберите поле поиска:";
            // 
            // employeeQueryTextBox
            // 
            this.employeeQueryTextBox.Location = new System.Drawing.Point(181, 63);
            this.employeeQueryTextBox.Name = "employeeQueryTextBox";
            this.employeeQueryTextBox.Size = new System.Drawing.Size(119, 22);
            this.employeeQueryTextBox.TabIndex = 6;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(181, 91);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(119, 42);
            this.btnSearchEmployee.TabIndex = 5;
            this.btnSearchEmployee.Text = "Найти";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployees_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToOrderColumns = true;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(352, 43);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(578, 318);
            this.dgvEmployee.TabIndex = 22;
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
            // panelTradeProfile
            // 
            this.panelTradeProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTradeProfile.Controls.Add(this.btnUpdateTradeProfileDGV);
            this.panelTradeProfile.Controls.Add(this.btnHandleTradeProfileForm);
            this.panelTradeProfile.Controls.Add(this.tradeProfileSortGroupBox);
            this.panelTradeProfile.Controls.Add(this.btnShowAllTradeProfiles);
            this.panelTradeProfile.Controls.Add(this.groupBox7);
            this.panelTradeProfile.Controls.Add(this.dgvTradeProfile);
            this.panelTradeProfile.Controls.Add(this.employeePanelLabel);
            this.panelTradeProfile.Location = new System.Drawing.Point(12, 33);
            this.panelTradeProfile.Name = "panelTradeProfile";
            this.panelTradeProfile.Size = new System.Drawing.Size(948, 479);
            this.panelTradeProfile.TabIndex = 15;
            // 
            // btnUpdateTradeProfileDGV
            // 
            this.btnUpdateTradeProfileDGV.Location = new System.Drawing.Point(666, 384);
            this.btnUpdateTradeProfileDGV.Name = "btnUpdateTradeProfileDGV";
            this.btnUpdateTradeProfileDGV.Size = new System.Drawing.Size(208, 60);
            this.btnUpdateTradeProfileDGV.TabIndex = 25;
            this.btnUpdateTradeProfileDGV.Text = "Обновить таблицу";
            this.btnUpdateTradeProfileDGV.UseVisualStyleBackColor = true;
            this.btnUpdateTradeProfileDGV.Click += new System.EventHandler(this.btnUpdateTradeProfileDGV_Click);
            // 
            // btnHandleTradeProfileForm
            // 
            this.btnHandleTradeProfileForm.Location = new System.Drawing.Point(392, 384);
            this.btnHandleTradeProfileForm.Name = "btnHandleTradeProfileForm";
            this.btnHandleTradeProfileForm.Size = new System.Drawing.Size(208, 60);
            this.btnHandleTradeProfileForm.TabIndex = 14;
            this.btnHandleTradeProfileForm.Text = "Управление торговыми профилями";
            this.btnHandleTradeProfileForm.UseVisualStyleBackColor = true;
            this.btnHandleTradeProfileForm.Click += new System.EventHandler(this.btnHandleTradeProfileForm_Click);
            // 
            // tradeProfileSortGroupBox
            // 
            this.tradeProfileSortGroupBox.Controls.Add(this.btnSortTradeProfile);
            this.tradeProfileSortGroupBox.Controls.Add(this.descTradeProfileRadioButton);
            this.tradeProfileSortGroupBox.Controls.Add(this.ascTradeProfileRadioButton);
            this.tradeProfileSortGroupBox.Location = new System.Drawing.Point(14, 266);
            this.tradeProfileSortGroupBox.Name = "tradeProfileSortGroupBox";
            this.tradeProfileSortGroupBox.Size = new System.Drawing.Size(264, 165);
            this.tradeProfileSortGroupBox.TabIndex = 24;
            this.tradeProfileSortGroupBox.TabStop = false;
            this.tradeProfileSortGroupBox.Text = "Сортировка";
            // 
            // btnSortTradeProfile
            // 
            this.btnSortTradeProfile.Location = new System.Drawing.Point(68, 93);
            this.btnSortTradeProfile.Name = "btnSortTradeProfile";
            this.btnSortTradeProfile.Size = new System.Drawing.Size(119, 42);
            this.btnSortTradeProfile.TabIndex = 4;
            this.btnSortTradeProfile.Text = "Сортировать";
            this.btnSortTradeProfile.UseVisualStyleBackColor = true;
            this.btnSortTradeProfile.Click += new System.EventHandler(this.btnSortTradeProfiles_Click);
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
            this.groupBox7.Controls.Add(this.tradeProfileQueryLabel);
            this.groupBox7.Controls.Add(this.queryTradeProfileTextBox);
            this.groupBox7.Controls.Add(this.btnSearchTradeProfile);
            this.groupBox7.Location = new System.Drawing.Point(13, 45);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(265, 149);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск";
            // 
            // tradeProfileQueryLabel
            // 
            this.tradeProfileQueryLabel.AutoSize = true;
            this.tradeProfileQueryLabel.Location = new System.Drawing.Point(73, 21);
            this.tradeProfileQueryLabel.Name = "tradeProfileQueryLabel";
            this.tradeProfileQueryLabel.Size = new System.Drawing.Size(117, 17);
            this.tradeProfileQueryLabel.TabIndex = 12;
            this.tradeProfileQueryLabel.Text = "Введите запрос:";
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
            this.btnSearchTradeProfile.Click += new System.EventHandler(this.btnSearchTradeProfiles_Click);
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
            // employeePanelLabel
            // 
            this.employeePanelLabel.AutoSize = true;
            this.employeePanelLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeePanelLabel.Location = new System.Drawing.Point(8, 9);
            this.employeePanelLabel.Name = "employeePanelLabel";
            this.employeePanelLabel.Size = new System.Drawing.Size(413, 28);
            this.employeePanelLabel.TabIndex = 21;
            this.employeePanelLabel.Text = "Панель управления: \"Торговые профили\"";
            // 
            // panelOutlet
            // 
            this.panelOutlet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutlet.Controls.Add(this.btnUpdateOutletDGV);
            this.panelOutlet.Controls.Add(this.btnShowHandleOutletForm);
            this.panelOutlet.Controls.Add(this.groupBox8);
            this.panelOutlet.Controls.Add(this.btnShowAllOutlets);
            this.panelOutlet.Controls.Add(this.groupBox9);
            this.panelOutlet.Controls.Add(this.dgvOutlet);
            this.panelOutlet.Controls.Add(this.label19);
            this.panelOutlet.Location = new System.Drawing.Point(12, 33);
            this.panelOutlet.Name = "panelOutlet";
            this.panelOutlet.Size = new System.Drawing.Size(948, 479);
            this.panelOutlet.TabIndex = 16;
            // 
            // btnUpdateOutletDGV
            // 
            this.btnUpdateOutletDGV.Location = new System.Drawing.Point(666, 397);
            this.btnUpdateOutletDGV.Name = "btnUpdateOutletDGV";
            this.btnUpdateOutletDGV.Size = new System.Drawing.Size(208, 60);
            this.btnUpdateOutletDGV.TabIndex = 25;
            this.btnUpdateOutletDGV.Text = "Обновить таблицу";
            this.btnUpdateOutletDGV.UseVisualStyleBackColor = true;
            this.btnUpdateOutletDGV.Click += new System.EventHandler(this.btnUpdateOutletDGV_Click);
            // 
            // btnShowHandleOutletForm
            // 
            this.btnShowHandleOutletForm.Location = new System.Drawing.Point(401, 397);
            this.btnShowHandleOutletForm.Name = "btnShowHandleOutletForm";
            this.btnShowHandleOutletForm.Size = new System.Drawing.Size(208, 60);
            this.btnShowHandleOutletForm.TabIndex = 14;
            this.btnShowHandleOutletForm.Text = "Управление торговыми точками";
            this.btnShowHandleOutletForm.UseVisualStyleBackColor = true;
            this.btnShowHandleOutletForm.Click += new System.EventHandler(this.btnHandleOutletForm_Click);
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
            this.sortColsOutletListBox.SelectedIndexChanged += new System.EventHandler(this.outletSortColListBox_SelectedIndexChanged);
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
            this.btnSearchOutlet.Click += new System.EventHandler(this.btnSearchOutlets_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 605);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.panelTradeProfile);
            this.Controls.Add(this.panelOutlet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД ТЦ \"Тессеракт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.bookingSearchFloorGroupBox.ResumeLayout(false);
            this.bookingSearchFloorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.bookingSquareSearchGroupBox.ResumeLayout(false);
            this.bookingSquareSearchGroupBox.PerformLayout();
            this.bookingSortColGroupBox.ResumeLayout(false);
            this.bookingSortColGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            this.employeeSortGroupBox.ResumeLayout(false);
            this.employeeSortGroupBox.PerformLayout();
            this.employeeSearchGroupBox.ResumeLayout(false);
            this.employeeSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panelTradeProfile.ResumeLayout(false);
            this.panelTradeProfile.PerformLayout();
            this.tradeProfileSortGroupBox.ResumeLayout(false);
            this.tradeProfileSortGroupBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeProfile)).EndInit();
            this.panelOutlet.ResumeLayout(false);
            this.panelOutlet.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBooking;
        private MartDBDataSet martDBDataSet;
        private System.Windows.Forms.Label bookingPanelLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox bookingSquareSearchGroupBox;
        private System.Windows.Forms.GroupBox bookingSortColGroupBox;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.ListBox listBoxFieldsForSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchSquare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox leftSquareBoundTextBox;
        private System.Windows.Forms.Button btnShowAllBookings;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label panelMainLabel;
        private System.Windows.Forms.Button btnNextPanel;
        private System.Windows.Forms.Button btnPanelMain;
        private System.Windows.Forms.Button btnPreviousPanel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem bookingHandlingToolStripMenuItem;
        private System.Windows.Forms.TextBox rightSquareBoundtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bookingSearchFloorGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rightFloorBoundTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox leftFloorBoundTextBox;
        private System.Windows.Forms.Button btnFloorSearch;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MartDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager bookingTableAdapterManager;
        private MartDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager areaTableAdapterManager;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MartDBDataSetTableAdapters.TableAdapterManager employeeTableAdapterManager;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox employeeSearchGroupBox;
        private System.Windows.Forms.Label employeeSearchColLabel;
        private System.Windows.Forms.TextBox employeeQueryTextBox;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label employeeQueryLabel;
        private System.Windows.Forms.ListBox employeeSearchColListBox;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Button btnPanelEmployee;
        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.GroupBox employeeSortGroupBox;
        private System.Windows.Forms.ListBox employeeSortColListBox;
        private System.Windows.Forms.Button btnSortEmployees;
        private System.Windows.Forms.RadioButton descEmployeeRadioButton;
        private System.Windows.Forms.RadioButton ascEmployeeRadioButton;
        private System.Windows.Forms.Label employeeSortColLabel;
        private System.Windows.Forms.Button btnHandleEmployeeForm;
        private System.Windows.Forms.Panel panelTradeProfile;
        private System.Windows.Forms.Button btnHandleTradeProfileForm;
        private System.Windows.Forms.GroupBox tradeProfileSortGroupBox;
        private System.Windows.Forms.Button btnSortTradeProfile;
        private System.Windows.Forms.RadioButton descTradeProfileRadioButton;
        private System.Windows.Forms.RadioButton ascTradeProfileRadioButton;
        private System.Windows.Forms.Button btnShowAllTradeProfiles;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label tradeProfileQueryLabel;
        private System.Windows.Forms.TextBox queryTradeProfileTextBox;
        private System.Windows.Forms.Button btnSearchTradeProfile;
        private System.Windows.Forms.DataGridView dgvTradeProfile;
        private System.Windows.Forms.Label employeePanelLabel;
        private System.Windows.Forms.ToolStripMenuItem tradeProfileToolStripMenuItem;
        private System.Windows.Forms.Button btnPanelTradeProfile;
        private System.Windows.Forms.Panel panelOutlet;
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
        private System.Windows.Forms.Button btnPanelOutlet;
        private System.Windows.Forms.ToolStripMenuItem outletToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateBookingDGV;
        private System.Windows.Forms.Button btnUpdateOutletDGV;
        private System.Windows.Forms.Button btnUpdateEmployeeDGV;
        private System.Windows.Forms.Button btnUpdateTradeProfileDGV;
        private System.Windows.Forms.Button btnPanelBooking;
        private System.Windows.Forms.Button btnHandleBookingForm;
    }
}