using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DBConn
{
    public partial class Default : System.Web.UI.Page
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        string query;
        string name;
        string nim;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitEventMethod(object sender, EventArgs e)
        {
            string connStr = "datasource = 127.0.0.1; username = root; password =; database = users";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                query = "SELECT * FROM users.mahasiswa WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                name = "";
                while (reader.HasRows && reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("name"));
                    nim = reader.GetString(reader.GetOrdinal("NIM"));
                }
                if (reader.HasRows)
                {
                    Session["nim"] = nim;
                    Session["uname"] = name;
                    Response.BufferOutput = true;
                    Response.Redirect("login.aspx", false);
                }
                else
                {
                    tbPassword.Text = "Invalid User/Pass";
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                Response.Redirect("Default.aspx", false);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }
    }
}