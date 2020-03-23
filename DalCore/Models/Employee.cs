using System;

namespace DalCore.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public decimal BasicSalary { get; set; }
        public string IdNumber { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public int? ChildrenNumber { get; set; }
        public string Department { get; set; }
        public string EducationLevel { get; set; }
        public string EmployeeType { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Speciality { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public bool? IsCivilEmployee { get; set; }
        public string EmployerJob { get; set; }
        public decimal? CivilSalary { get; set; }
        public byte[] EmployeeImage { get; set; }
        public decimal? OpeningNis { get; set; }
        public decimal? OpeningUsd { get; set; }
        public bool? IsActive { get; set; }
    }
}
