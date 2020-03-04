namespace LibraryApp
{
    partial class Search
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
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbExample = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnSearchNow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(226)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // lbExample
            // 
            this.lbExample.AutoSize = true;
            this.lbExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExample.Location = new System.Drawing.Point(176, 67);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(61, 16);
            this.lbExample.TabIndex = 2;
            this.lbExample.Text = "Example";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(179, 38);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(411, 26);
            this.txtValue.TabIndex = 3;
            // 
            // txtPrompt
            // 
            this.txtPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrompt.Location = new System.Drawing.Point(12, 41);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(161, 19);
            this.txtPrompt.TabIndex = 4;
            this.txtPrompt.Text = "Enter Name";
            this.txtPrompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearchNow
            // 
            this.btnSearchNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnSearchNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNow.ForeColor = System.Drawing.Color.White;
            this.btnSearchNow.Location = new System.Drawing.Point(12, 109);
            this.btnSearchNow.Name = "btnSearchNow";
            this.btnSearchNow.Size = new System.Drawing.Size(578, 30);
            this.btnSearchNow.TabIndex = 5;
            this.btnSearchNow.Text = "Search Now!";
            this.btnSearchNow.UseVisualStyleBackColor = false;
            this.btnSearchNow.Click += new System.EventHandler(this.btnSearchNow_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(604, 151);
            this.Controls.Add(this.btnSearchNow);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lbExample);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SupportingClassAddEdit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnSearchNow;
    }
}