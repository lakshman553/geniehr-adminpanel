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
    
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmpId { get; set; }
        public Nullable<int> MarkFlagId { get; set; }
        public System.DateTime MarkTime { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> longitude { get; set; }
        public Nullable<int> markcount { get; set; }
        public string locationdesc { get; set; }
    
        public virtual AttendanceFlag AttendanceFlag { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
