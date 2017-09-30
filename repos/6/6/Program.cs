using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if(n>=2 && n<=100)
            {
                for (int row = 0; row < n/2 ; row++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n-2));
                    Console.Write('|');
                    Console.WriteLine();
                }
            }



        }
    }
}
