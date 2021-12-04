
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
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label org_idLabel1;
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBookingHandling = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBookingHandlingPanel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMoveToPanelMain = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.employee_idTextBox = new System.Windows.Forms.TextBox();
            this.org_idTextBox1 = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.employeeTableAdapter = new MartDB.MartDBDataSetTableAdapters.EmployeeTableAdapter();
            this.bookingTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingTableAdapter = new MartDB.MartDBDataSetTableAdapters.BookingTableAdapter();
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.areaTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            employee_idLabel = new System.Windows.Forms.Label();
            org_idLabel1 = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panelBookingHandling.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHandling)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(11, 97);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(117, 17);
            employee_idLabel.TabIndex = 1;
            employee_idLabel.Text = "Код сотрудника:";
            // 
            // org_idLabel1
            // 
            org_idLabel1.AutoSize = true;
            org_idLabel1.Location = new System.Drawing.Point(11, 129);
            org_idLabel1.Name = "org_idLabel1";
            org_idLabel1.Size = new System.Drawing.Size(125, 17);
            org_idLabel1.TabIndex = 3;
            org_idLabel1.Text = "Код организации:";
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(11, 163);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(46, 17);
            fioLabel.TabIndex = 5;
            fioLabel.Text = "ФИО:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(11, 196);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(38, 17);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Пол:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(11, 226);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(85, 17);
            positionLabel.TabIndex = 9;
            positionLabel.Text = "Должность:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(11, 261);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(125, 17);
            phone_numberLabel.TabIndex = 11;
            phone_numberLabel.Text = "Номер телефона:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(11, 294);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(142, 17);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Электронная почта:";
            // 
            // panelBookingHandling
            // 
            this.panelBookingHandling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookingHandling.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 57);
            this.button2.TabIndex = 20;
            this.button2.Text = "Оформить аренду";
            this.button2.UseVisualStyleBackColor = true;
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
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
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
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.bookingHandlingToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.pagesToolStripMenuItem.Text = "Страницы";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.mainToolStripMenuItem.Text = "Главная";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // bookingHandlingToolStripMenuItem
            // 
            this.bookingHandlingToolStripMenuItem.Name = "bookingHandlingToolStripMenuItem";
            this.bookingHandlingToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.bookingHandlingToolStripMenuItem.Text = "Аренда помещений";
            this.bookingHandlingToolStripMenuItem.Click += new System.EventHandler(this.bookingHandlingToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
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
            this.btnBookingHandlingPanel.Click += new System.EventHandler(this.btnMoveToPanelArea_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Панель управления: \"Сотрудник\"";
            // 
            // employee_idTextBox
            // 
            this.employee_idTextBox.Location = new System.Drawing.Point(174, 97);
            this.employee_idTextBox.Name = "employee_idTextBox";
            this.employee_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.employee_idTextBox.TabIndex = 2;
            // 
            // org_idTextBox1
            // 
            this.org_idTextBox1.Location = new System.Drawing.Point(174, 129);
            this.org_idTextBox1.Name = "org_idTextBox1";
            this.org_idTextBox1.Size = new System.Drawing.Size(100, 22);
            this.org_idTextBox1.TabIndex = 4;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(174, 161);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 22);
            this.fioTextBox.TabIndex = 6;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(174, 193);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 8;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(174, 224);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 10;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.Location = new System.Drawing.Point(174, 258);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.phone_numberTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(174, 291);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 14;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(402, 16);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(528, 253);
            this.employeeDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "org_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "org_id";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn12.HeaderText = "fio";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn13.HeaderText = "gender";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn14.HeaderText = "position";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "phone_number";
            this.dataGridViewTextBoxColumn15.HeaderText = "phone_number";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn16.HeaderText = "email";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.martDBDataSet;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.pictureBox3);
            this.panelEmployee.Controls.Add(this.employeeDataGridView);
            this.panelEmployee.Controls.Add(emailLabel);
            this.panelEmployee.Controls.Add(this.emailTextBox);
            this.panelEmployee.Controls.Add(phone_numberLabel);
            this.panelEmployee.Controls.Add(this.phone_numberTextBox);
            this.panelEmployee.Controls.Add(positionLabel);
            this.panelEmployee.Controls.Add(this.positionTextBox);
            this.panelEmployee.Controls.Add(genderLabel);
            this.panelEmployee.Controls.Add(this.genderTextBox);
            this.panelEmployee.Controls.Add(fioLabel);
            this.panelEmployee.Controls.Add(this.fioTextBox);
            this.panelEmployee.Controls.Add(org_idLabel1);
            this.panelEmployee.Controls.Add(this.org_idTextBox1);
            this.panelEmployee.Controls.Add(employee_idLabel);
            this.panelEmployee.Controls.Add(this.employee_idTextBox);
            this.panelEmployee.Controls.Add(this.label4);
            this.panelEmployee.Location = new System.Drawing.Point(12, 33);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(948, 479);
            this.panelEmployee.TabIndex = 14;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 605);
            this.Controls.Add(this.panelBookingHandling);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private System.Windows.Forms.TextBox org_idTextBox1;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelEmployee;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MartDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager bookingTableAdapterManager;
        private MartDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager areaTableAdapterManager;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MartDBDataSetTableAdapters.TableAdapterManager employeeTableAdapterManager;
    }
}