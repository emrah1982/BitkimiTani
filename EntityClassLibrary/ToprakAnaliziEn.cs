using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
    public class ToprakAnaliziEn
    {

    }
    public class UrunBilgisiEn
    {
        public string UrunAdi { get; set; }
        public string TarimSekli { get; set; }      
    }
    public class NumuneEn
    {
        public string NumuneTuru { get; set; }
        public string NumuneNo { get; set; }
        public int Enlem { get; set; }
        public int Boylam { get; set; }
        public int Derinlik { get; set; }
        public DateTime AnalizTarihi { get; set; }
    }
}
