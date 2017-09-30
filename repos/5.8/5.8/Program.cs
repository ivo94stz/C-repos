using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumeven = 0.00;
            var sumodd = 0.00;
            
            for (int i = 1; i <= n; i++)
            {
                var x = int.Parse(Console.ReadLine());

                if (i % 2 == 0) sumeven = sumeven + x;
                else sumodd = sumodd + x;
            }

            if (sumeven == sumodd) Console.WriteLine("Yes, sum = {0} ", + sumeven);
            else Console.WriteLine("No, diff = {0}", + Math.Abs(sumeven - sumodd));

        }
    }
}
