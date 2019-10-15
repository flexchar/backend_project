using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MandotaryAssignment01.Infrastructure;
using MandotaryAssignment01.Models;
using MandotaryAssignment01.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.Controllers
{
    public class CartController : Controller
    {
        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                GetCart().RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart");

            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetJson("Cart", cart);
            }
            return cart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
        // public ViewResult Index(string returnUrl)
        // {
        //     return View(new CartIndexViewModel
        //     {
        //         Cart = GetCart(),
        //         ReturnUrl = returnUrl
        //     });
        // }
    }
}