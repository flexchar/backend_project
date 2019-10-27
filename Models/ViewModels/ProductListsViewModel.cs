using System.Collections.Generic;
using Backend.Models;
using Backend.Models.ViewModels;

namespace Backend.Models.ViewModels
{
    public class ProductListsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Paginator Paginator { get; set; }

        public string CurrentCategory { get; set; }

    }
}