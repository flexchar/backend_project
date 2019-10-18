using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class AddToCart : ViewComponent
    {
        public IViewComponentResult Invoke(int productId)
        {
            return View(productId);
        }
    }
}
