using BusinessClassLibrary;
using EntityClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitkimiTani.Controllers
{
    public class SistematikBitkiController : ApiController
    {
        static SistematikBitkiBO sistematikBO = new SistematikBitkiBO();
        // GET: api/SistematikBitki
        [HttpGet]
        [Route("api/SistematikBitkiListe")]
        public IEnumerable<string> SistematikBitkiListe()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SistematikBitki/5
        [HttpGet]
        [Route("api/SistematikBitkiSec")]
        public string SistematikBitkiSec(int bitkiID)
        {
            var seciliSistematikListesi = sistematikBO.GetBitkiSistematigiListesi(bitkiID);
            return seciliSistematikListesi;
        }

        // POST: api/SistematikBitki Ekle
        [HttpPost]
        [Route("api/SistematikBitkiEkle")]
        public string SistematikBitkiEkle(BitkiSistematik sistematik)
        {
            var seciliSistematik = sistematikBO.GetBitkiSistematikByEkle(sistematik);
            return seciliSistematik;
        }

        // PUT: api/SistematikBitki/5 Guncelle
        [HttpPut]
        [Route("api/SistematikBitkiGuncelle")]
        public string SistematikBitkiGuncelle(int bitkiID,BitkiSistematik sistematik)
        {
            var seciliSistematik = sistematikBO.GetBitkiSistematikByGuncelle(bitkiID,sistematik);
            return seciliSistematik;
        }

      
    }
}
