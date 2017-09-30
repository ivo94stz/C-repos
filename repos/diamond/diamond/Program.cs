using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
          var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int i = 1; i <= n - rows; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i <= rows - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

                for (int rowd = 1; rowd <= n- 1; rowd++)
                {
                    for (int i = 1; i <= rowd; i++)
                    {
                    Console.Write(" ");
                    }
                Console.Write("*");
                for (int i = n - rowd - 1; i >=1 ; i--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            
        }
    }
}
