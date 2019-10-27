using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.ViewComponents
{
    public class MusicCDItem : ViewComponent
    {
        public IViewComponentResult Invoke(MusicCD cd)
        {
            return View(cd);
        }
    }
}
