using System.Threading.Tasks;
using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class AddToCart : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            return View(productId);
        }
    }
}
