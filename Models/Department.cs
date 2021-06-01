using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdventureWorks2014.Models
{
    public partial class Department : BaseEntity
    {
        public short DepartmentId { get; set; }

        [DisplayName("Department")]
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }

        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
    }
}
