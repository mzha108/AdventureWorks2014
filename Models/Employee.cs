using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks2014.Models
{
    [Table("Employee", Schema = "HumanResources")]
    public class Employee : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityId { get; set; }
        public string NationalIdnumber { get; set; }
        public string LoginId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public short? OrganizationLevel { get; set; }
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public bool? SalariedFlag { get; set; } = false;
        public short VacationHours { get; set; } = 0;
        public short SickLeaveHours { get; set; } = 0;
        public bool? CurrentFlag { get; set; } = false;
        public Guid Rowguid { get; set; } = Guid.NewGuid();

        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; } = DateTime.Today;


        //public BusinessEntity BusinessEntity { get; set; }
        public Person Person { get; set; }
        public List<EmailAddress> EmailAddress { get; set; }
        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
    }
}
