//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TABLESIPARIS
    {
        public int URUNID { get; set; }
        public int MUSTERI { get; set; }
        public int URUNCINS { get; set; }
        public Nullable<int> URUNUN_ADI { get; set; }
        public Nullable<int> URUN_ADEDİ { get; set; }
        public Nullable<System.DateTime> TARİH { get; set; }
        public string SİPARİŞNO { get; set; }
        public Nullable<double> TUTAR { get; set; }
    
        public virtual TABLEMUSTERİ TABLEMUSTERİ { get; set; }
        public virtual TABLOKATEG TABLOKATEG { get; set; }
        public virtual URUNİSİMLERİ URUNİSİMLERİ { get; set; }
        public virtual SIPARISLER SIPARISLER { get; set; }
    }
}