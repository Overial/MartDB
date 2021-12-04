
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
            this.btnHandleBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.areaIdTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.bookingStartDateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookingEndDateTextBox = new System.Windows.Forms.TextBox();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.mySqlCommand = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // btnHandleBooking
            // 
            this.btnHandleBooking.Location = new System.Drawing.Point(157, 247);
            this.btnHandleBooking.Name = "btnHandleBooking";
            this.btnHandleBooking.Size = new System.Drawing.Size(146, 45);
            this.btnHandleBooking.TabIndex = 10;
            this.btnHandleBooking.Text = "Оформить аренду";
            this.btnHandleBooking.UseVisualStyleBackColor = true;
            this.btnHandleBooking.Click += new System.EventHandler(this.btnHandleBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код организации:";
            // 
            // bookingIdTextBox
            // 
            this.bookingIdTextBox.Location = new System.Drawing.Point(244, 37);
            this.bookingIdTextBox.Name = "bookingIdTextBox";
            this.bookingIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.bookingIdTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Код помещения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Стоимость аренды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Начало периода аренды:";
            // 
            // areaIdTextBox
            // 
            this.areaIdTextBox.Location = new System.Drawing.Point(244, 71);
            this.areaIdTextBox.Name = "areaIdTextBox";
            this.areaIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaIdTextBox.TabIndex = 17;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(244, 106);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 18;
            // 
            // bookingStartDateTextBox
            // 
            this.bookingStartDateTextBox.Location = new System.Drawing.Point(244, 142);
            this.bookingStartDateTextBox.Name = "bookingStartDateTextBox";
            this.bookingStartDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.bookingStartDateTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Конец периода аренды:";
            // 
            // bookingEndDateTextBox
            // 
            this.bookingEndDateTextBox.Location = new System.Drawing.Point(244, 174);
            this.bookingEndDateTextBox.Name = "bookingEndDateTextBox";
            this.bookingEndDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.bookingEndDateTextBox.TabIndex = 21;
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // mySqlCommand
            // 
            this.mySqlCommand.CommandText = "ProcHandleBooking";
            this.mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.mySqlCommand.Connection = this.mySqlConnection;
            this.mySqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@booking_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date)});
            // 
            // HandleBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 346);
            this.Controls.Add(this.bookingEndDateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookingStartDateTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.areaIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookingIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHandleBooking);
            this.Name = "HandleBookingForm";
            this.Text = "Оформление аренды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHandleBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookingIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areaIdTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox bookingStartDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookingEndDateTextBox;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand mySqlCommand;
    }
}