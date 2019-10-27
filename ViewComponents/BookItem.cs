using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.ViewComponents
{
    public class BookItem : ViewComponent
    {
        public IViewComponentResult Invoke(Book book)
        {
            return View(book);
        }
    }
}
