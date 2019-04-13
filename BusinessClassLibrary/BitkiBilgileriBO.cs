using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using ToolsClassLibrary;

namespace BusinessClassLibrary
{

    public class BitkiBilgileriBO
    {
        BitkiAdlariDB bitkiAd = new BitkiAdlariDB();
       static BitkiAdlari adlar = new BitkiAdlari();

        public void GetBitkiAdlariListesi()
        {
            var sonuc = bitkiAd.GetBitkiAdiListe();
        }

        public string GetBitkiAdiGetirBO(int bitkiID)
        {
            var ad = new BitkiAdlari()
            {
                ID = bitkiID
            };
            return bitkiAd.GetBitkiAdGetirBy(ad.ID);
        }
        public string GetBitkiAdlariEkleBO(BitkiAdlari ad)
        {
            return bitkiAd.GetBitkiAdiByEkle(ad);
        }

        public string GetBitkiAdlariGuncelleBO(int bitkiID, BitkiAdlari ad)
        {
            return bitkiAd.GetBitkiAdlariGuncelleByDB(bitkiID, ad);
        }

        public string GetBitkiAdlariSilBO(int bitkiID)
        {
            return bitkiAd.GetBitkiAdiSilByDB(bitkiID);
        }




    }





}
