
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOutlet = new System.Windows.Forms.Panel();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.btnUserReviewsForm = new System.Windows.Forms.Button();
            this.btnUpdateReview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.panelUser = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.panelOutletLabel = new System.Windows.Forms.Label();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.sortOutletGroupBox = new System.Windows.Forms.GroupBox();
            this.sortColsOutletListBox = new System.Windows.Forms.ListBox();
            this.btnSortOutlet = new System.Windows.Forms.Button();
            this.descOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.ascOutletRadioButton = new System.Windows.Forms.RadioButton();
            this.sortColOutletLabel = new System.Windows.Forms.Label();
            this.searchOutletGroupBox = new System.Windows.Forms.GroupBox();
            this.searchQueryOutletGroupBox = new System.Windows.Forms.Label();
            this.searchColsOutletListBox = new System.Windows.Forms.ListBox();
            this.searchOutletLabel = new System.Windows.Forms.Label();
            this.searchQueryOutletTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchOutlet = new System.Windows.Forms.Button();
            this.btnOutletShowAll = new System.Windows.Forms.Button();
            this.dgvOutlet = new System.Windows.Forms.DataGridView();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdGetOutletReviews = new System.Data.SqlClient.SqlCommand();
            this.btnReviewShowAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelOutlet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.panelUser.SuspendLayout();
            this.sortOutletGroupBox.SuspendLayout();
            this.searchOutletGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // panelOutlet
            // 
            this.panelOutlet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutlet.Controls.Add(this.btnReviewShowAll);
            this.panelOutlet.Controls.Add(this.btnDeleteReview);
            this.panelOutlet.Controls.Add(this.btnUserReviewsForm);
            this.panelOutlet.Controls.Add(this.btnUpdateReview);
            this.panelOutlet.Controls.Add(this.label2);
            this.panelOutlet.Controls.Add(this.label1);
            this.panelOutlet.Controls.Add(this.dgvReview);
            this.panelOutlet.Controls.Add(this.panelUser);
            this.panelOutlet.Controls.Add(this.btnAddReview);
            this.panelOutlet.Controls.Add(this.sortOutletGroupBox);
            this.panelOutlet.Controls.Add(this.searchOutletGroupBox);
            this.panelOutlet.Controls.Add(this.dgvOutlet);
            this.panelOutlet.Location = new System.Drawing.Point(12, 33);
            this.panelOutlet.Name = "panelOutlet";
            this.panelOutlet.Size = new System.Drawing.Size(1359, 544);
            this.panelOutlet.TabIndex = 5;
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReview.Location = new System.Drawing.Point(964, 466);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(209, 61);
            this.btnDeleteReview.TabIndex = 40;
            this.btnDeleteReview.Text = "Удалить отзыв";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // btnUserReviewsForm
            // 
            this.btnUserReviewsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserReviewsForm.Location = new System.Drawing.Point(1179, 443);
            this.btnUserReviewsForm.Name = "btnUserReviewsForm";
            this.btnUserReviewsForm.Size = new System.Drawing.Size(165, 84);
            this.btnUserReviewsForm.TabIndex = 39;
            this.btnUserReviewsForm.Text = "Посмотреть свои отзывы";
            this.btnUserReviewsForm.UseVisualStyleBackColor = true;
            this.btnUserReviewsForm.Click += new System.EventHandler(this.btnUserReviewsForm_Click);
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateReview.Location = new System.Drawing.Point(964, 399);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(209, 61);
            this.btnUpdateReview.TabIndex = 38;
            this.btnUpdateReview.Text = "Редактировать отзыв";
            this.btnUpdateReview.UseVisualStyleBackColor = true;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(960, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Отзывы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Торговые точки:";
            // 
            // dgvReview
            // 
            this.dgvReview.AllowUserToAddRows = false;
            this.dgvReview.AllowUserToDeleteRows = false;
            this.dgvReview.AllowUserToOrderColumns = true;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Location = new System.Drawing.Point(964, 38);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.ReadOnly = true;
            this.dgvReview.RowHeadersWidth = 51;
            this.dgvReview.RowTemplate.Height = 24;
            this.dgvReview.Size = new System.Drawing.Size(380, 288);
            this.dgvReview.TabIndex = 35;
            // 
            // panelUser
            // 
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.currentUserLabel);
            this.panelUser.Controls.Add(this.panelOutletLabel);
            this.panelUser.Controls.Add(this.btnChangeUser);
            this.panelUser.Location = new System.Drawing.Point(-1, -1);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(321, 144);
            this.panelUser.TabIndex = 33;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserLabel.Location = new System.Drawing.Point(87, 38);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(136, 28);
            this.currentUserLabel.TabIndex = 20;
            this.currentUserLabel.Text = "<username>!";
            // 
            // panelOutletLabel
            // 
            this.panelOutletLabel.AutoSize = true;
            this.panelOutletLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutletLabel.Location = new System.Drawing.Point(55, 0);
            this.panelOutletLabel.Name = "panelOutletLabel";
            this.panelOutletLabel.Size = new System.Drawing.Size(200, 28);
            this.panelOutletLabel.TabIndex = 17;
            this.panelOutletLabel.Text = "Добро пожаловать,";
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUser.Location = new System.Drawing.Point(92, 84);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(124, 45);
            this.btnChangeUser.TabIndex = 19;
            this.btnChangeUser.Text = "Сменить пользователя";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReview.Location = new System.Drawing.Point(964, 332);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(209, 61);
            this.btnAddReview.TabIndex = 32;
            this.btnAddReview.Text = "Написать отзыв";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // sortOutletGroupBox
            // 
            this.sortOutletGroupBox.Controls.Add(this.sortColsOutletListBox);
            this.sortOutletGroupBox.Controls.Add(this.btnSortOutlet);
            this.sortOutletGroupBox.Controls.Add(this.descOutletRadioButton);
            this.sortOutletGroupBox.Controls.Add(this.ascOutletRadioButton);
            this.sortOutletGroupBox.Controls.Add(this.sortColOutletLabel);
            this.sortOutletGroupBox.Location = new System.Drawing.Point(7, 349);
            this.sortOutletGroupBox.Name = "sortOutletGroupBox";
            this.sortOutletGroupBox.Size = new System.Drawing.Size(317, 178);
            this.sortOutletGroupBox.TabIndex = 31;
            this.sortOutletGroupBox.TabStop = false;
            this.sortOutletGroupBox.Text = "Сортировка";
            // 
            // sortColsOutletListBox
            // 
            this.sortColsOutletListBox.FormattingEnabled = true;
            this.sortColsOutletListBox.ItemHeight = 16;
            this.sortColsOutletListBox.Items.AddRange(new object[] {
            "Название торговой точки",
            "Тип торговой точки",
            "Номер этажа",
            "Расписание",
            "Рейтинг"});
            this.sortColsOutletListBox.Location = new System.Drawing.Point(7, 39);
            this.sortColsOutletListBox.Name = "sortColsOutletListBox";
            this.sortColsOutletListBox.Size = new System.Drawing.Size(154, 132);
            this.sortColsOutletListBox.TabIndex = 13;
            this.sortColsOutletListBox.SelectedIndexChanged += new System.EventHandler(this.sortColsOutletListBox_SelectedIndexChanged);
            // 
            // btnSortOutlet
            // 
            this.btnSortOutlet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortOutlet.Enabled = false;
            this.btnSortOutlet.Location = new System.Drawing.Point(174, 102);
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
            // searchOutletGroupBox
            // 
            this.searchOutletGroupBox.Controls.Add(this.searchQueryOutletGroupBox);
            this.searchOutletGroupBox.Controls.Add(this.searchColsOutletListBox);
            this.searchOutletGroupBox.Controls.Add(this.searchOutletLabel);
            this.searchOutletGroupBox.Controls.Add(this.searchQueryOutletTextBox);
            this.searchOutletGroupBox.Controls.Add(this.btnSearchOutlet);
            this.searchOutletGroupBox.Controls.Add(this.btnOutletShowAll);
            this.searchOutletGroupBox.Location = new System.Drawing.Point(7, 149);
            this.searchOutletGroupBox.Name = "searchOutletGroupBox";
            this.searchOutletGroupBox.Size = new System.Drawing.Size(317, 194);
            this.searchOutletGroupBox.TabIndex = 27;
            this.searchOutletGroupBox.TabStop = false;
            this.searchOutletGroupBox.Text = "Поиск";
            // 
            // searchQueryOutletGroupBox
            // 
            this.searchQueryOutletGroupBox.AutoSize = true;
            this.searchQueryOutletGroupBox.Location = new System.Drawing.Point(178, 18);
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
            "Название торговой точки",
            "Тип торговой точки",
            "Номер этажа",
            "Расписание",
            "Рейтинг"});
            this.searchColsOutletListBox.Location = new System.Drawing.Point(7, 38);
            this.searchColsOutletListBox.Name = "searchColsOutletListBox";
            this.searchColsOutletListBox.Size = new System.Drawing.Size(154, 148);
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
            this.searchQueryOutletTextBox.Location = new System.Drawing.Point(181, 38);
            this.searchQueryOutletTextBox.Name = "searchQueryOutletTextBox";
            this.searchQueryOutletTextBox.Size = new System.Drawing.Size(119, 22);
            this.searchQueryOutletTextBox.TabIndex = 6;
            // 
            // btnSearchOutlet
            // 
            this.btnSearchOutlet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchOutlet.Enabled = false;
            this.btnSearchOutlet.Location = new System.Drawing.Point(181, 81);
            this.btnSearchOutlet.Name = "btnSearchOutlet";
            this.btnSearchOutlet.Size = new System.Drawing.Size(119, 42);
            this.btnSearchOutlet.TabIndex = 5;
            this.btnSearchOutlet.Text = "Найти";
            this.btnSearchOutlet.UseVisualStyleBackColor = true;
            this.btnSearchOutlet.Click += new System.EventHandler(this.btnSearchOutlet_Click);
            // 
            // btnOutletShowAll
            // 
            this.btnOutletShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutletShowAll.Location = new System.Drawing.Point(181, 144);
            this.btnOutletShowAll.Name = "btnOutletShowAll";
            this.btnOutletShowAll.Size = new System.Drawing.Size(119, 42);
            this.btnOutletShowAll.TabIndex = 30;
            this.btnOutletShowAll.Text = "Показать все";
            this.btnOutletShowAll.UseVisualStyleBackColor = true;
            this.btnOutletShowAll.Click += new System.EventHandler(this.btnOutletShowAll_Click);
            // 
            // dgvOutlet
            // 
            this.dgvOutlet.AllowUserToAddRows = false;
            this.dgvOutlet.AllowUserToDeleteRows = false;
            this.dgvOutlet.AllowUserToOrderColumns = true;
            this.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutlet.Location = new System.Drawing.Point(330, 38);
            this.dgvOutlet.Name = "dgvOutlet";
            this.dgvOutlet.ReadOnly = true;
            this.dgvOutlet.RowHeadersWidth = 51;
            this.dgvOutlet.RowTemplate.Height = 24;
            this.dgvOutlet.Size = new System.Drawing.Size(616, 489);
            this.dgvOutlet.TabIndex = 29;
            this.dgvOutlet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutlet_CellClick);
            this.dgvOutlet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOutlet_RowHeaderMouseClick);
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdGetOutletReviews
            // 
            this.sqlCmdGetOutletReviews.CommandText = "SELECT * FROM FnGetOutletReviews(@outlet_name)";
            this.sqlCmdGetOutletReviews.Connection = this.sqlConnection;
            this.sqlCmdGetOutletReviews.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50)});
            // 
            // btnReviewShowAll
            // 
            this.btnReviewShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewShowAll.Location = new System.Drawing.Point(1179, 332);
            this.btnReviewShowAll.Name = "btnReviewShowAll";
            this.btnReviewShowAll.Size = new System.Drawing.Size(165, 105);
            this.btnReviewShowAll.TabIndex = 41;
            this.btnReviewShowAll.Text = "Показать все отзывы";
            this.btnReviewShowAll.UseVisualStyleBackColor = true;
            this.btnReviewShowAll.Click += new System.EventHandler(this.btnReviewShowAll_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 589);
            this.Controls.Add(this.panelOutlet);
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
            this.panelOutlet.ResumeLayout(false);
            this.panelOutlet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelOutlet;
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
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label panelOutletLabel;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserReviewsForm;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Button btnUpdateReview;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdGetOutletReviews;
        private System.Windows.Forms.Button btnReviewShowAll;
    }
}