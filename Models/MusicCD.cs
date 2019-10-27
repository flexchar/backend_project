using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public TimeSpan PlayingTime
        {
            get
            {
                TimeSpan time = new TimeSpan();
                foreach (Track t in this.Tracks)
                {
                    time += t.Length;
                }
                return time;
            }


        }
        public List<Track> Tracks { get; } = new List<Track>();

        public MusicCD(string artist, string title, decimal price, short released)
        {
            this.Artist = artist;
            this.Title = title;
            this.Price = price;
            this.Released = released;
        }

        public MusicCD AddTrack(Track track)
        {
            this.Tracks.Add(track);
            return this;
        }


    }
}
