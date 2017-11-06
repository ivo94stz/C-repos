using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalprice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal onecapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                decimal countcapsules = decimal.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = days*countcapsules*onecapsule;
                totalprice += price;
                Console.WriteLine("The price for the coffee is: ${0:f2}",price);
            }


            Console.WriteLine("Total: ${0:f2}",totalprice);

        }
    }
}
