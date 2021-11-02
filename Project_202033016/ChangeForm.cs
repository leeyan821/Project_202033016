using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_202033016
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
            label2.Text = DataManager.UserId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text=="")
                {
                    MessageBox.Show("비밀번호 입력");
                }
                else
                {
                    User user = DataManager.Users.Single(x => x.Id == DataManager.UserId);
                    user.Password = textBox1.Text;
                    DataManager.Save();
                    MessageBox.Show("비밀번호 수정 완료\n 로그아웃 됩니다.");
                    this.Close();
                    this.FormClosed += ChangeForm_FormClosed;
                    DataManager.UserId = "";
                }
            }catch(Exception ex) { }
        }

        private void ChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single(x => x.Id == DataManager.UserId);
                DialogResult dialogResult = MessageBox.Show("탈퇴하시겠습니까? \n( 예매 취소 후 사용 권장. 사용 및 환불이 불가합니다.)",
                    "inform",MessageBoxButtons.OKCancel);
                if(dialogResult == DialogResult.OK)
                {
                    DataManager.Users.Remove(user);
                    DataManager.Save();
                    MessageBox.Show("탈퇴 완료\n 로그아웃 됩니다.");
                    this.Close();
                    this.FormClosed += ChangeForm_FormClosed;
                    DataManager.UserId = "";
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("탈퇴 취소");
                }
            }
            catch(Exception ex) { }
        }
    }
}
