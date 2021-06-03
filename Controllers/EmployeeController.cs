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
        private readonly IBase<Employee> _employee;

        public EmployeeController(IBase<Employee> employee)
        {
            _employee = employee;
        }

        public IActionResult Index(int? page)
        {
            var pageSize = 25;
            var pageNumber = page ?? 1;

            var onePageOfEmployee = _employee.Get().ToPagedList(pageNumber, pageSize);
            ViewBag.PageName = "Employees";

            return View(onePageOfEmployee);
        }

        public IActionResult DisplayGrid(int? page)
        {
            var pageSize = 24;
            var pageNumber = page ?? 1;

            var onePageOfEmpolyee = _employee.Get().ToPagedList(pageNumber, pageSize);

            return View(onePageOfEmpolyee);
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
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //_businessEntity.Add(be);
                //_person.Add(person);
                _employee.Add(employee);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Edit(int Id)
        {
            var entity = _employee.Get(Id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employee.Update(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
