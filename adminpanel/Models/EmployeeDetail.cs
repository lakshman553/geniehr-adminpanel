
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
    
public partial class EmployeeDetail
{

    public int EmpId { get; set; }

    public Nullable<System.DateTime> DOJ { get; set; }

    public string WorkLocation { get; set; }

    public Nullable<decimal> Salary { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public Nullable<System.DateTime> DOB { get; set; }

    public string Gender { get; set; }

    public Nullable<int> MaritalStatus { get; set; }

    public string FatherName { get; set; }

    public string MotherName { get; set; }

    public string SpouseName { get; set; }

    public Nullable<int> BloodGroup { get; set; }

    public Nullable<System.DateTime> modified { get; set; }

    public Nullable<System.DateTime> created { get; set; }



    public virtual BloodGroup BloodGroup1 { get; set; }

    public virtual MaritalStatu MaritalStatu { get; set; }

}

}
