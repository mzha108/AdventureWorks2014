using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks2014.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace AdventureWorks2014.Services
{
    public class PersonService : BaseService<Person>
    {
        private AdventureContext _db;
        public PersonService(AdventureContext db):base(db)
        {
            _db = db;
        }

        public override void Add(Person person)
        {
            //person.BusinessEntityId = _db.BusinessEntities.Max(x => x.BusinessEntityId);

            //var res = _db.People.Count(x => x.FirstName == person.FirstName);

            base.Add(person);
            
        }

        public void Remove(int Id)
        {
            var entity = _db.People.Find(Id);
            _db.People.Remove(entity);
            _db.SaveChanges();
        }

        public List<Person> GetAllPerson()
        {
            return _db.People.ToList();
        }

        public Person GetPerson(int Id)
        {
            var entity = _db.People.Find(Id);
            return entity;
        }

        

        public void Update(Person person)
        {
            _db.People.Update(person);
            _db.SaveChanges();
        }

    }
}
