using AdventureWorks2014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public interface IBusinessEntity
    {
        List<BusinessEntity> GetAll();
        void Add(BusinessEntity be);
        void Update(BusinessEntity be);
        void Delete(int Id);
    }
}
