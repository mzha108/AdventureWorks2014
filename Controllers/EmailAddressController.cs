using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks2014.Models;
using AdventureWorks2014.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AdventureWorks2014.Controllers
{
    public class EmailAddressController : Controller
    {
        private readonly IBase<EmailAddress> _emailAddress;
        public EmailAddressController(IBase<EmailAddress> EmailAddress)
        {
            _emailAddress = EmailAddress;
        }

        public IActionResult Index(int? page)
        {
            var pageSize = 25;
            var pageNumber = page ?? 1;

            var onePageOfEmployee = _emailAddress.Get().ToPagedList(pageNumber, pageSize);

            return View(onePageOfEmployee);
        }
    }
}
