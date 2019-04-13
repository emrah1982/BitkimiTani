using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using ToolsClassLibrary;

namespace DataClassLibrary
{
    public class MailDB
    {
        //TODO veri tabanı işlemleri yapılacak
        //TODO Eksikleri var tamamla şifremi unuttum dendiğinde içine güvenlik link koyarak uye olmasını sagla
        BaglantiDB baglan = new BaglantiDB();
        public string MailKaydet(MailSendEn mailSend)
        {
            SqlConnection con = baglan.Baglanti();
            SqlCommand com = new SqlCommand("insert into Mail_tbl (KullaniciID,MailKonusu,MailBaslik,GonderilmeTarihi=GetDate()) values(@KullaniciID,@MailKonusu,@MailBaslik,)", con);
            com.Parameters.AddWithValue("@KullaniciID", mailSend.Kullanici_ID);
            com.Parameters.AddWithValue("@MailKonusu", mailSend.Body);
            com.Parameters.AddWithValue("@MailBaslik", mailSend.Subject);
            com.ExecuteNonQuery();
            return "Gönderilen Mail Veritabanına Kaydedildi";
        }

        //TODO Mail Onay kodu gönderilecek ve kaydedilecek
        public string MailOnayKodu(MailSendEn mailOnay)
        {
            //TODO Mail Onay kodu GUİD yapıldı

            return "asd";
        }

    }
}
