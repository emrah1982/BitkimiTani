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
    
    public partial class Mail_tbl
    {
        public int ID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public Nullable<int> KimeGonderildiID { get; set; }
        public string MailBaslik { get; set; }
        public string MailKonusu { get; set; }
        public Nullable<System.DateTime> GonderilmeTarihi { get; set; }
    }
}
