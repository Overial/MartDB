
namespace MartDB
{
    partial class UpdateOutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOutletForm));
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdProcUpdateOutlet = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outletNameTextBox = new System.Windows.Forms.TextBox();
            this.tradeProfileTextBox = new System.Windows.Forms.TextBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.areaIdComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdateOutlet = new System.Windows.Forms.Button();
            this.sqlCmdDeleteOutlet = new System.Data.SqlClient.SqlCommand();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.contactPersonComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdProcUpdateOutlet
            // 
            this.sqlCmdProcUpdateOutlet.CommandText = "ProcUpdateOutlet";
            this.sqlCmdProcUpdateOutlet.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcUpdateOutlet.Connection = this.sqlConnection;
            this.sqlCmdProcUpdateOutlet.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@outlet_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@trade_profile_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@timetable", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50)});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Организация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код помещения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Название торговой точки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип торговой точки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Расписание:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Рейтинг:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Контактное лицо:";
            // 
            // outletNameTextBox
            // 
            this.outletNameTextBox.Location = new System.Drawing.Point(266, 127);
            this.outletNameTextBox.Name = "outletNameTextBox";
            this.outletNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.outletNameTextBox.TabIndex = 9;
            // 
            // tradeProfileTextBox
            // 
            this.tradeProfileTextBox.Location = new System.Drawing.Point(266, 155);
            this.tradeProfileTextBox.Name = "tradeProfileTextBox";
            this.tradeProfileTextBox.Size = new System.Drawing.Size(136, 22);
            this.tradeProfileTextBox.TabIndex = 10;
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.Location = new System.Drawing.Point(266, 183);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(136, 22);
            this.timetableTextBox.TabIndex = 11;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(266, 211);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(136, 22);
            this.ratingTextBox.TabIndex = 12;
            // 
            // areaIdComboBox
            // 
            this.areaIdComboBox.FormattingEnabled = true;
            this.areaIdComboBox.Location = new System.Drawing.Point(266, 97);
            this.areaIdComboBox.Name = "areaIdComboBox";
            this.areaIdComboBox.Size = new System.Drawing.Size(136, 24);
            this.areaIdComboBox.TabIndex = 14;
            // 
            // btnUpdateOutlet
            // 
            this.btnUpdateOutlet.Location = new System.Drawing.Point(173, 285);
            this.btnUpdateOutlet.Name = "btnUpdateOutlet";
            this.btnUpdateOutlet.Size = new System.Drawing.Size(127, 52);
            this.btnUpdateOutlet.TabIndex = 15;
            this.btnUpdateOutlet.Text = "Обновить торговую точку";
            this.btnUpdateOutlet.UseVisualStyleBackColor = true;
            this.btnUpdateOutlet.Click += new System.EventHandler(this.btnUpdateOutlet_Click);
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
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(266, 69);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(136, 24);
            this.orgNameComboBox.TabIndex = 16;
            // 
            // contactPersonComboBox
            // 
            this.contactPersonComboBox.FormattingEnabled = true;
            this.contactPersonComboBox.Location = new System.Drawing.Point(266, 239);
            this.contactPersonComboBox.Name = "contactPersonComboBox";
            this.contactPersonComboBox.Size = new System.Drawing.Size(136, 24);
            this.contactPersonComboBox.TabIndex = 17;
            // 
            // UpdateOutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 358);
            this.Controls.Add(this.contactPersonComboBox);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.btnUpdateOutlet);
            this.Controls.Add(this.areaIdComboBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(this.tradeProfileTextBox);
            this.Controls.Add(this.outletNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateOutletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление торговых точек";
            this.Load += new System.EventHandler(this.HandleOutletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdProcUpdateOutlet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outletNameTextBox;
        private System.Windows.Forms.TextBox tradeProfileTextBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.ComboBox areaIdComboBox;
        private System.Windows.Forms.Button btnUpdateOutlet;
        private System.Data.SqlClient.SqlCommand sqlCmdDeleteOutlet;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.ComboBox contactPersonComboBox;
    }
}