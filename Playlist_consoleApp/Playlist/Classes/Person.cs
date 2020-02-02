using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(int id, string first, string last, Genre type, List<Song> title)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            FavMusicType = type;
            FavoriteSongs = title;

        }



        public void GetFavSongs()
        {

            if (FavoriteSongs != null)
            {
                Console.WriteLine($"{ FirstName} favorite songs are:");
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            else Console.WriteLine($"{FirstName} {LastName} hates music");


        }
    }
}
