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
        private Cart cart;

        public CartController(Cart cartService)
        {
            this.cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(
                new CartIndexViewModel
                {
                    Cart = this.cart,
                    ReturnUrl = returnUrl
                }
            );
        }

        public RedirectToActionResult AddToCart(int productID, string returnUrl, int quantity = 1)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);

            if (product != null)
            {
                this.cart.AddItem(product, quantity);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                this.cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}