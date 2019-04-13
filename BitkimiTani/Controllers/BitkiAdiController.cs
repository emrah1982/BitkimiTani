using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using BitkimiTani.MyFilter;
using BusinessClassLibrary;
using EntityClassLibrary;


namespace BitkimiTani.Controllers
{
    [MyError]
    public class BitkiAdiController : ApiController
    {
        // GET: api/BitkiAdi
        static BitkiBilgileriBO bitkiBilgileri = new BitkiBilgileriBO();
       

        public IEnumerable<string> Get()
        {
         
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiAdi/5
        [HttpGet]
        [Route("api/SeciliBitkiAdi")]
        public string SeciliBitkiAdi(int bitkiID)
        {
            var seciliBitkiAdi = bitkiBilgileri.GetBitkiAdiGetirBO(bitkiID);
            return seciliBitkiAdi;
        }

        // POST: api/BitkiAdi ---Ekleme
        [HttpPost]
        [Route("api/BitkiAdiEkle")]
        public string EkleBitkiAdi(BitkiAdlari ad)
        {
            var ekleBitkiAdi = bitkiBilgileri.GetBitkiAdlariEkleBO(ad);
            return ekleBitkiAdi;
        }

        // PUT: api/BitkiAdi/5 --- Guncelleme
        [HttpPut]
        [Route("api/BitkiAdiGuncelle")]
        public string GuncelleBitkiAdi(int bitkiID, BitkiAdlari ad)
        {
            var guncelleBitkiAdi = bitkiBilgileri.GetBitkiAdlariGuncelleBO(bitkiID, ad);
            return guncelleBitkiAdi;
        }

        // DELETE: api/BitkiAdi/5
        [HttpDelete]
        [Route("api/BitkiAdiSil")]
        public string SilBitkiAdi(int bitkiID)
        {
            var silBitkiAdi = bitkiBilgileri.GetBitkiAdlariSilBO(bitkiID);
            return silBitkiAdi;
        }

    }
}
