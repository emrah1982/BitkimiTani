using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitkimiTani.MyFilter
{
    public interface Yetkiler
    {
    }

    public class SeraFirma
    {
        public void Mudur() { }
        public void Personel() { }
        public void Bahcevan() { }
        public void Muhendis() { }
    }

    public class BatonikFirma
    {
        public void Admin(int yetki)
        {
            var yetkiKontrol = (yetki & (int)Yetki.Admin) != 0;
        }
        public void GenelMudur(int yetki)
        {
            var yetkiKontrol = (yetki & (int)Yetki.YoneticiAsistani) != 0;
        }
        public void Gonullu(int yetki)
        {
            var yetkiKontrol = (yetki & (int)Yetki.Gonullu) != 0;
        }
        public void Asistan(int yetki)
        {
            var yetkiKontrol = (yetki & (int)Yetki.Asistan) != 0;
        }

    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Yetki yetki = Yetki.Admin;
    //        YetkiAta(yetki);
    //    }

    //    static void YetkiAta(Yetki yetkiler)
    //    {
    //        Console.WriteLine("Verilen Yetkiler: " + yetkiler.ToString());

    //        if (yetkiler.HasFlag(Yetki.Ekleme))
    //        {
    //            Console.WriteLine("Ekleme yetkisi istendi");
    //        }
    //        if (yetkiler.HasFlag(Yetki.Silme))
    //        {
    //            Console.WriteLine("Silme yetkisi istendi");
    //        }
    //        if (yetkiler.HasFlag(Yetki.Degistirme))
    //        {
    //            Console.WriteLine("Degistirme yetkisi istendi");
    //        }
    //    }
    //}
    public class YetkiAta
    {
        public YetkiAta(int yetkiID)
        {
            Yetki yetkiler = new Yetki();
            if (yetkiler.HasFlag(Yetki.KullaniciEkle))
            {
                Console.WriteLine("Ekleme yetkisi istendi");
            }
            if (yetkiler.HasFlag(Yetki.KullaniciGuncelle))
            {
                Console.WriteLine("Güncelleme yetkisi istendi");
            }
            if (yetkiler.HasFlag(Yetki.KullaniciSil))
            {
                Console.WriteLine("Silme yetkisi istendi");
            }
        }

        public YetkiAta(string YetkiTuru)
        {
            //TODO Yetki turunu string tipinde deger göndermeye çalış
        }
    }


    [Flags]
    public enum Yetki
    {
        KullaniciEkle = 1,
        KullaniciGuncelle = 2,
        KullaniciSil = 4,

        DuyuruEkle = 8,
        DuyuruGuncelle = 16,
        DuyuruSil = 32,

        BitkiEkle = 64,
        BitkiGuncelle = 128,
        BitkiSil = 256,

        GrupEkle = 512,
        GrupGuncelle = 1024,
        GrupSil = 2048,

        //TODO yetki kontrol  sayfası mantıklı gelmedi kullanıcı yetkilerini kendisi belirlesin (YatkiAta Metodu)

        Admin = KullaniciEkle | KullaniciGuncelle | KullaniciSil | DuyuruEkle | DuyuruGuncelle | DuyuruSil | BitkiEkle | BitkiGuncelle | BitkiSil | GrupEkle | GrupGuncelle | GrupSil,

        Moderator = KullaniciEkle | DuyuruEkle | GrupEkle,

        YoneticiAsistani = KullaniciEkle | KullaniciGuncelle | KullaniciSil | DuyuruEkle | DuyuruGuncelle | DuyuruSil | BitkiEkle | BitkiGuncelle | BitkiSil,

        Gonullu = DuyuruEkle | BitkiEkle | GrupEkle,

        Asistan = DuyuruEkle | DuyuruGuncelle | BitkiEkle | BitkiGuncelle | GrupEkle | GrupSil,



    }
}