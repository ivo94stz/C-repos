﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            double mile = km * 1.60934;
            Console.WriteLine("{0:f2}",mile);



        }
    }
}
