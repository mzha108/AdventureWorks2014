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

        public override void Update(Person entity)
        {
            entity.BusinessEntity.BusinessEntityId = entity.BusinessEntityId;
            base.Update(entity);
        }


    }
}
