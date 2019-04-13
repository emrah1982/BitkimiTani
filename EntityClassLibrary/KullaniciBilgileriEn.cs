using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
    public class KullaniciBilgileriEn
    {
        //public string Id { get; set; } = Guid.NewGuid().ToString(); IDlere numara verme 
        public int ID { get; set; }

        public string KullaniciID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(100,ErrorMessage ="Adınız En fazla 100 karakter olabilir",MinimumLength =3)]
        public string Ad { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Soyadınız En fazla 100 karakter olabilir", MinimumLength = 3)]
        public string Soyad { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }   
        public string Image { get; set; }
       
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz ")]
        [StringLength(15, ErrorMessage = "Şifreniz En fazla 15 karakter olabilir", MinimumLength = 6)]
        [RegularExpression(@" ^ (?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[@$!% *? &])[A - Za - z\d@$!% *? &]{8,15}$",ErrorMessage = "En az altı karakter, en az bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter olmalı.")]    
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Required]
        [Compare(nameof(Sifre), ErrorMessage = "Şifre Bilginizi Kontrol Ediniz.")]
        [DataType(DataType.Password)]
        public string SifreTekrari { get; set; }
        //public Yetki KullaniciYetkileri { get; set; }
        [Required]
        [Range(18,100,ErrorMessage ="Yaş aralığı 18 ile 100 arasındadır")]
        public int DogumTarihi { get; set; }
        [Required]
        [Phone]
        public  string CepTelefonu { get; set; }
        [StringLength(500,ErrorMessage ="İletişim Adresiniz 500 karakterden fazla olamaz",MinimumLength =10)]
        public string Adres { get; set; }
        public int Sehir { get; set; }
        [Required]
        public bool Onay { get; set; }

        public DateTime SifreGuncellemeTarihi { get; set; }

        public string CepTelefonuOnay { get; set; } 
    }
    public class FavorilerimEn
    {
        public int Kullanici_ID { get; set; }
        public int ID { get; set; }
        public int Bitki_ID { get; set; }
    }

    public class PuanimEn
    {
        public int Kullanici_ID { get; set; }
        public int DusukPuan { get; set; }
        public int YuksekPuan { get; set; }
        public int OrtalamaPuan { get; set; }
        public string Derece { get; set; } //Rütbe gibi düşün aliexpress deki gibi
    }

    public class SosyalMedyaHesaplariEn
    {
        public int Kullanici_ID { get; set; }
        public int ID { get; set; }
        [Url]
        public string SosyalMedyaUrl { get; set; }
        [Url]
        public string FaceebookFileUrl { get; set; }
        [Url]
        public string TwiterFileUrl { get; set; }
        [Url]
        public string İnstegramFileUrl { get; set; }
    }

}
