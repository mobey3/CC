
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.Sty_Estimate = new Sunny.UI.UISymbolButton();
            this.Wool_Estimate = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-2, 144);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(570, 474);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 1;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // cxFlatPictureBox2
            // 
            this.cxFlatPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox2.Image")));
            this.cxFlatPictureBox2.Location = new System.Drawing.Point(566, 144);
            this.cxFlatPictureBox2.Name = "cxFlatPictureBox2";
            this.cxFlatPictureBox2.Size = new System.Drawing.Size(563, 474);
            this.cxFlatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox2.TabIndex = 2;
            this.cxFlatPictureBox2.TabStop = false;
            // 
            // Sty_Estimate
            // 
            this.Sty_Estimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sty_Estimate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Sty_Estimate.Location = new System.Drawing.Point(-2, 617);
            this.Sty_Estimate.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sty_Estimate.Name = "Sty_Estimate";
            this.Sty_Estimate.Size = new System.Drawing.Size(570, 84);
            this.Sty_Estimate.Symbol = 61785;
            this.Sty_Estimate.TabIndex = 5;
            this.Sty_Estimate.Text = "견적뽑기";
            this.Sty_Estimate.Click += new System.EventHandler(this.Sty_Estimate_Click);
            // 
            // Wool_Estimate
            // 
            this.Wool_Estimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wool_Estimate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Wool_Estimate.Location = new System.Drawing.Point(566, 617);
            this.Wool_Estimate.MinimumSize = new System.Drawing.Size(1, 1);
            this.Wool_Estimate.Name = "Wool_Estimate";
            this.Wool_Estimate.Size = new System.Drawing.Size(563, 84);
            this.Wool_Estimate.Symbol = 61785;
            this.Wool_Estimate.TabIndex = 6;
            this.Wool_Estimate.Text = "견적뽑기";
            this.Wool_Estimate.Click += new System.EventHandler(this.Wool_Estimate_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(-2, 63);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(570, 81);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "스티로폼";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(566, 63);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(566, 81);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "그라스울";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 699);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Wool_Estimate);
            this.Controls.Add(this.Sty_Estimate);
            this.Controls.Add(this.cxFlatPictureBox2);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox2;
        private Sunny.UI.UISymbolButton Sty_Estimate;
        private Sunny.UI.UISymbolButton Wool_Estimate;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}

