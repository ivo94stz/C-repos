using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                var x = 1;

                Console.WriteLine(x);
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(x *= 2);
                }
            }
            catch
            {
                Console.WriteLine("error");
            }

        }
    }
}
