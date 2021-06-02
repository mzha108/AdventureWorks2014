using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IBase<T>
    {
        IQueryable<T> Get();
        T Get(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
