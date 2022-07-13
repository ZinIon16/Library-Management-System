using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class Addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "Insert into [Book] (BookName, AuthorName) VALUES ('" + Booknametxt.Text + "','" + Authortxt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                outputlabel.Text = "Added data successfully..!!";

                
                con.Close();
            }
            catch (Exception ex)
            {
                outputlabel.Text = ex.Message;
            }

        }
    }
}