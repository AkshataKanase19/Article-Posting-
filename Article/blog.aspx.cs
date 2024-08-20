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
    public partial class blog : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=SAHIL\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False");
        string path;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindDataList();
                BindDataList1();
                BindDataList2();


            }

        }
       
        protected void BindDataList()
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM blogimg order by Id DESC", con))
                {
                    con.Open();
                    if (DataList1 != null)
                    {
                        DataList1.DataSource = cmd.ExecuteReader();
                        DataList1.DataBind();
                    }
                }
            }

        }
        protected void BindDataList1()
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM blogimgtxt order by Id DESC", con))
                {
                    con.Open();
                    if (DataList2 != null)
                    {
                        DataList2.DataSource = cmd.ExecuteReader();
                        DataList2.DataBind();
                    }
                }
            }

        }
        protected void BindDataList2()
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM blogtxt order by Id DESC", con))
                {
                    con.Open();
                    if (DataList3 != null)
                    {
                        DataList3.DataSource = cmd.ExecuteReader();
                        DataList3.DataBind();
                    }
                }
            }


        }
        //for datalist1
        private DataTable GetRepliesMethod(int postId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Replies.*, blogimg.imgpath " +
                                                       "FROM Replies " +
                                                       "INNER JOIN blogimg ON Replies.PostID = blogimg.Id " +
                                                       "WHERE Replies.PostId = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        protected void BindReplies(int postId, DataList dataListReplies)
        {
            DataTable dataTable = GetRepliesMethod(postId);

            if (dataTable.Rows.Count > 0)
            {
                dataListReplies.DataSource = dataTable;
                dataListReplies.DataBind();
            }
        }

        protected void btnSubmitReply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int postId = Convert.ToInt32(btn.CommandArgument);

           
            TextBox txtReply = (TextBox)btn.Parent.FindControl("TextBox1");
            string replyText = txtReply.Text;
            TextBox txtuser = (TextBox)btn.Parent.FindControl("TextBox2");
            string replyuser = txtuser.Text;

            
            string imgPath = GetImagePath(postId);
            if (string.IsNullOrEmpty(replyuser) || string.IsNullOrEmpty(replyText))
            {
                
                System.Windows.Forms.MessageBox.Show("Please enter Username and Add Comment.");
            }
            else
            {
                
                using (SqlConnection conn = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Replies (PostID,Username, ReplyText, ReplyDate, imgpath) VALUES (@PostID, @Username, @ReplyText, GETDATE(), @imgpath)", conn))
                    {
                        cmd.Parameters.AddWithValue("@PostID", postId);
                        cmd.Parameters.AddWithValue("@ReplyText", replyText);
                        cmd.Parameters.AddWithValue("@Username", replyuser);
                        cmd.Parameters.AddWithValue("@imgpath", imgPath);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

           
            DataListItem item = (DataListItem)btn.NamingContainer;
            DataList dataListReplies = (DataList)item.FindControl("DataListReplies");

            
            BindReplies(postId, dataListReplies);
        }

        
        private string GetImagePath(int postId)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT imgpath FROM blogimg WHERE Id = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId);
                    con.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Replies values(@username)";

        }

        // for datalist2
        private DataTable GetRepliesMethod1(int postId1)
        {
            DataTable dataTable1 = new DataTable();

            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Replies1.*, blogimgtxt.imgpath " +
                                                       "FROM Replies1 " +
                                                       "INNER JOIN blogimgtxt ON Replies1.PostID = blogimgtxt.Id " +
                                                       "WHERE Replies1.PostId = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId1);

                    using (SqlDataAdapter adapter1 = new SqlDataAdapter(cmd))
                    {
                        adapter1.Fill(dataTable1);
                    }
                }
            }

            return dataTable1;
        }



        protected void BindReplies1(int postId1, DataList dataListReplies1)
        {
            DataTable dataTable1 = GetRepliesMethod1(postId1);

            if (dataTable1.Rows.Count > 0)
            {
                dataListReplies1.DataSource = dataTable1;
                dataListReplies1.DataBind();
            }
        }


        protected void btnSubmitReply1_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            int postId1 = Convert.ToInt32(btn1.CommandArgument);

           
            TextBox txtReply1 = (TextBox)btn1.Parent.FindControl("TextBox3");
            string replyText1 = txtReply1.Text;
            TextBox txtuser1 = (TextBox)btn1.Parent.FindControl("TextBox4");
            string replyuser1 = txtuser1.Text;

            
            string imgPath1 = GetImagePath1(postId1);
            
            string title1 = GetTitle(postId1);  
            if (string.IsNullOrEmpty(replyuser1) || string.IsNullOrEmpty(replyText1))
            {
                
                System.Windows.Forms.MessageBox.Show("Please enter Username and Add Comment.");
            }
            else
            {
               
                using (SqlConnection conn = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Replies1 (PostID,Username, ReplyText, ReplyDate, imgpath, title) VALUES (@PostID, @Username, @ReplyText, GETDATE(), @imgpath, @title)", conn))
                    {
                        cmd.Parameters.AddWithValue("@PostID", postId1);
                        cmd.Parameters.AddWithValue("@ReplyText", replyText1);
                        cmd.Parameters.AddWithValue("@Username", replyuser1);

                        cmd.Parameters.AddWithValue("@imgpath", imgPath1);
                        cmd.Parameters.AddWithValue("@title", title1);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            
            DataListItem item = (DataListItem)btn1.NamingContainer;
            DataList dataListReplies1 = (DataList)item.FindControl("DataListReplies1");

            
            BindReplies1(postId1, dataListReplies1);

           
            txtReply1.Text = "";
            txtuser1.Text = "";
        }


        
        private string GetImagePath1(int postId1)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT imgpath FROM blogimgtxt WHERE Id = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId1);
                    con.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }
        private string GetTitle(int postId1)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT title FROM blogimgtxt WHERE Id = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId1);
                    con.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Replies1 values(@username)";
        }
        
        private string GetText(int title)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT title FROM blogimgtxt WHERE Id = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", title);
                    con.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }


        //  for datalist3
        private DataTable GetRepliesMethod2(int postId2)
        {
            DataTable dataTable2 = new DataTable();

            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Replies2.*, blogtxt.blog " +
                                                       "FROM Replies2 " +
                                                       "INNER JOIN blogtxt ON Replies2.PostID = blogtxt.Id " +
                                                       "WHERE Replies2.PostId = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId2);

                    using (SqlDataAdapter adapter2 = new SqlDataAdapter(cmd))
                    {
                        adapter2.Fill(dataTable2);
                    }
                }
            }

            return dataTable2;
        }



        protected void BindReplies2(int postId2, DataList dataListReplies2)
        {
            DataTable dataTable2 = GetRepliesMethod2(postId2);

            if (dataTable2.Rows.Count > 0)
            {
                dataListReplies2.DataSource = dataTable2;
                dataListReplies2.DataBind();
            }
        }


        protected void btnSubmitReply2_Click(object sender, EventArgs e)
        {
            Button btn2 = (Button)sender;
            int postId2 = Convert.ToInt32(btn2.CommandArgument);

            
            TextBox txtReply2 = (TextBox)btn2.Parent.FindControl("TextBox5");
            string replyText2 = txtReply2.Text;
            TextBox txtuser2 = (TextBox)btn2.Parent.FindControl("TextBox6");
            string replyuser2 = txtuser2.Text;

            //// Retrieve imgpath from blogimg table
            //string imgPath1 = GetImagePath2(postId2);
            // Retrieve title from blogimg table
            string blog2 = Getblog(postId2);  
            if (string.IsNullOrEmpty(replyuser2) || string.IsNullOrEmpty(replyText2))
            {
                
                System.Windows.Forms.MessageBox.Show("Please enter Username and Add Comment.");
            }
            else
            {
                
                using (SqlConnection conn = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Replies2 (PostID, Username,ReplyText, ReplyDate, blog) VALUES (@PostID, @Username, @ReplyText, GETDATE(), @blog)", conn))
                    {
                        cmd.Parameters.AddWithValue("@PostID", postId2);
                        cmd.Parameters.AddWithValue("@ReplyText", replyText2);
                        cmd.Parameters.AddWithValue("@Username", replyuser2);

                        cmd.Parameters.AddWithValue("@blog", blog2);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

           
            DataListItem item = (DataListItem)btn2.NamingContainer;
            DataList dataListReplies2 = (DataList)item.FindControl("DataListReplies2");

            
            BindReplies2(postId2, dataListReplies2);

            
            txtReply2.Text = "";
            txtuser2.Text = "";
        }



        private string Getblog(int postId2)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT blog FROM blogtxt WHERE Id = @PostId", con))
                {
                    cmd.Parameters.AddWithValue("@PostId", postId2);
                    con.Open();
                    return (string)cmd.ExecuteScalar();
                }
            }
        }


        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Replies2 values(@username)";
        }




    }
}
