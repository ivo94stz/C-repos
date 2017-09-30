using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = n * 2;

            if(n>=3 || n<=1000)
                for (int row = 1; row <= (n-1)/2 ; row++)
                {
                    Console.Write('/');
                    Console.Write(new string('^', n / 2));
                    Console.Write('\\');
                }
            Console.WriteLine();
            for (int col = 1; col <= 2*n ; col++)
            {
                if (col == 1 || col == n * 2) Console.Write('|');
                else Console.WriteLine(new string(' ', space - 2));


            }
            Console.WriteLine();


        }
    }
}
