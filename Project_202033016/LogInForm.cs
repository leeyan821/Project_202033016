using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_202033016
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            Text = "로그인";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string userPass = textBox2.Text;

            if (userId == "" || userPass == "")
                MessageBox.Show("아이디/비밀번호 입력");
             
            if (radioButton1.Checked)
            {
                var user = (from u in DataManager.Users
                            where u.Mode == "normal"
                            select u).ToList();
                Find(user);
            }
            else if(radioButton2.Checked)
            {
                var user = (from u in DataManager.Users
                            where u.Mode == "manager"
                            select u).ToList();
                Find(user);
            }
            else
            {
                if (userId == "" || userPass == "")
                    label2.Text = "";
                else
                    label2.Text = "회원 / 관리자 체크가 필요합니다.";
            }
            void Find(List<User> user)
            {
                foreach (var a in user)
                {
                    if (a.Id == userId && a.Password == userPass)
                    {
                        DataManager.UserId = userId;
                        label2.Text = "";
                        MessageBox.Show("로그인 되었습니다.");
                        this.Hide();
                    }
                    else
                    {
                        label2.Text = "아이디 / 패스워드가 틀립니다.";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Join().ShowDialog();
        }
    }
}
