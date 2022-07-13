using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library_Management_System
{
    public partial class RegisterStu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());


        protected void registerBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                string uid = email.Text;
                string pass = password.Text;
                outputlabel.Text = uid;
                con.Open();

                string qry = "select * from [Student] where id='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    outputlabel.Text = "Already exist......!!";
                }
                else
                {
                    string query = "Insert into [Student] (id, Password) VALUES ('" + uid + "','" + pass + "')";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    outputlabel.Text = "Added data successfully..!!";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                outputlabel.Text = ex.Message;
            }
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = email.Text;
                string pass = password.Text;
                outputlabel.Text = uid;
                con.Open();

                string qry = "select * from [Student] where StudentName='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    outputlabel.Text = "Already exist......!!";
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string query = "Insert into [Student] (StudentName, Password) VALUES ('" + uid + "','" + pass + "')";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    SqlDataReader sdr2 = cmd2.ExecuteReader();
                    outputlabel.Text = "Added data successfully..!!";
                    con.Close();

                }
                
            }
            catch (Exception ex)
            {
                outputlabel.Text = ex.Message;
            }
            }
    }
}