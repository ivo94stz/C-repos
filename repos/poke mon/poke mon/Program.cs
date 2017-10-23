using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke_mon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            decimal count = 0;
            decimal subtracting = n * 0.5m;

            while (m <= n)
            {
                
                n = n - m;
                count++;
                if (n == subtracting && y > 0) n = n / y;
               
            }


            Console.WriteLine(Math.Floor( n));
            Console.WriteLine(count);

        }
    }
}
