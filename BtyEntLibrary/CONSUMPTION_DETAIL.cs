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
    
    public partial class CONSUMPTION_DETAIL
    {
        public long ID { get; set; }
        public long OPTION_ID { get; set; }
        public long MASTER_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal ACTUAL_QUANTITY { get; set; }
        public bool APPROVAL { get; set; }
    }
}