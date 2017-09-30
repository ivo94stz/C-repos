using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var z = double.Parse(Console.ReadLine());
                max = Math.Min(max, z);
            }
            Console.WriteLine(max);
        }
    }
}
