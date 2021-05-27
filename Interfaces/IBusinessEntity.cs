using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IBusinessEntity<T>
    {
        IQueryable<T> Get();
        T Get(int Id);
        void Add(T entity, params object[] a);
        void Update(int Id);
        void Delete(T entity);
    }
}
