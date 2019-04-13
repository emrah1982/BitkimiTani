using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary.EnumType
{
    public class enumType
    {
        public enum Mevsimler : byte
        {
            ilkbahar = 0,
            yaz = 1,
            sonbahar = 2,
            kıs = 3
        }

        public enum Aylar : byte
        {
            Ocak = 0, Şubat = 1, Mart = 2, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık

        }

        public enum KullaniciTipi : byte
        {
            Demo = 0,
            Kullanici = 1,
            Yonetici = 2,

        }

        public enum YetkiTipi : byte { Okuma = 0, Ekleme = 1, Silme = 2, Guncelleme = 3 }


    }
}
