
namespace carFixMgr0611
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.custFixView = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdmin = new CxFlatUI.CxFlatRoundButton();
            this.custFixRand = new CxFlatUI.CxFlatRoundButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custFixinfo = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.InitialImage = null;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(0, 64);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(400, 501);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // custFixView
            // 
            this.custFixView.BackColor = System.Drawing.Color.Transparent;
            this.custFixView.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixView.Location = new System.Drawing.Point(472, 215);
            this.custFixView.Name = "custFixView";
            this.custFixView.Size = new System.Drawing.Size(238, 61);
            this.custFixView.TabIndex = 2;
            this.custFixView.Text = "수리 내역";
            this.custFixView.TextColor = System.Drawing.Color.White;
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.ButtonType = CxFlatUI.ButtonType.Danger;
            this.custFixAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(472, 299);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(238, 61);
            this.custFixAdmin.TabIndex = 3;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.TextColor = System.Drawing.Color.White;
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custFixRand
            // 
            this.custFixRand.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixRand.Location = new System.Drawing.Point(472, 390);
            this.custFixRand.Name = "custFixRand";
            this.custFixRand.Size = new System.Drawing.Size(238, 61);
            this.custFixRand.TabIndex = 4;
            this.custFixRand.Text = "랜덤 데이터 추가";
            this.custFixRand.TextColor = System.Drawing.Color.White;
            this.custFixRand.Click += new System.EventHandler(this.custFixRand_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Red;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainExit.ForeHoverColor = System.Drawing.Color.HotPink;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(700, 34);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(92, 59);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 48;
            this.mainExit.TabIndex = 6;
            this.mainExit.TipsColor = System.Drawing.Color.Transparent;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.ForeDisableColor = System.Drawing.Color.White;
            this.custFixAdd.ForeHoverColor = System.Drawing.Color.Gold;
            this.custFixAdd.Location = new System.Drawing.Point(472, 126);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.Size = new System.Drawing.Size(238, 61);
            this.custFixAdd.Style = Sunny.UI.UIStyle.Custom;
            this.custFixAdd.Symbol = 61447;
            this.custFixAdd.TabIndex = 7;
            this.custFixAdd.Text = "고객정보 접수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(47, 1);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(288, 57);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 57398;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.SymbolSize = 38;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // custFixinfo
            // 
            this.custFixinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixinfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixinfo.ForeHoverColor = System.Drawing.Color.Gold;
            this.custFixinfo.Location = new System.Drawing.Point(472, 480);
            this.custFixinfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixinfo.Name = "custFixinfo";
            this.custFixinfo.Size = new System.Drawing.Size(238, 61);
            this.custFixinfo.Style = Sunny.UI.UIStyle.Custom;
            this.custFixinfo.Symbol = 61459;
            this.custFixinfo.TabIndex = 9;
            this.custFixinfo.Text = "앱 정보";
            this.custFixinfo.Click += new System.EventHandler(this.custFixInfo_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 565);
            this.ControlBox = false;
            this.Controls.Add(this.custFixinfo);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custFixRand);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton custFixView;
        private CxFlatUI.CxFlatRoundButton custFixAdmin;
        private CxFlatUI.CxFlatRoundButton custFixRand;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton custFixinfo;
    }
}

