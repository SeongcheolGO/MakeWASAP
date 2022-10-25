namespace NewNotebook
{
  partial class PrintInfo
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
      this.PrintInfomation = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.PrintAllInfo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // PrintInfomation
      // 
      this.PrintInfomation.Location = new System.Drawing.Point(12, 39);
      this.PrintInfomation.Multiline = true;
      this.PrintInfomation.Name = "PrintInfomation";
      this.PrintInfomation.Size = new System.Drawing.Size(776, 399);
      this.PrintInfomation.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(123, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 21);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(301, 12);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 21);
      this.textBox2.TabIndex = 2;
      // 
      // PrintAllInfo
      // 
      this.PrintAllInfo.BackColor = System.Drawing.SystemColors.Info;
      this.PrintAllInfo.Location = new System.Drawing.Point(713, 10);
      this.PrintAllInfo.Name = "PrintAllInfo";
      this.PrintAllInfo.Size = new System.Drawing.Size(75, 23);
      this.PrintAllInfo.TabIndex = 3;
      this.PrintAllInfo.Text = "출력";
      this.PrintAllInfo.UseVisualStyleBackColor = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label1.Location = new System.Drawing.Point(34, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 4;
      this.label1.Text = "검침년월";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label2.Location = new System.Drawing.Point(229, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 12);
      this.label2.TabIndex = 5;
      this.label2.Text = "검침원";
      // 
      // PrintInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.PrintAllInfo);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.PrintInfomation);
      this.Name = "PrintInfo";
      this.Text = "출력";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox PrintInfomation;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button PrintAllInfo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}