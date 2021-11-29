
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
            System.Windows.Forms.Label area_idLabel;
            System.Windows.Forms.Label area_squareLabel;
            System.Windows.Forms.Label floor_numberLabel;
            System.Windows.Forms.Label booking_idLabel;
            System.Windows.Forms.Label org_idLabel;
            System.Windows.Forms.Label area_idLabel1;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label booking_start_dateLabel;
            System.Windows.Forms.Label booking_end_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label org_idLabel1;
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label emailLabel;
            this.panelArea = new System.Windows.Forms.Panel();
            this.floor_numberComboBox = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martDBDataSet = new MartDB.MartDBDataSet();
            this.areaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.areaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.area_squareTextBox = new System.Windows.Forms.TextBox();
            this.areaDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoveToPanelMain = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.bookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bookingAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bookingDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bookingMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bookingMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bookingSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bookingPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bookingSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bookingMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bookingSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.booking_start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.area_idTextBox = new System.Windows.Forms.TextBox();
            this.org_idTextBox = new System.Windows.Forms.TextBox();
            this.booking_idTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnMoveToPanelBooking = new System.Windows.Forms.Button();
            this.btnMoveToPanelArea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.areaTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.bookingTableAdapter = new MartDB.MartDBDataSetTableAdapters.BookingTableAdapter();
            this.bookingTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.area_idTextBox1 = new System.Windows.Forms.TextBox();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new MartDB.MartDBDataSetTableAdapters.EmployeeTableAdapter();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.employeeTableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveToPanelEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.employeeAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employeeCountItem = new System.Windows.Forms.ToolStripLabel();
            this.employeeDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeeMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.employeeMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.employeeSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.employeePositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.employeeSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.employeeMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.employeeSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxFieldsForSort = new System.Windows.Forms.ListBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.areaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxFieldsForSearch = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.queryForSearchTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            area_idLabel = new System.Windows.Forms.Label();
            area_squareLabel = new System.Windows.Forms.Label();
            floor_numberLabel = new System.Windows.Forms.Label();
            booking_idLabel = new System.Windows.Forms.Label();
            org_idLabel = new System.Windows.Forms.Label();
            area_idLabel1 = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            booking_start_dateLabel = new System.Windows.Forms.Label();
            booking_end_dateLabel = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            org_idLabel1 = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panelArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).BeginInit();
            this.areaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).BeginInit();
            this.bookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // area_idLabel
            // 
            area_idLabel.AutoSize = true;
            area_idLabel.Location = new System.Drawing.Point(10, 99);
            area_idLabel.Name = "area_idLabel";
            area_idLabel.Size = new System.Drawing.Size(117, 17);
            area_idLabel.TabIndex = 12;
            area_idLabel.Text = "Код помещения:";
            // 
            // area_squareLabel
            // 
            area_squareLabel.AutoSize = true;
            area_squareLabel.Location = new System.Drawing.Point(10, 131);
            area_squareLabel.Name = "area_squareLabel";
            area_squareLabel.Size = new System.Drawing.Size(152, 17);
            area_squareLabel.TabIndex = 13;
            area_squareLabel.Text = "Площадь помещения:";
            // 
            // floor_numberLabel
            // 
            floor_numberLabel.AutoSize = true;
            floor_numberLabel.Location = new System.Drawing.Point(10, 166);
            floor_numberLabel.Name = "floor_numberLabel";
            floor_numberLabel.Size = new System.Drawing.Size(98, 17);
            floor_numberLabel.TabIndex = 14;
            floor_numberLabel.Text = "Номер этажа:";
            // 
            // booking_idLabel
            // 
            booking_idLabel.AutoSize = true;
            booking_idLabel.Location = new System.Drawing.Point(10, 79);
            booking_idLabel.Name = "booking_idLabel";
            booking_idLabel.Size = new System.Drawing.Size(81, 17);
            booking_idLabel.TabIndex = 13;
            booking_idLabel.Text = "Код брони:";
            // 
            // org_idLabel
            // 
            org_idLabel.AutoSize = true;
            org_idLabel.Location = new System.Drawing.Point(10, 109);
            org_idLabel.Name = "org_idLabel";
            org_idLabel.Size = new System.Drawing.Size(125, 17);
            org_idLabel.TabIndex = 14;
            org_idLabel.Text = "Код организации:";
            // 
            // area_idLabel1
            // 
            area_idLabel1.AutoSize = true;
            area_idLabel1.Location = new System.Drawing.Point(10, 145);
            area_idLabel1.Name = "area_idLabel1";
            area_idLabel1.Size = new System.Drawing.Size(117, 17);
            area_idLabel1.TabIndex = 15;
            area_idLabel1.Text = "Код помещения:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(10, 179);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(82, 17);
            costLabel.TabIndex = 16;
            costLabel.Text = "Стоимость:";
            // 
            // booking_start_dateLabel
            // 
            booking_start_dateLabel.AutoSize = true;
            booking_start_dateLabel.Location = new System.Drawing.Point(10, 213);
            booking_start_dateLabel.Name = "booking_start_dateLabel";
            booking_start_dateLabel.Size = new System.Drawing.Size(166, 17);
            booking_start_dateLabel.TabIndex = 17;
            booking_start_dateLabel.Text = "Начало периода брони:";
            // 
            // booking_end_dateLabel
            // 
            booking_end_dateLabel.AutoSize = true;
            booking_end_dateLabel.Location = new System.Drawing.Point(10, 246);
            booking_end_dateLabel.Name = "booking_end_dateLabel";
            booking_end_dateLabel.Size = new System.Drawing.Size(157, 17);
            booking_end_dateLabel.TabIndex = 18;
            booking_end_dateLabel.Text = "Конец периода брони:";
            // 
            // panelArea
            // 
            this.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArea.Controls.Add(this.groupBox2);
            this.panelArea.Controls.Add(this.groupBox1);
            this.panelArea.Controls.Add(this.area_idTextBox1);
            this.panelArea.Controls.Add(floor_numberLabel);
            this.panelArea.Controls.Add(this.floor_numberComboBox);
            this.panelArea.Controls.Add(area_squareLabel);
            this.panelArea.Controls.Add(this.areaBindingNavigator);
            this.panelArea.Controls.Add(this.area_squareTextBox);
            this.panelArea.Controls.Add(area_idLabel);
            this.panelArea.Controls.Add(this.areaDataGridView);
            this.panelArea.Controls.Add(this.pictureBox1);
            this.panelArea.Controls.Add(this.label2);
            this.panelArea.Location = new System.Drawing.Point(12, 33);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(948, 479);
            this.panelArea.TabIndex = 1;
            // 
            // floor_numberComboBox
            // 
            this.floor_numberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "floor_number", true));
            this.floor_numberComboBox.FormattingEnabled = true;
            this.floor_numberComboBox.Location = new System.Drawing.Point(211, 166);
            this.floor_numberComboBox.Name = "floor_numberComboBox";
            this.floor_numberComboBox.Size = new System.Drawing.Size(121, 24);
            this.floor_numberComboBox.TabIndex = 15;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.martDBDataSet;
            // 
            // martDBDataSet
            // 
            this.martDBDataSet.DataSetName = "MartDBDataSet";
            this.martDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaBindingNavigator
            // 
            this.areaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.areaBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.areaBindingNavigator.BindingSource = this.areaBindingSource;
            this.areaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.areaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.areaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.areaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.areaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.areaBindingNavigatorSaveItem});
            this.areaBindingNavigator.Location = new System.Drawing.Point(12, 40);
            this.areaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.areaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.areaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.areaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.areaBindingNavigator.Name = "areaBindingNavigator";
            this.areaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.areaBindingNavigator.Size = new System.Drawing.Size(331, 27);
            this.areaBindingNavigator.TabIndex = 2;
            this.areaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "of {0}";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // areaBindingNavigatorSaveItem
            // 
            this.areaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.areaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("areaBindingNavigatorSaveItem.Image")));
            this.areaBindingNavigatorSaveItem.Name = "areaBindingNavigatorSaveItem";
            this.areaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.areaBindingNavigatorSaveItem.Text = "Save Data";
            this.areaBindingNavigatorSaveItem.Click += new System.EventHandler(this.areaBindingNavigatorSaveItem_Click);
            // 
            // area_squareTextBox
            // 
            this.area_squareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "area_square", true));
            this.area_squareTextBox.Location = new System.Drawing.Point(211, 131);
            this.area_squareTextBox.Name = "area_squareTextBox";
            this.area_squareTextBox.Size = new System.Drawing.Size(100, 22);
            this.area_squareTextBox.TabIndex = 14;
            // 
            // areaDataGridView
            // 
            this.areaDataGridView.AutoGenerateColumns = false;
            this.areaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaDataGridViewTextBoxColumn1,
            this.areaDataGridViewTextBoxColumn2,
            this.areaDataGridViewTextBoxColumn3});
            this.areaDataGridView.DataSource = this.areaBindingSource;
            this.areaDataGridView.Location = new System.Drawing.Point(384, 15);
            this.areaDataGridView.Name = "areaDataGridView";
            this.areaDataGridView.RowHeadersWidth = 51;
            this.areaDataGridView.RowTemplate.Height = 24;
            this.areaDataGridView.Size = new System.Drawing.Size(545, 269);
            this.areaDataGridView.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Панель управления: \"Помещение\"";
            // 
            // btnMoveToPanelMain
            // 
            this.btnMoveToPanelMain.Location = new System.Drawing.Point(34, 534);
            this.btnMoveToPanelMain.Name = "btnMoveToPanelMain";
            this.btnMoveToPanelMain.Size = new System.Drawing.Size(201, 59);
            this.btnMoveToPanelMain.TabIndex = 8;
            this.btnMoveToPanelMain.Text = "На главную";
            this.btnMoveToPanelMain.UseVisualStyleBackColor = true;
            this.btnMoveToPanelMain.Click += new System.EventHandler(this.btnMoveToMain_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(511, 522);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(110, 58);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Предыдущая страница";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(648, 522);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 58);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Следующая страница";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelBooking
            // 
            this.panelBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBooking.Controls.Add(this.bookingBindingNavigator);
            this.panelBooking.Controls.Add(this.label1);
            this.panelBooking.Controls.Add(this.bookingDataGridView);
            this.panelBooking.Controls.Add(booking_end_dateLabel);
            this.panelBooking.Controls.Add(this.booking_end_dateDateTimePicker);
            this.panelBooking.Controls.Add(booking_start_dateLabel);
            this.panelBooking.Controls.Add(this.booking_start_dateDateTimePicker);
            this.panelBooking.Controls.Add(costLabel);
            this.panelBooking.Controls.Add(this.costTextBox);
            this.panelBooking.Controls.Add(area_idLabel1);
            this.panelBooking.Controls.Add(this.area_idTextBox);
            this.panelBooking.Controls.Add(org_idLabel);
            this.panelBooking.Controls.Add(this.org_idTextBox);
            this.panelBooking.Controls.Add(booking_idLabel);
            this.panelBooking.Controls.Add(this.booking_idTextBox);
            this.panelBooking.Controls.Add(this.pictureBox2);
            this.panelBooking.Location = new System.Drawing.Point(12, 33);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(948, 479);
            this.panelBooking.TabIndex = 11;
            // 
            // bookingBindingNavigator
            // 
            this.bookingBindingNavigator.AddNewItem = this.bookingAddNewItem;
            this.bookingBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bookingBindingNavigator.BindingSource = this.bookingBindingSource;
            this.bookingBindingNavigator.CountItem = this.bookingCountItem;
            this.bookingBindingNavigator.DeleteItem = this.bookingDeleteItem;
            this.bookingBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bookingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingMoveFirstItem,
            this.bookingMovePreviousItem,
            this.bookingSeparator,
            this.bookingPositionItem,
            this.bookingCountItem,
            this.bookingSeparator1,
            this.bookingMoveNextItem,
            this.bookingMoveLastItem,
            this.bookingSeparator2,
            this.bookingAddNewItem,
            this.bookingDeleteItem,
            this.bookingSaveItem});
            this.bookingBindingNavigator.Location = new System.Drawing.Point(12, 40);
            this.bookingBindingNavigator.MoveFirstItem = this.bookingMoveFirstItem;
            this.bookingBindingNavigator.MoveLastItem = this.bookingMoveLastItem;
            this.bookingBindingNavigator.MoveNextItem = this.bookingMoveNextItem;
            this.bookingBindingNavigator.MovePreviousItem = this.bookingMovePreviousItem;
            this.bookingBindingNavigator.Name = "bookingBindingNavigator";
            this.bookingBindingNavigator.PositionItem = this.bookingPositionItem;
            this.bookingBindingNavigator.Size = new System.Drawing.Size(331, 27);
            this.bookingBindingNavigator.TabIndex = 21;
            this.bookingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bookingAddNewItem
            // 
            this.bookingAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingAddNewItem.Image")));
            this.bookingAddNewItem.Name = "bookingAddNewItem";
            this.bookingAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bookingAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bookingAddNewItem.Text = "Add new";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.martDBDataSet;
            // 
            // bookingCountItem
            // 
            this.bookingCountItem.Name = "bookingCountItem";
            this.bookingCountItem.Size = new System.Drawing.Size(45, 24);
            this.bookingCountItem.Text = "of {0}";
            this.bookingCountItem.ToolTipText = "Total number of items";
            // 
            // bookingDeleteItem
            // 
            this.bookingDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingDeleteItem.Image")));
            this.bookingDeleteItem.Name = "bookingDeleteItem";
            this.bookingDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bookingDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bookingDeleteItem.Text = "Delete";
            // 
            // bookingMoveFirstItem
            // 
            this.bookingMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingMoveFirstItem.Image")));
            this.bookingMoveFirstItem.Name = "bookingMoveFirstItem";
            this.bookingMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bookingMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bookingMoveFirstItem.Text = "Move first";
            // 
            // bookingMovePreviousItem
            // 
            this.bookingMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingMovePreviousItem.Image")));
            this.bookingMovePreviousItem.Name = "bookingMovePreviousItem";
            this.bookingMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bookingMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bookingMovePreviousItem.Text = "Move previous";
            // 
            // bookingSeparator
            // 
            this.bookingSeparator.Name = "bookingSeparator";
            this.bookingSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bookingPositionItem
            // 
            this.bookingPositionItem.AccessibleName = "Position";
            this.bookingPositionItem.AutoSize = false;
            this.bookingPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookingPositionItem.Name = "bookingPositionItem";
            this.bookingPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bookingPositionItem.Text = "0";
            this.bookingPositionItem.ToolTipText = "Current position";
            // 
            // bookingSeparator1
            // 
            this.bookingSeparator1.Name = "bookingSeparator1";
            this.bookingSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bookingMoveNextItem
            // 
            this.bookingMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingMoveNextItem.Image")));
            this.bookingMoveNextItem.Name = "bookingMoveNextItem";
            this.bookingMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bookingMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bookingMoveNextItem.Text = "Move next";
            // 
            // bookingMoveLastItem
            // 
            this.bookingMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingMoveLastItem.Image")));
            this.bookingMoveLastItem.Name = "bookingMoveLastItem";
            this.bookingMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bookingMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bookingMoveLastItem.Text = "Move last";
            // 
            // bookingSeparator2
            // 
            this.bookingSeparator2.Name = "bookingSeparator2";
            this.bookingSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bookingSaveItem
            // 
            this.bookingSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingSaveItem.Image")));
            this.bookingSaveItem.Name = "bookingSaveItem";
            this.bookingSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bookingSaveItem.Text = "Save Data";
            this.bookingSaveItem.Click += new System.EventHandler(this.bookingSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Панель управления: \"Бронь\"";
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(12, 290);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowHeadersWidth = 51;
            this.bookingDataGridView.RowTemplate.Height = 24;
            this.bookingDataGridView.Size = new System.Drawing.Size(464, 178);
            this.bookingDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "booking_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "booking_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "org_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "org_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "area_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "area_id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn7.HeaderText = "cost";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "booking_start_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "booking_start_date";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "booking_end_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "booking_end_date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // booking_end_dateDateTimePicker
            // 
            this.booking_end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingBindingSource, "booking_end_date", true));
            this.booking_end_dateDateTimePicker.Location = new System.Drawing.Point(203, 246);
            this.booking_end_dateDateTimePicker.Name = "booking_end_dateDateTimePicker";
            this.booking_end_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.booking_end_dateDateTimePicker.TabIndex = 19;
            // 
            // booking_start_dateDateTimePicker
            // 
            this.booking_start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingBindingSource, "booking_start_date", true));
            this.booking_start_dateDateTimePicker.Location = new System.Drawing.Point(203, 213);
            this.booking_start_dateDateTimePicker.Name = "booking_start_dateDateTimePicker";
            this.booking_start_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.booking_start_dateDateTimePicker.TabIndex = 18;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(203, 176);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 17;
            // 
            // area_idTextBox
            // 
            this.area_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "area_id", true));
            this.area_idTextBox.Location = new System.Drawing.Point(203, 142);
            this.area_idTextBox.Name = "area_idTextBox";
            this.area_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.area_idTextBox.TabIndex = 16;
            // 
            // org_idTextBox
            // 
            this.org_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "org_id", true));
            this.org_idTextBox.Location = new System.Drawing.Point(203, 106);
            this.org_idTextBox.Name = "org_idTextBox";
            this.org_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.org_idTextBox.TabIndex = 15;
            // 
            // booking_idTextBox
            // 
            this.booking_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "booking_id", true));
            this.booking_idTextBox.Location = new System.Drawing.Point(203, 76);
            this.booking_idTextBox.Name = "booking_idTextBox";
            this.booking_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.booking_idTextBox.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(674, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
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
            this.areaToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.pagesToolStripMenuItem.Text = "Страницы";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.areaToolStripMenuItem.Text = "Помещение";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookingToolStripMenuItem.Text = "Бронь";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
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
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.pictureBox4);
            this.panelMain.Controls.Add(this.button6);
            this.panelMain.Controls.Add(this.button5);
            this.panelMain.Controls.Add(this.button4);
            this.panelMain.Controls.Add(this.button3);
            this.panelMain.Controls.Add(this.button2);
            this.panelMain.Controls.Add(this.btnMoveToPanelEmployee);
            this.panelMain.Controls.Add(this.btnMoveToPanelBooking);
            this.panelMain.Controls.Add(this.btnMoveToPanelArea);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Location = new System.Drawing.Point(12, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 479);
            this.panelMain.TabIndex = 13;
            // 
            // btnMoveToPanelBooking
            // 
            this.btnMoveToPanelBooking.Location = new System.Drawing.Point(480, 191);
            this.btnMoveToPanelBooking.Name = "btnMoveToPanelBooking";
            this.btnMoveToPanelBooking.Size = new System.Drawing.Size(130, 53);
            this.btnMoveToPanelBooking.TabIndex = 2;
            this.btnMoveToPanelBooking.Text = "Бронь";
            this.btnMoveToPanelBooking.UseVisualStyleBackColor = true;
            this.btnMoveToPanelBooking.Click += new System.EventHandler(this.btnMoveToBookingArea_Click);
            // 
            // btnMoveToPanelArea
            // 
            this.btnMoveToPanelArea.Location = new System.Drawing.Point(480, 124);
            this.btnMoveToPanelArea.Name = "btnMoveToPanelArea";
            this.btnMoveToPanelArea.Size = new System.Drawing.Size(130, 53);
            this.btnMoveToPanelArea.TabIndex = 1;
            this.btnMoveToPanelArea.Text = "Помещение";
            this.btnMoveToPanelArea.UseVisualStyleBackColor = true;
            this.btnMoveToPanelArea.Click += new System.EventHandler(this.btnMoveToPanelArea_Click);
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
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
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
            // area_idTextBox1
            // 
            this.area_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "area_id", true));
            this.area_idTextBox1.Location = new System.Drawing.Point(211, 99);
            this.area_idTextBox1.Name = "area_idTextBox1";
            this.area_idTextBox1.Size = new System.Drawing.Size(100, 22);
            this.area_idTextBox1.TabIndex = 16;
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.employeeBindingNavigator);
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
            this.panelEmployee.Size = new System.Drawing.Size(948, 485);
            this.panelEmployee.TabIndex = 14;
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.martDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
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
            // employee_idTextBox
            // 
            this.employee_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "employee_id", true));
            this.employee_idTextBox.Location = new System.Drawing.Point(174, 97);
            this.employee_idTextBox.Name = "employee_idTextBox";
            this.employee_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.employee_idTextBox.TabIndex = 2;
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
            // org_idTextBox1
            // 
            this.org_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "org_id", true));
            this.org_idTextBox1.Location = new System.Drawing.Point(174, 129);
            this.org_idTextBox1.Name = "org_idTextBox1";
            this.org_idTextBox1.Size = new System.Drawing.Size(100, 22);
            this.org_idTextBox1.TabIndex = 4;
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
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(174, 161);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 22);
            this.fioTextBox.TabIndex = 6;
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
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(174, 193);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 8;
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
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "position", true));
            this.positionTextBox.Location = new System.Drawing.Point(174, 224);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 10;
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
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(174, 258);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.phone_numberTextBox.TabIndex = 12;
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
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "email", true));
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
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeToolStripMenuItem.Text = "Сотрудник";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // btnMoveToPanelEmployee
            // 
            this.btnMoveToPanelEmployee.Location = new System.Drawing.Point(480, 260);
            this.btnMoveToPanelEmployee.Name = "btnMoveToPanelEmployee";
            this.btnMoveToPanelEmployee.Size = new System.Drawing.Size(130, 53);
            this.btnMoveToPanelEmployee.TabIndex = 3;
            this.btnMoveToPanelEmployee.Text = "Сотрудник";
            this.btnMoveToPanelEmployee.UseVisualStyleBackColor = true;
            this.btnMoveToPanelEmployee.Click += new System.EventHandler(this.btnMoveToPanelEmployee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Организация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Торговая точка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Отзыв";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(736, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "Торговый профиль";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(736, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 53);
            this.button6.TabIndex = 8;
            this.button6.Text = "Пользователи";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.employeeAddNewItem;
            this.employeeBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.employeeCountItem;
            this.employeeBindingNavigator.DeleteItem = this.employeeDeleteItem;
            this.employeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.employeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMoveFirstItem,
            this.employeeMovePreviousItem,
            this.employeeSeparator,
            this.employeePositionItem,
            this.employeeCountItem,
            this.employeeSeparator1,
            this.employeeMoveNextItem,
            this.employeeMoveLastItem,
            this.employeeSeparator2,
            this.employeeAddNewItem,
            this.employeeDeleteItem,
            this.employeeSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(13, 47);
            this.employeeBindingNavigator.MoveFirstItem = this.employeeMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.employeeMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.employeeMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.employeeMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.employeePositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(331, 27);
            this.employeeBindingNavigator.TabIndex = 22;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // employeeAddNewItem
            // 
            this.employeeAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeAddNewItem.Image")));
            this.employeeAddNewItem.Name = "employeeAddNewItem";
            this.employeeAddNewItem.RightToLeftAutoMirrorImage = true;
            this.employeeAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.employeeAddNewItem.Text = "Add new";
            // 
            // employeeCountItem
            // 
            this.employeeCountItem.Name = "employeeCountItem";
            this.employeeCountItem.Size = new System.Drawing.Size(45, 24);
            this.employeeCountItem.Text = "of {0}";
            this.employeeCountItem.ToolTipText = "Total number of items";
            // 
            // employeeDeleteItem
            // 
            this.employeeDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeDeleteItem.Image")));
            this.employeeDeleteItem.Name = "employeeDeleteItem";
            this.employeeDeleteItem.RightToLeftAutoMirrorImage = true;
            this.employeeDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.employeeDeleteItem.Text = "Delete";
            // 
            // employeeMoveFirstItem
            // 
            this.employeeMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeMoveFirstItem.Image")));
            this.employeeMoveFirstItem.Name = "employeeMoveFirstItem";
            this.employeeMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.employeeMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.employeeMoveFirstItem.Text = "Move first";
            // 
            // employeeMovePreviousItem
            // 
            this.employeeMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeMovePreviousItem.Image")));
            this.employeeMovePreviousItem.Name = "employeeMovePreviousItem";
            this.employeeMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.employeeMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.employeeMovePreviousItem.Text = "Move previous";
            // 
            // employeeSeparator
            // 
            this.employeeSeparator.Name = "employeeSeparator";
            this.employeeSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // employeePositionItem
            // 
            this.employeePositionItem.AccessibleName = "Position";
            this.employeePositionItem.AutoSize = false;
            this.employeePositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.employeePositionItem.Name = "employeePositionItem";
            this.employeePositionItem.Size = new System.Drawing.Size(50, 27);
            this.employeePositionItem.Text = "0";
            this.employeePositionItem.ToolTipText = "Current position";
            // 
            // employeeSeparator1
            // 
            this.employeeSeparator1.Name = "employeeSeparator1";
            this.employeeSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // employeeMoveNextItem
            // 
            this.employeeMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeMoveNextItem.Image")));
            this.employeeMoveNextItem.Name = "employeeMoveNextItem";
            this.employeeMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.employeeMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.employeeMoveNextItem.Text = "Move next";
            // 
            // employeeMoveLastItem
            // 
            this.employeeMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeMoveLastItem.Image")));
            this.employeeMoveLastItem.Name = "employeeMoveLastItem";
            this.employeeMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.employeeMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.employeeMoveLastItem.Text = "Move last";
            // 
            // employeeSeparator2
            // 
            this.employeeSeparator2.Name = "employeeSeparator2";
            this.employeeSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // employeeSaveItem
            // 
            this.employeeSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeSaveItem.Image")));
            this.employeeSaveItem.Name = "employeeSaveItem";
            this.employeeSaveItem.Size = new System.Drawing.Size(29, 24);
            this.employeeSaveItem.Text = "Save Data";
            this.employeeSaveItem.Click += new System.EventHandler(this.employeeSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.radioButtonDesc);
            this.groupBox1.Controls.Add(this.radioButtonAsc);
            this.groupBox1.Controls.Add(this.listBoxFieldsForSort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(657, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 175);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
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
            // listBoxFieldsForSort
            // 
            this.listBoxFieldsForSort.FormattingEnabled = true;
            this.listBoxFieldsForSort.ItemHeight = 16;
            this.listBoxFieldsForSort.Items.AddRange(new object[] {
            "Код помещения",
            "Площадь помещения",
            "Номер этажа"});
            this.listBoxFieldsForSort.Location = new System.Drawing.Point(9, 38);
            this.listBoxFieldsForSort.Name = "listBoxFieldsForSort";
            this.listBoxFieldsForSort.Size = new System.Drawing.Size(114, 132);
            this.listBoxFieldsForSort.TabIndex = 1;
            this.listBoxFieldsForSort.SelectedIndexChanged += new System.EventHandler(this.listBoxFieldsForSort_SelectedIndexChanged);
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(129, 38);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(137, 21);
            this.radioButtonAsc.TabIndex = 2;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "По возрастанию";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(129, 65);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(117, 21);
            this.radioButtonDesc.TabIndex = 3;
            this.radioButtonDesc.Text = "По убыванию";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(138, 108);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(119, 42);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.queryForSearchTextBox);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBoxFieldsForSearch);
            this.groupBox2.Location = new System.Drawing.Point(363, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 175);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // areaDataGridViewTextBoxColumn1
            // 
            this.areaDataGridViewTextBoxColumn1.DataPropertyName = "area_id";
            this.areaDataGridViewTextBoxColumn1.HeaderText = "Код помещения";
            this.areaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn1.Name = "areaDataGridViewTextBoxColumn1";
            this.areaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn2
            // 
            this.areaDataGridViewTextBoxColumn2.DataPropertyName = "area_square";
            this.areaDataGridViewTextBoxColumn2.HeaderText = "Площадь помещения";
            this.areaDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn2.Name = "areaDataGridViewTextBoxColumn2";
            this.areaDataGridViewTextBoxColumn2.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn3
            // 
            this.areaDataGridViewTextBoxColumn3.DataPropertyName = "floor_number";
            this.areaDataGridViewTextBoxColumn3.HeaderText = "Номер этажа";
            this.areaDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn3.Name = "areaDataGridViewTextBoxColumn3";
            this.areaDataGridViewTextBoxColumn3.Width = 125;
            // 
            // listBoxFieldsForSearch
            // 
            this.listBoxFieldsForSearch.FormattingEnabled = true;
            this.listBoxFieldsForSearch.ItemHeight = 16;
            this.listBoxFieldsForSearch.Items.AddRange(new object[] {
            "Код помещения",
            "Площадь помещения",
            "Номер этажа"});
            this.listBoxFieldsForSearch.Location = new System.Drawing.Point(9, 37);
            this.listBoxFieldsForSearch.Name = "listBoxFieldsForSearch";
            this.listBoxFieldsForSearch.Size = new System.Drawing.Size(121, 132);
            this.listBoxFieldsForSearch.TabIndex = 5;
            this.listBoxFieldsForSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxFieldsForSearch_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Поле для поиска:";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(146, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 42);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // queryForSearchTextBox
            // 
            this.queryForSearchTextBox.Location = new System.Drawing.Point(146, 38);
            this.queryForSearchTextBox.Name = "queryForSearchTextBox";
            this.queryForSearchTextBox.Size = new System.Drawing.Size(119, 22);
            this.queryForSearchTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Введите запрос:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(146, 114);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(119, 42);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(41, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(375, 250);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 605);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.btnMoveToPanelMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "БД ТЦ \"Тессеракт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelArea.ResumeLayout(false);
            this.panelArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).EndInit();
            this.areaBindingNavigator.ResumeLayout(false);
            this.areaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).EndInit();
            this.bookingBindingNavigator.ResumeLayout(false);
            this.bookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelArea;
        private MartDBDataSet martDBDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMoveToPanelMain;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnMoveToPanelBooking;
        private System.Windows.Forms.Button btnMoveToPanelArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton areaBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator areaBindingNavigator;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MartDBDataSetTableAdapters.TableAdapterManager areaTableAdapterManager;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.DataGridView areaDataGridView;
        private System.Windows.Forms.ComboBox floor_numberComboBox;
        private System.Windows.Forms.TextBox area_squareTextBox;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private MartDBDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DateTimePicker booking_end_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker booking_start_dateDateTimePicker;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox area_idTextBox;
        private System.Windows.Forms.TextBox org_idTextBox;
        private System.Windows.Forms.TextBox booking_idTextBox;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private MartDBDataSetTableAdapters.TableAdapterManager bookingTableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bookingAddNewItem;
        private System.Windows.Forms.ToolStripLabel bookingCountItem;
        private System.Windows.Forms.ToolStripButton bookingDeleteItem;
        private System.Windows.Forms.ToolStripButton bookingMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bookingMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bookingSeparator;
        private System.Windows.Forms.ToolStripTextBox bookingPositionItem;
        private System.Windows.Forms.ToolStripSeparator bookingSeparator1;
        private System.Windows.Forms.ToolStripButton bookingMoveNextItem;
        private System.Windows.Forms.ToolStripButton bookingMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bookingSeparator2;
        private System.Windows.Forms.ToolStripButton bookingSaveItem;
        private System.Windows.Forms.TextBox area_idTextBox1;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MartDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox org_idTextBox1;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private MartDBDataSetTableAdapters.TableAdapterManager employeeTableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMoveToPanelEmployee;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton employeeAddNewItem;
        private System.Windows.Forms.ToolStripLabel employeeCountItem;
        private System.Windows.Forms.ToolStripButton employeeDeleteItem;
        private System.Windows.Forms.ToolStripButton employeeMoveFirstItem;
        private System.Windows.Forms.ToolStripButton employeeMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator employeeSeparator;
        private System.Windows.Forms.ToolStripTextBox employeePositionItem;
        private System.Windows.Forms.ToolStripSeparator employeeSeparator1;
        private System.Windows.Forms.ToolStripButton employeeMoveNextItem;
        private System.Windows.Forms.ToolStripButton employeeMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator employeeSeparator2;
        private System.Windows.Forms.ToolStripButton employeeSaveItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.ListBox listBoxFieldsForSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxFieldsForSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox queryForSearchTextBox;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}