
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
    
public partial class ClaimRevision
{

    public int Id { get; set; }

    public int ClaimId { get; set; }

    public string claimtext { get; set; }

    public System.DateTime revisionDate { get; set; }

    public int revisionBy { get; set; }

    public string revisionRemarks { get; set; }

    public int revisionName { get; set; }



    public virtual claimJSON claimJSON { get; set; }

    public virtual Employee Employee { get; set; }

}

}
