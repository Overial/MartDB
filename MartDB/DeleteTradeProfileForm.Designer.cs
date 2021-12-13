
namespace MartDB
{
    partial class DeleteTradeProfileForm
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
            this.btnDeleteTradeProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tradeProfileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteTradeProfile
            // 
            this.btnDeleteTradeProfile.Location = new System.Drawing.Point(155, 170);
            this.btnDeleteTradeProfile.Name = "btnDeleteTradeProfile";
            this.btnDeleteTradeProfile.Size = new System.Drawing.Size(149, 76);
            this.btnDeleteTradeProfile.TabIndex = 9;
            this.btnDeleteTradeProfile.Text = "Удалить торговый профиль";
            this.btnDeleteTradeProfile.UseVisualStyleBackColor = true;
            this.btnDeleteTradeProfile.Click += new System.EventHandler(this.btnDeleteTradeProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название торгового профиля:";
            // 
            // tradeProfileNameTextBox
            // 
            this.tradeProfileNameTextBox.Location = new System.Drawing.Point(251, 92);
            this.tradeProfileNameTextBox.Name = "tradeProfileNameTextBox";
            this.tradeProfileNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.tradeProfileNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите данные и нажмите необходимую кнопку:";
            // 
            // DeleteTradeProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 284);
            this.Controls.Add(this.btnDeleteTradeProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tradeProfileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteTradeProfileForm";
            this.Text = "DeleteTradeProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTradeProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tradeProfileNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}