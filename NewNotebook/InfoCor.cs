using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace NewNotebook
{
  public partial class InfoCor : Form
  {
    string DataFileName = @"C:\PDApractice\WASAP.txt";
    DirectoryInfo di = new DirectoryInfo(@"C:\PDApractice");




    public InfoCor()
    {
      InitializeComponent();


      // @"C:\PDApractice" 파일 있는지 확인 후 없으면 생성 있으면 넘어감
      if (di.Exists == false)
      {
        di.Create();
      }


      // @"C:\PDApractice\WASAP" 파일을 확인해보고 있으면 파일을 읽어오고 없으면 생성
      if (CheckExistDataFile())
      {
        string text = ReadDataFile();
        PdaText.Text = text;
      }
      else
      {
        TouchDataFile();
      }

    }




    private bool CheckExistDataFile()
    {
      bool exist = File.Exists(DataFileName);
      return exist;
    }

    private string ReadDataFile()
    {
      string text = System.IO.File.ReadAllText(DataFileName);
      return text;
    }

    private void TouchDataFile()
    {
      File.WriteAllText(DataFileName, "");
    }

    private void WriteDataFile()
    {
      File.WriteAllText(DataFileName, PdaText.Text);
    }

    private void PdaInput_Click(object sender, EventArgs e)
    {
      WriteDataFile();
      Close();
    }

    private void FastClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
