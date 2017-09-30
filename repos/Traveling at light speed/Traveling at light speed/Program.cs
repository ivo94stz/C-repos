using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_at_light_speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fy = decimal.Parse(Console.ReadLine());
            decimal one = 9450000000000;
            decimal speed = 300000;
            decimal mins = speed * 60;
            decimal hours = mins * 60;
            decimal days = hours * 24;
            decimal week = days * 7;
            Console.WriteLine(week);

        }
    }
}
