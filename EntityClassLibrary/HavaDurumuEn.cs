using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
    public class HavaDurumuEn
    {
        public int Il { get; set; }
        public int ilce { get; set; }
        public int YagisMiktari { get; set; }
        public int UcEnDusukSicaklik { get; set; }
        public int UcEnYuksekSicaklik { get; set; }
        public int OrtalamaEnDusukSicaklik { get; set; }
        public int OrtalamaEnYuksekSicaklik { get; set; }
        public int Nem_HavaDurumu { get; set; }
        public string RuzgarYonu { get; set; }
        public int OrtRuzgarHizi { get; set; }
        public int MaxRuzgarHizi { get; set; }
        public int Saat_HavaDurumu { get; set; }
        public DateTime Tarih_HavaDurumu { get; set; }
        public int Aktüel_Basinc { get; set; }
        public string image_HavaDurumu { get; set; }
        public int Rakim { get; set; }
        public int Saat_GunDogumu { get; set; }
        public int Saat_GunBatimi { get; set; }
    }
}
