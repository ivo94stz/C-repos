using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;
            var p5 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if ( num < 200) p1++;
                else if (num >= 200 && num < 400) p2++;
                else if (num >= 400 && num < 600) p3++;
                else if (num >= 600 && num < 800) p4++;
                else if (num >= 800) p5++;
            }

            double p1p = p1 / n * 100;
            double p2p = p2 / n * 100;
            double p3p = p3 / n * 100;
            double p4p = p4 / n * 100;
            double p5p = p5 / n * 100;

            Console.WriteLine("{0:f2}%", p1p);
            Console.WriteLine("{0:f2}%", p2p);
            Console.WriteLine("{0:f2}%", p3p);
            Console.WriteLine("{0:f2}%", p4p);
            Console.WriteLine("{0:f2}%", p5p);




        }
    }
}
