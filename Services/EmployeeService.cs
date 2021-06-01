﻿using AdventureWorks2014.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks2014.Services
{
    public class EmployeeService : BaseService<Employee>
    {
        
        public EmployeeService(AdventureContext db):base(db)
        {
            
        }

        public override IQueryable<Employee> Get()
        {
            return base.Get().Include(x => x.Person)
                                .ThenInclude(x => x.EmailAddress)
                             .Include(x => x.EmployeeDepartmentHistory)
                                .ThenInclude(y => y.Department).AsNoTracking();
        }

        public override Employee Get(int Id)
        {
            return base.Get().Include(x => x.Person).Where(x => x.BusinessEntityId == Id).FirstOrDefault();
        }


        public override void Add(Employee employee)
        {
            int NumOfDupLoginId = base.Get().Count(x => x.Person.FirstName == employee.Person.FirstName);

            string LoginIdStr = @"adventure-works\" + employee.Person.FirstName + 
                (NumOfDupLoginId == 0 ? NumOfDupLoginId : NumOfDupLoginId+1);

            employee.LoginId = LoginIdStr;

            base.Add(employee);
        }

        //public List<Employee> GetAllPerson()
        //{
        //    return _db.Employees.Include(x => x.Person)
        //                        .Include(x => x.EmailAddress)
        //                        .Include(x => x.EmployeeDepartmentHistory)
        //                            .ThenInclude(y => y.Department)
        //                        .ToList();
        //}

        //public Employee GetPerson(int Id)
        //{
        //    var entity = _db.Employees.Find(Id);
        //    return entity;
        //}

        //public void Remove(int Id)
        //{
        //    var entity = _db.Employees.Find(Id);
        //    _db.Remove(entity);
        //    _db.SaveChanges();
        //}

        //public void Update(Employee employee)
        //{
        //    _db.Employees.Update(employee);
        //    _db.SaveChanges(); 
        //}
    }
}
