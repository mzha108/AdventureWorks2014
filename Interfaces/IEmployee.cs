using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IEmployee
    {
        List<Employee> GetAllPerson();
        Employee GetPerson(int Id);
        void Add(Employee employee);
        void Remove(int Id);
        void Update(Employee employee);
    }
}
