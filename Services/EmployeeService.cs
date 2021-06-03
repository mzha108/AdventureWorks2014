using AdventureWorks2014.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class EmployeeService : BaseService<Employee>
    {
        
        public EmployeeService(AdventureContext db):base(db)
        {
            
        }

        public override IQueryable<Employee> Get()
        {
            return base.Get().Include(x => x.Person)
                                .ThenInclude(x => x.EmailAddress)
                             .Include(x => x.EmployeeDepartmentHistory)
                                .ThenInclude(y => y.Department).AsNoTracking();
        }

        public override Employee Get(int Id)
        {
            return base.Get().Include(x => x.Person).Where(x => x.BusinessEntityId == Id).FirstOrDefault();
        }

    }
}
