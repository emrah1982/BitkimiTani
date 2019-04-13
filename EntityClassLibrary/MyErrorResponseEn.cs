using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
    public class MyErrorResponseEn
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string HataMesaji { get; set; }
        public string HataOlayi { get; set; }
        public string HataKontrolir { get; set; }
        public DateTime HataZamani { get; set; }

    }
}
