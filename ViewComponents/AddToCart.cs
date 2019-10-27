using Microsoft.AspNetCore.Mvc;

namespace Backend.ViewComponents
{
    public class AddToCart : ViewComponent
    {
        public IViewComponentResult Invoke(int productId)
        {
            return View(productId);
        }
    }
}
