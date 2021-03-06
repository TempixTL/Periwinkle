﻿using System;
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
    public partial class SupportingClassAddEdit : Form
    {

        SupportingClass sc;
        String MyOption;

        public SupportingClassAddEdit()
        {
            InitializeComponent();
        }

        public SupportingClassAddEdit(SupportingClass parent, String NewDescription,
            String Option, String NewValue)
        {
            InitializeComponent();
            sc = parent;
            this.Height = 135;
            this.Width = 350;
            this.Location = new Point(850, 410);
            Text = Option + " " + NewDescription;
            lbDescription.Text = NewDescription;
            txtValue.Text = NewValue;
            MyOption = Option;
        }

        public SupportingClassAddEdit(Main parent, String NewDescription,
            String Option, String NewValue)
        {
            InitializeComponent();
            //sc = parent;
            this.Height = 135;
            this.Width = 350;
            this.Location = new Point(850, 410);
            Text = Option + " " + NewDescription;
            lbDescription.Text = NewDescription;
            txtValue.Text = NewValue;
            MyOption = Option;
        }

        private void SupportingClassAddEdit_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
        }

        //--------------------------------------------------------------------------------
        //---------------------- Dr. Hicks Initializtion Utilities -----------------------
        //----------SupportingClassAddEdit--SupportingClassAddEdit_Load--MyRenderer-------
        #region ----CreateParams ---------------------------------------------------------
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sc.Update(txtValue.Text, MyOption);
            this.Close();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        #endregion ------------- Dr. Hicks Initializtion Utilities -----------------------
        //--------------------------------------------------------------------------------
    }
}
