using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DBConn
{
    public partial class LogIn : System.Web.UI.Page
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string query;
        string name;
        string nim;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (string)(Session["uname"]);
            lbUser.Text = name;
        }
        protected void UploadBtn(object sender, EventArgs e)
        {
            UploadFile();
            //Response.Redirect("LogIn.aspx", false);
        }
        private void UploadFile()
        {
            nim = (string)(Session["nim"]);
            string connStr = "datasource = 127.0.0.1; username = root; password =; database = users";
            conn = new MySqlConnection(connStr);
            try
            {
                // For Extension Limitation
                // string extension = System.IO.Path.GetExtension([form ID].FileName);

                // For Size Limitation
                // int filesize = [form ID].PostedFile.ContentLength;
                conn.Open();
                if (fileUp.HasFile)
                {
                    fileUp.SaveAs(Server.MapPath("~/Upload/" + fileUp.FileName));
                    query = "INSERT INTO users.dbfile (nim, path) VALUES ('" + nim + "','~/Upload/" + fileUp.FileName + "')";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteReader();
                    lblNotif.Text = "File Upload Success";
                }
                else
                {
                    lblNotif.Text = "File Upload Failed";
                }
                
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}