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
    
    public partial class ORDER_SUMM
    {
        public long ID { get; set; }
        public long WH_ID { get; set; }
        public Nullable<long> PRODUCT_ID { get; set; }
        public Nullable<long> ASORTI_ID { get; set; }
        public Nullable<long> ASORTI_DETAIL_ID { get; set; }
        public decimal ORDER_QTY { get; set; }
        public decimal SHIP_QTY { get; set; }
        public decimal DAILY_QTY { get; set; }
        public Nullable<System.DateTime> ORDER_DATE { get; set; }
        public Nullable<System.DateTime> DUE_DATE { get; set; }
        public int ORDER_TYPE { get; set; }
    }
}
