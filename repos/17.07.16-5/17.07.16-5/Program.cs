using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._07._16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var star = n-2;
            var dotsight = n-1;
            var dotmiddle = 3 * n;
            var dotdown = 1;
            var dot = 5*n-4;
            var dotlast = 2 * n + 1;
            

            //part 1
            for (int row = 1; row <= n+1; row++)
            {
                if(row == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(".");
                    }
                    for (int i = 0; i < 3*n; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(".");
                    }
                }
                else if (row == n + 1)
                {
                    for (int i = 0; i < 5 * n; i++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int i = 1; i <= dotsight ; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int i = 0; i < dotmiddle; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int i = 1; i <= dotsight; i++)
                    {
                        Console.Write(".");
                    }
                    dotsight--;
                    dotmiddle+=2;
                }
                Console.WriteLine();
            }
            // part 2
            for (int row = 0; row < 2*n+1; row++)
            {
                if (row == 2 * n)
                {
                    for (int i = 0; i < dotlast; i++)
                    {
                        Console.Write(".");
                    }
                    for (int i = 0; i < star; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < dotlast; i++)
                    {
                        Console.Write(".");
                    }
                }
               else
               {
                   for (int i = 0; i < dotdown; i++)
                   {
                       Console.Write(".");
                   }
                   Console.Write("*");
                   for (int i = 0; i < dot; i++)
                   {
                       Console.Write(".");
                   }
                   Console.Write("*");
                   for (int i = 0; i < dotdown; i++)
                   {
                       Console.Write(".");
                   }
               }
               dotdown++;
               dot -= 2;
                Console.WriteLine();
            }
            
        }
    }
}
