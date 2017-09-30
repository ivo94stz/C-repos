using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var car = 0.0;
            var mikro = 0.0;
            var little = 0.0;
            var big = 0.0;
            var train = 0.0;
            var total = 0.0;

            for (int i = 0; i < n; i++)
            {
                var group = double.Parse(Console.ReadLine()); 
                if (group < 6) car = car + group;
                else if (group >= 6 && group <= 12) mikro = mikro + group;
                else if (group > 12 && group < 26) little = little + group;
                else if (group > 25 && group < 41) big = big + group;
                else train = train + group;


                total = total + group;
            
            }
            Console.WriteLine("{0:f2}%", car/total*100);
            Console.WriteLine("{0:f2}%", mikro / total * 100);
            Console.WriteLine("{0:f2}%", little / total * 100);
            Console.WriteLine("{0:f2}%", big / total * 100);
            Console.WriteLine("{0:f2}%", train / total * 100);

        }
    }
}
