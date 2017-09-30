using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._08._16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());
            var studio = 0.0;
            var apart = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14) studio = 50 * nights - 50 * nights * 0.05;
                else if (nights > 14) studio = 50 * nights - 50 * nights * 0.3;
                else studio = 50 * nights;
                if (nights > 14) apart = 65 * nights - 65 * nights * 0.1;
                else apart = 65 * nights;
            }
            else if (month=="June" || month == "September")
            {
                if (nights > 14) studio = 75.2 * nights- 75.2*nights * 0.2;
                else studio = 75.2 * nights;
                if (nights > 14) apart = 68.7 * nights - 68.7 * nights * 0.1;
                else apart = 68.7 * nights;
            }
            else if(month=="July" || month == "August")
            {
                studio = 76 * nights;
                if (nights > 14) apart = 77 * nights - 77 * nights * 0.1;
                else apart = 77 * nights;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apart);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }
    }
}
