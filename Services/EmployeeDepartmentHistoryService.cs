using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class EmployeeDepartmentHistoryService : BaseService<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryService(AdventureContext db) : base(db)
        {

        }

        public override void Update(int Id)
        {
            
        }
    }
}
