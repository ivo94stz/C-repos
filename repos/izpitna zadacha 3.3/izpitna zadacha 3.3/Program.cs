﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitna_zadacha_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            var workingDays = 365 - holidays;
            var totalPlayMinutes = (workingDays * 63) + (holidays * 127);

            var difference = totalPlayMinutes - 30000;
            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);

            if (totalPlayMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }



            }
    }
}
