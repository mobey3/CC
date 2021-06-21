
namespace _1313
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.panel_Usage = new Sunny.UI.UIComboBox();
            this.uiComboBox9 = new Sunny.UI.UIComboBox();
            this.panel_Th = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel10 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel11 = new Sunny.UI.UISymbolLabel();
            this.uiComboBox25 = new Sunny.UI.UIComboBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.panel_kinds = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(43, 337);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(1030, 247);
            this.uiDataGridView1.TabIndex = 0;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(916, 152);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.Size = new System.Drawing.Size(99, 29);
            this.uiTextBox2.TabIndex = 2;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Usage
            // 
            this.panel_Usage.FillColor = System.Drawing.Color.White;
            this.panel_Usage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.panel_Usage.Location = new System.Drawing.Point(238, 152);
            this.panel_Usage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Usage.MinimumSize = new System.Drawing.Size(63, 0);
            this.panel_Usage.Name = "panel_Usage";
            this.panel_Usage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.panel_Usage.Size = new System.Drawing.Size(85, 29);
            this.panel_Usage.TabIndex = 7;
            this.panel_Usage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox9
            // 
            this.uiComboBox9.FillColor = System.Drawing.Color.White;
            this.uiComboBox9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox9.Location = new System.Drawing.Point(505, 152);
            this.uiComboBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox9.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox9.Name = "uiComboBox9";
            this.uiComboBox9.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox9.Size = new System.Drawing.Size(85, 29);
            this.uiComboBox9.TabIndex = 11;
            this.uiComboBox9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Th
            // 
            this.panel_Th.FillColor = System.Drawing.Color.White;
            this.panel_Th.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.panel_Th.Location = new System.Drawing.Point(635, 152);
            this.panel_Th.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Th.MinimumSize = new System.Drawing.Size(63, 0);
            this.panel_Th.Name = "panel_Th";
            this.panel_Th.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.panel_Th.Size = new System.Drawing.Size(85, 29);
            this.panel_Th.TabIndex = 14;
            this.panel_Th.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(84, 77);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(107, 29);
            this.uiSymbolLabel6.TabIndex = 25;
            this.uiSymbolLabel6.Text = "종류";
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(347, 77);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(114, 29);
            this.uiSymbolLabel7.TabIndex = 26;
            this.uiSymbolLabel7.Text = "길이(mm)";
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.Location = new System.Drawing.Point(505, 77);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(85, 29);
            this.uiSymbolLabel8.TabIndex = 27;
            this.uiSymbolLabel8.Text = "골";
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel9.Location = new System.Drawing.Point(635, 77);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(85, 29);
            this.uiSymbolLabel9.TabIndex = 28;
            this.uiSymbolLabel9.Text = "두께";
            // 
            // uiSymbolLabel10
            // 
            this.uiSymbolLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel10.Location = new System.Drawing.Point(916, 77);
            this.uiSymbolLabel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel10.Name = "uiSymbolLabel10";
            this.uiSymbolLabel10.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel10.Size = new System.Drawing.Size(99, 29);
            this.uiSymbolLabel10.TabIndex = 29;
            this.uiSymbolLabel10.Text = "갯수";
            // 
            // uiSymbolLabel11
            // 
            this.uiSymbolLabel11.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel11.Location = new System.Drawing.Point(782, 77);
            this.uiSymbolLabel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel11.Name = "uiSymbolLabel11";
            this.uiSymbolLabel11.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel11.Size = new System.Drawing.Size(85, 29);
            this.uiSymbolLabel11.TabIndex = 35;
            this.uiSymbolLabel11.Text = "색상";
            // 
            // uiComboBox25
            // 
            this.uiComboBox25.FillColor = System.Drawing.Color.White;
            this.uiComboBox25.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox25.Items.AddRange(new object[] {
            "내벽용",
            "외벽용",
            "지붕용"});
            this.uiComboBox25.Location = new System.Drawing.Point(782, 152);
            this.uiComboBox25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox25.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox25.Name = "uiComboBox25";
            this.uiComboBox25.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox25.Size = new System.Drawing.Size(85, 29);
            this.uiComboBox25.TabIndex = 32;
            this.uiComboBox25.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(313, 245);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(114, 43);
            this.uiSymbolButton1.TabIndex = 38;
            this.uiSymbolButton1.Text = "추가";
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(643, 245);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(114, 43);
            this.uiSymbolButton2.TabIndex = 39;
            this.uiSymbolButton2.Text = "제거";
            // 
            // panel_kinds
            // 
            this.panel_kinds.FillColor = System.Drawing.Color.White;
            this.panel_kinds.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.panel_kinds.Items.AddRange(new object[] {
            "EPS",
            "PUR",
            "GlassWool"});
            this.panel_kinds.Location = new System.Drawing.Point(84, 152);
            this.panel_kinds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_kinds.MinimumSize = new System.Drawing.Size(63, 0);
            this.panel_kinds.Name = "panel_kinds";
            this.panel_kinds.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.panel_kinds.Size = new System.Drawing.Size(107, 29);
            this.panel_kinds.TabIndex = 8;
            this.panel_kinds.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(238, 77);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(85, 29);
            this.uiSymbolLabel1.TabIndex = 40;
            this.uiSymbolLabel1.Text = "용도";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(366, 152);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(85, 29);
            this.uiComboBox1.TabIndex = 12;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 630);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.panel_kinds);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiSymbolLabel11);
            this.Controls.Add(this.uiComboBox25);
            this.Controls.Add(this.uiSymbolLabel10);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.panel_Th);
            this.Controls.Add(this.uiComboBox9);
            this.Controls.Add(this.panel_Usage);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UIComboBox panel_Usage;
        private Sunny.UI.UIComboBox uiComboBox9;
        private Sunny.UI.UIComboBox panel_Th;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UISymbolLabel uiSymbolLabel10;
        private Sunny.UI.UISymbolLabel uiSymbolLabel11;
        private Sunny.UI.UIComboBox uiComboBox25;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIComboBox panel_kinds;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox uiComboBox1;
    }
}

