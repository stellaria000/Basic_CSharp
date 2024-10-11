using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*WinForm은 Form 클래스를 상속받는다.
             생성자에서 InitializeComponent를 호출해 윈폼에서 사용하는 모든 컨트롤에 대한 속성을 초기화한다.
             */
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
