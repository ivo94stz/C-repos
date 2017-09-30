using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                var z = double.Parse(Console.ReadLine());
                max = Math.Max(max, z);
            }
            Console.WriteLine(max);
        }
    }
}
