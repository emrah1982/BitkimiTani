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
    
    public partial class NumuneKonum_tbl
    {
        public int ID { get; set; }
        public Nullable<int> NumuneID { get; set; }
        public string yKonum { get; set; }
        public string xKonum { get; set; }
        public Nullable<short> Aktif { get; set; }
        public Nullable<int> Silik { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<System.DateTime> GuncellenmeTarihi { get; set; }
    }
}
