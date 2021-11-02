using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Project_202033016
{
    class DataManager
    {
        public static List<Movie> Movies = new List<Movie>();
        public static List<User> Users = new List<User>();
        public static List<Seat> Seats = new List<Seat>();
        public static List<Reservation> Ress = new List<Reservation>();
        public static string UserId="";

        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                string movieOut = File.ReadAllText(@"./Movie.xml");
                XElement moviesXElement = XElement.Parse(movieOut);
                Movies = (from item in moviesXElement.Descendants("movie")
                         select new Movie()
                         {
                             Title = item.Element("title").Value,
                             Time = item.Element("time").Value,
                             Date = item.Element("date").Value,
                             Theater = item.Element("theater").Value,
                             Num = int.Parse(item.Element("num").Value),
                             Id = int.Parse(item.Element("id").Value),
                             Count = item.Element("count").Value
                         }).ToList<Movie>();

                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Id = item.Element("id").Value,
                             Password = item.Element("password").Value,
                             Mode = item.Element("mode").Value,
                             Use = item.Element("use").Value
                         }).ToList<User>();

                string seatOut = File.ReadAllText(@"./Seats.xml");
                XElement seatsXElement = XElement.Parse(seatOut);
                Seats = (from item in seatsXElement.Descendants("movie")
                         select new Seat()
                         {
                             Movieid = int.Parse(item.Element("movieid").Value),
                             Line = item.Element("line").Value,
                             X1 = item.Element("x1").Value,
                             X2 = item.Element("x2").Value,
                             X3 = item.Element("x3").Value,
                             X4 = item.Element("x4").Value,
                             X5 = item.Element("x5").Value
                         }).ToList<Seat>();

                string resOut = File.ReadAllText(@"./Reservation.xml");
                XElement resXElement = XElement.Parse(resOut);
                Ress = (from item in resXElement.Descendants("res")
                        select new Reservation()
                        {
                            Movieid = int.Parse(item.Element("movieid").Value),
                            Userid = item.Element("userid").Value,
                            Seat = item.Element("seat").Value
                        }).ToList<Reservation>();
            }
            catch(Exception e)
            {
                Save();
            }
        }
        public static void Save()
        {
            string moviesOut = "";
            moviesOut += "<movies>\n";
            foreach(var item in Movies)
            {
                moviesOut += "<movie>\n";
                moviesOut += "<title>" + item.Title + "</title>\n";
                moviesOut += "<time>" + item.Time + "</time>\n";
                moviesOut += "<date>" + item.Date + "</date>\n";
                moviesOut += "<theater>" + item.Theater + "</theater>\n";
                moviesOut += "<num>" + item.Num + "</num>\n";
                moviesOut += "<id>" + item.Id + "</id>\n";
                moviesOut += "<count>" + item.Count + "</count>\n";
                moviesOut += "</movie>\n";
            }
            moviesOut += "</movies>\n";

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += "<id>" + item.Id + "</id>\n";
                usersOutput += "<password>" + item.Password + "</password>\n";
                usersOutput += "<mode>" + item.Mode + "</mode>\n";
                usersOutput += "<use>" + item.Use + "</use>\n";
                usersOutput += "</user>";
            }
            usersOutput += "</users>";

           string seatsOutput = "";
            seatsOutput += "<seats>\n";
            foreach (var item in Seats)
            {
                seatsOutput += "<movie>\n";
                seatsOutput += "<movieid>" + item.Movieid + "</movieid>\n";
                seatsOutput += "<line>" + item.Line + "</line>\n";
                seatsOutput += "<x1>" + item.X1 + "</x1>\n";
                seatsOutput += "<x2>" + item.X2 + "</x2>\n";
                seatsOutput += "<x3>" + item.X3 + "</x3>\n";
                seatsOutput += "<x4>" + item.X4 + "</x4>\n";
                seatsOutput += "<x5>" + item.X5 + "</x5>\n";
                seatsOutput += "</movie>\n";
            }
            seatsOutput += "</seats>";

            string resOutput = "";
            resOutput += "<ress>\n";
            foreach(var item in Ress)
            {
                resOutput += "<res>\n";
                resOutput += "<movieid>" + item.Movieid + "</movieid>\n";
                resOutput += "<userid>" + item.Userid + "</userid>\n";
                resOutput += "<seat>" + item.Seat + "</seat>\n";
                resOutput += "</res>\n";
            }
            resOutput += "</ress>\n";

            File.WriteAllText(@"./Movie.xml", moviesOut);
            File.WriteAllText(@"./Users.xml", usersOutput);
            File.WriteAllText(@"./Seats.xml", seatsOutput);
            File.WriteAllText(@"./Reservation.xml", resOutput);
        }
    }
}
