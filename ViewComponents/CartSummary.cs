using MandotaryAssignment01.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class CartSummary : ViewComponent
    {
        private Cart cart;
        public CartSummary(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}