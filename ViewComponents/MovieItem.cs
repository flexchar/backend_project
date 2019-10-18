using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class MovieItem : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie);
        }
    }
}
