//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api.DbService
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_sube
    {
        public int ID_SUBE { get; set; }
        public string AD { get; set; }
        public string TELEFON { get; set; }
        public string FAX { get; set; }
        public string E_POSTA { get; set; }
        public string ADRES { get; set; }
        public Nullable<int> ID_ILCE { get; set; }
        public Nullable<int> ID_SIRKET { get; set; }
        public Nullable<int> ID_EKLEYEN_KULLANICI { get; set; }
        public Nullable<System.DateTime> EKLEME_TARIHI { get; set; }
        public Nullable<int> ID_DUZENLEYEN { get; set; }
        public Nullable<System.DateTime> DUZENLEME_TARIHI { get; set; }
        public Nullable<bool> SILINDI { get; set; }
    }
}