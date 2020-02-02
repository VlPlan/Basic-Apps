using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;


namespace Playlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Fly Away", Genre.Rock);
            Song song2 = new Song("November Rain", Genre.Rock);
            Song song3 = new Song("Zombie", Genre.Rock);
            Song song4 = new Song("Basket Case", Genre.Rock);
            Song song5 = new Song("Always", Genre.Rock);
            Song song6 = new Song("Save Tonight", Genre.Rock);
            Song song7 = new Song("Money for nothing", Genre.Rock);
            Song song8 = new Song("Iris", Genre.Rock);
            Song song9 = new Song("Breathe", Genre.Techno);
            Song song10 = new Song("Da Rockwilder", Genre.Hip_Hop);
            Song song11 = new Song("My name is", Genre.Hip_Hop);
            Song song12 = new Song("Children", Genre.Techno);
            Song song13 = new Song("Firestarter", Genre.Techno);


            List<Song> VladSongs = new List<Song>() { song8, song11, song13, song6, song1 };

            Person Vladimir = new Person(1, "Vladimir", "Planojevikj", Genre.Rock, VladSongs);

            List<Song> MimiSongs = new List<Song>() { song12, song3, song2, song5, song10 };

            Person Mimi = new Person(2, "Mimi", "Pannini", Genre.Techno, MimiSongs);

            List<Song> GoranSongs = new List<Song>() { song9, song4, song8, song1 };

            Person Goran = new Person(3, "Goran", "Pandev", Genre.Hip_Hop, GoranSongs);

            Person Boris = new Person(4, "Boris", "Becker", Genre.Classical, null);

            Vladimir.GetFavSongs();
            Mimi.GetFavSongs();
            Goran.GetFavSongs();
            Boris.GetFavSongs();


            Console.ReadLine();

        }
    }
}
