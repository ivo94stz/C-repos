using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
namespace Softuni_coffee_orders
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal orders = decimal.Parse(Console.ReadLine());

            
            decimal price = 0;
            decimal total = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal pricecaps = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal capscount = decimal.Parse(Console.ReadLine());
                price = daysInMonth * capscount * pricecaps;
                

                Console.WriteLine("The price for the coffee is: ${0:F2}",price);
                total += price;
            }

            Console.WriteLine("Total: ${0:F2}",total);

        }
    }
}
