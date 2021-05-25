using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks2014.Models
{
    [Table("Employee", Schema = "HumanResources")]
    public class Employee : BaseEntity
    {
        public Employee() : base()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityId { get; set; }
        public string NationalIdnumber { get; set; }
        public string LoginId { get; set; }
        public short? OrganizationLevel { get; set; }
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid Rowguid { get; set; }

        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public Person Person { get; set; }
        public List<EmailAddress> EmailAddress { get; set; }
        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
    }
}
