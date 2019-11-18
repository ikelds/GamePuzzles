namespace Game15
{
    partial class Game15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game15));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.menu_level,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.начатьИгруToolStripMenuItem.Text = "Перемешать";
            this.начатьИгруToolStripMenuItem.Click += new System.EventHandler(this.начатьИгруToolStripMenuItem_Click);
            // 
            // menu_level
            // 
            this.menu_level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_level3,
            this.menu_level4,
            this.menu_level5,
            this.menu_level6});
            this.menu_level.Name = "menu_level";
            this.menu_level.Size = new System.Drawing.Size(65, 20);
            this.menu_level.Text = "Уровень";
            // 
            // menu_level3
            // 
            this.menu_level3.Name = "menu_level3";
            this.menu_level3.Size = new System.Drawing.Size(180, 22);
            this.menu_level3.Text = "3 х 3";
            this.menu_level3.Click += new System.EventHandler(this.menu_level3_Click);
            // 
            // menu_level4
            // 
            this.menu_level4.Name = "menu_level4";
            this.menu_level4.Size = new System.Drawing.Size(180, 22);
            this.menu_level4.Text = "4 х 4";
            this.menu_level4.Click += new System.EventHandler(this.menu_level4_Click);
            // 
            // menu_level5
            // 
            this.menu_level5.Name = "menu_level5";
            this.menu_level5.Size = new System.Drawing.Size(180, 22);
            this.menu_level5.Text = "5 х 5";
            this.menu_level5.Click += new System.EventHandler(this.menu_level5_Click);
            // 
            // menu_level6
            // 
            this.menu_level6.Name = "menu_level6";
            this.menu_level6.Size = new System.Drawing.Size(180, 22);
            this.menu_level6.Text = "6 х 6";
            this.menu_level6.Click += new System.EventHandler(this.menu_level6_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 657);
            this.panel1.TabIndex = 1;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Game15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Game15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пазлы";
            this.Load += new System.EventHandler(this.Game15_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_level;
        private System.Windows.Forms.ToolStripMenuItem menu_level3;
        private System.Windows.Forms.ToolStripMenuItem menu_level4;
        private System.Windows.Forms.ToolStripMenuItem menu_level5;
        private System.Windows.Forms.ToolStripMenuItem menu_level6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

