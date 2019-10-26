using System;
using System.Collections.Generic;
using System.Linq;
using MandotaryAssignment01.Infrastructure;
using MandotaryAssignment01.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 3;
        public IActionResult Index(int page = 1)
        {
            ProductListsViewModel model = new ProductListsViewModel();
            var Products = Repository.Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * this.PageSize)
                .Take(this.PageSize);

            var Paginator = new Paginator
            {
                CurrentPage = page,
                ItemsPerPage = this.PageSize,
                TotalItems = Repository.Products.Count()
            };


            model = new ProductListsViewModel { Products = Products, Paginator = Paginator };
            return View(model);
        }
    }
}