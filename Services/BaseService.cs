using AdventureWorks2014.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class BaseService<T> : IBase<T> where T:BaseEntity
    {
        private AdventureContext _db;
        private DbSet<T> _dbSet;
        public BaseService(AdventureContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        // SELECT * FROM table
        public virtual IQueryable<T> Get()
        {
            return _dbSet;
        }

        // SELECT with Id
        public virtual T Get(int Id)
        {
            return _dbSet.Find(Id);
        }
        
        // INSERT INTO table
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
            _db.SaveChanges();
        }

        // DELETE FROM table
        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }


        // UPDATE 
        public virtual void Update(T entity)
        {
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

    }
}
