using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Library_Management_System
{
    public partial class Overdue : System.Web.UI.Page
    {
      
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = ("SELECT RentedBook, DueDate FROM Student");

            SqlDataAdapter adp = new SqlDataAdapter(query, con);
           
            adp.Fill(ds);
            con.Close();

        
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        string query = "";
        DataSet DataSet = new DataSet();
        protected void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][1].ToString() == "")
                    {
                        count++;
                    }
                    else
                    {
                        if (DateTime.Compare(DateTime.Now, Convert.ToDateTime(ds.Tables[0].Rows[count][1])) != 0)
                        {

                            query = "Insert into [Overdue] (RentedBook, DueDate) VALUES ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "')";
                            query = query + " " + query;
                            count++;
                        }
                    }
                }
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                con.Close();

                con.Open();
                //string query2 = "select * from [Overdue]";
                //SqlDataAdapter adp2 = new SqlDataAdapter(query2, con);

                //adp2.Fill(DataSet);
                if (GridView1!= null)
                {
                    GridView1.Visible = true;
                    //GridView1.DataSource = DataSet.Tables[0];

                }
                else
                {
                    errorlbl.Text = "No overdues";

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