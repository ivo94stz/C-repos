using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_6._._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var x = 0;

            for (int i = start; i <= end; i++)
            {
                for (int i1 = start; i1 <= end; i1++)
                {
                    Console.Write("<{0}-{1}>",i,i1);
                    x++;
                    if (x == max) break;
                }
                if (x == max) break;

            }


        }
    }
}
