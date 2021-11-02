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
    public partial class MyPageForm : Form
    {
        public MyPageForm()
        {
            InitializeComponent();
            var res = (from a in DataManager.Ress
                       where a.Userid == DataManager.UserId
                       select a).ToList();
            var data = (from a in DataManager.Movies
                        join b in res on a.Id equals b.Movieid
                        orderby a.Id
                        select a).ToList();
            dataGridView1.DataSource = data;
            List<Reservation> ress = res.OrderBy(x => x.Movieid).ToList();
            dataGridView2.DataSource = ress;
        }

        private void 정보수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeForm().ShowDialog();
            this.Close();      
        }
    }
}
