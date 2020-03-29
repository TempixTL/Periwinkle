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
    public partial class Undelete : Form
    {
        private Main pf;
        public String Description;

        public Undelete()
        {
            InitializeComponent();
        }

        private void SupportingClass_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
        }

        public Undelete(Main parent, String NewText, String NewDescription, String NewRec1, String NewRec2, String NewRec3, String NewRec4, String NewRec5) {
            InitializeComponent();
            pf = parent;
            Location = new Point(850, 20);
            txtRec1.Text = NewRec1;
            txtRec2.Text = NewRec2;
            txtRec3.Text = NewRec3;
            txtRec4.Text = NewRec4;
            txtRec5.Text = NewRec5;
            lbDescription.Text = NewDescription;

        }
        //--------------------------------------------------------------------------------
        //---------------------- Dr. Hicks Initializtion Utilities -----------------------
        #region ----SupportingClass--SupportingClass_Load--MyRenderer--CreateParams ------
        //--------------------------------------------------------------------------------

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

        //--------------------------------------------------------------------------------
        #endregion ------------- Dr. Hicks Initializtion Utilities -----------------------
        //--------------------------------------------------------------------------------

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndelete5_Click(object sender, EventArgs e)
        {
            txtRec5.Text = "";
        }
    }
}
