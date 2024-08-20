using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



namespace Article
{
    public partial class view : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAHIL\SQLEXPRESS;Initial Catalog=art;Integrated Security=True; Trusted_Connection=True; Encrypt=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            fill();
        }
        private void fill()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from pic", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path;
            if (FileUpload1.HasFile)
                FileUpload1.SaveAs(HttpContext.Current.Request.PhysicalApplicationPath + "image/" + FileUpload1.FileName);
            path = FileUpload1.FileName;
            SqlCommand cmd = new SqlCommand("insert into pic values('" + path.ToString() + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fill();
        }
    }
}