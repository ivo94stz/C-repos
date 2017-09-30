using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._08._16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 2*n-1;
            var tireleft = n*3;
            var tiremiddle = n - 1;
            var star = n;
            var tireright = n - 1;

            //part 1
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < n*3; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < 2*n-1; i++)
                {
                    if (i == row) Console.Write("*");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }


            // part 2

            for (int row = 0; row < n/2; row++)
            {
                for (int i = 0; i < n*3+1; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < n*2-1; i++)
                {
                    if (i == n-1) Console.Write("*");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }


            // part 3
            for (int row = 0; row < n/2-1; row++)
            {
                for (int i = 0; i < tireleft; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < tiremiddle; i++)
                {
                    Console.Write("-");
                    
                }
                Console.Write("*");
                for (int i = 0; i < tireright; i++)
                {
                    Console.Write("-");
                }
                tireright--;
                tiremiddle += 2;
                tireleft--;
                Console.WriteLine();
            }


            //part 4
            for (int i = 1; i <= 5*n; i++)
            {
                if (i >= 1 && i <= (3 * n)- (n/2-1)) Console.Write("-");
                else if (i > (5 * n) - (n + 1) / 2) Console.Write("-");
                else Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
