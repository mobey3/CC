
namespace carFixMgr0611.ui
{
    partial class ReceiptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.vModify = new Sunny.UI.UISymbolButton();
            this.vConfirm = new Sunny.UI.UISymbolButton();
            this.vSearchItem = new Sunny.UI.UISymbolButton();
            this.viewSearch = new CxFlatUI.CxFlatTextBox();
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.gCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewList = new System.Windows.Forms.ListView();
            this.lCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vDelete = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.vSearchAll = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(125, 43);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiSymbolLabel3.SymbolSize = 36;
            this.uiSymbolLabel3.TabIndex = 13;
            this.uiSymbolLabel3.Text = "접수 내역";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(35, 85);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(111, 34);
            this.uiSymbolLabel1.Symbol = 61484;
            this.uiSymbolLabel1.TabIndex = 14;
            this.uiSymbolLabel1.Text = "검색항목";
            // 
            // viewSelect
            // 
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Items.AddRange(new object[] {
            "고객명"});
            this.viewSelect.Location = new System.Drawing.Point(172, 97);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.Size = new System.Drawing.Size(146, 29);
            this.viewSelect.TabIndex = 15;
            this.viewSelect.Text = "검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vModify
            // 
            this.vModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vModify.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.vModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vModify.Location = new System.Drawing.Point(507, 303);
            this.vModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.vModify.Name = "vModify";
            this.vModify.RectColor = System.Drawing.Color.MediumSeaGreen;
            this.vModify.Size = new System.Drawing.Size(106, 38);
            this.vModify.Style = Sunny.UI.UIStyle.Custom;
            this.vModify.Symbol = 61508;
            this.vModify.TabIndex = 21;
            this.vModify.Text = "수정";
            // 
            // vConfirm
            // 
            this.vConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vConfirm.Location = new System.Drawing.Point(395, 303);
            this.vConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.vConfirm.Name = "vConfirm";
            this.vConfirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vConfirm.Size = new System.Drawing.Size(106, 38);
            this.vConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.vConfirm.Symbol = 61639;
            this.vConfirm.TabIndex = 20;
            this.vConfirm.Text = "완료";
            // 
            // vSearchItem
            // 
            this.vSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.vSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchItem.FillColor = System.Drawing.Color.Transparent;
            this.vSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vSearchItem.ForeHoverColor = System.Drawing.Color.RoyalBlue;
            this.vSearchItem.ForePressColor = System.Drawing.Color.RoyalBlue;
            this.vSearchItem.ForeSelectedColor = System.Drawing.Color.RoyalBlue;
            this.vSearchItem.Location = new System.Drawing.Point(507, 90);
            this.vSearchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchItem.Name = "vSearchItem";
            this.vSearchItem.Size = new System.Drawing.Size(106, 38);
            this.vSearchItem.Style = Sunny.UI.UIStyle.Custom;
            this.vSearchItem.Symbol = 61454;
            this.vSearchItem.TabIndex = 19;
            this.vSearchItem.Text = "검색";
            // 
            // viewSearch
            // 
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSearch.Hint = "검색어을 입력하세요";
            this.viewSearch.Location = new System.Drawing.Point(325, 90);
            this.viewSearch.MaxLength = 32767;
            this.viewSearch.Multiline = false;
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.PasswordChar = '\0';
            this.viewSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewSearch.SelectedText = "";
            this.viewSearch.SelectionLength = 0;
            this.viewSearch.SelectionStart = 0;
            this.viewSearch.Size = new System.Drawing.Size(176, 38);
            this.viewSearch.TabIndex = 18;
            this.viewSearch.TabStop = false;
            this.viewSearch.UseSystemPasswordChar = false;
            // 
            // viewGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.ColumnHeadersHeight = 32;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gCount,
            this.gRepair,
            this.gPrice});
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(54, 406);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(672, 150);
            this.viewGrid.TabIndex = 17;
            // 
            // gCount
            // 
            this.gCount.HeaderText = "번호";
            this.gCount.Name = "gCount";
            // 
            // gRepair
            // 
            this.gRepair.HeaderText = "수리항목";
            this.gRepair.Name = "gRepair";
            // 
            // gPrice
            // 
            this.gPrice.HeaderText = "수리비용";
            this.gPrice.Name = "gPrice";
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lCount,
            this.linDate,
            this.lTotalPrice,
            this.lStaffName,
            this.lCustName});
            this.viewList.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewList.FullRowSelect = true;
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(54, 134);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(672, 163);
            this.viewList.TabIndex = 16;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            this.viewList.SelectedIndexChanged += new System.EventHandler(this.viewList_SelectedIndexChanged);
            // 
            // lCount
            // 
            this.lCount.Text = "번호";
            this.lCount.Width = 100;
            // 
            // linDate
            // 
            this.linDate.Text = "접수날짜";
            this.linDate.Width = 170;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.Text = "총결제금액";
            this.lTotalPrice.Width = 170;
            // 
            // lStaffName
            // 
            this.lStaffName.Text = "담당자";
            this.lStaffName.Width = 110;
            // 
            // lCustName
            // 
            this.lCustName.Text = "고객명";
            this.lCustName.Width = 110;
            // 
            // vDelete
            // 
            this.vDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vDelete.FillColor = System.Drawing.Color.DarkOrange;
            this.vDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vDelete.Location = new System.Drawing.Point(620, 303);
            this.vDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.vDelete.Name = "vDelete";
            this.vDelete.RectColor = System.Drawing.Color.DarkOrange;
            this.vDelete.Size = new System.Drawing.Size(106, 38);
            this.vDelete.Style = Sunny.UI.UIStyle.Custom;
            this.vDelete.Symbol = 62005;
            this.vDelete.TabIndex = 22;
            this.vDelete.Text = "삭제";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(54, 366);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(146, 34);
            this.uiSymbolLabel2.Symbol = 61613;
            this.uiSymbolLabel2.TabIndex = 23;
            this.uiSymbolLabel2.Text = "상세 수리내역";
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeColor = System.Drawing.Color.Yellow;
            this.mainExit.ForeHoverColor = System.Drawing.Color.HotPink;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(734, 12);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(43, 59);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 48;
            this.mainExit.TabIndex = 24;
            this.mainExit.TipsColor = System.Drawing.Color.Transparent;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // vSearchAll
            // 
            this.vSearchAll.BackColor = System.Drawing.Color.Transparent;
            this.vSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchAll.FillColor = System.Drawing.Color.Transparent;
            this.vSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vSearchAll.Location = new System.Drawing.Point(620, 90);
            this.vSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchAll.Name = "vSearchAll";
            this.vSearchAll.Size = new System.Drawing.Size(106, 38);
            this.vSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.vSearchAll.Symbol = 61442;
            this.vSearchAll.TabIndex = 25;
            this.vSearchAll.Text = "전체 검색";
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.ControlBox = false;
            this.Controls.Add(this.vSearchAll);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.vDelete);
            this.Controls.Add(this.vModify);
            this.Controls.Add(this.vConfirm);
            this.Controls.Add(this.vSearchItem);
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Name = "ReceiptView";
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox viewSelect;
        private Sunny.UI.UISymbolButton vModify;
        private Sunny.UI.UISymbolButton vConfirm;
        private Sunny.UI.UISymbolButton vSearchItem;
        private CxFlatUI.CxFlatTextBox viewSearch;
        private Sunny.UI.UIDataGridView viewGrid;
        private System.Windows.Forms.ListView viewList;
        private System.Windows.Forms.ColumnHeader lCount;
        private System.Windows.Forms.ColumnHeader linDate;
        private System.Windows.Forms.ColumnHeader lTotalPrice;
        private System.Windows.Forms.ColumnHeader lStaffName;
        private System.Windows.Forms.ColumnHeader lCustName;
        private Sunny.UI.UISymbolButton vDelete;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton vSearchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPrice;
    }
}