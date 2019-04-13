using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace BusinessClassLibrary
{
    
    public class MorfolojiBitkiBO
    {

        BitkiMorfolojiDB morfolojiDB = new BitkiMorfolojiDB();

        public string GetBitkiMorlojiBilgisiBy(BitkiMorfoloji morfoloji) {

            if ( morfoloji.Bitki_ID!=0)
            {
                var sonuc = morfolojiDB.GetBitkiMorfolojiBilgisiBy(morfoloji);
            }

            return "Bitki morfolojisi goruntulendi";
        }

        public string GetBitkiMorfolojiEkleGuncelle(BitkiMorfoloji morfoloji)
        {
            if (morfoloji.Bitki_ID!=0)
            {
                var sonuc = morfolojiDB.GetBitkiMorfolojiEkleGuncelleBy(morfoloji);
                return "Bitkinize ait morfoloji bilgisi başarılı bir şekilde Güncellediniz";
            }
            else
            {
                return "Bitki Secimi yapılmadığı için morfoloji bilgisini ekleyemediniz.";
            }
            
        }
    }
}
