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



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public class Messages
        {
            public bool transForm = true;
            public string transYes = "변환 성공";
            public string transNo = "변환 실패";
            public string ErrorMessage = "오류 창입니다.";
            public string sorr = "미안합니다.";
        }



        Messages mess = new Messages();


        private void Error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오류 내용입니다.", mess.ErrorMessage);
        }

        private void trans_Click(object sender, EventArgs e)
        {
            if(!mess.transForm)
            {
                MessageBox.Show(string.Format("전송 자료 {0} 했습니다.", mess.transNo));
            }
            else
            {
                MessageBox.Show(string.Format("전송 자료 {0} 했습니다.", mess.transYes));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdaInfo info = new PdaInfo();

            info.Show();
        }

        private void InfomationCorrection_Click(object sender, EventArgs e)
        {
            InfoCor info = new InfoCor();

            info.Show();
        }
    }
}
