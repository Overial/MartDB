
namespace MartDB
{
    partial class UpdateReviewForm
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
            this.reviewContentTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateReview = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdUpdateReview = new System.Data.SqlClient.SqlCommand();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.outletNameComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reviewContentTextBox
            // 
            this.reviewContentTextBox.Location = new System.Drawing.Point(195, 190);
            this.reviewContentTextBox.Multiline = true;
            this.reviewContentTextBox.Name = "reviewContentTextBox";
            this.reviewContentTextBox.Size = new System.Drawing.Size(399, 148);
            this.reviewContentTextBox.TabIndex = 36;
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.Location = new System.Drawing.Point(208, 362);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(165, 58);
            this.btnUpdateReview.TabIndex = 35;
            this.btnUpdateReview.Text = "Обновить отзыв!";
            this.btnUpdateReview.UseVisualStyleBackColor = true;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(139, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Введите данные и нажмите кнопку:";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.ratingComboBox.Location = new System.Drawing.Point(228, 149);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(77, 24);
            this.ratingComboBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Новый комментарий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Новый рейтинг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Имя пользователя:";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdUpdateReview
            // 
            this.sqlCmdUpdateReview.CommandText = "ProcUpdateReview";
            this.sqlCmdUpdateReview.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdUpdateReview.Connection = this.sqlConnection;
            this.sqlCmdUpdateReview.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@rating", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@review_content", System.Data.SqlDbType.VarChar, 200)});
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(228, 71);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(172, 22);
            this.usernameTextBox.TabIndex = 37;
            // 
            // outletNameComboBox
            // 
            this.outletNameComboBox.Enabled = false;
            this.outletNameComboBox.FormattingEnabled = true;
            this.outletNameComboBox.Location = new System.Drawing.Point(228, 108);
            this.outletNameComboBox.Name = "outletNameComboBox";
            this.outletNameComboBox.Size = new System.Drawing.Size(172, 24);
            this.outletNameComboBox.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Название торговой точки:";
            // 
            // UpdateReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 470);
            this.Controls.Add(this.outletNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.reviewContentTextBox);
            this.Controls.Add(this.btnUpdateReview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование отзыва";
            this.Load += new System.EventHandler(this.UpdateReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reviewContentTextBox;
        private System.Windows.Forms.Button btnUpdateReview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdUpdateReview;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ComboBox outletNameComboBox;
        private System.Windows.Forms.Label label4;
    }
}