using MandotaryAssignment01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository() {
            Book book1 = new Book("Georg Martin", "With a Little Help from My Friends: The  Making of Sgt. Pepper", 1995);

            this.Products.Add(book1);


        }
    }
}
