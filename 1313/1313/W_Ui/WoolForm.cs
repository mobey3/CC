using _1313.W_Ui;
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

namespace _1313.ui
{
    public partial class WoolForm : MaterialForm
    {
        public WoolForm()
        {
            InitializeComponent();
        }

        private void G_Wall_btn_Click(object sender, EventArgs e)
        {
            new W_WallForm().ShowDialog();
        }

        private void G_Boltless250_btn_Click(object sender, EventArgs e)
        {
            new W_Boltless250Form().ShowDialog();
        }

        private void G_V80_btn_Click(object sender, EventArgs e)
        {
            new W_V80Form().ShowDialog();
        }

        private void G_Metal_btn_Click(object sender, EventArgs e)
        {
            new W_MetalForm().ShowDialog();
        }

        private void G_Sideing_btn_Click(object sender, EventArgs e)
        {
            new W_SideingForm().ShowDialog();
        }

        private void G_Jinx_btn_Click(object sender, EventArgs e)
        {
            new W_JinxForm().ShowDialog();
        }

        private void G_Roof_btn_Click(object sender, EventArgs e)
        {
            new W_RoofForm().ShowDialog();
        }
    }
}
