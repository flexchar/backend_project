using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.ViewComponents
{
    public class MovieItem : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie);
        }
    }
}
