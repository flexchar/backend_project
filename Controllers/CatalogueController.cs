using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MandotaryAssignment01.Infrastructure;
using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.music = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.books = Repository.Products.OfType<Book>().ToList();

            return View();
        }
    }
}