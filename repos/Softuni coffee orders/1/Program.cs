using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalprice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = ReadOrder();
                totalprice += price;
            }
            Console.WriteLine("Total: ${0:f2}",totalprice);
        }

         static decimal ReadOrder()
        {
            decimal price = decimal.Parse(Console.ReadLine());
            string datestr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(datestr, "d/M/yyyy",null);
            decimal daysinmonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal capsules = decimal.Parse(Console.ReadLine());

            decimal priceall = daysinmonth * price * capsules;
            Console.WriteLine("The price for the coffee is: ${0:f2}", priceall);
            return priceall;
        }
    }
}
