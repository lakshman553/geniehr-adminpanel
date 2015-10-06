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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Attendances = new HashSet<Attendance>();
            this.GroupEmployees = new HashSet<GroupEmployee>();
            this.GroupIncharges = new HashSet<GroupIncharge>();
            this.ClaimHeads = new HashSet<ClaimHead>();
            this.claimJSONs = new HashSet<claimJSON>();
        }
    
        public int EmpId { get; set; }
        public string EmpNum { get; set; }
        public string EmpName { get; set; }
        public string ProfilePic { get; set; }
        public int EmpStatus { get; set; }
        public string Email { get; set; }
        public Nullable<long> PrimaryMobile { get; set; }
        public string Designation { get; set; }
        public string AuthUserId { get; set; }
        public Nullable<int> CompanyId { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual EmpStatu EmpStatu { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<GroupEmployee> GroupEmployees { get; set; }
        public virtual ICollection<GroupIncharge> GroupIncharges { get; set; }
        public virtual ICollection<ClaimHead> ClaimHeads { get; set; }
        public virtual ICollection<claimJSON> claimJSONs { get; set; }
    }
}
