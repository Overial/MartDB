
namespace MartDB
{
    partial class HandleBookingForm
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
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orgIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.areaIdTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdCreateBooking = new System.Data.SqlClient.SqlCommand();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.sqlCmdDeleteBooking = new System.Data.SqlClient.SqlCommand();
            this.dtpBookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(44, 262);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(146, 45);
            this.btnCreateBooking.TabIndex = 10;
            this.btnCreateBooking.Text = "Оформить аренду";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код организации:";
            // 
            // orgIdTextBox
            // 
            this.orgIdTextBox.Location = new System.Drawing.Point(247, 67);
            this.orgIdTextBox.Name = "orgIdTextBox";
            this.orgIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.orgIdTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Код помещения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Стоимость аренды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Начало периода аренды:";
            // 
            // areaIdTextBox
            // 
            this.areaIdTextBox.Location = new System.Drawing.Point(247, 101);
            this.areaIdTextBox.Name = "areaIdTextBox";
            this.areaIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaIdTextBox.TabIndex = 17;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(247, 136);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Конец периода аренды:";
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdCreateBooking
            // 
            this.sqlCmdCreateBooking.CommandText = "ProcCreateBooking";
            this.sqlCmdCreateBooking.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdCreateBooking.Connection = this.mySqlConnection;
            this.sqlCmdCreateBooking.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date)});
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(274, 262);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(146, 45);
            this.btnDeleteBooking.TabIndex = 22;
            this.btnDeleteBooking.Text = "Удалить аренду";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // sqlCmdDeleteBooking
            // 
            this.sqlCmdDeleteBooking.CommandText = "ProcDeleteBooking";
            this.sqlCmdDeleteBooking.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdDeleteBooking.Connection = this.mySqlConnection;
            this.sqlCmdDeleteBooking.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date)});
            // 
            // dtpBookingStartDate
            // 
            this.dtpBookingStartDate.Location = new System.Drawing.Point(247, 172);
            this.dtpBookingStartDate.Name = "dtpBookingStartDate";
            this.dtpBookingStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBookingStartDate.TabIndex = 23;
            // 
            // dtpBookingEndDate
            // 
            this.dtpBookingEndDate.Location = new System.Drawing.Point(247, 204);
            this.dtpBookingEndDate.Name = "dtpBookingEndDate";
            this.dtpBookingEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBookingEndDate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // HandleBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBookingEndDate);
            this.Controls.Add(this.dtpBookingStartDate);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.areaIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orgIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandleBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление арендами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orgIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areaIdTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdCreateBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Data.SqlClient.SqlCommand sqlCmdDeleteBooking;
        private System.Windows.Forms.DateTimePicker dtpBookingStartDate;
        private System.Windows.Forms.DateTimePicker dtpBookingEndDate;
        private System.Windows.Forms.Label label6;
    }
}