using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article
{
    public partial class img : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=SAHIL\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False");
        string path;
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
        //        protected void Button1_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(TextBox2.Text) || FileUpload1.PostedFile == null || FileUpload1.PostedFile.ContentLength == 0)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Please enter username and select an image.");
        //    }
        //    else
        //    {
        //        // Get the currently logged-in username
        //        string loggedInUser = Session["id"] != null ? Session["id"].ToString() : Session["idd"].ToString();

        //        // Check if the entered username matches the logged-in user
        //        if (TextBox2.Text.Equals(loggedInUser, StringComparison.OrdinalIgnoreCase))
        //        {
        //            if (IsUsernameExists(loggedInUser))
        //            {
        //                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/Photos/" + FileUpload1.FileName.ToString());
        //                path = "Photos/" + FileUpload1.FileName.ToString();

        //                con.Open();
        //                SqlCommand cmd = con.CreateCommand();
        //                cmd.CommandType = CommandType.Text;
        //                cmd.CommandText = "INSERT INTO Images VALUES(@imgpath, @status, @username, GETDATE())";

        //                cmd.Parameters.Add("@imgpath", SqlDbType.VarChar);
        //                cmd.Parameters["@imgpath"].Value = path;

        //                cmd.Parameters.Add("@status", SqlDbType.Int);
        //                cmd.Parameters["@status"].Value = 0;

        //                cmd.Parameters.Add("@username", SqlDbType.VarChar);
        //                cmd.Parameters["@username"].Value = loggedInUser;

        //                cmd.ExecuteNonQuery();
        //                con.Close();

        //                System.Windows.Forms.MessageBox.Show("Data has been sent to admin");

        //                TextBox2.Text = "";
        //            }
        //            else
        //            {
        //                System.Windows.Forms.MessageBox.Show("Username does not exist. Please enter a valid username.");
        //            }
        //        }
        //        else
        //        {
        //            System.Windows.Forms.MessageBox.Show("You can only upload images for your own username.");
        //        }
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox2.Text) || FileUpload1.PostedFile == null || FileUpload1.PostedFile.ContentLength == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please enter username and select an image.");
            }
            else
            {
                
                string loggedInUser = Session["id"] != null ? Session["id"].ToString() : Session["idd"].ToString();

                
                if (TextBox2.Text.Equals(loggedInUser, StringComparison.OrdinalIgnoreCase))
                {
                    if (IsUsernameExists(loggedInUser))
                    {
                        
                        string[] allowedFileExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; // Add more if needed
                        string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                        if (Array.IndexOf(allowedFileExtensions, fileExtension.ToLower()) != -1)
                        {
                            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/Photos/" + FileUpload1.FileName.ToString());
                            path = "Photos/" + FileUpload1.FileName.ToString();

                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "INSERT INTO Images VALUES(@imgpath, @status, @username, GETDATE())";

                            cmd.Parameters.Add("@imgpath", SqlDbType.VarChar);
                            cmd.Parameters["@imgpath"].Value = path;

                            cmd.Parameters.Add("@status", SqlDbType.Int);
                            cmd.Parameters["@status"].Value = 0;

                            cmd.Parameters.Add("@username", SqlDbType.VarChar);
                            cmd.Parameters["@username"].Value = loggedInUser;

                            cmd.ExecuteNonQuery();
                            con.Close();

                            System.Windows.Forms.MessageBox.Show("Data has been sent to admin");

                            TextBox2.Text = "";
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Invalid file format. Please upload only  (.jpg, .jpeg, .png, .gif). image file");
                        }
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

