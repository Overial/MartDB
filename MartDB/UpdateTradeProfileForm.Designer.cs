
namespace MartDB
{
    partial class UpdateTradeProfileForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateTradeProfile = new System.Windows.Forms.Button();
            this.tradeProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdProcUpdateTradeProfile = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название торгового профиля:";
            // 
            // btnUpdateTradeProfile
            // 
            this.btnUpdateTradeProfile.Location = new System.Drawing.Point(143, 173);
            this.btnUpdateTradeProfile.Name = "btnUpdateTradeProfile";
            this.btnUpdateTradeProfile.Size = new System.Drawing.Size(149, 76);
            this.btnUpdateTradeProfile.TabIndex = 7;
            this.btnUpdateTradeProfile.Text = "Обновить торговый профиль";
            this.btnUpdateTradeProfile.UseVisualStyleBackColor = true;
            this.btnUpdateTradeProfile.Click += new System.EventHandler(this.btnUpdateTradeProfile_Click);
            // 
            // tradeProfileNameTextBox
            // 
            this.tradeProfileNameTextBox.Location = new System.Drawing.Point(242, 92);
            this.tradeProfileNameTextBox.Name = "tradeProfileNameTextBox";
            this.tradeProfileNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.tradeProfileNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdProcUpdateTradeProfile
            // 
            this.sqlCmdProcUpdateTradeProfile.CommandText = "ProcUpdateTradeProfile";
            this.sqlCmdProcUpdateTradeProfile.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdProcUpdateTradeProfile.Connection = this.sqlConnection;
            this.sqlCmdProcUpdateTradeProfile.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@trade_profile_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@trade_profile_name", System.Data.SqlDbType.VarChar, 50)});
            // 
            // UpdateTradeProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateTradeProfile);
            this.Controls.Add(this.tradeProfileNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTradeProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTradeProfileForm";
            this.Load += new System.EventHandler(this.UpdateTradeProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateTradeProfile;
        private System.Windows.Forms.TextBox tradeProfileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdProcUpdateTradeProfile;
    }
}