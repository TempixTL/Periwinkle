using System.Windows.Forms;
using Microsoft.Win32;

namespace LibraryApp
{
    partial class User
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
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.txtCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtID1 = new System.Windows.Forms.Label();
            this.txtLast1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMI1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirst1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.TabPage();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.lblPerks = new System.Windows.Forms.Label();
            this.txtPerks = new System.Windows.Forms.TextBox();
            this.txtRenewalDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.Label();
            this.txtLast2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMI2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFirst2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
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
            this.btnPreviousRight = new System.Windows.Forms.Button();
            this.btnLastRight = new System.Windows.Forms.Button();
            this.btnNextRight = new System.Windows.Forms.Button();
            this.btnFirstRight = new System.Windows.Forms.Button();
            this.btnPreviousLeft = new System.Windows.Forms.Button();
            this.btnLastLeft = new System.Windows.Forms.Button();
            this.btnNextLeft = new System.Windows.Forms.Button();
            this.btnFirstLeft = new System.Windows.Forms.Button();
            this.btnCellPhone = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.Notes.SuspendLayout();
            this.Membership.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(79, 56);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(43, 19);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(128, 52);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(207, 26);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Leave += new System.EventHandler(this.TxtFirst_Leave);
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(467, 52);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(297, 26);
            this.txtLast.TabIndex = 2;
            this.txtLast.Leave += new System.EventHandler(this.TxtLast_Leave);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(419, 56);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(42, 19);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last";
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
            this.btnCheckOutTransfer.Location = new System.Drawing.Point(16, 300);
            this.btnCheckOutTransfer.Name = "btnCheckOutTransfer";
            this.btnCheckOutTransfer.Size = new System.Drawing.Size(370, 23);
            this.btnCheckOutTransfer.TabIndex = 42;
            this.btnCheckOutTransfer.Text = "View Playlists";
            this.toolTip1.SetToolTip(this.btnCheckOutTransfer, "Transfer to User\'s Playlists in Music Sub-System");
            this.btnCheckOutTransfer.UseVisualStyleBackColor = false;
            // 
            // btnPayFineTransfer
            // 
            this.btnPayFineTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPayFineTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnPayFineTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayFineTransfer.ForeColor = System.Drawing.Color.White;
            this.btnPayFineTransfer.Location = new System.Drawing.Point(398, 300);
            this.btnPayFineTransfer.Name = "btnPayFineTransfer";
            this.btnPayFineTransfer.Size = new System.Drawing.Size(370, 23);
            this.btnPayFineTransfer.TabIndex = 43;
            this.btnPayFineTransfer.Text = "Pay Membership";
            this.toolTip1.SetToolTip(this.btnPayFineTransfer, "Transfer to Payment Sub-System");
            this.btnPayFineTransfer.UseVisualStyleBackColor = false;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnUpgrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpgrade.ForeColor = System.Drawing.Color.White;
            this.btnUpgrade.Location = new System.Drawing.Point(208, 301);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(370, 23);
            this.btnUpgrade.TabIndex = 51;
            this.btnUpgrade.Text = "Upgrade Membership";
            this.toolTip1.SetToolTip(this.btnUpgrade, "Transfer to User\'s Playlists in Music Sub-System");
            this.btnUpgrade.UseVisualStyleBackColor = false;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(128, 115);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(35, 119);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 19);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(467, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(297, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(375, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 19);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(128, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(636, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cell Phone";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(131, 53);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(636, 275);
            this.txtNotes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Notes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonalInfo);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Controls.Add(this.Membership);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 370);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.PersonalInfo.Controls.Add(this.btnPayFineTransfer);
            this.PersonalInfo.Controls.Add(this.btnCheckOutTransfer);
            this.PersonalInfo.Controls.Add(this.txtCellPhone);
            this.PersonalInfo.Controls.Add(this.btnCellPhone);
            this.PersonalInfo.Controls.Add(this.txtID);
            this.PersonalInfo.Controls.Add(this.lblFirst);
            this.PersonalInfo.Controls.Add(this.txtFirst);
            this.PersonalInfo.Controls.Add(this.lblLast);
            this.PersonalInfo.Controls.Add(this.txtLast);
            this.PersonalInfo.Controls.Add(this.lblUsername);
            this.PersonalInfo.Controls.Add(this.txtUserName);
            this.PersonalInfo.Controls.Add(this.lblPassword);
            this.PersonalInfo.Controls.Add(this.txtPassword);
            this.PersonalInfo.Controls.Add(this.label3);
            this.PersonalInfo.Controls.Add(this.label1);
            this.PersonalInfo.Controls.Add(this.txtEmail);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(782, 341);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(128, 244);
            this.txtCellPhone.Mask = "(999) 000-0000";
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(166, 26);
            this.txtCellPhone.TabIndex = 40;
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
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.Notes.Controls.Add(this.label15);
            this.Notes.Controls.Add(this.txtID1);
            this.Notes.Controls.Add(this.txtLast1);
            this.Notes.Controls.Add(this.label13);
            this.Notes.Controls.Add(this.txtMI1);
            this.Notes.Controls.Add(this.label11);
            this.Notes.Controls.Add(this.txtFirst1);
            this.Notes.Controls.Add(this.label9);
            this.Notes.Controls.Add(this.txtNotes);
            this.Notes.Controls.Add(this.label8);
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(782, 341);
            this.Notes.TabIndex = 1;
            this.Notes.Text = "Notes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(364, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 14);
            this.label15.TabIndex = 50;
            this.label15.Text = "--- Place Your Notes Here ---";
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
            // txtLast1
            // 
            this.txtLast1.AutoSize = true;
            this.txtLast1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast1.Location = new System.Drawing.Point(467, 18);
            this.txtLast1.Name = "txtLast1";
            this.txtLast1.Size = new System.Drawing.Size(50, 18);
            this.txtLast1.TabIndex = 38;
            this.txtLast1.Text = "Hicks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(419, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Last";
            // 
            // txtMI1
            // 
            this.txtMI1.AutoSize = true;
            this.txtMI1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI1.Location = new System.Drawing.Point(373, 18);
            this.txtMI1.Name = "txtMI1";
            this.txtMI1.Size = new System.Drawing.Size(19, 18);
            this.txtMI1.TabIndex = 36;
            this.txtMI1.Text = "E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "MI";
            // 
            // txtFirst1
            // 
            this.txtFirst1.AutoSize = true;
            this.txtFirst1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst1.Location = new System.Drawing.Point(128, 18);
            this.txtFirst1.Name = "txtFirst1";
            this.txtFirst1.Size = new System.Drawing.Size(41, 18);
            this.txtFirst1.TabIndex = 34;
            this.txtFirst1.Text = "Tom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "First";
            // 
            // Membership
            // 
            this.Membership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.Membership.Controls.Add(this.txtPrice);
            this.Membership.Controls.Add(this.lblPrice);
            this.Membership.Controls.Add(this.txtMembership);
            this.Membership.Controls.Add(this.lblPerks);
            this.Membership.Controls.Add(this.txtPerks);
            this.Membership.Controls.Add(this.btnUpgrade);
            this.Membership.Controls.Add(this.txtRenewalDate);
            this.Membership.Controls.Add(this.label2);
            this.Membership.Controls.Add(this.label5);
            this.Membership.Controls.Add(this.txtID2);
            this.Membership.Controls.Add(this.txtLast2);
            this.Membership.Controls.Add(this.label18);
            this.Membership.Controls.Add(this.txtMI2);
            this.Membership.Controls.Add(this.label20);
            this.Membership.Controls.Add(this.txtFirst2);
            this.Membership.Controls.Add(this.label22);
            this.Membership.Location = new System.Drawing.Point(4, 25);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(782, 341);
            this.Membership.TabIndex = 2;
            this.Membership.Text = "Membership Settings";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(336, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(211, 26);
            this.txtPrice.TabIndex = 56;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(282, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 19);
            this.lblPrice.TabIndex = 55;
            this.lblPrice.Text = "Price";
            // 
            // txtMembership
            // 
            this.txtMembership.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtMembership.Location = new System.Drawing.Point(128, 55);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.ReadOnly = true;
            this.txtMembership.Size = new System.Drawing.Size(148, 26);
            this.txtMembership.TabIndex = 54;
            // 
            // lblPerks
            // 
            this.lblPerks.AutoSize = true;
            this.lblPerks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerks.Location = new System.Drawing.Point(19, 92);
            this.lblPerks.Name = "lblPerks";
            this.lblPerks.Size = new System.Drawing.Size(213, 19);
            this.lblPerks.TabIndex = 53;
            this.lblPerks.Text = "Current Membership Perks";
            // 
            // txtPerks
            // 
            this.txtPerks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerks.Location = new System.Drawing.Point(23, 119);
            this.txtPerks.Multiline = true;
            this.txtPerks.Name = "txtPerks";
            this.txtPerks.ReadOnly = true;
            this.txtPerks.Size = new System.Drawing.Size(731, 164);
            this.txtPerks.TabIndex = 52;
            // 
            // txtRenewalDate
            // 
            this.txtRenewalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenewalDate.Location = new System.Drawing.Point(630, 55);
            this.txtRenewalDate.Mask = "00/00/0000";
            this.txtRenewalDate.Name = "txtRenewalDate";
            this.txtRenewalDate.ReadOnly = true;
            this.txtRenewalDate.Size = new System.Drawing.Size(111, 26);
            this.txtRenewalDate.TabIndex = 50;
            this.txtRenewalDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Membership";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Renewal";
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
            // txtLast2
            // 
            this.txtLast2.AutoSize = true;
            this.txtLast2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast2.Location = new System.Drawing.Point(467, 18);
            this.txtLast2.Name = "txtLast2";
            this.txtLast2.Size = new System.Drawing.Size(50, 18);
            this.txtLast2.TabIndex = 45;
            this.txtLast2.Text = "Hicks";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(419, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 19);
            this.label18.TabIndex = 44;
            this.label18.Text = "Last";
            // 
            // txtMI2
            // 
            this.txtMI2.AutoSize = true;
            this.txtMI2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI2.Location = new System.Drawing.Point(373, 18);
            this.txtMI2.Name = "txtMI2";
            this.txtMI2.Size = new System.Drawing.Size(19, 18);
            this.txtMI2.TabIndex = 43;
            this.txtMI2.Text = "E";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(341, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 19);
            this.label20.TabIndex = 42;
            this.label20.Text = "MI";
            // 
            // txtFirst2
            // 
            this.txtFirst2.AutoSize = true;
            this.txtFirst2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst2.Location = new System.Drawing.Point(128, 18);
            this.txtFirst2.Name = "txtFirst2";
            this.txtFirst2.Size = new System.Drawing.Size(41, 18);
            this.txtFirst2.TabIndex = 41;
            this.txtFirst2.Text = "Tom";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(79, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 19);
            this.label22.TabIndex = 40;
            this.label22.Text = "First";
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
            this.thisUserToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.thisUserToolStripMenuItem.Text = "This User";
            // 
            // allUsersInViewToolStripMenuItem
            // 
            this.allUsersInViewToolStripMenuItem.Name = "allUsersInViewToolStripMenuItem";
            this.allUsersInViewToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.allUsersInViewToolStripMenuItem.Text = "All Users In View";
            // 
            // allUsersMatchingThisSearchToolStripMenuItem
            // 
            this.allUsersMatchingThisSearchToolStripMenuItem.Name = "allUsersMatchingThisSearchToolStripMenuItem";
            this.allUsersMatchingThisSearchToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
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
            this.dATAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
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
            "Name",
            "EMail",
            "ID",
            "Dept"});
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
            "All Users",
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
            // btnCellPhone
            // 
            this.btnCellPhone.BackgroundImage = global::LibraryApp.Properties.Resources.phone_48;
            this.btnCellPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCellPhone.FlatAppearance.BorderSize = 0;
            this.btnCellPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCellPhone.Location = new System.Drawing.Point(310, 244);
            this.btnCellPhone.Name = "btnCellPhone";
            this.btnCellPhone.Size = new System.Drawing.Size(26, 26);
            this.btnCellPhone.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnCellPhone, "Dialing Cell Phone");
            this.btnCellPhone.UseVisualStyleBackColor = false;
            this.btnCellPhone.Click += new System.EventHandler(this.btnCellPhone_Click);
            // 
            // User
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
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Sub-System | Written By Tom Lauerman";
            this.Load += new System.EventHandler(this.User_Load);
            this.VisibleChanged += new System.EventHandler(this.User_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.PersonalInfo.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.Membership.ResumeLayout(false);
            this.Membership.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonalInfo;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Membership;
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
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtFirst1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtID1;
        private System.Windows.Forms.Label txtLast1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtMI1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label txtID2;
        private System.Windows.Forms.Label txtLast2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtMI2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtFirst2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnCellPhone;
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
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtCellPhone;
        private System.Windows.Forms.Button btnCheckOutTransfer;
        private System.Windows.Forms.Button btnPayFineTransfer;
        private System.Windows.Forms.ImageList imageList1;
        private Label label15;
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
        private MaskedTextBox txtRenewalDate;
        private Label label2;
        private Label label5;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtMembership;
        private Label lblPerks;
        private TextBox txtPerks;
        private Button btnUpgrade;
    }
}

