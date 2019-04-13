using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
   public class GoruntuIslemeAyarlariEn
    {
        // Resim ID yi int olarak yapmak istedim string de yapınca kızması geçti
        //public string Resim_ID { get; set; } = Guid.NewGuid().ToString();
        public int Bitki_ID { get; set; }
        public int Threshold { get; set; }
        public int ResimBoyutlari { get; set; }
        public int Blur { get; set; }
        public int Kontstrat { get; set; }
        public string ResimYolu { get; set; }
   
    }
}
