using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Main : Form
    {
        public Artist UserForm;
        public bool UserInViewMode = true;
        public bool UserInEditMode = false;
        public bool UserInAddMode = false;
        public SupportingClass SupportingClassForm;
        public Undelete UndeleteForm;
        public Search SearchForm;
        public MembershipUpgrade MembershipForm;

        public String UserName = "thicks";
        public long Password = 12345;

        // Tom Lauerman Initialization Utilities
        #region Main -- Main_Load -- MyRenderer -- CreateParams

        public Main()
        {
            InitializeComponent();
            UserForm = new Artist(this);
            UserForm.MdiParent = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
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

        // CreateParams
        //
        // Purpose: Block of code to disable the close box on a form and yet control minimize and maximize functionality.
        // Written By: Tom Lauerman
        // Date: 1/29/2020
        // Operating System: Windows 10
        // Environment: C# VS 2017
        public const int CS_NOCLOSE = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        #endregion Tom Lauerman Initialization Utilities

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userSubSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm.Show();
        }

        public void LaunchSupportingClassWindow(String NewText, String NewDescription,
                    String NewRec1, String NewRec2, String NewRe3, String NewRec4, String NewRec5)
        {
            SupportingClassForm = new SupportingClass(this, NewText, NewDescription,
                 NewRec1, NewRec2, NewRe3, NewRec4, NewRec5);
            SupportingClassForm.MdiParent = this;
            SupportingClassForm.Show();
            SupportingClassForm.Text = NewText;
        }

        public void LaunchUndeleteWindow(String NewText, String NewDescription,
            String NewRec1, String NewRec2, String NewRe3, String NewRec4, String NewRec5)
        {
            UndeleteForm = new Undelete(this, NewText, NewDescription,
            NewRec1, NewRec2, NewRe3, NewRec4, NewRec5);
            UndeleteForm.MdiParent = this;
            UndeleteForm.Show();
            UndeleteForm.Location = new Point(850, 20);
            UndeleteForm.Text = NewText;
        }

        public void LaunchSearchWindow(String NewText, String Prompt, String Example)
        {
            SearchForm = new Search(this, NewText, Prompt, Example);
            SearchForm.MdiParent = this;
            SearchForm.Location = new Point(300, 200);
            SearchForm.Show();
        }

        public void LaunchMembershipUpgradeWindow(String Name, String CurrentMembership)
        {
            MembershipForm = new MembershipUpgrade(this, Name, CurrentMembership);
            MembershipForm.MdiParent = this;
            MembershipForm.Location = new Point(850, 20);
            MembershipForm.Show();
        }
    }
}
