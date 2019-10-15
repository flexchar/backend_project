using System.Threading.Tasks;
using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class BookItem : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Book book)
        {
            return View(book);
        }
    }
}
