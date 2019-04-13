using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
   public class BitkiTanimaBO
    {
        BitkiTanimaDB tanimaDB = new BitkiTanimaDB();
        public string GetBitkiTanimaListeleBy(int bitkiTanima_ID) {
            //var tanima = new BitkiTanima();
            if (bitkiTanima_ID != 0)
            {
                var bitkimiTaniBilgileri = tanimaDB.GetBitkiTanimaBilgileriBy(bitkiTanima_ID);
                return bitkimiTaniBilgileri;
            }
            else
            {
                return "Lütfen Bilginizi Seçiniz";
            }
            
        }

        public string GetBitkiTanimaEkleGuncelleBy(BitkiTanima tanima)
        {
            var bitkiEkleGuncelle = tanimaDB.GetBitkiTaEklemeGuncelleme(tanima);
            return bitkiEkleGuncelle;
        }

    }
}
