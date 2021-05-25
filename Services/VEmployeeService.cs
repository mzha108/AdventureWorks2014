using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class VEmployeeService : IVEmployee
    {
        private AdventureContext _db;
        public VEmployeeService(AdventureContext db)
        {
            _db = db;
        }

        public List<VEmployee> GetAllVEmployees()
        {
            //return _db.vEmployees.ToList();
            return null;
        }


    }
}
