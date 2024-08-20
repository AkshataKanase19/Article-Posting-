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
    public partial class imglog : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Images order by img_date DESC", con))
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
            string imgPathToDelete = btnDelete.CommandArgument;



            using (SqlConnection con = new SqlConnection("Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Images WHERE imgpath = @imgPath", con))
                {
                    cmd.Parameters.AddWithValue("@imgPath", imgPathToDelete);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Image deleted successfully");
                }
            }

            BindDataList();
        }


        protected void btnpost_Click(object sender, EventArgs e)
        {


            Button btnPost = (Button)sender;

            
            string imgpath = btnPost.CommandArgument;

           
            MoveImageToTable9(imgpath);


        }

        private void MoveImageToTable9(string imgpath)
        {
            
            string connectionString = "Data Source=SAHIL\\SQLEXPRESS;Initial Catalog=art;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO blogimg (imgpath, username, img_date) SELECT imgpath, username, img_date FROM Images WHERE imgpath = @imgPath", con))
                {
                    insertCmd.Parameters.AddWithValue("@imgPath", imgpath);
                    insertCmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Image posted on blog page successfully");

                }



            }
           
            BindDataList();


        }
        protected void button1_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}