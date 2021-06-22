using _1313.conmon;
using _1313.ui;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1313
{
    public partial class Form1 : MaterialForm
    {
        
        public Form1()
        {
            InitializeComponent();
            Util.initTheme(this);
        }

        private void Sty_Estimate_Click(object sender, EventArgs e)
        {
            new styrofoamForm().ShowDialog();
        }

        private void Wool_Estimate_Click(object sender, EventArgs e)
        {
            new WoolForm().ShowDialog();
        }
    }
}
