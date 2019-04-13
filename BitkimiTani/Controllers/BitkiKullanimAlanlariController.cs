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
    public class BitkiKullanimAlanlariController : ApiController
    {
        BitkiKullanimBO kullanimBO = new BitkiKullanimBO();

        // GET: api/BitkiKullanimAlanlari
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiKullanimAlanlari/5
        [HttpGet]
        public string BitkiKullanimAlanlariBilgisi(int bitkiAdID)
        {
            var kullanimBilgisi = kullanimBO.GetBitkiKullanimBy(bitkiAdID);
            return kullanimBilgisi;
        }

        // POST: api/BitkiKullanimAlanlari
        [HttpPost]
        public string BitkiKullanimEkleGuncelle(BitkiKullanimAlanlari bitkiKullanim)
        {
            var bitkiEkleGuncelle = kullanimBO.GetKullanimAlanlariEkleGuncelle(bitkiKullanim);
            return bitkiEkleGuncelle;
        }

        //// PUT: api/BitkiKullanimAlanlari/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/BitkiKullanimAlanlari/5
        //public void Delete(int id)
        //{
        //}
    }
}
