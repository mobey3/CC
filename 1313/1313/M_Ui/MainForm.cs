using _1313.conmon;
using _1313.M_Ui;
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
            string pk = P_K_text.SelectedText;

            if(pk == "스티로폼")
            {
                new styrofoamForm().ShowDialog();
            }
            else
            {
                new WoolForm().ShowDialog();
            }

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            new EstimateView().ShowDialog();
        }
    }
}
