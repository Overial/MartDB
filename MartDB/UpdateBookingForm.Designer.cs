
namespace MartDB
{
    partial class UpdateBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBookingForm));
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.label6 = new System.Windows.Forms.Label();
            this.areaIdComboBox = new System.Windows.Forms.ComboBox();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.dtpBookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBookingDates = new System.Windows.Forms.Button();
            this.sqlCmdUpdateBookingDates = new System.Data.SqlClient.SqlCommand();
            this.bCostCheckBox = new System.Windows.Forms.CheckBox();
            this.sqlCmdProcUpdateBookingCost = new System.Data.SqlClient.SqlCommand();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.sqlCmdUpdateBooking = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // areaIdComboBox
            // 
            this.areaIdComboBox.Enabled = false;
            this.areaIdComboBox.FormattingEnabled = true;
            this.areaIdComboBox.Location = new System.Drawing.Point(224, 107);
            this.areaIdComboBox.Name = "areaIdComboBox";
            this.areaIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.areaIdComboBox.TabIndex = 36;
            // 
            // orgNameComboBox
            // 
            this.orgNameComboBox.Enabled = false;
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(224, 73);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.orgNameComboBox.TabIndex = 35;
            // 
            // dtpBookingEndDate
            // 
            this.dtpBookingEndDate.Location = new System.Drawing.Point(224, 177);
            this.dtpBookingEndDate.Name = "dtpBookingEndDate";
            this.dtpBookingEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBookingEndDate.TabIndex = 34;
            // 
            // dtpBookingStartDate
            // 
            this.dtpBookingStartDate.Enabled = false;
            this.dtpBookingStartDate.Location = new System.Drawing.Point(224, 145);
            this.dtpBookingStartDate.Name = "dtpBookingStartDate";
            this.dtpBookingStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBookingStartDate.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Конец периода аренды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Начало периода аренды:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Код помещения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Название организации:";
            // 
            // btnUpdateBookingDates
            // 
            this.btnUpdateBookingDates.Location = new System.Drawing.Point(248, 293);
            this.btnUpdateBookingDates.Name = "btnUpdateBookingDates";
            this.btnUpdateBookingDates.Size = new System.Drawing.Size(176, 57);
            this.btnUpdateBookingDates.TabIndex = 37;
            this.btnUpdateBookingDates.Text = "Обновить даты";
            this.btnUpdateBookingDates.UseVisualStyleBackColor = true;
            this.btnUpdateBookingDates.Click += new System.EventHandler(this.btnUpdateBookingDates_Click);
            // 
            // sqlCmdUpdateBookingDates
            // 
            this.sqlCmdUpdateBookingDates.CommandText = "ProcUpdateBookingDates";
            this.sqlCmdUpdateBookingDates.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdUpdateBookingDates.Connection = this.sqlConnection;
            this.sqlCmdUpdateBookingDates.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date, 50),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date, 50)});
            // 
            // bCostCheckBox
            // 
            this.bCostCheckBox.AutoSize = true;
            this.bCostCheckBox.Enabled = false;
            this.bCostCheckBox.Location = new System.Drawing.Point(150, 244);
            this.bCostCheckBox.Name = "bCostCheckBox";
            this.bCostCheckBox.Size = new System.Drawing.Size(166, 21);
            this.bCostCheckBox.TabIndex = 38;
            this.bCostCheckBox.Text = "Обновить стоимость";
            this.bCostCheckBox.UseVisualStyleBackColor = true;
            // 
            // sqlCmdProcUpdateBookingCost
            // 
            this.sqlCmdProcUpdateBookingCost.CommandText = "ProcUpdateBookingCost";
            this.sqlCmdProcUpdateBookingCost.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcUpdateBookingCost.Connection = this.sqlConnection;
            this.sqlCmdProcUpdateBookingCost.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@booking_id", System.Data.SqlDbType.Int)});
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(45, 293);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(176, 57);
            this.btnUpdateBooking.TabIndex = 39;
            this.btnUpdateBooking.Text = "Изменить существующую аренду";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // sqlCmdUpdateBooking
            // 
            this.sqlCmdUpdateBooking.CommandText = "ProcUpdateBooking";
            this.sqlCmdUpdateBooking.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdUpdateBooking.Connection = this.sqlConnection;
            this.sqlCmdUpdateBooking.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@booking_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date, 50),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date, 50)});
            // 
            // UpdateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 377);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.bCostCheckBox);
            this.Controls.Add(this.btnUpdateBookingDates);
            this.Controls.Add(this.areaIdComboBox);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.dtpBookingEndDate);
            this.Controls.Add(this.dtpBookingStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление аренды";
            this.Load += new System.EventHandler(this.UpdateBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox areaIdComboBox;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.DateTimePicker dtpBookingEndDate;
        private System.Windows.Forms.DateTimePicker dtpBookingStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateBookingDates;
        private System.Data.SqlClient.SqlCommand sqlCmdUpdateBookingDates;
        private System.Windows.Forms.CheckBox bCostCheckBox;
        private System.Data.SqlClient.SqlCommand sqlCmdProcUpdateBookingCost;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Data.SqlClient.SqlCommand sqlCmdUpdateBooking;
    }
}