using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 0;
            var space = n;

            for (int row = 0; row < n+1; row++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string('*', stars));
                Console.Write(" | ");

                Console.Write(new string('*', stars));
                Console.Write(new string(' ', space));
                Console.WriteLine();
                space--; stars++;
            }

        }
    }
}
