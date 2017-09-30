using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                if (x > max) max = x;
                sum += x;
            }
            sum = sum - max;

            if (sum == max) Console.WriteLine("Yes sum = " + sum) ;
            else Console.WriteLine("No Diff = " + Math.Abs(sum-max));
        }
    }
}
