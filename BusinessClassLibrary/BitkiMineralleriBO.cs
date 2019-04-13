using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
   public class BitkiMineralleriBO
    {
        BitkiMineralleriDB mineralleriDB = new BitkiMineralleriDB();
        public string GetBitkiMineralleriBy(int bitkiAd_ID) {
           
            
                var bitkiMineralBilgileri = mineralleriDB.GetToprakMineralBilgisiBy(bitkiAd_ID);
                return bitkiMineralBilgileri;
            
           

        }

        public string GetBitkiMineralleriEkleGuncelleBy(BitkiMineralleri bitkiMineralleri)
        {
            var bitkiMineralBilgileriEkleGuncelle = mineralleriDB.GetToprakMineralleriBilgisiEkleGuncelle(bitkiMineralleri);
            return bitkiMineralBilgileriEkleGuncelle;
                       
        }
    }
}
