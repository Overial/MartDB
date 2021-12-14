
namespace MartDB
{
    partial class UpdateOrgForm
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
            this.userpasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymentTermsComboBox = new System.Windows.Forms.ComboBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.orgNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryMethodComboBox = new System.Windows.Forms.ComboBox();
            this.contactPersonComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdateOrg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdProcUpdateOrg = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // userpasswordTextBox
            // 
            this.userpasswordTextBox.Location = new System.Drawing.Point(259, 213);
            this.userpasswordTextBox.Name = "userpasswordTextBox";
            this.userpasswordTextBox.PasswordChar = '*';
            this.userpasswordTextBox.Size = new System.Drawing.Size(136, 22);
            this.userpasswordTextBox.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Пароль:";
            // 
            // paymentTermsComboBox
            // 
            this.paymentTermsComboBox.FormattingEnabled = true;
            this.paymentTermsComboBox.Items.AddRange(new object[] {
            "Безналичные",
            "Наличные"});
            this.paymentTermsComboBox.Location = new System.Drawing.Point(259, 125);
            this.paymentTermsComboBox.Name = "paymentTermsComboBox";
            this.paymentTermsComboBox.Size = new System.Drawing.Size(136, 24);
            this.paymentTermsComboBox.TabIndex = 65;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(259, 95);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(136, 22);
            this.countryTextBox.TabIndex = 64;
            // 
            // orgNameTextBox
            // 
            this.orgNameTextBox.Location = new System.Drawing.Point(259, 67);
            this.orgNameTextBox.Name = "orgNameTextBox";
            this.orgNameTextBox.Size = new System.Drawing.Size(136, 22);
            this.orgNameTextBox.TabIndex = 63;
            // 
            // deliveryMethodComboBox
            // 
            this.deliveryMethodComboBox.FormattingEnabled = true;
            this.deliveryMethodComboBox.Items.AddRange(new object[] {
            "Отсутствует",
            "Курьер",
            "Контейнеры",
            "Почтамат"});
            this.deliveryMethodComboBox.Location = new System.Drawing.Point(259, 153);
            this.deliveryMethodComboBox.Name = "deliveryMethodComboBox";
            this.deliveryMethodComboBox.Size = new System.Drawing.Size(136, 24);
            this.deliveryMethodComboBox.TabIndex = 62;
            // 
            // contactPersonComboBox
            // 
            this.contactPersonComboBox.FormattingEnabled = true;
            this.contactPersonComboBox.Location = new System.Drawing.Point(259, 183);
            this.contactPersonComboBox.Name = "contactPersonComboBox";
            this.contactPersonComboBox.Size = new System.Drawing.Size(136, 24);
            this.contactPersonComboBox.TabIndex = 61;
            // 
            // btnUpdateOrg
            // 
            this.btnUpdateOrg.Location = new System.Drawing.Point(153, 268);
            this.btnUpdateOrg.Name = "btnUpdateOrg";
            this.btnUpdateOrg.Size = new System.Drawing.Size(127, 52);
            this.btnUpdateOrg.TabIndex = 60;
            this.btnUpdateOrg.Text = "Обновить организацию";
            this.btnUpdateOrg.UseVisualStyleBackColor = true;
            this.btnUpdateOrg.Click += new System.EventHandler(this.btnUpdateOrg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Контактное лицо:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Метод доставки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Тип оплаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Страна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Организация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdProcUpdateOrg
            // 
            this.sqlCmdProcUpdateOrg.CommandText = "ProcUpdateOrg";
            this.sqlCmdProcUpdateOrg.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcUpdateOrg.Connection = this.sqlConnection;
            this.sqlCmdProcUpdateOrg.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@country", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@payment_terms", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@delivery_method", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@contact_person", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@userpassword", System.Data.SqlDbType.VarChar, 50)});
            // 
            // UpdateOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.userpasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paymentTermsComboBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.orgNameTextBox);
            this.Controls.Add(this.deliveryMethodComboBox);
            this.Controls.Add(this.contactPersonComboBox);
            this.Controls.Add(this.btnUpdateOrg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateOrgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrgForm";
            this.Load += new System.EventHandler(this.UpdateOrgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userpasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox paymentTermsComboBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox orgNameTextBox;
        private System.Windows.Forms.ComboBox deliveryMethodComboBox;
        private System.Windows.Forms.ComboBox contactPersonComboBox;
        private System.Windows.Forms.Button btnUpdateOrg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdProcUpdateOrg;
    }
}