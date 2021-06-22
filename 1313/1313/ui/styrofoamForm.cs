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
            new WallForm().ShowDialog();
        }

        private void Boltless250_btn_Click(object sender, EventArgs e)
        {
            new Boltless250Form().ShowDialog();
        }

        private void Boltless_btn_Click(object sender, EventArgs e)
        {
            new BoltlessForm().ShowDialog();
        }

        private void Roof_btn_Click(object sender, EventArgs e)
        {
            new RoofForm().ShowDialog();
        }

        private void Jinx_btn_Click(object sender, EventArgs e)
        {
            new JinxForm().ShowDialog();
        }

        private void Sideing_btn_Click(object sender, EventArgs e)
        {
            new SideingForm().ShowDialog();
        }

        private void Metal_btn_Click(object sender, EventArgs e)
        {
            new MetalForm().ShowDialog();
        }

        private void Tree_btn_Click(object sender, EventArgs e)
        {
            new TreeForm().ShowDialog();
        }
    }
}
