using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var a = (double.Parse(Console.ReadLine()) / 60);
            var b = (double.Parse(Console.ReadLine()) / 60);
            var c = (double.Parse(Console.ReadLine()) / 60);

            
            var s1 = (first * a);
            var s2 = ((first + 0.1 * first) * b);
            var s3 = ((first + 0.1 * first) - 0.05 * (first + 0.1 * first)) * c;
            var S = s1 + s2 + s3;
            Console.WriteLine("{0:f2}",S);
        }
    }
}
