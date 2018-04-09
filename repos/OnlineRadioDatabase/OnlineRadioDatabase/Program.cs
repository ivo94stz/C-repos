using System;
using System.Collections.Generic;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            int playlistMins = 0;
            int playlistSecs = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] info = input.Split(';');
                string artistName = info[0];
                string songName = info[1];
                string length = info[2];
                string[] time = length.Split(':');
                int mins = int.Parse(time[0]);
                int secs = int.Parse(time[1]);

                

                try
                {
                    Song song = new Song(artistName, songName, length);
                    songs.Add(song);
                    playlistMins += mins;
                    playlistSecs += secs;
                    Console.WriteLine("Song added.");
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                

            }
            
            Console.WriteLine("Songs added: {0}",songs.Count);

            int playlistFinalS = playlistSecs % 60;
            int playlistFinalM = (playlistMins % 60) + (playlistSecs / 60 ) % 60;
            int playlistFinalH =  (playlistSecs / 60) /60;
            if (playlistFinalM > 59)
            {
                playlistFinalH++;
                playlistFinalM %= 60;
            }
            

            Console.WriteLine("Playlist length: {0}h {1}m {2}s", playlistFinalH, playlistFinalM, playlistFinalS);



        }
    }
}
