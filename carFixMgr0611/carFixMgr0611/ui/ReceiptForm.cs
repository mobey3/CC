using carFixMgr0611.handler;
using carFixMgr0611.model;
using carFixMgr0611.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptForm : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
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
            string year = carYear.SelectedText;
            string staffname = staffName.SelectedText;


            /* if (name.Equals(""))
             {
                 MessageBox.Show("이름을 입력하세요.");
                 ActiveControl = custName;
                 custName.Focus();
                 return;
             }
             if (telH.Equals("")) 
             {
                 MessageBox.Show("전화번호 앞자리를 선택하세요");
                 ActiveControl = custTelH;
                 custTelH.Focus();
                 return;
             }

             if (telB.Length != 8)
             {
                 MessageBox.Show("전화번호를 잘못 입력하셨습니다.");
                 ActiveControl = custTelB;
                 custTelB.Focus();
                 return;
             }

             if (custyear.Equals(""))
             {
                 MessageBox.Show("생년을 선택하세요.");
             }*/

            string[] arrData = new string[]
            {
                name, telH, telB, custyear, custmonth, custday,
                model, number, cc, year, staffname
            };

            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear, custMonth, custDay,
                carModel, carNum, carCc, carYear,staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요","전화번호 앞자리를 선택하세요","전화번호를 잘못 입력했습니다",
                "년도를 선택하세요","월을 선택하세요","일일을 선택하세요","차량 모델을 선택하세요",
                "차량 번호를 입력하세요","차량 배기량을 선택하세요","차량 연식을 선택하세요",
                "담당자를 선택하세요"
            };

/*            List<Receipt> ReList = new List<Receipt>();

            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("")
                    || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i]);
                    ActiveControl = arrObj[i] as Control; // 하이캐스팅
                    ActiveControl.Focus();
                    custName.Text = "";
                    return;
                }
            }*/

            Dictionary<object, string> dicInput =
                new Dictionary<object, string>();

            for(int i = 0; i < arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            foreach(KeyValuePair<object,string> item in dicInput)
            {
                if(item.Value.Equals("") || item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, arrMsg[cnt]);
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox = new UICheckBox[]
            {
                chk1,chk2,chk3,chk4,chk5,
                chk6,chk7,chk8,chk9,chk10
            };


            // ↓ 컬렉션 클래스 <제네릭 or 범용데이터> 
            int sum = 0;
            List<RepairItem> itemList = new List< RepairItem > ();
            for (int i = RepairTable.ENGINE_OIL;
                i < RepairTable.ETC_COST + 1; i++)
            {
                if (checkBox[i].Checked)
                {
                    Console.WriteLine("수리항목: " + checkBox[i].Text);
                    Console.WriteLine("수리비: " + RepairTable.fixMoney[i]);
                    itemList.Add(new RepairItem(i, checkBox[i].Text,
                                 RepairTable.fixMoney[i]));
                    sum += RepairTable.fixMoney[i];

                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }

            // 한글 입력 체크 
            // ↓ 정규 표현식
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_WRONG);
                return;
            }

           /* Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_SIZE);
                return;
            }*/

            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length ==11)
            {
                Regex regex2 = new Regex(@"01{1}[01]{1}[0-9]{8}");
                Match m2 = regex2.Match(telAll);
                if(m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }


            /*  for (int i = 0; i < checkBox.Length; i++)
              {
                  if(checkBox[i].Checked)
                  {
                      Console.WriteLine("수리항목: " + checkBox[i].Text);
                  }
              }*/

            /*Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화번호: " + (telH + telB));
            Console.WriteLine("생년월일: " + (custyear + custmonth + custday));
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + number);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + year);
            Console.WriteLine("담당자: " + staffname);*/

            adapter.addReceipt(new Receipt(
                new Customer(name,telH+telB, custyear+custmonth+custday),
                new Car(model,number,cc,year),
                DateTime.Now.ToString("yyyy년MM월dd일"),
                staffname,itemList,sum));

           

            Close();

        }
            private void setFocus(Control cont,string msg)
            {
                MessageBox.Show(msg);
                ActiveControl = cont;
                ActiveControl.Focus();
                cont.Text = "";
            }
    

        private void receiptClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
