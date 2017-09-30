using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            

            if(n >= 3 && n <=100)
            for (int row = 0; row < n; row++)
            {
                    if (row == 0 || row == n - 1) Console.Write(new string('*', n * 2));
                    else
                    {
                        for (int col = 0; col < n*2; col++)
                            if (col == 0 || col == n * 2 - 1) Console.Write("*");
                            else Console.Write('/');
                    }

                    if (row == (n-1) / 2) Console.Write(new string('|', n));
                    else Console.Write(new string(' ', n));

                    if (row == 0 || row == n - 1) Console.Write(new string('*', n * 2));
                    else
                    {
                        for (int col = 0; col < n * 2; col++)
                            if (col == 0 || col == n * 2 - 1) Console.Write("*");
                            else Console.Write('/');
                    }
                    Console.Write(new string(' ', n));
                       // Console.Write(new string('*', n * 2));

                        Console.WriteLine();
                    

            }

        }
    }
}
