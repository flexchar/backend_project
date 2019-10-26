using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class NavigationCategories : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IEnumerable categories = new List<string> {
                 "Book", "MusicCD", "Movie"
            };

            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(categories);
        }
    }
}
