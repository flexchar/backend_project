using System.Threading.Tasks;
using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class MovieItem : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Movie movie)
        {
            return View(movie);
        }
    }
}
