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
    
    public partial class EntityAddress
    {
        public int EntityAddressId { get; set; }
        public int EntityId { get; set; }
        public int EntityTypId { get; set; }
        public int AddressId { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual EntityType EntityType { get; set; }
    }
}
