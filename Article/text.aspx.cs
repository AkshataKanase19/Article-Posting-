using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Article
{
    
    public partial class text : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null && Session["idd"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                string username = Session["id"] != null ? Session["id"].ToString() : Session["idd"].ToString();
                Response.Write("<b>" + username + "</b>");
            }
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LJ9LDA7T\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False");

        //    if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
        //    {

        //        System.Windows.Forms.MessageBox.Show("please enter username and blog.");
        //    }
        //    else
        //    {



        //        con.Open();
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "insert into imgtxt values(@username,@blog,getdate(),@status)";
        //        cmd.Parameters.Add("@username", SqlDbType.VarChar);
        //        cmd.Parameters["@username"].Value = TextBox1.Text;

        //        cmd.Parameters.Add("@blog", SqlDbType.VarChar);
        //        cmd.Parameters["@blog"].Value = TextBox2.Text;

        //        cmd.Parameters.Add("@status", SqlDbType.Int);
        //        cmd.Parameters["@status"].Value = 0;
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        System.Windows.Forms.MessageBox.Show("Data has been sent to admin");

        //        // Clear the TextBox
        //        TextBox2.Text = "";
        //        TextBox1.Text = "";

        //    }
        //}




        //new code
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = SAHIL\SQLEXPRESS;Initial Catalog = art; Integrated Security = True; Encrypt=False");
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
            {

                System.Windows.Forms.MessageBox.Show("please enter username and blog.");
            }
            else
            {
                
                string loggedInUser = Session["id"] != null ? Session["id"].ToString() : Session["idd"].ToString();

                
                if (TextBox1.Text.Equals(loggedInUser, StringComparison.OrdinalIgnoreCase))
                {
                    if (IsUsernameExists(loggedInUser))
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into imgtxt values(@username,@blog,getdate(),@status)";

                        cmd.Parameters.Add("@username", SqlDbType.VarChar);
                        cmd.Parameters["@username"].Value = loggedInUser;

                        cmd.Parameters.Add("@blog", SqlDbType.VarChar);
                        cmd.Parameters["@blog"].Value = TextBox2.Text;

                        cmd.Parameters.Add("@status", SqlDbType.Int);
                        cmd.Parameters["@status"].Value = 0;

                        cmd.ExecuteNonQuery();
                        con.Close();

                        System.Windows.Forms.MessageBox.Show("Data has been sent to admin");

                        TextBox1.Text = "";
                        TextBox2.Text = "";
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Username does not exist. Please enter a valid username.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You can only upload images for your own username.");
                }
            }
        }








        private bool IsUsernameExists(string username)
        {
            bool result = false;

            using (SqlConnection regCon = new SqlConnection(@"Data Source=SAHIL\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=False"))
            {
                regCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM reg WHERE UserName = @username", regCon);
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    result = true;
                }

                regCon.Close();
            }

            return result;
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}
