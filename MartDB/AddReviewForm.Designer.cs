
namespace MartDB
{
    partial class AddReviewForm
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
            this.outletNameComboBox = new System.Windows.Forms.ComboBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdAddReview = new System.Data.SqlClient.SqlCommand();
            this.reviewContentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название торговой точки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рейтинг:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Комментарий:";
            // 
            // outletNameComboBox
            // 
            this.outletNameComboBox.FormattingEnabled = true;
            this.outletNameComboBox.Location = new System.Drawing.Point(226, 61);
            this.outletNameComboBox.Name = "outletNameComboBox";
            this.outletNameComboBox.Size = new System.Drawing.Size(172, 24);
            this.outletNameComboBox.TabIndex = 3;
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
            this.ratingComboBox.Location = new System.Drawing.Point(226, 101);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(77, 24);
            this.ratingComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(137, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Введите данные и нажмите кнопку:";
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(177, 340);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(165, 58);
            this.btnAddReview.TabIndex = 27;
            this.btnAddReview.Text = "Оставить отзыв!";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdAddReview
            // 
            this.sqlCmdAddReview.CommandText = "ProcAddReview";
            this.sqlCmdAddReview.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdAddReview.Connection = this.sqlConnection;
            this.sqlCmdAddReview.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@outlet_name", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@rating", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@review_content", System.Data.SqlDbType.VarChar, 200)});
            // 
            // reviewContentTextBox
            // 
            this.reviewContentTextBox.Location = new System.Drawing.Point(158, 155);
            this.reviewContentTextBox.Multiline = true;
            this.reviewContentTextBox.Name = "reviewContentTextBox";
            this.reviewContentTextBox.Size = new System.Drawing.Size(411, 125);
            this.reviewContentTextBox.TabIndex = 28;
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 435);
            this.Controls.Add(this.reviewContentTextBox);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.outletNameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление отзыва";
            this.Load += new System.EventHandler(this.AddReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox outletNameComboBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddReview;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdAddReview;
        private System.Windows.Forms.TextBox reviewContentTextBox;
    }
}