﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ubietydbEntities : DbContext
    {
        public ubietydbEntities()
            : base("name=ubietydbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceFlag> AttendanceFlags { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<EmpClient> EmpClients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpStatu> EmpStatus { get; set; }
        public virtual DbSet<EntityAddress> EntityAddresses { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<attendancereport> attendancereports { get; set; }
        public virtual DbSet<attRepTemp> attRepTemps { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupEmployee> GroupEmployees { get; set; }
        public virtual DbSet<GroupIncharge> GroupIncharges { get; set; }
        public virtual DbSet<GroupType> GroupTypes { get; set; }
        public virtual DbSet<ClaimStatu> ClaimStatus { get; set; }
        public virtual DbSet<ClaimStatusHistory> ClaimStatusHistories { get; set; }
        public virtual DbSet<attByClient> attByClients { get; set; }
        public virtual DbSet<clientEmployee> clientEmployees { get; set; }
        public virtual DbSet<claimJSON> claimJSONs { get; set; }
        public virtual DbSet<claimHistory> claimHistories { get; set; }
        public virtual DbSet<ClaimRevision> ClaimRevisions { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }
        public virtual DbSet<EmpFinDetail> EmpFinDetails { get; set; }
        public virtual DbSet<EmpIdentity> EmpIdentities { get; set; }
        public virtual DbSet<contactType> contactTypes { get; set; }
        public virtual DbSet<EmpContactDetail> EmpContactDetails { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<EmpQualification> EmpQualifications { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<EmpPastEmp> EmpPastEmps { get; set; }
    
        public virtual ObjectResult<getEmpOfGroups_Result> getEmpOfGroups()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpOfGroups_Result>("getEmpOfGroups");
        }
    
        public virtual ObjectResult<getEmpOfGroups1_Result> getEmpOfGroups1(Nullable<int> clientId, Nullable<int> groupId)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("clientId", clientId) :
                new ObjectParameter("clientId", typeof(int));
    
            var groupIdParameter = groupId.HasValue ?
                new ObjectParameter("groupId", groupId) :
                new ObjectParameter("groupId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpOfGroups1_Result>("getEmpOfGroups1", clientIdParameter, groupIdParameter);
        }
    
        public virtual ObjectResult<getAttendanceByClientsDays_Result1> getAttendanceByClientsDays(Nullable<int> clientId, Nullable<int> numDays)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("clientId", clientId) :
                new ObjectParameter("clientId", typeof(int));
    
            var numDaysParameter = numDays.HasValue ?
                new ObjectParameter("numDays", numDays) :
                new ObjectParameter("numDays", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAttendanceByClientsDays_Result1>("getAttendanceByClientsDays", clientIdParameter, numDaysParameter);
        }
    
        public virtual ObjectResult<string> getNextClaimNo(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getNextClaimNo", empIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getEmpsofManager(Nullable<int> managerId)
        {
            var managerIdParameter = managerId.HasValue ?
                new ObjectParameter("ManagerId", managerId) :
                new ObjectParameter("ManagerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getEmpsofManager", managerIdParameter);
        }
    
        public virtual ObjectResult<getAttendanceByManagerId_Result> getAttendanceByManagerId(Nullable<int> managerId, Nullable<int> numDays)
        {
            var managerIdParameter = managerId.HasValue ?
                new ObjectParameter("managerId", managerId) :
                new ObjectParameter("managerId", typeof(int));
    
            var numDaysParameter = numDays.HasValue ?
                new ObjectParameter("numDays", numDays) :
                new ObjectParameter("numDays", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAttendanceByManagerId_Result>("getAttendanceByManagerId", managerIdParameter, numDaysParameter);
        }
    
        public virtual ObjectResult<getOpenCliamsByManagerId_Result> getOpenCliamsByManagerId(Nullable<int> managerId)
        {
            var managerIdParameter = managerId.HasValue ?
                new ObjectParameter("managerId", managerId) :
                new ObjectParameter("managerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getOpenCliamsByManagerId_Result>("getOpenCliamsByManagerId", managerIdParameter);
        }
    
        public virtual ObjectResult<getEmpDetofManager_Result> getEmpDetofManager(Nullable<int> managerId)
        {
            var managerIdParameter = managerId.HasValue ?
                new ObjectParameter("ManagerId", managerId) :
                new ObjectParameter("ManagerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpDetofManager_Result>("getEmpDetofManager", managerIdParameter);
        }
    
        public virtual ObjectResult<getManagerDetail_Result> getManagerDetail(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getManagerDetail_Result>("getManagerDetail", empIdParameter);
        }
    
        public virtual ObjectResult<claimLog_Result> claimLog(Nullable<int> claimId)
        {
            var claimIdParameter = claimId.HasValue ?
                new ObjectParameter("ClaimId", claimId) :
                new ObjectParameter("ClaimId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<claimLog_Result>("claimLog", claimIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getNextClaimRevisionNo(Nullable<int> claimId)
        {
            var claimIdParameter = claimId.HasValue ?
                new ObjectParameter("ClaimId", claimId) :
                new ObjectParameter("ClaimId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getNextClaimRevisionNo", claimIdParameter);
        }
    
        public virtual ObjectResult<empProfBasicDetails_Result> empProfBasicDetails(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<empProfBasicDetails_Result>("empProfBasicDetails", empIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getNextContactLineId(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getNextContactLineId", empIdParameter);
        }
    
        public virtual ObjectResult<getEmpContactDetail_Result> getEmpContactDetail(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpContactDetail_Result>("getEmpContactDetail", empIdParameter);
        }
    
        public virtual ObjectResult<getShortAddress_Result> getShortAddress(Nullable<int> entityType, Nullable<int> empId)
        {
            var entityTypeParameter = entityType.HasValue ?
                new ObjectParameter("EntityType", entityType) :
                new ObjectParameter("EntityType", typeof(int));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getShortAddress_Result>("getShortAddress", entityTypeParameter, empIdParameter);
        }
    
        public virtual ObjectResult<getEmergencyHeader_Result> getEmergencyHeader(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmergencyHeader_Result>("getEmergencyHeader", empIdParameter);
        }
    
        public virtual ObjectResult<qualsummary_Result> qualsummary(Nullable<int> empId)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<qualsummary_Result>("qualsummary", empIdParameter);
        }
    }
}
