using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify_project.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

        private Random random;

        public Playlist(Song firstSong)
        {
            Id= Guid.NewGuid();
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if (song != null)
            {
                Songs.Add(song);
            }
        }

        //public void ShowSongs()
        //{
        //    foreach(Song song in Songs)
        //    {
        //        Console.WriteLine($"Title: {song.Title} - Composer: {song.Composer}");
        //    }
        //}

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(x => $"Title: {x.Title} - Composer: {x.Composer}"));
        }

        public void ShuffleSongs()
        {
            int count = Songs.Count;

            while (count > 0)
            {
                count--;

                int randomIndex = random.Next(0, count);

                Song song = Songs[count];

                Songs[count] = Songs[randomIndex];

                Songs[randomIndex] = song;

            }
        }
    }
}
