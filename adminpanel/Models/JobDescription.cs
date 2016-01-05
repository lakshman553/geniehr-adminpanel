
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
    
public partial class JobDescription
{

    public JobDescription()
    {

        this.EmpJDs = new HashSet<EmpJD>();

        this.JobBenefits = new HashSet<JobBenefit>();

        this.JobCertifications = new HashSet<JobCertification>();

        this.JobSkills = new HashSet<JobSkill>();

        this.JobQualifications = new HashSet<JobQualification>();

        this.EmployeeJDs = new HashSet<EmployeeJD>();

    }


    public int Id { get; set; }

    public Nullable<int> CleintId { get; set; }

    public string JobShortName { get; set; }

    public string JobTitle { get; set; }

    public int ExpFrom { get; set; }

    public int ExpTo { get; set; }

    public string JobLocation { get; set; }

    public Nullable<decimal> Salary { get; set; }

    public Nullable<int> Openings { get; set; }

    public string JobNotes { get; set; }

    public System.DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public Nullable<System.DateTime> ModifiedDate { get; set; }

    public Nullable<int> ModifiedBy { get; set; }

    public Nullable<int> RExpFrom { get; set; }

    public Nullable<int> RExpTo { get; set; }

    public Nullable<decimal> SalaryTo { get; set; }



    public virtual Client Client { get; set; }

    public virtual ICollection<EmpJD> EmpJDs { get; set; }

    public virtual Employee Employee { get; set; }

    public virtual Employee Employee1 { get; set; }

    public virtual ICollection<JobBenefit> JobBenefits { get; set; }

    public virtual ICollection<JobCertification> JobCertifications { get; set; }

    public virtual ICollection<JobSkill> JobSkills { get; set; }

    public virtual ICollection<JobQualification> JobQualifications { get; set; }

    public virtual ICollection<EmployeeJD> EmployeeJDs { get; set; }

}

}
