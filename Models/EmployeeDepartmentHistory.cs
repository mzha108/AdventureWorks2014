using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks2014.Models
{
    public partial class EmployeeDepartmentHistory : BaseEntity
    {
        public int BusinessEntityId { get; set; }
        public short DepartmentId { get; set; }
        public byte ShiftId { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Today;
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; } = DateTime.Today;

        public Department Department { get; set; }
        public Employee Employee { get; set; }
    }
}
