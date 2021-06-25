using _1313.model;
using _1313.PanelTable;
using _1313.RepairTable;
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

namespace _1313.ui
{
    public partial class S_TreeForm : MaterialForm
    {
        public S_TreeForm()
        {
            InitializeComponent();
        }

        private void T_S_btn_Click(object sender, EventArgs e)
        {
            UICheckBox[] checkBox1 = new UICheckBox[]
          {
                T_T_chk1, T_T_chk2, T_T_chk3, T_T_chk4,
                T_T_chk5, T_T_chk6, T_T_chk7 
          };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                T_C_chk1 , T_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                M_D_chk1 , M_D_chk2
            };

            string Leg = T_L_Text.Text;

            int sum = 0;
            int st = 0;
            int co = 0;

            List<PriceItem> itemList = new List<PriceItem>();

            if (checkBox3[0].Checked)
            {
                for (int i = StyrofoamPrice.T75; i < StyrofoamPrice.T260 + 1; i++)
                {
                    if (checkBox1[i].Checked)
                    {
                        Console.WriteLine("구매항목:" + checkBox1[i].Text);
                        Console.WriteLine("비용:" + StyrofoamPrice.TreeMoney[i]);
                        itemList.Add(new PriceItem(i, StyrofoamPrice.TreeMoney[i]));
                        st = StyrofoamPrice.TreeMoney[i];
                        break;
                    }
                    break;
                }
            }
            if (checkBox3[1].Checked)
            {
                for (int i = StyrofoamPrice.T75; i < StyrofoamPrice.T260 + 1; i++)
                {
                    if (checkBox1[i].Checked)
                    {
                        Console.WriteLine("구매항목:" + checkBox1[i].Text);
                        Console.WriteLine("비용:" + StyrofoamPrice.TreeMoney2[i]);
                        itemList.Add(new PriceItem(i, StyrofoamPrice.TreeMoney2[i]));
                        st = StyrofoamPrice.TreeMoney2[i];
                        break;
                    }
                }
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

            sum = ((st + co) * Convert.ToInt32(T_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);
        }

        private void T_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
