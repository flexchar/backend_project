using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Track
    {
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }

        public Track(string title, TimeSpan length)
        {
            this.Title = title;
            this.Length = length;
        }


    }
}
