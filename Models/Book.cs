using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Book
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }

        public string ISBN { get; set; }

        public Book(string author, string publisher, short published)
        {
            this.Author = Author;
            this.Publisher = publisher;
            this.Published = published;
        }


    }
}
