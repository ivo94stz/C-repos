using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var tovar = 0.0;
            var sum = 0.0;
            var sumbus = 0.0;
            var sumkam = 0.0;
            var sumvlak = 0.0;
            for (int i = 0; i < n; i++)
            {
                tovar = double.Parse(Console.ReadLine());
                sum = sum + tovar;
                if (tovar <=3)
                {
                    sumbus = sumbus + tovar;
                }
                if (tovar > 3 && tovar <=11)
                {
                    sumkam = sumkam + tovar;
                }
                if (tovar >11)
                {
                    sumvlak = sumvlak + tovar;
                }

            }
            var sumbus1 = sumbus * 200;
            var sumkam1 = sumkam * 175;
            var sumvlak1 = sumvlak * 120;
            var sredno = (sumbus1 + sumkam1 + sumvlak1) / sum;
         //   Console.WriteLine(sum);
            Console.WriteLine("{0:f2}", sredno);
            var bus1 = sumbus / sum * 100;
            var kam1 = sumkam / sum * 100;
            var vlak1 = sumvlak / sum * 100;
            Console.WriteLine("{0:f2}%", bus1);
            Console.WriteLine("{0:f2}%", kam1);
            Console.WriteLine("{0:f2}%", vlak1);

        }
    }
}
