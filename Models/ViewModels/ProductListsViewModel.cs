using System.Collections.Generic;
using MandotaryAssignment01.Models;
using MandotaryAssignment01.Models.ViewModels;

namespace MandotaryAssignment01.Models.ViewModels
{
    public class ProductListsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Paginator Paginator { get; set; }

        public string CurrentCategory { get; set; }

    }
}