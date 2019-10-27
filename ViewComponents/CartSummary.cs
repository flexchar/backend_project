using Backend.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Backend.ViewComponents
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