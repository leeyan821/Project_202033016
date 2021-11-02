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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Main";

            var s = (from Mo in DataManager.Movies
                     where Mo.Date == "2021년 10월 28일 목요일"
                     orderby Mo.Time
                     select Mo).ToList();
            dataGridView1.DataSource = s;
        }

        private void 예매취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataManager.UserId == "")
                MessageBox.Show("로그인 후 이용 가능");
            else
                new Form3().ShowDialog();        
        }
        private void 영화관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataManager.UserId == "")
                MessageBox.Show("관리자 로그인 후 이용 가능");
            else
            {
                try
                {                    
                    User user = DataManager.Users.Single(x=> x.Id == DataManager.UserId);
                    if (user.Mode == "manager")
                        new MovieForm().ShowDialog();
                    else
                        MessageBox.Show("관리자가 아닙니다.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("관리자가 아닙니다.");
                }
            }
        }
        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataManager.UserId == "")
                new LogInForm().ShowDialog();
            else
            {
                DialogResult dialogResult = MessageBox.Show("로그인 중입니다. 로그아웃 하시겠습니까?",
                    "inform", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    DataManager.UserId = "";
                    MessageBox.Show("로그아웃 완료");
                }
                else if (dialogResult == DialogResult.Cancel)
                    MessageBox.Show("로그아웃 취소");
            }
        }

        private void 마이페이지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataManager.UserId == "")
                MessageBox.Show("로그인 후 이용 가능");
            else
            {
                try
                {
                    User user = DataManager.Users.Single(x => x.Id == DataManager.UserId &&
                    x.Mode == "manager");
                    new ManagerForm().ShowDialog();
                }
                catch
                {
                    new MyPageForm().ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1_CurrentCellChanged(sender, e);
            }catch(Exception ex) { }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var n = (from Mo in DataManager.Movies
                         where Mo.Date == "2021년 10월 28일 목요일"
                         orderby Mo.Time
                         select Mo).ToList();
                dataGridView1.DataSource = n;
            }
            catch (Exception ex) { }
        }
    }
}
