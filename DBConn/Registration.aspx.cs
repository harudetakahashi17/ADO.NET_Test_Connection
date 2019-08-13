using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DBConn
{
    public partial class Registration : System.Web.UI.Page
    {
        MySqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void regEventMethod(object sender, EventArgs e)
        {
            regisUser();
            Response.Redirect("Default.aspx", false);
        }
        private void regisUser()
        {
            string connStr = "datasource = 127.0.0.1; username = root; password =; database = users";
            this.conn = new MySqlConnection(connStr);
            try
            {
                this.conn.Open();
                string query = "INSERT INTO users.mahasiswa VALUES ('" +
                    tbNewUsername.Text + "','" + tbNewPassword.Text + "','" + tbNIM.Text + "','" + tbName.Text + "')";
                MySqlCommand command = new MySqlCommand(query, this.conn);
                command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}