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
    
    public partial class QC_TEST_DETAIL
    {
        public long ID { get; set; }
        public long MASTER_ID { get; set; }
        public long PRODUCT_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal SAMPLE_QUANTITY { get; set; }
        public decimal REJECTED_QUANTITY { get; set; }
        public long PO_DETAIL_ID { get; set; }
        public decimal PO_QUANTITY { get; set; }
        public decimal REJECTED_QUANTITY_MINOR { get; set; }
        public decimal REJECTED_QUANTITY_MAJOR { get; set; }
        public decimal REJECTED_QUANTITY_CRITICAL { get; set; }
    }
}
