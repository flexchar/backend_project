using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Movie : Product
    {
        public string Director { get; set; }
        public short Released { get; set; }

        public Movie(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }
        public Movie(string title, decimal price, string imageUrl, string director)
        {
            this.Title = title;
            this.Price = price;
            this.ImageUrl = imageUrl;
            this.Director = director;
        }


    }
}
