using _1313.model;
using _1313.PanelTable;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _1313.ui
{
    public partial class S_WallForm : MaterialForm
    {
        public S_WallForm()
        {
            InitializeComponent();
        }

        private void W_S_btn_Click(object sender, EventArgs e)
        {
            string com = C_text.SelectedText;
            string ki = "벽체";
            string di;

            
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("회사명");
            dt.Columns.Add("종류");
            dt.Columns.Add("구분");
            dt.Columns.Add("두께");
            dt.Columns.Add("색상");
            dt.Columns.Add("총견적");

            DataRow dr = dt.NewRow();
           


            dr["회사명"] = C_text;
            dr["종류"] = ki;

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
                            //Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            //Console.WriteLine("비용:" + StyrofoamPrice.WallMoney[i]);
                            itemList.Add(new PriceItem(checkBox1[i].Text));
                            st = StyrofoamPrice.WallMoney[i];
                            dr["두께"] = checkBox1[i].Text;
                            break;
                        }
                    }
                
                di = checkBox3[0].Text;
                dr["구분"] = di;
                }
           
                else
                {
                    for (int i = StyrofoamPrice.T50; i < StyrofoamPrice.T260 + 1; i++)
                    {
                        if (checkBox1[i].Checked)
                        {
                            //Console.WriteLine("구매항목:" + checkBox1[i].Text);
                            //Console.WriteLine("비용:" + StyrofoamPrice.WallMoney2[i]);
                            itemList.Add(new PriceItem(checkBox1[i].Text));
                            st = StyrofoamPrice.WallMoney2[i];
                            dr["두께"] = checkBox1[i].Text;
                            break;
                        }
                    }
                    di = checkBox3[1].Text;
                    dr["구분"] = di;
                }
            

            List<PriceItem> itemList2 = new List<PriceItem>();
            
            for (int j = 0;j < 2; j++)
            {
                if (checkBox2[j].Checked)
                {
                    //Console.WriteLine("구매항목:" + checkBox2[j].Text);
                    //Console.WriteLine("추가비용:" + ColorPrice.ColorMoney[j]);
                    itemList2.Add(new PriceItem(checkBox2[j].Text));
                    co = ColorPrice.ColorMoney[j];
                    dr["색상"] = checkBox2[j].Text;
                    break;
                }
            }

            sum = ((st + co) * Convert.ToInt32(W_L_Text.Text));
           //Console.WriteLine("총 비용: " + sum);
            dr["총견적"] = sum;

            ViewItem sty = new ViewItem(com, ki, di, itemList, itemList2, sum);

            Console.WriteLine(sty);
        }

       

        private void W_C_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
