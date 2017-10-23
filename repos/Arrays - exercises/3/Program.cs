using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var intarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = intarr.Length / 4;

            int[] leftarr = intarr.Take(k).ToArray();
            int[] rightarr = intarr.Skip(3 * k).Take(k).ToArray();
            int[] middlearr = intarr.Skip(k).Take(2 * k).ToArray();

            Array.Reverse(leftarr);
            Array.Reverse(rightarr);
            int[] result = leftarr.Concat(rightarr).ToArray();
            int[] final = new int[k * 2];
            for (int i = 0; i < result.Length; i++)
            {
                final[i] = middlearr[i] + result[i];
            }
            

            

            //for (int i = 0; i < middlearr.Length; i++)
            //{
            //    if (i < k)
            //    {
            //        result[i] = leftarr[i] + middlearr[i];
            //    }
            //    else
            //    {
            //        result[i] = middlearr[i] + rightarr[i % k];
            //    }
                
            //}
            Console.WriteLine(string.Join(" ", final));




        }
    }
}
