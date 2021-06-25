﻿using _1313.model;
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
    public partial class WallForm : MaterialForm
    {
        public WallForm()
        {
            InitializeComponent();
        }

        private void W_S_btn_Click(object sender, EventArgs e)
        {
            UICheckBox[] checkBox1 = new UICheckBox[]
            {
                W_T_chk1, W_T_chk2, W_T_chk3, W_T_chk4, W_T_chk5,
                W_T_chk6, W_T_chk7, W_T_chk8, W_T_chk9
            };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                W_C_chk1 , W_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                W_D_chk1 , W_D_chk2
            };

            string Leg = W_L_Text.Text;

            int sum = 0;
            int st = 0;
            int co = 0;

            List<PriceItem> itemList = new List<PriceItem>();
            
                if (checkBox3[0].Checked)
                {
                    for (int i = StyrofoamPrice.T50; i < StyrofoamPrice.T260 + 1; i++)
                    {
                        if (checkBox1[i].Checked)
                        {
                            Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            Console.WriteLine("비용:" + StyrofoamPrice.WallMoney[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.WallMoney[i]));
                            st = StyrofoamPrice.WallMoney[i];
                            break;
                        }
                    }
                }
           
                if(checkBox3[1].Checked)
                {
                    for (int i = StyrofoamPrice.T50; i < StyrofoamPrice.T260 + 1; i++)
                    {
                        if (checkBox1[i].Checked)
                        {
                            Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            Console.WriteLine("비용:" + StyrofoamPrice.WallMoney2[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.WallMoney2[i]));
                            st = StyrofoamPrice.WallMoney2[i];
                            break;
                        }
                    }
                }
            

            List<PriceItem> itemList2 = new List<PriceItem>();

            for (int j = 0;j < 2; j++)
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

            sum = ((st + co) * Convert.ToInt32(W_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);

        }

        private void W_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}