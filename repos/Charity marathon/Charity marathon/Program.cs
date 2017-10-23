using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal runners = decimal.Parse(Console.ReadLine());
            decimal averlaps = decimal.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            decimal capacity = decimal.Parse(Console.ReadLine());
            decimal donate = decimal.Parse(Console.ReadLine());

            decimal maxrunners = capacity * days;
            if (maxrunners > runners) maxrunners = runners;
            if (runners > capacity) maxrunners = capacity * days;

            decimal totalm = maxrunners * averlaps * length;
            decimal totalkm = totalm / 1000;
            decimal raisedmoney = totalkm * donate;

            Console.WriteLine("Money raised: {0:f2}",raisedmoney);


        }
    }
}
