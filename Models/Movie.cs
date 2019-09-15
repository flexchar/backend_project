using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Movie
    {
        public string Director { get; set; }
        public short Released { get; set; }

        public Movie(string director, short released)
        {
            this.Director = Director;
            this.Released = released;
        }


    }
}
