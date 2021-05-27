using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks2014.Models;
using AdventureWorks2014.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks2014.Controllers
{
    public class BusinessEntityController : Controller
    {

        private readonly IBase<BusinessEntity> _businessEntity;
        public BusinessEntityController(IBase<BusinessEntity> businessEntity)
        {
            _businessEntity = businessEntity;
        }

        public IActionResult Index()
        {
            var entities = _businessEntity.Get();
            return View(entities);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BusinessEntity be)
        {
            _businessEntity.Add(be);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Delete(int Id)
        //{
        //    _businessEntity.Delete(Id);
        //    return RedirectToAction("Index");
        //}
    }
}
