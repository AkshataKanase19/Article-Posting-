using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article
{
    public partial class alogin : System.Web.UI.Page
    {
       
         protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(" Server=SAHIL\\SQLEXPRESS; Database=userreg; Trusted_Connection=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from alogin where username = @username and password = @password", con);
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
                Response.Redirect("adminlogin.aspx");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid Admin");
            }

            con.Close();

        }

    }
}