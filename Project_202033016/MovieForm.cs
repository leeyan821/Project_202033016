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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataManager.Movies;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == ""
                    || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("모두 입력.");
                }
                else
                {
                    if (DataManager.Movies.Exists(x => x.Time == textBox2.Text &&
                     x.Date == textBox3.Text && x.Theater == textBox4.Text))
                    {
                        MessageBox.Show("추가 불가능.");
                    }
                    else
                    {
                        Movie movie = new Movie()
                        {
                            Title = textBox1.Text,
                            Time = textBox2.Text,
                            Date = textBox3.Text,
                            Theater = textBox4.Text,
                            Num = int.Parse(textBox5.Text),
                            Id = DataManager.Movies.Max(x => x.Id) + 1,
                            Count = DataManager.Movies.Exists(x => x.Title == textBox1.Text) ? "two" : "one"
                        };
                        DataManager.Movies.Add(movie);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Movies;

                        char ch = 'a';
                        int n = 1;
                        for (int i = 0; i < 5; i++)
                        {
                            n = 1;
                            Seat seat = new Seat
                            {
                                Movieid = DataManager.Movies.Max(x => x.Id),
                                Line = ch.ToString(),
                                X1 = ch.ToString() + n.ToString(),
                                X2 = ch.ToString() + (n + 1).ToString(),
                                X3 = ch.ToString() + (n + 2).ToString(),
                                X4 = ch.ToString() + (n + 3).ToString(),
                                X5 = ch.ToString() + (n + 4).ToString()
                            };
                            DataManager.Seats.Add(seat);
                            ch++;
                        }
                        int no = 25 - movie.Num;
                        Ch(no, movie);
                        DataManager.Save();
                        MessageBox.Show("추가 완료");
                    }
                }
            }catch (Exception ex) { }
        }
        
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Movie movie = dataGridView1.CurrentRow.DataBoundItem as Movie;
                textBox1.Text = movie.Title;
                textBox2.Text = movie.Time;
                textBox3.Text = movie.Date;
                textBox4.Text = movie.Theater;
                textBox5.Text = movie.Num.ToString();
                label7.Text = movie.Id.ToString();
            }catch(Exception ex) 
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Movie movie = DataManager.Movies.Single(x => x.Title == textBox1.Text &&
                    x.Id == int.Parse(label7.Text));

                if (DataManager.Ress.Exists(x=> x.Movieid == movie.Id))
                {
                    MessageBox.Show("변경 불가");
                }
                else
                {
                    if (DataManager.Movies.Exists(x => x.Time == textBox2.Text &&
                    x.Date == textBox3.Text && x.Theater == textBox4.Text && x.Num == int.Parse(textBox5.Text)))
                    {
                        MessageBox.Show("세부정보 중복.");
                    }
                    else
                    {
                        int mn = movie.Num;
                        movie.Time = textBox2.Text;
                        movie.Date = textBox3.Text;
                        movie.Theater = textBox4.Text;
                        movie.Num = int.Parse(textBox5.Text);

                        int no = 25 - movie.Num;
                        if (mn > movie.Num)
                            Ch(no, movie);
                        else if(mn < movie.Num)
                        {
                            char ch = 'a';
                            int n = 1;
                            var s = DataManager.Seats.Where(x => x.Movieid == movie.Id).ToList();
                            foreach (var a in s)
                            {
                            n = 1;
                            a.Movieid = movie.Id;
                            a.Line = ch.ToString();
                            a.X1 = ch.ToString() + n.ToString();
                            a.X2 = ch.ToString() + (n + 1).ToString();
                            a.X3 = ch.ToString() + (n + 2).ToString();
                            a.X4 = ch.ToString() + (n + 3).ToString();
                            a.X5 = ch.ToString() + (n + 4).ToString();
                            ch++;
                            }
                            Ch(no, movie);
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Movies;
                        DataManager.Save();
                        MessageBox.Show("수정 완료");
                    }
                }
            }catch(Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Movie movie = DataManager.Movies.Single(x => x.Title == textBox1.Text &&
                    x.Id == int.Parse(label7.Text));
                if (DataManager.Ress.Exists(x => x.Movieid == movie.Id))
                {
                    MessageBox.Show("삭제 불가");
                }
                else
                {
                    DataManager.Movies.Remove(movie);                    
                    var seat = (from a in DataManager.Seats
                                where a.Movieid == movie.Id
                                select a).ToList();
                    foreach (var a in seat)
                        DataManager.Seats.Remove(a);
                    int m = (from a in DataManager.Movies
                             where a.Title == textBox1.Text
                             select a).Count();
                    if (m == 1)
                    {
                        Movie mov = DataManager.Movies.Single(x => x.Title == textBox1.Text);
                        mov.Count = "one";
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Movies;
                    DataManager.Save();
                    MessageBox.Show("삭제 완료");
                }
            }catch(Exception ex)
            { }
        }

        private void Ch(int n, Movie movie)
        {
            char ch = 'e';
            if (n >= 0 && n <= 5)
            {
                for (int i = 0; i < n; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X5 = "X";
                    ch--;
                }
            }
            else if (n <= 10)
            {
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X5 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < n - 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X4 = "X";
                    ch--;
                }
            }
            else if (n <= 15)
            {
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X5 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X4 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < n - 10; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X3 = "X";
                    ch--;
                }
            }
            else if (n <= 20)
            {
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X5 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X4 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X3 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < n - 15; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X2 = "X";
                    ch--;
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X5 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X4 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X3 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < 5; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X2 = "X";
                    ch--;
                }
                ch = 'e';
                for (int i = 0; i < n - 20; i++)
                {
                    Seat seat = DataManager.Seats.Single(x => x.Movieid == movie.Id && x.Line == ch.ToString());
                    seat.X1 = "X";
                    ch--;
                }
            }
        }
    }
}
