
namespace MartDB
{
    partial class HandleEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orgNameTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdAddEmployee = new System.Data.SqlClient.SqlCommand();
            this.sqlCmdDeleteEmployee = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер телефона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Электронная почта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // orgNameTextBox
            // 
            this.orgNameTextBox.Location = new System.Drawing.Point(216, 54);
            this.orgNameTextBox.Name = "orgNameTextBox";
            this.orgNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.orgNameTextBox.TabIndex = 7;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(216, 84);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 22);
            this.fioTextBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.genderComboBox.Location = new System.Drawing.Point(216, 116);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(216, 150);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.positionTextBox.TabIndex = 10;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(216, 187);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumberTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(216, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 12;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(52, 288);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(157, 52);
            this.btnAddEmployee.TabIndex = 13;
            this.btnAddEmployee.Text = "Добавить сотрудника";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(264, 288);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(157, 52);
            this.btnDeleteEmployee.TabIndex = 14;
            this.btnDeleteEmployee.Text = "Удалить сотрудника";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdAddEmployee
            // 
            this.sqlCmdAddEmployee.CommandText = "ProcAddEmployee";
            this.sqlCmdAddEmployee.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdAddEmployee.Connection = this.sqlConnection;
            this.sqlCmdAddEmployee.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.VarChar, 1),
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlCmdDeleteEmployee
            // 
            this.sqlCmdDeleteEmployee.CommandText = "ProcDeleteEmployee";
            this.sqlCmdDeleteEmployee.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdDeleteEmployee.Connection = this.sqlConnection;
            this.sqlCmdDeleteEmployee.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.VarChar, 1),
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50)});
            // 
            // HandleEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 407);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.orgNameTextBox);
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
            this.Name = "HandleEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сотрудниками";
            this.Load += new System.EventHandler(this.HandleEmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orgNameTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdAddEmployee;
        private System.Data.SqlClient.SqlCommand sqlCmdDeleteEmployee;
    }
}