using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityClassLibrary;
using BusinessClassLibrary;
using BitkimiTani.MyFilter;
using System.Threading;

namespace BitkimiTani.Controllers
{
    //[MyModelValidation]
    //[MyAuthorization]
    public class KullaniciController : ApiController
    {
        public string LogoOnKullanici()
        {
            return Thread.CurrentPrincipal.Identity.Name;
        }

        // POST: api/Kullanici
        [HttpPost]
        [Route("api/yeniKullaniciEkle")]
        public HttpResponseMessage yeniKullaniciEkle(KullaniciBilgileriEn kullaniciBilgileri)
        {
            try
            {
                LoginBO yeniKullanici = new LoginBO();
                yeniKullanici.GetKullaniciEkleBy(kullaniciBilgileri);
               return Request.CreateResponse(HttpStatusCode.Created, "Yeni Kullanici Kaydı Oluşturuldu.");
            }
            catch (Exception ex)
            {
               return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/UyeGiris")]
        public List<KullaniciBilgileriEn> KullaniciLoginGirisi(string email, string sifre)
        {
            LoginBO kullaniciGiris = new LoginBO();
            return kullaniciGiris.GetKullaniciLoginIslemleriBy(email, sifre);
        }


        //[HttpPost]
        //public void YeniKullaniciEkle([FromBody] string kullaniciAdi, string kullaniciSoyadi, string cepTelefonu, string adres, int sehir, string email, string sifre, bool onay)
        //{
        //    LoginBO yeniKullanici = new LoginBO();
        //    yeniKullanici.GetKullaniciEkleBy(kullaniciAdi, kullaniciSoyadi, cepTelefonu, adres, sehir, email, sifre, onay);

        //    // return "asd";
        //}


    }
}
