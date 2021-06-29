
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
            this.Sty_Estimate = new Sunny.UI.UISymbolButton();
            this.P_K_text = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // Sty_Estimate
            // 
            this.Sty_Estimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sty_Estimate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Sty_Estimate.Location = new System.Drawing.Point(272, 635);
            this.Sty_Estimate.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sty_Estimate.Name = "Sty_Estimate";
            this.Sty_Estimate.Size = new System.Drawing.Size(221, 40);
            this.Sty_Estimate.Symbol = 61785;
            this.Sty_Estimate.TabIndex = 5;
            this.Sty_Estimate.Text = "견적뽑기";
            this.Sty_Estimate.Click += new System.EventHandler(this.Sty_Estimate_Click);
            // 
            // P_K_text
            // 
            this.P_K_text.FillColor = System.Drawing.Color.White;
            this.P_K_text.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.P_K_text.Items.AddRange(new object[] {
            "스티로폼",
            "그라스울"});
            this.P_K_text.Location = new System.Drawing.Point(272, 509);
            this.P_K_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.P_K_text.MinimumSize = new System.Drawing.Size(63, 0);
            this.P_K_text.Name = "P_K_text";
            this.P_K_text.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.P_K_text.Size = new System.Drawing.Size(221, 29);
            this.P_K_text.TabIndex = 6;
            this.P_K_text.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 706);
            this.Controls.Add(this.P_K_text);
            this.Controls.Add(this.Sty_Estimate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton Sty_Estimate;
        private Sunny.UI.UIComboBox P_K_text;
    }
}

