//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Progress
    {
        public int ID { get; set; }
        public Nullable<int> IdStudent { get; set; }
        public Nullable<int> Mark { get; set; }
        public Nullable<int> IdItem { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Student Student { get; set; }
    }
}
