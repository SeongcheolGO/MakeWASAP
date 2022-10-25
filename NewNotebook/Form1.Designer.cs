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
      this.SuspendLayout();
      // 
      // trans
      // 
      this.trans.Location = new System.Drawing.Point(18, 21);
      this.trans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.trans.Name = "trans";
      this.trans.Size = new System.Drawing.Size(135, 110);
      this.trans.TabIndex = 0;
      this.trans.Text = "전송";
      this.trans.UseVisualStyleBackColor = true;
      this.trans.Click += new System.EventHandler(this.trans_Click);
      // 
      // Error
      // 
      this.Error.Location = new System.Drawing.Point(689, 21);
      this.Error.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Error.Name = "Error";
      this.Error.Size = new System.Drawing.Size(175, 46);
      this.Error.TabIndex = 1;
      this.Error.Text = "오류창";
      this.Error.UseVisualStyleBackColor = true;
      this.Error.Click += new System.EventHandler(this.Error_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(161, 21);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(135, 110);
      this.button1.TabIndex = 2;
      this.button1.Text = "PDA 정보";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // InfomationCorrection
      // 
      this.InfomationCorrection.Location = new System.Drawing.Point(303, 21);
      this.InfomationCorrection.Name = "InfomationCorrection";
      this.InfomationCorrection.Size = new System.Drawing.Size(135, 110);
      this.InfomationCorrection.TabIndex = 3;
      this.InfomationCorrection.Text = "정보 입력";
      this.InfomationCorrection.UseVisualStyleBackColor = true;
      this.InfomationCorrection.Click += new System.EventHandler(this.InfomationCorrection_Click);
      // 
      // TransPda
      // 
      this.TransPda.Location = new System.Drawing.Point(729, 403);
      this.TransPda.Name = "TransPda";
      this.TransPda.Size = new System.Drawing.Size(135, 110);
      this.TransPda.TabIndex = 4;
      this.TransPda.Text = "PCtoPDA";
      this.TransPda.UseVisualStyleBackColor = true;
      // 
      // TransPc
      // 
      this.TransPc.Location = new System.Drawing.Point(729, 287);
      this.TransPc.Name = "TransPc";
      this.TransPc.Size = new System.Drawing.Size(135, 110);
      this.TransPc.TabIndex = 5;
      this.TransPc.Text = "PDAtoPC";
      this.TransPc.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(880, 525);
      this.Controls.Add(this.TransPc);
      this.Controls.Add(this.TransPda);
      this.Controls.Add(this.InfomationCorrection);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.Error);
      this.Controls.Add(this.trans);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Practice";
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trans;
        private System.Windows.Forms.Button Error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InfomationCorrection;
        private System.Windows.Forms.Button TransPda;
        private System.Windows.Forms.Button TransPc;
    }
}

