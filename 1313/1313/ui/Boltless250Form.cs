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
    public partial class Boltless250Form : MaterialForm
    {
        public Boltless250Form()
        {
            InitializeComponent();
        }

        private void B250_S_btn_Click(object sender, EventArgs e)
        {
            UICheckBox[] checkBox1 = new UICheckBox[]
           {
                B250_T_chk1, B250_T_chk2, B250_T_chk3, B250_T_chk4, B250_T_chk5,
                B250_T_chk6, B250_T_chk7, B250_T_chk8, B250_T_chk9
           };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                B250_C_chk1 , B250_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                B250_D_chk1 , B250_D_chk2
            };

            string Leg = B250_L_Text.Text;

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
                            Console.WriteLine("비용:" + StyrofoamPrice.Boltless250Money[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.Boltless250Money[i]));
                            st = StyrofoamPrice.Boltless250Money[i];
                            break;
                        }
                        break;
                    }
                }

                if (checkBox3[1].Checked)
                {
                    for (int i = StyrofoamPrice.T50; i < StyrofoamPrice.T260 + 1; i++)
                    {
                        if (checkBox1[i].Checked)
                        {
                            Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            Console.WriteLine("비용:" + StyrofoamPrice.BoltlessMoney2[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.BoltlessMoney2[i]));
                            st = StyrofoamPrice.BoltlessMoney2[i];
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

            sum = ((st + co) * Convert.ToInt32(B250_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);
        }

        private void B_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
