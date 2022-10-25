namespace NewNotebook
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
      this.trans = new System.Windows.Forms.Button();
      this.Error = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.InfomationCorrection = new System.Windows.Forms.Button();
      this.TransPda = new System.Windows.Forms.Button();
      this.TransPc = new System.Windows.Forms.Button();
      this.PrintInfo = new System.Windows.Forms.Button();
      this.printicon = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.printicon)).BeginInit();
      this.SuspendLayout();
      // 
      // trans
      // 
      this.trans.Location = new System.Drawing.Point(11, 12);
      this.trans.Margin = new System.Windows.Forms.Padding(2);
      this.trans.Name = "trans";
      this.trans.Size = new System.Drawing.Size(86, 63);
      this.trans.TabIndex = 0;
      this.trans.Text = "전송";
      this.trans.UseVisualStyleBackColor = true;
      this.trans.Click += new System.EventHandler(this.trans_Click);
      // 
      // Error
      // 
      this.Error.Location = new System.Drawing.Point(438, 12);
      this.Error.Margin = new System.Windows.Forms.Padding(2);
      this.Error.Name = "Error";
      this.Error.Size = new System.Drawing.Size(111, 26);
      this.Error.TabIndex = 1;
      this.Error.Text = "오류창";
      this.Error.UseVisualStyleBackColor = true;
      this.Error.Click += new System.EventHandler(this.Error_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(102, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(86, 63);
      this.button1.TabIndex = 2;
      this.button1.Text = "PDA 정보";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // InfomationCorrection
      // 
      this.InfomationCorrection.Location = new System.Drawing.Point(193, 12);
      this.InfomationCorrection.Margin = new System.Windows.Forms.Padding(2);
      this.InfomationCorrection.Name = "InfomationCorrection";
      this.InfomationCorrection.Size = new System.Drawing.Size(86, 63);
      this.InfomationCorrection.TabIndex = 3;
      this.InfomationCorrection.Text = "정보 입력";
      this.InfomationCorrection.UseVisualStyleBackColor = true;
      this.InfomationCorrection.Click += new System.EventHandler(this.InfomationCorrection_Click);
      // 
      // TransPda
      // 
      this.TransPda.Location = new System.Drawing.Point(464, 230);
      this.TransPda.Margin = new System.Windows.Forms.Padding(2);
      this.TransPda.Name = "TransPda";
      this.TransPda.Size = new System.Drawing.Size(86, 63);
      this.TransPda.TabIndex = 4;
      this.TransPda.Text = "PCtoPDA";
      this.TransPda.UseVisualStyleBackColor = true;
      // 
      // TransPc
      // 
      this.TransPc.Location = new System.Drawing.Point(464, 164);
      this.TransPc.Margin = new System.Windows.Forms.Padding(2);
      this.TransPc.Name = "TransPc";
      this.TransPc.Size = new System.Drawing.Size(86, 63);
      this.TransPc.TabIndex = 5;
      this.TransPc.Text = "PDAtoPC";
      this.TransPc.UseVisualStyleBackColor = true;
      // 
      // PrintInfo
      // 
      this.PrintInfo.Location = new System.Drawing.Point(284, 12);
      this.PrintInfo.Name = "PrintInfo";
      this.PrintInfo.Size = new System.Drawing.Size(86, 63);
      this.PrintInfo.TabIndex = 6;
      this.PrintInfo.Text = "출력";
      this.PrintInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.PrintInfo.UseVisualStyleBackColor = true;
      this.PrintInfo.Click += new System.EventHandler(this.PrintInfo_Click);
      // 
      // printicon
      // 
      this.printicon.BackColor = System.Drawing.SystemColors.Control;
      this.printicon.Image = global::NewNotebook.Properties.Resources.printicon;
      this.printicon.Location = new System.Drawing.Point(294, 24);
      this.printicon.Name = "printicon";
      this.printicon.Size = new System.Drawing.Size(42, 35);
      this.printicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.printicon.TabIndex = 7;
      this.printicon.TabStop = false;
      this.printicon.Click += new System.EventHandler(this.printicon_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 300);
      this.Controls.Add(this.printicon);
      this.Controls.Add(this.PrintInfo);
      this.Controls.Add(this.TransPc);
      this.Controls.Add(this.TransPda);
      this.Controls.Add(this.InfomationCorrection);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.Error);
      this.Controls.Add(this.trans);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Practice";
      ((System.ComponentModel.ISupportInitialize)(this.printicon)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trans;
        private System.Windows.Forms.Button Error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InfomationCorrection;
        private System.Windows.Forms.Button TransPda;
        private System.Windows.Forms.Button TransPc;
    private System.Windows.Forms.Button PrintInfo;
    private System.Windows.Forms.PictureBox printicon;
  }
}

