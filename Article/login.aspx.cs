using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Article
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=SAHIL\\SQLEXPRESS; initial catalog=userreg; integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_click(object sender, EventArgs e)
        {

            //string check = "select count(*) from [reg] where username= '" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            //SqlCommand com = new SqlCommand(check, con);
            //con.Open();
            //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            //con.Close();
            //if (temp == 1)
            //{
            //    Response.Redirect("post.aspx");
            //}
            //else
            //{
            //    System.Windows.Forms.MessageBox.Show("Please login your details");
            //}

            SqlConnection con = new SqlConnection("Data source=SAHIL\\SQLEXPRESS; initial catalog=userreg; integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from reg where username = @username and password = @password", con);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
            {
                
                System.Windows.Forms.MessageBox.Show("Please enter both username and password");
            }
            else if (dr.Read())
            {
                Session["id"] = TextBox1.Text;
                Response.Redirect("post.aspx");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid user");
            }

            con.Close();


        }
    }
}
