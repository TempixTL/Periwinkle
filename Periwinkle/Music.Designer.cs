using System.Windows.Forms;
using Microsoft.Win32;

namespace LibraryApp
{
    partial class Music
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
            this.components = new System.ComponentModel.Container();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnCheckOutTransfer = new System.Windows.Forms.Button();
            this.btnPayFineTransfer = new System.Windows.Forms.Button();
            this.btnViewDetails1 = new System.Windows.Forms.Button();
            this.btnViewDetails2 = new System.Windows.Forms.Button();
            this.btnViewDetails3 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnPreviousRight = new System.Windows.Forms.Button();
            this.btnLastRight = new System.Windows.Forms.Button();
            this.btnNextRight = new System.Windows.Forms.Button();
            this.btnFirstRight = new System.Windows.Forms.Button();
            this.btnPreviousLeft = new System.Windows.Forms.Button();
            this.btnLastLeft = new System.Windows.Forms.Button();
            this.btnNextLeft = new System.Windows.Forms.Button();
            this.btnFirstLeft = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SongInfo = new System.Windows.Forms.TabPage();
            this.txtRenewalDate = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.AlbumInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID1 = new System.Windows.Forms.Label();
            this.txtRenewalDate1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserName1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLast1 = new System.Windows.Forms.Label();
            this.AllSongs = new System.Windows.Forms.TabPage();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCheckOut3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgCheckOut = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byUniversityIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsAddEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypesAddEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTrace = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.SongInfo.SuspendLayout();
            this.AlbumInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AllSongs.SuspendLayout();
            this.pnlCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckOut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(37, 59);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(86, 19);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Song Title";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(128, 56);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(357, 19);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Leave += new System.EventHandler(this.TxtFirst_Leave);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(128, 94);
            this.txtLast.Name = "txtLast";
            this.txtLast.ReadOnly = true;
            this.txtLast.Size = new System.Drawing.Size(357, 19);
            this.txtLast.TabIndex = 2;
            this.txtLast.Leave += new System.EventHandler(this.TxtLast_Leave);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(65, 97);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 19);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Album";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(912, 522);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(130, 23);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "Test";
            this.toolTip1.SetToolTip(this.btnTest, "btnTest might be used to display local variables!");
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(154, 32);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(25, 25);
            this.btnA.TabIndex = 8;
            this.btnA.Text = "A";
            this.toolTip1.SetToolTip(this.btnA, "Navigate to the Next Logical Record Within the View");
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Location = new System.Drawing.Point(278, 32);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(25, 25);
            this.btnE.TabIndex = 9;
            this.btnE.Text = "E";
            this.toolTip1.SetToolTip(this.btnE, "Navigate to the Next Logical Record Within the View");
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(247, 32);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(25, 25);
            this.btnD.TabIndex = 10;
            this.btnD.Text = "D";
            this.toolTip1.SetToolTip(this.btnD, "Navigate to the Next Logical Record Within the View");
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF.ForeColor = System.Drawing.Color.White;
            this.btnF.Location = new System.Drawing.Point(309, 32);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(25, 25);
            this.btnF.TabIndex = 11;
            this.btnF.Text = "F";
            this.toolTip1.SetToolTip(this.btnF, "Navigate to the Next Logical Record Within the View");
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnH.FlatAppearance.BorderSize = 0;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnH.Location = new System.Drawing.Point(371, 32);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(25, 25);
            this.btnH.TabIndex = 12;
            this.btnH.Text = "H";
            this.toolTip1.SetToolTip(this.btnH, "Navigate to the Next Logical Record Within the View");
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnG.FlatAppearance.BorderSize = 0;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.ForeColor = System.Drawing.Color.White;
            this.btnG.Location = new System.Drawing.Point(340, 32);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(25, 25);
            this.btnG.TabIndex = 13;
            this.btnG.Text = "G";
            this.toolTip1.SetToolTip(this.btnG, "Navigate to the Next Logical Record Within the View");
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnI.FlatAppearance.BorderSize = 0;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnI.ForeColor = System.Drawing.Color.White;
            this.btnI.Location = new System.Drawing.Point(402, 32);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(25, 25);
            this.btnI.TabIndex = 14;
            this.btnI.Text = "I";
            this.toolTip1.SetToolTip(this.btnI, "Navigate to the Next Logical Record Within the View");
            this.btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnJ.FlatAppearance.BorderSize = 0;
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJ.ForeColor = System.Drawing.Color.White;
            this.btnJ.Location = new System.Drawing.Point(433, 32);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(25, 25);
            this.btnJ.TabIndex = 15;
            this.btnJ.Text = "J";
            this.toolTip1.SetToolTip(this.btnJ, "Navigate to the Next Logical Record Within the View");
            this.btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnK.FlatAppearance.BorderSize = 0;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnK.ForeColor = System.Drawing.Color.White;
            this.btnK.Location = new System.Drawing.Point(464, 32);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(25, 25);
            this.btnK.TabIndex = 16;
            this.btnK.Text = "K";
            this.toolTip1.SetToolTip(this.btnK, "Navigate to the Next Logical Record Within the View");
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnL.Location = new System.Drawing.Point(495, 32);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(25, 25);
            this.btnL.TabIndex = 17;
            this.btnL.Text = "L";
            this.toolTip1.SetToolTip(this.btnL, "Navigate to the Next Logical Record Within the View");
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnN.FlatAppearance.BorderSize = 0;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN.ForeColor = System.Drawing.Color.White;
            this.btnN.Location = new System.Drawing.Point(557, 32);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(25, 25);
            this.btnN.TabIndex = 18;
            this.btnN.Text = "N";
            this.toolTip1.SetToolTip(this.btnN, "Navigate to the Next Logical Record Within the View");
            this.btnN.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnM.FlatAppearance.BorderSize = 0;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.Location = new System.Drawing.Point(526, 32);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(25, 25);
            this.btnM.TabIndex = 19;
            this.btnM.Text = "M";
            this.toolTip1.SetToolTip(this.btnM, "Navigate to the Next Logical Record Within the View");
            this.btnM.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(216, 32);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(25, 25);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.toolTip1.SetToolTip(this.btnC, "Navigate to the Next Logical Record Within the View");
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.ForeColor = System.Drawing.Color.White;
            this.btnP.Location = new System.Drawing.Point(619, 32);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(25, 25);
            this.btnP.TabIndex = 21;
            this.btnP.Text = "P";
            this.toolTip1.SetToolTip(this.btnP, "Navigate to the Next Logical Record Within the View");
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnO.FlatAppearance.BorderSize = 0;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnO.ForeColor = System.Drawing.Color.White;
            this.btnO.Location = new System.Drawing.Point(588, 32);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(25, 25);
            this.btnO.TabIndex = 22;
            this.btnO.Text = "O";
            this.toolTip1.SetToolTip(this.btnO, "Navigate to the Next Logical Record Within the View");
            this.btnO.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.ForeColor = System.Drawing.Color.White;
            this.btnR.Location = new System.Drawing.Point(278, 63);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(25, 25);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "R";
            this.toolTip1.SetToolTip(this.btnR, "Navigate to the Next Logical Record Within the View");
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnQ.FlatAppearance.BorderSize = 0;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQ.ForeColor = System.Drawing.Color.White;
            this.btnQ.Location = new System.Drawing.Point(247, 63);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(25, 25);
            this.btnQ.TabIndex = 24;
            this.btnQ.Text = "Q";
            this.toolTip1.SetToolTip(this.btnQ, "Navigate to the Next Logical Record Within the View");
            this.btnQ.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnZ.FlatAppearance.BorderSize = 0;
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZ.ForeColor = System.Drawing.Color.White;
            this.btnZ.Location = new System.Drawing.Point(526, 63);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(25, 25);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.toolTip1.SetToolTip(this.btnZ, "Navigate to the Next Logical Record Within the View");
            this.btnZ.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnU.FlatAppearance.BorderSize = 0;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU.ForeColor = System.Drawing.Color.White;
            this.btnU.Location = new System.Drawing.Point(371, 63);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(25, 25);
            this.btnU.TabIndex = 26;
            this.btnU.Text = "U";
            this.toolTip1.SetToolTip(this.btnU, "Navigate to the Next Logical Record Within the View");
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnT.FlatAppearance.BorderSize = 0;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnT.ForeColor = System.Drawing.Color.White;
            this.btnT.Location = new System.Drawing.Point(340, 63);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(25, 25);
            this.btnT.TabIndex = 27;
            this.btnT.Text = "T";
            this.toolTip1.SetToolTip(this.btnT, "Navigate to the Next Logical Record Within the View");
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Location = new System.Drawing.Point(309, 63);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(25, 25);
            this.btnS.TabIndex = 28;
            this.btnS.Text = "S";
            this.toolTip1.SetToolTip(this.btnS, "Navigate to the Next Logical Record Within the View");
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnY.FlatAppearance.BorderSize = 0;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY.ForeColor = System.Drawing.Color.White;
            this.btnY.Location = new System.Drawing.Point(495, 63);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(25, 25);
            this.btnY.TabIndex = 29;
            this.btnY.Text = "Y";
            this.toolTip1.SetToolTip(this.btnY, "Navigate to the Next Logical Record Within the View");
            this.btnY.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(464, 63);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 25);
            this.btnX.TabIndex = 30;
            this.btnX.Text = "X";
            this.toolTip1.SetToolTip(this.btnX, "Navigate to the Next Logical Record Within the View");
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnW.FlatAppearance.BorderSize = 0;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnW.ForeColor = System.Drawing.Color.White;
            this.btnW.Location = new System.Drawing.Point(433, 63);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(25, 25);
            this.btnW.TabIndex = 31;
            this.btnW.Text = "W";
            this.toolTip1.SetToolTip(this.btnW, "Navigate to the Next Logical Record Within the View");
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnV.FlatAppearance.BorderSize = 0;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnV.ForeColor = System.Drawing.Color.White;
            this.btnV.Location = new System.Drawing.Point(402, 63);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(25, 25);
            this.btnV.TabIndex = 32;
            this.btnV.Text = "V";
            this.toolTip1.SetToolTip(this.btnV, "Navigate to the Next Logical Record Within the View");
            this.btnV.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(185, 32);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(25, 25);
            this.btnB.TabIndex = 33;
            this.btnB.Text = "B";
            this.toolTip1.SetToolTip(this.btnB, "Navigate to the Next Logical Record Within the View");
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnCheckOutTransfer
            // 
            this.btnCheckOutTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnCheckOutTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnCheckOutTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOutTransfer.ForeColor = System.Drawing.Color.White;
            this.btnCheckOutTransfer.Location = new System.Drawing.Point(18, 287);
            this.btnCheckOutTransfer.Name = "btnCheckOutTransfer";
            this.btnCheckOutTransfer.Size = new System.Drawing.Size(457, 23);
            this.btnCheckOutTransfer.TabIndex = 42;
            this.btnCheckOutTransfer.Text = "Play Now!";
            this.toolTip1.SetToolTip(this.btnCheckOutTransfer, "Start Song Playing in Music Player");
            this.btnCheckOutTransfer.UseVisualStyleBackColor = false;
            // 
            // btnPayFineTransfer
            // 
            this.btnPayFineTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPayFineTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnPayFineTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFineTransfer.ForeColor = System.Drawing.Color.White;
            this.btnPayFineTransfer.Location = new System.Drawing.Point(491, 287);
            this.btnPayFineTransfer.Name = "btnPayFineTransfer";
            this.btnPayFineTransfer.Size = new System.Drawing.Size(210, 23);
            this.btnPayFineTransfer.TabIndex = 43;
            this.btnPayFineTransfer.Text = "Add To Playlist";
            this.toolTip1.SetToolTip(this.btnPayFineTransfer, "Choose a playlist and add this song");
            this.btnPayFineTransfer.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails1
            // 
            this.btnViewDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnViewDetails1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails1.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails1.Location = new System.Drawing.Point(492, 0);
            this.btnViewDetails1.Name = "btnViewDetails1";
            this.btnViewDetails1.Size = new System.Drawing.Size(71, 23);
            this.btnViewDetails1.TabIndex = 3;
            this.btnViewDetails1.Text = "View";
            this.toolTip1.SetToolTip(this.btnViewDetails1, "View the Details of this Transaction");
            this.btnViewDetails1.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails2
            // 
            this.btnViewDetails2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnViewDetails2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails2.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails2.Location = new System.Drawing.Point(492, 22);
            this.btnViewDetails2.Name = "btnViewDetails2";
            this.btnViewDetails2.Size = new System.Drawing.Size(71, 23);
            this.btnViewDetails2.TabIndex = 4;
            this.btnViewDetails2.Text = "View";
            this.toolTip1.SetToolTip(this.btnViewDetails2, "View the Details of this Transaction");
            this.btnViewDetails2.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails3
            // 
            this.btnViewDetails3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnViewDetails3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails3.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails3.Location = new System.Drawing.Point(492, 44);
            this.btnViewDetails3.Name = "btnViewDetails3";
            this.btnViewDetails3.Size = new System.Drawing.Size(71, 23);
            this.btnViewDetails3.TabIndex = 5;
            this.btnViewDetails3.Text = "* View *";
            this.toolTip1.SetToolTip(this.btnViewDetails3, "View the Details of this Transaction");
            this.btnViewDetails3.UseVisualStyleBackColor = false;
            this.btnViewDetails3.Click += new System.EventHandler(this.btnViewDetails3_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete3.ForeColor = System.Drawing.Color.White;
            this.btnDelete3.Location = new System.Drawing.Point(563, 44);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(62, 23);
            this.btnDelete3.TabIndex = 8;
            this.btnDelete3.Text = "* Play *";
            this.toolTip1.SetToolTip(this.btnDelete3, "Delete this Transaction");
            this.btnDelete3.UseVisualStyleBackColor = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete2.ForeColor = System.Drawing.Color.White;
            this.btnDelete2.Location = new System.Drawing.Point(563, 22);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(62, 23);
            this.btnDelete2.TabIndex = 7;
            this.btnDelete2.Text = "Play";
            this.toolTip1.SetToolTip(this.btnDelete2, "Delete this Transaction");
            this.btnDelete2.UseVisualStyleBackColor = false;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.Location = new System.Drawing.Point(563, 0);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(62, 23);
            this.btnDelete1.TabIndex = 6;
            this.btnDelete1.Text = "Play";
            this.toolTip1.SetToolTip(this.btnDelete1, "Delete this Transaction");
            this.btnDelete1.UseVisualStyleBackColor = false;
            // 
            // btnPreviousRight
            // 
            this.btnPreviousRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPreviousRight.BackgroundImage = global::LibraryApp.Properties.Resources.Previous;
            this.btnPreviousRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnPreviousRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousRight.Location = new System.Drawing.Point(686, 45);
            this.btnPreviousRight.Name = "btnPreviousRight";
            this.btnPreviousRight.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousRight.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnPreviousRight, "Navigate to the Previous Logical Record Within the View");
            this.btnPreviousRight.UseVisualStyleBackColor = false;
            this.btnPreviousRight.Click += new System.EventHandler(this.btnPreviousRight_Click);
            // 
            // btnLastRight
            // 
            this.btnLastRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnLastRight.BackgroundImage = global::LibraryApp.Properties.Resources.Last;
            this.btnLastRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnLastRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastRight.Location = new System.Drawing.Point(715, 74);
            this.btnLastRight.Name = "btnLastRight";
            this.btnLastRight.Size = new System.Drawing.Size(30, 30);
            this.btnLastRight.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLastRight, "Navigate to the Last Logical Record Within the View");
            this.btnLastRight.UseVisualStyleBackColor = false;
            this.btnLastRight.Click += new System.EventHandler(this.btnLastRight_Click);
            // 
            // btnNextRight
            // 
            this.btnNextRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnNextRight.BackgroundImage = global::LibraryApp.Properties.Resources.Next;
            this.btnNextRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnNextRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextRight.Location = new System.Drawing.Point(744, 45);
            this.btnNextRight.Name = "btnNextRight";
            this.btnNextRight.Size = new System.Drawing.Size(30, 30);
            this.btnNextRight.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNextRight, "Navigate to the Next Logical Record Within the View");
            this.btnNextRight.UseVisualStyleBackColor = false;
            this.btnNextRight.Click += new System.EventHandler(this.btnNextRight_Click);
            // 
            // btnFirstRight
            // 
            this.btnFirstRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnFirstRight.BackgroundImage = global::LibraryApp.Properties.Resources.First;
            this.btnFirstRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirstRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnFirstRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirstRight.Location = new System.Drawing.Point(715, 16);
            this.btnFirstRight.Name = "btnFirstRight";
            this.btnFirstRight.Size = new System.Drawing.Size(30, 30);
            this.btnFirstRight.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnFirstRight, "Navigate to the First Logical Record Within the View");
            this.btnFirstRight.UseVisualStyleBackColor = false;
            this.btnFirstRight.Click += new System.EventHandler(this.btnFirstRight_Click);
            // 
            // btnPreviousLeft
            // 
            this.btnPreviousLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPreviousLeft.BackgroundImage = global::LibraryApp.Properties.Resources.Previous;
            this.btnPreviousLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviousLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnPreviousLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousLeft.Location = new System.Drawing.Point(16, 45);
            this.btnPreviousLeft.Name = "btnPreviousLeft";
            this.btnPreviousLeft.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousLeft.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPreviousLeft, "Navigate to the Previous Logical Record Within the View");
            this.btnPreviousLeft.UseVisualStyleBackColor = false;
            this.btnPreviousLeft.Click += new System.EventHandler(this.btnPreviousLeft_Click);
            // 
            // btnLastLeft
            // 
            this.btnLastLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnLastLeft.BackgroundImage = global::LibraryApp.Properties.Resources.Last;
            this.btnLastLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnLastLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastLeft.Location = new System.Drawing.Point(45, 74);
            this.btnLastLeft.Name = "btnLastLeft";
            this.btnLastLeft.Size = new System.Drawing.Size(30, 30);
            this.btnLastLeft.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnLastLeft, "Navigate to the Last Logical Record Within the View");
            this.btnLastLeft.UseVisualStyleBackColor = false;
            this.btnLastLeft.Click += new System.EventHandler(this.btnLastLeft_Click);
            // 
            // btnNextLeft
            // 
            this.btnNextLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnNextLeft.BackgroundImage = global::LibraryApp.Properties.Resources.Next;
            this.btnNextLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnNextLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextLeft.Location = new System.Drawing.Point(74, 45);
            this.btnNextLeft.Name = "btnNextLeft";
            this.btnNextLeft.Size = new System.Drawing.Size(30, 30);
            this.btnNextLeft.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNextLeft, "Navigate to the Next Logical Record Within the View");
            this.btnNextLeft.UseVisualStyleBackColor = false;
            this.btnNextLeft.Click += new System.EventHandler(this.btnNextLeft_Click);
            // 
            // btnFirstLeft
            // 
            this.btnFirstLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnFirstLeft.BackgroundImage = global::LibraryApp.Properties.Resources.First;
            this.btnFirstLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirstLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnFirstLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirstLeft.Location = new System.Drawing.Point(45, 16);
            this.btnFirstLeft.Name = "btnFirstLeft";
            this.btnFirstLeft.Size = new System.Drawing.Size(30, 30);
            this.btnFirstLeft.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnFirstLeft, "Navigate to the First Logical Record Within the View");
            this.btnFirstLeft.UseVisualStyleBackColor = false;
            this.btnFirstLeft.Click += new System.EventHandler(this.btnFirstLeft_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(128, 132);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(357, 19);
            this.txtUserName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUserName, "Click To Go To Artist Sub-System");
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(491, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 210);
            this.button6.TabIndex = 44;
            this.button6.Text = "Album Art Goes Here\r\nClick to go to Album";
            this.toolTip1.SetToolTip(this.button6, "Click To View Album");
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 210);
            this.button7.TabIndex = 45;
            this.button7.Text = "Album Art Goes Here";
            this.toolTip1.SetToolTip(this.button7, "Click To View Album");
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(514, 312);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(210, 23);
            this.button8.TabIndex = 48;
            this.button8.Text = "Add To Playlist";
            this.toolTip1.SetToolTip(this.button8, "Choose a playlist and add this song");
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(41, 312);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(457, 23);
            this.button9.TabIndex = 47;
            this.button9.Text = "Play Now!";
            this.toolTip1.SetToolTip(this.button9, "Start Song Playing in Music Player");
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(625, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button1, "Delete this Transaction");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(625, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button2, "Delete this Transaction");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(625, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button3, "Delete this Transaction");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(625, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button4, "Delete this Transaction");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(625, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button5, "Delete this Transaction");
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(625, 66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button10, "Delete this Transaction");
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(563, 110);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "* Play *";
            this.toolTip1.SetToolTip(this.button11, "Delete this Transaction");
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(563, 88);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "Play";
            this.toolTip1.SetToolTip(this.button12, "Delete this Transaction");
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(563, 66);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(62, 23);
            this.button13.TabIndex = 18;
            this.button13.Text = "Play";
            this.toolTip1.SetToolTip(this.button13, "Delete this Transaction");
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(492, 110);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "* View *";
            this.toolTip1.SetToolTip(this.button14, "View the Details of this Transaction");
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(492, 88);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(71, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "View";
            this.toolTip1.SetToolTip(this.button15, "View the Details of this Transaction");
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(492, 66);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(71, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = "View";
            this.toolTip1.SetToolTip(this.button16, "View the Details of this Transaction");
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(625, 153);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(107, 23);
            this.button17.TabIndex = 31;
            this.button17.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button17, "Delete this Transaction");
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(625, 131);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(107, 23);
            this.button18.TabIndex = 30;
            this.button18.Text = "Add to Playlist";
            this.toolTip1.SetToolTip(this.button18, "Delete this Transaction");
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(563, 153);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(62, 23);
            this.button19.TabIndex = 29;
            this.button19.Text = "* Play *";
            this.toolTip1.SetToolTip(this.button19, "Delete this Transaction");
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(563, 131);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(62, 23);
            this.button20.TabIndex = 28;
            this.button20.Text = "Play";
            this.toolTip1.SetToolTip(this.button20, "Delete this Transaction");
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(492, 153);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(71, 23);
            this.button21.TabIndex = 27;
            this.button21.Text = "* View *";
            this.toolTip1.SetToolTip(this.button21, "View the Details of this Transaction");
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(492, 131);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(71, 23);
            this.button22.TabIndex = 26;
            this.button22.Text = "View";
            this.toolTip1.SetToolTip(this.button22, "View the Details of this Transaction");
            this.button22.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(73, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(49, 19);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Artist";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(128, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(357, 19);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Main Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Release Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SongInfo);
            this.tabControl1.Controls.Add(this.AlbumInfo);
            this.tabControl1.Controls.Add(this.AllSongs);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 370);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.Tag = "";
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // SongInfo
            // 
            this.SongInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.SongInfo.Controls.Add(this.button6);
            this.SongInfo.Controls.Add(this.btnPayFineTransfer);
            this.SongInfo.Controls.Add(this.btnCheckOutTransfer);
            this.SongInfo.Controls.Add(this.txtRenewalDate);
            this.SongInfo.Controls.Add(this.txtID);
            this.SongInfo.Controls.Add(this.lblFirst);
            this.SongInfo.Controls.Add(this.txtFirst);
            this.SongInfo.Controls.Add(this.lblLast);
            this.SongInfo.Controls.Add(this.txtLast);
            this.SongInfo.Controls.Add(this.lblUsername);
            this.SongInfo.Controls.Add(this.txtUserName);
            this.SongInfo.Controls.Add(this.label5);
            this.SongInfo.Controls.Add(this.label3);
            this.SongInfo.Controls.Add(this.txtEmail);
            this.SongInfo.Location = new System.Drawing.Point(4, 25);
            this.SongInfo.Name = "SongInfo";
            this.SongInfo.Padding = new System.Windows.Forms.Padding(3);
            this.SongInfo.Size = new System.Drawing.Size(782, 341);
            this.SongInfo.TabIndex = 0;
            this.SongInfo.Text = "Song Info";
            // 
            // txtRenewalDate
            // 
            this.txtRenewalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.txtRenewalDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenewalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenewalDate.Location = new System.Drawing.Point(129, 208);
            this.txtRenewalDate.Mask = "00/00/0000";
            this.txtRenewalDate.Name = "txtRenewalDate";
            this.txtRenewalDate.ReadOnly = true;
            this.txtRenewalDate.Size = new System.Drawing.Size(111, 19);
            this.txtRenewalDate.TabIndex = 41;
            this.txtRenewalDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(707, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 16);
            this.txtID.TabIndex = 31;
            this.txtID.Text = "ID 1234";
            // 
            // AlbumInfo
            // 
            this.AlbumInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.AlbumInfo.Controls.Add(this.button8);
            this.AlbumInfo.Controls.Add(this.button9);
            this.AlbumInfo.Controls.Add(this.dataGridView1);
            this.AlbumInfo.Controls.Add(this.button7);
            this.AlbumInfo.Controls.Add(this.txtID1);
            this.AlbumInfo.Controls.Add(this.txtRenewalDate1);
            this.AlbumInfo.Controls.Add(this.label13);
            this.AlbumInfo.Controls.Add(this.txtUserName1);
            this.AlbumInfo.Controls.Add(this.label11);
            this.AlbumInfo.Controls.Add(this.txtLast1);
            this.AlbumInfo.Location = new System.Drawing.Point(4, 25);
            this.AlbumInfo.Name = "AlbumInfo";
            this.AlbumInfo.Padding = new System.Windows.Forms.Padding(3);
            this.AlbumInfo.Size = new System.Drawing.Size(782, 341);
            this.AlbumInfo.TabIndex = 1;
            this.AlbumInfo.Text = "Album Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName});
            this.dataGridView1.Location = new System.Drawing.Point(257, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 251);
            this.dataGridView1.TabIndex = 46;
            // 
            // SongName
            // 
            this.SongName.HeaderText = "Song Name";
            this.SongName.Name = "SongName";
            this.SongName.Width = 420;
            // 
            // txtID1
            // 
            this.txtID1.AutoSize = true;
            this.txtID1.Font = new System.Drawing.Font("Arial", 10F);
            this.txtID1.Location = new System.Drawing.Point(707, 18);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(57, 16);
            this.txtID1.TabIndex = 39;
            this.txtID1.Text = "ID 1234";
            // 
            // txtRenewalDate1
            // 
            this.txtRenewalDate1.AutoSize = true;
            this.txtRenewalDate1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenewalDate1.Location = new System.Drawing.Point(118, 272);
            this.txtRenewalDate1.Name = "txtRenewalDate1";
            this.txtRenewalDate1.Size = new System.Drawing.Size(88, 18);
            this.txtRenewalDate1.TabIndex = 38;
            this.txtRenewalDate1.Text = "10/10/2010";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Released";
            // 
            // txtUserName1
            // 
            this.txtUserName1.AutoSize = true;
            this.txtUserName1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName1.Location = new System.Drawing.Point(73, 254);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.Size = new System.Drawing.Size(19, 18);
            this.txtUserName1.TabIndex = 36;
            this.txtUserName1.Text = "E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "By";
            // 
            // txtLast1
            // 
            this.txtLast1.AutoSize = true;
            this.txtLast1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast1.Location = new System.Drawing.Point(38, 19);
            this.txtLast1.Name = "txtLast1";
            this.txtLast1.Size = new System.Drawing.Size(94, 18);
            this.txtLast1.TabIndex = 34;
            this.txtLast1.Text = "Album Title";
            // 
            // AllSongs
            // 
            this.AllSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.AllSongs.Controls.Add(this.pnlCheckOut);
            this.AllSongs.Controls.Add(this.dgCheckOut);
            this.AllSongs.Location = new System.Drawing.Point(4, 25);
            this.AllSongs.Name = "AllSongs";
            this.AllSongs.Size = new System.Drawing.Size(782, 341);
            this.AllSongs.TabIndex = 2;
            this.AllSongs.Text = "All Songs";
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.Controls.Add(this.button17);
            this.pnlCheckOut.Controls.Add(this.button18);
            this.pnlCheckOut.Controls.Add(this.button19);
            this.pnlCheckOut.Controls.Add(this.button20);
            this.pnlCheckOut.Controls.Add(this.button21);
            this.pnlCheckOut.Controls.Add(this.button22);
            this.pnlCheckOut.Controls.Add(this.textBox6);
            this.pnlCheckOut.Controls.Add(this.textBox7);
            this.pnlCheckOut.Controls.Add(this.button4);
            this.pnlCheckOut.Controls.Add(this.button5);
            this.pnlCheckOut.Controls.Add(this.button10);
            this.pnlCheckOut.Controls.Add(this.button11);
            this.pnlCheckOut.Controls.Add(this.button12);
            this.pnlCheckOut.Controls.Add(this.button13);
            this.pnlCheckOut.Controls.Add(this.button14);
            this.pnlCheckOut.Controls.Add(this.button15);
            this.pnlCheckOut.Controls.Add(this.button16);
            this.pnlCheckOut.Controls.Add(this.textBox3);
            this.pnlCheckOut.Controls.Add(this.textBox4);
            this.pnlCheckOut.Controls.Add(this.textBox5);
            this.pnlCheckOut.Controls.Add(this.button1);
            this.pnlCheckOut.Controls.Add(this.button2);
            this.pnlCheckOut.Controls.Add(this.button3);
            this.pnlCheckOut.Controls.Add(this.btnDelete3);
            this.pnlCheckOut.Controls.Add(this.btnDelete2);
            this.pnlCheckOut.Controls.Add(this.btnDelete1);
            this.pnlCheckOut.Controls.Add(this.btnViewDetails3);
            this.pnlCheckOut.Controls.Add(this.btnViewDetails2);
            this.pnlCheckOut.Controls.Add(this.btnViewDetails1);
            this.pnlCheckOut.Controls.Add(this.txtCheckOut3);
            this.pnlCheckOut.Controls.Add(this.textBox2);
            this.pnlCheckOut.Controls.Add(this.textBox1);
            this.pnlCheckOut.Location = new System.Drawing.Point(15, 79);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(753, 244);
            this.pnlCheckOut.TabIndex = 48;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(0, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(492, 23);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "                         5                     7             6/7/2017";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(0, 131);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(492, 23);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "                        10                    14            3/15/2017";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(492, 23);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "                         5                     7             6/7/2017";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(492, 23);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "                        10                    14            3/15/2017";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(492, 23);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "                  song name                  957            3/14/2017";
            // 
            // txtCheckOut3
            // 
            this.txtCheckOut3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut3.Location = new System.Drawing.Point(0, 44);
            this.txtCheckOut3.Name = "txtCheckOut3";
            this.txtCheckOut3.Size = new System.Drawing.Size(492, 23);
            this.txtCheckOut3.TabIndex = 2;
            this.txtCheckOut3.Text = "                         5                     7             6/7/2017";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(492, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "                        10                    14            3/15/2017";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "                  song name                  957            3/14/2017";
            // 
            // dgCheckOut
            // 
            this.dgCheckOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.Album,
            this.TDate,
            this.ViewDetails,
            this.TDelete});
            this.dgCheckOut.Location = new System.Drawing.Point(15, 54);
            this.dgCheckOut.Name = "dgCheckOut";
            this.dgCheckOut.Size = new System.Drawing.Size(753, 93);
            this.dgCheckOut.TabIndex = 47;
            // 
            // title
            // 
            this.title.HeaderText = "Song Title";
            this.title.Name = "title";
            this.title.Width = 150;
            // 
            // Album
            // 
            this.Album.HeaderText = "Album Name";
            this.Album.Name = "Album";
            this.Album.Width = 150;
            // 
            // TDate
            // 
            this.TDate.HeaderText = "Release Date";
            this.TDate.Name = "TDate";
            this.TDate.Width = 150;
            // 
            // ViewDetails
            // 
            this.ViewDetails.HeaderText = "";
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Width = 120;
            // 
            // TDelete
            // 
            this.TDelete.HeaderText = "";
            this.TDelete.Name = "TDelete";
            this.TDelete.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(226)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.undeleteToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.administrativeToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.dATAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.ToolTipText = "Add A New User";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.ToolTipText = "Edit This User";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.ToolTipText = "Delete This User";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // undeleteToolStripMenuItem
            // 
            this.undeleteToolStripMenuItem.Name = "undeleteToolStripMenuItem";
            this.undeleteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.undeleteToolStripMenuItem.Text = "Undelete";
            this.undeleteToolStripMenuItem.ToolTipText = "UnDelete This User";
            this.undeleteToolStripMenuItem.Click += new System.EventHandler(this.undeleteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byIDToolStripMenuItem,
            this.byUniversityIDToolStripMenuItem,
            this.byPhoneToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byIDToolStripMenuItem
            // 
            this.byIDToolStripMenuItem.Name = "byIDToolStripMenuItem";
            this.byIDToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byIDToolStripMenuItem.Text = "By Album";
            this.byIDToolStripMenuItem.Click += new System.EventHandler(this.byIDToolStripMenuItem_Click);
            // 
            // byUniversityIDToolStripMenuItem
            // 
            this.byUniversityIDToolStripMenuItem.Name = "byUniversityIDToolStripMenuItem";
            this.byUniversityIDToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byUniversityIDToolStripMenuItem.Text = "By Artist";
            this.byUniversityIDToolStripMenuItem.Click += new System.EventHandler(this.byUniversityIDToolStripMenuItem_Click);
            // 
            // byPhoneToolStripMenuItem
            // 
            this.byPhoneToolStripMenuItem.Name = "byPhoneToolStripMenuItem";
            this.byPhoneToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byPhoneToolStripMenuItem.Text = "By Genre";
            this.byPhoneToolStripMenuItem.Click += new System.EventHandler(this.byPhoneToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.toolStripMenuItem1.Text = "============";
            this.toolStripMenuItem1.ToolTipText = "This is not a button : - )";
            // 
            // administrativeToolStripMenuItem
            // 
            this.administrativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentsAddEditDeleteToolStripMenuItem,
            this.userTypesAddEditDeleteToolStripMenuItem});
            this.administrativeToolStripMenuItem.Name = "administrativeToolStripMenuItem";
            this.administrativeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administrativeToolStripMenuItem.Text = "Administrative";
            this.administrativeToolStripMenuItem.ToolTipText = "Administrative Tools";
            // 
            // departmentsAddEditDeleteToolStripMenuItem
            // 
            this.departmentsAddEditDeleteToolStripMenuItem.Name = "departmentsAddEditDeleteToolStripMenuItem";
            this.departmentsAddEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.departmentsAddEditDeleteToolStripMenuItem.Text = "Genres --> Add, Edit, Delete";
            this.departmentsAddEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.departmentsAddEditDeleteToolStripMenuItem_Click);
            // 
            // userTypesAddEditDeleteToolStripMenuItem
            // 
            this.userTypesAddEditDeleteToolStripMenuItem.Name = "userTypesAddEditDeleteToolStripMenuItem";
            this.userTypesAddEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.userTypesAddEditDeleteToolStripMenuItem.Text = "User Types --> Add, Edit, Delete";
            this.userTypesAddEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.userTypesAddEditDeleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close This Form";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dATAToolStripMenuItem
            // 
            this.dATAToolStripMenuItem.Name = "dATAToolStripMenuItem";
            this.dATAToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dATAToolStripMenuItem.Text = "DATA";
            this.dATAToolStripMenuItem.ToolTipText = "Toggle Dummy Data in the Form";
            this.dATAToolStripMenuItem.Click += new System.EventHandler(this.DataToolStripMenuItem_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.pnlNavigation.Controls.Add(this.cbOrderBy);
            this.pnlNavigation.Controls.Add(this.label12);
            this.pnlNavigation.Controls.Add(this.btnB);
            this.pnlNavigation.Controls.Add(this.btnV);
            this.pnlNavigation.Controls.Add(this.btnW);
            this.pnlNavigation.Controls.Add(this.btnX);
            this.pnlNavigation.Controls.Add(this.btnY);
            this.pnlNavigation.Controls.Add(this.btnS);
            this.pnlNavigation.Controls.Add(this.btnT);
            this.pnlNavigation.Controls.Add(this.btnU);
            this.pnlNavigation.Controls.Add(this.btnZ);
            this.pnlNavigation.Controls.Add(this.btnQ);
            this.pnlNavigation.Controls.Add(this.btnR);
            this.pnlNavigation.Controls.Add(this.btnO);
            this.pnlNavigation.Controls.Add(this.btnP);
            this.pnlNavigation.Controls.Add(this.btnC);
            this.pnlNavigation.Controls.Add(this.btnM);
            this.pnlNavigation.Controls.Add(this.btnN);
            this.pnlNavigation.Controls.Add(this.btnL);
            this.pnlNavigation.Controls.Add(this.btnK);
            this.pnlNavigation.Controls.Add(this.btnJ);
            this.pnlNavigation.Controls.Add(this.btnI);
            this.pnlNavigation.Controls.Add(this.btnG);
            this.pnlNavigation.Controls.Add(this.btnH);
            this.pnlNavigation.Controls.Add(this.btnF);
            this.pnlNavigation.Controls.Add(this.btnD);
            this.pnlNavigation.Controls.Add(this.btnE);
            this.pnlNavigation.Controls.Add(this.btnA);
            this.pnlNavigation.Controls.Add(this.btnPreviousRight);
            this.pnlNavigation.Controls.Add(this.btnLastRight);
            this.pnlNavigation.Controls.Add(this.btnNextRight);
            this.pnlNavigation.Controls.Add(this.btnFirstRight);
            this.pnlNavigation.Controls.Add(this.btnPreviousLeft);
            this.pnlNavigation.Controls.Add(this.btnLastLeft);
            this.pnlNavigation.Controls.Add(this.btnNextLeft);
            this.pnlNavigation.Controls.Add(this.btnFirstLeft);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 394);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(790, 160);
            this.pnlNavigation.TabIndex = 35;
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Title",
            "Artist",
            "Release Date",
            "Genre"});
            this.cbOrderBy.Location = new System.Drawing.Point(247, 121);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(304, 27);
            this.cbOrderBy.TabIndex = 37;
            this.cbOrderBy.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "Order By";
            // 
            // lbTrace
            // 
            this.lbTrace.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrace.FormattingEnabled = true;
            this.lbTrace.ItemHeight = 14;
            this.lbTrace.Location = new System.Drawing.Point(804, 48);
            this.lbTrace.Name = "lbTrace";
            this.lbTrace.Size = new System.Drawing.Size(346, 466);
            this.lbTrace.TabIndex = 36;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Music
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Controls.Add(this.lbTrace);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTest);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.Location = new System.Drawing.Point(20, 20);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Music Sub-System | Written By Colin Taylor-Adair";
            this.Load += new System.EventHandler(this.User_Load);
            this.VisibleChanged += new System.EventHandler(this.User_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.SongInfo.ResumeLayout(false);
            this.SongInfo.PerformLayout();
            this.AlbumInfo.ResumeLayout(false);
            this.AlbumInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AllSongs.ResumeLayout(false);
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckOut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SongInfo;
        private System.Windows.Forms.TabPage AlbumInfo;
        private System.Windows.Forms.TabPage AllSongs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byUniversityIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATAToolStripMenuItem;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtLast1;
        private System.Windows.Forms.Label txtID1;
        private System.Windows.Forms.Label txtRenewalDate1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtUserName1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnFirstLeft;
        private System.Windows.Forms.Button btnPreviousRight;
        private System.Windows.Forms.Button btnLastRight;
        private System.Windows.Forms.Button btnNextRight;
        private System.Windows.Forms.Button btnFirstRight;
        private System.Windows.Forms.Button btnPreviousLeft;
        private System.Windows.Forms.Button btnLastLeft;
        private System.Windows.Forms.Button btnNextLeft;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.ListBox lbTrace;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtRenewalDate;
        private System.Windows.Forms.Button btnCheckOutTransfer;
        private System.Windows.Forms.Button btnPayFineTransfer;
        private System.Windows.Forms.DataGridView dgCheckOut;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Button btnViewDetails3;
        private System.Windows.Forms.Button btnViewDetails2;
        private System.Windows.Forms.Button btnViewDetails1;
        private System.Windows.Forms.TextBox txtCheckOut3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnDelete1;
        private ToolStripMenuItem departmentsAddEditDeleteToolStripMenuItem;
        private ToolStripMenuItem userTypesAddEditDeleteToolStripMenuItem;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridViewTextBoxColumn SongName;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn TDate;
        private DataGridViewButtonColumn ViewDetails;
        private DataGridViewButtonColumn TDelete;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button4;
        private Button button5;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}

