using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

           
                for (int row = 0; row < n; row++)
                {
                    Console.Write("$");
                    for (int cow = 0; cow < row; cow++)
                    {
                        Console.Write(" $");
                    }
                    Console.WriteLine();
                }
                
                
            
        }
    }
}
