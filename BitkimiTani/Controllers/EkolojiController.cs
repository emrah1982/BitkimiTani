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
    public class EkolojiController : ApiController
    {
        EkolojiBitkiBO ekolojiBO = new EkolojiBitkiBO();
        // GET: api/Ekoloji
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ekoloji/5
        [HttpGet]
        public string SeciliEkolojiBilgisi(int bitkiAdID)
        {
            ekolojiBO.GetSeciliBitkiEkolojiBilgisi(bitkiAdID);

            return "Secilen Bitki Verileri Getirildi.";
        }

        // POST: api/Ekoloji
        [HttpPost]
        public string EkolojiBilgisiEkle(BitkiEkoloji ekoloji)
        {
           var ekolojiEkle=ekolojiBO.GetEkolojikBilgiEkleGuncelle(ekoloji);
            return ekolojiEkle;
        }

        // PUT: api/Ekoloji/5
        [HttpPut]
        public void EkolojiBilgisiGuncelle(BitkiEkoloji ekoloji)
        {
            ekolojiBO.GetEkolojikBilgiEkleGuncelle(ekoloji);
        }

        // DELETE: api/Ekoloji/5
        public void Delete(int id)
        {
        }
    }
}
