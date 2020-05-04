using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UserPlaylists : Form
    {
        private Main pf;

        private bool Testing = false;
        private String Database = "Trinity";
        private long Port = 12345;
        private bool DataToggle = true;
        private String QuickLinkText = "Full Name";
        public int ViewFirstRecord = 0;

        public SupportingClassAddEdit AddPlaylist;
        public Search SendToUser;

        private List<Control> editFields = new List<Control>();

        // Tom Lauerman Initialization Utilities
        #region User -- User_Load -- MyRenderer

        public UserPlaylists()
        {
            InitializeComponent();
        }

        public UserPlaylists(Main parent)
        {
            InitializeComponent();
            pf = parent;
        }

        private void User_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
            PopulateDeptIDComboBox();
            ProcessDataToggle();
            ReloadQuickLinkToolTips();
            ViewMode();

            //editFields.Add(txtFirst);
            //editFields.Add(txtMI);
            //editFields.Add(txtLast);
            //editFields.Add(txtArtistName);
            //editFields.Add(txtPassword);
            //editFields.Add(txtEmail);
            //editFields.Add(txtHomePhone);
            //editFields.Add(txtCellPhone);
            //editFields.Add(txtDateEstablished);
            //editFields.Add(cbGenre);
            //editFields.Add(txtNotes);
            //editFields.Add(txtProfile);
        }

        public void LaunchSupportingClassWindow(String NewDescription,
            String Option, String NewValue)
        {
            AddPlaylist = new SupportingClassAddEdit(pf, NewDescription,
            Option, NewValue);
            AddPlaylist.MdiParent = pf;
            AddPlaylist.Show();
            //AddPlaylist.Text = NewText;
        }

        public void LaunchSearchWindow(String NewText, String Prompt, String btnText, String filler)
        {
            SendToUser = new Search(pf, NewText, Prompt, btnText, filler);
            SendToUser.MdiParent = pf;
            SendToUser.Show();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.FromArgb(242, 208, 242) : Color.FromArgb(242, 159, 226);
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        #endregion Tom Lauerman Initialization Utilities
        
        // Tom Lauerman Functions for lbTrace
        #region lbTraceLine -- lbTraceNote

        //--------------------------------------------------------------------------------//
        //================================================================================//
        // lbTraceLine //
        //================================================================================//
        // Purpose: Helper function for lbTraceNote. //
        //================================================================================//
        public void lbTraceLine(String Note, String ch = "=")
        {
            int len = Note.Length;
            if (len <= 0)
                return;
            String newStr = ch + ch;
            int Padding = Convert.ToInt16(18 - 0.5 * Note.Length);
            for (int pos = 1; pos <= Padding; pos++)
                newStr = newStr + " ";
            newStr = newStr + Note;
            while (newStr.Length < 38)
                newStr = newStr + " ";
            newStr = newStr + ch + ch;
            lbTrace.Items.Add(newStr);
        }

        //================================================================================//
        // lbTraceNote //
        //================================================================================//
        // Purpose: Routine for producing boxed output in lbTrace. //
        //================================================================================//
        public void lbTraceNote(String ch, String Note1, String Note2 = "", String Note3 = "",
            String Note4 = "", String Note5 = "")
        {
            if (ch == "=")
                lbTrace.Items.Add("========================================");
            else
            {
                lbTrace.Items.Add(" ");
                lbTrace.Items.Add("----------------------------------------");
            }
            lbTraceLine(Note1, ch);
            lbTraceLine(Note2, ch);
            lbTraceLine(Note3, ch);
            lbTraceLine(Note4, ch);
            lbTraceLine(Note5, ch);
            if (ch == "=")
                lbTrace.Items.Add("========================================");
            else
                lbTrace.Items.Add("----------------------------------------");
        }

        #endregion End Tom Lauerman lbTrace Functions

        // Tom Lauerman Form Processing
        #region FillFormVariables -- FillFormBlank -- ProcessDataToggle

        // FillFormVariables
        //
        // Purpose: Fill all of the data entry fields with a realistic sample data record.
        //
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void FillFormVariables()
        {
            if (ViewFirstRecord == 0)
            {
                pnlPlaylist1.Show();
                pnlPlaylist2.Hide();
                pnlPlaylist3.Hide();
                txtPlaylistName.Text = "Classical and Rock n' Roll";
                txtPlaylistName2.Text = "Classical and Rock n' Roll";
                txtID.Text = "ID:1";
                txtID2.Text = txtID.Text;
                txtPlaylistOwner.Text = "Tom";
                txtMinutes.Text = "000,000,000,376";
                txtNotes.Text = "Playlist of rock music";
                txtVisibility.Text = "Private";
                if (cbVisibility.Text.Length != 0){
                    txtVisibility.Text = cbVisibility.Text;
                }
            }
            else if (ViewFirstRecord == 2)
            {
                pnlPlaylist1.Hide();
                pnlPlaylist2.Show();
                pnlPlaylist3.Hide();
                txtPlaylistName.Text = "Rap";
                txtPlaylistName2.Text = "Rap";
                txtID.Text = "ID:2";
                txtID2.Text = txtID.Text;
                txtPlaylistOwner.Text = "Tom";
                txtMinutes.Text = "000,000,000,056";
                txtNotes.Text = "Playlist of rap songs";
                txtVisibility.Text = "Public";

            }
            else
            {
                pnlPlaylist1.Hide();
                pnlPlaylist2.Hide();
                pnlPlaylist3.Show();
                txtPlaylistName.Text = "My Music";
                txtPlaylistName2.Text = "My Music";
                txtID.Text = "ID:3";
                txtID2.Text = txtID.Text;
                txtPlaylistOwner.Text = "Joseph";
                txtMinutes.Text = "000,000,000,013";
                txtNotes.Text = "Playlist of songs I like";
                txtVisibility.Text = "Public";

            }

            SynchronizeCommonFields();
        }

        // FillFormBlank
        //
        // Purpose: Fill all of the data entry fields with a realistic blank (new user type) data record.
        //
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void FillFormBlank()
        {
            pnlPlaylist1.Hide();
            pnlPlaylist2.Hide();
            pnlPlaylist3.Hide();
            txtPlaylistName.Text = "";
            txtPlaylistName2.Text = "";
            txtPlaylistOwner.Text = "";
            cbVisibility.Text = "--- Select Visibility ---";
            txtNotes.Text = "";
            txtID.Text = "ID:";
            txtVisibility.Text = "";
            txtMinutes.Text = "000,000,000,000";
            

            SynchronizeCommonFields();
        }

        // SynchronizeCommonFields
        //
        // Purpose: Sync the common text fields throughout the form to ensure consistent information.
        //
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void SynchronizeCommonFields()
        {
            /*txtArtistName2.Text = txtArtistName.Text;
            txtArtistName3.Text = txtArtistName.Text;
            txtArtistName4.Text = txtArtistName.Text;

            txtID2.Text = txtID.Text;
            txtID2.Text = txtID.Text;
            txtID3.Text = txtID.Text;
            txtID4.Text = txtID.Text;*/
        }

        // ProcessDataToggle
        //
        // Purpose: When the DataToggle = true, set it to false and run FillFormVariables.
        // When the DataToggle =  true, set it to true and run FillFormBlank.
        //
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void ProcessDataToggle()
        {
            if (DataToggle == true)
            {
                FillFormVariables();
                DataToggle = false;
            }
            else
            {
                FillFormBlank();
                DataToggle = true;
            }
        }

        #endregion Tom Lauerman Form Processing

        // Tom Lauerman Record Set Navigation Collection
        #region ReloadQuickLinkToolTips -- LoadFirstLetterRecord

        // ReloadQuickLinkToolTips
        //
        // Purpose: Programatically assign tool tips to the quick-link keys.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        public void ReloadQuickLinkToolTips()
        {
            toolTip1.SetToolTip(btnA, "Load The First Record Whose " + QuickLinkText + " Begins With An 'A'");
            toolTip1.SetToolTip(btnB, "Load The First Record Whose " + QuickLinkText + " Begins With A 'B'");
            toolTip1.SetToolTip(btnC, "Load The First Record Whose " + QuickLinkText + " Begins With A 'C'");
            toolTip1.SetToolTip(btnD, "Load The First Record Whose " + QuickLinkText + " Begins With A 'D'");
            toolTip1.SetToolTip(btnE, "Load The First Record Whose " + QuickLinkText + " Begins With An 'E'");
            toolTip1.SetToolTip(btnF, "Load The First Record Whose " + QuickLinkText + " Begins With An 'F'");
            toolTip1.SetToolTip(btnG, "Load The First Record Whose " + QuickLinkText + " Begins With A 'G'");
            toolTip1.SetToolTip(btnH, "Load The First Record Whose " + QuickLinkText + " Begins With An 'H'");
            toolTip1.SetToolTip(btnI, "Load The First Record Whose " + QuickLinkText + " Begins With An 'I'");
            toolTip1.SetToolTip(btnJ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'J");
            toolTip1.SetToolTip(btnK, "Load The First Record Whose " + QuickLinkText + " Begins With A 'K'");
            toolTip1.SetToolTip(btnL, "Load The First Record Whose " + QuickLinkText + " Begins With An 'L'");
            toolTip1.SetToolTip(btnM, "Load The First Record Whose " + QuickLinkText + " Begins With An 'M'");
            toolTip1.SetToolTip(btnN, "Load The First Record Whose " + QuickLinkText + " Begins With An 'N'");
            toolTip1.SetToolTip(btnO, "Load The First Record Whose " + QuickLinkText + " Begins With An 'O'");
            toolTip1.SetToolTip(btnP, "Load The First Record Whose " + QuickLinkText + " Begins With A 'P'");
            toolTip1.SetToolTip(btnQ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Q'");
            toolTip1.SetToolTip(btnR, "Load The First Record Whose " + QuickLinkText + " Begins With An 'R'");
            toolTip1.SetToolTip(btnS, "Load The First Record Whose " + QuickLinkText + " Begins With An 'S'");
            toolTip1.SetToolTip(btnT, "Load The First Record Whose " + QuickLinkText + " Begins With A 'T'");
            toolTip1.SetToolTip(btnU, "Load The First Record Whose " + QuickLinkText + " Begins With A 'U'");
            toolTip1.SetToolTip(btnV, "Load The First Record Whose " + QuickLinkText + " Begins With A 'V'");
            toolTip1.SetToolTip(btnW, "Load The First Record Whose " + QuickLinkText + " Begins With A 'W'");
            toolTip1.SetToolTip(btnX, "Load The First Record Whose " + QuickLinkText + " Begins With An 'X'");
            toolTip1.SetToolTip(btnY, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Y'");
            toolTip1.SetToolTip(btnZ, "Load The First Record Whose " + QuickLinkText + " Begins With A 'Z'");
        }

        // LoadLastRecord
        //
        // Purpose: Load the last logical record into the datatable.
        // Limitation: Problem when all records are deleted or no records in view.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void LoadLastRecord()
        {
            ViewFirstRecord = 2;
            FillFormVariables();
        }

        // LoadFirstRecord
        //
        // Purpose: Load the first logical record into the datatable.
        // Limitation: Problem when all records are deleted or no records in view.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        //===========================================================================//
        private void LoadFirstRecord()
        {
            ViewFirstRecord = 0;
            FillFormVariables();
        }

        // LoadNextRecord
        //
        // Purpose: Load the next logical record into the datatable. Cycle from the last record to the first.
        // Limitation: Problem when all records are deleted or no records in view.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void LoadNextRecord()
        {
            ViewFirstRecord = (ViewFirstRecord+1)%3;
            FillFormVariables();
        }

        // LoadPreviousRecord
        //
        // Purpose: Load the previous logical record into the datatable. Cycle from the first record to the last. ==//
        // Limitation: Problem when all records are deleted or no records in view.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void LoadPreviousRecord()
        {
            if (ViewFirstRecord == 0) ViewFirstRecord = 2;
            else ViewFirstRecord--;
            FillFormVariables();
        }


        // LoadFirstLetterRecord
        //
        // Purpose:
        //   Load the first logical record, in the current view, whose  FullName begins with the Letter into the datatable.
        //
        //   In the event that there is no name with this letter, you
        //   can choose to (1) bring up a dialog box and tell the user
        //   or go to the first record past that letter ==> i.e. if
        //   there is no FullName starting with an 'X' --> maybe
        //   try 'Y'?
        //
        //   Use MySqlDataAdapter da & DataTable dt to house the  data.
        // Limitation: Problem when all records are deleted or no records in view.
        // Written By: Tom Lauerman
        // Date: 1/26/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        private void LoadFirstLetterRecord(char Letter)
        {
            if (Letter == 'R')
            {
                ViewFirstRecord = 0;
            }
            else if (Letter == 'C')
            {
                ViewFirstRecord = 1;
            }
            else if (Letter == 'M')
            {
                ViewFirstRecord = 2;
            }

            FillFormVariables();
        }

        #endregion Tom Lauerman Record Set Navigation Collection

        // Tom Lauerman Diagnostic Testing
        #region TestingMaster -- TestModule1, TestModule2, ...
        
        // TestingMaster
        //
        // Purpose: Testing Master which evokes TestModule1, TestModule2, ...
        // Written By: Tom Lauerman
        // Date: 1/29/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        public void TestingMaster()
        {
            int UserClassDiagnosticLevel = 5;
            if ((UserClassDiagnosticLevel <= 1) || (UserClassDiagnosticLevel == -1))
                TestModule1();
            if ((UserClassDiagnosticLevel <= 2) || (UserClassDiagnosticLevel == -1))
             TestModule2();
            if ((UserClassDiagnosticLevel <= 3) || (UserClassDiagnosticLevel == -1))
             TestModule3();
            if ((UserClassDiagnosticLevel <= 4) || (UserClassDiagnosticLevel == -1))
             TestModule4();
            if ((UserClassDiagnosticLevel <= 5) || (UserClassDiagnosticLevel == -1))
             TestModule5();
        }

        //===========================================================================//
        //== Test Module 1 - Testing llbTrace Functions ==//
        //===========================================================================//
        //== Purpose: Use the lbTrace Functions to display the contents of all of ==//
        //== the local variables in Users.cs ==//
        //===========================================================================//
        public void TestModule1()
        {
            lbTraceNote("-", "Test Module 1", "Testing lbTrace Functions", "Display User Variables");
            lbTrace.Items.Add("Testing ....... = " + Testing.ToString());
            lbTrace.Items.Add("Database ...... = " + Database);
            lbTrace.Items.Add("Port........... = " + Port.ToString());
            lbTrace.Items.Add("DataToggle .... = " + DataToggle.ToString());
            lbTrace.Items.Add("QuickLinkText.. = " + QuickLinkText);
            lbTrace.Items.Add("");
        }

        // Test Module 2 - Testing Parent-Chlid Communication
        //
        // Purpose: All of the public variables and public functions (in Main) can be
        // referenced in the child forms via pf.xxx
        public void TestModule2()
        {
            lbTraceNote("-", "Test Module 2", "Testing Parent-Child", "Communication");

            lbTrace.Items.Add("pf.UserName ....... = " + pf.UserName);
            lbTrace.Items.Add("pf.Password ....... = " + pf.Password.ToString());

            pf.UserName = "mlewis";
            pf.Password = 987;

            lbTrace.Items.Add("");

            lbTrace.Items.Add("\n-- We Have Tried To Make Changes? --");
            lbTrace.Items.Add("pf.UserName ....... = " + pf.UserName);
            lbTrace.Items.Add("pf.Password ....... = " + pf.Password.ToString());

            lbTrace.Items.Add("");
        }

        // Test Module 3 - Testing ComboBox Controls
        //
        // Purpose: Display the selections of all ComboBox Controls
        public void TestModule3()
        {
            lbTraceNote("-", "Test Module 3", "ComboBox Control", "Settings");

            lbTrace.Items.Add("cbOrderBy.Text ....... = " + cbOrderBy.Text);
            //lbTrace.Items.Add("cbSelect.Text ........ = " + cbSelect.Text);
            //lbTrace.Items.Add("cbDeptID.DispalyValue  = " + cbGenre.Text.ToString());
            //lbTrace.Items.Add("cbDeptID.SelectedValue = " + cbGenre.SelectedValue.ToString());
            lbTrace.Items.Add("");
        }

        // Test Module 4 - Testing ComboBox Controls
        //
        // Purpose: Display the selections of all CheckBox Controls
        public void TestModule4()
        {
            lbTraceNote("-", "Test Module 4", "CheckBox Control", "Settings");

            //lbTrace.Items.Add("chAdministrator.Checked ....... = " + chAdministrator.Checked.ToString());
            lbTrace.Items.Add("");
        }

        // Test Module 5 - Testing Radio Button Controls
        //
        // Purpose: Display the selections of all Radio Button Controls
        public void TestModule5()
        {
            lbTraceNote("-", "Test Module 5", "Radio Button Control", "Settings");

            //lbTrace.Items.Add("rbFemale.Checked ....... = " + rbFemale.Checked.ToString());
            //lbTrace.Items.Add("rbMale.Checked ......... = " + rbMale.Checked.ToString());
            lbTrace.Items.Add("");
        }

        #endregion Tom Lauerman Diagnostic Testing

        //--------------------------------------------------------------------------------
        //------------------ Dr. Hicks View Management Functionality ---------------------
        #region -----ViewMode--EditMode--Add--Deleted-Save--Cancel------------------------
        //--------------------------------------------------------------------------------
        //===========================================================================//
        //== ViewMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Protect the form from accidental data change. ==//
        //== (1) Make sure that the user can not change any of the ==//
        //== controls (i.e. --> TextBoxes, RadioButtons, CheckBoxes, ==//
        //== ComboBoxes, Spinners, etc.) that are associat ed with ==//
        //== data entry on any of the tabs. ==//
        //== (2) Make sure that the user cannot change any of those ==//
        //== controls that are meant to display view-only info ==////== such as the ID (auto incrementing primary key). ==//
        //== (3) Make sure that the user can see, and use, to those ==//
        //== MenuStrip buttons for which they have permission; ==//
        //== if the user is not an administrator, you should ==//
        //== hide any administrative buttons. ==//
        //== (4) Buttons Save and Cancel should be hidden. ==//
        //== (5) The EditMode will often change the data control ==//
        //== background to make it obvious, to the user, that they ==//
        //== are in a data entry mode; ViewMode shoud change the ==//
        //== background back to the normal view color (often ==//
        //== white). ==//
        //== (6) Make sure that the user has access to all Navigation ==//
        //== buttons, Select ComboBoxes, Select Order By's, ==//
        //== Quick-Link Buttons, Form Transfer Buttons, Phone/Fax ==//
        //== Call Buttons, etc. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void ViewMode()
        {
            pf.UserInViewMode = true;
            pf.UserInEditMode = false;
            pf.UserInAddMode = false;

            // ------------------ Control MenuStrip Buttons ----------------------
            addToolStripMenuItem.Visible = true;
            editToolStripMenuItem.Visible = true;
            deleteToolStripMenuItem.Visible = true;
            undeleteToolStripMenuItem.Visible = true;
            saveToolStripMenuItem.Visible = false;
            
            cancelToolStripMenuItem.Visible = false;
            searchToolStripMenuItem.Visible = true;
            searchYourPlaylistsToolStripMenuItem.Visible = true;
            reportsToolStripMenuItem.Visible = true;
            sendLinkToUserToolStripMenuItem.Visible = true;
            //administrativeToolStripMenuItem.Visible = true;
            closeToolStripMenuItem.Visible = true;
            dATAToolStripMenuItem.Visible = true;

            // ------ Must Change FlatStyle Property From Standard To Flat -------
            // ------------------------- CoboBoxes ------------------------------- 


            cbVisibility.BackColor = Color.FromArgb(242, 208, 242);
            txtVisibility.Text = cbVisibility.Text;
            cbVisibility.Visible = false;

            txtVisibility.Visible = true;

            txtPlaylistName.ReadOnly = true;
            txtPlaylistName.BackColor = Color.FromArgb(242, 208, 242);
            



            txtNotes.ReadOnly = true;
            txtNotes.BackColor = Color.FromArgb(255, 255, 255);

            // ---------------------- Navigation Controls -------------------------
            pnlNavigation.Show();
            btnTest.Show();

            // ------------------------ Testing Controls --------------------------
            if (Testing == false)
            {
                lbTrace.Hide();
                btnTest.Hide();
                this.Width = 810;
                this.Height = 600;
            }
            if (Testing == true)
            {
                lbTrace.Show();
                btnTest.Show();
                this.Width = 1182;
                this.Height = 593;
            }

            // Transaction Views
            pnlPlaylist1.Show();
            pnlPlaylist1.BringToFront();

            // Fill Form Variables
            if (!DataToggle)
            {
                FillFormVariables();
            }
        }
        //===========================================================================//
        //== EditMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Create an enviornment in which the user's only choices ==//
        //== are to (a) alter the data entry controls, (b) Save any ==//
        //== changes, (c) Cancel any changes and revert/return back to ==//
        //== the previous status --> reload the current record. ==//
        //== (1) Make sure that the user can change any of the ==//
        //== controls (i.e. --> TextBoxes, RadioButtons, CheckBoxes, ==//
        //== ComboBoxes, Spinners, etc.) that are associat ed with ==//
        //== data entry on any of the tabs. ==//
        //== (2) Make sure that the user cannot change any of those ==//
        //== controls that are meant to display view-only info ==//
        //== such as the ID (auto incrementing primary key). ==//
        //== (3) Make sure that the only MenuStrip choices are Save and ==//
        //== Cancel. ==//
        //== (4) Buttons Save and Cancel should be hidden. ==//
        //== (5) Alter the background to make it obvious, to the user, ==//
        //== that they are in a data entry mode. Keep it ==//
        //== professional; do not select really wild colors. ==//
        //== (6) Make sure that the user has no access Navigation ==//
        //== buttons, Select ComboBoxes, Select Order By's, ==//
        //== Quick-Link Buttons, Form Transfer Buttons, Phone/Fax ==//
        //== Call Buttons, etc. The idea is to force the user to ==//
        //== complete the Edit/Add process. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void EditMode()
        {
            pf.UserInViewMode = false;
            pf.UserInEditMode = true;

            // ------------------ Control MenuStrip Buttons ----------------------
            addToolStripMenuItem.Visible = false;
            editToolStripMenuItem.Visible = false;
            saveToolStripMenuItem.Visible = true;
            cancelToolStripMenuItem.Visible = true;
            deleteToolStripMenuItem.Visible = false;
            undeleteToolStripMenuItem.Visible = false;
            searchToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            sendLinkToUserToolStripMenuItem.Visible = false;
            searchYourPlaylistsToolStripMenuItem.Visible = false;
            //administrativeToolStripMenuItem.Visible = false;
            closeToolStripMenuItem.Visible = false;
            dATAToolStripMenuItem.Visible = false;
            //txtProfile.Visible = true;

            // ------------ Make All TextBoxes Available To Edit ----------------
            // ---------------- Change Background To EditColor -----------------

            // ------ Must Change FlatStyle Property From Standard To Flat -------
            // ------------------------- CoboBoxes ------------------------------- 

            foreach (Control cntrl in editFields)
            {
                var txtCntrl = cntrl as TextBoxBase;
                if (txtCntrl != null)
                    txtCntrl.ReadOnly = false;

                cntrl.BackColor = Color.FromArgb(227, 220, 184);
            }

            txtPlaylistName.Text = txtPlaylistName.Text;
            cbVisibility.BackColor = Color.FromArgb(227, 220, 184);
            cbVisibility.Text = txtVisibility.Text;
            cbVisibility.Visible = true;
            txtVisibility.Visible = false;
            


            txtPlaylistName.ReadOnly = false;
            txtPlaylistName.BackColor = Color.FromArgb(227, 220, 184);
            txtNotes.ReadOnly = false;
            txtNotes.BackColor = Color.FromArgb(227, 220, 184);
            txtNotes.Text = txtNotes.Text; 

            // ---------------------- Navigation Controls -------------------------
            pnlNavigation.Hide();
            btnTest.Hide();

            // Transaction Panels
            if (pf.UserInAddMode)
            {
                pnlPlaylist1.Hide();
                //pnlCODetail.Hide();
            }
        }
        //===========================================================================//
        //== AddMode ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Set the InAddMode to true and call EditMode. The NoLogRec ==//
        //== must increase if the user chooses to save this new record; ==//
        //== re-calibrate it. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void AddMode()
        {
            pf.UserInAddMode = true;
            FillFormBlank();
            EditMode();
        }
        //===========================================================================//
        //== Delete ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Tag the Current record for deletion; set Deleted = 'F'. ==//
        //== The NoLogRec must decrease; re-calibrate it. Since we do ==//
        //== waant to be looking at a deleted record, I would suggest ==//
        //== that you LoadPreviousRecord then LoadNextRecord. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void Delete()
        {
            // String Query = "UPDATE User SET Deleted = 'T' WHERE ID = '" + CurrentID.ToString() + "';";
            //ViewFirstRecord = !ViewFirstRecord;
            FillFormBlank();
        }
        //===========================================================================//
        //== Save ==//
        //===========================================================================//
        //== ==//
        //== Purpose: If InAddMode: ==//
        //== (1) INSERT the record into the database ==//
        //== (2) If this new record is part of the current view : ==//
        //== (a) Reset the CurrentID ==//
        //== (b) Make this new record the Current Record in dt ==//
        //== (3) If this new record is not part of the current view ==//
        //== (a) Reload the last record in the current view ==//
        //== (4) Re-Calibrate the NoLogRec ==//
        //== ==//
        //== If Not In InAddMode: ==//
        //== (1) UPDATE the record into the database ==//
        //== (a) Reset the CurrentID ==//
        //== (b) Make this new record the Current Record in dt ==//
        //== (2) Re-Calibrate the NoLogRec ==//
        //== ==//
        //== Update the FullName & Reset the modes. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        public void Save()
        {
            ViewMode();
            txtPlaylistName2.Text = txtPlaylistName.Text;
        }
        //===========================================================================//
        //== Cancel ==//
        //===========================================================================//
        //== ==//
        //== Purpose: Discard any changes and reload the current record. ==//
        //== ==//
        //== Written By: Dr. Tom Hicks Operating System: Windows 10 ==//
        //== Date: XX\XX\XXXX Environment: C# VS 2017 ==//
        //===========================================================================//
        private void Cancel()
        {
            FillFormVariables();
            ViewMode();
        }
        //--------------------------------------------------------------------------------
        #endregion --------- Dr. Hicks View Management Functionality ---------------------
        //--------------------------------------------------------------------------------

        // PopulateDeptIdComboBox
        //
        // Purpose: Use a Dictionary to populate the cbDeptId ComboBox with
        // Department Names and IDs.
        // Written By: Tom Lauerman
        // Date: 1/29/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        public void PopulateDeptIDComboBox()
        {
            Dictionary<Int32, String> departments = new Dictionary<Int32, String>();
            departments.Add(0, "--- Select Genre ---");
            departments.Add(19, "Classical");
            departments.Add(1, "Rock");
            departments.Add(13, "Pop");
            departments.Add(6, "K-Pop");
            departments.Add(15, "Jazz");

            /*cbGenre.DataSource = new BindingSource(departments, null);
            cbGenre.DisplayMember = "Value";
            cbGenre.ValueMember = "Key";
            cbGenre.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestingMaster();
        }

        private void btnHomePhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialing Home Phone\nHello Computer Scientist!");
        }

        private void btnCellPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialing Cell Phone\nHello Computer Scientist!");
        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessDataToggle();
        }

        private void btnNextLeft_Click(object sender, EventArgs e)
        {
            LoadNextRecord();
        }

        private void btnPreviousLeft_Click(object sender, EventArgs e)
        {
            LoadPreviousRecord();
        }

        private void btnFirstLeft_Click(object sender, EventArgs e)
        {
            LoadFirstRecord();
        }

        private void btnLastLeft_Click(object sender, EventArgs e)
        {
            LoadLastRecord();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            //this.SendToBack();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFirstRecord = 2;
            FillFormVariables();
        }

        private void User_VisibleChanged(object sender, EventArgs e)
        {
            if (pf.UserInEditMode)
                EditMode();
            else
                ViewMode();
        }

        private void CbDeptID_Enter(object sender, EventArgs e)
        {
            ShowReadOnlyMessageBox();
        }

        private void ChAdministrator_Enter(object sender, EventArgs e)
        {
            ShowReadOnlyMessageBox();
        }

        private void TxtFirst_Leave(object sender, EventArgs e)
        {
            SynchronizeCommonFields();
        }

        private void TxtMI_Leave(object sender, EventArgs e)
        {
            SynchronizeCommonFields();
        }

        private void TxtLast_Leave(object sender, EventArgs e)
        {
            SynchronizeCommonFields();
        }

        private void RbFemale_Enter(object sender, EventArgs e)
        {
            ShowReadOnlyMessageBox();
        }

        private void RbMale_Enter(object sender, EventArgs e)
        {
            ShowReadOnlyMessageBox();
        }

        private void ShowReadOnlyMessageBox()
        {
            if (!pf.UserInEditMode)
            {
                MessageBox.Show("You Must Edit - If You Want To Change This");
                btnNextLeft.Focus();
            }
        }

        private void tabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            // Hide Detail Components
            /*dgSongs.Hide();
            pnlSongs.Hide();
            lblSongs.Hide();
            dgMembers.Hide();
            pnlMembers.Hide();
            lblMembers.Hide();

            ViewFirstRecord = 2;
            FillFormVariables();

            // Show possibly deleted records
            btnDelete3.Show();
            btnViewDetails3.Show();
            txtCheckOut3.Show();
            button21.Show();
            button25.Show();
            textBox15.Show();

            button5.Show();
            button8.Show();
            textBox7.Show();*/

        }

        private void btnViewDetails3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Playing", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*dgSongs.Show();
            pnlSongs.Show();
            lblSongs.Show();

            pnlSongs.BringToFront();*/
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            button44.Hide();
            btnDelete3.Hide();
            btnViewDetails3.Hide();
            txtCheckOut3.Hide();

            // Hide Detail Components
            /*dgSongs.Hide();
            pnlSongs.Hide();
            lblSongs.Hide();*/
        }

        private void btnNextRight_Click(object sender, EventArgs e)
        {
            LoadNextRecord();
        }

        private void btnPreviousRight_Click(object sender, EventArgs e)
        {
            LoadPreviousRecord();
        }

        private void btnFirstRight_Click(object sender, EventArgs e)
        {
            LoadFirstRecord();
        }

        private void btnLastRight_Click(object sender, EventArgs e)
        {
            LoadLastRecord();
        }

        private void departmentsAddEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Add - Edit - Delete Departments", "Department Name", "Biology", "Chemistry", "Computer Science", "Math", "Physics");
        }

        private void userTypesAddEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Add - Edit - Delete User Types", "User Type", "Faculty", "Guest", "Librarian", "Parent", "Student");
        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchUndeleteWindow("Undelete Playlists", "Playlists", "Fun Songs!", "Songs That Make My Mom Go Crazy", "Edgy Songs for Edgy Teens", "My Study Music", "Classical and Rock n' Roll");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pf.LaunchSearchWindow("Search User By Name", "Enter Name", "Hicks, T");
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search Song By Name", "Enter Name", "Renegade", "Push the View Button to Add the song", "Renegade, Momo", "Renegade, Bobo", "Renegade, CiCi", "Renegade, Grande", "Renegade, Styx");
            textBox8.Show();
            button10.Show();
            button9.Show();
            button38.Show();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pf.LaunchSearchWindow("Search User By ID", "Enter ID", "223");
        }

        private void byUniversityIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pf.LaunchSearchWindow("Search User By University ID", "Enter University ID", "00133456");
        }

        private void byPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pf.LaunchSearchWindow("Search User By Phone", "Enter Phone", "(210) 999-7438");
        }

        private void Songs_Click(object sender, EventArgs e)
        {

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            ViewFirstRecord = 2;
            FillFormVariables();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //dgMembers.Show();
            //pnlMembers.Show();
            //lblMembers.Show();

            //pnlMembers.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //button21.Hide();
            //button25.Hide();
            //textBox15.Hide();

            // Hide Detail Components
            //dgMembers.Hide();
            //pnlMembers.Hide();
            //lblMembers.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Links to the Music subsystem", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Hide();
            button8.Hide();
            textBox7.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ViewFirstRecord = 0;
            FillFormVariables();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            ViewFirstRecord = 1;
            FillFormVariables();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (txtVisibility.Text == "Public" || txtVisibility.Text == "Unlisted")
            {
                MessageBox.Show("Playlist is now available to anyone with a link \nThe link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");

            }
            else
            {
                if (MessageBox.Show("To share playlists, visibility must be public or unlisted. Would you like to change the visibility to Public?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cbVisibility.Text = "Pubic";
                    txtVisibility.Text = "Public";
                    MessageBox.Show("Playlist is now available to anyone with a link. \n The link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll");
                    Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");

                }
                else
                {
                    if (MessageBox.Show("To share playlists, visibility must be public or unlisted. Would you like to change the visibility to Unlisted?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cbVisibility.Text = "Pubic";
                        txtVisibility.Text = "Public";
                        MessageBox.Show("Playlist is now available to anyone with a link \nThe link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll");
                        Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");


                    }
                    else
                    {
                        MessageBox.Show("Link can not be shared. Consider changing visbility by using edit and the visibility combobox.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    }

                }
            }
        }

        private void cbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your Playlists Have Been Updated.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendLinkToUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Playing From Start", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Playing In Random Order","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPlaylistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVisibility_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Going to User Subsystem", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void popularPlaylistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchSelect("The most listened to playlists on Periwinkle", "The most listened to playlists on Periwinkle", "Cool Girls", "Hot Chicks", "Mixed Artists", "Mexican Artists", "He Be Hitting Different");
        }

        private void fromALinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchSearchWindow("Enter the unlisted/public playlist link to add to your playlist library.", "Paste the Link", "Add Playlist", "");
        }

        private void personalPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchSupportingClassWindow("New Playlist", "Add", "");
        }

        private void fromPlaylistNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Add Playlist By Name", "Enter Name", "Chill", "Push the View Button to Add the playlist", "Chill Beats", "Music for Chilly Days", "Chill Boy Bands", "Chill Rappers", "Chill");

        }

        private void sentFromUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchSelect("Playlists Sent By Other Users", "Playlists Sent By Other Users", "One (user: Tom)", "Two (user: Tom)", "Three (User: Tom)", "Four (User:Tom)", "Five (User:Tom)");

        }

        private void dgAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opens Music Subsystem to view genre, album it is in, release date, notes, song art, and more.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaylistName2_Click(object sender, EventArgs e)
        {

        }

        private void addReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchBySongTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search Your 3 Playlist By Name", "Enter Name", "Classical and Rock n' Roll", "Push the View Button to Go to Your playlist", "Playlist 1", "Playlist 2", "Playlist 3", "Playlist 4", "Classical and Rock n' Roll");

        }

        private void addAllSongsFromSelectedAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your Playlists Have Been Updated.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void searchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search Your 3 Playlist By ID", "Enter ID", "1", "Push the View Button to Go to Your playlist", "ID5:Playlist 5", "ID2:Playlist 2", "ID3:Playlist 3", "ID4Playlist 4", "ID1:Classical and Rock n' Roll");

        }

        private void searchByOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search Your 3 Playlist By Owner", "Enter Owner", "1", "Push the View Button to Go to Your playlist", "", "", "", "", "Tom: Classical and Rock n' Roll");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shareToUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtVisibility.Text == "Private")
            {
                MessageBox.Show("Change visbility to Not Listed or Public to share", "Playlist is Private", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                LaunchSearchWindow("Send playlist link to a user", "Enter Username", "Send", "");
            }

        }

        private void shareWithLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtVisibility.Text == "Public" || txtVisibility.Text == "Unlisted")
            {
                MessageBox.Show("Playlist is now available to anyone with a link \nThe link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");

            }
            else
            {
                if (MessageBox.Show("To share playlists, visibility must be public or unlisted. Would you like to change the visibility to Public?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cbVisibility.Text = "Pubic";
                    txtVisibility.Text = "Public";
                    MessageBox.Show("Playlist is now available to anyone with a link. \n The link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll");
                    Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");

                }
                else
                {
                    if (MessageBox.Show("To share playlists, visibility must be public or unlisted. Would you like to change the visibility to Unlisted?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cbVisibility.Text = "Pubic";
                        txtVisibility.Text = "Public";
                        MessageBox.Show("Playlist is now available to anyone with a link \nThe link has been copied to your clipboard.\n\n Here is your link: \n PeriwinkleMusic.cs/Playlist?=TomRocknRoll");
                        Clipboard.SetText("PeriwinkleMusic.cs/Playlist?=TomRocknRoll");


                    }
                    else
                    {
                        MessageBox.Show("Link can not be shared. Consider changing visbility by using edit and the visibility combobox.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    }

                }
            }

        }

        private void shareOnSocialMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchSelect("Share this playlist on social media", "Choose Your Prefereed Medium", "Facebook", "Twitter", "Instagram", "Reddit", "TikTok");



        }

        private void amministrationAddEditDeleteSocialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSupportingClassWindow("Add - Edit - Delete Social Media for Sharing", "Social Media", "Facebook", "Twitter", "Instagram", "Reddit", "TikTok");

        }

        private void searchByCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pf.LaunchSearchWindow("Search Your Playlists By Comment. Only partial match needed.", "Enter Comment", "classical", "Push the View Button to Go to Your playlist", "", "", "", "", "*Classic*al and Rock n' Roll");

        }

        private void searchByVisibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
