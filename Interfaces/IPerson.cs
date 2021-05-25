using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IPerson:IBase<Person>
    {
        Person GetPerson(int Id);
        void Add(Person person);
        void Remove(int Id);
        void Update(Person person);
    }
}
