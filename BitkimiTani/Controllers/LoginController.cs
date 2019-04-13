using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityClassLibrary;
using BusinessClassLibrary;
using ToolsClassLibrary;
using Newtonsoft.Json;

namespace BitkimiTani.Controllers
{

    public class LoginController : ApiController
    {
        LoginBO kullaniciLogin = new LoginBO();
        // GET: api/Login
        [HttpGet]
        //[Route("api/LoginGiris/{kullaniciAdi}/{sifre}")]
        [Route("api/LoginGiris")]
        public HttpResponseMessage LoginGiris([FromBody] string email, [FromBody]string sifre)
        {
            if (kullaniciLogin.GetKullaniciGirisi(email, sifre))
            {

                var token ="";

                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Kullanıcı Adınız veya Şifreniz Hatalı");
            }

        }


        [HttpGet]  // GET: api/Login/Kullanıcı Giris Ekranı?
        [Route("api/KullaniciGiris")]
        public List<KullaniciBilgileriEn> GetKullaniciBul(KullaniciBilgileriEn kullanici)
        {
            var list = new List<KullaniciBilgileriEn>();
            var KullaniciBulundu = kullaniciLogin.GetKullaniciLoginIslemleriBy(kullanici.Email, kullanici.Sifre);
            return list;
        }


        [HttpPost] // POST: api/Login Yeni Kullanici Ekleme
        [Route("api/KullaniciEkle")]
        public HttpResponseMessage GetYeniKullaniciEkleBy([FromBody] KullaniciBilgileriEn kullaniciBilgileri)
        {
            //var kullaniciEkle = JsonConvert.SerializeObject(yeniUyeEkle);
            kullaniciLogin.GetKullaniciEkleBy(kullaniciBilgileri);
            return Request.CreateResponse(HttpStatusCode.Created, "Yeni Üye Kaydınız Başarılı Bir Şekilde Oluşturuldu");
        }


        [HttpPut]  //(Güncelleme) PUT: api/Login/ Şifremi Unuttum
        [Route("api/SifremiUnuttum")]
        public void GetSifremiUnuttum([FromBody] string email)
        {
            var mail = new KullaniciBilgileriEn()
            {
                Email = email
            };
            // var jsonString = JsonConvert.SerializeObject(mail);
            kullaniciLogin.GetSifremiUnuttumMailGonderBy(mail.Email);
        }

        // DELETE: api/Login/5
        [HttpDelete]
        public void GetUyelikIptaliBy(int id)
        {

        }
    }
}
