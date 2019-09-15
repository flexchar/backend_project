using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class Track
    {
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }

        public Track(string title, string composer, TimeSpan length)
        {
            this.Title = title;
            this.Composer = composer;
            this.Length = length;
        }


    }
}
