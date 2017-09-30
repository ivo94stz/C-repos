using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo = int.Parse(Console.ReadLine());
            if (chislo <100 )
            {
                Console.WriteLine("Less than 100");
            }
            if (chislo >=100 && chislo <= 200)
            {
                Console.WriteLine("between 100 and 200");

            }
            if (chislo > 200)
            {
                Console.WriteLine("greater than 200");
            }
        }
    }
}
