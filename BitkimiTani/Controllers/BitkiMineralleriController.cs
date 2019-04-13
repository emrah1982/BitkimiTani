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
    public class BitkiMineralleriController : ApiController
    {
        BitkiMineralleriBO mineralleriBO = new BitkiMineralleriBO();
        // GET: api/BitkiMineralleri
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiMineralleri/5
        [HttpGet]
        public string BitkiMineralleri(int bitkiAdID)
        {
            var bitkiMineralBilgileri = mineralleriBO.GetBitkiMineralleriBy(bitkiAdID);
            return bitkiMineralBilgileri;
        }

        // POST: api/BitkiMineralleri
        [HttpPost]
        public string BitkiMineralleriEkleGuncelle(BitkiMineralleri bitkiMineralleri)
        {
            var bitkiMineralBilgileriEkleGuncelle = mineralleriBO.GetBitkiMineralleriEkleGuncelleBy(bitkiMineralleri);
            return bitkiMineralBilgileriEkleGuncelle;
        }

        //// PUT: api/BitkiMineralleri/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/BitkiMineralleri/5
        //public void Delete(int id)
        //{
        //}
    }
}
