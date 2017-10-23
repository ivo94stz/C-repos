using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }

            }
            var result = new List<string>();
            foreach (var pairs in counts)
            {
                if (pairs.Value%2!=0)
                {
                    result.Add(pairs.Key);
                }


            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
