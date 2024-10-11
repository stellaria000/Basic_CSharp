using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*윈폼은 Form 클래스를 상속받으며, 생성자에서 InitializeComponent 메소드를 호출해 
             윈폼에서 사용하는 모든 컨트롤에 대한 속성을 초기화한다.*/
            InitializeComponent();
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {

        }
        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = pw.Text;

            if (userId.Equals("MyId") && userPassword.Equals("MyPassword"))
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
            else MessageBox.Show("로그인에 실패했습니다.", "로그인")
        }

        
    }
}
