
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
    
public partial class Candidate
{

    public Candidate()
    {

        this.CandidateSkills = new HashSet<CandidateSkill>();

        this.CandidateRecruitmentLogs = new HashSet<CandidateRecruitmentLog>();

    }


    public int Id { get; set; }

    public string CandidateName { get; set; }

    public long PrimaryMobile { get; set; }

    public Nullable<long> AlternateNumber { get; set; }

    public string Email { get; set; }

    public string CurrentCompany { get; set; }

    public Nullable<decimal> CurrentSalary { get; set; }

    public Nullable<int> CurrentExp { get; set; }

    public string CurrentLocation { get; set; }

    public string Designation { get; set; }

    public int TotalExp { get; set; }

    public string NativePlace { get; set; }

    public int HighestQualification { get; set; }

    public int CreatedBy { get; set; }

    public Nullable<System.DateTime> CreatedOn { get; set; }

    public Nullable<System.DateTime> ModifiedOn { get; set; }

    public Nullable<int> ModifiedBy { get; set; }

    public Nullable<int> degree { get; set; }

    public Nullable<int> NoticePeriod { get; set; }

    public Nullable<int> SourceId { get; set; }

    public string SourceNotes { get; set; }



    public virtual Employee Employee { get; set; }

    public virtual Employee Employee1 { get; set; }

    public virtual Qualification Qualification { get; set; }

    public virtual Source Source { get; set; }

    public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }

    public virtual ICollection<CandidateRecruitmentLog> CandidateRecruitmentLogs { get; set; }

}

}
