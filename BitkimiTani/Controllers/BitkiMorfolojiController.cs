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
    public class BitkiMorfolojiController : ApiController
    {
        MorfolojiBitkiBO morfolojiBO = new MorfolojiBitkiBO();
        
        // GET: api/BitkiMorfoloji
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BitkiMorfoloji/5
       [HttpGet]
        public string GetBitkiMorfolojiBilgisi(int id)
        {
            BitkiMorfoloji morfoloji = new BitkiMorfoloji();
            morfolojiBO.GetBitkiMorlojiBilgisiBy(morfoloji);
            return "Sectiğiniz Bitkinin Morfoloji Bilgilerini Görüntülüyorsunuz.";
        }

        // POST: api/BitkiMorfoloji
        [HttpPost]
        public string BitkiMorfolojisiEkle(BitkiMorfoloji morfoloji)
        {
            var morfolojiEkle=morfolojiBO.GetBitkiMorfolojiEkleGuncelle(morfoloji);
            return morfolojiEkle;
        }

        // PUT: api/BitkiMorfoloji/5
        [HttpPut]
        public string BitkiMorfolojisiGuncelle(int id, BitkiMorfoloji morfoloji)
        {
           var morfolojiGuncelle=morfolojiBO.GetBitkiMorfolojiEkleGuncelle(morfoloji);
            return morfolojiGuncelle;
        }

        // DELETE: api/BitkiMorfoloji/5
        [HttpDelete]
        public void BitkiMorfolojisiSil(int id)
        {
            //TODO Morofolojik veri silme yapılacak / gerek var mı ad silince gözükmeyecek de :))
        }
    }
}
