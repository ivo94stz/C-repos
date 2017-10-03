﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTV_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            uint days =(uint)(years * 365.2422); 
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);
        }
    }
}
