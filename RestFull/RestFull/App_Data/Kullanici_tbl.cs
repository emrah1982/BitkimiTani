//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestFull.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici_tbl()
        {
            this.FavoriBitki_tbl = new HashSet<FavoriBitki_tbl>();
        }
    
        public int ID { get; set; }
        public string KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public Nullable<byte> Sehir { get; set; }
        public string DogumTarihi { get; set; }
        public string CepTelefonu { get; set; }
        public string CepTelefonuOnayKodu { get; set; }
        public string Sifre { get; set; }
        public string Resim { get; set; }
        public string MailSifreOnay { get; set; }
        public Nullable<bool> Onay { get; set; }
        public string Token { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<System.DateTime> GuncellemeTarihi { get; set; }
        public Nullable<System.DateTime> SilinmeTarihi { get; set; }
        public Nullable<bool> Aktif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriBitki_tbl> FavoriBitki_tbl { get; set; }
    }
}
