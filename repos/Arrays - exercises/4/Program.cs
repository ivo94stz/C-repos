using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var intarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < intarr.Length; i++)
            {
                int[] leftarr = intarr.Take(i).ToArray();
                int[] rightarr = intarr.Skip(i + 1).ToArray();
                if (leftarr.Sum() == rightarr.Sum())
                {
                    Console.WriteLine(i);
                    count++;
                    break;
                }
            }
            if (count == 0) Console.WriteLine("no");
        }
    }
}