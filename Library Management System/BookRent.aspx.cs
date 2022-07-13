using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class BookRent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
         
                con.Open();
                string query=("SELECT BookName FROM Book");

                SqlDataAdapter adp = new SqlDataAdapter(query,con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
            con.Close();

            Bookddl.DataSource = ds.Tables[0];
            Bookddl.DataTextField = "BookName";
     
            Bookddl.DataBind();
               
        }
        

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            DateTime date;
            date= Calendar1.SelectedDate;
            DateTime datetime = DateTime.Now;
            string query = "Insert into [Student] (RentedBook, DueDate) VALUES ('" + Bookddl.Text + "','" + date + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            con.Close();

        }
        }
    }
