using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
   public class EkolojiBitkiBO
    {
        BitkiEkolojiDB ekolojiDB = new BitkiEkolojiDB();
        public string GetSeciliBitkiEkolojiBilgisi(int bitkiAdID)
        {
            ekolojiDB.EkolojiListesi(bitkiAdID);
            return "Sectiğiniz Bitkinin Ekolojik Bilgileri Listelendi";
        }

        public string GetEkolojikBilgiEkleGuncelle(BitkiEkoloji ekoloji) {
            var sonuc = ekolojiDB.GetEkolojiEkleGuncelleBy(ekoloji);
            return sonuc;
        }
    }
}
