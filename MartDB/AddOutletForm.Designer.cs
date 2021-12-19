
namespace MartDB
{
    partial class AddOutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOutletForm));
            this.contactPersonComboBox = new System.Windows.Forms.ComboBox();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddOutlet = new System.Windows.Forms.Button();
            this.areaIdComboBox = new System.Windows.Forms.ComboBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.outletNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdProcAddOutlet = new System.Data.SqlClient.SqlCommand();
            this.tradeProfileComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // contactPersonComboBox
            // 
            this.contactPersonComboBox.FormattingEnabled = true;
            this.contactPersonComboBox.Location = new System.Drawing.Point(272, 214);
            this.contactPersonComboBox.Name = "contactPersonComboBox";
            this.contactPersonComboBox.Size = new System.Drawing.Size(136, 24);
            this.contactPersonComboBox.TabIndex = 33;
            // 
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(272, 72);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(136, 24);
            this.orgNameComboBox.TabIndex = 32;
            // 
            // btnAddOutlet
            // 
            this.btnAddOutlet.Location = new System.Drawing.Point(179, 260);
            this.btnAddOutlet.Name = "btnAddOutlet";
            this.btnAddOutlet.Size = new System.Drawing.Size(127, 52);
            this.btnAddOutlet.TabIndex = 31;
            this.btnAddOutlet.Text = "Добавить торговую точку";
            this.btnAddOutlet.UseVisualStyleBackColor = true;
            this.btnAddOutlet.Click += new System.EventHandler(this.btnAddOutlet_Click);
            // 
            // areaIdComboBox
            // 
            this.areaIdComboBox.FormattingEnabled = true;
            this.areaIdComboBox.Location = new System.Drawing.Point(272, 100);
            this.areaIdComboBox.Name = "areaIdComboBox";
            this.areaIdComboBox.Size = new System.Drawing.Size(136, 24);
            this.areaIdComboBox.TabIndex = 30;
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.Location = new System.Drawing.Point(272, 186);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(136, 22);
            this.timetableTextBox.TabIndex = 28;
            // 
            // outletNameTextBox
            // 
            this.outletNameTextBox.Location = new System.Drawing.Point(272, 130);
            this.outletNameTextBox.Name = "outletNameTextBox";
            this.outletNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.outletNameTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Контактное лицо:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Расписание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Торговый профиль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Название торговой точки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Код помещения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Организация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdProcAddOutlet
            // 
            this.sqlCmdProcAddOutlet.CommandText = "ProcAddOutlet";
            this.sqlCmdProcAddOutlet.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcAddOutlet.Connection = this.sqlConnection;
            this.sqlCmdProcAddOutlet.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@trade_profile_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@timetable", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50)});
            // 
            // tradeProfileComboBox
            // 
            this.tradeProfileComboBox.FormattingEnabled = true;
            this.tradeProfileComboBox.Location = new System.Drawing.Point(272, 158);
            this.tradeProfileComboBox.Name = "tradeProfileComboBox";
            this.tradeProfileComboBox.Size = new System.Drawing.Size(136, 24);
            this.tradeProfileComboBox.TabIndex = 34;
            // 
            // AddOutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 323);
            this.Controls.Add(this.tradeProfileComboBox);
            this.Controls.Add(this.contactPersonComboBox);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.btnAddOutlet);
            this.Controls.Add(this.areaIdComboBox);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(this.outletNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOutletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление торговых точек";
            this.Load += new System.EventHandler(this.AddOutletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contactPersonComboBox;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.Button btnAddOutlet;
        private System.Windows.Forms.ComboBox areaIdComboBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.TextBox outletNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdProcAddOutlet;
        private System.Windows.Forms.ComboBox tradeProfileComboBox;
    }
}