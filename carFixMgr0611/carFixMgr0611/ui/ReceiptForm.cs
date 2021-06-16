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

namespace carFixMgr0611.ui
{
    public partial class ReceiptForm : MaterialForm
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string custyear = custYear.SelectedText;
            string custmonth = custMonth.SelectedText;
            string custday = custDay.SelectedText;
            string model = carModel.SelectedText;
            string number = carNum.Text;
            string cc = carCc.SelectedText;
            string year = carYear.Text;
            string staffname = staffName.SelectedText;
            bool ck1 = chk1.Checked;
            bool ck2 = chk2.Checked;
            bool ck3 = chk3.Checked;
            bool ck4 = chk4.Checked;
            bool ck5 = chk5.Checked;
            bool ck6 = chk6.Checked;
            bool ck7 = chk7.Checked;
            bool ck8 = chk8.Checked;
            bool ck9 = chk9.Checked;
            bool[] a = new bool[] { ck1, ck2, ck3, ck4, ck5, ck6, ck7, ck8, ck9 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == true)
                {
                    switch (i)


                }
            }
            if (name.Equals(""))
            {
                Console.WriteLine("고객이름 누락");
            }

           

            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화번호: " + (telH + telB));
            Console.WriteLine("생년월일: " + (custyear + custmonth + custday));
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + number);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + year);
            Console.WriteLine("담당자: " + staffname);
            Console.WriteLine("수리내역: " + a);

            Close();
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
