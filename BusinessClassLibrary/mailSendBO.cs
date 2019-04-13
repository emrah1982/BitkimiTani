using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using ToolsClassLibrary;

namespace BusinessClassLibrary
{
   public class mailSendBO
    {
        public void GetMailSend (string sendMailAdress, string subject, string body)
        {
            //Todo Mail gönder
            MailSendTO kullanici = new MailSendTO();
            kullanici.GetMail(sendMailAdress, subject, body);
        }
    }
}
