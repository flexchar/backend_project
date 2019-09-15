using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MandotaryAssignment01.Models
{
    public class MusicCD
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        public TimeSpan PlayingTime { get; }

        public List<Track> Tracks { get; }

        public MusicCD(string artist, string label, short released)
        {
            this.Artist = artist;
            this.Label = label;
            this.Released = released;
        }

        public MusicCD AddTrack(Track track)
        {
            this.Tracks.Add(track);
            return this;
        }


    }
}
