using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LibraryApp
{
    public partial class MembershipUpgrade : Form
    {

        private Main pf;
        private String UserName;
        private String CurrentMembership;

        public MembershipUpgrade()
        {
            InitializeComponent();
        }

        public MembershipUpgrade(Main pf, String Name, String CurrentMembership)
        {
            InitializeComponent();
            this.pf = pf;
            this.UserName = Name;
            this.CurrentMembership = CurrentMembership;
        }

        private void MembershipUpgrade_Load(object sender, EventArgs e)
        {
            lblName.Text = UserName;
            lblMembership.Text = CurrentMembership;

            if (btnFree.Text == CurrentMembership)
            {
                btnFree.BackColor = Color.FromArgb(242, 159, 226);
                btnFree.Enabled = false;
            }
            else if (btnPremium.Text == CurrentMembership)
            {
                btnPremium.BackColor = Color.FromArgb(242, 159, 226);
                btnPremium.Enabled = false;
            }
            else if (btnMorePremium.Text == CurrentMembership)
            {
                btnMorePremium.BackColor = Color.FromArgb(242, 159, 226);
                btnMorePremium.Enabled = false;
            }
            else if (btnArtist.Text == CurrentMembership)
            {
                btnArtist.BackColor = Color.FromArgb(242, 159, 226);
                btnArtist.Enabled = false;
            }
        }

        private void btnClick(String SelectedButtonText)
        {
            CurrentMembership = SelectedButtonText;

            List<Button> btns = new List<Button>
            {
                btnFree,
                btnPremium,
                btnMorePremium,
                btnArtist
            };

            foreach (Button b in btns)
            {
                if (b.Text.Equals(SelectedButtonText))
                {
                    b.BackColor = Color.FromArgb(242, 159, 226);
                    b.Enabled = false;
                } else
                {
                    b.BackColor = Color.FromArgb(201, 107, 255);
                    b.Enabled = true;
                }
            }

            lblMembership.Text = SelectedButtonText;
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            btnClick(btnFree.Text);
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            btnClick(btnPremium.Text);
        }

        private void btnMorePremium_Click(object sender, EventArgs e)
        {
            btnClick(btnMorePremium.Text);
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            btnClick(btnArtist.Text);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String price = "";
            switch (CurrentMembership)
            {
                case "Free":
                    price = "$0.00 Per Month";
                    break;
                case "Premium":
                    price = "$9.99 Per Month";
                    break;
                case "Premium++":
                    price = "$19.99 Per Month";
                    break;
                case "Artist":
                    price = "$99.99 Per Month";
                    break;
            }

            pf.UserForm.ChangeMembership(CurrentMembership, price);
            this.Hide();
        }
    }
}
