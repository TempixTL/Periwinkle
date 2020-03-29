using System.Windows.Forms;
using Microsoft.Win32;

namespace LibraryApp
{
    partial class Artist
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
            this.btnViewDetails1 = new System.Windows.Forms.Button();
            this.btnViewDetails2 = new System.Windows.Forms.Button();
            this.btnViewDetails3 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byUniversityIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllInfoForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersInViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersMatchingThisSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printContactListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printUsersWhoOweFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printUsersWhoHaveBooksOverdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabelsForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersInViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersWhoOweMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersWhoHaveBooksOverdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsAddEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypesAddEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTrace = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Notes = new System.Windows.Forms.TabPage();
            this.txtID4 = new System.Windows.Forms.Label();
            this.txtArtistName4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupMembers = new System.Windows.Forms.TabPage();
            this.txtID3 = new System.Windows.Forms.Label();
            this.txtArtistName3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.pnlBands = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.dgBands = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Albums = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pnlSongs = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dgSongs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.pnlAlbums = new System.Windows.Forms.Panel();
            this.txtCheckOut3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgAlbums = new System.Windows.Forms.DataGridView();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID2 = new System.Windows.Forms.Label();
            this.txtArtistName2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateEstablished = new System.Windows.Forms.MaskedTextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.Notes.SuspendLayout();
            this.groupMembers.SuspendLayout();
            this.pnlMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.pnlBands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBands)).BeginInit();
            this.Albums.SuspendLayout();
            this.pnlSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSongs)).BeginInit();
            this.pnlAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbums)).BeginInit();
            this.PersonalInfo.SuspendLayout();
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
            this.btnR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
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
            this.btnV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
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
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(185, 32);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(25, 25);
            this.btnB.TabIndex = 33;
            this.btnB.Text = "B";
            this.toolTip1.SetToolTip(this.btnB, "Navigate to the Next Logical Record Within the View");
            this.btnB.UseVisualStyleBackColor = false;
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
            // btnViewDetails1
            // 
            this.btnViewDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnViewDetails1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails1.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails1.Location = new System.Drawing.Point(492, 0);
            this.btnViewDetails1.Name = "btnViewDetails1";
            this.btnViewDetails1.Size = new System.Drawing.Size(120, 23);
            this.btnViewDetails1.TabIndex = 3;
            this.btnViewDetails1.Text = "View Album";
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
            this.btnViewDetails2.Size = new System.Drawing.Size(120, 23);
            this.btnViewDetails2.TabIndex = 4;
            this.btnViewDetails2.Text = "View Album";
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
            this.btnViewDetails3.Size = new System.Drawing.Size(120, 23);
            this.btnViewDetails3.TabIndex = 5;
            this.btnViewDetails3.Text = "* View Album *";
            this.toolTip1.SetToolTip(this.btnViewDetails3, "View the Details of this Transaction");
            this.btnViewDetails3.UseVisualStyleBackColor = false;
            this.btnViewDetails3.Click += new System.EventHandler(this.btnViewDetails3_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete1.ForeColor = System.Drawing.Color.White;
            this.btnDelete1.Location = new System.Drawing.Point(611, 0);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(120, 23);
            this.btnDelete1.TabIndex = 6;
            this.btnDelete1.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete1, "Delete this Transaction");
            this.btnDelete1.UseVisualStyleBackColor = false;
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete2.ForeColor = System.Drawing.Color.White;
            this.btnDelete2.Location = new System.Drawing.Point(611, 22);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(120, 23);
            this.btnDelete2.TabIndex = 7;
            this.btnDelete2.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete2, "Delete this Transaction");
            this.btnDelete2.UseVisualStyleBackColor = false;
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete3.ForeColor = System.Drawing.Color.White;
            this.btnDelete3.Location = new System.Drawing.Point(611, 44);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(120, 23);
            this.btnDelete3.TabIndex = 8;
            this.btnDelete3.Text = "* Delete *";
            this.toolTip1.SetToolTip(this.btnDelete3, "Delete this Transaction");
            this.btnDelete3.UseVisualStyleBackColor = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(507, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Album";
            this.toolTip1.SetToolTip(this.button1, "View the Details of this Transaction");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(626, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.toolTip1.SetToolTip(this.button2, "Delete this Transaction");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(492, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 23);
            this.button18.TabIndex = 3;
            this.button18.Text = "Song Details";
            this.toolTip1.SetToolTip(this.button18, "View the Details of this Transaction");
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(492, 22);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 23);
            this.button17.TabIndex = 4;
            this.button17.Text = "Song Details";
            this.toolTip1.SetToolTip(this.button17, "View the Details of this Transaction");
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(492, 44);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 23);
            this.button16.TabIndex = 5;
            this.button16.Text = "* Song Details *";
            this.toolTip1.SetToolTip(this.button16, "View the Details of this Transaction");
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(611, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 23);
            this.button15.TabIndex = 6;
            this.button15.Text = "Delete";
            this.toolTip1.SetToolTip(this.button15, "Delete this Transaction");
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(611, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 23);
            this.button14.TabIndex = 7;
            this.button14.Text = "Delete";
            this.toolTip1.SetToolTip(this.button14, "Delete this Transaction");
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(611, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 23);
            this.button13.TabIndex = 8;
            this.button13.Text = "Delete";
            this.toolTip1.SetToolTip(this.button13, "Delete this Transaction");
            this.button13.UseVisualStyleBackColor = false;
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddle.Location = new System.Drawing.Point(345, 100);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(26, 19);
            this.lblMiddle.TabIndex = 12;
            this.lblMiddle.Text = "MI";
            this.toolTip1.SetToolTip(this.lblMiddle, "Enter Middle Initial");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(611, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "* Delete *";
            this.toolTip1.SetToolTip(this.button5, "Delete this Transaction");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(611, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Delete";
            this.toolTip1.SetToolTip(this.button6, "Delete this Transaction");
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(611, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Delete";
            this.toolTip1.SetToolTip(this.button7, "Delete this Transaction");
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(492, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Artist Details";
            this.toolTip1.SetToolTip(this.button8, "View the Details of this Transaction");
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(492, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Artist Details";
            this.toolTip1.SetToolTip(this.button9, "View the Details of this Transaction");
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(492, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Artist Details";
            this.toolTip1.SetToolTip(this.button10, "View the Details of this Transaction");
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(611, 22);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 23);
            this.button21.TabIndex = 8;
            this.button21.Text = "* Delete *";
            this.toolTip1.SetToolTip(this.button21, "Delete this Transaction");
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(611, 0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 23);
            this.button23.TabIndex = 6;
            this.button23.Text = "Delete";
            this.toolTip1.SetToolTip(this.button23, "Delete this Transaction");
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(492, 22);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 23);
            this.button25.TabIndex = 4;
            this.button25.Text = "*View Members*";
            this.toolTip1.SetToolTip(this.button25, "View the Details of this Transaction");
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(492, 0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(120, 23);
            this.button26.TabIndex = 3;
            this.button26.Text = "View Members";
            this.toolTip1.SetToolTip(this.button26, "View the Details of this Transaction");
            this.button26.UseVisualStyleBackColor = false;
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
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.administrativeToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.dATAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
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
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byIDToolStripMenuItem
            // 
            this.byIDToolStripMenuItem.Name = "byIDToolStripMenuItem";
            this.byIDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.byIDToolStripMenuItem.Text = "By ID";
            this.byIDToolStripMenuItem.Click += new System.EventHandler(this.byIDToolStripMenuItem_Click);
            // 
            // byUniversityIDToolStripMenuItem
            // 
            this.byUniversityIDToolStripMenuItem.Name = "byUniversityIDToolStripMenuItem";
            this.byUniversityIDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.byUniversityIDToolStripMenuItem.Text = "By University ID";
            this.byUniversityIDToolStripMenuItem.Click += new System.EventHandler(this.byUniversityIDToolStripMenuItem_Click);
            // 
            // byPhoneToolStripMenuItem
            // 
            this.byPhoneToolStripMenuItem.Name = "byPhoneToolStripMenuItem";
            this.byPhoneToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.byPhoneToolStripMenuItem.Text = "By Phone";
            this.byPhoneToolStripMenuItem.Click += new System.EventHandler(this.byPhoneToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAllInfoForToolStripMenuItem,
            this.printContactListToolStripMenuItem,
            this.printUsersWhoOweFinesToolStripMenuItem,
            this.printUsersWhoHaveBooksOverdueToolStripMenuItem,
            this.printLabelsForToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // printAllInfoForToolStripMenuItem
            // 
            this.printAllInfoForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisUserToolStripMenuItem,
            this.allUsersInViewToolStripMenuItem,
            this.allUsersMatchingThisSearchToolStripMenuItem});
            this.printAllInfoForToolStripMenuItem.Name = "printAllInfoForToolStripMenuItem";
            this.printAllInfoForToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.printAllInfoForToolStripMenuItem.Text = "Print All Info For";
            // 
            // thisUserToolStripMenuItem
            // 
            this.thisUserToolStripMenuItem.Name = "thisUserToolStripMenuItem";
            this.thisUserToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.thisUserToolStripMenuItem.Text = "This User";
            // 
            // allUsersInViewToolStripMenuItem
            // 
            this.allUsersInViewToolStripMenuItem.Name = "allUsersInViewToolStripMenuItem";
            this.allUsersInViewToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.allUsersInViewToolStripMenuItem.Text = "All Users In View";
            // 
            // allUsersMatchingThisSearchToolStripMenuItem
            // 
            this.allUsersMatchingThisSearchToolStripMenuItem.Name = "allUsersMatchingThisSearchToolStripMenuItem";
            this.allUsersMatchingThisSearchToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.allUsersMatchingThisSearchToolStripMenuItem.Text = "All Users Matching This Search";
            // 
            // printContactListToolStripMenuItem
            // 
            this.printContactListToolStripMenuItem.Name = "printContactListToolStripMenuItem";
            this.printContactListToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.printContactListToolStripMenuItem.Text = "Print Contact List";
            // 
            // printUsersWhoOweFinesToolStripMenuItem
            // 
            this.printUsersWhoOweFinesToolStripMenuItem.Name = "printUsersWhoOweFinesToolStripMenuItem";
            this.printUsersWhoOweFinesToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.printUsersWhoOweFinesToolStripMenuItem.Text = "Print Users Who Owe Fines";
            // 
            // printUsersWhoHaveBooksOverdueToolStripMenuItem
            // 
            this.printUsersWhoHaveBooksOverdueToolStripMenuItem.Name = "printUsersWhoHaveBooksOverdueToolStripMenuItem";
            this.printUsersWhoHaveBooksOverdueToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.printUsersWhoHaveBooksOverdueToolStripMenuItem.Text = "Print Users Who Have Books Overdue";
            // 
            // printLabelsForToolStripMenuItem
            // 
            this.printLabelsForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsersToolStripMenuItem,
            this.allUsersInViewToolStripMenuItem1,
            this.allUsersWhoOweMoneyToolStripMenuItem,
            this.allUsersWhoHaveBooksOverdueToolStripMenuItem});
            this.printLabelsForToolStripMenuItem.Name = "printLabelsForToolStripMenuItem";
            this.printLabelsForToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.printLabelsForToolStripMenuItem.Text = "Print Labels For";
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.allUsersToolStripMenuItem.Text = "All Users";
            // 
            // allUsersInViewToolStripMenuItem1
            // 
            this.allUsersInViewToolStripMenuItem1.Name = "allUsersInViewToolStripMenuItem1";
            this.allUsersInViewToolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.allUsersInViewToolStripMenuItem1.Text = "All Users In View";
            // 
            // allUsersWhoOweMoneyToolStripMenuItem
            // 
            this.allUsersWhoOweMoneyToolStripMenuItem.Name = "allUsersWhoOweMoneyToolStripMenuItem";
            this.allUsersWhoOweMoneyToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.allUsersWhoOweMoneyToolStripMenuItem.Text = "All Users Who Owe Money";
            // 
            // allUsersWhoHaveBooksOverdueToolStripMenuItem
            // 
            this.allUsersWhoHaveBooksOverdueToolStripMenuItem.Name = "allUsersWhoHaveBooksOverdueToolStripMenuItem";
            this.allUsersWhoHaveBooksOverdueToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.allUsersWhoHaveBooksOverdueToolStripMenuItem.Text = "All Users Who Have Books Overdue";
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
            this.departmentsAddEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.departmentsAddEditDeleteToolStripMenuItem.Text = "Departments --> Add, Edit, Delete";
            this.departmentsAddEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.departmentsAddEditDeleteToolStripMenuItem_Click);
            // 
            // userTypesAddEditDeleteToolStripMenuItem
            // 
            this.userTypesAddEditDeleteToolStripMenuItem.Name = "userTypesAddEditDeleteToolStripMenuItem";
            this.userTypesAddEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
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
            this.pnlNavigation.Location = new System.Drawing.Point(0, 394);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(790, 160);
            this.pnlNavigation.TabIndex = 35;
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "First",
            "Artist Name",
            "Genre",
            "Established Date"});
            this.cbOrderBy.Location = new System.Drawing.Point(474, 118);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(170, 27);
            this.cbOrderBy.TabIndex = 37;
            this.cbOrderBy.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "Order By";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "All Artist",
            "Administrators",
            "Non-Administrators",
            "Males",
            "Females"});
            this.cbSelect.Location = new System.Drawing.Point(212, 118);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(170, 27);
            this.cbSelect.TabIndex = 35;
            this.cbSelect.Text = "All Users";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Select";
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
            this.Notes.Controls.Add(this.txtID4);
            this.Notes.Controls.Add(this.txtArtistName4);
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
            // txtID4
            // 
            this.txtID4.AutoSize = true;
            this.txtID4.Font = new System.Drawing.Font("Arial", 10F);
            this.txtID4.Location = new System.Drawing.Point(707, 18);
            this.txtID4.Name = "txtID4";
            this.txtID4.Size = new System.Drawing.Size(57, 16);
            this.txtID4.TabIndex = 53;
            this.txtID4.Text = "ID 1234";
            // 
            // txtArtistName4
            // 
            this.txtArtistName4.AutoSize = true;
            this.txtArtistName4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName4.Location = new System.Drawing.Point(389, 18);
            this.txtArtistName4.Name = "txtArtistName4";
            this.txtArtistName4.Size = new System.Drawing.Size(41, 18);
            this.txtArtistName4.TabIndex = 52;
            this.txtArtistName4.Text = "Tom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(287, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "Artist Name";
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
            // groupMembers
            // 
            this.groupMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.groupMembers.Controls.Add(this.txtID3);
            this.groupMembers.Controls.Add(this.txtArtistName3);
            this.groupMembers.Controls.Add(this.label17);
            this.groupMembers.Controls.Add(this.pnlMembers);
            this.groupMembers.Controls.Add(this.dgMembers);
            this.groupMembers.Controls.Add(this.label3);
            this.groupMembers.Controls.Add(this.lblMembers);
            this.groupMembers.Controls.Add(this.pnlBands);
            this.groupMembers.Controls.Add(this.dgBands);
            this.groupMembers.Location = new System.Drawing.Point(4, 25);
            this.groupMembers.Name = "groupMembers";
            this.groupMembers.Size = new System.Drawing.Size(782, 341);
            this.groupMembers.TabIndex = 4;
            this.groupMembers.Text = "Group Members";
            // 
            // txtID3
            // 
            this.txtID3.AutoSize = true;
            this.txtID3.Font = new System.Drawing.Font("Arial", 10F);
            this.txtID3.Location = new System.Drawing.Point(707, 18);
            this.txtID3.Name = "txtID3";
            this.txtID3.Size = new System.Drawing.Size(57, 16);
            this.txtID3.TabIndex = 76;
            this.txtID3.Text = "ID 1234";
            // 
            // txtArtistName3
            // 
            this.txtArtistName3.AutoSize = true;
            this.txtArtistName3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName3.Location = new System.Drawing.Point(389, 18);
            this.txtArtistName3.Name = "txtArtistName3";
            this.txtArtistName3.Size = new System.Drawing.Size(41, 18);
            this.txtArtistName3.TabIndex = 75;
            this.txtArtistName3.Text = "Tom";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(287, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 19);
            this.label17.TabIndex = 74;
            this.label17.Text = "Artist Name";
            // 
            // pnlMembers
            // 
            this.pnlMembers.Controls.Add(this.button5);
            this.pnlMembers.Controls.Add(this.button6);
            this.pnlMembers.Controls.Add(this.button7);
            this.pnlMembers.Controls.Add(this.button8);
            this.pnlMembers.Controls.Add(this.button9);
            this.pnlMembers.Controls.Add(this.button10);
            this.pnlMembers.Controls.Add(this.textBox7);
            this.pnlMembers.Controls.Add(this.textBox8);
            this.pnlMembers.Controls.Add(this.textBox13);
            this.pnlMembers.Location = new System.Drawing.Point(15, 208);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Size = new System.Drawing.Size(753, 67);
            this.pnlMembers.TabIndex = 73;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(0, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(492, 23);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "                        10            04/01/1980        Brian Johnson";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(0, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(492, 23);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "                        25            ??/??/1975           Mark Evans";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(0, 0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(492, 23);
            this.textBox13.TabIndex = 0;
            this.textBox13.Text = "                        10            ??/??/1975            Phil Rudd";
            // 
            // dgMembers
            // 
            this.dgMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgMembers.Location = new System.Drawing.Point(15, 183);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.Size = new System.Drawing.Size(753, 92);
            this.dgMembers.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Artist ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Established Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Artist Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 120;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 68;
            this.label3.Text = "--- Member Of ---";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(337, 164);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(81, 14);
            this.lblMembers.TabIndex = 67;
            this.lblMembers.Text = "--- Members ---";
            // 
            // pnlBands
            // 
            this.pnlBands.Controls.Add(this.button21);
            this.pnlBands.Controls.Add(this.button23);
            this.pnlBands.Controls.Add(this.button25);
            this.pnlBands.Controls.Add(this.button26);
            this.pnlBands.Controls.Add(this.textBox15);
            this.pnlBands.Controls.Add(this.textBox16);
            this.pnlBands.Location = new System.Drawing.Point(15, 85);
            this.pnlBands.Name = "pnlBands";
            this.pnlBands.Size = new System.Drawing.Size(753, 45);
            this.pnlBands.TabIndex = 66;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(0, 22);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(492, 23);
            this.textBox15.TabIndex = 1;
            this.textBox15.Text = "                        10            01/01/1973                AC/DC";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(0, 0);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(492, 23);
            this.textBox16.TabIndex = 0;
            // 
            // dgBands
            // 
            this.dgBands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgBands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6});
            this.dgBands.Location = new System.Drawing.Point(15, 60);
            this.dgBands.Name = "dgBands";
            this.dgBands.Size = new System.Drawing.Size(753, 70);
            this.dgBands.TabIndex = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Artist ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Established Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Group Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Width = 120;
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.HeaderText = "";
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            this.dataGridViewButtonColumn6.Width = 120;
            // 
            // Albums
            // 
            this.Albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.Albums.Controls.Add(this.textBox4);
            this.Albums.Controls.Add(this.pnlSongs);
            this.Albums.Controls.Add(this.dgSongs);
            this.Albums.Controls.Add(this.label16);
            this.Albums.Controls.Add(this.button2);
            this.Albums.Controls.Add(this.button1);
            this.Albums.Controls.Add(this.lblSongs);
            this.Albums.Controls.Add(this.pnlAlbums);
            this.Albums.Controls.Add(this.dgAlbums);
            this.Albums.Controls.Add(this.txtID2);
            this.Albums.Controls.Add(this.txtArtistName2);
            this.Albums.Controls.Add(this.label22);
            this.Albums.Location = new System.Drawing.Point(4, 25);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(782, 341);
            this.Albums.TabIndex = 2;
            this.Albums.Text = "Albums";
            this.Albums.Click += new System.EventHandler(this.Songs_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(492, 23);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "                         9           02/28/2000       Stiff Upper Lip";
            // 
            // pnlSongs
            // 
            this.pnlSongs.Controls.Add(this.button13);
            this.pnlSongs.Controls.Add(this.button14);
            this.pnlSongs.Controls.Add(this.button15);
            this.pnlSongs.Controls.Add(this.button16);
            this.pnlSongs.Controls.Add(this.button17);
            this.pnlSongs.Controls.Add(this.button18);
            this.pnlSongs.Controls.Add(this.textBox10);
            this.pnlSongs.Controls.Add(this.textBox11);
            this.pnlSongs.Controls.Add(this.textBox12);
            this.pnlSongs.Location = new System.Drawing.Point(15, 228);
            this.pnlSongs.Name = "pnlSongs";
            this.pnlSongs.Size = new System.Drawing.Size(753, 67);
            this.pnlSongs.TabIndex = 61;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(0, 44);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(492, 23);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "                        12            07/25/1980        Back in Black";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(0, 22);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(492, 23);
            this.textBox11.TabIndex = 1;
            this.textBox11.Text = "                        12            07/25/1980      Shoot to Thrill";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(0, 0);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(492, 23);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "                        10            07/25/1980         Hell\'s Bells";
            // 
            // dgSongs
            // 
            this.dgSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgSongs.Location = new System.Drawing.Point(15, 203);
            this.dgSongs.Name = "dgSongs";
            this.dgSongs.Size = new System.Drawing.Size(753, 92);
            this.dgSongs.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Song ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Released";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Song Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Width = 120;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Width = 120;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(333, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 14);
            this.label16.TabIndex = 56;
            this.label16.Text = "--- Albums ---";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.Location = new System.Drawing.Point(337, 184);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(68, 14);
            this.lblSongs.TabIndex = 49;
            this.lblSongs.Text = "--- Songs ---";
            // 
            // pnlAlbums
            // 
            this.pnlAlbums.Controls.Add(this.btnDelete3);
            this.pnlAlbums.Controls.Add(this.btnDelete2);
            this.pnlAlbums.Controls.Add(this.btnDelete1);
            this.pnlAlbums.Controls.Add(this.btnViewDetails3);
            this.pnlAlbums.Controls.Add(this.btnViewDetails2);
            this.pnlAlbums.Controls.Add(this.btnViewDetails1);
            this.pnlAlbums.Controls.Add(this.txtCheckOut3);
            this.pnlAlbums.Controls.Add(this.textBox2);
            this.pnlAlbums.Controls.Add(this.textBox1);
            this.pnlAlbums.Location = new System.Drawing.Point(15, 85);
            this.pnlAlbums.Name = "pnlAlbums";
            this.pnlAlbums.Size = new System.Drawing.Size(753, 89);
            this.pnlAlbums.TabIndex = 48;
            // 
            // txtCheckOut3
            // 
            this.txtCheckOut3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut3.Location = new System.Drawing.Point(0, 44);
            this.txtCheckOut3.Name = "txtCheckOut3";
            this.txtCheckOut3.Size = new System.Drawing.Size(492, 23);
            this.txtCheckOut3.TabIndex = 2;
            this.txtCheckOut3.Text = "                         5           07/25/1980         Back In Black";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(492, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "                         6           07/27/1979       Highway to Hell";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "                         2           04/30/1976          High Voltage";
            // 
            // dgAlbums
            // 
            this.dgAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.dgAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.TDate,
            this.AlbumTitle,
            this.ViewDetails,
            this.TDelete});
            this.dgAlbums.Location = new System.Drawing.Point(15, 60);
            this.dgAlbums.Name = "dgAlbums";
            this.dgAlbums.Size = new System.Drawing.Size(753, 114);
            this.dgAlbums.TabIndex = 47;
            // 
            // AlbumID
            // 
            this.AlbumID.HeaderText = "Album ID";
            this.AlbumID.Name = "AlbumID";
            this.AlbumID.Width = 150;
            // 
            // TDate
            // 
            this.TDate.HeaderText = "Date Released";
            this.TDate.Name = "TDate";
            this.TDate.Width = 150;
            // 
            // AlbumTitle
            // 
            this.AlbumTitle.HeaderText = "Album Title";
            this.AlbumTitle.Name = "AlbumTitle";
            this.AlbumTitle.Width = 150;
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
            // txtID2
            // 
            this.txtID2.AutoSize = true;
            this.txtID2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtID2.Location = new System.Drawing.Point(707, 18);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(57, 16);
            this.txtID2.TabIndex = 46;
            this.txtID2.Text = "ID 1234";
            // 
            // txtArtistName2
            // 
            this.txtArtistName2.AutoSize = true;
            this.txtArtistName2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName2.Location = new System.Drawing.Point(389, 18);
            this.txtArtistName2.Name = "txtArtistName2";
            this.txtArtistName2.Size = new System.Drawing.Size(41, 18);
            this.txtArtistName2.TabIndex = 41;
            this.txtArtistName2.Text = "Tom";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(287, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 19);
            this.label22.TabIndex = 40;
            this.label22.Text = "Artist Name";
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.PersonalInfo.Controls.Add(this.txtProfile);
            this.PersonalInfo.Controls.Add(this.txtFirst);
            this.PersonalInfo.Controls.Add(this.txtLast);
            this.PersonalInfo.Controls.Add(this.txtMI);
            this.PersonalInfo.Controls.Add(this.txtArtistName);
            this.PersonalInfo.Controls.Add(this.label1);
            this.PersonalInfo.Controls.Add(this.txtDateEstablished);
            this.PersonalInfo.Controls.Add(this.cbGenre);
            this.PersonalInfo.Controls.Add(this.txtID);
            this.PersonalInfo.Controls.Add(this.lblFirst);
            this.PersonalInfo.Controls.Add(this.lblLast);
            this.PersonalInfo.Controls.Add(this.lblMiddle);
            this.PersonalInfo.Controls.Add(this.lblUsername);
            this.PersonalInfo.Controls.Add(this.label2);
            this.PersonalInfo.Controls.Add(this.label5);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(782, 341);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            // 
            // txtProfile
            // 
            this.txtProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfile.Location = new System.Drawing.Point(128, 188);
            this.txtProfile.Multiline = true;
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(636, 113);
            this.txtProfile.TabIndex = 44;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(128, 96);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(207, 26);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Leave += new System.EventHandler(this.TxtFirst_Leave);
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(467, 96);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(297, 26);
            this.txtLast.TabIndex = 2;
            this.txtLast.Leave += new System.EventHandler(this.TxtLast_Leave);
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.Location = new System.Drawing.Point(373, 96);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(40, 26);
            this.txtMI.TabIndex = 1;
            this.txtMI.Leave += new System.EventHandler(this.TxtMI_Leave);
            // 
            // txtArtistName
            // 
            this.txtArtistName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtistName.Location = new System.Drawing.Point(128, 50);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(636, 26);
            this.txtArtistName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Profile";
            // 
            // txtDateEstablished
            // 
            this.txtDateEstablished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEstablished.Location = new System.Drawing.Point(128, 142);
            this.txtDateEstablished.Mask = "00/00/0000";
            this.txtDateEstablished.Name = "txtDateEstablished";
            this.txtDateEstablished.Size = new System.Drawing.Size(207, 26);
            this.txtDateEstablished.TabIndex = 41;
            this.txtDateEstablished.ValidatingType = typeof(System.DateTime);
            // 
            // cbGenre
            // 
            this.cbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(467, 142);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(208, 27);
            this.cbGenre.TabIndex = 35;
            this.cbGenre.Enter += new System.EventHandler(this.CbDeptID_Enter);
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
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(83, 100);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(43, 19);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(423, 100);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(42, 19);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(29, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 19);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Artist Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Est Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonalInfo);
            this.tabControl1.Controls.Add(this.Albums);
            this.tabControl1.Controls.Add(this.groupMembers);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 370);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Artist
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
            this.Name = "Artist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Sub-System | Written By Tom Lauerman";
            this.Load += new System.EventHandler(this.User_Load);
            this.VisibleChanged += new System.EventHandler(this.User_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.groupMembers.ResumeLayout(false);
            this.groupMembers.PerformLayout();
            this.pnlMembers.ResumeLayout(false);
            this.pnlMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.pnlBands.ResumeLayout(false);
            this.pnlBands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBands)).EndInit();
            this.Albums.ResumeLayout(false);
            this.Albums.PerformLayout();
            this.pnlSongs.ResumeLayout(false);
            this.pnlSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSongs)).EndInit();
            this.pnlAlbums.ResumeLayout(false);
            this.pnlAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbums)).EndInit();
            this.PersonalInfo.ResumeLayout(false);
            this.PersonalInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byUniversityIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
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
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ImageList imageList1;
        private ToolStripMenuItem departmentsAddEditDeleteToolStripMenuItem;
        private ToolStripMenuItem userTypesAddEditDeleteToolStripMenuItem;
        private ToolStripMenuItem printAllInfoForToolStripMenuItem;
        private ToolStripMenuItem thisUserToolStripMenuItem;
        private ToolStripMenuItem allUsersInViewToolStripMenuItem;
        private ToolStripMenuItem allUsersMatchingThisSearchToolStripMenuItem;
        private ToolStripMenuItem printContactListToolStripMenuItem;
        private ToolStripMenuItem printUsersWhoOweFinesToolStripMenuItem;
        private ToolStripMenuItem printUsersWhoHaveBooksOverdueToolStripMenuItem;
        private ToolStripMenuItem printLabelsForToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem allUsersInViewToolStripMenuItem1;
        private ToolStripMenuItem allUsersWhoOweMoneyToolStripMenuItem;
        private ToolStripMenuItem allUsersWhoHaveBooksOverdueToolStripMenuItem;
        private TabPage Notes;
        private Label label15;
        private TextBox txtNotes;
        private Label label8;
        private TabPage groupMembers;
        private Panel pnlMembers;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox13;
        private DataGridView dgMembers;
        private Label label3;
        private Label lblMembers;
        private Panel pnlBands;
        private Button button21;
        private Button button23;
        private Button button25;
        private Button button26;
        private TextBox textBox15;
        private TextBox textBox16;
        private DataGridView dgBands;
        private TabPage Albums;
        private TextBox textBox4;
        private Panel pnlSongs;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private DataGridView dgSongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private Label label16;
        private Button button2;
        private Button button1;
        private Label lblSongs;
        private Panel pnlAlbums;
        private Button btnDelete3;
        private Button btnDelete2;
        private Button btnDelete1;
        private Button btnViewDetails3;
        private Button btnViewDetails2;
        private Button btnViewDetails1;
        private TextBox txtCheckOut3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dgAlbums;
        private DataGridViewTextBoxColumn AlbumID;
        private DataGridViewTextBoxColumn TDate;
        private DataGridViewTextBoxColumn AlbumTitle;
        private DataGridViewButtonColumn ViewDetails;
        private DataGridViewButtonColumn TDelete;
        private Label txtID2;
        private Label txtArtistName2;
        private Label label22;
        private TabPage PersonalInfo;
        private TextBox txtProfile;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtMI;
        private TextBox txtArtistName;
        private Label label1;
        private MaskedTextBox txtDateEstablished;
        private ComboBox cbGenre;
        private Label txtID;
        private Label lblFirst;
        private Label lblLast;
        private Label lblMiddle;
        private Label lblUsername;
        private Label label2;
        private Label label5;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn6;
        private Label txtID4;
        private Label txtArtistName4;
        private Label label13;
        private Label txtID3;
        private Label txtArtistName3;
        private Label label17;
    }
}

