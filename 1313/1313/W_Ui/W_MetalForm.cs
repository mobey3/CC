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
    public partial class W_MetalForm : MaterialForm
    {
        public W_MetalForm()
        {
            InitializeComponent();
        }

        private void M_S_btn_Click(object sender, EventArgs e)
        {
            string com = C_text.SelectedText;
            string ki = "메탈";
            string di;

            UICheckBox[] checkBox1 = new UICheckBox[]
           {
                M_T_chk1, M_T_chk2, M_T_chk3, M_T_chk4, M_T_chk5,
                M_T_chk6, M_T_chk7
           };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                M_C_chk1 , M_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                M_D_chk1 , M_D_chk2
            };

            string Leg = M_L_Text.Text;

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
                        Console.WriteLine("비용:" + GlasswoolPrice.Metal48Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.Metal48Money[i]));
                        st = GlasswoolPrice.Metal48Money[i];
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
                        Console.WriteLine("비용:" + GlasswoolPrice.Metal64Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.Metal64Money[i]));
                        st = GlasswoolPrice.Metal64Money[i];
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

            sum = ((st + co) * Convert.ToInt32(M_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);

            ViewItem sty = new ViewItem(com, ki, di, itemList, itemList2, sum);
        }

        private void M_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
