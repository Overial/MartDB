
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label area_idLabel;
            System.Windows.Forms.Label area_squareLabel;
            System.Windows.Forms.Label floor_numberLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panelArea = new System.Windows.Forms.Panel();
            this.martDBDataSet = new MartDB.MartDBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoveToPanelMain = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMoveToPanelArea = new System.Windows.Forms.Button();
            this.btnMoveToPanelBooking = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.areaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.areaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.area_squareTextBox = new System.Windows.Forms.TextBox();
            this.floor_numberComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            area_idLabel = new System.Windows.Forms.Label();
            area_squareLabel = new System.Windows.Forms.Label();
            floor_numberLabel = new System.Windows.Forms.Label();
            this.panelArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).BeginInit();
            this.areaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных ТЦ \"Тессеракт\"";
            // 
            // panelArea
            // 
            this.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArea.Controls.Add(this.listBox1);
            this.panelArea.Controls.Add(this.button2);
            this.panelArea.Controls.Add(floor_numberLabel);
            this.panelArea.Controls.Add(this.floor_numberComboBox);
            this.panelArea.Controls.Add(area_squareLabel);
            this.panelArea.Controls.Add(this.area_squareTextBox);
            this.panelArea.Controls.Add(area_idLabel);
            this.panelArea.Controls.Add(this.area_idNumericUpDown);
            this.panelArea.Controls.Add(this.areaDataGridView);
            this.panelArea.Controls.Add(this.pictureBox1);
            this.panelArea.Controls.Add(this.label2);
            this.panelArea.Location = new System.Drawing.Point(12, 75);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(948, 437);
            this.panelArea.TabIndex = 1;
            // 
            // martDBDataSet
            // 
            this.martDBDataSet.DataSetName = "MartDBDataSet";
            this.martDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 12);
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
            this.panelBooking.Controls.Add(this.pictureBox2);
            this.panelBooking.Location = new System.Drawing.Point(12, 75);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(948, 430);
            this.panelBooking.TabIndex = 11;
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
            this.bookingToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.pagesToolStripMenuItem.Text = "Страницы";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.areaToolStripMenuItem.Text = "Помещение";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookingToolStripMenuItem.Text = "Бронь";
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "О программе";
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnMoveToPanelBooking);
            this.panelMain.Controls.Add(this.btnMoveToPanelArea);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Location = new System.Drawing.Point(12, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 430);
            this.panelMain.TabIndex = 13;
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
            // btnMoveToPanelArea
            // 
            this.btnMoveToPanelArea.Location = new System.Drawing.Point(401, 94);
            this.btnMoveToPanelArea.Name = "btnMoveToPanelArea";
            this.btnMoveToPanelArea.Size = new System.Drawing.Size(130, 53);
            this.btnMoveToPanelArea.TabIndex = 1;
            this.btnMoveToPanelArea.Text = "Помещение";
            this.btnMoveToPanelArea.UseVisualStyleBackColor = true;
            this.btnMoveToPanelArea.Click += new System.EventHandler(this.btnMoveToPanelArea_Click);
            // 
            // btnMoveToPanelBooking
            // 
            this.btnMoveToPanelBooking.Location = new System.Drawing.Point(401, 161);
            this.btnMoveToPanelBooking.Name = "btnMoveToPanelBooking";
            this.btnMoveToPanelBooking.Size = new System.Drawing.Size(130, 53);
            this.btnMoveToPanelBooking.TabIndex = 2;
            this.btnMoveToPanelBooking.Text = "Бронь";
            this.btnMoveToPanelBooking.UseVisualStyleBackColor = true;
            this.btnMoveToPanelBooking.Click += new System.EventHandler(this.btnMoveToBookingArea_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(537, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // areaBindingNavigatorSaveItem
            // 
            this.areaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.areaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("areaBindingNavigatorSaveItem.Image")));
            this.areaBindingNavigatorSaveItem.Name = "areaBindingNavigatorSaveItem";
            this.areaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.areaBindingNavigatorSaveItem.Text = "Save Data";
            this.areaBindingNavigatorSaveItem.Click += new System.EventHandler(this.areaBindingNavigatorSaveItem_Click);
            // 
            // areaBindingNavigator
            // 
            this.areaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.areaBindingNavigator.BindingSource = this.areaBindingSource;
            this.areaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.areaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.areaBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.areaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.areaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.areaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.areaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.areaBindingNavigator.Name = "areaBindingNavigator";
            this.areaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.areaBindingNavigator.Size = new System.Drawing.Size(971, 27);
            this.areaBindingNavigator.TabIndex = 2;
            this.areaBindingNavigator.Text = "bindingNavigator1";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrganisationTableAdapter = null;
            this.tableAdapterManager.OutletTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.TradeProfileTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MartDB.MartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.martDBDataSet;
            // 
            // areaDataGridView
            // 
            this.areaDataGridView.AutoGenerateColumns = false;
            this.areaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.areaDataGridView.DataSource = this.areaBindingSource;
            this.areaDataGridView.Location = new System.Drawing.Point(12, 161);
            this.areaDataGridView.Name = "areaDataGridView";
            this.areaDataGridView.RowHeadersWidth = 51;
            this.areaDataGridView.RowTemplate.Height = 24;
            this.areaDataGridView.Size = new System.Drawing.Size(491, 254);
            this.areaDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "area_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "area_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "area_square";
            this.dataGridViewTextBoxColumn2.HeaderText = "area_square";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "floor_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "floor_number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // area_idLabel
            // 
            area_idLabel.AutoSize = true;
            area_idLabel.Location = new System.Drawing.Point(18, 50);
            area_idLabel.Name = "area_idLabel";
            area_idLabel.Size = new System.Drawing.Size(117, 17);
            area_idLabel.TabIndex = 12;
            area_idLabel.Text = "Код помещения:";
            // 
            // area_idNumericUpDown
            // 
            this.area_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.areaBindingSource, "area_id", true));
            this.area_idNumericUpDown.Location = new System.Drawing.Point(219, 48);
            this.area_idNumericUpDown.Name = "area_idNumericUpDown";
            this.area_idNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.area_idNumericUpDown.TabIndex = 13;
            // 
            // area_squareLabel
            // 
            area_squareLabel.AutoSize = true;
            area_squareLabel.Location = new System.Drawing.Point(18, 85);
            area_squareLabel.Name = "area_squareLabel";
            area_squareLabel.Size = new System.Drawing.Size(152, 17);
            area_squareLabel.TabIndex = 13;
            area_squareLabel.Text = "Площадь помещения:";
            // 
            // area_squareTextBox
            // 
            this.area_squareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "area_square", true));
            this.area_squareTextBox.Location = new System.Drawing.Point(219, 82);
            this.area_squareTextBox.Name = "area_squareTextBox";
            this.area_squareTextBox.Size = new System.Drawing.Size(100, 22);
            this.area_squareTextBox.TabIndex = 14;
            // 
            // floor_numberLabel
            // 
            floor_numberLabel.AutoSize = true;
            floor_numberLabel.Location = new System.Drawing.Point(18, 120);
            floor_numberLabel.Name = "floor_numberLabel";
            floor_numberLabel.Size = new System.Drawing.Size(98, 17);
            floor_numberLabel.TabIndex = 14;
            floor_numberLabel.Text = "Номер этажа:";
            // 
            // floor_numberComboBox
            // 
            this.floor_numberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "floor_number", true));
            this.floor_numberComboBox.FormattingEnabled = true;
            this.floor_numberComboBox.Location = new System.Drawing.Point(219, 117);
            this.floor_numberComboBox.Name = "floor_numberComboBox";
            this.floor_numberComboBox.Size = new System.Drawing.Size(121, 24);
            this.floor_numberComboBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(684, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 605);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.btnMoveToPanelMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.areaBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "БД ТЦ \"Тессеракт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelArea.ResumeLayout(false);
            this.panelArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).EndInit();
            this.areaBindingNavigator.ResumeLayout(false);
            this.areaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private MartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.DataGridView areaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox floor_numberComboBox;
        private System.Windows.Forms.TextBox area_squareTextBox;
        private System.Windows.Forms.NumericUpDown area_idNumericUpDown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}