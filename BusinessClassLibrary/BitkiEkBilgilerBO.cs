using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
    public class BitkiEkBilgilerBO
    {
        BitkiEkBilgilerDB ekBilgilerDB = new BitkiEkBilgilerDB();
        public string GetBitkiEkBilleriBy(int bitkiAd_ID) {

            var bitkiEkBilgileri = ekBilgilerDB.GetBitkiEkBilgileriBy(bitkiAd_ID);
            return bitkiEkBilgileri; 
        }

        public string GetBitkiEkBilgileriEkleGuncelle(BitkiEkBilgiler bitkiEk)
        {
            var bitkiEkBilgiler = ekBilgilerDB.GetBitkiEkBilgiEkleGuncelle(bitkiEk);
            return bitkiEkBilgiler;

        }

    }
}
