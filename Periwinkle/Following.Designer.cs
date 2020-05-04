using System.Windows.Forms;
using Microsoft.Win32;

namespace LibraryApp
{
    partial class Following
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
            this.btnPreviousRight = new System.Windows.Forms.Button();
            this.btnLastRight = new System.Windows.Forms.Button();
            this.btnNextRight = new System.Windows.Forms.Button();
            this.btnFirstRight = new System.Windows.Forms.Button();
            this.btnPreviousLeft = new System.Windows.Forms.Button();
            this.btnLastLeft = new System.Windows.Forms.Button();
            this.btnNextLeft = new System.Windows.Forms.Button();
            this.btnFirstLeft = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byUniversityIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lbTrace = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Notes = new System.Windows.Forms.TabPage();
            this.txtPlaylistName2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Playlist = new System.Windows.Forms.TabPage();
            this.txtPlaylistOwner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlPlaylist1 = new System.Windows.Forms.Panel();
            this.txtArtist4 = new System.Windows.Forms.TextBox();
            this.txtArtist9 = new System.Windows.Forms.TextBox();
            this.txtArtist8 = new System.Windows.Forms.TextBox();
            this.txtArtist6 = new System.Windows.Forms.TextBox();
            this.txtArtist7 = new System.Windows.Forms.TextBox();
            this.txtArtist5 = new System.Windows.Forms.TextBox();
            this.txtArtist3 = new System.Windows.Forms.TextBox();
            this.txtArtist2 = new System.Windows.Forms.TextBox();
            this.txtArtist1 = new System.Windows.Forms.TextBox();
            this.dgAlbums = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtFocusedArtist = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Playlist.SuspendLayout();
            this.pnlPlaylist1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbums)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnA.Location = new System.Drawing.Point(154, 32);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(25, 25);
            this.btnA.TabIndex = 8;
            this.btnA.Text = "A";
            this.toolTip1.SetToolTip(this.btnA, "Navigate to the Next Logical Record Within the View");
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
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
            this.btnH.ForeColor = System.Drawing.Color.White;
            this.btnH.Location = new System.Drawing.Point(371, 32);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(25, 25);
            this.btnH.TabIndex = 12;
            this.btnH.Text = "H";
            this.toolTip1.SetToolTip(this.btnH, "Navigate to the Next Logical Record Within the View");
            this.btnH.UseVisualStyleBackColor = false;
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
            this.btnK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnK.Location = new System.Drawing.Point(464, 32);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(25, 25);
            this.btnK.TabIndex = 16;
            this.btnK.Text = "K";
            this.toolTip1.SetToolTip(this.btnK, "Navigate to the Next Logical Record Within the View");
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnL.FlatAppearance.BorderSize = 0;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.Location = new System.Drawing.Point(495, 32);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(25, 25);
            this.btnL.TabIndex = 17;
            this.btnL.Text = "L";
            this.toolTip1.SetToolTip(this.btnL, "Navigate to the Next Logical Record Within the View");
            this.btnL.UseVisualStyleBackColor = false;
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
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
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
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnP.Location = new System.Drawing.Point(619, 32);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(25, 25);
            this.btnP.TabIndex = 21;
            this.btnP.Text = "P";
            this.toolTip1.SetToolTip(this.btnP, "Navigate to the Next Logical Record Within the View");
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
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
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
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
            this.btnT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnT.Location = new System.Drawing.Point(340, 63);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(25, 25);
            this.btnT.TabIndex = 27;
            this.btnT.Text = "T";
            this.toolTip1.SetToolTip(this.btnT, "Navigate to the Next Logical Record Within the View");
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnS.Location = new System.Drawing.Point(309, 63);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(25, 25);
            this.btnS.TabIndex = 28;
            this.btnS.Text = "S";
            this.toolTip1.SetToolTip(this.btnS, "Navigate to the Next Logical Record Within the View");
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnY.FlatAppearance.BorderSize = 0;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnY.Location = new System.Drawing.Point(495, 63);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(25, 25);
            this.btnY.TabIndex = 29;
            this.btnY.Text = "Y";
            this.toolTip1.SetToolTip(this.btnY, "Navigate to the Next Logical Record Within the View");
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
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
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnB.Location = new System.Drawing.Point(185, 32);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(25, 25);
            this.btnB.TabIndex = 33;
            this.btnB.Text = "B";
            this.toolTip1.SetToolTip(this.btnB, "Navigate to the Next Logical Record Within the View");
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
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
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.Location = new System.Drawing.Point(606, 0);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(94, 23);
            this.btnDelete1.TabIndex = 6;
            this.btnDelete1.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.btnDelete1, "Delete this Transaction");
            this.btnDelete1.UseVisualStyleBackColor = false;
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete2.ForeColor = System.Drawing.Color.White;
            this.btnDelete2.Location = new System.Drawing.Point(606, 22);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(94, 23);
            this.btnDelete2.TabIndex = 7;
            this.btnDelete2.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.btnDelete2, "Delete this Transaction");
            this.btnDelete2.UseVisualStyleBackColor = false;
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete3.ForeColor = System.Drawing.Color.White;
            this.btnDelete3.Location = new System.Drawing.Point(606, 44);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(94, 23);
            this.btnDelete3.TabIndex = 8;
            this.btnDelete3.Text = "*Unfollow*";
            this.toolTip1.SetToolTip(this.btnDelete3, "Delete this Transaction");
            this.btnDelete3.UseVisualStyleBackColor = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(606, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button3, "Delete this Transaction");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(606, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button5, "Delete this Transaction");
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(606, 112);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button7, "Delete this Transaction");
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(606, 181);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 23);
            this.button11.TabIndex = 26;
            this.button11.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button11, "Delete this Transaction");
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(606, 158);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 23);
            this.button13.TabIndex = 20;
            this.button13.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button13, "Delete this Transaction");
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(606, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Unfollow";
            this.toolTip1.SetToolTip(this.button1, "Delete this Transaction");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(226)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.undeleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.dATAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.deleteToolStripMenuItem.Text = "Clear Following";
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save Changes Made to This User";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.ToolTipText = "Cancel Changes Made to This User";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byUniversityIDToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.searchToolStripMenuItem.Text = "Follow Artist";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click_1);
            // 
            // byUniversityIDToolStripMenuItem
            // 
            this.byUniversityIDToolStripMenuItem.Name = "byUniversityIDToolStripMenuItem";
            this.byUniversityIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byUniversityIDToolStripMenuItem.Text = "By Artist Name";
            this.byUniversityIDToolStripMenuItem.Click += new System.EventHandler(this.byUniversityIDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.toolStripMenuItem1.Text = "============";
            this.toolStripMenuItem1.ToolTipText = "This is not a button : - )";
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
            this.pnlNavigation.Controls.Add(this.cbSelect);
            this.pnlNavigation.Controls.Add(this.label10);
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
            this.pnlNavigation.Location = new System.Drawing.Point(0, 395);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(790, 160);
            this.pnlNavigation.TabIndex = 35;
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
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.Notes.Controls.Add(this.txtPlaylistName2);
            this.Notes.Controls.Add(this.label13);
            this.Notes.Controls.Add(this.label15);
            this.Notes.Controls.Add(this.txtNotes);
            this.Notes.Controls.Add(this.label8);
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(782, 341);
            this.Notes.TabIndex = 1;
            this.Notes.Text = "Notes";
            // 
            // txtPlaylistName2
            // 
            this.txtPlaylistName2.AutoSize = true;
            this.txtPlaylistName2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName2.Location = new System.Drawing.Point(384, 16);
            this.txtPlaylistName2.Name = "txtPlaylistName2";
            this.txtPlaylistName2.Size = new System.Drawing.Size(41, 18);
            this.txtPlaylistName2.TabIndex = 52;
            this.txtPlaylistName2.Text = "Tom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(340, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "User";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(312, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 14);
            this.label15.TabIndex = 50;
            this.label15.Text = "--- Place Your Notes Here ---";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(79, 53);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(636, 275);
            this.txtNotes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Notes";
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.Playlist.Controls.Add(this.button16);
            this.Playlist.Controls.Add(this.txtFocusedArtist);
            this.Playlist.Controls.Add(this.txtPlaylistOwner);
            this.Playlist.Controls.Add(this.label2);
            this.Playlist.Controls.Add(this.label16);
            this.Playlist.Controls.Add(this.pnlPlaylist1);
            this.Playlist.Controls.Add(this.dgAlbums);
            this.Playlist.Location = new System.Drawing.Point(4, 25);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(782, 341);
            this.Playlist.TabIndex = 2;
            this.Playlist.Text = "Playlist";
            this.Playlist.Click += new System.EventHandler(this.Songs_Click);
            // 
            // txtPlaylistOwner
            // 
            this.txtPlaylistOwner.AutoSize = true;
            this.txtPlaylistOwner.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistOwner.Location = new System.Drawing.Point(54, 9);
            this.txtPlaylistOwner.Name = "txtPlaylistOwner";
            this.txtPlaylistOwner.Size = new System.Drawing.Size(41, 18);
            this.txtPlaylistOwner.TabIndex = 58;
            this.txtPlaylistOwner.Text = "Tom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "User";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 14);
            this.label16.TabIndex = 56;
            this.label16.Text = "--- Artists ---";
            // 
            // pnlPlaylist1
            // 
            this.pnlPlaylist1.Controls.Add(this.button17);
            this.pnlPlaylist1.Controls.Add(this.button2);
            this.pnlPlaylist1.Controls.Add(this.button4);
            this.pnlPlaylist1.Controls.Add(this.button6);
            this.pnlPlaylist1.Controls.Add(this.button8);
            this.pnlPlaylist1.Controls.Add(this.button9);
            this.pnlPlaylist1.Controls.Add(this.button10);
            this.pnlPlaylist1.Controls.Add(this.button12);
            this.pnlPlaylist1.Controls.Add(this.button14);
            this.pnlPlaylist1.Controls.Add(this.button15);
            this.pnlPlaylist1.Controls.Add(this.txtArtist4);
            this.pnlPlaylist1.Controls.Add(this.button1);
            this.pnlPlaylist1.Controls.Add(this.txtArtist9);
            this.pnlPlaylist1.Controls.Add(this.button11);
            this.pnlPlaylist1.Controls.Add(this.txtArtist8);
            this.pnlPlaylist1.Controls.Add(this.button13);
            this.pnlPlaylist1.Controls.Add(this.txtArtist6);
            this.pnlPlaylist1.Controls.Add(this.txtArtist7);
            this.pnlPlaylist1.Controls.Add(this.button5);
            this.pnlPlaylist1.Controls.Add(this.button7);
            this.pnlPlaylist1.Controls.Add(this.txtArtist5);
            this.pnlPlaylist1.Controls.Add(this.button3);
            this.pnlPlaylist1.Controls.Add(this.btnDelete3);
            this.pnlPlaylist1.Controls.Add(this.btnDelete2);
            this.pnlPlaylist1.Controls.Add(this.btnDelete1);
            this.pnlPlaylist1.Controls.Add(this.txtArtist3);
            this.pnlPlaylist1.Controls.Add(this.txtArtist2);
            this.pnlPlaylist1.Controls.Add(this.txtArtist1);
            this.pnlPlaylist1.Location = new System.Drawing.Point(15, 127);
            this.pnlPlaylist1.Name = "pnlPlaylist1";
            this.pnlPlaylist1.Size = new System.Drawing.Size(753, 213);
            this.pnlPlaylist1.TabIndex = 48;
            // 
            // txtArtist4
            // 
            this.txtArtist4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist4.Location = new System.Drawing.Point(1, 66);
            this.txtArtist4.Name = "txtArtist4";
            this.txtArtist4.ReadOnly = true;
            this.txtArtist4.Size = new System.Drawing.Size(485, 23);
            this.txtArtist4.TabIndex = 28;
            this.txtArtist4.Text = "      4   Styx";
            // 
            // txtArtist9
            // 
            this.txtArtist9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist9.Location = new System.Drawing.Point(1, 181);
            this.txtArtist9.Name = "txtArtist9";
            this.txtArtist9.ReadOnly = true;
            this.txtArtist9.Size = new System.Drawing.Size(485, 23);
            this.txtArtist9.TabIndex = 25;
            this.txtArtist9.Text = "      9   Blue Oyster Cult";
            this.txtArtist9.Visible = false;
            // 
            // txtArtist8
            // 
            this.txtArtist8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist8.Location = new System.Drawing.Point(1, 158);
            this.txtArtist8.Name = "txtArtist8";
            this.txtArtist8.ReadOnly = true;
            this.txtArtist8.Size = new System.Drawing.Size(485, 23);
            this.txtArtist8.TabIndex = 19;
            this.txtArtist8.Text = "      8   Kokia";
            // 
            // txtArtist6
            // 
            this.txtArtist6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist6.Location = new System.Drawing.Point(1, 112);
            this.txtArtist6.Name = "txtArtist6";
            this.txtArtist6.ReadOnly = true;
            this.txtArtist6.Size = new System.Drawing.Size(485, 23);
            this.txtArtist6.TabIndex = 16;
            this.txtArtist6.Text = "      6   Pink Floyd";
            // 
            // txtArtist7
            // 
            this.txtArtist7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist7.Location = new System.Drawing.Point(1, 135);
            this.txtArtist7.Name = "txtArtist7";
            this.txtArtist7.ReadOnly = true;
            this.txtArtist7.Size = new System.Drawing.Size(485, 23);
            this.txtArtist7.TabIndex = 13;
            this.txtArtist7.Text = "      7   Tomohito Nishura";
            // 
            // txtArtist5
            // 
            this.txtArtist5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist5.Location = new System.Drawing.Point(1, 89);
            this.txtArtist5.Name = "txtArtist5";
            this.txtArtist5.ReadOnly = true;
            this.txtArtist5.Size = new System.Drawing.Size(485, 23);
            this.txtArtist5.TabIndex = 10;
            this.txtArtist5.Text = "      5   Bon Jovi";
            // 
            // txtArtist3
            // 
            this.txtArtist3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist3.Location = new System.Drawing.Point(1, 44);
            this.txtArtist3.Name = "txtArtist3";
            this.txtArtist3.ReadOnly = true;
            this.txtArtist3.Size = new System.Drawing.Size(485, 23);
            this.txtArtist3.TabIndex = 2;
            this.txtArtist3.Text = "      3   AC/DC";
            // 
            // txtArtist2
            // 
            this.txtArtist2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist2.Location = new System.Drawing.Point(1, 22);
            this.txtArtist2.Name = "txtArtist2";
            this.txtArtist2.ReadOnly = true;
            this.txtArtist2.Size = new System.Drawing.Size(485, 23);
            this.txtArtist2.TabIndex = 1;
            this.txtArtist2.Text = "      2   Ludwig van Beethoven";
            // 
            // txtArtist1
            // 
            this.txtArtist1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist1.Location = new System.Drawing.Point(1, 0);
            this.txtArtist1.Name = "txtArtist1";
            this.txtArtist1.ReadOnly = true;
            this.txtArtist1.Size = new System.Drawing.Size(485, 23);
            this.txtArtist1.TabIndex = 0;
            this.txtArtist1.Text = "      1   Yasunori Nishiki";
            // 
            // dgAlbums
            // 
            this.dgAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.TDate,
            this.AlbumTitle,
            this.ViewDetails});
            this.dgAlbums.Location = new System.Drawing.Point(15, 103);
            this.dgAlbums.Name = "dgAlbums";
            this.dgAlbums.Size = new System.Drawing.Size(753, 238);
            this.dgAlbums.TabIndex = 47;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Playlist);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 370);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // txtFocusedArtist
            // 
            this.txtFocusedArtist.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFocusedArtist.Location = new System.Drawing.Point(88, 40);
            this.txtFocusedArtist.Name = "txtFocusedArtist";
            this.txtFocusedArtist.ReadOnly = true;
            this.txtFocusedArtist.Size = new System.Drawing.Size(485, 23);
            this.txtFocusedArtist.TabIndex = 59;
            this.txtFocusedArtist.Text = "      1   Song Name                                  Artist";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(486, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "View Info";
            this.toolTip1.SetToolTip(this.button2, "Delete this Transaction");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(486, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "View Info";
            this.toolTip1.SetToolTip(this.button4, "Delete this Transaction");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(486, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "View Info";
            this.toolTip1.SetToolTip(this.button6, "Delete this Transaction");
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(486, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "View Info";
            this.toolTip1.SetToolTip(this.button8, "Delete this Transaction");
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(486, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "View Info";
            this.toolTip1.SetToolTip(this.button9, "Delete this Transaction");
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(486, 89);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 33;
            this.button10.Text = "View Info";
            this.toolTip1.SetToolTip(this.button10, "Delete this Transaction");
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(486, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 23);
            this.button12.TabIndex = 32;
            this.button12.Text = "*View Info*";
            this.toolTip1.SetToolTip(this.button12, "Delete this Transaction");
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(486, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 23);
            this.button14.TabIndex = 31;
            this.button14.Text = "View Info";
            this.toolTip1.SetToolTip(this.button14, "Delete this Transaction");
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(486, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 23);
            this.button15.TabIndex = 30;
            this.button15.Text = "View Info";
            this.toolTip1.SetToolTip(this.button15, "Delete this Transaction");
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(573, 40);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 23);
            this.button16.TabIndex = 60;
            this.button16.Text = "View Info";
            this.toolTip1.SetToolTip(this.button16, "Delete this Transaction");
            this.button16.UseVisualStyleBackColor = false;
            // 
            // AlbumID
            // 
            this.AlbumID.HeaderText = "#";
            this.AlbumID.Name = "AlbumID";
            this.AlbumID.Width = 25;
            // 
            // TDate
            // 
            this.TDate.HeaderText = "Artist Name";
            this.TDate.Name = "TDate";
            this.TDate.Width = 420;
            // 
            // AlbumTitle
            // 
            this.AlbumTitle.HeaderText = "";
            this.AlbumTitle.Name = "AlbumTitle";
            this.AlbumTitle.Width = 120;
            // 
            // ViewDetails
            // 
            this.ViewDetails.HeaderText = "";
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Width = 120;
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Artist Name",
            "# of Songs",
            "Rating",
            "Genre"});
            this.cbOrderBy.Location = new System.Drawing.Point(472, 119);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(170, 27);
            this.cbOrderBy.TabIndex = 41;
            this.cbOrderBy.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "Order By";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Genre",
            "Top 10"});
            this.cbSelect.Location = new System.Drawing.Point(210, 119);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(170, 27);
            this.cbSelect.TabIndex = 39;
            this.cbSelect.Text = "All Users";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "Select";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(700, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(26, 23);
            this.button17.TabIndex = 39;
            this.button17.Text = "*!*";
            this.toolTip1.SetToolTip(this.button17, "Delete this Transaction");
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Following
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(795, 589);
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
            this.Name = "Following";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserPlaylists Sub-System | Written By Tom Lauerman";
            this.Load += new System.EventHandler(this.User_Load);
            this.VisibleChanged += new System.EventHandler(this.User_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.Playlist.ResumeLayout(false);
            this.Playlist.PerformLayout();
            this.pnlPlaylist1.ResumeLayout(false);
            this.pnlPlaylist1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbums)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byUniversityIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATAToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
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
        private System.Windows.Forms.ImageList imageList1;
        private TabPage Notes;
        private Label label15;
        private TextBox txtNotes;
        private Label label8;
        private TabPage Playlist;
        private Label label16;
        private Panel pnlPlaylist1;
        private Button btnDelete3;
        private Button btnDelete2;
        private Button btnDelete1;
        private TextBox txtArtist3;
        private TextBox txtArtist2;
        private TextBox txtArtist1;
        private DataGridView dgAlbums;
        private TabControl tabControl1;
        private Label txtPlaylistName2;
        private Label label13;
        private TextBox txtArtist9;
        private Button button11;
        private TextBox txtArtist8;
        private Button button13;
        private TextBox txtArtist6;
        private TextBox txtArtist7;
        private Button button5;
        private Button button7;
        private TextBox txtArtist5;
        private Button button3;
        private Label txtPlaylistOwner;
        private Label label2;
        private TextBox txtArtist4;
        private Button button1;
        private TextBox txtFocusedArtist;
        private Button button2;
        private Button button4;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button16;
        private DataGridViewTextBoxColumn AlbumID;
        private DataGridViewTextBoxColumn TDate;
        private DataGridViewTextBoxColumn AlbumTitle;
        private DataGridViewButtonColumn ViewDetails;
        private ComboBox cbOrderBy;
        private Label label12;
        private ComboBox cbSelect;
        private Label label10;
        private Button button17;
    }
}

