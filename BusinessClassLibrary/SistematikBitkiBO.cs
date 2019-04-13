using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using ToolsClassLibrary;

namespace BusinessClassLibrary
{
    public class SistematikBitkiBO
    {

        BitkiSistematikDB sistematik = new BitkiSistematikDB();

        //TODO Bitki sistematik listeleme işi bu şekilde mi
        //public List<BitkiSistematik> BitkiSistematigiList(BitkiSistematik bitkiSistematik)
        //{
        //    return
        //}

        public string GetBitkiSistematigiListesi(int bitkiID)
        {
            BitkiSistematik bitkiSistematik = new BitkiSistematik();
            if (bitkiSistematik.Bitki_ID !=0)
            {
                var sonuc = sistematik.GetBitkiSistematikByListe(bitkiSistematik.Bitki_ID);
            }
            return "Bitki Sistematik Bilgileri Listelendi";
        }

        public string GetBitkiSistematikByEkle(BitkiSistematik bitkiSistematik)
        {
            //Bitki Sistematiği Ekleme ve güncelleme yapıyor
            return sistematik.GetBitkiSistematikByEkle(bitkiSistematik);
        }
        public string GetBitkiSistematikByGuncelle(int bitkiID, BitkiSistematik bitkiSistematik)
        {
            return sistematik.GetBitkiSistematikByGuncelle(bitkiID, bitkiSistematik);
        }


    }
}
