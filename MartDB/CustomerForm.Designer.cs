
namespace MartDB
{
    partial class CustomerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOutletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnPanelOutlet = new System.Windows.Forms.Button();
            this.btnPanelMain = new System.Windows.Forms.Button();
            this.btnPreviousPanel = new System.Windows.Forms.Button();
            this.btnNextPanel = new System.Windows.Forms.Button();
            this.panelOutlet = new System.Windows.Forms.Panel();
            this.panelOutletLabel = new System.Windows.Forms.Label();
            this.panelMainLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOutlet.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelsToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelsToolStripMenuItem
            // 
            this.panelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelMainToolStripMenuItem,
            this.panelOutletToolStripMenuItem,
            this.panelReviewToolStripMenuItem});
            this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            this.panelsToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.panelsToolStripMenuItem.Text = "Страницы";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelOutletToolStripMenuItem
            // 
            this.panelOutletToolStripMenuItem.Name = "panelOutletToolStripMenuItem";
            this.panelOutletToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelOutletToolStripMenuItem.Text = "Просмотр торговых точек";
            this.panelOutletToolStripMenuItem.Click += new System.EventHandler(this.panelOutletToolStripMenuItem_Click);
            // 
            // panelReviewToolStripMenuItem
            // 
            this.panelReviewToolStripMenuItem.Name = "panelReviewToolStripMenuItem";
            this.panelReviewToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelReviewToolStripMenuItem.Text = "Просмотр личных отзывов";
            // 
            // panelMainToolStripMenuItem
            // 
            this.panelMainToolStripMenuItem.Name = "panelMainToolStripMenuItem";
            this.panelMainToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.panelMainToolStripMenuItem.Text = "Главная";
            this.panelMainToolStripMenuItem.Click += new System.EventHandler(this.panelMainToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMainLabel);
            this.panelMain.Controls.Add(this.btnNextPanel);
            this.panelMain.Controls.Add(this.btnPreviousPanel);
            this.panelMain.Controls.Add(this.btnPanelMain);
            this.panelMain.Controls.Add(this.btnPanelOutlet);
            this.panelMain.Location = new System.Drawing.Point(12, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 560);
            this.panelMain.TabIndex = 1;
            // 
            // btnPanelOutlet
            // 
            this.btnPanelOutlet.Location = new System.Drawing.Point(112, 130);
            this.btnPanelOutlet.Name = "btnPanelOutlet";
            this.btnPanelOutlet.Size = new System.Drawing.Size(196, 75);
            this.btnPanelOutlet.TabIndex = 0;
            this.btnPanelOutlet.Text = "Просмотр торговых точек";
            this.btnPanelOutlet.UseVisualStyleBackColor = true;
            this.btnPanelOutlet.Click += new System.EventHandler(this.btnPanelOutlet_Click);
            // 
            // btnPanelMain
            // 
            this.btnPanelMain.Location = new System.Drawing.Point(13, 484);
            this.btnPanelMain.Name = "btnPanelMain";
            this.btnPanelMain.Size = new System.Drawing.Size(290, 59);
            this.btnPanelMain.TabIndex = 1;
            this.btnPanelMain.Text = "На главную";
            this.btnPanelMain.UseVisualStyleBackColor = true;
            this.btnPanelMain.Click += new System.EventHandler(this.btnPanelMain_Click);
            // 
            // btnPreviousPanel
            // 
            this.btnPreviousPanel.Location = new System.Drawing.Point(493, 488);
            this.btnPreviousPanel.Name = "btnPreviousPanel";
            this.btnPreviousPanel.Size = new System.Drawing.Size(135, 51);
            this.btnPreviousPanel.TabIndex = 2;
            this.btnPreviousPanel.Text = "Предыдущая страница";
            this.btnPreviousPanel.UseVisualStyleBackColor = true;
            this.btnPreviousPanel.Click += new System.EventHandler(this.btnPreviousPanel_Click);
            // 
            // btnNextPanel
            // 
            this.btnNextPanel.Location = new System.Drawing.Point(666, 488);
            this.btnNextPanel.Name = "btnNextPanel";
            this.btnNextPanel.Size = new System.Drawing.Size(135, 51);
            this.btnNextPanel.TabIndex = 3;
            this.btnNextPanel.Text = "Предыдущая страница";
            this.btnNextPanel.UseVisualStyleBackColor = true;
            this.btnNextPanel.Click += new System.EventHandler(this.btnNextPanel_Click);
            // 
            // panelOutlet
            // 
            this.panelOutlet.Controls.Add(this.panelOutletLabel);
            this.panelOutlet.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutlet.Location = new System.Drawing.Point(12, 33);
            this.panelOutlet.Name = "panelOutlet";
            this.panelOutlet.Size = new System.Drawing.Size(948, 479);
            this.panelOutlet.TabIndex = 4;
            // 
            // panelOutletLabel
            // 
            this.panelOutletLabel.Location = new System.Drawing.Point(8, 9);
            this.panelOutletLabel.Name = "panelOutletLabel";
            this.panelOutletLabel.Size = new System.Drawing.Size(299, 28);
            this.panelOutletLabel.TabIndex = 0;
            this.panelOutletLabel.Text = "Просмотр: \"Торговые точки\"";
            // 
            // panelMainLabel
            // 
            this.panelMainLabel.AutoSize = true;
            this.panelMainLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMainLabel.Location = new System.Drawing.Point(290, 9);
            this.panelMainLabel.Name = "panelMainLabel";
            this.panelMainLabel.Size = new System.Drawing.Size(338, 46);
            this.panelMainLabel.TabIndex = 4;
            this.panelMainLabel.Text = "Добро пожаловать!";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 605);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelOutlet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOutlet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelOutletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelMainToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnPanelOutlet;
        private System.Windows.Forms.Button btnPanelMain;
        private System.Windows.Forms.Button btnPreviousPanel;
        private System.Windows.Forms.Button btnNextPanel;
        private System.Windows.Forms.Panel panelOutlet;
        private System.Windows.Forms.Label panelOutletLabel;
        private System.Windows.Forms.Label panelMainLabel;
    }
}