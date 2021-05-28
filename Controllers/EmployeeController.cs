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
    public class EmployeeController : Controller
    {
        //private readonly IEmployee _employee;
        //private readonly IPerson _person;
        private readonly IBase<BusinessEntity> _businessEntity;
        private readonly IBase<Employee> _employee;
        private readonly IBase<Person> _person;
        //private readonly IVEmployee _vEmployee;

        public EmployeeController(IBase<Employee> employee, IBase<Person> person, IBase<BusinessEntity> businessEntity)
        {
            //_employee = employee;
            //_person = person;
            //_businessEntity = businessEntity;

            _employee = employee;
            _person = person;
            _businessEntity = businessEntity;
        }

        public IActionResult Index(int? page)
        {
            var pageSize = 25;
            var pageNumber = page ?? 1;

            var onePageOfEmployee = _employee.Get().ToPagedList(pageNumber, pageSize);
            ViewBag.PageName = "Employees";

            return View(onePageOfEmployee);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            return View(_employee.Get(Id));
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee, Person person, BusinessEntity be)
        {
            if (ModelState.IsValid)
            {
                _businessEntity.Add(be);
                _person.Add(person);
                _employee.Add(employee);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
