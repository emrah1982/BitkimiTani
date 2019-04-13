using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitkimiTani.Controllers
{
    public class YaprakTipiController : ApiController
    {
        // GET: api/YaprakTipi
        public IEnumerable<string> Get()
        {
            //TODO yaprak tipi tablolarına veri eklenecek
            return new string[] { "value1", "value2" };
        }

        // GET: api/YaprakTipi/5
        [HttpGet]
        public string YaprakTipiBilgisi(int id)
        {
            return "value";
        }

        // POST: api/YaprakTipi
        [HttpPost]
        public void YaprakTipiEkle([FromBody]string value)
        {
        }

        // PUT: api/YaprakTipi/5
        [HttpPut]
        public void YaprakTipiGuncelle(int id, [FromBody]string value)
        {
        }

        // DELETE: api/YaprakTipi/5
        [HttpDelete]
        public void YaprakTipiSil(int id)
        {

        }
    }
}
