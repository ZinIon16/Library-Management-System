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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Student");
            DropDownList1.Items.Add("Admin");
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedIndex == 0)
            {

            
            try
            {
                string uid = TextBox1.Text;
                string pass = TextBox2.Text;
                con.Open();
                string qry = "select * from [Student] where StudentName='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Label4.Text = "Login Sucess......!!";

                        Response.Redirect("BookRent.aspx");
                    }
                else
                {
                    Label4.Text = "UserId & Password Is not correct Try again..!!";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            }

            else if (DropDownList1.SelectedIndex == 1)
            {


                try
                {
                    string uid = TextBox1.Text;
                    string pass = TextBox2.Text;
                    con.Open();
                    string qry = "select * from [Admin] where AdminName='" + uid + "' and Password='" + pass + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Label4.Text = "Login Sucess......!!";
                        Response.Redirect("Overdue.aspx");
                    }
                    else
                    {
                        Label4.Text = "UserId & Password Is not correct Try again..!!";

                    }
                    con.Close();
                   
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}
