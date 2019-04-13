using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
    public class BitkiUretimBO
    {
        BitkiUretimDB bitkiUretim = new BitkiUretimDB();
        public string GetBitkiUretimBilgileri(int bitkiAd_ID)
        {
            var uretimBilgileri = bitkiUretim.GetBitkiUretimBilgileriBy(bitkiAd_ID);
            return uretimBilgileri;
        }

        public string GetBitkiUretimBilgileriEkleGuncelle(BitkiUretim uretim)
        {
            var uretimEkleGuncelle = bitkiUretim.GetBitkiUretimBilgileriEkleGuncelle(uretim);
            return uretimEkleGuncelle;
        }

    }
}
