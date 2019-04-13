using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
   public class BitkiKullanimBO
    {
        BitkiKullanimAlanlariDB alanlariDB = new BitkiKullanimAlanlariDB();
        public string GetBitkiKullanimBy(int bitkiAd_ID)
        {

            var bitkiKullanimBilgileri = alanlariDB.GetBitkiKullanimAlanlariBy(bitkiAd_ID);
            return bitkiKullanimBilgileri;
        }

        public string GetKullanimAlanlariEkleGuncelle(BitkiKullanimAlanlari bitkiKullanim)
        {
            var kullanimEkleGuncelle = alanlariDB.GetKullanimAlanlariEkleGuncelle(bitkiKullanim);
            return kullanimEkleGuncelle;

        }

    }
}
