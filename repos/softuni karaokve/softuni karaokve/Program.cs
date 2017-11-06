using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuni_karaokve
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();


            var output = new SortedDictionary<string, List<string>>();
            
            while (command[0] != "dawn")
            {
                if (command.Count == 3)
                {
                    string name = command[0];
                    string song = command[1];
                    string award = command[2];

                    if (names.Contains(name) && songs.Contains(song))
                    {
                        
                        
                        if (output.ContainsKey(name))
                        {
                            if (!output[name].Contains(award))
                            {
                                output[name].Add(award);
                            }
                        }
                        else
                        {
                            output[name] = new List<string>();
                            output[name].Add(award);
                        }
                    }
                }

                else
                {
                    command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in output.OrderByDescending(a=>a.Value.Count))
            {
                
                    Console.WriteLine("{0}: {1} awards",item.Key,item.Value.Count);

                foreach (var awar in item.Value.OrderBy(awar=>awar))
                {
                    Console.WriteLine("--{0}",awar);
                }
            }
            if(output.Count == 0) Console.WriteLine("No awards");

        }
    }
}
