using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace MediaShare.Models
{
    public class Photo
    {
        private List<string> comments = new List<string>();
        public int Likes { get; set; }
        public List<string> getComments()
        {
            return comments;
        }
        public void addComments(string s)
        {
            comments.Add(s);
        }
        public void uploadPhoto(string path)
        {
            string dbconn = "datasource = localhost; username = root; password=; database = coba";
            MySqlConnection conn = new MySqlConnection(dbconn);
            try
            {
                conn.Open();
                Console.WriteLine("Connected to DB");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}