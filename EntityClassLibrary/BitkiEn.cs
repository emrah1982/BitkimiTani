using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityClassLibrary
{
    public class BitkiSuOrani
    {
        //Bitki ucunda % 91-93
        //YApraklarında % 75 -85
        //Odunda % 50-60
    }

    public class MorOtesiIsinlar
    {
        //120-140 nm dalga arasında dalga boylari
    }

    public class BitkiResimleri
    {
        public int BitkiID { get; set; }
        public string Image_Genel { get; set; }
        public string Image_Govde { get; set; }
        public string Image_Cicek { get; set; }
        public string Image_Meyve { get; set; }
        public string Image_Yaprak { get; set; }
        public string Image_MineralEksikligi { get; set; }
        public string Image_Hastaliklari { get; set; }
        public string Image_Zararlilari { get; set; }
    }
    public class BitkiAdlari
    {

        public int ID { get; set; }
        [Display(Name = "Türkçe Adı")]
        // [Required(ErrorMessage = "Lütfen Türkçe Adını Giriniz")]
        [StringLength(60, ErrorMessage = ("Türkçe Adı 60 karakterden Büyük olamaz"))]
        // [MinLength(10,ErrorMessage =("Türkçe Adı 10 Karakterden Az olamaz"))]      
        public string TurkceAdi { get; set; }

        public string IngilizceAdi { get; set; }
        public string LatinceAdi { get; set; }
        public string YerelAdlari { get; set; }
        public string SinonimAdlari { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }
    public class BitkiSistematik
    {
        public int Bitki_ID { get; set; }
        public string Alem { get; set; }
        public string Bolum { get; set; }
        public string Sinif { get; set; }
        public string Takim { get; set; }
        public string Familya { get; set; }
        public string Cins { get; set; }
        public string Tur { get; set; }
        public string AltTurler { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }
    public class BitkiMorfoloji
    {
        public int Bitki_ID { get; set; }
        public byte YaprakTipiID { get; set; }
        public string FamilyaHakkindaGenelBilgi { get; set; }
        public string CiceklenmeZamani { get; set; }
        //TODO YaprakYapilari adında ayrı bir class ta toplamam (en alt hazırladım) dogru olur mu? veri tipi ni byte yaptım 255 i geçmiyor. 

        public string Kokusu { get; set; }
        public string EnDusukRakim { get; set; }
        public string EnYuksekRakim { get; set; }
        public string Tur { get; set; }
        public string Budama { get; set; }
        public string MeyveTipi { get; set; }
        public string DalFormu { get; set; }
        public string Cicek { get; set; }
        public string CicekRengi { get; set; }
        public string CiceklilikSuresi { get; set; }
        public byte EnUzunBoy { get; set; }
        public byte EnKisaBoy { get; set; }
        public byte OrtalamaBoy { get; set; }
        public string YaprakDizilisi { get; set; }



        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class YaprakTipi
    {
        //TODO nested kullanım mantığı dogru mu? :))
        public class DamarimsiYaprakCesitleri
        {
            public int YaprakTipiID { get; set; }
            public string AgsiDamar { get; set; }
            public string ParalelDamar { get; set; }
            public string BasitDamar { get; set; }
            public string CatalsiDamar { get; set; }
        }

        public class KenarlarinaGoreYaprakCesitleri
        {
            public int YaprakTipiID { get; set; }
            public string DuzKenarlar { get; set; }
            public string DisliKenarlar { get; set; }
            public string BolmeliKenarlar { get; set; }
            public string ParcaKenarlar { get; set; }
        }

        public class DizilislerineGoreYaprakCesitleri
        {
            public int YaprakTipiID { get; set; }
            public string SarmalDizilisliYapraklar { get; set; }
            public string HalkaliDizilisliYapraklar { get; set; }
            public string KarsilikliDizilisliYapraklar { get; set; }
        }
        public class AyasinaGoreYaprakCesitleri
        {
            public int YaprakTipiID { get; set; }
            public string IgneYapraklilar { get; set; }
            public string DikenliYapraklilar { get; set; }
            public string OvalYapraklilar { get; set; }
            public string SeritYapraklilar { get; set; }
            public string SpatulYapraklilar { get; set; }
            public string EtliYapraklilar { get; set; }
        }
    }
    public class BitkiEkoloji
    {
        public int BitkiAd_ID { get; set; }
        public string Iklim { get; set; }
        public string Isik { get; set; }
        public string Sicaklik { get; set; }
        public string Nem { get; set; }
        public string Gorunus { get; set; }
        public string Ca { get; set; }
        public string P { get; set; }
        public string Soc { get; set; }
        public string ToprakEnDusuk_Ph { get; set; }
        public string ToprakEnYuksek_Ph { get; set; }
        public string BolgeSohuklugu { get; set; }
        public string BolgeSicakligiGunsayisi { get; set; }
        public string KusakSoguklugu { get; set; }
        public string KusakSicakligi { get; set; }
        public string ToprakYapisi { get; set; }
        public string Mineraller { get; set; }
        public string ToprakPh { get; set; }

        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class BitkiUretim
    {
        public int BitkiAd_ID { get; set; }
        public string VideoLinki { get; set; }
        public string TohumCimlenmeSicakligi { get; set; }
        public string TohumDikimDerinligi_Max { get; set; }
        public string TohumDikimDerinligi_Min { get; set; }
        public string SulamaYontemi { get; set; }
        public string BakimIhtiyaci { get; set; }
        public string GelisimHizi { get; set; }
        public string SogukKusak { get; set; }
        public string SicakKusak { get; set; }
        public string YillikSicaklikGunSayisi { get; set; }
        public string SogugaDayaniklilikSicaklikAraligi { get; set; }
        public string MevsimineGore { get; set; }
        public string AraziOlcusu { get; set; }
        public string UretimYontemleri { get; set; }
        public string CelikleUretim { get; set; }
        // public virtual List<UretimYontemleri> BitkiUretimYontemleri { get; set; }



        public string SulamaTarihi { get; set; }
        public string RuzgarHizi { get; set; }
        public string OrtamSicakligi { get; set; }

        //public DateTime EklenmeZamani { get; set; }
        //public DateTime GuncellenmeZamani { get; set; }
        //public bool Aktif { get; set; }
        //public bool Silik { get; set; }
    }


    public class UretimYontemleri
    {
        public int BitkiAd_ID { get; set; }
        public int BitkiUretim_ID { get; set; }
        public string CelikleUretim { get; set; }
        public string GozAsisiveyaYaprakAsilari { get; set; }
        public string KalemAsilari { get; set; }
        public string AsiMacunlari { get; set; }
        public string Sulama { get; set; }

        // public BitkiUretim BitkiUretim { get; set; }
    }
    public class BitkiTanima
    {
        public int Bitki_ID { get; set; }
        public string BitkiTipi { get; set; }
        public string ArsizlikDurumu { get; set; }
        public string AnavataniDogalYayılısAlanlariIhtiyaci { get; set; }
        public string YetistigiSehirler { get; set; }
        //Türkiye Genelinde Yetişme Durumu
        public string Tolerans { get; set; }
        public string YetismeDurumu { get; set; }
        public string DogalYasamAlanlari { get; set; }
        public string YasamSuresi { get; set; }
        public string ToksikOzellikler { get; set; }
        public string HangiDonem { get; set; }
        public string BitkiYetismeAlanlari { get; set; }
        public bool Endemik { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class BitkiKullanimAlanlari
    {
        public int Bitki_ID { get; set; }
        public string KullanimAlanlari { get; set; }
        public string PeyzajdaKullanim { get; set; }
        public string TibbiAramotikBitkiler { get; set; }
        public string SusBitkileri { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class BitkiEkBilgiler
    {
        public int Bitki_ID { get; set; }
        public string Kaynaklar { get; set; }
        public string Notlar { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }
    public class BitkiMineralleri
    {
        public int Bitki_ID { get; set; }
        public string MineralAdi { get; set; }
        public string MineralHakkindaBilgi { get; set; }
        public string Nem { get; set; }
        public string MaxMineral { get; set; }
        public string MinMineral { get; set; }
        public string AnalizBirimi { get; set; }
        public string TopraktaBulunmasiGerekenMineraller { get; set; }
        public string Image_Mineral { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class BitkiHastaliklari
    {
        public int Bitki_ID { get; set; }
        public string HastalikAdi { get; set; }
        public string HastalikHakkinda_Bilgi { get; set; }
        public string FungalHastaliklar { get; set; }
        public string BakteriyelHastaliklar { get; set; }
        public string ViralHastaliklar { get; set; }
        public string BesinEksikligiHastaliklari { get; set; }
        public string Image_Hastaliklar { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }

    }
    public class BitkiZararlilari
    {
        public int Bitki_ID { get; set; }
        public string EmiciBocekler { get; set; }
        public string Yaprak_YesilAksamZararlilari { get; set; }
        public string KokGovdeZararlilari { get; set; }
        public string ToprakAltiZararlilari { get; set; }
        public string ZararlininAdi { get; set; }
        public string ZararliHakkindaAciklama { get; set; }
        public string Image_Zararli { get; set; }
        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }

    public class BesinEksikligi
    {
        public int Bitki_ID { get; set; }
        public string MineralAdi { get; set; }
        public string MineralEksikligi { get; set; }
        public int minMineralDegeri { get; set; }
        public int maxMineralDegeri { get; set; }
        public int stdMineralDegeri { get; set; }
        public string BesinEksikligiAciklama { get; set; }

        public DateTime EklenmeZamani { get; set; }
        public DateTime GuncellenmeZamani { get; set; }
        public int Aktif { get; set; }
        public int Silik { get; set; }
    }



}
