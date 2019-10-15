using System.Threading.Tasks;
using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class MusicCDItem : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(MusicCD cd)
        {
            return View(cd);
        }
    }
}
