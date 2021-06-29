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
    public partial class styrofoamForm : MaterialForm
    {
        public styrofoamForm()
        {
            InitializeComponent();
        }

        private void Wall_btn_Click(object sender, EventArgs e)
        {
            new S_WallForm().ShowDialog();
        }

        private void Boltless250_btn_Click(object sender, EventArgs e)
        {
            new S_Boltless250Form().ShowDialog();
        }

        private void Boltless_btn_Click(object sender, EventArgs e)
        {
            new S_BoltlessForm().ShowDialog();
        }

        private void Roof_btn_Click(object sender, EventArgs e)
        {
            new S_RoofForm().ShowDialog();
        }

        private void Jinx_btn_Click(object sender, EventArgs e)
        {
            new S_JinxForm().ShowDialog();
        }

        private void Sideing_btn_Click(object sender, EventArgs e)
        {
            new S_SideingForm().ShowDialog();
        }

        private void Metal_btn_Click(object sender, EventArgs e)
        {
            new S_MetalForm().ShowDialog();
        }

        private void Tree_btn_Click(object sender, EventArgs e)
        {
            new S_TreeForm().ShowDialog();
        }

        private void Tree_btn_Click_1(object sender, EventArgs e)
        {
            new S_TreeForm().ShowDialog();
        }
    }
}
