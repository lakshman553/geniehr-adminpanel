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
    
    public partial class EntityType
    {
        public EntityType()
        {
            this.EntityAddresses = new HashSet<EntityAddress>();
        }
    
        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
    
        public virtual ICollection<EntityAddress> EntityAddresses { get; set; }
    }
}
