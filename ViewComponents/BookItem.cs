using MandotaryAssignment01.Models;
using Microsoft.AspNetCore.Mvc;

namespace MandotaryAssignment01.ViewComponents
{
    public class BookItem : ViewComponent
    {
        public IViewComponentResult Invoke(Book book)
        {
            return View(book);
        }
    }
}
