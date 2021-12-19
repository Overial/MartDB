
namespace MartDB
{
    partial class AddBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookingForm));
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdAddBooking = new System.Data.SqlClient.SqlCommand();
            this.dtpBookingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.areaIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(178, 242);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(146, 45);
            this.btnAddBooking.TabIndex = 10;
            this.btnAddBooking.Text = "Оформить новую аренду";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название организации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Код помещения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Начало периода аренды:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Конец периода аренды:";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdAddBooking
            // 
            this.sqlCmdAddBooking.CommandText = "ProcAddBooking";
            this.sqlCmdAddBooking.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdAddBooking.Connection = this.sqlConnection;
            this.sqlCmdAddBooking.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@org_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@area_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@booking_start_date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@booking_end_date", System.Data.SqlDbType.Date)});
            // 
            // dtpBookingStartDate
            // 
            this.dtpBookingStartDate.Location = new System.Drawing.Point(247, 151);
            this.dtpBookingStartDate.Name = "dtpBookingStartDate";
            this.dtpBookingStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBookingStartDate.TabIndex = 23;
            // 
            // dtpBookingEndDate
            // 
            this.dtpBookingEndDate.Location = new System.Drawing.Point(247, 183);
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
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(247, 79);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.orgNameComboBox.TabIndex = 26;
            // 
            // areaIdComboBox
            // 
            this.areaIdComboBox.FormattingEnabled = true;
            this.areaIdComboBox.Location = new System.Drawing.Point(247, 113);
            this.areaIdComboBox.Name = "areaIdComboBox";
            this.areaIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.areaIdComboBox.TabIndex = 27;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 311);
            this.Controls.Add(this.areaIdComboBox);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBookingEndDate);
            this.Controls.Add(this.dtpBookingStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление аренды";
            this.Load += new System.EventHandler(this.HandleBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdAddBooking;
        private System.Windows.Forms.DateTimePicker dtpBookingStartDate;
        private System.Windows.Forms.DateTimePicker dtpBookingEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.ComboBox areaIdComboBox;
    }
}