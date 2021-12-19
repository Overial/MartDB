
namespace MartDB
{
    partial class AddTradeProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTradeProfileForm));
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdCreateTradeProfile = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.tradeProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.btnAddTradeProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlCmdDeleteTradeProfile = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MartDB;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdCreateTradeProfile
            // 
            this.sqlCmdCreateTradeProfile.CommandText = "ProcAddTradeProfile";
            this.sqlCmdCreateTradeProfile.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdCreateTradeProfile.Connection = this.sqlConnection;
            this.sqlCmdCreateTradeProfile.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@trade_profile_name", System.Data.SqlDbType.VarChar, 50)});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // tradeProfileNameTextBox
            // 
            this.tradeProfileNameTextBox.Location = new System.Drawing.Point(253, 81);
            this.tradeProfileNameTextBox.Name = "tradeProfileNameTextBox";
            this.tradeProfileNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.tradeProfileNameTextBox.TabIndex = 1;
            // 
            // btnAddTradeProfile
            // 
            this.btnAddTradeProfile.Location = new System.Drawing.Point(164, 145);
            this.btnAddTradeProfile.Name = "btnAddTradeProfile";
            this.btnAddTradeProfile.Size = new System.Drawing.Size(149, 76);
            this.btnAddTradeProfile.TabIndex = 2;
            this.btnAddTradeProfile.Text = "Добавить торговый профиль";
            this.btnAddTradeProfile.UseVisualStyleBackColor = true;
            this.btnAddTradeProfile.Click += new System.EventHandler(this.btnAddTradeProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название торгового профиля:";
            // 
            // sqlCmdDeleteTradeProfile
            // 
            this.sqlCmdDeleteTradeProfile.CommandText = "ProcDeleteTradeProfile";
            this.sqlCmdDeleteTradeProfile.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdDeleteTradeProfile.Connection = this.sqlConnection;
            this.sqlCmdDeleteTradeProfile.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@trade_profile_name", System.Data.SqlDbType.VarChar, 50)});
            // 
            // AddTradeProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTradeProfile);
            this.Controls.Add(this.tradeProfileNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTradeProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление торговыми профилями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCmdCreateTradeProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tradeProfileNameTextBox;
        private System.Windows.Forms.Button btnAddTradeProfile;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlCommand sqlCmdDeleteTradeProfile;
    }
}