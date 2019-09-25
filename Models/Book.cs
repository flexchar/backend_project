using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }

        public string ISBN { get; set; }

        public Book(string author, string title, decimal price, short published)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
            this.Published = published;
        }


    }
}
