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
    
    public partial class BitkiEkoloji_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BitkiEkoloji_tbl()
        {
            this.BitkiDetay_tbl = new HashSet<BitkiDetay_tbl>();
        }
    
        public int ID { get; set; }
        public Nullable<int> BitkiAd_ID { get; set; }
        public string Iklim { get; set; }
        public string Isik { get; set; }
        public string Sicaklik { get; set; }
        public string Nem { get; set; }
        public string Gorunus { get; set; }
        public string Ca { get; set; }
        public string P { get; set; }
        public string Soc { get; set; }
        public string ToprakYapisi { get; set; }
        public string ToprakEnDusuk_Ph { get; set; }
        public string ToprakEnYuksek_Ph { get; set; }
        public string BolgeSoguklugu { get; set; }
        public string BolgeSicakligiGunSayisi { get; set; }
        public string KusakSoguklugu { get; set; }
        public string KusakSicakligi { get; set; }
        public string Minerallar { get; set; }
        public string ToprakPh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BitkiDetay_tbl> BitkiDetay_tbl { get; set; }
    }
}