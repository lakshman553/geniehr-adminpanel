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
    
    public partial class GroupEmployee
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int EmpId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Group Group { get; set; }
    }
}
