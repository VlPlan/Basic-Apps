using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Type { get; set; }

        public Song(string track, Genre genre)
        {
            Title = track;
            Type = genre;
        }
    }
}
