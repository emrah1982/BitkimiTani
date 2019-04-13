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
    public class BitkiTanimaController : ApiController
    {
        BitkiTanimaBO tanimaBO = new BitkiTanimaBO();
        //// GET: api/BitkiTanima
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/BitkiTanima/5
        [HttpGet]
        public string GetBitkiTanimaBilgileri(int bitkiAd_ID)
        {
            var bitkiTanimaBilgileri = tanimaBO.GetBitkiTanimaListeleBy(bitkiAd_ID);
            return bitkiTanimaBilgileri;
        }

        // POST: api/BitkiTanima
        [HttpPost]
        public string GetBitkiTanimaEkleGuncelle(BitkiTanima tanima)
        {
            var bitkiTanimaEkleGuncelle = tanimaBO.GetBitkiTanimaEkleGuncelleBy(tanima);
            return bitkiTanimaEkleGuncelle;
        }

        //// PUT: api/BitkiTanima/5
        //[HttpPut]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/BitkiTanima/5
        //[HttpDelete]
        //public void Delete(int id)
        //{
        //}
    }
}
