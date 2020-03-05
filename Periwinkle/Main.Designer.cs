namespace LibraryApp
{
    partial class Main
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSubSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutSubSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaSubSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(226)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.userSubSystemToolStripMenuItem,
            this.checkOutSubSystemToolStripMenuItem,
            this.mediaSubSystemToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.ToolTipText = "Login Now";
            // 
            // userSubSystemToolStripMenuItem
            // 
            this.userSubSystemToolStripMenuItem.Name = "userSubSystemToolStripMenuItem";
            this.userSubSystemToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.userSubSystemToolStripMenuItem.Text = "User Sub-System";
            this.userSubSystemToolStripMenuItem.ToolTipText = "Load the User Sub-System";
            this.userSubSystemToolStripMenuItem.Click += new System.EventHandler(this.userSubSystemToolStripMenuItem_Click);
            // 
            // checkOutSubSystemToolStripMenuItem
            // 
            this.checkOutSubSystemToolStripMenuItem.Name = "checkOutSubSystemToolStripMenuItem";
            this.checkOutSubSystemToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.checkOutSubSystemToolStripMenuItem.Text = "Check-Out Sub-System";
            this.checkOutSubSystemToolStripMenuItem.ToolTipText = "Load the Check-Out Sub-System";
            // 
            // mediaSubSystemToolStripMenuItem
            // 
            this.mediaSubSystemToolStripMenuItem.Name = "mediaSubSystemToolStripMenuItem";
            this.mediaSubSystemToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.mediaSubSystemToolStripMenuItem.Text = "Media Sub-System";
            this.mediaSubSystemToolStripMenuItem.ToolTipText = "Load the Media Sub-System";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.toolStripMenuItem1.Text = "============";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit the Library System";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryApp.Properties.Resources.furelise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 710);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Periwinkle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSubSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutSubSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaSubSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}