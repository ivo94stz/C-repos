using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary <string, long>();

            List<string> files = new List<string>();
            for (int i = 0; i < n; i++)
            {
                files.Add(Console.ReadLine());
            }
            List<string> filter = Console.ReadLine().Split(' ').ToList();
            
            for (int i = 0; i < files.Count; i++)
            {
                string[] road = files[i].Split(new char[] { '\\' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string folder = road[0];
                if (filter[2] != folder) continue;
                else
                {
                    string[] last = road[road.Length - 1].Trim().Split(new char[] {';'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                    long size = long.Parse(last[last.Length - 1]);
                    string[] lastname = last[0].Split('.').ToArray();
                    string extansion = lastname[lastname.Length - 1];
                    string filename = last[0];
                    //Console.WriteLine(string.Join(".",filename));
                    if (extansion == filter[0])
                    {
                        dictionary[filename] = size;

                    }



                }

                
                
            }
            if (dictionary.Count < 1) Console.WriteLine("No");
            else
            {
                foreach (var item in dictionary.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine("{0} - {1} KB", item.Key, item.Value);

                }
            }

            
            

        }
    }
}
