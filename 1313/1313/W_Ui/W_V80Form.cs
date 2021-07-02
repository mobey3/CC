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
    public partial class W_V80Form : MaterialForm
    {
        public W_V80Form()
        {
            InitializeComponent();
        }

        private void V_S_btn_Click(object sender, EventArgs e)
        {
            string com = C_text.SelectedText;
            string ki = "V-80";
            string di;

            UICheckBox[] checkBox1 = new UICheckBox[]
          {
                V_T_chk1, V_T_chk2, V_T_chk3, V_T_chk4, V_T_chk5,
                V_T_chk6, V_T_chk7
          };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                V_C_chk1 , V_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                V_D_chk1 , V_D_chk2
            };

            string Leg = V_L_Text.Text;

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
                        Console.WriteLine("비용:" + GlasswoolPrice.V8048Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.V8048Money[i]));
                        st = GlasswoolPrice.V8048Money[i];
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
                        Console.WriteLine("비용:" + GlasswoolPrice.V8064Money[i]);
                        itemList.Add(new PriceItem(i, GlasswoolPrice.V8064Money[i]));
                        st = GlasswoolPrice.V8064Money[i];
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

            sum = ((st + co) * Convert.ToInt32(V_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);

            ViewItem sty = new ViewItem(com, ki, di, itemList, itemList2, sum);
        }

        private void V_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
