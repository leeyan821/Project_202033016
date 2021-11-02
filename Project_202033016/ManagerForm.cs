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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = (from a in DataManager.Users
                                        where a.Id != DataManager.UserId
                                        select a).ToList();
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single(x => x.Id == textBox1.Text);
                if (user.Use == "no use")
                {
                    if (user.Mode == "manager")
                    {
                        DialogResult dialogResult = MessageBox.Show("관리자 아이디 입니다.\n삭제하시겠습니까?",
                            "inform", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            Remove();
                        }
                        else if (dialogResult == DialogResult.Cancel)
                            MessageBox.Show("삭제 취소");
                    }
                    else
                        Remove();                                   
                }
                else
                {
                    MessageBox.Show("휴면 사용자가 아닙니다.");
                }
                void Remove()
                    {
                        DataManager.Users.Remove(user);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = (from a in DataManager.Users
                                                    where a.Id != DataManager.UserId
                                                    select a).ToList();
                        MessageBox.Show("회원 삭제가 완료되었습니다.");
                        DataManager.Save();
                    }    
            }
            catch(Exception ex) { }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView1.CurrentRow.DataBoundItem as User;
                textBox1.Text = user.Id;
            }catch(Exception ex) { }
        }
    }
}
