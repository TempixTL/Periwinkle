using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periwinkle
{
    public partial class Periwinkle : Form
    {
        public Periwinkle()
        {
            InitializeComponent();

            Form f = new User();
            f.MdiParent = this;
            f.Show();
        }
    }
}
