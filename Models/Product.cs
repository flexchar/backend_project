using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public Product()
        {

        }

        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }


    }
}
