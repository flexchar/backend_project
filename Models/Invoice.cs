using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice
        {
            get
            {
                Decimal price = 0;
                foreach (OrderItem i in this.OrderItems)
                {
                    price += i.Product.Price;
                }
                return price;
            }
        }


        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }

        public Invoice AddOrderItem(Product product, int quantity)
        {
            OrderItem o = new OrderItem(product, quantity);
            this.OrderItems.Add(o);
            return this;
        }
    }
}
