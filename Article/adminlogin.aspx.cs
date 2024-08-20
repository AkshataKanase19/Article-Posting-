using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Article
{
    public partial class adminlogin : System.Web.UI.Page
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

        }
        protected void button1_Click(object sender, EventArgs e)
        {
            Session["idd"] = null;
            Response.Redirect("alogin.aspx");
        }
    }
}