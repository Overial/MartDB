
namespace MartDB
{
    partial class AddOrgForm
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
            this.deliveryMethodComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddOrg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orgNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonComboBox = new System.Windows.Forms.ComboBox();
            this.paymentTermsComboBox = new System.Windows.Forms.ComboBox();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdProcAddOrg = new System.Data.SqlClient.SqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.userpasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deliveryMethodComboBox
            // 
            this.deliveryMethodComboBox.FormattingEnabled = true;
            this.deliveryMethodComboBox.Items.AddRange(new object[] {
            "Отсутствует",
            "Курьер",
            "Контейнеры",
            "Почтамат"});
            this.deliveryMethodComboBox.Location = new System.Drawing.Point(273, 163);
            this.deliveryMethodComboBox.Name = "deliveryMethodComboBox";
            this.deliveryMethodComboBox.Size = new System.Drawing.Size(136, 24);
            this.deliveryMethodComboBox.TabIndex = 48;
            // 
            // btnAddOrg
            // 
            this.btnAddOrg.Location = new System.Drawing.Point(167, 278);
            this.btnAddOrg.Name = "btnAddOrg";
            this.btnAddOrg.Size = new System.Drawing.Size(127, 52);
            this.btnAddOrg.TabIndex = 45;
            this.btnAddOrg.Text = "Добавить организацию";
            this.btnAddOrg.UseVisualStyleBackColor = true;
            this.btnAddOrg.Click += new System.EventHandler(this.btnAddOrg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Контактное лицо:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Метод доставки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Тип оплаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Страна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Организация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // orgNameTextBox
            // 
            this.orgNameTextBox.Location = new System.Drawing.Point(273, 77);
            this.orgNameTextBox.Name = "orgNameTextBox";
            this.orgNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.orgNameTextBox.TabIndex = 49;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(273, 105);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(136, 22);
            this.countryTextBox.TabIndex = 50;
            // 
            // contactPersonComboBox
            // 
            this.contactPersonComboBox.FormattingEnabled = true;
            this.contactPersonComboBox.Location = new System.Drawing.Point(273, 193);
            this.contactPersonComboBox.Name = "contactPersonComboBox";
            this.contactPersonComboBox.Size = new System.Drawing.Size(136, 24);
            this.contactPersonComboBox.TabIndex = 47;
            // 
            // paymentTermsComboBox
            // 
            this.paymentTermsComboBox.FormattingEnabled = true;
            this.paymentTermsComboBox.Items.AddRange(new object[] {
            "Безналичные",
            "Наличные"});
            this.paymentTermsComboBox.Location = new System.Drawing.Point(273, 135);
            this.paymentTermsComboBox.Name = "paymentTermsComboBox";
            this.paymentTermsComboBox.Size = new System.Drawing.Size(136, 24);
            this.paymentTermsComboBox.TabIndex = 51;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdProcAddOrg
            // 
            this.sqlCmdProcAddOrg.CommandText = "ProcAddOrg";
            this.sqlCmdProcAddOrg.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcAddOrg.Connection = this.sqlConnection;
            this.sqlCmdProcAddOrg.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@payment_terms", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@delivery_method", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@userpassword", System.Data.SqlDbType.VarChar, 50)});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Пароль:";
            // 
            // userpasswordTextBox
            // 
            this.userpasswordTextBox.Location = new System.Drawing.Point(273, 223);
            this.userpasswordTextBox.Name = "userpasswordTextBox";
            this.userpasswordTextBox.PasswordChar = '*';
            this.userpasswordTextBox.Size = new System.Drawing.Size(136, 22);
            this.userpasswordTextBox.TabIndex = 53;
            // 
            // AddOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 355);
            this.Controls.Add(this.userpasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paymentTermsComboBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.orgNameTextBox);
            this.Controls.Add(this.deliveryMethodComboBox);
            this.Controls.Add(this.contactPersonComboBox);
            this.Controls.Add(this.btnAddOrg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление организаций";
            this.Load += new System.EventHandler(this.AddOrgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deliveryMethodComboBox;
        private System.Windows.Forms.Button btnAddOrg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orgNameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.ComboBox contactPersonComboBox;
        private System.Windows.Forms.ComboBox paymentTermsComboBox;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdProcAddOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userpasswordTextBox;
    }
}