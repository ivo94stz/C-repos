using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            var bulgarias = budget * 0.3;
            var bulgariaw = budget * 0.7;
            var balkanss = budget * 0.4;
            var balkansw = budget * 0.8;
            var europa = budget * 0.9;

            if ( sezon == "summer" && budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:0.00}", bulgarias);
            }
            else if (sezon == "winter" && budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:0.00}", bulgariaw);
            }
            else if(sezon == "summer" && budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:0.00}", balkanss);
            }
            else if (sezon == "winter" && budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:0.00}", balkansw);
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:0.00}", europa);
            }

        }
    }
}
