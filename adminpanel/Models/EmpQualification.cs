
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
    
public partial class EmpQualification
{

    public int Id { get; set; }

    public int EmpId { get; set; }

    public int Qualification { get; set; }

    public int Degree { get; set; }

    public string Institution { get; set; }

    public int Year { get; set; }

    public string Stream { get; set; }

    public Nullable<int> Percentage { get; set; }

    public Nullable<System.DateTime> createdate { get; set; }

    public Nullable<System.DateTime> modifieddate { get; set; }



    public virtual Degree Degree1 { get; set; }

    public virtual Employee Employee { get; set; }

    public virtual Qualification Qualification1 { get; set; }

}

}
