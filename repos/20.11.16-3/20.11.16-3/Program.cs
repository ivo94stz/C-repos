using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var junior = double.Parse(Console.ReadLine());
            var senior = double.Parse(Console.ReadLine());
            var trase = Console.ReadLine();
            var total = 0.0;
            if (trase == "trail")
            {
                junior = junior * 5.5;
                senior = senior * 7;
                var sum = junior + senior;
                 total = sum - sum * 0.05;
            }
            else if (trase == "cross-country")
            {
                
                if (junior + senior >= 50)
                {
                    
                    var sum =(junior * 8 + senior * 9.5) * 0.75;
                    total = sum - sum * 0.05;
                }
                else
                {
                    junior = junior * 8;
                    senior = senior * 9.5;
                    var sum = junior + senior;
                    total = sum - sum * 0.05;
                }
                
            }
            else if (trase == "downhill")
            {
                junior = junior * 12.25;
                senior = senior * 13.75;
                var sum = junior + senior;
                total = sum - sum * 0.05;
            }
            else if (trase == "road")
            {
                junior = junior * 20;
                senior = senior * 21.5;
                var sum = junior + senior;
                total = sum - sum * 0.05;
            }
            Console.WriteLine("{0:f2}", total);

        }
    }
}
