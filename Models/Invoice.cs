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

        public decimal TotalPrice { get; }

        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }

        public Invoice AddOrderItem(Product product, int quantity)
        {
            this.OrderItems.Add(new OrderItem(product, quantity));
            return this;
        }
    }
}
