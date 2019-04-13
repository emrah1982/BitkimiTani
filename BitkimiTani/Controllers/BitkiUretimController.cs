using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityClassLibrary;
using BusinessClassLibrary;

namespace BitkimiTani.Controllers
{
    public class BitkiUretimController : ApiController
    {
        BitkiUretimBO uretimBO = new BitkiUretimBO();
      

        // GET: api/BitkiUretim/5
        [HttpGet]
        public string BitkiUretimBilgileri(int bitkiAd_ID)
        {
            var bitkiUretimBilgileri = uretimBO.GetBitkiUretimBilgileri(bitkiAd_ID);
            return bitkiUretimBilgileri;
        }

        // POST: api/BitkiUretim
        [HttpPost]
        public string BitkiUretimEkle(BitkiUretim uretim)
        {
            var bitkiUretimEkle = uretimBO.GetBitkiUretimBilgileriEkleGuncelle(uretim);
            return bitkiUretimEkle;
        }

        // PUT: api/BitkiUretim/5
        [HttpPut]
        public string BitkiUretimGuncelle(BitkiUretim uretim)
        {
            var bitkiUretimGuncelle = uretimBO.GetBitkiUretimBilgileriEkleGuncelle(uretim); 
            return bitkiUretimGuncelle;
        }

    }
}
