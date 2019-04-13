using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ToolsClassLibrary
{
    public class MailSendTO
    {
        SmtpClient client = new SmtpClient();
        public void GetMail(string sendMailAdress, string subject, string body)
        {
          
            MailAddress from = new MailAddress("mailAdresi@gmail.com");
            MailAddress to = new MailAddress("info@bitkimitani.com");
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = subject;
            msg.Body += "Gönderen Mail Adresi" + to + " | <h1>" + body + "</h1>";
            msg.CC.Add(sendMailAdress);//Herkes görür

            MailAyarlari();

            client.Send(msg);

        } 

        public void MailAyarlari()
        {
            NetworkCredential info = new NetworkCredential("emrahaktas82@gmail.com", "Qwedsa931382!");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = info;
            
        }
    }
}
