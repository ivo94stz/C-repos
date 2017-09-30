using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var i = Console.ReadLine();
            var taxiDay = 0.70 + n * 0.79;
            var taxiNight = 0.70 + n * 0.90;
            var bus = n * 0.09;
            var train = n * 0.06;


            if (n >= 1 && n <= 5000)
            {
            if (n < 20)
            {
            if (i == "day") Console.WriteLine(taxiDay);
            else if (i == "night") Console.WriteLine(taxiNight);
            }
            else if (n >= 20 && n < 100)
            {
            if (i == "day") Console.WriteLine(bus);
            else if (i == "night") Console.WriteLine(bus);
            }
            else if (n >= 100)
            {
            if (i == "day") Console.WriteLine(train);
            else if (i == "night") Console.WriteLine(train);
            }
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
