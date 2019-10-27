using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string Category
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public Product()
        {
            this.ProductId = new Random().Next(100, 300);
        }

        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;

            this.ProductId = new Random().Next(100, 300);
        }


    }
}
