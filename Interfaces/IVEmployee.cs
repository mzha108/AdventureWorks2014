using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IVEmployee
    {
        List<VEmployee> GetAllVEmployees();
    }
}
