using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFull.Models
{
    public class Bitki
    {

        private App_Data.BitkimiTaniEntities ent;
        public Bitki()
        {
            ent = new App_Data.BitkimiTaniEntities();
        }

        public List<App_Data.BitkiAd_tbl> GetBitkiAdlari()
        {
            var liste = (from d in ent.BitkiAd_tbl orderby d.TurkceAdi ascending select d).ToList();
            return liste;
        }


    }
}