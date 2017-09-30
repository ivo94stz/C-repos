using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11016_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var starsleft = 1;
            var tire = 2*n-1;
            var starsmiddle1 = n / 2;
            var starsmiddle2 = starsmiddle1 * 2 + 1;
            var starsright = 1;
            var tiredown = 2 * n - 1;


            //part 1
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < starsleft; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int i = 0; i < tire; i++)
                {
                    Console.Write("-");
                }
                tire -= 2;
                Console.Write("/");
                for (int i = 0; i < starsleft; i++)
                {
                    Console.Write("*");
                }
                starsleft++;
                Console.WriteLine();
            }


            // part 2
            for (int row = 0; row < n/3; row++)
            {
                Console.Write("|");
                for (int i = 0; i < starsmiddle1; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int i = 0; i < starsmiddle2; i++)
                {
                    Console.Write("*");
                }
                Console.Write("/");
                for (int i = 0; i < starsmiddle1; i++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                starsmiddle1++;
                starsmiddle2 -= 2;
                Console.WriteLine();
            }



            //part 3
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < starsright; i++)
                {
                    Console.Write("-");
                }
                Console.Write("\\");
                for (int i = 0; i < tiredown; i++)
                {
                    Console.Write("*");
                }
                tiredown -= 2;
                Console.Write("/");
                for (int i = 0; i < starsright; i++)
                {
                    Console.Write("-");
                }
                starsright++;
                Console.WriteLine();
            }


        }
    }
}
