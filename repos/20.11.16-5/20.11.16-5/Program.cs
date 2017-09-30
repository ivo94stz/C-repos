using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var spaces = 0;
            var dot = (n * 3 - 2)/2;
            var stars = 2 * n - 2;
            var dotx = n / 2;

                for (int rows = 1; rows <= n ; rows++)
                {
                    for (int i = 1; i <= dot; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("/");
                    for (int i = 1; i <= spaces; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");
                    for (int i = 1; i <= dot; i++)
                    {
                        Console.Write(".");
                    }
                    dot--;
                    spaces += 2;
                    Console.WriteLine();
            
                }
            
            
               
                for (int rows =1 ; rows <= 1; rows++)
                {
                    for (int i = 0; i < n/2; i++)
                    {
                        Console.Write(".");
                    }
                    for (int i = 0; i < n*2; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < n / 2; i++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
               
               
               
               for (int rows = 1; rows <=2*n; rows++)
               {
                  for (int i = 1; i <= 3*n; i++)
                  {
                      if (i <= n / 2) Console.Write(".");
                      else if (i == n / 2+1  || i == 3 * n - n / 2 ) Console.Write("|");
                      else if (i > n / 2+1 && i <= (3 * n - n / 2)-1) Console.Write("\\");
                      else Console.Write(".");
                  }
                  Console.WriteLine();
               }
               
               
               
            for (int rows = 1; rows <= n/2; rows++)
            {
                
                for (int i = 1; i <= dotx; i++)
                {
                    Console.Write(".");
                }
                Console.Write("/");
                for (int i = 1; i <= stars; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int i = 1; i <= dotx; i++)
                {
                    Console.Write(".");
                }
                dotx--;
                stars += 2;
                Console.WriteLine();
            }
        }
    }
}
