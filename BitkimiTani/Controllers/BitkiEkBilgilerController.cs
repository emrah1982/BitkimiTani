using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessClassLibrary;
using EntityClassLibrary;

namespace BitkimiTani.Controllers
{
    public class BitkiEkBilgilerController : ApiController
    {

        BitkiEkBilgilerBO bilgilerBO = new BitkiEkBilgilerBO();
        // GET: api/BitkiEkBilgiler
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiEkBilgiler/5
        [HttpGet]
        public string GetEkBilgilerBy(int bitkiAd_ID)
        {
            var ekBilgiler = bilgilerBO.GetBitkiEkBilleriBy(bitkiAd_ID);
            return ekBilgiler;
        }

        // POST: api/BitkiEkBilgiler
        [HttpPost]
        public string GetBitkiEkBilgilerEkleGuncelleBy(BitkiEkBilgiler bitkiEk)
        {
            var bitkiEkBilgiEkleGuncelle = bilgilerBO.GetBitkiEkBilgileriEkleGuncelle(bitkiEk);
            return bitkiEkBilgiEkleGuncelle;
        }

        //// PUT: api/BitkiEkBilgiler/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/BitkiEkBilgiler/5
        //public void Delete(int id)
        //{
        //}
    }
}
