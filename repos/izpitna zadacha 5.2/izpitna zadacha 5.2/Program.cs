using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
            }

            var p1p = p1 / n * 100;
            var p2p = p2 / n * 100;
            var p3p = p3 / n * 100;

            Console.WriteLine("{0:f2}%", p1p);
            Console.WriteLine("{0:f2}%", p2p);
            Console.WriteLine("{0:f2}%", p3p);


        }
    }
}
