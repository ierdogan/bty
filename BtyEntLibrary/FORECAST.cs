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
    
    public partial class FORECAST
    {
        public long ID { get; set; }
        public Nullable<long> COMPANY_ID { get; set; }
        public Nullable<long> FORECAST_TYPE_ID { get; set; }
        public Nullable<long> SEASON_ID { get; set; }
        public Nullable<long> ACCOUNT_ID { get; set; }
        public Nullable<long> OPTION_ID { get; set; }
        public Nullable<long> SIZE_ID { get; set; }
        public Nullable<long> CALENDAR_ID { get; set; }
        public Nullable<decimal> FORECAST_INV_NOLIMIT { get; set; }
        public Nullable<decimal> FORECAST_INV_LIMITED { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
