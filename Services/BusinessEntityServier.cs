using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class BusinessEntityServier : BaseService<BusinessEntity>
    {
        private AdventureContext _db;
        public BusinessEntityServier(AdventureContext db):base(db)
        {
            _db = db;
        }

        //public List<BusinessEntity> GetAll()
        //{
        //    return _db.BusinessEntities.ToList();
        //}

        //public void Add(BusinessEntity be)
        //{
        //    if (_db.BusinessEntities.Find(be.BusinessEntityID) == null)
        //    {
        //        be.rowguid = Guid.NewGuid();
        //        _db.BusinessEntities.Add(be);
        //        _db.SaveChanges();
        //    }
        //    else
        //    {
        //        throw new Exception("Already here!");
        //    }
            
        //}

        //public void Delete(int Id)
        //{
        //    var entity = _db.BusinessEntities.Find(Id);
        //    _db.BusinessEntities.Remove(entity);
        //    _db.SaveChanges();
        //}

        //public void Update(BusinessEntity be)
        //{
            
        //}

        public override void Add(BusinessEntity entity, params object[] a)
        {
            if (_db.BusinessEntities.Find(entity.BusinessEntityId) == null)
            {
                entity.rowguid = Guid.NewGuid();
                _db.BusinessEntities.Add(entity);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Already here!");
            }
        }
    }
}
