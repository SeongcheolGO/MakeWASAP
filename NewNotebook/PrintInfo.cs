using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNotebook
{
  public partial class PrintInfo : Form
  {
    Form1 form = new Form1();
    InfoCor cor = new InfoCor(); 

    public PrintInfo()
    {
      InitializeComponent();
      
      if (cor.CheckExistDataFile())
      {
        string text = cor.ReadDataFile();
        PrintInfomation.Text = text;
      }
      else
      {
        MessageBox.Show("자료가 없습니다.");
      }
    }




  }
}
