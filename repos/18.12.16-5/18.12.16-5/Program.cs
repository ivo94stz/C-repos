using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._12._16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dot = n*2-1;
            var x = 0;
            var y = 0;


            // row 1
            for (int row = 0; row < 1; row++)
            {
                for (x = 1; x <= 2 * n - 1; x++)
                {
                    Console.Write(".");
                }
                Console.Write("/");
                Console.Write("|");
                Console.Write("\\");
                for (x = 1; x <= 2 * n - 1; x++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            // row 2
            for (int row = 0; row < 1; row++)
            {
                for (x = 1; x <= 2 * n - 1; x++)
                {
                    Console.Write(".");
                }
                Console.Write("\\");
                Console.Write("|");
                Console.Write("/");
                for (x = 1; x <= 2 * n - 1; x++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }


            //row 3
            for (int row = 0; row < 1; row++)
            {
                for ( y = 0; y < dot; y++)
                {
                    Console.Write(".");
                }
                Console.Write("***");
                for (y = 0; y < dot; y++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }


            // tree
            for (int row = 1; row <= n*2-1; row++)
            {
                for (int i = 0; i < dot-1; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < dot - 1; i++)
                {
                    Console.Write(".");
                }
                dot--;
                Console.WriteLine();
            }

            // stars
            for (int i = 0; i < 4*n+1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            // dot stars
            for (int i = 1; i <= 4*n+1; i++)
            {
                if (i % 2 == 0) Console.Write(".");
                else Console.Write("*");
            }
            Console.WriteLine();

            // stars
            for (int i = 0; i < 4 * n + 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
