namespace NewNotebook
{
    partial class PdaInfo
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "PDA 모델";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(177, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "Andriod 버전 : 7. 1. 2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(177, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 12);
      this.label3.TabIndex = 3;
      this.label3.Text = "커널버전 : 3. 18.31";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(177, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(127, 12);
      this.label4.TabIndex = 4;
      this.label4.Text = "일련번호 : 18193A0209";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(177, 147);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(182, 12);
      this.label5.TabIndex = 5;
      this.label5.Text = "빌드 번호 : 45.00 (MAY 31 2018)";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(177, 116);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(241, 12);
      this.label6.TabIndex = 6;
      this.label6.Text = "안드로이드 보안 패치 수준 : 2018년 5월 5일";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(383, 167);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(65, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "확인";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::NewNotebook.Properties.Resources.Image;
      this.pictureBox1.Location = new System.Drawing.Point(25, 23);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 164);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // PdaInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 198);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "PdaInfo";
      this.Text = "PDA 정보";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}