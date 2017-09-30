using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 1; spaces <= n-row; spaces++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine("*");
                for (int stars = 1; stars < row-1; stars++)
                {
                    Console.Write(" *");
                }
            }

        }
    }
}
