﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array___1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 7) Console.WriteLine("Invalid day!");
            else Console.WriteLine(days[n-1]);
        }
    }
}
