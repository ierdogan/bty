//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BtyEntLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class BUDGET_DETAIL_PERIOD
    {
        public int ID { get; set; }
        public int BASLIK_ID { get; set; }
        public int SIRA_ID { get; set; }
        public int DETAY_SIRA_ID { get; set; }
        public System.DateTime BAS_TARIH { get; set; }
        public System.DateTime BIT_TARIH { get; set; }
        public Nullable<short> HAFTA { get; set; }
    }
}