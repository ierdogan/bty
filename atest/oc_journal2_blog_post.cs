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
    
    public partial class oc_journal2_blog_post
    {
        public int post_id { get; set; }
        public Nullable<int> author_id { get; set; }
        public string image { get; set; }
        public Nullable<bool> comments { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> sort_order { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
        public Nullable<int> views { get; set; }
    }
}
