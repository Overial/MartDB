
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.martDBDataSet = new MartDB.MartDBDataSet();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new MartDB.MartDBDataSetTableAdapters.AreaTableAdapter();
            this.tableAdapterManager = new MartDB.MartDBDataSetTableAdapters.TableAdapterManager();
            this.areaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.floor_numberComboBox = new System.Windows.Forms.ComboBox();
            this.area_squareTextBox = new System.Windows.Forms.TextBox();
            this.area_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.areaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            area_idLabel = new System.Windows.Forms.Label();
            area_squareLabel = new System.Windows.Forms.Label();
            floor_numberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).BeginInit();
            this.areaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).BeginInit();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.areaDataGridView);
            this.panel1.Controls.Add(this.area_idNumericUpDown);
            this.panel1.Controls.Add(this.floor_numberComboBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(floor_numberLabel);
            this.panel1.Controls.Add(area_squareLabel);
            this.panel1.Controls.Add(this.area_squareTextBox);
            this.panel1.Controls.Add(area_idLabel);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 442);
            this.panel1.TabIndex = 1;
            // 
            // martDBDataSet
            // 
            this.martDBDataSet.DataSetName = "MartDBDataSet";
            this.martDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.martDBDataSet;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
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
            this.areaBindingNavigator.Location = new System.Drawing.Point(0, 0);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // area_idLabel
            // 
            area_idLabel.AutoSize = true;
            area_idLabel.Location = new System.Drawing.Point(83, 55);
            area_idLabel.Name = "area_idLabel";
            area_idLabel.Size = new System.Drawing.Size(117, 17);
            area_idLabel.TabIndex = 0;
            area_idLabel.Text = "Код помещения:";
            // 
            // area_squareLabel
            // 
            area_squareLabel.AutoSize = true;
            area_squareLabel.Location = new System.Drawing.Point(83, 90);
            area_squareLabel.Name = "area_squareLabel";
            area_squareLabel.Size = new System.Drawing.Size(152, 17);
            area_squareLabel.TabIndex = 2;
            area_squareLabel.Text = "Площадь помещения:";
            // 
            // floor_numberLabel
            // 
            floor_numberLabel.AutoSize = true;
            floor_numberLabel.Location = new System.Drawing.Point(83, 127);
            floor_numberLabel.Name = "floor_numberLabel";
            floor_numberLabel.Size = new System.Drawing.Size(98, 17);
            floor_numberLabel.TabIndex = 4;
            floor_numberLabel.Text = "Номер этажа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Панель управления: \"Помещения\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 83);
            this.button1.TabIndex = 8;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Предыдущая страница";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Следующая страница";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // floor_numberComboBox
            // 
            this.floor_numberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "floor_number", true));
            this.floor_numberComboBox.FormattingEnabled = true;
            this.floor_numberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.floor_numberComboBox.Location = new System.Drawing.Point(246, 122);
            this.floor_numberComboBox.Name = "floor_numberComboBox";
            this.floor_numberComboBox.Size = new System.Drawing.Size(152, 24);
            this.floor_numberComboBox.TabIndex = 10;
            // 
            // area_squareTextBox
            // 
            this.area_squareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "area_square", true));
            this.area_squareTextBox.Location = new System.Drawing.Point(246, 85);
            this.area_squareTextBox.Name = "area_squareTextBox";
            this.area_squareTextBox.Size = new System.Drawing.Size(152, 22);
            this.area_squareTextBox.TabIndex = 3;
            // 
            // area_idNumericUpDown
            // 
            this.area_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.areaBindingSource, "area_id", true));
            this.area_idNumericUpDown.Location = new System.Drawing.Point(246, 50);
            this.area_idNumericUpDown.Name = "area_idNumericUpDown";
            this.area_idNumericUpDown.Size = new System.Drawing.Size(152, 22);
            this.area_idNumericUpDown.TabIndex = 11;
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
            this.areaDataGridView.Location = new System.Drawing.Point(12, 220);
            this.areaDataGridView.Name = "areaDataGridView";
            this.areaDataGridView.RowHeadersWidth = 51;
            this.areaDataGridView.RowTemplate.Height = 24;
            this.areaDataGridView.Size = new System.Drawing.Size(471, 203);
            this.areaDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "area_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код помещения";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "area_square";
            this.dataGridViewTextBoxColumn2.HeaderText = "Площадь помещения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "floor_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер этажа";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.areaBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "БД ТЦ \"Тессеракт\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.martDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).EndInit();
            this.areaBindingNavigator.ResumeLayout(false);
            this.areaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MartDBDataSet martDBDataSet;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MartDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private MartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator areaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton areaBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox floor_numberComboBox;
        private System.Windows.Forms.TextBox area_squareTextBox;
        private System.Windows.Forms.NumericUpDown area_idNumericUpDown;
        private System.Windows.Forms.DataGridView areaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button4;
    }
}