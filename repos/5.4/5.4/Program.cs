﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)


      {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.00;

            for (int i = 0; i < n; i++) 
            {
                var z = double.Parse(Console.ReadLine());
                sum = sum + z;
            }
            Console.WriteLine(sum);
        }
    }
}
