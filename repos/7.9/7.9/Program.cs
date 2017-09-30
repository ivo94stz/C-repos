using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var x = 0;

            while (num > 0)
            {
                var y = num % 10;
                num = num / 10;
                x += y;
            }
            Console.WriteLine(x);
             

        }
    }
}
