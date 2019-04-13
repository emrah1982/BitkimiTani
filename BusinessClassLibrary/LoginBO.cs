using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataClassLibrary;
using EntityClassLibrary;
using ToolsClassLibrary;

namespace BusinessClassLibrary
{

    public class LoginBO
    {

        public List<KullaniciBilgileriEn> GetKullaniciLoginIslemleriBy(string email, string sifre)
        {
            var kullanici = new KullaniciBilgileriEn()
            {
                Email = email,
                Sifre = sifre
            };
            var list = new List<KullaniciBilgileriEn>();
            if (!string.IsNullOrEmpty(kullanici.Email) && !string.IsNullOrEmpty(kullanici.Sifre))
            {     
                LoginDB login = new LoginDB();
                list = login.KullaniciEmailVeSifre(kullanici.Email, kullanici.Sifre);
                HttpContext.Current.Response.Redirect("~/BitkiDetay.aspx");
            }
            else
            {
                HttpContext.Current.Response.Redirect("~/Login.aspx");
            }
            return list;
        }

        public void GetKullaniciEkleBy(KullaniciBilgileriEn kullaniciBilgileri)
        {
            LoginDB login = new LoginDB();
            login.GetYeniKullaniciEkleBy(kullaniciBilgileri);
        }

        public void GetSifremiUnuttumMailGonderBy(string email)
        {
            //Yapılacaklar
            //1. kontrol email var mı ona bakılacak
            //2. varsa mail atılacak kişiye

            var kullanici = new KullaniciBilgileriEn()
            {
                Email = email,
            };

            LoginDB login = new LoginDB();
            if (login.GetSifremiUnuttumBy(kullanici.Email) == false)
            {
                MailSendTO ayarlar = new MailSendTO();
                ayarlar.MailAyarlari();

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(kullanici.Email);
                mailMessage.To.Add(kullanici.Email);

                //TODO list deki degerleri nasıl alabilirim degişkenlerin yerine yazdım Bu mantık dogrumu?

                string ad = "";
                string soyad = "";
                string sifre = "";
                foreach (var bilgi in login.GetKullaniciKaydiBilgileri(kullanici.Email))
                {
                    ad = bilgi.Ad;
                    soyad = bilgi.Soyad;
                    sifre = bilgi.Sifre;
                }
                string SifreOnay = Guid.NewGuid().ToString("N").Substring(0, 6);
                mailMessage.Subject = "Bitkimi Tanı'dan Kullanıcı Şifrenizi Hatırlatma";
                mailMessage.Body = "Merhaba,<br/>Lütfen giriş bilgilerinizi kontrol ediniz.<br/> Kullanıcı Adınız:" + ad + "" + " " + " " + soyad + "<br/><br/>Şifreniz :" + SifreOnay + "";

                //Veri tabanına kaydediyorum burda sifreyi
                login.MailSifreOnayKoduOlustur(SifreOnay, kullanici.Email);

                // throw new Exception("Mail Gönderme işlemi sırasında hata oluştu"); //Hata fırlatma işi dogru mu?
                Hata hata = new Hata();
                var hataOlustu = hata.ToString();//Hatayı bu şekilde yakalama şansım nedir? varsa veri tabanına kaydetcem :))

            }
        }


        public bool GetKullaniciGirisi(string email,string sifre) {
            LoginDB loginDB = new LoginDB();
            if (loginDB.GetKullaniciGiris(email,sifre))
            {

                HttpContext.Current.Response.Redirect("~/BitkiDetay.aspx");                
            }
            else
            {
                HttpContext.Current.Response.Redirect("~/Login.aspx");
            }
            return false;
        }
    }
}
