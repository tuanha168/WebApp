//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingMobile.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MobileDetail
    {
        public int SLNO { get; set; }
        public Nullable<int> MobileId { get; set; }
        public string Features { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string SimType { get; set; }
    
        public virtual Mobile Mobile { get; set; }
    }
}
