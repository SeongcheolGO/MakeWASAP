namespace NewNotebook
{
  partial class InfoCor
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
      this.PdaText = new System.Windows.Forms.TextBox();
      this.PdaInput = new System.Windows.Forms.Button();
      this.FastClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PdaText
      // 
      this.PdaText.Location = new System.Drawing.Point(8, 7);
      this.PdaText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.PdaText.Multiline = true;
      this.PdaText.Name = "PdaText";
      this.PdaText.Size = new System.Drawing.Size(495, 211);
      this.PdaText.TabIndex = 0;
      // 
      // PdaInput
      // 
      this.PdaInput.Location = new System.Drawing.Point(355, 222);
      this.PdaInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.PdaInput.Name = "PdaInput";
      this.PdaInput.Size = new System.Drawing.Size(71, 30);
      this.PdaInput.TabIndex = 1;
      this.PdaInput.Text = "저장";
      this.PdaInput.UseVisualStyleBackColor = true;
      this.PdaInput.Click += new System.EventHandler(this.PdaInput_Click);
      // 
      // FastClose
      // 
      this.FastClose.Location = new System.Drawing.Point(431, 222);
      this.FastClose.Name = "FastClose";
      this.FastClose.Size = new System.Drawing.Size(71, 30);
      this.FastClose.TabIndex = 2;
      this.FastClose.Text = "취소";
      this.FastClose.UseVisualStyleBackColor = true;
      this.FastClose.Click += new System.EventHandler(this.FastClose_Click);
      // 
      // InfoCor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(509, 257);
      this.Controls.Add(this.FastClose);
      this.Controls.Add(this.PdaInput);
      this.Controls.Add(this.PdaText);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "InfoCor";
      this.Text = "WASAP 파일 작성";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox PdaText;
        private System.Windows.Forms.Button PdaInput;
    private System.Windows.Forms.Button FastClose;
  }
}