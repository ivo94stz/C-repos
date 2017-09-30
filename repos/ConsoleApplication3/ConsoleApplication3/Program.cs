using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocenka = double.Parse(Console.ReadLine());

            if (ocenka < 5.50 && ocenka >= 2)
            {
                Console.WriteLine("not exellent");
            }
            else if (ocenka <= 6)
            {
                Console.WriteLine("exellent");



            }
        }
    }
}
