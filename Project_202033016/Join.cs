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
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ID 입력");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Password 입력");
            }
            else
            {
                try
                {
                    if (DataManager.Users.Exists(x => x.Id == textBox1.Text))
                    {
                        MessageBox.Show("추가 불가능");
                    }
                    else if(DataManager.Ress.Exists(x=>x.Userid == textBox1.Text))
                    {
                        MessageBox.Show("추가 불가능");
                    }
                    else
                    {
                        User user = new User()
                        {
                            Id = textBox1.Text,
                            Password = textBox2.Text,
                            Mode = "normal",
                            Use = "no use"
                        };
                        DataManager.Users.Add(user);
                        DataManager.Save();
                        MessageBox.Show("회원가입 완료");
                        this.Close();
                    }
                }
                catch (Exception ex) { }
            }
        }
    }
}
