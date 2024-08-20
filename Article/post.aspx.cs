using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article
{
    public partial class post : System.Web.UI.Page
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

               
                DisplayImages(username);
                DisplayImagesWithTitle(username);
                DisplayBlogs(username);
            }
        }

        private void DisplayImages(string username)
        {
            string connectionString = "Data Source = SAHIL\\SQLEXPRESS;Initial Catalog = art; Integrated Security = True; Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT imgpath FROM Images WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int imagesPerRow = 3;
                        int imagesInCurrentRow = 0;

                        while (reader.Read())
                        {
                            Image img = new Image();
                            img.ImageUrl = reader["imgpath"].ToString();
                            img.Style["max-width"] = "400px"; 
                            imagePlaceholder.Controls.Add(img);

                           
                            if (++imagesInCurrentRow == imagesPerRow)
                            {
                               
                                imagePlaceholder.Controls.Add(new LiteralControl("<br />"));
                                imagesInCurrentRow = 0;
                            }
                        }
                    }
                }


            }
        }
        private void DisplayImagesWithTitle(string username)
        {
            string connectionString = "Data Source = SAHIL\\SQLEXPRESS;Initial Catalog = art; Integrated Security = True; Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT imgpath, title FROM Table1 WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int imagesPerRow = 3;
                        int imagesInCurrentRow = 0;

                        while (reader.Read())
                        {
                            
                            Panel imageContainer = new Panel();

                          
                            Image img = new Image();
                            img.ImageUrl = reader["imgpath"].ToString();
                            img.Style["max-width"] = "400px"; 
                            imageContainer.Controls.Add(img);

                           
                            imageContainer.Controls.Add(new LiteralControl("<br />"));
                            Label titleLabel = new Label();
                            titleLabel.Text = reader["title"].ToString();
                            imageContainer.Controls.Add(titleLabel);

                            
                            imagePlaceholder.Controls.Add(imageContainer);

                           
                            if (++imagesInCurrentRow == imagesPerRow)
                            {
                               
                                imagePlaceholder.Controls.Add(new LiteralControl("<br />"));
                                imagesInCurrentRow = 0;
                            }
                        }
                    }
                }
            }
        }

        private void DisplayBlogs(string username)
        {
            string connectionString = "Data Source = SAHIL\\SQLEXPRESS;Initial Catalog = art; Integrated Security = True; Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT blog FROM imgtxt WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int blogsPerRow = 3;
                        int blogsInCurrentRow = 0;

                        while (reader.Read())
                        {
                            
                            Panel blogContainer = new Panel();
                            blogContainer.CssClass = "blog-container"; 

                            
                            Label blogLabel = new Label();
                            blogLabel.Text = reader["blog"].ToString();
                            blogContainer.Controls.Add(blogLabel);

                            
                            blogContainer.Controls.Add(new LiteralControl("<br />"));

                           
                            imagePlaceholder.Controls.Add(blogContainer);

                            
                            if (++blogsInCurrentRow == blogsPerRow)
                            {
                                
                                imagePlaceholder.Controls.Add(new LiteralControl("<br />"));
                                blogsInCurrentRow = 0;
                            }
                        }
                    }
                }
            }
        }




        protected void button1_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}
