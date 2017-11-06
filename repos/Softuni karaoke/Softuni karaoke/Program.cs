using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new string[] {", " },StringSplitOptions.None);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string[] command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            
            int count = 0;
            var awards = new Dictionary<string, List<string>>();


            while (command[0] != "dawn")
            {

                if (names.Contains(command[0]) && songs.Contains(command[1]))
                {
                    if (!awards.ContainsKey(command[0]))
                    {
                        awards[command[0]] = new List<string>();
                        
                    }
                    if (!awards[command[0]].Contains(command[2]))
                    {
                        awards[command[0]].Add(command[2]);
                    }

                }



                

                command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
                count = 0;
            }
            if (awards.Any())
            {
                foreach (var singer in awards.OrderByDescending(x=>x.Value.Count).ThenBy(n=>n.Key))
                {
                    Console.WriteLine("{0}: {1} awards",singer.Key,awards[command[0]].Count);
                    for (int i = 0; i < awards[command[0]].Count; i++)
                    {
                        Console.WriteLine("--{0}",awards[command[i]]);
                    }

                }

            }




        }
    }
}
