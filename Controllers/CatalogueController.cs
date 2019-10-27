using System;
using System.Collections.Generic;
using System.Linq;
using Backend.Infrastructure;
using Backend.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 3;
        public IActionResult Index(string category, int page = 1)
        {
            ProductListsViewModel model = new ProductListsViewModel();
            var Products = Repository.Products
                .Where(p => category == null || p.Category.ToLower() == category.ToLower())
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * this.PageSize)
                .Take(this.PageSize);

            var Paginator = new Paginator
            {
                CurrentPage = page,
                ItemsPerPage = this.PageSize,
                TotalItems = Repository.getProductsCount(category)
            };


            model = new ProductListsViewModel { Products = Products, Paginator = Paginator, CurrentCategory = category };
            return View(model);
        }
    }
}