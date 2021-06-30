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
        private List<ViewItem> list =
            new List<ViewItem>();
        public EstimateView()
        {
            InitializeComponent();
        }

        
        
        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
