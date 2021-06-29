using _1313.model;
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

namespace _1313.M_Ui
{
    public partial class EstimateView : MaterialForm
    {
        public EstimateView()
        {
            InitializeComponent();
        }

        private void view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            view.Rows.Add();
        }
    }
}
