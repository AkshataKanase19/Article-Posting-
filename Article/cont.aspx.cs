using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


namespace Article
{
    public partial class cont : System.Web.UI.Page
    {
        //public bool hasData = false;
        //public string firstname = "";
        //public string email = "";
        //public string message = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void OnPost()
        //{
        //    hasData = true;
        //    firstname = Request.Form["firstname"];
        //    email = Request.Form["email"];
        //    message = Request.Form["subject"];
        //}

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            
            
               try
                {
                   sendEmail();
                    Response.Redirect(@"~\sucessful.aspx");
                }
                catch(Exception ex)
               {
                    lblError.Text = ex.Message;
                }
            }
            private void sendEmail()
            {
                string smtpUserName;
                string smtpPassword;

                MailMessage mail = new MailMessage();
                SmtpClient smtp_Client = new SmtpClient(System.Configuration.ConfigurationSettings.AppSettings["smtpClient"]);
                smtpUserName = System.Configuration.ConfigurationSettings.AppSettings["smtpUserName"];
                smtpPassword = System.Configuration.ConfigurationSettings.AppSettings["smtpPassword"];
            mail.To.Add(smtpUserName);
               mail.From= new MailAddress(txtEmailId.Text.Trim());
               mail.Subject = "Email Configuration Project";
               mail.Body = ("Name:"+txtName.Text.Trim()+ Environment.NewLine + "Message:"+ txtMessage.Text.Trim());
                smtp_Client.Port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["smtpPort"]);
                smtp_Client.Credentials = new System.Net.NetworkCredential(smtpUserName,smtpPassword);
                smtp_Client.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationSettings.AppSettings["enableSSL"]);
                smtp_Client.Send(mail);
            
        }
    }
}