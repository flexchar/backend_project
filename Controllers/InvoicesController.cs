using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Infrastructure;

namespace Backend.Controllers
{
    public class InvoicesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.invoices = Repository.Invoices;

            return View();
        }
    }
}