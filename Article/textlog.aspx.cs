using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article
{
    public partial class textlog : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("alogin.aspx");
            }
            else
            {
                Response.Write("<b>" + Session["id"] + "</b>");

            }
            if (!IsPostBack)
            {

                BindDataList();
            }

        }
        protected void BindDataList()
        {



            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM imgtxt order by img_date DESC", con))
                {
                    con.Open();
                    DataList1.DataSource = cmd.ExecuteReader();
                    DataList1.DataBind();
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            Button btnDelete = (Button)sender;
            string blogPathToDelete = btnDelete.CommandArgument;



            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM imgtxt WHERE  blog LIKE @blog", con))
                {
                    cmd.Parameters.AddWithValue("@blog", "%" + blogPathToDelete + "%");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("blog deleted successfully");
                }
            }

            BindDataList();
        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            Button btnPost = (Button)sender;

           
            string blog = btnPost.CommandArgument;

            
            MoveImageToTable9(blog);


        }

        private void MoveImageToTable9(string blog)
        {
            
            string connectionString = "Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO blogtxt (username,blog,img_date) SELECT username,blog, img_date FROM imgtxt WHERE blog LIKE @blog", con))
                {
                    insertCmd.Parameters.AddWithValue("@blog", "%" + blog + "%");
                    insertCmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Image posted on blog page successfully");

                }



            }
            
            BindDataList();


        }


        protected void button1_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("alogin.aspx");
        }








    }
}