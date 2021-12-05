
namespace MartDB
{
    partial class HandleOutletForm
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
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdAddOutlet = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.orgNameTextBox = new System.Windows.Forms.TextBox();
            this.outletNameTextBox = new System.Windows.Forms.TextBox();
            this.outletTypeTextBox = new System.Windows.Forms.TextBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.areaIdComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddOutlet = new System.Windows.Forms.Button();
            this.btnDeleteOutlet = new System.Windows.Forms.Button();
            this.sqlCmdDeleteOutlet = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdAddOutlet
            // 
            this.sqlCmdAddOutlet.CommandText = "ProcAddOutlet";
            this.sqlCmdAddOutlet.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdAddOutlet.Connection = this.sqlConnection;
            this.sqlCmdAddOutlet.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@outlet_type", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@timetable", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@rating", System.Data.SqlDbType.Float),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50)});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Организация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код помещения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Название торговой точки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип торговой точки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Расписание:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Рейтинг:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Контактное лицо:";
            // 
            // orgNameTextBox
            // 
            this.orgNameTextBox.Location = new System.Drawing.Point(254, 60);
            this.orgNameTextBox.Name = "orgNameTextBox";
            this.orgNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.orgNameTextBox.TabIndex = 8;
            // 
            // outletNameTextBox
            // 
            this.outletNameTextBox.Location = new System.Drawing.Point(254, 118);
            this.outletNameTextBox.Name = "outletNameTextBox";
            this.outletNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.outletNameTextBox.TabIndex = 9;
            // 
            // outletTypeTextBox
            // 
            this.outletTypeTextBox.Location = new System.Drawing.Point(254, 146);
            this.outletTypeTextBox.Name = "outletTypeTextBox";
            this.outletTypeTextBox.Size = new System.Drawing.Size(136, 22);
            this.outletTypeTextBox.TabIndex = 10;
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.Location = new System.Drawing.Point(254, 174);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(136, 22);
            this.timetableTextBox.TabIndex = 11;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(254, 202);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(136, 22);
            this.ratingTextBox.TabIndex = 12;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(254, 230);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(136, 22);
            this.contactPersonTextBox.TabIndex = 13;
            // 
            // areaIdComboBox
            // 
            this.areaIdComboBox.FormattingEnabled = true;
            this.areaIdComboBox.Location = new System.Drawing.Point(254, 88);
            this.areaIdComboBox.Name = "areaIdComboBox";
            this.areaIdComboBox.Size = new System.Drawing.Size(136, 24);
            this.areaIdComboBox.TabIndex = 14;
            // 
            // btnAddOutlet
            // 
            this.btnAddOutlet.Location = new System.Drawing.Point(49, 276);
            this.btnAddOutlet.Name = "btnAddOutlet";
            this.btnAddOutlet.Size = new System.Drawing.Size(127, 52);
            this.btnAddOutlet.TabIndex = 15;
            this.btnAddOutlet.Text = "Добавить торговую точку";
            this.btnAddOutlet.UseVisualStyleBackColor = true;
            this.btnAddOutlet.Click += new System.EventHandler(this.btnAddOutlet_Click);
            // 
            // btnDeleteOutlet
            // 
            this.btnDeleteOutlet.Location = new System.Drawing.Point(263, 276);
            this.btnDeleteOutlet.Name = "btnDeleteOutlet";
            this.btnDeleteOutlet.Size = new System.Drawing.Size(127, 52);
            this.btnDeleteOutlet.TabIndex = 16;
            this.btnDeleteOutlet.Text = "Удалить торговую точку";
            this.btnDeleteOutlet.UseVisualStyleBackColor = true;
            this.btnDeleteOutlet.Click += new System.EventHandler(this.btnDeleteOutlet_Click);
            // 
            // sqlCmdDeleteOutlet
            // 
            this.sqlCmdDeleteOutlet.CommandText = "ProcDeleteOutlet";
            this.sqlCmdDeleteOutlet.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdDeleteOutlet.Connection = this.sqlConnection;
            this.sqlCmdDeleteOutlet.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@outlet_type", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@timetable", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@rating", System.Data.SqlDbType.Float),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50)});
            // 
            // HandleOutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 358);
            this.Controls.Add(this.btnDeleteOutlet);
            this.Controls.Add(this.btnAddOutlet);
            this.Controls.Add(this.areaIdComboBox);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(this.outletTypeTextBox);
            this.Controls.Add(this.outletNameTextBox);
            this.Controls.Add(this.orgNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandleOutletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление торговыми точками";
            this.Load += new System.EventHandler(this.HandleOutletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdAddOutlet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox orgNameTextBox;
        private System.Windows.Forms.TextBox outletNameTextBox;
        private System.Windows.Forms.TextBox outletTypeTextBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.ComboBox areaIdComboBox;
        private System.Windows.Forms.Button btnAddOutlet;
        private System.Windows.Forms.Button btnDeleteOutlet;
        private System.Data.SqlClient.SqlCommand sqlCmdDeleteOutlet;
    }
}