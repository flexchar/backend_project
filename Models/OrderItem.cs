using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class OrderItem
    {

        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice { get; }

        public Product Product { get; set; }

        public int OrderItemId { get; set; }

        public OrderItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }


    }
}
