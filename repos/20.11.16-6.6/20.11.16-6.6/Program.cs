using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pok1 = int.Parse(Console.ReadLine());
            var pok2 = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var num = 0;

            for (int i1 = 1; i1 <= pok1; i1++)
            {
                for (int i2 = 1; i2 <= pok2; i2++)
                {
                    Console.Write("({0} <-> {1}) ", i1, i2);
                    num++;
                    if (num == max) break;

                }
                if (num == max) break;

            }




        }
    }
}
