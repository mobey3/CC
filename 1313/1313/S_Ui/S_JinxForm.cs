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

namespace _1313.ui
{
    public partial class S_JinxForm : MaterialForm
    {
        public S_JinxForm()
        {
            InitializeComponent();
        }

        private void J_S_btn_Click(object sender, EventArgs e)
        {
            string com = C_text.SelectedText;
            string ki = "징크";
            string di;

            UICheckBox[] checkBox1 = new UICheckBox[]
           {
                J_T_chk2, J_T_chk2, J_T_chk2, J_T_chk4, J_T_chk5,
                J_T_chk6, J_T_chk7, J_T_chk8, J_T_chk9
           };

            UICheckBox[] checkBox2 = new UICheckBox[]
            {
                J_C_chk1 , J_C_chk2
            };

            UICheckBox[] checkBox3 = new UICheckBox[]
            {
                J_D_chk1 , J_D_chk2
            };

            string Leg = J_L_Text.Text;

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
                            Console.WriteLine("비용:" + StyrofoamPrice.JinxMoney[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.JinxMoney[i]));
                            st = StyrofoamPrice.JinxMoney[i];
                            break;
                        } 
                    }
                di = checkBox3[0].Text;
                }
                else
                {
                    for (int i = StyrofoamPrice.T50; i < StyrofoamPrice.T260 + 1; i++)
                    {
                        if (checkBox1[i].Checked)
                        {
                            Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            Console.WriteLine("비용:" + StyrofoamPrice.JinxMoney2[i]);
                            itemList.Add(new PriceItem(i, StyrofoamPrice.JinxMoney2[i]));
                            st = StyrofoamPrice.JinxMoney2[i];
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

            sum = ((st + co) * Convert.ToInt32(J_L_Text.Text));
            Console.WriteLine("총 비용: " + sum);

            ViewItem sty = new ViewItem(com, ki, di, itemList, itemList2, sum);
        }

        private void J_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
