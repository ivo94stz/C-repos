using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarity
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if(counts.ContainsKey(num))
                {
                    counts[num]++;

                }
                else
                {
                    counts[num] = 1;
                }

            }
            foreach (var count in counts.Keys)
            {
                Console.WriteLine("{0} -> {1} ",count,counts[count]);
                
            }
        }
    }
}
