﻿using carFixMgr0611.conmon;
using carFixMgr0611.handler;
using carFixMgr0611.model;
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
    partial class ReceiptView : MaterialForm
    {
        ReceiptAdapter adapter;
        List<ReceiptVO> receiptList;

        public ReceiptView()
        {
            InitializeComponent();
        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void initList(List<ReceiptVO> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
              string strPrice =
              string.Format("{0:#,0}원", list[i].TotalPrice);
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].Indate,
                        strPrice, 
                        list[i].StaffName,
                        list[i].CarNum,
                        list[i].CustName
                    }
                    ));
            }
            CommUtil.setRowColor(viewList, Color.LightBlue, Color.LightSkyBlue);
            if (viewList.Items.Count > 0)
            {
                int index = viewList.Items.Count - 1;
                viewList.Items[index].Selected = true;
                viewList.Items[index].Focused = true;
                viewList.EnsureVisible(index);
            }
        }

        public void initGrid()
        {
            string strPrice =
                string.Format("{0:#,0}원", 80000);
            string[] data = { "1", "엔진오일 교환", strPrice };
            viewGrid.Rows.Add(data);

            for (int i = 0; i < 50; i++)
            {
                viewGrid.Rows.Add(new string[]
                {
                    (i+2).ToString(), "부동액 교환", strPrice
                });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell =
                viewGrid.Rows[count - 1].Cells[0];
        }


        public void initGrid(List<RepairItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice =
                string.Format("{0:#,0}원", list[i].Price);
                viewGrid.Rows.Add(new string[]
                {
                    (i+1).ToString(), list[i].Repair, strPrice
                });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell =
            viewGrid.Rows[count - 1].Cells[0];
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            CommUtil.colorListViewHeader(ref viewList,
                Color.Black, Color.Gray);
            receiptList = adapter.getReceiptVoDb();
            initList(receiptList);
            initGrid();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(viewList.SelectedItems.Count != 0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string carNum = viewList.Items[n].SubItems[4].Text;
                string cust = viewList.Items[n].SubItems[5].Text;
                Console.WriteLine("번호: " + num);
                Console.WriteLine("접수날짜: " + date);
                Console.WriteLine("총결제금액: " + price);
                Console.WriteLine("담당자: " + staff);
                Console.WriteLine("차량번호: " + carNum);
                int receiptid = receiptList[n].ReceiptId;
                Console.WriteLine("접수ID: " + receiptid);
                Console.WriteLine("고객명: " + cust);

                List<RepairItem> list = adapter.GetRepairItemsDb(receiptid);
                viewGrid.ClearRows();
                initGrid(list);
                for(int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("수리항목: " + list[i].Repair);
                    Console.WriteLine("수리비: " + list[i].Price);
                }

            }
        }

        private void vSearchItem_Click(object sender, EventArgs e)
        {
            string item = viewSelect.SelectedText;
            string value = viewSearch.Text;
            if(item.Equals("")|| item.Equals("검색항목 선택")||
                value.Equals("")) 
            {
                MessageBox.Show("정확한 검색어를 입력하세요.");
                return;
            }
            else
            {
                switch (item)
                {
                    case "접수고객명":
                        item = "cust_name";
                        break;
                    case "접수차량번호":
                        item = "car_num";
                        break;
                }
            }
            List<ReceiptVO> list = 
                adapter.getReceiptDbBysearch(item,value);
            viewList.Items.Clear();
            initList(list);
         
        }

        private void vSearchAll_Click(object sender, EventArgs e)
        {
            viewList.Items.Clear();
            initList(receiptList);
            viewSelect.SelectedIndex = -1;
            viewSelect.Text = "검색항목 선택";
            viewSearch.Text = "";
        }
    }
}
