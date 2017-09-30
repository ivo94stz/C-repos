using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee") Console.WriteLine(0.5 * kol);
                else if (product == "water") Console.WriteLine(0.8 * kol);
                else if (product == "beer") Console.WriteLine(1.2 * kol);
                else if (product == "sweets") Console.WriteLine(1.45 * kol);
                else if (product == "peanuts") Console.WriteLine(1.6 * kol);
            }
            else if (city == "Varna")
            {
                if (product == "coffee") Console.WriteLine(0.45 * kol);
                else if (product == "water") Console.WriteLine(0.7 * kol);
                else if (product == "beer") Console.WriteLine(1.1 * kol);
                else if (product == "sweets") Console.WriteLine(1.35 * kol);
                else if (product == "peanuts") Console.WriteLine(1.55 * kol);
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee") Console.WriteLine(0.4 * kol);
                else if (product == "water") Console.WriteLine(0.7 * kol);
                else if (product == "beer") Console.WriteLine(1.15 * kol);
                else if (product == "sweets") Console.WriteLine(1.3 * kol);
                else if (product == "peanuts") Console.WriteLine(1.5 * kol);
            }
        }
    }
}
