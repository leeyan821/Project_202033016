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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var m = (from mo in DataManager.Movies
                             where mo.Count == "one"
                             orderby mo.Title
                             select mo).ToList();
            dataGridView1.DataSource = m;            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("영화 선택");
                }
                else if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("세부사항 선택");
                }
                else if (textBox4.Text.Trim() == "")
                {
                    MessageBox.Show("좌석 선택");
                }
                else if(textBox4.Text == "X")
                {
                    MessageBox.Show("좌석 선택 불가");
                }
                else
                {
                    try
                    {
                        Movie movie = DataManager.Movies.Single(x => x.Title == textBox1.Text &&
                        x.Time == textBox2.Text && x.Date == textBox5.Text && x.Theater == textBox3.Text);
                        if(movie.Num == 0)
                        {
                            MessageBox.Show("남은 좌석이 없습니다.");
                        }
                        else
                        {
                            Reservation res = new Reservation()
                            {
                                Movieid = movie.Id,
                                Userid = DataManager.UserId,
                                Seat = textBox4.Text
                            };
                            DataManager.Ress.Add(res);
                            movie.Num -= 1;
                            User user = DataManager.Users.Single(x => x.Id == DataManager.UserId);
                            user.Use = "use";
                            var s = (from a in DataManager.Seats
                                     where a.Movieid == movie.Id 
                                     select a).ToList();
                            
                            foreach (var a in s)
                            {
                                if (a.X1 == textBox4.Text)
                                {
                                    a.X1 = "X";
                                }
                                else if (a.X2 == textBox4.Text)
                                {
                                    a.X2 = "X";
                                }
                                else if (a.X3 == textBox4.Text)
                                {
                                    a.X3 = "X";
                                }
                                else if (a.X4 == textBox4.Text)
                                {
                                    a.X4 = "X";
                                }
                                else if (a.X5 == textBox4.Text)
                                {
                                    a.X5 = "X";
                                }
                            }
                            DataManager.Save();
                            MessageBox.Show("예매 완료");
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("일치 항목 없음");
                    }
                }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Movie movie = dataGridView1.CurrentRow.DataBoundItem as Movie;
                textBox1.Text = movie.Title;
            }
            catch (Exception ex)
            {}
        }
        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Movie movie = dataGridView2.CurrentRow.DataBoundItem as Movie;
                textBox2.Text = movie.Time;
                textBox5.Text = movie.Date;
                textBox3.Text = movie.Theater;
            }
            catch (Exception ex)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var detail = (from n in DataManager.Movies
                          where n.Title == textBox1.Text
                          orderby n.Time
                          select n).ToList();
            dataGridView2.DataSource = detail;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var find = (from fi in DataManager.Movies
                        where fi.Title == textBox1.Text && fi.Time == textBox2.Text && fi.Date == textBox5.Text && fi.Theater == textBox3.Text
                        select fi).ToList();
            var seat = (from se in DataManager.Seats
                        from fi in find
                        where se.Movieid == fi.Id
                        select se).ToList();
            dataGridView3.DataSource = seat;
            dataGridView4.DataSource = seat;
            dataGridView5.DataSource = seat;
            dataGridView6.DataSource = seat;
            dataGridView7.DataSource = seat;
        }

        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Seat seat = dataGridView3.CurrentRow.DataBoundItem as Seat;
                textBox4.Text = seat.X1;
            }
            catch(Exception ex) { }
        }
        private void dataGridView4_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Seat seat = dataGridView4.CurrentRow.DataBoundItem as Seat;
                textBox4.Text = seat.X2;
            }catch(Exception ex) { }
        }
        private void dataGridView5_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Seat seat = dataGridView5.CurrentRow.DataBoundItem as Seat;
                textBox4.Text = seat.X3;
            }catch(Exception ex) { }
        }
        private void dataGridView6_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Seat seat = dataGridView6.CurrentRow.DataBoundItem as Seat;
                textBox4.Text = seat.X4;
            }catch(Exception ex) { }
        }
        private void dataGridView7_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Seat seat = dataGridView7.CurrentRow.DataBoundItem as Seat;
                textBox4.Text = seat.X5;
            }catch(Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("영화 선택");
            }
            else if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("세부사항 선택");
            }
            else if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("좌석 입력");
            }
            else
            {
                try
                {
                    Movie movie = DataManager.Movies.Single(x => x.Title == textBox1.Text &&
                       x.Time == textBox2.Text && x.Date == textBox5.Text && x.Theater == textBox3.Text);
                    Reservation res = DataManager.Ress.Single(x => x.Movieid == movie.Id &&
                    x.Userid == DataManager.UserId && x.Seat == textBox4.Text);

                    movie.Num += 1;                   
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id &&
                    textBox4.Text.Contains(x.Line));

                        if (textBox4.Text.EndsWith("1"))
                            seat.X1 = res.Seat;                     
                        else if (textBox4.Text.EndsWith("2"))
                            seat.X2 = res.Seat;
                        else if (textBox4.Text.EndsWith("3"))
                            seat.X3 = res.Seat;
                        else if (textBox4.Text.EndsWith("4"))
                            seat.X4 = res.Seat;
                        else if (textBox4.Text.EndsWith("5"))
                            seat.X5 = res.Seat;
                                              
                    DataManager.Ress.Remove(res);
                    int resNum = (from a in DataManager.Ress
                                where a.Userid == DataManager.UserId
                                select a).Count();
                    if(resNum <= 0)
                    {
                        User user = DataManager.Users.Single(x => x.Id == DataManager.UserId);
                        user.Use = "no use";
                    }
                    DataManager.Save();
                    MessageBox.Show("예매 취소 완료");
                }
                catch(Exception ex) {
                    MessageBox.Show("일치 항목이 없습니다.");
                }
            }
        }
    }
}
