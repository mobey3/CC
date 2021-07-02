using _1313.model;
using _1313.PanelTable;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1313.W_Ui
{
    public partial class W_RoofForm : MaterialForm
    {
        public W_RoofForm()
        {
            InitializeComponent();
        }

        private void R_S_btn_Click(object sender, EventArgs e)
        {
            string com = C_text.SelectedText;
            string ki = "지붕";
            string di;

            UICheckBox[] checkBox1 = new UICheckBox[]
           {
                R_T_chk1, R_T_chk2, R_T_chk3, R_T_chk4, R_T_chk5,
                R_T_chk6, R_T_chk7, R_T_chk8
           };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                R_C_chk1 , R_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                R_D_chk1 , R_D_chk2
            };

            string Leg = R_L_Text.Text;

            int sum = 0;
            int st = 0;
            int co = 0;

            List<PriceItem> itemList = new List<PriceItem>();

            if (checkBox3[0].Checked)
            {
                for (int i = GlasswoolPrice.T50; i < GlasswoolPrice.T220 + 1; i++)
                {
                    if (checkBox1[i].Checked)
                    {
                        Console.WriteLine("구매항목:" + checkBox1[i].Text);
                        Console.WriteLine("비용:" + GlasswoolPrice.Roof48Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.Roof48Money[i]));
                        st = GlasswoolPrice.Roof48Money[i];
                        break;
                    }
                }
                di = checkBox3[0].Text;
            }

            else
            {
                for (int i = GlasswoolPrice.T50; i < GlasswoolPrice.T220 + 1; i++)
                {
                    if (checkBox1[i].Checked)
                    {
                        Console.WriteLine("구매항목:" + checkBox1[i].Text);
                        Console.WriteLine("비용:" + GlasswoolPrice.Roof64Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.Roof64Money[i]));
                        st = GlasswoolPrice.Roof64Money[i];
                        break;
                    }
                }
                di = checkBox3[1].Text;
            }


            List<PriceItem> itemList2 = new List<PriceItem>();

            for (int j = 0; j < 2; j++)
            {
                if (checkBox2[j].Checked)
                {
                    Console.WriteLine("구매항목:" + checkBox2[j].Text);
                    Console.WriteLine("추가비용:" + ColorPrice.ColorMoney[j]);
                    itemList2.Add(new PriceItem(j, ColorPrice.ColorMoney[j]));
                    co = ColorPrice.ColorMoney[j];
                    break;
                }
            }
            Console.WriteLine(co);

            sum = ((st + co) * Convert.ToInt32(R_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);

            ViewItem sty = new ViewItem(com, ki, di, itemList, itemList2, sum);
        }

        private void R_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
