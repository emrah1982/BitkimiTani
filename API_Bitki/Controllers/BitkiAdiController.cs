using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using BusinessClassLibrary;
using EntityClassLibrary;


namespace API_Bitki.Controllers
{
    public class BitkiAdiController : ApiController
    {
        // GET: api/BitkiAdi
        static BitkiBilgileriBO bitkiBilgileri = new BitkiBilgileriBO();
        //TODO bu dogru mu static yaptım

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiAdi/5
        [HttpGet]
        [Route("{id:int}", Name = "SeciliBitkiAdi")]
        public string SeciliBitkiAdi(BitkiAdlari bitkiAdi)
        {
            var seciliBitkiAdi = bitkiBilgileri.GetBitkiAdiGetirBO(bitkiAdi);
            return seciliBitkiAdi;
        }

        // POST: api/BitkiAdi ---Ekleme
        [HttpPost]
        //TODO [FromBody] string name amacı nedir ve kullanımı nasıl oluyor?
        public string EkleBitkiAdi([FromBody] string TurkceAdi, string LatinceAdi, BitkiAdlari bitkiAdi)
        {
            var ekleBitkiAdi = bitkiBilgileri.GetBitkiAdlariEkleBO(bitkiAdi);
            return ekleBitkiAdi;
        }

        // PUT: api/BitkiAdi/5 --- Guncelleme
        [HttpPut]
        public string GuncelleBitkiAdi(BitkiAdlari bitkiAdi)
        {
            var guncelleBitkiAdi = bitkiBilgileri.GetBitkiAdlariGuncelleBO(bitkiAdi);
            return guncelleBitkiAdi;
        }

        // DELETE: api/BitkiAdi/5
        [HttpDelete]
        public string SilBitkiAdi(BitkiAdlari bitkiAdi)
        {
            var silBitkiAdi = bitkiBilgileri.GetBitkiAdlariSilBO(bitkiAdi);
            return silBitkiAdi;
        }
 
    }
}
