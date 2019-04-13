using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
    public class MailSendEn
    {
        public int ID { get; set; }
        [Required]
        public int Kullanici_ID { get; set; }
        public string MailOnayKodu { get; set; } = Guid.NewGuid().ToString();
        public string SendMailAdress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


        public DateTime EklenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }
}
