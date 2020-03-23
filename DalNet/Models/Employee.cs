namespace DalNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [StringLength(15)]
        public string EmployeeCode { get; set; }

        [StringLength(250)]
        public string EmployeeName { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal BasicSalary { get; set; }

        [StringLength(9)]
        public string IdNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthOfDate { get; set; }

        public int? ChildrenNumber { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        [StringLength(20)]
        public string EducationLevel { get; set; }

        [StringLength(5)]
        public string EmployeeType { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

        [StringLength(10)]
        public string MaritalStatus { get; set; }

        [StringLength(10)]
        public string MobileNumber { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Speciality { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public bool? IsCivilEmployee { get; set; }

        [StringLength(20)]
        public string EmployerJob { get; set; }

        public decimal? CivilSalary { get; set; }

        public byte[] EmployeeImage { get; set; }

        public decimal? OpeningNis { get; set; }

        public decimal? OpeningUsd { get; set; }

        public bool? IsActive { get; set; }
    }
}
