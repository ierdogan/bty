//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BtyEntityLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class oc_journal2_blog_comments
    {
        public int comment_id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public Nullable<int> post_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> author_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string comment { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}
