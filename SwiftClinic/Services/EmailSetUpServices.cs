using System;
using System.Configuration;
using System.Net.Mail;

namespace SwiftClinic.Services
{

    public class EmailSetUpServices : SmtpClient
    {
        // Gmail user-name
        public string UserName { get; set; }

        public EmailSetUpServices() :
            base(ConfigurationManager.AppSettings["GmailHost"], Int32.Parse(ConfigurationManager.AppSettings["GmailPort"]))
        {
            //Get values from web.config file:
            this.UserName = ConfigurationManager.AppSettings["GmailUserName"];
            this.EnableSsl = Boolean.Parse(ConfigurationManager.AppSettings["GmailSsl"]);
            this.UseDefaultCredentials = false;
            //this.DeliveryMethod = SmtpDeliveryMethod.Network;
            this.Credentials = new System.Net.NetworkCredential(this.UserName, ConfigurationManager.AppSettings["GmailPassword"]);
        }


    }
}