using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i ==n-1)
                    Console.Write("+");
                else Console.Write("|");

                for (int row = 0; row < n-2; row++)
                {
                    Console.Write(" -", n - 2);
                }
                if (i == 0 || i == n - 1)
                    Console.WriteLine(" +");
                else Console.WriteLine(" |");
                
            }

        }
    }
}
