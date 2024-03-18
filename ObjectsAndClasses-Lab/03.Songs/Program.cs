using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _03.Songs
{
    internal class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();

            for (int i = 0; i < n; i++)
            {
          
                string[] songTokens = Console.ReadLine().Split("_");
                Song song = new Song();
                song.TypeList = songTokens[0];
                song.Time = songTokens[2];
                song.Name = songTokens[1];

                playlist.Add(song);
            }

            string playlistToPrint = Console.ReadLine();
            if (playlistToPrint == "all")
            {
                foreach (var song in playlist)
                {
                    Console.WriteLine(song.Name);
                }
                return;
            }

            foreach (Song song in playlist)
            {
                if (song.TypeList == playlistToPrint)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
        
           class Song
           {
            public string TypeList { get; set; }  

            public string Name { get; set; }

            public string Time {  get; set; }   
           } 
        
    }
}
