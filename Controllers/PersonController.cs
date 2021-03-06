using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks2014.Models;
using AdventureWorks2014.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AdventureWorks2014.Controllers
{
    //[Authorize]
    public class PersonController : Controller
    {
        //private readonly IPerson _person;
        //private readonly PersonService person;
        private readonly IBase<Person> _person;
        private readonly IBase<BusinessEntity> _businessEntity;
        public PersonController(IBase<Person> person, IBase<BusinessEntity> businessEntity)
        {
            _person = person;
            _businessEntity = businessEntity;
        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 25;
            
            var tmp = _person.Get().ToPagedList(pageNumber, pageSize);

            return View(tmp);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Create(Person person)
         {
             if (ModelState.IsValid)
             {
                //_businessEntity.Add(be);
                //person.BusinessEntity = new BusinessEntity();
                _person.Add(person);
                return RedirectToAction(nameof(Index));
             }

             return View();
         }

        public IActionResult Edit(int Id)
        {
            var entity = _person.Get(Id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _person.Update(person);
            return RedirectToAction("Index");
        }
    }
}
