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
    
    public partial class BitkiTanima_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BitkiTanima_tbl()
        {
            this.BitkiDetay_tbl = new HashSet<BitkiDetay_tbl>();
        }
    
        public int ID { get; set; }
        public Nullable<int> BitkiAd_ID { get; set; }
        public string BitkiTipi_Tur { get; set; }
        public string Toleranslari { get; set; }
        public string YetistigiSehirler { get; set; }
        public string AnavataniVeDogalYayilisAlanlari { get; set; }
        public string ArsizlikDurumu { get; set; }
        public string YetismeDurumu { get; set; }
        public string DogalYasamAlanlari { get; set; }
        public string YasamSuresi { get; set; }
        public string ToksikOzellikler { get; set; }
        public string HangiDonem { get; set; }
        public string BitkiYetismeAlanlari { get; set; }
        public string Endemik { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BitkiDetay_tbl> BitkiDetay_tbl { get; set; }
    }
}
