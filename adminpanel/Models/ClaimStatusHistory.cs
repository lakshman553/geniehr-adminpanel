//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adminpanel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClaimStatusHistory
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int StatusId { get; set; }
        public System.DateTime StatusDateTime { get; set; }
    
        public virtual ClaimStatu ClaimStatu { get; set; }
    }
}
