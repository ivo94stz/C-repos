using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = 2;
            var a = (2*n+1)-6;
            var dotdown = n - 1;
            var space = 0;

            //part 1
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //part 2
            Console.Write(".");
            Console.Write("*");
            for (int i = 1; i <= 2*n-3; i++)
            {
                Console.Write(" ");

            }
            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();

            //part 3

            for (int row = 0; row < n-2; row++)
            {
                for (int i = 0; i < dot; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("@");
                }
                Console.Write("*");
                for (int i = 0; i < dot; i++)
                {
                    Console.Write(".");
                }
                dot++;
                a -= 2;
                Console.WriteLine();
            }

            // part 4

            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write(".");
                if (i == n ) Console.Write("*");
            }
            Console.WriteLine();


            //part 5

            for (int row = 0; row < n-2; row++)
            {
                for (int i = 0; i < dotdown; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < space; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("@");
                for (int i = 0; i < space; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < dotdown; i++)
                {
                    Console.Write(".");
                }
                dotdown--;
                space++;
                Console.WriteLine();
            }

            //part 6

            Console.Write(".");
            Console.Write("*");
            for (int i = 0; i < 2*n-3; i++)
            {
                Console.Write("@");
            }
            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();


            // part 7
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


        }
    }
}
