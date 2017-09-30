using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            if (first - second >= 0) Console.WriteLine("in");
            else Console.WriteLine("out");

            var x = Math.Abs(point - first);
            var z = Math.Abs(second - point);

            if (x <= z) Console.WriteLine(x);
            else Console.WriteLine(z);

        }
    }
}
