
namespace MartDB
{
    partial class UpdateEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeForm));
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlCmdUpdateEmployee = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Менеджер",
            "Консультант"});
            this.positionComboBox.Location = new System.Drawing.Point(221, 165);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(121, 24);
            this.positionComboBox.TabIndex = 29;
            // 
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(221, 69);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.orgNameComboBox.TabIndex = 28;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(162, 277);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(157, 52);
            this.btnUpdateEmployee.TabIndex = 27;
            this.btnUpdateEmployee.Text = "Обновить данные о сотруднике";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(221, 235);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 22);
            this.emailTextBox.TabIndex = 26;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(221, 202);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.phoneNumberTextBox.TabIndex = 25;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.genderComboBox.Location = new System.Drawing.Point(221, 131);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 24;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(221, 99);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(121, 22);
            this.fioTextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(32, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Электронная почта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Пол:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Организация:";
            // 
            // sqlCmdUpdateEmployee
            // 
            this.sqlCmdUpdateEmployee.CommandText = "ProcUpdateEmployee";
            this.sqlCmdUpdateEmployee.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdUpdateEmployee.Connection = this.sqlConnection;
            this.sqlCmdUpdateEmployee.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@employee_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.VarChar, 1),
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 358);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label7);
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
            this.Name = "UpdateEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление данных о сотрудниках";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand sqlCmdUpdateEmployee;
        private System.Data.SqlClient.SqlConnection sqlConnection;
    }
}