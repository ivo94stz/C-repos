using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._04._16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = n;
            var down = 2*n-1;
            var downf = down+2*(n-1);

            // part 1
            for (int row = 0; row < n+1; row++)
            {
                if (row == 0)
                {
                    for (int i = 0; i < n + 1; i++)
                    {
                        Console.Write(".");
                    }
                    for (int i = 0; i < 2*n+1; i++)
                    {
                        Console.Write("_");
                    }
                    for (int i = 0; i < n + 1; i++)
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    for (int i = 0; i < dot; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("//");
                    for (int i = 0; i < down; i++)
                    {
                        Console.Write("_");
                    }
                    Console.Write("\\\\");
                    for (int i = 0; i < dot; i++)
                    {
                        Console.Write(".");
                    }
                    dot--;
                    down += 2;
                    var x = down;
                }
                Console.WriteLine();
            }


            //part 2

            Console.Write("//");
            for (int i = 0; i < downf/2-1; i++)
            {
                Console.Write("_");
            }
            Console.Write("STOP!");
            for (int i = 0; i < downf/2-1; i++)
            {
                Console.Write("_");
            }

            Console.Write("\\\\");
            Console.WriteLine();

            // part 3
            Console.Write("\\\\");
            for (int i = 0; i < downf+2; i++)
            {
                Console.Write("_");
            }
            Console.Write("//");
            Console.WriteLine();


            
            //part 4
            for (int row = 1; row <= n-1; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\\\\");
                for (int i = 0; i <downf  ; i++)
                {
                    Console.Write("_");
                }
                Console.Write("//");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                downf -= 2;

                Console.WriteLine();
            }

        }

    }
}
