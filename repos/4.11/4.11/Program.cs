using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var proj = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (proj == "Premiere")
            {
                var result = r * c * 12.0;
                Console.WriteLine("{0:f2} leva", result);
            }
            else if (proj == "Normal")
            {
                var result = r * c * 7.5;
                Console.WriteLine("{0:f2} leva", result);
            }
            else if( proj == "Discount")
            {
                var result = r * c * 5.0;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
