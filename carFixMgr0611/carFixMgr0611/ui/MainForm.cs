using carFixMgr0611.conmon;
using carFixMgr0611.handler;
using carFixMgr0611.ui;
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

namespace carFixMgr0611
{
    public partial class MainForm1 : MaterialForm
    {
        OraHandler ora = new OraHandler();
        ReceiptAdapter adapter = new ReceiptAdapter();

        public MainForm1()
        {
            InitializeComponent();
            CommUtil.initTheme(this);              
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm().ShowDialog();
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            new HistoryForm().ShowDialog();
        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custFixInfo_Click(object sender, EventArgs e)
        {

        }

        private void MainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
