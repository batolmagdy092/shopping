//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace loginshopping
{
    using System;
    using System.Collections.Generic;
    
    public partial class delivry
    {
        public int id_ { get; set; }
        public string name_ { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<int> number_ { get; set; }
    
        public virtual Admin_ Admin_ { get; set; }
        public virtual Userr_ Userr_ { get; set; }
    }
}