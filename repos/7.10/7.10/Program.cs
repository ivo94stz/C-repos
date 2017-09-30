using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var x = 2;
            var y = 0;

            if (num < 2) Console.WriteLine("Not Prime");
            else
            {
               while (num % x == 0 && num / x >1)
                {
                    Console.WriteLine("Prime");
                    x++;
                    break;
                }
                Console.WriteLine("Not Prime");
            }

        }
    }
}
