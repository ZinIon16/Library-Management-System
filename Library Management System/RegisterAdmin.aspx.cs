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
    public partial class RegisterAdmin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());


        protected void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = email.Text;
                string pass = password.Text;
                outputlabel.Text = uid;
                con.Open();

                string qry = "select * from [Admin] where AdminName='" + uid + "' and Password='" + pass + "'";
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
                    string query = "Insert into [Admin] (AdminName, Password) VALUES ('" + uid + "','" + pass + "')";
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