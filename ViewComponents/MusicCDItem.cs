using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class MusicCDItem : ViewComponent
    {
        public IViewComponentResult Invoke(MusicCD cd)
        {
            return View(cd);
        }
    }
}
